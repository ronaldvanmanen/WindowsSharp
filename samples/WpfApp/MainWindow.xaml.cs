// DirectXSharp
//
// Copyright (C) 2021 Ronald van Manen <rvanmanen@gmail.com>
//
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private readonly RendererManager _rendererManager;

        private readonly DispatcherTimer _sizeTimer;

        private readonly DispatcherTimer _adapterTimer;

        private TimeSpan _lastRenderingTime;

        public MainWindow()
        {
            InitializeComponent();

            _rendererManager = new RendererManager();
            _rendererManager.SetSize(512, 384);
            _rendererManager.SetAlpha(false);
            _rendererManager.SetNumDesiredSamples(4);

            //
            // Optional: Multi-adapter optimization
            //
            // The surface is created initially on a particular adapter.
            // If the WPF window is dragged to another adapter, WPF
            // ensures that the D3DImage still shows up on the new
            // adapter.
            //
            // This process is slow on Windows XP.
            //
            // Performance is better on Vista with a 9Ex device. It's only
            // slow when the D3DImage crosses a video-card boundary.
            //
            // To work around this issue, you can move your surface when
            // the D3DImage is displayed on another adapter. To
            // determine when that is the case, transform a point on the
            // D3DImage into screen space and find out which adapter
            // contains that screen space point.
            //
            // When your D3DImage straddles two adapters, nothing
            // can be done, because one will be updating slowly.
            //
            _adapterTimer = new DispatcherTimer();
            _adapterTimer.Tick += new EventHandler(AdapterTimerTick);
            _adapterTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            _adapterTimer.Start();

            //
            // Optional: Surface resizing
            //
            // The D3DImage is scaled when WPF renders it at a size
            // different from the natural size of the surface. If the
            // D3DImage is scaled up significantly, image quality
            // degrades.
            //
            // To avoid this, you can either create a very large
            // texture initially, or you can create new surfaces as
            // the size changes. Below is a very simple example of
            // how to do the latter.
            //
            // By creating a timer at Render priority, you are guaranteed
            // that new surfaces are created while the element
            // is still being arranged. A 200 ms interval gives
            // a good balance between image quality and performance.
            // You must be careful not to create new surfaces too
            // frequently. Frequently allocating a new surface may
            // fragment or exhaust video memory. This issue is more
            // significant on XDDM than it is on WDDM, because WDDM
            // can page out video memory.
            //
            // Another approach is deriving from the Image class,
            // participating in layout by overriding the ArrangeOverride method, and
            // updating size in the overriden method. Performance will degrade
            // if you resize too frequently.
            //
            // Blurry D3DImages can still occur due to subpixel
            // alignments.
            //
            _sizeTimer = new DispatcherTimer(DispatcherPriority.Render);
            _sizeTimer.Tick += new EventHandler(SizeTimerTick);
            _sizeTimer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            _sizeTimer.Start();

            //
            // Optional: Subscribing to the IsFrontBufferAvailableChanged event.
            //
            // If you don't render every frame (e.g. you only render in
            // reaction to a button click), you should subscribe to the
            // IsFrontBufferAvailableChanged event to be notified when rendered content
            // is no longer being displayed. This event also notifies you when
            // the D3DImage is capable of being displayed again.

            // For example, in the button click case, if you don't render again when
            // the IsFrontBufferAvailable property is set to true, your
            // D3DImage won't display anything until the next button click.
            //
            // Because this application renders every frame, there is no need to
            // handle the IsFrontBufferAvailableChanged event.
            //
            CompositionTarget.Rendering += new EventHandler(CompositionTargetRendering);
        }

        private void CompositionTargetRendering(object? sender, EventArgs eventArgs)
        {
            var renderingEventArgs = (RenderingEventArgs)eventArgs;

            var renderingTime = renderingEventArgs.RenderingTime;

            // It's possible for Rendering to call back twice in the same frame
            // so only render when we haven't already rendered in this frame.
            if (D3DImage.IsFrontBufferAvailable && _lastRenderingTime != renderingTime)
            {
                unsafe
                {
                    var surface = _rendererManager.GetBackBuffer();
                    if (surface is not null)
                    {
                        // Repeatedly calling SetBackBuffer with the same IntPtr is a no-op. There is no performance penalty.
                        D3DImage.Lock();
                        D3DImage.SetBackBuffer(surface);
                        _rendererManager.Render(renderingTime);
                        D3DImage.AddDirtyRect(new Int32Rect(0, 0, D3DImage.PixelWidth, D3DImage.PixelHeight));
                        D3DImage.Unlock();

                        _lastRenderingTime = renderingTime;
                    }
                }
            }
        }

        private void AdapterTimerTick(object? sender, EventArgs e)
        {
            _rendererManager.SetAdapter(Image.PointToScreen(new Point(0, 0)));
        }

        private void SizeTimerTick(object? sender, EventArgs e)
        {
            // The following code does not account for RenderTransforms.
            // To handle that case, you must transform up to the root and
            // check the size there.

            // Given that the D3DImage is at 96.0 DPI, its Width and Height
            // properties will always be integers. ActualWidth/Height
            // may not be integers, so they are cast to integers.
            var actualWidth = (uint)Image.ActualWidth;
            var actualHeight = (uint)Image.ActualHeight;
            var imageWidth = (uint)D3DImage.Width;
            var imageHeight = (uint)D3DImage.Height;
            if (actualWidth > 0 && actualHeight > 0 && (actualWidth != imageWidth || actualHeight != imageHeight))
            {
                _rendererManager.SetSize(actualWidth, actualHeight);
            }
        }
    }
}

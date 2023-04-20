// This file is part of WindowsSharp
//
// Copyright (C) 2021-2023 Ronald van Manen <rvanmanen@gmail.com>
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

namespace D3D9Sharp.Extensions.Windows.Interop
{
    public sealed class D3D11Image : D3DImage
    {
        public static DependencyProperty OnRenderProperty;

        public static DependencyProperty WindowOwnerProperty;

        // The OnRender action delegate will fire and pass the surface to the
        // application that the DirectX rendering component should render into.
        public Action<IntPtr, bool> OnRender
        {
            get => (Action<IntPtr, bool>)GetValue(OnRenderProperty);
            set => SetValue(OnRenderProperty, value);
        }

        // The window handle (HWND) of the Window which hosts the D3D11Image
        // (used during DirectX surface creation).
        public IntPtr WindowOwner
        {
            get => (IntPtr)GetValue(WindowOwnerProperty);
            set => SetValue(WindowOwnerProperty, value);
        }

        internal SurfaceQueueInteropHelper Helper { get; set; }

        static D3D11Image()
        {
            OnRenderProperty = DependencyProperty.Register(
                nameof(OnRender),
                typeof(Action<IntPtr, bool>),
                typeof(D3D11Image),
                new UIPropertyMetadata(null, new PropertyChangedCallback(RenderChanged)));

            WindowOwnerProperty = DependencyProperty.Register(
                nameof(WindowOwner),
                typeof(IntPtr),
                typeof(D3D11Image),
                new UIPropertyMetadata(IntPtr.Zero, new PropertyChangedCallback(WindowOwnerChanged)));
        }

        public D3D11Image()
        {

        }

        ~D3D11Image()
        {
            if (Helper != null)
            {
                Helper.Dispose();
            }
        }


        // The RequestRender method signals that the D3D11Image should get the
        // DirectX rendering code to render a new frame to the provided surface.
        // Typically the user of the D3D11Image calls this every time the
        // CompositionTarget.Rendering event fires.
        public void RequestRender()
        {
            EnsureHelper();

            // Don't bother with a call if there's no callback registered.
            if (OnRender is not null)
            {
                Helper.RequestRenderD2D();
            }
        }

        // The application hosting the D3D11Image should ensure that the
        // PixelSize is the number of pixels that the D3D11Image is being
        // displayed in.
        public void SetPixelSize(int pixelWidth, int pixelHeight)
        {
            EnsureHelper();
            Helper.SetPixelSize(pixelWidth, pixelHeight);
        }

        protected override Freezable CreateInstanceCore()
        {
            return new D3D11Image();
        }

        private void EnsureHelper()
        {
            Helper ??= new SurfaceQueueInteropHelper
            {
                HWND = WindowOwner,
                D3DImage = this,
                RenderD2D = OnRender
            };
        }

        private static void RenderChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (sender is D3D11Image image)
            {
                if (image.Helper is not null)
                {
                    image.Helper.RenderD2D = (Action<IntPtr, bool>)args.NewValue;
                }
            }
        }

        private static void WindowOwnerChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (sender is D3D11Image image)
            {
                if (image.Helper is not null)
                {
                    image.Helper.HWND = (IntPtr)args.NewValue;
                }
            }
        }
    }
}

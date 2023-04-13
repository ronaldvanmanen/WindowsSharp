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
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using DirectXSharp.Extensions.Windows;
using DirectXSharp.Interop;

namespace DirectXSharp.In.WPF
{
    internal sealed unsafe class RendererManager : IDisposable
    {
        private Direct3D9 _d3d = null!;

        private Direct3D9Ex _d3dEx = null!;

        private int _adapterCount = 0;

        private List<Renderer> _renderers = null!;

        private Renderer _currentRenderer = null!;

        private WindowClass _windowClass = null!;

        private Window _window = null!;

        private uint _width = 0;

        private uint _height = 0;

        private uint _numSamples = 0;

        private bool _useAlpha = false;

        private bool _surfaceSettingsChanged = true;

        public RendererManager() { }

        ~RendererManager()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool _)
        {
            DestroyResources();
        }

        public void SetSize(uint width, uint height)
        {
            if (width != _width || height != _height)
            {
                _width = width;
                _height = height;
                _surfaceSettingsChanged = true;
            }
        }

        public void SetAlpha(bool useAlpha)
        {
            if (useAlpha != _useAlpha)
            {
                _useAlpha = useAlpha;
                _surfaceSettingsChanged = true;
            }
        }

        public void SetNumDesiredSamples(uint numSamples)
        {
            if (_numSamples != numSamples)
            {
                _numSamples = numSamples;
                _surfaceSettingsChanged = true;
            }
        }

        public void SetAdapter(Point screenSpacePoint)
        {
            CleanupInvalidDevices();

            //
            // After CleanupInvalidDevices, we may not have any D3D objects. Rather than
            // recreate them here, ignore the adapter update and wait for render to recreate.
            //

            if (_d3d != null && _renderers != null)
            {
                var monitor = Monitor.FromPoint(screenSpacePoint.ToPOINT());
                for (uint i = 0; i < _adapterCount; ++i)
                {
                    if (monitor == _d3d.GetAdapterMonitor(i))
                    {
                        _currentRenderer = _renderers[(int)i];
                        break;
                    }
                }
            }
        }

        public Direct3DSurface9? GetBackBuffer()
        {
            CleanupInvalidDevices();

            EnsureD3DObjects();

            //
            // Even if we never render to another adapter, this sample creates devices
            // and resources on each one. This is a potential waste of video memory,
            // but it guarantees that we won't have any problems (e.g. out of video
            // memory) when switching to render on another adapter. In your own code
            // you may choose to delay creation but you'll need to handle the issues
            // that come with it.
            //

            EnsureRenderers();

            if (_surfaceSettingsChanged)
            {
                if (!TestSurfaceSettings())
                {
                    throw new InvalidOperationException();
                }

                for (var i = 0; i < _adapterCount; ++i)
                {
                    _renderers[i].CreateSurface(_width, _height, _useAlpha, _numSamples);
                }

                _surfaceSettingsChanged = false;
            }

            if (_currentRenderer != null)
            {
                return _currentRenderer.GetSurface();
            }

            return null;
        }

        public void Render(TimeSpan renderingTime)
        {
            _currentRenderer?.Render(renderingTime);
        }

        private void CleanupInvalidDevices()
        {
            if (_renderers is not null && _renderers.Any(e => e.CheckDeviceState() < 0))
            {
                DestroyResources();
            }
        }

        private void EnsureRenderers()
        {
            if (_renderers == null)
            {
                EnsureWindow();

                _renderers = new List<Renderer>(_adapterCount);

                for (var i = 0; i < _adapterCount; ++i)
                {
                    _renderers.Add(
                        new TriangleRenderer(
                            _d3d, _d3dEx, _window, (uint)i));
                }

                // Default to the default adapter 
                _currentRenderer = _renderers[0];
            }
        }

        private void EnsureWindow()
        {
            if (_windowClass is null)
            {
                _windowClass = new WindowClass("D3DImageSample", NativeMethods.CS_HREDRAW | NativeMethods.CS_VREDRAW);
            }

            if (_window is null)
            {
                _window = _windowClass.CreateWindow("D3DImageSample", NativeMethods.WS_OVERLAPPEDWINDOW);
            }
        }

        private void EnsureD3DObjects()
        {
            try
            {
                _d3dEx = new Direct3D9Ex();
                _d3d = (Direct3D9)_d3dEx;
            }
            catch
            {
                _d3d = new Direct3D9();
            }

            _adapterCount = (int)_d3d.AdapterCount;
        }

        private bool TestSurfaceSettings()
        {
            var format = _useAlpha ? D3DFORMAT.D3DFMT_A8R8G8B8 : D3DFORMAT.D3DFMT_X8R8G8B8;

            // 
            // We test all adapters because because we potentially use all adapters.
            // But even if this sample only rendered to the default adapter, you
            // should check all adapters because WPF may move your surface to
            // another adapter for you!
            //

            for (uint adapter = 0; adapter < _adapterCount; ++adapter)
            {
                // Can we get HW rendering?
                if (!_d3d.CheckDeviceType(
                    adapter,
                    D3DDEVTYPE.D3DDEVTYPE_HAL,
                    D3DFORMAT.D3DFMT_X8R8G8B8,
                    format,
                    true))
                {
                    return false;
                }

                // Is the format okay?
                if (!_d3d.CheckDeviceFormat(
                    adapter,
                    D3DDEVTYPE.D3DDEVTYPE_HAL,
                    D3DFORMAT.D3DFMT_X8R8G8B8,
                    NativeMethods.D3DUSAGE_RENDERTARGET | NativeMethods.D3DUSAGE_DYNAMIC, // We'll use dynamic when on XP
                    D3DRESOURCETYPE.D3DRTYPE_SURFACE,
                    format))
                {
                    return false;
                }

                // D3DImage only allows multisampling on 9Ex devices. If we can't 
                // multisample, overwrite the desired number of samples with 0.
                if (_d3dEx != null && _numSamples > 1)
                {
                    Debug.Assert(_numSamples <= 16);

                    if (!_d3d.CheckDeviceMultiSampleType(
                        adapter,
                        D3DDEVTYPE.D3DDEVTYPE_HAL,
                        format,
                        true,
                        (D3DMULTISAMPLE_TYPE)_numSamples,
                        out _))
                    {
                        _numSamples = 0;
                    }
                }
                else
                {
                    _numSamples = 0;
                }
            }

            return true;
        }

        private void DestroyResources()
        {
            _window?.Dispose();
            _window = null!;
            _windowClass?.Dispose();
            _windowClass = null!;

            _d3d?.Dispose();
            _d3d = null!;
            _d3dEx?.Dispose();
            _d3dEx = null!;

            for (var i = 0; i < _renderers.Count; ++i)
            {
                _renderers[i].Dispose();
            }

            _renderers.Clear();
            _renderers = null!;
            _currentRenderer = null!;
            _adapterCount = 0;

            _surfaceSettingsChanged = true;
        }
    };
}

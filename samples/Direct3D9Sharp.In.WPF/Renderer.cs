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
using WindowsSharp;
using WindowsSharp.Interop;

namespace Direct3D9Sharp.In.WPF
{
    internal abstract unsafe class Renderer : IDisposable
    {
        protected readonly Direct3DDevice9 _device = null!;

        protected readonly Direct3DDevice9Ex _deviceEx = null!;

        protected Direct3DSurface9 _surface = null!;

        public Renderer(Direct3D9 d3d, Direct3D9Ex d3dEx, Window window, uint adapter)
        {
            var d3dpp = new D3DPRESENT_PARAMETERS
            {
                Windowed = 1,
                BackBufferFormat = D3DFORMAT.D3DFMT_UNKNOWN,
                BackBufferHeight = 1,
                BackBufferWidth = 1,
                SwapEffect = D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD
            };

            var caps = d3d.GetDeviceCaps(adapter, D3DDEVTYPE.D3DDEVTYPE_HAL);
            int dwVertexProcessing;
            if ((caps.DevCaps & NativeMethods.D3DDEVCAPS_HWTRANSFORMANDLIGHT) == NativeMethods.D3DDEVCAPS_HWTRANSFORMANDLIGHT)
            {
                dwVertexProcessing = NativeMethods.D3DCREATE_HARDWARE_VERTEXPROCESSING;
            }
            else
            {
                dwVertexProcessing = NativeMethods.D3DCREATE_SOFTWARE_VERTEXPROCESSING;
            }

            if (d3dEx != null)
            {
                _deviceEx = d3dEx.CreateDeviceEx(
                    adapter,
                    D3DDEVTYPE.D3DDEVTYPE_HAL,
                    window,
                    (uint)(dwVertexProcessing | NativeMethods.D3DCREATE_MULTITHREADED | NativeMethods.D3DCREATE_FPU_PRESERVE),
                    &d3dpp);

                _device = _deviceEx;
            }
            else
            {
                _device = d3d.CreateDevice(
                    adapter,
                    D3DDEVTYPE.D3DDEVTYPE_HAL,
                    window,
                    (uint)(dwVertexProcessing | NativeMethods.D3DCREATE_MULTITHREADED | NativeMethods.D3DCREATE_FPU_PRESERVE),
                    &d3dpp);
            }
        }

        ~Renderer()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
        }

        public int CheckDeviceState()
        {
            if (_deviceEx != null)
            {
                return _deviceEx.CheckDeviceState();
            }
            else if (_device != null)
            {
                return _device.TestCooperativeLevel();
            }
            else
            {
                return NativeMethods.D3DERR_DEVICELOST;
            }
        }

        public void CreateSurface(uint width, uint height, bool useAlpha, uint numSamples)
        {
            if (_surface != null)
            {
                _surface.Dispose();
            }

            _surface = _device.CreateRenderTarget(
                width,
                height,
                useAlpha ? D3DFORMAT.D3DFMT_A8R8G8B8 : D3DFORMAT.D3DFMT_X8R8G8B8,
                (D3DMULTISAMPLE_TYPE)numSamples,
                0,
                _deviceEx == null);  // Lockable RT required for good XP perf

            _device.SetRenderTarget(0, _surface);
        }

        public Direct3DSurface9 GetSurface()
        {
            return _surface;
        }

        public abstract void Render(TimeSpan renderingTime);
    };
}

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
using DirectXSharp;
using DirectXSharp.Interop;

namespace WpfApp
{
    internal abstract unsafe class Renderer : IDisposable
    {
        protected readonly Direct3DDevice9 m_pd3dDevice = null!;

        protected readonly Direct3DDevice9Ex m_pd3dDeviceEx = null!;

        protected Direct3DSurface9 m_pd3dRTS = null!;

        public Renderer(Direct3D9 pD3D, Direct3D9Ex pD3DEx, HWND__* hwnd, uint uAdapter)
        {
            var d3dpp = new D3DPRESENT_PARAMETERS
            {
                Windowed = 1,
                BackBufferFormat = D3DFORMAT.D3DFMT_UNKNOWN,
                BackBufferHeight = 1,
                BackBufferWidth = 1,
                SwapEffect = D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD
            };

            var caps = pD3D.GetDeviceCaps(uAdapter, D3DDEVTYPE.D3DDEVTYPE_HAL);
            int dwVertexProcessing;
            if ((caps.DevCaps & NativeMethods.D3DDEVCAPS_HWTRANSFORMANDLIGHT) == NativeMethods.D3DDEVCAPS_HWTRANSFORMANDLIGHT)
            {
                dwVertexProcessing = NativeMethods.D3DCREATE_HARDWARE_VERTEXPROCESSING;
            }
            else
            {
                dwVertexProcessing = NativeMethods.D3DCREATE_SOFTWARE_VERTEXPROCESSING;
            }

            if (pD3DEx != null)
            {
                m_pd3dDeviceEx = pD3DEx.CreateDeviceEx(
                    uAdapter,
                    D3DDEVTYPE.D3DDEVTYPE_HAL,
                    hwnd,
                    (uint)(dwVertexProcessing | NativeMethods.D3DCREATE_MULTITHREADED | NativeMethods.D3DCREATE_FPU_PRESERVE),
                    &d3dpp);

                m_pd3dDevice = m_pd3dDeviceEx;
            }
            else
            {
                m_pd3dDevice = pD3D.CreateDevice(
                    uAdapter,
                    D3DDEVTYPE.D3DDEVTYPE_HAL,
                    hwnd,
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
            if (m_pd3dDeviceEx != null)
            {
                return m_pd3dDeviceEx.CheckDeviceState();
            }
            else if (m_pd3dDevice != null)
            {
                return m_pd3dDevice.TestCooperativeLevel();
            }
            else
            {
                return NativeMethods.D3DERR_DEVICELOST;
            }
        }

        public void CreateSurface(uint uWidth, uint uHeight, bool fUseAlpha, uint m_uNumSamples)
        {
            if (m_pd3dRTS != null)
            {
                m_pd3dRTS.Dispose();
            }

            m_pd3dRTS = m_pd3dDevice.CreateRenderTarget(
                uWidth,
                uHeight,
                fUseAlpha ? D3DFORMAT.D3DFMT_A8R8G8B8 : D3DFORMAT.D3DFMT_X8R8G8B8,
                (D3DMULTISAMPLE_TYPE)m_uNumSamples,
                0,
                m_pd3dDeviceEx == null);  // Lockable RT required for good XP perf

            m_pd3dDevice.SetRenderTarget(0, m_pd3dRTS);
        }

        public Direct3DSurface9 GetSurfaceNoRef()
        {
            return m_pd3dRTS;
        }

        public abstract void Render(TimeSpan renderingTime);
    };
}

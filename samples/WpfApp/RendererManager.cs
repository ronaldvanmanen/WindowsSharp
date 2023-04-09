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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using DirectXSharp;
using DirectXSharp.Internals;
using DirectXSharp.Interop;

namespace WpfApp
{
    internal sealed unsafe class RendererManager : IDisposable
    {
        private Direct3D9 m_pD3D = null!;

        private Direct3D9Ex m_pD3DEx = null!;

        private int m_cAdapters = 0;

        private List<Renderer> m_rgRenderers = null!;

        private Renderer m_pCurrentRenderer = null!;

        private HWND__* m_hwnd = null;

        private uint m_uWidth = 0;

        private uint m_uHeight = 0;

        private uint m_uNumSamples = 0;

        private bool m_fUseAlpha = false;

        private bool m_fSurfaceSettingsChanged = true;

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

        private void Dispose(bool disposing)
        {

        }

        public void SetSize(uint uWidth, uint uHeight)
        {
            if (uWidth != m_uWidth || uHeight != m_uHeight)
            {
                m_uWidth = uWidth;
                m_uHeight = uHeight;
                m_fSurfaceSettingsChanged = true;
            }
        }

        public void SetAlpha(bool fUseAlpha)
        {
            if (fUseAlpha != m_fUseAlpha)
            {
                m_fUseAlpha = fUseAlpha;
                m_fSurfaceSettingsChanged = true;
            }
        }

        public void SetNumDesiredSamples(uint uNumSamples)
        {
            if (m_uNumSamples != uNumSamples)
            {
                m_uNumSamples = uNumSamples;
                m_fSurfaceSettingsChanged = true;
            }
        }

        public void SetAdapter(Point screenSpacePoint)
        {
            CleanupInvalidDevices();

            //
            // After CleanupInvalidDevices, we may not have any D3D objects. Rather than
            // recreate them here, ignore the adapter update and wait for render to recreate.
            //

            if (m_pD3D != null && m_rgRenderers != null)
            {
                var monitor = Monitor.FromPoint(screenSpacePoint.ToPOINT());
                for (uint i = 0; i < m_cAdapters; ++i)
                {
                    if (monitor == m_pD3D.GetAdapterMonitor(i))
                    {
                        m_pCurrentRenderer = m_rgRenderers[(int)i];
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

            if (m_fSurfaceSettingsChanged)
            {
                if (!TestSurfaceSettings())
                {
                    throw new InvalidOperationException();
                }

                for (var i = 0; i < m_cAdapters; ++i)
                {
                    m_rgRenderers[i].CreateSurface(m_uWidth, m_uHeight, m_fUseAlpha, m_uNumSamples);
                }

                m_fSurfaceSettingsChanged = false;
            }

            if (m_pCurrentRenderer != null)
            {
                return m_pCurrentRenderer.GetSurfaceNoRef();
            }

            return null;
        }

        public void Render(TimeSpan renderingTime)
        {
            m_pCurrentRenderer?.Render(renderingTime);
        }

        private void CleanupInvalidDevices()
        {
            if (m_rgRenderers is not null && m_rgRenderers.Any(e => e.CheckDeviceState() < 0))
            {
                DestroyResources();
            }
        }

        private void EnsureRenderers()
        {
            if (m_rgRenderers == null)
            {
                EnsureHWND();

                m_rgRenderers = new List<Renderer>(m_cAdapters);

                for (var i = 0; i < m_cAdapters; ++i)
                {
                    m_rgRenderers.Add(
                        new TriangleRenderer(
                            m_pD3D, m_pD3DEx, m_hwnd, (uint)i));
                }

                // Default to the default adapter 
                m_pCurrentRenderer = m_rgRenderers[0];
            }
        }

        private void EnsureHWND()
        {
            if (m_hwnd == null)
            {
                var lpszClassName = new MarshaledString("D3DImageSample");
                var wndclass = new WNDCLASSW
                {
                    style = NativeMethods.CS_HREDRAW | NativeMethods.CS_VREDRAW,
                    lpfnWndProc = &WindowProc,
                    cbClsExtra = 0,
                    cbWndExtra = 0,
                    hInstance = null,
                    hIcon = null,
                    hCursor = null,
                    hbrBackground = null,
                    lpszMenuName = null,
                    lpszClassName = lpszClassName
                };

                if (0 == NativeMethods.RegisterClass(&wndclass))
                {
                    var error = Marshal.GetLastPInvokeError();
                    var exception = new Win32Exception(error);
                    throw exception;
                }

                var lpszWindowName = new MarshaledString("D3DImageSample");
                var hwnd = NativeMethods.CreateWindowW(
                    lpszClassName,
                    lpszWindowName,
                    NativeMethods.WS_OVERLAPPEDWINDOW,
                    0,    // Initial X
                    0,    // Initial Y
                    0,    // Width
                    0,    // Height
                    null,
                    null,
                    null,
                    null);

                m_hwnd = hwnd;
            }
        }

        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        private static long WindowProc(HWND__* hwnd, uint msg, ulong wparam, long lparam)
        {
            return NativeMethods.DefWindowProcW(hwnd, msg, wparam, lparam);
        }

        private void EnsureD3DObjects()
        {
            try
            {
                m_pD3DEx = new Direct3D9Ex();
                m_pD3D = (Direct3D9)m_pD3DEx;
            }
            catch
            {
                m_pD3D = new Direct3D9();
            }

            m_cAdapters = (int)m_pD3D.AdapterCount;
        }

        private bool TestSurfaceSettings()
        {
            D3DFORMAT fmt = m_fUseAlpha ? D3DFORMAT.D3DFMT_A8R8G8B8 : D3DFORMAT.D3DFMT_X8R8G8B8;

            // 
            // We test all adapters because because we potentially use all adapters.
            // But even if this sample only rendered to the default adapter, you
            // should check all adapters because WPF may move your surface to
            // another adapter for you!
            //

            for (uint i = 0; i < m_cAdapters; ++i)
            {
                // Can we get HW rendering?
                if (m_pD3D.CheckDeviceType(
                    i,
                    D3DDEVTYPE.D3DDEVTYPE_HAL,
                    D3DFORMAT.D3DFMT_X8R8G8B8,
                    fmt,
                    true) < 0)
                {
                    return false;
                }

                // Is the format okay?
                if (m_pD3D.CheckDeviceFormat(
                    i,
                    D3DDEVTYPE.D3DDEVTYPE_HAL,
                    D3DFORMAT.D3DFMT_X8R8G8B8,
                    NativeMethods.D3DUSAGE_RENDERTARGET | NativeMethods.D3DUSAGE_DYNAMIC, // We'll use dynamic when on XP
                    D3DRESOURCETYPE.D3DRTYPE_SURFACE,
                    fmt) < 0)
                {
                    return false;
                }

                // D3DImage only allows multisampling on 9Ex devices. If we can't 
                // multisample, overwrite the desired number of samples with 0.
                if (m_pD3DEx != null && m_uNumSamples > 1)
                {
                    Debug.Assert(m_uNumSamples <= 16);

                    if (m_pD3D.CheckDeviceMultiSampleType(
                        i,
                        D3DDEVTYPE.D3DDEVTYPE_HAL,
                        fmt,
                        true,
                        (D3DMULTISAMPLE_TYPE)m_uNumSamples) < 0)
                    {
                        m_uNumSamples = 0;
                    }
                }
                else
                {
                    m_uNumSamples = 0;
                }
            }

            return true;
        }

        private void DestroyResources()
        {
            if (m_pD3D != null)
            {
                m_pD3D.Dispose();
                m_pD3D = null!;
            }

            if (m_pD3DEx != null)
            {
                m_pD3DEx.Dispose();
                m_pD3DEx = null!;
            }

            for (var i = 0; i < m_rgRenderers.Count; ++i)
            {
                m_rgRenderers[i].Dispose();
            }

            m_rgRenderers.Clear();
            m_rgRenderers = null!;
            m_pCurrentRenderer = null!;
            m_cAdapters = 0;

            m_fSurfaceSettingsChanged = true;
        }
    };
}

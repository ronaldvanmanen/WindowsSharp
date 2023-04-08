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
using DirectXSharp.Interop;

namespace DirectXSharp
{
    public sealed unsafe class Direct3D9 : IDisposable
    {
        private IDirect3D9* _handle;

        public uint AdapterCount => _handle->GetAdapterCount();

        public Direct3D9()
        : this(NativeMethods.D3D_SDK_VERSION)
        { }

        public Direct3D9(uint sdkVersion)
        : this(NativeMethods.Direct3DCreate9(sdkVersion))
        { }

        internal Direct3D9(IDirect3D9* handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;
        }

        ~Direct3D9()
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
            if (_handle != null)
            {
                _handle->Release();
                _handle = null;
            }
        }

        public Monitor GetAdapterMonitor(uint i)
        {
            return Monitor.FromHandle(_handle->GetAdapterMonitor(i));
        }

        public int CheckDeviceType(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMAT backBufferFormat, bool windowed)
        {
            return _handle->CheckDeviceType(
                adapter,
                deviceType,
                adapterFormat,
                backBufferFormat,
                windowed ? NativeMethods.TRUE : NativeMethods.FALSE);
        }

        public int CheckDeviceFormat(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, uint usage, D3DRESOURCETYPE resourceType, D3DFORMAT checkFormat)
        {
            return _handle->CheckDeviceFormat(
                adapter,
                deviceType,
                adapterFormat,
                usage,
                resourceType,
                checkFormat);
        }

        public int CheckDeviceMultiSampleType(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT surfaceFormat, bool windowed, D3DMULTISAMPLE_TYPE multiSampleType)
        {
            return _handle->CheckDeviceMultiSampleType(
                adapter,
                deviceType,
                surfaceFormat,
                windowed ? NativeMethods.TRUE : NativeMethods.FALSE,
                multiSampleType,
                null);
        }

        public D3DCAPS9 GetDeviceCaps(uint adapter, D3DDEVTYPE deviceType)
        {
            var caps = new D3DCAPS9();
            Direct3D9Error.ThrowOnFailure(
                _handle->GetDeviceCaps(adapter, D3DDEVTYPE.D3DDEVTYPE_HAL, &caps)
            );
            return caps;
        }

        public Direct3DDevice9 CreateDevice(uint adapter, D3DDEVTYPE deviceType, HWND__* focusWindow, uint behaviorFlags, D3DPRESENT_PARAMETERS* presentationParameters)
        {
            IDirect3DDevice9* handle = null;

            Direct3D9Error.ThrowOnFailure(
                _handle->CreateDevice(
                    adapter,
                    deviceType,
                    focusWindow,
                    behaviorFlags,
                    presentationParameters,
                    &handle)
            );

            return new Direct3DDevice9(handle);
        }
    }
}

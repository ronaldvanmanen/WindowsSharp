// WindowsSharp
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
using System.Diagnostics.CodeAnalysis;
using WindowsSharp.Interop;
using static WindowsSharp.Direct3D9Error;

namespace WindowsSharp
{
    public sealed unsafe class Direct3D9 : IDisposable
    {
        private IDirect3D9* _handle;

        public IDirect3D9* Handle
        {
            get
            {
                ThrowIfDisposed();

                return _handle;
            }
        }

        public uint AdapterCount
        {
            get
            {
                ThrowIfDisposed();

                return _handle->GetAdapterCount();
            }
        }

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
            ThrowIfDisposed();

            return Monitor.FromHandle(_handle->GetAdapterMonitor(i));
        }

        public bool CheckDeviceType(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMAT backBufferFormat, bool windowed)
        {
            return CheckDeviceType(adapter, deviceType, adapterFormat, backBufferFormat, windowed, out _);
        }

        public bool CheckDeviceType(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, D3DFORMAT backBufferFormat, bool windowed, [NotNullWhen(false)] out Direct3D9Error? error)
        {
            ThrowIfDisposed();

            var result = _handle->CheckDeviceType(
                adapter,
                deviceType,
                adapterFormat,
                backBufferFormat,
                windowed.ToBOOL());
            var succeeded = Succeeded(result, out error);
            return succeeded;
        }

        public bool CheckDeviceFormat(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, uint usage, D3DRESOURCETYPE resourceType, D3DFORMAT checkFormat)
        {
            return CheckDeviceFormat(adapter, deviceType, adapterFormat, usage, resourceType, checkFormat, out _);
        }

        public bool CheckDeviceFormat(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT adapterFormat, uint usage, D3DRESOURCETYPE resourceType, D3DFORMAT checkFormat, [NotNullWhen(false)] out Direct3D9Error? error)
        {
            ThrowIfDisposed();

            var result = _handle->CheckDeviceFormat(
                adapter,
                deviceType,
                adapterFormat,
                usage,
                resourceType,
                checkFormat);
            var succeeded = Succeeded(result, out error);
            return succeeded;
        }

        public bool CheckDeviceMultiSampleType(uint adapter, D3DDEVTYPE deviceType, D3DFORMAT surfaceFormat, bool windowed, D3DMULTISAMPLE_TYPE multiSampleType, [NotNullWhen(false)] out Direct3D9Error? error)
        {
            ThrowIfDisposed();

            var result = _handle->CheckDeviceMultiSampleType(
                adapter,
                deviceType,
                surfaceFormat,
                windowed.ToBOOL(),
                multiSampleType,
                null);
            var succeeded = Succeeded(result, out error);
            return succeeded;
        }

        public D3DCAPS9 GetDeviceCaps(uint adapter, D3DDEVTYPE deviceType)
        {
            ThrowIfDisposed();

            var caps = new D3DCAPS9();
            ThrowOnFailure(
                _handle->GetDeviceCaps(adapter, D3DDEVTYPE.D3DDEVTYPE_HAL, &caps)
            );
            return caps;
        }

        public Direct3DDevice9 CreateDevice(uint adapter, D3DDEVTYPE deviceType, Window focusWindow, uint behaviorFlags, D3DPRESENT_PARAMETERS* presentationParameters)
        {
            ThrowIfDisposed();

            IDirect3DDevice9* handle = null;

            ThrowOnFailure(
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

        private void ThrowIfDisposed()
        {
            if (_handle == null)
            {
                var type = GetType();
                var exception = new ObjectDisposedException(type.FullName);
                throw exception;
            }
        }

        public static implicit operator IDirect3D9*(Direct3D9 instance)
        {
            if (instance is null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            return instance.Handle;
        }
    }
}

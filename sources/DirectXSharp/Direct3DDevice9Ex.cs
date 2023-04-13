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
    public sealed unsafe class Direct3DDevice9Ex : IDisposable
    {
        private IDirect3DDevice9Ex* _handle;

        public IDirect3DDevice9Ex* Handle
        {
            get
            {
                ThrowIfDisposed();

                return _handle;
            }
        }

        public Direct3DDevice9Ex(IDirect3DDevice9Ex* handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;
        }

        ~Direct3DDevice9Ex()
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

        public int CheckDeviceState()
        {
            ThrowIfDisposed();

            return _handle->CheckDeviceState(null);
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

        public static implicit operator Direct3DDevice9(Direct3DDevice9Ex instance)
        {
            if (instance is null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            fixed (Guid* riid = &NativeMethods.IID_IDirect3DDevice9)
            {
                IDirect3DDevice9* handle = null;
                instance.Handle->QueryInterface(riid, (void**)&handle);
                return new Direct3DDevice9(handle);
            }
        }
    }
}

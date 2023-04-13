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
using System.Runtime.InteropServices;
using DirectXSharp.Interop;
using static DirectXSharp.Direct3D9Error;

namespace DirectXSharp
{
    public sealed unsafe class Direct3DVertexBuffer9<TVertex> : IDisposable
    {
        private IDirect3DVertexBuffer9* _handle;

        public IDirect3DVertexBuffer9* Handle
        {
            get
            {
                ThrowIfDisposed();

                return _handle;
            }
        }

        public D3DVERTEXBUFFER_DESC Desc
        {
            get
            {
                ThrowIfDisposed();

                var desc = new D3DVERTEXBUFFER_DESC();
                _handle->GetDesc(&desc);
                return desc;
            }
        }

        public Direct3DVertexBuffer9(IDirect3DVertexBuffer9* handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;
        }

        ~Direct3DVertexBuffer9()
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

        public Span<TVertex> Lock(uint offset, uint size, uint flags)
        {
            ThrowIfDisposed();

            var byteSize = (uint)Marshal.SizeOf<TVertex>();
            var offsetToLock = offset * byteSize;
            var sizeToLock = size * byteSize;

            void* data;
            ThrowOnFailure(
                _handle->Lock(offsetToLock, sizeToLock, &data, flags)
            );
            return new Span<TVertex>(data, (int)size);
        }

        public void Unlock()
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->Unlock()
            );
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

        public static implicit operator IDirect3DVertexBuffer9*(Direct3DVertexBuffer9<TVertex> instance)
        {
            if (instance is null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            return instance.Handle;
        }
    }
}

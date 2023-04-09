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
using static DirectXSharp.Direct3D9Error;

namespace DirectXSharp
{
    public sealed unsafe class Direct3DVertexBuffer9 : IDisposable
    {
        private IDirect3DVertexBuffer9* _handle;

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

        public void Lock(uint offsetToLock, uint sizeToLock, void** data, uint flags)
        {
            ThrowOnFailure(
                _handle->Lock(offsetToLock, sizeToLock, data, flags)
            );
        }

        public void Unlock()
        {
            ThrowOnFailure(
                _handle->Unlock()
            );
        }

        public static implicit operator IDirect3DVertexBuffer9*(Direct3DVertexBuffer9 instance)
        {
            return instance._handle;
        }
    }
}

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
using WindowsSharp.Interop;

namespace D3D11Sharp
{
    public sealed unsafe class D3D11ClassLinkage : IDisposable
    {
        private ID3D11ClassLinkage* _handle;

        public ID3D11ClassLinkage* Handle
        {
            get
            {
                ThrowIfDisposed();

                return _handle;
            }
        }

        public D3D11ClassLinkage(ID3D11ClassLinkage* handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;
        }

        ~D3D11ClassLinkage()
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

        private void ThrowIfDisposed()
        {
            if (_handle == null)
            {
                var type = GetType();
                var exception = new ObjectDisposedException(type.FullName);
                throw exception;
            }
        }

        public static implicit operator ID3D11ClassLinkage*(D3D11ClassLinkage? instance)
        {
            if (instance is null)
            {
                return null;
            }

            return instance.Handle;
        }
    }
}

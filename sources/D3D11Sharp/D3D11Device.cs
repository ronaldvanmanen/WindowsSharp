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
    using static D3D11Sharp.D3D11Error;

    public sealed unsafe class D3D11Device : IDisposable
    {
        private ID3D11Device* _handle;

        public ID3D11Device* Handle
        {
            get
            {
                ThrowIfDisposed();

                return _handle;
            }
        }

        public D3D11Device(ID3D11Device* handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;
        }

        ~D3D11Device()
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

        public D3D11PixelShader CreatePixelShader(Span<byte> shaderByteCode)
        {
            return CreatePixelShader(shaderByteCode, null);
        }

        public D3D11PixelShader CreatePixelShader(Span<byte> shaderByteCode, D3D11ClassLinkage? classLinkage)
        {
            ID3D11PixelShader* pPixelShader = null;

            fixed (void* pShaderByteCode = shaderByteCode)
            {
                D3D11Error.ThrowOnFailure(
                    _handle->CreatePixelShader(pShaderByteCode, (ulong)shaderByteCode.Length, classLinkage, &pPixelShader)
                );
            }

            return new D3D11PixelShader(pPixelShader);
        }

        public D3D11VertexShader CreateVertexShader(Span<byte> shaderByteCode)
        {
            return CreateVertexShader(shaderByteCode, null);
        }

        public D3D11VertexShader CreateVertexShader(Span<byte> shaderByteCode, D3D11ClassLinkage? classLinkage)
        {
            ID3D11VertexShader* pVertexShader = null;

            fixed (void* pShaderByteCode = shaderByteCode)
            {
                D3D11Error.ThrowOnFailure(
                    _handle->CreateVertexShader(pShaderByteCode, (ulong)shaderByteCode.Length, classLinkage, &pVertexShader)
                );
            }

            return new D3D11VertexShader(pVertexShader);
        }

        public D3D11InputLayout CreateInputLayout(D3D11_INPUT_ELEMENT_DESC[] layout, Span<byte> shaderByteCode)
        {
            ID3D11InputLayout* pInputLayout = null;

            fixed (D3D11_INPUT_ELEMENT_DESC* pLayout = layout)
            {
                fixed (void* pShaderByteCode = shaderByteCode)
                {
                    ThrowOnFailure(
                        _handle->CreateInputLayout(pLayout,
                            (uint)layout.Length,
                            pShaderByteCode,
                            (ulong)shaderByteCode.Length,
                            &pInputLayout)
                    );
                }
            }

            return new D3D11InputLayout(pInputLayout);
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

        public static implicit operator ID3D11Device*(D3D11Device instance)
        {
            if (instance is null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            return instance.Handle;
        }
    }
}

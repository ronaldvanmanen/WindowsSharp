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
using System.Reflection;
using System.Runtime.InteropServices;
using WindowsSharp.Interop;
using static WindowsSharp.Direct3D9Error;

namespace WindowsSharp
{
    public sealed unsafe class Direct3DDevice9 : IDisposable
    {
        private IDirect3DDevice9* _handle;

        public IDirect3DDevice9* Handle
        {
            get
            {
                ThrowIfDisposed();

                return _handle;
            }
        }

        public Direct3DDevice9(IDirect3DDevice9* handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;
        }

        ~Direct3DDevice9()
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

        public int TestCooperativeLevel()
        {
            ThrowIfDisposed();

            return _handle->TestCooperativeLevel();
        }

        public Direct3DSurface9 CreateRenderTarget(uint width, uint height, D3DFORMAT format, D3DMULTISAMPLE_TYPE multiSample, uint multiSampleQuality, bool lockable)
        {
            ThrowIfDisposed();

            IDirect3DSurface9* handle = null;

            ThrowOnFailure(
                _handle->CreateRenderTarget(
                    width,
                    height,
                    format,
                    multiSample,
                    multiSampleQuality,
                    lockable.ToBOOL(),
                    &handle, null)
            );

            return new Direct3DSurface9(handle);
        }

        public void SetRenderTarget(uint renderTargetIndex, Direct3DSurface9 renderTarget)
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->SetRenderTarget(renderTargetIndex, renderTarget)
            );
        }

        public Direct3DVertexBuffer9<TVertex> CreateVertexBuffer<TVertex>(uint length, uint usage, D3DPOOL pool)
        {
            ThrowIfDisposed();

            IDirect3DVertexBuffer9* handle = null;

            var fvf = GetFlexibleVertexFormat<TVertex>();
            var byteLength = (uint)(length * Marshal.SizeOf<TVertex>());

            ThrowOnFailure(
                _handle->CreateVertexBuffer(
                    byteLength,
                    usage,
                    fvf,
                    pool,
                    &handle,
                    null)
            );

            return new Direct3DVertexBuffer9<TVertex>(handle);
        }

        public void SetFVF(uint fvf)
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->SetFVF(fvf)
            );
        }

        public void SetRenderState(D3DRENDERSTATETYPE state, uint value)
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->SetRenderState(state, value)
            );
        }

        public void SetStreamSource<TVertex>(uint streamNumber, Direct3DVertexBuffer9<TVertex> streamData, uint offset)
        {
            ThrowIfDisposed();

            var stride = (uint)Marshal.SizeOf<TVertex>();

            ThrowOnFailure(
                _handle->SetStreamSource(streamNumber, streamData, offset, stride)
            );
        }

        public void SetTransform(D3DTRANSFORMSTATETYPE state, D3DMATRIX* matrix)
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->SetTransform(state, matrix)
            );
        }

        public void BeginScene()
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->BeginScene()
            );
        }

        public void EndScene()
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->EndScene()
            );
        }

        public void Clear(uint flags, uint color, float z, uint stencil)
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->Clear(0, null, flags, color, z, stencil)
            );
        }

        public void DrawPrimitive(D3DPRIMITIVETYPE primitiveType, uint startVertex, uint primitiveCount)
        {
            ThrowIfDisposed();

            ThrowOnFailure(
                _handle->DrawPrimitive(primitiveType, startVertex, primitiveCount)
            );
        }

        private static uint GetFlexibleVertexFormat<TVertex>()
        {
            var type = typeof(TVertex);
            var attribute = type.GetCustomAttribute<FlexibleVertexFormatAttribute>();
            if (attribute is null)
            {
                throw new ArgumentException();
            }

            return attribute.Format;
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

        public static implicit operator IDirect3DDevice9*(Direct3DDevice9 instance)
        {
            if (instance is null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            return instance.Handle;
        }
    }
}

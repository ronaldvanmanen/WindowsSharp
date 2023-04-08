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
    public sealed unsafe class Direct3DDevice9 : IDisposable
    {
        private IDirect3DDevice9* _handle;

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
            return _handle->TestCooperativeLevel();
        }

        public Direct3DSurface9 CreateRenderTarget(uint width, uint height, D3DFORMAT format, D3DMULTISAMPLE_TYPE multiSample, uint multiSampleQuality, bool lockable)
        {
            IDirect3DSurface9* handle = null;

            Direct3D9Error.ThrowOnFailure(
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
            Direct3D9Error.ThrowOnFailure(
                _handle->SetRenderTarget(renderTargetIndex, renderTarget)
            );
        }

        public Direct3DVertexBuffer9 CreateVertexBuffer(uint length, uint usage, uint fvf, D3DPOOL pool)
        {
            IDirect3DVertexBuffer9* handle = null;

            Direct3D9Error.ThrowOnFailure(
                _handle->CreateVertexBuffer(
                    length,
                    usage,
                    fvf,
                    pool,
                    &handle,
                    null)
            );

            return new Direct3DVertexBuffer9(handle);
        }

        public void SetFVF(uint fvf)
        {
            Direct3D9Error.ThrowOnFailure(
                _handle->SetFVF(fvf)
            );
        }

        public void SetRenderState(D3DRENDERSTATETYPE state, uint value)
        {
            Direct3D9Error.ThrowOnFailure(
                _handle->SetRenderState(state, value)
            );
        }

        public void SetStreamSource(uint streamNumber, Direct3DVertexBuffer9 streamData, uint offsetInBytes, uint stride)
        {
            Direct3D9Error.ThrowOnFailure(
                _handle->SetStreamSource(streamNumber, streamData, offsetInBytes, stride)
            );
        }

        public void SetTransform(D3DTRANSFORMSTATETYPE state, D3DMATRIX* matrix)
        {
            Direct3D9Error.ThrowOnFailure(
                _handle->SetTransform(state, matrix)
            );
        }

        public void BeginScene()
        {
            Direct3D9Error.ThrowOnFailure(
                _handle->BeginScene()
            );
        }

        public void EndScene()
        {
            Direct3D9Error.ThrowOnFailure(
                _handle->EndScene()
            );
        }

        public void Clear(uint flags, uint color, float z, uint stencil)
        {
            Direct3D9Error.ThrowOnFailure(
                _handle->Clear(0, null, flags, color, z, stencil)
            );
        }

        public void DrawPrimitive(D3DPRIMITIVETYPE primitiveType, uint startVertex, uint primitiveCount)
        {
            Direct3D9Error.ThrowOnFailure(
                _handle->DrawPrimitive(primitiveType, startVertex, primitiveCount)
            );
        }
    }
}

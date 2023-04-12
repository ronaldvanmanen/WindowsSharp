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
using System.Numerics;
using DirectXSharp.Extensions.Numerics;
using DirectXSharp.Interop;

namespace DirectXSharp.In.WPF
{
    internal sealed unsafe class TriangleRenderer : Renderer
    {
        private Direct3DVertexBuffer9<CustomVertex> _vertexBuffer;

        public TriangleRenderer(Direct3D9 d3d, Direct3D9Ex d3dEx, HWND__* hwnd, uint adapter)
        : base(d3d, d3dEx, hwnd, adapter)
        {
            var eyePoint = new Vector3(0.0f, 0.0f, -5.0f);
            var lookatPoint = new Vector3(0.0f, 0.0f, 0.0f);
            var upVector = new Vector3(0.0f, 1.0f, 0.0f);

            // Set up the vertex buffer
            const uint vertexBufferSize = 3;

            _vertexBuffer = _device.CreateVertexBuffer<CustomVertex>(
                vertexBufferSize,
                0,
                D3DPOOL.D3DPOOL_DEFAULT);

            var destVertices = _vertexBuffer.Lock(0, vertexBufferSize, 0);
            destVertices[0] = new CustomVertex { X = -1.0f, Y = -1.0f, Z = 0.0f, Color = 0xffff0000 };
            destVertices[1] = new CustomVertex { X = 1.0f, Y = -1.0f, Z = 0.0f, Color = 0xff00ff00 };
            destVertices[2] = new CustomVertex { X = 0.0f, Y = 1.0f, Z = 0.0f, Color = 0xff00ffff };
            _vertexBuffer.Unlock();

            // Set up the camera
            var matView = Matrix4x4.CreateLookAt(eyePoint, lookatPoint, upVector).ToD3DMATRIX();
            _device.SetTransform(D3DTRANSFORMSTATETYPE.D3DTS_VIEW, &matView);
            var matProj = Matrix4x4.CreatePerspectiveFieldOfView((float)(Math.PI / 4.0), 1.0f, 1.0f, 100.0f).ToD3DMATRIX();
            _device.SetTransform(D3DTRANSFORMSTATETYPE.D3DTS_PROJECTION, &matProj);

            // Set up the global state
            _device.SetRenderState(D3DRENDERSTATETYPE.D3DRS_CULLMODE, (uint)D3DCULL.D3DCULL_NONE);
            _device.SetRenderState(D3DRENDERSTATETYPE.D3DRS_LIGHTING, 0);
            _device.SetStreamSource(0, _vertexBuffer, 0);
            _device.SetFVF(_vertexBuffer.Desc.FVF);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                if (_vertexBuffer != null)
                {
                    _vertexBuffer.Dispose();
                    _vertexBuffer = null!;
                }
            }
        }

        public override void Render(TimeSpan renderingTime)
        {
            _device.BeginScene();
            _device.Clear(
                NativeMethods.D3DCLEAR_TARGET,
                0x7F00007F,  // NOTE: Premultiplied alpha!
                1.0f,
                0);

            // Set up the rotation
            var time = renderingTime.TotalMilliseconds % 1000;
            var angle = time * (2.0 * Math.PI) / 1000.0;
            var matWorld = Matrix4x4.CreateRotationY((float)angle).ToD3DMATRIX();
            _device.SetTransform(NativeMethods.D3DTS_WORLD, &matWorld);
            _device.DrawPrimitive(D3DPRIMITIVETYPE.D3DPT_TRIANGLELIST, 0, 1);
            _device.EndScene();
        }
    }
}

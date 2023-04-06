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
using System.Runtime.InteropServices;
using DirectXSharp.Interop;

namespace WpfApp
{
    internal sealed unsafe class TriangleRenderer : Renderer
    {
        private IDirect3DVertexBuffer9* m_pd3dVB;

        public TriangleRenderer(IDirect3D9* pD3D, IDirect3D9Ex* pD3DEx, HWND__* hwnd, uint uAdapter)
        : base(pD3D, pD3DEx, hwnd, uAdapter)
        {
            var vEyePt = new Vector3(0.0f, 0.0f, -5.0f);
            var vLookatPt = new Vector3(0.0f, 0.0f, 0.0f);
            var vUpVec = new Vector3(0.0f, 1.0f, 0.0f);

            // Set up the VB
            CustomVertex[] vertices =
            {
                new CustomVertex
                {
                    X = -1.0f,
                    Y = -1.0f,
                    Z = 0.0f,
                    Color = 0xffff0000
                }, // x, y, z, color
                new CustomVertex
                {
                    X = 1.0f,
                    Y = -1.0f,
                    Z = 0.0f,
                    Color = 0xff00ff00
                },
                new CustomVertex
                {
                    X = 0.0f,
                    Y = 1.0f,
                    Z = 0.0f,
                    Color = 0xff00ffff
                }
            };

            fixed (IDirect3DVertexBuffer9** pd3dVB = &m_pd3dVB)
            {
                m_pd3dDevice->CreateVertexBuffer(
                  (uint)Marshal.SizeOf(vertices),
                  0,
                  CustomVertex.FVF,
                  D3DPOOL.D3DPOOL_DEFAULT,
                  pd3dVB,
                  null);
            }

            void* pVertices;
            m_pd3dVB->Lock(0, (uint)Marshal.SizeOf(vertices), &pVertices, 0);
            var destVertices = new Span<CustomVertex>(pVertices, vertices.Length);
            vertices.CopyTo(destVertices);
            m_pd3dVB->Unlock();

            // Set up the camera
            var matView = Matrix4x4.CreateLookAt(vEyePt, vLookatPt, vUpVec).ToD3DMATRIX();
            m_pd3dDevice->SetTransform(D3DTRANSFORMSTATETYPE.D3DTS_VIEW, &matView);
            var matProj = Matrix4x4.CreatePerspectiveFieldOfView((float)(Math.PI / 4.0), 1.0f, 1.0f, 100.0f).ToD3DMATRIX();
            m_pd3dDevice->SetTransform(D3DTRANSFORMSTATETYPE.D3DTS_PROJECTION, &matProj);

            // Set up the global state
            m_pd3dDevice->SetRenderState(D3DRENDERSTATETYPE.D3DRS_CULLMODE, (uint)D3DCULL.D3DCULL_NONE);
            m_pd3dDevice->SetRenderState(D3DRENDERSTATETYPE.D3DRS_LIGHTING, 0);
            m_pd3dDevice->SetStreamSource(0, m_pd3dVB, 0, (uint)Marshal.SizeOf<CustomVertex>());
            m_pd3dDevice->SetFVF(CustomVertex.FVF);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                if (m_pd3dVB != null)
                {
                    m_pd3dVB->Release();
                    m_pd3dVB = null;
                }
            }
        }

        public override void Render(TimeSpan renderingTime)
        {
            m_pd3dDevice->BeginScene();
            m_pd3dDevice->Clear(
                0,
                null,
                NativeMethods.D3DCLEAR_TARGET,
                0x7F00007F,  // NOTE: Premultiplied alpha!
                1.0f,
                0);

            // Set up the rotation
            var iTime = renderingTime.TotalMilliseconds % 1000;
            var fAngle = iTime * (2.0 * Math.PI) / 1000.0;
            var matWorld = Matrix4x4.CreateRotationY((float)fAngle).ToD3DMATRIX();
            m_pd3dDevice->SetTransform(NativeMethods.D3DTS_WORLD, &matWorld);
            m_pd3dDevice->DrawPrimitive(D3DPRIMITIVETYPE.D3DPT_TRIANGLELIST, 0, 1);
            m_pd3dDevice->EndScene();
        }
    }
}

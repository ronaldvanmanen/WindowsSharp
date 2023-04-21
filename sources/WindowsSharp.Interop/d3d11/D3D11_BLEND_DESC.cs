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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='D3D11_BLEND_DESC.xml' path='doc/member[@name="D3D11_BLEND_DESC"]/*' />
    public partial struct D3D11_BLEND_DESC
    {
        /// <include file='D3D11_BLEND_DESC.xml' path='doc/member[@name="D3D11_BLEND_DESC.AlphaToCoverageEnable"]/*' />
        [NativeTypeName("BOOL")]
        public int AlphaToCoverageEnable;

        /// <include file='D3D11_BLEND_DESC.xml' path='doc/member[@name="D3D11_BLEND_DESC.IndependentBlendEnable"]/*' />
        [NativeTypeName("BOOL")]
        public int IndependentBlendEnable;

        /// <include file='D3D11_BLEND_DESC.xml' path='doc/member[@name="D3D11_BLEND_DESC.RenderTarget"]/*' />
        [NativeTypeName("D3D11_RENDER_TARGET_BLEND_DESC[8]")]
        public _RenderTarget_e__FixedBuffer RenderTarget;

        /// <include file='_RenderTarget_e__FixedBuffer.xml' path='doc/member[@name="_RenderTarget_e__FixedBuffer"]/*' />
        public partial struct _RenderTarget_e__FixedBuffer
        {
            public D3D11_RENDER_TARGET_BLEND_DESC e0;
            public D3D11_RENDER_TARGET_BLEND_DESC e1;
            public D3D11_RENDER_TARGET_BLEND_DESC e2;
            public D3D11_RENDER_TARGET_BLEND_DESC e3;
            public D3D11_RENDER_TARGET_BLEND_DESC e4;
            public D3D11_RENDER_TARGET_BLEND_DESC e5;
            public D3D11_RENDER_TARGET_BLEND_DESC e6;
            public D3D11_RENDER_TARGET_BLEND_DESC e7;

            public ref D3D11_RENDER_TARGET_BLEND_DESC this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3D11_RENDER_TARGET_BLEND_DESC> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}

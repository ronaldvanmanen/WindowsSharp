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

namespace WindowsSharp.Interop
{
    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC"]/*' />
    public partial struct D3D11_RENDER_TARGET_BLEND_DESC
    {
        /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.BlendEnable"]/*' />
        [NativeTypeName("BOOL")]
        public int BlendEnable;

        /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.SrcBlend"]/*' />
        public D3D11_BLEND SrcBlend;

        /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.DestBlend"]/*' />
        public D3D11_BLEND DestBlend;

        /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.BlendOp"]/*' />
        public D3D11_BLEND_OP BlendOp;

        /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.SrcBlendAlpha"]/*' />
        public D3D11_BLEND SrcBlendAlpha;

        /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.DestBlendAlpha"]/*' />
        public D3D11_BLEND DestBlendAlpha;

        /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.BlendOpAlpha"]/*' />
        public D3D11_BLEND_OP BlendOpAlpha;

        /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.RenderTargetWriteMask"]/*' />
        [NativeTypeName("UINT8")]
        public byte RenderTargetWriteMask;
    }
}

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
    /// <include file='D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC"]/*' />
    public partial struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC
    {
        /// <include file='D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.DecodeProfile"]/*' />
        public Guid DecodeProfile;

        /// <include file='D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.ViewDimension"]/*' />
        public D3D11_VDOV_DIMENSION ViewDimension;

        /// <include file='D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC.Anonymous"]/*' />
        [NativeTypeName("D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:11210:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
        public ref D3D11_TEX2D_VDOV Texture2D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2D, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*' />
            [FieldOffset(0)]
            public D3D11_TEX2D_VDOV Texture2D;
        }
    }
}

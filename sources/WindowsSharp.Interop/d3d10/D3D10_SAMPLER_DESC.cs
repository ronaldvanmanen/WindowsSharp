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
    /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC"]/*' />
    public unsafe partial struct D3D10_SAMPLER_DESC
    {
        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.Filter"]/*' />
        public D3D10_FILTER Filter;

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.AddressU"]/*' />
        public D3D10_TEXTURE_ADDRESS_MODE AddressU;

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.AddressV"]/*' />
        public D3D10_TEXTURE_ADDRESS_MODE AddressV;

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.AddressW"]/*' />
        public D3D10_TEXTURE_ADDRESS_MODE AddressW;

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.MipLODBias"]/*' />
        public float MipLODBias;

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.MaxAnisotropy"]/*' />
        public uint MaxAnisotropy;

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.ComparisonFunc"]/*' />
        public D3D10_COMPARISON_FUNC ComparisonFunc;

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.BorderColor"]/*' />
        [NativeTypeName("FLOAT[4]")]
        public fixed float BorderColor[4];

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.MinLOD"]/*' />
        public float MinLOD;

        /// <include file='D3D10_SAMPLER_DESC.xml' path='doc/member[@name="D3D10_SAMPLER_DESC.MaxLOD"]/*' />
        public float MaxLOD;
    }
}

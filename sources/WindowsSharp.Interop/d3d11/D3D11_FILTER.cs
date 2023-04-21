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
    /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER"]/*' />
    public enum D3D11_FILTER
    {
        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MIN_MAG_MIP_POINT"]/*' />
        D3D11_FILTER_MIN_MAG_MIP_POINT = 0,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MIN_MAG_POINT_MIP_LINEAR"]/*' />
        D3D11_FILTER_MIN_MAG_POINT_MIP_LINEAR = 0x1,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
        D3D11_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x4,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MIN_POINT_MAG_MIP_LINEAR"]/*' />
        D3D11_FILTER_MIN_POINT_MAG_MIP_LINEAR = 0x5,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MIN_LINEAR_MAG_MIP_POINT"]/*' />
        D3D11_FILTER_MIN_LINEAR_MAG_MIP_POINT = 0x10,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
        D3D11_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x11,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MIN_MAG_LINEAR_MIP_POINT"]/*' />
        D3D11_FILTER_MIN_MAG_LINEAR_MIP_POINT = 0x14,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MIN_MAG_MIP_LINEAR"]/*' />
        D3D11_FILTER_MIN_MAG_MIP_LINEAR = 0x15,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_ANISOTROPIC"]/*' />
        D3D11_FILTER_ANISOTROPIC = 0x55,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_MIN_MAG_MIP_POINT"]/*' />
        D3D11_FILTER_COMPARISON_MIN_MAG_MIP_POINT = 0x80,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR"]/*' />
        D3D11_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 0x81,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
        D3D11_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x84,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR"]/*' />
        D3D11_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 0x85,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT"]/*' />
        D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 0x90,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
        D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x91,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT"]/*' />
        D3D11_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 0x94,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR"]/*' />
        D3D11_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR = 0x95,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_COMPARISON_ANISOTROPIC"]/*' />
        D3D11_FILTER_COMPARISON_ANISOTROPIC = 0xd5,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_MIN_MAG_MIP_POINT"]/*' />
        D3D11_FILTER_MINIMUM_MIN_MAG_MIP_POINT = 0x100,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR"]/*' />
        D3D11_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR = 0x101,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
        D3D11_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x104,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR"]/*' />
        D3D11_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR = 0x105,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT"]/*' />
        D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT = 0x110,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
        D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x111,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT"]/*' />
        D3D11_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT = 0x114,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR"]/*' />
        D3D11_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR = 0x115,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MINIMUM_ANISOTROPIC"]/*' />
        D3D11_FILTER_MINIMUM_ANISOTROPIC = 0x155,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_POINT"]/*' />
        D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_POINT = 0x180,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR"]/*' />
        D3D11_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR = 0x181,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
        D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x184,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR"]/*' />
        D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR = 0x185,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT"]/*' />
        D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT = 0x190,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
        D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x191,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT"]/*' />
        D3D11_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT = 0x194,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR"]/*' />
        D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR = 0x195,

        /// <include file='D3D11_FILTER.xml' path='doc/member[@name="D3D11_FILTER.D3D11_FILTER_MAXIMUM_ANISOTROPIC"]/*' />
        D3D11_FILTER_MAXIMUM_ANISOTROPIC = 0x1d5,
    }
}

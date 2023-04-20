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
    /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER"]/*' />
    public enum D3D10_FILTER
    {
        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_MAG_MIP_POINT"]/*' />
        D3D10_FILTER_MIN_MAG_MIP_POINT = 0,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_MAG_POINT_MIP_LINEAR"]/*' />
        D3D10_FILTER_MIN_MAG_POINT_MIP_LINEAR = 0x1,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
        D3D10_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x4,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_POINT_MAG_MIP_LINEAR"]/*' />
        D3D10_FILTER_MIN_POINT_MAG_MIP_LINEAR = 0x5,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_LINEAR_MAG_MIP_POINT"]/*' />
        D3D10_FILTER_MIN_LINEAR_MAG_MIP_POINT = 0x10,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
        D3D10_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x11,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_MAG_LINEAR_MIP_POINT"]/*' />
        D3D10_FILTER_MIN_MAG_LINEAR_MIP_POINT = 0x14,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_MIN_MAG_MIP_LINEAR"]/*' />
        D3D10_FILTER_MIN_MAG_MIP_LINEAR = 0x15,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_ANISOTROPIC"]/*' />
        D3D10_FILTER_ANISOTROPIC = 0x55,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_MAG_MIP_POINT"]/*' />
        D3D10_FILTER_COMPARISON_MIN_MAG_MIP_POINT = 0x80,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR"]/*' />
        D3D10_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 0x81,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*' />
        D3D10_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x84,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR"]/*' />
        D3D10_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 0x85,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT"]/*' />
        D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 0x90,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*' />
        D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x91,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT"]/*' />
        D3D10_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 0x94,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR"]/*' />
        D3D10_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR = 0x95,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_COMPARISON_ANISOTROPIC"]/*' />
        D3D10_FILTER_COMPARISON_ANISOTROPIC = 0xd5,

        /// <include file='D3D10_FILTER.xml' path='doc/member[@name="D3D10_FILTER.D3D10_FILTER_TEXT_1BIT"]/*' />
        D3D10_FILTER_TEXT_1BIT = unchecked((int)(0x80000000)),
    }
}

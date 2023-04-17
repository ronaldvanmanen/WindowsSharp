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
    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE"]/*' />
    public enum DXGI_COLOR_SPACE_TYPE
    {
        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709"]/*' />
        DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709 = 0,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709"]/*' />
        DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709 = 1,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709"]/*' />
        DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709 = 2,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020"]/*' />
        DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020 = 3,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RESERVED"]/*' />
        DXGI_COLOR_SPACE_RESERVED = 4,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601"]/*' />
        DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601 = 5,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601 = 6,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601"]/*' />
        DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601 = 7,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709 = 8,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709"]/*' />
        DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709 = 9,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020 = 10,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020 = 11,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020"]/*' />
        DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020 = 12,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020 = 13,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020"]/*' />
        DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020 = 14,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020 = 15,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020 = 16,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020"]/*' />
        DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020 = 17,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020 = 18,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020 = 19,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709"]/*' />
        DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709 = 20,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020"]/*' />
        DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020 = 21,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709 = 22,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020 = 23,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020"]/*' />
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020 = 24,

        /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_CUSTOM"]/*' />
        DXGI_COLOR_SPACE_CUSTOM = unchecked((int)(0xFFFFFFFF)),
    }
}

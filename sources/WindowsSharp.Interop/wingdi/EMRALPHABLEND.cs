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
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND"]/*' />
    public partial struct EMRALPHABLEND
    {
        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.emr"]/*' />
        public EMR emr;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.xDest"]/*' />
        [NativeTypeName("LONG")]
        public int xDest;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.yDest"]/*' />
        [NativeTypeName("LONG")]
        public int yDest;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cxDest"]/*' />
        [NativeTypeName("LONG")]
        public int cxDest;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cyDest"]/*' />
        [NativeTypeName("LONG")]
        public int cyDest;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.dwRop"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwRop;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.xSrc"]/*' />
        [NativeTypeName("LONG")]
        public int xSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.ySrc"]/*' />
        [NativeTypeName("LONG")]
        public int ySrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.xformSrc"]/*' />
        public XFORM xformSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.crBkColorSrc"]/*' />
        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.iUsageSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.offBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cbBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.offBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cbBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cxSrc"]/*' />
        [NativeTypeName("LONG")]
        public int cxSrc;

        /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cySrc"]/*' />
        [NativeTypeName("LONG")]
        public int cySrc;
    }
}

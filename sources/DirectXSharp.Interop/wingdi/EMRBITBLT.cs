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

namespace DirectXSharp.Interop
{
    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT"]/*' />
    public partial struct EMRBITBLT
    {
        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.emr"]/*' />
        public EMR emr;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.xDest"]/*' />
        [NativeTypeName("LONG")]
        public int xDest;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.yDest"]/*' />
        [NativeTypeName("LONG")]
        public int yDest;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.cxDest"]/*' />
        [NativeTypeName("LONG")]
        public int cxDest;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.cyDest"]/*' />
        [NativeTypeName("LONG")]
        public int cyDest;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.dwRop"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwRop;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.xSrc"]/*' />
        [NativeTypeName("LONG")]
        public int xSrc;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.ySrc"]/*' />
        [NativeTypeName("LONG")]
        public int ySrc;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.xformSrc"]/*' />
        public XFORM xformSrc;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.crBkColorSrc"]/*' />
        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.iUsageSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.offBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.cbBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.offBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.cbBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;
    }
}

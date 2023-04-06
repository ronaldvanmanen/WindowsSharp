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
    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT"]/*' />
    public partial struct EMRTRANSPARENTBLT
    {
        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.emr"]/*' />
        public EMR emr;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.xDest"]/*' />
        [NativeTypeName("LONG")]
        public int xDest;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.yDest"]/*' />
        [NativeTypeName("LONG")]
        public int yDest;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cxDest"]/*' />
        [NativeTypeName("LONG")]
        public int cxDest;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cyDest"]/*' />
        [NativeTypeName("LONG")]
        public int cyDest;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.dwRop"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwRop;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.xSrc"]/*' />
        [NativeTypeName("LONG")]
        public int xSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.ySrc"]/*' />
        [NativeTypeName("LONG")]
        public int ySrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.xformSrc"]/*' />
        public XFORM xformSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.crBkColorSrc"]/*' />
        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.iUsageSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.offBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cbBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.offBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cbBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cxSrc"]/*' />
        [NativeTypeName("LONG")]
        public int cxSrc;

        /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cySrc"]/*' />
        [NativeTypeName("LONG")]
        public int cySrc;
    }
}

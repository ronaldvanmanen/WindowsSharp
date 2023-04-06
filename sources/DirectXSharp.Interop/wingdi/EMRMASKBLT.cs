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
    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT"]/*' />
    public partial struct EMRMASKBLT
    {
        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.emr"]/*' />
        public EMR emr;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.xDest"]/*' />
        [NativeTypeName("LONG")]
        public int xDest;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.yDest"]/*' />
        [NativeTypeName("LONG")]
        public int yDest;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cxDest"]/*' />
        [NativeTypeName("LONG")]
        public int cxDest;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cyDest"]/*' />
        [NativeTypeName("LONG")]
        public int cyDest;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.dwRop"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwRop;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.xSrc"]/*' />
        [NativeTypeName("LONG")]
        public int xSrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.ySrc"]/*' />
        [NativeTypeName("LONG")]
        public int ySrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.xformSrc"]/*' />
        public XFORM xformSrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.crBkColorSrc"]/*' />
        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.iUsageSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.offBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cbBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.offBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cbBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.xMask"]/*' />
        [NativeTypeName("LONG")]
        public int xMask;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.yMask"]/*' />
        [NativeTypeName("LONG")]
        public int yMask;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.iUsageMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageMask;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.offBmiMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiMask;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cbBmiMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiMask;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.offBitsMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsMask;

        /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cbBitsMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsMask;
    }
}

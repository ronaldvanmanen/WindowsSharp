// WindowsSharp
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

namespace WindowsSharp.Interop
{
    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS"]/*' />
    public partial struct EMRSTRETCHDIBITS
    {
        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.emr"]/*' />
        public EMR emr;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.xDest"]/*' />
        [NativeTypeName("LONG")]
        public int xDest;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.yDest"]/*' />
        [NativeTypeName("LONG")]
        public int yDest;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.xSrc"]/*' />
        [NativeTypeName("LONG")]
        public int xSrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.ySrc"]/*' />
        [NativeTypeName("LONG")]
        public int ySrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cxSrc"]/*' />
        [NativeTypeName("LONG")]
        public int cxSrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cySrc"]/*' />
        [NativeTypeName("LONG")]
        public int cySrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.offBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cbBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.offBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cbBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.iUsageSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.dwRop"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwRop;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cxDest"]/*' />
        [NativeTypeName("LONG")]
        public int cxDest;

        /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cyDest"]/*' />
        [NativeTypeName("LONG")]
        public int cyDest;
    }
}

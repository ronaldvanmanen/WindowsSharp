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
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE"]/*' />
    public partial struct EMRSETDIBITSTODEVICE
    {
        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.emr"]/*' />
        public EMR emr;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.xDest"]/*' />
        [NativeTypeName("LONG")]
        public int xDest;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.yDest"]/*' />
        [NativeTypeName("LONG")]
        public int yDest;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.xSrc"]/*' />
        [NativeTypeName("LONG")]
        public int xSrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.ySrc"]/*' />
        [NativeTypeName("LONG")]
        public int ySrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cxSrc"]/*' />
        [NativeTypeName("LONG")]
        public int cxSrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cySrc"]/*' />
        [NativeTypeName("LONG")]
        public int cySrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.offBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cbBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.offBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cbBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.iUsageSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.iStartScan"]/*' />
        [NativeTypeName("DWORD")]
        public uint iStartScan;

        /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cScans"]/*' />
        [NativeTypeName("DWORD")]
        public uint cScans;
    }
}

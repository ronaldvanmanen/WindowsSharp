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
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER"]/*' />
    public partial struct ENHMETAHEADER
    {
        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.iType"]/*' />
        [NativeTypeName("DWORD")]
        public uint iType;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint nSize;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.rclFrame"]/*' />
        public RECTL rclFrame;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.dSignature"]/*' />
        [NativeTypeName("DWORD")]
        public uint dSignature;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint nVersion;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nBytes"]/*' />
        [NativeTypeName("DWORD")]
        public uint nBytes;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nRecords"]/*' />
        [NativeTypeName("DWORD")]
        public uint nRecords;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nHandles"]/*' />
        [NativeTypeName("WORD")]
        public ushort nHandles;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.sReserved"]/*' />
        [NativeTypeName("WORD")]
        public ushort sReserved;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nDescription"]/*' />
        [NativeTypeName("DWORD")]
        public uint nDescription;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.offDescription"]/*' />
        [NativeTypeName("DWORD")]
        public uint offDescription;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nPalEntries"]/*' />
        [NativeTypeName("DWORD")]
        public uint nPalEntries;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.szlDevice"]/*' />
        [NativeTypeName("SIZEL")]
        public SIZE szlDevice;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.szlMillimeters"]/*' />
        [NativeTypeName("SIZEL")]
        public SIZE szlMillimeters;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.cbPixelFormat"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbPixelFormat;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.offPixelFormat"]/*' />
        [NativeTypeName("DWORD")]
        public uint offPixelFormat;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.bOpenGL"]/*' />
        [NativeTypeName("DWORD")]
        public uint bOpenGL;

        /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.szlMicrometers"]/*' />
        [NativeTypeName("SIZEL")]
        public SIZE szlMicrometers;
    }
}

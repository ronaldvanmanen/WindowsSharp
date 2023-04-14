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
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER"]/*' />
    public partial struct BITMAPV4HEADER
    {
        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4Size;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Width"]/*' />
        [NativeTypeName("LONG")]
        public int bV4Width;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Height"]/*' />
        [NativeTypeName("LONG")]
        public int bV4Height;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Planes"]/*' />
        [NativeTypeName("WORD")]
        public ushort bV4Planes;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4BitCount"]/*' />
        [NativeTypeName("WORD")]
        public ushort bV4BitCount;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4V4Compression"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4V4Compression;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4SizeImage"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4SizeImage;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4XPelsPerMeter"]/*' />
        [NativeTypeName("LONG")]
        public int bV4XPelsPerMeter;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4YPelsPerMeter"]/*' />
        [NativeTypeName("LONG")]
        public int bV4YPelsPerMeter;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4ClrUsed"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4ClrUsed;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4ClrImportant"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4ClrImportant;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4RedMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4RedMask;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4GreenMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4GreenMask;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4BlueMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4BlueMask;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4AlphaMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4AlphaMask;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4CSType"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4CSType;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Endpoints"]/*' />
        public CIEXYZTRIPLE bV4Endpoints;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4GammaRed"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4GammaRed;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4GammaGreen"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4GammaGreen;

        /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4GammaBlue"]/*' />
        [NativeTypeName("DWORD")]
        public uint bV4GammaBlue;
    }
}

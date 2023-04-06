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
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER"]/*' />
    public partial struct BITMAPINFOHEADER
    {
        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint biSize;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biWidth"]/*' />
        [NativeTypeName("LONG")]
        public int biWidth;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biHeight"]/*' />
        [NativeTypeName("LONG")]
        public int biHeight;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biPlanes"]/*' />
        [NativeTypeName("WORD")]
        public ushort biPlanes;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biBitCount"]/*' />
        [NativeTypeName("WORD")]
        public ushort biBitCount;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biCompression"]/*' />
        [NativeTypeName("DWORD")]
        public uint biCompression;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biSizeImage"]/*' />
        [NativeTypeName("DWORD")]
        public uint biSizeImage;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biXPelsPerMeter"]/*' />
        [NativeTypeName("LONG")]
        public int biXPelsPerMeter;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biYPelsPerMeter"]/*' />
        [NativeTypeName("LONG")]
        public int biYPelsPerMeter;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biClrUsed"]/*' />
        [NativeTypeName("DWORD")]
        public uint biClrUsed;

        /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biClrImportant"]/*' />
        [NativeTypeName("DWORD")]
        public uint biClrImportant;
    }
}

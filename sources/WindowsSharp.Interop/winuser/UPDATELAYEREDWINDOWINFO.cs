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
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO"]/*' />
    public unsafe partial struct UPDATELAYEREDWINDOWINFO
    {
        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.cbSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbSize;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.hdcDst"]/*' />
        [NativeTypeName("HDC")]
        public HDC__* hdcDst;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.pptDst"]/*' />
        [NativeTypeName("const POINT *")]
        public POINT* pptDst;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.psize"]/*' />
        [NativeTypeName("const SIZE *")]
        public SIZE* psize;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.hdcSrc"]/*' />
        [NativeTypeName("HDC")]
        public HDC__* hdcSrc;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.pptSrc"]/*' />
        [NativeTypeName("const POINT *")]
        public POINT* pptSrc;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.crKey"]/*' />
        [NativeTypeName("COLORREF")]
        public uint crKey;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.pblend"]/*' />
        [NativeTypeName("const BLENDFUNCTION *")]
        public BLENDFUNCTION* pblend;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.prcDirty"]/*' />
        [NativeTypeName("const RECT *")]
        public RECT* prcDirty;
    }
}

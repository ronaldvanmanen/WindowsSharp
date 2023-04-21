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
    /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW"]/*' />
    public unsafe partial struct ICONINFOEXW
    {
        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.cbSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbSize;

        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.fIcon"]/*' />
        [NativeTypeName("BOOL")]
        public int fIcon;

        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.xHotspot"]/*' />
        [NativeTypeName("DWORD")]
        public uint xHotspot;

        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.yHotspot"]/*' />
        [NativeTypeName("DWORD")]
        public uint yHotspot;

        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.hbmMask"]/*' />
        [NativeTypeName("HBITMAP")]
        public HBITMAP__* hbmMask;

        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.hbmColor"]/*' />
        [NativeTypeName("HBITMAP")]
        public HBITMAP__* hbmColor;

        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.wResID"]/*' />
        [NativeTypeName("WORD")]
        public ushort wResID;

        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.szModName"]/*' />
        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szModName[260];

        /// <include file='ICONINFOEXW.xml' path='doc/member[@name="ICONINFOEXW.szResName"]/*' />
        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szResName[260];
    }
}

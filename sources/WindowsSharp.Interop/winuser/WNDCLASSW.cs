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
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW"]/*' />
    public unsafe partial struct WNDCLASSW
    {
        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.style"]/*' />
        public uint style;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.lpfnWndProc"]/*' />
        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged[Stdcall]<HWND__*, uint, ulong, long, long> lpfnWndProc;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.cbClsExtra"]/*' />
        public int cbClsExtra;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.cbWndExtra"]/*' />
        public int cbWndExtra;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.hInstance"]/*' />
        [NativeTypeName("HINSTANCE")]
        public HINSTANCE__* hInstance;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.hIcon"]/*' />
        [NativeTypeName("HICON")]
        public HICON__* hIcon;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.hCursor"]/*' />
        [NativeTypeName("HCURSOR")]
        public HICON__* hCursor;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.hbrBackground"]/*' />
        [NativeTypeName("HBRUSH")]
        public HBRUSH__* hbrBackground;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.lpszMenuName"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpszMenuName;

        /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.lpszClassName"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpszClassName;
    }
}

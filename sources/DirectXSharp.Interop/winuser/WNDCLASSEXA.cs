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
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA"]/*' />
    public unsafe partial struct WNDCLASSEXA
    {
        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.cbSize"]/*' />
        public uint cbSize;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.style"]/*' />
        public uint style;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.lpfnWndProc"]/*' />
        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged<HWND__*, uint, ulong, long, long> lpfnWndProc;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.cbClsExtra"]/*' />
        public int cbClsExtra;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.cbWndExtra"]/*' />
        public int cbWndExtra;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hInstance"]/*' />
        [NativeTypeName("HINSTANCE")]
        public HINSTANCE__* hInstance;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hIcon"]/*' />
        [NativeTypeName("HICON")]
        public HICON__* hIcon;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hCursor"]/*' />
        [NativeTypeName("HCURSOR")]
        public HICON__* hCursor;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hbrBackground"]/*' />
        [NativeTypeName("HBRUSH")]
        public HBRUSH__* hbrBackground;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.lpszMenuName"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpszMenuName;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.lpszClassName"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpszClassName;

        /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hIconSm"]/*' />
        [NativeTypeName("HICON")]
        public HICON__* hIconSm;
    }
}

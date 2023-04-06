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
    /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW"]/*' />
    public unsafe partial struct CREATESTRUCTW
    {
        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.lpCreateParams"]/*' />
        [NativeTypeName("LPVOID")]
        public void* lpCreateParams;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.hInstance"]/*' />
        [NativeTypeName("HINSTANCE")]
        public HINSTANCE__* hInstance;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.hMenu"]/*' />
        [NativeTypeName("HMENU")]
        public HMENU__* hMenu;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.hwndParent"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndParent;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.cy"]/*' />
        public int cy;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.cx"]/*' />
        public int cx;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.y"]/*' />
        public int y;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.x"]/*' />
        public int x;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.style"]/*' />
        [NativeTypeName("LONG")]
        public int style;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.lpszName"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpszName;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.lpszClass"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpszClass;

        /// <include file='CREATESTRUCTW.xml' path='doc/member[@name="CREATESTRUCTW.dwExStyle"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwExStyle;
    }
}

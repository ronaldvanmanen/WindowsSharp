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
    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW"]/*' />
    public unsafe partial struct MSGBOXPARAMSW
    {
        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.cbSize"]/*' />
        public uint cbSize;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.hwndOwner"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndOwner;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.hInstance"]/*' />
        [NativeTypeName("HINSTANCE")]
        public HINSTANCE__* hInstance;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.lpszText"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpszText;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.lpszCaption"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpszCaption;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.dwStyle"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwStyle;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.lpszIcon"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpszIcon;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.dwContextHelpId"]/*' />
        [NativeTypeName("DWORD_PTR")]
        public ulong dwContextHelpId;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.lpfnMsgBoxCallback"]/*' />
        [NativeTypeName("MSGBOXCALLBACK")]
        public delegate* unmanaged<HELPINFO*, void> lpfnMsgBoxCallback;

        /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.dwLanguageId"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwLanguageId;
    }
}

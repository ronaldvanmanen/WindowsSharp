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
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA"]/*' />
    public unsafe partial struct MSGBOXPARAMSA
    {
        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.cbSize"]/*' />
        public uint cbSize;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.hwndOwner"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndOwner;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.hInstance"]/*' />
        [NativeTypeName("HINSTANCE")]
        public HINSTANCE__* hInstance;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.lpszText"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpszText;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.lpszCaption"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpszCaption;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.dwStyle"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwStyle;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.lpszIcon"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpszIcon;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.dwContextHelpId"]/*' />
        [NativeTypeName("DWORD_PTR")]
        public ulong dwContextHelpId;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.lpfnMsgBoxCallback"]/*' />
        [NativeTypeName("MSGBOXCALLBACK")]
        public delegate* unmanaged<HELPINFO*, void> lpfnMsgBoxCallback;

        /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.dwLanguageId"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwLanguageId;
    }
}

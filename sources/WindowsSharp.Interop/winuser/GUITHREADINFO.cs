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
    /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO"]/*' />
    public unsafe partial struct GUITHREADINFO
    {
        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.cbSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbSize;

        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint flags;

        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndActive"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndActive;

        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndFocus"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndFocus;

        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndCapture"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndCapture;

        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndMenuOwner"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndMenuOwner;

        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndMoveSize"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndMoveSize;

        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.hwndCaret"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndCaret;

        /// <include file='GUITHREADINFO.xml' path='doc/member[@name="GUITHREADINFO.rcCaret"]/*' />
        public RECT rcCaret;
    }
}

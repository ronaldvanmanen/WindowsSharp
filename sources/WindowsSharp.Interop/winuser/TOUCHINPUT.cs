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
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT"]/*' />
    public unsafe partial struct TOUCHINPUT
    {
        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.x"]/*' />
        [NativeTypeName("LONG")]
        public int x;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.y"]/*' />
        [NativeTypeName("LONG")]
        public int y;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.hSource"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hSource;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwID"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwID;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwMask;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwTime"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwTime;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwExtraInfo"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong dwExtraInfo;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.cxContact"]/*' />
        [NativeTypeName("DWORD")]
        public uint cxContact;

        /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.cyContact"]/*' />
        [NativeTypeName("DWORD")]
        public uint cyContact;
    }
}

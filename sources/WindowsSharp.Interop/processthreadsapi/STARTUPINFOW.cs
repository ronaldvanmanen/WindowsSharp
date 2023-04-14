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
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW"]/*' />
    public unsafe partial struct STARTUPINFOW
    {
        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.cb"]/*' />
        [NativeTypeName("DWORD")]
        public uint cb;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.lpReserved"]/*' />
        [NativeTypeName("LPWSTR")]
        public ushort* lpReserved;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.lpDesktop"]/*' />
        [NativeTypeName("LPWSTR")]
        public ushort* lpDesktop;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.lpTitle"]/*' />
        [NativeTypeName("LPWSTR")]
        public ushort* lpTitle;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwX"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwX;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwY"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwY;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwXSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwXSize;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwYSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwYSize;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwXCountChars"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwXCountChars;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwYCountChars"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwYCountChars;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwFillAttribute"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFillAttribute;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.wShowWindow"]/*' />
        [NativeTypeName("WORD")]
        public ushort wShowWindow;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.cbReserved2"]/*' />
        [NativeTypeName("WORD")]
        public ushort cbReserved2;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.lpReserved2"]/*' />
        [NativeTypeName("LPBYTE")]
        public byte* lpReserved2;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.hStdInput"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hStdInput;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.hStdOutput"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hStdOutput;

        /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.hStdError"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hStdError;
    }
}

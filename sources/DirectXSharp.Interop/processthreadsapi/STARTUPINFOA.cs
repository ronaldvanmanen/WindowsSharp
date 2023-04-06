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
    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA"]/*' />
    public unsafe partial struct STARTUPINFOA
    {
        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.cb"]/*' />
        [NativeTypeName("DWORD")]
        public uint cb;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.lpReserved"]/*' />
        [NativeTypeName("LPSTR")]
        public sbyte* lpReserved;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.lpDesktop"]/*' />
        [NativeTypeName("LPSTR")]
        public sbyte* lpDesktop;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.lpTitle"]/*' />
        [NativeTypeName("LPSTR")]
        public sbyte* lpTitle;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwX"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwX;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwY"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwY;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwXSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwXSize;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwYSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwYSize;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwXCountChars"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwXCountChars;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwYCountChars"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwYCountChars;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwFillAttribute"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFillAttribute;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.wShowWindow"]/*' />
        [NativeTypeName("WORD")]
        public ushort wShowWindow;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.cbReserved2"]/*' />
        [NativeTypeName("WORD")]
        public ushort cbReserved2;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.lpReserved2"]/*' />
        [NativeTypeName("LPBYTE")]
        public byte* lpReserved2;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.hStdInput"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hStdInput;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.hStdOutput"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hStdOutput;

        /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.hStdError"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hStdError;
    }
}

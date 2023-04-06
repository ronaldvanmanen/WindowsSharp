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
    /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA"]/*' />
    public unsafe partial struct OSVERSIONINFOEXA
    {
        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwOSVersionInfoSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwOSVersionInfoSize;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwMajorVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwMajorVersion;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwMinorVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwMinorVersion;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwBuildNumber"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwBuildNumber;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.dwPlatformId"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwPlatformId;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.szCSDVersion"]/*' />
        [NativeTypeName("CHAR [128]")]
        public fixed sbyte szCSDVersion[128];

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wServicePackMajor"]/*' />
        [NativeTypeName("WORD")]
        public ushort wServicePackMajor;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wServicePackMinor"]/*' />
        [NativeTypeName("WORD")]
        public ushort wServicePackMinor;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wSuiteMask"]/*' />
        [NativeTypeName("WORD")]
        public ushort wSuiteMask;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wProductType"]/*' />
        public byte wProductType;

        /// <include file='OSVERSIONINFOEXA.xml' path='doc/member[@name="OSVERSIONINFOEXA.wReserved"]/*' />
        public byte wReserved;
    }
}

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
    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA"]/*' />
    public unsafe partial struct WIN32_FIND_DATAA
    {
        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.dwFileAttributes"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFileAttributes;

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.ftCreationTime"]/*' />
        public FILETIME ftCreationTime;

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.ftLastAccessTime"]/*' />
        public FILETIME ftLastAccessTime;

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.ftLastWriteTime"]/*' />
        public FILETIME ftLastWriteTime;

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.nFileSizeHigh"]/*' />
        [NativeTypeName("DWORD")]
        public uint nFileSizeHigh;

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.nFileSizeLow"]/*' />
        [NativeTypeName("DWORD")]
        public uint nFileSizeLow;

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.dwReserved0"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwReserved0;

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.dwReserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.cFileName"]/*' />
        [NativeTypeName("CHAR [260]")]
        public fixed sbyte cFileName[260];

        /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.cAlternateFileName"]/*' />
        [NativeTypeName("CHAR [14]")]
        public fixed sbyte cAlternateFileName[14];
    }
}

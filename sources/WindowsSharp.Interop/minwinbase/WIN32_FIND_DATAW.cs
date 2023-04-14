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
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW"]/*' />
    public unsafe partial struct WIN32_FIND_DATAW
    {
        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwFileAttributes"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFileAttributes;

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftCreationTime"]/*' />
        public FILETIME ftCreationTime;

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftLastAccessTime"]/*' />
        public FILETIME ftLastAccessTime;

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftLastWriteTime"]/*' />
        public FILETIME ftLastWriteTime;

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.nFileSizeHigh"]/*' />
        [NativeTypeName("DWORD")]
        public uint nFileSizeHigh;

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.nFileSizeLow"]/*' />
        [NativeTypeName("DWORD")]
        public uint nFileSizeLow;

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwReserved0"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwReserved0;

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwReserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.cFileName"]/*' />
        [NativeTypeName("WCHAR [260]")]
        public fixed ushort cFileName[260];

        /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.cAlternateFileName"]/*' />
        [NativeTypeName("WCHAR [14]")]
        public fixed ushort cAlternateFileName[14];
    }
}

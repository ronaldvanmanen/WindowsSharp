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
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER"]/*' />
    public unsafe partial struct IMAGE_ARCHIVE_MEMBER_HEADER
    {
        /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Name"]/*' />
        [NativeTypeName("BYTE [16]")]
        public fixed byte Name[16];

        /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Date"]/*' />
        [NativeTypeName("BYTE [12]")]
        public fixed byte Date[12];

        /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.UserID"]/*' />
        [NativeTypeName("BYTE [6]")]
        public fixed byte UserID[6];

        /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.GroupID"]/*' />
        [NativeTypeName("BYTE [6]")]
        public fixed byte GroupID[6];

        /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Mode"]/*' />
        [NativeTypeName("BYTE [8]")]
        public fixed byte Mode[8];

        /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Size"]/*' />
        [NativeTypeName("BYTE [10]")]
        public fixed byte Size[10];

        /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.EndHeader"]/*' />
        [NativeTypeName("BYTE [2]")]
        public fixed byte EndHeader[2];
    }
}

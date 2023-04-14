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
    /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION"]/*' />
    public unsafe partial struct FILE_NOTIFY_EXTENDED_INFORMATION
    {
        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.NextEntryOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint NextEntryOffset;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.Action"]/*' />
        [NativeTypeName("DWORD")]
        public uint Action;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.CreationTime"]/*' />
        public LARGE_INTEGER CreationTime;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.LastModificationTime"]/*' />
        public LARGE_INTEGER LastModificationTime;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.LastChangeTime"]/*' />
        public LARGE_INTEGER LastChangeTime;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.LastAccessTime"]/*' />
        public LARGE_INTEGER LastAccessTime;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.AllocatedLength"]/*' />
        public LARGE_INTEGER AllocatedLength;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileSize"]/*' />
        public LARGE_INTEGER FileSize;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileAttributes"]/*' />
        [NativeTypeName("DWORD")]
        public uint FileAttributes;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.ReparsePointTag"]/*' />
        [NativeTypeName("DWORD")]
        public uint ReparsePointTag;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileId"]/*' />
        public LARGE_INTEGER FileId;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.ParentFileId"]/*' />
        public LARGE_INTEGER ParentFileId;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileNameLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint FileNameLength;

        /// <include file='FILE_NOTIFY_EXTENDED_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_EXTENDED_INFORMATION.FileName"]/*' />
        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileName[1];
    }
}

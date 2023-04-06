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
    /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO"]/*' />
    public unsafe partial struct FILE_FULL_DIR_INFO
    {
        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.NextEntryOffset"]/*' />
        [NativeTypeName("ULONG")]
        public uint NextEntryOffset;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.FileIndex"]/*' />
        [NativeTypeName("ULONG")]
        public uint FileIndex;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.CreationTime"]/*' />
        public LARGE_INTEGER CreationTime;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.LastAccessTime"]/*' />
        public LARGE_INTEGER LastAccessTime;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.LastWriteTime"]/*' />
        public LARGE_INTEGER LastWriteTime;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.ChangeTime"]/*' />
        public LARGE_INTEGER ChangeTime;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.EndOfFile"]/*' />
        public LARGE_INTEGER EndOfFile;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.AllocationSize"]/*' />
        public LARGE_INTEGER AllocationSize;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.FileAttributes"]/*' />
        [NativeTypeName("ULONG")]
        public uint FileAttributes;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.FileNameLength"]/*' />
        [NativeTypeName("ULONG")]
        public uint FileNameLength;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.EaSize"]/*' />
        [NativeTypeName("ULONG")]
        public uint EaSize;

        /// <include file='FILE_FULL_DIR_INFO.xml' path='doc/member[@name="FILE_FULL_DIR_INFO.FileName"]/*' />
        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileName[1];
    }
}

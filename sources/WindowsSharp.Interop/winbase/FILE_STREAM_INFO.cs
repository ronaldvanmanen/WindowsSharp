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
    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO"]/*' />
    public unsafe partial struct FILE_STREAM_INFO
    {
        /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.NextEntryOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint NextEntryOffset;

        /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamNameLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint StreamNameLength;

        /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamSize"]/*' />
        public LARGE_INTEGER StreamSize;

        /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamAllocationSize"]/*' />
        public LARGE_INTEGER StreamAllocationSize;

        /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamName"]/*' />
        [NativeTypeName("WCHAR [1]")]
        public fixed ushort StreamName[1];
    }
}

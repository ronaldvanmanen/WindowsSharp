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

using System;

namespace WindowsSharp.Interop
{
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG"]/*' />
    public unsafe partial struct STATSTG
    {
        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.pwcsName"]/*' />
        [NativeTypeName("LPOLESTR")]
        public ushort* pwcsName;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.type"]/*' />
        [NativeTypeName("DWORD")]
        public uint type;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.cbSize"]/*' />
        public ULARGE_INTEGER cbSize;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.mtime"]/*' />
        public FILETIME mtime;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.ctime"]/*' />
        public FILETIME ctime;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.atime"]/*' />
        public FILETIME atime;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfMode"]/*' />
        [NativeTypeName("DWORD")]
        public uint grfMode;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfLocksSupported"]/*' />
        [NativeTypeName("DWORD")]
        public uint grfLocksSupported;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.clsid"]/*' />
        [NativeTypeName("CLSID")]
        public Guid clsid;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfStateBits"]/*' />
        [NativeTypeName("DWORD")]
        public uint grfStateBits;

        /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.reserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint reserved;
    }
}

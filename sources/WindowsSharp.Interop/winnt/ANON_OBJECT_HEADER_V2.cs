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
    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2"]/*' />
    public partial struct ANON_OBJECT_HEADER_V2
    {
        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Sig1"]/*' />
        [NativeTypeName("WORD")]
        public ushort Sig1;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Sig2"]/*' />
        [NativeTypeName("WORD")]
        public ushort Sig2;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Version"]/*' />
        [NativeTypeName("WORD")]
        public ushort Version;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Machine"]/*' />
        [NativeTypeName("WORD")]
        public ushort Machine;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.TimeDateStamp"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.ClassID"]/*' />
        [NativeTypeName("CLSID")]
        public Guid ClassID;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.SizeOfData"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfData;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.MetaDataSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint MetaDataSize;

        /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.MetaDataOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint MetaDataOffset;
    }
}

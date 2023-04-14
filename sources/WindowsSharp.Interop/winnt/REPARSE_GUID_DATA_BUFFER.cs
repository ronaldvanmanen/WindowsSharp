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

using System;

namespace WindowsSharp.Interop
{
    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER"]/*' />
    public partial struct REPARSE_GUID_DATA_BUFFER
    {
        /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseTag"]/*' />
        [NativeTypeName("DWORD")]
        public uint ReparseTag;

        /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseDataLength"]/*' />
        [NativeTypeName("WORD")]
        public ushort ReparseDataLength;

        /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.Reserved"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved;

        /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseGuid"]/*' />
        public Guid ReparseGuid;

        /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.GenericReparseBuffer"]/*' />
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:13453:5)")]
        public _GenericReparseBuffer_e__Struct GenericReparseBuffer;

        /// <include file='_GenericReparseBuffer_e__Struct.xml' path='doc/member[@name="_GenericReparseBuffer_e__Struct"]/*' />
        public unsafe partial struct _GenericReparseBuffer_e__Struct
        {
            /// <include file='_GenericReparseBuffer_e__Struct.xml' path='doc/member[@name="_GenericReparseBuffer_e__Struct.DataBuffer"]/*' />
            [NativeTypeName("BYTE [1]")]
            public fixed byte DataBuffer[1];
        }
    }
}

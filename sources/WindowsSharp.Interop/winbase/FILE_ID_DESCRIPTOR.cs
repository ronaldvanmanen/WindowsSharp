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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR"]/*' />
    public partial struct FILE_ID_DESCRIPTOR
    {
        /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.dwSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwSize;

        /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.Type"]/*' />
        public FILE_ID_TYPE Type;

        /// <include file='FILE_ID_DESCRIPTOR.xml' path='doc/member[@name="FILE_ID_DESCRIPTOR.Anonymous"]/*' />
        [NativeTypeName("FILE_ID_DESCRIPTOR::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:9139:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FileId"]/*' />
        public ref LARGE_INTEGER FileId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FileId, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ObjectId"]/*' />
        public ref Guid ObjectId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ObjectId, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedFileId"]/*' />
        public ref FILE_ID_128 ExtendedFileId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ExtendedFileId, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FileId"]/*' />
            [FieldOffset(0)]
            public LARGE_INTEGER FileId;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ObjectId"]/*' />
            [FieldOffset(0)]
            public Guid ObjectId;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedFileId"]/*' />
            [FieldOffset(0)]
            public FILE_ID_128 ExtendedFileId;
        }
    }
}

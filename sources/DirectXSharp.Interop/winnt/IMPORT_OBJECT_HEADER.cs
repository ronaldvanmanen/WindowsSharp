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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER"]/*' />
    public partial struct IMPORT_OBJECT_HEADER
    {
        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Sig1"]/*' />
        [NativeTypeName("WORD")]
        public ushort Sig1;

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Sig2"]/*' />
        [NativeTypeName("WORD")]
        public ushort Sig2;

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Version"]/*' />
        [NativeTypeName("WORD")]
        public ushort Version;

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Machine"]/*' />
        [NativeTypeName("WORD")]
        public ushort Machine;

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.TimeDateStamp"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.SizeOfData"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfData;

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Anonymous"]/*' />
        [NativeTypeName("IMPORT_OBJECT_HEADER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:19177:5)")]
        public _Anonymous_e__Union Anonymous;

        public ushort _bitfield;

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Type"]/*' />
        [NativeTypeName("WORD : 2")]
        public ushort Type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)(_bitfield & 0x3u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~0x3u) | (value & 0x3u));
            }
        }

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.NameType"]/*' />
        [NativeTypeName("WORD : 3")]
        public ushort NameType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)((_bitfield >> 2) & 0x7u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x7u << 2)) | ((value & 0x7u) << 2));
            }
        }

        /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Reserved"]/*' />
        [NativeTypeName("WORD : 11")]
        public ushort Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)((_bitfield >> 5) & 0x7FFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x7FFu << 5)) | ((value & 0x7FFu) << 5));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Ordinal"]/*' />
        public ref ushort Ordinal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Ordinal, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Hint"]/*' />
        public ref ushort Hint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Hint, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Ordinal"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort Ordinal;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Hint"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort Hint;
        }
    }
}

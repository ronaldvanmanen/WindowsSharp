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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='SLIST_HEADER.xml' path='doc/member[@name="SLIST_HEADER"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct SLIST_HEADER
    {
        /// <include file='SLIST_HEADER.xml' path='doc/member[@name="SLIST_HEADER.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_SLIST_HEADER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:19918:5)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='SLIST_HEADER.xml' path='doc/member[@name="SLIST_HEADER.HeaderX64"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:19922:5)")]
        public _HeaderX64_e__Struct HeaderX64;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Alignment"]/*' />
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Alignment, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Region"]/*' />
        public ref ulong Region
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Region, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Alignment"]/*' />
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Region"]/*' />
            [NativeTypeName("ULONGLONG")]
            public ulong Region;
        }

        /// <include file='_HeaderX64_e__Struct.xml' path='doc/member[@name="_HeaderX64_e__Struct"]/*' />
        public partial struct _HeaderX64_e__Struct
        {
            public ulong _bitfield1;

            /// <include file='_HeaderX64_e__Struct.xml' path='doc/member[@name="_HeaderX64_e__Struct.Depth"]/*' />
            [NativeTypeName("ULONGLONG : 16")]
            public ulong Depth
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield1 & 0xFFFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield1 = (_bitfield1 & ~0xFFFFUL) | (value & 0xFFFFUL);
                }
            }

            /// <include file='_HeaderX64_e__Struct.xml' path='doc/member[@name="_HeaderX64_e__Struct.Sequence"]/*' />
            [NativeTypeName("ULONGLONG : 48")]
            public ulong Sequence
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield1 >> 16) & 0xFFFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield1 = (_bitfield1 & ~(0xFFFFUL << 16)) | ((value & 0xFFFFUL) << 16);
                }
            }

            public ulong _bitfield2;

            /// <include file='_HeaderX64_e__Struct.xml' path='doc/member[@name="_HeaderX64_e__Struct.Reserved"]/*' />
            [NativeTypeName("ULONGLONG : 4")]
            public ulong Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield2 & 0xFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield2 = (_bitfield2 & ~0xFUL) | (value & 0xFUL);
                }
            }

            /// <include file='_HeaderX64_e__Struct.xml' path='doc/member[@name="_HeaderX64_e__Struct.NextEntry"]/*' />
            [NativeTypeName("ULONGLONG : 60")]
            public ulong NextEntry
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield2 >> 4) & 0xFFFFFFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield2 = (_bitfield2 & ~(0xFFFFFFFUL << 4)) | ((value & 0xFFFFFFFUL) << 4);
                }
            }
        }
    }
}

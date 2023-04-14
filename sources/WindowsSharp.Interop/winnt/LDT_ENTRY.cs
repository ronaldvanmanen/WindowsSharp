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
    /// <include file='LDT_ENTRY.xml' path='doc/member[@name="LDT_ENTRY"]/*' />
    public partial struct LDT_ENTRY
    {
        /// <include file='LDT_ENTRY.xml' path='doc/member[@name="LDT_ENTRY.LimitLow"]/*' />
        [NativeTypeName("WORD")]
        public ushort LimitLow;

        /// <include file='LDT_ENTRY.xml' path='doc/member[@name="LDT_ENTRY.BaseLow"]/*' />
        [NativeTypeName("WORD")]
        public ushort BaseLow;

        /// <include file='LDT_ENTRY.xml' path='doc/member[@name="LDT_ENTRY.HighWord"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:7724:5)")]
        public _HighWord_e__Union HighWord;

        /// <include file='_HighWord_e__Union.xml' path='doc/member[@name="_HighWord_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _HighWord_e__Union
        {
            /// <include file='_HighWord_e__Union.xml' path='doc/member[@name="_HighWord_e__Union.Bytes"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:7725:9)")]
            public _Bytes_e__Struct Bytes;

            /// <include file='_HighWord_e__Union.xml' path='doc/member[@name="_HighWord_e__Union.Bits"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:7731:9)")]
            public _Bits_e__Struct Bits;

            /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct"]/*' />
            public partial struct _Bytes_e__Struct
            {
                /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct.BaseMid"]/*' />
                public byte BaseMid;

                /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct.Flags1"]/*' />
                public byte Flags1;

                /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct.Flags2"]/*' />
                public byte Flags2;

                /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct.BaseHi"]/*' />
                public byte BaseHi;
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct"]/*' />
            public partial struct _Bits_e__Struct
            {
                public uint _bitfield;

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.BaseMid"]/*' />
                [NativeTypeName("DWORD : 8")]
                public uint BaseMid
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0xFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Type"]/*' />
                [NativeTypeName("DWORD : 5")]
                public uint Type
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 8) & 0x1Fu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1Fu << 8)) | ((value & 0x1Fu) << 8);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Dpl"]/*' />
                [NativeTypeName("DWORD : 2")]
                public uint Dpl
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 13) & 0x3u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x3u << 13)) | ((value & 0x3u) << 13);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Pres"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint Pres
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 15) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.LimitHi"]/*' />
                [NativeTypeName("DWORD : 4")]
                public uint LimitHi
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 16) & 0xFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFu << 16)) | ((value & 0xFu) << 16);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Sys"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint Sys
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 20) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Reserved_0"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint Reserved_0
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 21) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Default_Big"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint Default_Big
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 22) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Granularity"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint Granularity
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 23) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23);
                    }
                }

                /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.BaseHi"]/*' />
                [NativeTypeName("DWORD : 8")]
                public uint BaseHi
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 24) & 0xFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
                    }
                }
            }
        }
    }
}

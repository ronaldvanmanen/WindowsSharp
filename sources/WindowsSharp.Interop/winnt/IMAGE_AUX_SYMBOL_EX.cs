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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct IMAGE_AUX_SYMBOL_EX
    {
        /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Sym"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17616:5)")]
        public _Sym_e__Struct Sym;

        /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.File"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17621:5)")]
        public _File_e__Struct File;

        /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Section"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17624:5)")]
        public _Section_e__Struct Section;

        /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_IMAGE_AUX_SYMBOL_EX::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17635:5)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.CRC"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17639:5)")]
        public _CRC_e__Struct CRC;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.TokenDef"]/*' />
        public ref IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.TokenDef, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.rgbReserved"]/*' />
        public Span<byte> rgbReserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.rgbReserved[0], 2);
            }
        }

        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public unsafe partial struct _Sym_e__Struct
        {
            /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.WeakDefaultSymIndex"]/*' />
            [NativeTypeName("DWORD")]
            public uint WeakDefaultSymIndex;

            /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.WeakSearchType"]/*' />
            [NativeTypeName("DWORD")]
            public uint WeakSearchType;

            /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.rgbReserved"]/*' />
            [NativeTypeName("BYTE [12]")]
            public fixed byte rgbReserved[12];
        }

        /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct"]/*' />
        public unsafe partial struct _File_e__Struct
        {
            /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct.Name"]/*' />
            [NativeTypeName("BYTE [20]")]
            public fixed byte Name[20];
        }

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public unsafe partial struct _Section_e__Struct
        {
            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Length"]/*' />
            [NativeTypeName("DWORD")]
            public uint Length;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.NumberOfRelocations"]/*' />
            [NativeTypeName("WORD")]
            public ushort NumberOfRelocations;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.NumberOfLinenumbers"]/*' />
            [NativeTypeName("WORD")]
            public ushort NumberOfLinenumbers;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.CheckSum"]/*' />
            [NativeTypeName("DWORD")]
            public uint CheckSum;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Number"]/*' />
            public short Number;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Selection"]/*' />
            public byte Selection;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.bReserved"]/*' />
            public byte bReserved;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.HighNumber"]/*' />
            public short HighNumber;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.rgbReserved"]/*' />
            [NativeTypeName("BYTE [2]")]
            public fixed byte rgbReserved[2];
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public unsafe partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.TokenDef"]/*' />
            public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.rgbReserved"]/*' />
            [NativeTypeName("BYTE [2]")]
            public fixed byte rgbReserved[2];
        }

        /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public unsafe partial struct _CRC_e__Struct
        {
            /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.crc"]/*' />
            [NativeTypeName("DWORD")]
            public uint crc;

            /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.rgbReserved"]/*' />
            [NativeTypeName("BYTE [16]")]
            public fixed byte rgbReserved[16];
        }
    }
}

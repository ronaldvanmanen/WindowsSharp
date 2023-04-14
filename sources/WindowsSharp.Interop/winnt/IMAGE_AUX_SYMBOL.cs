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

using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct IMAGE_AUX_SYMBOL
    {
        /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.Sym"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17574:5)")]
        public _Sym_e__Struct Sym;

        /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.File"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17594:5)")]
        public _File_e__Struct File;

        /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.Section"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17597:5)")]
        public _Section_e__Struct Section;

        /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.TokenDef"]/*' />
        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

        /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.CRC"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17608:5)")]
        public _CRC_e__Struct CRC;

        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public partial struct _Sym_e__Struct
        {
            /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.TagIndex"]/*' />
            [NativeTypeName("DWORD")]
            public uint TagIndex;

            /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.Misc"]/*' />
            [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17576:9)")]
            public _Misc_e__Union Misc;

            /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.FcnAry"]/*' />
            [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17583:9)")]
            public _FcnAry_e__Union FcnAry;

            /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.TvIndex"]/*' />
            [NativeTypeName("WORD")]
            public ushort TvIndex;

            /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union"]/*' />
            [StructLayout(LayoutKind.Explicit, Pack = 2)]
            public partial struct _Misc_e__Union
            {
                /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union.LnSz"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17577:13)")]
                public _LnSz_e__Struct LnSz;

                /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union.TotalSize"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("DWORD")]
                public uint TotalSize;

                /// <include file='_LnSz_e__Struct.xml' path='doc/member[@name="_LnSz_e__Struct"]/*' />
                public partial struct _LnSz_e__Struct
                {
                    /// <include file='_LnSz_e__Struct.xml' path='doc/member[@name="_LnSz_e__Struct.Linenumber"]/*' />
                    [NativeTypeName("WORD")]
                    public ushort Linenumber;

                    /// <include file='_LnSz_e__Struct.xml' path='doc/member[@name="_LnSz_e__Struct.Size"]/*' />
                    [NativeTypeName("WORD")]
                    public ushort Size;
                }
            }

            /// <include file='_FcnAry_e__Union.xml' path='doc/member[@name="_FcnAry_e__Union"]/*' />
            [StructLayout(LayoutKind.Explicit)]
            public partial struct _FcnAry_e__Union
            {
                /// <include file='_FcnAry_e__Union.xml' path='doc/member[@name="_FcnAry_e__Union.Function"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17584:13)")]
                public _Function_e__Struct Function;

                /// <include file='_FcnAry_e__Union.xml' path='doc/member[@name="_FcnAry_e__Union.Array"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17588:13)")]
                public _Array_e__Struct Array;

                /// <include file='_Function_e__Struct.xml' path='doc/member[@name="_Function_e__Struct"]/*' />
                [StructLayout(LayoutKind.Sequential, Pack = 2)]
                public partial struct _Function_e__Struct
                {
                    /// <include file='_Function_e__Struct.xml' path='doc/member[@name="_Function_e__Struct.PointerToLinenumber"]/*' />
                    [NativeTypeName("DWORD")]
                    public uint PointerToLinenumber;

                    /// <include file='_Function_e__Struct.xml' path='doc/member[@name="_Function_e__Struct.PointerToNextFunction"]/*' />
                    [NativeTypeName("DWORD")]
                    public uint PointerToNextFunction;
                }

                /// <include file='_Array_e__Struct.xml' path='doc/member[@name="_Array_e__Struct"]/*' />
                public unsafe partial struct _Array_e__Struct
                {
                    /// <include file='_Array_e__Struct.xml' path='doc/member[@name="_Array_e__Struct.Dimension"]/*' />
                    [NativeTypeName("WORD [4]")]
                    public fixed ushort Dimension[4];
                }
            }
        }

        /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct"]/*' />
        public unsafe partial struct _File_e__Struct
        {
            /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct.Name"]/*' />
            [NativeTypeName("BYTE [18]")]
            public fixed byte Name[18];
        }

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public partial struct _Section_e__Struct
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
        }

        /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public unsafe partial struct _CRC_e__Struct
        {
            /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.crc"]/*' />
            [NativeTypeName("DWORD")]
            public uint crc;

            /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.rgbReserved"]/*' />
            [NativeTypeName("BYTE [14]")]
            public fixed byte rgbReserved[14];
        }
    }
}

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
    /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct IMAGE_SYMBOL
    {
        /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.N"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17401:5)")]
        public _N_e__Union N;

        /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.Value"]/*' />
        [NativeTypeName("DWORD")]
        public uint Value;

        /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.SectionNumber"]/*' />
        public short SectionNumber;

        /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.Type"]/*' />
        [NativeTypeName("WORD")]
        public ushort Type;

        /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.StorageClass"]/*' />
        public byte StorageClass;

        /// <include file='IMAGE_SYMBOL.xml' path='doc/member[@name="IMAGE_SYMBOL.NumberOfAuxSymbols"]/*' />
        public byte NumberOfAuxSymbols;

        /// <include file='_N_e__Union.xml' path='doc/member[@name="_N_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit, Pack = 2)]
        public unsafe partial struct _N_e__Union
        {
            /// <include file='_N_e__Union.xml' path='doc/member[@name="_N_e__Union.ShortName"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("BYTE [8]")]
            public fixed byte ShortName[8];

            /// <include file='_N_e__Union.xml' path='doc/member[@name="_N_e__Union.Name"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17403:9)")]
            public _Name_e__Struct Name;

            /// <include file='_N_e__Union.xml' path='doc/member[@name="_N_e__Union.LongName"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD [2]")]
            public fixed uint LongName[2];

            /// <include file='_Name_e__Struct.xml' path='doc/member[@name="_Name_e__Struct"]/*' />
            [StructLayout(LayoutKind.Sequential, Pack = 2)]
            public partial struct _Name_e__Struct
            {
                /// <include file='_Name_e__Struct.xml' path='doc/member[@name="_Name_e__Struct.Short"]/*' />
                [NativeTypeName("DWORD")]
                public uint Short;

                /// <include file='_Name_e__Struct.xml' path='doc/member[@name="_Name_e__Struct.Long"]/*' />
                [NativeTypeName("DWORD")]
                public uint Long;
            }
        }
    }
}

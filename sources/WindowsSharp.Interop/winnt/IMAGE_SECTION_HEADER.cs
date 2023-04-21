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
    /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER"]/*' />
    public unsafe partial struct IMAGE_SECTION_HEADER
    {
        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.Name"]/*' />
        [NativeTypeName("BYTE [8]")]
        public fixed byte Name[8];

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.Misc"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17315:5)")]
        public _Misc_e__Union Misc;

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.VirtualAddress"]/*' />
        [NativeTypeName("DWORD")]
        public uint VirtualAddress;

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.SizeOfRawData"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfRawData;

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.PointerToRawData"]/*' />
        [NativeTypeName("DWORD")]
        public uint PointerToRawData;

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.PointerToRelocations"]/*' />
        [NativeTypeName("DWORD")]
        public uint PointerToRelocations;

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.PointerToLinenumbers"]/*' />
        [NativeTypeName("DWORD")]
        public uint PointerToLinenumbers;

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.NumberOfRelocations"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfRelocations;

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.NumberOfLinenumbers"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfLinenumbers;

        /// <include file='IMAGE_SECTION_HEADER.xml' path='doc/member[@name="IMAGE_SECTION_HEADER.Characteristics"]/*' />
        [NativeTypeName("DWORD")]
        public uint Characteristics;

        /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Misc_e__Union
        {
            /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union.PhysicalAddress"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint PhysicalAddress;

            /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union.VirtualSize"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint VirtualSize;
        }
    }
}

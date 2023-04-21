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
    /// <include file='IMAGE_LINENUMBER.xml' path='doc/member[@name="IMAGE_LINENUMBER"]/*' />
    public partial struct IMAGE_LINENUMBER
    {
        /// <include file='IMAGE_LINENUMBER.xml' path='doc/member[@name="IMAGE_LINENUMBER.Type"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18086:5)")]
        public _Type_e__Union Type;

        /// <include file='IMAGE_LINENUMBER.xml' path='doc/member[@name="IMAGE_LINENUMBER.Linenumber"]/*' />
        [NativeTypeName("WORD")]
        public ushort Linenumber;

        /// <include file='_Type_e__Union.xml' path='doc/member[@name="_Type_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit, Pack = 2)]
        public partial struct _Type_e__Union
        {
            /// <include file='_Type_e__Union.xml' path='doc/member[@name="_Type_e__Union.SymbolTableIndex"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint SymbolTableIndex;

            /// <include file='_Type_e__Union.xml' path='doc/member[@name="_Type_e__Union.VirtualAddress"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint VirtualAddress;
        }
    }
}

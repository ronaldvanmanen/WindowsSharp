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
    /// <include file='IMAGE_RELOCATION.xml' path='doc/member[@name="IMAGE_RELOCATION"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct IMAGE_RELOCATION
    {
        /// <include file='IMAGE_RELOCATION.xml' path='doc/member[@name="IMAGE_RELOCATION.Anonymous"]/*' />
        [NativeTypeName("_IMAGE_RELOCATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17673:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='IMAGE_RELOCATION.xml' path='doc/member[@name="IMAGE_RELOCATION.SymbolTableIndex"]/*' />
        [NativeTypeName("DWORD")]
        public uint SymbolTableIndex;

        /// <include file='IMAGE_RELOCATION.xml' path='doc/member[@name="IMAGE_RELOCATION.Type"]/*' />
        [NativeTypeName("WORD")]
        public ushort Type;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VirtualAddress"]/*' />
        public ref uint VirtualAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.VirtualAddress, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RelocCount"]/*' />
        public ref uint RelocCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.RelocCount, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit, Pack = 2)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VirtualAddress"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint VirtualAddress;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RelocCount"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint RelocCount;
        }
    }
}

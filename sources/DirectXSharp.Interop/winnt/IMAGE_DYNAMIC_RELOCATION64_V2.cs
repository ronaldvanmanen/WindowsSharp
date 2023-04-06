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

using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='IMAGE_DYNAMIC_RELOCATION64_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64_V2"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct IMAGE_DYNAMIC_RELOCATION64_V2
    {
        /// <include file='IMAGE_DYNAMIC_RELOCATION64_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64_V2.HeaderSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint HeaderSize;

        /// <include file='IMAGE_DYNAMIC_RELOCATION64_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64_V2.FixupInfoSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint FixupInfoSize;

        /// <include file='IMAGE_DYNAMIC_RELOCATION64_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64_V2.Symbol"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong Symbol;

        /// <include file='IMAGE_DYNAMIC_RELOCATION64_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64_V2.SymbolGroup"]/*' />
        [NativeTypeName("DWORD")]
        public uint SymbolGroup;

        /// <include file='IMAGE_DYNAMIC_RELOCATION64_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION64_V2.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}

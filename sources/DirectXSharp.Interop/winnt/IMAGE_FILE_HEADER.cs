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

namespace DirectXSharp.Interop
{
    /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER"]/*' />
    public partial struct IMAGE_FILE_HEADER
    {
        /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.Machine"]/*' />
        [NativeTypeName("WORD")]
        public ushort Machine;

        /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.NumberOfSections"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfSections;

        /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.TimeDateStamp"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.PointerToSymbolTable"]/*' />
        [NativeTypeName("DWORD")]
        public uint PointerToSymbolTable;

        /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.NumberOfSymbols"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfSymbols;

        /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.SizeOfOptionalHeader"]/*' />
        [NativeTypeName("WORD")]
        public ushort SizeOfOptionalHeader;

        /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.Characteristics"]/*' />
        [NativeTypeName("WORD")]
        public ushort Characteristics;
    }
}
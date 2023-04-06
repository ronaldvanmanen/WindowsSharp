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
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER"]/*' />
    public unsafe partial struct IMAGE_ROM_OPTIONAL_HEADER
    {
        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.Magic"]/*' />
        [NativeTypeName("WORD")]
        public ushort Magic;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.MajorLinkerVersion"]/*' />
        public byte MajorLinkerVersion;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.MinorLinkerVersion"]/*' />
        public byte MinorLinkerVersion;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.SizeOfCode"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfCode;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.SizeOfInitializedData"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfInitializedData;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.SizeOfUninitializedData"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfUninitializedData;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.AddressOfEntryPoint"]/*' />
        [NativeTypeName("DWORD")]
        public uint AddressOfEntryPoint;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.BaseOfCode"]/*' />
        [NativeTypeName("DWORD")]
        public uint BaseOfCode;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.BaseOfData"]/*' />
        [NativeTypeName("DWORD")]
        public uint BaseOfData;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.BaseOfBss"]/*' />
        [NativeTypeName("DWORD")]
        public uint BaseOfBss;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.GprMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint GprMask;

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.CprMask"]/*' />
        [NativeTypeName("DWORD [4]")]
        public fixed uint CprMask[4];

        /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.GpValue"]/*' />
        [NativeTypeName("DWORD")]
        public uint GpValue;
    }
}
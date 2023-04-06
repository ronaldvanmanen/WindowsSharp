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
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT"]/*' />
    public unsafe partial struct IMAGE_ENCLAVE_IMPORT
    {
        /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.MatchType"]/*' />
        [NativeTypeName("DWORD")]
        public uint MatchType;

        /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.MinimumSecurityVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint MinimumSecurityVersion;

        /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.UniqueOrAuthorID"]/*' />
        [NativeTypeName("BYTE [32]")]
        public fixed byte UniqueOrAuthorID[32];

        /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.FamilyID"]/*' />
        [NativeTypeName("BYTE [16]")]
        public fixed byte FamilyID[16];

        /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.ImageID"]/*' />
        [NativeTypeName("BYTE [16]")]
        public fixed byte ImageID[16];

        /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.ImportName"]/*' />
        [NativeTypeName("DWORD")]
        public uint ImportName;

        /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.Reserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved;
    }
}

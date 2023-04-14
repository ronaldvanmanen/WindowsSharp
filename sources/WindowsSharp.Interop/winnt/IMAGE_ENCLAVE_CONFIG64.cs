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
    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe partial struct IMAGE_ENCLAVE_CONFIG64
    {
        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.MinimumRequiredConfigSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint MinimumRequiredConfigSize;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.PolicyFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint PolicyFlags;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.NumberOfImports"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfImports;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.ImportList"]/*' />
        [NativeTypeName("DWORD")]
        public uint ImportList;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.ImportEntrySize"]/*' />
        [NativeTypeName("DWORD")]
        public uint ImportEntrySize;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.FamilyID"]/*' />
        [NativeTypeName("BYTE [16]")]
        public fixed byte FamilyID[16];

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.ImageID"]/*' />
        [NativeTypeName("BYTE [16]")]
        public fixed byte ImageID[16];

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.ImageVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint ImageVersion;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.SecurityVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint SecurityVersion;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.EnclaveSize"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong EnclaveSize;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.NumberOfThreads"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfThreads;

        /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.EnclaveFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint EnclaveFlags;
    }
}

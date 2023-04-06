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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC"]/*' />
    public unsafe partial struct ENCLAVE_INIT_INFO_VBS_BASIC
    {
        /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.FamilyId"]/*' />
        [NativeTypeName("BYTE [16]")]
        public fixed byte FamilyId[16];

        /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.ImageId"]/*' />
        [NativeTypeName("BYTE [16]")]
        public fixed byte ImageId[16];

        /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.EnclaveSize"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong EnclaveSize;

        /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.EnclaveSvn"]/*' />
        [NativeTypeName("DWORD")]
        public uint EnclaveSvn;

        /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.Reserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved;

        /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.Anonymous"]/*' />
        [NativeTypeName("_ENCLAVE_INIT_INFO_VBS_BASIC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:13169:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SignatureInfoHandle"]/*' />
        public ref void* SignatureInfoHandle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.SignatureInfoHandle;
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Unused"]/*' />
        public ref ulong Unused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Unused, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SignatureInfoHandle"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("HANDLE")]
            public void* SignatureInfoHandle;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Unused"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Unused;
        }
    }
}

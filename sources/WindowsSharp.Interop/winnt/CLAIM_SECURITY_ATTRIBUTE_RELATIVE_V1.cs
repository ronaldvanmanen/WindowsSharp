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
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1"]/*' />
    public partial struct CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1
    {
        /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Name"]/*' />
        [NativeTypeName("DWORD")]
        public uint Name;

        /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.ValueType"]/*' />
        [NativeTypeName("WORD")]
        public ushort ValueType;

        /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Reserved"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved;

        /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.ValueCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint ValueCount;

        /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Values"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11241:5)")]
        public _Values_e__Union Values;

        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Values_e__Union
        {
            /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pInt64"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint pInt64[1];

            /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pUint64"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint pUint64[1];

            /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.ppString"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint ppString[1];

            /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pFqbn"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint pFqbn[1];

            /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pOctetString"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint pOctetString[1];
        }
    }
}

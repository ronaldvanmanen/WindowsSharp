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
    /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION"]/*' />
    public partial struct CLAIM_SECURITY_ATTRIBUTES_INFORMATION
    {
        /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION.Version"]/*' />
        [NativeTypeName("WORD")]
        public ushort Version;

        /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION.Reserved"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved;

        /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION.AttributeCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint AttributeCount;

        /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION.Attribute"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11285:5)")]
        public _Attribute_e__Union Attribute;

        /// <include file='_Attribute_e__Union.xml' path='doc/member[@name="_Attribute_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Attribute_e__Union
        {
            /// <include file='_Attribute_e__Union.xml' path='doc/member[@name="_Attribute_e__Union.pAttributeV1"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTE_V1")]
            public CLAIM_SECURITY_ATTRIBUTE_V1* pAttributeV1;
        }
    }
}

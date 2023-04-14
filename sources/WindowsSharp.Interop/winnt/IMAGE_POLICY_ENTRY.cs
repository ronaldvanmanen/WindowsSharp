// WindowsSharp
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

namespace WindowsSharp.Interop
{
    /// <include file='IMAGE_POLICY_ENTRY.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY"]/*' />
    public partial struct IMAGE_POLICY_ENTRY
    {
        /// <include file='IMAGE_POLICY_ENTRY.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY.Type"]/*' />
        public IMAGE_POLICY_ENTRY_TYPE Type;

        /// <include file='IMAGE_POLICY_ENTRY.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY.PolicyId"]/*' />
        public IMAGE_POLICY_ID PolicyId;

        /// <include file='IMAGE_POLICY_ENTRY.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY.u"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:21032:5)")]
        public _u_e__Union u;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.None"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("const void *")]
            public void* None;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.BoolValue"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("BOOLEAN")]
            public byte BoolValue;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Int8Value"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("INT8")]
            public sbyte Int8Value;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UInt8Value"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("UINT8")]
            public byte UInt8Value;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Int16Value"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("INT16")]
            public short Int16Value;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UInt16Value"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("UINT16")]
            public ushort UInt16Value;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Int32Value"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("INT32")]
            public int Int32Value;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UInt32Value"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint UInt32Value;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Int64Value"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("INT64")]
            public long Int64Value;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UInt64Value"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("UINT64")]
            public ulong UInt64Value;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.AnsiStringValue"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("PCSTR")]
            public sbyte* AnsiStringValue;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UnicodeStringValue"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("PCWSTR")]
            public ushort* UnicodeStringValue;
        }
    }
}

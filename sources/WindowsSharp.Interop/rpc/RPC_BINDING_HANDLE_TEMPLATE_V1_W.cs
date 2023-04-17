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

using System;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W"]/*' />
    public unsafe partial struct RPC_BINDING_HANDLE_TEMPLATE_V1_W
    {
        /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.Version"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Version;

        /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.Flags"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Flags;

        /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.ProtocolSequence"]/*' />
        [NativeTypeName("unsigned long")]
        public uint ProtocolSequence;

        /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.NetworkAddress"]/*' />
        [NativeTypeName("unsigned short *")]
        public ushort* NetworkAddress;

        /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.StringEndpoint"]/*' />
        [NativeTypeName("unsigned short *")]
        public ushort* StringEndpoint;

        /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.u1"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.19041.0/shared/rpcdce.h:2046:5)")]
        public _u1_e__Union u1;

        /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.ObjectUuid"]/*' />
        [NativeTypeName("UUID")]
        public Guid ObjectUuid;

        /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u1_e__Union
        {
            /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union.Reserved"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("unsigned short *")]
            public ushort* Reserved;
        }
    }
}

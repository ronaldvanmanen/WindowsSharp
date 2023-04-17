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
    /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W"]/*' />
    public unsafe partial struct RPC_SECURITY_QOS_V5_W
    {
        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.Version"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Version;

        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.Capabilities"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Capabilities;

        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.IdentityTracking"]/*' />
        [NativeTypeName("unsigned long")]
        public uint IdentityTracking;

        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.ImpersonationType"]/*' />
        [NativeTypeName("unsigned long")]
        public uint ImpersonationType;

        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.AdditionalSecurityInfoType"]/*' />
        [NativeTypeName("unsigned long")]
        public uint AdditionalSecurityInfoType;

        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.u"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.19041.0/shared/rpcdce.h:1901:3)")]
        public _u_e__Union u;

        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.Sid"]/*' />
        public void* Sid;

        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.EffectiveOnly"]/*' />
        [NativeTypeName("unsigned int")]
        public uint EffectiveOnly;

        /// <include file='RPC_SECURITY_QOS_V5_W.xml' path='doc/member[@name="RPC_SECURITY_QOS_V5_W.ServerSecurityDescriptor"]/*' />
        public void* ServerSecurityDescriptor;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.HttpCredentials"]/*' />
            [FieldOffset(0)]
            public RPC_HTTP_TRANSPORT_CREDENTIALS_W* HttpCredentials;
        }
    }
}

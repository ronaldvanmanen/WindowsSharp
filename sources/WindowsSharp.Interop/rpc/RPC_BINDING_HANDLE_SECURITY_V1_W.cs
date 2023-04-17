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

namespace WindowsSharp.Interop
{
    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W"]/*' />
    public unsafe partial struct RPC_BINDING_HANDLE_SECURITY_V1_W
    {
        /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.Version"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Version;

        /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.ServerPrincName"]/*' />
        [NativeTypeName("unsigned short *")]
        public ushort* ServerPrincName;

        /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.AuthnLevel"]/*' />
        [NativeTypeName("unsigned long")]
        public uint AuthnLevel;

        /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.AuthnSvc"]/*' />
        [NativeTypeName("unsigned long")]
        public uint AuthnSvc;

        /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.AuthIdentity"]/*' />
        public SEC_WINNT_AUTH_IDENTITY_W* AuthIdentity;

        /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.SecurityQos"]/*' />
        public RPC_SECURITY_QOS* SecurityQos;
    }
}

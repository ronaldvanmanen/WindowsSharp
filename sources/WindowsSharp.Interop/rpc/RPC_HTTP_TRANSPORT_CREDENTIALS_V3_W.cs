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
    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W"]/*' />
    public unsafe partial struct RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W
    {
        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.TransportCredentials"]/*' />
        [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")]
        public void* TransportCredentials;

        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.Flags"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Flags;

        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.AuthenticationTarget"]/*' />
        [NativeTypeName("unsigned long")]
        public uint AuthenticationTarget;

        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.NumberOfAuthnSchemes"]/*' />
        [NativeTypeName("unsigned long")]
        public uint NumberOfAuthnSchemes;

        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.AuthnSchemes"]/*' />
        [NativeTypeName("unsigned long *")]
        public uint* AuthnSchemes;

        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.ServerCertificateSubject"]/*' />
        [NativeTypeName("unsigned short *")]
        public ushort* ServerCertificateSubject;

        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.ProxyCredentials"]/*' />
        [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")]
        public void* ProxyCredentials;

        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.NumberOfProxyAuthnSchemes"]/*' />
        [NativeTypeName("unsigned long")]
        public uint NumberOfProxyAuthnSchemes;

        /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V3_W.ProxyAuthnSchemes"]/*' />
        [NativeTypeName("unsigned long *")]
        public uint* ProxyAuthnSchemes;
    }
}
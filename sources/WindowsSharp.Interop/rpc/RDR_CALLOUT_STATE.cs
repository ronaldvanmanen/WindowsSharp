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

namespace WindowsSharp.Interop
{
    /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE"]/*' />
    public unsafe partial struct RDR_CALLOUT_STATE
    {
        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.LastError"]/*' />
        [NativeTypeName("RPC_STATUS")]
        public int LastError;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.LastEEInfo"]/*' />
        public void* LastEEInfo;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.LastCalledStage"]/*' />
        public RPC_HTTP_REDIRECTOR_STAGE LastCalledStage;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.ServerName"]/*' />
        [NativeTypeName("unsigned short *")]
        public ushort* ServerName;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.ServerPort"]/*' />
        [NativeTypeName("unsigned short *")]
        public ushort* ServerPort;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.RemoteUser"]/*' />
        [NativeTypeName("unsigned short *")]
        public ushort* RemoteUser;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.AuthType"]/*' />
        [NativeTypeName("unsigned short *")]
        public ushort* AuthType;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.ResourceTypePresent"]/*' />
        [NativeTypeName("unsigned char")]
        public byte ResourceTypePresent;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.SessionIdPresent"]/*' />
        [NativeTypeName("unsigned char")]
        public byte SessionIdPresent;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.InterfacePresent"]/*' />
        [NativeTypeName("unsigned char")]
        public byte InterfacePresent;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.ResourceType"]/*' />
        [NativeTypeName("UUID")]
        public Guid ResourceType;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.SessionId"]/*' />
        [NativeTypeName("UUID")]
        public Guid SessionId;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.Interface"]/*' />
        public RPC_SYNTAX_IDENTIFIER Interface;

        /// <include file='RDR_CALLOUT_STATE.xml' path='doc/member[@name="RDR_CALLOUT_STATE.CertContext"]/*' />
        public void* CertContext;
    }
}

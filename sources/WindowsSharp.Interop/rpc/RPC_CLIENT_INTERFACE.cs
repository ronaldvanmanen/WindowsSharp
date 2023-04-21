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
    /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE"]/*' />
    public unsafe partial struct RPC_CLIENT_INTERFACE
    {
        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.Length"]/*' />
        [NativeTypeName("unsigned int")]
        public uint Length;

        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.InterfaceId"]/*' />
        public RPC_SYNTAX_IDENTIFIER InterfaceId;

        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.TransferSyntax"]/*' />
        public RPC_SYNTAX_IDENTIFIER TransferSyntax;

        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.DispatchTable"]/*' />
        [NativeTypeName("PRPC_DISPATCH_TABLE")]
        public RPC_DISPATCH_TABLE* DispatchTable;

        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.RpcProtseqEndpointCount"]/*' />
        [NativeTypeName("unsigned int")]
        public uint RpcProtseqEndpointCount;

        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.RpcProtseqEndpoint"]/*' />
        [NativeTypeName("PRPC_PROTSEQ_ENDPOINT")]
        public RPC_PROTSEQ_ENDPOINT* RpcProtseqEndpoint;

        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.Reserved"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong Reserved;

        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.InterpreterInfo"]/*' />
        [NativeTypeName("const void *")]
        public void* InterpreterInfo;

        /// <include file='RPC_CLIENT_INTERFACE.xml' path='doc/member[@name="RPC_CLIENT_INTERFACE.Flags"]/*' />
        [NativeTypeName("unsigned int")]
        public uint Flags;
    }
}

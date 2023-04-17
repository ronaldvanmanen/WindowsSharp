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
    /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE"]/*' />
    public unsafe partial struct RPC_MESSAGE
    {
        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.Handle"]/*' />
        [NativeTypeName("RPC_BINDING_HANDLE")]
        public void* Handle;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.DataRepresentation"]/*' />
        [NativeTypeName("unsigned long")]
        public uint DataRepresentation;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.Buffer"]/*' />
        public void* Buffer;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.BufferLength"]/*' />
        [NativeTypeName("unsigned int")]
        public uint BufferLength;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.ProcNum"]/*' />
        [NativeTypeName("unsigned int")]
        public uint ProcNum;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.TransferSyntax"]/*' />
        [NativeTypeName("PRPC_SYNTAX_IDENTIFIER")]
        public RPC_SYNTAX_IDENTIFIER* TransferSyntax;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.RpcInterfaceInformation"]/*' />
        public void* RpcInterfaceInformation;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.ReservedForRuntime"]/*' />
        public void* ReservedForRuntime;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.ManagerEpv"]/*' />
        public void* ManagerEpv;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.ImportContext"]/*' />
        public void* ImportContext;

        /// <include file='RPC_MESSAGE.xml' path='doc/member[@name="RPC_MESSAGE.RpcFlags"]/*' />
        [NativeTypeName("unsigned long")]
        public uint RpcFlags;
    }
}

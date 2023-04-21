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
    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW"]/*' />
    public unsafe partial struct RPC_INTERFACE_TEMPLATEW
    {
        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.Version"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Version;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.IfSpec"]/*' />
        [NativeTypeName("RPC_IF_HANDLE")]
        public void* IfSpec;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.MgrTypeUuid"]/*' />
        [NativeTypeName("UUID *")]
        public Guid* MgrTypeUuid;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.MgrEpv"]/*' />
        public void* MgrEpv;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.Flags"]/*' />
        [NativeTypeName("unsigned int")]
        public uint Flags;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.MaxCalls"]/*' />
        [NativeTypeName("unsigned int")]
        public uint MaxCalls;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.MaxRpcSize"]/*' />
        [NativeTypeName("unsigned int")]
        public uint MaxRpcSize;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.IfCallback"]/*' />
        [NativeTypeName("RPC_IF_CALLBACK_FN *")]
        public delegate* unmanaged<void*, void*, int> IfCallback;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.UuidVector"]/*' />
        public UUID_VECTOR* UuidVector;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.Annotation"]/*' />
        [NativeTypeName("RPC_WSTR")]
        public ushort* Annotation;

        /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.SecurityDescriptor"]/*' />
        public void* SecurityDescriptor;
    }
}

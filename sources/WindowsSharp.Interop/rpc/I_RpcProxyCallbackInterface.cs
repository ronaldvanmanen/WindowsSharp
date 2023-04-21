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
    /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface"]/*' />
    public unsafe partial struct I_RpcProxyCallbackInterface
    {
        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.IsValidMachineFn"]/*' />
        [NativeTypeName("I_RpcProxyIsValidMachineFn")]
        public delegate* unmanaged<ushort*, ushort*, uint, int> IsValidMachineFn;

        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.GetClientAddressFn"]/*' />
        [NativeTypeName("I_RpcProxyGetClientAddressFn")]
        public delegate* unmanaged<void*, sbyte*, uint*, int> GetClientAddressFn;

        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.GetConnectionTimeoutFn"]/*' />
        [NativeTypeName("I_RpcProxyGetConnectionTimeoutFn")]
        public delegate* unmanaged<uint*, int> GetConnectionTimeoutFn;

        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.PerformCalloutFn"]/*' />
        [NativeTypeName("I_RpcPerformCalloutFn")]
        public delegate* unmanaged<void*, RDR_CALLOUT_STATE*, RPC_HTTP_REDIRECTOR_STAGE, int> PerformCalloutFn;

        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.FreeCalloutStateFn"]/*' />
        [NativeTypeName("I_RpcFreeCalloutStateFn")]
        public delegate* unmanaged<RDR_CALLOUT_STATE*, void> FreeCalloutStateFn;

        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.GetClientSessionAndResourceUUIDFn"]/*' />
        [NativeTypeName("I_RpcProxyGetClientSessionAndResourceUUID")]
        public delegate* unmanaged<void*, int*, Guid*, int*, Guid*, int> GetClientSessionAndResourceUUIDFn;

        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.ProxyFilterIfFn"]/*' />
        [NativeTypeName("I_RpcProxyFilterIfFn")]
        public delegate* unmanaged<void*, Guid*, ushort, int*, int> ProxyFilterIfFn;

        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.RpcProxyUpdatePerfCounterFn"]/*' />
        [NativeTypeName("I_RpcProxyUpdatePerfCounterFn")]
        public delegate* unmanaged<RpcPerfCounters, int, uint, void> RpcProxyUpdatePerfCounterFn;

        /// <include file='I_RpcProxyCallbackInterface.xml' path='doc/member[@name="I_RpcProxyCallbackInterface.RpcProxyUpdatePerfCounterBackendServerFn"]/*' />
        [NativeTypeName("I_RpcProxyUpdatePerfCounterBackendServerFn")]
        public delegate* unmanaged<ushort*, int, void> RpcProxyUpdatePerfCounterBackendServerFn;
    }
}

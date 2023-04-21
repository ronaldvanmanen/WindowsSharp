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
    public static unsafe partial class NativeMethods
    {
        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingCopy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingCopy([NativeTypeName("RPC_BINDING_HANDLE")] void* SourceBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** DestinationBinding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingFree"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingFree([NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingSetOption"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingSetOption([NativeTypeName("RPC_BINDING_HANDLE")] void* hBinding, [NativeTypeName("unsigned long")] uint option, [NativeTypeName("ULONG_PTR")] ulong optionValue);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqOption"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqOption([NativeTypeName("RPC_BINDING_HANDLE")] void* hBinding, [NativeTypeName("unsigned long")] uint option, [NativeTypeName("ULONG_PTR *")] ulong* pOptionValue);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingFromStringBindingA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingFromStringBindingA([NativeTypeName("RPC_CSTR")] byte* StringBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingFromStringBindingW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingFromStringBindingW([NativeTypeName("RPC_WSTR")] ushort* StringBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcSsGetContextBinding"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcSsGetContextBinding(void* ContextHandle, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqObject"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqObject([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingReset"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingReset([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingSetObject"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingSetObject([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtInqDefaultProtectLevel"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtInqDefaultProtectLevel([NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthnLevel);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingToStringBindingA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingToStringBindingA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR *")] byte** StringBinding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingToStringBindingW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingToStringBindingW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR *")] ushort** StringBinding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingVectorFree"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingVectorFree(RPC_BINDING_VECTOR** BindingVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcStringBindingComposeA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcStringBindingComposeA([NativeTypeName("RPC_CSTR")] byte* ObjUuid, [NativeTypeName("RPC_CSTR")] byte* ProtSeq, [NativeTypeName("RPC_CSTR")] byte* NetworkAddr, [NativeTypeName("RPC_CSTR")] byte* Endpoint, [NativeTypeName("RPC_CSTR")] byte* Options, [NativeTypeName("RPC_CSTR *")] byte** StringBinding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcStringBindingComposeW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcStringBindingComposeW([NativeTypeName("RPC_WSTR")] ushort* ObjUuid, [NativeTypeName("RPC_WSTR")] ushort* ProtSeq, [NativeTypeName("RPC_WSTR")] ushort* NetworkAddr, [NativeTypeName("RPC_WSTR")] ushort* Endpoint, [NativeTypeName("RPC_WSTR")] ushort* Options, [NativeTypeName("RPC_WSTR *")] ushort** StringBinding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcStringBindingParseA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcStringBindingParseA([NativeTypeName("RPC_CSTR")] byte* StringBinding, [NativeTypeName("RPC_CSTR *")] byte** ObjUuid, [NativeTypeName("RPC_CSTR *")] byte** Protseq, [NativeTypeName("RPC_CSTR *")] byte** NetworkAddr, [NativeTypeName("RPC_CSTR *")] byte** Endpoint, [NativeTypeName("RPC_CSTR *")] byte** NetworkOptions);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcStringBindingParseW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcStringBindingParseW([NativeTypeName("RPC_WSTR")] ushort* StringBinding, [NativeTypeName("RPC_WSTR *")] ushort** ObjUuid, [NativeTypeName("RPC_WSTR *")] ushort** Protseq, [NativeTypeName("RPC_WSTR *")] ushort** NetworkAddr, [NativeTypeName("RPC_WSTR *")] ushort** Endpoint, [NativeTypeName("RPC_WSTR *")] ushort** NetworkOptions);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcStringFreeA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcStringFreeA([NativeTypeName("RPC_CSTR *")] byte** String);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcStringFreeW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcStringFreeW([NativeTypeName("RPC_WSTR *")] ushort** String);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcIfInqId"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcIfInqId([NativeTypeName("RPC_IF_HANDLE")] void* RpcIfHandle, RPC_IF_ID* RpcIfId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcNetworkIsProtseqValidA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcNetworkIsProtseqValidA([NativeTypeName("RPC_CSTR")] byte* Protseq);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcNetworkIsProtseqValidW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcNetworkIsProtseqValidW([NativeTypeName("RPC_WSTR")] ushort* Protseq);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtInqComTimeout"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtInqComTimeout([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned int *")] uint* Timeout);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtSetComTimeout"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtSetComTimeout([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned int")] uint Timeout);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtSetCancelTimeout"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtSetCancelTimeout([NativeTypeName("long")] int Timeout);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcNetworkInqProtseqsA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcNetworkInqProtseqsA(RPC_PROTSEQ_VECTORA** ProtseqVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcNetworkInqProtseqsW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcNetworkInqProtseqsW(RPC_PROTSEQ_VECTORW** ProtseqVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcObjectInqType"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcObjectInqType([NativeTypeName("UUID *")] Guid* ObjUuid, [NativeTypeName("UUID *")] Guid* TypeUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcObjectSetInqFn"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcObjectSetInqFn([NativeTypeName("RPC_OBJECT_INQ_FN *")] delegate* unmanaged<Guid*, Guid*, int*, void> InquiryFn);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcObjectSetType"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcObjectSetType([NativeTypeName("UUID *")] Guid* ObjUuid, [NativeTypeName("UUID *")] Guid* TypeUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcProtseqVectorFreeA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcProtseqVectorFreeA(RPC_PROTSEQ_VECTORA** ProtseqVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcProtseqVectorFreeW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcProtseqVectorFreeW(RPC_PROTSEQ_VECTORW** ProtseqVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInqBindings"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInqBindings(RPC_BINDING_VECTOR** BindingVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInqBindingsEx"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInqBindingsEx(void* SecurityDescriptor, RPC_BINDING_VECTOR** BindingVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInqIf"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInqIf([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void** MgrEpv);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerListen"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerListen([NativeTypeName("unsigned int")] uint MinimumCallThreads, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("unsigned int")] uint DontWait);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerRegisterIf"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerRegisterIf([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void* MgrEpv);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerRegisterIfEx"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerRegisterIfEx([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void* MgrEpv, [NativeTypeName("unsigned int")] uint Flags, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_CALLBACK_FN *")] delegate* unmanaged<void*, void*, int> IfCallback);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerRegisterIf2"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerRegisterIf2([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void* MgrEpv, [NativeTypeName("unsigned int")] uint Flags, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("unsigned int")] uint MaxRpcSize, [NativeTypeName("RPC_IF_CALLBACK_FN *")] delegate* unmanaged<void*, void*, int> IfCallbackFn);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerRegisterIf3"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerRegisterIf3([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void* MgrEpv, [NativeTypeName("unsigned int")] uint Flags, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("unsigned int")] uint MaxRpcSize, [NativeTypeName("RPC_IF_CALLBACK_FN *")] delegate* unmanaged<void*, void*, int> IfCallback, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUnregisterIf"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUnregisterIf([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, [NativeTypeName("unsigned int")] uint WaitForCallsToComplete);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUnregisterIfEx"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUnregisterIfEx([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, int RundownContextHandles);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseAllProtseqs"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseAllProtseqs([NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseAllProtseqsEx"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseAllProtseqsEx([NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseAllProtseqsIf"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseAllProtseqsIf([NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseAllProtseqsIfEx"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseAllProtseqsIfEx([NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqExA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqExA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqExW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqExW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqEpA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqEpA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_CSTR")] byte* Endpoint, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqEpExA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqEpExA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_CSTR")] byte* Endpoint, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqEpW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqEpW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_WSTR")] ushort* Endpoint, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqEpExW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqEpExW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_WSTR")] ushort* Endpoint, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqIfA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqIfA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqIfExA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqIfExA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqIfW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqIfW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerUseProtseqIfExW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerUseProtseqIfExW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerYield"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void RpcServerYield();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtStatsVectorFree"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtStatsVectorFree(RPC_STATS_VECTOR** StatsVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtInqStats"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtInqStats([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, RPC_STATS_VECTOR** Statistics);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtIsServerListening"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtIsServerListening([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtStopServerListening"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtStopServerListening([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtWaitServerListen"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtWaitServerListen();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtSetServerStackSize"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtSetServerStackSize([NativeTypeName("unsigned long")] uint ThreadStackSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcSsDontSerializeContext"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void RpcSsDontSerializeContext();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtEnableIdleCleanup"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtEnableIdleCleanup();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtInqIfIds"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtInqIfIds([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, RPC_IF_ID_VECTOR** IfIdVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcIfIdVectorFree"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcIfIdVectorFree(RPC_IF_ID_VECTOR** IfIdVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtInqServerPrincNameA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtInqServerPrincNameA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtInqServerPrincNameW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtInqServerPrincNameW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInqDefaultPrincNameA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInqDefaultPrincNameA([NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_CSTR *")] byte** PrincName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInqDefaultPrincNameW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInqDefaultPrincNameW([NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_WSTR *")] ushort** PrincName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcEpResolveBinding"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcEpResolveBinding([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcNsBindingInqEntryNameA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcNsBindingInqEntryNameA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint EntryNameSyntax, [NativeTypeName("RPC_CSTR *")] byte** EntryName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcNsBindingInqEntryNameW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcNsBindingInqEntryNameW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint EntryNameSyntax, [NativeTypeName("RPC_WSTR *")] ushort** EntryName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingCreateA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingCreateA(RPC_BINDING_HANDLE_TEMPLATE_V1_A* Template, RPC_BINDING_HANDLE_SECURITY_V1_A* Security, RPC_BINDING_HANDLE_OPTIONS_V1* Options, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingCreateW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingCreateW(RPC_BINDING_HANDLE_TEMPLATE_V1_W* Template, RPC_BINDING_HANDLE_SECURITY_V1_W* Security, RPC_BINDING_HANDLE_OPTIONS_V1* Options, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingGetTrainingContextHandle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingGetTrainingContextHandle([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void** ContextHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInqBindingHandle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInqBindingHandle([NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcImpersonateClient"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcImpersonateClient([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcImpersonateClient2"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcImpersonateClient2([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcRevertToSelfEx"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcRevertToSelfEx([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcRevertToSelf"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcRevertToSelf();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcImpersonateClientContainer"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcImpersonateClientContainer([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcRevertContainerImpersonation"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcRevertContainerImpersonation();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqAuthClientA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqAuthClientA([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** Privs, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthzSvc);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqAuthClientW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqAuthClientW([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** Privs, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthzSvc);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqAuthClientExA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqAuthClientExA([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** Privs, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthzSvc, [NativeTypeName("unsigned long")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqAuthClientExW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqAuthClientExW([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** Privs, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthzSvc, [NativeTypeName("unsigned long")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqAuthInfoA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqAuthInfoA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** AuthIdentity, [NativeTypeName("unsigned long *")] uint* AuthzSvc);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqAuthInfoW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqAuthInfoW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** AuthIdentity, [NativeTypeName("unsigned long *")] uint* AuthzSvc);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingSetAuthInfoA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingSetAuthInfoA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR")] byte* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnLevel, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* AuthIdentity, [NativeTypeName("unsigned long")] uint AuthzSvc);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingSetAuthInfoExA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingSetAuthInfoExA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR")] byte* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnLevel, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* AuthIdentity, [NativeTypeName("unsigned long")] uint AuthzSvc, RPC_SECURITY_QOS* SecurityQos);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingSetAuthInfoW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingSetAuthInfoW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR")] ushort* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnLevel, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* AuthIdentity, [NativeTypeName("unsigned long")] uint AuthzSvc);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingSetAuthInfoExW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingSetAuthInfoExW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR")] ushort* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnLevel, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* AuthIdentity, [NativeTypeName("unsigned long")] uint AuthzSvc, RPC_SECURITY_QOS* SecurityQOS);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqAuthInfoExA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqAuthInfoExA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** AuthIdentity, [NativeTypeName("unsigned long *")] uint* AuthzSvc, [NativeTypeName("unsigned long")] uint RpcQosVersion, RPC_SECURITY_QOS* SecurityQOS);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingInqAuthInfoExW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingInqAuthInfoExW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** AuthIdentity, [NativeTypeName("unsigned long *")] uint* AuthzSvc, [NativeTypeName("unsigned long")] uint RpcQosVersion, RPC_SECURITY_QOS* SecurityQOS);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerCompleteSecurityCallback"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerCompleteSecurityCallback([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle, [NativeTypeName("RPC_STATUS")] int Status);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerRegisterAuthInfoA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerRegisterAuthInfoA([NativeTypeName("RPC_CSTR")] byte* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_KEY_RETRIEVAL_FN")] delegate* unmanaged<void*, ushort*, uint, void**, int*, void> GetKeyFn, void* Arg);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerRegisterAuthInfoW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerRegisterAuthInfoW([NativeTypeName("RPC_WSTR")] ushort* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_KEY_RETRIEVAL_FN")] delegate* unmanaged<void*, ushort*, uint, void**, int*, void> GetKeyFn, void* Arg);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcBindingServerFromClient"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcBindingServerFromClient([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** ServerBinding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcRaiseException"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void RpcRaiseException([NativeTypeName("RPC_STATUS")] int exception);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcTestCancel"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcTestCancel();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerTestCancel"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerTestCancel([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcCancelThread"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcCancelThread(void* Thread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcCancelThreadEx"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcCancelThreadEx(void* Thread, [NativeTypeName("long")] int Timeout);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidCreate"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int UuidCreate([NativeTypeName("UUID *")] Guid* Uuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidCreateSequential"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int UuidCreateSequential([NativeTypeName("UUID *")] Guid* Uuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidToStringA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int UuidToStringA([NativeTypeName("const UUID *")] Guid* Uuid, [NativeTypeName("RPC_CSTR *")] byte** StringUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidFromStringA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int UuidFromStringA([NativeTypeName("RPC_CSTR")] byte* StringUuid, [NativeTypeName("UUID *")] Guid* Uuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidToStringW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int UuidToStringW([NativeTypeName("const UUID *")] Guid* Uuid, [NativeTypeName("RPC_WSTR *")] ushort** StringUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidFromStringW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int UuidFromStringW([NativeTypeName("RPC_WSTR")] ushort* StringUuid, [NativeTypeName("UUID *")] Guid* Uuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidCompare"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern int UuidCompare([NativeTypeName("UUID *")] Guid* Uuid1, [NativeTypeName("UUID *")] Guid* Uuid2, [NativeTypeName("RPC_STATUS *")] int* Status);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidCreateNil"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int UuidCreateNil([NativeTypeName("UUID *")] Guid* NilUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidEqual"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern int UuidEqual([NativeTypeName("UUID *")] Guid* Uuid1, [NativeTypeName("UUID *")] Guid* Uuid2, [NativeTypeName("RPC_STATUS *")] int* Status);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidHash"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("unsigned short")]
        public static extern ushort UuidHash([NativeTypeName("UUID *")] Guid* Uuid, [NativeTypeName("RPC_STATUS *")] int* Status);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UuidIsNil"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern int UuidIsNil([NativeTypeName("UUID *")] Guid* Uuid, [NativeTypeName("RPC_STATUS *")] int* Status);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcEpRegisterNoReplaceA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcEpRegisterNoReplaceA([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector, [NativeTypeName("RPC_CSTR")] byte* Annotation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcEpRegisterNoReplaceW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcEpRegisterNoReplaceW([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector, [NativeTypeName("RPC_WSTR")] ushort* Annotation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcEpRegisterA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcEpRegisterA([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector, [NativeTypeName("RPC_CSTR")] byte* Annotation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcEpRegisterW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcEpRegisterW([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector, [NativeTypeName("RPC_WSTR")] ushort* Annotation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcEpUnregister"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcEpUnregister([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DceErrorInqTextA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int DceErrorInqTextA([NativeTypeName("RPC_STATUS")] int RpcStatus, [NativeTypeName("RPC_CSTR")] byte* ErrorText);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DceErrorInqTextW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int DceErrorInqTextW([NativeTypeName("RPC_STATUS")] int RpcStatus, [NativeTypeName("RPC_WSTR")] ushort* ErrorText);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtEpEltInqBegin"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtEpEltInqBegin([NativeTypeName("RPC_BINDING_HANDLE")] void* EpBinding, [NativeTypeName("unsigned long")] uint InquiryType, RPC_IF_ID* IfId, [NativeTypeName("unsigned long")] uint VersOption, [NativeTypeName("UUID *")] Guid* ObjectUuid, [NativeTypeName("RPC_EP_INQ_HANDLE *")] void*** InquiryContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtEpEltInqDone"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtEpEltInqDone([NativeTypeName("RPC_EP_INQ_HANDLE *")] void*** InquiryContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtEpEltInqNextA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtEpEltInqNextA([NativeTypeName("RPC_EP_INQ_HANDLE")] void** InquiryContext, RPC_IF_ID* IfId, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid, [NativeTypeName("RPC_CSTR *")] byte** Annotation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtEpEltInqNextW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtEpEltInqNextW([NativeTypeName("RPC_EP_INQ_HANDLE")] void** InquiryContext, RPC_IF_ID* IfId, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid, [NativeTypeName("RPC_WSTR *")] ushort** Annotation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtEpUnregister"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtEpUnregister([NativeTypeName("RPC_BINDING_HANDLE")] void* EpBinding, RPC_IF_ID* IfId, [NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcMgmtSetAuthorizationFn"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcMgmtSetAuthorizationFn([NativeTypeName("RPC_MGMT_AUTHORIZATION_FN")] delegate* unmanaged<void*, uint, int*, int> AuthorizationFn);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcExceptionFilter"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern int RpcExceptionFilter([NativeTypeName("unsigned long")] uint ExceptionCode);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInterfaceGroupCreateW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInterfaceGroupCreateW(RPC_INTERFACE_TEMPLATEW* Interfaces, [NativeTypeName("unsigned long")] uint NumIfs, RPC_ENDPOINT_TEMPLATEW* Endpoints, [NativeTypeName("unsigned long")] uint NumEndpoints, [NativeTypeName("unsigned long")] uint IdlePeriod, [NativeTypeName("RPC_INTERFACE_GROUP_IDLE_CALLBACK_FN")] delegate* unmanaged<void*, void*, uint, void> IdleCallbackFn, void* IdleCallbackContext, [NativeTypeName("PRPC_INTERFACE_GROUP")] void** IfGroup);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInterfaceGroupCreateA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInterfaceGroupCreateA(RPC_INTERFACE_TEMPLATEA* Interfaces, [NativeTypeName("unsigned long")] uint NumIfs, RPC_ENDPOINT_TEMPLATEA* Endpoints, [NativeTypeName("unsigned long")] uint NumEndpoints, [NativeTypeName("unsigned long")] uint IdlePeriod, [NativeTypeName("RPC_INTERFACE_GROUP_IDLE_CALLBACK_FN")] delegate* unmanaged<void*, void*, uint, void> IdleCallbackFn, void* IdleCallbackContext, [NativeTypeName("PRPC_INTERFACE_GROUP")] void** IfGroup);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInterfaceGroupClose"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInterfaceGroupClose([NativeTypeName("RPC_INTERFACE_GROUP")] void* IfGroup);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInterfaceGroupActivate"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInterfaceGroupActivate([NativeTypeName("RPC_INTERFACE_GROUP")] void* IfGroup);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInterfaceGroupDeactivate"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInterfaceGroupDeactivate([NativeTypeName("RPC_INTERFACE_GROUP")] void* IfGroup, [NativeTypeName("unsigned long")] uint ForceDeactivation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RpcServerInterfaceGroupInqBindings"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int RpcServerInterfaceGroupInqBindings([NativeTypeName("RPC_INTERFACE_GROUP")] void* IfGroup, RPC_BINDING_VECTOR** BindingVector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcNegotiateTransferSyntax"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcNegotiateTransferSyntax(RPC_MESSAGE* Message);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcGetBuffer"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcGetBuffer(RPC_MESSAGE* Message);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcGetBufferWithObject"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcGetBufferWithObject(RPC_MESSAGE* Message, [NativeTypeName("UUID *")] Guid* ObjectUuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcSendReceive"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcSendReceive(RPC_MESSAGE* Message);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcFreeBuffer"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcFreeBuffer(RPC_MESSAGE* Message);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcSend"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcSend([NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* Message);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcReceive"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcReceive([NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* Message, [NativeTypeName("unsigned int")] uint Size);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcFreePipeBuffer"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcFreePipeBuffer(RPC_MESSAGE* Message);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcReallocPipeBuffer"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcReallocPipeBuffer([NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* Message, [NativeTypeName("unsigned int")] uint NewSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcRequestMutex"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcRequestMutex([NativeTypeName("I_RPC_MUTEX *")] void** Mutex);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcClearMutex"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcClearMutex([NativeTypeName("I_RPC_MUTEX")] void* Mutex);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcDeleteMutex"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcDeleteMutex([NativeTypeName("I_RPC_MUTEX")] void* Mutex);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcAllocate"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void* I_RpcAllocate([NativeTypeName("unsigned int")] uint Size);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcFree"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcFree(void* Object);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcFreeSystemHandleCollection"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint I_RpcFreeSystemHandleCollection(void* CallObj, [NativeTypeName("unsigned long")] uint FreeFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcSetSystemHandle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcSetSystemHandle(void* Handle, [NativeTypeName("unsigned char")] byte Type, [NativeTypeName("unsigned long")] uint AccessMask, void* CallObj, [NativeTypeName("unsigned long *")] uint* HandleIndex);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcGetSystemHandle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcGetSystemHandle([NativeTypeName("unsigned char *")] byte* pMemory, [NativeTypeName("unsigned char")] byte Type, [NativeTypeName("unsigned long")] uint AccessMask, [NativeTypeName("unsigned long")] uint HandleIndex, void* CallObj);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcFreeSystemHandle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcFreeSystemHandle([NativeTypeName("unsigned char")] byte Type, void* Handle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcPauseExecution"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcPauseExecution([NativeTypeName("unsigned long")] uint Milliseconds);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcGetExtendedError"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcGetExtendedError();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcSystemHandleTypeSpecificWork"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcSystemHandleTypeSpecificWork(void* Handle, [NativeTypeName("unsigned char")] byte ActualType, [NativeTypeName("unsigned char")] byte IdlType, LRPC_SYSTEM_HANDLE_MARSHAL_DIRECTION MarshalDirection);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcMonitorAssociation"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcMonitorAssociation([NativeTypeName("RPC_BINDING_HANDLE")] void* Handle, [NativeTypeName("PRPC_RUNDOWN")] delegate* unmanaged<void*, void> RundownRoutine, void* Context);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcStopMonitorAssociation"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcStopMonitorAssociation([NativeTypeName("RPC_BINDING_HANDLE")] void* Handle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcGetCurrentCallHandle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_BINDING_HANDLE")]
        public static extern void* I_RpcGetCurrentCallHandle();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcGetAssociationContext"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcGetAssociationContext([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle, void** AssociationContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcGetServerContextList"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void* I_RpcGetServerContextList([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcSetServerContextList"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcSetServerContextList([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle, void* ServerContextList);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcNsInterfaceExported"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcNsInterfaceExported([NativeTypeName("unsigned long")] uint EntryNameSyntax, [NativeTypeName("unsigned short *")] ushort* EntryName, RPC_SERVER_INTERFACE* RpcInterfaceInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcNsInterfaceUnexported"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcNsInterfaceUnexported([NativeTypeName("unsigned long")] uint EntryNameSyntax, [NativeTypeName("unsigned short *")] ushort* EntryName, RPC_SERVER_INTERFACE* RpcInterfaceInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingToStaticStringBindingW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingToStaticStringBindingW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned short **")] ushort** StringBinding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqSecurityContext"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqSecurityContext([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void** SecurityContextHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqSecurityContextKeyInfo"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqSecurityContextKeyInfo([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void* KeyInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqWireIdForSnego"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqWireIdForSnego([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned char *")] byte* WireId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqMarshalledTargetInfo"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqMarshalledTargetInfo([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long *")] uint* MarshalledTargetInfoSize, [NativeTypeName("RPC_CSTR *")] byte** MarshalledTargetInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqLocalClientPID"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqLocalClientPID([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long *")] uint* Pid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingHandleToAsyncHandle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingHandleToAsyncHandle([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void** AsyncHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcNsBindingSetEntryNameW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcNsBindingSetEntryNameW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint EntryNameSyntax, [NativeTypeName("RPC_WSTR")] ushort* EntryName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcNsBindingSetEntryNameA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcNsBindingSetEntryNameA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint EntryNameSyntax, [NativeTypeName("RPC_CSTR")] byte* EntryName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerUseProtseqEp2A"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerUseProtseqEp2A([NativeTypeName("RPC_CSTR")] byte* NetworkAddress, [NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_CSTR")] byte* Endpoint, void* SecurityDescriptor, void* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerUseProtseqEp2W"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerUseProtseqEp2W([NativeTypeName("RPC_WSTR")] ushort* NetworkAddress, [NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_WSTR")] ushort* Endpoint, void* SecurityDescriptor, void* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerUseProtseq2W"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerUseProtseq2W([NativeTypeName("RPC_WSTR")] ushort* NetworkAddress, [NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor, void* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerUseProtseq2A"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerUseProtseq2A([NativeTypeName("RPC_CSTR")] byte* NetworkAddress, [NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor, void* Policy);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerStartService"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerStartService([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("RPC_WSTR")] ushort* Endpoint, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqDynamicEndpointW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqDynamicEndpointW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR *")] ushort** DynamicEndpoint);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqDynamicEndpointA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqDynamicEndpointA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR *")] byte** DynamicEndpoint);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerCheckClientRestriction"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerCheckClientRestriction([NativeTypeName("RPC_BINDING_HANDLE")] void* Context);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqTransportType"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqTransportType([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned int *")] uint* Type);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcIfInqTransferSyntaxes"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcIfInqTransferSyntaxes([NativeTypeName("RPC_IF_HANDLE")] void* RpcIfHandle, RPC_TRANSFER_SYNTAX* TransferSyntaxes, [NativeTypeName("unsigned int")] uint TransferSyntaxSize, [NativeTypeName("unsigned int *")] uint* TransferSyntaxCount);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_UuidCreate"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_UuidCreate([NativeTypeName("UUID *")] Guid* Uuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcUninitializeNdrOle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcUninitializeNdrOle();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingCopy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingCopy([NativeTypeName("RPC_BINDING_HANDLE")] void* SourceBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** DestinationBinding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingIsClientLocal"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingIsClientLocal([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle, [NativeTypeName("unsigned int *")] uint* ClientLocalFlag);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingInqConnId"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingInqConnId([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void** ConnId, int* pfFirstCall);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingCreateNP"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingCreateNP([NativeTypeName("RPC_WSTR")] ushort* ServerName, [NativeTypeName("RPC_WSTR")] ushort* ServiceName, [NativeTypeName("RPC_WSTR")] ushort* NetworkOptions, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcSsDontSerializeContext"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcSsDontSerializeContext();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcLaunchDatagramReceiveThread"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcLaunchDatagramReceiveThread(void* pAddress);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerRegisterForwardFunction"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerRegisterForwardFunction([NativeTypeName("RPC_FORWARD_FUNCTION *")] delegate* unmanaged<Guid*, RPC_VERSION*, Guid*, byte*, void**, int> pForwardFunction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerInqAddressChangeFn"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_ADDRESS_CHANGE_FN * __attribute__((stdcall))")]
        public static extern delegate* unmanaged<void*, void> I_RpcServerInqAddressChangeFn();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerSetAddressChangeFn"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerSetAddressChangeFn([NativeTypeName("RPC_ADDRESS_CHANGE_FN *")] delegate* unmanaged<void*, void> pAddressChangeFn);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerInqLocalConnAddress"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerInqLocalConnAddress([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void* Buffer, [NativeTypeName("unsigned long *")] uint* BufferSize, [NativeTypeName("unsigned long *")] uint* AddressFormat);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerInqRemoteConnAddress"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerInqRemoteConnAddress([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void* Buffer, [NativeTypeName("unsigned long *")] uint* BufferSize, [NativeTypeName("unsigned long *")] uint* AddressFormat);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcSessionStrictContextHandle"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcSessionStrictContextHandle();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcTurnOnEEInfoPropagation"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcTurnOnEEInfoPropagation();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcConnectionInqSockBuffSize"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcConnectionInqSockBuffSize([NativeTypeName("unsigned long *")] uint* RecvBuffSize, [NativeTypeName("unsigned long *")] uint* SendBuffSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcConnectionSetSockBuffSize"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcConnectionSetSockBuffSize([NativeTypeName("unsigned long")] uint RecvBuffSize, [NativeTypeName("unsigned long")] uint SendBuffSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerStartListening"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerStartListening(void* hWnd);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerStopListening"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerStopListening();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingSetAsync"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingSetAsync([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_BLOCKING_FN")] delegate* unmanaged<void*, void*, void*, int> BlockingFn, [NativeTypeName("unsigned long")] uint ServerTid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcSetThreadParams"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcSetThreadParams(int fClientFree, void* Context, void* hWndClient);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcWindowProc"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint I_RpcWindowProc(void* hWnd, [NativeTypeName("unsigned int")] uint Message, [NativeTypeName("unsigned int")] uint wParam, [NativeTypeName("unsigned long")] uint lParam);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerUnregisterEndpointA"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerUnregisterEndpointA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("RPC_CSTR")] byte* Endpoint);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerUnregisterEndpointW"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerUnregisterEndpointW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("RPC_WSTR")] ushort* Endpoint);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerInqTransportType"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerInqTransportType([NativeTypeName("unsigned int *")] uint* Type);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcMapWin32Status"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int I_RpcMapWin32Status([NativeTypeName("RPC_STATUS")] int Status);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcProxyNewConnection"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcProxyNewConnection([NativeTypeName("unsigned long")] uint ConnectionType, [NativeTypeName("unsigned short *")] ushort* ServerAddress, [NativeTypeName("unsigned short *")] ushort* ServerPort, [NativeTypeName("unsigned short *")] ushort* MinConnTimeout, void* ConnectionParameter, RDR_CALLOUT_STATE* CallOutState, I_RpcProxyCallbackInterface* ProxyCallbackInterface);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcReplyToClientWithStatus"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcReplyToClientWithStatus(void* ConnectionParameter, [NativeTypeName("RPC_STATUS")] int RpcStatus);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcRecordCalloutFailure"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void I_RpcRecordCalloutFailure([NativeTypeName("RPC_STATUS")] int RpcStatus, RDR_CALLOUT_STATE* CallOutState, [NativeTypeName("unsigned short *")] ushort* DllName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcMgmtEnableDedicatedThreadPool"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcMgmtEnableDedicatedThreadPool();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcGetDefaultSD"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcGetDefaultSD(void** ppSecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcOpenClientProcess"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcOpenClientProcess([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint DesiredAccess, void** ClientProcess);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingIsServerLocal"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingIsServerLocal([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned int *")] uint* ServerLocalFlag);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcBindingSetPrivateOption"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcBindingSetPrivateOption([NativeTypeName("RPC_BINDING_HANDLE")] void* hBinding, [NativeTypeName("unsigned long")] uint option, [NativeTypeName("ULONG_PTR")] ulong optionValue);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerSubscribeForDisconnectNotification"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerSubscribeForDisconnectNotification([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void* hEvent);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerGetAssociationID"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerGetAssociationID([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long *")] uint* AssociationID);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerDisableExceptionFilter"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int I_RpcServerDisableExceptionFilter();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerSubscribeForDisconnectNotification2"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerSubscribeForDisconnectNotification2([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, void* hEvent, [NativeTypeName("UUID *")] Guid* SubscriptionId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.I_RpcServerUnsubscribeForDisconnectNotification"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("RPC_STATUS")]
        public static extern int I_RpcServerUnsubscribeForDisconnectNotification([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("UUID")] Guid SubscriptionId);

        [NativeTypeName("#define RPC_C_BINDING_INFINITE_TIMEOUT 10")]
        public const int RPC_C_BINDING_INFINITE_TIMEOUT = 10;

        [NativeTypeName("#define RPC_C_BINDING_MIN_TIMEOUT 0")]
        public const int RPC_C_BINDING_MIN_TIMEOUT = 0;

        [NativeTypeName("#define RPC_C_BINDING_DEFAULT_TIMEOUT 5")]
        public const int RPC_C_BINDING_DEFAULT_TIMEOUT = 5;

        [NativeTypeName("#define RPC_C_BINDING_MAX_TIMEOUT 9")]
        public const int RPC_C_BINDING_MAX_TIMEOUT = 9;

        [NativeTypeName("#define RPC_C_CANCEL_INFINITE_TIMEOUT -1")]
        public const int RPC_C_CANCEL_INFINITE_TIMEOUT = -1;

        [NativeTypeName("#define RPC_C_LISTEN_MAX_CALLS_DEFAULT 1234")]
        public const int RPC_C_LISTEN_MAX_CALLS_DEFAULT = 1234;

        [NativeTypeName("#define RPC_C_PROTSEQ_MAX_REQS_DEFAULT 10")]
        public const int RPC_C_PROTSEQ_MAX_REQS_DEFAULT = 10;

        [NativeTypeName("#define RPC_C_BIND_TO_ALL_NICS 1")]
        public const int RPC_C_BIND_TO_ALL_NICS = 1;

        [NativeTypeName("#define RPC_C_USE_INTERNET_PORT 0x1")]
        public const int RPC_C_USE_INTERNET_PORT = 0x1;

        [NativeTypeName("#define RPC_C_USE_INTRANET_PORT 0x2")]
        public const int RPC_C_USE_INTRANET_PORT = 0x2;

        [NativeTypeName("#define RPC_C_DONT_FAIL 0x4")]
        public const int RPC_C_DONT_FAIL = 0x4;

        [NativeTypeName("#define RPC_C_RPCHTTP_USE_LOAD_BALANCE 0x8")]
        public const int RPC_C_RPCHTTP_USE_LOAD_BALANCE = 0x8;

        [NativeTypeName("#define RPC_C_OPT_BINDING_NONCAUSAL 9")]
        public const int RPC_C_OPT_BINDING_NONCAUSAL = 9;

        [NativeTypeName("#define RPC_C_OPT_SECURITY_CALLBACK 10")]
        public const int RPC_C_OPT_SECURITY_CALLBACK = 10;

        [NativeTypeName("#define RPC_C_OPT_UNIQUE_BINDING 11")]
        public const int RPC_C_OPT_UNIQUE_BINDING = 11;

        [NativeTypeName("#define RPC_C_OPT_TRANS_SEND_BUFFER_SIZE 5")]
        public const int RPC_C_OPT_TRANS_SEND_BUFFER_SIZE = 5;

        [NativeTypeName("#define RPC_C_OPT_CALL_TIMEOUT 12")]
        public const int RPC_C_OPT_CALL_TIMEOUT = 12;

        [NativeTypeName("#define RPC_C_OPT_DONT_LINGER 13")]
        public const int RPC_C_OPT_DONT_LINGER = 13;

        [NativeTypeName("#define RPC_C_OPT_TRUST_PEER 14")]
        public const int RPC_C_OPT_TRUST_PEER = 14;

        [NativeTypeName("#define RPC_C_OPT_ASYNC_BLOCK 15")]
        public const int RPC_C_OPT_ASYNC_BLOCK = 15;

        [NativeTypeName("#define RPC_C_OPT_OPTIMIZE_TIME 16")]
        public const int RPC_C_OPT_OPTIMIZE_TIME = 16;

        [NativeTypeName("#define RPC_C_OPT_MAX_OPTIONS 17")]
        public const int RPC_C_OPT_MAX_OPTIONS = 17;

        [NativeTypeName("#define RPC_C_FULL_CERT_CHAIN 0x0001")]
        public const int RPC_C_FULL_CERT_CHAIN = 0x0001;

        [NativeTypeName("#define RPC_C_STATS_CALLS_IN 0")]
        public const int RPC_C_STATS_CALLS_IN = 0;

        [NativeTypeName("#define RPC_C_STATS_CALLS_OUT 1")]
        public const int RPC_C_STATS_CALLS_OUT = 1;

        [NativeTypeName("#define RPC_C_STATS_PKTS_IN 2")]
        public const int RPC_C_STATS_PKTS_IN = 2;

        [NativeTypeName("#define RPC_C_STATS_PKTS_OUT 3")]
        public const int RPC_C_STATS_PKTS_OUT = 3;

        [NativeTypeName("#define RpcBindingFromStringBinding RpcBindingFromStringBindingW")]
        public static readonly delegate*<ushort*, void**, int> RpcBindingFromStringBinding = &RpcBindingFromStringBindingW;

        [NativeTypeName("#define RpcBindingToStringBinding RpcBindingToStringBindingW")]
        public static readonly delegate*<void*, ushort**, int> RpcBindingToStringBinding = &RpcBindingToStringBindingW;

        [NativeTypeName("#define RpcStringBindingCompose RpcStringBindingComposeW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, ushort*, ushort*, ushort**, int> RpcStringBindingCompose = &RpcStringBindingComposeW;

        [NativeTypeName("#define RpcStringBindingParse RpcStringBindingParseW")]
        public static readonly delegate*<ushort*, ushort**, ushort**, ushort**, ushort**, ushort**, int> RpcStringBindingParse = &RpcStringBindingParseW;

        [NativeTypeName("#define RpcStringFree RpcStringFreeW")]
        public static readonly delegate*<ushort**, int> RpcStringFree = &RpcStringFreeW;

        [NativeTypeName("#define RpcNetworkIsProtseqValid RpcNetworkIsProtseqValidW")]
        public static readonly delegate*<ushort*, int> RpcNetworkIsProtseqValid = &RpcNetworkIsProtseqValidW;

        [NativeTypeName("#define RpcNetworkInqProtseqs RpcNetworkInqProtseqsW")]
        public static readonly delegate*<RPC_PROTSEQ_VECTORW**, int> RpcNetworkInqProtseqs = &RpcNetworkInqProtseqsW;

        [NativeTypeName("#define RpcProtseqVectorFree RpcProtseqVectorFreeW")]
        public static readonly delegate*<RPC_PROTSEQ_VECTORW**, int> RpcProtseqVectorFree = &RpcProtseqVectorFreeW;

        [NativeTypeName("#define RpcServerUseProtseq RpcServerUseProtseqW")]
        public static readonly delegate*<ushort*, uint, void*, int> RpcServerUseProtseq = &RpcServerUseProtseqW;

        [NativeTypeName("#define RpcServerUseProtseqEx RpcServerUseProtseqExW")]
        public static readonly delegate*<ushort*, uint, void*, RPC_POLICY*, int> RpcServerUseProtseqEx = &RpcServerUseProtseqExW;

        [NativeTypeName("#define RpcServerUseProtseqEp RpcServerUseProtseqEpW")]
        public static readonly delegate*<ushort*, uint, ushort*, void*, int> RpcServerUseProtseqEp = &RpcServerUseProtseqEpW;

        [NativeTypeName("#define RpcServerUseProtseqEpEx RpcServerUseProtseqEpExW")]
        public static readonly delegate*<ushort*, uint, ushort*, void*, RPC_POLICY*, int> RpcServerUseProtseqEpEx = &RpcServerUseProtseqEpExW;

        [NativeTypeName("#define RpcServerUseProtseqIf RpcServerUseProtseqIfW")]
        public static readonly delegate*<ushort*, uint, void*, void*, int> RpcServerUseProtseqIf = &RpcServerUseProtseqIfW;

        [NativeTypeName("#define RpcServerUseProtseqIfEx RpcServerUseProtseqIfExW")]
        public static readonly delegate*<ushort*, uint, void*, void*, RPC_POLICY*, int> RpcServerUseProtseqIfEx = &RpcServerUseProtseqIfExW;

        [NativeTypeName("#define RpcMgmtInqServerPrincName RpcMgmtInqServerPrincNameW")]
        public static readonly delegate*<void*, uint, ushort**, int> RpcMgmtInqServerPrincName = &RpcMgmtInqServerPrincNameW;

        [NativeTypeName("#define RpcServerInqDefaultPrincName RpcServerInqDefaultPrincNameW")]
        public static readonly delegate*<uint, ushort**, int> RpcServerInqDefaultPrincName = &RpcServerInqDefaultPrincNameW;

        [NativeTypeName("#define RpcNsBindingInqEntryName RpcNsBindingInqEntryNameW")]
        public static readonly delegate*<void*, uint, ushort**, int> RpcNsBindingInqEntryName = &RpcNsBindingInqEntryNameW;

        [NativeTypeName("#define RPC_C_AUTHN_LEVEL_DEFAULT 0")]
        public const int RPC_C_AUTHN_LEVEL_DEFAULT = 0;

        [NativeTypeName("#define RPC_C_AUTHN_LEVEL_NONE 1")]
        public const int RPC_C_AUTHN_LEVEL_NONE = 1;

        [NativeTypeName("#define RPC_C_AUTHN_LEVEL_CONNECT 2")]
        public const int RPC_C_AUTHN_LEVEL_CONNECT = 2;

        [NativeTypeName("#define RPC_C_AUTHN_LEVEL_CALL 3")]
        public const int RPC_C_AUTHN_LEVEL_CALL = 3;

        [NativeTypeName("#define RPC_C_AUTHN_LEVEL_PKT 4")]
        public const int RPC_C_AUTHN_LEVEL_PKT = 4;

        [NativeTypeName("#define RPC_C_AUTHN_LEVEL_PKT_INTEGRITY 5")]
        public const int RPC_C_AUTHN_LEVEL_PKT_INTEGRITY = 5;

        [NativeTypeName("#define RPC_C_AUTHN_LEVEL_PKT_PRIVACY 6")]
        public const int RPC_C_AUTHN_LEVEL_PKT_PRIVACY = 6;

        [NativeTypeName("#define RPC_C_IMP_LEVEL_DEFAULT 0")]
        public const int RPC_C_IMP_LEVEL_DEFAULT = 0;

        [NativeTypeName("#define RPC_C_IMP_LEVEL_ANONYMOUS 1")]
        public const int RPC_C_IMP_LEVEL_ANONYMOUS = 1;

        [NativeTypeName("#define RPC_C_IMP_LEVEL_IDENTIFY 2")]
        public const int RPC_C_IMP_LEVEL_IDENTIFY = 2;

        [NativeTypeName("#define RPC_C_IMP_LEVEL_IMPERSONATE 3")]
        public const int RPC_C_IMP_LEVEL_IMPERSONATE = 3;

        [NativeTypeName("#define RPC_C_IMP_LEVEL_DELEGATE 4")]
        public const int RPC_C_IMP_LEVEL_DELEGATE = 4;

        [NativeTypeName("#define RPC_C_QOS_IDENTITY_STATIC 0")]
        public const int RPC_C_QOS_IDENTITY_STATIC = 0;

        [NativeTypeName("#define RPC_C_QOS_IDENTITY_DYNAMIC 1")]
        public const int RPC_C_QOS_IDENTITY_DYNAMIC = 1;

        [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_DEFAULT 0x0")]
        public const int RPC_C_QOS_CAPABILITIES_DEFAULT = 0x0;

        [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_MUTUAL_AUTH 0x1")]
        public const int RPC_C_QOS_CAPABILITIES_MUTUAL_AUTH = 0x1;

        [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_MAKE_FULLSIC 0x2")]
        public const int RPC_C_QOS_CAPABILITIES_MAKE_FULLSIC = 0x2;

        [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_ANY_AUTHORITY 0x4")]
        public const int RPC_C_QOS_CAPABILITIES_ANY_AUTHORITY = 0x4;

        [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_IGNORE_DELEGATE_FAILURE 0x8")]
        public const int RPC_C_QOS_CAPABILITIES_IGNORE_DELEGATE_FAILURE = 0x8;

        [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_LOCAL_MA_HINT 0x10")]
        public const int RPC_C_QOS_CAPABILITIES_LOCAL_MA_HINT = 0x10;

        [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_SCHANNEL_FULL_AUTH_IDENTITY 0x20")]
        public const int RPC_C_QOS_CAPABILITIES_SCHANNEL_FULL_AUTH_IDENTITY = 0x20;

        [NativeTypeName("#define RPC_C_PROTECT_LEVEL_DEFAULT (RPC_C_AUTHN_LEVEL_DEFAULT)")]
        public const int RPC_C_PROTECT_LEVEL_DEFAULT = (0);

        [NativeTypeName("#define RPC_C_PROTECT_LEVEL_NONE (RPC_C_AUTHN_LEVEL_NONE)")]
        public const int RPC_C_PROTECT_LEVEL_NONE = (1);

        [NativeTypeName("#define RPC_C_PROTECT_LEVEL_CONNECT (RPC_C_AUTHN_LEVEL_CONNECT)")]
        public const int RPC_C_PROTECT_LEVEL_CONNECT = (2);

        [NativeTypeName("#define RPC_C_PROTECT_LEVEL_CALL (RPC_C_AUTHN_LEVEL_CALL)")]
        public const int RPC_C_PROTECT_LEVEL_CALL = (3);

        [NativeTypeName("#define RPC_C_PROTECT_LEVEL_PKT (RPC_C_AUTHN_LEVEL_PKT)")]
        public const int RPC_C_PROTECT_LEVEL_PKT = (4);

        [NativeTypeName("#define RPC_C_PROTECT_LEVEL_PKT_INTEGRITY (RPC_C_AUTHN_LEVEL_PKT_INTEGRITY)")]
        public const int RPC_C_PROTECT_LEVEL_PKT_INTEGRITY = (5);

        [NativeTypeName("#define RPC_C_PROTECT_LEVEL_PKT_PRIVACY (RPC_C_AUTHN_LEVEL_PKT_PRIVACY)")]
        public const int RPC_C_PROTECT_LEVEL_PKT_PRIVACY = (6);

        [NativeTypeName("#define RPC_C_AUTHN_NONE 0")]
        public const int RPC_C_AUTHN_NONE = 0;

        [NativeTypeName("#define RPC_C_AUTHN_DCE_PRIVATE 1")]
        public const int RPC_C_AUTHN_DCE_PRIVATE = 1;

        [NativeTypeName("#define RPC_C_AUTHN_DCE_PUBLIC 2")]
        public const int RPC_C_AUTHN_DCE_PUBLIC = 2;

        [NativeTypeName("#define RPC_C_AUTHN_DEC_PUBLIC 4")]
        public const int RPC_C_AUTHN_DEC_PUBLIC = 4;

        [NativeTypeName("#define RPC_C_AUTHN_GSS_NEGOTIATE 9")]
        public const int RPC_C_AUTHN_GSS_NEGOTIATE = 9;

        [NativeTypeName("#define RPC_C_AUTHN_WINNT 10")]
        public const int RPC_C_AUTHN_WINNT = 10;

        [NativeTypeName("#define RPC_C_AUTHN_GSS_SCHANNEL 14")]
        public const int RPC_C_AUTHN_GSS_SCHANNEL = 14;

        [NativeTypeName("#define RPC_C_AUTHN_GSS_KERBEROS 16")]
        public const int RPC_C_AUTHN_GSS_KERBEROS = 16;

        [NativeTypeName("#define RPC_C_AUTHN_DPA 17")]
        public const int RPC_C_AUTHN_DPA = 17;

        [NativeTypeName("#define RPC_C_AUTHN_MSN 18")]
        public const int RPC_C_AUTHN_MSN = 18;

        [NativeTypeName("#define RPC_C_AUTHN_DIGEST 21")]
        public const int RPC_C_AUTHN_DIGEST = 21;

        [NativeTypeName("#define RPC_C_AUTHN_KERNEL 20")]
        public const int RPC_C_AUTHN_KERNEL = 20;

        [NativeTypeName("#define RPC_C_AUTHN_NEGO_EXTENDER 30")]
        public const int RPC_C_AUTHN_NEGO_EXTENDER = 30;

        [NativeTypeName("#define RPC_C_AUTHN_PKU2U 31")]
        public const int RPC_C_AUTHN_PKU2U = 31;

        [NativeTypeName("#define RPC_C_AUTHN_LIVE_SSP 32")]
        public const int RPC_C_AUTHN_LIVE_SSP = 32;

        [NativeTypeName("#define RPC_C_AUTHN_LIVEXP_SSP 35")]
        public const int RPC_C_AUTHN_LIVEXP_SSP = 35;

        [NativeTypeName("#define RPC_C_AUTHN_CLOUD_AP 36")]
        public const int RPC_C_AUTHN_CLOUD_AP = 36;

        [NativeTypeName("#define RPC_C_AUTHN_MSONLINE 82")]
        public const int RPC_C_AUTHN_MSONLINE = 82;

        [NativeTypeName("#define RPC_C_AUTHN_MQ 100")]
        public const int RPC_C_AUTHN_MQ = 100;

        [NativeTypeName("#define RPC_C_AUTHN_DEFAULT 0xFFFFFFFFL")]
        public const uint RPC_C_AUTHN_DEFAULT = 0xFFFFFFFF;

        [NativeTypeName("#define RPC_C_NO_CREDENTIALS ((RPC_AUTH_IDENTITY_HANDLE) MAXUINT_PTR)")]
        public static readonly void* RPC_C_NO_CREDENTIALS = unchecked((void*)(~((ulong)(0))));

        [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION 1L")]
        public const int RPC_C_SECURITY_QOS_VERSION = 1;

        [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_1 1L")]
        public const int RPC_C_SECURITY_QOS_VERSION_1 = 1;

        [NativeTypeName("#define SEC_WINNT_AUTH_IDENTITY_ANSI 0x1")]
        public const int SEC_WINNT_AUTH_IDENTITY_ANSI = 0x1;

        [NativeTypeName("#define SEC_WINNT_AUTH_IDENTITY_UNICODE 0x2")]
        public const int SEC_WINNT_AUTH_IDENTITY_UNICODE = 0x2;

        [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_2 2L")]
        public const int RPC_C_SECURITY_QOS_VERSION_2 = 2;

        [NativeTypeName("#define RPC_C_AUTHN_INFO_TYPE_HTTP 1")]
        public const int RPC_C_AUTHN_INFO_TYPE_HTTP = 1;

        [NativeTypeName("#define RPC_C_HTTP_AUTHN_TARGET_SERVER 1")]
        public const int RPC_C_HTTP_AUTHN_TARGET_SERVER = 1;

        [NativeTypeName("#define RPC_C_HTTP_AUTHN_TARGET_PROXY 2")]
        public const int RPC_C_HTTP_AUTHN_TARGET_PROXY = 2;

        [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_BASIC 0x00000001")]
        public const int RPC_C_HTTP_AUTHN_SCHEME_BASIC = 0x00000001;

        [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_NTLM 0x00000002")]
        public const int RPC_C_HTTP_AUTHN_SCHEME_NTLM = 0x00000002;

        [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_PASSPORT 0x00000004")]
        public const int RPC_C_HTTP_AUTHN_SCHEME_PASSPORT = 0x00000004;

        [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_DIGEST 0x00000008")]
        public const int RPC_C_HTTP_AUTHN_SCHEME_DIGEST = 0x00000008;

        [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_NEGOTIATE 0x00000010")]
        public const int RPC_C_HTTP_AUTHN_SCHEME_NEGOTIATE = 0x00000010;

        [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_CERT 0x00010000")]
        public const int RPC_C_HTTP_AUTHN_SCHEME_CERT = 0x00010000;

        [NativeTypeName("#define RPC_C_HTTP_FLAG_USE_SSL 1")]
        public const int RPC_C_HTTP_FLAG_USE_SSL = 1;

        [NativeTypeName("#define RPC_C_HTTP_FLAG_USE_FIRST_AUTH_SCHEME 2")]
        public const int RPC_C_HTTP_FLAG_USE_FIRST_AUTH_SCHEME = 2;

        [NativeTypeName("#define RPC_C_HTTP_FLAG_IGNORE_CERT_CN_INVALID 8")]
        public const int RPC_C_HTTP_FLAG_IGNORE_CERT_CN_INVALID = 8;

        [NativeTypeName("#define RPC_C_HTTP_FLAG_ENABLE_CERT_REVOCATION_CHECK 16")]
        public const int RPC_C_HTTP_FLAG_ENABLE_CERT_REVOCATION_CHECK = 16;

        [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_3 3L")]
        public const int RPC_C_SECURITY_QOS_VERSION_3 = 3;

        [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_4 4L")]
        public const int RPC_C_SECURITY_QOS_VERSION_4 = 4;

        [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_5 5L")]
        public const int RPC_C_SECURITY_QOS_VERSION_5 = 5;

        [NativeTypeName("#define RPC_PROTSEQ_TCP (0x1)")]
        public const int RPC_PROTSEQ_TCP = (0x1);

        [NativeTypeName("#define RPC_PROTSEQ_NMP (0x2)")]
        public const int RPC_PROTSEQ_NMP = (0x2);

        [NativeTypeName("#define RPC_PROTSEQ_LRPC (0x3)")]
        public const int RPC_PROTSEQ_LRPC = (0x3);

        [NativeTypeName("#define RPC_PROTSEQ_HTTP (0x4)")]
        public const int RPC_PROTSEQ_HTTP = (0x4);

        [NativeTypeName("#define RPC_BHT_OBJECT_UUID_VALID (0x1)")]
        public const int RPC_BHT_OBJECT_UUID_VALID = (0x1);

        [NativeTypeName("#define RPC_BHO_NONCAUSAL (0x1)")]
        public const int RPC_BHO_NONCAUSAL = (0x1);

        [NativeTypeName("#define RPC_BHO_DONTLINGER (0x2)")]
        public const int RPC_BHO_DONTLINGER = (0x2);

        [NativeTypeName("#define RPC_BHO_EXCLUSIVE_AND_GUARANTEED (0x4)")]
        public const int RPC_BHO_EXCLUSIVE_AND_GUARANTEED = (0x4);

        [NativeTypeName("#define RpcBindingCreate RpcBindingCreateW")]
        public static readonly delegate*<RPC_BINDING_HANDLE_TEMPLATE_V1_W*, RPC_BINDING_HANDLE_SECURITY_V1_W*, RPC_BINDING_HANDLE_OPTIONS_V1*, void**, int> RpcBindingCreate = &RpcBindingCreateW;

        [NativeTypeName("#define RPC_C_AUTHZ_NONE 0")]
        public const int RPC_C_AUTHZ_NONE = 0;

        [NativeTypeName("#define RPC_C_AUTHZ_NAME 1")]
        public const int RPC_C_AUTHZ_NAME = 1;

        [NativeTypeName("#define RPC_C_AUTHZ_DCE 2")]
        public const int RPC_C_AUTHZ_DCE = 2;

        [NativeTypeName("#define RPC_C_AUTHZ_DEFAULT 0xffffffff")]
        public const uint RPC_C_AUTHZ_DEFAULT = 0xffffffff;

        [NativeTypeName("#define RpcBindingInqAuthClient RpcBindingInqAuthClientW")]
        public static readonly delegate*<void*, void**, ushort**, uint*, uint*, uint*, int> RpcBindingInqAuthClient = &RpcBindingInqAuthClientW;

        [NativeTypeName("#define RpcBindingInqAuthClientEx RpcBindingInqAuthClientExW")]
        public static readonly delegate*<void*, void**, ushort**, uint*, uint*, uint*, uint, int> RpcBindingInqAuthClientEx = &RpcBindingInqAuthClientExW;

        [NativeTypeName("#define RpcBindingInqAuthInfo RpcBindingInqAuthInfoW")]
        public static readonly delegate*<void*, ushort**, uint*, uint*, void**, uint*, int> RpcBindingInqAuthInfo = &RpcBindingInqAuthInfoW;

        [NativeTypeName("#define RpcBindingSetAuthInfo RpcBindingSetAuthInfoW")]
        public static readonly delegate*<void*, ushort*, uint, uint, void*, uint, int> RpcBindingSetAuthInfo = &RpcBindingSetAuthInfoW;

        [NativeTypeName("#define RpcServerRegisterAuthInfo RpcServerRegisterAuthInfoW")]
        public static readonly delegate*<ushort*, uint, delegate* unmanaged<void*, ushort*, uint, void**, int*, void>, void*, int> RpcServerRegisterAuthInfo = &RpcServerRegisterAuthInfoW;

        [NativeTypeName("#define RpcBindingInqAuthInfoEx RpcBindingInqAuthInfoExW")]
        public static readonly delegate*<void*, ushort**, uint*, uint*, void**, uint*, uint, RPC_SECURITY_QOS*, int> RpcBindingInqAuthInfoEx = &RpcBindingInqAuthInfoExW;

        [NativeTypeName("#define RpcBindingSetAuthInfoEx RpcBindingSetAuthInfoExW")]
        public static readonly delegate*<void*, ushort*, uint, uint, void*, uint, RPC_SECURITY_QOS*, int> RpcBindingSetAuthInfoEx = &RpcBindingSetAuthInfoExW;

        [NativeTypeName("#define UuidFromString UuidFromStringW")]
        public static readonly delegate*<ushort*, Guid*, int> UuidFromString = &UuidFromStringW;

        [NativeTypeName("#define UuidToString UuidToStringW")]
        public static readonly delegate*<Guid*, ushort**, int> UuidToString = &UuidToStringW;

        [NativeTypeName("#define RpcEpRegisterNoReplace RpcEpRegisterNoReplaceW")]
        public static readonly delegate*<void*, RPC_BINDING_VECTOR*, UUID_VECTOR*, ushort*, int> RpcEpRegisterNoReplace = &RpcEpRegisterNoReplaceW;

        [NativeTypeName("#define RpcEpRegister RpcEpRegisterW")]
        public static readonly delegate*<void*, RPC_BINDING_VECTOR*, UUID_VECTOR*, ushort*, int> RpcEpRegister = &RpcEpRegisterW;

        [NativeTypeName("#define DCE_C_ERROR_STRING_LEN 256")]
        public const int DCE_C_ERROR_STRING_LEN = 256;

        [NativeTypeName("#define DceErrorInqText DceErrorInqTextW")]
        public static readonly delegate*<int, ushort*, int> DceErrorInqText = &DceErrorInqTextW;

        [NativeTypeName("#define RPC_C_EP_ALL_ELTS 0")]
        public const int RPC_C_EP_ALL_ELTS = 0;

        [NativeTypeName("#define RPC_C_EP_MATCH_BY_IF 1")]
        public const int RPC_C_EP_MATCH_BY_IF = 1;

        [NativeTypeName("#define RPC_C_EP_MATCH_BY_OBJ 2")]
        public const int RPC_C_EP_MATCH_BY_OBJ = 2;

        [NativeTypeName("#define RPC_C_EP_MATCH_BY_BOTH 3")]
        public const int RPC_C_EP_MATCH_BY_BOTH = 3;

        [NativeTypeName("#define RPC_C_VERS_ALL 1")]
        public const int RPC_C_VERS_ALL = 1;

        [NativeTypeName("#define RPC_C_VERS_COMPATIBLE 2")]
        public const int RPC_C_VERS_COMPATIBLE = 2;

        [NativeTypeName("#define RPC_C_VERS_EXACT 3")]
        public const int RPC_C_VERS_EXACT = 3;

        [NativeTypeName("#define RPC_C_VERS_MAJOR_ONLY 4")]
        public const int RPC_C_VERS_MAJOR_ONLY = 4;

        [NativeTypeName("#define RPC_C_VERS_UPTO 5")]
        public const int RPC_C_VERS_UPTO = 5;

        [NativeTypeName("#define RpcMgmtEpEltInqNext RpcMgmtEpEltInqNextW")]
        public static readonly delegate*<void**, RPC_IF_ID*, void**, Guid*, ushort**, int> RpcMgmtEpEltInqNext = &RpcMgmtEpEltInqNextW;

        [NativeTypeName("#define RPC_C_MGMT_INQ_IF_IDS 0")]
        public const int RPC_C_MGMT_INQ_IF_IDS = 0;

        [NativeTypeName("#define RPC_C_MGMT_INQ_PRINC_NAME 1")]
        public const int RPC_C_MGMT_INQ_PRINC_NAME = 1;

        [NativeTypeName("#define RPC_C_MGMT_INQ_STATS 2")]
        public const int RPC_C_MGMT_INQ_STATS = 2;

        [NativeTypeName("#define RPC_C_MGMT_IS_SERVER_LISTEN 3")]
        public const int RPC_C_MGMT_IS_SERVER_LISTEN = 3;

        [NativeTypeName("#define RPC_C_MGMT_STOP_SERVER_LISTEN 4")]
        public const int RPC_C_MGMT_STOP_SERVER_LISTEN = 4;

        [NativeTypeName("#define RPC_C_PARM_MAX_PACKET_LENGTH 1")]
        public const int RPC_C_PARM_MAX_PACKET_LENGTH = 1;

        [NativeTypeName("#define RPC_C_PARM_BUFFER_LENGTH 2")]
        public const int RPC_C_PARM_BUFFER_LENGTH = 2;

        [NativeTypeName("#define RPC_IF_AUTOLISTEN 0x0001")]
        public const int RPC_IF_AUTOLISTEN = 0x0001;

        [NativeTypeName("#define RPC_IF_OLE 0x0002")]
        public const int RPC_IF_OLE = 0x0002;

        [NativeTypeName("#define RPC_IF_ALLOW_UNKNOWN_AUTHORITY 0x0004")]
        public const int RPC_IF_ALLOW_UNKNOWN_AUTHORITY = 0x0004;

        [NativeTypeName("#define RPC_IF_ALLOW_SECURE_ONLY 0x0008")]
        public const int RPC_IF_ALLOW_SECURE_ONLY = 0x0008;

        [NativeTypeName("#define RPC_IF_ALLOW_CALLBACKS_WITH_NO_AUTH 0x0010")]
        public const int RPC_IF_ALLOW_CALLBACKS_WITH_NO_AUTH = 0x0010;

        [NativeTypeName("#define RPC_IF_ALLOW_LOCAL_ONLY 0x0020")]
        public const int RPC_IF_ALLOW_LOCAL_ONLY = 0x0020;

        [NativeTypeName("#define RPC_IF_SEC_NO_CACHE 0x0040")]
        public const int RPC_IF_SEC_NO_CACHE = 0x0040;

        [NativeTypeName("#define RPC_IF_SEC_CACHE_PER_PROC 0x0080")]
        public const int RPC_IF_SEC_CACHE_PER_PROC = 0x0080;

        [NativeTypeName("#define RPC_IF_ASYNC_CALLBACK 0x0100")]
        public const int RPC_IF_ASYNC_CALLBACK = 0x0100;

        [NativeTypeName("#define RPC_FW_IF_FLAG_DCOM 0x0001")]
        public const int RPC_FW_IF_FLAG_DCOM = 0x0001;

        [NativeTypeName("#define RpcServerInterfaceGroupCreate RpcServerInterfaceGroupCreateW")]
        public static readonly delegate*<RPC_INTERFACE_TEMPLATEW*, uint, RPC_ENDPOINT_TEMPLATEW*, uint, uint, delegate* unmanaged<void*, void*, uint, void>, void*, void**, int> RpcServerInterfaceGroupCreate = &RpcServerInterfaceGroupCreateW;

        [NativeTypeName("#define RPC_CONTEXT_HANDLE_DEFAULT_GUARD ((void *)(ULONG_PTR)0xFFFFF00D)")]
        public static readonly void* RPC_CONTEXT_HANDLE_DEFAULT_GUARD = ((void*)((ulong)(0xFFFFF00D)));

        [NativeTypeName("#define RPC_CONTEXT_HANDLE_DEFAULT_FLAGS 0x00000000UL")]
        public const uint RPC_CONTEXT_HANDLE_DEFAULT_FLAGS = 0x00000000U;

        [NativeTypeName("#define RPC_CONTEXT_HANDLE_FLAGS 0x30000000UL")]
        public const uint RPC_CONTEXT_HANDLE_FLAGS = 0x30000000U;

        [NativeTypeName("#define RPC_CONTEXT_HANDLE_SERIALIZE 0x10000000UL")]
        public const uint RPC_CONTEXT_HANDLE_SERIALIZE = 0x10000000U;

        [NativeTypeName("#define RPC_CONTEXT_HANDLE_DONT_SERIALIZE 0x20000000UL")]
        public const uint RPC_CONTEXT_HANDLE_DONT_SERIALIZE = 0x20000000U;

        [NativeTypeName("#define RPC_TYPE_STRICT_CONTEXT_HANDLE 0x40000000UL")]
        public const uint RPC_TYPE_STRICT_CONTEXT_HANDLE = 0x40000000U;

        [NativeTypeName("#define RPC_TYPE_DISCONNECT_EVENT_CONTEXT_HANDLE 0x80000000UL")]
        public const uint RPC_TYPE_DISCONNECT_EVENT_CONTEXT_HANDLE = 0x80000000U;

        [NativeTypeName("#define RPC_NCA_FLAGS_DEFAULT 0x00000000")]
        public const int RPC_NCA_FLAGS_DEFAULT = 0x00000000;

        [NativeTypeName("#define RPC_NCA_FLAGS_IDEMPOTENT 0x00000001")]
        public const int RPC_NCA_FLAGS_IDEMPOTENT = 0x00000001;

        [NativeTypeName("#define RPC_NCA_FLAGS_BROADCAST 0x00000002")]
        public const int RPC_NCA_FLAGS_BROADCAST = 0x00000002;

        [NativeTypeName("#define RPC_NCA_FLAGS_MAYBE 0x00000004")]
        public const int RPC_NCA_FLAGS_MAYBE = 0x00000004;

        [NativeTypeName("#define RPCFLG_HAS_GUARANTEE 0x00000010UL")]
        public const uint RPCFLG_HAS_GUARANTEE = 0x00000010U;

        [NativeTypeName("#define RPCFLG_WINRT_REMOTE_ASYNC 0x00000020UL")]
        public const uint RPCFLG_WINRT_REMOTE_ASYNC = 0x00000020U;

        [NativeTypeName("#define RPC_BUFFER_COMPLETE 0x00001000")]
        public const int RPC_BUFFER_COMPLETE = 0x00001000;

        [NativeTypeName("#define RPC_BUFFER_PARTIAL 0x00002000")]
        public const int RPC_BUFFER_PARTIAL = 0x00002000;

        [NativeTypeName("#define RPC_BUFFER_EXTRA 0x00004000")]
        public const int RPC_BUFFER_EXTRA = 0x00004000;

        [NativeTypeName("#define RPC_BUFFER_ASYNC 0x00008000")]
        public const int RPC_BUFFER_ASYNC = 0x00008000;

        [NativeTypeName("#define RPC_BUFFER_NONOTIFY 0x00010000")]
        public const int RPC_BUFFER_NONOTIFY = 0x00010000;

        [NativeTypeName("#define RPCFLG_MESSAGE 0x01000000UL")]
        public const uint RPCFLG_MESSAGE = 0x01000000U;

        [NativeTypeName("#define RPCFLG_AUTO_COMPLETE 0x08000000UL")]
        public const uint RPCFLG_AUTO_COMPLETE = 0x08000000U;

        [NativeTypeName("#define RPCFLG_LOCAL_CALL 0x10000000UL")]
        public const uint RPCFLG_LOCAL_CALL = 0x10000000U;

        [NativeTypeName("#define RPCFLG_INPUT_SYNCHRONOUS 0x20000000UL")]
        public const uint RPCFLG_INPUT_SYNCHRONOUS = 0x20000000U;

        [NativeTypeName("#define RPCFLG_ASYNCHRONOUS 0x40000000UL")]
        public const uint RPCFLG_ASYNCHRONOUS = 0x40000000U;

        [NativeTypeName("#define RPCFLG_NON_NDR 0x80000000UL")]
        public const uint RPCFLG_NON_NDR = 0x80000000U;

        [NativeTypeName("#define RPCFLG_HAS_MULTI_SYNTAXES 0x02000000UL")]
        public const uint RPCFLG_HAS_MULTI_SYNTAXES = 0x02000000U;

        [NativeTypeName("#define RPCFLG_HAS_CALLBACK 0x04000000UL")]
        public const uint RPCFLG_HAS_CALLBACK = 0x04000000U;

        [NativeTypeName("#define RPCFLG_ACCESSIBILITY_BIT1 0x00100000UL")]
        public const uint RPCFLG_ACCESSIBILITY_BIT1 = 0x00100000U;

        [NativeTypeName("#define RPCFLG_ACCESSIBILITY_BIT2 0x00200000UL")]
        public const uint RPCFLG_ACCESSIBILITY_BIT2 = 0x00200000U;

        [NativeTypeName("#define RPCFLG_ACCESS_LOCAL 0x00400000UL")]
        public const uint RPCFLG_ACCESS_LOCAL = 0x00400000U;

        [NativeTypeName("#define NDR_CUSTOM_OR_DEFAULT_ALLOCATOR 0x10000000UL")]
        public const uint NDR_CUSTOM_OR_DEFAULT_ALLOCATOR = 0x10000000U;

        [NativeTypeName("#define NDR_DEFAULT_ALLOCATOR 0x20000000UL")]
        public const uint NDR_DEFAULT_ALLOCATOR = 0x20000000U;

        [NativeTypeName("#define RPCFLG_NDR64_CONTAINS_ARM_LAYOUT 0x04000000UL")]
        public const uint RPCFLG_NDR64_CONTAINS_ARM_LAYOUT = 0x04000000U;

        [NativeTypeName("#define RPCFLG_SENDER_WAITING_FOR_REPLY 0x00800000UL")]
        public const uint RPCFLG_SENDER_WAITING_FOR_REPLY = 0x00800000U;

        [NativeTypeName("#define RPC_FLAGS_VALID_BIT 0x00008000")]
        public const int RPC_FLAGS_VALID_BIT = 0x00008000;

        [NativeTypeName("#define NT351_INTERFACE_SIZE 0x40")]
        public const int NT351_INTERFACE_SIZE = 0x40;

        [NativeTypeName("#define RPC_INTERFACE_HAS_PIPES 0x0001")]
        public const int RPC_INTERFACE_HAS_PIPES = 0x0001;

        [NativeTypeName("#define RPC_SYSTEM_HANDLE_FREE_UNRETRIEVED 1")]
        public const int RPC_SYSTEM_HANDLE_FREE_UNRETRIEVED = 1;

        [NativeTypeName("#define RPC_SYSTEM_HANDLE_FREE_RETRIEVED 2")]
        public const int RPC_SYSTEM_HANDLE_FREE_RETRIEVED = 2;

        [NativeTypeName("#define RPC_SYSTEM_HANDLE_FREE_ALL 3")]
        public const int RPC_SYSTEM_HANDLE_FREE_ALL = 3;

        [NativeTypeName("#define RPC_SYSTEM_HANDLE_FREE_ERROR_ON_CLOSE 4")]
        public const int RPC_SYSTEM_HANDLE_FREE_ERROR_ON_CLOSE = 4;

        [NativeTypeName("#define I_RpcNsBindingSetEntryName I_RpcNsBindingSetEntryNameW")]
        public static readonly delegate*<void*, uint, ushort*, int> I_RpcNsBindingSetEntryName = &I_RpcNsBindingSetEntryNameW;

        [NativeTypeName("#define I_RpcServerUseProtseqEp2 I_RpcServerUseProtseqEp2W")]
        public static readonly delegate*<ushort*, ushort*, uint, ushort*, void*, void*, int> I_RpcServerUseProtseqEp2 = &I_RpcServerUseProtseqEp2W;

        [NativeTypeName("#define I_RpcServerUseProtseq2 I_RpcServerUseProtseq2W")]
        public static readonly delegate*<ushort*, ushort*, uint, void*, void*, int> I_RpcServerUseProtseq2 = &I_RpcServerUseProtseq2W;

        [NativeTypeName("#define I_RpcBindingInqDynamicEndpoint I_RpcBindingInqDynamicEndpointW")]
        public static readonly delegate*<void*, ushort**, int> I_RpcBindingInqDynamicEndpoint = &I_RpcBindingInqDynamicEndpointW;

        [NativeTypeName("#define TRANSPORT_TYPE_CN 0x01")]
        public const int TRANSPORT_TYPE_CN = 0x01;

        [NativeTypeName("#define TRANSPORT_TYPE_DG 0x02")]
        public const int TRANSPORT_TYPE_DG = 0x02;

        [NativeTypeName("#define TRANSPORT_TYPE_LPC 0x04")]
        public const int TRANSPORT_TYPE_LPC = 0x04;

        [NativeTypeName("#define TRANSPORT_TYPE_WMSG 0x08")]
        public const int TRANSPORT_TYPE_WMSG = 0x08;

        [NativeTypeName("#define RPC_P_ADDR_FORMAT_TCP_IPV4 1")]
        public const int RPC_P_ADDR_FORMAT_TCP_IPV4 = 1;

        [NativeTypeName("#define RPC_P_ADDR_FORMAT_TCP_IPV6 2")]
        public const int RPC_P_ADDR_FORMAT_TCP_IPV6 = 2;

        [NativeTypeName("#define I_RpcServerUnregisterEndpoint I_RpcServerUnregisterEndpointW")]
        public static readonly delegate*<ushort*, ushort*, int> I_RpcServerUnregisterEndpoint = &I_RpcServerUnregisterEndpointW;

        [NativeTypeName("#define RPC_C_OPT_SESSION_ID (6)")]
        public const int RPC_C_OPT_SESSION_ID = (6);

        [NativeTypeName("#define RPC_C_OPT_COOKIE_AUTH (7)")]
        public const int RPC_C_OPT_COOKIE_AUTH = (7);

        [NativeTypeName("#define RPC_C_OPT_RESOURCE_TYPE_UUID (8)")]
        public const int RPC_C_OPT_RESOURCE_TYPE_UUID = (8);

        [NativeTypeName("#define RPC_PROXY_CONNECTION_TYPE_IN_PROXY 0")]
        public const int RPC_PROXY_CONNECTION_TYPE_IN_PROXY = 0;

        [NativeTypeName("#define RPC_PROXY_CONNECTION_TYPE_OUT_PROXY 1")]
        public const int RPC_PROXY_CONNECTION_TYPE_OUT_PROXY = 1;

        [NativeTypeName("#define RPC_C_OPT_PRIVATE_SUPPRESS_WAKE 1")]
        public const int RPC_C_OPT_PRIVATE_SUPPRESS_WAKE = 1;

        [NativeTypeName("#define RPC_C_OPT_PRIVATE_DO_NOT_DISTURB 2")]
        public const int RPC_C_OPT_PRIVATE_DO_NOT_DISTURB = 2;

        [NativeTypeName("#define RPC_C_OPT_PRIVATE_BREAK_ON_SUSPEND 3")]
        public const int RPC_C_OPT_PRIVATE_BREAK_ON_SUSPEND = 3;

        [NativeTypeName("#define I_RRPCUNINITIALIZENDROLE_EXPORT_NAME reinterpret_cast<LPCSTR>(static_cast<ULONG_PTR>(1000))")]
        public static readonly sbyte* I_RRPCUNINITIALIZENDROLE_EXPORT_NAME = (sbyte*)((ulong)(1000));
    }
}

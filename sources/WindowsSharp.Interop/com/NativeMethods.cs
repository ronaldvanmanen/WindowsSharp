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
using static WindowsSharp.Interop.CLSCTX;

namespace WindowsSharp.Interop
{
    public static unsafe partial class NativeMethods
    {
        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IUnknown_QueryInterface_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IUnknown_QueryInterface_Proxy(IUnknown* This, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IUnknown_QueryInterface_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IUnknown_QueryInterface_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IUnknown_AddRef_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint IUnknown_AddRef_Proxy(IUnknown* This);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IUnknown_AddRef_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IUnknown_AddRef_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IUnknown_Release_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint IUnknown_Release_Proxy(IUnknown* This);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IUnknown_Release_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IUnknown_Release_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IClassFactory_RemoteCreateInstance_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IClassFactory_RemoteCreateInstance_Proxy(IClassFactory* This, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppvObject);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IClassFactory_RemoteCreateInstance_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IClassFactory_RemoteCreateInstance_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IClassFactory_RemoteLockServer_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IClassFactory_RemoteLockServer_Proxy(IClassFactory* This, [NativeTypeName("BOOL")] int fLock);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IClassFactory_RemoteLockServer_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IClassFactory_RemoteLockServer_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IClassFactory_CreateInstance_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IClassFactory_CreateInstance_Proxy(IClassFactory* This, IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IClassFactory_CreateInstance_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IClassFactory_CreateInstance_Stub(IClassFactory* This, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppvObject);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IClassFactory_LockServer_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IClassFactory_LockServer_Proxy(IClassFactory* This, [NativeTypeName("BOOL")] int fLock);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IClassFactory_LockServer_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IClassFactory_LockServer_Stub(IClassFactory* This, [NativeTypeName("BOOL")] int fLock);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IEnumUnknown_RemoteNext_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IEnumUnknown_RemoteNext_Proxy(IEnumUnknown* This, [NativeTypeName("ULONG")] uint celt, IUnknown** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IEnumUnknown_RemoteNext_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IEnumUnknown_RemoteNext_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IEnumString_RemoteNext_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IEnumString_RemoteNext_Proxy(IEnumString* This, [NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLESTR *")] ushort** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IEnumString_RemoteNext_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IEnumString_RemoteNext_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ISequentialStream_RemoteRead_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ISequentialStream_RemoteRead_Proxy(ISequentialStream* This, byte* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ISequentialStream_RemoteRead_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void ISequentialStream_RemoteRead_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ISequentialStream_RemoteWrite_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ISequentialStream_RemoteWrite_Proxy(ISequentialStream* This, [NativeTypeName("const byte *")] byte* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ISequentialStream_RemoteWrite_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void ISequentialStream_RemoteWrite_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IStream_RemoteSeek_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_RemoteSeek_Proxy(IStream* This, LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IStream_RemoteSeek_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IStream_RemoteSeek_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IStream_RemoteCopyTo_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_RemoteCopyTo_Proxy(IStream* This, IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IStream_RemoteCopyTo_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        public static extern void IStream_RemoteCopyTo_Stub(IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, [NativeTypeName("PRPC_MESSAGE")] RPC_MESSAGE* _pRpcMessage, [NativeTypeName("DWORD *")] uint* _pdwStubPhase);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IEnumUnknown_Next_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IEnumUnknown_Next_Proxy(IEnumUnknown* This, [NativeTypeName("ULONG")] uint celt, IUnknown** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IEnumUnknown_Next_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IEnumUnknown_Next_Stub(IEnumUnknown* This, [NativeTypeName("ULONG")] uint celt, IUnknown** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IEnumString_Next_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IEnumString_Next_Proxy(IEnumString* This, [NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLESTR *")] ushort** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IEnumString_Next_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IEnumString_Next_Stub(IEnumString* This, [NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLESTR *")] ushort** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ISequentialStream_Read_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ISequentialStream_Read_Proxy(ISequentialStream* This, void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ISequentialStream_Read_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ISequentialStream_Read_Stub(ISequentialStream* This, byte* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ISequentialStream_Write_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ISequentialStream_Write_Proxy(ISequentialStream* This, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ISequentialStream_Write_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ISequentialStream_Write_Stub(ISequentialStream* This, [NativeTypeName("const byte *")] byte* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IStream_Seek_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_Seek_Proxy(IStream* This, LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IStream_Seek_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_Seek_Stub(IStream* This, LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IStream_CopyTo_Proxy"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_CopyTo_Proxy(IStream* This, IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IStream_CopyTo_Stub"]/*' />
        [DllImport("Rpcrt4.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_CopyTo_Stub(IStream* This, IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten);

        [NativeTypeName("#define ROTREGFLAGS_ALLOWANYCLIENT 0x1")]
        public const int ROTREGFLAGS_ALLOWANYCLIENT = 0x1;

        [NativeTypeName("#define APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP 0x1")]
        public const int APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP = 0x1;

        [NativeTypeName("#define APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND 0x2")]
        public const int APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND = 0x2;

        [NativeTypeName("#define APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY 0x4")]
        public const int APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY = 0x4;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN 0x8")]
        public const int APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN = 0x8;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION 0x10")]
        public const int APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION = 0x10;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY 0x20")]
        public const int APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY = 0x20;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED1 0x40")]
        public const int APPIDREGFLAGS_RESERVED1 = 0x40;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED2 0x80")]
        public const int APPIDREGFLAGS_RESERVED2 = 0x80;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED3 0x100")]
        public const int APPIDREGFLAGS_RESERVED3 = 0x100;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED4 0x200")]
        public const int APPIDREGFLAGS_RESERVED4 = 0x200;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED5 0x400")]
        public const int APPIDREGFLAGS_RESERVED5 = 0x400;

        [NativeTypeName("#define APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU 0x800")]
        public const int APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU = 0x800;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED7 0x1000")]
        public const int APPIDREGFLAGS_RESERVED7 = 0x1000;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED8 0x2000")]
        public const int APPIDREGFLAGS_RESERVED8 = 0x2000;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED9 0x4000")]
        public const int APPIDREGFLAGS_RESERVED9 = 0x4000;

        [NativeTypeName("#define DCOMSCM_ACTIVATION_USE_ALL_AUTHNSERVICES 0x1")]
        public const int DCOMSCM_ACTIVATION_USE_ALL_AUTHNSERVICES = 0x1;

        [NativeTypeName("#define DCOMSCM_ACTIVATION_DISALLOW_UNSECURE_CALL 0x2")]
        public const int DCOMSCM_ACTIVATION_DISALLOW_UNSECURE_CALL = 0x2;

        [NativeTypeName("#define DCOMSCM_RESOLVE_USE_ALL_AUTHNSERVICES 0x4")]
        public const int DCOMSCM_RESOLVE_USE_ALL_AUTHNSERVICES = 0x4;

        [NativeTypeName("#define DCOMSCM_RESOLVE_DISALLOW_UNSECURE_CALL 0x8")]
        public const int DCOMSCM_RESOLVE_DISALLOW_UNSECURE_CALL = 0x8;

        [NativeTypeName("#define DCOMSCM_PING_USE_MID_AUTHNSERVICE 0x10")]
        public const int DCOMSCM_PING_USE_MID_AUTHNSERVICE = 0x10;

        [NativeTypeName("#define DCOMSCM_PING_DISALLOW_UNSECURE_CALL 0x20")]
        public const int DCOMSCM_PING_DISALLOW_UNSECURE_CALL = 0x20;

        [NativeTypeName("#define CLSCTX_VALID_MASK (CLSCTX_INPROC_SERVER | \\\r\n    CLSCTX_INPROC_HANDLER | \\\r\n    CLSCTX_LOCAL_SERVER | \\\r\n    CLSCTX_INPROC_SERVER16 | \\\r\n    CLSCTX_REMOTE_SERVER | \\\r\n    CLSCTX_NO_CODE_DOWNLOAD | \\\r\n    CLSCTX_NO_CUSTOM_MARSHAL | \\\r\n    CLSCTX_ENABLE_CODE_DOWNLOAD | \\\r\n    CLSCTX_NO_FAILURE_LOG | \\\r\n    CLSCTX_DISABLE_AAA | \\\r\n    CLSCTX_ENABLE_AAA | \\\r\n    CLSCTX_FROM_DEFAULT_CONTEXT | \\\r\n    CLSCTX_ACTIVATE_X86_SERVER | \\\r\n    CLSCTX_ACTIVATE_64_BIT_SERVER | \\\r\n    CLSCTX_ENABLE_CLOAKING | \\\r\n    CLSCTX_APPCONTAINER | \\\r\n    CLSCTX_ACTIVATE_AAA_AS_IU | \\\r\n    CLSCTX_RESERVED6 | \\\r\n    CLSCTX_ACTIVATE_ARM32_SERVER | \\\r\n    CLSCTX_PS_DLL)")]
        public const int CLSCTX_VALID_MASK = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_INPROC_HANDLER) | (int)(CLSCTX_LOCAL_SERVER) | (int)(CLSCTX_INPROC_SERVER16) | (int)(CLSCTX_REMOTE_SERVER) | (int)(CLSCTX_NO_CODE_DOWNLOAD) | (int)(CLSCTX_NO_CUSTOM_MARSHAL) | (int)(CLSCTX_ENABLE_CODE_DOWNLOAD) | (int)(CLSCTX_NO_FAILURE_LOG) | (int)(CLSCTX_DISABLE_AAA) | (int)(CLSCTX_ENABLE_AAA) | (int)(CLSCTX_FROM_DEFAULT_CONTEXT) | (int)(CLSCTX_ACTIVATE_X86_SERVER) | (int)(CLSCTX_ACTIVATE_64_BIT_SERVER) | (int)(CLSCTX_ENABLE_CLOAKING) | (int)(CLSCTX_APPCONTAINER) | (int)(CLSCTX_ACTIVATE_AAA_AS_IU) | (int)(CLSCTX_RESERVED6) | (int)(CLSCTX_ACTIVATE_ARM32_SERVER) | (int)(CLSCTX_PS_DLL));

        [NativeTypeName("#define COLE_DEFAULT_PRINCIPAL ( ( OLECHAR * )( INT_PTR  )-1 )")]
        public static readonly ushort* COLE_DEFAULT_PRINCIPAL = unchecked((ushort*)((long)(-1)));

        [NativeTypeName("#define COLE_DEFAULT_AUTHINFO ( ( void * )( INT_PTR  )-1 )")]
        public static readonly void* COLE_DEFAULT_AUTHINFO = unchecked((void*)((long)(-1)));

        public static readonly Guid IID_IUnknown = new Guid(0x00000000, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_AsyncIUnknown = new Guid(0x000E0000, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IClassFactory = new Guid(0x00000001, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IMarshal = new Guid(0x00000003, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_INoMarshal = new Guid(0xECC8691B, 0xC1DB, 0x4DC0, 0x85, 0x5E, 0x65, 0xF6, 0xC5, 0x51, 0xAF, 0x49);

        public static readonly Guid IID_IAgileObject = new Guid(0x94EA2B94, 0xE9CC, 0x49E0, 0xC0, 0xFF, 0xEE, 0x64, 0xCA, 0x8F, 0x5B, 0x90);

        public static readonly Guid IID_IActivationFilter = new Guid(0x00000017, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IMarshal2 = new Guid(0x000001CF, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IMalloc = new Guid(0x00000002, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IStdMarshalInfo = new Guid(0x00000018, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IExternalConnection = new Guid(0x00000019, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IMultiQI = new Guid(0x00000020, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_AsyncIMultiQI = new Guid(0x000E0020, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IInternalUnknown = new Guid(0x00000021, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumUnknown = new Guid(0x00000100, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumString = new Guid(0x00000101, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ISequentialStream = new Guid(0x0C733A30, 0x2A1C, 0x11CE, 0xAD, 0xE5, 0x00, 0xAA, 0x00, 0x44, 0x77, 0x3D);

        public static readonly Guid IID_IStream = new Guid(0x0000000C, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IRpcChannelBuffer = new Guid(0xD5F56B60, 0x593B, 0x101A, 0xB5, 0x69, 0x08, 0x00, 0x2B, 0x2D, 0xBF, 0x7A);

        public static readonly Guid IID_IRpcChannelBuffer2 = new Guid(0x594F31D0, 0x7F19, 0x11D0, 0xB1, 0x94, 0x00, 0xA0, 0xC9, 0x0D, 0xC8, 0xBF);

        public static readonly Guid IID_IAsyncRpcChannelBuffer = new Guid(0xA5029FB6, 0x3C34, 0x11D1, 0x9C, 0x99, 0x00, 0xC0, 0x4F, 0xB9, 0x98, 0xAA);

        public static readonly Guid IID_IRpcChannelBuffer3 = new Guid(0x25B15600, 0x0115, 0x11D0, 0xBF, 0x0D, 0x00, 0xAA, 0x00, 0xB8, 0xDF, 0xD2);

        public static readonly Guid IID_IRpcSyntaxNegotiate = new Guid(0x58A08519, 0x24C8, 0x4935, 0xB4, 0x82, 0x3F, 0xD8, 0x23, 0x33, 0x3A, 0x4F);

        public static readonly Guid IID_IRpcProxyBuffer = new Guid(0xD5F56A34, 0x593B, 0x101A, 0xB5, 0x69, 0x08, 0x00, 0x2B, 0x2D, 0xBF, 0x7A);

        public static readonly Guid IID_IRpcStubBuffer = new Guid(0xD5F56AFC, 0x593B, 0x101A, 0xB5, 0x69, 0x08, 0x00, 0x2B, 0x2D, 0xBF, 0x7A);

        public static readonly Guid IID_IPSFactoryBuffer = new Guid(0xD5F569D0, 0x593B, 0x101A, 0xB5, 0x69, 0x08, 0x00, 0x2B, 0x2D, 0xBF, 0x7A);

        public static readonly Guid IID_IChannelHook = new Guid(0x1008C4A0, 0x7613, 0x11CF, 0x9A, 0xF1, 0x00, 0x20, 0xAF, 0x6E, 0x72, 0xF4);

        public static readonly Guid IID_IClientSecurity = new Guid(0x0000013D, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IServerSecurity = new Guid(0x0000013E, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IRpcOptions = new Guid(0x00000144, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IGlobalOptions = new Guid(0x0000015B, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ISurrogate = new Guid(0x00000022, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IGlobalInterfaceTable = new Guid(0x00000146, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ISynchronize = new Guid(0x00000030, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ISynchronizeHandle = new Guid(0x00000031, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ISynchronizeEvent = new Guid(0x00000032, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ISynchronizeContainer = new Guid(0x00000033, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ISynchronizeMutex = new Guid(0x00000025, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ICancelMethodCalls = new Guid(0x00000029, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IAsyncManager = new Guid(0x0000002A, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ICallFactory = new Guid(0x1C733A30, 0x2A1C, 0x11CE, 0xAD, 0xE5, 0x00, 0xAA, 0x00, 0x44, 0x77, 0x3D);

        public static readonly Guid IID_IRpcHelper = new Guid(0x00000149, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IReleaseMarshalBuffers = new Guid(0xEB0CB9E8, 0x7996, 0x11D2, 0x87, 0x2E, 0x00, 0x00, 0xF8, 0x08, 0x08, 0x59);

        public static readonly Guid IID_IWaitMultiple = new Guid(0x0000002B, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IAddrTrackingControl = new Guid(0x00000147, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IAddrExclusionControl = new Guid(0x00000148, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IPipeByte = new Guid(0xDB2F3ACA, 0x2F86, 0x11D1, 0x8E, 0x04, 0x00, 0xC0, 0x4F, 0xB9, 0x98, 0x9A);

        public static readonly Guid IID_AsyncIPipeByte = new Guid(0xDB2F3ACB, 0x2F86, 0x11D1, 0x8E, 0x04, 0x00, 0xC0, 0x4F, 0xB9, 0x98, 0x9A);

        public static readonly Guid IID_IPipeLong = new Guid(0xDB2F3ACC, 0x2F86, 0x11D1, 0x8E, 0x04, 0x00, 0xC0, 0x4F, 0xB9, 0x98, 0x9A);

        public static readonly Guid IID_AsyncIPipeLong = new Guid(0xDB2F3ACD, 0x2F86, 0x11D1, 0x8E, 0x04, 0x00, 0xC0, 0x4F, 0xB9, 0x98, 0x9A);

        public static readonly Guid IID_IPipeDouble = new Guid(0xDB2F3ACE, 0x2F86, 0x11D1, 0x8E, 0x04, 0x00, 0xC0, 0x4F, 0xB9, 0x98, 0x9A);

        public static readonly Guid IID_AsyncIPipeDouble = new Guid(0xDB2F3ACF, 0x2F86, 0x11D1, 0x8E, 0x04, 0x00, 0xC0, 0x4F, 0xB9, 0x98, 0x9A);

        public static readonly Guid IID_IComThreadingInfo = new Guid(0x000001CE, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IProcessInitControl = new Guid(0x72380D55, 0x8D2B, 0x43A3, 0x85, 0x13, 0x2B, 0x6E, 0xF3, 0x14, 0x34, 0xE9);

        public static readonly Guid IID_IFastRundown = new Guid(0x00000040, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IMarshalingStream = new Guid(0xD8F2F5E6, 0x6102, 0x4863, 0x9F, 0x26, 0x38, 0x9A, 0x46, 0x76, 0xEF, 0xDE);

        public static readonly Guid IID_IAgileReference = new Guid(0xC03F6A43, 0x65A4, 0x9818, 0x98, 0x7E, 0xE0, 0xB8, 0x10, 0xD2, 0xA6, 0xF2);
    }
}

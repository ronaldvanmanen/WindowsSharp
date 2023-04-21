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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='IRpcChannelBuffer3.xml' path='doc/member[@name="IRpcChannelBuffer3"]/*' />
    [Guid("25B15600-0115-11D0-BF0D-00AA00B8DFD2")]
    [NativeTypeName("struct IRpcChannelBuffer3 : IRpcChannelBuffer2")]
    [NativeInheritance("IRpcChannelBuffer2")]
    public unsafe partial struct IRpcChannelBuffer3
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, Guid*, void**, int>)(lpVtbl[0]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, uint>)(lpVtbl[1]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, uint>)(lpVtbl[2]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IRpcChannelBuffer.GetBuffer" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        /// <inheritdoc cref="IRpcChannelBuffer.SendReceive" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        /// <inheritdoc cref="IRpcChannelBuffer.FreeBuffer" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer(RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage);
        }

        /// <inheritdoc cref="IRpcChannelBuffer.GetDestCtx" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, uint*, void**, int>)(lpVtbl[6]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        /// <inheritdoc cref="IRpcChannelBuffer.IsConnected" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, int>)(lpVtbl[7]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IRpcChannelBuffer2.GetProtocolVersion" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, uint*, int>)(lpVtbl[8]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        /// <include file='IRpcChannelBuffer3.xml' path='doc/member[@name="IRpcChannelBuffer3.Send"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Send(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[9]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        /// <include file='IRpcChannelBuffer3.xml' path='doc/member[@name="IRpcChannelBuffer3.Receive"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Receive(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint, uint*, int>)(lpVtbl[10]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, ulSize, pulStatus);
        }

        /// <include file='IRpcChannelBuffer3.xml' path='doc/member[@name="IRpcChannelBuffer3.Cancel"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Cancel(RPCOLEMESSAGE* pMsg)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, int>)(lpVtbl[11]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg);
        }

        /// <include file='IRpcChannelBuffer3.xml' path='doc/member[@name="IRpcChannelBuffer3.GetCallContext"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetCallContext(RPCOLEMESSAGE* pMsg, [NativeTypeName("const IID &")] Guid* riid, void** pInterface)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, Guid*, void**, int>)(lpVtbl[12]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, riid, pInterface);
        }

        /// <include file='IRpcChannelBuffer3.xml' path='doc/member[@name="IRpcChannelBuffer3.GetDestCtxEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestCtxEx(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, void**, int>)(lpVtbl[13]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
        }

        /// <include file='IRpcChannelBuffer3.xml' path='doc/member[@name="IRpcChannelBuffer3.GetState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetState(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pState)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[14]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pState);
        }

        /// <include file='IRpcChannelBuffer3.xml' path='doc/member[@name="IRpcChannelBuffer3.RegisterAsync"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterAsync(RPCOLEMESSAGE* pMsg, IAsyncManager* pAsyncMgr)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer3*, RPCOLEMESSAGE*, IAsyncManager*, int>)(lpVtbl[15]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pAsyncMgr);
        }
    }
}

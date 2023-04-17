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
    /// <include file='IRpcChannelBuffer2.xml' path='doc/member[@name="IRpcChannelBuffer2"]/*' />
    [Guid("594F31D0-7F19-11D0-B194-00A0C90DC8BF")]
    [NativeTypeName("struct IRpcChannelBuffer2 : IRpcChannelBuffer")]
    [NativeInheritance("IRpcChannelBuffer")]
    public unsafe partial struct IRpcChannelBuffer2
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, Guid*, void**, int>)(lpVtbl[0]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, uint>)(lpVtbl[1]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, uint>)(lpVtbl[2]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IRpcChannelBuffer.GetBuffer" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        /// <inheritdoc cref="IRpcChannelBuffer.SendReceive" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        /// <inheritdoc cref="IRpcChannelBuffer.FreeBuffer" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer(RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pMessage);
        }

        /// <inheritdoc cref="IRpcChannelBuffer.GetDestCtx" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, uint*, void**, int>)(lpVtbl[6]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        /// <inheritdoc cref="IRpcChannelBuffer.IsConnected" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, int>)(lpVtbl[7]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IRpcChannelBuffer2.xml' path='doc/member[@name="IRpcChannelBuffer2.GetProtocolVersion"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, uint*, int>)(lpVtbl[8]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pdwVersion);
        }
    }
}

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
    /// <include file='IRpcProxyBuffer.xml' path='doc/member[@name="IRpcProxyBuffer"]/*' />
    [Guid("D5F56A34-593B-101A-B569-08002B2DBF7A")]
    [NativeTypeName("struct IRpcProxyBuffer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRpcProxyBuffer
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcProxyBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcProxyBuffer*, uint>)(lpVtbl[1]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcProxyBuffer*, uint>)(lpVtbl[2]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IRpcProxyBuffer.xml' path='doc/member[@name="IRpcProxyBuffer.Connect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Connect(IRpcChannelBuffer* pRpcChannelBuffer)
        {
            return ((delegate* unmanaged<IRpcProxyBuffer*, IRpcChannelBuffer*, int>)(lpVtbl[3]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), pRpcChannelBuffer);
        }

        /// <include file='IRpcProxyBuffer.xml' path='doc/member[@name="IRpcProxyBuffer.Disconnect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void Disconnect()
        {
            ((delegate* unmanaged<IRpcProxyBuffer*, void>)(lpVtbl[4]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }
    }
}

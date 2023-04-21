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
    /// <include file='AsyncIMultiQI.xml' path='doc/member[@name="AsyncIMultiQI"]/*' />
    [Guid("000E0020-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIMultiQI : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct AsyncIMultiQI
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint>)(lpVtbl[1]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint>)(lpVtbl[2]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this));
        }

        /// <include file='AsyncIMultiQI.xml' path='doc/member[@name="AsyncIMultiQI.Begin_QueryMultipleInterfaces"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_QueryMultipleInterfaces([NativeTypeName("ULONG")] uint cMQIs, MULTI_QI* pMQIs)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, uint, MULTI_QI*, int>)(lpVtbl[3]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), cMQIs, pMQIs);
        }

        /// <include file='AsyncIMultiQI.xml' path='doc/member[@name="AsyncIMultiQI.Finish_QueryMultipleInterfaces"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_QueryMultipleInterfaces(MULTI_QI* pMQIs)
        {
            return ((delegate* unmanaged<AsyncIMultiQI*, MULTI_QI*, int>)(lpVtbl[4]))((AsyncIMultiQI*)Unsafe.AsPointer(ref this), pMQIs);
        }
    }
}

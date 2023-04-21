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
    /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte"]/*' />
    [Guid("DB2F3ACB-2F86-11D1-8E04-00C04FB9989A")]
    [NativeTypeName("struct AsyncIPipeByte : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct AsyncIPipeByte
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIPipeByte*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIPipeByte*, uint>)(lpVtbl[1]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIPipeByte*, uint>)(lpVtbl[2]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }

        /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte.Begin_Pull"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_Pull([NativeTypeName("ULONG")] uint cRequest)
        {
            return ((delegate* unmanaged<AsyncIPipeByte*, uint, int>)(lpVtbl[3]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), cRequest);
        }

        /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte.Finish_Pull"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_Pull(byte* buf, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* unmanaged<AsyncIPipeByte*, byte*, uint*, int>)(lpVtbl[4]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), buf, pcReturned);
        }

        /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte.Begin_Push"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_Push(byte* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* unmanaged<AsyncIPipeByte*, byte*, uint, int>)(lpVtbl[5]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this), buf, cSent);
        }

        /// <include file='AsyncIPipeByte.xml' path='doc/member[@name="AsyncIPipeByte.Finish_Push"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_Push()
        {
            return ((delegate* unmanaged<AsyncIPipeByte*, int>)(lpVtbl[6]))((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }
    }
}

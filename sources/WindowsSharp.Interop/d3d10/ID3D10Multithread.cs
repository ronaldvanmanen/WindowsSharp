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
    /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread"]/*' />
    [Guid("9B7E4E00-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10Multithread : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D10Multithread
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Multithread*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Multithread*, uint>)(lpVtbl[1]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Multithread*, uint>)(lpVtbl[2]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread.Enter"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Enter()
        {
            ((delegate* unmanaged<ID3D10Multithread*, void>)(lpVtbl[3]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread.Leave"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void Leave()
        {
            ((delegate* unmanaged<ID3D10Multithread*, void>)(lpVtbl[4]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread.SetMultithreadProtected"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("BOOL")]
        public int SetMultithreadProtected([NativeTypeName("BOOL")] int bMTProtect)
        {
            return ((delegate* unmanaged<ID3D10Multithread*, int, int>)(lpVtbl[5]))((ID3D10Multithread*)Unsafe.AsPointer(ref this), bMTProtect);
        }

        /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread.GetMultithreadProtected"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("BOOL")]
        public int GetMultithreadProtected()
        {
            return ((delegate* unmanaged<ID3D10Multithread*, int>)(lpVtbl[6]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
        }
    }
}

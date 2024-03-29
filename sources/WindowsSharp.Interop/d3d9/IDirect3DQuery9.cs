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
    /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9"]/*' />
    [Guid("D9771460-A695-4F26-BBD3-27B840B541CC")]
    [NativeTypeName("struct IDirect3DQuery9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3DQuery9
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, uint>)(lpVtbl[1]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, uint>)(lpVtbl[2]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetDevice"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetType"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public new D3DQUERYTYPE GetType()
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, D3DQUERYTYPE>)(lpVtbl[4]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetDataSize"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        public uint GetDataSize()
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, uint>)(lpVtbl[5]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.Issue"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Issue([NativeTypeName("DWORD")] uint dwIssueFlags)
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, uint, int>)(lpVtbl[6]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), dwIssueFlags);
        }

        /// <include file='IDirect3DQuery9.xml' path='doc/member[@name="IDirect3DQuery9.GetData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetData(void* pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags)
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, void*, uint, uint, int>)(lpVtbl[7]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), pData, dwSize, dwGetDataFlags);
        }
    }
}

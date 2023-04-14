// WindowsSharp
//
// Copyright (C) 2021 Ronald van Manen <rvanmanen@gmail.com>
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
    /// <include file='IDirect3DIndexBuffer9.xml' path='doc/member[@name="IDirect3DIndexBuffer9"]/*' />
    [Guid("7C9DD65E-D3F7-4529-ACEE-785830ACDE35")]
    [NativeTypeName("struct IDirect3DIndexBuffer9 : IDirect3DResource9")]
    [NativeInheritance("IDirect3DResource9")]
    public unsafe partial struct IDirect3DIndexBuffer9
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint>)(lpVtbl[1]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint>)(lpVtbl[2]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DResource9.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="IDirect3DResource9.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        /// <inheritdoc cref="IDirect3DResource9.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        /// <inheritdoc cref="IDirect3DResource9.FreePrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, Guid*, int>)(lpVtbl[6]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid);
        }

        /// <inheritdoc cref="IDirect3DResource9.SetPriority" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint, uint>)(lpVtbl[7]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), PriorityNew);
        }

        /// <inheritdoc cref="IDirect3DResource9.GetPriority" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("DWORD")]
        public uint GetPriority()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint>)(lpVtbl[8]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DResource9.PreLoad" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void PreLoad()
        {
            ((delegate* unmanaged<IDirect3DIndexBuffer9*, void>)(lpVtbl[9]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DResource9.GetType" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public new D3DRESOURCETYPE GetType()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, D3DRESOURCETYPE>)(lpVtbl[10]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DIndexBuffer9.xml' path='doc/member[@name="IDirect3DIndexBuffer9.Lock"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Lock(uint OffsetToLock, uint SizeToLock, void** ppbData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint, uint, void**, uint, int>)(lpVtbl[11]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), OffsetToLock, SizeToLock, ppbData, Flags);
        }

        /// <include file='IDirect3DIndexBuffer9.xml' path='doc/member[@name="IDirect3DIndexBuffer9.Unlock"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, int>)(lpVtbl[12]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DIndexBuffer9.xml' path='doc/member[@name="IDirect3DIndexBuffer9.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3DINDEXBUFFER_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, D3DINDEXBUFFER_DESC*, int>)(lpVtbl[13]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}

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
    /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9"]/*' />
    [Guid("24F416E6-1F67-4AA7-B88E-D33F6F3128A1")]
    [NativeTypeName("struct IDirect3DVolume9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3DVolume9
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, uint>)(lpVtbl[1]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, uint>)(lpVtbl[2]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetDevice"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.SetPrivateData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetPrivateData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.FreePrivateData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, int>)(lpVtbl[6]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid);
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetContainer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)(lpVtbl[7]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), riid, ppContainer);
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3DVOLUME_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, D3DVOLUME_DESC*, int>)(lpVtbl[8]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.LockBox"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int LockBox(D3DLOCKED_BOX* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3DBOX* pBox, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, D3DLOCKED_BOX*, D3DBOX*, uint, int>)(lpVtbl[9]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), pLockedVolume, pBox, Flags);
        }

        /// <include file='IDirect3DVolume9.xml' path='doc/member[@name="IDirect3DVolume9.UnlockBox"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockBox()
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, int>)(lpVtbl[10]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
        }
    }
}

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
    /// <include file='ID3D10Texture3D.xml' path='doc/member[@name="ID3D10Texture3D"]/*' />
    [Guid("9B7E4C05-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10Texture3D : ID3D10Resource")]
    [NativeInheritance("ID3D10Resource")]
    public unsafe partial struct ID3D10Texture3D
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, uint>)(lpVtbl[1]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, uint>)(lpVtbl[2]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D10DeviceChild.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D10Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="ID3D10DeviceChild.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <inheritdoc cref="ID3D10DeviceChild.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <inheritdoc cref="ID3D10DeviceChild.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <inheritdoc cref="ID3D10Resource.GetType" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetType(D3D10_RESOURCE_DIMENSION* rType)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, D3D10_RESOURCE_DIMENSION*, void>)(lpVtbl[7]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), rType);
        }

        /// <inheritdoc cref="ID3D10Resource.SetEvictionPriority" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void SetEvictionPriority(uint EvictionPriority)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, uint, void>)(lpVtbl[8]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        /// <inheritdoc cref="ID3D10Resource.GetEvictionPriority" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public uint GetEvictionPriority()
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, uint>)(lpVtbl[9]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D10Texture3D.xml' path='doc/member[@name="ID3D10Texture3D.Map"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Map(uint Subresource, D3D10_MAP MapType, uint MapFlags, D3D10_MAPPED_TEXTURE3D* pMappedTex3D)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, uint, D3D10_MAP, uint, D3D10_MAPPED_TEXTURE3D*, int>)(lpVtbl[10]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), Subresource, MapType, MapFlags, pMappedTex3D);
        }

        /// <include file='ID3D10Texture3D.xml' path='doc/member[@name="ID3D10Texture3D.Unmap"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void Unmap(uint Subresource)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, uint, void>)(lpVtbl[11]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), Subresource);
        }

        /// <include file='ID3D10Texture3D.xml' path='doc/member[@name="ID3D10Texture3D.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void GetDesc(D3D10_TEXTURE3D_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, D3D10_TEXTURE3D_DESC*, void>)(lpVtbl[12]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}

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
    /// <include file='ID3D10Predicate.xml' path='doc/member[@name="ID3D10Predicate"]/*' />
    [Guid("9B7E4C10-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10Predicate : ID3D10Query")]
    [NativeInheritance("ID3D10Query")]
    public unsafe partial struct ID3D10Predicate
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Predicate*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Predicate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Predicate*, uint>)(lpVtbl[1]))((ID3D10Predicate*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Predicate*, uint>)(lpVtbl[2]))((ID3D10Predicate*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D10DeviceChild.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D10Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D10Predicate*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10Predicate*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="ID3D10DeviceChild.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D10Predicate*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10Predicate*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <inheritdoc cref="ID3D10DeviceChild.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10Predicate*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10Predicate*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <inheritdoc cref="ID3D10DeviceChild.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D10Predicate*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10Predicate*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <inheritdoc cref="ID3D10Asynchronous.Begin" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void Begin()
        {
            ((delegate* unmanaged<ID3D10Predicate*, void>)(lpVtbl[7]))((ID3D10Predicate*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D10Asynchronous.End" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void End()
        {
            ((delegate* unmanaged<ID3D10Predicate*, void>)(lpVtbl[8]))((ID3D10Predicate*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D10Asynchronous.GetData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetData(void* pData, uint DataSize, uint GetDataFlags)
        {
            return ((delegate* unmanaged<ID3D10Predicate*, void*, uint, uint, int>)(lpVtbl[9]))((ID3D10Predicate*)Unsafe.AsPointer(ref this), pData, DataSize, GetDataFlags);
        }

        /// <inheritdoc cref="ID3D10Asynchronous.GetDataSize" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public uint GetDataSize()
        {
            return ((delegate* unmanaged<ID3D10Predicate*, uint>)(lpVtbl[10]))((ID3D10Predicate*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D10Query.GetDesc" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void GetDesc(D3D10_QUERY_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D10Predicate*, D3D10_QUERY_DESC*, void>)(lpVtbl[11]))((ID3D10Predicate*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
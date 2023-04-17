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
    /// <include file='ID3D11Query.xml' path='doc/member[@name="ID3D11Query"]/*' />
    [Guid("D6C00747-87B7-425E-B84D-44D108560AFD")]
    [NativeTypeName("struct ID3D11Query : ID3D11Asynchronous")]
    [NativeInheritance("ID3D11Asynchronous")]
    public unsafe partial struct ID3D11Query
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Query*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Query*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Query*, uint>)(lpVtbl[1]))((ID3D11Query*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Query*, uint>)(lpVtbl[2]))((ID3D11Query*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11Query*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Query*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11Query*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Query*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11Query*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Query*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11Query*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Query*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <inheritdoc cref="ID3D11Asynchronous.GetDataSize" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public uint GetDataSize()
        {
            return ((delegate* unmanaged<ID3D11Query*, uint>)(lpVtbl[7]))((ID3D11Query*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11Query.xml' path='doc/member[@name="ID3D11Query.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GetDesc(D3D11_QUERY_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D11Query*, D3D11_QUERY_DESC*, void>)(lpVtbl[8]))((ID3D11Query*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}

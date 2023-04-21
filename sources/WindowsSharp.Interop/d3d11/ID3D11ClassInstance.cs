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
    /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance"]/*' />
    [Guid("A6CD7FAA-B0B7-4A2F-9436-8662A65797CB")]
    [NativeTypeName("struct ID3D11ClassInstance : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11ClassInstance
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11ClassInstance*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11ClassInstance*, uint>)(lpVtbl[1]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11ClassInstance*, uint>)(lpVtbl[2]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11ClassInstance*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11ClassInstance*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11ClassInstance*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11ClassInstance*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance.GetClassLinkage"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetClassLinkage(ID3D11ClassLinkage** ppLinkage)
        {
            ((delegate* unmanaged<ID3D11ClassInstance*, ID3D11ClassLinkage**, void>)(lpVtbl[7]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GetDesc(D3D11_CLASS_INSTANCE_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D11ClassInstance*, D3D11_CLASS_INSTANCE_DESC*, void>)(lpVtbl[8]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance.GetInstanceName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void GetInstanceName([NativeTypeName("LPSTR")] sbyte* pInstanceName, [NativeTypeName("SIZE_T *")] ulong* pBufferLength)
        {
            ((delegate* unmanaged<ID3D11ClassInstance*, sbyte*, ulong*, void>)(lpVtbl[9]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pInstanceName, pBufferLength);
        }

        /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance.GetTypeName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void GetTypeName([NativeTypeName("LPSTR")] sbyte* pTypeName, [NativeTypeName("SIZE_T *")] ulong* pBufferLength)
        {
            ((delegate* unmanaged<ID3D11ClassInstance*, sbyte*, ulong*, void>)(lpVtbl[10]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pTypeName, pBufferLength);
        }
    }
}

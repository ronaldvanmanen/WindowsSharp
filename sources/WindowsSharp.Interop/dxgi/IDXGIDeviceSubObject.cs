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
    /// <include file='IDXGIDeviceSubObject.xml' path='doc/member[@name="IDXGIDeviceSubObject"]/*' />
    [Guid("3D3E0379-F9DE-4D58-BB6C-18D62992F1A6")]
    [NativeTypeName("struct IDXGIDeviceSubObject : IDXGIObject")]
    [NativeInheritance("IDXGIObject")]
    public unsafe partial struct IDXGIDeviceSubObject
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIDeviceSubObject*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDeviceSubObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIDeviceSubObject*, uint>)(lpVtbl[1]))((IDXGIDeviceSubObject*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIDeviceSubObject*, uint>)(lpVtbl[2]))((IDXGIDeviceSubObject*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIDeviceSubObject*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDeviceSubObject*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIDeviceSubObject*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDeviceSubObject*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        /// <inheritdoc cref="IDXGIObject.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIDeviceSubObject*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDeviceSubObject*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.GetParent" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIDeviceSubObject*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDeviceSubObject*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        /// <include file='IDXGIDeviceSubObject.xml' path='doc/member[@name="IDXGIDeviceSubObject.GetDevice"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return ((delegate* unmanaged<IDXGIDeviceSubObject*, Guid*, void**, int>)(lpVtbl[7]))((IDXGIDeviceSubObject*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }
    }
}

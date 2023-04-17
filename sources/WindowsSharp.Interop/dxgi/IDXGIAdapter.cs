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
    /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter"]/*' />
    [Guid("2411E7E1-12AC-4CCF-BD14-9798E8534DC0")]
    [NativeTypeName("struct IDXGIAdapter : IDXGIObject")]
    [NativeInheritance("IDXGIObject")]
    public unsafe partial struct IDXGIAdapter
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIAdapter*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIAdapter*, uint>)(lpVtbl[1]))((IDXGIAdapter*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIAdapter*, uint>)(lpVtbl[2]))((IDXGIAdapter*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIAdapter*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIAdapter*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        /// <inheritdoc cref="IDXGIObject.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIAdapter*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.GetParent" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIAdapter*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.EnumOutputs"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EnumOutputs(uint Output, IDXGIOutput** ppOutput)
        {
            return ((delegate* unmanaged<IDXGIAdapter*, uint, IDXGIOutput**, int>)(lpVtbl[7]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), Output, ppOutput);
        }

        /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_ADAPTER_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGIAdapter*, DXGI_ADAPTER_DESC*, int>)(lpVtbl[8]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='IDXGIAdapter.xml' path='doc/member[@name="IDXGIAdapter.CheckInterfaceSupport"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CheckInterfaceSupport([NativeTypeName("const GUID &")] Guid* InterfaceName, LARGE_INTEGER* pUMDVersion)
        {
            return ((delegate* unmanaged<IDXGIAdapter*, Guid*, LARGE_INTEGER*, int>)(lpVtbl[9]))((IDXGIAdapter*)Unsafe.AsPointer(ref this), InterfaceName, pUMDVersion);
        }
    }
}

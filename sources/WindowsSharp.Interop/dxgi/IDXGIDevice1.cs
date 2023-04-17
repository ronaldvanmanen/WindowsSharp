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
    /// <include file='IDXGIDevice1.xml' path='doc/member[@name="IDXGIDevice1"]/*' />
    [Guid("77DB970F-6276-48BA-BA28-070143B4392C")]
    [NativeTypeName("struct IDXGIDevice1 : IDXGIDevice")]
    [NativeInheritance("IDXGIDevice")]
    public unsafe partial struct IDXGIDevice1
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIDevice1*, uint>)(lpVtbl[1]))((IDXGIDevice1*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIDevice1*, uint>)(lpVtbl[2]))((IDXGIDevice1*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        /// <inheritdoc cref="IDXGIObject.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.GetParent" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        /// <inheritdoc cref="IDXGIDevice.GetAdapter" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapter(IDXGIAdapter** pAdapter)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pAdapter);
        }

        /// <inheritdoc cref="IDXGIDevice.CreateSurface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("const DXGI_SURFACE_DESC *")] DXGI_SURFACE_DESC* pDesc, uint NumSurfaces, [NativeTypeName("DXGI_USAGE")] uint Usage, [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DXGI_SHARED_RESOURCE* pSharedResource, IDXGISurface** ppSurface)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, DXGI_SURFACE_DESC*, uint, uint, DXGI_SHARED_RESOURCE*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
        }

        /// <inheritdoc cref="IDXGIDevice.QueryResourceResidency" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int QueryResourceResidency([NativeTypeName("IUnknown *const *")] IUnknown** ppResources, DXGI_RESIDENCY* pResidencyStatus, uint NumResources)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, IUnknown**, DXGI_RESIDENCY*, uint, int>)(lpVtbl[9]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
        }

        /// <inheritdoc cref="IDXGIDevice.SetGPUThreadPriority" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetGPUThreadPriority(int Priority)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, int, int>)(lpVtbl[10]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Priority);
        }

        /// <inheritdoc cref="IDXGIDevice.GetGPUThreadPriority" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetGPUThreadPriority(int* pPriority)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, int*, int>)(lpVtbl[11]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pPriority);
        }

        /// <include file='IDXGIDevice1.xml' path='doc/member[@name="IDXGIDevice1.SetMaximumFrameLatency"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency(uint MaxLatency)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, uint, int>)(lpVtbl[12]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        /// <include file='IDXGIDevice1.xml' path='doc/member[@name="IDXGIDevice1.GetMaximumFrameLatency"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IDXGIDevice1*, uint*, int>)(lpVtbl[13]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pMaxLatency);
        }
    }
}

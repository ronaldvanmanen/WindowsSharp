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
    /// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1"]/*' />
    [Guid("770AAE78-F26F-4DBA-A829-253C83D1B387")]
    [NativeTypeName("struct IDXGIFactory1 : IDXGIFactory")]
    [NativeInheritance("IDXGIFactory")]
    public unsafe partial struct IDXGIFactory1
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIFactory1*, uint>)(lpVtbl[1]))((IDXGIFactory1*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIFactory1*, uint>)(lpVtbl[2]))((IDXGIFactory1*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        /// <inheritdoc cref="IDXGIObject.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.GetParent" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        /// <inheritdoc cref="IDXGIFactory.EnumAdapters" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, uint, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        /// <inheritdoc cref="IDXGIFactory.MakeWindowAssociation" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation([NativeTypeName("HWND")] HWND__* WindowHandle, uint Flags)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, HWND__*, uint, int>)(lpVtbl[8]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
        }

        /// <inheritdoc cref="IDXGIFactory.GetWindowAssociation" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation([NativeTypeName("HWND *")] HWND__** pWindowHandle)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, HWND__**, int>)(lpVtbl[9]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), pWindowHandle);
        }

        /// <inheritdoc cref="IDXGIFactory.CreateSwapChain" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain(IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, IUnknown*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain**, int>)(lpVtbl[10]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
        }

        /// <inheritdoc cref="IDXGIFactory.CreateSoftwareAdapter" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter([NativeTypeName("HMODULE")] HINSTANCE__* Module, IDXGIAdapter** ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, HINSTANCE__*, IDXGIAdapter**, int>)(lpVtbl[11]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Module, ppAdapter);
        }

        /// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1.EnumAdapters1"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            return ((delegate* unmanaged<IDXGIFactory1*, uint, IDXGIAdapter1**, int>)(lpVtbl[12]))((IDXGIFactory1*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        /// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1.IsCurrent"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("BOOL")]
        public int IsCurrent()
        {
            return ((delegate* unmanaged<IDXGIFactory1*, int>)(lpVtbl[13]))((IDXGIFactory1*)Unsafe.AsPointer(ref this));
        }
    }
}

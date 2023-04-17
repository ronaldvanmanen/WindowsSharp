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
    /// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1"]/*' />
    [Guid("4AE63092-6327-4C1B-80AE-BFE12EA32B86")]
    [NativeTypeName("struct IDXGISurface1 : IDXGISurface")]
    [NativeInheritance("IDXGISurface")]
    public unsafe partial struct IDXGISurface1
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISurface1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGISurface1*, uint>)(lpVtbl[1]))((IDXGISurface1*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGISurface1*, uint>)(lpVtbl[2]))((IDXGISurface1*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISurface1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISurface1*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        /// <inheritdoc cref="IDXGIObject.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISurface1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.GetParent" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISurface1*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        /// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISurface1*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        /// <inheritdoc cref="IDXGISurface.GetDesc" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_SURFACE_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGISurface1*, DXGI_SURFACE_DESC*, int>)(lpVtbl[8]))((IDXGISurface1*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <inheritdoc cref="IDXGISurface.Map" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Map(DXGI_MAPPED_RECT* pLockedRect, uint MapFlags)
        {
            return ((delegate* unmanaged<IDXGISurface1*, DXGI_MAPPED_RECT*, uint, int>)(lpVtbl[9]))((IDXGISurface1*)Unsafe.AsPointer(ref this), pLockedRect, MapFlags);
        }

        /// <inheritdoc cref="IDXGISurface.Unmap" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            return ((delegate* unmanaged<IDXGISurface1*, int>)(lpVtbl[10]))((IDXGISurface1*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1.GetDC"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("BOOL")] int Discard, [NativeTypeName("HDC *")] HDC__** phdc)
        {
            return ((delegate* unmanaged<IDXGISurface1*, int, HDC__**, int>)(lpVtbl[11]))((IDXGISurface1*)Unsafe.AsPointer(ref this), Discard, phdc);
        }

        /// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1.ReleaseDC"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC(RECT* pDirtyRect)
        {
            return ((delegate* unmanaged<IDXGISurface1*, RECT*, int>)(lpVtbl[12]))((IDXGISurface1*)Unsafe.AsPointer(ref this), pDirtyRect);
        }
    }
}

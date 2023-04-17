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
    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain"]/*' />
    [Guid("310D36A0-D2E7-4C0A-AA04-6A9D23B8886A")]
    [NativeTypeName("struct IDXGISwapChain : IDXGIDeviceSubObject")]
    [NativeInheritance("IDXGIDeviceSubObject")]
    public unsafe partial struct IDXGISwapChain
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGISwapChain*, uint>)(lpVtbl[1]))((IDXGISwapChain*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGISwapChain*, uint>)(lpVtbl[2]))((IDXGISwapChain*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        /// <inheritdoc cref="IDXGIObject.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.GetParent" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        /// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.Present"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Present(uint SyncInterval, uint Flags)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, uint, uint, int>)(lpVtbl[8]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer(uint Buffer, [NativeTypeName("const IID &")] Guid* riid, void** ppSurface)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.SetFullscreenState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, IDXGIOutput* pTarget)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, int, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetFullscreenState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState([NativeTypeName("BOOL *")] int* pFullscreen, IDXGIOutput** ppTarget)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, int*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, DXGI_SWAP_CHAIN_DESC*, int>)(lpVtbl[12]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.ResizeBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers(uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, uint, uint, uint, DXGI_FORMAT, uint, int>)(lpVtbl[13]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.ResizeTarget"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, DXGI_MODE_DESC*, int>)(lpVtbl[14]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pNewTargetParameters);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetContainingOutput"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), ppOutput);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetFrameStatistics"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, DXGI_FRAME_STATISTICS*, int>)(lpVtbl[16]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pStats);
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetLastPresentCount"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount(uint* pLastPresentCount)
        {
            return ((delegate* unmanaged<IDXGISwapChain*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain*)Unsafe.AsPointer(ref this), pLastPresentCount);
        }
    }
}

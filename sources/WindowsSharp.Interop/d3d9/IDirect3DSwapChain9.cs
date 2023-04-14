// WindowsSharp
//
// Copyright (C) 2021 Ronald van Manen <rvanmanen@gmail.com>
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
    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9"]/*' />
    [Guid("794950F2-ADFC-458A-905E-10A10B0B503B")]
    [NativeTypeName("struct IDirect3DSwapChain9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3DSwapChain9
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, uint>)(lpVtbl[1]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, uint>)(lpVtbl[2]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.Present"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, [NativeTypeName("HWND")] HWND__* hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, RECT*, RECT*, HWND__*, RGNDATA*, uint, int>)(lpVtbl[3]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetFrontBufferData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrontBufferData(IDirect3DSurface9* pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)(lpVtbl[4]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pDestSurface);
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetBackBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackBuffer(uint iBackBuffer, D3DBACKBUFFER_TYPE Type, IDirect3DSurface9** ppBackBuffer)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int>)(lpVtbl[5]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), iBackBuffer, Type, ppBackBuffer);
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetRasterStatus"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetRasterStatus(D3DRASTER_STATUS* pRasterStatus)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, D3DRASTER_STATUS*, int>)(lpVtbl[6]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pRasterStatus);
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetDisplayMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode(D3DDISPLAYMODE* pMode)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, D3DDISPLAYMODE*, int>)(lpVtbl[7]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pMode);
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetDevice"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)(lpVtbl[8]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetPresentParameters"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentParameters(D3DPRESENT_PARAMETERS* pPresentationParameters)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9*, D3DPRESENT_PARAMETERS*, int>)(lpVtbl[9]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pPresentationParameters);
        }
    }
}

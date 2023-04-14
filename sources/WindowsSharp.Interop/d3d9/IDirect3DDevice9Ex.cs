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
    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex"]/*' />
    [Guid("B18B10CE-2649-405A-870F-95F777D4313A")]
    [NativeTypeName("struct IDirect3DDevice9Ex : IDirect3DDevice9")]
    [NativeInheritance("IDirect3DDevice9")]
    public unsafe partial struct IDirect3DDevice9Ex
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint>)(lpVtbl[1]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint>)(lpVtbl[2]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.TestCooperativeLevel" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int TestCooperativeLevel()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[3]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetAvailableTextureMem" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public uint GetAvailableTextureMem()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint>)(lpVtbl[4]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.EvictManagedResources" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int EvictManagedResources()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[5]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetDirect3D" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDirect3D(IDirect3D9** ppD3D9)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3D9**, int>)(lpVtbl[6]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppD3D9);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetDeviceCaps" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceCaps(D3DCAPS9* pCaps)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DCAPS9*, int>)(lpVtbl[7]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pCaps);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetDisplayMode" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode(uint iSwapChain, D3DDISPLAYMODE* pMode)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DDISPLAYMODE*, int>)(lpVtbl[8]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pMode);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetCreationParameters" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetCreationParameters(D3DDEVICE_CREATION_PARAMETERS* pParameters)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DDEVICE_CREATION_PARAMETERS*, int>)(lpVtbl[9]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pParameters);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetCursorProperties" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, IDirect3DSurface9*, int>)(lpVtbl[10]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), XHotSpot, YHotSpot, pCursorBitmap);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetCursorPosition" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int, uint, void>)(lpVtbl[11]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), X, Y, Flags);
        }

        /// <inheritdoc cref="IDirect3DDevice9.ShowCursor" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("BOOL")]
        public int ShowCursor([NativeTypeName("BOOL")] int bShow)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int>)(lpVtbl[12]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), bShow);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateAdditionalSwapChain" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAdditionalSwapChain(D3DPRESENT_PARAMETERS* pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRESENT_PARAMETERS*, IDirect3DSwapChain9**, int>)(lpVtbl[13]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pPresentationParameters, pSwapChain);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetSwapChain" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetSwapChain(uint iSwapChain, IDirect3DSwapChain9** pSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DSwapChain9**, int>)(lpVtbl[14]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pSwapChain);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetNumberOfSwapChains" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public uint GetNumberOfSwapChains()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint>)(lpVtbl[15]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.Reset" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int Reset(D3DPRESENT_PARAMETERS* pPresentationParameters)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRESENT_PARAMETERS*, int>)(lpVtbl[16]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pPresentationParameters);
        }

        /// <inheritdoc cref="IDirect3DDevice9.Present" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, [NativeTypeName("HWND")] HWND__* hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, RECT*, RECT*, HWND__*, RGNDATA*, int>)(lpVtbl[17]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetBackBuffer" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackBuffer(uint iSwapChain, uint iBackBuffer, D3DBACKBUFFER_TYPE Type, IDirect3DSurface9** ppBackBuffer)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int>)(lpVtbl[18]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, iBackBuffer, Type, ppBackBuffer);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetRasterStatus" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetRasterStatus(uint iSwapChain, D3DRASTER_STATUS* pRasterStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DRASTER_STATUS*, int>)(lpVtbl[19]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pRasterStatus);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetDialogBoxMode" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetDialogBoxMode([NativeTypeName("BOOL")] int bEnableDialogs)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int>)(lpVtbl[20]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), bEnableDialogs);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetGammaRamp" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] D3DGAMMARAMP* pRamp)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DGAMMARAMP*, void>)(lpVtbl[21]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, Flags, pRamp);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetGammaRamp" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void GetGammaRamp(uint iSwapChain, D3DGAMMARAMP* pRamp)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DGAMMARAMP*, void>)(lpVtbl[22]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pRamp);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateTexture" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DTexture9** ppTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DTexture9**, void**, int>)(lpVtbl[23]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateVolumeTexture" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DVolumeTexture9** ppVolumeTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DVolumeTexture9**, void**, int>)(lpVtbl[24]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateCubeTexture" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DCubeTexture9** ppCubeTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DCubeTexture9**, void**, int>)(lpVtbl[25]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateVertexBuffer" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, D3DPOOL Pool, IDirect3DVertexBuffer9** ppVertexBuffer, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, D3DPOOL, IDirect3DVertexBuffer9**, void**, int>)(lpVtbl[26]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateIndexBuffer" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DIndexBuffer9** ppIndexBuffer, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DIndexBuffer9**, void**, int>)(lpVtbl[27]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateRenderTarget" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTarget(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Lockable, IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, int, IDirect3DSurface9**, void**, int>)(lpVtbl[28]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateDepthStencilSurface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilSurface(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Discard, IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, int, IDirect3DSurface9**, void**, int>)(lpVtbl[29]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.UpdateSurface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateSurface(IDirect3DSurface9* pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9* pDestinationSurface, [NativeTypeName("const POINT *")] POINT* pDestPoint)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, RECT*, IDirect3DSurface9*, POINT*, int>)(lpVtbl[30]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
        }

        /// <inheritdoc cref="IDirect3DDevice9.UpdateTexture" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)(lpVtbl[31]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceTexture, pDestinationTexture);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetRenderTargetData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)(lpVtbl[32]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pRenderTarget, pDestSurface);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetFrontBufferData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrontBufferData(uint iSwapChain, IDirect3DSurface9* pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)(lpVtbl[33]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pDestSurface);
        }

        /// <inheritdoc cref="IDirect3DDevice9.StretchRect" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int StretchRect(IDirect3DSurface9* pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9* pDestSurface, [NativeTypeName("const RECT *")] RECT* pDestRect, D3DTEXTUREFILTERTYPE Filter)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, RECT*, IDirect3DSurface9*, RECT*, D3DTEXTUREFILTERTYPE, int>)(lpVtbl[34]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
        }

        /// <inheritdoc cref="IDirect3DDevice9.ColorFill" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int ColorFill(IDirect3DSurface9* pSurface, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("D3DCOLOR")] uint color)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, RECT*, uint, int>)(lpVtbl[35]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSurface, pRect, color);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateOffscreenPlainSurface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOffscreenPlainSurface(uint Width, uint Height, D3DFORMAT Format, D3DPOOL Pool, IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DSurface9**, void**, int>)(lpVtbl[36]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, Pool, ppSurface, pSharedHandle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetRenderTarget" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)(lpVtbl[37]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), RenderTargetIndex, pRenderTarget);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetRenderTarget" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DSurface9**, int>)(lpVtbl[38]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), RenderTargetIndex, ppRenderTarget);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetDepthStencilSurface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int SetDepthStencilSurface(IDirect3DSurface9* pNewZStencil)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, int>)(lpVtbl[39]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pNewZStencil);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetDepthStencilSurface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int GetDepthStencilSurface(IDirect3DSurface9** ppZStencilSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9**, int>)(lpVtbl[40]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppZStencilSurface);
        }

        /// <inheritdoc cref="IDirect3DDevice9.BeginScene" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int BeginScene()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[41]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.EndScene" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int EndScene()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[42]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.Clear" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] D3DRECT* pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DRECT*, uint, uint, float, uint, int>)(lpVtbl[43]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Count, pRects, Flags, Color, Z, Stencil);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetTransform" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform(D3DTRANSFORMSTATETYPE State, [NativeTypeName("const D3DMATRIX *")] D3DMATRIX* pMatrix)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DTRANSFORMSTATETYPE, D3DMATRIX*, int>)(lpVtbl[44]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), State, pMatrix);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetTransform" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransform(D3DTRANSFORMSTATETYPE State, D3DMATRIX* pMatrix)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DTRANSFORMSTATETYPE, D3DMATRIX*, int>)(lpVtbl[45]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), State, pMatrix);
        }

        /// <inheritdoc cref="IDirect3DDevice9.MultiplyTransform" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int MultiplyTransform(D3DTRANSFORMSTATETYPE param0, [NativeTypeName("const D3DMATRIX *")] D3DMATRIX* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DTRANSFORMSTATETYPE, D3DMATRIX*, int>)(lpVtbl[46]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), param0, param1);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetViewport" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] D3DVIEWPORT9* pViewport)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DVIEWPORT9*, int>)(lpVtbl[47]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pViewport);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetViewport" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewport(D3DVIEWPORT9* pViewport)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DVIEWPORT9*, int>)(lpVtbl[48]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pViewport);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetMaterial" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] D3DMATERIAL9* pMaterial)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DMATERIAL9*, int>)(lpVtbl[49]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pMaterial);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetMaterial" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaterial(D3DMATERIAL9* pMaterial)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DMATERIAL9*, int>)(lpVtbl[50]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pMaterial);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetLight" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] D3DLIGHT9* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DLIGHT9*, int>)(lpVtbl[51]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, param1);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetLight" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int GetLight([NativeTypeName("DWORD")] uint Index, D3DLIGHT9* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DLIGHT9*, int>)(lpVtbl[52]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, param1);
        }

        /// <inheritdoc cref="IDirect3DDevice9.LightEnable" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int LightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL")] int Enable)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int, int>)(lpVtbl[53]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, Enable);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetLightEnable" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int GetLightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL *")] int* pEnable)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, int>)(lpVtbl[54]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, pEnable);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetClipPlane" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] float* pPlane)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, int>)(lpVtbl[55]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, pPlane);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetClipPlane" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipPlane([NativeTypeName("DWORD")] uint Index, float* pPlane)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, int>)(lpVtbl[56]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, pPlane);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetRenderState" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DRENDERSTATETYPE, uint, int>)(lpVtbl[57]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), State, Value);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetRenderState" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DRENDERSTATETYPE, uint*, int>)(lpVtbl[58]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), State, pValue);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateStateBlock" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStateBlock(D3DSTATEBLOCKTYPE Type, IDirect3DStateBlock9** ppSB)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DSTATEBLOCKTYPE, IDirect3DStateBlock9**, int>)(lpVtbl[59]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Type, ppSB);
        }

        /// <inheritdoc cref="IDirect3DDevice9.BeginStateBlock" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int BeginStateBlock()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[60]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.EndStateBlock" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int EndStateBlock(IDirect3DStateBlock9** ppSB)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DStateBlock9**, int>)(lpVtbl[61]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppSB);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetClipStatus" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] D3DCLIPSTATUS9* pClipStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DCLIPSTATUS9*, int>)(lpVtbl[62]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pClipStatus);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetClipStatus" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipStatus(D3DCLIPSTATUS9* pClipStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DCLIPSTATUS9*, int>)(lpVtbl[63]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pClipStatus);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetTexture" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int GetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9** ppTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9**, int>)(lpVtbl[64]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Stage, ppTexture);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetTexture" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int SetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9* pTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9*, int>)(lpVtbl[65]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Stage, pTexture);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetTextureStageState" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3DTEXTURESTAGESTATETYPE Type, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DTEXTURESTAGESTATETYPE, uint*, int>)(lpVtbl[66]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Stage, Type, pValue);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetTextureStageState" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3DTEXTURESTAGESTATETYPE Type, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DTEXTURESTAGESTATETYPE, uint, int>)(lpVtbl[67]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Stage, Type, Value);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetSamplerState" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int GetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3DSAMPLERSTATETYPE Type, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DSAMPLERSTATETYPE, uint*, int>)(lpVtbl[68]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Sampler, Type, pValue);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetSamplerState" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int SetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3DSAMPLERSTATETYPE Type, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DSAMPLERSTATETYPE, uint, int>)(lpVtbl[69]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Sampler, Type, Value);
        }

        /// <inheritdoc cref="IDirect3DDevice9.ValidateDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, int>)(lpVtbl[70]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pNumPasses);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetPaletteEntries" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pEntries)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, PALETTEENTRY*, int>)(lpVtbl[71]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetPaletteEntries" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int GetPaletteEntries(uint PaletteNumber, PALETTEENTRY* pEntries)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, PALETTEENTRY*, int>)(lpVtbl[72]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetCurrentTexturePalette" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTexturePalette(uint PaletteNumber)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[73]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PaletteNumber);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetCurrentTexturePalette" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTexturePalette(uint* PaletteNumber)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, int>)(lpVtbl[74]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PaletteNumber);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetScissorRect" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int SetScissorRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, RECT*, int>)(lpVtbl[75]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pRect);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetScissorRect" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int GetScissorRect(RECT* pRect)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, RECT*, int>)(lpVtbl[76]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pRect);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetSoftwareVertexProcessing" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int SetSoftwareVertexProcessing([NativeTypeName("BOOL")] int bSoftware)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int>)(lpVtbl[77]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), bSoftware);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetSoftwareVertexProcessing" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("BOOL")]
        public int GetSoftwareVertexProcessing()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[78]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetNPatchMode" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int SetNPatchMode(float nSegments)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, float, int>)(lpVtbl[79]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), nSegments);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetNPatchMode" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public float GetNPatchMode()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, float>)(lpVtbl[80]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DDevice9.DrawPrimitive" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int DrawPrimitive(D3DPRIMITIVETYPE PrimitiveType, uint StartVertex, uint PrimitiveCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRIMITIVETYPE, uint, uint, int>)(lpVtbl[81]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PrimitiveType, StartVertex, PrimitiveCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.DrawIndexedPrimitive" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int DrawIndexedPrimitive(D3DPRIMITIVETYPE param0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRIMITIVETYPE, int, uint, uint, uint, uint, int>)(lpVtbl[82]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), param0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.DrawPrimitiveUP" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int DrawPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRIMITIVETYPE, uint, void*, uint, int>)(lpVtbl[83]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
        }

        /// <inheritdoc cref="IDirect3DDevice9.DrawIndexedPrimitiveUP" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int DrawIndexedPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] void* pIndexData, D3DFORMAT IndexDataFormat, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRIMITIVETYPE, uint, uint, uint, void*, D3DFORMAT, void*, uint, int>)(lpVtbl[84]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
        }

        /// <inheritdoc cref="IDirect3DDevice9.ProcessVertices" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)(lpVtbl[85]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateVertexDeclaration" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] D3DVERTEXELEMENT9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DVERTEXELEMENT9*, IDirect3DVertexDeclaration9**, int>)(lpVtbl[86]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pVertexElements, ppDecl);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetVertexDeclaration" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexDeclaration(IDirect3DVertexDeclaration9* pDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9*, int>)(lpVtbl[87]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pDecl);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetVertexDeclaration" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexDeclaration(IDirect3DVertexDeclaration9** ppDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9**, int>)(lpVtbl[88]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppDecl);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetFVF" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int SetFVF([NativeTypeName("DWORD")] uint FVF)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[89]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), FVF);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetFVF" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int GetFVF([NativeTypeName("DWORD *")] uint* pFVF)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, int>)(lpVtbl[90]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pFVF);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateVertexShader" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DVertexShader9** ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)(lpVtbl[91]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pFunction, ppShader);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetVertexShader" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShader(IDirect3DVertexShader9* pShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DVertexShader9*, int>)(lpVtbl[92]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pShader);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetVertexShader" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShader(IDirect3DVertexShader9** ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DVertexShader9**, int>)(lpVtbl[93]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppShader);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetVertexShaderConstantF" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, uint, int>)(lpVtbl[94]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetVertexShaderConstantF" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, uint, int>)(lpVtbl[95]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetVertexShaderConstantI" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[96]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetVertexShaderConstantI" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[97]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetVertexShaderConstantB" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] int* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[98]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetVertexShaderConstantB" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] int* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[99]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetStreamSource" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)(lpVtbl[100]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StreamNumber, pStreamData, OffsetInBytes, Stride);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetStreamSource" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, uint* pStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)(lpVtbl[101]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StreamNumber, ppStreamData, pOffsetInBytes, pStride);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetStreamSourceFreq" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSourceFreq(uint StreamNumber, uint Setting)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, int>)(lpVtbl[102]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StreamNumber, Setting);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetStreamSourceFreq" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSourceFreq(uint StreamNumber, uint* pSetting)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint*, int>)(lpVtbl[103]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StreamNumber, pSetting);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetIndices" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int SetIndices(IDirect3DIndexBuffer9* pIndexData)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9*, int>)(lpVtbl[104]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pIndexData);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetIndices" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int GetIndices(IDirect3DIndexBuffer9** ppIndexData)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9**, int>)(lpVtbl[105]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppIndexData);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreatePixelShader" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DPixelShader9** ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)(lpVtbl[106]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pFunction, ppShader);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetPixelShader" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShader(IDirect3DPixelShader9* pShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DPixelShader9*, int>)(lpVtbl[107]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pShader);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetPixelShader" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShader(IDirect3DPixelShader9** ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DPixelShader9**, int>)(lpVtbl[108]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppShader);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetPixelShaderConstantF" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, uint, int>)(lpVtbl[109]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetPixelShaderConstantF" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, uint, int>)(lpVtbl[110]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetPixelShaderConstantI" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[111]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetPixelShaderConstantI" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[112]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.SetPixelShaderConstantB" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] int* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[113]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.GetPixelShaderConstantB" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] int* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[114]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        /// <inheritdoc cref="IDirect3DDevice9.DrawRectPatch" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        [return: NativeTypeName("HRESULT")]
        public int DrawRectPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] D3DRECTPATCH_INFO* pRectPatchInfo)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, D3DRECTPATCH_INFO*, int>)(lpVtbl[115]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pRectPatchInfo);
        }

        /// <inheritdoc cref="IDirect3DDevice9.DrawTriPatch" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        [return: NativeTypeName("HRESULT")]
        public int DrawTriPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] D3DTRIPATCH_INFO* pTriPatchInfo)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, D3DTRIPATCH_INFO*, int>)(lpVtbl[116]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pTriPatchInfo);
        }

        /// <inheritdoc cref="IDirect3DDevice9.DeletePatch" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        [return: NativeTypeName("HRESULT")]
        public int DeletePatch(uint Handle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[117]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Handle);
        }

        /// <inheritdoc cref="IDirect3DDevice9.CreateQuery" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQuery(D3DQUERYTYPE Type, IDirect3DQuery9** ppQuery)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DQUERYTYPE, IDirect3DQuery9**, int>)(lpVtbl[118]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Type, ppQuery);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetConvolutionMonoKernel"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        [return: NativeTypeName("HRESULT")]
        public int SetConvolutionMonoKernel(uint width, uint height, float* rows, float* columns)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)(lpVtbl[119]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), width, height, rows, columns);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.ComposeRects"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        [return: NativeTypeName("HRESULT")]
        public int ComposeRects(IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, D3DCOMPOSERECTSOP Operation, int Xoffset, int Yoffset)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, D3DCOMPOSERECTSOP, int, int, int>)(lpVtbl[120]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSrc, pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.PresentEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        [return: NativeTypeName("HRESULT")]
        public int PresentEx([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, [NativeTypeName("HWND")] HWND__* hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, RECT*, RECT*, HWND__*, RGNDATA*, uint, int>)(lpVtbl[121]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetGPUThreadPriority"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        [return: NativeTypeName("HRESULT")]
        public int GetGPUThreadPriority(int* pPriority)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int*, int>)(lpVtbl[122]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pPriority);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetGPUThreadPriority"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        [return: NativeTypeName("HRESULT")]
        public int SetGPUThreadPriority(int Priority)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int>)(lpVtbl[123]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Priority);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.WaitForVBlank"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank(uint iSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[124]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CheckResourceResidency"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        [return: NativeTypeName("HRESULT")]
        public int CheckResourceResidency(IDirect3DResource9** pResourceArray, [NativeTypeName("UINT32")] uint NumResources)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DResource9**, uint, int>)(lpVtbl[125]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pResourceArray, NumResources);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetMaximumFrameLatency"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency(uint MaxLatency)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[126]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetMaximumFrameLatency"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, int>)(lpVtbl[127]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pMaxLatency);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CheckDeviceState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceState([NativeTypeName("HWND")] HWND__* hDestinationWindow)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, HWND__*, int>)(lpVtbl[128]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), hDestinationWindow);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateRenderTargetEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetEx(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Lockable, IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, int, IDirect3DSurface9**, void**, uint, int>)(lpVtbl[129]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle, Usage);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateOffscreenPlainSurfaceEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOffscreenPlainSurfaceEx(uint Width, uint Height, D3DFORMAT Format, D3DPOOL Pool, IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DSurface9**, void**, uint, int>)(lpVtbl[130]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, Pool, ppSurface, pSharedHandle, Usage);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateDepthStencilSurfaceEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilSurfaceEx(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Discard, IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, int, IDirect3DSurface9**, void**, uint, int>)(lpVtbl[131]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle, Usage);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.ResetEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        [return: NativeTypeName("HRESULT")]
        public int ResetEx(D3DPRESENT_PARAMETERS* pPresentationParameters, D3DDISPLAYMODEEX* pFullscreenDisplayMode)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRESENT_PARAMETERS*, D3DDISPLAYMODEEX*, int>)(lpVtbl[132]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pPresentationParameters, pFullscreenDisplayMode);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetDisplayModeEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeEx(uint iSwapChain, D3DDISPLAYMODEEX* pMode, D3DDISPLAYROTATION* pRotation)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int>)(lpVtbl[133]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pMode, pRotation);
        }
    }
}

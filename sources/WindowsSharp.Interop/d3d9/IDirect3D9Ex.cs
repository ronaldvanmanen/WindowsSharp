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
    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex"]/*' />
    [Guid("02177241-69FC-400C-8FF1-93A44DF6861D")]
    [NativeTypeName("struct IDirect3D9Ex : IDirect3D9")]
    [NativeInheritance("IDirect3D9")]
    public unsafe partial struct IDirect3D9Ex
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint>)(lpVtbl[1]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint>)(lpVtbl[2]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3D9.RegisterSoftwareDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterSoftwareDevice(void* pInitializeFunction)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, void*, int>)(lpVtbl[3]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), pInitializeFunction);
        }

        /// <inheritdoc cref="IDirect3D9.GetAdapterCount" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public uint GetAdapterCount()
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint>)(lpVtbl[4]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3D9.GetAdapterIdentifier" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterIdentifier(uint Adapter, [NativeTypeName("DWORD")] uint Flags, D3DADAPTER_IDENTIFIER9* pIdentifier)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, uint, D3DADAPTER_IDENTIFIER9*, int>)(lpVtbl[5]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Flags, pIdentifier);
        }

        /// <inheritdoc cref="IDirect3D9.GetAdapterModeCount" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public uint GetAdapterModeCount(uint Adapter, D3DFORMAT Format)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DFORMAT, uint>)(lpVtbl[6]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Format);
        }

        /// <inheritdoc cref="IDirect3D9.EnumAdapterModes" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterModes(uint Adapter, D3DFORMAT Format, uint Mode, D3DDISPLAYMODE* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DFORMAT, uint, D3DDISPLAYMODE*, int>)(lpVtbl[7]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Format, Mode, pMode);
        }

        /// <inheritdoc cref="IDirect3D9.GetAdapterDisplayMode" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterDisplayMode(uint Adapter, D3DDISPLAYMODE* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDISPLAYMODE*, int>)(lpVtbl[8]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pMode);
        }

        /// <inheritdoc cref="IDirect3D9.CheckDeviceType" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceType(uint Adapter, D3DDEVTYPE DevType, D3DFORMAT AdapterFormat, D3DFORMAT BackBufferFormat, [NativeTypeName("BOOL")] int bWindowed)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, int, int>)(lpVtbl[9]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
        }

        /// <inheritdoc cref="IDirect3D9.CheckDeviceFormat" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceFormat(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, [NativeTypeName("DWORD")] uint Usage, D3DRESOURCETYPE RType, D3DFORMAT CheckFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, uint, D3DRESOURCETYPE, D3DFORMAT, int>)(lpVtbl[10]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
        }

        /// <inheritdoc cref="IDirect3D9.CheckDeviceMultiSampleType" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceMultiSampleType(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SurfaceFormat, [NativeTypeName("BOOL")] int Windowed, D3DMULTISAMPLE_TYPE MultiSampleType, [NativeTypeName("DWORD *")] uint* pQualityLevels)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, int, D3DMULTISAMPLE_TYPE, uint*, int>)(lpVtbl[11]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
        }

        /// <inheritdoc cref="IDirect3D9.CheckDepthStencilMatch" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDepthStencilMatch(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, D3DFORMAT RenderTargetFormat, D3DFORMAT DepthStencilFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, D3DFORMAT, int>)(lpVtbl[12]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
        }

        /// <inheritdoc cref="IDirect3D9.CheckDeviceFormatConversion" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceFormatConversion(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SourceFormat, D3DFORMAT TargetFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, int>)(lpVtbl[13]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, SourceFormat, TargetFormat);
        }

        /// <inheritdoc cref="IDirect3D9.GetDeviceCaps" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceCaps(uint Adapter, D3DDEVTYPE DeviceType, D3DCAPS9* pCaps)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DCAPS9*, int>)(lpVtbl[14]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, pCaps);
        }

        /// <inheritdoc cref="IDirect3D9.GetAdapterMonitor" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HMONITOR")]
        public HMONITOR__* GetAdapterMonitor(uint Adapter)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, HMONITOR__*>)(lpVtbl[15]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter);
        }

        /// <inheritdoc cref="IDirect3D9.CreateDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice(uint Adapter, D3DDEVTYPE DeviceType, [NativeTypeName("HWND")] HWND__* hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DPRESENT_PARAMETERS* pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, HWND__*, uint, D3DPRESENT_PARAMETERS*, IDirect3DDevice9**, int>)(lpVtbl[16]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterModeCountEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3DDISPLAYMODEFILTER* pFilter)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDISPLAYMODEFILTER*, uint>)(lpVtbl[17]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pFilter);
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.EnumAdapterModesEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3DDISPLAYMODEFILTER* pFilter, uint Mode, D3DDISPLAYMODEEX* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDISPLAYMODEFILTER*, uint, D3DDISPLAYMODEEX*, int>)(lpVtbl[18]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pFilter, Mode, pMode);
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterDisplayModeEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterDisplayModeEx(uint Adapter, D3DDISPLAYMODEEX* pMode, D3DDISPLAYROTATION* pRotation)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int>)(lpVtbl[19]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pMode, pRotation);
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.CreateDeviceEx"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceEx(uint Adapter, D3DDEVTYPE DeviceType, [NativeTypeName("HWND")] HWND__* hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DPRESENT_PARAMETERS* pPresentationParameters, D3DDISPLAYMODEEX* pFullscreenDisplayMode, IDirect3DDevice9Ex** ppReturnedDeviceInterface)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, HWND__*, uint, D3DPRESENT_PARAMETERS*, D3DDISPLAYMODEEX*, IDirect3DDevice9Ex**, int>)(lpVtbl[20]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterface);
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterLUID"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterLUID(uint Adapter, LUID* pLUID)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, LUID*, int>)(lpVtbl[21]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pLUID);
        }
    }
}

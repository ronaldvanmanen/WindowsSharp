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
    /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9"]/*' />
    [Guid("85C31227-3DE5-4F00-9B3A-F11AC38C18B5")]
    [NativeTypeName("struct IDirect3DTexture9 : IDirect3DBaseTexture9")]
    [NativeInheritance("IDirect3DBaseTexture9")]
    public unsafe partial struct IDirect3DTexture9
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint>)(lpVtbl[1]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint>)(lpVtbl[2]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DResource9.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="IDirect3DResource9.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        /// <inheritdoc cref="IDirect3DResource9.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        /// <inheritdoc cref="IDirect3DResource9.FreePrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, Guid*, int>)(lpVtbl[6]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), refguid);
        }

        /// <inheritdoc cref="IDirect3DResource9.SetPriority" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint, uint>)(lpVtbl[7]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), PriorityNew);
        }

        /// <inheritdoc cref="IDirect3DResource9.GetPriority" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("DWORD")]
        public uint GetPriority()
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint>)(lpVtbl[8]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DResource9.PreLoad" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void PreLoad()
        {
            ((delegate* unmanaged<IDirect3DTexture9*, void>)(lpVtbl[9]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DResource9.GetType" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public new D3DRESOURCETYPE GetType()
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, D3DRESOURCETYPE>)(lpVtbl[10]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DBaseTexture9.SetLOD" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("DWORD")]
        public uint SetLOD([NativeTypeName("DWORD")] uint LODNew)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint, uint>)(lpVtbl[11]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), LODNew);
        }

        /// <inheritdoc cref="IDirect3DBaseTexture9.GetLOD" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("DWORD")]
        public uint GetLOD()
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint>)(lpVtbl[12]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DBaseTexture9.GetLevelCount" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("DWORD")]
        public uint GetLevelCount()
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint>)(lpVtbl[13]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DBaseTexture9.SetAutoGenFilterType" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetAutoGenFilterType(D3DTEXTUREFILTERTYPE FilterType)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, D3DTEXTUREFILTERTYPE, int>)(lpVtbl[14]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), FilterType);
        }

        /// <inheritdoc cref="IDirect3DBaseTexture9.GetAutoGenFilterType" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public D3DTEXTUREFILTERTYPE GetAutoGenFilterType()
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, D3DTEXTUREFILTERTYPE>)(lpVtbl[15]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDirect3DBaseTexture9.GenerateMipSubLevels" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void GenerateMipSubLevels()
        {
            ((delegate* unmanaged<IDirect3DTexture9*, void>)(lpVtbl[16]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.GetLevelDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevelDesc(uint Level, D3DSURFACE_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint, D3DSURFACE_DESC*, int>)(lpVtbl[17]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), Level, pDesc);
        }

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.GetSurfaceLevel"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceLevel(uint Level, IDirect3DSurface9** ppSurfaceLevel)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint, IDirect3DSurface9**, int>)(lpVtbl[18]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), Level, ppSurfaceLevel);
        }

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.LockRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int LockRect(uint Level, D3DLOCKED_RECT* pLockedRect, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint, D3DLOCKED_RECT*, RECT*, uint, int>)(lpVtbl[19]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), Level, pLockedRect, pRect, Flags);
        }

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.UnlockRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRect(uint Level)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, uint, int>)(lpVtbl[20]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), Level);
        }

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.AddDirtyRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int AddDirtyRect([NativeTypeName("const RECT *")] RECT* pDirtyRect)
        {
            return ((delegate* unmanaged<IDirect3DTexture9*, RECT*, int>)(lpVtbl[21]))((IDirect3DTexture9*)Unsafe.AsPointer(ref this), pDirtyRect);
        }
    }
}

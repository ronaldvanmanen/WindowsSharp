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
    /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput"]/*' />
    [Guid("AE02EEDB-C735-4690-8D52-5A8DC20213AA")]
    [NativeTypeName("struct IDXGIOutput : IDXGIObject")]
    [NativeInheritance("IDXGIObject")]
    public unsafe partial struct IDXGIOutput
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIOutput*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIOutput*, uint>)(lpVtbl[1]))((IDXGIOutput*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIOutput*, uint>)(lpVtbl[2]))((IDXGIOutput*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIOutput*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIOutput*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        /// <inheritdoc cref="IDXGIObject.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIOutput*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        /// <inheritdoc cref="IDXGIObject.GetParent" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIOutput*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_OUTPUT_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGIOutput*, DXGI_OUTPUT_DESC*, int>)(lpVtbl[7]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetDisplayModeList"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(DXGI_FORMAT EnumFormat, uint Flags, uint* pNumModes, DXGI_MODE_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGIOutput*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int>)(lpVtbl[8]))((IDXGIOutput*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.FindClosestMatchingMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice)
        {
            return ((delegate* unmanaged<IDXGIOutput*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.WaitForVBlank"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            return ((delegate* unmanaged<IDXGIOutput*, int>)(lpVtbl[10]))((IDXGIOutput*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.TakeOwnership"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership(IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive)
        {
            return ((delegate* unmanaged<IDXGIOutput*, IUnknown*, int, int>)(lpVtbl[11]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.ReleaseOwnership"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void ReleaseOwnership()
        {
            ((delegate* unmanaged<IDXGIOutput*, void>)(lpVtbl[12]))((IDXGIOutput*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetGammaControlCapabilities"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities(DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
        {
            return ((delegate* unmanaged<IDXGIOutput*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int>)(lpVtbl[13]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pGammaCaps);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.SetGammaControl"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* unmanaged<IDXGIOutput*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[14]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pArray);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetGammaControl"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl(DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* unmanaged<IDXGIOutput*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[15]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pArray);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.SetDisplaySurface"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface(IDXGISurface* pScanoutSurface)
        {
            return ((delegate* unmanaged<IDXGIOutput*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pScanoutSurface);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetDisplaySurfaceData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData(IDXGISurface* pDestination)
        {
            return ((delegate* unmanaged<IDXGIOutput*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pDestination);
        }

        /// <include file='IDXGIOutput.xml' path='doc/member[@name="IDXGIOutput.GetFrameStatistics"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            return ((delegate* unmanaged<IDXGIOutput*, DXGI_FRAME_STATISTICS*, int>)(lpVtbl[18]))((IDXGIOutput*)Unsafe.AsPointer(ref this), pStats);
        }
    }
}

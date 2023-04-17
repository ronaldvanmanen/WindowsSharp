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
    /// <include file='ID3D11VideoProcessorEnumerator.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator"]/*' />
    [Guid("31627037-53AB-4200-9061-05FAA9AB45F9")]
    [NativeTypeName("struct ID3D11VideoProcessorEnumerator : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11VideoProcessorEnumerator
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint>)(lpVtbl[1]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint>)(lpVtbl[2]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <include file='ID3D11VideoProcessorEnumerator.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator.GetVideoProcessorContentDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, int>)(lpVtbl[7]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), pContentDesc);
        }

        /// <include file='ID3D11VideoProcessorEnumerator.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator.CheckVideoProcessorFormat"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CheckVideoProcessorFormat(DXGI_FORMAT Format, uint* pFlags)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, DXGI_FORMAT, uint*, int>)(lpVtbl[8]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), Format, pFlags);
        }

        /// <include file='ID3D11VideoProcessorEnumerator.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator.GetVideoProcessorCaps"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorCaps(D3D11_VIDEO_PROCESSOR_CAPS* pCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_CAPS*, int>)(lpVtbl[9]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), pCaps);
        }

        /// <include file='ID3D11VideoProcessorEnumerator.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator.GetVideoProcessorRateConversionCaps"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorRateConversionCaps(uint TypeIndex, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, int>)(lpVtbl[10]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), TypeIndex, pCaps);
        }

        /// <include file='ID3D11VideoProcessorEnumerator.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator.GetVideoProcessorCustomRate"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, uint, uint, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE*, int>)(lpVtbl[11]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), TypeIndex, CustomRateIndex, pRate);
        }

        /// <include file='ID3D11VideoProcessorEnumerator.xml' path='doc/member[@name="ID3D11VideoProcessorEnumerator.GetVideoProcessorFilterRange"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoProcessorFilterRange(D3D11_VIDEO_PROCESSOR_FILTER Filter, D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE*, int>)(lpVtbl[12]))((ID3D11VideoProcessorEnumerator*)Unsafe.AsPointer(ref this), Filter, pRange);
        }
    }
}

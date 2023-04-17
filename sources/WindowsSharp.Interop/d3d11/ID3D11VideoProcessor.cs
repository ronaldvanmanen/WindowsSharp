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
    /// <include file='ID3D11VideoProcessor.xml' path='doc/member[@name="ID3D11VideoProcessor"]/*' />
    [Guid("1D7B0652-185F-41C6-85CE-0C5BE3D4AE6C")]
    [NativeTypeName("struct ID3D11VideoProcessor : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11VideoProcessor
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessor*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessor*, uint>)(lpVtbl[1]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessor*, uint>)(lpVtbl[2]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoProcessor*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessor*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessor*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <include file='ID3D11VideoProcessor.xml' path='doc/member[@name="ID3D11VideoProcessor.GetContentDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, void>)(lpVtbl[7]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='ID3D11VideoProcessor.xml' path='doc/member[@name="ID3D11VideoProcessor.GetRateConversionCaps"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GetRateConversionCaps(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps)
        {
            ((delegate* unmanaged<ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*, void>)(lpVtbl[8]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), pCaps);
        }
    }
}

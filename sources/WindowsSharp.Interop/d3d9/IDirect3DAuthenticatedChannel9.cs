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
    /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9"]/*' />
    [Guid("FF24BEEE-DA21-4BEB-98B5-D2F899F98AF9")]
    [NativeTypeName("struct IDirect3DAuthenticatedChannel9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3DAuthenticatedChannel9
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint>)(lpVtbl[1]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint>)(lpVtbl[2]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.GetCertificateSize"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificateSize(uint* pCertificateSize)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint*, int>)(lpVtbl[3]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.GetCertificate"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificate(uint CertifacteSize, byte* ppCertificate)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)(lpVtbl[4]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), CertifacteSize, ppCertificate);
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.NegotiateKeyExchange"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateKeyExchange(uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint, void*, int>)(lpVtbl[5]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), DataSize, pData);
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.Query"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Query(uint InputSize, [NativeTypeName("const void *")] void* pInput, uint OutputSize, void* pOutput)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)(lpVtbl[6]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), InputSize, pInput, OutputSize, pOutput);
        }

        /// <include file='IDirect3DAuthenticatedChannel9.xml' path='doc/member[@name="IDirect3DAuthenticatedChannel9.Configure"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Configure(uint InputSize, [NativeTypeName("const void *")] void* pInput, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint, void*, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT*, int>)(lpVtbl[7]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), InputSize, pInput, pOutput);
        }
    }
}

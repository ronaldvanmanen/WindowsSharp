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
    /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9"]/*' />
    [Guid("FA0AB799-7A9C-48CA-8C5B-237E71A54434")]
    [NativeTypeName("struct IDirect3DCryptoSession9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3DCryptoSession9
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint>)(lpVtbl[1]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint>)(lpVtbl[2]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetCertificateSize"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificateSize(uint* pCertificateSize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint*, int>)(lpVtbl[3]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetCertificate"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificate(uint CertifacteSize, byte* ppCertificate)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, byte*, int>)(lpVtbl[4]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), CertifacteSize, ppCertificate);
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.NegotiateKeyExchange"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateKeyExchange(uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, void*, int>)(lpVtbl[5]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), DataSize, pData);
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.EncryptionBlt"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int EncryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)(lpVtbl[6]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.DecryptionBlt"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int DecryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, D3DENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, D3DENCRYPTED_BLOCK_INFO*, void*, void*, int>)(lpVtbl[7]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetSurfacePitch"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfacePitch(IDirect3DSurface9* pSrcSurface, uint* pSurfacePitch)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)(lpVtbl[8]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pSurfacePitch);
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.StartSessionKeyRefresh"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, void*, uint, int>)(lpVtbl[9]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pRandomNumber, RandomNumberSize);
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.FinishSessionKeyRefresh"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int FinishSessionKeyRefresh()
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, int>)(lpVtbl[10]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DCryptoSession9.xml' path='doc/member[@name="IDirect3DCryptoSession9.GetEncryptionBltKey"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetEncryptionBltKey(void* pReadbackKey, uint KeySize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, void*, uint, int>)(lpVtbl[11]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pReadbackKey, KeySize);
        }
    }
}

// DirectXSharp
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

namespace DirectXSharp.Interop
{
    /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video"]/*' />
    [Guid("26DC4561-A1EE-4AE7-96DA-118A36C0EC95")]
    [NativeTypeName("struct IDirect3DDevice9Video : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3DDevice9Video
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, uint>)(lpVtbl[1]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, uint>)(lpVtbl[2]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.GetContentProtectionCaps"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, D3DCONTENTPROTECTIONCAPS* pCaps)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, D3DCONTENTPROTECTIONCAPS*, int>)(lpVtbl[3]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), pCryptoType, pDecodeProfile, pCaps);
        }

        /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.CreateAuthenticatedChannel"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAuthenticatedChannel(D3DAUTHENTICATEDCHANNELTYPE ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, [NativeTypeName("HANDLE *")] void** pChannelHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, D3DAUTHENTICATEDCHANNELTYPE, IDirect3DAuthenticatedChannel9**, void**, int>)(lpVtbl[4]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel, pChannelHandle);
        }

        /// <include file='IDirect3DDevice9Video.xml' path='doc/member[@name="IDirect3DDevice9Video.CreateCryptoSession"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, [NativeTypeName("HANDLE *")] void** pCryptoHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)(lpVtbl[5]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
        }
    }
}

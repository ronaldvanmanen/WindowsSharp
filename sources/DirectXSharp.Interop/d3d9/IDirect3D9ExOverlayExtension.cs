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
    /// <include file='IDirect3D9ExOverlayExtension.xml' path='doc/member[@name="IDirect3D9ExOverlayExtension"]/*' />
    [Guid("187AEB13-AAF5-4C59-876D-E059088C0DF8")]
    [NativeTypeName("struct IDirect3D9ExOverlayExtension : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3D9ExOverlayExtension
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension*, uint>)(lpVtbl[1]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension*, uint>)(lpVtbl[2]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3D9ExOverlayExtension.xml' path='doc/member[@name="IDirect3D9ExOverlayExtension.CheckDeviceOverlayType"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceOverlayType(uint Adapter, D3DDEVTYPE DevType, uint OverlayWidth, uint OverlayHeight, D3DFORMAT OverlayFormat, D3DDISPLAYMODEEX* pDisplayMode, D3DDISPLAYROTATION DisplayRotation, D3DOVERLAYCAPS* pOverlayCaps)
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension*, uint, D3DDEVTYPE, uint, uint, D3DFORMAT, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION, D3DOVERLAYCAPS*, int>)(lpVtbl[3]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this), Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCaps);
        }
    }
}

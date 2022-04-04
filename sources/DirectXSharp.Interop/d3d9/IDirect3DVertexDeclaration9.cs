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
    /// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9"]/*' />
    [Guid("DD13C59C-36FA-4098-A8FB-C7ED39DC8546")]
    [NativeTypeName("struct IDirect3DVertexDeclaration9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirect3DVertexDeclaration9
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, uint>)(lpVtbl[1]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, uint>)(lpVtbl[2]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9.GetDevice"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <include file='IDirect3DVertexDeclaration9.xml' path='doc/member[@name="IDirect3DVertexDeclaration9.GetDeclaration"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeclaration(D3DVERTEXELEMENT9* pElement, uint* pNumElements)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, D3DVERTEXELEMENT9*, uint*, int>)(lpVtbl[4]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this), pElement, pNumElements);
        }
    }
}

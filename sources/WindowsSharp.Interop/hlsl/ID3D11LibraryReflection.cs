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
    /// <include file='ID3D11LibraryReflection.xml' path='doc/member[@name="ID3D11LibraryReflection"]/*' />
    [Guid("54384F1B-5B3E-4BB7-AE01-60BA3097CBB6")]
    [NativeTypeName("struct ID3D11LibraryReflection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11LibraryReflection
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, uint>)(lpVtbl[1]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, uint>)(lpVtbl[2]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11LibraryReflection.xml' path='doc/member[@name="ID3D11LibraryReflection.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_LIBRARY_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, D3D11_LIBRARY_DESC*, int>)(lpVtbl[3]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='ID3D11LibraryReflection.xml' path='doc/member[@name="ID3D11LibraryReflection.GetFunctionByIndex"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D11FunctionReflection* GetFunctionByIndex(int FunctionIndex)
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*>)(lpVtbl[4]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), FunctionIndex);
        }
    }
}

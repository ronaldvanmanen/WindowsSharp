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
    /// <include file='IGlobalInterfaceTable.xml' path='doc/member[@name="IGlobalInterfaceTable"]/*' />
    [Guid("00000146-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IGlobalInterfaceTable : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGlobalInterfaceTable
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, Guid*, void**, int>)(lpVtbl[0]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, uint>)(lpVtbl[1]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, uint>)(lpVtbl[2]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IGlobalInterfaceTable.xml' path='doc/member[@name="IGlobalInterfaceTable.RegisterInterfaceInGlobal"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterInterfaceInGlobal(IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, IUnknown*, Guid*, uint*, int>)(lpVtbl[3]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), pUnk, riid, pdwCookie);
        }

        /// <include file='IGlobalInterfaceTable.xml' path='doc/member[@name="IGlobalInterfaceTable.RevokeInterfaceFromGlobal"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int RevokeInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, uint, int>)(lpVtbl[4]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie);
        }

        /// <include file='IGlobalInterfaceTable.xml' path='doc/member[@name="IGlobalInterfaceTable.GetInterfaceFromGlobal"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, uint, Guid*, void**, int>)(lpVtbl[5]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie, riid, ppv);
        }
    }
}

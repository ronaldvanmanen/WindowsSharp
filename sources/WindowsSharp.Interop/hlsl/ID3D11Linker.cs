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
    /// <include file='ID3D11Linker.xml' path='doc/member[@name="ID3D11Linker"]/*' />
    [Guid("59A6CD0E-E10D-4C1F-88C0-63ABA1DAF30E")]
    [NativeTypeName("struct ID3D11Linker : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11Linker
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Linker*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Linker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Linker*, uint>)(lpVtbl[1]))((ID3D11Linker*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Linker*, uint>)(lpVtbl[2]))((ID3D11Linker*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11Linker.xml' path='doc/member[@name="ID3D11Linker.Link"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Link([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pEntry, [NativeTypeName("LPCSTR")] sbyte* pEntryName, [NativeTypeName("LPCSTR")] sbyte* pTargetName, uint uFlags, ID3DBlob** ppShaderBlob, ID3DBlob** ppErrorBuffer)
        {
            return ((delegate* unmanaged<ID3D11Linker*, ID3D11ModuleInstance*, sbyte*, sbyte*, uint, ID3DBlob**, ID3DBlob**, int>)(lpVtbl[3]))((ID3D11Linker*)Unsafe.AsPointer(ref this), pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        }

        /// <include file='ID3D11Linker.xml' path='doc/member[@name="ID3D11Linker.UseLibrary"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UseLibrary([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pLibraryMI)
        {
            return ((delegate* unmanaged<ID3D11Linker*, ID3D11ModuleInstance*, int>)(lpVtbl[4]))((ID3D11Linker*)Unsafe.AsPointer(ref this), pLibraryMI);
        }

        /// <include file='ID3D11Linker.xml' path='doc/member[@name="ID3D11Linker.AddClipPlaneFromCBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry)
        {
            return ((delegate* unmanaged<ID3D11Linker*, uint, uint, int>)(lpVtbl[5]))((ID3D11Linker*)Unsafe.AsPointer(ref this), uCBufferSlot, uCBufferEntry);
        }
    }
}

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
    /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance"]/*' />
    [Guid("469E07F7-045A-48D5-AA12-68A478CDF75D")]
    [NativeTypeName("struct ID3D11ModuleInstance : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11ModuleInstance
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint>)(lpVtbl[1]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint>)(lpVtbl[2]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindConstantBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[3]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, cbDstOffset);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindConstantBufferByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int BindConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint cbDstOffset)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[4]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, cbDstOffset);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindResource"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int BindResource(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[5]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindResourceByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int BindResourceByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[6]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindSampler"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[7]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindSamplerByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int BindSamplerByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[8]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindUnorderedAccessView"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[9]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindUnorderedAccessViewByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int BindUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pName, uint uDstSlot, uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[10]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindResourceAsUnorderedAccessView"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[11]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSrvSlot, uDstUavSlot, uCount);
        }

        /// <include file='ID3D11ModuleInstance.xml' path='doc/member[@name="ID3D11ModuleInstance.BindResourceAsUnorderedAccessViewByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int BindResourceAsUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pSrvName, uint uDstUavSlot, uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[12]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pSrvName, uDstUavSlot, uCount);
        }
    }
}

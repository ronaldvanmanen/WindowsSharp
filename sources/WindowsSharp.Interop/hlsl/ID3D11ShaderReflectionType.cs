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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType"]/*' />
    [Guid("6E6FFA6A-9BAE-4613-A51E-91652D508C21")]
    public unsafe partial struct ID3D11ShaderReflectionType
    {
        public void** lpVtbl;

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_SHADER_TYPE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, D3D11_SHADER_TYPE_DESC*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetMemberTypeByIndex"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D11ShaderReflectionType* GetMemberTypeByIndex(uint Index)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)(lpVtbl[1]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetMemberTypeByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D11ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, sbyte*, ID3D11ShaderReflectionType*>)(lpVtbl[2]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetMemberTypeName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName(uint Index)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, sbyte*>)(lpVtbl[3]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.IsEqual"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqual(ID3D11ShaderReflectionType* pType)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[4]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetSubType"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D11ShaderReflectionType* GetSubType()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)(lpVtbl[5]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetBaseClass"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D11ShaderReflectionType* GetBaseClass()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)(lpVtbl[6]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetNumInterfaces"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public uint GetNumInterfaces()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint>)(lpVtbl[7]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetInterfaceByIndex"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public ID3D11ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)(lpVtbl[8]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.IsOfType"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int IsOfType(ID3D11ShaderReflectionType* pType)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[9]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.ImplementsInterface"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ImplementsInterface(ID3D11ShaderReflectionType* pBase)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[10]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
        }
    }
}

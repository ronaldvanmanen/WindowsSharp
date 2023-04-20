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
    /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable"]/*' />
    [Guid("51F23923-F3E5-4BD1-91CB-606177D8DB4C")]
    public unsafe partial struct ID3D11ShaderReflectionVariable
    {
        public void** lpVtbl;

        /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_SHADER_VARIABLE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, D3D11_SHADER_VARIABLE_DESC*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable.GetType"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public new ID3D11ShaderReflectionType* GetType()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionType*>)(lpVtbl[1]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable.GetBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D11ShaderReflectionConstantBuffer* GetBuffer()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[2]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable.GetInterfaceSlot"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public uint GetInterfaceSlot(uint uArrayIndex)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, uint, uint>)(lpVtbl[3]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this), uArrayIndex);
        }
    }
}

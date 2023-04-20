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
    /// <include file='ID3D11ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D11ShaderReflectionConstantBuffer"]/*' />
    [Guid("EB62D63D-93DD-4318-8AE8-C6F83AD371B8")]
    public unsafe partial struct ID3D11ShaderReflectionConstantBuffer
    {
        public void** lpVtbl;

        /// <include file='ID3D11ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D11ShaderReflectionConstantBuffer.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_SHADER_BUFFER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, D3D11_SHADER_BUFFER_DESC*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='ID3D11ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D11ShaderReflectionConstantBuffer.GetVariableByIndex"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D11ShaderReflectionVariable* GetVariableByIndex(uint Index)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, uint, ID3D11ShaderReflectionVariable*>)(lpVtbl[1]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
        }

        /// <include file='ID3D11ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D11ShaderReflectionConstantBuffer.GetVariableByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionConstantBuffer*, sbyte*, ID3D11ShaderReflectionVariable*>)(lpVtbl[2]))((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
        }
    }
}

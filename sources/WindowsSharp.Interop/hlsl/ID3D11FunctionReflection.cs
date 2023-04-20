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
    /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection"]/*' />
    [Guid("207BCECB-D683-4A06-A8A3-9B149B9F73A4")]
    public unsafe partial struct ID3D11FunctionReflection
    {
        public void** lpVtbl;

        /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_FUNCTION_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, D3D11_FUNCTION_DESC*, int>)(lpVtbl[0]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetConstantBufferByIndex"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[1]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
        }

        /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetConstantBufferByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[2]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetResourceBindingDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc(uint ResourceIndex, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[3]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetVariableByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, ID3D11ShaderReflectionVariable*>)(lpVtbl[4]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetResourceBindingDescByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[5]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetFunctionParameter"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D11FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)(lpVtbl[6]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
        }
    }
}

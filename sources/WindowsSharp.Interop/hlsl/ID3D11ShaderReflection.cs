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
    /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection"]/*' />
    [Guid("8D536CA1-0CCA-4956-A837-786963755584")]
    [NativeTypeName("struct ID3D11ShaderReflection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11ShaderReflection
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[1]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[2]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D11_SHADER_DESC*, int>)(lpVtbl[3]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetConstantBufferByIndex"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[4]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Index);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetConstantBufferByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[5]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetResourceBindingDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc(uint ResourceIndex, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[6]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetInputParameterDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[7]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetOutputParameterDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[8]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetPatchConstantParameterDesc"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetPatchConstantParameterDesc(uint ParameterIndex, D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[9]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetVariableByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, ID3D11ShaderReflectionVariable*>)(lpVtbl[10]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetResourceBindingDescByName"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[11]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetMovInstructionCount"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public uint GetMovInstructionCount()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[12]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetMovcInstructionCount"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public uint GetMovcInstructionCount()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[13]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetConversionInstructionCount"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public uint GetConversionInstructionCount()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[14]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetBitwiseInstructionCount"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public uint GetBitwiseInstructionCount()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[15]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetGSInputPrimitive"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public D3D_PRIMITIVE GetGSInputPrimitive()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D_PRIMITIVE>)(lpVtbl[16]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.IsSampleFrequencyShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("BOOL")]
        public int IsSampleFrequencyShader()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, int>)(lpVtbl[17]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetNumInterfaceSlots"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public uint GetNumInterfaceSlots()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[18]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetMinFeatureLevel"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D_FEATURE_LEVEL*, int>)(lpVtbl[19]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetThreadGroupSize"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)(lpVtbl[20]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
        }

        /// <include file='ID3D11ShaderReflection.xml' path='doc/member[@name="ID3D11ShaderReflection.GetRequiresFlags"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("UINT64")]
        public ulong GetRequiresFlags()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, ulong>)(lpVtbl[21]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }
    }
}

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
    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph"]/*' />
    [Guid("54133220-1CE8-43D3-8236-9855C5CEECFF")]
    [NativeTypeName("struct ID3D11FunctionLinkingGraph : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11FunctionLinkingGraph
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, uint>)(lpVtbl[1]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, uint>)(lpVtbl[2]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.CreateModuleInstance"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateModuleInstance([NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance, ID3DBlob** ppErrorBuffer)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, ID3DBlob**, int>)(lpVtbl[3]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppModuleInstance, ppErrorBuffer);
        }

        /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.SetInputSignature"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pInputParameters, uint cInputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppInputNode)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, D3D11_PARAMETER_DESC*, uint, ID3D11LinkingNode**, int>)(lpVtbl[4]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pInputParameters, cInputParameters, ppInputNode);
        }

        /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.SetOutputSignature"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pOutputParameters, uint cOutputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppOutputNode)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, D3D11_PARAMETER_DESC*, uint, ID3D11LinkingNode**, int>)(lpVtbl[5]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pOutputParameters, cOutputParameters, ppOutputNode);
        }

        /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.CallFunction"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CallFunction([NativeTypeName("LPCSTR")] sbyte* pModuleInstanceNamespace, [NativeTypeName("struct ID3D11Module *")] ID3D11Module* pModuleWithFunctionPrototype, [NativeTypeName("LPCSTR")] sbyte* pFunctionName, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppCallNode)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, sbyte*, ID3D11Module*, sbyte*, ID3D11LinkingNode**, int>)(lpVtbl[6]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        }

        /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.PassValue"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int PassValue([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, int DstParameterIndex)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)(lpVtbl[7]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
        }

        /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.PassValueWithSwizzle"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int PassValueWithSwizzle([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pSrcSwizzle, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, int DstParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pDstSwizzle)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, sbyte*, ID3D11LinkingNode*, int, sbyte*, int>)(lpVtbl[8]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
        }

        /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.GetLastError"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastError(ID3DBlob** ppErrorBuffer)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3DBlob**, int>)(lpVtbl[9]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppErrorBuffer);
        }

        /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.GenerateHlsl"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GenerateHlsl(uint uFlags, ID3DBlob** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, uint, ID3DBlob**, int>)(lpVtbl[10]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), uFlags, ppBuffer);
        }
    }
}

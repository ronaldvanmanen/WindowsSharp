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
    /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext"]/*' />
    [Guid("C0BFA96C-E089-44FB-8EAF-26F8796190DA")]
    [NativeTypeName("struct ID3D11DeviceContext : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11DeviceContext
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, uint>)(lpVtbl[1]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, uint>)(lpVtbl[2]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.VSSetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[7]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.PSSetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void PSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[8]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.PSSetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void PSSetShader(ID3D11PixelShader* pPixelShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[9]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pPixelShader, ppClassInstances, NumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.PSSetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void PSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[10]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.VSSetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void VSSetShader(ID3D11VertexShader* pVertexShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[11]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pVertexShader, ppClassInstances, NumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DrawIndexed"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, int, void>)(lpVtbl[12]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.Draw"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void Draw(uint VertexCount, uint StartVertexLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, void>)(lpVtbl[13]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), VertexCount, StartVertexLocation);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.Map"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Map(ID3D11Resource* pResource, uint Subresource, D3D11_MAP MapType, uint MapFlags, D3D11_MAPPED_SUBRESOURCE* pMappedResource)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, D3D11_MAP, uint, D3D11_MAPPED_SUBRESOURCE*, int>)(lpVtbl[14]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pResource, Subresource, MapType, MapFlags, pMappedResource);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.Unmap"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void Unmap(ID3D11Resource* pResource, uint Subresource)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, void>)(lpVtbl[15]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pResource, Subresource);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.PSSetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[16]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.IASetInputLayout"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void IASetInputLayout(ID3D11InputLayout* pInputLayout)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11InputLayout*, void>)(lpVtbl[17]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pInputLayout);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.IASetVertexBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[18]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.IASetIndexBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void IASetIndexBuffer(ID3D11Buffer* pIndexBuffer, DXGI_FORMAT Format, uint Offset)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, DXGI_FORMAT, uint, void>)(lpVtbl[19]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DrawIndexedInstanced"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, int, uint, void>)(lpVtbl[20]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DrawInstanced"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, uint, void>)(lpVtbl[21]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GSSetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[22]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GSSetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void GSSetShader(ID3D11GeometryShader* pShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[23]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pShader, ppClassInstances, NumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.IASetPrimitiveTopology"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY Topology)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, D3D11_PRIMITIVE_TOPOLOGY, void>)(lpVtbl[24]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), Topology);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.VSSetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void VSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[25]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.VSSetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void VSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[26]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.Begin"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void Begin(ID3D11Asynchronous* pAsync)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void>)(lpVtbl[27]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pAsync);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.End"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void End(ID3D11Asynchronous* pAsync)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void>)(lpVtbl[28]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pAsync);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GetData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetData(ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Asynchronous*, void*, uint, uint, int>)(lpVtbl[29]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pAsync, pData, DataSize, GetDataFlags);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.SetPredication"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void SetPredication(ID3D11Predicate* pPredicate, [NativeTypeName("BOOL")] int PredicateValue)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Predicate*, int, void>)(lpVtbl[30]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pPredicate, PredicateValue);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GSSetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void GSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[31]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GSSetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void GSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[32]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.OMSetRenderTargets"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void OMSetRenderTargets(uint NumViews, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)(lpVtbl[33]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.OMSetRenderTargetsAndUnorderedAccessViews"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [NativeTypeName("ID3D11RenderTargetView *const *")] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)(lpVtbl[34]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.OMSetBlendState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public void OMSetBlendState(ID3D11BlendState* pBlendState, [NativeTypeName("const FLOAT[4]")] float* BlendFactor, uint SampleMask)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11BlendState*, float*, uint, void>)(lpVtbl[35]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pBlendState, BlendFactor, SampleMask);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.OMSetDepthStencilState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void OMSetDepthStencilState(ID3D11DepthStencilState* pDepthStencilState, uint StencilRef)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilState*, uint, void>)(lpVtbl[36]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDepthStencilState, StencilRef);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.SOSetTargets"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void SOSetTargets(uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11Buffer**, uint*, void>)(lpVtbl[37]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DrawAuto"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void DrawAuto()
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, void>)(lpVtbl[38]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DrawIndexedInstancedIndirect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public void DrawIndexedInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)(lpVtbl[39]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DrawInstancedIndirect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void DrawInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)(lpVtbl[40]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.Dispatch"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, uint, void>)(lpVtbl[41]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DispatchIndirect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void DispatchIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)(lpVtbl[42]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.RSSetState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void RSSetState(ID3D11RasterizerState* pRasterizerState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11RasterizerState*, void>)(lpVtbl[43]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pRasterizerState);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.RSSetViewports"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, D3D11_VIEWPORT*, void>)(lpVtbl[44]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.RSSetScissorRects"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D11_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, RECT*, void>)(lpVtbl[45]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CopySubresourceRegion"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, D3D11_BOX*, void>)(lpVtbl[46]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CopyResource"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void CopyResource(ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, ID3D11Resource*, void>)(lpVtbl[47]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.UpdateSubresource"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, D3D11_BOX*, void*, uint, uint, void>)(lpVtbl[48]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CopyStructureCount"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)(lpVtbl[49]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstBuffer, DstAlignedByteOffset, pSrcView);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.ClearRenderTargetView"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT[4]")] float* ColorRGBA)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11RenderTargetView*, float*, void>)(lpVtbl[50]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pRenderTargetView, ColorRGBA);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.ClearUnorderedAccessViewUint"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const UINT[4]")] uint* Values)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, uint*, void>)(lpVtbl[51]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.ClearUnorderedAccessViewFloat"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [NativeTypeName("const FLOAT[4]")] float* Values)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, float*, void>)(lpVtbl[52]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pUnorderedAccessView, Values);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.ClearDepthStencilView"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public void ClearDepthStencilView(ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilView*, uint, float, byte, void>)(lpVtbl[53]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GenerateMips"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public void GenerateMips(ID3D11ShaderResourceView* pShaderResourceView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11ShaderResourceView*, void>)(lpVtbl[54]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pShaderResourceView);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.SetResourceMinLOD"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public void SetResourceMinLOD(ID3D11Resource* pResource, float MinLOD)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, float, void>)(lpVtbl[55]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pResource, MinLOD);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GetResourceMinLOD"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public float GetResourceMinLOD(ID3D11Resource* pResource)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, float>)(lpVtbl[56]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pResource);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.ResolveSubresource"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, DXGI_FORMAT Format)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Resource*, uint, ID3D11Resource*, uint, DXGI_FORMAT, void>)(lpVtbl[57]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.ExecuteCommandList"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public void ExecuteCommandList(ID3D11CommandList* pCommandList, [NativeTypeName("BOOL")] int RestoreContextState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11CommandList*, int, void>)(lpVtbl[58]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pCommandList, RestoreContextState);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.HSSetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public void HSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[59]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.HSSetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public void HSSetShader(ID3D11HullShader* pHullShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[60]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pHullShader, ppClassInstances, NumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.HSSetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public void HSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[61]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.HSSetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[62]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DSSetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public void DSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[63]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DSSetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public void DSSetShader(ID3D11DomainShader* pDomainShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[64]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pDomainShader, ppClassInstances, NumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DSSetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public void DSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[65]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DSSetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[66]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSSetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public void CSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D11ShaderResourceView *const *")] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[67]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSSetUnorderedAccessViews"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, [NativeTypeName("ID3D11UnorderedAccessView *const *")] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [NativeTypeName("const UINT *")] uint* pUAVInitialCounts)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)(lpVtbl[68]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSSetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public void CSSetShader(ID3D11ComputeShader* pComputeShader, [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)(lpVtbl[69]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pComputeShader, ppClassInstances, NumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSSetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public void CSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[70]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSSetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[71]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.VSGetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[72]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.PSGetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[73]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.PSGetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[74]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppPixelShader, ppClassInstances, pNumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.PSGetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[75]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.VSGetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[76]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppVertexShader, ppClassInstances, pNumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.PSGetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[77]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.IAGetInputLayout"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public void IAGetInputLayout(ID3D11InputLayout** ppInputLayout)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11InputLayout**, void>)(lpVtbl[78]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppInputLayout);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.IAGetVertexBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)(lpVtbl[79]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.IAGetIndexBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, DXGI_FORMAT* Format, uint* Offset)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Buffer**, DXGI_FORMAT*, uint*, void>)(lpVtbl[80]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GSGetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[81]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GSGetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[82]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppGeometryShader, ppClassInstances, pNumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.IAGetPrimitiveTopology"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public void IAGetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY* pTopology)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, D3D11_PRIMITIVE_TOPOLOGY*, void>)(lpVtbl[83]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pTopology);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.VSGetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[84]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.VSGetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[85]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GetPredication"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public void GetPredication(ID3D11Predicate** ppPredicate, [NativeTypeName("BOOL *")] int* pPredicateValue)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11Predicate**, int*, void>)(lpVtbl[86]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppPredicate, pPredicateValue);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GSGetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[87]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GSGetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[88]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.OMGetRenderTargets"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)(lpVtbl[89]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.OMGetRenderTargetsAndUnorderedAccessViews"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)(lpVtbl[90]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.OMGetBlendState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public void OMGetBlendState(ID3D11BlendState** ppBlendState, [NativeTypeName("FLOAT[4]")] float* BlendFactor, uint* pSampleMask)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)(lpVtbl[91]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppBlendState, BlendFactor, pSampleMask);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.OMGetDepthStencilState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DepthStencilState**, uint*, void>)(lpVtbl[92]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppDepthStencilState, pStencilRef);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.SOGetTargets"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public void SOGetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, ID3D11Buffer**, void>)(lpVtbl[93]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.RSGetState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public void RSGetState(ID3D11RasterizerState** ppRasterizerState)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11RasterizerState**, void>)(lpVtbl[94]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppRasterizerState);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.RSGetViewports"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public void RSGetViewports(uint* pNumViewports, D3D11_VIEWPORT* pViewports)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint*, D3D11_VIEWPORT*, void>)(lpVtbl[95]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pNumViewports, pViewports);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.RSGetScissorRects"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public void RSGetScissorRects(uint* pNumRects, [NativeTypeName("D3D11_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint*, RECT*, void>)(lpVtbl[96]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), pNumRects, pRects);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.HSGetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public void HSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[97]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.HSGetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        public void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[98]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppHullShader, ppClassInstances, pNumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.HSGetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        public void HSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[99]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.HSGetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        public void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[100]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DSGetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        public void DSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[101]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DSGetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        public void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[102]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppDomainShader, ppClassInstances, pNumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DSGetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        public void DSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[103]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.DSGetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        public void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[104]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSGetShaderResources"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        public void CSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)(lpVtbl[105]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSGetUnorderedAccessViews"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        public void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, void>)(lpVtbl[106]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSGetShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        public void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)(lpVtbl[107]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), ppComputeShader, ppClassInstances, pNumClassInstances);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSGetSamplers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        public void CSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)(lpVtbl[108]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.CSGetConstantBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        public void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)(lpVtbl[109]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.ClearState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        public void ClearState()
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, void>)(lpVtbl[110]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.Flush"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        public void Flush()
        {
            ((delegate* unmanaged<ID3D11DeviceContext*, void>)(lpVtbl[111]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GetType"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        public new D3D11_DEVICE_CONTEXT_TYPE GetType()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, D3D11_DEVICE_CONTEXT_TYPE>)(lpVtbl[112]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.GetContextFlags"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        public uint GetContextFlags()
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, uint>)(lpVtbl[113]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11DeviceContext.xml' path='doc/member[@name="ID3D11DeviceContext.FinishCommandList"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int FinishCommandList([NativeTypeName("BOOL")] int RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
        {
            return ((delegate* unmanaged<ID3D11DeviceContext*, int, ID3D11CommandList**, int>)(lpVtbl[114]))((ID3D11DeviceContext*)Unsafe.AsPointer(ref this), RestoreDeferredContextState, ppCommandList);
        }
    }
}

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
    /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device"]/*' />
    [Guid("DB6F6DDB-AC77-4E88-8253-819DF9BBF140")]
    [NativeTypeName("struct ID3D11Device : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11Device
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Device*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Device*, uint>)(lpVtbl[1]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Device*, uint>)(lpVtbl[2]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBuffer([NativeTypeName("const D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Buffer** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_BUFFER_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Buffer**, int>)(lpVtbl[3]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateTexture1D"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture1D([NativeTypeName("const D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture1D** ppTexture1D)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_TEXTURE1D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture1D**, int>)(lpVtbl[4]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateTexture2D"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture2D([NativeTypeName("const D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture2D** ppTexture2D)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_TEXTURE2D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture2D**, int>)(lpVtbl[5]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateTexture3D"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture3D([NativeTypeName("const D3D11_TEXTURE3D_DESC *")] D3D11_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, ID3D11Texture3D** ppTexture3D)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_TEXTURE3D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture3D**, int>)(lpVtbl[6]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateShaderResourceView"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC *")] D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, ID3D11ShaderResourceView** ppSRView)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11Resource*, D3D11_SHADER_RESOURCE_VIEW_DESC*, ID3D11ShaderResourceView**, int>)(lpVtbl[7]))((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateUnorderedAccessView"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUnorderedAccessView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC *")] D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, ID3D11UnorderedAccessView** ppUAView)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11Resource*, D3D11_UNORDERED_ACCESS_VIEW_DESC*, ID3D11UnorderedAccessView**, int>)(lpVtbl[8]))((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppUAView);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateRenderTargetView"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc, ID3D11RenderTargetView** ppRTView)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11Resource*, D3D11_RENDER_TARGET_VIEW_DESC*, ID3D11RenderTargetView**, int>)(lpVtbl[9]))((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateDepthStencilView"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_DEPTH_STENCIL_VIEW_DESC *")] D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, ID3D11DepthStencilView** ppDepthStencilView)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11Resource*, D3D11_DEPTH_STENCIL_VIEW_DESC*, ID3D11DepthStencilView**, int>)(lpVtbl[10]))((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateInputLayout"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInputLayout([NativeTypeName("const D3D11_INPUT_ELEMENT_DESC *")] D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] ulong BytecodeLength, ID3D11InputLayout** ppInputLayout)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_INPUT_ELEMENT_DESC*, uint, void*, ulong, ID3D11InputLayout**, int>)(lpVtbl[11]))((ID3D11Device*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateVertexShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] ulong BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11VertexShader** ppVertexShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, ulong, ID3D11ClassLinkage*, ID3D11VertexShader**, int>)(lpVtbl[12]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateGeometryShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] ulong BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, ulong, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[13]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateGeometryShaderWithStreamOutput"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] ulong BytecodeLength, [NativeTypeName("const D3D11_SO_DECLARATION_ENTRY *")] D3D11_SO_DECLARATION_ENTRY* pSODeclaration, uint NumEntries, [NativeTypeName("const UINT *")] uint* pBufferStrides, uint NumStrides, uint RasterizedStream, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, ulong, D3D11_SO_DECLARATION_ENTRY*, uint, uint*, uint, uint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[14]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ppGeometryShader);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreatePixelShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] ulong BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11PixelShader** ppPixelShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, ulong, ID3D11ClassLinkage*, ID3D11PixelShader**, int>)(lpVtbl[15]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateHullShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CreateHullShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] ulong BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11HullShader** ppHullShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, ulong, ID3D11ClassLinkage*, ID3D11HullShader**, int>)(lpVtbl[16]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateDomainShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDomainShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] ulong BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11DomainShader** ppDomainShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, ulong, ID3D11ClassLinkage*, ID3D11DomainShader**, int>)(lpVtbl[17]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateComputeShader"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComputeShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] ulong BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11ComputeShader** ppComputeShader)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, ulong, ID3D11ClassLinkage*, ID3D11ComputeShader**, int>)(lpVtbl[18]))((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateClassLinkage"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int CreateClassLinkage(ID3D11ClassLinkage** ppLinkage)
        {
            return ((delegate* unmanaged<ID3D11Device*, ID3D11ClassLinkage**, int>)(lpVtbl[19]))((ID3D11Device*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateBlendState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState([NativeTypeName("const D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pBlendStateDesc, ID3D11BlendState** ppBlendState)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_BLEND_DESC*, ID3D11BlendState**, int>)(lpVtbl[20]))((ID3D11Device*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateDepthStencilState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilState([NativeTypeName("const D3D11_DEPTH_STENCIL_DESC *")] D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, ID3D11DepthStencilState** ppDepthStencilState)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_DEPTH_STENCIL_DESC*, ID3D11DepthStencilState**, int>)(lpVtbl[21]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateRasterizerState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState([NativeTypeName("const D3D11_RASTERIZER_DESC *")] D3D11_RASTERIZER_DESC* pRasterizerDesc, ID3D11RasterizerState** ppRasterizerState)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_RASTERIZER_DESC*, ID3D11RasterizerState**, int>)(lpVtbl[22]))((ID3D11Device*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateSamplerState"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSamplerState([NativeTypeName("const D3D11_SAMPLER_DESC *")] D3D11_SAMPLER_DESC* pSamplerDesc, ID3D11SamplerState** ppSamplerState)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_SAMPLER_DESC*, ID3D11SamplerState**, int>)(lpVtbl[23]))((ID3D11Device*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateQuery"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQuery([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pQueryDesc, ID3D11Query** ppQuery)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_QUERY_DESC*, ID3D11Query**, int>)(lpVtbl[24]))((ID3D11Device*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreatePredicate"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePredicate([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pPredicateDesc, ID3D11Predicate** ppPredicate)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_QUERY_DESC*, ID3D11Predicate**, int>)(lpVtbl[25]))((ID3D11Device*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateCounter"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pCounterDesc, ID3D11Counter** ppCounter)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_COUNTER_DESC*, ID3D11Counter**, int>)(lpVtbl[26]))((ID3D11Device*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CreateDeferredContext"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext(uint ContextFlags, ID3D11DeviceContext** ppDeferredContext)
        {
            return ((delegate* unmanaged<ID3D11Device*, uint, ID3D11DeviceContext**, int>)(lpVtbl[27]))((ID3D11Device*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.OpenSharedResource"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource([NativeTypeName("HANDLE")] void* hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, void** ppResource)
        {
            return ((delegate* unmanaged<ID3D11Device*, void*, Guid*, void**, int>)(lpVtbl[28]))((ID3D11Device*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CheckFormatSupport"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFormatSupport(DXGI_FORMAT Format, uint* pFormatSupport)
        {
            return ((delegate* unmanaged<ID3D11Device*, DXGI_FORMAT, uint*, int>)(lpVtbl[29]))((ID3D11Device*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CheckMultisampleQualityLevels"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels(DXGI_FORMAT Format, uint SampleCount, uint* pNumQualityLevels)
        {
            return ((delegate* unmanaged<ID3D11Device*, DXGI_FORMAT, uint, uint*, int>)(lpVtbl[30]))((ID3D11Device*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CheckCounterInfo"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void CheckCounterInfo(D3D11_COUNTER_INFO* pCounterInfo)
        {
            ((delegate* unmanaged<ID3D11Device*, D3D11_COUNTER_INFO*, void>)(lpVtbl[31]))((ID3D11Device*)Unsafe.AsPointer(ref this), pCounterInfo);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CheckCounter"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int CheckCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pDesc, D3D11_COUNTER_TYPE* pType, uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, uint* pDescriptionLength)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_COUNTER_DESC*, D3D11_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int>)(lpVtbl[32]))((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.CheckFeatureSupport"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D11_FEATURE Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D11_FEATURE, void*, uint, int>)(lpVtbl[33]))((ID3D11Device*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.GetPrivateData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11Device*, Guid*, uint*, void*, int>)(lpVtbl[34]))((ID3D11Device*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.SetPrivateData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11Device*, Guid*, uint, void*, int>)(lpVtbl[35]))((ID3D11Device*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.SetPrivateDataInterface"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11Device*, Guid*, IUnknown*, int>)(lpVtbl[36]))((ID3D11Device*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.GetFeatureLevel"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public D3D_FEATURE_LEVEL GetFeatureLevel()
        {
            return ((delegate* unmanaged<ID3D11Device*, D3D_FEATURE_LEVEL>)(lpVtbl[37]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.GetCreationFlags"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public uint GetCreationFlags()
        {
            return ((delegate* unmanaged<ID3D11Device*, uint>)(lpVtbl[38]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.GetDeviceRemovedReason"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<ID3D11Device*, int>)(lpVtbl[39]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.GetImmediateContext"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void GetImmediateContext(ID3D11DeviceContext** ppImmediateContext)
        {
            ((delegate* unmanaged<ID3D11Device*, ID3D11DeviceContext**, void>)(lpVtbl[40]))((ID3D11Device*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.SetExceptionMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int SetExceptionMode(uint RaiseFlags)
        {
            return ((delegate* unmanaged<ID3D11Device*, uint, int>)(lpVtbl[41]))((ID3D11Device*)Unsafe.AsPointer(ref this), RaiseFlags);
        }

        /// <include file='ID3D11Device.xml' path='doc/member[@name="ID3D11Device.GetExceptionMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public uint GetExceptionMode()
        {
            return ((delegate* unmanaged<ID3D11Device*, uint>)(lpVtbl[42]))((ID3D11Device*)Unsafe.AsPointer(ref this));
        }
    }
}

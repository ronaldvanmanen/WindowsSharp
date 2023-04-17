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
    /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext"]/*' />
    [Guid("61F21C45-3C0E-4A74-9CEA-67100D9AD5E4")]
    [NativeTypeName("struct ID3D11VideoContext : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3D11VideoContext
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, uint>)(lpVtbl[1]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, uint>)(lpVtbl[2]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), ppDevice);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, pData);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.GetDecoderBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, uint* pBufferSize, void** ppBuffer)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, uint*, void**, int>)(lpVtbl[7]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, Type, pBufferSize, ppBuffer);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.ReleaseDecoderBuffer"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDecoderBuffer(ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, int>)(lpVtbl[8]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, Type);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.DecoderBeginFrame"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)(lpVtbl[9]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, pView, ContentKeySize, pContentKey);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.DecoderEndFrame"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int DecoderEndFrame(ID3D11VideoDecoder* pDecoder)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)(lpVtbl[10]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.SubmitDecoderBuffers"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")] D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC*, int>)(lpVtbl[11]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.DecoderExtension"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int DecoderExtension(ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")] D3D11_VIDEO_DECODER_EXTENSION* pExtensionData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_EXTENSION*, int>)(lpVtbl[12]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, pExtensionData);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetOutputTargetRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, RECT*, void>)(lpVtbl[13]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, pRect);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetOutputBackgroundColor"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int YCbCr, [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, D3D11_VIDEO_COLOR*, void>)(lpVtbl[14]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, YCbCr, pColor);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetOutputColorSpace"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[15]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetOutputAlphaFillMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, uint StreamIndex)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, uint, void>)(lpVtbl[16]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, AlphaFillMode, StreamIndex);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetOutputConstriction"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable, SIZE Size)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, SIZE, void>)(lpVtbl[17]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, Size);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetOutputStereoMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL")] int Enable)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)(lpVtbl[18]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetOutputExtension"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[19]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetOutputTargetRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* Enabled, RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, RECT*, void>)(lpVtbl[20]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enabled, pRect);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetOutputBackgroundColor"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pYCbCr, D3D11_VIDEO_COLOR* pColor)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, D3D11_VIDEO_COLOR*, void>)(lpVtbl[21]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pYCbCr, pColor);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetOutputColorSpace"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[22]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetOutputAlphaFillMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, uint* pStreamIndex)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE*, uint*, void>)(lpVtbl[23]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pAlphaFillMode, pStreamIndex);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetOutputConstriction"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled, SIZE* pSize)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, SIZE*, void>)(lpVtbl[24]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled, pSize);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetOutputStereoMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)(lpVtbl[25]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetOutputExtension"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[26]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamFrameFormat"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT, void>)(lpVtbl[27]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, FrameFormat);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamColorSpace"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[28]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamOutputRate"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, [NativeTypeName("BOOL")] int RepeatFrame, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, int, DXGI_RATIONAL*, void>)(lpVtbl[29]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamSourceRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, RECT*, void>)(lpVtbl[30]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamDestRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const RECT *")] RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, RECT*, void>)(lpVtbl[31]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamAlpha"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL")] int Enable, float Alpha)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)(lpVtbl[32]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Alpha);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamPalette"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, [NativeTypeName("const UINT *")] uint* pEntries)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[33]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamPixelAspectRatio"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL")] int Enable, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, DXGI_RATIONAL*, DXGI_RATIONAL*, void>)(lpVtbl[34]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamLumaKey"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL")] int Enable, float Lower, float Upper)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)(lpVtbl[35]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Lower, Upper);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamStereoFormat"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, [NativeTypeName("BOOL")] int LeftViewFrame0, [NativeTypeName("BOOL")] int BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, int, int, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int, void>)(lpVtbl[36]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamAutoProcessingMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL")] int Enable)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)(lpVtbl[37]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamFilter"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL")] int Enable, int Level)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, int, int, void>)(lpVtbl[38]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, Enable, Level);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamExtension"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[39]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamFrameFormat"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT* pFrameFormat)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT*, void>)(lpVtbl[40]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pFrameFormat);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamColorSpace"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[41]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamOutputRate"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, [NativeTypeName("BOOL *")] int* pRepeatFrame, DXGI_RATIONAL* pCustomRate)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE*, int*, DXGI_RATIONAL*, void>)(lpVtbl[42]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamSourceRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, RECT*, void>)(lpVtbl[43]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamDestRect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, RECT* pRect)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, RECT*, void>)(lpVtbl[44]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamAlpha"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, float* pAlpha)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)(lpVtbl[45]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pAlpha);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamPalette"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[46]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamPixelAspectRatio"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, DXGI_RATIONAL* pSourceAspectRatio, DXGI_RATIONAL* pDestinationAspectRatio)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, DXGI_RATIONAL*, DXGI_RATIONAL*, void>)(lpVtbl[47]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamLumaKey"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled, float* pLower, float* pUpper)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)(lpVtbl[48]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamStereoFormat"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, [NativeTypeName("BOOL *")] int* pLeftViewFrame0, [NativeTypeName("BOOL *")] int* pBaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, int* MonoOffset)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT*, int*, int*, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE*, int*, void>)(lpVtbl[49]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamAutoProcessingMode"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)(lpVtbl[50]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamFilter"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [NativeTypeName("BOOL *")] int* pEnabled, int* pLevel)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, int*, int*, void>)(lpVtbl[51]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamExtension"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        public int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[52]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorBlt"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")] D3D11_VIDEO_PROCESSOR_STREAM* pStreams)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, D3D11_VIDEO_PROCESSOR_STREAM*, int>)(lpVtbl[53]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.NegotiateCryptoSessionKeyExchange"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[54]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, DataSize, pData);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.EncryptionBlt"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)(lpVtbl[55]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.DecryptionBlt"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey, uint IVSize, void* pIV)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, D3D11_ENCRYPTED_BLOCK_INFO*, uint, void*, uint, void*, void>)(lpVtbl[56]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.StartSessionKeyRefresh"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public void StartSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)(lpVtbl[57]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, RandomNumberSize, pRandomNumber);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.FinishSessionKeyRefresh"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, void>)(lpVtbl[58]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.GetEncryptionBltKey"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int GetEncryptionBltKey(ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[59]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, KeySize, pReadbackKey);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.NegotiateAuthenticatedChannelKeyExchange"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)(lpVtbl[60]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, DataSize, pData);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.QueryAuthenticatedChannel"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int QueryAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [NativeTypeName("const void *")] void* pInput, uint OutputSize, void* pOutput)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)(lpVtbl[61]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, OutputSize, pOutput);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.ConfigureAuthenticatedChannel"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [NativeTypeName("const void *")] void* pInput, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT*, int>)(lpVtbl[62]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, pOutput);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorSetStreamRotation"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL")] int Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, D3D11_VIDEO_PROCESSOR_ROTATION, void>)(lpVtbl[63]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Rotation);
        }

        /// <include file='ID3D11VideoContext.xml' path='doc/member[@name="ID3D11VideoContext.VideoProcessorGetStreamRotation"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("BOOL *")] int* pEnable, D3D11_VIDEO_PROCESSOR_ROTATION* pRotation)
        {
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, D3D11_VIDEO_PROCESSOR_ROTATION*, void>)(lpVtbl[64]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pRotation);
        }
    }
}

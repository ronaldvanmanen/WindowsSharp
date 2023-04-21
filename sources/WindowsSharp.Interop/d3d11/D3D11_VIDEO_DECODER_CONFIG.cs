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

namespace WindowsSharp.Interop
{
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG"]/*' />
    public partial struct D3D11_VIDEO_DECODER_CONFIG
    {
        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.guidConfigBitstreamEncryption"]/*' />
        public Guid guidConfigBitstreamEncryption;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.guidConfigMBcontrolEncryption"]/*' />
        public Guid guidConfigMBcontrolEncryption;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.guidConfigResidDiffEncryption"]/*' />
        public Guid guidConfigResidDiffEncryption;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigBitstreamRaw"]/*' />
        public uint ConfigBitstreamRaw;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigMBcontrolRasterOrder"]/*' />
        public uint ConfigMBcontrolRasterOrder;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigResidDiffHost"]/*' />
        public uint ConfigResidDiffHost;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigSpatialResid8"]/*' />
        public uint ConfigSpatialResid8;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigResid8Subtraction"]/*' />
        public uint ConfigResid8Subtraction;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigSpatialHost8or9Clipping"]/*' />
        public uint ConfigSpatialHost8or9Clipping;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigSpatialResidInterleaved"]/*' />
        public uint ConfigSpatialResidInterleaved;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigIntraResidUnsigned"]/*' />
        public uint ConfigIntraResidUnsigned;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigResidDiffAccelerator"]/*' />
        public uint ConfigResidDiffAccelerator;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigHostInverseScan"]/*' />
        public uint ConfigHostInverseScan;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigSpecificIDCT"]/*' />
        public uint ConfigSpecificIDCT;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.Config4GroupedCoefs"]/*' />
        public uint Config4GroupedCoefs;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigMinRenderTargetBuffCount"]/*' />
        public ushort ConfigMinRenderTargetBuffCount;

        /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigDecoderSpecific"]/*' />
        public ushort ConfigDecoderSpecific;
    }
}

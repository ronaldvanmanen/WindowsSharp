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

namespace WindowsSharp.Interop
{
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS"]/*' />
    public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS
    {
        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.OutputMergerLogicOp"]/*' />
        [NativeTypeName("BOOL")]
        public int OutputMergerLogicOp;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.UAVOnlyRenderingForcedSampleCount"]/*' />
        [NativeTypeName("BOOL")]
        public int UAVOnlyRenderingForcedSampleCount;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.DiscardAPIsSeenByDriver"]/*' />
        [NativeTypeName("BOOL")]
        public int DiscardAPIsSeenByDriver;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.FlagsForUpdateAndCopySeenByDriver"]/*' />
        [NativeTypeName("BOOL")]
        public int FlagsForUpdateAndCopySeenByDriver;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ClearView"]/*' />
        [NativeTypeName("BOOL")]
        public int ClearView;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.CopyWithOverlap"]/*' />
        [NativeTypeName("BOOL")]
        public int CopyWithOverlap;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ConstantBufferPartialUpdate"]/*' />
        [NativeTypeName("BOOL")]
        public int ConstantBufferPartialUpdate;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ConstantBufferOffsetting"]/*' />
        [NativeTypeName("BOOL")]
        public int ConstantBufferOffsetting;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.MapNoOverwriteOnDynamicConstantBuffer"]/*' />
        [NativeTypeName("BOOL")]
        public int MapNoOverwriteOnDynamicConstantBuffer;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.MapNoOverwriteOnDynamicBufferSRV"]/*' />
        [NativeTypeName("BOOL")]
        public int MapNoOverwriteOnDynamicBufferSRV;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.MultisampleRTVWithForcedSampleCountOne"]/*' />
        [NativeTypeName("BOOL")]
        public int MultisampleRTVWithForcedSampleCountOne;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.SAD4ShaderInstructions"]/*' />
        [NativeTypeName("BOOL")]
        public int SAD4ShaderInstructions;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ExtendedDoublesShaderInstructions"]/*' />
        [NativeTypeName("BOOL")]
        public int ExtendedDoublesShaderInstructions;

        /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ExtendedResourceSharing"]/*' />
        [NativeTypeName("BOOL")]
        public int ExtendedResourceSharing;
    }
}

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
    /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE"]/*' />
    public enum D3D11_FEATURE
    {
        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_THREADING"]/*' />
        D3D11_FEATURE_THREADING = 0,

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_DOUBLES"]/*' />
        D3D11_FEATURE_DOUBLES = (D3D11_FEATURE_THREADING + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_FORMAT_SUPPORT"]/*' />
        D3D11_FEATURE_FORMAT_SUPPORT = (D3D11_FEATURE_DOUBLES + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_FORMAT_SUPPORT2"]/*' />
        D3D11_FEATURE_FORMAT_SUPPORT2 = (D3D11_FEATURE_FORMAT_SUPPORT + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS"]/*' />
        D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS = (D3D11_FEATURE_FORMAT_SUPPORT2 + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS"]/*' />
        D3D11_FEATURE_D3D11_OPTIONS = (D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_ARCHITECTURE_INFO"]/*' />
        D3D11_FEATURE_ARCHITECTURE_INFO = (D3D11_FEATURE_D3D11_OPTIONS + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D9_OPTIONS"]/*' />
        D3D11_FEATURE_D3D9_OPTIONS = (D3D11_FEATURE_ARCHITECTURE_INFO + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT"]/*' />
        D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT = (D3D11_FEATURE_D3D9_OPTIONS + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D9_SHADOW_SUPPORT"]/*' />
        D3D11_FEATURE_D3D9_SHADOW_SUPPORT = (D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS1"]/*' />
        D3D11_FEATURE_D3D11_OPTIONS1 = (D3D11_FEATURE_D3D9_SHADOW_SUPPORT + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT"]/*' />
        D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT = (D3D11_FEATURE_D3D11_OPTIONS1 + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_MARKER_SUPPORT"]/*' />
        D3D11_FEATURE_MARKER_SUPPORT = (D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D9_OPTIONS1"]/*' />
        D3D11_FEATURE_D3D9_OPTIONS1 = (D3D11_FEATURE_MARKER_SUPPORT + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS2"]/*' />
        D3D11_FEATURE_D3D11_OPTIONS2 = (D3D11_FEATURE_D3D9_OPTIONS1 + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS3"]/*' />
        D3D11_FEATURE_D3D11_OPTIONS3 = (D3D11_FEATURE_D3D11_OPTIONS2 + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT"]/*' />
        D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT = (D3D11_FEATURE_D3D11_OPTIONS3 + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS4"]/*' />
        D3D11_FEATURE_D3D11_OPTIONS4 = (D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_SHADER_CACHE"]/*' />
        D3D11_FEATURE_SHADER_CACHE = (D3D11_FEATURE_D3D11_OPTIONS4 + 1),

        /// <include file='D3D11_FEATURE.xml' path='doc/member[@name="D3D11_FEATURE.D3D11_FEATURE_D3D11_OPTIONS5"]/*' />
        D3D11_FEATURE_D3D11_OPTIONS5 = (D3D11_FEATURE_SHADER_CACHE + 1),
    }
}

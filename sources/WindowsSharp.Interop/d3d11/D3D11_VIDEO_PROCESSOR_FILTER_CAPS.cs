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
    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS"]/*' />
    public enum D3D11_VIDEO_PROCESSOR_FILTER_CAPS
    {
        /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_BRIGHTNESS"]/*' />
        D3D11_VIDEO_PROCESSOR_FILTER_CAPS_BRIGHTNESS = 0x1,

        /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_CONTRAST"]/*' />
        D3D11_VIDEO_PROCESSOR_FILTER_CAPS_CONTRAST = 0x2,

        /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_HUE"]/*' />
        D3D11_VIDEO_PROCESSOR_FILTER_CAPS_HUE = 0x4,

        /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_SATURATION"]/*' />
        D3D11_VIDEO_PROCESSOR_FILTER_CAPS_SATURATION = 0x8,

        /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_NOISE_REDUCTION"]/*' />
        D3D11_VIDEO_PROCESSOR_FILTER_CAPS_NOISE_REDUCTION = 0x10,

        /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_EDGE_ENHANCEMENT"]/*' />
        D3D11_VIDEO_PROCESSOR_FILTER_CAPS_EDGE_ENHANCEMENT = 0x20,

        /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_ANAMORPHIC_SCALING"]/*' />
        D3D11_VIDEO_PROCESSOR_FILTER_CAPS_ANAMORPHIC_SCALING = 0x40,

        /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_STEREO_ADJUSTMENT"]/*' />
        D3D11_VIDEO_PROCESSOR_FILTER_CAPS_STEREO_ADJUSTMENT = 0x80,
    }
}

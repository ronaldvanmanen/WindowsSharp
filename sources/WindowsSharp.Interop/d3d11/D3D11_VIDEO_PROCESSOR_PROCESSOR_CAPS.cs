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
    /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS"]/*' />
    public enum D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS
    {
        /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND"]/*' />
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND = 0x1,

        /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB"]/*' />
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB = 0x2,

        /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE"]/*' />
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE = 0x4,

        /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION"]/*' />
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION = 0x8,

        /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE"]/*' />
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE = 0x10,

        /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION"]/*' />
        D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION = 0x20,
    }
}

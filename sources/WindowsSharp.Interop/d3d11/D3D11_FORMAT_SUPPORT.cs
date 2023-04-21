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
    /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT"]/*' />
    public enum D3D11_FORMAT_SUPPORT
    {
        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_BUFFER"]/*' />
        D3D11_FORMAT_SUPPORT_BUFFER = 0x1,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_IA_VERTEX_BUFFER"]/*' />
        D3D11_FORMAT_SUPPORT_IA_VERTEX_BUFFER = 0x2,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_IA_INDEX_BUFFER"]/*' />
        D3D11_FORMAT_SUPPORT_IA_INDEX_BUFFER = 0x4,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_SO_BUFFER"]/*' />
        D3D11_FORMAT_SUPPORT_SO_BUFFER = 0x8,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_TEXTURE1D"]/*' />
        D3D11_FORMAT_SUPPORT_TEXTURE1D = 0x10,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_TEXTURE2D"]/*' />
        D3D11_FORMAT_SUPPORT_TEXTURE2D = 0x20,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_TEXTURE3D"]/*' />
        D3D11_FORMAT_SUPPORT_TEXTURE3D = 0x40,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_TEXTURECUBE"]/*' />
        D3D11_FORMAT_SUPPORT_TEXTURECUBE = 0x80,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_SHADER_LOAD"]/*' />
        D3D11_FORMAT_SUPPORT_SHADER_LOAD = 0x100,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_SHADER_SAMPLE"]/*' />
        D3D11_FORMAT_SUPPORT_SHADER_SAMPLE = 0x200,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_COMPARISON"]/*' />
        D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_COMPARISON = 0x400,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_MONO_TEXT"]/*' />
        D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_MONO_TEXT = 0x800,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_MIP"]/*' />
        D3D11_FORMAT_SUPPORT_MIP = 0x1000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_MIP_AUTOGEN"]/*' />
        D3D11_FORMAT_SUPPORT_MIP_AUTOGEN = 0x2000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_RENDER_TARGET"]/*' />
        D3D11_FORMAT_SUPPORT_RENDER_TARGET = 0x4000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_BLENDABLE"]/*' />
        D3D11_FORMAT_SUPPORT_BLENDABLE = 0x8000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_DEPTH_STENCIL"]/*' />
        D3D11_FORMAT_SUPPORT_DEPTH_STENCIL = 0x10000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_CPU_LOCKABLE"]/*' />
        D3D11_FORMAT_SUPPORT_CPU_LOCKABLE = 0x20000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_MULTISAMPLE_RESOLVE"]/*' />
        D3D11_FORMAT_SUPPORT_MULTISAMPLE_RESOLVE = 0x40000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_DISPLAY"]/*' />
        D3D11_FORMAT_SUPPORT_DISPLAY = 0x80000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_CAST_WITHIN_BIT_LAYOUT"]/*' />
        D3D11_FORMAT_SUPPORT_CAST_WITHIN_BIT_LAYOUT = 0x100000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_MULTISAMPLE_RENDERTARGET"]/*' />
        D3D11_FORMAT_SUPPORT_MULTISAMPLE_RENDERTARGET = 0x200000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_MULTISAMPLE_LOAD"]/*' />
        D3D11_FORMAT_SUPPORT_MULTISAMPLE_LOAD = 0x400000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_SHADER_GATHER"]/*' />
        D3D11_FORMAT_SUPPORT_SHADER_GATHER = 0x800000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_BACK_BUFFER_CAST"]/*' />
        D3D11_FORMAT_SUPPORT_BACK_BUFFER_CAST = 0x1000000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_TYPED_UNORDERED_ACCESS_VIEW"]/*' />
        D3D11_FORMAT_SUPPORT_TYPED_UNORDERED_ACCESS_VIEW = 0x2000000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_SHADER_GATHER_COMPARISON"]/*' />
        D3D11_FORMAT_SUPPORT_SHADER_GATHER_COMPARISON = 0x4000000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_DECODER_OUTPUT"]/*' />
        D3D11_FORMAT_SUPPORT_DECODER_OUTPUT = 0x8000000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_OUTPUT"]/*' />
        D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_OUTPUT = 0x10000000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_INPUT"]/*' />
        D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_INPUT = 0x20000000,

        /// <include file='D3D11_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT.D3D11_FORMAT_SUPPORT_VIDEO_ENCODER"]/*' />
        D3D11_FORMAT_SUPPORT_VIDEO_ENCODER = 0x40000000,
    }
}

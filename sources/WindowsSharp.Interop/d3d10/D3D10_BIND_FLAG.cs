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
    /// <include file='D3D10_BIND_FLAG.xml' path='doc/member[@name="D3D10_BIND_FLAG"]/*' />
    public enum D3D10_BIND_FLAG
    {
        /// <include file='D3D10_BIND_FLAG.xml' path='doc/member[@name="D3D10_BIND_FLAG.D3D10_BIND_VERTEX_BUFFER"]/*' />
        D3D10_BIND_VERTEX_BUFFER = 0x1,

        /// <include file='D3D10_BIND_FLAG.xml' path='doc/member[@name="D3D10_BIND_FLAG.D3D10_BIND_INDEX_BUFFER"]/*' />
        D3D10_BIND_INDEX_BUFFER = 0x2,

        /// <include file='D3D10_BIND_FLAG.xml' path='doc/member[@name="D3D10_BIND_FLAG.D3D10_BIND_CONSTANT_BUFFER"]/*' />
        D3D10_BIND_CONSTANT_BUFFER = 0x4,

        /// <include file='D3D10_BIND_FLAG.xml' path='doc/member[@name="D3D10_BIND_FLAG.D3D10_BIND_SHADER_RESOURCE"]/*' />
        D3D10_BIND_SHADER_RESOURCE = 0x8,

        /// <include file='D3D10_BIND_FLAG.xml' path='doc/member[@name="D3D10_BIND_FLAG.D3D10_BIND_STREAM_OUTPUT"]/*' />
        D3D10_BIND_STREAM_OUTPUT = 0x10,

        /// <include file='D3D10_BIND_FLAG.xml' path='doc/member[@name="D3D10_BIND_FLAG.D3D10_BIND_RENDER_TARGET"]/*' />
        D3D10_BIND_RENDER_TARGET = 0x20,

        /// <include file='D3D10_BIND_FLAG.xml' path='doc/member[@name="D3D10_BIND_FLAG.D3D10_BIND_DEPTH_STENCIL"]/*' />
        D3D10_BIND_DEPTH_STENCIL = 0x40,
    }
}

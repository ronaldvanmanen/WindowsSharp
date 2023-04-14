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
    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE"]/*' />
    public enum D3DRESOURCETYPE
    {
        /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_SURFACE"]/*' />
        D3DRTYPE_SURFACE = 1,

        /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VOLUME"]/*' />
        D3DRTYPE_VOLUME = 2,

        /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_TEXTURE"]/*' />
        D3DRTYPE_TEXTURE = 3,

        /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VOLUMETEXTURE"]/*' />
        D3DRTYPE_VOLUMETEXTURE = 4,

        /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_CUBETEXTURE"]/*' />
        D3DRTYPE_CUBETEXTURE = 5,

        /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VERTEXBUFFER"]/*' />
        D3DRTYPE_VERTEXBUFFER = 6,

        /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_INDEXBUFFER"]/*' />
        D3DRTYPE_INDEXBUFFER = 7,

        /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_FORCE_DWORD"]/*' />
        D3DRTYPE_FORCE_DWORD = 0x7fffffff,
    }
}

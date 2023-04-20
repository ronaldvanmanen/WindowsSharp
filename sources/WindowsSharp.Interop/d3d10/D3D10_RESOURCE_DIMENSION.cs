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
    /// <include file='D3D10_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_RESOURCE_DIMENSION"]/*' />
    public enum D3D10_RESOURCE_DIMENSION
    {
        /// <include file='D3D10_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_UNKNOWN"]/*' />
        D3D10_RESOURCE_DIMENSION_UNKNOWN = 0,

        /// <include file='D3D10_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_BUFFER"]/*' />
        D3D10_RESOURCE_DIMENSION_BUFFER = 1,

        /// <include file='D3D10_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE1D"]/*' />
        D3D10_RESOURCE_DIMENSION_TEXTURE1D = 2,

        /// <include file='D3D10_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE2D"]/*' />
        D3D10_RESOURCE_DIMENSION_TEXTURE2D = 3,

        /// <include file='D3D10_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_RESOURCE_DIMENSION.D3D10_RESOURCE_DIMENSION_TEXTURE3D"]/*' />
        D3D10_RESOURCE_DIMENSION_TEXTURE3D = 4,
    }
}

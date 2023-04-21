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
    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE"]/*' />
    public enum D3D_RESOURCE_RETURN_TYPE
    {
        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_UNORM"]/*' />
        D3D_RETURN_TYPE_UNORM = 1,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_SNORM"]/*' />
        D3D_RETURN_TYPE_SNORM = 2,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_SINT"]/*' />
        D3D_RETURN_TYPE_SINT = 3,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_UINT"]/*' />
        D3D_RETURN_TYPE_UINT = 4,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_FLOAT"]/*' />
        D3D_RETURN_TYPE_FLOAT = 5,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_MIXED"]/*' />
        D3D_RETURN_TYPE_MIXED = 6,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_DOUBLE"]/*' />
        D3D_RETURN_TYPE_DOUBLE = 7,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_CONTINUED"]/*' />
        D3D_RETURN_TYPE_CONTINUED = 8,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_UNORM"]/*' />
        D3D10_RETURN_TYPE_UNORM = D3D_RETURN_TYPE_UNORM,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_SNORM"]/*' />
        D3D10_RETURN_TYPE_SNORM = D3D_RETURN_TYPE_SNORM,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_SINT"]/*' />
        D3D10_RETURN_TYPE_SINT = D3D_RETURN_TYPE_SINT,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_UINT"]/*' />
        D3D10_RETURN_TYPE_UINT = D3D_RETURN_TYPE_UINT,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_FLOAT"]/*' />
        D3D10_RETURN_TYPE_FLOAT = D3D_RETURN_TYPE_FLOAT,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_MIXED"]/*' />
        D3D10_RETURN_TYPE_MIXED = D3D_RETURN_TYPE_MIXED,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_UNORM"]/*' />
        D3D11_RETURN_TYPE_UNORM = D3D_RETURN_TYPE_UNORM,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_SNORM"]/*' />
        D3D11_RETURN_TYPE_SNORM = D3D_RETURN_TYPE_SNORM,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_SINT"]/*' />
        D3D11_RETURN_TYPE_SINT = D3D_RETURN_TYPE_SINT,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_UINT"]/*' />
        D3D11_RETURN_TYPE_UINT = D3D_RETURN_TYPE_UINT,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_FLOAT"]/*' />
        D3D11_RETURN_TYPE_FLOAT = D3D_RETURN_TYPE_FLOAT,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_MIXED"]/*' />
        D3D11_RETURN_TYPE_MIXED = D3D_RETURN_TYPE_MIXED,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_DOUBLE"]/*' />
        D3D11_RETURN_TYPE_DOUBLE = D3D_RETURN_TYPE_DOUBLE,

        /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_CONTINUED"]/*' />
        D3D11_RETURN_TYPE_CONTINUED = D3D_RETURN_TYPE_CONTINUED,
    }
}

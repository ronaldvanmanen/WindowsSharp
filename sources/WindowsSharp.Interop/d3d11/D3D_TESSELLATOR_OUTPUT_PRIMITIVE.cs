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
    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE"]/*' />
    public enum D3D_TESSELLATOR_OUTPUT_PRIMITIVE
    {
        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_UNDEFINED"]/*' />
        D3D_TESSELLATOR_OUTPUT_UNDEFINED = 0,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_POINT"]/*' />
        D3D_TESSELLATOR_OUTPUT_POINT = 1,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_LINE"]/*' />
        D3D_TESSELLATOR_OUTPUT_LINE = 2,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW"]/*' />
        D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW = 3,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW"]/*' />
        D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW = 4,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_UNDEFINED"]/*' />
        D3D11_TESSELLATOR_OUTPUT_UNDEFINED = D3D_TESSELLATOR_OUTPUT_UNDEFINED,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_POINT"]/*' />
        D3D11_TESSELLATOR_OUTPUT_POINT = D3D_TESSELLATOR_OUTPUT_POINT,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_LINE"]/*' />
        D3D11_TESSELLATOR_OUTPUT_LINE = D3D_TESSELLATOR_OUTPUT_LINE,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW"]/*' />
        D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW = D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW,

        /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW"]/*' />
        D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW = D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW,
    }
}

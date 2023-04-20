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
    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION"]/*' />
    public enum D3D_SRV_DIMENSION
    {
        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_UNKNOWN"]/*' />
        D3D_SRV_DIMENSION_UNKNOWN = 0,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_BUFFER"]/*' />
        D3D_SRV_DIMENSION_BUFFER = 1,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE1D"]/*' />
        D3D_SRV_DIMENSION_TEXTURE1D = 2,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE1DARRAY"]/*' />
        D3D_SRV_DIMENSION_TEXTURE1DARRAY = 3,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2D"]/*' />
        D3D_SRV_DIMENSION_TEXTURE2D = 4,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DARRAY"]/*' />
        D3D_SRV_DIMENSION_TEXTURE2DARRAY = 5,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DMS"]/*' />
        D3D_SRV_DIMENSION_TEXTURE2DMS = 6,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
        D3D_SRV_DIMENSION_TEXTURE2DMSARRAY = 7,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE3D"]/*' />
        D3D_SRV_DIMENSION_TEXTURE3D = 8,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURECUBE"]/*' />
        D3D_SRV_DIMENSION_TEXTURECUBE = 9,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURECUBEARRAY"]/*' />
        D3D_SRV_DIMENSION_TEXTURECUBEARRAY = 10,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_BUFFEREX"]/*' />
        D3D_SRV_DIMENSION_BUFFEREX = 11,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_UNKNOWN"]/*' />
        D3D10_SRV_DIMENSION_UNKNOWN = D3D_SRV_DIMENSION_UNKNOWN,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_BUFFER"]/*' />
        D3D10_SRV_DIMENSION_BUFFER = D3D_SRV_DIMENSION_BUFFER,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE1D"]/*' />
        D3D10_SRV_DIMENSION_TEXTURE1D = D3D_SRV_DIMENSION_TEXTURE1D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE1DARRAY"]/*' />
        D3D10_SRV_DIMENSION_TEXTURE1DARRAY = D3D_SRV_DIMENSION_TEXTURE1DARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2D"]/*' />
        D3D10_SRV_DIMENSION_TEXTURE2D = D3D_SRV_DIMENSION_TEXTURE2D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DARRAY"]/*' />
        D3D10_SRV_DIMENSION_TEXTURE2DARRAY = D3D_SRV_DIMENSION_TEXTURE2DARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DMS"]/*' />
        D3D10_SRV_DIMENSION_TEXTURE2DMS = D3D_SRV_DIMENSION_TEXTURE2DMS,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
        D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE3D"]/*' />
        D3D10_SRV_DIMENSION_TEXTURE3D = D3D_SRV_DIMENSION_TEXTURE3D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURECUBE"]/*' />
        D3D10_SRV_DIMENSION_TEXTURECUBE = D3D_SRV_DIMENSION_TEXTURECUBE,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_UNKNOWN"]/*' />
        D3D10_1_SRV_DIMENSION_UNKNOWN = D3D_SRV_DIMENSION_UNKNOWN,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_BUFFER"]/*' />
        D3D10_1_SRV_DIMENSION_BUFFER = D3D_SRV_DIMENSION_BUFFER,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE1D"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURE1D = D3D_SRV_DIMENSION_TEXTURE1D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY = D3D_SRV_DIMENSION_TEXTURE1DARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2D"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURE2D = D3D_SRV_DIMENSION_TEXTURE2D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY = D3D_SRV_DIMENSION_TEXTURE2DARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DMS"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURE2DMS = D3D_SRV_DIMENSION_TEXTURE2DMS,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE3D"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURE3D = D3D_SRV_DIMENSION_TEXTURE3D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURECUBE"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURECUBE = D3D_SRV_DIMENSION_TEXTURECUBE,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY"]/*' />
        D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY = D3D_SRV_DIMENSION_TEXTURECUBEARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_UNKNOWN"]/*' />
        D3D11_SRV_DIMENSION_UNKNOWN = D3D_SRV_DIMENSION_UNKNOWN,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_BUFFER"]/*' />
        D3D11_SRV_DIMENSION_BUFFER = D3D_SRV_DIMENSION_BUFFER,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE1D"]/*' />
        D3D11_SRV_DIMENSION_TEXTURE1D = D3D_SRV_DIMENSION_TEXTURE1D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE1DARRAY"]/*' />
        D3D11_SRV_DIMENSION_TEXTURE1DARRAY = D3D_SRV_DIMENSION_TEXTURE1DARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2D"]/*' />
        D3D11_SRV_DIMENSION_TEXTURE2D = D3D_SRV_DIMENSION_TEXTURE2D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DARRAY"]/*' />
        D3D11_SRV_DIMENSION_TEXTURE2DARRAY = D3D_SRV_DIMENSION_TEXTURE2DARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DMS"]/*' />
        D3D11_SRV_DIMENSION_TEXTURE2DMS = D3D_SRV_DIMENSION_TEXTURE2DMS,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*' />
        D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY = D3D_SRV_DIMENSION_TEXTURE2DMSARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE3D"]/*' />
        D3D11_SRV_DIMENSION_TEXTURE3D = D3D_SRV_DIMENSION_TEXTURE3D,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURECUBE"]/*' />
        D3D11_SRV_DIMENSION_TEXTURECUBE = D3D_SRV_DIMENSION_TEXTURECUBE,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURECUBEARRAY"]/*' />
        D3D11_SRV_DIMENSION_TEXTURECUBEARRAY = D3D_SRV_DIMENSION_TEXTURECUBEARRAY,

        /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_BUFFEREX"]/*' />
        D3D11_SRV_DIMENSION_BUFFEREX = D3D_SRV_DIMENSION_BUFFEREX,
    }
}

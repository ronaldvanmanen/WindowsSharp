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
    /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER"]/*' />
    public enum DXGI_MODE_SCANLINE_ORDER
    {
        /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER.DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED"]/*' />
        DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED = 0,

        /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER.DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE"]/*' />
        DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE = 1,

        /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER.DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST"]/*' />
        DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST = 2,

        /// <include file='DXGI_MODE_SCANLINE_ORDER.xml' path='doc/member[@name="DXGI_MODE_SCANLINE_ORDER.DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST"]/*' />
        DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST = 3,
    }
}

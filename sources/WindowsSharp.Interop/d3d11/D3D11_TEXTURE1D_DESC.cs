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
    /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC"]/*' />
    public partial struct D3D11_TEXTURE1D_DESC
    {
        /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC.Width"]/*' />
        public uint Width;

        /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC.MipLevels"]/*' />
        public uint MipLevels;

        /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC.ArraySize"]/*' />
        public uint ArraySize;

        /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC.Format"]/*' />
        public DXGI_FORMAT Format;

        /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC.Usage"]/*' />
        public D3D11_USAGE Usage;

        /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC.BindFlags"]/*' />
        public uint BindFlags;

        /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC.CPUAccessFlags"]/*' />
        public uint CPUAccessFlags;

        /// <include file='D3D11_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D11_TEXTURE1D_DESC.MiscFlags"]/*' />
        public uint MiscFlags;
    }
}

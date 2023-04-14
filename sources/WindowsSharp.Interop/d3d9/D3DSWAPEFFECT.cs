// WindowsSharp
//
// Copyright (C) 2021 Ronald van Manen <rvanmanen@gmail.com>
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
    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT"]/*' />
    public enum D3DSWAPEFFECT : uint
    {
        /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD"]/*' />
        D3DSWAPEFFECT_DISCARD = 1,

        /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FLIP"]/*' />
        D3DSWAPEFFECT_FLIP = 2,

        /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_COPY"]/*' />
        D3DSWAPEFFECT_COPY = 3,

        /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_OVERLAY"]/*' />
        D3DSWAPEFFECT_OVERLAY = 4,

        /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FLIPEX"]/*' />
        D3DSWAPEFFECT_FLIPEX = 5,

        /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FORCE_DWORD"]/*' />
        D3DSWAPEFFECT_FORCE_DWORD = 0x7fffffff,
    }
}

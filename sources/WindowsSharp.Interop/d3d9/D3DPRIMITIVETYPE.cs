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
    /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE"]/*' />
    public enum D3DPRIMITIVETYPE
    {
        /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_POINTLIST"]/*' />
        D3DPT_POINTLIST = 1,

        /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_LINELIST"]/*' />
        D3DPT_LINELIST = 2,

        /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_LINESTRIP"]/*' />
        D3DPT_LINESTRIP = 3,

        /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_TRIANGLELIST"]/*' />
        D3DPT_TRIANGLELIST = 4,

        /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_TRIANGLESTRIP"]/*' />
        D3DPT_TRIANGLESTRIP = 5,

        /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_TRIANGLEFAN"]/*' />
        D3DPT_TRIANGLEFAN = 6,

        /// <include file='D3DPRIMITIVETYPE.xml' path='doc/member[@name="D3DPRIMITIVETYPE.D3DPT_FORCE_DWORD"]/*' />
        D3DPT_FORCE_DWORD = 0x7fffffff,
    }
}

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
    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP"]/*' />
    public enum D3DTEXTUREOP
    {
        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_DISABLE"]/*' />
        D3DTOP_DISABLE = 1,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_SELECTARG1"]/*' />
        D3DTOP_SELECTARG1 = 2,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_SELECTARG2"]/*' />
        D3DTOP_SELECTARG2 = 3,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATE"]/*' />
        D3DTOP_MODULATE = 4,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATE2X"]/*' />
        D3DTOP_MODULATE2X = 5,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATE4X"]/*' />
        D3DTOP_MODULATE4X = 6,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_ADD"]/*' />
        D3DTOP_ADD = 7,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_ADDSIGNED"]/*' />
        D3DTOP_ADDSIGNED = 8,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_ADDSIGNED2X"]/*' />
        D3DTOP_ADDSIGNED2X = 9,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_SUBTRACT"]/*' />
        D3DTOP_SUBTRACT = 10,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_ADDSMOOTH"]/*' />
        D3DTOP_ADDSMOOTH = 11,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDDIFFUSEALPHA"]/*' />
        D3DTOP_BLENDDIFFUSEALPHA = 12,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDTEXTUREALPHA"]/*' />
        D3DTOP_BLENDTEXTUREALPHA = 13,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDFACTORALPHA"]/*' />
        D3DTOP_BLENDFACTORALPHA = 14,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDTEXTUREALPHAPM"]/*' />
        D3DTOP_BLENDTEXTUREALPHAPM = 15,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDCURRENTALPHA"]/*' />
        D3DTOP_BLENDCURRENTALPHA = 16,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_PREMODULATE"]/*' />
        D3DTOP_PREMODULATE = 17,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATEALPHA_ADDCOLOR"]/*' />
        D3DTOP_MODULATEALPHA_ADDCOLOR = 18,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATECOLOR_ADDALPHA"]/*' />
        D3DTOP_MODULATECOLOR_ADDALPHA = 19,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATEINVALPHA_ADDCOLOR"]/*' />
        D3DTOP_MODULATEINVALPHA_ADDCOLOR = 20,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATEINVCOLOR_ADDALPHA"]/*' />
        D3DTOP_MODULATEINVCOLOR_ADDALPHA = 21,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BUMPENVMAP"]/*' />
        D3DTOP_BUMPENVMAP = 22,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BUMPENVMAPLUMINANCE"]/*' />
        D3DTOP_BUMPENVMAPLUMINANCE = 23,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_DOTPRODUCT3"]/*' />
        D3DTOP_DOTPRODUCT3 = 24,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MULTIPLYADD"]/*' />
        D3DTOP_MULTIPLYADD = 25,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_LERP"]/*' />
        D3DTOP_LERP = 26,

        /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_FORCE_DWORD"]/*' />
        D3DTOP_FORCE_DWORD = 0x7fffffff,
    }
}

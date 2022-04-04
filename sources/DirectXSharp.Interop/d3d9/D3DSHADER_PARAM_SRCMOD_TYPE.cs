// DirectXSharp
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

namespace DirectXSharp.Interop
{
    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE"]/*' />
    public enum D3DSHADER_PARAM_SRCMOD_TYPE
    {
        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NONE"]/*' />
        D3DSPSM_NONE = 0 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NEG"]/*' />
        D3DSPSM_NEG = 1 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_BIAS"]/*' />
        D3DSPSM_BIAS = 2 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_BIASNEG"]/*' />
        D3DSPSM_BIASNEG = 3 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_SIGN"]/*' />
        D3DSPSM_SIGN = 4 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_SIGNNEG"]/*' />
        D3DSPSM_SIGNNEG = 5 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_COMP"]/*' />
        D3DSPSM_COMP = 6 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_X2"]/*' />
        D3DSPSM_X2 = 7 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_X2NEG"]/*' />
        D3DSPSM_X2NEG = 8 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_DZ"]/*' />
        D3DSPSM_DZ = 9 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_DW"]/*' />
        D3DSPSM_DW = 10 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_ABS"]/*' />
        D3DSPSM_ABS = 11 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_ABSNEG"]/*' />
        D3DSPSM_ABSNEG = 12 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NOT"]/*' />
        D3DSPSM_NOT = 13 << 24,

        /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_FORCE_DWORD"]/*' />
        D3DSPSM_FORCE_DWORD = 0x7fffffff,
    }
}

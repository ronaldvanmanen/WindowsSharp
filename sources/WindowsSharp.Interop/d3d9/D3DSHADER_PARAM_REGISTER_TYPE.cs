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
    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE"]/*' />
    public enum D3DSHADER_PARAM_REGISTER_TYPE
    {
        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEMP"]/*' />
        D3DSPR_TEMP = 0,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_INPUT"]/*' />
        D3DSPR_INPUT = 1,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST"]/*' />
        D3DSPR_CONST = 2,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_ADDR"]/*' />
        D3DSPR_ADDR = 3,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEXTURE"]/*' />
        D3DSPR_TEXTURE = 3,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_RASTOUT"]/*' />
        D3DSPR_RASTOUT = 4,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_ATTROUT"]/*' />
        D3DSPR_ATTROUT = 5,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEXCRDOUT"]/*' />
        D3DSPR_TEXCRDOUT = 6,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_OUTPUT"]/*' />
        D3DSPR_OUTPUT = 6,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONSTINT"]/*' />
        D3DSPR_CONSTINT = 7,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_COLOROUT"]/*' />
        D3DSPR_COLOROUT = 8,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_DEPTHOUT"]/*' />
        D3DSPR_DEPTHOUT = 9,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_SAMPLER"]/*' />
        D3DSPR_SAMPLER = 10,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST2"]/*' />
        D3DSPR_CONST2 = 11,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST3"]/*' />
        D3DSPR_CONST3 = 12,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST4"]/*' />
        D3DSPR_CONST4 = 13,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONSTBOOL"]/*' />
        D3DSPR_CONSTBOOL = 14,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_LOOP"]/*' />
        D3DSPR_LOOP = 15,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEMPFLOAT16"]/*' />
        D3DSPR_TEMPFLOAT16 = 16,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_MISCTYPE"]/*' />
        D3DSPR_MISCTYPE = 17,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_LABEL"]/*' />
        D3DSPR_LABEL = 18,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_PREDICATE"]/*' />
        D3DSPR_PREDICATE = 19,

        /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_FORCE_DWORD"]/*' />
        D3DSPR_FORCE_DWORD = 0x7fffffff,
    }
}

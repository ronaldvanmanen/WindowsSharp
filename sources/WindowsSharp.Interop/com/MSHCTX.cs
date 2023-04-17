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
    /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX"]/*' />
    public enum MSHCTX
    {
        /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_LOCAL"]/*' />
        MSHCTX_LOCAL = 0,

        /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_NOSHAREDMEM"]/*' />
        MSHCTX_NOSHAREDMEM = 1,

        /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_DIFFERENTMACHINE"]/*' />
        MSHCTX_DIFFERENTMACHINE = 2,

        /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_INPROC"]/*' />
        MSHCTX_INPROC = 3,

        /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_CROSSCTX"]/*' />
        MSHCTX_CROSSCTX = 4,

        /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_RESERVED1"]/*' />
        MSHCTX_RESERVED1 = 5,
    }
}

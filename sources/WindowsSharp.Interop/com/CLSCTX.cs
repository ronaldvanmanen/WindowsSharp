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
    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX"]/*' />
    public enum CLSCTX
    {
        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_INPROC_SERVER"]/*' />
        CLSCTX_INPROC_SERVER = 0x1,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_INPROC_HANDLER"]/*' />
        CLSCTX_INPROC_HANDLER = 0x2,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_LOCAL_SERVER"]/*' />
        CLSCTX_LOCAL_SERVER = 0x4,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_INPROC_SERVER16"]/*' />
        CLSCTX_INPROC_SERVER16 = 0x8,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_REMOTE_SERVER"]/*' />
        CLSCTX_REMOTE_SERVER = 0x10,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_INPROC_HANDLER16"]/*' />
        CLSCTX_INPROC_HANDLER16 = 0x20,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED1"]/*' />
        CLSCTX_RESERVED1 = 0x40,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED2"]/*' />
        CLSCTX_RESERVED2 = 0x80,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED3"]/*' />
        CLSCTX_RESERVED3 = 0x100,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED4"]/*' />
        CLSCTX_RESERVED4 = 0x200,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_NO_CODE_DOWNLOAD"]/*' />
        CLSCTX_NO_CODE_DOWNLOAD = 0x400,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED5"]/*' />
        CLSCTX_RESERVED5 = 0x800,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_NO_CUSTOM_MARSHAL"]/*' />
        CLSCTX_NO_CUSTOM_MARSHAL = 0x1000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ENABLE_CODE_DOWNLOAD"]/*' />
        CLSCTX_ENABLE_CODE_DOWNLOAD = 0x2000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_NO_FAILURE_LOG"]/*' />
        CLSCTX_NO_FAILURE_LOG = 0x4000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_DISABLE_AAA"]/*' />
        CLSCTX_DISABLE_AAA = 0x8000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ENABLE_AAA"]/*' />
        CLSCTX_ENABLE_AAA = 0x10000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_FROM_DEFAULT_CONTEXT"]/*' />
        CLSCTX_FROM_DEFAULT_CONTEXT = 0x20000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_X86_SERVER"]/*' />
        CLSCTX_ACTIVATE_X86_SERVER = 0x40000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_32_BIT_SERVER"]/*' />
        CLSCTX_ACTIVATE_32_BIT_SERVER = CLSCTX_ACTIVATE_X86_SERVER,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_64_BIT_SERVER"]/*' />
        CLSCTX_ACTIVATE_64_BIT_SERVER = 0x80000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ENABLE_CLOAKING"]/*' />
        CLSCTX_ENABLE_CLOAKING = 0x100000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_APPCONTAINER"]/*' />
        CLSCTX_APPCONTAINER = 0x400000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_AAA_AS_IU"]/*' />
        CLSCTX_ACTIVATE_AAA_AS_IU = 0x800000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED6"]/*' />
        CLSCTX_RESERVED6 = 0x1000000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_ARM32_SERVER"]/*' />
        CLSCTX_ACTIVATE_ARM32_SERVER = 0x2000000,

        /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_PS_DLL"]/*' />
        CLSCTX_PS_DLL = unchecked((int)(0x80000000)),
    }
}

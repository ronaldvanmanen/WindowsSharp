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
    /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS"]/*' />
    public enum GLOBALOPT_RO_FLAGS
    {
        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES"]/*' />
        COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES = 0x1,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES"]/*' />
        COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES = 0x2,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES"]/*' />
        COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES = 0x4,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_FAST_RUNDOWN"]/*' />
        COMGLB_FAST_RUNDOWN = 0x8,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED1"]/*' />
        COMGLB_RESERVED1 = 0x10,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED2"]/*' />
        COMGLB_RESERVED2 = 0x20,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED3"]/*' />
        COMGLB_RESERVED3 = 0x40,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES"]/*' />
        COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES = 0x80,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED4"]/*' />
        COMGLB_RESERVED4 = 0x100,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED5"]/*' />
        COMGLB_RESERVED5 = 0x200,

        /// <include file='GLOBALOPT_RO_FLAGS.xml' path='doc/member[@name="GLOBALOPT_RO_FLAGS.COMGLB_RESERVED6"]/*' />
        COMGLB_RESERVED6 = 0x400,
    }
}

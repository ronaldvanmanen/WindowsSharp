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
    /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE"]/*' />
    public enum AR_STATE
    {
        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_ENABLED"]/*' />
        AR_ENABLED = 0x0,

        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_DISABLED"]/*' />
        AR_DISABLED = 0x1,

        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_SUPPRESSED"]/*' />
        AR_SUPPRESSED = 0x2,

        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_REMOTESESSION"]/*' />
        AR_REMOTESESSION = 0x4,

        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_MULTIMON"]/*' />
        AR_MULTIMON = 0x8,

        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_NOSENSOR"]/*' />
        AR_NOSENSOR = 0x10,

        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_NOT_SUPPORTED"]/*' />
        AR_NOT_SUPPORTED = 0x20,

        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_DOCKED"]/*' />
        AR_DOCKED = 0x40,

        /// <include file='AR_STATE.xml' path='doc/member[@name="AR_STATE.AR_LAPTOP"]/*' />
        AR_LAPTOP = 0x80,
    }
}

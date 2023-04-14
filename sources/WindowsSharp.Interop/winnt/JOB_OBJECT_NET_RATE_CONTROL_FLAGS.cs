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
    /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS"]/*' />
    public enum JOB_OBJECT_NET_RATE_CONTROL_FLAGS
    {
        /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS.JOB_OBJECT_NET_RATE_CONTROL_ENABLE"]/*' />
        JOB_OBJECT_NET_RATE_CONTROL_ENABLE = 0x1,

        /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS.JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH"]/*' />
        JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH = 0x2,

        /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS.JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG"]/*' />
        JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG = 0x4,

        /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS.JOB_OBJECT_NET_RATE_CONTROL_VALID_FLAGS"]/*' />
        JOB_OBJECT_NET_RATE_CONTROL_VALID_FLAGS = 0x7,
    }
}

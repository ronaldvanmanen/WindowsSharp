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
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE"]/*' />
    public enum COPYFILE2_COPY_PHASE
    {
        /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_NONE"]/*' />
        COPYFILE2_PHASE_NONE = 0,

        /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_PREPARE_SOURCE"]/*' />
        COPYFILE2_PHASE_PREPARE_SOURCE,

        /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_PREPARE_DEST"]/*' />
        COPYFILE2_PHASE_PREPARE_DEST,

        /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_READ_SOURCE"]/*' />
        COPYFILE2_PHASE_READ_SOURCE,

        /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_WRITE_DESTINATION"]/*' />
        COPYFILE2_PHASE_WRITE_DESTINATION,

        /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_SERVER_COPY"]/*' />
        COPYFILE2_PHASE_SERVER_COPY,

        /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_NAMEGRAFT_COPY"]/*' />
        COPYFILE2_PHASE_NAMEGRAFT_COPY,

        /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_MAX"]/*' />
        COPYFILE2_PHASE_MAX,
    }
}

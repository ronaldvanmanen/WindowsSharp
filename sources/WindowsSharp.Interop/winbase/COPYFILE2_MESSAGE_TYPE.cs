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
    /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE"]/*' />
    public enum COPYFILE2_MESSAGE_TYPE
    {
        /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_NONE"]/*' />
        COPYFILE2_CALLBACK_NONE = 0,

        /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_CHUNK_STARTED"]/*' />
        COPYFILE2_CALLBACK_CHUNK_STARTED,

        /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_CHUNK_FINISHED"]/*' />
        COPYFILE2_CALLBACK_CHUNK_FINISHED,

        /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_STREAM_STARTED"]/*' />
        COPYFILE2_CALLBACK_STREAM_STARTED,

        /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_STREAM_FINISHED"]/*' />
        COPYFILE2_CALLBACK_STREAM_FINISHED,

        /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_POLL_CONTINUE"]/*' />
        COPYFILE2_CALLBACK_POLL_CONTINUE,

        /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_ERROR"]/*' />
        COPYFILE2_CALLBACK_ERROR,

        /// <include file='COPYFILE2_MESSAGE_TYPE.xml' path='doc/member[@name="COPYFILE2_MESSAGE_TYPE.COPYFILE2_CALLBACK_MAX"]/*' />
        COPYFILE2_CALLBACK_MAX,
    }
}

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
    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE"]/*' />
    public enum FEEDBACK_TYPE
    {
        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_CONTACTVISUALIZATION"]/*' />
        FEEDBACK_TOUCH_CONTACTVISUALIZATION = 1,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_BARRELVISUALIZATION"]/*' />
        FEEDBACK_PEN_BARRELVISUALIZATION = 2,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_TAP"]/*' />
        FEEDBACK_PEN_TAP = 3,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_DOUBLETAP"]/*' />
        FEEDBACK_PEN_DOUBLETAP = 4,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_PRESSANDHOLD"]/*' />
        FEEDBACK_PEN_PRESSANDHOLD = 5,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_RIGHTTAP"]/*' />
        FEEDBACK_PEN_RIGHTTAP = 6,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_TAP"]/*' />
        FEEDBACK_TOUCH_TAP = 7,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_DOUBLETAP"]/*' />
        FEEDBACK_TOUCH_DOUBLETAP = 8,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_PRESSANDHOLD"]/*' />
        FEEDBACK_TOUCH_PRESSANDHOLD = 9,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_RIGHTTAP"]/*' />
        FEEDBACK_TOUCH_RIGHTTAP = 10,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_GESTURE_PRESSANDTAP"]/*' />
        FEEDBACK_GESTURE_PRESSANDTAP = 11,

        /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_MAX"]/*' />
        FEEDBACK_MAX = unchecked((int)(0xFFFFFFFF)),
    }
}

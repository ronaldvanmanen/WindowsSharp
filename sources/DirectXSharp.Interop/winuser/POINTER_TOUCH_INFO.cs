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
    /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO"]/*' />
    public partial struct POINTER_TOUCH_INFO
    {
        /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.pointerInfo"]/*' />
        public POINTER_INFO pointerInfo;

        /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.touchFlags"]/*' />
        [NativeTypeName("TOUCH_FLAGS")]
        public uint touchFlags;

        /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.touchMask"]/*' />
        [NativeTypeName("TOUCH_MASK")]
        public uint touchMask;

        /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.rcContact"]/*' />
        public RECT rcContact;

        /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.rcContactRaw"]/*' />
        public RECT rcContactRaw;

        /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.orientation"]/*' />
        [NativeTypeName("UINT32")]
        public uint orientation;

        /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.pressure"]/*' />
        [NativeTypeName("UINT32")]
        public uint pressure;
    }
}

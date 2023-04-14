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
    /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY"]/*' />
    public partial struct POINTER_DEVICE_PROPERTY
    {
        /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.logicalMin"]/*' />
        [NativeTypeName("INT32")]
        public int logicalMin;

        /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.logicalMax"]/*' />
        [NativeTypeName("INT32")]
        public int logicalMax;

        /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.physicalMin"]/*' />
        [NativeTypeName("INT32")]
        public int physicalMin;

        /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.physicalMax"]/*' />
        [NativeTypeName("INT32")]
        public int physicalMax;

        /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.unit"]/*' />
        [NativeTypeName("UINT32")]
        public uint unit;

        /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.unitExponent"]/*' />
        [NativeTypeName("UINT32")]
        public uint unitExponent;

        /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.usagePageId"]/*' />
        public ushort usagePageId;

        /// <include file='POINTER_DEVICE_PROPERTY.xml' path='doc/member[@name="POINTER_DEVICE_PROPERTY.usageId"]/*' />
        public ushort usageId;
    }
}

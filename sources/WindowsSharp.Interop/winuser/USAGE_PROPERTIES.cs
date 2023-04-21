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
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES"]/*' />
    public partial struct USAGE_PROPERTIES
    {
        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.level"]/*' />
        public ushort level;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.page"]/*' />
        public ushort page;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.usage"]/*' />
        public ushort usage;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.logicalMinimum"]/*' />
        [NativeTypeName("INT32")]
        public int logicalMinimum;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.logicalMaximum"]/*' />
        [NativeTypeName("INT32")]
        public int logicalMaximum;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.unit"]/*' />
        public ushort unit;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.exponent"]/*' />
        public ushort exponent;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.count"]/*' />
        public byte count;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.physicalMinimum"]/*' />
        [NativeTypeName("INT32")]
        public int physicalMinimum;

        /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.physicalMaximum"]/*' />
        [NativeTypeName("INT32")]
        public int physicalMaximum;
    }
}

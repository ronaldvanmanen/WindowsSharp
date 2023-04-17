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
    /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE"]/*' />
    public enum ACTIVATIONTYPE
    {
        /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_UNCATEGORIZED"]/*' />
        ACTIVATIONTYPE_UNCATEGORIZED = 0,

        /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_MONIKER"]/*' />
        ACTIVATIONTYPE_FROM_MONIKER = 0x1,

        /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_DATA"]/*' />
        ACTIVATIONTYPE_FROM_DATA = 0x2,

        /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_STORAGE"]/*' />
        ACTIVATIONTYPE_FROM_STORAGE = 0x4,

        /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_STREAM"]/*' />
        ACTIVATIONTYPE_FROM_STREAM = 0x8,

        /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_FILE"]/*' />
        ACTIVATIONTYPE_FROM_FILE = 0x10,
    }
}

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
    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER"]/*' />
    public enum APTTYPEQUALIFIER
    {
        /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NONE"]/*' />
        APTTYPEQUALIFIER_NONE = 0,

        /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_IMPLICIT_MTA"]/*' />
        APTTYPEQUALIFIER_IMPLICIT_MTA = 1,

        /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NA_ON_MTA"]/*' />
        APTTYPEQUALIFIER_NA_ON_MTA = 2,

        /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NA_ON_STA"]/*' />
        APTTYPEQUALIFIER_NA_ON_STA = 3,

        /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA"]/*' />
        APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA = 4,

        /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NA_ON_MAINSTA"]/*' />
        APTTYPEQUALIFIER_NA_ON_MAINSTA = 5,

        /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_APPLICATION_STA"]/*' />
        APTTYPEQUALIFIER_APPLICATION_STA = 6,

        /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_RESERVED_1"]/*' />
        APTTYPEQUALIFIER_RESERVED_1 = 7,
    }
}

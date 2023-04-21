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
    /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES"]/*' />
    public enum EOLE_AUTHENTICATION_CAPABILITIES
    {
        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_NONE"]/*' />
        EOAC_NONE = 0,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_MUTUAL_AUTH"]/*' />
        EOAC_MUTUAL_AUTH = 0x1,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_STATIC_CLOAKING"]/*' />
        EOAC_STATIC_CLOAKING = 0x20,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_DYNAMIC_CLOAKING"]/*' />
        EOAC_DYNAMIC_CLOAKING = 0x40,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_ANY_AUTHORITY"]/*' />
        EOAC_ANY_AUTHORITY = 0x80,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_MAKE_FULLSIC"]/*' />
        EOAC_MAKE_FULLSIC = 0x100,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_DEFAULT"]/*' />
        EOAC_DEFAULT = 0x800,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_SECURE_REFS"]/*' />
        EOAC_SECURE_REFS = 0x2,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_ACCESS_CONTROL"]/*' />
        EOAC_ACCESS_CONTROL = 0x4,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_APPID"]/*' />
        EOAC_APPID = 0x8,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_DYNAMIC"]/*' />
        EOAC_DYNAMIC = 0x10,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_REQUIRE_FULLSIC"]/*' />
        EOAC_REQUIRE_FULLSIC = 0x200,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_AUTO_IMPERSONATE"]/*' />
        EOAC_AUTO_IMPERSONATE = 0x400,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_DISABLE_AAA"]/*' />
        EOAC_DISABLE_AAA = 0x1000,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_NO_CUSTOM_MARSHAL"]/*' />
        EOAC_NO_CUSTOM_MARSHAL = 0x2000,

        /// <include file='EOLE_AUTHENTICATION_CAPABILITIES.xml' path='doc/member[@name="EOLE_AUTHENTICATION_CAPABILITIES.EOAC_RESERVED1"]/*' />
        EOAC_RESERVED1 = 0x4000,
    }
}

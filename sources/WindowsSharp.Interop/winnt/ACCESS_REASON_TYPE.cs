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
    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE"]/*' />
    public enum ACCESS_REASON_TYPE
    {
        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNone"]/*' />
        AccessReasonNone = 0x00000000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonAllowedAce"]/*' />
        AccessReasonAllowedAce = 0x00010000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonDeniedAce"]/*' />
        AccessReasonDeniedAce = 0x00020000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonAllowedParentAce"]/*' />
        AccessReasonAllowedParentAce = 0x00030000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonDeniedParentAce"]/*' />
        AccessReasonDeniedParentAce = 0x00040000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNotGrantedByCape"]/*' />
        AccessReasonNotGrantedByCape = 0x00050000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNotGrantedByParentCape"]/*' />
        AccessReasonNotGrantedByParentCape = 0x00060000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNotGrantedToAppContainer"]/*' />
        AccessReasonNotGrantedToAppContainer = 0x00070000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonMissingPrivilege"]/*' />
        AccessReasonMissingPrivilege = 0x00100000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonFromPrivilege"]/*' />
        AccessReasonFromPrivilege = 0x00200000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonIntegrityLevel"]/*' />
        AccessReasonIntegrityLevel = 0x00300000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonOwnership"]/*' />
        AccessReasonOwnership = 0x00400000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNullDacl"]/*' />
        AccessReasonNullDacl = 0x00500000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonEmptyDacl"]/*' />
        AccessReasonEmptyDacl = 0x00600000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNoSD"]/*' />
        AccessReasonNoSD = 0x00700000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNoGrant"]/*' />
        AccessReasonNoGrant = 0x00800000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonTrustLabel"]/*' />
        AccessReasonTrustLabel = 0x00900000,

        /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonFilterAce"]/*' />
        AccessReasonFilterAce = 0x00a00000,
    }
}

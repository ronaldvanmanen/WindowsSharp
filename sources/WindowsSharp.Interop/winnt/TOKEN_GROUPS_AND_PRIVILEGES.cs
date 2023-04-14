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
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES"]/*' />
    public unsafe partial struct TOKEN_GROUPS_AND_PRIVILEGES
    {
        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.SidCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint SidCount;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.SidLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint SidLength;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.Sids"]/*' />
        [NativeTypeName("PSID_AND_ATTRIBUTES")]
        public SID_AND_ATTRIBUTES* Sids;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.RestrictedSidCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint RestrictedSidCount;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.RestrictedSidLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint RestrictedSidLength;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.RestrictedSids"]/*' />
        [NativeTypeName("PSID_AND_ATTRIBUTES")]
        public SID_AND_ATTRIBUTES* RestrictedSids;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.PrivilegeCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint PrivilegeCount;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.PrivilegeLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint PrivilegeLength;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.Privileges"]/*' />
        [NativeTypeName("PLUID_AND_ATTRIBUTES")]
        public LUID_AND_ATTRIBUTES* Privileges;

        /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.AuthenticationId"]/*' />
        public LUID AuthenticationId;
    }
}

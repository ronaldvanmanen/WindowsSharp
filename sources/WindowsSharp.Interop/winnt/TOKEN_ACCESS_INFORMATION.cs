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
    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION"]/*' />
    public unsafe partial struct TOKEN_ACCESS_INFORMATION
    {
        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.SidHash"]/*' />
        [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
        public SID_AND_ATTRIBUTES_HASH* SidHash;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.RestrictedSidHash"]/*' />
        [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
        public SID_AND_ATTRIBUTES_HASH* RestrictedSidHash;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.Privileges"]/*' />
        [NativeTypeName("PTOKEN_PRIVILEGES")]
        public TOKEN_PRIVILEGES* Privileges;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.AuthenticationId"]/*' />
        public LUID AuthenticationId;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.TokenType"]/*' />
        public TOKEN_TYPE TokenType;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.ImpersonationLevel"]/*' />
        public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.MandatoryPolicy"]/*' />
        public TOKEN_MANDATORY_POLICY MandatoryPolicy;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.AppContainerNumber"]/*' />
        [NativeTypeName("DWORD")]
        public uint AppContainerNumber;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.PackageSid"]/*' />
        [NativeTypeName("PSID")]
        public void* PackageSid;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.CapabilitiesHash"]/*' />
        [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
        public SID_AND_ATTRIBUTES_HASH* CapabilitiesHash;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.TrustLevelSid"]/*' />
        [NativeTypeName("PSID")]
        public void* TrustLevelSid;

        /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.SecurityAttributes"]/*' />
        [NativeTypeName("PSECURITY_ATTRIBUTES_OPAQUE")]
        public void* SecurityAttributes;
    }
}

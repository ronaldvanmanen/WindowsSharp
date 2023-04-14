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
    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS"]/*' />
    public enum TOKEN_INFORMATION_CLASS
    {
        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenUser"]/*' />
        TokenUser = 1,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenGroups"]/*' />
        TokenGroups,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenPrivileges"]/*' />
        TokenPrivileges,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenOwner"]/*' />
        TokenOwner,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenPrimaryGroup"]/*' />
        TokenPrimaryGroup,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenDefaultDacl"]/*' />
        TokenDefaultDacl,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSource"]/*' />
        TokenSource,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenType"]/*' />
        TokenType,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenImpersonationLevel"]/*' />
        TokenImpersonationLevel,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenStatistics"]/*' />
        TokenStatistics,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenRestrictedSids"]/*' />
        TokenRestrictedSids,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSessionId"]/*' />
        TokenSessionId,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenGroupsAndPrivileges"]/*' />
        TokenGroupsAndPrivileges,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSessionReference"]/*' />
        TokenSessionReference,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSandBoxInert"]/*' />
        TokenSandBoxInert,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenAuditPolicy"]/*' />
        TokenAuditPolicy,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenOrigin"]/*' />
        TokenOrigin,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenElevationType"]/*' />
        TokenElevationType,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenLinkedToken"]/*' />
        TokenLinkedToken,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenElevation"]/*' />
        TokenElevation,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenHasRestrictions"]/*' />
        TokenHasRestrictions,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenAccessInformation"]/*' />
        TokenAccessInformation,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenVirtualizationAllowed"]/*' />
        TokenVirtualizationAllowed,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenVirtualizationEnabled"]/*' />
        TokenVirtualizationEnabled,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIntegrityLevel"]/*' />
        TokenIntegrityLevel,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenUIAccess"]/*' />
        TokenUIAccess,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenMandatoryPolicy"]/*' />
        TokenMandatoryPolicy,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenLogonSid"]/*' />
        TokenLogonSid,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsAppContainer"]/*' />
        TokenIsAppContainer,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenCapabilities"]/*' />
        TokenCapabilities,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenAppContainerSid"]/*' />
        TokenAppContainerSid,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenAppContainerNumber"]/*' />
        TokenAppContainerNumber,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenUserClaimAttributes"]/*' />
        TokenUserClaimAttributes,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenDeviceClaimAttributes"]/*' />
        TokenDeviceClaimAttributes,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenRestrictedUserClaimAttributes"]/*' />
        TokenRestrictedUserClaimAttributes,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenRestrictedDeviceClaimAttributes"]/*' />
        TokenRestrictedDeviceClaimAttributes,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenDeviceGroups"]/*' />
        TokenDeviceGroups,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenRestrictedDeviceGroups"]/*' />
        TokenRestrictedDeviceGroups,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSecurityAttributes"]/*' />
        TokenSecurityAttributes,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsRestricted"]/*' />
        TokenIsRestricted,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenProcessTrustLevel"]/*' />
        TokenProcessTrustLevel,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenPrivateNameSpace"]/*' />
        TokenPrivateNameSpace,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSingletonAttributes"]/*' />
        TokenSingletonAttributes,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenBnoIsolation"]/*' />
        TokenBnoIsolation,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenChildProcessFlags"]/*' />
        TokenChildProcessFlags,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsLessPrivilegedAppContainer"]/*' />
        TokenIsLessPrivilegedAppContainer,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsSandboxed"]/*' />
        TokenIsSandboxed,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenOriginatingProcessTrustLevel"]/*' />
        TokenOriginatingProcessTrustLevel,

        /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.MaxTokenInfoClass"]/*' />
        MaxTokenInfoClass,
    }
}

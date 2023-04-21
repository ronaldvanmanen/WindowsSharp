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
    /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO"]/*' />
    public unsafe partial struct COAUTHINFO
    {
        /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwAuthnSvc"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwAuthnSvc;

        /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwAuthzSvc"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwAuthzSvc;

        /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.pwszServerPrincName"]/*' />
        [NativeTypeName("LPWSTR")]
        public ushort* pwszServerPrincName;

        /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwAuthnLevel"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwAuthnLevel;

        /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwImpersonationLevel"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwImpersonationLevel;

        /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.pAuthIdentityData"]/*' />
        public COAUTHIDENTITY* pAuthIdentityData;

        /// <include file='COAUTHINFO.xml' path='doc/member[@name="COAUTHINFO.dwCapabilities"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwCapabilities;
    }
}

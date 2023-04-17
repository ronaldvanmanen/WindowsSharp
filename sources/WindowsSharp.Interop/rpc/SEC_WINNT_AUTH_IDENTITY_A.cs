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
    /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A"]/*' />
    public unsafe partial struct SEC_WINNT_AUTH_IDENTITY_A
    {
        /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.User"]/*' />
        [NativeTypeName("unsigned char *")]
        public byte* User;

        /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.UserLength"]/*' />
        [NativeTypeName("unsigned long")]
        public uint UserLength;

        /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.Domain"]/*' />
        [NativeTypeName("unsigned char *")]
        public byte* Domain;

        /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.DomainLength"]/*' />
        [NativeTypeName("unsigned long")]
        public uint DomainLength;

        /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.Password"]/*' />
        [NativeTypeName("unsigned char *")]
        public byte* Password;

        /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.PasswordLength"]/*' />
        [NativeTypeName("unsigned long")]
        public uint PasswordLength;

        /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.Flags"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Flags;
    }
}

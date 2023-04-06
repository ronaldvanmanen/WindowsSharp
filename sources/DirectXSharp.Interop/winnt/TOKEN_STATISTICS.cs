// DirectXSharp
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

namespace DirectXSharp.Interop
{
    /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS"]/*' />
    public partial struct TOKEN_STATISTICS
    {
        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.TokenId"]/*' />
        public LUID TokenId;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.AuthenticationId"]/*' />
        public LUID AuthenticationId;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.ExpirationTime"]/*' />
        public LARGE_INTEGER ExpirationTime;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.TokenType"]/*' />
        public TOKEN_TYPE TokenType;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.ImpersonationLevel"]/*' />
        public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.DynamicCharged"]/*' />
        [NativeTypeName("DWORD")]
        public uint DynamicCharged;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.DynamicAvailable"]/*' />
        [NativeTypeName("DWORD")]
        public uint DynamicAvailable;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.GroupCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint GroupCount;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.PrivilegeCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint PrivilegeCount;

        /// <include file='TOKEN_STATISTICS.xml' path='doc/member[@name="TOKEN_STATISTICS.ModifiedId"]/*' />
        public LUID ModifiedId;
    }
}

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
    /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX"]/*' />
    public partial struct QUOTA_LIMITS_EX
    {
        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.PagedPoolLimit"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong PagedPoolLimit;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.NonPagedPoolLimit"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong NonPagedPoolLimit;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.MinimumWorkingSetSize"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong MinimumWorkingSetSize;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.MaximumWorkingSetSize"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong MaximumWorkingSetSize;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.PagefileLimit"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong PagefileLimit;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.TimeLimit"]/*' />
        public LARGE_INTEGER TimeLimit;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.WorkingSetLimit"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong WorkingSetLimit;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.Reserved2"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong Reserved2;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.Reserved3"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong Reserved3;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.Reserved4"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong Reserved4;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='QUOTA_LIMITS_EX.xml' path='doc/member[@name="QUOTA_LIMITS_EX.CpuRateLimit"]/*' />
        public RATE_QUOTA_LIMIT CpuRateLimit;
    }
}

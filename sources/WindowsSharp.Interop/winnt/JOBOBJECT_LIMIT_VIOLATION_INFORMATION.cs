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
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION"]/*' />
    public partial struct JOBOBJECT_LIMIT_VIOLATION_INFORMATION
    {
        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.LimitFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint LimitFlags;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.ViolationLimitFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ViolationLimitFlags;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.IoReadBytes"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong IoReadBytes;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.IoReadBytesLimit"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong IoReadBytesLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.IoWriteBytes"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong IoWriteBytes;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.IoWriteBytesLimit"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong IoWriteBytesLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.PerJobUserTime"]/*' />
        public LARGE_INTEGER PerJobUserTime;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.PerJobUserTimeLimit"]/*' />
        public LARGE_INTEGER PerJobUserTimeLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.JobMemory"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong JobMemory;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.JobMemoryLimit"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong JobMemoryLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.RateControlTolerance"]/*' />
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION.RateControlToleranceLimit"]/*' />
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit;
    }
}

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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2"]/*' />
    public partial struct JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2
    {
        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.LimitFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint LimitFlags;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.ViolationLimitFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ViolationLimitFlags;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.IoReadBytes"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong IoReadBytes;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.IoReadBytesLimit"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong IoReadBytesLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.IoWriteBytes"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong IoWriteBytes;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.IoWriteBytesLimit"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong IoWriteBytesLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.PerJobUserTime"]/*' />
        public LARGE_INTEGER PerJobUserTime;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.PerJobUserTimeLimit"]/*' />
        public LARGE_INTEGER PerJobUserTimeLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.JobMemory"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong JobMemory;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.Anonymous1"]/*' />
        [NativeTypeName("JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12117:5)")]
        public _Anonymous1_e__Union Anonymous1;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.Anonymous2"]/*' />
        [NativeTypeName("JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12122:5)")]
        public _Anonymous2_e__Union Anonymous2;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.Anonymous3"]/*' />
        [NativeTypeName("JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12127:5)")]
        public _Anonymous3_e__Union Anonymous3;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.JobLowMemoryLimit"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong JobLowMemoryLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.IoRateControlTolerance"]/*' />
        public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlTolerance;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.IoRateControlToleranceLimit"]/*' />
        public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlToleranceLimit;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.NetRateControlTolerance"]/*' />
        public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlTolerance;

        /// <include file='JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2.NetRateControlToleranceLimit"]/*' />
        public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlToleranceLimit;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.JobHighMemoryLimit"]/*' />
        public ref ulong JobHighMemoryLimit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.JobHighMemoryLimit, 1));
            }
        }

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.JobMemoryLimit"]/*' />
        public ref ulong JobMemoryLimit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.JobMemoryLimit, 1));
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.RateControlTolerance"]/*' />
        public ref JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.RateControlTolerance, 1));
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.CpuRateControlTolerance"]/*' />
        public ref JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.CpuRateControlTolerance, 1));
            }
        }

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.RateControlToleranceLimit"]/*' />
        public ref JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.RateControlToleranceLimit, 1));
            }
        }

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.CpuRateControlToleranceLimit"]/*' />
        public ref JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlToleranceLimit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.CpuRateControlToleranceLimit, 1));
            }
        }

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.JobHighMemoryLimit"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong JobHighMemoryLimit;

            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.JobMemoryLimit"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong JobMemoryLimit;
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.RateControlTolerance"]/*' />
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;

            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.CpuRateControlTolerance"]/*' />
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance;
        }

        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous3_e__Union
        {
            /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.RateControlToleranceLimit"]/*' />
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit;

            /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.CpuRateControlToleranceLimit"]/*' />
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlToleranceLimit;
        }
    }
}

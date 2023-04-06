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

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA"]/*' />
    public partial struct PERFORMANCE_DATA
    {
        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.Size"]/*' />
        [NativeTypeName("WORD")]
        public ushort Size;

        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.Version"]/*' />
        public byte Version;

        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.HwCountersCount"]/*' />
        public byte HwCountersCount;

        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.ContextSwitchCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint ContextSwitchCount;

        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.WaitReasonBitMap"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong WaitReasonBitMap;

        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.CycleTime"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong CycleTime;

        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.RetryCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint RetryCount;

        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.Reserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved;

        /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.HwCounters"]/*' />
        [NativeTypeName("HARDWARE_COUNTER_DATA [16]")]
        public _HwCounters_e__FixedBuffer HwCounters;

        /// <include file='_HwCounters_e__FixedBuffer.xml' path='doc/member[@name="_HwCounters_e__FixedBuffer"]/*' />
        public partial struct _HwCounters_e__FixedBuffer
        {
            public HARDWARE_COUNTER_DATA e0;
            public HARDWARE_COUNTER_DATA e1;
            public HARDWARE_COUNTER_DATA e2;
            public HARDWARE_COUNTER_DATA e3;
            public HARDWARE_COUNTER_DATA e4;
            public HARDWARE_COUNTER_DATA e5;
            public HARDWARE_COUNTER_DATA e6;
            public HARDWARE_COUNTER_DATA e7;
            public HARDWARE_COUNTER_DATA e8;
            public HARDWARE_COUNTER_DATA e9;
            public HARDWARE_COUNTER_DATA e10;
            public HARDWARE_COUNTER_DATA e11;
            public HARDWARE_COUNTER_DATA e12;
            public HARDWARE_COUNTER_DATA e13;
            public HARDWARE_COUNTER_DATA e14;
            public HARDWARE_COUNTER_DATA e15;

            public ref HARDWARE_COUNTER_DATA this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<HARDWARE_COUNTER_DATA> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}

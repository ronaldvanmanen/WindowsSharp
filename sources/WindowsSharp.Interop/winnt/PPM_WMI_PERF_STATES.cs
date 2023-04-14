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

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES"]/*' />
    public partial struct PPM_WMI_PERF_STATES
    {
        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.Count"]/*' />
        [NativeTypeName("DWORD")]
        public uint Count;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.MaxFrequency"]/*' />
        [NativeTypeName("DWORD")]
        public uint MaxFrequency;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.CurrentState"]/*' />
        [NativeTypeName("DWORD")]
        public uint CurrentState;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.MaxPerfState"]/*' />
        [NativeTypeName("DWORD")]
        public uint MaxPerfState;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.MinPerfState"]/*' />
        [NativeTypeName("DWORD")]
        public uint MinPerfState;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.LowestPerfState"]/*' />
        [NativeTypeName("DWORD")]
        public uint LowestPerfState;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.ThermalConstraint"]/*' />
        [NativeTypeName("DWORD")]
        public uint ThermalConstraint;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.BusyAdjThreshold"]/*' />
        public byte BusyAdjThreshold;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.PolicyType"]/*' />
        public byte PolicyType;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.Type"]/*' />
        public byte Type;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.Reserved"]/*' />
        public byte Reserved;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.TimerInterval"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimerInterval;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.TargetProcessors"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong TargetProcessors;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.PStateHandler"]/*' />
        [NativeTypeName("DWORD")]
        public uint PStateHandler;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.PStateContext"]/*' />
        [NativeTypeName("DWORD")]
        public uint PStateContext;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.TStateHandler"]/*' />
        [NativeTypeName("DWORD")]
        public uint TStateHandler;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.TStateContext"]/*' />
        [NativeTypeName("DWORD")]
        public uint TStateContext;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.FeedbackHandler"]/*' />
        [NativeTypeName("DWORD")]
        public uint FeedbackHandler;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.Reserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved1;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.Reserved2"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Reserved2;

        /// <include file='PPM_WMI_PERF_STATES.xml' path='doc/member[@name="PPM_WMI_PERF_STATES.State"]/*' />
        [NativeTypeName("PPM_WMI_PERF_STATE [1]")]
        public _State_e__FixedBuffer State;

        /// <include file='_State_e__FixedBuffer.xml' path='doc/member[@name="_State_e__FixedBuffer"]/*' />
        public partial struct _State_e__FixedBuffer
        {
            public PPM_WMI_PERF_STATE e0;

            public ref PPM_WMI_PERF_STATE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PPM_WMI_PERF_STATE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

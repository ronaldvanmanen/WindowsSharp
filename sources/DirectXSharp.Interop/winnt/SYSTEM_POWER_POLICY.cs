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
    /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY"]/*' />
    public unsafe partial struct SYSTEM_POWER_POLICY
    {
        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.Revision"]/*' />
        [NativeTypeName("DWORD")]
        public uint Revision;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.PowerButton"]/*' />
        public POWER_ACTION_POLICY PowerButton;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.SleepButton"]/*' />
        public POWER_ACTION_POLICY SleepButton;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.LidClose"]/*' />
        public POWER_ACTION_POLICY LidClose;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.LidOpenWake"]/*' />
        public SYSTEM_POWER_STATE LidOpenWake;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.Reserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.Idle"]/*' />
        public POWER_ACTION_POLICY Idle;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.IdleTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint IdleTimeout;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.IdleSensitivity"]/*' />
        public byte IdleSensitivity;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.DynamicThrottle"]/*' />
        public byte DynamicThrottle;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.Spare2"]/*' />
        [NativeTypeName("BYTE [2]")]
        public fixed byte Spare2[2];

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.MinSleep"]/*' />
        public SYSTEM_POWER_STATE MinSleep;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.MaxSleep"]/*' />
        public SYSTEM_POWER_STATE MaxSleep;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.ReducedLatencySleep"]/*' />
        public SYSTEM_POWER_STATE ReducedLatencySleep;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.WinLogonFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint WinLogonFlags;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.Spare3"]/*' />
        [NativeTypeName("DWORD")]
        public uint Spare3;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.DozeS4Timeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint DozeS4Timeout;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.BroadcastCapacityResolution"]/*' />
        [NativeTypeName("DWORD")]
        public uint BroadcastCapacityResolution;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.DischargePolicy"]/*' />
        [NativeTypeName("SYSTEM_POWER_LEVEL [4]")]
        public _DischargePolicy_e__FixedBuffer DischargePolicy;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.VideoTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint VideoTimeout;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.VideoDimDisplay"]/*' />
        [NativeTypeName("BOOLEAN")]
        public byte VideoDimDisplay;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.VideoReserved"]/*' />
        [NativeTypeName("DWORD [3]")]
        public fixed uint VideoReserved[3];

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.SpindownTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint SpindownTimeout;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.OptimizeForPower"]/*' />
        [NativeTypeName("BOOLEAN")]
        public byte OptimizeForPower;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.FanThrottleTolerance"]/*' />
        public byte FanThrottleTolerance;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.ForcedThrottle"]/*' />
        public byte ForcedThrottle;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.MinThrottle"]/*' />
        public byte MinThrottle;

        /// <include file='SYSTEM_POWER_POLICY.xml' path='doc/member[@name="SYSTEM_POWER_POLICY.OverThrottled"]/*' />
        public POWER_ACTION_POLICY OverThrottled;

        /// <include file='_DischargePolicy_e__FixedBuffer.xml' path='doc/member[@name="_DischargePolicy_e__FixedBuffer"]/*' />
        public partial struct _DischargePolicy_e__FixedBuffer
        {
            public SYSTEM_POWER_LEVEL e0;
            public SYSTEM_POWER_LEVEL e1;
            public SYSTEM_POWER_LEVEL e2;
            public SYSTEM_POWER_LEVEL e3;

            public ref SYSTEM_POWER_LEVEL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SYSTEM_POWER_LEVEL> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
        }
    }
}

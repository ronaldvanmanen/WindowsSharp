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

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA"]/*' />
    public partial struct CM_POWER_DATA
    {
        /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint PD_Size;

        /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_MostRecentPowerState"]/*' />
        public DEVICE_POWER_STATE PD_MostRecentPowerState;

        /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_Capabilities"]/*' />
        [NativeTypeName("DWORD")]
        public uint PD_Capabilities;

        /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_D1Latency"]/*' />
        [NativeTypeName("DWORD")]
        public uint PD_D1Latency;

        /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_D2Latency"]/*' />
        [NativeTypeName("DWORD")]
        public uint PD_D2Latency;

        /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_D3Latency"]/*' />
        [NativeTypeName("DWORD")]
        public uint PD_D3Latency;

        /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_PowerStateMapping"]/*' />
        [NativeTypeName("DEVICE_POWER_STATE [7]")]
        public _PD_PowerStateMapping_e__FixedBuffer PD_PowerStateMapping;

        /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_DeepestSystemWake"]/*' />
        public SYSTEM_POWER_STATE PD_DeepestSystemWake;

        /// <include file='_PD_PowerStateMapping_e__FixedBuffer.xml' path='doc/member[@name="_PD_PowerStateMapping_e__FixedBuffer"]/*' />
        public partial struct _PD_PowerStateMapping_e__FixedBuffer
        {
            public DEVICE_POWER_STATE e0;
            public DEVICE_POWER_STATE e1;
            public DEVICE_POWER_STATE e2;
            public DEVICE_POWER_STATE e3;
            public DEVICE_POWER_STATE e4;
            public DEVICE_POWER_STATE e5;
            public DEVICE_POWER_STATE e6;

            public ref DEVICE_POWER_STATE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<DEVICE_POWER_STATE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 7);
        }
    }
}

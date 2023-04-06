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
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE"]/*' />
    public unsafe partial struct SYSTEM_BATTERY_STATE
    {
        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.AcOnLine"]/*' />
        [NativeTypeName("BOOLEAN")]
        public byte AcOnLine;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.BatteryPresent"]/*' />
        [NativeTypeName("BOOLEAN")]
        public byte BatteryPresent;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Charging"]/*' />
        [NativeTypeName("BOOLEAN")]
        public byte Charging;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Discharging"]/*' />
        [NativeTypeName("BOOLEAN")]
        public byte Discharging;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Spare1"]/*' />
        [NativeTypeName("BOOLEAN [3]")]
        public fixed byte Spare1[3];

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Tag"]/*' />
        public byte Tag;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.MaxCapacity"]/*' />
        [NativeTypeName("DWORD")]
        public uint MaxCapacity;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.RemainingCapacity"]/*' />
        [NativeTypeName("DWORD")]
        public uint RemainingCapacity;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Rate"]/*' />
        [NativeTypeName("DWORD")]
        public uint Rate;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.EstimatedTime"]/*' />
        [NativeTypeName("DWORD")]
        public uint EstimatedTime;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.DefaultAlert1"]/*' />
        [NativeTypeName("DWORD")]
        public uint DefaultAlert1;

        /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.DefaultAlert2"]/*' />
        [NativeTypeName("DWORD")]
        public uint DefaultAlert2;
    }
}

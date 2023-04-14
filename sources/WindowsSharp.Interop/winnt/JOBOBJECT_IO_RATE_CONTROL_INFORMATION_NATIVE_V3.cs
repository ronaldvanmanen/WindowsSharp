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
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3"]/*' />
    public unsafe partial struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3
    {
        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.MaxIops"]/*' />
        [NativeTypeName("LONG64")]
        public long MaxIops;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.MaxBandwidth"]/*' />
        [NativeTypeName("LONG64")]
        public long MaxBandwidth;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.ReservationIops"]/*' />
        [NativeTypeName("LONG64")]
        public long ReservationIops;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.VolumeName"]/*' />
        [NativeTypeName("PWSTR")]
        public ushort* VolumeName;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.BaseIoSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint BaseIoSize;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.ControlFlags"]/*' />
        public JOB_OBJECT_IO_RATE_CONTROL_FLAGS ControlFlags;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.VolumeNameLength"]/*' />
        [NativeTypeName("WORD")]
        public ushort VolumeNameLength;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.CriticalReservationIops"]/*' />
        [NativeTypeName("LONG64")]
        public long CriticalReservationIops;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.ReservationBandwidth"]/*' />
        [NativeTypeName("LONG64")]
        public long ReservationBandwidth;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.CriticalReservationBandwidth"]/*' />
        [NativeTypeName("LONG64")]
        public long CriticalReservationBandwidth;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.MaxTimePercent"]/*' />
        [NativeTypeName("LONG64")]
        public long MaxTimePercent;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.ReservationTimePercent"]/*' />
        [NativeTypeName("LONG64")]
        public long ReservationTimePercent;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.CriticalReservationTimePercent"]/*' />
        [NativeTypeName("LONG64")]
        public long CriticalReservationTimePercent;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.SoftMaxIops"]/*' />
        [NativeTypeName("LONG64")]
        public long SoftMaxIops;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.SoftMaxBandwidth"]/*' />
        [NativeTypeName("LONG64")]
        public long SoftMaxBandwidth;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.SoftMaxTimePercent"]/*' />
        [NativeTypeName("LONG64")]
        public long SoftMaxTimePercent;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.LimitExcessNotifyIops"]/*' />
        [NativeTypeName("LONG64")]
        public long LimitExcessNotifyIops;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.LimitExcessNotifyBandwidth"]/*' />
        [NativeTypeName("LONG64")]
        public long LimitExcessNotifyBandwidth;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.LimitExcessNotifyTimePercent"]/*' />
        [NativeTypeName("LONG64")]
        public long LimitExcessNotifyTimePercent;
    }
}

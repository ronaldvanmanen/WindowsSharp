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
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1"]/*' />
    public unsafe partial struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1
    {
        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.MaxIops"]/*' />
        [NativeTypeName("LONG64")]
        public long MaxIops;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.MaxBandwidth"]/*' />
        [NativeTypeName("LONG64")]
        public long MaxBandwidth;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.ReservationIops"]/*' />
        [NativeTypeName("LONG64")]
        public long ReservationIops;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.VolumeName"]/*' />
        [NativeTypeName("PWSTR")]
        public ushort* VolumeName;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.BaseIoSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint BaseIoSize;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.ControlFlags"]/*' />
        public JOB_OBJECT_IO_RATE_CONTROL_FLAGS ControlFlags;

        /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.VolumeNameLength"]/*' />
        [NativeTypeName("WORD")]
        public ushort VolumeNameLength;
    }
}

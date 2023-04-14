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

namespace WindowsSharp.Interop
{
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE"]/*' />
    public partial struct PPM_WMI_PERF_STATE
    {
        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Frequency"]/*' />
        [NativeTypeName("DWORD")]
        public uint Frequency;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Power"]/*' />
        [NativeTypeName("DWORD")]
        public uint Power;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.PercentFrequency"]/*' />
        public byte PercentFrequency;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.IncreaseLevel"]/*' />
        public byte IncreaseLevel;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.DecreaseLevel"]/*' />
        public byte DecreaseLevel;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Type"]/*' />
        public byte Type;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.IncreaseTime"]/*' />
        [NativeTypeName("DWORD")]
        public uint IncreaseTime;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.DecreaseTime"]/*' />
        [NativeTypeName("DWORD")]
        public uint DecreaseTime;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Control"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Control;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Status"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Status;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.HitCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint HitCount;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Reserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved1;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Reserved2"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Reserved2;

        /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Reserved3"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Reserved3;
    }
}

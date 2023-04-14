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
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE"]/*' />
    public partial struct PPM_WMI_IDLE_STATE
    {
        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Latency"]/*' />
        [NativeTypeName("DWORD")]
        public uint Latency;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Power"]/*' />
        [NativeTypeName("DWORD")]
        public uint Power;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.TimeCheck"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeCheck;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.PromotePercent"]/*' />
        public byte PromotePercent;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.DemotePercent"]/*' />
        public byte DemotePercent;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.StateType"]/*' />
        public byte StateType;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Reserved"]/*' />
        public byte Reserved;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.StateFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint StateFlags;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Context"]/*' />
        [NativeTypeName("DWORD")]
        public uint Context;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.IdleHandler"]/*' />
        [NativeTypeName("DWORD")]
        public uint IdleHandler;

        /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Reserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved1;
    }
}

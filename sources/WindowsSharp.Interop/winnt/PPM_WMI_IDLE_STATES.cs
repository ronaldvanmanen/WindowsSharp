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
    /// <include file='PPM_WMI_IDLE_STATES.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES"]/*' />
    public partial struct PPM_WMI_IDLE_STATES
    {
        /// <include file='PPM_WMI_IDLE_STATES.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES.Type"]/*' />
        [NativeTypeName("DWORD")]
        public uint Type;

        /// <include file='PPM_WMI_IDLE_STATES.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES.Count"]/*' />
        [NativeTypeName("DWORD")]
        public uint Count;

        /// <include file='PPM_WMI_IDLE_STATES.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES.TargetState"]/*' />
        [NativeTypeName("DWORD")]
        public uint TargetState;

        /// <include file='PPM_WMI_IDLE_STATES.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES.OldState"]/*' />
        [NativeTypeName("DWORD")]
        public uint OldState;

        /// <include file='PPM_WMI_IDLE_STATES.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES.TargetProcessors"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong TargetProcessors;

        /// <include file='PPM_WMI_IDLE_STATES.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES.State"]/*' />
        [NativeTypeName("PPM_WMI_IDLE_STATE [1]")]
        public _State_e__FixedBuffer State;

        /// <include file='_State_e__FixedBuffer.xml' path='doc/member[@name="_State_e__FixedBuffer"]/*' />
        public partial struct _State_e__FixedBuffer
        {
            public PPM_WMI_IDLE_STATE e0;

            public ref PPM_WMI_IDLE_STATE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PPM_WMI_IDLE_STATE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

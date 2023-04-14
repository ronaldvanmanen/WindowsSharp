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
    /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX"]/*' />
    public partial struct PPM_IDLE_ACCOUNTING_EX
    {
        /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.StateCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint StateCount;

        /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.TotalTransitions"]/*' />
        [NativeTypeName("DWORD")]
        public uint TotalTransitions;

        /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.ResetCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint ResetCount;

        /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.AbortCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint AbortCount;

        /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.StartTime"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong StartTime;

        /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.State"]/*' />
        [NativeTypeName("PPM_IDLE_STATE_ACCOUNTING_EX [1]")]
        public _State_e__FixedBuffer State;

        /// <include file='_State_e__FixedBuffer.xml' path='doc/member[@name="_State_e__FixedBuffer"]/*' />
        public partial struct _State_e__FixedBuffer
        {
            public PPM_IDLE_STATE_ACCOUNTING_EX e0;

            public ref PPM_IDLE_STATE_ACCOUNTING_EX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PPM_IDLE_STATE_ACCOUNTING_EX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

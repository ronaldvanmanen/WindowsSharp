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
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX"]/*' />
    public partial struct PPM_IDLE_STATE_ACCOUNTING_EX
    {
        /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.TotalTime"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong TotalTime;

        /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.IdleTransitions"]/*' />
        [NativeTypeName("DWORD")]
        public uint IdleTransitions;

        /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.FailedTransitions"]/*' />
        [NativeTypeName("DWORD")]
        public uint FailedTransitions;

        /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.InvalidBucketIndex"]/*' />
        [NativeTypeName("DWORD")]
        public uint InvalidBucketIndex;

        /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.MinTimeUs"]/*' />
        [NativeTypeName("DWORD")]
        public uint MinTimeUs;

        /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.MaxTimeUs"]/*' />
        [NativeTypeName("DWORD")]
        public uint MaxTimeUs;

        /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.CancelledTransitions"]/*' />
        [NativeTypeName("DWORD")]
        public uint CancelledTransitions;

        /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.IdleTimeBuckets"]/*' />
        [NativeTypeName("PPM_IDLE_STATE_BUCKET_EX [16]")]
        public _IdleTimeBuckets_e__FixedBuffer IdleTimeBuckets;

        /// <include file='_IdleTimeBuckets_e__FixedBuffer.xml' path='doc/member[@name="_IdleTimeBuckets_e__FixedBuffer"]/*' />
        public partial struct _IdleTimeBuckets_e__FixedBuffer
        {
            public PPM_IDLE_STATE_BUCKET_EX e0;
            public PPM_IDLE_STATE_BUCKET_EX e1;
            public PPM_IDLE_STATE_BUCKET_EX e2;
            public PPM_IDLE_STATE_BUCKET_EX e3;
            public PPM_IDLE_STATE_BUCKET_EX e4;
            public PPM_IDLE_STATE_BUCKET_EX e5;
            public PPM_IDLE_STATE_BUCKET_EX e6;
            public PPM_IDLE_STATE_BUCKET_EX e7;
            public PPM_IDLE_STATE_BUCKET_EX e8;
            public PPM_IDLE_STATE_BUCKET_EX e9;
            public PPM_IDLE_STATE_BUCKET_EX e10;
            public PPM_IDLE_STATE_BUCKET_EX e11;
            public PPM_IDLE_STATE_BUCKET_EX e12;
            public PPM_IDLE_STATE_BUCKET_EX e13;
            public PPM_IDLE_STATE_BUCKET_EX e14;
            public PPM_IDLE_STATE_BUCKET_EX e15;

            public ref PPM_IDLE_STATE_BUCKET_EX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PPM_IDLE_STATE_BUCKET_EX> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}

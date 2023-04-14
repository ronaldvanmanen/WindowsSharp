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
    /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY"]/*' />
    public unsafe partial struct PROCESSOR_POWER_POLICY
    {
        /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.Revision"]/*' />
        [NativeTypeName("DWORD")]
        public uint Revision;

        /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.DynamicThrottle"]/*' />
        public byte DynamicThrottle;

        /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.Spare"]/*' />
        [NativeTypeName("BYTE [3]")]
        public fixed byte Spare[3];

        public uint _bitfield;

        /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.DisableCStates"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint DisableCStates
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.Reserved"]/*' />
        [NativeTypeName("DWORD : 31")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x7FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
            }
        }

        /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.PolicyCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint PolicyCount;

        /// <include file='PROCESSOR_POWER_POLICY.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY.Policy"]/*' />
        [NativeTypeName("PROCESSOR_POWER_POLICY_INFO [3]")]
        public _Policy_e__FixedBuffer Policy;

        /// <include file='_Policy_e__FixedBuffer.xml' path='doc/member[@name="_Policy_e__FixedBuffer"]/*' />
        public partial struct _Policy_e__FixedBuffer
        {
            public PROCESSOR_POWER_POLICY_INFO e0;
            public PROCESSOR_POWER_POLICY_INFO e1;
            public PROCESSOR_POWER_POLICY_INFO e2;

            public ref PROCESSOR_POWER_POLICY_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PROCESSOR_POWER_POLICY_INFO> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}

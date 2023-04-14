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
    /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP"]/*' />
    public unsafe partial struct PROCESSOR_RELATIONSHIP
    {
        /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.Flags"]/*' />
        public byte Flags;

        /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.EfficiencyClass"]/*' />
        public byte EfficiencyClass;

        /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.Reserved"]/*' />
        [NativeTypeName("BYTE [20]")]
        public fixed byte Reserved[20];

        /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.GroupCount"]/*' />
        [NativeTypeName("WORD")]
        public ushort GroupCount;

        /// <include file='PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="PROCESSOR_RELATIONSHIP.GroupMask"]/*' />
        [NativeTypeName("GROUP_AFFINITY [1]")]
        public _GroupMask_e__FixedBuffer GroupMask;

        /// <include file='_GroupMask_e__FixedBuffer.xml' path='doc/member[@name="_GroupMask_e__FixedBuffer"]/*' />
        public partial struct _GroupMask_e__FixedBuffer
        {
            public GROUP_AFFINITY e0;

            public ref GROUP_AFFINITY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<GROUP_AFFINITY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

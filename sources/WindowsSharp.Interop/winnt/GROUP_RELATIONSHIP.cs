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
    /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP"]/*' />
    public unsafe partial struct GROUP_RELATIONSHIP
    {
        /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP.MaximumGroupCount"]/*' />
        [NativeTypeName("WORD")]
        public ushort MaximumGroupCount;

        /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP.ActiveGroupCount"]/*' />
        [NativeTypeName("WORD")]
        public ushort ActiveGroupCount;

        /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP.Reserved"]/*' />
        [NativeTypeName("BYTE [20]")]
        public fixed byte Reserved[20];

        /// <include file='GROUP_RELATIONSHIP.xml' path='doc/member[@name="GROUP_RELATIONSHIP.GroupInfo"]/*' />
        [NativeTypeName("PROCESSOR_GROUP_INFO [1]")]
        public _GroupInfo_e__FixedBuffer GroupInfo;

        /// <include file='_GroupInfo_e__FixedBuffer.xml' path='doc/member[@name="_GroupInfo_e__FixedBuffer"]/*' />
        public partial struct _GroupInfo_e__FixedBuffer
        {
            public PROCESSOR_GROUP_INFO e0;

            public ref PROCESSOR_GROUP_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PROCESSOR_GROUP_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

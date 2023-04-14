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
    /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA"]/*' />
    public partial struct SCRUB_PARITY_EXTENT_DATA
    {
        /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.Size"]/*' />
        [NativeTypeName("WORD")]
        public ushort Size;

        /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.Flags"]/*' />
        [NativeTypeName("WORD")]
        public ushort Flags;

        /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.NumberOfParityExtents"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfParityExtents;

        /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.MaximumNumberOfParityExtents"]/*' />
        [NativeTypeName("WORD")]
        public ushort MaximumNumberOfParityExtents;

        /// <include file='SCRUB_PARITY_EXTENT_DATA.xml' path='doc/member[@name="SCRUB_PARITY_EXTENT_DATA.ParityExtents"]/*' />
        [NativeTypeName("SCRUB_PARITY_EXTENT [1]")]
        public _ParityExtents_e__FixedBuffer ParityExtents;

        /// <include file='_ParityExtents_e__FixedBuffer.xml' path='doc/member[@name="_ParityExtents_e__FixedBuffer"]/*' />
        public partial struct _ParityExtents_e__FixedBuffer
        {
            public SCRUB_PARITY_EXTENT e0;

            public ref SCRUB_PARITY_EXTENT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SCRUB_PARITY_EXTENT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

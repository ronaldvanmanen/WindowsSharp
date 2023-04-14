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
    /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16"]/*' />
    public unsafe partial struct EMRPOLYPOLYLINE16
    {
        /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.emr"]/*' />
        public EMR emr;

        /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.nPolys"]/*' />
        [NativeTypeName("DWORD")]
        public uint nPolys;

        /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.cpts"]/*' />
        [NativeTypeName("DWORD")]
        public uint cpts;

        /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.aPolyCounts"]/*' />
        [NativeTypeName("DWORD [1]")]
        public fixed uint aPolyCounts[1];

        /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.apts"]/*' />
        [NativeTypeName("POINTS [1]")]
        public _apts_e__FixedBuffer apts;

        /// <include file='_apts_e__FixedBuffer.xml' path='doc/member[@name="_apts_e__FixedBuffer"]/*' />
        public partial struct _apts_e__FixedBuffer
        {
            public POINTS e0;

            public ref POINTS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<POINTS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

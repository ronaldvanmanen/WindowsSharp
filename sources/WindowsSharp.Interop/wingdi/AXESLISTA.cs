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
    /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA"]/*' />
    public partial struct AXESLISTA
    {
        /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlReserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint axlReserved;

        /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlNumAxes"]/*' />
        [NativeTypeName("DWORD")]
        public uint axlNumAxes;

        /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlAxisInfo"]/*' />
        [NativeTypeName("AXISINFOA [16]")]
        public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

        /// <include file='_axlAxisInfo_e__FixedBuffer.xml' path='doc/member[@name="_axlAxisInfo_e__FixedBuffer"]/*' />
        public partial struct _axlAxisInfo_e__FixedBuffer
        {
            public AXISINFOA e0;
            public AXISINFOA e1;
            public AXISINFOA e2;
            public AXISINFOA e3;
            public AXISINFOA e4;
            public AXISINFOA e5;
            public AXISINFOA e6;
            public AXISINFOA e7;
            public AXISINFOA e8;
            public AXISINFOA e9;
            public AXISINFOA e10;
            public AXISINFOA e11;
            public AXISINFOA e12;
            public AXISINFOA e13;
            public AXISINFOA e14;
            public AXISINFOA e15;

            public ref AXISINFOA this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<AXISINFOA> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}

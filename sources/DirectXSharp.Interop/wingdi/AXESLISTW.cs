// DirectXSharp
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

namespace DirectXSharp.Interop
{
    /// <include file='AXESLISTW.xml' path='doc/member[@name="AXESLISTW"]/*' />
    public partial struct AXESLISTW
    {
        /// <include file='AXESLISTW.xml' path='doc/member[@name="AXESLISTW.axlReserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint axlReserved;

        /// <include file='AXESLISTW.xml' path='doc/member[@name="AXESLISTW.axlNumAxes"]/*' />
        [NativeTypeName("DWORD")]
        public uint axlNumAxes;

        /// <include file='AXESLISTW.xml' path='doc/member[@name="AXESLISTW.axlAxisInfo"]/*' />
        [NativeTypeName("AXISINFOW [16]")]
        public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

        /// <include file='_axlAxisInfo_e__FixedBuffer.xml' path='doc/member[@name="_axlAxisInfo_e__FixedBuffer"]/*' />
        public partial struct _axlAxisInfo_e__FixedBuffer
        {
            public AXISINFOW e0;
            public AXISINFOW e1;
            public AXISINFOW e2;
            public AXISINFOW e3;
            public AXISINFOW e4;
            public AXISINFOW e5;
            public AXISINFOW e6;
            public AXISINFOW e7;
            public AXISINFOW e8;
            public AXISINFOW e9;
            public AXISINFOW e10;
            public AXISINFOW e11;
            public AXISINFOW e12;
            public AXISINFOW e13;
            public AXISINFOW e14;
            public AXISINFOW e15;

            public ref AXISINFOW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<AXISINFOW> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}

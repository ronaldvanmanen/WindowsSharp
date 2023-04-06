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
    /// <include file='TTPOLYCURVE.xml' path='doc/member[@name="TTPOLYCURVE"]/*' />
    public partial struct TTPOLYCURVE
    {
        /// <include file='TTPOLYCURVE.xml' path='doc/member[@name="TTPOLYCURVE.wType"]/*' />
        [NativeTypeName("WORD")]
        public ushort wType;

        /// <include file='TTPOLYCURVE.xml' path='doc/member[@name="TTPOLYCURVE.cpfx"]/*' />
        [NativeTypeName("WORD")]
        public ushort cpfx;

        /// <include file='TTPOLYCURVE.xml' path='doc/member[@name="TTPOLYCURVE.apfx"]/*' />
        [NativeTypeName("POINTFX [1]")]
        public _apfx_e__FixedBuffer apfx;

        /// <include file='_apfx_e__FixedBuffer.xml' path='doc/member[@name="_apfx_e__FixedBuffer"]/*' />
        public partial struct _apfx_e__FixedBuffer
        {
            public POINTFX e0;

            public ref POINTFX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<POINTFX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

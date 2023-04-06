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
    /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET"]/*' />
    public partial struct GLYPHSET
    {
        /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.cbThis"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbThis;

        /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.flAccel"]/*' />
        [NativeTypeName("DWORD")]
        public uint flAccel;

        /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.cGlyphsSupported"]/*' />
        [NativeTypeName("DWORD")]
        public uint cGlyphsSupported;

        /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.cRanges"]/*' />
        [NativeTypeName("DWORD")]
        public uint cRanges;

        /// <include file='GLYPHSET.xml' path='doc/member[@name="GLYPHSET.ranges"]/*' />
        [NativeTypeName("WCRANGE [1]")]
        public _ranges_e__FixedBuffer ranges;

        /// <include file='_ranges_e__FixedBuffer.xml' path='doc/member[@name="_ranges_e__FixedBuffer"]/*' />
        public partial struct _ranges_e__FixedBuffer
        {
            public WCRANGE e0;

            public ref WCRANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<WCRANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

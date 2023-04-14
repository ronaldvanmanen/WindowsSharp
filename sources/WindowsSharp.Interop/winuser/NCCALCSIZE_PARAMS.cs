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
    /// <include file='NCCALCSIZE_PARAMS.xml' path='doc/member[@name="NCCALCSIZE_PARAMS"]/*' />
    public unsafe partial struct NCCALCSIZE_PARAMS
    {
        /// <include file='NCCALCSIZE_PARAMS.xml' path='doc/member[@name="NCCALCSIZE_PARAMS.rgrc"]/*' />
        [NativeTypeName("RECT [3]")]
        public _rgrc_e__FixedBuffer rgrc;

        /// <include file='NCCALCSIZE_PARAMS.xml' path='doc/member[@name="NCCALCSIZE_PARAMS.lppos"]/*' />
        [NativeTypeName("PWINDOWPOS")]
        public WINDOWPOS* lppos;

        /// <include file='_rgrc_e__FixedBuffer.xml' path='doc/member[@name="_rgrc_e__FixedBuffer"]/*' />
        public partial struct _rgrc_e__FixedBuffer
        {
            public RECT e0;
            public RECT e1;
            public RECT e2;

            public ref RECT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<RECT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}

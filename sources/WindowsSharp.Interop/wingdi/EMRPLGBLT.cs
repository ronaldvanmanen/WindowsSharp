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
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT"]/*' />
    public partial struct EMRPLGBLT
    {
        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.emr"]/*' />
        public EMR emr;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.rclBounds"]/*' />
        public RECTL rclBounds;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.aptlDest"]/*' />
        [NativeTypeName("POINTL [3]")]
        public _aptlDest_e__FixedBuffer aptlDest;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.xSrc"]/*' />
        [NativeTypeName("LONG")]
        public int xSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.ySrc"]/*' />
        [NativeTypeName("LONG")]
        public int ySrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cxSrc"]/*' />
        [NativeTypeName("LONG")]
        public int cxSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cySrc"]/*' />
        [NativeTypeName("LONG")]
        public int cySrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.xformSrc"]/*' />
        public XFORM xformSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.crBkColorSrc"]/*' />
        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.iUsageSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.offBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cbBmiSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.offBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cbBitsSrc"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.xMask"]/*' />
        [NativeTypeName("LONG")]
        public int xMask;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.yMask"]/*' />
        [NativeTypeName("LONG")]
        public int yMask;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.iUsageMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint iUsageMask;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.offBmiMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBmiMask;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cbBmiMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBmiMask;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.offBitsMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint offBitsMask;

        /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cbBitsMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbBitsMask;

        /// <include file='_aptlDest_e__FixedBuffer.xml' path='doc/member[@name="_aptlDest_e__FixedBuffer"]/*' />
        public partial struct _aptlDest_e__FixedBuffer
        {
            public POINTL e0;
            public POINTL e1;
            public POINTL e2;

            public ref POINTL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<POINTL> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}

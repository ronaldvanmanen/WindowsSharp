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
    /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE"]/*' />
    public partial struct UNWIND_HISTORY_TABLE
    {
        /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.Count"]/*' />
        [NativeTypeName("DWORD")]
        public uint Count;

        /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.LocalHint"]/*' />
        public byte LocalHint;

        /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.GlobalHint"]/*' />
        public byte GlobalHint;

        /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.Search"]/*' />
        public byte Search;

        /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.Once"]/*' />
        public byte Once;

        /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.LowAddress"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong LowAddress;

        /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.HighAddress"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong HighAddress;

        /// <include file='UNWIND_HISTORY_TABLE.xml' path='doc/member[@name="UNWIND_HISTORY_TABLE.Entry"]/*' />
        [NativeTypeName("UNWIND_HISTORY_TABLE_ENTRY [12]")]
        public _Entry_e__FixedBuffer Entry;

        /// <include file='_Entry_e__FixedBuffer.xml' path='doc/member[@name="_Entry_e__FixedBuffer"]/*' />
        public partial struct _Entry_e__FixedBuffer
        {
            public UNWIND_HISTORY_TABLE_ENTRY e0;
            public UNWIND_HISTORY_TABLE_ENTRY e1;
            public UNWIND_HISTORY_TABLE_ENTRY e2;
            public UNWIND_HISTORY_TABLE_ENTRY e3;
            public UNWIND_HISTORY_TABLE_ENTRY e4;
            public UNWIND_HISTORY_TABLE_ENTRY e5;
            public UNWIND_HISTORY_TABLE_ENTRY e6;
            public UNWIND_HISTORY_TABLE_ENTRY e7;
            public UNWIND_HISTORY_TABLE_ENTRY e8;
            public UNWIND_HISTORY_TABLE_ENTRY e9;
            public UNWIND_HISTORY_TABLE_ENTRY e10;
            public UNWIND_HISTORY_TABLE_ENTRY e11;

            public ref UNWIND_HISTORY_TABLE_ENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<UNWIND_HISTORY_TABLE_ENTRY> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 12);
        }
    }
}

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
    /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT"]/*' />
    public unsafe partial struct XSAVE_FORMAT
    {
        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.ControlWord"]/*' />
        [NativeTypeName("WORD")]
        public ushort ControlWord;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.StatusWord"]/*' />
        [NativeTypeName("WORD")]
        public ushort StatusWord;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.TagWord"]/*' />
        public byte TagWord;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.Reserved1"]/*' />
        public byte Reserved1;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.ErrorOpcode"]/*' />
        [NativeTypeName("WORD")]
        public ushort ErrorOpcode;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.ErrorOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint ErrorOffset;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.ErrorSelector"]/*' />
        [NativeTypeName("WORD")]
        public ushort ErrorSelector;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.Reserved2"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved2;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.DataOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint DataOffset;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.DataSelector"]/*' />
        [NativeTypeName("WORD")]
        public ushort DataSelector;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.Reserved3"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved3;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.MxCsr"]/*' />
        [NativeTypeName("DWORD")]
        public uint MxCsr;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.MxCsr_Mask"]/*' />
        [NativeTypeName("DWORD")]
        public uint MxCsr_Mask;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.FloatRegisters"]/*' />
        [NativeTypeName("M128A [8]")]
        public _FloatRegisters_e__FixedBuffer FloatRegisters;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.XmmRegisters"]/*' />
        [NativeTypeName("M128A [16]")]
        public _XmmRegisters_e__FixedBuffer XmmRegisters;

        /// <include file='XSAVE_FORMAT.xml' path='doc/member[@name="XSAVE_FORMAT.Reserved4"]/*' />
        [NativeTypeName("BYTE [96]")]
        public fixed byte Reserved4[96];

        /// <include file='_FloatRegisters_e__FixedBuffer.xml' path='doc/member[@name="_FloatRegisters_e__FixedBuffer"]/*' />
        public partial struct _FloatRegisters_e__FixedBuffer
        {
            public M128A e0;
            public M128A e1;
            public M128A e2;
            public M128A e3;
            public M128A e4;
            public M128A e5;
            public M128A e6;
            public M128A e7;

            public ref M128A this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }

        /// <include file='_XmmRegisters_e__FixedBuffer.xml' path='doc/member[@name="_XmmRegisters_e__FixedBuffer"]/*' />
        public partial struct _XmmRegisters_e__FixedBuffer
        {
            public M128A e0;
            public M128A e1;
            public M128A e2;
            public M128A e3;
            public M128A e4;
            public M128A e5;
            public M128A e6;
            public M128A e7;
            public M128A e8;
            public M128A e9;
            public M128A e10;
            public M128A e11;
            public M128A e12;
            public M128A e13;
            public M128A e14;
            public M128A e15;

            public ref M128A this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}

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
    /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT"]/*' />
    public partial struct CONTEXT
    {
        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.P1Home"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong P1Home;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.P2Home"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong P2Home;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.P3Home"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong P3Home;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.P4Home"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong P4Home;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.P5Home"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong P5Home;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.P6Home"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong P6Home;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.ContextFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ContextFlags;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.MxCsr"]/*' />
        [NativeTypeName("DWORD")]
        public uint MxCsr;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.SegCs"]/*' />
        [NativeTypeName("WORD")]
        public ushort SegCs;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.SegDs"]/*' />
        [NativeTypeName("WORD")]
        public ushort SegDs;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.SegEs"]/*' />
        [NativeTypeName("WORD")]
        public ushort SegEs;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.SegFs"]/*' />
        [NativeTypeName("WORD")]
        public ushort SegFs;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.SegGs"]/*' />
        [NativeTypeName("WORD")]
        public ushort SegGs;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.SegSs"]/*' />
        [NativeTypeName("WORD")]
        public ushort SegSs;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.EFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint EFlags;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Dr0"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Dr0;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Dr1"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Dr1;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Dr2"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Dr2;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Dr3"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Dr3;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Dr6"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Dr6;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Dr7"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Dr7;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rax"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rax;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rcx"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rcx;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rdx"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rdx;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rbx"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rbx;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rsp"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rsp;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rbp"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rbp;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rsi"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rsi;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rdi"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rdi;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.R8"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong R8;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.R9"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong R9;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.R10"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong R10;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.R11"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong R11;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.R12"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong R12;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.R13"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong R13;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.R14"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong R14;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.R15"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong R15;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Rip"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Rip;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.Anonymous"]/*' />
        [NativeTypeName("_CONTEXT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:3978:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.VectorRegister"]/*' />
        [NativeTypeName("M128A [26]")]
        public _VectorRegister_e__FixedBuffer VectorRegister;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.VectorControl"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong VectorControl;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.DebugControl"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong DebugControl;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.LastBranchToRip"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong LastBranchToRip;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.LastBranchFromRip"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong LastBranchFromRip;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.LastExceptionToRip"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong LastExceptionToRip;

        /// <include file='CONTEXT.xml' path='doc/member[@name="CONTEXT.LastExceptionFromRip"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong LastExceptionFromRip;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FltSave"]/*' />
        public ref XSAVE_FORMAT FltSave
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FltSave, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Header"]/*' />
        public Span<M128A> Header
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.Header.AsSpan();
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Legacy"]/*' />
        public Span<M128A> Legacy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.Legacy.AsSpan();
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm0"]/*' />
        public ref M128A Xmm0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm0, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm1"]/*' />
        public ref M128A Xmm1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm1, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm2"]/*' />
        public ref M128A Xmm2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm2, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm3"]/*' />
        public ref M128A Xmm3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm3, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm4"]/*' />
        public ref M128A Xmm4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm4, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm5"]/*' />
        public ref M128A Xmm5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm5, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm6"]/*' />
        public ref M128A Xmm6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm6, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm7"]/*' />
        public ref M128A Xmm7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm7, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm8"]/*' />
        public ref M128A Xmm8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm8, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm9"]/*' />
        public ref M128A Xmm9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm9, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm10"]/*' />
        public ref M128A Xmm10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm10, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm11"]/*' />
        public ref M128A Xmm11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm11, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm12"]/*' />
        public ref M128A Xmm12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm12, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm13"]/*' />
        public ref M128A Xmm13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm13, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm14"]/*' />
        public ref M128A Xmm14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm14, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm15"]/*' />
        public ref M128A Xmm15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Xmm15, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FltSave"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("XMM_SAVE_AREA32")]
            public XSAVE_FORMAT FltSave;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_CONTEXT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:3980:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Header"]/*' />
                [NativeTypeName("M128A [2]")]
                public _Header_e__FixedBuffer Header;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Legacy"]/*' />
                [NativeTypeName("M128A [8]")]
                public _Legacy_e__FixedBuffer Legacy;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm0"]/*' />
                public M128A Xmm0;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm1"]/*' />
                public M128A Xmm1;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm2"]/*' />
                public M128A Xmm2;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm3"]/*' />
                public M128A Xmm3;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm4"]/*' />
                public M128A Xmm4;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm5"]/*' />
                public M128A Xmm5;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm6"]/*' />
                public M128A Xmm6;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm7"]/*' />
                public M128A Xmm7;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm8"]/*' />
                public M128A Xmm8;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm9"]/*' />
                public M128A Xmm9;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm10"]/*' />
                public M128A Xmm10;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm11"]/*' />
                public M128A Xmm11;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm12"]/*' />
                public M128A Xmm12;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm13"]/*' />
                public M128A Xmm13;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm14"]/*' />
                public M128A Xmm14;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm15"]/*' />
                public M128A Xmm15;

                /// <include file='_Header_e__FixedBuffer.xml' path='doc/member[@name="_Header_e__FixedBuffer"]/*' />
                public partial struct _Header_e__FixedBuffer
                {
                    public M128A e0;
                    public M128A e1;

                    public ref M128A this[int index]
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return ref AsSpan()[index];
                        }
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
                }

                /// <include file='_Legacy_e__FixedBuffer.xml' path='doc/member[@name="_Legacy_e__FixedBuffer"]/*' />
                public partial struct _Legacy_e__FixedBuffer
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
            }
        }

        /// <include file='_VectorRegister_e__FixedBuffer.xml' path='doc/member[@name="_VectorRegister_e__FixedBuffer"]/*' />
        public partial struct _VectorRegister_e__FixedBuffer
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
            public M128A e16;
            public M128A e17;
            public M128A e18;
            public M128A e19;
            public M128A e20;
            public M128A e21;
            public M128A e22;
            public M128A e23;
            public M128A e24;
            public M128A e25;

            public ref M128A this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 26);
        }
    }
}

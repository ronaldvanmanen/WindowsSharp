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
    /// <include file='KNONVOLATILE_CONTEXT_POINTERS.xml' path='doc/member[@name="KNONVOLATILE_CONTEXT_POINTERS"]/*' />
    public unsafe partial struct KNONVOLATILE_CONTEXT_POINTERS
    {
        /// <include file='KNONVOLATILE_CONTEXT_POINTERS.xml' path='doc/member[@name="KNONVOLATILE_CONTEXT_POINTERS.Anonymous1"]/*' />
        [NativeTypeName("_KNONVOLATILE_CONTEXT_POINTERS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:4135:5)")]
        public _Anonymous1_e__Union Anonymous1;

        /// <include file='KNONVOLATILE_CONTEXT_POINTERS.xml' path='doc/member[@name="KNONVOLATILE_CONTEXT_POINTERS.Anonymous2"]/*' />
        [NativeTypeName("_KNONVOLATILE_CONTEXT_POINTERS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:4157:5)")]
        public _Anonymous2_e__Union Anonymous2;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.FloatingContext"]/*' />
        public Span<M128A> FloatingContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return new Span<M128A>(Anonymous1.FloatingContext.e0, 16);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm0"]/*' />
        public ref M128A* Xmm0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm0;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm1"]/*' />
        public ref M128A* Xmm1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm1;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm2"]/*' />
        public ref M128A* Xmm2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm2;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm3"]/*' />
        public ref M128A* Xmm3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm3;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm4"]/*' />
        public ref M128A* Xmm4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm4;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm5"]/*' />
        public ref M128A* Xmm5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm5;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm6"]/*' />
        public ref M128A* Xmm6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm6;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm7"]/*' />
        public ref M128A* Xmm7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm7;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm8"]/*' />
        public ref M128A* Xmm8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm8;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm9"]/*' />
        public ref M128A* Xmm9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm9;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm10"]/*' />
        public ref M128A* Xmm10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm10;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm11"]/*' />
        public ref M128A* Xmm11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm11;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm12"]/*' />
        public ref M128A* Xmm12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm12;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm13"]/*' />
        public ref M128A* Xmm13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm13;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm14"]/*' />
        public ref M128A* Xmm14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm14;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm15"]/*' />
        public ref M128A* Xmm15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.Anonymous.Xmm15;
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.IntegerContext"]/*' />
        public Span<ulong> IntegerContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return new Span<ulong>(Anonymous2.IntegerContext.e0, 16);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rax"]/*' />
        public ref ulong* Rax
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.Rax;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rcx"]/*' />
        public ref ulong* Rcx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.Rcx;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rdx"]/*' />
        public ref ulong* Rdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.Rdx;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rbx"]/*' />
        public ref ulong* Rbx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.Rbx;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rsp"]/*' />
        public ref ulong* Rsp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.Rsp;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rbp"]/*' />
        public ref ulong* Rbp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.Rbp;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rsi"]/*' />
        public ref ulong* Rsi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.Rsi;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rdi"]/*' />
        public ref ulong* Rdi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.Rdi;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R8"]/*' />
        public ref ulong* R8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.R8;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R9"]/*' />
        public ref ulong* R9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.R9;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R10"]/*' />
        public ref ulong* R10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.R10;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R11"]/*' />
        public ref ulong* R11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.R11;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R12"]/*' />
        public ref ulong* R12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.R12;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R13"]/*' />
        public ref ulong* R13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.R13;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R14"]/*' />
        public ref ulong* R14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.R14;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R15"]/*' />
        public ref ulong* R15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.Anonymous.R15;
            }
        }

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.FloatingContext"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("PM128A [16]")]
            public _FloatingContext_e__FixedBuffer FloatingContext;

            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_KNONVOLATILE_CONTEXT_POINTERS::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:4137:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public unsafe partial struct _Anonymous_e__Struct
            {
                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm0"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm0;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm1"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm1;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm2"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm2;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm3"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm3;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm4"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm4;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm5"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm5;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm6"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm6;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm7"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm7;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm8"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm8;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm9"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm9;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm10"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm10;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm11"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm11;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm12"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm12;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm13"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm13;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm14"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm14;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Xmm15"]/*' />
                [NativeTypeName("PM128A")]
                public M128A* Xmm15;
            }

            /// <include file='_FloatingContext_e__FixedBuffer.xml' path='doc/member[@name="_FloatingContext_e__FixedBuffer"]/*' />
            public unsafe partial struct _FloatingContext_e__FixedBuffer
            {
                public M128A* e0;
                public M128A* e1;
                public M128A* e2;
                public M128A* e3;
                public M128A* e4;
                public M128A* e5;
                public M128A* e6;
                public M128A* e7;
                public M128A* e8;
                public M128A* e9;
                public M128A* e10;
                public M128A* e11;
                public M128A* e12;
                public M128A* e13;
                public M128A* e14;
                public M128A* e15;

                public ref M128A* this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        fixed (M128A** pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.IntegerContext"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("PDWORD64 [16]")]
            public _IntegerContext_e__FixedBuffer IntegerContext;

            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_KNONVOLATILE_CONTEXT_POINTERS::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:4159:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public unsafe partial struct _Anonymous_e__Struct
            {
                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rax"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* Rax;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rcx"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* Rcx;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rdx"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* Rdx;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rbx"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* Rbx;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rsp"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* Rsp;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rbp"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* Rbp;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rsi"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* Rsi;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Rdi"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* Rdi;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R8"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* R8;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R9"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* R9;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R10"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* R10;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R11"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* R11;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R12"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* R12;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R13"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* R13;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R14"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* R14;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.R15"]/*' />
                [NativeTypeName("PDWORD64")]
                public ulong* R15;
            }

            /// <include file='_IntegerContext_e__FixedBuffer.xml' path='doc/member[@name="_IntegerContext_e__FixedBuffer"]/*' />
            public unsafe partial struct _IntegerContext_e__FixedBuffer
            {
                public ulong* e0;
                public ulong* e1;
                public ulong* e2;
                public ulong* e3;
                public ulong* e4;
                public ulong* e5;
                public ulong* e6;
                public ulong* e7;
                public ulong* e8;
                public ulong* e9;
                public ulong* e10;
                public ulong* e11;
                public ulong* e12;
                public ulong* e13;
                public ulong* e14;
                public ulong* e15;

                public ref ulong* this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        fixed (ulong** pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }
}

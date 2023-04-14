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
    /// <include file='PROCESSOR_IDLESTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_POLICY"]/*' />
    public partial struct PROCESSOR_IDLESTATE_POLICY
    {
        /// <include file='PROCESSOR_IDLESTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_POLICY.Revision"]/*' />
        [NativeTypeName("WORD")]
        public ushort Revision;

        /// <include file='PROCESSOR_IDLESTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_POLICY.Flags"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16637:5)")]
        public _Flags_e__Union Flags;

        /// <include file='PROCESSOR_IDLESTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_POLICY.PolicyCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint PolicyCount;

        /// <include file='PROCESSOR_IDLESTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_POLICY.Policy"]/*' />
        [NativeTypeName("PROCESSOR_IDLESTATE_INFO [3]")]
        public _Policy_e__FixedBuffer Policy;

        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Flags_e__Union
        {
            /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsWORD"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort AsWORD;

            /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("PROCESSOR_IDLESTATE_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16639:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowScaling"]/*' />
            public ushort AllowScaling
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous.AllowScaling;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous.AllowScaling = value;
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Disabled"]/*' />
            public ushort Disabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous.Disabled;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous.Disabled = value;
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            public ushort Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous.Reserved;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous.Reserved = value;
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                public ushort _bitfield;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllowScaling"]/*' />
                [NativeTypeName("WORD : 1")]
                public ushort AllowScaling
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (ushort)(_bitfield & 0x1u);
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u));
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Disabled"]/*' />
                [NativeTypeName("WORD : 1")]
                public ushort Disabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (ushort)((_bitfield >> 1) & 0x1u);
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
                [NativeTypeName("WORD : 14")]
                public ushort Reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (ushort)((_bitfield >> 2) & 0x3FFFu);
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (ushort)((_bitfield & ~(0x3FFFu << 2)) | ((value & 0x3FFFu) << 2));
                    }
                }
            }
        }

        /// <include file='_Policy_e__FixedBuffer.xml' path='doc/member[@name="_Policy_e__FixedBuffer"]/*' />
        public partial struct _Policy_e__FixedBuffer
        {
            public PROCESSOR_IDLESTATE_INFO e0;
            public PROCESSOR_IDLESTATE_INFO e1;
            public PROCESSOR_IDLESTATE_INFO e2;

            public ref PROCESSOR_IDLESTATE_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PROCESSOR_IDLESTATE_INFO> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}

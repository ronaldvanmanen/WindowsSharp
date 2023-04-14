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
    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION"]/*' />
    public unsafe partial struct XSTATE_CONFIGURATION
    {
        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.EnabledFeatures"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong EnabledFeatures;

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.EnabledVolatileFeatures"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong EnabledVolatileFeatures;

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Anonymous"]/*' />
        [NativeTypeName("_XSTATE_CONFIGURATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12868:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Features"]/*' />
        [NativeTypeName("XSTATE_FEATURE [64]")]
        public _Features_e__FixedBuffer Features;

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.EnabledSupervisorFeatures"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong EnabledSupervisorFeatures;

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.AlignedFeatures"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong AlignedFeatures;

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.AllFeatureSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint AllFeatureSize;

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.AllFeatures"]/*' />
        [NativeTypeName("DWORD [64]")]
        public fixed uint AllFeatures[64];

        /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.EnabledUserVisibleSupervisorFeatures"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong EnabledUserVisibleSupervisorFeatures;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ControlFlags"]/*' />
        public ref uint ControlFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ControlFlags, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OptimizedSave"]/*' />
        public uint OptimizedSave
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.OptimizedSave;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.OptimizedSave = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.CompactionEnabled"]/*' />
        public uint CompactionEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.CompactionEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.CompactionEnabled = value;
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ControlFlags"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint ControlFlags;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_XSTATE_CONFIGURATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12870:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OptimizedSave"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint OptimizedSave
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.CompactionEnabled"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint CompactionEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }
            }
        }

        /// <include file='_Features_e__FixedBuffer.xml' path='doc/member[@name="_Features_e__FixedBuffer"]/*' />
        public partial struct _Features_e__FixedBuffer
        {
            public XSTATE_FEATURE e0;
            public XSTATE_FEATURE e1;
            public XSTATE_FEATURE e2;
            public XSTATE_FEATURE e3;
            public XSTATE_FEATURE e4;
            public XSTATE_FEATURE e5;
            public XSTATE_FEATURE e6;
            public XSTATE_FEATURE e7;
            public XSTATE_FEATURE e8;
            public XSTATE_FEATURE e9;
            public XSTATE_FEATURE e10;
            public XSTATE_FEATURE e11;
            public XSTATE_FEATURE e12;
            public XSTATE_FEATURE e13;
            public XSTATE_FEATURE e14;
            public XSTATE_FEATURE e15;
            public XSTATE_FEATURE e16;
            public XSTATE_FEATURE e17;
            public XSTATE_FEATURE e18;
            public XSTATE_FEATURE e19;
            public XSTATE_FEATURE e20;
            public XSTATE_FEATURE e21;
            public XSTATE_FEATURE e22;
            public XSTATE_FEATURE e23;
            public XSTATE_FEATURE e24;
            public XSTATE_FEATURE e25;
            public XSTATE_FEATURE e26;
            public XSTATE_FEATURE e27;
            public XSTATE_FEATURE e28;
            public XSTATE_FEATURE e29;
            public XSTATE_FEATURE e30;
            public XSTATE_FEATURE e31;
            public XSTATE_FEATURE e32;
            public XSTATE_FEATURE e33;
            public XSTATE_FEATURE e34;
            public XSTATE_FEATURE e35;
            public XSTATE_FEATURE e36;
            public XSTATE_FEATURE e37;
            public XSTATE_FEATURE e38;
            public XSTATE_FEATURE e39;
            public XSTATE_FEATURE e40;
            public XSTATE_FEATURE e41;
            public XSTATE_FEATURE e42;
            public XSTATE_FEATURE e43;
            public XSTATE_FEATURE e44;
            public XSTATE_FEATURE e45;
            public XSTATE_FEATURE e46;
            public XSTATE_FEATURE e47;
            public XSTATE_FEATURE e48;
            public XSTATE_FEATURE e49;
            public XSTATE_FEATURE e50;
            public XSTATE_FEATURE e51;
            public XSTATE_FEATURE e52;
            public XSTATE_FEATURE e53;
            public XSTATE_FEATURE e54;
            public XSTATE_FEATURE e55;
            public XSTATE_FEATURE e56;
            public XSTATE_FEATURE e57;
            public XSTATE_FEATURE e58;
            public XSTATE_FEATURE e59;
            public XSTATE_FEATURE e60;
            public XSTATE_FEATURE e61;
            public XSTATE_FEATURE e62;
            public XSTATE_FEATURE e63;

            public ref XSTATE_FEATURE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<XSTATE_FEATURE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 64);
        }
    }
}

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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY"]/*' />
    public partial struct PROCESSOR_PERFSTATE_POLICY
    {
        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.Revision"]/*' />
        [NativeTypeName("DWORD")]
        public uint Revision;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.MaxThrottle"]/*' />
        public byte MaxThrottle;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.MinThrottle"]/*' />
        public byte MinThrottle;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.BusyAdjThreshold"]/*' />
        public byte BusyAdjThreshold;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.Anonymous"]/*' />
        [NativeTypeName("PROCESSOR_PERFSTATE_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16711:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.TimeCheck"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeCheck;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.IncreaseTime"]/*' />
        [NativeTypeName("DWORD")]
        public uint IncreaseTime;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.DecreaseTime"]/*' />
        [NativeTypeName("DWORD")]
        public uint DecreaseTime;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.IncreasePercent"]/*' />
        [NativeTypeName("DWORD")]
        public uint IncreasePercent;

        /// <include file='PROCESSOR_PERFSTATE_POLICY.xml' path='doc/member[@name="PROCESSOR_PERFSTATE_POLICY.DecreasePercent"]/*' />
        [NativeTypeName("DWORD")]
        public uint DecreasePercent;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Spare"]/*' />
        public ref byte Spare
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Spare, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
        public ref _Anonymous_e__Union._Flags_e__Union Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Spare"]/*' />
            [FieldOffset(0)]
            public byte Spare;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16713:9)")]
            public _Flags_e__Union Flags;

            /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*' />
            [StructLayout(LayoutKind.Explicit)]
            public partial struct _Flags_e__Union
            {
                /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsBYTE"]/*' />
                [FieldOffset(0)]
                public byte AsBYTE;

                /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("PROCESSOR_PERFSTATE_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:16715:13)")]
                public _Anonymous_e__Struct Anonymous;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NoDomainAccounting"]/*' />
                public byte NoDomainAccounting
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous.NoDomainAccounting;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous.NoDomainAccounting = value;
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IncreasePolicy"]/*' />
                public byte IncreasePolicy
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous.IncreasePolicy;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous.IncreasePolicy = value;
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DecreasePolicy"]/*' />
                public byte DecreasePolicy
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous.DecreasePolicy;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous.DecreasePolicy = value;
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
                public byte Reserved
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
                    public byte _bitfield;

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NoDomainAccounting"]/*' />
                    [NativeTypeName("byte : 1")]
                    public byte NoDomainAccounting
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)(_bitfield & 0x1u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
                        }
                    }

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IncreasePolicy"]/*' />
                    [NativeTypeName("byte : 2")]
                    public byte IncreasePolicy
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 1) & 0x3u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x3u << 1)) | ((value & 0x3u) << 1));
                        }
                    }

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DecreasePolicy"]/*' />
                    [NativeTypeName("byte : 2")]
                    public byte DecreasePolicy
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 3) & 0x3u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x3u << 3)) | ((value & 0x3u) << 3));
                        }
                    }

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
                    [NativeTypeName("byte : 3")]
                    public byte Reserved
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 5) & 0x7u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x7u << 5)) | ((value & 0x7u) << 5));
                        }
                    }
                }
            }
        }
    }
}

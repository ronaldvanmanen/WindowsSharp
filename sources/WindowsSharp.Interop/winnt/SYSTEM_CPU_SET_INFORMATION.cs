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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='SYSTEM_CPU_SET_INFORMATION.xml' path='doc/member[@name="SYSTEM_CPU_SET_INFORMATION"]/*' />
    public partial struct SYSTEM_CPU_SET_INFORMATION
    {
        /// <include file='SYSTEM_CPU_SET_INFORMATION.xml' path='doc/member[@name="SYSTEM_CPU_SET_INFORMATION.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='SYSTEM_CPU_SET_INFORMATION.xml' path='doc/member[@name="SYSTEM_CPU_SET_INFORMATION.Type"]/*' />
        public CPU_SET_INFORMATION_TYPE Type;

        /// <include file='SYSTEM_CPU_SET_INFORMATION.xml' path='doc/member[@name="SYSTEM_CPU_SET_INFORMATION.Anonymous"]/*' />
        [NativeTypeName("_SYSTEM_CPU_SET_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12628:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuSet"]/*' />
        public ref _Anonymous_e__Union._CpuSet_e__Struct CpuSet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.CpuSet, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuSet"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12629:9)")]
            public _CpuSet_e__Struct CpuSet;

            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct"]/*' />
            public partial struct _CpuSet_e__Struct
            {
                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.Id"]/*' />
                [NativeTypeName("DWORD")]
                public uint Id;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.Group"]/*' />
                [NativeTypeName("WORD")]
                public ushort Group;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.LogicalProcessorIndex"]/*' />
                public byte LogicalProcessorIndex;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.CoreIndex"]/*' />
                public byte CoreIndex;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.LastLevelCacheIndex"]/*' />
                public byte LastLevelCacheIndex;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.NumaNodeIndex"]/*' />
                public byte NumaNodeIndex;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.EfficiencyClass"]/*' />
                public byte EfficiencyClass;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.Anonymous1"]/*' />
                [NativeTypeName("_SYSTEM_CPU_SET_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12637:13)")]
                public _Anonymous1_e__Union Anonymous1;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.Anonymous2"]/*' />
                [NativeTypeName("_SYSTEM_CPU_SET_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12654:13)")]
                public _Anonymous2_e__Union Anonymous2;

                /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.AllocationTag"]/*' />
                [NativeTypeName("DWORD64")]
                public ulong AllocationTag;

                /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.AllFlags"]/*' />
                public ref byte AllFlags
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.AllFlags, 1));
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Parked"]/*' />
                public byte Parked
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.Parked;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.Parked = value;
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Allocated"]/*' />
                public byte Allocated
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.Allocated;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.Allocated = value;
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllocatedToTargetProcess"]/*' />
                public byte AllocatedToTargetProcess
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.AllocatedToTargetProcess;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.AllocatedToTargetProcess = value;
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RealTime"]/*' />
                public byte RealTime
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.RealTime;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.RealTime = value;
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
                public byte ReservedFlags
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.ReservedFlags;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.ReservedFlags = value;
                    }
                }

                /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Reserved"]/*' />
                public ref uint Reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Reserved, 1));
                    }
                }

                /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.SchedulingClass"]/*' />
                public ref byte SchedulingClass
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.SchedulingClass, 1));
                    }
                }

                /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
                [StructLayout(LayoutKind.Explicit)]
                public partial struct _Anonymous1_e__Union
                {
                    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.AllFlags"]/*' />
                    [FieldOffset(0)]
                    public byte AllFlags;

                    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*' />
                    [FieldOffset(0)]
                    [NativeTypeName("_SYSTEM_CPU_SET_INFORMATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12645:17)")]
                    public _Anonymous_e__Struct Anonymous;

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
                    public partial struct _Anonymous_e__Struct
                    {
                        public byte _bitfield;

                        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Parked"]/*' />
                        [NativeTypeName("byte : 1")]
                        public byte Parked
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

                        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Allocated"]/*' />
                        [NativeTypeName("byte : 1")]
                        public byte Allocated
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)((_bitfield >> 1) & 0x1u);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                            }
                        }

                        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllocatedToTargetProcess"]/*' />
                        [NativeTypeName("byte : 1")]
                        public byte AllocatedToTargetProcess
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)((_bitfield >> 2) & 0x1u);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
                            }
                        }

                        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RealTime"]/*' />
                        [NativeTypeName("byte : 1")]
                        public byte RealTime
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)((_bitfield >> 3) & 0x1u);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
                            }
                        }

                        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
                        [NativeTypeName("byte : 4")]
                        public byte ReservedFlags
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)((_bitfield >> 4) & 0xFu);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~(0xFu << 4)) | ((value & 0xFu) << 4));
                            }
                        }
                    }
                }

                /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
                [StructLayout(LayoutKind.Explicit)]
                public partial struct _Anonymous2_e__Union
                {
                    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Reserved"]/*' />
                    [FieldOffset(0)]
                    [NativeTypeName("DWORD")]
                    public uint Reserved;

                    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.SchedulingClass"]/*' />
                    [FieldOffset(0)]
                    public byte SchedulingClass;
                }
            }
        }
    }
}

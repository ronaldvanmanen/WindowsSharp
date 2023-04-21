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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY"]/*' />
    public partial struct PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY
    {
        /// <include file='PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY.Anonymous"]/*' />
        [NativeTypeName("_PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11861:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableExportAddressFilter"]/*' />
        public uint EnableExportAddressFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.EnableExportAddressFilter;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.EnableExportAddressFilter = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditExportAddressFilter"]/*' />
        public uint AuditExportAddressFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditExportAddressFilter;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditExportAddressFilter = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableExportAddressFilterPlus"]/*' />
        public uint EnableExportAddressFilterPlus
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.EnableExportAddressFilterPlus;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.EnableExportAddressFilterPlus = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditExportAddressFilterPlus"]/*' />
        public uint AuditExportAddressFilterPlus
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditExportAddressFilterPlus;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditExportAddressFilterPlus = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableImportAddressFilter"]/*' />
        public uint EnableImportAddressFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.EnableImportAddressFilter;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.EnableImportAddressFilter = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditImportAddressFilter"]/*' />
        public uint AuditImportAddressFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditImportAddressFilter;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditImportAddressFilter = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableRopStackPivot"]/*' />
        public uint EnableRopStackPivot
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.EnableRopStackPivot;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.EnableRopStackPivot = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditRopStackPivot"]/*' />
        public uint AuditRopStackPivot
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditRopStackPivot;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditRopStackPivot = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableRopCallerCheck"]/*' />
        public uint EnableRopCallerCheck
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.EnableRopCallerCheck;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.EnableRopCallerCheck = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditRopCallerCheck"]/*' />
        public uint AuditRopCallerCheck
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditRopCallerCheck;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditRopCallerCheck = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableRopSimExec"]/*' />
        public uint EnableRopSimExec
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.EnableRopSimExec;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.EnableRopSimExec = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditRopSimExec"]/*' />
        public uint AuditRopSimExec
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditRopSimExec;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditRopSimExec = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
        public uint ReservedFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.ReservedFlags;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.ReservedFlags = value;
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Flags;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_PROCESS_MITIGATION_PAYLOAD_RESTRICTION_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11863:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableExportAddressFilter"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint EnableExportAddressFilter
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

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditExportAddressFilter"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint AuditExportAddressFilter
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

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableExportAddressFilterPlus"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint EnableExportAddressFilterPlus
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditExportAddressFilterPlus"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint AuditExportAddressFilterPlus
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 3) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableImportAddressFilter"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint EnableImportAddressFilter
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 4) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditImportAddressFilter"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint AuditImportAddressFilter
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 5) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableRopStackPivot"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint EnableRopStackPivot
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 6) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditRopStackPivot"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint AuditRopStackPivot
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 7) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableRopCallerCheck"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint EnableRopCallerCheck
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 8) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditRopCallerCheck"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint AuditRopCallerCheck
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 9) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EnableRopSimExec"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint EnableRopSimExec
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 10) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditRopSimExec"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint AuditRopSimExec
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 11) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
                [NativeTypeName("DWORD : 20")]
                public uint ReservedFlags
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 12) & 0xFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFFu << 12)) | ((value & 0xFFFFFu) << 12);
                    }
                }
            }
        }
    }
}

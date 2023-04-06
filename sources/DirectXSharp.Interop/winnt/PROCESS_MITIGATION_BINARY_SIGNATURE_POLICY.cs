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
    /// <include file='PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY"]/*' />
    public partial struct PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY
    {
        /// <include file='PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY.Anonymous"]/*' />
        [NativeTypeName("_PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11812:5)")]
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MicrosoftSignedOnly"]/*' />
        public uint MicrosoftSignedOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.MicrosoftSignedOnly;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.MicrosoftSignedOnly = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.StoreSignedOnly"]/*' />
        public uint StoreSignedOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.StoreSignedOnly;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.StoreSignedOnly = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MitigationOptIn"]/*' />
        public uint MitigationOptIn
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.MitigationOptIn;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.MitigationOptIn = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditMicrosoftSignedOnly"]/*' />
        public uint AuditMicrosoftSignedOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditMicrosoftSignedOnly;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditMicrosoftSignedOnly = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditStoreSignedOnly"]/*' />
        public uint AuditStoreSignedOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.AuditStoreSignedOnly;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.AuditStoreSignedOnly = value;
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
            [NativeTypeName("_PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11814:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MicrosoftSignedOnly"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint MicrosoftSignedOnly
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

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.StoreSignedOnly"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint StoreSignedOnly
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

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MitigationOptIn"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint MitigationOptIn
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

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditMicrosoftSignedOnly"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint AuditMicrosoftSignedOnly
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

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditStoreSignedOnly"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint AuditStoreSignedOnly
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

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
                [NativeTypeName("DWORD : 27")]
                public uint ReservedFlags
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 5) & 0x7FFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFu << 5)) | ((value & 0x7FFFFFFu) << 5);
                    }
                }
            }
        }
    }
}

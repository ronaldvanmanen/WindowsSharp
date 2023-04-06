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
    /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32"]/*' />
    public partial struct IMAGE_TLS_DIRECTORY32
    {
        /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.StartAddressOfRawData"]/*' />
        [NativeTypeName("DWORD")]
        public uint StartAddressOfRawData;

        /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.EndAddressOfRawData"]/*' />
        [NativeTypeName("DWORD")]
        public uint EndAddressOfRawData;

        /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.AddressOfIndex"]/*' />
        [NativeTypeName("DWORD")]
        public uint AddressOfIndex;

        /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.AddressOfCallBacks"]/*' />
        [NativeTypeName("DWORD")]
        public uint AddressOfCallBacks;

        /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.SizeOfZeroFill"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfZeroFill;

        /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.Anonymous"]/*' />
        [NativeTypeName("_IMAGE_TLS_DIRECTORY32::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18266:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Characteristics"]/*' />
        public ref uint Characteristics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Characteristics, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved0"]/*' />
        public uint Reserved0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.Reserved0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.Reserved0 = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Alignment"]/*' />
        public uint Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.Alignment;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.Alignment = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved1"]/*' />
        public uint Reserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.Reserved1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.Reserved1 = value;
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Characteristics"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Characteristics;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_IMAGE_TLS_DIRECTORY32::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18268:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved0"]/*' />
                [NativeTypeName("DWORD : 20")]
                public uint Reserved0
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0xFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFFu) | (value & 0xFFFFFu);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Alignment"]/*' />
                [NativeTypeName("DWORD : 4")]
                public uint Alignment
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 20) & 0xFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFu << 20)) | ((value & 0xFu) << 20);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved1"]/*' />
                [NativeTypeName("DWORD : 8")]
                public uint Reserved1
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 24) & 0xFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
                    }
                }
            }
        }
    }
}

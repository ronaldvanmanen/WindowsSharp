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

namespace DirectXSharp.Interop
{
    /// <include file='DCB.xml' path='doc/member[@name="DCB"]/*' />
    public partial struct DCB
    {
        /// <include file='DCB.xml' path='doc/member[@name="DCB.DCBlength"]/*' />
        [NativeTypeName("DWORD")]
        public uint DCBlength;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.BaudRate"]/*' />
        [NativeTypeName("DWORD")]
        public uint BaudRate;

        public uint _bitfield;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fBinary"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fBinary
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fParity"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fParity
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fOutxCtsFlow"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fOutxCtsFlow
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fOutxDsrFlow"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fOutxDsrFlow
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fDtrControl"]/*' />
        [NativeTypeName("DWORD : 2")]
        public uint fDtrControl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 4) & 0x3u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3u << 4)) | ((value & 0x3u) << 4);
            }
        }

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fDsrSensitivity"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fDsrSensitivity
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fTXContinueOnXoff"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fTXContinueOnXoff
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fOutX"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fOutX
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fInX"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fInX
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fErrorChar"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fErrorChar
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fNull"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fNull
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

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fRtsControl"]/*' />
        [NativeTypeName("DWORD : 2")]
        public uint fRtsControl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 12) & 0x3u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3u << 12)) | ((value & 0x3u) << 12);
            }
        }

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fAbortOnError"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fAbortOnError
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 14) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14);
            }
        }

        /// <include file='DCB.xml' path='doc/member[@name="DCB.fDummy2"]/*' />
        [NativeTypeName("DWORD : 17")]
        public uint fDummy2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 15) & 0x1FFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1FFFFu << 15)) | ((value & 0x1FFFFu) << 15);
            }
        }

        /// <include file='DCB.xml' path='doc/member[@name="DCB.wReserved"]/*' />
        [NativeTypeName("WORD")]
        public ushort wReserved;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.XonLim"]/*' />
        [NativeTypeName("WORD")]
        public ushort XonLim;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.XoffLim"]/*' />
        [NativeTypeName("WORD")]
        public ushort XoffLim;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.ByteSize"]/*' />
        public byte ByteSize;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.Parity"]/*' />
        public byte Parity;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.StopBits"]/*' />
        public byte StopBits;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.XonChar"]/*' />
        [NativeTypeName("char")]
        public sbyte XonChar;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.XoffChar"]/*' />
        [NativeTypeName("char")]
        public sbyte XoffChar;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.ErrorChar"]/*' />
        [NativeTypeName("char")]
        public sbyte ErrorChar;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.EofChar"]/*' />
        [NativeTypeName("char")]
        public sbyte EofChar;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.EvtChar"]/*' />
        [NativeTypeName("char")]
        public sbyte EvtChar;

        /// <include file='DCB.xml' path='doc/member[@name="DCB.wReserved1"]/*' />
        [NativeTypeName("WORD")]
        public ushort wReserved1;
    }
}

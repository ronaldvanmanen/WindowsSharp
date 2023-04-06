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
    /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT"]/*' />
    public partial struct COMSTAT
    {
        public uint _bitfield;

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fCtsHold"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fCtsHold
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

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fDsrHold"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fDsrHold
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

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fRlsdHold"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fRlsdHold
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

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fXoffHold"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fXoffHold
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

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fXoffSent"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fXoffSent
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

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fEof"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fEof
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

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fTxim"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint fTxim
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

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.fReserved"]/*' />
        [NativeTypeName("DWORD : 25")]
        public uint fReserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 7) & 0x1FFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1FFFFFFu << 7)) | ((value & 0x1FFFFFFu) << 7);
            }
        }

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.cbInQue"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbInQue;

        /// <include file='COMSTAT.xml' path='doc/member[@name="COMSTAT.cbOutQue"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbOutQue;
    }
}

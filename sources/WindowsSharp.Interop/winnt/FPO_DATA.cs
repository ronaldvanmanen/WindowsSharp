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

namespace WindowsSharp.Interop
{
    /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA"]/*' />
    public partial struct FPO_DATA
    {
        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.ulOffStart"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulOffStart;

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cbProcSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbProcSize;

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cdwLocals"]/*' />
        [NativeTypeName("DWORD")]
        public uint cdwLocals;

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cdwParams"]/*' />
        [NativeTypeName("WORD")]
        public ushort cdwParams;

        public ushort _bitfield;

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cbProlog"]/*' />
        [NativeTypeName("WORD : 8")]
        public ushort cbProlog
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)(_bitfield & 0xFFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~0xFFu) | (value & 0xFFu));
            }
        }

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cbRegs"]/*' />
        [NativeTypeName("WORD : 3")]
        public ushort cbRegs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)((_bitfield >> 8) & 0x7u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x7u << 8)) | ((value & 0x7u) << 8));
            }
        }

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.fHasSEH"]/*' />
        [NativeTypeName("WORD : 1")]
        public ushort fHasSEH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)((_bitfield >> 11) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11));
            }
        }

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.fUseBP"]/*' />
        [NativeTypeName("WORD : 1")]
        public ushort fUseBP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)((_bitfield >> 12) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12));
            }
        }

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.reserved"]/*' />
        [NativeTypeName("WORD : 1")]
        public ushort reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)((_bitfield >> 13) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13));
            }
        }

        /// <include file='FPO_DATA.xml' path='doc/member[@name="FPO_DATA.cbFrame"]/*' />
        [NativeTypeName("WORD : 2")]
        public ushort cbFrame
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)((_bitfield >> 14) & 0x3u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x3u << 14)) | ((value & 0x3u) << 14));
            }
        }
    }
}

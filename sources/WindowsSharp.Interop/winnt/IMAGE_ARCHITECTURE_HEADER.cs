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
    /// <include file='IMAGE_ARCHITECTURE_HEADER.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_HEADER"]/*' />
    public partial struct IMAGE_ARCHITECTURE_HEADER
    {
        public uint _bitfield;

        /// <include file='IMAGE_ARCHITECTURE_HEADER.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_HEADER.AmaskValue"]/*' />
        [NativeTypeName("unsigned int : 1")]
        public uint AmaskValue
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

        /// <include file='IMAGE_ARCHITECTURE_HEADER.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_HEADER.Anonymous1"]/*' />
        [NativeTypeName("int : 7")]
        public int Anonymous1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (int)((_bitfield >> 1) & 0x7Fu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7Fu << 1)) | (uint)((value & 0x7F) << 1);
            }
        }

        /// <include file='IMAGE_ARCHITECTURE_HEADER.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_HEADER.AmaskShift"]/*' />
        [NativeTypeName("unsigned int : 8")]
        public uint AmaskShift
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 8) & 0xFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFu << 8)) | ((value & 0xFFu) << 8);
            }
        }

        /// <include file='IMAGE_ARCHITECTURE_HEADER.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_HEADER.Anonymous2"]/*' />
        [NativeTypeName("int : 16")]
        public int Anonymous2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (int)((_bitfield >> 16) & 0xFFFFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFFu << 16)) | (uint)((value & 0xFFFF) << 16);
            }
        }

        /// <include file='IMAGE_ARCHITECTURE_HEADER.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_HEADER.FirstEntryRVA"]/*' />
        [NativeTypeName("DWORD")]
        public uint FirstEntryRVA;
    }
}

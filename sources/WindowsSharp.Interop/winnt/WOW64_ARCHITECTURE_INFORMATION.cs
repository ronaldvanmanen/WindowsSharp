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
    /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION"]/*' />
    public partial struct WOW64_ARCHITECTURE_INFORMATION
    {
        public uint _bitfield;

        /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.Machine"]/*' />
        [NativeTypeName("DWORD : 16")]
        public uint Machine
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0xFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
            }
        }

        /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.KernelMode"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint KernelMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 16) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
            }
        }

        /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.UserMode"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint UserMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 17) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17);
            }
        }

        /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.Native"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint Native
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 18) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18);
            }
        }

        /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.Process"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint Process
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 19) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
            }
        }

        /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.ReservedZero0"]/*' />
        [NativeTypeName("DWORD : 12")]
        public uint ReservedZero0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 20) & 0xFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFFu) << 20);
            }
        }
    }
}

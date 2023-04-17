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

namespace WindowsSharp.Interop
{
    /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE"]/*' />
    public partial struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE
    {
        public uint _bitfield;

        /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.Usage"]/*' />
        [NativeTypeName("uint : 1")]
        public uint Usage
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

        /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.RGB_Range"]/*' />
        [NativeTypeName("uint : 1")]
        public uint RGB_Range
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

        /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.YCbCr_Matrix"]/*' />
        [NativeTypeName("uint : 1")]
        public uint YCbCr_Matrix
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

        /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.YCbCr_xvYCC"]/*' />
        [NativeTypeName("uint : 1")]
        public uint YCbCr_xvYCC
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

        /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.Nominal_Range"]/*' />
        [NativeTypeName("uint : 2")]
        public uint Nominal_Range
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

        /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.Reserved"]/*' />
        [NativeTypeName("uint : 26")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 6) & 0x3FFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFu << 6)) | ((value & 0x3FFFFFFu) << 6);
            }
        }
    }
}

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
    /// <include file='D3D11_AUTHENTICATED_PROTECTION_FLAGS.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROTECTION_FLAGS"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct D3D11_AUTHENTICATED_PROTECTION_FLAGS
    {
        /// <include file='D3D11_AUTHENTICATED_PROTECTION_FLAGS.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROTECTION_FLAGS.Flags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct __MIDL___MIDL_itf_d3d11_0000_0034_0001")]
        public __MIDL___MIDL_itf_d3d11_0000_0034_0001 Flags;

        /// <include file='D3D11_AUTHENTICATED_PROTECTION_FLAGS.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROTECTION_FLAGS.Value"]/*' />
        [FieldOffset(0)]
        public uint Value;

        /// <include file='__MIDL___MIDL_itf_d3d11_0000_0034_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_d3d11_0000_0034_0001"]/*' />
        public partial struct __MIDL___MIDL_itf_d3d11_0000_0034_0001
        {
            public uint _bitfield;

            /// <include file='__MIDL___MIDL_itf_d3d11_0000_0034_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_d3d11_0000_0034_0001.ProtectionEnabled"]/*' />
            [NativeTypeName("uint : 1")]
            public uint ProtectionEnabled
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

            /// <include file='__MIDL___MIDL_itf_d3d11_0000_0034_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_d3d11_0000_0034_0001.OverlayOrFullscreenRequired"]/*' />
            [NativeTypeName("uint : 1")]
            public uint OverlayOrFullscreenRequired
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

            /// <include file='__MIDL___MIDL_itf_d3d11_0000_0034_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_d3d11_0000_0034_0001.Reserved"]/*' />
            [NativeTypeName("uint : 30")]
            public uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 2) & 0x3FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                }
            }
        }
    }
}

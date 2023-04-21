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

namespace WindowsSharp.Interop
{
    /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2"]/*' />
    public enum D3D11_FORMAT_SUPPORT2
    {
        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_ADD"]/*' />
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_ADD = 0x1,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS"]/*' />
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS = 0x2,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE"]/*' />
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE = 0x4,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE"]/*' />
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE = 0x8,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX"]/*' />
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX = 0x10,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX"]/*' />
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX = 0x20,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_UAV_TYPED_LOAD"]/*' />
        D3D11_FORMAT_SUPPORT2_UAV_TYPED_LOAD = 0x40,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_UAV_TYPED_STORE"]/*' />
        D3D11_FORMAT_SUPPORT2_UAV_TYPED_STORE = 0x80,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP"]/*' />
        D3D11_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP = 0x100,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_TILED"]/*' />
        D3D11_FORMAT_SUPPORT2_TILED = 0x200,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_SHAREABLE"]/*' />
        D3D11_FORMAT_SUPPORT2_SHAREABLE = 0x400,

        /// <include file='D3D11_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FORMAT_SUPPORT2.D3D11_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY"]/*' />
        D3D11_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY = 0x4000,
    }
}

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
    /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS"]/*' />
    public enum D3DCOMPILER_STRIP_FLAGS
    {
        /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_REFLECTION_DATA"]/*' />
        D3DCOMPILER_STRIP_REFLECTION_DATA = 0x00000001,

        /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_DEBUG_INFO"]/*' />
        D3DCOMPILER_STRIP_DEBUG_INFO = 0x00000002,

        /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_TEST_BLOBS"]/*' />
        D3DCOMPILER_STRIP_TEST_BLOBS = 0x00000004,

        /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_PRIVATE_DATA"]/*' />
        D3DCOMPILER_STRIP_PRIVATE_DATA = 0x00000008,

        /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_ROOT_SIGNATURE"]/*' />
        D3DCOMPILER_STRIP_ROOT_SIGNATURE = 0x00000010,

        /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_FORCE_DWORD"]/*' />
        D3DCOMPILER_STRIP_FORCE_DWORD = 0x7fffffff,
    }
}

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
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART"]/*' />
    public enum D3D_BLOB_PART
    {
        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_INPUT_SIGNATURE_BLOB"]/*' />
        D3D_BLOB_INPUT_SIGNATURE_BLOB,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_OUTPUT_SIGNATURE_BLOB"]/*' />
        D3D_BLOB_OUTPUT_SIGNATURE_BLOB,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB"]/*' />
        D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB"]/*' />
        D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_ALL_SIGNATURE_BLOB"]/*' />
        D3D_BLOB_ALL_SIGNATURE_BLOB,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_DEBUG_INFO"]/*' />
        D3D_BLOB_DEBUG_INFO,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_LEGACY_SHADER"]/*' />
        D3D_BLOB_LEGACY_SHADER,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_XNA_PREPASS_SHADER"]/*' />
        D3D_BLOB_XNA_PREPASS_SHADER,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_XNA_SHADER"]/*' />
        D3D_BLOB_XNA_SHADER,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_PDB"]/*' />
        D3D_BLOB_PDB,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_PRIVATE_DATA"]/*' />
        D3D_BLOB_PRIVATE_DATA,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_ROOT_SIGNATURE"]/*' />
        D3D_BLOB_ROOT_SIGNATURE,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_DEBUG_NAME"]/*' />
        D3D_BLOB_DEBUG_NAME,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_TEST_ALTERNATE_SHADER"]/*' />
        D3D_BLOB_TEST_ALTERNATE_SHADER = 0x8000,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_TEST_COMPILE_DETAILS"]/*' />
        D3D_BLOB_TEST_COMPILE_DETAILS,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_TEST_COMPILE_PERF"]/*' />
        D3D_BLOB_TEST_COMPILE_PERF,

        /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_TEST_COMPILE_REPORT"]/*' />
        D3D_BLOB_TEST_COMPILE_REPORT,
    }
}

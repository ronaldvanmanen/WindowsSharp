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
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA"]/*' />
    public unsafe partial struct GCP_RESULTSA
    {
        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lStructSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint lStructSize;

        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpOutString"]/*' />
        [NativeTypeName("LPSTR")]
        public sbyte* lpOutString;

        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpOrder"]/*' />
        public uint* lpOrder;

        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpDx"]/*' />
        public int* lpDx;

        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpCaretPos"]/*' />
        public int* lpCaretPos;

        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpClass"]/*' />
        [NativeTypeName("LPSTR")]
        public sbyte* lpClass;

        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpGlyphs"]/*' />
        [NativeTypeName("LPWSTR")]
        public ushort* lpGlyphs;

        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.nGlyphs"]/*' />
        public uint nGlyphs;

        /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.nMaxFit"]/*' />
        public int nMaxFit;
    }
}

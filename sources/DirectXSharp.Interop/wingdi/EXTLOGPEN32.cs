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

namespace DirectXSharp.Interop
{
    /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32"]/*' />
    public unsafe partial struct EXTLOGPEN32
    {
        /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpPenStyle"]/*' />
        [NativeTypeName("DWORD")]
        public uint elpPenStyle;

        /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpWidth"]/*' />
        [NativeTypeName("DWORD")]
        public uint elpWidth;

        /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpBrushStyle"]/*' />
        public uint elpBrushStyle;

        /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpColor"]/*' />
        [NativeTypeName("COLORREF")]
        public uint elpColor;

        /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpHatch"]/*' />
        [NativeTypeName("ULONG")]
        public uint elpHatch;

        /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpNumEntries"]/*' />
        [NativeTypeName("DWORD")]
        public uint elpNumEntries;

        /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpStyleEntry"]/*' />
        [NativeTypeName("DWORD [1]")]
        public fixed uint elpStyleEntry[1];
    }
}

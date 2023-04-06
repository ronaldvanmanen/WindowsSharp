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
    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN"]/*' />
    public unsafe partial struct EXTLOGPEN
    {
        /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpPenStyle"]/*' />
        [NativeTypeName("DWORD")]
        public uint elpPenStyle;

        /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpWidth"]/*' />
        [NativeTypeName("DWORD")]
        public uint elpWidth;

        /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpBrushStyle"]/*' />
        public uint elpBrushStyle;

        /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpColor"]/*' />
        [NativeTypeName("COLORREF")]
        public uint elpColor;

        /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpHatch"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong elpHatch;

        /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpNumEntries"]/*' />
        [NativeTypeName("DWORD")]
        public uint elpNumEntries;

        /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpStyleEntry"]/*' />
        [NativeTypeName("DWORD [1]")]
        public fixed uint elpStyleEntry[1];
    }
}
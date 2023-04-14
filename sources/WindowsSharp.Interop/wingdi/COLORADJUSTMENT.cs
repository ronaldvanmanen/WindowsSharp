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
    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT"]/*' />
    public partial struct COLORADJUSTMENT
    {
        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caSize"]/*' />
        [NativeTypeName("WORD")]
        public ushort caSize;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caFlags"]/*' />
        [NativeTypeName("WORD")]
        public ushort caFlags;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caIlluminantIndex"]/*' />
        [NativeTypeName("WORD")]
        public ushort caIlluminantIndex;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caRedGamma"]/*' />
        [NativeTypeName("WORD")]
        public ushort caRedGamma;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caGreenGamma"]/*' />
        [NativeTypeName("WORD")]
        public ushort caGreenGamma;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caBlueGamma"]/*' />
        [NativeTypeName("WORD")]
        public ushort caBlueGamma;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caReferenceBlack"]/*' />
        [NativeTypeName("WORD")]
        public ushort caReferenceBlack;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caReferenceWhite"]/*' />
        [NativeTypeName("WORD")]
        public ushort caReferenceWhite;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caContrast"]/*' />
        public short caContrast;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caBrightness"]/*' />
        public short caBrightness;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caColorfulness"]/*' />
        public short caColorfulness;

        /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caRedGreenTint"]/*' />
        public short caRedGreenTint;
    }
}

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
    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA"]/*' />
    public partial struct TEXTMETRICA
    {
        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmHeight"]/*' />
        [NativeTypeName("LONG")]
        public int tmHeight;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmAscent"]/*' />
        [NativeTypeName("LONG")]
        public int tmAscent;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmDescent"]/*' />
        [NativeTypeName("LONG")]
        public int tmDescent;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmInternalLeading"]/*' />
        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmExternalLeading"]/*' />
        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmAveCharWidth"]/*' />
        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmMaxCharWidth"]/*' />
        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmWeight"]/*' />
        [NativeTypeName("LONG")]
        public int tmWeight;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmOverhang"]/*' />
        [NativeTypeName("LONG")]
        public int tmOverhang;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmDigitizedAspectX"]/*' />
        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmDigitizedAspectY"]/*' />
        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmFirstChar"]/*' />
        public byte tmFirstChar;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmLastChar"]/*' />
        public byte tmLastChar;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmDefaultChar"]/*' />
        public byte tmDefaultChar;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmBreakChar"]/*' />
        public byte tmBreakChar;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmItalic"]/*' />
        public byte tmItalic;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmUnderlined"]/*' />
        public byte tmUnderlined;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmStruckOut"]/*' />
        public byte tmStruckOut;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmPitchAndFamily"]/*' />
        public byte tmPitchAndFamily;

        /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmCharSet"]/*' />
        public byte tmCharSet;
    }
}

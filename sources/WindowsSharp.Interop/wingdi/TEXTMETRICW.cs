// WindowsSharp
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

namespace WindowsSharp.Interop
{
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW"]/*' />
    public partial struct TEXTMETRICW
    {
        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmHeight"]/*' />
        [NativeTypeName("LONG")]
        public int tmHeight;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmAscent"]/*' />
        [NativeTypeName("LONG")]
        public int tmAscent;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmDescent"]/*' />
        [NativeTypeName("LONG")]
        public int tmDescent;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmInternalLeading"]/*' />
        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmExternalLeading"]/*' />
        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmAveCharWidth"]/*' />
        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmMaxCharWidth"]/*' />
        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmWeight"]/*' />
        [NativeTypeName("LONG")]
        public int tmWeight;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmOverhang"]/*' />
        [NativeTypeName("LONG")]
        public int tmOverhang;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmDigitizedAspectX"]/*' />
        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmDigitizedAspectY"]/*' />
        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmFirstChar"]/*' />
        [NativeTypeName("WCHAR")]
        public ushort tmFirstChar;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmLastChar"]/*' />
        [NativeTypeName("WCHAR")]
        public ushort tmLastChar;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmDefaultChar"]/*' />
        [NativeTypeName("WCHAR")]
        public ushort tmDefaultChar;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmBreakChar"]/*' />
        [NativeTypeName("WCHAR")]
        public ushort tmBreakChar;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmItalic"]/*' />
        public byte tmItalic;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmUnderlined"]/*' />
        public byte tmUnderlined;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmStruckOut"]/*' />
        public byte tmStruckOut;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmPitchAndFamily"]/*' />
        public byte tmPitchAndFamily;

        /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmCharSet"]/*' />
        public byte tmCharSet;
    }
}

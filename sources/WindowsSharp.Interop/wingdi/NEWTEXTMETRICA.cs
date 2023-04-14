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
    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA"]/*' />
    public partial struct NEWTEXTMETRICA
    {
        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmHeight"]/*' />
        [NativeTypeName("LONG")]
        public int tmHeight;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmAscent"]/*' />
        [NativeTypeName("LONG")]
        public int tmAscent;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmDescent"]/*' />
        [NativeTypeName("LONG")]
        public int tmDescent;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmInternalLeading"]/*' />
        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmExternalLeading"]/*' />
        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmAveCharWidth"]/*' />
        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmMaxCharWidth"]/*' />
        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmWeight"]/*' />
        [NativeTypeName("LONG")]
        public int tmWeight;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmOverhang"]/*' />
        [NativeTypeName("LONG")]
        public int tmOverhang;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmDigitizedAspectX"]/*' />
        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmDigitizedAspectY"]/*' />
        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmFirstChar"]/*' />
        public byte tmFirstChar;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmLastChar"]/*' />
        public byte tmLastChar;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmDefaultChar"]/*' />
        public byte tmDefaultChar;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmBreakChar"]/*' />
        public byte tmBreakChar;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmItalic"]/*' />
        public byte tmItalic;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmUnderlined"]/*' />
        public byte tmUnderlined;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmStruckOut"]/*' />
        public byte tmStruckOut;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmPitchAndFamily"]/*' />
        public byte tmPitchAndFamily;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmCharSet"]/*' />
        public byte tmCharSet;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.ntmFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ntmFlags;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.ntmSizeEM"]/*' />
        public uint ntmSizeEM;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.ntmCellHeight"]/*' />
        public uint ntmCellHeight;

        /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.ntmAvgWidth"]/*' />
        public uint ntmAvgWidth;
    }
}

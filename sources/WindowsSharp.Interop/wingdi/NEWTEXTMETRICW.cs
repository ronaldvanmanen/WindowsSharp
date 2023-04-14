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
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW"]/*' />
    public partial struct NEWTEXTMETRICW
    {
        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmHeight"]/*' />
        [NativeTypeName("LONG")]
        public int tmHeight;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmAscent"]/*' />
        [NativeTypeName("LONG")]
        public int tmAscent;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmDescent"]/*' />
        [NativeTypeName("LONG")]
        public int tmDescent;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmInternalLeading"]/*' />
        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmExternalLeading"]/*' />
        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmAveCharWidth"]/*' />
        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmMaxCharWidth"]/*' />
        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmWeight"]/*' />
        [NativeTypeName("LONG")]
        public int tmWeight;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmOverhang"]/*' />
        [NativeTypeName("LONG")]
        public int tmOverhang;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmDigitizedAspectX"]/*' />
        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmDigitizedAspectY"]/*' />
        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmFirstChar"]/*' />
        [NativeTypeName("WCHAR")]
        public ushort tmFirstChar;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmLastChar"]/*' />
        [NativeTypeName("WCHAR")]
        public ushort tmLastChar;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmDefaultChar"]/*' />
        [NativeTypeName("WCHAR")]
        public ushort tmDefaultChar;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmBreakChar"]/*' />
        [NativeTypeName("WCHAR")]
        public ushort tmBreakChar;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmItalic"]/*' />
        public byte tmItalic;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmUnderlined"]/*' />
        public byte tmUnderlined;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmStruckOut"]/*' />
        public byte tmStruckOut;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmPitchAndFamily"]/*' />
        public byte tmPitchAndFamily;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmCharSet"]/*' />
        public byte tmCharSet;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.ntmFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ntmFlags;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.ntmSizeEM"]/*' />
        public uint ntmSizeEM;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.ntmCellHeight"]/*' />
        public uint ntmCellHeight;

        /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.ntmAvgWidth"]/*' />
        public uint ntmAvgWidth;
    }
}

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
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA"]/*' />
    public unsafe partial struct OUTLINETEXTMETRICA
    {
        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmSize"]/*' />
        public uint otmSize;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmTextMetrics"]/*' />
        public TEXTMETRICA otmTextMetrics;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmFiller"]/*' />
        public byte otmFiller;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmPanoseNumber"]/*' />
        public PANOSE otmPanoseNumber;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmfsSelection"]/*' />
        public uint otmfsSelection;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmfsType"]/*' />
        public uint otmfsType;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsCharSlopeRise"]/*' />
        public int otmsCharSlopeRise;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsCharSlopeRun"]/*' />
        public int otmsCharSlopeRun;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmItalicAngle"]/*' />
        public int otmItalicAngle;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmEMSquare"]/*' />
        public uint otmEMSquare;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmAscent"]/*' />
        public int otmAscent;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmDescent"]/*' />
        public int otmDescent;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmLineGap"]/*' />
        public uint otmLineGap;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsCapEmHeight"]/*' />
        public uint otmsCapEmHeight;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsXHeight"]/*' />
        public uint otmsXHeight;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmrcFontBox"]/*' />
        public RECT otmrcFontBox;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmMacAscent"]/*' />
        public int otmMacAscent;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmMacDescent"]/*' />
        public int otmMacDescent;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmMacLineGap"]/*' />
        public uint otmMacLineGap;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmusMinimumPPEM"]/*' />
        public uint otmusMinimumPPEM;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmptSubscriptSize"]/*' />
        public POINT otmptSubscriptSize;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmptSubscriptOffset"]/*' />
        public POINT otmptSubscriptOffset;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmptSuperscriptSize"]/*' />
        public POINT otmptSuperscriptSize;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmptSuperscriptOffset"]/*' />
        public POINT otmptSuperscriptOffset;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsStrikeoutSize"]/*' />
        public uint otmsStrikeoutSize;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsStrikeoutPosition"]/*' />
        public int otmsStrikeoutPosition;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsUnderscoreSize"]/*' />
        public int otmsUnderscoreSize;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsUnderscorePosition"]/*' />
        public int otmsUnderscorePosition;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmpFamilyName"]/*' />
        [NativeTypeName("PSTR")]
        public sbyte* otmpFamilyName;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmpFaceName"]/*' />
        [NativeTypeName("PSTR")]
        public sbyte* otmpFaceName;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmpStyleName"]/*' />
        [NativeTypeName("PSTR")]
        public sbyte* otmpStyleName;

        /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmpFullName"]/*' />
        [NativeTypeName("PSTR")]
        public sbyte* otmpFullName;
    }
}

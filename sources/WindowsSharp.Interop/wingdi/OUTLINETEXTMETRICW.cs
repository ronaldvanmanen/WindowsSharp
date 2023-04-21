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
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW"]/*' />
    public unsafe partial struct OUTLINETEXTMETRICW
    {
        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmSize"]/*' />
        public uint otmSize;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmTextMetrics"]/*' />
        public TEXTMETRICW otmTextMetrics;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmFiller"]/*' />
        public byte otmFiller;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmPanoseNumber"]/*' />
        public PANOSE otmPanoseNumber;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmfsSelection"]/*' />
        public uint otmfsSelection;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmfsType"]/*' />
        public uint otmfsType;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsCharSlopeRise"]/*' />
        public int otmsCharSlopeRise;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsCharSlopeRun"]/*' />
        public int otmsCharSlopeRun;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmItalicAngle"]/*' />
        public int otmItalicAngle;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmEMSquare"]/*' />
        public uint otmEMSquare;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmAscent"]/*' />
        public int otmAscent;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmDescent"]/*' />
        public int otmDescent;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmLineGap"]/*' />
        public uint otmLineGap;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsCapEmHeight"]/*' />
        public uint otmsCapEmHeight;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsXHeight"]/*' />
        public uint otmsXHeight;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmrcFontBox"]/*' />
        public RECT otmrcFontBox;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmMacAscent"]/*' />
        public int otmMacAscent;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmMacDescent"]/*' />
        public int otmMacDescent;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmMacLineGap"]/*' />
        public uint otmMacLineGap;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmusMinimumPPEM"]/*' />
        public uint otmusMinimumPPEM;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmptSubscriptSize"]/*' />
        public POINT otmptSubscriptSize;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmptSubscriptOffset"]/*' />
        public POINT otmptSubscriptOffset;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmptSuperscriptSize"]/*' />
        public POINT otmptSuperscriptSize;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmptSuperscriptOffset"]/*' />
        public POINT otmptSuperscriptOffset;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsStrikeoutSize"]/*' />
        public uint otmsStrikeoutSize;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsStrikeoutPosition"]/*' />
        public int otmsStrikeoutPosition;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsUnderscoreSize"]/*' />
        public int otmsUnderscoreSize;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsUnderscorePosition"]/*' />
        public int otmsUnderscorePosition;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmpFamilyName"]/*' />
        [NativeTypeName("PSTR")]
        public sbyte* otmpFamilyName;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmpFaceName"]/*' />
        [NativeTypeName("PSTR")]
        public sbyte* otmpFaceName;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmpStyleName"]/*' />
        [NativeTypeName("PSTR")]
        public sbyte* otmpStyleName;

        /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmpFullName"]/*' />
        [NativeTypeName("PSTR")]
        public sbyte* otmpFullName;
    }
}

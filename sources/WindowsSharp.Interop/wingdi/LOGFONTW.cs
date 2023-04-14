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
    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW"]/*' />
    public unsafe partial struct LOGFONTW
    {
        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfHeight"]/*' />
        [NativeTypeName("LONG")]
        public int lfHeight;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfWidth"]/*' />
        [NativeTypeName("LONG")]
        public int lfWidth;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfEscapement"]/*' />
        [NativeTypeName("LONG")]
        public int lfEscapement;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfOrientation"]/*' />
        [NativeTypeName("LONG")]
        public int lfOrientation;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfWeight"]/*' />
        [NativeTypeName("LONG")]
        public int lfWeight;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfItalic"]/*' />
        public byte lfItalic;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfUnderline"]/*' />
        public byte lfUnderline;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfStrikeOut"]/*' />
        public byte lfStrikeOut;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfCharSet"]/*' />
        public byte lfCharSet;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfOutPrecision"]/*' />
        public byte lfOutPrecision;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfClipPrecision"]/*' />
        public byte lfClipPrecision;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfQuality"]/*' />
        public byte lfQuality;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfPitchAndFamily"]/*' />
        public byte lfPitchAndFamily;

        /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfFaceName"]/*' />
        [NativeTypeName("WCHAR [32]")]
        public fixed ushort lfFaceName[32];
    }
}

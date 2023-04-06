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
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA"]/*' />
    public unsafe partial struct LOGFONTA
    {
        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfHeight"]/*' />
        [NativeTypeName("LONG")]
        public int lfHeight;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfWidth"]/*' />
        [NativeTypeName("LONG")]
        public int lfWidth;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfEscapement"]/*' />
        [NativeTypeName("LONG")]
        public int lfEscapement;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfOrientation"]/*' />
        [NativeTypeName("LONG")]
        public int lfOrientation;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfWeight"]/*' />
        [NativeTypeName("LONG")]
        public int lfWeight;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfItalic"]/*' />
        public byte lfItalic;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfUnderline"]/*' />
        public byte lfUnderline;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfStrikeOut"]/*' />
        public byte lfStrikeOut;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfCharSet"]/*' />
        public byte lfCharSet;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfOutPrecision"]/*' />
        public byte lfOutPrecision;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfClipPrecision"]/*' />
        public byte lfClipPrecision;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfQuality"]/*' />
        public byte lfQuality;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfPitchAndFamily"]/*' />
        public byte lfPitchAndFamily;

        /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfFaceName"]/*' />
        [NativeTypeName("CHAR [32]")]
        public fixed sbyte lfFaceName[32];
    }
}

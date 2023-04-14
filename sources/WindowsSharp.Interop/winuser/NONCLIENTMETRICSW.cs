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
    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW"]/*' />
    public partial struct NONCLIENTMETRICSW
    {
        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.cbSize"]/*' />
        public uint cbSize;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iBorderWidth"]/*' />
        public int iBorderWidth;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iScrollWidth"]/*' />
        public int iScrollWidth;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iScrollHeight"]/*' />
        public int iScrollHeight;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iCaptionWidth"]/*' />
        public int iCaptionWidth;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iCaptionHeight"]/*' />
        public int iCaptionHeight;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfCaptionFont"]/*' />
        public LOGFONTW lfCaptionFont;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iSmCaptionWidth"]/*' />
        public int iSmCaptionWidth;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iSmCaptionHeight"]/*' />
        public int iSmCaptionHeight;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfSmCaptionFont"]/*' />
        public LOGFONTW lfSmCaptionFont;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iMenuWidth"]/*' />
        public int iMenuWidth;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iMenuHeight"]/*' />
        public int iMenuHeight;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfMenuFont"]/*' />
        public LOGFONTW lfMenuFont;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfStatusFont"]/*' />
        public LOGFONTW lfStatusFont;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfMessageFont"]/*' />
        public LOGFONTW lfMessageFont;

        /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iPaddedBorderWidth"]/*' />
        public int iPaddedBorderWidth;
    }
}

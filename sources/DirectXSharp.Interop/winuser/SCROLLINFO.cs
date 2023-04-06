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
    /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO"]/*' />
    public partial struct SCROLLINFO
    {
        /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.cbSize"]/*' />
        public uint cbSize;

        /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.fMask"]/*' />
        public uint fMask;

        /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nMin"]/*' />
        public int nMin;

        /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nMax"]/*' />
        public int nMax;

        /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nPage"]/*' />
        public uint nPage;

        /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nPos"]/*' />
        public int nPos;

        /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nTrackPos"]/*' />
        public int nTrackPos;
    }
}

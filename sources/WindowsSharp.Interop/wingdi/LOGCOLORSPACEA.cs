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
    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA"]/*' />
    public unsafe partial struct LOGCOLORSPACEA
    {
        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsSignature"]/*' />
        [NativeTypeName("DWORD")]
        public uint lcsSignature;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint lcsVersion;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint lcsSize;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsCSType"]/*' />
        [NativeTypeName("LCSCSTYPE")]
        public int lcsCSType;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsIntent"]/*' />
        [NativeTypeName("LCSGAMUTMATCH")]
        public int lcsIntent;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsEndpoints"]/*' />
        public CIEXYZTRIPLE lcsEndpoints;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsGammaRed"]/*' />
        [NativeTypeName("DWORD")]
        public uint lcsGammaRed;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsGammaGreen"]/*' />
        [NativeTypeName("DWORD")]
        public uint lcsGammaGreen;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsGammaBlue"]/*' />
        [NativeTypeName("DWORD")]
        public uint lcsGammaBlue;

        /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsFilename"]/*' />
        [NativeTypeName("CHAR [260]")]
        public fixed sbyte lcsFilename[260];
    }
}

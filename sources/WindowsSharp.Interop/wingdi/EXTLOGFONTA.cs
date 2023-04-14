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
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA"]/*' />
    public unsafe partial struct EXTLOGFONTA
    {
        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfLogFont"]/*' />
        public LOGFONTA elfLogFont;

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfFullName"]/*' />
        [NativeTypeName("BYTE [64]")]
        public fixed byte elfFullName[64];

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfStyle"]/*' />
        [NativeTypeName("BYTE [32]")]
        public fixed byte elfStyle[32];

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint elfVersion;

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfStyleSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint elfStyleSize;

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfMatch"]/*' />
        [NativeTypeName("DWORD")]
        public uint elfMatch;

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfReserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint elfReserved;

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfVendorId"]/*' />
        [NativeTypeName("BYTE [4]")]
        public fixed byte elfVendorId[4];

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfCulture"]/*' />
        [NativeTypeName("DWORD")]
        public uint elfCulture;

        /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfPanose"]/*' />
        public PANOSE elfPanose;
    }
}

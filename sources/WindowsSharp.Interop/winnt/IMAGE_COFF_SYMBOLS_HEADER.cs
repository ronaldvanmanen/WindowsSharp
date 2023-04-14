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
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER"]/*' />
    public partial struct IMAGE_COFF_SYMBOLS_HEADER
    {
        /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.NumberOfSymbols"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfSymbols;

        /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.LvaToFirstSymbol"]/*' />
        [NativeTypeName("DWORD")]
        public uint LvaToFirstSymbol;

        /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.NumberOfLinenumbers"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfLinenumbers;

        /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.LvaToFirstLinenumber"]/*' />
        [NativeTypeName("DWORD")]
        public uint LvaToFirstLinenumber;

        /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.RvaToFirstByteOfCode"]/*' />
        [NativeTypeName("DWORD")]
        public uint RvaToFirstByteOfCode;

        /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.RvaToLastByteOfCode"]/*' />
        [NativeTypeName("DWORD")]
        public uint RvaToLastByteOfCode;

        /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.RvaToFirstByteOfData"]/*' />
        [NativeTypeName("DWORD")]
        public uint RvaToFirstByteOfData;

        /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.RvaToLastByteOfData"]/*' />
        [NativeTypeName("DWORD")]
        public uint RvaToLastByteOfData;
    }
}

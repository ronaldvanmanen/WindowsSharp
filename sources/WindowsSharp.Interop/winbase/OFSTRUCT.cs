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
    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT"]/*' />
    public unsafe partial struct OFSTRUCT
    {
        /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.cBytes"]/*' />
        public byte cBytes;

        /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.fFixedDisk"]/*' />
        public byte fFixedDisk;

        /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.nErrCode"]/*' />
        [NativeTypeName("WORD")]
        public ushort nErrCode;

        /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.Reserved1"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved1;

        /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.Reserved2"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved2;

        /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.szPathName"]/*' />
        [NativeTypeName("CHAR [128]")]
        public fixed sbyte szPathName[128];
    }
}

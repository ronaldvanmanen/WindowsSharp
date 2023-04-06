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
    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG"]/*' />
    public unsafe partial struct COMMCONFIG
    {
        /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dwSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwSize;

        /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.wVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort wVersion;

        /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.wReserved"]/*' />
        [NativeTypeName("WORD")]
        public ushort wReserved;

        /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dcb"]/*' />
        public DCB dcb;

        /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dwProviderSubType"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProviderSubType;

        /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dwProviderOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProviderOffset;

        /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dwProviderSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProviderSize;

        /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.wcProviderData"]/*' />
        [NativeTypeName("WCHAR [1]")]
        public fixed ushort wcProviderData[1];
    }
}

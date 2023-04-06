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
    /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS"]/*' />
    public partial struct MOUSEKEYS
    {
        /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.cbSize"]/*' />
        public uint cbSize;

        /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.iMaxSpeed"]/*' />
        [NativeTypeName("DWORD")]
        public uint iMaxSpeed;

        /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.iTimeToMaxSpeed"]/*' />
        [NativeTypeName("DWORD")]
        public uint iTimeToMaxSpeed;

        /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.iCtrlSpeed"]/*' />
        [NativeTypeName("DWORD")]
        public uint iCtrlSpeed;

        /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.dwReserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.dwReserved2"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwReserved2;
    }
}

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

using System;

namespace WindowsSharp.Interop
{
    /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9"]/*' />
    public unsafe partial struct D3DADAPTER_IDENTIFIER9
    {
        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.Driver"]/*' />
        [NativeTypeName("char [512]")]
        public fixed sbyte Driver[512];

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.Description"]/*' />
        [NativeTypeName("char [512]")]
        public fixed sbyte Description[512];

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.DeviceName"]/*' />
        [NativeTypeName("char [32]")]
        public fixed sbyte DeviceName[32];

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.DriverVersion"]/*' />
        public LARGE_INTEGER DriverVersion;

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.VendorId"]/*' />
        [NativeTypeName("DWORD")]
        public uint VendorId;

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.DeviceId"]/*' />
        [NativeTypeName("DWORD")]
        public uint DeviceId;

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.SubSysId"]/*' />
        [NativeTypeName("DWORD")]
        public uint SubSysId;

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.Revision"]/*' />
        [NativeTypeName("DWORD")]
        public uint Revision;

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.DeviceIdentifier"]/*' />
        public Guid DeviceIdentifier;

        /// <include file='D3DADAPTER_IDENTIFIER9.xml' path='doc/member[@name="D3DADAPTER_IDENTIFIER9.WHQLLevel"]/*' />
        [NativeTypeName("DWORD")]
        public uint WHQLLevel;
    }
}

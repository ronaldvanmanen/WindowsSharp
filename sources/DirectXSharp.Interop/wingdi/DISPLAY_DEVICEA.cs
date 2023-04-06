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
    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA"]/*' />
    public unsafe partial struct DISPLAY_DEVICEA
    {
        /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.cb"]/*' />
        [NativeTypeName("DWORD")]
        public uint cb;

        /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceName"]/*' />
        [NativeTypeName("CHAR [32]")]
        public fixed sbyte DeviceName[32];

        /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceString"]/*' />
        [NativeTypeName("CHAR [128]")]
        public fixed sbyte DeviceString[128];

        /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.StateFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint StateFlags;

        /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceID"]/*' />
        [NativeTypeName("CHAR [128]")]
        public fixed sbyte DeviceID[128];

        /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceKey"]/*' />
        [NativeTypeName("CHAR [128]")]
        public fixed sbyte DeviceKey[128];
    }
}

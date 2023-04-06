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
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME"]/*' />
    public unsafe partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME
    {
        /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.header"]/*' />
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.flags"]/*' />
        public DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS flags;

        /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.outputTechnology"]/*' />
        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;

        /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.edidManufactureId"]/*' />
        [NativeTypeName("UINT16")]
        public ushort edidManufactureId;

        /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.edidProductCodeId"]/*' />
        [NativeTypeName("UINT16")]
        public ushort edidProductCodeId;

        /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.connectorInstance"]/*' />
        [NativeTypeName("UINT32")]
        public uint connectorInstance;

        /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.monitorFriendlyDeviceName"]/*' />
        [NativeTypeName("WCHAR [64]")]
        public fixed ushort monitorFriendlyDeviceName[64];

        /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.monitorDevicePath"]/*' />
        [NativeTypeName("WCHAR [128]")]
        public fixed ushort monitorDevicePath[128];
    }
}

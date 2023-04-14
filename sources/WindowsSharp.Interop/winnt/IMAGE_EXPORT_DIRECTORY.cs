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
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY"]/*' />
    public partial struct IMAGE_EXPORT_DIRECTORY
    {
        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.Characteristics"]/*' />
        [NativeTypeName("DWORD")]
        public uint Characteristics;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.TimeDateStamp"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.MajorVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MajorVersion;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.MinorVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MinorVersion;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.Name"]/*' />
        [NativeTypeName("DWORD")]
        public uint Name;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.Base"]/*' />
        [NativeTypeName("DWORD")]
        public uint Base;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.NumberOfFunctions"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfFunctions;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.NumberOfNames"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfNames;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.AddressOfFunctions"]/*' />
        [NativeTypeName("DWORD")]
        public uint AddressOfFunctions;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.AddressOfNames"]/*' />
        [NativeTypeName("DWORD")]
        public uint AddressOfNames;

        /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.AddressOfNameOrdinals"]/*' />
        [NativeTypeName("DWORD")]
        public uint AddressOfNameOrdinals;
    }
}

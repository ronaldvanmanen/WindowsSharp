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
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER"]/*' />
    public unsafe partial struct IMAGE_SEPARATE_DEBUG_HEADER
    {
        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Signature"]/*' />
        [NativeTypeName("WORD")]
        public ushort Signature;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Flags"]/*' />
        [NativeTypeName("WORD")]
        public ushort Flags;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Machine"]/*' />
        [NativeTypeName("WORD")]
        public ushort Machine;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Characteristics"]/*' />
        [NativeTypeName("WORD")]
        public ushort Characteristics;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.TimeDateStamp"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.CheckSum"]/*' />
        [NativeTypeName("DWORD")]
        public uint CheckSum;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.ImageBase"]/*' />
        [NativeTypeName("DWORD")]
        public uint ImageBase;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.SizeOfImage"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfImage;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.NumberOfSections"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfSections;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.ExportedNamesSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint ExportedNamesSize;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.DebugDirectorySize"]/*' />
        [NativeTypeName("DWORD")]
        public uint DebugDirectorySize;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.SectionAlignment"]/*' />
        [NativeTypeName("DWORD")]
        public uint SectionAlignment;

        /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Reserved"]/*' />
        [NativeTypeName("DWORD [2]")]
        public fixed uint Reserved[2];
    }
}

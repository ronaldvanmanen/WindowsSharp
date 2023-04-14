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

using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe partial struct IMAGE_DOS_HEADER
    {
        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_magic"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_magic;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_cblp"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_cblp;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_cp"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_cp;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_crlc"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_crlc;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_cparhdr"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_cparhdr;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_minalloc"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_minalloc;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_maxalloc"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_maxalloc;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_ss"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_ss;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_sp"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_sp;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_csum"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_csum;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_ip"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_ip;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_cs"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_cs;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_lfarlc"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_lfarlc;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_ovno"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_ovno;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_res"]/*' />
        [NativeTypeName("WORD [4]")]
        public fixed ushort e_res[4];

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_oemid"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_oemid;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_oeminfo"]/*' />
        [NativeTypeName("WORD")]
        public ushort e_oeminfo;

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_res2"]/*' />
        [NativeTypeName("WORD [10]")]
        public fixed ushort e_res2[10];

        /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_lfanew"]/*' />
        [NativeTypeName("LONG")]
        public int e_lfanew;
    }
}

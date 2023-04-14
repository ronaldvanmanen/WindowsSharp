// This file is part of WindowsSharp
//
// Copyright (C) 2021-2023 Ronald van Manen <rvanmanen@gmail.com>
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
    /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct IMAGE_OS2_HEADER
    {
        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_magic"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_magic;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_ver"]/*' />
        [NativeTypeName("CHAR")]
        public sbyte ne_ver;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_rev"]/*' />
        [NativeTypeName("CHAR")]
        public sbyte ne_rev;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_enttab"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_enttab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_cbenttab"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_cbenttab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_crc"]/*' />
        [NativeTypeName("LONG")]
        public int ne_crc;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_flags"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_flags;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_autodata"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_autodata;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_heap"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_heap;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_stack"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_stack;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_csip"]/*' />
        [NativeTypeName("LONG")]
        public int ne_csip;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_sssp"]/*' />
        [NativeTypeName("LONG")]
        public int ne_sssp;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_cseg"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_cseg;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_cmod"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_cmod;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_cbnrestab"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_cbnrestab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_segtab"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_segtab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_rsrctab"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_rsrctab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_restab"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_restab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_modtab"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_modtab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_imptab"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_imptab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_nrestab"]/*' />
        [NativeTypeName("LONG")]
        public int ne_nrestab;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_cmovent"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_cmovent;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_align"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_align;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_cres"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_cres;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_exetyp"]/*' />
        public byte ne_exetyp;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_flagsothers"]/*' />
        public byte ne_flagsothers;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_pretthunks"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_pretthunks;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_psegrefbytes"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_psegrefbytes;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_swaparea"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_swaparea;

        /// <include file='IMAGE_OS2_HEADER.xml' path='doc/member[@name="IMAGE_OS2_HEADER.ne_expver"]/*' />
        [NativeTypeName("WORD")]
        public ushort ne_expver;
    }
}

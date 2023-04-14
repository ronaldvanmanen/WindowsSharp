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
    /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe partial struct IMAGE_VXD_HEADER
    {
        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_magic"]/*' />
        [NativeTypeName("WORD")]
        public ushort e32_magic;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_border"]/*' />
        public byte e32_border;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_worder"]/*' />
        public byte e32_worder;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_level"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_level;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_cpu"]/*' />
        [NativeTypeName("WORD")]
        public ushort e32_cpu;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_os"]/*' />
        [NativeTypeName("WORD")]
        public ushort e32_os;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_ver"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_ver;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_mflags"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_mflags;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_mpages"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_mpages;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_startobj"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_startobj;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_eip"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_eip;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_stackobj"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_stackobj;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_esp"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_esp;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_pagesize"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_pagesize;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_lastpagesize"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_lastpagesize;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_fixupsize"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_fixupsize;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_fixupsum"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_fixupsum;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_ldrsize"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_ldrsize;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_ldrsum"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_ldrsum;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_objtab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_objtab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_objcnt"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_objcnt;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_objmap"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_objmap;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_itermap"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_itermap;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_rsrctab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_rsrctab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_rsrccnt"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_rsrccnt;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_restab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_restab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_enttab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_enttab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_dirtab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_dirtab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_dircnt"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_dircnt;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_fpagetab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_fpagetab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_frectab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_frectab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_impmod"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_impmod;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_impmodcnt"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_impmodcnt;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_impproc"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_impproc;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_pagesum"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_pagesum;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_datapage"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_datapage;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_preload"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_preload;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_nrestab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_nrestab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_cbnrestab"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_cbnrestab;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_nressum"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_nressum;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_autodata"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_autodata;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_debuginfo"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_debuginfo;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_debuglen"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_debuglen;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_instpreload"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_instpreload;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_instdemand"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_instdemand;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_heapsize"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_heapsize;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_res3"]/*' />
        [NativeTypeName("BYTE [12]")]
        public fixed byte e32_res3[12];

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_winresoff"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_winresoff;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_winreslen"]/*' />
        [NativeTypeName("DWORD")]
        public uint e32_winreslen;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_devid"]/*' />
        [NativeTypeName("WORD")]
        public ushort e32_devid;

        /// <include file='IMAGE_VXD_HEADER.xml' path='doc/member[@name="IMAGE_VXD_HEADER.e32_ddkver"]/*' />
        [NativeTypeName("WORD")]
        public ushort e32_ddkver;
    }
}

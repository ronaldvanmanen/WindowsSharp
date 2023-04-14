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
    /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct NON_PAGED_DEBUG_INFO
    {
        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Signature"]/*' />
        [NativeTypeName("WORD")]
        public ushort Signature;

        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Flags"]/*' />
        [NativeTypeName("WORD")]
        public ushort Flags;

        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Machine"]/*' />
        [NativeTypeName("WORD")]
        public ushort Machine;

        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.Characteristics"]/*' />
        [NativeTypeName("WORD")]
        public ushort Characteristics;

        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.TimeDateStamp"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.CheckSum"]/*' />
        [NativeTypeName("DWORD")]
        public uint CheckSum;

        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.SizeOfImage"]/*' />
        [NativeTypeName("DWORD")]
        public uint SizeOfImage;

        /// <include file='NON_PAGED_DEBUG_INFO.xml' path='doc/member[@name="NON_PAGED_DEBUG_INFO.ImageBase"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong ImageBase;
    }
}

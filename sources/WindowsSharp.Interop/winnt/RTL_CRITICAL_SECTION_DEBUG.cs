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

namespace WindowsSharp.Interop
{
    /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG"]/*' />
    public unsafe partial struct RTL_CRITICAL_SECTION_DEBUG
    {
        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.Type"]/*' />
        [NativeTypeName("WORD")]
        public ushort Type;

        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.CreatorBackTraceIndex"]/*' />
        [NativeTypeName("WORD")]
        public ushort CreatorBackTraceIndex;

        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.CriticalSection"]/*' />
        [NativeTypeName("struct _RTL_CRITICAL_SECTION *")]
        public RTL_CRITICAL_SECTION* CriticalSection;

        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.ProcessLocksList"]/*' />
        public LIST_ENTRY ProcessLocksList;

        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.EntryCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint EntryCount;

        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.ContentionCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint ContentionCount;

        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.CreatorBackTraceIndexHigh"]/*' />
        [NativeTypeName("WORD")]
        public ushort CreatorBackTraceIndexHigh;

        /// <include file='RTL_CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="RTL_CRITICAL_SECTION_DEBUG.SpareWORD"]/*' />
        [NativeTypeName("WORD")]
        public ushort SpareWORD;
    }
}

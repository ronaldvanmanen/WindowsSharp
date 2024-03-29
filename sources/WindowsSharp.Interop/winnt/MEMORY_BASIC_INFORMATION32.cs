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
    /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32"]/*' />
    public partial struct MEMORY_BASIC_INFORMATION32
    {
        /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.BaseAddress"]/*' />
        [NativeTypeName("DWORD")]
        public uint BaseAddress;

        /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.AllocationBase"]/*' />
        [NativeTypeName("DWORD")]
        public uint AllocationBase;

        /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.AllocationProtect"]/*' />
        [NativeTypeName("DWORD")]
        public uint AllocationProtect;

        /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.RegionSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint RegionSize;

        /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.State"]/*' />
        [NativeTypeName("DWORD")]
        public uint State;

        /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.Protect"]/*' />
        [NativeTypeName("DWORD")]
        public uint Protect;

        /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.Type"]/*' />
        [NativeTypeName("DWORD")]
        public uint Type;
    }
}

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
    /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO"]/*' />
    public partial struct JIT_DEBUG_INFO
    {
        /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.dwSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwSize;

        /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.dwProcessorArchitecture"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProcessorArchitecture;

        /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.dwThreadID"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwThreadID;

        /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.dwReserved0"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwReserved0;

        /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.lpExceptionAddress"]/*' />
        [NativeTypeName("ULONG64")]
        public ulong lpExceptionAddress;

        /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.lpExceptionRecord"]/*' />
        [NativeTypeName("ULONG64")]
        public ulong lpExceptionRecord;

        /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.lpContextRecord"]/*' />
        [NativeTypeName("ULONG64")]
        public ulong lpContextRecord;
    }
}

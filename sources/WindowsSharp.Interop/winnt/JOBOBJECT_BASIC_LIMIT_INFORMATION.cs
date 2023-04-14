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
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION"]/*' />
    public partial struct JOBOBJECT_BASIC_LIMIT_INFORMATION
    {
        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.PerProcessUserTimeLimit"]/*' />
        public LARGE_INTEGER PerProcessUserTimeLimit;

        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.PerJobUserTimeLimit"]/*' />
        public LARGE_INTEGER PerJobUserTimeLimit;

        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.LimitFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint LimitFlags;

        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.MinimumWorkingSetSize"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong MinimumWorkingSetSize;

        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.MaximumWorkingSetSize"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong MaximumWorkingSetSize;

        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.ActiveProcessLimit"]/*' />
        [NativeTypeName("DWORD")]
        public uint ActiveProcessLimit;

        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.Affinity"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong Affinity;

        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.PriorityClass"]/*' />
        [NativeTypeName("DWORD")]
        public uint PriorityClass;

        /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.SchedulingClass"]/*' />
        [NativeTypeName("DWORD")]
        public uint SchedulingClass;
    }
}

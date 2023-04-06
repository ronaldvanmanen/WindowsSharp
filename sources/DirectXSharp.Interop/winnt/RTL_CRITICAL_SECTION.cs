// DirectXSharp
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

namespace DirectXSharp.Interop
{
    /// <include file='RTL_CRITICAL_SECTION.xml' path='doc/member[@name="RTL_CRITICAL_SECTION"]/*' />
    public unsafe partial struct RTL_CRITICAL_SECTION
    {
        /// <include file='RTL_CRITICAL_SECTION.xml' path='doc/member[@name="RTL_CRITICAL_SECTION.DebugInfo"]/*' />
        [NativeTypeName("PRTL_CRITICAL_SECTION_DEBUG")]
        public RTL_CRITICAL_SECTION_DEBUG* DebugInfo;

        /// <include file='RTL_CRITICAL_SECTION.xml' path='doc/member[@name="RTL_CRITICAL_SECTION.LockCount"]/*' />
        [NativeTypeName("LONG")]
        public int LockCount;

        /// <include file='RTL_CRITICAL_SECTION.xml' path='doc/member[@name="RTL_CRITICAL_SECTION.RecursionCount"]/*' />
        [NativeTypeName("LONG")]
        public int RecursionCount;

        /// <include file='RTL_CRITICAL_SECTION.xml' path='doc/member[@name="RTL_CRITICAL_SECTION.OwningThread"]/*' />
        [NativeTypeName("HANDLE")]
        public void* OwningThread;

        /// <include file='RTL_CRITICAL_SECTION.xml' path='doc/member[@name="RTL_CRITICAL_SECTION.LockSemaphore"]/*' />
        [NativeTypeName("HANDLE")]
        public void* LockSemaphore;

        /// <include file='RTL_CRITICAL_SECTION.xml' path='doc/member[@name="RTL_CRITICAL_SECTION.SpinCount"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong SpinCount;
    }
}
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
    /// <include file='XSTATE_CONTEXT.xml' path='doc/member[@name="XSTATE_CONTEXT"]/*' />
    public unsafe partial struct XSTATE_CONTEXT
    {
        /// <include file='XSTATE_CONTEXT.xml' path='doc/member[@name="XSTATE_CONTEXT.Mask"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Mask;

        /// <include file='XSTATE_CONTEXT.xml' path='doc/member[@name="XSTATE_CONTEXT.Length"]/*' />
        [NativeTypeName("DWORD")]
        public uint Length;

        /// <include file='XSTATE_CONTEXT.xml' path='doc/member[@name="XSTATE_CONTEXT.Reserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved1;

        /// <include file='XSTATE_CONTEXT.xml' path='doc/member[@name="XSTATE_CONTEXT.Area"]/*' />
        [NativeTypeName("PXSAVE_AREA")]
        public XSAVE_AREA* Area;

        /// <include file='XSTATE_CONTEXT.xml' path='doc/member[@name="XSTATE_CONTEXT.Buffer"]/*' />
        [NativeTypeName("PVOID")]
        public void* Buffer;
    }
}

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

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='PRIVILEGE_SET.xml' path='doc/member[@name="PRIVILEGE_SET"]/*' />
    public partial struct PRIVILEGE_SET
    {
        /// <include file='PRIVILEGE_SET.xml' path='doc/member[@name="PRIVILEGE_SET.PrivilegeCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint PrivilegeCount;

        /// <include file='PRIVILEGE_SET.xml' path='doc/member[@name="PRIVILEGE_SET.Control"]/*' />
        [NativeTypeName("DWORD")]
        public uint Control;

        /// <include file='PRIVILEGE_SET.xml' path='doc/member[@name="PRIVILEGE_SET.Privilege"]/*' />
        [NativeTypeName("LUID_AND_ATTRIBUTES [1]")]
        public _Privilege_e__FixedBuffer Privilege;

        /// <include file='_Privilege_e__FixedBuffer.xml' path='doc/member[@name="_Privilege_e__FixedBuffer"]/*' />
        public partial struct _Privilege_e__FixedBuffer
        {
            public LUID_AND_ATTRIBUTES e0;

            public ref LUID_AND_ATTRIBUTES this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<LUID_AND_ATTRIBUTES> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

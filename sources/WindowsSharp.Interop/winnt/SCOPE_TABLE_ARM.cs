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
    /// <include file='SCOPE_TABLE_ARM.xml' path='doc/member[@name="SCOPE_TABLE_ARM"]/*' />
    public partial struct SCOPE_TABLE_ARM
    {
        /// <include file='SCOPE_TABLE_ARM.xml' path='doc/member[@name="SCOPE_TABLE_ARM.Count"]/*' />
        [NativeTypeName("DWORD")]
        public uint Count;

        /// <include file='SCOPE_TABLE_ARM.xml' path='doc/member[@name="SCOPE_TABLE_ARM.ScopeRecord"]/*' />
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:4189:5) [1]")]
        public _ScopeRecord_e__FixedBuffer ScopeRecord;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BeginAddress"]/*' />
            [NativeTypeName("DWORD")]
            public uint BeginAddress;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EndAddress"]/*' />
            [NativeTypeName("DWORD")]
            public uint EndAddress;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.HandlerAddress"]/*' />
            [NativeTypeName("DWORD")]
            public uint HandlerAddress;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.JumpTarget"]/*' />
            [NativeTypeName("DWORD")]
            public uint JumpTarget;
        }

        /// <include file='_ScopeRecord_e__FixedBuffer.xml' path='doc/member[@name="_ScopeRecord_e__FixedBuffer"]/*' />
        public partial struct _ScopeRecord_e__FixedBuffer
        {
            public _Anonymous_e__Struct e0;

            public ref _Anonymous_e__Struct this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<_Anonymous_e__Struct> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

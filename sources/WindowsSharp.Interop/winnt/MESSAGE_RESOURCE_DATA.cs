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
    /// <include file='MESSAGE_RESOURCE_DATA.xml' path='doc/member[@name="MESSAGE_RESOURCE_DATA"]/*' />
    public partial struct MESSAGE_RESOURCE_DATA
    {
        /// <include file='MESSAGE_RESOURCE_DATA.xml' path='doc/member[@name="MESSAGE_RESOURCE_DATA.NumberOfBlocks"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberOfBlocks;

        /// <include file='MESSAGE_RESOURCE_DATA.xml' path='doc/member[@name="MESSAGE_RESOURCE_DATA.Blocks"]/*' />
        [NativeTypeName("MESSAGE_RESOURCE_BLOCK [1]")]
        public _Blocks_e__FixedBuffer Blocks;

        /// <include file='_Blocks_e__FixedBuffer.xml' path='doc/member[@name="_Blocks_e__FixedBuffer"]/*' />
        public partial struct _Blocks_e__FixedBuffer
        {
            public MESSAGE_RESOURCE_BLOCK e0;

            public ref MESSAGE_RESOURCE_BLOCK this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MESSAGE_RESOURCE_BLOCK> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}

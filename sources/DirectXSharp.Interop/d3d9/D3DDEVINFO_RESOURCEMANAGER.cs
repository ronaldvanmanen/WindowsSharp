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

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='D3DDEVINFO_RESOURCEMANAGER.xml' path='doc/member[@name="D3DDEVINFO_RESOURCEMANAGER"]/*' />
    public partial struct D3DDEVINFO_RESOURCEMANAGER
    {
        /// <include file='D3DDEVINFO_RESOURCEMANAGER.xml' path='doc/member[@name="D3DDEVINFO_RESOURCEMANAGER.stats"]/*' />
        [NativeTypeName("D3DRESOURCESTATS [8]")]
        public _stats_e__FixedBuffer stats;

        /// <include file='_stats_e__FixedBuffer.xml' path='doc/member[@name="_stats_e__FixedBuffer"]/*' />
        public partial struct _stats_e__FixedBuffer
        {
            public D3DRESOURCESTATS e0;
            public D3DRESOURCESTATS e1;
            public D3DRESOURCESTATS e2;
            public D3DRESOURCESTATS e3;
            public D3DRESOURCESTATS e4;
            public D3DRESOURCESTATS e5;
            public D3DRESOURCESTATS e6;
            public D3DRESOURCESTATS e7;

            public ref D3DRESOURCESTATS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3DRESOURCESTATS> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}

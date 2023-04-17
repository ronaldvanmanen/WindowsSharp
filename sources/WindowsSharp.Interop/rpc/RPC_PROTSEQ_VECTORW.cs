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

using System.Runtime.CompilerServices;

namespace WindowsSharp.Interop
{
    /// <include file='RPC_PROTSEQ_VECTORW.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORW"]/*' />
    public partial struct RPC_PROTSEQ_VECTORW
    {
        /// <include file='RPC_PROTSEQ_VECTORW.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORW.Count"]/*' />
        [NativeTypeName("unsigned int")]
        public uint Count;

        /// <include file='RPC_PROTSEQ_VECTORW.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORW.Protseq"]/*' />
        [NativeTypeName("unsigned short *[1]")]
        public _Protseq_e__FixedBuffer Protseq;

        /// <include file='_Protseq_e__FixedBuffer.xml' path='doc/member[@name="_Protseq_e__FixedBuffer"]/*' />
        public unsafe partial struct _Protseq_e__FixedBuffer
        {
            public ushort* e0;

            public ref ushort* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (ushort** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}

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
    /// <include file='RPC_IF_ID_VECTOR.xml' path='doc/member[@name="RPC_IF_ID_VECTOR"]/*' />
    public partial struct RPC_IF_ID_VECTOR
    {
        /// <include file='RPC_IF_ID_VECTOR.xml' path='doc/member[@name="RPC_IF_ID_VECTOR.Count"]/*' />
        [NativeTypeName("unsigned long")]
        public uint Count;

        /// <include file='RPC_IF_ID_VECTOR.xml' path='doc/member[@name="RPC_IF_ID_VECTOR.IfId"]/*' />
        [NativeTypeName("RPC_IF_ID *[1]")]
        public _IfId_e__FixedBuffer IfId;

        /// <include file='_IfId_e__FixedBuffer.xml' path='doc/member[@name="_IfId_e__FixedBuffer"]/*' />
        public unsafe partial struct _IfId_e__FixedBuffer
        {
            public RPC_IF_ID* e0;

            public ref RPC_IF_ID* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (RPC_IF_ID** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}

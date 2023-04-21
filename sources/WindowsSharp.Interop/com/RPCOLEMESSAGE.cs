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
    /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE"]/*' />
    public unsafe partial struct RPCOLEMESSAGE
    {
        /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.reserved1"]/*' />
        public void* reserved1;

        /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.dataRepresentation"]/*' />
        [NativeTypeName("RPCOLEDATAREP")]
        public uint dataRepresentation;

        /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.Buffer"]/*' />
        public void* Buffer;

        /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.cbBuffer"]/*' />
        [NativeTypeName("ULONG")]
        public uint cbBuffer;

        /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.iMethod"]/*' />
        [NativeTypeName("ULONG")]
        public uint iMethod;

        /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.reserved2"]/*' />
        [NativeTypeName("void *[5]")]
        public _reserved2_e__FixedBuffer reserved2;

        /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.rpcFlags"]/*' />
        [NativeTypeName("ULONG")]
        public uint rpcFlags;

        /// <include file='_reserved2_e__FixedBuffer.xml' path='doc/member[@name="_reserved2_e__FixedBuffer"]/*' />
        public unsafe partial struct _reserved2_e__FixedBuffer
        {
            public void* e0;
            public void* e1;
            public void* e2;
            public void* e3;
            public void* e4;

            public ref void* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (void** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}

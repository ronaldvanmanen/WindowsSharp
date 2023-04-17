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
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='D3D11_BUFFER_RTV.xml' path='doc/member[@name="D3D11_BUFFER_RTV"]/*' />
    public partial struct D3D11_BUFFER_RTV
    {
        /// <include file='D3D11_BUFFER_RTV.xml' path='doc/member[@name="D3D11_BUFFER_RTV.Anonymous1"]/*' />
        [NativeTypeName("D3D11_BUFFER_RTV::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:3745:5)")]
        public _Anonymous1_e__Union Anonymous1;

        /// <include file='D3D11_BUFFER_RTV.xml' path='doc/member[@name="D3D11_BUFFER_RTV.Anonymous2"]/*' />
        [NativeTypeName("D3D11_BUFFER_RTV::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11.h:3750:5)")]
        public _Anonymous2_e__Union Anonymous2;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.FirstElement"]/*' />
        public ref uint FirstElement
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.FirstElement, 1));
            }
        }

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.ElementOffset"]/*' />
        public ref uint ElementOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.ElementOffset, 1));
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.NumElements"]/*' />
        public ref uint NumElements
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.NumElements, 1));
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ElementWidth"]/*' />
        public ref uint ElementWidth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.ElementWidth, 1));
            }
        }

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.FirstElement"]/*' />
            [FieldOffset(0)]
            public uint FirstElement;

            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.ElementOffset"]/*' />
            [FieldOffset(0)]
            public uint ElementOffset;
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.NumElements"]/*' />
            [FieldOffset(0)]
            public uint NumElements;

            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ElementWidth"]/*' />
            [FieldOffset(0)]
            public uint ElementWidth;
        }
    }
}

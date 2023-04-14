// WindowsSharp
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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"]/*' />
    public partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX
    {
        /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Relationship"]/*' />
        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

        /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Anonymous"]/*' />
        [NativeTypeName("_SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12611:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Processor"]/*' />
        public ref PROCESSOR_RELATIONSHIP Processor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Processor, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
        public ref NUMA_NODE_RELATIONSHIP NumaNode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NumaNode, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
        public ref CACHE_RELATIONSHIP Cache
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Cache, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Group"]/*' />
        public ref GROUP_RELATIONSHIP Group
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Group, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Processor"]/*' />
            [FieldOffset(0)]
            public PROCESSOR_RELATIONSHIP Processor;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
            [FieldOffset(0)]
            public NUMA_NODE_RELATIONSHIP NumaNode;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
            [FieldOffset(0)]
            public CACHE_RELATIONSHIP Cache;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Group"]/*' />
            [FieldOffset(0)]
            public GROUP_RELATIONSHIP Group;
        }
    }
}

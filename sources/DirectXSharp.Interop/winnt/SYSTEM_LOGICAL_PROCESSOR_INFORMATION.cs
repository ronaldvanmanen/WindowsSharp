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
    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"]/*' />
    public unsafe partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
    {
        /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION.ProcessorMask"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong ProcessorMask;

        /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION.Relationship"]/*' />
        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

        /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION.Anonymous"]/*' />
        [NativeTypeName("_SYSTEM_LOGICAL_PROCESSOR_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12558:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ProcessorCore"]/*' />
        public ref _Anonymous_e__Union._ProcessorCore_e__Struct ProcessorCore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ProcessorCore, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
        public ref _Anonymous_e__Union._NumaNode_e__Struct NumaNode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NumaNode, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
        public ref CACHE_DESCRIPTOR Cache
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Cache, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
        public Span<ulong> Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.Reserved[0], 2);
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ProcessorCore"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12559:9)")]
            public _ProcessorCore_e__Struct ProcessorCore;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12562:9)")]
            public _NumaNode_e__Struct NumaNode;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
            [FieldOffset(0)]
            public CACHE_DESCRIPTOR Cache;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG [2]")]
            public fixed ulong Reserved[2];

            /// <include file='_ProcessorCore_e__Struct.xml' path='doc/member[@name="_ProcessorCore_e__Struct"]/*' />
            public partial struct _ProcessorCore_e__Struct
            {
                /// <include file='_ProcessorCore_e__Struct.xml' path='doc/member[@name="_ProcessorCore_e__Struct.Flags"]/*' />
                public byte Flags;
            }

            /// <include file='_NumaNode_e__Struct.xml' path='doc/member[@name="_NumaNode_e__Struct"]/*' />
            public partial struct _NumaNode_e__Struct
            {
                /// <include file='_NumaNode_e__Struct.xml' path='doc/member[@name="_NumaNode_e__Struct.NodeNumber"]/*' />
                [NativeTypeName("DWORD")]
                public uint NodeNumber;
            }
        }
    }
}

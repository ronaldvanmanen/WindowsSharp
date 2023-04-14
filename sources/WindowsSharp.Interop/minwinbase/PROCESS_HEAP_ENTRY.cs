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
    /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY"]/*' />
    public unsafe partial struct PROCESS_HEAP_ENTRY
    {
        /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.lpData"]/*' />
        [NativeTypeName("PVOID")]
        public void* lpData;

        /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.cbData"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbData;

        /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.cbOverhead"]/*' />
        public byte cbOverhead;

        /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.iRegionIndex"]/*' />
        public byte iRegionIndex;

        /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.wFlags"]/*' />
        [NativeTypeName("WORD")]
        public ushort wFlags;

        /// <include file='PROCESS_HEAP_ENTRY.xml' path='doc/member[@name="PROCESS_HEAP_ENTRY.Anonymous"]/*' />
        [NativeTypeName("_PROCESS_HEAP_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:244:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Block"]/*' />
        public ref _Anonymous_e__Union._Block_e__Struct Block
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Block, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Region"]/*' />
        public ref _Anonymous_e__Union._Region_e__Struct Region
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Region, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Block"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:245:9)")]
            public _Block_e__Struct Block;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Region"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:249:9)")]
            public _Region_e__Struct Region;

            /// <include file='_Block_e__Struct.xml' path='doc/member[@name="_Block_e__Struct"]/*' />
            public unsafe partial struct _Block_e__Struct
            {
                /// <include file='_Block_e__Struct.xml' path='doc/member[@name="_Block_e__Struct.hMem"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hMem;

                /// <include file='_Block_e__Struct.xml' path='doc/member[@name="_Block_e__Struct.dwReserved"]/*' />
                [NativeTypeName("DWORD [3]")]
                public fixed uint dwReserved[3];
            }

            /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct"]/*' />
            public unsafe partial struct _Region_e__Struct
            {
                /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct.dwCommittedSize"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwCommittedSize;

                /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct.dwUnCommittedSize"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwUnCommittedSize;

                /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct.lpFirstBlock"]/*' />
                [NativeTypeName("LPVOID")]
                public void* lpFirstBlock;

                /// <include file='_Region_e__Struct.xml' path='doc/member[@name="_Region_e__Struct.lpLastBlock"]/*' />
                [NativeTypeName("LPVOID")]
                public void* lpLastBlock;
            }
        }
    }
}

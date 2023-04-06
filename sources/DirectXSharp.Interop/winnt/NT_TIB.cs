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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='NT_TIB.xml' path='doc/member[@name="NT_TIB"]/*' />
    public unsafe partial struct NT_TIB
    {
        /// <include file='NT_TIB.xml' path='doc/member[@name="NT_TIB.ExceptionList"]/*' />
        [NativeTypeName("struct _EXCEPTION_REGISTRATION_RECORD *")]
        public EXCEPTION_REGISTRATION_RECORD* ExceptionList;

        /// <include file='NT_TIB.xml' path='doc/member[@name="NT_TIB.StackBase"]/*' />
        [NativeTypeName("PVOID")]
        public void* StackBase;

        /// <include file='NT_TIB.xml' path='doc/member[@name="NT_TIB.StackLimit"]/*' />
        [NativeTypeName("PVOID")]
        public void* StackLimit;

        /// <include file='NT_TIB.xml' path='doc/member[@name="NT_TIB.SubSystemTib"]/*' />
        [NativeTypeName("PVOID")]
        public void* SubSystemTib;

        /// <include file='NT_TIB.xml' path='doc/member[@name="NT_TIB.Anonymous"]/*' />
        [NativeTypeName("_NT_TIB::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11490:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='NT_TIB.xml' path='doc/member[@name="NT_TIB.ArbitraryUserPointer"]/*' />
        [NativeTypeName("PVOID")]
        public void* ArbitraryUserPointer;

        /// <include file='NT_TIB.xml' path='doc/member[@name="NT_TIB.Self"]/*' />
        [NativeTypeName("struct _NT_TIB *")]
        public NT_TIB* Self;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FiberData"]/*' />
        public ref void* FiberData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.FiberData;
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
        public ref uint Version
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Version, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FiberData"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("PVOID")]
            public void* FiberData;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Version;
        }
    }
}

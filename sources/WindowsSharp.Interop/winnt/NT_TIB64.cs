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
    /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64"]/*' />
    public partial struct NT_TIB64
    {
        /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.ExceptionList"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong ExceptionList;

        /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.StackBase"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong StackBase;

        /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.StackLimit"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong StackLimit;

        /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.SubSystemTib"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong SubSystemTib;

        /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.Anonymous"]/*' />
        [NativeTypeName("_NT_TIB64::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11531:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.ArbitraryUserPointer"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong ArbitraryUserPointer;

        /// <include file='NT_TIB64.xml' path='doc/member[@name="NT_TIB64.Self"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong Self;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FiberData"]/*' />
        public ref ulong FiberData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.FiberData, 1));
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
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FiberData"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong FiberData;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Version;
        }
    }
}

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
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER"]/*' />
    public partial struct IMAGE_COR20_HEADER
    {
        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.cb"]/*' />
        [NativeTypeName("DWORD")]
        public uint cb;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.MajorRuntimeVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MajorRuntimeVersion;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.MinorRuntimeVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MinorRuntimeVersion;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.MetaData"]/*' />
        public IMAGE_DATA_DIRECTORY MetaData;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.Anonymous"]/*' />
        [NativeTypeName("IMAGE_COR20_HEADER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:19265:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.Resources"]/*' />
        public IMAGE_DATA_DIRECTORY Resources;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.StrongNameSignature"]/*' />
        public IMAGE_DATA_DIRECTORY StrongNameSignature;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.CodeManagerTable"]/*' />
        public IMAGE_DATA_DIRECTORY CodeManagerTable;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.VTableFixups"]/*' />
        public IMAGE_DATA_DIRECTORY VTableFixups;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.ExportAddressTableJumps"]/*' />
        public IMAGE_DATA_DIRECTORY ExportAddressTableJumps;

        /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.ManagedNativeHeader"]/*' />
        public IMAGE_DATA_DIRECTORY ManagedNativeHeader;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EntryPointToken"]/*' />
        public ref uint EntryPointToken
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.EntryPointToken, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EntryPointRVA"]/*' />
        public ref uint EntryPointRVA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.EntryPointRVA, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EntryPointToken"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint EntryPointToken;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EntryPointRVA"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint EntryPointRVA;
        }
    }
}

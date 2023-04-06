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

namespace DirectXSharp.Interop
{
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600"]/*' />
    public unsafe partial struct ACTCTX_SECTION_KEYED_DATA_2600
    {
        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.cbSize"]/*' />
        [NativeTypeName("ULONG")]
        public uint cbSize;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulDataFormatVersion"]/*' />
        [NativeTypeName("ULONG")]
        public uint ulDataFormatVersion;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.lpData"]/*' />
        [NativeTypeName("PVOID")]
        public void* lpData;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulLength"]/*' />
        [NativeTypeName("ULONG")]
        public uint ulLength;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.lpSectionGlobalData"]/*' />
        [NativeTypeName("PVOID")]
        public void* lpSectionGlobalData;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulSectionGlobalDataLength"]/*' />
        [NativeTypeName("ULONG")]
        public uint ulSectionGlobalDataLength;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.lpSectionBase"]/*' />
        [NativeTypeName("PVOID")]
        public void* lpSectionBase;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulSectionTotalLength"]/*' />
        [NativeTypeName("ULONG")]
        public uint ulSectionTotalLength;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.hActCtx"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hActCtx;

        /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulAssemblyRosterIndex"]/*' />
        [NativeTypeName("ULONG")]
        public uint ulAssemblyRosterIndex;
    }
}

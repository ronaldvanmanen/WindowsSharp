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
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT"]/*' />
    public unsafe partial struct SCRUB_DATA_OUTPUT
    {
        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.Status"]/*' />
        [NativeTypeName("DWORD")]
        public uint Status;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ErrorFileOffset"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong ErrorFileOffset;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ErrorLength"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong ErrorLength;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.NumberOfBytesRepaired"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong NumberOfBytesRepaired;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.NumberOfBytesFailed"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong NumberOfBytesFailed;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.InternalFileReference"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong InternalFileReference;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ResumeContextLength"]/*' />
        [NativeTypeName("WORD")]
        public ushort ResumeContextLength;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ParityExtentDataOffset"]/*' />
        [NativeTypeName("WORD")]
        public ushort ParityExtentDataOffset;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.Reserved"]/*' />
        [NativeTypeName("DWORD [9]")]
        public fixed uint Reserved[9];

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.NumberOfMetadataBytesProcessed"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong NumberOfMetadataBytesProcessed;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.NumberOfDataBytesProcessed"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong NumberOfDataBytesProcessed;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.TotalNumberOfMetadataBytesInUse"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong TotalNumberOfMetadataBytesInUse;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.TotalNumberOfDataBytesInUse"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong TotalNumberOfDataBytesInUse;

        /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ResumeContext"]/*' />
        [NativeTypeName("BYTE [816]")]
        public fixed byte ResumeContext[816];
    }
}

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
    /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO"]/*' />
    public partial struct FILE_STORAGE_INFO
    {
        /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.LogicalBytesPerSector"]/*' />
        [NativeTypeName("ULONG")]
        public uint LogicalBytesPerSector;

        /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.PhysicalBytesPerSectorForAtomicity"]/*' />
        [NativeTypeName("ULONG")]
        public uint PhysicalBytesPerSectorForAtomicity;

        /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.PhysicalBytesPerSectorForPerformance"]/*' />
        [NativeTypeName("ULONG")]
        public uint PhysicalBytesPerSectorForPerformance;

        /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.FileSystemEffectivePhysicalBytesPerSectorForAtomicity"]/*' />
        [NativeTypeName("ULONG")]
        public uint FileSystemEffectivePhysicalBytesPerSectorForAtomicity;

        /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.Flags"]/*' />
        [NativeTypeName("ULONG")]
        public uint Flags;

        /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.ByteOffsetForSectorAlignment"]/*' />
        [NativeTypeName("ULONG")]
        public uint ByteOffsetForSectorAlignment;

        /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.ByteOffsetForPartitionAlignment"]/*' />
        [NativeTypeName("ULONG")]
        public uint ByteOffsetForPartitionAlignment;
    }
}

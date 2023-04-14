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

namespace WindowsSharp.Interop
{
    /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION"]/*' />
    public partial struct DISK_SPACE_INFORMATION
    {
        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.ActualTotalAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong ActualTotalAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.ActualAvailableAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong ActualAvailableAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.ActualPoolUnavailableAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong ActualPoolUnavailableAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.CallerTotalAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong CallerTotalAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.CallerAvailableAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong CallerAvailableAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.CallerPoolUnavailableAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong CallerPoolUnavailableAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.UsedAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong UsedAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.TotalReservedAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong TotalReservedAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.VolumeStorageReserveAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong VolumeStorageReserveAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.AvailableCommittedAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong AvailableCommittedAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.PoolAvailableAllocationUnits"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong PoolAvailableAllocationUnits;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.SectorsPerAllocationUnit"]/*' />
        [NativeTypeName("DWORD")]
        public uint SectorsPerAllocationUnit;

        /// <include file='DISK_SPACE_INFORMATION.xml' path='doc/member[@name="DISK_SPACE_INFORMATION.BytesPerSector"]/*' />
        [NativeTypeName("DWORD")]
        public uint BytesPerSector;
    }
}

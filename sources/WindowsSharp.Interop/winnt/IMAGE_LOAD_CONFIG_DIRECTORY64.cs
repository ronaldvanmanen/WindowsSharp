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

using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct IMAGE_LOAD_CONFIG_DIRECTORY64
    {
        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.TimeDateStamp"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.MajorVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MajorVersion;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.MinorVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MinorVersion;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GlobalFlagsClear"]/*' />
        [NativeTypeName("DWORD")]
        public uint GlobalFlagsClear;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GlobalFlagsSet"]/*' />
        [NativeTypeName("DWORD")]
        public uint GlobalFlagsSet;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CriticalSectionDefaultTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint CriticalSectionDefaultTimeout;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DeCommitFreeBlockThreshold"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong DeCommitFreeBlockThreshold;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DeCommitTotalFreeThreshold"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong DeCommitTotalFreeThreshold;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.LockPrefixTable"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong LockPrefixTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.MaximumAllocationSize"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong MaximumAllocationSize;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.VirtualMemoryThreshold"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong VirtualMemoryThreshold;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.ProcessAffinityMask"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong ProcessAffinityMask;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.ProcessHeapFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ProcessHeapFlags;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CSDVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort CSDVersion;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DependentLoadFlags"]/*' />
        [NativeTypeName("WORD")]
        public ushort DependentLoadFlags;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.EditList"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong EditList;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.SecurityCookie"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong SecurityCookie;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.SEHandlerTable"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong SEHandlerTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.SEHandlerCount"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong SEHandlerCount;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardCFCheckFunctionPointer"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardCFCheckFunctionPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardCFDispatchFunctionPointer"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardCFDispatchFunctionPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardCFFunctionTable"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardCFFunctionTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardCFFunctionCount"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardCFFunctionCount;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardFlags;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CodeIntegrity"]/*' />
        public IMAGE_LOAD_CONFIG_CODE_INTEGRITY CodeIntegrity;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardAddressTakenIatEntryTable"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardAddressTakenIatEntryTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardAddressTakenIatEntryCount"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardAddressTakenIatEntryCount;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardLongJumpTargetTable"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardLongJumpTargetTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardLongJumpTargetCount"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardLongJumpTargetCount;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DynamicValueRelocTable"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong DynamicValueRelocTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.CHPEMetadataPointer"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong CHPEMetadataPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardRFFailureRoutine"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardRFFailureRoutine;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardRFFailureRoutineFunctionPointer"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardRFFailureRoutineFunctionPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DynamicValueRelocTableOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint DynamicValueRelocTableOffset;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.DynamicValueRelocTableSection"]/*' />
        [NativeTypeName("WORD")]
        public ushort DynamicValueRelocTableSection;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.Reserved2"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved2;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardRFVerifyStackPointerFunctionPointer"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardRFVerifyStackPointerFunctionPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.HotPatchTableOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint HotPatchTableOffset;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.Reserved3"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved3;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.EnclaveConfigurationPointer"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong EnclaveConfigurationPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.VolatileMetadataPointer"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong VolatileMetadataPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardEHContinuationTable"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardEHContinuationTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY64.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY64.GuardEHContinuationCount"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong GuardEHContinuationCount;
    }
}

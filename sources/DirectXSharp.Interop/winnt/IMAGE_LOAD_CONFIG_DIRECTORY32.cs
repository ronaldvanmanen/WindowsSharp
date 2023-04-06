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
    /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32"]/*' />
    public partial struct IMAGE_LOAD_CONFIG_DIRECTORY32
    {
        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.TimeDateStamp"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.MajorVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MajorVersion;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.MinorVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MinorVersion;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GlobalFlagsClear"]/*' />
        [NativeTypeName("DWORD")]
        public uint GlobalFlagsClear;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GlobalFlagsSet"]/*' />
        [NativeTypeName("DWORD")]
        public uint GlobalFlagsSet;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.CriticalSectionDefaultTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint CriticalSectionDefaultTimeout;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.DeCommitFreeBlockThreshold"]/*' />
        [NativeTypeName("DWORD")]
        public uint DeCommitFreeBlockThreshold;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.DeCommitTotalFreeThreshold"]/*' />
        [NativeTypeName("DWORD")]
        public uint DeCommitTotalFreeThreshold;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.LockPrefixTable"]/*' />
        [NativeTypeName("DWORD")]
        public uint LockPrefixTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.MaximumAllocationSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint MaximumAllocationSize;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.VirtualMemoryThreshold"]/*' />
        [NativeTypeName("DWORD")]
        public uint VirtualMemoryThreshold;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.ProcessHeapFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ProcessHeapFlags;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.ProcessAffinityMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint ProcessAffinityMask;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.CSDVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort CSDVersion;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.DependentLoadFlags"]/*' />
        [NativeTypeName("WORD")]
        public ushort DependentLoadFlags;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.EditList"]/*' />
        [NativeTypeName("DWORD")]
        public uint EditList;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.SecurityCookie"]/*' />
        [NativeTypeName("DWORD")]
        public uint SecurityCookie;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.SEHandlerTable"]/*' />
        [NativeTypeName("DWORD")]
        public uint SEHandlerTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.SEHandlerCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint SEHandlerCount;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardCFCheckFunctionPointer"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardCFCheckFunctionPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardCFDispatchFunctionPointer"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardCFDispatchFunctionPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardCFFunctionTable"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardCFFunctionTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardCFFunctionCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardCFFunctionCount;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardFlags;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.CodeIntegrity"]/*' />
        public IMAGE_LOAD_CONFIG_CODE_INTEGRITY CodeIntegrity;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardAddressTakenIatEntryTable"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardAddressTakenIatEntryTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardAddressTakenIatEntryCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardAddressTakenIatEntryCount;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardLongJumpTargetTable"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardLongJumpTargetTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardLongJumpTargetCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardLongJumpTargetCount;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.DynamicValueRelocTable"]/*' />
        [NativeTypeName("DWORD")]
        public uint DynamicValueRelocTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.CHPEMetadataPointer"]/*' />
        [NativeTypeName("DWORD")]
        public uint CHPEMetadataPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardRFFailureRoutine"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardRFFailureRoutine;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardRFFailureRoutineFunctionPointer"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardRFFailureRoutineFunctionPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.DynamicValueRelocTableOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint DynamicValueRelocTableOffset;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.DynamicValueRelocTableSection"]/*' />
        [NativeTypeName("WORD")]
        public ushort DynamicValueRelocTableSection;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.Reserved2"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved2;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardRFVerifyStackPointerFunctionPointer"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardRFVerifyStackPointerFunctionPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.HotPatchTableOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint HotPatchTableOffset;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.Reserved3"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved3;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.EnclaveConfigurationPointer"]/*' />
        [NativeTypeName("DWORD")]
        public uint EnclaveConfigurationPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.VolatileMetadataPointer"]/*' />
        [NativeTypeName("DWORD")]
        public uint VolatileMetadataPointer;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardEHContinuationTable"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardEHContinuationTable;

        /// <include file='IMAGE_LOAD_CONFIG_DIRECTORY32.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_DIRECTORY32.GuardEHContinuationCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint GuardEHContinuationCount;
    }
}

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

namespace WindowsSharp.Interop
{
    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION"]/*' />
    public unsafe partial struct ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION
    {
        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulFlags;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulEncodedAssemblyIdentityLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulEncodedAssemblyIdentityLength;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulManifestPathType"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulManifestPathType;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulManifestPathLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulManifestPathLength;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.liManifestLastWriteTime"]/*' />
        public LARGE_INTEGER liManifestLastWriteTime;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulPolicyPathType"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulPolicyPathType;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulPolicyPathLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulPolicyPathLength;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.liPolicyLastWriteTime"]/*' />
        public LARGE_INTEGER liPolicyLastWriteTime;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulMetadataSatelliteRosterIndex"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulMetadataSatelliteRosterIndex;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulManifestVersionMajor"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulManifestVersionMajor;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulManifestVersionMinor"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulManifestVersionMinor;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulPolicyVersionMajor"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulPolicyVersionMajor;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulPolicyVersionMinor"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulPolicyVersionMinor;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulAssemblyDirectoryNameLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulAssemblyDirectoryNameLength;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.lpAssemblyEncodedAssemblyIdentity"]/*' />
        [NativeTypeName("PCWSTR")]
        public ushort* lpAssemblyEncodedAssemblyIdentity;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.lpAssemblyManifestPath"]/*' />
        [NativeTypeName("PCWSTR")]
        public ushort* lpAssemblyManifestPath;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.lpAssemblyPolicyPath"]/*' />
        [NativeTypeName("PCWSTR")]
        public ushort* lpAssemblyPolicyPath;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.lpAssemblyDirectoryName"]/*' />
        [NativeTypeName("PCWSTR")]
        public ushort* lpAssemblyDirectoryName;

        /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulFileCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulFileCount;
    }
}

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
    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION"]/*' />
    public unsafe partial struct ACTIVATION_CONTEXT_DETAILED_INFORMATION
    {
        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulFormatVersion"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulFormatVersion;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulAssemblyCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulAssemblyCount;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulRootManifestPathType"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulRootManifestPathType;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulRootManifestPathChars"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulRootManifestPathChars;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulRootConfigurationPathType"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulRootConfigurationPathType;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulRootConfigurationPathChars"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulRootConfigurationPathChars;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulAppDirPathType"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulAppDirPathType;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulAppDirPathChars"]/*' />
        [NativeTypeName("DWORD")]
        public uint ulAppDirPathChars;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.lpRootManifestPath"]/*' />
        [NativeTypeName("PCWSTR")]
        public ushort* lpRootManifestPath;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.lpRootConfigurationPath"]/*' />
        [NativeTypeName("PCWSTR")]
        public ushort* lpRootConfigurationPath;

        /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.lpAppDirPath"]/*' />
        [NativeTypeName("PCWSTR")]
        public ushort* lpAppDirPath;
    }
}

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
    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS"]/*' />
    public partial struct MEMORYSTATUS
    {
        /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwLength;

        /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwMemoryLoad"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwMemoryLoad;

        /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwTotalPhys"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong dwTotalPhys;

        /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwAvailPhys"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong dwAvailPhys;

        /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwTotalPageFile"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong dwTotalPageFile;

        /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwAvailPageFile"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong dwAvailPageFile;

        /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwTotalVirtual"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong dwTotalVirtual;

        /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwAvailVirtual"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong dwAvailVirtual;
    }
}

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
    /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS"]/*' />
    public unsafe partial struct CREATEFILE2_EXTENDED_PARAMETERS
    {
        /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.dwSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwSize;

        /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.dwFileAttributes"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFileAttributes;

        /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.dwFileFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFileFlags;

        /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.dwSecurityQosFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwSecurityQosFlags;

        /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.lpSecurityAttributes"]/*' />
        [NativeTypeName("LPSECURITY_ATTRIBUTES")]
        public SECURITY_ATTRIBUTES* lpSecurityAttributes;

        /// <include file='CREATEFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="CREATEFILE2_EXTENDED_PARAMETERS.hTemplateFile"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hTemplateFile;
    }
}

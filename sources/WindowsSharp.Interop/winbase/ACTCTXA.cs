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
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA"]/*' />
    public unsafe partial struct ACTCTXA
    {
        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.cbSize"]/*' />
        [NativeTypeName("ULONG")]
        public uint cbSize;

        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.lpSource"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpSource;

        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.wProcessorArchitecture"]/*' />
        public ushort wProcessorArchitecture;

        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.wLangId"]/*' />
        [NativeTypeName("LANGID")]
        public ushort wLangId;

        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.lpAssemblyDirectory"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpAssemblyDirectory;

        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.lpResourceName"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpResourceName;

        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.lpApplicationName"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* lpApplicationName;

        /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.hModule"]/*' />
        [NativeTypeName("HMODULE")]
        public HINSTANCE__* hModule;
    }
}

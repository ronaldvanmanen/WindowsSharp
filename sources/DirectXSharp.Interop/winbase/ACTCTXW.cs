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
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW"]/*' />
    public unsafe partial struct ACTCTXW
    {
        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.cbSize"]/*' />
        [NativeTypeName("ULONG")]
        public uint cbSize;

        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.lpSource"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpSource;

        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.wProcessorArchitecture"]/*' />
        public ushort wProcessorArchitecture;

        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.wLangId"]/*' />
        [NativeTypeName("LANGID")]
        public ushort wLangId;

        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.lpAssemblyDirectory"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpAssemblyDirectory;

        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.lpResourceName"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpResourceName;

        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.lpApplicationName"]/*' />
        [NativeTypeName("LPCWSTR")]
        public ushort* lpApplicationName;

        /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.hModule"]/*' />
        [NativeTypeName("HMODULE")]
        public HINSTANCE__* hModule;
    }
}

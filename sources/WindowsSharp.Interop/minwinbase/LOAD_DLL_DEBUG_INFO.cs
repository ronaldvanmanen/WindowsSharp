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
    /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO"]/*' />
    public unsafe partial struct LOAD_DLL_DEBUG_INFO
    {
        /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.hFile"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hFile;

        /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.lpBaseOfDll"]/*' />
        [NativeTypeName("LPVOID")]
        public void* lpBaseOfDll;

        /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.dwDebugInfoFileOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwDebugInfoFileOffset;

        /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.nDebugInfoSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint nDebugInfoSize;

        /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.lpImageName"]/*' />
        [NativeTypeName("LPVOID")]
        public void* lpImageName;

        /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.fUnicode"]/*' />
        [NativeTypeName("WORD")]
        public ushort fUnicode;
    }
}

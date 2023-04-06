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
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO"]/*' />
    public unsafe partial struct CREATE_PROCESS_DEBUG_INFO
    {
        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.hFile"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hFile;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.hProcess"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hProcess;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.hThread"]/*' />
        [NativeTypeName("HANDLE")]
        public void* hThread;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.lpBaseOfImage"]/*' />
        [NativeTypeName("LPVOID")]
        public void* lpBaseOfImage;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.dwDebugInfoFileOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwDebugInfoFileOffset;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.nDebugInfoSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint nDebugInfoSize;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.lpThreadLocalBase"]/*' />
        [NativeTypeName("LPVOID")]
        public void* lpThreadLocalBase;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.lpStartAddress"]/*' />
        [NativeTypeName("LPTHREAD_START_ROUTINE")]
        public delegate* unmanaged<void*, uint> lpStartAddress;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.lpImageName"]/*' />
        [NativeTypeName("LPVOID")]
        public void* lpImageName;

        /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.fUnicode"]/*' />
        [NativeTypeName("WORD")]
        public ushort fUnicode;
    }
}

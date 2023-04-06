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

using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY
    {
        /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.BeginAddress"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong BeginAddress;

        /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.EndAddress"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong EndAddress;

        /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.ExceptionHandler"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong ExceptionHandler;

        /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.HandlerData"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong HandlerData;

        /// <include file='IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY.PrologEndAddress"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong PrologEndAddress;
    }
}

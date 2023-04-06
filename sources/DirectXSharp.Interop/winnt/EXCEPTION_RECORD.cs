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
    /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD"]/*' />
    public unsafe partial struct EXCEPTION_RECORD
    {
        /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionCode"]/*' />
        [NativeTypeName("DWORD")]
        public uint ExceptionCode;

        /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint ExceptionFlags;

        /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionRecord"]/*' />
        [NativeTypeName("struct _EXCEPTION_RECORD *")]
        public EXCEPTION_RECORD* ExceptionRecord;

        /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionAddress"]/*' />
        [NativeTypeName("PVOID")]
        public void* ExceptionAddress;

        /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.NumberParameters"]/*' />
        [NativeTypeName("DWORD")]
        public uint NumberParameters;

        /// <include file='EXCEPTION_RECORD.xml' path='doc/member[@name="EXCEPTION_RECORD.ExceptionInformation"]/*' />
        [NativeTypeName("ULONG_PTR [15]")]
        public fixed ulong ExceptionInformation[15];
    }
}
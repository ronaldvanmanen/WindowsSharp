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
    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST"]/*' />
    public unsafe partial struct SE_ACCESS_REQUEST
    {
        /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.SeSecurityDescriptor"]/*' />
        [NativeTypeName("PSE_SECURITY_DESCRIPTOR")]
        public SE_SECURITY_DESCRIPTOR* SeSecurityDescriptor;

        /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.DesiredAccess"]/*' />
        [NativeTypeName("ACCESS_MASK")]
        public uint DesiredAccess;

        /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.PreviouslyGrantedAccess"]/*' />
        [NativeTypeName("ACCESS_MASK")]
        public uint PreviouslyGrantedAccess;

        /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.PrincipalSelfSid"]/*' />
        [NativeTypeName("PSID")]
        public void* PrincipalSelfSid;

        /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.GenericMapping"]/*' />
        [NativeTypeName("PGENERIC_MAPPING")]
        public GENERIC_MAPPING* GenericMapping;

        /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.ObjectTypeListCount"]/*' />
        [NativeTypeName("DWORD")]
        public uint ObjectTypeListCount;

        /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.ObjectTypeList"]/*' />
        [NativeTypeName("POBJECT_TYPE_LIST")]
        public OBJECT_TYPE_LIST* ObjectTypeList;
    }
}

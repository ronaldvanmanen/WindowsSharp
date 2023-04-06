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
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS"]/*' />
    public unsafe partial struct COPYFILE2_EXTENDED_PARAMETERS
    {
        /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.dwSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwSize;

        /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.dwCopyFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwCopyFlags;

        /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.pfCancel"]/*' />
        [NativeTypeName("BOOL *")]
        public int* pfCancel;

        /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.pProgressRoutine"]/*' />
        [NativeTypeName("PCOPYFILE2_PROGRESS_ROUTINE")]
        public delegate* unmanaged<COPYFILE2_MESSAGE*, void*, COPYFILE2_MESSAGE_ACTION> pProgressRoutine;

        /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.pvCallbackContext"]/*' />
        [NativeTypeName("PVOID")]
        public void* pvCallbackContext;
    }
}

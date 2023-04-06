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
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO"]/*' />
    public unsafe partial struct POINTER_INFO
    {
        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.pointerType"]/*' />
        [NativeTypeName("POINTER_INPUT_TYPE")]
        public uint pointerType;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.pointerId"]/*' />
        [NativeTypeName("UINT32")]
        public uint pointerId;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.frameId"]/*' />
        [NativeTypeName("UINT32")]
        public uint frameId;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.pointerFlags"]/*' />
        [NativeTypeName("POINTER_FLAGS")]
        public uint pointerFlags;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.sourceDevice"]/*' />
        [NativeTypeName("HANDLE")]
        public void* sourceDevice;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.hwndTarget"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndTarget;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ptPixelLocation"]/*' />
        public POINT ptPixelLocation;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ptHimetricLocation"]/*' />
        public POINT ptHimetricLocation;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ptPixelLocationRaw"]/*' />
        public POINT ptPixelLocationRaw;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ptHimetricLocationRaw"]/*' />
        public POINT ptHimetricLocationRaw;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.dwTime"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwTime;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.historyCount"]/*' />
        [NativeTypeName("UINT32")]
        public uint historyCount;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.InputData"]/*' />
        [NativeTypeName("INT32")]
        public int InputData;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.dwKeyStates"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwKeyStates;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.PerformanceCount"]/*' />
        [NativeTypeName("UINT64")]
        public ulong PerformanceCount;

        /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ButtonChangeType"]/*' />
        public POINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
    }
}

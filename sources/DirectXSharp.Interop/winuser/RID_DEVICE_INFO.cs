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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='RID_DEVICE_INFO.xml' path='doc/member[@name="RID_DEVICE_INFO"]/*' />
    public partial struct RID_DEVICE_INFO
    {
        /// <include file='RID_DEVICE_INFO.xml' path='doc/member[@name="RID_DEVICE_INFO.cbSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbSize;

        /// <include file='RID_DEVICE_INFO.xml' path='doc/member[@name="RID_DEVICE_INFO.dwType"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwType;

        /// <include file='RID_DEVICE_INFO.xml' path='doc/member[@name="RID_DEVICE_INFO.Anonymous"]/*' />
        [NativeTypeName("tagRID_DEVICE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinUser.h:15154:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.mouse"]/*' />
        public ref RID_DEVICE_INFO_MOUSE mouse
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.mouse, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.keyboard"]/*' />
        public ref RID_DEVICE_INFO_KEYBOARD keyboard
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.keyboard, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hid"]/*' />
        public ref RID_DEVICE_INFO_HID hid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hid, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.mouse"]/*' />
            [FieldOffset(0)]
            public RID_DEVICE_INFO_MOUSE mouse;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.keyboard"]/*' />
            [FieldOffset(0)]
            public RID_DEVICE_INFO_KEYBOARD keyboard;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hid"]/*' />
            [FieldOffset(0)]
            public RID_DEVICE_INFO_HID hid;
        }
    }
}

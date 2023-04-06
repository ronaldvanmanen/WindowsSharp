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
    /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO"]/*' />
    public partial struct DISPLAYCONFIG_MODE_INFO
    {
        /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO.infoType"]/*' />
        public DISPLAYCONFIG_MODE_INFO_TYPE infoType;

        /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO.id"]/*' />
        [NativeTypeName("UINT32")]
        public uint id;

        /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO.adapterId"]/*' />
        public LUID adapterId;

        /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO.Anonymous"]/*' />
        [NativeTypeName("DISPLAYCONFIG_MODE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2932:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.targetMode"]/*' />
        public ref DISPLAYCONFIG_TARGET_MODE targetMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.targetMode, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.sourceMode"]/*' />
        public ref DISPLAYCONFIG_SOURCE_MODE sourceMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.sourceMode, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.desktopImageInfo"]/*' />
        public ref DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.desktopImageInfo, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.targetMode"]/*' />
            [FieldOffset(0)]
            public DISPLAYCONFIG_TARGET_MODE targetMode;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.sourceMode"]/*' />
            [FieldOffset(0)]
            public DISPLAYCONFIG_SOURCE_MODE sourceMode;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.desktopImageInfo"]/*' />
            [FieldOffset(0)]
            public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
        }
    }
}

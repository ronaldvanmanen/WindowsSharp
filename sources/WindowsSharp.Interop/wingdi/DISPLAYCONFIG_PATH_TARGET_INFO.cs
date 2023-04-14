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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO"]/*' />
    public partial struct DISPLAYCONFIG_PATH_TARGET_INFO
    {
        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.adapterId"]/*' />
        public LUID adapterId;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.id"]/*' />
        [NativeTypeName("UINT32")]
        public uint id;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.Anonymous"]/*' />
        [NativeTypeName("DISPLAYCONFIG_PATH_TARGET_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2973:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.outputTechnology"]/*' />
        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.rotation"]/*' />
        public DISPLAYCONFIG_ROTATION rotation;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.scaling"]/*' />
        public DISPLAYCONFIG_SCALING scaling;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.refreshRate"]/*' />
        public DISPLAYCONFIG_RATIONAL refreshRate;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.scanLineOrdering"]/*' />
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.targetAvailable"]/*' />
        [NativeTypeName("BOOL")]
        public int targetAvailable;

        /// <include file='DISPLAYCONFIG_PATH_TARGET_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_TARGET_INFO.statusFlags"]/*' />
        [NativeTypeName("UINT32")]
        public uint statusFlags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.modeInfoIdx"]/*' />
        public ref uint modeInfoIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.modeInfoIdx, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.desktopModeInfoIdx"]/*' />
        public uint desktopModeInfoIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.desktopModeInfoIdx;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.desktopModeInfoIdx = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.targetModeInfoIdx"]/*' />
        public uint targetModeInfoIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.targetModeInfoIdx;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.targetModeInfoIdx = value;
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.modeInfoIdx"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint modeInfoIdx;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DISPLAYCONFIG_PATH_TARGET_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2976:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.desktopModeInfoIdx"]/*' />
                [NativeTypeName("UINT32 : 16")]
                public uint desktopModeInfoIdx
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0xFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
                    }
                }

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.targetModeInfoIdx"]/*' />
                [NativeTypeName("UINT32 : 16")]
                public uint targetModeInfoIdx
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 16) & 0xFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
                    }
                }
            }
        }
    }
}

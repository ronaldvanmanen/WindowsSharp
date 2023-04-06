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
    /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO"]/*' />
    public partial struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
    {
        /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.pixelRate"]/*' />
        [NativeTypeName("UINT64")]
        public ulong pixelRate;

        /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.hSyncFreq"]/*' />
        public DISPLAYCONFIG_RATIONAL hSyncFreq;

        /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.vSyncFreq"]/*' />
        public DISPLAYCONFIG_RATIONAL vSyncFreq;

        /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.activeSize"]/*' />
        public DISPLAYCONFIG_2DREGION activeSize;

        /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.totalSize"]/*' />
        public DISPLAYCONFIG_2DREGION totalSize;

        /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.Anonymous"]/*' />
        [NativeTypeName("DISPLAYCONFIG_VIDEO_SIGNAL_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2850:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.scanLineOrdering"]/*' />
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AdditionalSignalInfo"]/*' />
        public ref _Anonymous_e__Union._AdditionalSignalInfo_e__Struct AdditionalSignalInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.AdditionalSignalInfo, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.videoStandard"]/*' />
        public ref uint videoStandard
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.videoStandard, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AdditionalSignalInfo"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2852:9)")]
            public _AdditionalSignalInfo_e__Struct AdditionalSignalInfo;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.videoStandard"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint videoStandard;

            /// <include file='_AdditionalSignalInfo_e__Struct.xml' path='doc/member[@name="_AdditionalSignalInfo_e__Struct"]/*' />
            public partial struct _AdditionalSignalInfo_e__Struct
            {
                public uint _bitfield;

                /// <include file='_AdditionalSignalInfo_e__Struct.xml' path='doc/member[@name="_AdditionalSignalInfo_e__Struct.videoStandard"]/*' />
                [NativeTypeName("UINT32 : 16")]
                public uint videoStandard
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

                /// <include file='_AdditionalSignalInfo_e__Struct.xml' path='doc/member[@name="_AdditionalSignalInfo_e__Struct.vSyncFreqDivider"]/*' />
                [NativeTypeName("UINT32 : 6")]
                public uint vSyncFreqDivider
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 16) & 0x3Fu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x3Fu << 16)) | ((value & 0x3Fu) << 16);
                    }
                }

                /// <include file='_AdditionalSignalInfo_e__Struct.xml' path='doc/member[@name="_AdditionalSignalInfo_e__Struct.reserved"]/*' />
                [NativeTypeName("UINT32 : 10")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 22) & 0x3FFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFu << 22)) | ((value & 0x3FFu) << 22);
                    }
                }
            }
        }
    }
}

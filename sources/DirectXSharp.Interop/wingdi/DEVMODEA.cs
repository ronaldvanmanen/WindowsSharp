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
    /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA"]/*' />
    public unsafe partial struct DEVMODEA
    {
        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDeviceName"]/*' />
        [NativeTypeName("BYTE [32]")]
        public fixed byte dmDeviceName[32];

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmSpecVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort dmSpecVersion;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDriverVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort dmDriverVersion;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmSize"]/*' />
        [NativeTypeName("WORD")]
        public ushort dmSize;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDriverExtra"]/*' />
        [NativeTypeName("WORD")]
        public ushort dmDriverExtra;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmFields"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmFields;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.Anonymous1"]/*' />
        [NativeTypeName("_devicemodeA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2202:5)")]
        public _Anonymous1_e__Union Anonymous1;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmColor"]/*' />
        public short dmColor;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDuplex"]/*' />
        public short dmDuplex;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmYResolution"]/*' />
        public short dmYResolution;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmTTOption"]/*' />
        public short dmTTOption;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmCollate"]/*' />
        public short dmCollate;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmFormName"]/*' />
        [NativeTypeName("BYTE [32]")]
        public fixed byte dmFormName[32];

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmLogPixels"]/*' />
        [NativeTypeName("WORD")]
        public ushort dmLogPixels;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmBitsPerPel"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmBitsPerPel;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmPelsWidth"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmPelsWidth;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmPelsHeight"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmPelsHeight;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.Anonymous2"]/*' />
        [NativeTypeName("_devicemodeA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2231:5)")]
        public _Anonymous2_e__Union Anonymous2;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDisplayFrequency"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmDisplayFrequency;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmICMMethod"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmICMMethod;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmICMIntent"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmICMIntent;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmMediaType"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmMediaType;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmDitherType"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmDitherType;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmReserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmReserved1;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmReserved2"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmReserved2;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmPanningWidth"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmPanningWidth;

        /// <include file='DEVMODEA.xml' path='doc/member[@name="DEVMODEA.dmPanningHeight"]/*' />
        [NativeTypeName("DWORD")]
        public uint dmPanningHeight;

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmOrientation"]/*' />
        public ref short dmOrientation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmOrientation, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperSize"]/*' />
        public ref short dmPaperSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmPaperSize, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperLength"]/*' />
        public ref short dmPaperLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmPaperLength, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperWidth"]/*' />
        public ref short dmPaperWidth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmPaperWidth, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmScale"]/*' />
        public ref short dmScale
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmScale, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmCopies"]/*' />
        public ref short dmCopies
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmCopies, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmDefaultSource"]/*' />
        public ref short dmDefaultSource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmDefaultSource, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPrintQuality"]/*' />
        public ref short dmPrintQuality
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous1.dmPrintQuality, 1));
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmPosition"]/*' />
        public ref POINTL dmPosition
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous2.dmPosition, 1));
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayOrientation"]/*' />
        public ref uint dmDisplayOrientation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous2.dmDisplayOrientation, 1));
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayFixedOutput"]/*' />
        public ref uint dmDisplayFixedOutput
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous2.dmDisplayFixedOutput, 1));
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmDisplayFlags"]/*' />
        public ref uint dmDisplayFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dmDisplayFlags, 1));
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmNup"]/*' />
        public ref uint dmNup
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dmNup, 1));
            }
        }

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous1"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_devicemodeA::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2204:7)")]
            public _Anonymous1_e__Struct Anonymous1;

            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous2"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_devicemodeA::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2215:7)")]
            public _Anonymous2_e__Struct Anonymous2;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*' />
            public partial struct _Anonymous1_e__Struct
            {
                /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmOrientation"]/*' />
                public short dmOrientation;

                /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperSize"]/*' />
                public short dmPaperSize;

                /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperLength"]/*' />
                public short dmPaperLength;

                /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPaperWidth"]/*' />
                public short dmPaperWidth;

                /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmScale"]/*' />
                public short dmScale;

                /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmCopies"]/*' />
                public short dmCopies;

                /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmDefaultSource"]/*' />
                public short dmDefaultSource;

                /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.dmPrintQuality"]/*' />
                public short dmPrintQuality;
            }

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*' />
            public partial struct _Anonymous2_e__Struct
            {
                /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmPosition"]/*' />
                public POINTL dmPosition;

                /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayOrientation"]/*' />
                [NativeTypeName("DWORD")]
                public uint dmDisplayOrientation;

                /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dmDisplayFixedOutput"]/*' />
                [NativeTypeName("DWORD")]
                public uint dmDisplayFixedOutput;
            }
        }

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmDisplayFlags"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmDisplayFlags;

            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.dmNup"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmNup;
        }
    }
}

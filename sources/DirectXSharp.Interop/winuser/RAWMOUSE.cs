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
    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE"]/*' />
    public partial struct RAWMOUSE
    {
        /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.usFlags"]/*' />
        public ushort usFlags;

        /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.Anonymous"]/*' />
        [NativeTypeName("tagRAWMOUSE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinUser.h:14914:5)")]
        public _Anonymous_e__Union Anonymous;

        /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.ulRawButtons"]/*' />
        [NativeTypeName("ULONG")]
        public uint ulRawButtons;

        /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.lLastX"]/*' />
        [NativeTypeName("LONG")]
        public int lLastX;

        /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.lLastY"]/*' />
        [NativeTypeName("LONG")]
        public int lLastY;

        /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.ulExtraInformation"]/*' />
        [NativeTypeName("ULONG")]
        public uint ulExtraInformation;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulButtons"]/*' />
        public ref uint ulButtons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ulButtons, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonFlags"]/*' />
        public ref ushort usButtonFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.usButtonFlags, 1));
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonData"]/*' />
        public ref ushort usButtonData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.usButtonData, 1));
            }
        }

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulButtons"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ulButtons;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("tagRAWMOUSE::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinUser.h:14916:9)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonFlags"]/*' />
                public ushort usButtonFlags;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonData"]/*' />
                public ushort usButtonData;
            }
        }
    }
}

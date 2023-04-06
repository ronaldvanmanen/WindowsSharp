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

using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='REASON_CONTEXT.xml' path='doc/member[@name="REASON_CONTEXT"]/*' />
    public partial struct REASON_CONTEXT
    {
        /// <include file='REASON_CONTEXT.xml' path='doc/member[@name="REASON_CONTEXT.Version"]/*' />
        [NativeTypeName("ULONG")]
        public uint Version;

        /// <include file='REASON_CONTEXT.xml' path='doc/member[@name="REASON_CONTEXT.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='REASON_CONTEXT.xml' path='doc/member[@name="REASON_CONTEXT.Reason"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:268:5)")]
        public _Reason_e__Union Reason;

        /// <include file='_Reason_e__Union.xml' path='doc/member[@name="_Reason_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Reason_e__Union
        {
            /// <include file='_Reason_e__Union.xml' path='doc/member[@name="_Reason_e__Union.Detailed"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:269:9)")]
            public _Detailed_e__Struct Detailed;

            /// <include file='_Reason_e__Union.xml' path='doc/member[@name="_Reason_e__Union.SimpleReasonString"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* SimpleReasonString;

            /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct"]/*' />
            public unsafe partial struct _Detailed_e__Struct
            {
                /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct.LocalizedReasonModule"]/*' />
                [NativeTypeName("HMODULE")]
                public HINSTANCE__* LocalizedReasonModule;

                /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct.LocalizedReasonId"]/*' />
                [NativeTypeName("ULONG")]
                public uint LocalizedReasonId;

                /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct.ReasonStringCount"]/*' />
                [NativeTypeName("ULONG")]
                public uint ReasonStringCount;

                /// <include file='_Detailed_e__Struct.xml' path='doc/member[@name="_Detailed_e__Struct.ReasonStrings"]/*' />
                [NativeTypeName("LPWSTR *")]
                public ushort** ReasonStrings;
            }
        }
    }
}

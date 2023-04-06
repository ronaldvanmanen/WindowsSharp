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
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3"]/*' />
    public unsafe partial struct TP_CALLBACK_ENVIRON_V3
    {
        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.Version"]/*' />
        [NativeTypeName("TP_VERSION")]
        public uint Version;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.Pool"]/*' />
        [NativeTypeName("PTP_POOL")]
        public TP_POOL* Pool;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.CleanupGroup"]/*' />
        [NativeTypeName("PTP_CLEANUP_GROUP")]
        public TP_CLEANUP_GROUP* CleanupGroup;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.CleanupGroupCancelCallback"]/*' />
        [NativeTypeName("PTP_CLEANUP_GROUP_CANCEL_CALLBACK")]
        public delegate* unmanaged<void*, void*, void> CleanupGroupCancelCallback;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.RaceDll"]/*' />
        [NativeTypeName("PVOID")]
        public void* RaceDll;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.ActivationContext"]/*' />
        [NativeTypeName("struct _ACTIVATION_CONTEXT *")]
        public _ACTIVATION_CONTEXT* ActivationContext;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.FinalizationCallback"]/*' />
        [NativeTypeName("PTP_SIMPLE_CALLBACK")]
        public delegate* unmanaged<TP_CALLBACK_INSTANCE*, void*, void> FinalizationCallback;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.u"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:22686:5)")]
        public _u_e__Union u;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.CallbackPriority"]/*' />
        public TP_CALLBACK_PRIORITY CallbackPriority;

        /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='_ACTIVATION_CONTEXT.xml' path='doc/member[@name="_ACTIVATION_CONTEXT"]/*' />
        public partial struct _ACTIVATION_CONTEXT
        {
        }

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _u_e__Union
        {
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Flags"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Flags;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.s"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:22688:9)")]
            public _s_e__Struct s;

            /// <include file='_s_e__Struct.xml' path='doc/member[@name="_s_e__Struct"]/*' />
            public partial struct _s_e__Struct
            {
                public uint _bitfield;

                /// <include file='_s_e__Struct.xml' path='doc/member[@name="_s_e__Struct.LongFunction"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint LongFunction
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                /// <include file='_s_e__Struct.xml' path='doc/member[@name="_s_e__Struct.Persistent"]/*' />
                [NativeTypeName("DWORD : 1")]
                public uint Persistent
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                /// <include file='_s_e__Struct.xml' path='doc/member[@name="_s_e__Struct.Private"]/*' />
                [NativeTypeName("DWORD : 30")]
                public uint Private
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 2) & 0x3FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                    }
                }
            }
        }
    }
}

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
    /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO"]/*' />
    public partial struct FILE_REMOTE_PROTOCOL_INFO
    {
        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.StructureVersion"]/*' />
        public ushort StructureVersion;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.StructureSize"]/*' />
        public ushort StructureSize;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.Protocol"]/*' />
        [NativeTypeName("ULONG")]
        public uint Protocol;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.ProtocolMajorVersion"]/*' />
        public ushort ProtocolMajorVersion;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.ProtocolMinorVersion"]/*' />
        public ushort ProtocolMinorVersion;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.ProtocolRevision"]/*' />
        public ushort ProtocolRevision;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.Reserved"]/*' />
        public ushort Reserved;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.Flags"]/*' />
        [NativeTypeName("ULONG")]
        public uint Flags;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.GenericReserved"]/*' />
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:9077:5)")]
        public _GenericReserved_e__Struct GenericReserved;

        /// <include file='FILE_REMOTE_PROTOCOL_INFO.xml' path='doc/member[@name="FILE_REMOTE_PROTOCOL_INFO.ProtocolSpecific"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:9090:5)")]
        public _ProtocolSpecific_e__Union ProtocolSpecific;

        /// <include file='_GenericReserved_e__Struct.xml' path='doc/member[@name="_GenericReserved_e__Struct"]/*' />
        public unsafe partial struct _GenericReserved_e__Struct
        {
            /// <include file='_GenericReserved_e__Struct.xml' path='doc/member[@name="_GenericReserved_e__Struct.Reserved"]/*' />
            [NativeTypeName("ULONG [8]")]
            public fixed uint Reserved[8];
        }

        /// <include file='_ProtocolSpecific_e__Union.xml' path='doc/member[@name="_ProtocolSpecific_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _ProtocolSpecific_e__Union
        {
            /// <include file='_ProtocolSpecific_e__Union.xml' path='doc/member[@name="_ProtocolSpecific_e__Union.Smb2"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:9092:9)")]
            public _Smb2_e__Struct Smb2;

            /// <include file='_ProtocolSpecific_e__Union.xml' path='doc/member[@name="_ProtocolSpecific_e__Union.Reserved"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("ULONG [16]")]
            public fixed uint Reserved[16];

            /// <include file='_Smb2_e__Struct.xml' path='doc/member[@name="_Smb2_e__Struct"]/*' />
            public partial struct _Smb2_e__Struct
            {
                /// <include file='_Smb2_e__Struct.xml' path='doc/member[@name="_Smb2_e__Struct.Server"]/*' />
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:9094:13)")]
                public _Server_e__Struct Server;

                /// <include file='_Smb2_e__Struct.xml' path='doc/member[@name="_Smb2_e__Struct.Share"]/*' />
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:9098:13)")]
                public _Share_e__Struct Share;

                /// <include file='_Server_e__Struct.xml' path='doc/member[@name="_Server_e__Struct"]/*' />
                public partial struct _Server_e__Struct
                {
                    /// <include file='_Server_e__Struct.xml' path='doc/member[@name="_Server_e__Struct.Capabilities"]/*' />
                    [NativeTypeName("ULONG")]
                    public uint Capabilities;
                }

                /// <include file='_Share_e__Struct.xml' path='doc/member[@name="_Share_e__Struct"]/*' />
                public partial struct _Share_e__Struct
                {
                    /// <include file='_Share_e__Struct.xml' path='doc/member[@name="_Share_e__Struct.Capabilities"]/*' />
                    [NativeTypeName("ULONG")]
                    public uint Capabilities;

                    /// <include file='_Share_e__Struct.xml' path='doc/member[@name="_Share_e__Struct.CachingFlags"]/*' />
                    [NativeTypeName("ULONG")]
                    public uint CachingFlags;
                }
            }
        }
    }
}

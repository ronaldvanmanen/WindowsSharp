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

using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='COPYFILE2_MESSAGE.xml' path='doc/member[@name="COPYFILE2_MESSAGE"]/*' />
    public partial struct COPYFILE2_MESSAGE
    {
        /// <include file='COPYFILE2_MESSAGE.xml' path='doc/member[@name="COPYFILE2_MESSAGE.Type"]/*' />
        public COPYFILE2_MESSAGE_TYPE Type;

        /// <include file='COPYFILE2_MESSAGE.xml' path='doc/member[@name="COPYFILE2_MESSAGE.dwPadding"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwPadding;

        /// <include file='COPYFILE2_MESSAGE.xml' path='doc/member[@name="COPYFILE2_MESSAGE.Info"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:5729:5)")]
        public _Info_e__Union Info;

        /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Info_e__Union
        {
            /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.ChunkStarted"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:5731:9)")]
            public _ChunkStarted_e__Struct ChunkStarted;

            /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.ChunkFinished"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:5742:9)")]
            public _ChunkFinished_e__Struct ChunkFinished;

            /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.StreamStarted"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:5755:9)")]
            public _StreamStarted_e__Struct StreamStarted;

            /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.StreamFinished"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:5764:9)")]
            public _StreamFinished_e__Struct StreamFinished;

            /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.PollContinue"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:5775:9)")]
            public _PollContinue_e__Struct PollContinue;

            /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.Error"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winbase.h:5779:9)")]
            public _Error_e__Struct Error;

            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct"]/*' />
            public unsafe partial struct _ChunkStarted_e__Struct
            {
                /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.dwStreamNumber"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.dwReserved"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwReserved;

                /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.hSourceFile"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hSourceFile;

                /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.hDestinationFile"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hDestinationFile;

                /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.uliChunkNumber"]/*' />
                public ULARGE_INTEGER uliChunkNumber;

                /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.uliChunkSize"]/*' />
                public ULARGE_INTEGER uliChunkSize;

                /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.uliStreamSize"]/*' />
                public ULARGE_INTEGER uliStreamSize;

                /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.uliTotalFileSize"]/*' />
                public ULARGE_INTEGER uliTotalFileSize;
            }

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct"]/*' />
            public unsafe partial struct _ChunkFinished_e__Struct
            {
                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.dwStreamNumber"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.dwFlags"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwFlags;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.hSourceFile"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hSourceFile;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.hDestinationFile"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hDestinationFile;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliChunkNumber"]/*' />
                public ULARGE_INTEGER uliChunkNumber;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliChunkSize"]/*' />
                public ULARGE_INTEGER uliChunkSize;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliStreamSize"]/*' />
                public ULARGE_INTEGER uliStreamSize;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliStreamBytesTransferred"]/*' />
                public ULARGE_INTEGER uliStreamBytesTransferred;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliTotalFileSize"]/*' />
                public ULARGE_INTEGER uliTotalFileSize;

                /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliTotalBytesTransferred"]/*' />
                public ULARGE_INTEGER uliTotalBytesTransferred;
            }

            /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct"]/*' />
            public unsafe partial struct _StreamStarted_e__Struct
            {
                /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.dwStreamNumber"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.dwReserved"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwReserved;

                /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.hSourceFile"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hSourceFile;

                /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.hDestinationFile"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hDestinationFile;

                /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.uliStreamSize"]/*' />
                public ULARGE_INTEGER uliStreamSize;

                /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.uliTotalFileSize"]/*' />
                public ULARGE_INTEGER uliTotalFileSize;
            }

            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct"]/*' />
            public unsafe partial struct _StreamFinished_e__Struct
            {
                /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.dwStreamNumber"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.dwReserved"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwReserved;

                /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.hSourceFile"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hSourceFile;

                /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.hDestinationFile"]/*' />
                [NativeTypeName("HANDLE")]
                public void* hDestinationFile;

                /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.uliStreamSize"]/*' />
                public ULARGE_INTEGER uliStreamSize;

                /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.uliStreamBytesTransferred"]/*' />
                public ULARGE_INTEGER uliStreamBytesTransferred;

                /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.uliTotalFileSize"]/*' />
                public ULARGE_INTEGER uliTotalFileSize;

                /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.uliTotalBytesTransferred"]/*' />
                public ULARGE_INTEGER uliTotalBytesTransferred;
            }

            /// <include file='_PollContinue_e__Struct.xml' path='doc/member[@name="_PollContinue_e__Struct"]/*' />
            public partial struct _PollContinue_e__Struct
            {
                /// <include file='_PollContinue_e__Struct.xml' path='doc/member[@name="_PollContinue_e__Struct.dwReserved"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwReserved;
            }

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct"]/*' />
            public partial struct _Error_e__Struct
            {
                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.CopyPhase"]/*' />
                public COPYFILE2_COPY_PHASE CopyPhase;

                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.dwStreamNumber"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwStreamNumber;

                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.hrFailure"]/*' />
                [NativeTypeName("HRESULT")]
                public int hrFailure;

                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.dwReserved"]/*' />
                [NativeTypeName("DWORD")]
                public uint dwReserved;

                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliChunkNumber"]/*' />
                public ULARGE_INTEGER uliChunkNumber;

                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliStreamSize"]/*' />
                public ULARGE_INTEGER uliStreamSize;

                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliStreamBytesTransferred"]/*' />
                public ULARGE_INTEGER uliStreamBytesTransferred;

                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliTotalFileSize"]/*' />
                public ULARGE_INTEGER uliTotalFileSize;

                /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliTotalBytesTransferred"]/*' />
                public ULARGE_INTEGER uliTotalBytesTransferred;
            }
        }
    }
}

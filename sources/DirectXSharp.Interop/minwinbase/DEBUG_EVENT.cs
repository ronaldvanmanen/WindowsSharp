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
    /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT"]/*' />
    public partial struct DEBUG_EVENT
    {
        /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT.dwDebugEventCode"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwDebugEventCode;

        /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT.dwProcessId"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProcessId;

        /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT.dwThreadId"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwThreadId;

        /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT.u"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:365:5)")]
        public _u_e__Union u;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _u_e__Union
        {
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Exception"]/*' />
            [FieldOffset(0)]
            public EXCEPTION_DEBUG_INFO Exception;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.CreateThread"]/*' />
            [FieldOffset(0)]
            public CREATE_THREAD_DEBUG_INFO CreateThread;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.CreateProcessInfo"]/*' />
            [FieldOffset(0)]
            public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.ExitThread"]/*' />
            [FieldOffset(0)]
            public EXIT_THREAD_DEBUG_INFO ExitThread;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.ExitProcess"]/*' />
            [FieldOffset(0)]
            public EXIT_PROCESS_DEBUG_INFO ExitProcess;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.LoadDll"]/*' />
            [FieldOffset(0)]
            public LOAD_DLL_DEBUG_INFO LoadDll;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UnloadDll"]/*' />
            [FieldOffset(0)]
            public UNLOAD_DLL_DEBUG_INFO UnloadDll;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.DebugString"]/*' />
            [FieldOffset(0)]
            public OUTPUT_DEBUG_STRING_INFO DebugString;

            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.RipInfo"]/*' />
            [FieldOffset(0)]
            public RIP_INFO RipInfo;
        }
    }
}

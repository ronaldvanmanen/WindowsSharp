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

namespace WindowsSharp.Interop
{
    /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT"]/*' />
    public unsafe partial struct DISPATCHER_CONTEXT
    {
        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.ControlPc"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong ControlPc;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.ImageBase"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong ImageBase;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.FunctionEntry"]/*' />
        [NativeTypeName("PRUNTIME_FUNCTION")]
        public IMAGE_RUNTIME_FUNCTION_ENTRY* FunctionEntry;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.EstablisherFrame"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong EstablisherFrame;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.TargetIp"]/*' />
        [NativeTypeName("DWORD64")]
        public ulong TargetIp;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.ContextRecord"]/*' />
        [NativeTypeName("PCONTEXT")]
        public CONTEXT* ContextRecord;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.LanguageHandler"]/*' />
        [NativeTypeName("PEXCEPTION_ROUTINE")]
        public delegate* unmanaged<EXCEPTION_RECORD*, void*, CONTEXT*, void*, EXCEPTION_DISPOSITION> LanguageHandler;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.HandlerData"]/*' />
        [NativeTypeName("PVOID")]
        public void* HandlerData;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.HistoryTable"]/*' />
        [NativeTypeName("PUNWIND_HISTORY_TABLE")]
        public UNWIND_HISTORY_TABLE* HistoryTable;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.ScopeIndex"]/*' />
        [NativeTypeName("DWORD")]
        public uint ScopeIndex;

        /// <include file='DISPATCHER_CONTEXT.xml' path='doc/member[@name="DISPATCHER_CONTEXT.Fill0"]/*' />
        [NativeTypeName("DWORD")]
        public uint Fill0;
    }
}

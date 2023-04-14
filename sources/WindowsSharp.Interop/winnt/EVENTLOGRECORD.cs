// This file is part of WindowsSharp
//
// Copyright (C) 2021-2023 Ronald van Manen <rvanmanen@gmail.com>
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
    /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD"]/*' />
    public partial struct EVENTLOGRECORD
    {
        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.Length"]/*' />
        [NativeTypeName("DWORD")]
        public uint Length;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.Reserved"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.RecordNumber"]/*' />
        [NativeTypeName("DWORD")]
        public uint RecordNumber;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.TimeGenerated"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeGenerated;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.TimeWritten"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeWritten;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.EventID"]/*' />
        [NativeTypeName("DWORD")]
        public uint EventID;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.EventType"]/*' />
        [NativeTypeName("WORD")]
        public ushort EventType;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.NumStrings"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumStrings;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.EventCategory"]/*' />
        [NativeTypeName("WORD")]
        public ushort EventCategory;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.ReservedFlags"]/*' />
        [NativeTypeName("WORD")]
        public ushort ReservedFlags;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.ClosingRecordNumber"]/*' />
        [NativeTypeName("DWORD")]
        public uint ClosingRecordNumber;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.StringOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint StringOffset;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.UserSidLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint UserSidLength;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.UserSidOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint UserSidOffset;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.DataLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint DataLength;

        /// <include file='EVENTLOGRECORD.xml' path='doc/member[@name="EVENTLOGRECORD.DataOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint DataOffset;
    }
}

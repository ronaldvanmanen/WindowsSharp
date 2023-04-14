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
    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP"]/*' />
    public unsafe partial struct COMMPROP
    {
        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wPacketLength"]/*' />
        [NativeTypeName("WORD")]
        public ushort wPacketLength;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wPacketVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort wPacketVersion;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwServiceMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwServiceMask;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwReserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwMaxTxQueue"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwMaxTxQueue;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwMaxRxQueue"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwMaxRxQueue;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwMaxBaud"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwMaxBaud;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwProvSubType"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProvSubType;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwProvCapabilities"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProvCapabilities;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwSettableParams"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwSettableParams;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwSettableBaud"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwSettableBaud;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wSettableData"]/*' />
        [NativeTypeName("WORD")]
        public ushort wSettableData;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wSettableStopParity"]/*' />
        [NativeTypeName("WORD")]
        public ushort wSettableStopParity;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwCurrentTxQueue"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwCurrentTxQueue;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwCurrentRxQueue"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwCurrentRxQueue;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwProvSpec1"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProvSpec1;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwProvSpec2"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwProvSpec2;

        /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wcProvChar"]/*' />
        [NativeTypeName("WCHAR [1]")]
        public fixed ushort wcProvChar[1];
    }
}

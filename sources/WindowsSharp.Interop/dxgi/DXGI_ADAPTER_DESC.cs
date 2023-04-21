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
    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC"]/*' />
    public unsafe partial struct DXGI_ADAPTER_DESC
    {
        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.Description"]/*' />
        [NativeTypeName("WCHAR[128]")]
        public fixed ushort Description[128];

        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.VendorId"]/*' />
        public uint VendorId;

        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DeviceId"]/*' />
        public uint DeviceId;

        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.SubSysId"]/*' />
        public uint SubSysId;

        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.Revision"]/*' />
        public uint Revision;

        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DedicatedVideoMemory"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong DedicatedVideoMemory;

        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DedicatedSystemMemory"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong DedicatedSystemMemory;

        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.SharedSystemMemory"]/*' />
        [NativeTypeName("SIZE_T")]
        public ulong SharedSystemMemory;

        /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.AdapterLuid"]/*' />
        public LUID AdapterLuid;
    }
}

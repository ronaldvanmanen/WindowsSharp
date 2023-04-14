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
    /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION"]/*' />
    public unsafe partial struct PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION
    {
        /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.NumberOfRanges"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfRanges;

        /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.Reserved"]/*' />
        [NativeTypeName("WORD")]
        public ushort Reserved;

        /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.Reserved2"]/*' />
        [NativeTypeName("DWORD")]
        public uint Reserved2;

        /// <include file='PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.xml' path='doc/member[@name="PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGES_INFORMATION.Ranges"]/*' />
        [NativeTypeName("PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE")]
        public PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE* Ranges;
    }
}

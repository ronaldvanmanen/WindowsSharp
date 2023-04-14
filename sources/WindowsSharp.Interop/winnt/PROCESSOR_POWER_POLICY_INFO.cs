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

using System.Runtime.CompilerServices;

namespace WindowsSharp.Interop
{
    /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO"]/*' />
    public unsafe partial struct PROCESSOR_POWER_POLICY_INFO
    {
        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.TimeCheck"]/*' />
        [NativeTypeName("DWORD")]
        public uint TimeCheck;

        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.DemoteLimit"]/*' />
        [NativeTypeName("DWORD")]
        public uint DemoteLimit;

        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.PromoteLimit"]/*' />
        [NativeTypeName("DWORD")]
        public uint PromoteLimit;

        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.DemotePercent"]/*' />
        public byte DemotePercent;

        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.PromotePercent"]/*' />
        public byte PromotePercent;

        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.Spare"]/*' />
        [NativeTypeName("BYTE [2]")]
        public fixed byte Spare[2];

        public uint _bitfield;

        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.AllowDemotion"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint AllowDemotion
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

        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.AllowPromotion"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint AllowPromotion
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

        /// <include file='PROCESSOR_POWER_POLICY_INFO.xml' path='doc/member[@name="PROCESSOR_POWER_POLICY_INFO.Reserved"]/*' />
        [NativeTypeName("DWORD : 30")]
        public uint Reserved
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

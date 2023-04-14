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

using System.Runtime.CompilerServices;

namespace WindowsSharp.Interop
{
    /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY"]/*' />
    public partial struct IMAGE_CE_RUNTIME_FUNCTION_ENTRY
    {
        /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.FuncStart"]/*' />
        [NativeTypeName("DWORD")]
        public uint FuncStart;

        public uint _bitfield;

        /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.PrologLen"]/*' />
        [NativeTypeName("DWORD : 8")]
        public uint PrologLen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0xFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu);
            }
        }

        /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.FuncLen"]/*' />
        [NativeTypeName("DWORD : 22")]
        public uint FuncLen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 8) & 0x3FFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFu << 8)) | ((value & 0x3FFFFFu) << 8);
            }
        }

        /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.ThirtyTwoBit"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint ThirtyTwoBit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 30) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 30)) | ((value & 0x1u) << 30);
            }
        }

        /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.ExceptionFlag"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint ExceptionFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 31) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
            }
        }
    }
}

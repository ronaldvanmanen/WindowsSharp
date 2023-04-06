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

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION
    {
        public uint _bitfield;

        /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.PageRelativeOffset"]/*' />
        [NativeTypeName("DWORD : 12")]
        public uint PageRelativeOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0xFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFFu) | (value & 0xFFFu);
            }
        }

        /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.IndirectCall"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint IndirectCall
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 12) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12);
            }
        }

        /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.IATIndex"]/*' />
        [NativeTypeName("DWORD : 19")]
        public uint IATIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 13) & 0x7FFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7FFFFu << 13)) | ((value & 0x7FFFFu) << 13);
            }
        }
    }
}

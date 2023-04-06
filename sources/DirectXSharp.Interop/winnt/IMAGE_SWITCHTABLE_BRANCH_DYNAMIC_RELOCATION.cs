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
    /// <include file='IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION
    {
        public ushort _bitfield;

        /// <include file='IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.PageRelativeOffset"]/*' />
        [NativeTypeName("WORD : 12")]
        public ushort PageRelativeOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)(_bitfield & 0xFFFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~0xFFFu) | (value & 0xFFFu));
            }
        }

        /// <include file='IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.RegisterNumber"]/*' />
        [NativeTypeName("WORD : 4")]
        public ushort RegisterNumber
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (ushort)((_bitfield >> 12) & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0xFu << 12)) | ((value & 0xFu) << 12));
            }
        }
    }
}

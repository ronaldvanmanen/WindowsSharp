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
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE"]/*' />
    public enum D3D11_BUS_TYPE
    {
        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_OTHER"]/*' />
        D3D11_BUS_TYPE_OTHER = 0,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_PCI"]/*' />
        D3D11_BUS_TYPE_PCI = 0x1,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_PCIX"]/*' />
        D3D11_BUS_TYPE_PCIX = 0x2,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_PCIEXPRESS"]/*' />
        D3D11_BUS_TYPE_PCIEXPRESS = 0x3,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_AGP"]/*' />
        D3D11_BUS_TYPE_AGP = 0x4,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET"]/*' />
        D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET = 0x10000,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP"]/*' />
        D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 0x20000,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET"]/*' />
        D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 0x30000,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR"]/*' />
        D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 0x40000,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE"]/*' />
        D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 0x50000,

        /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_NON_STANDARD"]/*' />
        D3D11_BUS_IMPL_MODIFIER_NON_STANDARD = unchecked((int)(0x80000000)),
    }
}

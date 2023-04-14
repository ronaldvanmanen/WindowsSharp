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
    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE"]/*' />
    public enum D3DBUSTYPE
    {
        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_OTHER"]/*' />
        D3DBUSTYPE_OTHER = 0x00000000,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCI"]/*' />
        D3DBUSTYPE_PCI = 0x00000001,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCIX"]/*' />
        D3DBUSTYPE_PCIX = 0x00000002,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCIEXPRESS"]/*' />
        D3DBUSTYPE_PCIEXPRESS = 0x00000003,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_AGP"]/*' />
        D3DBUSTYPE_AGP = 0x00000004,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_INSIDE_OF_CHIPSET"]/*' />
        D3DBUSIMPL_MODIFIER_INSIDE_OF_CHIPSET = 0x00010000,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP"]/*' />
        D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 0x00020000,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET"]/*' />
        D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 0x00030000,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR"]/*' />
        D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 0x00040000,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE"]/*' />
        D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 0x00050000,

        /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_NON_STANDARD"]/*' />
        D3DBUSIMPL_MODIFIER_NON_STANDARD = unchecked((int)(0x80000000)),
    }
}

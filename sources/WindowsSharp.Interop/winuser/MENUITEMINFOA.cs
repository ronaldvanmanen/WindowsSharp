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
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA"]/*' />
    public unsafe partial struct MENUITEMINFOA
    {
        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.cbSize"]/*' />
        public uint cbSize;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.fMask"]/*' />
        public uint fMask;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.fType"]/*' />
        public uint fType;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.fState"]/*' />
        public uint fState;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.wID"]/*' />
        public uint wID;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.hSubMenu"]/*' />
        [NativeTypeName("HMENU")]
        public HMENU__* hSubMenu;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.hbmpChecked"]/*' />
        [NativeTypeName("HBITMAP")]
        public HBITMAP__* hbmpChecked;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.hbmpUnchecked"]/*' />
        [NativeTypeName("HBITMAP")]
        public HBITMAP__* hbmpUnchecked;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.dwItemData"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong dwItemData;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.dwTypeData"]/*' />
        [NativeTypeName("LPSTR")]
        public sbyte* dwTypeData;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.cch"]/*' />
        public uint cch;

        /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.hbmpItem"]/*' />
        [NativeTypeName("HBITMAP")]
        public HBITMAP__* hbmpItem;
    }
}

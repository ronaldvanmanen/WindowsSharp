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
    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT"]/*' />
    public unsafe partial struct COMPAREITEMSTRUCT
    {
        /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.CtlType"]/*' />
        public uint CtlType;

        /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.CtlID"]/*' />
        public uint CtlID;

        /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.hwndItem"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndItem;

        /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.itemID1"]/*' />
        public uint itemID1;

        /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.itemData1"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong itemData1;

        /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.itemID2"]/*' />
        public uint itemID2;

        /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.itemData2"]/*' />
        [NativeTypeName("ULONG_PTR")]
        public ulong itemData2;

        /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.dwLocaleId"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwLocaleId;
    }
}

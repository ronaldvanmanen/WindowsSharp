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
    /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO"]/*' />
    public unsafe partial struct COMBOBOXINFO
    {
        /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.cbSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbSize;

        /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.rcItem"]/*' />
        public RECT rcItem;

        /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.rcButton"]/*' />
        public RECT rcButton;

        /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.stateButton"]/*' />
        [NativeTypeName("DWORD")]
        public uint stateButton;

        /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.hwndCombo"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndCombo;

        /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.hwndItem"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndItem;

        /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.hwndList"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndList;
    }
}

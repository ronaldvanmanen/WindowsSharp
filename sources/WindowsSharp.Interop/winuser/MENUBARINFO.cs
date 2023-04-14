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
    /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO"]/*' />
    public unsafe partial struct MENUBARINFO
    {
        /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.cbSize"]/*' />
        [NativeTypeName("DWORD")]
        public uint cbSize;

        /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.rcBar"]/*' />
        public RECT rcBar;

        /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.hMenu"]/*' />
        [NativeTypeName("HMENU")]
        public HMENU__* hMenu;

        /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.hwndMenu"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hwndMenu;

        public int _bitfield;

        /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.fBarFocused"]/*' />
        [NativeTypeName("BOOL : 1")]
        public int fBarFocused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1) | (value & 0x1);
            }
        }

        /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.fFocused"]/*' />
        [NativeTypeName("BOOL : 1")]
        public int fFocused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 1)) | ((value & 0x1) << 1);
            }
        }

        /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.fUnused"]/*' />
        [NativeTypeName("BOOL : 30")]
        public int fUnused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 2) & 0x3FFFFFFF;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFF << 2)) | ((value & 0x3FFFFFFF) << 2);
            }
        }
    }
}

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
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW"]/*' />
    public unsafe partial struct SOUNDSENTRYW
    {
        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.cbSize"]/*' />
        public uint cbSize;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSTextEffect"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSTextEffect;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSTextEffectMSec"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSTextEffectMSec;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSTextEffectColorBits"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSTextEffectColorBits;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSGrafEffect"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSGrafEffect;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSGrafEffectMSec"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectMSec;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSGrafEffectColor"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectColor;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iWindowsEffect"]/*' />
        [NativeTypeName("DWORD")]
        public uint iWindowsEffect;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iWindowsEffectMSec"]/*' />
        [NativeTypeName("DWORD")]
        public uint iWindowsEffectMSec;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.lpszWindowsEffectDLL"]/*' />
        [NativeTypeName("LPWSTR")]
        public ushort* lpszWindowsEffectDLL;

        /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iWindowsEffectOrdinal"]/*' />
        [NativeTypeName("DWORD")]
        public uint iWindowsEffectOrdinal;
    }
}

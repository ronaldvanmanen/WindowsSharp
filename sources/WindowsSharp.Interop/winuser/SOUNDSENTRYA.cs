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
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA"]/*' />
    public unsafe partial struct SOUNDSENTRYA
    {
        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.cbSize"]/*' />
        public uint cbSize;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSTextEffect"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSTextEffect;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSTextEffectMSec"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSTextEffectMSec;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSTextEffectColorBits"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSTextEffectColorBits;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSGrafEffect"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSGrafEffect;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSGrafEffectMSec"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectMSec;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSGrafEffectColor"]/*' />
        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectColor;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iWindowsEffect"]/*' />
        [NativeTypeName("DWORD")]
        public uint iWindowsEffect;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iWindowsEffectMSec"]/*' />
        [NativeTypeName("DWORD")]
        public uint iWindowsEffectMSec;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.lpszWindowsEffectDLL"]/*' />
        [NativeTypeName("LPSTR")]
        public sbyte* lpszWindowsEffectDLL;

        /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iWindowsEffectOrdinal"]/*' />
        [NativeTypeName("DWORD")]
        public uint iWindowsEffectOrdinal;
    }
}

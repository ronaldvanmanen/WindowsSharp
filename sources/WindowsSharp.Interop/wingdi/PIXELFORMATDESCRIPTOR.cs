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
    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR"]/*' />
    public partial struct PIXELFORMATDESCRIPTOR
    {
        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.nSize"]/*' />
        [NativeTypeName("WORD")]
        public ushort nSize;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.nVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort nVersion;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.iPixelType"]/*' />
        public byte iPixelType;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cColorBits"]/*' />
        public byte cColorBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cRedBits"]/*' />
        public byte cRedBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cRedShift"]/*' />
        public byte cRedShift;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cGreenBits"]/*' />
        public byte cGreenBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cGreenShift"]/*' />
        public byte cGreenShift;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cBlueBits"]/*' />
        public byte cBlueBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cBlueShift"]/*' />
        public byte cBlueShift;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAlphaBits"]/*' />
        public byte cAlphaBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAlphaShift"]/*' />
        public byte cAlphaShift;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumBits"]/*' />
        public byte cAccumBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumRedBits"]/*' />
        public byte cAccumRedBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumGreenBits"]/*' />
        public byte cAccumGreenBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumBlueBits"]/*' />
        public byte cAccumBlueBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumAlphaBits"]/*' />
        public byte cAccumAlphaBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cDepthBits"]/*' />
        public byte cDepthBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cStencilBits"]/*' />
        public byte cStencilBits;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAuxBuffers"]/*' />
        public byte cAuxBuffers;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.iLayerType"]/*' />
        public byte iLayerType;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.bReserved"]/*' />
        public byte bReserved;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.dwLayerMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwLayerMask;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.dwVisibleMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwVisibleMask;

        /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.dwDamageMask"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwDamageMask;
    }
}

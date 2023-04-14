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
    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR"]/*' />
    public partial struct LAYERPLANEDESCRIPTOR
    {
        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.nSize"]/*' />
        [NativeTypeName("WORD")]
        public ushort nSize;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.nVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort nVersion;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.iPixelType"]/*' />
        public byte iPixelType;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cColorBits"]/*' />
        public byte cColorBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cRedBits"]/*' />
        public byte cRedBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cRedShift"]/*' />
        public byte cRedShift;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cGreenBits"]/*' />
        public byte cGreenBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cGreenShift"]/*' />
        public byte cGreenShift;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cBlueBits"]/*' />
        public byte cBlueBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cBlueShift"]/*' />
        public byte cBlueShift;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAlphaBits"]/*' />
        public byte cAlphaBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAlphaShift"]/*' />
        public byte cAlphaShift;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumBits"]/*' />
        public byte cAccumBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumRedBits"]/*' />
        public byte cAccumRedBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumGreenBits"]/*' />
        public byte cAccumGreenBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumBlueBits"]/*' />
        public byte cAccumBlueBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumAlphaBits"]/*' />
        public byte cAccumAlphaBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cDepthBits"]/*' />
        public byte cDepthBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cStencilBits"]/*' />
        public byte cStencilBits;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAuxBuffers"]/*' />
        public byte cAuxBuffers;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.iLayerPlane"]/*' />
        public byte iLayerPlane;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.bReserved"]/*' />
        public byte bReserved;

        /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.crTransparent"]/*' />
        [NativeTypeName("COLORREF")]
        public uint crTransparent;
    }
}

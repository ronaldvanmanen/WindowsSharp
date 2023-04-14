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
    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS"]/*' />
    public unsafe partial struct D3DPRESENT_PARAMETERS
    {
        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferWidth"]/*' />
        public uint BackBufferWidth;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferHeight"]/*' />
        public uint BackBufferHeight;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferFormat"]/*' />
        public D3DFORMAT BackBufferFormat;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferCount"]/*' />
        public uint BackBufferCount;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.MultiSampleType"]/*' />
        public D3DMULTISAMPLE_TYPE MultiSampleType;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.MultiSampleQuality"]/*' />
        [NativeTypeName("DWORD")]
        public uint MultiSampleQuality;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.SwapEffect"]/*' />
        public D3DSWAPEFFECT SwapEffect;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.hDeviceWindow"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* hDeviceWindow;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.Windowed"]/*' />
        [NativeTypeName("BOOL")]
        public int Windowed;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.EnableAutoDepthStencil"]/*' />
        [NativeTypeName("BOOL")]
        public int EnableAutoDepthStencil;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.AutoDepthStencilFormat"]/*' />
        public D3DFORMAT AutoDepthStencilFormat;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.FullScreen_RefreshRateInHz"]/*' />
        public uint FullScreen_RefreshRateInHz;

        /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.PresentationInterval"]/*' />
        public uint PresentationInterval;
    }
}

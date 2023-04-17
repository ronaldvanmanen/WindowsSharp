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
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG"]/*' />
    public enum DXGI_SWAP_CHAIN_FLAG
    {
        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_NONPREROTATED"]/*' />
        DXGI_SWAP_CHAIN_FLAG_NONPREROTATED = 1,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH"]/*' />
        DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH = 2,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE"]/*' />
        DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE = 4,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT"]/*' />
        DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT = 8,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER"]/*' />
        DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER = 16,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY"]/*' />
        DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY = 32,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT"]/*' />
        DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT = 64,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER"]/*' />
        DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER = 128,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO"]/*' />
        DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO = 256,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO"]/*' />
        DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO = 512,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED"]/*' />
        DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED = 1024,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING"]/*' />
        DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING = 2048,

        /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS"]/*' />
        DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS = 4096,
    }
}

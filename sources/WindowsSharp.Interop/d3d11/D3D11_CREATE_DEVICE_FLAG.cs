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
    /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG"]/*' />
    public enum D3D11_CREATE_DEVICE_FLAG
    {
        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_SINGLETHREADED"]/*' />
        D3D11_CREATE_DEVICE_SINGLETHREADED = 0x1,

        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG"]/*' />
        D3D11_CREATE_DEVICE_DEBUG = 0x2,

        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_SWITCH_TO_REF"]/*' />
        D3D11_CREATE_DEVICE_SWITCH_TO_REF = 0x4,

        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS"]/*' />
        D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS = 0x8,

        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT"]/*' />
        D3D11_CREATE_DEVICE_BGRA_SUPPORT = 0x20,

        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUGGABLE"]/*' />
        D3D11_CREATE_DEVICE_DEBUGGABLE = 0x40,

        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY"]/*' />
        D3D11_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY = 0x80,

        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT"]/*' />
        D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT = 0x100,

        /// <include file='D3D11_CREATE_DEVICE_FLAG.xml' path='doc/member[@name="D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_VIDEO_SUPPORT"]/*' />
        D3D11_CREATE_DEVICE_VIDEO_SUPPORT = 0x800,
    }
}

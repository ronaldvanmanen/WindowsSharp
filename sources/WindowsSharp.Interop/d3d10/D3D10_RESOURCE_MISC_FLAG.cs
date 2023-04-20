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
    /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG"]/*' />
    public enum D3D10_RESOURCE_MISC_FLAG
    {
        /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_GENERATE_MIPS"]/*' />
        D3D10_RESOURCE_MISC_GENERATE_MIPS = 0x1,

        /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_SHARED"]/*' />
        D3D10_RESOURCE_MISC_SHARED = 0x2,

        /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_TEXTURECUBE"]/*' />
        D3D10_RESOURCE_MISC_TEXTURECUBE = 0x4,

        /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX"]/*' />
        D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX = 0x10,

        /// <include file='D3D10_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D10_RESOURCE_MISC_FLAG.D3D10_RESOURCE_MISC_GDI_COMPATIBLE"]/*' />
        D3D10_RESOURCE_MISC_GDI_COMPATIBLE = 0x20,
    }
}

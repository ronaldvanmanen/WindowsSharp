// DirectXSharp
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

namespace DirectXSharp.Interop
{
    /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION"]/*' />
    public enum DISPLAYCONFIG_ROTATION
    {
        /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_IDENTITY"]/*' />
        DISPLAYCONFIG_ROTATION_IDENTITY = 1,

        /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_ROTATE90"]/*' />
        DISPLAYCONFIG_ROTATION_ROTATE90 = 2,

        /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_ROTATE180"]/*' />
        DISPLAYCONFIG_ROTATION_ROTATE180 = 3,

        /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_ROTATE270"]/*' />
        DISPLAYCONFIG_ROTATION_ROTATE270 = 4,

        /// <include file='DISPLAYCONFIG_ROTATION.xml' path='doc/member[@name="DISPLAYCONFIG_ROTATION.DISPLAYCONFIG_ROTATION_FORCE_UINT32"]/*' />
        DISPLAYCONFIG_ROTATION_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }
}

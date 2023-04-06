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
    /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING"]/*' />
    public enum DISPLAYCONFIG_SCANLINE_ORDERING
    {
        /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED"]/*' />
        DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED = 0,

        /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE"]/*' />
        DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE = 1,

        /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED"]/*' />
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED = 2,

        /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST"]/*' />
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST = DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED,

        /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST"]/*' />
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST = 3,

        /// <include file='DISPLAYCONFIG_SCANLINE_ORDERING.xml' path='doc/member[@name="DISPLAYCONFIG_SCANLINE_ORDERING.DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32"]/*' />
        DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }
}

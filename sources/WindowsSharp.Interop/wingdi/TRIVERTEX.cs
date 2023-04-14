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
    /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX"]/*' />
    public partial struct TRIVERTEX
    {
        /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.x"]/*' />
        [NativeTypeName("LONG")]
        public int x;

        /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.y"]/*' />
        [NativeTypeName("LONG")]
        public int y;

        /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.Red"]/*' />
        [NativeTypeName("COLOR16")]
        public ushort Red;

        /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.Green"]/*' />
        [NativeTypeName("COLOR16")]
        public ushort Green;

        /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.Blue"]/*' />
        [NativeTypeName("COLOR16")]
        public ushort Blue;

        /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.Alpha"]/*' />
        [NativeTypeName("COLOR16")]
        public ushort Alpha;
    }
}

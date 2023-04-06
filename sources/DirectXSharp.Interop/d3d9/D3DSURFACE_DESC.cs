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
    /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC"]/*' />
    public partial struct D3DSURFACE_DESC
    {
        /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC.Format"]/*' />
        public D3DFORMAT Format;

        /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC.Type"]/*' />
        public D3DRESOURCETYPE Type;

        /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC.Usage"]/*' />
        [NativeTypeName("DWORD")]
        public uint Usage;

        /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC.Pool"]/*' />
        public D3DPOOL Pool;

        /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC.MultiSampleType"]/*' />
        public D3DMULTISAMPLE_TYPE MultiSampleType;

        /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC.MultiSampleQuality"]/*' />
        [NativeTypeName("DWORD")]
        public uint MultiSampleQuality;

        /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC.Width"]/*' />
        public uint Width;

        /// <include file='D3DSURFACE_DESC.xml' path='doc/member[@name="D3DSURFACE_DESC.Height"]/*' />
        public uint Height;
    }
}
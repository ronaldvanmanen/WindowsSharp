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
    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9"]/*' />
    public partial struct D3DLIGHT9
    {
        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Type"]/*' />
        public D3DLIGHTTYPE Type;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Diffuse"]/*' />
        public D3DCOLORVALUE Diffuse;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Specular"]/*' />
        public D3DCOLORVALUE Specular;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Ambient"]/*' />
        public D3DCOLORVALUE Ambient;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Position"]/*' />
        public D3DVECTOR Position;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Direction"]/*' />
        public D3DVECTOR Direction;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Range"]/*' />
        public float Range;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Falloff"]/*' />
        public float Falloff;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Attenuation0"]/*' />
        public float Attenuation0;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Attenuation1"]/*' />
        public float Attenuation1;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Attenuation2"]/*' />
        public float Attenuation2;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Theta"]/*' />
        public float Theta;

        /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Phi"]/*' />
        public float Phi;
    }
}

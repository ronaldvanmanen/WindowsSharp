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
    /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC"]/*' />
    public partial struct EMRANGLEARC
    {
        /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.emr"]/*' />
        public EMR emr;

        /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.ptlCenter"]/*' />
        public POINTL ptlCenter;

        /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.nRadius"]/*' />
        [NativeTypeName("DWORD")]
        public uint nRadius;

        /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.eStartAngle"]/*' />
        public float eStartAngle;

        /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.eSweepAngle"]/*' />
        public float eSweepAngle;
    }
}

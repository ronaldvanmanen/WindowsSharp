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
    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT"]/*' />
    public unsafe partial struct SCRUB_DATA_INPUT
    {
        /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Size"]/*' />
        [NativeTypeName("DWORD")]
        public uint Size;

        /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Flags"]/*' />
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.MaximumIos"]/*' />
        [NativeTypeName("DWORD")]
        public uint MaximumIos;

        /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.ObjectId"]/*' />
        [NativeTypeName("DWORD [4]")]
        public fixed uint ObjectId[4];

        /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Reserved"]/*' />
        [NativeTypeName("DWORD [25]")]
        public fixed uint Reserved[25];

        /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.ResumeContext"]/*' />
        [NativeTypeName("BYTE [816]")]
        public fixed byte ResumeContext[816];
    }
}

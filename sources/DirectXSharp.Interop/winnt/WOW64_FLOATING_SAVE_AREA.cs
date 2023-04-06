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
    /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA"]/*' />
    public unsafe partial struct WOW64_FLOATING_SAVE_AREA
    {
        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.ControlWord"]/*' />
        [NativeTypeName("DWORD")]
        public uint ControlWord;

        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.StatusWord"]/*' />
        [NativeTypeName("DWORD")]
        public uint StatusWord;

        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.TagWord"]/*' />
        [NativeTypeName("DWORD")]
        public uint TagWord;

        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.ErrorOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint ErrorOffset;

        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.ErrorSelector"]/*' />
        [NativeTypeName("DWORD")]
        public uint ErrorSelector;

        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.DataOffset"]/*' />
        [NativeTypeName("DWORD")]
        public uint DataOffset;

        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.DataSelector"]/*' />
        [NativeTypeName("DWORD")]
        public uint DataSelector;

        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.RegisterArea"]/*' />
        [NativeTypeName("BYTE [80]")]
        public fixed byte RegisterArea[80];

        /// <include file='WOW64_FLOATING_SAVE_AREA.xml' path='doc/member[@name="WOW64_FLOATING_SAVE_AREA.Cr0NpxState"]/*' />
        [NativeTypeName("DWORD")]
        public uint Cr0NpxState;
    }
}

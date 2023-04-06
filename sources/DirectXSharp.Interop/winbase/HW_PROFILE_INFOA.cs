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
    /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA"]/*' />
    public unsafe partial struct HW_PROFILE_INFOA
    {
        /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.dwDockInfo"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwDockInfo;

        /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.szHwProfileGuid"]/*' />
        [NativeTypeName("CHAR [39]")]
        public fixed sbyte szHwProfileGuid[39];

        /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.szHwProfileName"]/*' />
        [NativeTypeName("CHAR [80]")]
        public fixed sbyte szHwProfileName[80];
    }
}

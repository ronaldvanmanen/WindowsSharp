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
    /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES"]/*' />
    public enum RPCOPT_PROPERTIES
    {
        /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RPCTIMEOUT"]/*' />
        COMBND_RPCTIMEOUT = 0x1,

        /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_SERVER_LOCALITY"]/*' />
        COMBND_SERVER_LOCALITY = 0x2,

        /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RESERVED1"]/*' />
        COMBND_RESERVED1 = 0x4,

        /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RESERVED2"]/*' />
        COMBND_RESERVED2 = 0x5,

        /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RESERVED3"]/*' />
        COMBND_RESERVED3 = 0x8,

        /// <include file='RPCOPT_PROPERTIES.xml' path='doc/member[@name="RPCOPT_PROPERTIES.COMBND_RESERVED4"]/*' />
        COMBND_RESERVED4 = 0x10,
    }
}

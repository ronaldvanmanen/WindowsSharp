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
    /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY"]/*' />
    public partial struct ADMINISTRATOR_POWER_POLICY
    {
        /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MinSleep"]/*' />
        public SYSTEM_POWER_STATE MinSleep;

        /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MaxSleep"]/*' />
        public SYSTEM_POWER_STATE MaxSleep;

        /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MinVideoTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint MinVideoTimeout;

        /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MaxVideoTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint MaxVideoTimeout;

        /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MinSpindownTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint MinSpindownTimeout;

        /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MaxSpindownTimeout"]/*' />
        [NativeTypeName("DWORD")]
        public uint MaxSpindownTimeout;
    }
}

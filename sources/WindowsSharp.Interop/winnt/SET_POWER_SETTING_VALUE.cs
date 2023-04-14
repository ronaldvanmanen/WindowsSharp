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

using System;

namespace WindowsSharp.Interop
{
    /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE"]/*' />
    public unsafe partial struct SET_POWER_SETTING_VALUE
    {
        /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.Version"]/*' />
        [NativeTypeName("DWORD")]
        public uint Version;

        /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.Guid"]/*' />
        public Guid Guid;

        /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.PowerCondition"]/*' />
        public SYSTEM_POWER_CONDITION PowerCondition;

        /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.DataLength"]/*' />
        [NativeTypeName("DWORD")]
        public uint DataLength;

        /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.Data"]/*' />
        [NativeTypeName("BYTE [1]")]
        public fixed byte Data[1];
    }
}

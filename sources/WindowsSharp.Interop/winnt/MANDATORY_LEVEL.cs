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
    /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL"]/*' />
    public enum MANDATORY_LEVEL
    {
        /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelUntrusted"]/*' />
        MandatoryLevelUntrusted = 0,

        /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelLow"]/*' />
        MandatoryLevelLow,

        /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelMedium"]/*' />
        MandatoryLevelMedium,

        /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelHigh"]/*' />
        MandatoryLevelHigh,

        /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelSystem"]/*' />
        MandatoryLevelSystem,

        /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelSecureProcess"]/*' />
        MandatoryLevelSecureProcess,

        /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelCount"]/*' />
        MandatoryLevelCount,
    }
}

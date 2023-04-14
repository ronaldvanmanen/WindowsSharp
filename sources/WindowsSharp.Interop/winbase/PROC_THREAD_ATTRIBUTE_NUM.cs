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
    /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM"]/*' />
    public enum PROC_THREAD_ATTRIBUTE_NUM
    {
        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeParentProcess"]/*' />
        ProcThreadAttributeParentProcess = 0,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeHandleList"]/*' />
        ProcThreadAttributeHandleList = 2,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeGroupAffinity"]/*' />
        ProcThreadAttributeGroupAffinity = 3,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributePreferredNode"]/*' />
        ProcThreadAttributePreferredNode = 4,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeIdealProcessor"]/*' />
        ProcThreadAttributeIdealProcessor = 5,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeUmsThread"]/*' />
        ProcThreadAttributeUmsThread = 6,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeMitigationPolicy"]/*' />
        ProcThreadAttributeMitigationPolicy = 7,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeSecurityCapabilities"]/*' />
        ProcThreadAttributeSecurityCapabilities = 9,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeProtectionLevel"]/*' />
        ProcThreadAttributeProtectionLevel = 11,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeJobList"]/*' />
        ProcThreadAttributeJobList = 13,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeChildProcessPolicy"]/*' />
        ProcThreadAttributeChildProcessPolicy = 14,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeAllApplicationPackagesPolicy"]/*' />
        ProcThreadAttributeAllApplicationPackagesPolicy = 15,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeWin32kFilter"]/*' />
        ProcThreadAttributeWin32kFilter = 16,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeSafeOpenPromptOriginClaim"]/*' />
        ProcThreadAttributeSafeOpenPromptOriginClaim = 17,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeDesktopAppPolicy"]/*' />
        ProcThreadAttributeDesktopAppPolicy = 18,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributePseudoConsole"]/*' />
        ProcThreadAttributePseudoConsole = 22,

        /// <include file='PROC_THREAD_ATTRIBUTE_NUM.xml' path='doc/member[@name="PROC_THREAD_ATTRIBUTE_NUM.ProcThreadAttributeMitigationAuditPolicy"]/*' />
        ProcThreadAttributeMitigationAuditPolicy = 24,
    }
}

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
    /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY"]/*' />
    public enum PROCESS_MITIGATION_POLICY
    {
        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessDEPPolicy"]/*' />
        ProcessDEPPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessASLRPolicy"]/*' />
        ProcessASLRPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessDynamicCodePolicy"]/*' />
        ProcessDynamicCodePolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessStrictHandleCheckPolicy"]/*' />
        ProcessStrictHandleCheckPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSystemCallDisablePolicy"]/*' />
        ProcessSystemCallDisablePolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessMitigationOptionsMask"]/*' />
        ProcessMitigationOptionsMask,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessExtensionPointDisablePolicy"]/*' />
        ProcessExtensionPointDisablePolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessControlFlowGuardPolicy"]/*' />
        ProcessControlFlowGuardPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSignaturePolicy"]/*' />
        ProcessSignaturePolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessFontDisablePolicy"]/*' />
        ProcessFontDisablePolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessImageLoadPolicy"]/*' />
        ProcessImageLoadPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSystemCallFilterPolicy"]/*' />
        ProcessSystemCallFilterPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessPayloadRestrictionPolicy"]/*' />
        ProcessPayloadRestrictionPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessChildProcessPolicy"]/*' />
        ProcessChildProcessPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessSideChannelIsolationPolicy"]/*' />
        ProcessSideChannelIsolationPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.ProcessUserShadowStackPolicy"]/*' />
        ProcessUserShadowStackPolicy,

        /// <include file='PROCESS_MITIGATION_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_POLICY.MaxProcessMitigationPolicy"]/*' />
        MaxProcessMitigationPolicy,
    }
}

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
    /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON"]/*' />
    public enum POWER_MONITOR_REQUEST_REASON
    {
        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUnknown"]/*' />
        MonitorRequestReasonUnknown,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPowerButton"]/*' />
        MonitorRequestReasonPowerButton,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonRemoteConnection"]/*' />
        MonitorRequestReasonRemoteConnection,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonScMonitorpower"]/*' />
        MonitorRequestReasonScMonitorpower,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInput"]/*' />
        MonitorRequestReasonUserInput,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonAcDcDisplayBurst"]/*' />
        MonitorRequestReasonAcDcDisplayBurst,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserDisplayBurst"]/*' />
        MonitorRequestReasonUserDisplayBurst,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPoSetSystemState"]/*' />
        MonitorRequestReasonPoSetSystemState,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonSetThreadExecutionState"]/*' />
        MonitorRequestReasonSetThreadExecutionState,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonFullWake"]/*' />
        MonitorRequestReasonFullWake,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonSessionUnlock"]/*' />
        MonitorRequestReasonSessionUnlock,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonScreenOffRequest"]/*' />
        MonitorRequestReasonScreenOffRequest,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonIdleTimeout"]/*' />
        MonitorRequestReasonIdleTimeout,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPolicyChange"]/*' />
        MonitorRequestReasonPolicyChange,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonSleepButton"]/*' />
        MonitorRequestReasonSleepButton,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonLid"]/*' />
        MonitorRequestReasonLid,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonBatteryCountChange"]/*' />
        MonitorRequestReasonBatteryCountChange,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonGracePeriod"]/*' />
        MonitorRequestReasonGracePeriod,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPnP"]/*' />
        MonitorRequestReasonPnP,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonDP"]/*' />
        MonitorRequestReasonDP,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonSxTransition"]/*' />
        MonitorRequestReasonSxTransition,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonSystemIdle"]/*' />
        MonitorRequestReasonSystemIdle,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonNearProximity"]/*' />
        MonitorRequestReasonNearProximity,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonThermalStandby"]/*' />
        MonitorRequestReasonThermalStandby,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonResumePdc"]/*' />
        MonitorRequestReasonResumePdc,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonResumeS4"]/*' />
        MonitorRequestReasonResumeS4,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonTerminal"]/*' />
        MonitorRequestReasonTerminal,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPdcSignal"]/*' />
        MonitorRequestReasonPdcSignal,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonAcDcDisplayBurstSuppressed"]/*' />
        MonitorRequestReasonAcDcDisplayBurstSuppressed,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonSystemStateEntered"]/*' />
        MonitorRequestReasonSystemStateEntered,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonWinrt"]/*' />
        MonitorRequestReasonWinrt,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputKeyboard"]/*' />
        MonitorRequestReasonUserInputKeyboard,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputMouse"]/*' />
        MonitorRequestReasonUserInputMouse,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputTouch"]/*' />
        MonitorRequestReasonUserInputTouch,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputPen"]/*' />
        MonitorRequestReasonUserInputPen,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputAccelerometer"]/*' />
        MonitorRequestReasonUserInputAccelerometer,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputHid"]/*' />
        MonitorRequestReasonUserInputHid,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputPoUserPresent"]/*' />
        MonitorRequestReasonUserInputPoUserPresent,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputSessionSwitch"]/*' />
        MonitorRequestReasonUserInputSessionSwitch,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonUserInputInitialization"]/*' />
        MonitorRequestReasonUserInputInitialization,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPdcSignalWindowsMobilePwrNotif"]/*' />
        MonitorRequestReasonPdcSignalWindowsMobilePwrNotif,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPdcSignalWindowsMobileShell"]/*' />
        MonitorRequestReasonPdcSignalWindowsMobileShell,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPdcSignalHeyCortana"]/*' />
        MonitorRequestReasonPdcSignalHeyCortana,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPdcSignalHolographicShell"]/*' />
        MonitorRequestReasonPdcSignalHolographicShell,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonPdcSignalFingerprint"]/*' />
        MonitorRequestReasonPdcSignalFingerprint,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonDirectedDrips"]/*' />
        MonitorRequestReasonDirectedDrips,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonDim"]/*' />
        MonitorRequestReasonDim,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonBuiltinPanel"]/*' />
        MonitorRequestReasonBuiltinPanel,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonDisplayRequiredUnDim"]/*' />
        MonitorRequestReasonDisplayRequiredUnDim,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonBatteryCountChangeSuppressed"]/*' />
        MonitorRequestReasonBatteryCountChangeSuppressed,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonResumeModernStandby"]/*' />
        MonitorRequestReasonResumeModernStandby,

        /// <include file='POWER_MONITOR_REQUEST_REASON.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_REASON.MonitorRequestReasonMax"]/*' />
        MonitorRequestReasonMax,
    }
}

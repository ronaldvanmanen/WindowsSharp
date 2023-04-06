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

using System;
using System.Runtime.InteropServices;
using static DirectXSharp.Interop.PROC_THREAD_ATTRIBUTE_NUM;
using static DirectXSharp.Interop.SECURITY_IMPERSONATION_LEVEL;

namespace DirectXSharp.Interop
{
    public static unsafe partial class NativeMethods
    {
        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WinMain"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int WinMain([NativeTypeName("HINSTANCE")] HINSTANCE__* hInstance, [NativeTypeName("HINSTANCE")] HINSTANCE__* hPrevInstance, [NativeTypeName("LPSTR")] sbyte* lpCmdLine, int nShowCmd);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.wWinMain"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int wWinMain([NativeTypeName("HINSTANCE")] HINSTANCE__* hInstance, [NativeTypeName("HINSTANCE")] HINSTANCE__* hPrevInstance, [NativeTypeName("LPWSTR")] ushort* lpCmdLine, int nShowCmd);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalAlloc"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern void* GlobalAlloc(uint uFlags, [NativeTypeName("SIZE_T")] ulong dwBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalReAlloc"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern void* GlobalReAlloc([NativeTypeName("HGLOBAL")] void* hMem, [NativeTypeName("SIZE_T")] ulong dwBytes, uint uFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalSize"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern ulong GlobalSize([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalUnlock"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GlobalUnlock([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalLock"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* GlobalLock([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalFlags"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GlobalFlags([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalHandle"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern void* GlobalHandle([NativeTypeName("LPCVOID")] void* pMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalFree"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern void* GlobalFree([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalCompact"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern ulong GlobalCompact([NativeTypeName("DWORD")] uint dwMinFree);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalFix"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void GlobalFix([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalUnfix"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void GlobalUnfix([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalWire"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* GlobalWire([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalUnWire"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GlobalUnWire([NativeTypeName("HGLOBAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalMemoryStatus"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void GlobalMemoryStatus([NativeTypeName("LPMEMORYSTATUS")] MEMORYSTATUS* lpBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalAlloc"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern void* LocalAlloc(uint uFlags, [NativeTypeName("SIZE_T")] ulong uBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalReAlloc"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern void* LocalReAlloc([NativeTypeName("HLOCAL")] void* hMem, [NativeTypeName("SIZE_T")] ulong uBytes, uint uFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalLock"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* LocalLock([NativeTypeName("HLOCAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalHandle"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern void* LocalHandle([NativeTypeName("LPCVOID")] void* pMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalUnlock"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LocalUnlock([NativeTypeName("HLOCAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalSize"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern ulong LocalSize([NativeTypeName("HLOCAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalFlags"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint LocalFlags([NativeTypeName("HLOCAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalFree"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern void* LocalFree([NativeTypeName("HLOCAL")] void* hMem);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalShrink"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern ulong LocalShrink([NativeTypeName("HLOCAL")] void* hMem, uint cbNewSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalCompact"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern ulong LocalCompact(uint uMinFree);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetBinaryTypeA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBinaryTypeA([NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPDWORD")] uint* lpBinaryType);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetBinaryTypeW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBinaryTypeW([NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPDWORD")] uint* lpBinaryType);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetShortPathNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetShortPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszLongPath, [NativeTypeName("LPSTR")] sbyte* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetLongPathNameTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameTransactedA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetLongPathNameTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpszShortPath, [NativeTypeName("LPWSTR")] ushort* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessAffinityMask"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessAffinityMask([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("PDWORD_PTR")] ulong* lpProcessAffinityMask, [NativeTypeName("PDWORD_PTR")] ulong* lpSystemAffinityMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessAffinityMask"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessAffinityMask([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD_PTR")] ulong dwProcessAffinityMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessIoCounters"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessIoCounters([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("PIO_COUNTERS")] IO_COUNTERS* lpIoCounters);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessWorkingSetSize"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessWorkingSetSize([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("PSIZE_T")] ulong* lpMinimumWorkingSetSize, [NativeTypeName("PSIZE_T")] ulong* lpMaximumWorkingSetSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessWorkingSetSize"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessWorkingSetSize([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("SIZE_T")] ulong dwMinimumWorkingSetSize, [NativeTypeName("SIZE_T")] ulong dwMaximumWorkingSetSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FatalExit"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void FatalExit(int ExitCode);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetEnvironmentStringsA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEnvironmentStringsA([NativeTypeName("LPCH")] sbyte* NewEnvironment);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SwitchToFiber"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void SwitchToFiber([NativeTypeName("LPVOID")] void* lpFiber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteFiber"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void DeleteFiber([NativeTypeName("LPVOID")] void* lpFiber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ConvertFiberToThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ConvertFiberToThread();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFiberEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CreateFiberEx([NativeTypeName("SIZE_T")] ulong dwStackCommitSize, [NativeTypeName("SIZE_T")] ulong dwStackReserveSize, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* unmanaged<void*, void> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ConvertThreadToFiberEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* ConvertThreadToFiberEx([NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFiber"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CreateFiber([NativeTypeName("SIZE_T")] ulong dwStackSize, [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* unmanaged<void*, void> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ConvertThreadToFiber"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* ConvertThreadToFiber([NativeTypeName("LPVOID")] void* lpParameter);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateUmsCompletionList"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateUmsCompletionList([NativeTypeName("PUMS_COMPLETION_LIST *")] void** UmsCompletionList);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DequeueUmsCompletionListItems"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DequeueUmsCompletionListItems([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList, [NativeTypeName("DWORD")] uint WaitTimeOut, [NativeTypeName("PUMS_CONTEXT *")] void** UmsThreadList);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetUmsCompletionListEvent"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUmsCompletionListEvent([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList, [NativeTypeName("PHANDLE")] void** UmsCompletionEvent);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ExecuteUmsThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExecuteUmsThread([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UmsThreadYield"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UmsThreadYield([NativeTypeName("PVOID")] void* SchedulerParam);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteUmsCompletionList"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteUmsCompletionList([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentUmsThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("PUMS_CONTEXT")]
        public static extern void* GetCurrentUmsThread();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNextUmsListItem"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("PUMS_CONTEXT")]
        public static extern void* GetNextUmsListItem([NativeTypeName("PUMS_CONTEXT")] void* UmsContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryUmsThreadInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryUmsThreadInformation([NativeTypeName("PUMS_CONTEXT")] void* UmsThread, [NativeTypeName("UMS_THREAD_INFO_CLASS")] RTL_UMS_THREAD_INFO_CLASS UmsThreadInfoClass, [NativeTypeName("PVOID")] void* UmsThreadInformation, [NativeTypeName("ULONG")] uint UmsThreadInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetUmsThreadInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUmsThreadInformation([NativeTypeName("PUMS_CONTEXT")] void* UmsThread, [NativeTypeName("UMS_THREAD_INFO_CLASS")] RTL_UMS_THREAD_INFO_CLASS UmsThreadInfoClass, [NativeTypeName("PVOID")] void* UmsThreadInformation, [NativeTypeName("ULONG")] uint UmsThreadInformationLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteUmsThreadContext"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteUmsThreadContext([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateUmsThreadContext"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateUmsThreadContext([NativeTypeName("PUMS_CONTEXT *")] void** lpUmsThread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EnterUmsSchedulingMode"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnterUmsSchedulingMode([NativeTypeName("PUMS_SCHEDULER_STARTUP_INFO")] UMS_SCHEDULER_STARTUP_INFO* SchedulerStartupInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetUmsSystemThreadInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUmsSystemThreadInformation([NativeTypeName("HANDLE")] void* ThreadHandle, [NativeTypeName("PUMS_SYSTEM_THREAD_INFORMATION")] UMS_SYSTEM_THREAD_INFORMATION* SystemThreadInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadAffinityMask"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD_PTR")]
        public static extern ulong SetThreadAffinityMask([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("DWORD_PTR")] ulong dwThreadAffinityMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessDEPPolicy"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDEPPolicy([NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessDEPPolicy"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDEPPolicy([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("LPDWORD")] uint* lpFlags, [NativeTypeName("PBOOL")] int* lpPermanent);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RequestWakeupLatency"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RequestWakeupLatency(LATENCY_TIME latency);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsSystemResumeAutomatic"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsSystemResumeAutomatic();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadSelectorEntry"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadSelectorEntry([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("DWORD")] uint dwSelector, [NativeTypeName("LPLDT_ENTRY")] void* lpSelectorEntry);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadExecutionState"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("EXECUTION_STATE")]
        public static extern uint SetThreadExecutionState([NativeTypeName("EXECUTION_STATE")] uint esFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.PowerCreateRequest"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* PowerCreateRequest([NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* Context);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.PowerSetRequest"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PowerSetRequest([NativeTypeName("HANDLE")] void* PowerRequest, POWER_REQUEST_TYPE RequestType);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.PowerClearRequest"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PowerClearRequest([NativeTypeName("HANDLE")] void* PowerRequest, POWER_REQUEST_TYPE RequestType);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileCompletionNotificationModes"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileCompletionNotificationModes([NativeTypeName("HANDLE")] void* FileHandle, [NativeTypeName("UCHAR")] byte Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.Wow64GetThreadSelectorEntry"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Wow64GetThreadSelectorEntry([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("DWORD")] uint dwSelector, [NativeTypeName("PWOW64_LDT_ENTRY")] WOW64_LDT_ENTRY* lpSelectorEntry);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DebugSetProcessKillOnExit"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DebugSetProcessKillOnExit([NativeTypeName("BOOL")] int KillOnExit);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DebugBreakProcess"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DebugBreakProcess([NativeTypeName("HANDLE")] void* Process);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.PulseEvent"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PulseEvent([NativeTypeName("HANDLE")] void* hEvent);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalDeleteAtom"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalDeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.InitAtomTable"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitAtomTable([NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteAtom"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort DeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetHandleCount"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint SetHandleCount(uint uNumber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RequestDeviceWakeup"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RequestDeviceWakeup([NativeTypeName("HANDLE")] void* hDevice);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CancelDeviceWakeupRequest"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelDeviceWakeupRequest([NativeTypeName("HANDLE")] void* hDevice);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDevicePowerState"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDevicePowerState([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("BOOL *")] int* pfOn);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetMessageWaitingIndicator"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMessageWaitingIndicator([NativeTypeName("HANDLE")] void* hMsgIndicator, [NativeTypeName("ULONG")] uint ulMsgCount);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileShortNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileShortNameA([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPCSTR")] sbyte* lpShortName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileShortNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileShortNameW([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPCWSTR")] ushort* lpShortName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LoadModule"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint LoadModule([NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("LPVOID")] void* lpParameterBlock);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WinExec"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint WinExec([NativeTypeName("LPCSTR")] sbyte* lpCmdLine, uint uCmdShow);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ClearCommBreak"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearCommBreak([NativeTypeName("HANDLE")] void* hFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ClearCommError"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearCommError([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPDWORD")] uint* lpErrors, [NativeTypeName("LPCOMSTAT")] COMSTAT* lpStat);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetupComm"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupComm([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwInQueue, [NativeTypeName("DWORD")] uint dwOutQueue);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EscapeCommFunction"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EscapeCommFunction([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwFunc);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCommConfig"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommConfig([NativeTypeName("HANDLE")] void* hCommDev, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCommMask"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommMask([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPDWORD")] uint* lpEvtMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCommProperties"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommProperties([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPCOMMPROP")] COMMPROP* lpCommProp);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCommModemStatus"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommModemStatus([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPDWORD")] uint* lpModemStat);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCommState"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommState([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCommTimeouts"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommTimeouts([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.PurgeComm"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PurgeComm([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetCommBreak"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommBreak([NativeTypeName("HANDLE")] void* hFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetCommConfig"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommConfig([NativeTypeName("HANDLE")] void* hCommDev, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetCommMask"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommMask([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwEvtMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetCommState"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommState([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetCommTimeouts"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommTimeouts([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.TransmitCommChar"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TransmitCommChar([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("char")] sbyte cChar);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WaitCommEvent"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitCommEvent([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPDWORD")] uint* lpEvtMask, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenCommPort"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenCommPort([NativeTypeName("ULONG")] uint uPortNumber, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCommPorts"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetCommPorts([NativeTypeName("PULONG")] uint* lpPortNumbers, [NativeTypeName("ULONG")] uint uPortNumbersCount, [NativeTypeName("PULONG")] uint* puPortNumbersFound);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetTapePosition"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetTapePosition([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("DWORD")] uint dwPositionMethod, [NativeTypeName("DWORD")] uint dwPartition, [NativeTypeName("DWORD")] uint dwOffsetLow, [NativeTypeName("DWORD")] uint dwOffsetHigh, [NativeTypeName("BOOL")] int bImmediate);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetTapePosition"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapePosition([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("DWORD")] uint dwPositionType, [NativeTypeName("LPDWORD")] uint* lpdwPartition, [NativeTypeName("LPDWORD")] uint* lpdwOffsetLow, [NativeTypeName("LPDWORD")] uint* lpdwOffsetHigh);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.PrepareTape"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PrepareTape([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("BOOL")] int bImmediate);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EraseTape"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint EraseTape([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("DWORD")] uint dwEraseType, [NativeTypeName("BOOL")] int bImmediate);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateTapePartition"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateTapePartition([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("DWORD")] uint dwPartitionMethod, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("DWORD")] uint dwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteTapemark"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WriteTapemark([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("DWORD")] uint dwTapemarkType, [NativeTypeName("DWORD")] uint dwTapemarkCount, [NativeTypeName("BOOL")] int bImmediate);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetTapeStatus"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapeStatus([NativeTypeName("HANDLE")] void* hDevice);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetTapeParameters"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapeParameters([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("LPDWORD")] uint* lpdwSize, [NativeTypeName("LPVOID")] void* lpTapeInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetTapeParameters"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetTapeParameters([NativeTypeName("HANDLE")] void* hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("LPVOID")] void* lpTapeInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MulDiv"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetSystemDEPPolicy"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern DEP_SYSTEM_POLICY_TYPE GetSystemDEPPolicy();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetSystemRegistryQuota"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemRegistryQuota([NativeTypeName("PDWORD")] uint* pdwQuotaAllowed, [NativeTypeName("PDWORD")] uint* pdwQuotaUsed);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FileTimeToDosDateTime"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileTimeToDosDateTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPWORD")] ushort* lpFatDate, [NativeTypeName("LPWORD")] ushort* lpFatTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DosDateTimeToFileTime"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DosDateTimeToFileTime([NativeTypeName("WORD")] ushort wFatDate, [NativeTypeName("WORD")] ushort wFatTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FormatMessageA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FormatMessageA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpSource, [NativeTypeName("DWORD")] uint dwMessageId, [NativeTypeName("DWORD")] uint dwLanguageId, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("va_list *")] sbyte** Arguments);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FormatMessageW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FormatMessageW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpSource, [NativeTypeName("DWORD")] uint dwMessageId, [NativeTypeName("DWORD")] uint dwLanguageId, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("va_list *")] sbyte** Arguments);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateMailslotA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateMailslotA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint nMaxMessageSize, [NativeTypeName("DWORD")] uint lReadTimeout, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateMailslotW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateMailslotW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint nMaxMessageSize, [NativeTypeName("DWORD")] uint lReadTimeout, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetMailslotInfo"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMailslotInfo([NativeTypeName("HANDLE")] void* hMailslot, [NativeTypeName("LPDWORD")] uint* lpMaxMessageSize, [NativeTypeName("LPDWORD")] uint* lpNextSize, [NativeTypeName("LPDWORD")] uint* lpMessageCount, [NativeTypeName("LPDWORD")] uint* lpReadTimeout);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetMailslotInfo"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMailslotInfo([NativeTypeName("HANDLE")] void* hMailslot, [NativeTypeName("DWORD")] uint lReadTimeout);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EncryptFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EncryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EncryptFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EncryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DecryptFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DecryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwReserved);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DecryptFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DecryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwReserved);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FileEncryptionStatusA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileEncryptionStatusA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpStatus);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FileEncryptionStatusW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileEncryptionStatusW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpStatus);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenEncryptedFileRawA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OpenEncryptedFileRawA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("ULONG")] uint ulFlags, [NativeTypeName("PVOID *")] void** pvContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenEncryptedFileRawW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OpenEncryptedFileRawW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("ULONG")] uint ulFlags, [NativeTypeName("PVOID *")] void** pvContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadEncryptedFileRaw"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ReadEncryptedFileRaw([NativeTypeName("PFE_EXPORT_FUNC")] delegate* unmanaged<byte*, void*, uint, uint> pfExportCallback, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("PVOID")] void* pvContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteEncryptedFileRaw"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WriteEncryptedFileRaw([NativeTypeName("PFE_IMPORT_FUNC")] delegate* unmanaged<byte*, void*, uint*, uint> pfImportCallback, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("PVOID")] void* pvContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CloseEncryptedFileRaw"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void CloseEncryptedFileRaw([NativeTypeName("PVOID")] void* pvContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcmpA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int lstrcmpA([NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcmpW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int lstrcmpW([NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcmpiA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int lstrcmpiA([NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcmpiW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int lstrcmpiW([NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcpynA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcpynA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2, int iMaxLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcpynW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcpynW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2, int iMaxLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcpyA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcpyA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcpyW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcpyW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcatA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcatA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrcatW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcatW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrlenA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int lstrlenA([NativeTypeName("LPCSTR")] sbyte* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.lstrlenW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int lstrlenW([NativeTypeName("LPCWSTR")] ushort* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenFile"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int OpenFile([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPOFSTRUCT")] OFSTRUCT* lpReOpenBuff, uint uStyle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods._lopen"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lopen([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iReadWrite);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods._lcreat"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lcreat([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iAttribute);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods._lread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint _lread([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPVOID")] void* lpBuffer, uint uBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods._lwrite"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint _lwrite([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPCCH")] sbyte* lpBuffer, uint uBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods._hread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int _hread([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("long")] int lBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods._hwrite"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int _hwrite([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPCCH")] sbyte* lpBuffer, [NativeTypeName("long")] int lBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods._lclose"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lclose([NativeTypeName("HFILE")] int hFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods._llseek"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int _llseek([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LONG")] int lOffset, int iOrigin);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsTextUnicode"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTextUnicode([NativeTypeName("const void *")] void* lpv, int iSize, [NativeTypeName("LPINT")] int* lpiResult);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SignalObjectAndWait"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SignalObjectAndWait([NativeTypeName("HANDLE")] void* hObjectToSignal, [NativeTypeName("HANDLE")] void* hObjectToWaitOn, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BackupRead"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupRead([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPBYTE")] byte* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, [NativeTypeName("BOOL")] int bAbort, [NativeTypeName("BOOL")] int bProcessSecurity, [NativeTypeName("LPVOID *")] void** lpContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BackupSeek"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupSeek([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwLowBytesToSeek, [NativeTypeName("DWORD")] uint dwHighBytesToSeek, [NativeTypeName("LPDWORD")] uint* lpdwLowByteSeeked, [NativeTypeName("LPDWORD")] uint* lpdwHighByteSeeked, [NativeTypeName("LPVOID *")] void** lpContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BackupWrite"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupWrite([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPBYTE")] byte* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, [NativeTypeName("BOOL")] int bAbort, [NativeTypeName("BOOL")] int bProcessSecurity, [NativeTypeName("LPVOID *")] void** lpContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenMutexA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenMutexA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateSemaphoreA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateSemaphoreA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCSTR")] sbyte* lpName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenSemaphoreA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenSemaphoreA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateWaitableTimerA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateWaitableTimerA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("LPCSTR")] sbyte* lpTimerName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenWaitableTimerA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenWaitableTimerA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpTimerName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateSemaphoreExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateSemaphoreExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateWaitableTimerExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateWaitableTimerExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("LPCSTR")] sbyte* lpTimerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFileMappingA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateFileMappingA([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCSTR")] sbyte* lpName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFileMappingNumaA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateFileMappingNumaA([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint nndPreferred);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenFileMappingA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenFileMappingA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetLogicalDriveStringsA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDriveStringsA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LoadPackagedLibrary"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern HINSTANCE__* LoadPackagedLibrary([NativeTypeName("LPCWSTR")] ushort* lpwLibFileName, [NativeTypeName("DWORD")] uint Reserved);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryFullProcessImageNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryFullProcessImageNameA([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* lpExeName, [NativeTypeName("PDWORD")] uint* lpdwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryFullProcessImageNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryFullProcessImageNameW([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* lpExeName, [NativeTypeName("PDWORD")] uint* lpdwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetStartupInfoA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void GetStartupInfoA([NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFirmwareEnvironmentVariableA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFirmwareEnvironmentVariableW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFirmwareEnvironmentVariableExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableExA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("PDWORD")] uint* pdwAttribubutes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFirmwareEnvironmentVariableExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableExW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("PDWORD")] uint* pdwAttribubutes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFirmwareEnvironmentVariableA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFirmwareEnvironmentVariableW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFirmwareEnvironmentVariableExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableExA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("DWORD")] uint dwAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFirmwareEnvironmentVariableExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableExW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("DWORD")] uint dwAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFirmwareType"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFirmwareType([NativeTypeName("PFIRMWARE_TYPE")] FIRMWARE_TYPE* FirmwareType);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsNativeVhdBoot"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsNativeVhdBoot([NativeTypeName("PBOOL")] int* NativeVhdBoot);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindResourceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern HRSRC__* FindResourceA([NativeTypeName("HMODULE")] HINSTANCE__* hModule, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpType);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindResourceExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern HRSRC__* FindResourceExA([NativeTypeName("HMODULE")] HINSTANCE__* hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EnumResourceTypesA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesA([NativeTypeName("HMODULE")] HINSTANCE__* hModule, [NativeTypeName("ENUMRESTYPEPROCA")] delegate* unmanaged<HINSTANCE__*, sbyte*, long, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] long lParam);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EnumResourceTypesW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesW([NativeTypeName("HMODULE")] HINSTANCE__* hModule, [NativeTypeName("ENUMRESTYPEPROCW")] delegate* unmanaged<HINSTANCE__*, ushort*, long, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] long lParam);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EnumResourceNamesA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesA([NativeTypeName("HMODULE")] HINSTANCE__* hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* unmanaged<HINSTANCE__*, sbyte*, sbyte*, long, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] long lParam);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EnumResourceLanguagesA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesA([NativeTypeName("HMODULE")] HINSTANCE__* hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] delegate* unmanaged<HINSTANCE__*, sbyte*, sbyte*, ushort, long, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] long lParam);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EnumResourceLanguagesW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesW([NativeTypeName("HMODULE")] HINSTANCE__* hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] delegate* unmanaged<HINSTANCE__*, ushort*, ushort*, ushort, long, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] long lParam);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BeginUpdateResourceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* BeginUpdateResourceA([NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("BOOL")] int bDeleteExistingResources);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BeginUpdateResourceW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* BeginUpdateResourceW([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("BOOL")] int bDeleteExistingResources);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UpdateResourceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateResourceA([NativeTypeName("HANDLE")] void* hUpdate, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint cb);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UpdateResourceW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateResourceW([NativeTypeName("HANDLE")] void* hUpdate, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint cb);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EndUpdateResourceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndUpdateResourceA([NativeTypeName("HANDLE")] void* hUpdate, [NativeTypeName("BOOL")] int fDiscard);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EndUpdateResourceW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndUpdateResourceW([NativeTypeName("HANDLE")] void* hUpdate, [NativeTypeName("BOOL")] int fDiscard);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalAddAtomA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalAddAtomW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalAddAtomExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomExA([NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("DWORD")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalAddAtomExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomExW([NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("DWORD")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalFindAtomA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalFindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalFindAtomW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalFindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalGetAtomNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GlobalGetAtomNameA([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GlobalGetAtomNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GlobalGetAtomNameW([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AddAtomA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort AddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AddAtomW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort AddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindAtomA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort FindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindAtomW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort FindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetAtomNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetAtomNameA([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetAtomNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetAtomNameW([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProfileIntA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetProfileIntA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, int nDefault);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProfileIntW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetProfileIntW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, int nDefault);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProfileStringA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpDefault, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProfileStringW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpDefault, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteProfileStringA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteProfileStringW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProfileSectionA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProfileSectionW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteProfileSectionA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteProfileSectionW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpString);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileIntA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetPrivateProfileIntA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, int nDefault, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileIntW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetPrivateProfileIntW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, int nDefault, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileStringA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpDefault, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileStringW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpDefault, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WritePrivateProfileStringA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WritePrivateProfileStringW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileSectionA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileSectionW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WritePrivateProfileSectionA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WritePrivateProfileSectionW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileSectionNamesA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionNamesA([NativeTypeName("LPSTR")] sbyte* lpszReturnBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileSectionNamesW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionNamesW([NativeTypeName("LPWSTR")] ushort* lpszReturnBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileStructA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPrivateProfileStructA([NativeTypeName("LPCSTR")] sbyte* lpszSection, [NativeTypeName("LPCSTR")] sbyte* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, uint uSizeStruct, [NativeTypeName("LPCSTR")] sbyte* szFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPrivateProfileStructW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPrivateProfileStructW([NativeTypeName("LPCWSTR")] ushort* lpszSection, [NativeTypeName("LPCWSTR")] ushort* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, uint uSizeStruct, [NativeTypeName("LPCWSTR")] ushort* szFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WritePrivateProfileStructA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStructA([NativeTypeName("LPCSTR")] sbyte* lpszSection, [NativeTypeName("LPCSTR")] sbyte* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, uint uSizeStruct, [NativeTypeName("LPCSTR")] sbyte* szFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WritePrivateProfileStructW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStructW([NativeTypeName("LPCWSTR")] ushort* lpszSection, [NativeTypeName("LPCWSTR")] ushort* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, uint uSizeStruct, [NativeTypeName("LPCWSTR")] ushort* szFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.Wow64EnableWow64FsRedirection"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte Wow64EnableWow64FsRedirection([NativeTypeName("BOOLEAN")] byte Wow64FsEnableRedirection);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetDllDirectoryA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDllDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetDllDirectoryW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDllDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDllDirectoryA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetDllDirectoryA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDllDirectoryW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetDllDirectoryW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetSearchPathMode"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSearchPathMode([NativeTypeName("DWORD")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateDirectoryExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryExA([NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory, [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateDirectoryExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryExW([NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory, [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateDirectoryTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryTransactedA([NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory, [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateDirectoryTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryTransactedW([NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory, [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RemoveDirectoryTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryTransactedA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RemoveDirectoryTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryTransactedW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFullPathNameTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFullPathNameTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DefineDosDeviceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DefineDosDeviceA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpDeviceName, [NativeTypeName("LPCSTR")] sbyte* lpTargetPath);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryDosDeviceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryDosDeviceA([NativeTypeName("LPCSTR")] sbyte* lpDeviceName, [NativeTypeName("LPSTR")] sbyte* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFileTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] void* hTemplateFile, [NativeTypeName("HANDLE")] void* hTransaction, [NativeTypeName("PUSHORT")] ushort* pusMiniVersion, [NativeTypeName("PVOID")] void* lpExtendedParameter);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFileTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] void* hTemplateFile, [NativeTypeName("HANDLE")] void* hTransaction, [NativeTypeName("PUSHORT")] ushort* pusMiniVersion, [NativeTypeName("PVOID")] void* lpExtendedParameter);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReOpenFile"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* ReOpenFile([NativeTypeName("HANDLE")] void* hOriginalFile, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileAttributesTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileAttributesTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileAttributesTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileAttributesTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCompressedFileSizeTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCompressedFileSizeTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteFileTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteFileTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CheckNameLegalDOS8Dot3A"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckNameLegalDOS8Dot3A([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpOemName, [NativeTypeName("DWORD")] uint OemNameSize, [NativeTypeName("PBOOL")] int* pbNameContainsSpaces, [NativeTypeName("PBOOL")] int* pbNameLegal);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CheckNameLegalDOS8Dot3W"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckNameLegalDOS8Dot3W([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPSTR")] sbyte* lpOemName, [NativeTypeName("DWORD")] uint OemNameSize, [NativeTypeName("PBOOL")] int* pbNameContainsSpaces, [NativeTypeName("PBOOL")] int* pbNameLegal);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstFileTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstFileTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CopyFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("BOOL")] int bFailIfExists);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CopyFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("BOOL")] int bFailIfExists);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CopyFileExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileExA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CopyFileExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileExW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CopyFileTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CopyFileTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CopyFile2"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CopyFile2([NativeTypeName("PCWSTR")] ushort* pwszExistingFileName, [NativeTypeName("PCWSTR")] ushort* pwszNewFileName, COPYFILE2_EXTENDED_PARAMETERS* pExtendedParameters);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MoveFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MoveFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MoveFileExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileExA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MoveFileExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileExW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MoveFileWithProgressA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileWithProgressA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MoveFileWithProgressW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileWithProgressW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MoveFileTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MoveFileTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReplaceFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplaceFileA([NativeTypeName("LPCSTR")] sbyte* lpReplacedFileName, [NativeTypeName("LPCSTR")] sbyte* lpReplacementFileName, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName, [NativeTypeName("DWORD")] uint dwReplaceFlags, [NativeTypeName("LPVOID")] void* lpExclude, [NativeTypeName("LPVOID")] void* lpReserved);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReplaceFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplaceFileW([NativeTypeName("LPCWSTR")] ushort* lpReplacedFileName, [NativeTypeName("LPCWSTR")] ushort* lpReplacementFileName, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName, [NativeTypeName("DWORD")] uint dwReplaceFlags, [NativeTypeName("LPVOID")] void* lpExclude, [NativeTypeName("LPVOID")] void* lpReserved);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateHardLinkA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateHardLinkW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateHardLinkTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateHardLinkTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstStreamTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstStreamTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstFileNameTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstFileNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateNamedPipeA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwOpenMode, [NativeTypeName("DWORD")] uint dwPipeMode, [NativeTypeName("DWORD")] uint nMaxInstances, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("DWORD")] uint nDefaultTimeOut, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNamedPipeHandleStateA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeHandleStateA([NativeTypeName("HANDLE")] void* hNamedPipe, [NativeTypeName("LPDWORD")] uint* lpState, [NativeTypeName("LPDWORD")] uint* lpCurInstances, [NativeTypeName("LPDWORD")] uint* lpMaxCollectionCount, [NativeTypeName("LPDWORD")] uint* lpCollectDataTimeout, [NativeTypeName("LPSTR")] sbyte* lpUserName, [NativeTypeName("DWORD")] uint nMaxUserNameSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CallNamedPipeA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName, [NativeTypeName("LPVOID")] void* lpInBuffer, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("LPVOID")] void* lpOutBuffer, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("LPDWORD")] uint* lpBytesRead, [NativeTypeName("DWORD")] uint nTimeOut);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WaitNamedPipeA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName, [NativeTypeName("DWORD")] uint nTimeOut);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNamedPipeClientComputerNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientComputerNameA([NativeTypeName("HANDLE")] void* Pipe, [NativeTypeName("LPSTR")] sbyte* ClientComputerName, [NativeTypeName("ULONG")] uint ClientComputerNameLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNamedPipeClientProcessId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientProcessId([NativeTypeName("HANDLE")] void* Pipe, [NativeTypeName("PULONG")] uint* ClientProcessId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNamedPipeClientSessionId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientSessionId([NativeTypeName("HANDLE")] void* Pipe, [NativeTypeName("PULONG")] uint* ClientSessionId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNamedPipeServerProcessId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeServerProcessId([NativeTypeName("HANDLE")] void* Pipe, [NativeTypeName("PULONG")] uint* ServerProcessId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNamedPipeServerSessionId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeServerSessionId([NativeTypeName("HANDLE")] void* Pipe, [NativeTypeName("PULONG")] uint* ServerSessionId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetVolumeLabelA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeLabelA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPCSTR")] sbyte* lpVolumeName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetVolumeLabelW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeLabelW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPCWSTR")] ushort* lpVolumeName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileBandwidthReservation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileBandwidthReservation([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint nPeriodMilliseconds, [NativeTypeName("DWORD")] uint nBytesPerPeriod, [NativeTypeName("BOOL")] int bDiscardable, [NativeTypeName("LPDWORD")] uint* lpTransferSize, [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileBandwidthReservation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileBandwidthReservation([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPDWORD")] uint* lpPeriodMilliseconds, [NativeTypeName("LPDWORD")] uint* lpBytesPerPeriod, [NativeTypeName("LPBOOL")] int* pDiscardable, [NativeTypeName("LPDWORD")] uint* lpTransferSize, [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ClearEventLogA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearEventLogA([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ClearEventLogW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearEventLogW([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BackupEventLogA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupEventLogA([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BackupEventLogW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupEventLogW([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CloseEventLog"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseEventLog([NativeTypeName("HANDLE")] void* hEventLog);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeregisterEventSource"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeregisterEventSource([NativeTypeName("HANDLE")] void* hEventLog);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.NotifyChangeEventLog"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int NotifyChangeEventLog([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("HANDLE")] void* hEvent);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNumberOfEventLogRecords"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumberOfEventLogRecords([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("PDWORD")] uint* NumberOfRecords);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetOldestEventLogRecord"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOldestEventLogRecord([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("PDWORD")] uint* OldestRecord);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenEventLogA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenEventLogA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpSourceName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenEventLogW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenEventLogW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpSourceName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RegisterEventSourceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* RegisterEventSourceA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpSourceName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RegisterEventSourceW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* RegisterEventSourceW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpSourceName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenBackupEventLogA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenBackupEventLogA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenBackupEventLogW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenBackupEventLogW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadEventLogA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadEventLogA([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("DWORD")] uint dwReadFlags, [NativeTypeName("DWORD")] uint dwRecordOffset, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("DWORD *")] uint* pnBytesRead, [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadEventLogW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadEventLogW([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("DWORD")] uint dwReadFlags, [NativeTypeName("DWORD")] uint dwRecordOffset, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("DWORD *")] uint* pnBytesRead, [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReportEventA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReportEventA([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("WORD")] ushort wType, [NativeTypeName("WORD")] ushort wCategory, [NativeTypeName("DWORD")] uint dwEventID, [NativeTypeName("PSID")] void* lpUserSid, [NativeTypeName("WORD")] ushort wNumStrings, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("LPCSTR *")] sbyte** lpStrings, [NativeTypeName("LPVOID")] void* lpRawData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReportEventW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReportEventW([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("WORD")] ushort wType, [NativeTypeName("WORD")] ushort wCategory, [NativeTypeName("DWORD")] uint dwEventID, [NativeTypeName("PSID")] void* lpUserSid, [NativeTypeName("WORD")] ushort wNumStrings, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("LPCWSTR *")] ushort** lpStrings, [NativeTypeName("LPVOID")] void* lpRawData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetEventLogInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetEventLogInformation([NativeTypeName("HANDLE")] void* hEventLog, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint cbBufSize, [NativeTypeName("LPDWORD")] uint* pcbBytesNeeded);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OperationStart"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OperationStart(OPERATION_START_PARAMETERS* OperationStartParams);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OperationEnd"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OperationEnd(OPERATION_END_PARAMETERS* OperationEndParams);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AccessCheckAndAuditAlarmA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AccessCheckByTypeAndAuditAlarmA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AccessCheckByTypeResultListAndAuditAlarmA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AccessCheckByTypeResultListAndAuditAlarmByHandleA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("HANDLE")] void* ClientToken, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ObjectOpenAuditAlarmA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectOpenAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("HANDLE")] void* ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("BOOL")] int AccessGranted, [NativeTypeName("LPBOOL")] int* GenerateOnClose);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ObjectPrivilegeAuditAlarmA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectPrivilegeAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("HANDLE")] void* ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int AccessGranted);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ObjectCloseAuditAlarmA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectCloseAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("BOOL")] int GenerateOnClose);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ObjectDeleteAuditAlarmA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectDeleteAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("BOOL")] int GenerateOnClose);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.PrivilegedServiceAuditAlarmA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrivilegedServiceAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPCSTR")] sbyte* ServiceName, [NativeTypeName("HANDLE")] void* ClientToken, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int AccessGranted);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AddConditionalAce"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddConditionalAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("UCHAR")] byte AceType, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PWCHAR")] ushort* ConditionStr, [NativeTypeName("DWORD *")] uint* ReturnLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileSecurityA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileSecurityA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileSecurityA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileSecurityA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadDirectoryChangesW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadDirectoryChangesW([NativeTypeName("HANDLE")] void* hDirectory, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadDirectoryChangesExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadDirectoryChangesExW([NativeTypeName("HANDLE")] void* hDirectory, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine, READ_DIRECTORY_NOTIFY_INFORMATION_CLASS ReadDirectoryNotifyInformationClass);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MapViewOfFileExNuma"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* MapViewOfFileExNuma([NativeTypeName("HANDLE")] void* hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] ulong dwNumberOfBytesToMap, [NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("DWORD")] uint nndPreferred);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsBadReadPtr"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadReadPtr([NativeTypeName("const void *")] void* lp, [NativeTypeName("UINT_PTR")] ulong ucb);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsBadWritePtr"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadWritePtr([NativeTypeName("LPVOID")] void* lp, [NativeTypeName("UINT_PTR")] ulong ucb);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsBadHugeReadPtr"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadHugeReadPtr([NativeTypeName("const void *")] void* lp, [NativeTypeName("UINT_PTR")] ulong ucb);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsBadHugeWritePtr"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadHugeWritePtr([NativeTypeName("LPVOID")] void* lp, [NativeTypeName("UINT_PTR")] ulong ucb);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsBadCodePtr"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadCodePtr([NativeTypeName("FARPROC")] delegate* unmanaged<long> lpfn);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsBadStringPtrA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadStringPtrA([NativeTypeName("LPCSTR")] sbyte* lpsz, [NativeTypeName("UINT_PTR")] ulong ucchMax);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsBadStringPtrW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadStringPtrW([NativeTypeName("LPCWSTR")] ushort* lpsz, [NativeTypeName("UINT_PTR")] ulong ucchMax);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupAccountSidA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR")] sbyte* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupAccountSidW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR")] ushort* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupAccountNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupAccountNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupAccountNameLocalA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameLocalA([NativeTypeName("LPCSTR")] sbyte* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupAccountNameLocalW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameLocalW([NativeTypeName("LPCWSTR")] ushort* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupAccountSidLocalA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidLocalA([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR")] sbyte* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupAccountSidLocalW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidLocalW([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR")] ushort* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupPrivilegeValueA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeValueA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupPrivilegeValueW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeValueW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupPrivilegeNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("PLUID")] LUID* lpLuid, [NativeTypeName("LPSTR")] sbyte* lpName, [NativeTypeName("LPDWORD")] uint* cchName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupPrivilegeNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("PLUID")] LUID* lpLuid, [NativeTypeName("LPWSTR")] ushort* lpName, [NativeTypeName("LPDWORD")] uint* cchName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupPrivilegeDisplayNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeDisplayNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpDisplayName, [NativeTypeName("LPDWORD")] uint* cchDisplayName, [NativeTypeName("LPDWORD")] uint* lpLanguageId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LookupPrivilegeDisplayNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeDisplayNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPWSTR")] ushort* lpDisplayName, [NativeTypeName("LPDWORD")] uint* cchDisplayName, [NativeTypeName("LPDWORD")] uint* lpLanguageId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BuildCommDCBA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBA([NativeTypeName("LPCSTR")] sbyte* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BuildCommDCBW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBW([NativeTypeName("LPCWSTR")] ushort* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BuildCommDCBAndTimeoutsA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBAndTimeoutsA([NativeTypeName("LPCSTR")] sbyte* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BuildCommDCBAndTimeoutsW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBAndTimeoutsW([NativeTypeName("LPCWSTR")] ushort* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CommConfigDialogA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommConfigDialogA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("HWND")] HWND__* hWnd, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CommConfigDialogW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommConfigDialogW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("HWND")] HWND__* hWnd, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDefaultCommConfigA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDefaultCommConfigA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDefaultCommConfigW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDefaultCommConfigW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetDefaultCommConfigA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultCommConfigA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetDefaultCommConfigW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultCommConfigW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetComputerNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetComputerNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DnsHostnameToComputerNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DnsHostnameToComputerNameA([NativeTypeName("LPCSTR")] sbyte* Hostname, [NativeTypeName("LPSTR")] sbyte* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DnsHostnameToComputerNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DnsHostnameToComputerNameW([NativeTypeName("LPCWSTR")] ushort* Hostname, [NativeTypeName("LPWSTR")] ushort* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetUserNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserNameA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* pcbBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetUserNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserNameW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* pcbBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LogonUserA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserA([NativeTypeName("LPCSTR")] sbyte* lpszUsername, [NativeTypeName("LPCSTR")] sbyte* lpszDomain, [NativeTypeName("LPCSTR")] sbyte* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] void** phToken);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LogonUserW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserW([NativeTypeName("LPCWSTR")] ushort* lpszUsername, [NativeTypeName("LPCWSTR")] ushort* lpszDomain, [NativeTypeName("LPCWSTR")] ushort* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] void** phToken);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LogonUserExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserExA([NativeTypeName("LPCSTR")] sbyte* lpszUsername, [NativeTypeName("LPCSTR")] sbyte* lpszDomain, [NativeTypeName("LPCSTR")] sbyte* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] void** phToken, [NativeTypeName("PSID *")] void** ppLogonSid, [NativeTypeName("PVOID *")] void** ppProfileBuffer, [NativeTypeName("LPDWORD")] uint* pdwProfileLength, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LogonUserExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserExW([NativeTypeName("LPCWSTR")] ushort* lpszUsername, [NativeTypeName("LPCWSTR")] ushort* lpszDomain, [NativeTypeName("LPCWSTR")] ushort* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] void** phToken, [NativeTypeName("PSID *")] void** ppLogonSid, [NativeTypeName("PVOID *")] void** ppProfileBuffer, [NativeTypeName("LPDWORD")] uint* pdwProfileLength, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateProcessWithLogonW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessWithLogonW([NativeTypeName("LPCWSTR")] ushort* lpUsername, [NativeTypeName("LPCWSTR")] ushort* lpDomain, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("DWORD")] uint dwLogonFlags, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateProcessWithTokenW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessWithTokenW([NativeTypeName("HANDLE")] void* hToken, [NativeTypeName("DWORD")] uint dwLogonFlags, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsTokenUntrusted"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTokenUntrusted([NativeTypeName("HANDLE")] void* TokenHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RegisterWaitForSingleObject"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterWaitForSingleObject([NativeTypeName("PHANDLE")] void** phNewWaitObject, [NativeTypeName("HANDLE")] void* hObject, [NativeTypeName("WAITORTIMERCALLBACK")] delegate* unmanaged<void*, byte, void> Callback, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("ULONG")] uint dwMilliseconds, [NativeTypeName("ULONG")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UnregisterWait"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterWait([NativeTypeName("HANDLE")] void* WaitHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.BindIoCompletionCallback"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BindIoCompletionCallback([NativeTypeName("HANDLE")] void* FileHandle, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> Function, [NativeTypeName("ULONG")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetTimerQueueTimer"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* SetTimerQueueTimer([NativeTypeName("HANDLE")] void* TimerQueue, [NativeTypeName("WAITORTIMERCALLBACK")] delegate* unmanaged<void*, byte, void> Callback, [NativeTypeName("PVOID")] void* Parameter, [NativeTypeName("DWORD")] uint DueTime, [NativeTypeName("DWORD")] uint Period, [NativeTypeName("BOOL")] int PreferIo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CancelTimerQueueTimer"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelTimerQueueTimer([NativeTypeName("HANDLE")] void* TimerQueue, [NativeTypeName("HANDLE")] void* Timer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteTimerQueue"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteTimerQueue([NativeTypeName("HANDLE")] void* TimerQueue);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreatePrivateNamespaceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreatePrivateNamespaceA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpPrivateNamespaceAttributes, [NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenPrivateNamespaceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenPrivateNamespaceA([NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateBoundaryDescriptorA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateBoundaryDescriptorA([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("ULONG")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AddIntegrityLabelToBoundaryDescriptor"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddIntegrityLabelToBoundaryDescriptor([NativeTypeName("HANDLE *")] void** BoundaryDescriptor, [NativeTypeName("PSID")] void* IntegrityLabel);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentHwProfileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentHwProfileA([NativeTypeName("LPHW_PROFILE_INFOA")] HW_PROFILE_INFOA* lpHwProfileInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentHwProfileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentHwProfileW([NativeTypeName("LPHW_PROFILE_INFOW")] HW_PROFILE_INFOW* lpHwProfileInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.VerifyVersionInfoA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int VerifyVersionInfoA([NativeTypeName("LPOSVERSIONINFOEXA")] OSVERSIONINFOEXA* lpVersionInformation, [NativeTypeName("DWORD")] uint dwTypeMask, [NativeTypeName("DWORDLONG")] ulong dwlConditionMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.VerifyVersionInfoW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int VerifyVersionInfoW([NativeTypeName("LPOSVERSIONINFOEXW")] OSVERSIONINFOEXW* lpVersionInformation, [NativeTypeName("DWORD")] uint dwTypeMask, [NativeTypeName("DWORDLONG")] ulong dwlConditionMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetSystemPowerState"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemPowerState([NativeTypeName("BOOL")] int fSuspend, [NativeTypeName("BOOL")] int fForce);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetSystemPowerStatus"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemPowerStatus([NativeTypeName("LPSYSTEM_POWER_STATUS")] SYSTEM_POWER_STATUS* lpSystemPowerStatus);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.MapUserPhysicalPagesScatter"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MapUserPhysicalPagesScatter([NativeTypeName("PVOID *")] void** VirtualAddresses, [NativeTypeName("ULONG_PTR")] ulong NumberOfPages, [NativeTypeName("PULONG_PTR")] ulong* PageArray);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateJobObjectA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateJobObjectA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenJobObjectA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenJobObjectA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateJobSet"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateJobSet([NativeTypeName("ULONG")] uint NumJob, [NativeTypeName("PJOB_SET_ARRAY")] JOB_SET_ARRAY* UserJobSet, [NativeTypeName("ULONG")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstVolumeA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstVolumeA([NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextVolumeA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeA([NativeTypeName("HANDLE")] void* hFindVolume, [NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstVolumeMountPointA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszRootPathName, [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstVolumeMountPointW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszRootPathName, [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextVolumeMountPointA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeMountPointA([NativeTypeName("HANDLE")] void* hFindVolumeMountPoint, [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextVolumeMountPointW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeMountPointW([NativeTypeName("HANDLE")] void* hFindVolumeMountPoint, [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindVolumeMountPointClose"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindVolumeMountPointClose([NativeTypeName("HANDLE")] void* hFindVolumeMountPoint);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetVolumeMountPointA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("LPCSTR")] sbyte* lpszVolumeName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetVolumeMountPointW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("LPCWSTR")] ushort* lpszVolumeName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteVolumeMountPointA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumeNameForVolumeMountPointA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeNameForVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumePathNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNameA([NativeTypeName("LPCSTR")] sbyte* lpszFileName, [NativeTypeName("LPSTR")] sbyte* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumePathNamesForVolumeNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNamesForVolumeNameA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeName, [NativeTypeName("LPCH")] sbyte* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateActCtxA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateActCtxA([NativeTypeName("PCACTCTXA")] ACTCTXA* pActCtx);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateActCtxW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateActCtxW([NativeTypeName("PCACTCTXW")] ACTCTXW* pActCtx);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AddRefActCtx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void AddRefActCtx([NativeTypeName("HANDLE")] void* hActCtx);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReleaseActCtx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void ReleaseActCtx([NativeTypeName("HANDLE")] void* hActCtx);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ZombifyActCtx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ZombifyActCtx([NativeTypeName("HANDLE")] void* hActCtx);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ActivateActCtx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ActivateActCtx([NativeTypeName("HANDLE")] void* hActCtx, [NativeTypeName("ULONG_PTR *")] ulong* lpCookie);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeactivateActCtx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeactivateActCtx([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] ulong ulCookie);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentActCtx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentActCtx([NativeTypeName("HANDLE *")] void** lphActCtx);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindActCtxSectionStringA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionStringA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("LPCSTR")] sbyte* lpStringToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindActCtxSectionStringW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionStringW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("LPCWSTR")] ushort* lpStringToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindActCtxSectionGuid"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionGuid([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("const GUID *")] Guid* lpGuidToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryActCtxW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryActCtxW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] void* hActCtx, [NativeTypeName("PVOID")] void* pvSubInstance, [NativeTypeName("ULONG")] uint ulInfoClass, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("SIZE_T")] ulong cbBuffer, [NativeTypeName("SIZE_T *")] ulong* pcbWrittenOrRequired);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WTSGetActiveConsoleSessionId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WTSGetActiveConsoleSessionId();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WTSGetServiceSessionId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WTSGetServiceSessionId();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WTSIsServerContainer"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte WTSIsServerContainer();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetActiveProcessorGroupCount"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetActiveProcessorGroupCount();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetMaximumProcessorGroupCount"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetMaximumProcessorGroupCount();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetActiveProcessorCount"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetActiveProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetMaximumProcessorCount"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMaximumProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNumaProcessorNode"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProcessorNode([NativeTypeName("UCHAR")] byte Processor, [NativeTypeName("PUCHAR")] byte* NodeNumber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNumaNodeNumberFromHandle"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaNodeNumberFromHandle([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("PUSHORT")] ushort* NodeNumber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNumaProcessorNodeEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProcessorNodeEx([NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* Processor, [NativeTypeName("PUSHORT")] ushort* NodeNumber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNumaNodeProcessorMask"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaNodeProcessorMask([NativeTypeName("UCHAR")] byte Node, [NativeTypeName("PULONGLONG")] ulong* ProcessorMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNumaAvailableMemoryNode"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaAvailableMemoryNode([NativeTypeName("UCHAR")] byte Node, [NativeTypeName("PULONGLONG")] ulong* AvailableBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNumaAvailableMemoryNodeEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaAvailableMemoryNodeEx(ushort Node, [NativeTypeName("PULONGLONG")] ulong* AvailableBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetNumaProximityNode"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProximityNode([NativeTypeName("ULONG")] uint ProximityId, [NativeTypeName("PUCHAR")] byte* NodeNumber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RegisterApplicationRecoveryCallback"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterApplicationRecoveryCallback([NativeTypeName("APPLICATION_RECOVERY_CALLBACK")] delegate* unmanaged<void*, uint> pRecoveyCallback, [NativeTypeName("PVOID")] void* pvParameter, [NativeTypeName("DWORD")] uint dwPingInterval, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UnregisterApplicationRecoveryCallback"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UnregisterApplicationRecoveryCallback();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RegisterApplicationRestart"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterApplicationRestart([NativeTypeName("PCWSTR")] ushort* pwzCommandline, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UnregisterApplicationRestart"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UnregisterApplicationRestart();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetApplicationRecoveryCallback"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetApplicationRecoveryCallback([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("APPLICATION_RECOVERY_CALLBACK *")] delegate* unmanaged<void*, uint>* pRecoveryCallback, [NativeTypeName("PVOID *")] void** ppvParameter, [NativeTypeName("PDWORD")] uint* pdwPingInterval, [NativeTypeName("PDWORD")] uint* pdwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetApplicationRestartSettings"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetApplicationRestartSettings([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("PWSTR")] ushort* pwzCommandline, [NativeTypeName("PDWORD")] uint* pcchSize, [NativeTypeName("PDWORD")] uint* pdwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ApplicationRecoveryInProgress"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ApplicationRecoveryInProgress([NativeTypeName("PBOOL")] int* pbCancelled);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ApplicationRecoveryFinished"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void ApplicationRecoveryFinished([NativeTypeName("BOOL")] int bSuccess);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileInformationByHandleEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileInformationByHandleEx([NativeTypeName("HANDLE")] void* hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenFileById"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenFileById([NativeTypeName("HANDLE")] void* hVolumeHint, [NativeTypeName("LPFILE_ID_DESCRIPTOR")] FILE_ID_DESCRIPTOR* lpFileId, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateSymbolicLinkA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkA([NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName, [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateSymbolicLinkW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkW([NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName, [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryActCtxSettingsW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryActCtxSettingsW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] void* hActCtx, [NativeTypeName("PCWSTR")] ushort* settingsNameSpace, [NativeTypeName("PCWSTR")] ushort* settingName, [NativeTypeName("PWSTR")] ushort* pvBuffer, [NativeTypeName("SIZE_T")] ulong dwBuffer, [NativeTypeName("SIZE_T *")] ulong* pdwWrittenOrRequired);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateSymbolicLinkTransactedA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkTransactedA([NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName, [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateSymbolicLinkTransactedW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkTransactedW([NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName, [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] void* hTransaction);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReplacePartitionUnit"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplacePartitionUnit([NativeTypeName("PWSTR")] ushort* TargetPartition, [NativeTypeName("PWSTR")] ushort* SparePartition, [NativeTypeName("ULONG")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AddSecureMemoryCacheCallback"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddSecureMemoryCacheCallback([NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")] delegate* unmanaged<void*, ulong, byte> pfnCallBack);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RemoveSecureMemoryCacheCallback"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveSecureMemoryCacheCallback([NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")] delegate* unmanaged<void*, ulong, byte> pfnCallBack);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CopyContext"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyContext([NativeTypeName("PCONTEXT")] CONTEXT* Destination, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT")] CONTEXT* Source);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.InitializeContext"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeContext([NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT *")] CONTEXT** Context, [NativeTypeName("PDWORD")] uint* ContextLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.InitializeContext2"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeContext2([NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT *")] CONTEXT** Context, [NativeTypeName("PDWORD")] uint* ContextLength, [NativeTypeName("ULONG64")] ulong XStateCompactionMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetEnabledXStateFeatures"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD64")]
        public static extern ulong GetEnabledXStateFeatures();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetXStateFeaturesMask"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetXStateFeaturesMask([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("PDWORD64")] ulong* FeatureMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocateXStateFeature"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* LocateXStateFeature([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("DWORD")] uint FeatureId, [NativeTypeName("PDWORD")] uint* Length);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetXStateFeaturesMask"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetXStateFeaturesMask([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("DWORD64")] ulong FeatureMask);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.EnableThreadProfiling"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint EnableThreadProfiling([NativeTypeName("HANDLE")] void* ThreadHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD64")] ulong HardwareCounters, [NativeTypeName("HANDLE *")] void** PerformanceDataHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DisableThreadProfiling"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DisableThreadProfiling([NativeTypeName("HANDLE")] void* PerformanceDataHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryThreadProfiling"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryThreadProfiling([NativeTypeName("HANDLE")] void* ThreadHandle, [NativeTypeName("PBOOLEAN")] byte* Enabled);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadThreadProfilingData"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ReadThreadProfilingData([NativeTypeName("HANDLE")] void* PerformanceDataHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PPERFORMANCE_DATA")] PERFORMANCE_DATA* PerformanceData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RaiseCustomSystemEventTrigger"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RaiseCustomSystemEventTrigger([NativeTypeName("PCUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG")] CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG* CustomSystemEventTriggerConfig);

        [NativeTypeName("#define FILE_BEGIN 0")]
        public const int FILE_BEGIN = 0;

        [NativeTypeName("#define FILE_CURRENT 1")]
        public const int FILE_CURRENT = 1;

        [NativeTypeName("#define FILE_END 2")]
        public const int FILE_END = 2;

        [NativeTypeName("#define WAIT_FAILED ((DWORD)0xFFFFFFFF)")]
        public const uint WAIT_FAILED = ((uint)(0xFFFFFFFF));

        [NativeTypeName("#define WAIT_OBJECT_0 ((STATUS_WAIT_0 ) + 0 )")]
        public const uint WAIT_OBJECT_0 = ((((uint)(0x00000000))) + 0);

        [NativeTypeName("#define WAIT_ABANDONED ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
        public const uint WAIT_ABANDONED = ((((uint)(0x00000080))) + 0);

        [NativeTypeName("#define WAIT_ABANDONED_0 ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
        public const uint WAIT_ABANDONED_0 = ((((uint)(0x00000080))) + 0);

        [NativeTypeName("#define WAIT_IO_COMPLETION STATUS_USER_APC")]
        public const uint WAIT_IO_COMPLETION = ((uint)(0x000000C0));

        [NativeTypeName("#define FILE_FLAG_WRITE_THROUGH 0x80000000")]
        public const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;

        [NativeTypeName("#define FILE_FLAG_OVERLAPPED 0x40000000")]
        public const int FILE_FLAG_OVERLAPPED = 0x40000000;

        [NativeTypeName("#define FILE_FLAG_NO_BUFFERING 0x20000000")]
        public const int FILE_FLAG_NO_BUFFERING = 0x20000000;

        [NativeTypeName("#define FILE_FLAG_RANDOM_ACCESS 0x10000000")]
        public const int FILE_FLAG_RANDOM_ACCESS = 0x10000000;

        [NativeTypeName("#define FILE_FLAG_SEQUENTIAL_SCAN 0x08000000")]
        public const int FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000;

        [NativeTypeName("#define FILE_FLAG_DELETE_ON_CLOSE 0x04000000")]
        public const int FILE_FLAG_DELETE_ON_CLOSE = 0x04000000;

        [NativeTypeName("#define FILE_FLAG_BACKUP_SEMANTICS 0x02000000")]
        public const int FILE_FLAG_BACKUP_SEMANTICS = 0x02000000;

        [NativeTypeName("#define FILE_FLAG_POSIX_SEMANTICS 0x01000000")]
        public const int FILE_FLAG_POSIX_SEMANTICS = 0x01000000;

        [NativeTypeName("#define FILE_FLAG_SESSION_AWARE 0x00800000")]
        public const int FILE_FLAG_SESSION_AWARE = 0x00800000;

        [NativeTypeName("#define FILE_FLAG_OPEN_REPARSE_POINT 0x00200000")]
        public const int FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000;

        [NativeTypeName("#define FILE_FLAG_OPEN_NO_RECALL 0x00100000")]
        public const int FILE_FLAG_OPEN_NO_RECALL = 0x00100000;

        [NativeTypeName("#define FILE_FLAG_FIRST_PIPE_INSTANCE 0x00080000")]
        public const int FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000;

        [NativeTypeName("#define FILE_FLAG_OPEN_REQUIRING_OPLOCK 0x00040000")]
        public const int FILE_FLAG_OPEN_REQUIRING_OPLOCK = 0x00040000;

        [NativeTypeName("#define PROGRESS_CONTINUE 0")]
        public const int PROGRESS_CONTINUE = 0;

        [NativeTypeName("#define PROGRESS_CANCEL 1")]
        public const int PROGRESS_CANCEL = 1;

        [NativeTypeName("#define PROGRESS_STOP 2")]
        public const int PROGRESS_STOP = 2;

        [NativeTypeName("#define PROGRESS_QUIET 3")]
        public const int PROGRESS_QUIET = 3;

        [NativeTypeName("#define CALLBACK_CHUNK_FINISHED 0x00000000")]
        public const int CALLBACK_CHUNK_FINISHED = 0x00000000;

        [NativeTypeName("#define CALLBACK_STREAM_SWITCH 0x00000001")]
        public const int CALLBACK_STREAM_SWITCH = 0x00000001;

        [NativeTypeName("#define COPY_FILE_FAIL_IF_EXISTS 0x00000001")]
        public const int COPY_FILE_FAIL_IF_EXISTS = 0x00000001;

        [NativeTypeName("#define COPY_FILE_RESTARTABLE 0x00000002")]
        public const int COPY_FILE_RESTARTABLE = 0x00000002;

        [NativeTypeName("#define COPY_FILE_OPEN_SOURCE_FOR_WRITE 0x00000004")]
        public const int COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004;

        [NativeTypeName("#define COPY_FILE_ALLOW_DECRYPTED_DESTINATION 0x00000008")]
        public const int COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008;

        [NativeTypeName("#define COPY_FILE_COPY_SYMLINK 0x00000800")]
        public const int COPY_FILE_COPY_SYMLINK = 0x00000800;

        [NativeTypeName("#define COPY_FILE_NO_BUFFERING 0x00001000")]
        public const int COPY_FILE_NO_BUFFERING = 0x00001000;

        [NativeTypeName("#define COPY_FILE_REQUEST_SECURITY_PRIVILEGES 0x00002000")]
        public const int COPY_FILE_REQUEST_SECURITY_PRIVILEGES = 0x00002000;

        [NativeTypeName("#define COPY_FILE_RESUME_FROM_PAUSE 0x00004000")]
        public const int COPY_FILE_RESUME_FROM_PAUSE = 0x00004000;

        [NativeTypeName("#define COPY_FILE_NO_OFFLOAD 0x00040000")]
        public const int COPY_FILE_NO_OFFLOAD = 0x00040000;

        [NativeTypeName("#define COPY_FILE_IGNORE_EDP_BLOCK 0x00400000")]
        public const int COPY_FILE_IGNORE_EDP_BLOCK = 0x00400000;

        [NativeTypeName("#define COPY_FILE_IGNORE_SOURCE_ENCRYPTION 0x00800000")]
        public const int COPY_FILE_IGNORE_SOURCE_ENCRYPTION = 0x00800000;

        [NativeTypeName("#define COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC 0x02000000")]
        public const int COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC = 0x02000000;

        [NativeTypeName("#define COPY_FILE_REQUEST_COMPRESSED_TRAFFIC 0x10000000")]
        public const int COPY_FILE_REQUEST_COMPRESSED_TRAFFIC = 0x10000000;

        [NativeTypeName("#define COPY_FILE_OPEN_AND_COPY_REPARSE_POINT 0x00200000")]
        public const int COPY_FILE_OPEN_AND_COPY_REPARSE_POINT = 0x00200000;

        [NativeTypeName("#define COPY_FILE_DIRECTORY 0x00000080")]
        public const int COPY_FILE_DIRECTORY = 0x00000080;

        [NativeTypeName("#define COPY_FILE_SKIP_ALTERNATE_STREAMS 0x00008000")]
        public const int COPY_FILE_SKIP_ALTERNATE_STREAMS = 0x00008000;

        [NativeTypeName("#define COPY_FILE_DISABLE_PRE_ALLOCATION 0x04000000")]
        public const int COPY_FILE_DISABLE_PRE_ALLOCATION = 0x04000000;

        [NativeTypeName("#define COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE 0x08000000")]
        public const int COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE = 0x08000000;

        [NativeTypeName("#define REPLACEFILE_WRITE_THROUGH 0x00000001")]
        public const int REPLACEFILE_WRITE_THROUGH = 0x00000001;

        [NativeTypeName("#define REPLACEFILE_IGNORE_MERGE_ERRORS 0x00000002")]
        public const int REPLACEFILE_IGNORE_MERGE_ERRORS = 0x00000002;

        [NativeTypeName("#define REPLACEFILE_IGNORE_ACL_ERRORS 0x00000004")]
        public const int REPLACEFILE_IGNORE_ACL_ERRORS = 0x00000004;

        [NativeTypeName("#define PIPE_ACCESS_INBOUND 0x00000001")]
        public const int PIPE_ACCESS_INBOUND = 0x00000001;

        [NativeTypeName("#define PIPE_ACCESS_OUTBOUND 0x00000002")]
        public const int PIPE_ACCESS_OUTBOUND = 0x00000002;

        [NativeTypeName("#define PIPE_ACCESS_DUPLEX 0x00000003")]
        public const int PIPE_ACCESS_DUPLEX = 0x00000003;

        [NativeTypeName("#define PIPE_CLIENT_END 0x00000000")]
        public const int PIPE_CLIENT_END = 0x00000000;

        [NativeTypeName("#define PIPE_SERVER_END 0x00000001")]
        public const int PIPE_SERVER_END = 0x00000001;

        [NativeTypeName("#define PIPE_WAIT 0x00000000")]
        public const int PIPE_WAIT = 0x00000000;

        [NativeTypeName("#define PIPE_NOWAIT 0x00000001")]
        public const int PIPE_NOWAIT = 0x00000001;

        [NativeTypeName("#define PIPE_READMODE_BYTE 0x00000000")]
        public const int PIPE_READMODE_BYTE = 0x00000000;

        [NativeTypeName("#define PIPE_READMODE_MESSAGE 0x00000002")]
        public const int PIPE_READMODE_MESSAGE = 0x00000002;

        [NativeTypeName("#define PIPE_TYPE_BYTE 0x00000000")]
        public const int PIPE_TYPE_BYTE = 0x00000000;

        [NativeTypeName("#define PIPE_TYPE_MESSAGE 0x00000004")]
        public const int PIPE_TYPE_MESSAGE = 0x00000004;

        [NativeTypeName("#define PIPE_ACCEPT_REMOTE_CLIENTS 0x00000000")]
        public const int PIPE_ACCEPT_REMOTE_CLIENTS = 0x00000000;

        [NativeTypeName("#define PIPE_REJECT_REMOTE_CLIENTS 0x00000008")]
        public const int PIPE_REJECT_REMOTE_CLIENTS = 0x00000008;

        [NativeTypeName("#define PIPE_UNLIMITED_INSTANCES 255")]
        public const int PIPE_UNLIMITED_INSTANCES = 255;

        [NativeTypeName("#define SECURITY_ANONYMOUS ( SecurityAnonymous      << 16 )")]
        public const int SECURITY_ANONYMOUS = ((int)(SecurityAnonymous) << 16);

        [NativeTypeName("#define SECURITY_IDENTIFICATION ( SecurityIdentification << 16 )")]
        public const int SECURITY_IDENTIFICATION = ((int)(SecurityIdentification) << 16);

        [NativeTypeName("#define SECURITY_IMPERSONATION ( SecurityImpersonation  << 16 )")]
        public const int SECURITY_IMPERSONATION = ((int)(SecurityImpersonation) << 16);

        [NativeTypeName("#define SECURITY_DELEGATION ( SecurityDelegation     << 16 )")]
        public const int SECURITY_DELEGATION = ((int)(SecurityDelegation) << 16);

        [NativeTypeName("#define SECURITY_CONTEXT_TRACKING 0x00040000")]
        public const int SECURITY_CONTEXT_TRACKING = 0x00040000;

        [NativeTypeName("#define SECURITY_EFFECTIVE_ONLY 0x00080000")]
        public const int SECURITY_EFFECTIVE_ONLY = 0x00080000;

        [NativeTypeName("#define SECURITY_SQOS_PRESENT 0x00100000")]
        public const int SECURITY_SQOS_PRESENT = 0x00100000;

        [NativeTypeName("#define SECURITY_VALID_SQOS_FLAGS 0x001F0000")]
        public const int SECURITY_VALID_SQOS_FLAGS = 0x001F0000;

        [NativeTypeName("#define FAIL_FAST_GENERATE_EXCEPTION_ADDRESS 0x1")]
        public const int FAIL_FAST_GENERATE_EXCEPTION_ADDRESS = 0x1;

        [NativeTypeName("#define FAIL_FAST_NO_HARD_ERROR_DLG 0x2")]
        public const int FAIL_FAST_NO_HARD_ERROR_DLG = 0x2;

        [NativeTypeName("#define SP_SERIALCOMM ((DWORD)0x00000001)")]
        public const uint SP_SERIALCOMM = ((uint)(0x00000001));

        [NativeTypeName("#define PST_UNSPECIFIED ((DWORD)0x00000000)")]
        public const uint PST_UNSPECIFIED = ((uint)(0x00000000));

        [NativeTypeName("#define PST_RS232 ((DWORD)0x00000001)")]
        public const uint PST_RS232 = ((uint)(0x00000001));

        [NativeTypeName("#define PST_PARALLELPORT ((DWORD)0x00000002)")]
        public const uint PST_PARALLELPORT = ((uint)(0x00000002));

        [NativeTypeName("#define PST_RS422 ((DWORD)0x00000003)")]
        public const uint PST_RS422 = ((uint)(0x00000003));

        [NativeTypeName("#define PST_RS423 ((DWORD)0x00000004)")]
        public const uint PST_RS423 = ((uint)(0x00000004));

        [NativeTypeName("#define PST_RS449 ((DWORD)0x00000005)")]
        public const uint PST_RS449 = ((uint)(0x00000005));

        [NativeTypeName("#define PST_MODEM ((DWORD)0x00000006)")]
        public const uint PST_MODEM = ((uint)(0x00000006));

        [NativeTypeName("#define PST_FAX ((DWORD)0x00000021)")]
        public const uint PST_FAX = ((uint)(0x00000021));

        [NativeTypeName("#define PST_SCANNER ((DWORD)0x00000022)")]
        public const uint PST_SCANNER = ((uint)(0x00000022));

        [NativeTypeName("#define PST_NETWORK_BRIDGE ((DWORD)0x00000100)")]
        public const uint PST_NETWORK_BRIDGE = ((uint)(0x00000100));

        [NativeTypeName("#define PST_LAT ((DWORD)0x00000101)")]
        public const uint PST_LAT = ((uint)(0x00000101));

        [NativeTypeName("#define PST_TCPIP_TELNET ((DWORD)0x00000102)")]
        public const uint PST_TCPIP_TELNET = ((uint)(0x00000102));

        [NativeTypeName("#define PST_X25 ((DWORD)0x00000103)")]
        public const uint PST_X25 = ((uint)(0x00000103));

        [NativeTypeName("#define PCF_DTRDSR ((DWORD)0x0001)")]
        public const uint PCF_DTRDSR = ((uint)(0x0001));

        [NativeTypeName("#define PCF_RTSCTS ((DWORD)0x0002)")]
        public const uint PCF_RTSCTS = ((uint)(0x0002));

        [NativeTypeName("#define PCF_RLSD ((DWORD)0x0004)")]
        public const uint PCF_RLSD = ((uint)(0x0004));

        [NativeTypeName("#define PCF_PARITY_CHECK ((DWORD)0x0008)")]
        public const uint PCF_PARITY_CHECK = ((uint)(0x0008));

        [NativeTypeName("#define PCF_XONXOFF ((DWORD)0x0010)")]
        public const uint PCF_XONXOFF = ((uint)(0x0010));

        [NativeTypeName("#define PCF_SETXCHAR ((DWORD)0x0020)")]
        public const uint PCF_SETXCHAR = ((uint)(0x0020));

        [NativeTypeName("#define PCF_TOTALTIMEOUTS ((DWORD)0x0040)")]
        public const uint PCF_TOTALTIMEOUTS = ((uint)(0x0040));

        [NativeTypeName("#define PCF_INTTIMEOUTS ((DWORD)0x0080)")]
        public const uint PCF_INTTIMEOUTS = ((uint)(0x0080));

        [NativeTypeName("#define PCF_SPECIALCHARS ((DWORD)0x0100)")]
        public const uint PCF_SPECIALCHARS = ((uint)(0x0100));

        [NativeTypeName("#define PCF_16BITMODE ((DWORD)0x0200)")]
        public const uint PCF_16BITMODE = ((uint)(0x0200));

        [NativeTypeName("#define SP_PARITY ((DWORD)0x0001)")]
        public const uint SP_PARITY = ((uint)(0x0001));

        [NativeTypeName("#define SP_BAUD ((DWORD)0x0002)")]
        public const uint SP_BAUD = ((uint)(0x0002));

        [NativeTypeName("#define SP_DATABITS ((DWORD)0x0004)")]
        public const uint SP_DATABITS = ((uint)(0x0004));

        [NativeTypeName("#define SP_STOPBITS ((DWORD)0x0008)")]
        public const uint SP_STOPBITS = ((uint)(0x0008));

        [NativeTypeName("#define SP_HANDSHAKING ((DWORD)0x0010)")]
        public const uint SP_HANDSHAKING = ((uint)(0x0010));

        [NativeTypeName("#define SP_PARITY_CHECK ((DWORD)0x0020)")]
        public const uint SP_PARITY_CHECK = ((uint)(0x0020));

        [NativeTypeName("#define SP_RLSD ((DWORD)0x0040)")]
        public const uint SP_RLSD = ((uint)(0x0040));

        [NativeTypeName("#define BAUD_075 ((DWORD)0x00000001)")]
        public const uint BAUD_075 = ((uint)(0x00000001));

        [NativeTypeName("#define BAUD_110 ((DWORD)0x00000002)")]
        public const uint BAUD_110 = ((uint)(0x00000002));

        [NativeTypeName("#define BAUD_134_5 ((DWORD)0x00000004)")]
        public const uint BAUD_134_5 = ((uint)(0x00000004));

        [NativeTypeName("#define BAUD_150 ((DWORD)0x00000008)")]
        public const uint BAUD_150 = ((uint)(0x00000008));

        [NativeTypeName("#define BAUD_300 ((DWORD)0x00000010)")]
        public const uint BAUD_300 = ((uint)(0x00000010));

        [NativeTypeName("#define BAUD_600 ((DWORD)0x00000020)")]
        public const uint BAUD_600 = ((uint)(0x00000020));

        [NativeTypeName("#define BAUD_1200 ((DWORD)0x00000040)")]
        public const uint BAUD_1200 = ((uint)(0x00000040));

        [NativeTypeName("#define BAUD_1800 ((DWORD)0x00000080)")]
        public const uint BAUD_1800 = ((uint)(0x00000080));

        [NativeTypeName("#define BAUD_2400 ((DWORD)0x00000100)")]
        public const uint BAUD_2400 = ((uint)(0x00000100));

        [NativeTypeName("#define BAUD_4800 ((DWORD)0x00000200)")]
        public const uint BAUD_4800 = ((uint)(0x00000200));

        [NativeTypeName("#define BAUD_7200 ((DWORD)0x00000400)")]
        public const uint BAUD_7200 = ((uint)(0x00000400));

        [NativeTypeName("#define BAUD_9600 ((DWORD)0x00000800)")]
        public const uint BAUD_9600 = ((uint)(0x00000800));

        [NativeTypeName("#define BAUD_14400 ((DWORD)0x00001000)")]
        public const uint BAUD_14400 = ((uint)(0x00001000));

        [NativeTypeName("#define BAUD_19200 ((DWORD)0x00002000)")]
        public const uint BAUD_19200 = ((uint)(0x00002000));

        [NativeTypeName("#define BAUD_38400 ((DWORD)0x00004000)")]
        public const uint BAUD_38400 = ((uint)(0x00004000));

        [NativeTypeName("#define BAUD_56K ((DWORD)0x00008000)")]
        public const uint BAUD_56K = ((uint)(0x00008000));

        [NativeTypeName("#define BAUD_128K ((DWORD)0x00010000)")]
        public const uint BAUD_128K = ((uint)(0x00010000));

        [NativeTypeName("#define BAUD_115200 ((DWORD)0x00020000)")]
        public const uint BAUD_115200 = ((uint)(0x00020000));

        [NativeTypeName("#define BAUD_57600 ((DWORD)0x00040000)")]
        public const uint BAUD_57600 = ((uint)(0x00040000));

        [NativeTypeName("#define BAUD_USER ((DWORD)0x10000000)")]
        public const uint BAUD_USER = ((uint)(0x10000000));

        [NativeTypeName("#define DATABITS_5 ((WORD)0x0001)")]
        public const ushort DATABITS_5 = ((ushort)(0x0001));

        [NativeTypeName("#define DATABITS_6 ((WORD)0x0002)")]
        public const ushort DATABITS_6 = ((ushort)(0x0002));

        [NativeTypeName("#define DATABITS_7 ((WORD)0x0004)")]
        public const ushort DATABITS_7 = ((ushort)(0x0004));

        [NativeTypeName("#define DATABITS_8 ((WORD)0x0008)")]
        public const ushort DATABITS_8 = ((ushort)(0x0008));

        [NativeTypeName("#define DATABITS_16 ((WORD)0x0010)")]
        public const ushort DATABITS_16 = ((ushort)(0x0010));

        [NativeTypeName("#define DATABITS_16X ((WORD)0x0020)")]
        public const ushort DATABITS_16X = ((ushort)(0x0020));

        [NativeTypeName("#define STOPBITS_10 ((WORD)0x0001)")]
        public const ushort STOPBITS_10 = ((ushort)(0x0001));

        [NativeTypeName("#define STOPBITS_15 ((WORD)0x0002)")]
        public const ushort STOPBITS_15 = ((ushort)(0x0002));

        [NativeTypeName("#define STOPBITS_20 ((WORD)0x0004)")]
        public const ushort STOPBITS_20 = ((ushort)(0x0004));

        [NativeTypeName("#define PARITY_NONE ((WORD)0x0100)")]
        public const ushort PARITY_NONE = ((ushort)(0x0100));

        [NativeTypeName("#define PARITY_ODD ((WORD)0x0200)")]
        public const ushort PARITY_ODD = ((ushort)(0x0200));

        [NativeTypeName("#define PARITY_EVEN ((WORD)0x0400)")]
        public const ushort PARITY_EVEN = ((ushort)(0x0400));

        [NativeTypeName("#define PARITY_MARK ((WORD)0x0800)")]
        public const ushort PARITY_MARK = ((ushort)(0x0800));

        [NativeTypeName("#define PARITY_SPACE ((WORD)0x1000)")]
        public const ushort PARITY_SPACE = ((ushort)(0x1000));

        [NativeTypeName("#define COMMPROP_INITIALIZED ((DWORD)0xE73CF52E)")]
        public const uint COMMPROP_INITIALIZED = ((uint)(0xE73CF52E));

        [NativeTypeName("#define DTR_CONTROL_DISABLE 0x00")]
        public const int DTR_CONTROL_DISABLE = 0x00;

        [NativeTypeName("#define DTR_CONTROL_ENABLE 0x01")]
        public const int DTR_CONTROL_ENABLE = 0x01;

        [NativeTypeName("#define DTR_CONTROL_HANDSHAKE 0x02")]
        public const int DTR_CONTROL_HANDSHAKE = 0x02;

        [NativeTypeName("#define RTS_CONTROL_DISABLE 0x00")]
        public const int RTS_CONTROL_DISABLE = 0x00;

        [NativeTypeName("#define RTS_CONTROL_ENABLE 0x01")]
        public const int RTS_CONTROL_ENABLE = 0x01;

        [NativeTypeName("#define RTS_CONTROL_HANDSHAKE 0x02")]
        public const int RTS_CONTROL_HANDSHAKE = 0x02;

        [NativeTypeName("#define RTS_CONTROL_TOGGLE 0x03")]
        public const int RTS_CONTROL_TOGGLE = 0x03;

        [NativeTypeName("#define GMEM_FIXED 0x0000")]
        public const int GMEM_FIXED = 0x0000;

        [NativeTypeName("#define GMEM_MOVEABLE 0x0002")]
        public const int GMEM_MOVEABLE = 0x0002;

        [NativeTypeName("#define GMEM_NOCOMPACT 0x0010")]
        public const int GMEM_NOCOMPACT = 0x0010;

        [NativeTypeName("#define GMEM_NODISCARD 0x0020")]
        public const int GMEM_NODISCARD = 0x0020;

        [NativeTypeName("#define GMEM_ZEROINIT 0x0040")]
        public const int GMEM_ZEROINIT = 0x0040;

        [NativeTypeName("#define GMEM_MODIFY 0x0080")]
        public const int GMEM_MODIFY = 0x0080;

        [NativeTypeName("#define GMEM_DISCARDABLE 0x0100")]
        public const int GMEM_DISCARDABLE = 0x0100;

        [NativeTypeName("#define GMEM_NOT_BANKED 0x1000")]
        public const int GMEM_NOT_BANKED = 0x1000;

        [NativeTypeName("#define GMEM_SHARE 0x2000")]
        public const int GMEM_SHARE = 0x2000;

        [NativeTypeName("#define GMEM_DDESHARE 0x2000")]
        public const int GMEM_DDESHARE = 0x2000;

        [NativeTypeName("#define GMEM_NOTIFY 0x4000")]
        public const int GMEM_NOTIFY = 0x4000;

        [NativeTypeName("#define GMEM_LOWER GMEM_NOT_BANKED")]
        public const int GMEM_LOWER = 0x1000;

        [NativeTypeName("#define GMEM_VALID_FLAGS 0x7F72")]
        public const int GMEM_VALID_FLAGS = 0x7F72;

        [NativeTypeName("#define GMEM_INVALID_HANDLE 0x8000")]
        public const int GMEM_INVALID_HANDLE = 0x8000;

        [NativeTypeName("#define GHND (GMEM_MOVEABLE | GMEM_ZEROINIT)")]
        public const int GHND = (0x0002 | 0x0040);

        [NativeTypeName("#define GPTR (GMEM_FIXED | GMEM_ZEROINIT)")]
        public const int GPTR = (0x0000 | 0x0040);

        [NativeTypeName("#define GMEM_DISCARDED 0x4000")]
        public const int GMEM_DISCARDED = 0x4000;

        [NativeTypeName("#define GMEM_LOCKCOUNT 0x00FF")]
        public const int GMEM_LOCKCOUNT = 0x00FF;

        [NativeTypeName("#define DEBUG_PROCESS 0x00000001")]
        public const int DEBUG_PROCESS = 0x00000001;

        [NativeTypeName("#define DEBUG_ONLY_THIS_PROCESS 0x00000002")]
        public const int DEBUG_ONLY_THIS_PROCESS = 0x00000002;

        [NativeTypeName("#define CREATE_SUSPENDED 0x00000004")]
        public const int CREATE_SUSPENDED = 0x00000004;

        [NativeTypeName("#define DETACHED_PROCESS 0x00000008")]
        public const int DETACHED_PROCESS = 0x00000008;

        [NativeTypeName("#define CREATE_NEW_CONSOLE 0x00000010")]
        public const int CREATE_NEW_CONSOLE = 0x00000010;

        [NativeTypeName("#define NORMAL_PRIORITY_CLASS 0x00000020")]
        public const int NORMAL_PRIORITY_CLASS = 0x00000020;

        [NativeTypeName("#define IDLE_PRIORITY_CLASS 0x00000040")]
        public const int IDLE_PRIORITY_CLASS = 0x00000040;

        [NativeTypeName("#define HIGH_PRIORITY_CLASS 0x00000080")]
        public const int HIGH_PRIORITY_CLASS = 0x00000080;

        [NativeTypeName("#define REALTIME_PRIORITY_CLASS 0x00000100")]
        public const int REALTIME_PRIORITY_CLASS = 0x00000100;

        [NativeTypeName("#define CREATE_NEW_PROCESS_GROUP 0x00000200")]
        public const int CREATE_NEW_PROCESS_GROUP = 0x00000200;

        [NativeTypeName("#define CREATE_UNICODE_ENVIRONMENT 0x00000400")]
        public const int CREATE_UNICODE_ENVIRONMENT = 0x00000400;

        [NativeTypeName("#define CREATE_SEPARATE_WOW_VDM 0x00000800")]
        public const int CREATE_SEPARATE_WOW_VDM = 0x00000800;

        [NativeTypeName("#define CREATE_SHARED_WOW_VDM 0x00001000")]
        public const int CREATE_SHARED_WOW_VDM = 0x00001000;

        [NativeTypeName("#define CREATE_FORCEDOS 0x00002000")]
        public const int CREATE_FORCEDOS = 0x00002000;

        [NativeTypeName("#define BELOW_NORMAL_PRIORITY_CLASS 0x00004000")]
        public const int BELOW_NORMAL_PRIORITY_CLASS = 0x00004000;

        [NativeTypeName("#define ABOVE_NORMAL_PRIORITY_CLASS 0x00008000")]
        public const int ABOVE_NORMAL_PRIORITY_CLASS = 0x00008000;

        [NativeTypeName("#define INHERIT_PARENT_AFFINITY 0x00010000")]
        public const int INHERIT_PARENT_AFFINITY = 0x00010000;

        [NativeTypeName("#define INHERIT_CALLER_PRIORITY 0x00020000")]
        public const int INHERIT_CALLER_PRIORITY = 0x00020000;

        [NativeTypeName("#define CREATE_PROTECTED_PROCESS 0x00040000")]
        public const int CREATE_PROTECTED_PROCESS = 0x00040000;

        [NativeTypeName("#define EXTENDED_STARTUPINFO_PRESENT 0x00080000")]
        public const int EXTENDED_STARTUPINFO_PRESENT = 0x00080000;

        [NativeTypeName("#define PROCESS_MODE_BACKGROUND_BEGIN 0x00100000")]
        public const int PROCESS_MODE_BACKGROUND_BEGIN = 0x00100000;

        [NativeTypeName("#define PROCESS_MODE_BACKGROUND_END 0x00200000")]
        public const int PROCESS_MODE_BACKGROUND_END = 0x00200000;

        [NativeTypeName("#define CREATE_SECURE_PROCESS 0x00400000")]
        public const int CREATE_SECURE_PROCESS = 0x00400000;

        [NativeTypeName("#define CREATE_BREAKAWAY_FROM_JOB 0x01000000")]
        public const int CREATE_BREAKAWAY_FROM_JOB = 0x01000000;

        [NativeTypeName("#define CREATE_PRESERVE_CODE_AUTHZ_LEVEL 0x02000000")]
        public const int CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x02000000;

        [NativeTypeName("#define CREATE_DEFAULT_ERROR_MODE 0x04000000")]
        public const int CREATE_DEFAULT_ERROR_MODE = 0x04000000;

        [NativeTypeName("#define CREATE_NO_WINDOW 0x08000000")]
        public const int CREATE_NO_WINDOW = 0x08000000;

        [NativeTypeName("#define PROFILE_USER 0x10000000")]
        public const int PROFILE_USER = 0x10000000;

        [NativeTypeName("#define PROFILE_KERNEL 0x20000000")]
        public const int PROFILE_KERNEL = 0x20000000;

        [NativeTypeName("#define PROFILE_SERVER 0x40000000")]
        public const int PROFILE_SERVER = 0x40000000;

        [NativeTypeName("#define CREATE_IGNORE_SYSTEM_DEFAULT 0x80000000")]
        public const uint CREATE_IGNORE_SYSTEM_DEFAULT = 0x80000000;

        [NativeTypeName("#define STACK_SIZE_PARAM_IS_A_RESERVATION 0x00010000")]
        public const int STACK_SIZE_PARAM_IS_A_RESERVATION = 0x00010000;

        [NativeTypeName("#define THREAD_PRIORITY_LOWEST THREAD_BASE_PRIORITY_MIN")]
        public const int THREAD_PRIORITY_LOWEST = (-2);

        [NativeTypeName("#define THREAD_PRIORITY_BELOW_NORMAL (THREAD_PRIORITY_LOWEST+1)")]
        public const int THREAD_PRIORITY_BELOW_NORMAL = ((-2) + 1);

        [NativeTypeName("#define THREAD_PRIORITY_NORMAL 0")]
        public const int THREAD_PRIORITY_NORMAL = 0;

        [NativeTypeName("#define THREAD_PRIORITY_HIGHEST THREAD_BASE_PRIORITY_MAX")]
        public const int THREAD_PRIORITY_HIGHEST = 2;

        [NativeTypeName("#define THREAD_PRIORITY_ABOVE_NORMAL (THREAD_PRIORITY_HIGHEST-1)")]
        public const int THREAD_PRIORITY_ABOVE_NORMAL = (2 - 1);

        [NativeTypeName("#define THREAD_PRIORITY_ERROR_RETURN (MAXLONG)")]
        public const int THREAD_PRIORITY_ERROR_RETURN = (0x7fffffff);

        [NativeTypeName("#define THREAD_PRIORITY_TIME_CRITICAL THREAD_BASE_PRIORITY_LOWRT")]
        public const int THREAD_PRIORITY_TIME_CRITICAL = 15;

        [NativeTypeName("#define THREAD_PRIORITY_IDLE THREAD_BASE_PRIORITY_IDLE")]
        public const int THREAD_PRIORITY_IDLE = (-15);

        [NativeTypeName("#define THREAD_MODE_BACKGROUND_BEGIN 0x00010000")]
        public const int THREAD_MODE_BACKGROUND_BEGIN = 0x00010000;

        [NativeTypeName("#define THREAD_MODE_BACKGROUND_END 0x00020000")]
        public const int THREAD_MODE_BACKGROUND_END = 0x00020000;

        [NativeTypeName("#define VOLUME_NAME_DOS 0x0")]
        public const int VOLUME_NAME_DOS = 0x0;

        [NativeTypeName("#define VOLUME_NAME_GUID 0x1")]
        public const int VOLUME_NAME_GUID = 0x1;

        [NativeTypeName("#define VOLUME_NAME_NT 0x2")]
        public const int VOLUME_NAME_NT = 0x2;

        [NativeTypeName("#define VOLUME_NAME_NONE 0x4")]
        public const int VOLUME_NAME_NONE = 0x4;

        [NativeTypeName("#define FILE_NAME_NORMALIZED 0x0")]
        public const int FILE_NAME_NORMALIZED = 0x0;

        [NativeTypeName("#define FILE_NAME_OPENED 0x8")]
        public const int FILE_NAME_OPENED = 0x8;

        [NativeTypeName("#define DRIVE_UNKNOWN 0")]
        public const int DRIVE_UNKNOWN = 0;

        [NativeTypeName("#define DRIVE_NO_ROOT_DIR 1")]
        public const int DRIVE_NO_ROOT_DIR = 1;

        [NativeTypeName("#define DRIVE_REMOVABLE 2")]
        public const int DRIVE_REMOVABLE = 2;

        [NativeTypeName("#define DRIVE_FIXED 3")]
        public const int DRIVE_FIXED = 3;

        [NativeTypeName("#define DRIVE_REMOTE 4")]
        public const int DRIVE_REMOTE = 4;

        [NativeTypeName("#define DRIVE_CDROM 5")]
        public const int DRIVE_CDROM = 5;

        [NativeTypeName("#define DRIVE_RAMDISK 6")]
        public const int DRIVE_RAMDISK = 6;

        [NativeTypeName("#define FILE_TYPE_UNKNOWN 0x0000")]
        public const int FILE_TYPE_UNKNOWN = 0x0000;

        [NativeTypeName("#define FILE_TYPE_DISK 0x0001")]
        public const int FILE_TYPE_DISK = 0x0001;

        [NativeTypeName("#define FILE_TYPE_CHAR 0x0002")]
        public const int FILE_TYPE_CHAR = 0x0002;

        [NativeTypeName("#define FILE_TYPE_PIPE 0x0003")]
        public const int FILE_TYPE_PIPE = 0x0003;

        [NativeTypeName("#define FILE_TYPE_REMOTE 0x8000")]
        public const int FILE_TYPE_REMOTE = 0x8000;

        [NativeTypeName("#define STD_INPUT_HANDLE ((DWORD)-10)")]
        public const uint STD_INPUT_HANDLE = unchecked((uint)(-10));

        [NativeTypeName("#define STD_OUTPUT_HANDLE ((DWORD)-11)")]
        public const uint STD_OUTPUT_HANDLE = unchecked((uint)(-11));

        [NativeTypeName("#define STD_ERROR_HANDLE ((DWORD)-12)")]
        public const uint STD_ERROR_HANDLE = unchecked((uint)(-12));

        [NativeTypeName("#define NOPARITY 0")]
        public const int NOPARITY = 0;

        [NativeTypeName("#define ODDPARITY 1")]
        public const int ODDPARITY = 1;

        [NativeTypeName("#define EVENPARITY 2")]
        public const int EVENPARITY = 2;

        [NativeTypeName("#define MARKPARITY 3")]
        public const int MARKPARITY = 3;

        [NativeTypeName("#define SPACEPARITY 4")]
        public const int SPACEPARITY = 4;

        [NativeTypeName("#define ONESTOPBIT 0")]
        public const int ONESTOPBIT = 0;

        [NativeTypeName("#define ONE5STOPBITS 1")]
        public const int ONE5STOPBITS = 1;

        [NativeTypeName("#define TWOSTOPBITS 2")]
        public const int TWOSTOPBITS = 2;

        [NativeTypeName("#define IGNORE 0")]
        public const int IGNORE = 0;

        [NativeTypeName("#define INFINITE 0xFFFFFFFF")]
        public const uint INFINITE = 0xFFFFFFFF;

        [NativeTypeName("#define CBR_110 110")]
        public const int CBR_110 = 110;

        [NativeTypeName("#define CBR_300 300")]
        public const int CBR_300 = 300;

        [NativeTypeName("#define CBR_600 600")]
        public const int CBR_600 = 600;

        [NativeTypeName("#define CBR_1200 1200")]
        public const int CBR_1200 = 1200;

        [NativeTypeName("#define CBR_2400 2400")]
        public const int CBR_2400 = 2400;

        [NativeTypeName("#define CBR_4800 4800")]
        public const int CBR_4800 = 4800;

        [NativeTypeName("#define CBR_9600 9600")]
        public const int CBR_9600 = 9600;

        [NativeTypeName("#define CBR_14400 14400")]
        public const int CBR_14400 = 14400;

        [NativeTypeName("#define CBR_19200 19200")]
        public const int CBR_19200 = 19200;

        [NativeTypeName("#define CBR_38400 38400")]
        public const int CBR_38400 = 38400;

        [NativeTypeName("#define CBR_56000 56000")]
        public const int CBR_56000 = 56000;

        [NativeTypeName("#define CBR_57600 57600")]
        public const int CBR_57600 = 57600;

        [NativeTypeName("#define CBR_115200 115200")]
        public const int CBR_115200 = 115200;

        [NativeTypeName("#define CBR_128000 128000")]
        public const int CBR_128000 = 128000;

        [NativeTypeName("#define CBR_256000 256000")]
        public const int CBR_256000 = 256000;

        [NativeTypeName("#define CE_RXOVER 0x0001")]
        public const int CE_RXOVER = 0x0001;

        [NativeTypeName("#define CE_OVERRUN 0x0002")]
        public const int CE_OVERRUN = 0x0002;

        [NativeTypeName("#define CE_RXPARITY 0x0004")]
        public const int CE_RXPARITY = 0x0004;

        [NativeTypeName("#define CE_FRAME 0x0008")]
        public const int CE_FRAME = 0x0008;

        [NativeTypeName("#define CE_BREAK 0x0010")]
        public const int CE_BREAK = 0x0010;

        [NativeTypeName("#define CE_TXFULL 0x0100")]
        public const int CE_TXFULL = 0x0100;

        [NativeTypeName("#define CE_PTO 0x0200")]
        public const int CE_PTO = 0x0200;

        [NativeTypeName("#define CE_IOE 0x0400")]
        public const int CE_IOE = 0x0400;

        [NativeTypeName("#define CE_DNS 0x0800")]
        public const int CE_DNS = 0x0800;

        [NativeTypeName("#define CE_OOP 0x1000")]
        public const int CE_OOP = 0x1000;

        [NativeTypeName("#define CE_MODE 0x8000")]
        public const int CE_MODE = 0x8000;

        [NativeTypeName("#define IE_BADID (-1)")]
        public const int IE_BADID = (-1);

        [NativeTypeName("#define IE_OPEN (-2)")]
        public const int IE_OPEN = (-2);

        [NativeTypeName("#define IE_NOPEN (-3)")]
        public const int IE_NOPEN = (-3);

        [NativeTypeName("#define IE_MEMORY (-4)")]
        public const int IE_MEMORY = (-4);

        [NativeTypeName("#define IE_DEFAULT (-5)")]
        public const int IE_DEFAULT = (-5);

        [NativeTypeName("#define IE_HARDWARE (-10)")]
        public const int IE_HARDWARE = (-10);

        [NativeTypeName("#define IE_BYTESIZE (-11)")]
        public const int IE_BYTESIZE = (-11);

        [NativeTypeName("#define IE_BAUDRATE (-12)")]
        public const int IE_BAUDRATE = (-12);

        [NativeTypeName("#define EV_RXCHAR 0x0001")]
        public const int EV_RXCHAR = 0x0001;

        [NativeTypeName("#define EV_RXFLAG 0x0002")]
        public const int EV_RXFLAG = 0x0002;

        [NativeTypeName("#define EV_TXEMPTY 0x0004")]
        public const int EV_TXEMPTY = 0x0004;

        [NativeTypeName("#define EV_CTS 0x0008")]
        public const int EV_CTS = 0x0008;

        [NativeTypeName("#define EV_DSR 0x0010")]
        public const int EV_DSR = 0x0010;

        [NativeTypeName("#define EV_RLSD 0x0020")]
        public const int EV_RLSD = 0x0020;

        [NativeTypeName("#define EV_BREAK 0x0040")]
        public const int EV_BREAK = 0x0040;

        [NativeTypeName("#define EV_ERR 0x0080")]
        public const int EV_ERR = 0x0080;

        [NativeTypeName("#define EV_RING 0x0100")]
        public const int EV_RING = 0x0100;

        [NativeTypeName("#define EV_PERR 0x0200")]
        public const int EV_PERR = 0x0200;

        [NativeTypeName("#define EV_RX80FULL 0x0400")]
        public const int EV_RX80FULL = 0x0400;

        [NativeTypeName("#define EV_EVENT1 0x0800")]
        public const int EV_EVENT1 = 0x0800;

        [NativeTypeName("#define EV_EVENT2 0x1000")]
        public const int EV_EVENT2 = 0x1000;

        [NativeTypeName("#define SETXOFF 1")]
        public const int SETXOFF = 1;

        [NativeTypeName("#define SETXON 2")]
        public const int SETXON = 2;

        [NativeTypeName("#define SETRTS 3")]
        public const int SETRTS = 3;

        [NativeTypeName("#define CLRRTS 4")]
        public const int CLRRTS = 4;

        [NativeTypeName("#define SETDTR 5")]
        public const int SETDTR = 5;

        [NativeTypeName("#define CLRDTR 6")]
        public const int CLRDTR = 6;

        [NativeTypeName("#define RESETDEV 7")]
        public const int RESETDEV = 7;

        [NativeTypeName("#define SETBREAK 8")]
        public const int SETBREAK = 8;

        [NativeTypeName("#define CLRBREAK 9")]
        public const int CLRBREAK = 9;

        [NativeTypeName("#define PURGE_TXABORT 0x0001")]
        public const int PURGE_TXABORT = 0x0001;

        [NativeTypeName("#define PURGE_RXABORT 0x0002")]
        public const int PURGE_RXABORT = 0x0002;

        [NativeTypeName("#define PURGE_TXCLEAR 0x0004")]
        public const int PURGE_TXCLEAR = 0x0004;

        [NativeTypeName("#define PURGE_RXCLEAR 0x0008")]
        public const int PURGE_RXCLEAR = 0x0008;

        [NativeTypeName("#define LPTx 0x80")]
        public const int LPTx = 0x80;

        [NativeTypeName("#define MS_CTS_ON ((DWORD)0x0010)")]
        public const uint MS_CTS_ON = ((uint)(0x0010));

        [NativeTypeName("#define MS_DSR_ON ((DWORD)0x0020)")]
        public const uint MS_DSR_ON = ((uint)(0x0020));

        [NativeTypeName("#define MS_RING_ON ((DWORD)0x0040)")]
        public const uint MS_RING_ON = ((uint)(0x0040));

        [NativeTypeName("#define MS_RLSD_ON ((DWORD)0x0080)")]
        public const uint MS_RLSD_ON = ((uint)(0x0080));

        [NativeTypeName("#define S_QUEUEEMPTY 0")]
        public const int S_QUEUEEMPTY = 0;

        [NativeTypeName("#define S_THRESHOLD 1")]
        public const int S_THRESHOLD = 1;

        [NativeTypeName("#define S_ALLTHRESHOLD 2")]
        public const int S_ALLTHRESHOLD = 2;

        [NativeTypeName("#define S_NORMAL 0")]
        public const int S_NORMAL = 0;

        [NativeTypeName("#define S_LEGATO 1")]
        public const int S_LEGATO = 1;

        [NativeTypeName("#define S_STACCATO 2")]
        public const int S_STACCATO = 2;

        [NativeTypeName("#define S_PERIOD512 0")]
        public const int S_PERIOD512 = 0;

        [NativeTypeName("#define S_PERIOD1024 1")]
        public const int S_PERIOD1024 = 1;

        [NativeTypeName("#define S_PERIOD2048 2")]
        public const int S_PERIOD2048 = 2;

        [NativeTypeName("#define S_PERIODVOICE 3")]
        public const int S_PERIODVOICE = 3;

        [NativeTypeName("#define S_WHITE512 4")]
        public const int S_WHITE512 = 4;

        [NativeTypeName("#define S_WHITE1024 5")]
        public const int S_WHITE1024 = 5;

        [NativeTypeName("#define S_WHITE2048 6")]
        public const int S_WHITE2048 = 6;

        [NativeTypeName("#define S_WHITEVOICE 7")]
        public const int S_WHITEVOICE = 7;

        [NativeTypeName("#define S_SERDVNA (-1)")]
        public const int S_SERDVNA = (-1);

        [NativeTypeName("#define S_SEROFM (-2)")]
        public const int S_SEROFM = (-2);

        [NativeTypeName("#define S_SERMACT (-3)")]
        public const int S_SERMACT = (-3);

        [NativeTypeName("#define S_SERQFUL (-4)")]
        public const int S_SERQFUL = (-4);

        [NativeTypeName("#define S_SERBDNT (-5)")]
        public const int S_SERBDNT = (-5);

        [NativeTypeName("#define S_SERDLN (-6)")]
        public const int S_SERDLN = (-6);

        [NativeTypeName("#define S_SERDCC (-7)")]
        public const int S_SERDCC = (-7);

        [NativeTypeName("#define S_SERDTP (-8)")]
        public const int S_SERDTP = (-8);

        [NativeTypeName("#define S_SERDVL (-9)")]
        public const int S_SERDVL = (-9);

        [NativeTypeName("#define S_SERDMD (-10)")]
        public const int S_SERDMD = (-10);

        [NativeTypeName("#define S_SERDSH (-11)")]
        public const int S_SERDSH = (-11);

        [NativeTypeName("#define S_SERDPT (-12)")]
        public const int S_SERDPT = (-12);

        [NativeTypeName("#define S_SERDFQ (-13)")]
        public const int S_SERDFQ = (-13);

        [NativeTypeName("#define S_SERDDR (-14)")]
        public const int S_SERDDR = (-14);

        [NativeTypeName("#define S_SERDSR (-15)")]
        public const int S_SERDSR = (-15);

        [NativeTypeName("#define S_SERDST (-16)")]
        public const int S_SERDST = (-16);

        [NativeTypeName("#define NMPWAIT_WAIT_FOREVER 0xffffffff")]
        public const uint NMPWAIT_WAIT_FOREVER = 0xffffffff;

        [NativeTypeName("#define NMPWAIT_NOWAIT 0x00000001")]
        public const int NMPWAIT_NOWAIT = 0x00000001;

        [NativeTypeName("#define NMPWAIT_USE_DEFAULT_WAIT 0x00000000")]
        public const int NMPWAIT_USE_DEFAULT_WAIT = 0x00000000;

        [NativeTypeName("#define FS_CASE_IS_PRESERVED FILE_CASE_PRESERVED_NAMES")]
        public const int FS_CASE_IS_PRESERVED = 0x00000002;

        [NativeTypeName("#define FS_CASE_SENSITIVE FILE_CASE_SENSITIVE_SEARCH")]
        public const int FS_CASE_SENSITIVE = 0x00000001;

        [NativeTypeName("#define FS_UNICODE_STORED_ON_DISK FILE_UNICODE_ON_DISK")]
        public const int FS_UNICODE_STORED_ON_DISK = 0x00000004;

        [NativeTypeName("#define FS_PERSISTENT_ACLS FILE_PERSISTENT_ACLS")]
        public const int FS_PERSISTENT_ACLS = 0x00000008;

        [NativeTypeName("#define FS_VOL_IS_COMPRESSED FILE_VOLUME_IS_COMPRESSED")]
        public const int FS_VOL_IS_COMPRESSED = 0x00008000;

        [NativeTypeName("#define FS_FILE_COMPRESSION FILE_FILE_COMPRESSION")]
        public const int FS_FILE_COMPRESSION = 0x00000010;

        [NativeTypeName("#define FS_FILE_ENCRYPTION FILE_SUPPORTS_ENCRYPTION")]
        public const int FS_FILE_ENCRYPTION = 0x00020000;

        [NativeTypeName("#define OF_READ 0x00000000")]
        public const int OF_READ = 0x00000000;

        [NativeTypeName("#define OF_WRITE 0x00000001")]
        public const int OF_WRITE = 0x00000001;

        [NativeTypeName("#define OF_READWRITE 0x00000002")]
        public const int OF_READWRITE = 0x00000002;

        [NativeTypeName("#define OF_SHARE_COMPAT 0x00000000")]
        public const int OF_SHARE_COMPAT = 0x00000000;

        [NativeTypeName("#define OF_SHARE_EXCLUSIVE 0x00000010")]
        public const int OF_SHARE_EXCLUSIVE = 0x00000010;

        [NativeTypeName("#define OF_SHARE_DENY_WRITE 0x00000020")]
        public const int OF_SHARE_DENY_WRITE = 0x00000020;

        [NativeTypeName("#define OF_SHARE_DENY_READ 0x00000030")]
        public const int OF_SHARE_DENY_READ = 0x00000030;

        [NativeTypeName("#define OF_SHARE_DENY_NONE 0x00000040")]
        public const int OF_SHARE_DENY_NONE = 0x00000040;

        [NativeTypeName("#define OF_PARSE 0x00000100")]
        public const int OF_PARSE = 0x00000100;

        [NativeTypeName("#define OF_DELETE 0x00000200")]
        public const int OF_DELETE = 0x00000200;

        [NativeTypeName("#define OF_VERIFY 0x00000400")]
        public const int OF_VERIFY = 0x00000400;

        [NativeTypeName("#define OF_CANCEL 0x00000800")]
        public const int OF_CANCEL = 0x00000800;

        [NativeTypeName("#define OF_CREATE 0x00001000")]
        public const int OF_CREATE = 0x00001000;

        [NativeTypeName("#define OF_PROMPT 0x00002000")]
        public const int OF_PROMPT = 0x00002000;

        [NativeTypeName("#define OF_EXIST 0x00004000")]
        public const int OF_EXIST = 0x00004000;

        [NativeTypeName("#define OF_REOPEN 0x00008000")]
        public const int OF_REOPEN = 0x00008000;

        [NativeTypeName("#define OFS_MAXPATHNAME 128")]
        public const int OFS_MAXPATHNAME = 128;

        [NativeTypeName("#define MAXINTATOM 0xC000")]
        public const int MAXINTATOM = 0xC000;

        [NativeTypeName("#define INVALID_ATOM ((ATOM)0)")]
        public const ushort INVALID_ATOM = ((ushort)(0));

        [NativeTypeName("#define SCS_32BIT_BINARY 0")]
        public const int SCS_32BIT_BINARY = 0;

        [NativeTypeName("#define SCS_DOS_BINARY 1")]
        public const int SCS_DOS_BINARY = 1;

        [NativeTypeName("#define SCS_WOW_BINARY 2")]
        public const int SCS_WOW_BINARY = 2;

        [NativeTypeName("#define SCS_PIF_BINARY 3")]
        public const int SCS_PIF_BINARY = 3;

        [NativeTypeName("#define SCS_POSIX_BINARY 4")]
        public const int SCS_POSIX_BINARY = 4;

        [NativeTypeName("#define SCS_OS216_BINARY 5")]
        public const int SCS_OS216_BINARY = 5;

        [NativeTypeName("#define SCS_64BIT_BINARY 6")]
        public const int SCS_64BIT_BINARY = 6;

        [NativeTypeName("#define SCS_THIS_PLATFORM_BINARY SCS_64BIT_BINARY")]
        public const int SCS_THIS_PLATFORM_BINARY = 6;

        [NativeTypeName("#define GetBinaryType GetBinaryTypeW")]
        public static readonly delegate*<ushort*, uint*, int> GetBinaryType = &GetBinaryTypeW;

        [NativeTypeName("#define GetLongPathNameTransacted GetLongPathNameTransactedW")]
        public static readonly delegate*<ushort*, ushort*, uint, void*, uint> GetLongPathNameTransacted = &GetLongPathNameTransactedW;

        [NativeTypeName("#define FIBER_FLAG_FLOAT_SWITCH 0x1")]
        public const int FIBER_FLAG_FLOAT_SWITCH = 0x1;

        [NativeTypeName("#define UMS_VERSION RTL_UMS_VERSION")]
        public const int UMS_VERSION = (0x0100);

        [NativeTypeName("#define PROCESS_DEP_ENABLE 0x00000001")]
        public const int PROCESS_DEP_ENABLE = 0x00000001;

        [NativeTypeName("#define PROCESS_DEP_DISABLE_ATL_THUNK_EMULATION 0x00000002")]
        public const int PROCESS_DEP_DISABLE_ATL_THUNK_EMULATION = 0x00000002;

        [NativeTypeName("#define FILE_SKIP_COMPLETION_PORT_ON_SUCCESS 0x1")]
        public const int FILE_SKIP_COMPLETION_PORT_ON_SUCCESS = 0x1;

        [NativeTypeName("#define FILE_SKIP_SET_EVENT_ON_HANDLE 0x2")]
        public const int FILE_SKIP_SET_EVENT_ON_HANDLE = 0x2;

        [NativeTypeName("#define SEM_FAILCRITICALERRORS 0x0001")]
        public const int SEM_FAILCRITICALERRORS = 0x0001;

        [NativeTypeName("#define SEM_NOGPFAULTERRORBOX 0x0002")]
        public const int SEM_NOGPFAULTERRORBOX = 0x0002;

        [NativeTypeName("#define SEM_NOALIGNMENTFAULTEXCEPT 0x0004")]
        public const int SEM_NOALIGNMENTFAULTEXCEPT = 0x0004;

        [NativeTypeName("#define SEM_NOOPENFILEERRORBOX 0x8000")]
        public const int SEM_NOOPENFILEERRORBOX = 0x8000;

        [NativeTypeName("#define CRITICAL_SECTION_NO_DEBUG_INFO RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO")]
        public const int CRITICAL_SECTION_NO_DEBUG_INFO = 0x01000000;

        [NativeTypeName("#define SetFileShortName SetFileShortNameW")]
        public static readonly delegate*<void*, ushort*, int> SetFileShortName = &SetFileShortNameW;

        [NativeTypeName("#define HANDLE_FLAG_INHERIT 0x00000001")]
        public const int HANDLE_FLAG_INHERIT = 0x00000001;

        [NativeTypeName("#define HANDLE_FLAG_PROTECT_FROM_CLOSE 0x00000002")]
        public const int HANDLE_FLAG_PROTECT_FROM_CLOSE = 0x00000002;

        [NativeTypeName("#define HINSTANCE_ERROR 32")]
        public const int HINSTANCE_ERROR = 32;

        [NativeTypeName("#define GET_TAPE_MEDIA_INFORMATION 0")]
        public const int GET_TAPE_MEDIA_INFORMATION = 0;

        [NativeTypeName("#define GET_TAPE_DRIVE_INFORMATION 1")]
        public const int GET_TAPE_DRIVE_INFORMATION = 1;

        [NativeTypeName("#define SET_TAPE_MEDIA_INFORMATION 0")]
        public const int SET_TAPE_MEDIA_INFORMATION = 0;

        [NativeTypeName("#define SET_TAPE_DRIVE_INFORMATION 1")]
        public const int SET_TAPE_DRIVE_INFORMATION = 1;

        [NativeTypeName("#define FORMAT_MESSAGE_ALLOCATE_BUFFER 0x00000100")]
        public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;

        [NativeTypeName("#define FormatMessage FormatMessageW")]
        public static readonly delegate*<uint, void*, uint, uint, ushort*, uint, sbyte**, uint> FormatMessage = &FormatMessageW;

        [NativeTypeName("#define FORMAT_MESSAGE_IGNORE_INSERTS 0x00000200")]
        public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;

        [NativeTypeName("#define FORMAT_MESSAGE_FROM_STRING 0x00000400")]
        public const int FORMAT_MESSAGE_FROM_STRING = 0x00000400;

        [NativeTypeName("#define FORMAT_MESSAGE_FROM_HMODULE 0x00000800")]
        public const int FORMAT_MESSAGE_FROM_HMODULE = 0x00000800;

        [NativeTypeName("#define FORMAT_MESSAGE_FROM_SYSTEM 0x00001000")]
        public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;

        [NativeTypeName("#define FORMAT_MESSAGE_ARGUMENT_ARRAY 0x00002000")]
        public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000;

        [NativeTypeName("#define FORMAT_MESSAGE_MAX_WIDTH_MASK 0x000000FF")]
        public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF;

        [NativeTypeName("#define CreateMailslot CreateMailslotW")]
        public static readonly delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, void*> CreateMailslot = &CreateMailslotW;

        [NativeTypeName("#define EncryptFile EncryptFileW")]
        public static readonly delegate*<ushort*, int> EncryptFile = &EncryptFileW;

        [NativeTypeName("#define DecryptFile DecryptFileW")]
        public static readonly delegate*<ushort*, uint, int> DecryptFile = &DecryptFileW;

        [NativeTypeName("#define FILE_ENCRYPTABLE 0")]
        public const int FILE_ENCRYPTABLE = 0;

        [NativeTypeName("#define FILE_IS_ENCRYPTED 1")]
        public const int FILE_IS_ENCRYPTED = 1;

        [NativeTypeName("#define FILE_SYSTEM_ATTR 2")]
        public const int FILE_SYSTEM_ATTR = 2;

        [NativeTypeName("#define FILE_ROOT_DIR 3")]
        public const int FILE_ROOT_DIR = 3;

        [NativeTypeName("#define FILE_SYSTEM_DIR 4")]
        public const int FILE_SYSTEM_DIR = 4;

        [NativeTypeName("#define FILE_UNKNOWN 5")]
        public const int FILE_UNKNOWN = 5;

        [NativeTypeName("#define FILE_SYSTEM_NOT_SUPPORT 6")]
        public const int FILE_SYSTEM_NOT_SUPPORT = 6;

        [NativeTypeName("#define FILE_USER_DISALLOWED 7")]
        public const int FILE_USER_DISALLOWED = 7;

        [NativeTypeName("#define FILE_READ_ONLY 8")]
        public const int FILE_READ_ONLY = 8;

        [NativeTypeName("#define FILE_DIR_DISALLOWED 9")]
        public const int FILE_DIR_DISALLOWED = 9;

        [NativeTypeName("#define FileEncryptionStatus FileEncryptionStatusW")]
        public static readonly delegate*<ushort*, uint*, int> FileEncryptionStatus = &FileEncryptionStatusW;

        [NativeTypeName("#define EFS_USE_RECOVERY_KEYS (0x1)")]
        public const int EFS_USE_RECOVERY_KEYS = (0x1);

        [NativeTypeName("#define CREATE_FOR_IMPORT (1)")]
        public const int CREATE_FOR_IMPORT = (1);

        [NativeTypeName("#define CREATE_FOR_DIR (2)")]
        public const int CREATE_FOR_DIR = (2);

        [NativeTypeName("#define OVERWRITE_HIDDEN (4)")]
        public const int OVERWRITE_HIDDEN = (4);

        [NativeTypeName("#define EFSRPC_SECURE_ONLY (8)")]
        public const int EFSRPC_SECURE_ONLY = (8);

        [NativeTypeName("#define EFS_DROP_ALTERNATE_STREAMS (0x10)")]
        public const int EFS_DROP_ALTERNATE_STREAMS = (0x10);

        [NativeTypeName("#define OpenEncryptedFileRaw OpenEncryptedFileRawW")]
        public static readonly delegate*<ushort*, uint, void**, uint> OpenEncryptedFileRaw = &OpenEncryptedFileRawW;

        [NativeTypeName("#define lstrcmp lstrcmpW")]
        public static readonly delegate*<ushort*, ushort*, int> lstrcmp = &lstrcmpW;

        [NativeTypeName("#define lstrcmpi lstrcmpiW")]
        public static readonly delegate*<ushort*, ushort*, int> lstrcmpi = &lstrcmpiW;

        [NativeTypeName("#define lstrcpyn lstrcpynW")]
        public static readonly delegate*<ushort*, ushort*, int, ushort*> lstrcpyn = &lstrcpynW;

        [NativeTypeName("#define lstrcpy lstrcpyW")]
        public static readonly delegate*<ushort*, ushort*, ushort*> lstrcpy = &lstrcpyW;

        [NativeTypeName("#define lstrcat lstrcatW")]
        public static readonly delegate*<ushort*, ushort*, ushort*> lstrcat = &lstrcatW;

        [NativeTypeName("#define lstrlen lstrlenW")]
        public static readonly delegate*<ushort*, int> lstrlen = &lstrlenW;

        [NativeTypeName("#define BACKUP_INVALID 0x00000000")]
        public const int BACKUP_INVALID = 0x00000000;

        [NativeTypeName("#define BACKUP_DATA 0x00000001")]
        public const int BACKUP_DATA = 0x00000001;

        [NativeTypeName("#define BACKUP_EA_DATA 0x00000002")]
        public const int BACKUP_EA_DATA = 0x00000002;

        [NativeTypeName("#define BACKUP_SECURITY_DATA 0x00000003")]
        public const int BACKUP_SECURITY_DATA = 0x00000003;

        [NativeTypeName("#define BACKUP_ALTERNATE_DATA 0x00000004")]
        public const int BACKUP_ALTERNATE_DATA = 0x00000004;

        [NativeTypeName("#define BACKUP_LINK 0x00000005")]
        public const int BACKUP_LINK = 0x00000005;

        [NativeTypeName("#define BACKUP_PROPERTY_DATA 0x00000006")]
        public const int BACKUP_PROPERTY_DATA = 0x00000006;

        [NativeTypeName("#define BACKUP_OBJECT_ID 0x00000007")]
        public const int BACKUP_OBJECT_ID = 0x00000007;

        [NativeTypeName("#define BACKUP_REPARSE_DATA 0x00000008")]
        public const int BACKUP_REPARSE_DATA = 0x00000008;

        [NativeTypeName("#define BACKUP_SPARSE_BLOCK 0x00000009")]
        public const int BACKUP_SPARSE_BLOCK = 0x00000009;

        [NativeTypeName("#define BACKUP_TXFS_DATA 0x0000000a")]
        public const int BACKUP_TXFS_DATA = 0x0000000a;

        [NativeTypeName("#define BACKUP_GHOSTED_FILE_EXTENTS 0x0000000b")]
        public const int BACKUP_GHOSTED_FILE_EXTENTS = 0x0000000b;

        [NativeTypeName("#define STREAM_NORMAL_ATTRIBUTE 0x00000000")]
        public const int STREAM_NORMAL_ATTRIBUTE = 0x00000000;

        [NativeTypeName("#define STREAM_MODIFIED_WHEN_READ 0x00000001")]
        public const int STREAM_MODIFIED_WHEN_READ = 0x00000001;

        [NativeTypeName("#define STREAM_CONTAINS_SECURITY 0x00000002")]
        public const int STREAM_CONTAINS_SECURITY = 0x00000002;

        [NativeTypeName("#define STREAM_CONTAINS_PROPERTIES 0x00000004")]
        public const int STREAM_CONTAINS_PROPERTIES = 0x00000004;

        [NativeTypeName("#define STREAM_SPARSE_ATTRIBUTE 0x00000008")]
        public const int STREAM_SPARSE_ATTRIBUTE = 0x00000008;

        [NativeTypeName("#define STREAM_CONTAINS_GHOSTED_FILE_EXTENTS 0x00000010")]
        public const int STREAM_CONTAINS_GHOSTED_FILE_EXTENTS = 0x00000010;

        [NativeTypeName("#define STARTF_USESHOWWINDOW 0x00000001")]
        public const int STARTF_USESHOWWINDOW = 0x00000001;

        [NativeTypeName("#define STARTF_USESIZE 0x00000002")]
        public const int STARTF_USESIZE = 0x00000002;

        [NativeTypeName("#define STARTF_USEPOSITION 0x00000004")]
        public const int STARTF_USEPOSITION = 0x00000004;

        [NativeTypeName("#define STARTF_USECOUNTCHARS 0x00000008")]
        public const int STARTF_USECOUNTCHARS = 0x00000008;

        [NativeTypeName("#define STARTF_USEFILLATTRIBUTE 0x00000010")]
        public const int STARTF_USEFILLATTRIBUTE = 0x00000010;

        [NativeTypeName("#define STARTF_RUNFULLSCREEN 0x00000020")]
        public const int STARTF_RUNFULLSCREEN = 0x00000020;

        [NativeTypeName("#define STARTF_FORCEONFEEDBACK 0x00000040")]
        public const int STARTF_FORCEONFEEDBACK = 0x00000040;

        [NativeTypeName("#define STARTF_FORCEOFFFEEDBACK 0x00000080")]
        public const int STARTF_FORCEOFFFEEDBACK = 0x00000080;

        [NativeTypeName("#define STARTF_USESTDHANDLES 0x00000100")]
        public const int STARTF_USESTDHANDLES = 0x00000100;

        [NativeTypeName("#define STARTF_USEHOTKEY 0x00000200")]
        public const int STARTF_USEHOTKEY = 0x00000200;

        [NativeTypeName("#define STARTF_TITLEISLINKNAME 0x00000800")]
        public const int STARTF_TITLEISLINKNAME = 0x00000800;

        [NativeTypeName("#define STARTF_TITLEISAPPID 0x00001000")]
        public const int STARTF_TITLEISAPPID = 0x00001000;

        [NativeTypeName("#define STARTF_PREVENTPINNING 0x00002000")]
        public const int STARTF_PREVENTPINNING = 0x00002000;

        [NativeTypeName("#define STARTF_UNTRUSTEDSOURCE 0x00008000")]
        public const int STARTF_UNTRUSTEDSOURCE = 0x00008000;

        [NativeTypeName("#define SHUTDOWN_NORETRY 0x00000001")]
        public const int SHUTDOWN_NORETRY = 0x00000001;

        [NativeTypeName("#define PROTECTION_LEVEL_WINTCB_LIGHT 0x00000000")]
        public const int PROTECTION_LEVEL_WINTCB_LIGHT = 0x00000000;

        [NativeTypeName("#define PROTECTION_LEVEL_WINDOWS 0x00000001")]
        public const int PROTECTION_LEVEL_WINDOWS = 0x00000001;

        [NativeTypeName("#define PROTECTION_LEVEL_WINDOWS_LIGHT 0x00000002")]
        public const int PROTECTION_LEVEL_WINDOWS_LIGHT = 0x00000002;

        [NativeTypeName("#define PROTECTION_LEVEL_ANTIMALWARE_LIGHT 0x00000003")]
        public const int PROTECTION_LEVEL_ANTIMALWARE_LIGHT = 0x00000003;

        [NativeTypeName("#define PROTECTION_LEVEL_LSA_LIGHT 0x00000004")]
        public const int PROTECTION_LEVEL_LSA_LIGHT = 0x00000004;

        [NativeTypeName("#define PROTECTION_LEVEL_WINTCB 0x00000005")]
        public const int PROTECTION_LEVEL_WINTCB = 0x00000005;

        [NativeTypeName("#define PROTECTION_LEVEL_CODEGEN_LIGHT 0x00000006")]
        public const int PROTECTION_LEVEL_CODEGEN_LIGHT = 0x00000006;

        [NativeTypeName("#define PROTECTION_LEVEL_AUTHENTICODE 0x00000007")]
        public const int PROTECTION_LEVEL_AUTHENTICODE = 0x00000007;

        [NativeTypeName("#define PROTECTION_LEVEL_PPL_APP 0x00000008")]
        public const int PROTECTION_LEVEL_PPL_APP = 0x00000008;

        [NativeTypeName("#define PROTECTION_LEVEL_SAME 0xFFFFFFFF")]
        public const uint PROTECTION_LEVEL_SAME = 0xFFFFFFFF;

        [NativeTypeName("#define PROTECTION_LEVEL_NONE 0xFFFFFFFE")]
        public const uint PROTECTION_LEVEL_NONE = 0xFFFFFFFE;

        [NativeTypeName("#define PROCESS_NAME_NATIVE 0x00000001")]
        public const int PROCESS_NAME_NATIVE = 0x00000001;

        [NativeTypeName("#define QueryFullProcessImageName QueryFullProcessImageNameW")]
        public static readonly delegate*<void*, uint, ushort*, uint*, int> QueryFullProcessImageName = &QueryFullProcessImageNameW;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_NUMBER 0x0000FFFF")]
        public const int PROC_THREAD_ATTRIBUTE_NUMBER = 0x0000FFFF;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_THREAD 0x00010000")]
        public const int PROC_THREAD_ATTRIBUTE_THREAD = 0x00010000;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_INPUT 0x00020000")]
        public const int PROC_THREAD_ATTRIBUTE_INPUT = 0x00020000;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_ADDITIVE 0x00040000")]
        public const int PROC_THREAD_ATTRIBUTE_ADDITIVE = 0x00040000;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PARENT_PROCESS ProcThreadAttributeValue (ProcThreadAttributeParentProcess, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_PARENT_PROCESS = (((int)(ProcThreadAttributeParentProcess) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_HANDLE_LIST ProcThreadAttributeValue (ProcThreadAttributeHandleList, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_HANDLE_LIST = (((int)(ProcThreadAttributeHandleList) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_GROUP_AFFINITY ProcThreadAttributeValue (ProcThreadAttributeGroupAffinity, TRUE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_GROUP_AFFINITY = (((int)(ProcThreadAttributeGroupAffinity) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PREFERRED_NODE ProcThreadAttributeValue (ProcThreadAttributePreferredNode, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_PREFERRED_NODE = (((int)(ProcThreadAttributePreferredNode) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_IDEAL_PROCESSOR ProcThreadAttributeValue (ProcThreadAttributeIdealProcessor, TRUE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_IDEAL_PROCESSOR = (((int)(ProcThreadAttributeIdealProcessor) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_UMS_THREAD ProcThreadAttributeValue (ProcThreadAttributeUmsThread, TRUE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_UMS_THREAD = (((int)(ProcThreadAttributeUmsThread) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_MITIGATION_POLICY ProcThreadAttributeValue (ProcThreadAttributeMitigationPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_MITIGATION_POLICY = (((int)(ProcThreadAttributeMitigationPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_SECURITY_CAPABILITIES ProcThreadAttributeValue (ProcThreadAttributeSecurityCapabilities, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_SECURITY_CAPABILITIES = (((int)(ProcThreadAttributeSecurityCapabilities) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PROTECTION_LEVEL ProcThreadAttributeValue (ProcThreadAttributeProtectionLevel, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_PROTECTION_LEVEL = (((int)(ProcThreadAttributeProtectionLevel) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PSEUDOCONSOLE ProcThreadAttributeValue (ProcThreadAttributePseudoConsole, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_PSEUDOCONSOLE = (((int)(ProcThreadAttributePseudoConsole) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_DEP_ENABLE 0x01")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_DEP_ENABLE = 0x01;

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_DEP_ATL_THUNK_ENABLE 0x02")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_DEP_ATL_THUNK_ENABLE = 0x02;

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_SEHOP_ENABLE 0x04")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_SEHOP_ENABLE = 0x04;

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_MASK (0x00000003 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_MASK = (0x00000003 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_DEFER (0x00000000 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_DEFER = (0x00000000 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_ON (0x00000001 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_ON = (0x00000001 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_OFF (0x00000002 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_OFF = (0x00000002 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_ON_REQ_RELOCS (0x00000003 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_ON_REQ_RELOCS = (0x00000003 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_MASK (0x00000003 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_MASK = (0x00000003 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_DEFER (0x00000000 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_DEFER = (0x00000000 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_ALWAYS_ON (0x00000001 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_ALWAYS_ON = (0x00000001 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_ALWAYS_OFF (0x00000002 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_ALWAYS_OFF = (0x00000002 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_RESERVED (0x00000003 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_RESERVED = (0x00000003 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_MASK (0x00000003 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_MASK = (0x00000003 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_DEFER (0x00000000 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_DEFER = (0x00000000 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_ALWAYS_ON (0x00000001 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_ALWAYS_ON = (0x00000001 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_ALWAYS_OFF (0x00000002 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_ALWAYS_OFF = (0x00000002 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_RESERVED (0x00000003 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_RESERVED = (0x00000003 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_MASK (0x00000003 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_MASK = (0x00000003 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_DEFER (0x00000000 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_DEFER = (0x00000000 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_ALWAYS_ON (0x00000001 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_ALWAYS_ON = (0x00000001 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_ALWAYS_OFF (0x00000002 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_ALWAYS_OFF = (0x00000002 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_RESERVED (0x00000003 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_RESERVED = (0x00000003 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_MASK (0x00000003 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_MASK = (0x00000003 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_DEFER (0x00000000 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_DEFER = (0x00000000 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_ALWAYS_ON (0x00000001 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_ALWAYS_ON = (0x00000001 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_ALWAYS_OFF (0x00000002 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_ALWAYS_OFF = (0x00000002 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_RESERVED (0x00000003 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_RESERVED = (0x00000003 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_MASK (0x00000003 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_MASK = (0x00000003 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_DEFER (0x00000000 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_DEFER = (0x00000000 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_ALWAYS_ON (0x00000001 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_ALWAYS_ON = (0x00000001 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_ALWAYS_OFF (0x00000002 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_ALWAYS_OFF = (0x00000002 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_RESERVED (0x00000003 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_RESERVED = (0x00000003 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_MASK (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_MASK = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_DEFER (0x00000000ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_DEFER = (0x00000000UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_ALWAYS_ON (0x00000001ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_ALWAYS_ON = (0x00000001UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_ALWAYS_OFF (0x00000002ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_ALWAYS_OFF = (0x00000002UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_RESERVED (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_RESERVED = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_MASK (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_MASK = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_DEFER (0x00000000ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_DEFER = (0x00000000UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_ON (0x00000001ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_ON = (0x00000001UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_OFF (0x00000002ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_OFF = (0x00000002UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_ON_ALLOW_OPT_OUT (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_ON_ALLOW_OPT_OUT = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_MASK (0x00000003ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_MASK = (0x00000003UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_DEFER (0x00000000ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_DEFER = (0x00000000UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_ALWAYS_ON (0x00000001ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_ALWAYS_ON = (0x00000001UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_ALWAYS_OFF (0x00000002ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_ALWAYS_OFF = (0x00000002UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_EXPORT_SUPPRESSION (0x00000003ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_EXPORT_SUPPRESSION = (0x00000003UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_MASK (0x00000003ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_MASK = (0x00000003UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_DEFER (0x00000000ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_DEFER = (0x00000000UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALWAYS_ON (0x00000001ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALWAYS_ON = (0x00000001UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALWAYS_OFF (0x00000002ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALWAYS_OFF = (0x00000002UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALLOW_STORE (0x00000003ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALLOW_STORE = (0x00000003UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_MASK (0x00000003ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_MASK = (0x00000003UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_DEFER (0x00000000ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_DEFER = (0x00000000UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_ALWAYS_ON (0x00000001ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_ALWAYS_ON = (0x00000001UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_ALWAYS_OFF (0x00000002ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_ALWAYS_OFF = (0x00000002UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_AUDIT_NONSYSTEM_FONTS (0x00000003ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_AUDIT_NONSYSTEM_FONTS = (0x00000003UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_MASK (0x00000003ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_MASK = (0x00000003UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_DEFER (0x00000000ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_DEFER = (0x00000000UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_ALWAYS_ON (0x00000001ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_ALWAYS_ON = (0x00000001UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_ALWAYS_OFF (0x00000002ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_ALWAYS_OFF = (0x00000002UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_RESERVED (0x00000003ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_RESERVED = (0x00000003UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_MASK (0x00000003ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_MASK = (0x00000003UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_DEFER (0x00000000ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_DEFER = (0x00000000UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_ALWAYS_ON (0x00000001ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_ALWAYS_ON = (0x00000001UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_ALWAYS_OFF (0x00000002ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_ALWAYS_OFF = (0x00000002UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_RESERVED (0x00000003ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_RESERVED = (0x00000003UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_MASK (0x00000003ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_MASK = (0x00000003UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_DEFER (0x00000000ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_DEFER = (0x00000000UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_ALWAYS_ON (0x00000001ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_ALWAYS_ON = (0x00000001UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_ALWAYS_OFF (0x00000002ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_ALWAYS_OFF = (0x00000002UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_RESERVED (0x00000003ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_RESERVED = (0x00000003UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_MASK (0x00000003ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_MASK = (0x00000003UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_DEFER (0x00000000ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_DEFER = (0x00000000UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_ALWAYS_ON (0x00000001ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_ALWAYS_ON = (0x00000001UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_ALWAYS_OFF (0x00000002ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_ALWAYS_OFF = (0x00000002UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_AUDIT (0x00000003ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_AUDIT = (0x00000003UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_MASK (0x00000003ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_MASK = (0x00000003UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_DEFER (0x00000000ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_DEFER = (0x00000000UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_ALWAYS_ON (0x00000001ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_ALWAYS_ON = (0x00000001UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_ALWAYS_OFF (0x00000002ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_ALWAYS_OFF = (0x00000002UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_RESERVED (0x00000003ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_RESERVED = (0x00000003UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_MASK (0x00000003ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_MASK = (0x00000003UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_DEFER (0x00000000ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_DEFER = (0x00000000UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_ALWAYS_ON (0x00000001ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_ALWAYS_ON = (0x00000001UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_ALWAYS_OFF (0x00000002ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_ALWAYS_OFF = (0x00000002UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_NOINHERIT (0x00000003ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_NOINHERIT = (0x00000003UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_MASK (0x00000003ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_MASK = (0x00000003UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_DEFER (0x00000000ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_DEFER = (0x00000000UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_ALWAYS_ON (0x00000001ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_ALWAYS_ON = (0x00000001UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_ALWAYS_OFF (0x00000002ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_ALWAYS_OFF = (0x00000002UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_RESERVED (0x00000003ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_RESERVED = (0x00000003UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_MASK (0x00000003ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_MASK = (0x00000003UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_DEFER (0x00000000ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_DEFER = (0x00000000UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_ALWAYS_ON (0x00000001ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_ALWAYS_ON = (0x00000001UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_ALWAYS_OFF (0x00000002ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_ALWAYS_OFF = (0x00000002UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_RESERVED (0x00000003ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_RESERVED = (0x00000003UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_MASK (0x00000003ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_MASK = (0x00000003UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_DEFER (0x00000000ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_DEFER = (0x00000000UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_ALWAYS_ON (0x00000001ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_ALWAYS_ON = (0x00000001UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_ALWAYS_OFF (0x00000002ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_ALWAYS_OFF = (0x00000002UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_RESERVED (0x00000003ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_RESERVED = (0x00000003UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_MASK (0x00000003ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_MASK = (0x00000003UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_DEFER (0x00000000ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_DEFER = (0x00000000UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_ON (0x00000001ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_ON = (0x00000001UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_OFF (0x00000002ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_OFF = (0x00000002UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_STRICT_MODE (0x00000003ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_STRICT_MODE = (0x00000003UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_MASK (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_MASK = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_DEFER (0x00000000ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_DEFER = (0x00000000UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_ON (0x00000001ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_ON = (0x00000001UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_OFF (0x00000002ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_OFF = (0x00000002UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_RELAXED_MODE (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_RELAXED_MODE = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_MASK (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_MASK = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_DEFER (0x00000000ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_DEFER = (0x00000000UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_ON (0x00000001ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_ON = (0x00000001UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_OFF (0x00000002ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_OFF = (0x00000002UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_NON_EHCONT (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_NON_EHCONT = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_MASK (0x00000003ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_MASK = (0x00000003UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_DEFER (0x00000000ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_DEFER = (0x00000000UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_ALWAYS_ON (0x00000001ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_ALWAYS_ON = (0x00000001UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_ALWAYS_OFF (0x00000002ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_ALWAYS_OFF = (0x00000002UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_RESERVED (0x00000003ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_RESERVED = (0x00000003UL << 48);

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_JOB_LIST ProcThreadAttributeValue (ProcThreadAttributeJobList, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_JOB_LIST = (((int)(ProcThreadAttributeJobList) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_CHILD_PROCESS_RESTRICTED 0x01")]
        public const int PROCESS_CREATION_CHILD_PROCESS_RESTRICTED = 0x01;

        [NativeTypeName("#define PROCESS_CREATION_CHILD_PROCESS_OVERRIDE 0x02")]
        public const int PROCESS_CREATION_CHILD_PROCESS_OVERRIDE = 0x02;

        [NativeTypeName("#define PROCESS_CREATION_CHILD_PROCESS_RESTRICTED_UNLESS_SECURE 0x04")]
        public const int PROCESS_CREATION_CHILD_PROCESS_RESTRICTED_UNLESS_SECURE = 0x04;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_CHILD_PROCESS_POLICY ProcThreadAttributeValue (ProcThreadAttributeChildProcessPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_CHILD_PROCESS_POLICY = (((int)(ProcThreadAttributeChildProcessPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_ALL_APPLICATION_PACKAGES_OPT_OUT 0x01")]
        public const int PROCESS_CREATION_ALL_APPLICATION_PACKAGES_OPT_OUT = 0x01;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_ALL_APPLICATION_PACKAGES_POLICY ProcThreadAttributeValue (ProcThreadAttributeAllApplicationPackagesPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_ALL_APPLICATION_PACKAGES_POLICY = (((int)(ProcThreadAttributeAllApplicationPackagesPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_WIN32K_FILTER ProcThreadAttributeValue (ProcThreadAttributeWin32kFilter, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_WIN32K_FILTER = (((int)(ProcThreadAttributeWin32kFilter) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_ENABLE_PROCESS_TREE 0x01")]
        public const int PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_ENABLE_PROCESS_TREE = 0x01;

        [NativeTypeName("#define PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_DISABLE_PROCESS_TREE 0x02")]
        public const int PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_DISABLE_PROCESS_TREE = 0x02;

        [NativeTypeName("#define PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_OVERRIDE 0x04")]
        public const int PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_OVERRIDE = 0x04;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_DESKTOP_APP_POLICY ProcThreadAttributeValue (ProcThreadAttributeDesktopAppPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_DESKTOP_APP_POLICY = (((int)(ProcThreadAttributeDesktopAppPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_MITIGATION_AUDIT_POLICY ProcThreadAttributeValue (ProcThreadAttributeMitigationAuditPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_MITIGATION_AUDIT_POLICY = (((int)(ProcThreadAttributeMitigationAuditPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_MASK (0x00000003ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_MASK = (0x00000003UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_DEFER (0x00000000ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_DEFER = (0x00000000UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_ON (0x00000001ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_ON = (0x00000001UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_OFF (0x00000002ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_OFF = (0x00000002UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_RESERVED (0x00000003ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_RESERVED = (0x00000003UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_MASK (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_MASK = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_DEFER (0x00000000ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_DEFER = (0x00000000UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_ON (0x00000001ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_ON = (0x00000001UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_OFF (0x00000002ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_OFF = (0x00000002UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_RESERVED (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_RESERVED = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_MASK (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_MASK = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_DEFER (0x00000000ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_DEFER = (0x00000000UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_ON (0x00000001ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_ON = (0x00000001UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_OFF (0x00000002ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_OFF = (0x00000002UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_RESERVED (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_RESERVED = (0x00000003UL << 36);

        [NativeTypeName("#define GetFirmwareEnvironmentVariable GetFirmwareEnvironmentVariableW")]
        public static readonly delegate*<ushort*, ushort*, void*, uint, uint> GetFirmwareEnvironmentVariable = &GetFirmwareEnvironmentVariableW;

        [NativeTypeName("#define GetFirmwareEnvironmentVariableEx GetFirmwareEnvironmentVariableExW")]
        public static readonly delegate*<ushort*, ushort*, void*, uint, uint*, uint> GetFirmwareEnvironmentVariableEx = &GetFirmwareEnvironmentVariableExW;

        [NativeTypeName("#define SetFirmwareEnvironmentVariable SetFirmwareEnvironmentVariableW")]
        public static readonly delegate*<ushort*, ushort*, void*, uint, int> SetFirmwareEnvironmentVariable = &SetFirmwareEnvironmentVariableW;

        [NativeTypeName("#define SetFirmwareEnvironmentVariableEx SetFirmwareEnvironmentVariableExW")]
        public static readonly delegate*<ushort*, ushort*, void*, uint, uint, int> SetFirmwareEnvironmentVariableEx = &SetFirmwareEnvironmentVariableExW;

        [NativeTypeName("#define EnumResourceTypes EnumResourceTypesW")]
        public static readonly delegate*<HINSTANCE__*, delegate* unmanaged<HINSTANCE__*, ushort*, long, int>, long, int> EnumResourceTypes = &EnumResourceTypesW;

        [NativeTypeName("#define EnumResourceLanguages EnumResourceLanguagesW")]
        public static readonly delegate*<HINSTANCE__*, ushort*, ushort*, delegate* unmanaged<HINSTANCE__*, ushort*, ushort*, ushort, long, int>, long, int> EnumResourceLanguages = &EnumResourceLanguagesW;

        [NativeTypeName("#define BeginUpdateResource BeginUpdateResourceW")]
        public static readonly delegate*<ushort*, int, void*> BeginUpdateResource = &BeginUpdateResourceW;

        [NativeTypeName("#define UpdateResource UpdateResourceW")]
        public static readonly delegate*<void*, ushort*, ushort*, ushort, void*, uint, int> UpdateResource = &UpdateResourceW;

        [NativeTypeName("#define EndUpdateResource EndUpdateResourceW")]
        public static readonly delegate*<void*, int, int> EndUpdateResource = &EndUpdateResourceW;

        [NativeTypeName("#define ATOM_FLAG_GLOBAL 0x2")]
        public const int ATOM_FLAG_GLOBAL = 0x2;

        [NativeTypeName("#define GlobalAddAtom GlobalAddAtomW")]
        public static readonly delegate*<ushort*, ushort> GlobalAddAtom = &GlobalAddAtomW;

        [NativeTypeName("#define GlobalAddAtomEx GlobalAddAtomExW")]
        public static readonly delegate*<ushort*, uint, ushort> GlobalAddAtomEx = &GlobalAddAtomExW;

        [NativeTypeName("#define GlobalFindAtom GlobalFindAtomW")]
        public static readonly delegate*<ushort*, ushort> GlobalFindAtom = &GlobalFindAtomW;

        [NativeTypeName("#define GlobalGetAtomName GlobalGetAtomNameW")]
        public static readonly delegate*<ushort, ushort*, int, uint> GlobalGetAtomName = &GlobalGetAtomNameW;

        [NativeTypeName("#define AddAtom AddAtomW")]
        public static readonly delegate*<ushort*, ushort> AddAtom = &AddAtomW;

        [NativeTypeName("#define FindAtom FindAtomW")]
        public static readonly delegate*<ushort*, ushort> FindAtom = &FindAtomW;

        [NativeTypeName("#define GetAtomName GetAtomNameW")]
        public static readonly delegate*<ushort, ushort*, int, uint> GetAtomName = &GetAtomNameW;

        [NativeTypeName("#define GetProfileInt GetProfileIntW")]
        public static readonly delegate*<ushort*, ushort*, int, uint> GetProfileInt = &GetProfileIntW;

        [NativeTypeName("#define GetProfileString GetProfileStringW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, ushort*, uint, uint> GetProfileString = &GetProfileStringW;

        [NativeTypeName("#define WriteProfileString WriteProfileStringW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, int> WriteProfileString = &WriteProfileStringW;

        [NativeTypeName("#define GetProfileSection GetProfileSectionW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> GetProfileSection = &GetProfileSectionW;

        [NativeTypeName("#define WriteProfileSection WriteProfileSectionW")]
        public static readonly delegate*<ushort*, ushort*, int> WriteProfileSection = &WriteProfileSectionW;

        [NativeTypeName("#define GetPrivateProfileInt GetPrivateProfileIntW")]
        public static readonly delegate*<ushort*, ushort*, int, ushort*, uint> GetPrivateProfileInt = &GetPrivateProfileIntW;

        [NativeTypeName("#define GetPrivateProfileString GetPrivateProfileStringW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, ushort*, uint, ushort*, uint> GetPrivateProfileString = &GetPrivateProfileStringW;

        [NativeTypeName("#define WritePrivateProfileString WritePrivateProfileStringW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, ushort*, int> WritePrivateProfileString = &WritePrivateProfileStringW;

        [NativeTypeName("#define GetPrivateProfileSection GetPrivateProfileSectionW")]
        public static readonly delegate*<ushort*, ushort*, uint, ushort*, uint> GetPrivateProfileSection = &GetPrivateProfileSectionW;

        [NativeTypeName("#define WritePrivateProfileSection WritePrivateProfileSectionW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, int> WritePrivateProfileSection = &WritePrivateProfileSectionW;

        [NativeTypeName("#define GetPrivateProfileSectionNames GetPrivateProfileSectionNamesW")]
        public static readonly delegate*<ushort*, uint, ushort*, uint> GetPrivateProfileSectionNames = &GetPrivateProfileSectionNamesW;

        [NativeTypeName("#define GetPrivateProfileStruct GetPrivateProfileStructW")]
        public static readonly delegate*<ushort*, ushort*, void*, uint, ushort*, int> GetPrivateProfileStruct = &GetPrivateProfileStructW;

        [NativeTypeName("#define WritePrivateProfileStruct WritePrivateProfileStructW")]
        public static readonly delegate*<ushort*, ushort*, void*, uint, ushort*, int> WritePrivateProfileStruct = &WritePrivateProfileStructW;

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_A \"GetSystemWow64DirectoryA\"")]
        public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_A_A => new byte[] { 0x47, 0x65, 0x74, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x57, 0x6F, 0x77, 0x36, 0x34, 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x41, 0x00 };

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_W L\"GetSystemWow64DirectoryA\"")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_A_W = "GetSystemWow64DirectoryA";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_T TEXT(\"GetSystemWow64DirectoryA\")")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_A_T = "GetSystemWow64DirectoryA";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A \"GetSystemWow64DirectoryW\"")]
        public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A => new byte[] { 0x47, 0x65, 0x74, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x57, 0x6F, 0x77, 0x36, 0x34, 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x57, 0x00 };

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W L\"GetSystemWow64DirectoryW\"")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W = "GetSystemWow64DirectoryW";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T TEXT(\"GetSystemWow64DirectoryW\")")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T = "GetSystemWow64DirectoryW";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_A GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A")]
        public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_T_A => new byte[] { 0x47, 0x65, 0x74, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x57, 0x6F, 0x77, 0x36, 0x34, 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x57, 0x00 };

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_W GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_W = "GetSystemWow64DirectoryW";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_T GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_T = "GetSystemWow64DirectoryW";

        [NativeTypeName("#define SetDllDirectory SetDllDirectoryW")]
        public static readonly delegate*<ushort*, int> SetDllDirectory = &SetDllDirectoryW;

        [NativeTypeName("#define GetDllDirectory GetDllDirectoryW")]
        public static readonly delegate*<uint, ushort*, uint> GetDllDirectory = &GetDllDirectoryW;

        [NativeTypeName("#define BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE 0x1")]
        public const int BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE = 0x1;

        [NativeTypeName("#define BASE_SEARCH_PATH_DISABLE_SAFE_SEARCHMODE 0x10000")]
        public const int BASE_SEARCH_PATH_DISABLE_SAFE_SEARCHMODE = 0x10000;

        [NativeTypeName("#define BASE_SEARCH_PATH_PERMANENT 0x8000")]
        public const int BASE_SEARCH_PATH_PERMANENT = 0x8000;

        [NativeTypeName("#define BASE_SEARCH_PATH_INVALID_FLAGS ~0x18001")]
        public const int BASE_SEARCH_PATH_INVALID_FLAGS = ~0x18001;

        [NativeTypeName("#define CreateDirectoryEx CreateDirectoryExW")]
        public static readonly delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, int> CreateDirectoryEx = &CreateDirectoryExW;

        [NativeTypeName("#define CreateDirectoryTransacted CreateDirectoryTransactedW")]
        public static readonly delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, void*, int> CreateDirectoryTransacted = &CreateDirectoryTransactedW;

        [NativeTypeName("#define RemoveDirectoryTransacted RemoveDirectoryTransactedW")]
        public static readonly delegate*<ushort*, void*, int> RemoveDirectoryTransacted = &RemoveDirectoryTransactedW;

        [NativeTypeName("#define GetFullPathNameTransacted GetFullPathNameTransactedW")]
        public static readonly delegate*<ushort*, uint, ushort*, ushort**, void*, uint> GetFullPathNameTransacted = &GetFullPathNameTransactedW;

        [NativeTypeName("#define DDD_RAW_TARGET_PATH 0x00000001")]
        public const int DDD_RAW_TARGET_PATH = 0x00000001;

        [NativeTypeName("#define DDD_REMOVE_DEFINITION 0x00000002")]
        public const int DDD_REMOVE_DEFINITION = 0x00000002;

        [NativeTypeName("#define DDD_EXACT_MATCH_ON_REMOVE 0x00000004")]
        public const int DDD_EXACT_MATCH_ON_REMOVE = 0x00000004;

        [NativeTypeName("#define DDD_NO_BROADCAST_SYSTEM 0x00000008")]
        public const int DDD_NO_BROADCAST_SYSTEM = 0x00000008;

        [NativeTypeName("#define DDD_LUID_BROADCAST_DRIVE 0x00000010")]
        public const int DDD_LUID_BROADCAST_DRIVE = 0x00000010;

        [NativeTypeName("#define CreateFileTransacted CreateFileTransactedW")]
        public static readonly delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, uint, uint, void*, void*, ushort*, void*, void*> CreateFileTransacted = &CreateFileTransactedW;

        [NativeTypeName("#define SetFileAttributesTransacted SetFileAttributesTransactedW")]
        public static readonly delegate*<ushort*, uint, void*, int> SetFileAttributesTransacted = &SetFileAttributesTransactedW;

        [NativeTypeName("#define GetFileAttributesTransacted GetFileAttributesTransactedW")]
        public static readonly delegate*<ushort*, GET_FILEEX_INFO_LEVELS, void*, void*, int> GetFileAttributesTransacted = &GetFileAttributesTransactedW;

        [NativeTypeName("#define GetCompressedFileSizeTransacted GetCompressedFileSizeTransactedW")]
        public static readonly delegate*<ushort*, uint*, void*, uint> GetCompressedFileSizeTransacted = &GetCompressedFileSizeTransactedW;

        [NativeTypeName("#define DeleteFileTransacted DeleteFileTransactedW")]
        public static readonly delegate*<ushort*, void*, int> DeleteFileTransacted = &DeleteFileTransactedW;

        [NativeTypeName("#define CheckNameLegalDOS8Dot3 CheckNameLegalDOS8Dot3W")]
        public static readonly delegate*<ushort*, sbyte*, uint, int*, int*, int> CheckNameLegalDOS8Dot3 = &CheckNameLegalDOS8Dot3W;

        [NativeTypeName("#define FindFirstFileTransacted FindFirstFileTransactedW")]
        public static readonly delegate*<ushort*, FINDEX_INFO_LEVELS, void*, FINDEX_SEARCH_OPS, void*, uint, void*, void*> FindFirstFileTransacted = &FindFirstFileTransactedW;

        [NativeTypeName("#define CopyFile CopyFileW")]
        public static readonly delegate*<ushort*, ushort*, int, int> CopyFile = &CopyFileW;

        [NativeTypeName("#define CopyFileEx CopyFileExW")]
        public static readonly delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint>, void*, int*, uint, int> CopyFileEx = &CopyFileExW;

        [NativeTypeName("#define CopyFileTransacted CopyFileTransactedW")]
        public static readonly delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint>, void*, int*, uint, void*, int> CopyFileTransacted = &CopyFileTransactedW;

        [NativeTypeName("#define COPYFILE2_MESSAGE_COPY_OFFLOAD (0x00000001L)")]
        public const int COPYFILE2_MESSAGE_COPY_OFFLOAD = (0x00000001);

        [NativeTypeName("#define MoveFile MoveFileW")]
        public static readonly delegate*<ushort*, ushort*, int> MoveFile = &MoveFileW;

        [NativeTypeName("#define MoveFileEx MoveFileExW")]
        public static readonly delegate*<ushort*, ushort*, uint, int> MoveFileEx = &MoveFileExW;

        [NativeTypeName("#define MoveFileWithProgress MoveFileWithProgressW")]
        public static readonly delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint>, void*, uint, int> MoveFileWithProgress = &MoveFileWithProgressW;

        [NativeTypeName("#define MoveFileTransacted MoveFileTransactedW")]
        public static readonly delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, void*, void*, void*, uint>, void*, uint, void*, int> MoveFileTransacted = &MoveFileTransactedW;

        [NativeTypeName("#define MOVEFILE_REPLACE_EXISTING 0x00000001")]
        public const int MOVEFILE_REPLACE_EXISTING = 0x00000001;

        [NativeTypeName("#define MOVEFILE_COPY_ALLOWED 0x00000002")]
        public const int MOVEFILE_COPY_ALLOWED = 0x00000002;

        [NativeTypeName("#define MOVEFILE_DELAY_UNTIL_REBOOT 0x00000004")]
        public const int MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004;

        [NativeTypeName("#define MOVEFILE_WRITE_THROUGH 0x00000008")]
        public const int MOVEFILE_WRITE_THROUGH = 0x00000008;

        [NativeTypeName("#define MOVEFILE_CREATE_HARDLINK 0x00000010")]
        public const int MOVEFILE_CREATE_HARDLINK = 0x00000010;

        [NativeTypeName("#define MOVEFILE_FAIL_IF_NOT_TRACKABLE 0x00000020")]
        public const int MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020;

        [NativeTypeName("#define ReplaceFile ReplaceFileW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, uint, void*, void*, int> ReplaceFile = &ReplaceFileW;

        [NativeTypeName("#define CreateHardLink CreateHardLinkW")]
        public static readonly delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, int> CreateHardLink = &CreateHardLinkW;

        [NativeTypeName("#define CreateHardLinkTransacted CreateHardLinkTransactedW")]
        public static readonly delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, void*, int> CreateHardLinkTransacted = &CreateHardLinkTransactedW;

        [NativeTypeName("#define SetVolumeLabel SetVolumeLabelW")]
        public static readonly delegate*<ushort*, ushort*, int> SetVolumeLabel = &SetVolumeLabelW;

        [NativeTypeName("#define ClearEventLog ClearEventLogW")]
        public static readonly delegate*<void*, ushort*, int> ClearEventLog = &ClearEventLogW;

        [NativeTypeName("#define BackupEventLog BackupEventLogW")]
        public static readonly delegate*<void*, ushort*, int> BackupEventLog = &BackupEventLogW;

        [NativeTypeName("#define OpenEventLog OpenEventLogW")]
        public static readonly delegate*<ushort*, ushort*, void*> OpenEventLog = &OpenEventLogW;

        [NativeTypeName("#define RegisterEventSource RegisterEventSourceW")]
        public static readonly delegate*<ushort*, ushort*, void*> RegisterEventSource = &RegisterEventSourceW;

        [NativeTypeName("#define OpenBackupEventLog OpenBackupEventLogW")]
        public static readonly delegate*<ushort*, ushort*, void*> OpenBackupEventLog = &OpenBackupEventLogW;

        [NativeTypeName("#define ReadEventLog ReadEventLogW")]
        public static readonly delegate*<void*, uint, uint, void*, uint, uint*, uint*, int> ReadEventLog = &ReadEventLogW;

        [NativeTypeName("#define ReportEvent ReportEventW")]
        public static readonly delegate*<void*, ushort, ushort, uint, void*, ushort, uint, ushort**, void*, int> ReportEvent = &ReportEventW;

        [NativeTypeName("#define EVENTLOG_FULL_INFO 0")]
        public const int EVENTLOG_FULL_INFO = 0;

        [NativeTypeName("#define OPERATION_API_VERSION 1")]
        public const int OPERATION_API_VERSION = 1;

        [NativeTypeName("#define OPERATION_START_TRACE_CURRENT_THREAD 0x1")]
        public const int OPERATION_START_TRACE_CURRENT_THREAD = 0x1;

        [NativeTypeName("#define OPERATION_END_DISCARD 0x1")]
        public const int OPERATION_END_DISCARD = 0x1;

        [NativeTypeName("#define IsBadStringPtr IsBadStringPtrW")]
        public static readonly delegate*<ushort*, ulong, int> IsBadStringPtr = &IsBadStringPtrW;

        [NativeTypeName("#define LookupAccountSid LookupAccountSidW")]
        public static readonly delegate*<ushort*, void*, ushort*, uint*, ushort*, uint*, SID_NAME_USE*, int> LookupAccountSid = &LookupAccountSidW;

        [NativeTypeName("#define LookupAccountName LookupAccountNameW")]
        public static readonly delegate*<ushort*, ushort*, void*, uint*, ushort*, uint*, SID_NAME_USE*, int> LookupAccountName = &LookupAccountNameW;

        [NativeTypeName("#define LookupAccountNameLocal LookupAccountNameLocalW")]
        public static readonly delegate*<ushort*, void*, uint*, ushort*, uint*, SID_NAME_USE*, int> LookupAccountNameLocal = &LookupAccountNameLocalW;

        [NativeTypeName("#define LookupAccountSidLocal LookupAccountSidLocalW")]
        public static readonly delegate*<void*, ushort*, uint*, ushort*, uint*, SID_NAME_USE*, int> LookupAccountSidLocal = &LookupAccountSidLocalW;

        [NativeTypeName("#define LookupPrivilegeValue LookupPrivilegeValueW")]
        public static readonly delegate*<ushort*, ushort*, LUID*, int> LookupPrivilegeValue = &LookupPrivilegeValueW;

        [NativeTypeName("#define LookupPrivilegeName LookupPrivilegeNameW")]
        public static readonly delegate*<ushort*, LUID*, ushort*, uint*, int> LookupPrivilegeName = &LookupPrivilegeNameW;

        [NativeTypeName("#define LookupPrivilegeDisplayName LookupPrivilegeDisplayNameW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, uint*, uint*, int> LookupPrivilegeDisplayName = &LookupPrivilegeDisplayNameW;

        [NativeTypeName("#define BuildCommDCB BuildCommDCBW")]
        public static readonly delegate*<ushort*, DCB*, int> BuildCommDCB = &BuildCommDCBW;

        [NativeTypeName("#define BuildCommDCBAndTimeouts BuildCommDCBAndTimeoutsW")]
        public static readonly delegate*<ushort*, DCB*, COMMTIMEOUTS*, int> BuildCommDCBAndTimeouts = &BuildCommDCBAndTimeoutsW;

        [NativeTypeName("#define CommConfigDialog CommConfigDialogW")]
        public static readonly delegate*<ushort*, HWND__*, COMMCONFIG*, int> CommConfigDialog = &CommConfigDialogW;

        [NativeTypeName("#define GetDefaultCommConfig GetDefaultCommConfigW")]
        public static readonly delegate*<ushort*, COMMCONFIG*, uint*, int> GetDefaultCommConfig = &GetDefaultCommConfigW;

        [NativeTypeName("#define SetDefaultCommConfig SetDefaultCommConfigW")]
        public static readonly delegate*<ushort*, COMMCONFIG*, uint, int> SetDefaultCommConfig = &SetDefaultCommConfigW;

        [NativeTypeName("#define MAX_COMPUTERNAME_LENGTH 15")]
        public const int MAX_COMPUTERNAME_LENGTH = 15;

        [NativeTypeName("#define GetComputerName GetComputerNameW")]
        public static readonly delegate*<ushort*, uint*, int> GetComputerName = &GetComputerNameW;

        [NativeTypeName("#define DnsHostnameToComputerName DnsHostnameToComputerNameW")]
        public static readonly delegate*<ushort*, ushort*, uint*, int> DnsHostnameToComputerName = &DnsHostnameToComputerNameW;

        [NativeTypeName("#define GetUserName GetUserNameW")]
        public static readonly delegate*<ushort*, uint*, int> GetUserName = &GetUserNameW;

        [NativeTypeName("#define LOGON32_LOGON_INTERACTIVE 2")]
        public const int LOGON32_LOGON_INTERACTIVE = 2;

        [NativeTypeName("#define LOGON32_LOGON_NETWORK 3")]
        public const int LOGON32_LOGON_NETWORK = 3;

        [NativeTypeName("#define LOGON32_LOGON_BATCH 4")]
        public const int LOGON32_LOGON_BATCH = 4;

        [NativeTypeName("#define LOGON32_LOGON_SERVICE 5")]
        public const int LOGON32_LOGON_SERVICE = 5;

        [NativeTypeName("#define LOGON32_LOGON_UNLOCK 7")]
        public const int LOGON32_LOGON_UNLOCK = 7;

        [NativeTypeName("#define LOGON32_LOGON_NETWORK_CLEARTEXT 8")]
        public const int LOGON32_LOGON_NETWORK_CLEARTEXT = 8;

        [NativeTypeName("#define LOGON32_LOGON_NEW_CREDENTIALS 9")]
        public const int LOGON32_LOGON_NEW_CREDENTIALS = 9;

        [NativeTypeName("#define LOGON32_PROVIDER_DEFAULT 0")]
        public const int LOGON32_PROVIDER_DEFAULT = 0;

        [NativeTypeName("#define LOGON32_PROVIDER_WINNT35 1")]
        public const int LOGON32_PROVIDER_WINNT35 = 1;

        [NativeTypeName("#define LOGON32_PROVIDER_WINNT40 2")]
        public const int LOGON32_PROVIDER_WINNT40 = 2;

        [NativeTypeName("#define LOGON32_PROVIDER_WINNT50 3")]
        public const int LOGON32_PROVIDER_WINNT50 = 3;

        [NativeTypeName("#define LOGON32_PROVIDER_VIRTUAL 4")]
        public const int LOGON32_PROVIDER_VIRTUAL = 4;

        [NativeTypeName("#define LogonUser LogonUserW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, uint, uint, void**, int> LogonUser = &LogonUserW;

        [NativeTypeName("#define LogonUserEx LogonUserExW")]
        public static readonly delegate*<ushort*, ushort*, ushort*, uint, uint, void**, void**, void**, uint*, QUOTA_LIMITS*, int> LogonUserEx = &LogonUserExW;

        [NativeTypeName("#define LOGON_WITH_PROFILE 0x00000001")]
        public const int LOGON_WITH_PROFILE = 0x00000001;

        [NativeTypeName("#define LOGON_NETCREDENTIALS_ONLY 0x00000002")]
        public const int LOGON_NETCREDENTIALS_ONLY = 0x00000002;

        [NativeTypeName("#define LOGON_ZERO_PASSWORD_BUFFER 0x80000000")]
        public const uint LOGON_ZERO_PASSWORD_BUFFER = 0x80000000;

        [NativeTypeName("#define HW_PROFILE_GUIDLEN 39")]
        public const int HW_PROFILE_GUIDLEN = 39;

        [NativeTypeName("#define MAX_PROFILE_LEN 80")]
        public const int MAX_PROFILE_LEN = 80;

        [NativeTypeName("#define DOCKINFO_UNDOCKED (0x1)")]
        public const int DOCKINFO_UNDOCKED = (0x1);

        [NativeTypeName("#define DOCKINFO_DOCKED (0x2)")]
        public const int DOCKINFO_DOCKED = (0x2);

        [NativeTypeName("#define DOCKINFO_USER_SUPPLIED (0x4)")]
        public const int DOCKINFO_USER_SUPPLIED = (0x4);

        [NativeTypeName("#define DOCKINFO_USER_UNDOCKED (DOCKINFO_USER_SUPPLIED | DOCKINFO_UNDOCKED)")]
        public const int DOCKINFO_USER_UNDOCKED = ((0x4) | (0x1));

        [NativeTypeName("#define DOCKINFO_USER_DOCKED (DOCKINFO_USER_SUPPLIED | DOCKINFO_DOCKED)")]
        public const int DOCKINFO_USER_DOCKED = ((0x4) | (0x2));

        [NativeTypeName("#define GetCurrentHwProfile GetCurrentHwProfileW")]
        public static readonly delegate*<HW_PROFILE_INFOW*, int> GetCurrentHwProfile = &GetCurrentHwProfileW;

        [NativeTypeName("#define VerifyVersionInfo VerifyVersionInfoW")]
        public static readonly delegate*<OSVERSIONINFOEXW*, uint, ulong, int> VerifyVersionInfo = &VerifyVersionInfoW;

        [NativeTypeName("#define TC_NORMAL 0")]
        public const int TC_NORMAL = 0;

        [NativeTypeName("#define TC_HARDERR 1")]
        public const int TC_HARDERR = 1;

        [NativeTypeName("#define TC_GP_TRAP 2")]
        public const int TC_GP_TRAP = 2;

        [NativeTypeName("#define TC_SIGNAL 3")]
        public const int TC_SIGNAL = 3;

        [NativeTypeName("#define AC_LINE_OFFLINE 0x00")]
        public const int AC_LINE_OFFLINE = 0x00;

        [NativeTypeName("#define AC_LINE_ONLINE 0x01")]
        public const int AC_LINE_ONLINE = 0x01;

        [NativeTypeName("#define AC_LINE_BACKUP_POWER 0x02")]
        public const int AC_LINE_BACKUP_POWER = 0x02;

        [NativeTypeName("#define AC_LINE_UNKNOWN 0xFF")]
        public const int AC_LINE_UNKNOWN = 0xFF;

        [NativeTypeName("#define BATTERY_FLAG_HIGH 0x01")]
        public const int BATTERY_FLAG_HIGH = 0x01;

        [NativeTypeName("#define BATTERY_FLAG_LOW 0x02")]
        public const int BATTERY_FLAG_LOW = 0x02;

        [NativeTypeName("#define BATTERY_FLAG_CRITICAL 0x04")]
        public const int BATTERY_FLAG_CRITICAL = 0x04;

        [NativeTypeName("#define BATTERY_FLAG_CHARGING 0x08")]
        public const int BATTERY_FLAG_CHARGING = 0x08;

        [NativeTypeName("#define BATTERY_FLAG_NO_BATTERY 0x80")]
        public const int BATTERY_FLAG_NO_BATTERY = 0x80;

        [NativeTypeName("#define BATTERY_FLAG_UNKNOWN 0xFF")]
        public const int BATTERY_FLAG_UNKNOWN = 0xFF;

        [NativeTypeName("#define BATTERY_PERCENTAGE_UNKNOWN 0xFF")]
        public const int BATTERY_PERCENTAGE_UNKNOWN = 0xFF;

        [NativeTypeName("#define SYSTEM_STATUS_FLAG_POWER_SAVING_ON 0x01")]
        public const int SYSTEM_STATUS_FLAG_POWER_SAVING_ON = 0x01;

        [NativeTypeName("#define BATTERY_LIFE_UNKNOWN 0xFFFFFFFF")]
        public const uint BATTERY_LIFE_UNKNOWN = 0xFFFFFFFF;

        [NativeTypeName("#define FindFirstVolumeMountPoint FindFirstVolumeMountPointW")]
        public static readonly delegate*<ushort*, ushort*, uint, void*> FindFirstVolumeMountPoint = &FindFirstVolumeMountPointW;

        [NativeTypeName("#define FindNextVolumeMountPoint FindNextVolumeMountPointW")]
        public static readonly delegate*<void*, ushort*, uint, int> FindNextVolumeMountPoint = &FindNextVolumeMountPointW;

        [NativeTypeName("#define SetVolumeMountPoint SetVolumeMountPointW")]
        public static readonly delegate*<ushort*, ushort*, int> SetVolumeMountPoint = &SetVolumeMountPointW;

        [NativeTypeName("#define ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID (0x00000001)")]
        public const int ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID = (0x00000001);

        [NativeTypeName("#define ACTCTX_FLAG_LANGID_VALID (0x00000002)")]
        public const int ACTCTX_FLAG_LANGID_VALID = (0x00000002);

        [NativeTypeName("#define ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID (0x00000004)")]
        public const int ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID = (0x00000004);

        [NativeTypeName("#define ACTCTX_FLAG_RESOURCE_NAME_VALID (0x00000008)")]
        public const int ACTCTX_FLAG_RESOURCE_NAME_VALID = (0x00000008);

        [NativeTypeName("#define ACTCTX_FLAG_SET_PROCESS_DEFAULT (0x00000010)")]
        public const int ACTCTX_FLAG_SET_PROCESS_DEFAULT = (0x00000010);

        [NativeTypeName("#define ACTCTX_FLAG_APPLICATION_NAME_VALID (0x00000020)")]
        public const int ACTCTX_FLAG_APPLICATION_NAME_VALID = (0x00000020);

        [NativeTypeName("#define ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF (0x00000040)")]
        public const int ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF = (0x00000040);

        [NativeTypeName("#define ACTCTX_FLAG_HMODULE_VALID (0x00000080)")]
        public const int ACTCTX_FLAG_HMODULE_VALID = (0x00000080);

        [NativeTypeName("#define CreateActCtx CreateActCtxW")]
        public static readonly delegate*<ACTCTXW*, void*> CreateActCtx = &CreateActCtxW;

        [NativeTypeName("#define DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION (0x00000001)")]
        public const int DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION = (0x00000001);

        [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX (0x00000001)")]
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX = (0x00000001);

        [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS (0x00000002)")]
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS = (0x00000002);

        [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA (0x00000004)")]
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA = (0x00000004);

        [NativeTypeName("#define FindActCtxSectionString FindActCtxSectionStringW")]
        public static readonly delegate*<uint, Guid*, uint, ushort*, ACTCTX_SECTION_KEYED_DATA*, int> FindActCtxSectionString = &FindActCtxSectionStringW;

        [NativeTypeName("#define ACTIVATION_CONTEXT_BASIC_INFORMATION_DEFINED 1")]
        public const int ACTIVATION_CONTEXT_BASIC_INFORMATION_DEFINED = 1;

        [NativeTypeName("#define QUERY_ACTCTX_FLAG_USE_ACTIVE_ACTCTX (0x00000004)")]
        public const int QUERY_ACTCTX_FLAG_USE_ACTIVE_ACTCTX = (0x00000004);

        [NativeTypeName("#define QUERY_ACTCTX_FLAG_ACTCTX_IS_HMODULE (0x00000008)")]
        public const int QUERY_ACTCTX_FLAG_ACTCTX_IS_HMODULE = (0x00000008);

        [NativeTypeName("#define QUERY_ACTCTX_FLAG_ACTCTX_IS_ADDRESS (0x00000010)")]
        public const int QUERY_ACTCTX_FLAG_ACTCTX_IS_ADDRESS = (0x00000010);

        [NativeTypeName("#define QUERY_ACTCTX_FLAG_NO_ADDREF (0x80000000)")]
        public const uint QUERY_ACTCTX_FLAG_NO_ADDREF = (0x80000000);

        [NativeTypeName("#define RESTART_MAX_CMD_LINE 1024")]
        public const int RESTART_MAX_CMD_LINE = 1024;

        [NativeTypeName("#define RESTART_NO_CRASH 1")]
        public const int RESTART_NO_CRASH = 1;

        [NativeTypeName("#define RESTART_NO_HANG 2")]
        public const int RESTART_NO_HANG = 2;

        [NativeTypeName("#define RESTART_NO_PATCH 4")]
        public const int RESTART_NO_PATCH = 4;

        [NativeTypeName("#define RESTART_NO_REBOOT 8")]
        public const int RESTART_NO_REBOOT = 8;

        [NativeTypeName("#define RECOVERY_DEFAULT_PING_INTERVAL 5000")]
        public const int RECOVERY_DEFAULT_PING_INTERVAL = 5000;

        [NativeTypeName("#define RECOVERY_MAX_PING_INTERVAL (5 * 60 * 1000)")]
        public const int RECOVERY_MAX_PING_INTERVAL = (5 * 60 * 1000);

        [NativeTypeName("#define FILE_RENAME_FLAG_REPLACE_IF_EXISTS 0x00000001")]
        public const int FILE_RENAME_FLAG_REPLACE_IF_EXISTS = 0x00000001;

        [NativeTypeName("#define FILE_RENAME_FLAG_POSIX_SEMANTICS 0x00000002")]
        public const int FILE_RENAME_FLAG_POSIX_SEMANTICS = 0x00000002;

        [NativeTypeName("#define FILE_RENAME_FLAG_SUPPRESS_PIN_STATE_INHERITANCE 0x00000004")]
        public const int FILE_RENAME_FLAG_SUPPRESS_PIN_STATE_INHERITANCE = 0x00000004;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_DO_NOT_DELETE 0x00000000")]
        public const int FILE_DISPOSITION_FLAG_DO_NOT_DELETE = 0x00000000;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_DELETE 0x00000001")]
        public const int FILE_DISPOSITION_FLAG_DELETE = 0x00000001;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_POSIX_SEMANTICS 0x00000002")]
        public const int FILE_DISPOSITION_FLAG_POSIX_SEMANTICS = 0x00000002;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_FORCE_IMAGE_SECTION_CHECK 0x00000004")]
        public const int FILE_DISPOSITION_FLAG_FORCE_IMAGE_SECTION_CHECK = 0x00000004;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_ON_CLOSE 0x00000008")]
        public const int FILE_DISPOSITION_FLAG_ON_CLOSE = 0x00000008;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_IGNORE_READONLY_ATTRIBUTE 0x00000010")]
        public const int FILE_DISPOSITION_FLAG_IGNORE_READONLY_ATTRIBUTE = 0x00000010;

        [NativeTypeName("#define STORAGE_INFO_FLAGS_ALIGNED_DEVICE 0x00000001")]
        public const int STORAGE_INFO_FLAGS_ALIGNED_DEVICE = 0x00000001;

        [NativeTypeName("#define STORAGE_INFO_FLAGS_PARTITION_ALIGNED_ON_DEVICE 0x00000002")]
        public const int STORAGE_INFO_FLAGS_PARTITION_ALIGNED_ON_DEVICE = 0x00000002;

        [NativeTypeName("#define STORAGE_INFO_OFFSET_UNKNOWN (0xffffffff)")]
        public const uint STORAGE_INFO_OFFSET_UNKNOWN = (0xffffffff);

        [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_LOOPBACK 0x00000001")]
        public const int REMOTE_PROTOCOL_INFO_FLAG_LOOPBACK = 0x00000001;

        [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_OFFLINE 0x00000002")]
        public const int REMOTE_PROTOCOL_INFO_FLAG_OFFLINE = 0x00000002;

        [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_PERSISTENT_HANDLE 0x00000004")]
        public const int REMOTE_PROTOCOL_INFO_FLAG_PERSISTENT_HANDLE = 0x00000004;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_TIMEWARP 0x00000002")]
        public const int RPI_FLAG_SMB2_SHARECAP_TIMEWARP = 0x00000002;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_DFS 0x00000008")]
        public const int RPI_FLAG_SMB2_SHARECAP_DFS = 0x00000008;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_CONTINUOUS_AVAILABILITY 0x00000010")]
        public const int RPI_FLAG_SMB2_SHARECAP_CONTINUOUS_AVAILABILITY = 0x00000010;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_SCALEOUT 0x00000020")]
        public const int RPI_FLAG_SMB2_SHARECAP_SCALEOUT = 0x00000020;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_CLUSTER 0x00000040")]
        public const int RPI_FLAG_SMB2_SHARECAP_CLUSTER = 0x00000040;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_DFS 0x00000001")]
        public const int RPI_SMB2_FLAG_SERVERCAP_DFS = 0x00000001;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_LEASING 0x00000002")]
        public const int RPI_SMB2_FLAG_SERVERCAP_LEASING = 0x00000002;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_LARGEMTU 0x00000004")]
        public const int RPI_SMB2_FLAG_SERVERCAP_LARGEMTU = 0x00000004;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_MULTICHANNEL 0x00000008")]
        public const int RPI_SMB2_FLAG_SERVERCAP_MULTICHANNEL = 0x00000008;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_PERSISTENT_HANDLES 0x00000010")]
        public const int RPI_SMB2_FLAG_SERVERCAP_PERSISTENT_HANDLES = 0x00000010;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_DIRECTORY_LEASING 0x00000020")]
        public const int RPI_SMB2_FLAG_SERVERCAP_DIRECTORY_LEASING = 0x00000020;

        [NativeTypeName("#define SYMBOLIC_LINK_FLAG_DIRECTORY (0x1)")]
        public const int SYMBOLIC_LINK_FLAG_DIRECTORY = (0x1);

        [NativeTypeName("#define SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE (0x2)")]
        public const int SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE = (0x2);

        [NativeTypeName("#define CreateSymbolicLink CreateSymbolicLinkW")]
        public static readonly delegate*<ushort*, ushort*, uint, byte> CreateSymbolicLink = &CreateSymbolicLinkW;

        [NativeTypeName("#define CreateSymbolicLinkTransacted CreateSymbolicLinkTransactedW")]
        public static readonly delegate*<ushort*, ushort*, uint, void*, byte> CreateSymbolicLinkTransacted = &CreateSymbolicLinkTransactedW;
    }
}

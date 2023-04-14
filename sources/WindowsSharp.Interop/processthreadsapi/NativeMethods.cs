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
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    public static unsafe partial class NativeMethods
    {
        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueueUserAPC"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueueUserAPC([NativeTypeName("PAPCFUNC")] delegate* unmanaged<ulong, void> pfnAPC, [NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("ULONG_PTR")] ulong dwData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessTimes"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessTimes([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime, [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentProcess"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* GetCurrentProcess();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentProcessId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentProcessId();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ExitProcess"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void ExitProcess(uint uExitCode);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.TerminateProcess"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TerminateProcess([NativeTypeName("HANDLE")] void* hProcess, uint uExitCode);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetExitCodeProcess"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetExitCodeProcess([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("LPDWORD")] uint* lpExitCode);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SwitchToThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwitchToThread();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateThread([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] ulong dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateRemoteThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateRemoteThread([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] ulong dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* GetCurrentThread();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentThreadId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentThreadId();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenThread([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("DWORD")] uint dwThreadId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadPriority"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadPriority([NativeTypeName("HANDLE")] void* hThread, int nPriority);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadPriorityBoost"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadPriorityBoost([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("BOOL")] int bDisablePriorityBoost);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadPriorityBoost"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadPriorityBoost([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("PBOOL")] int* pDisablePriorityBoost);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadPriority"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern int GetThreadPriority([NativeTypeName("HANDLE")] void* hThread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ExitThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void ExitThread([NativeTypeName("DWORD")] uint dwExitCode);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.TerminateThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TerminateThread([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("DWORD")] uint dwExitCode);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetExitCodeThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetExitCodeThread([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("LPDWORD")] uint* lpExitCode);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SuspendThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SuspendThread([NativeTypeName("HANDLE")] void* hThread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ResumeThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ResumeThread([NativeTypeName("HANDLE")] void* hThread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.TlsAlloc"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint TlsAlloc();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.TlsGetValue"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* TlsGetValue([NativeTypeName("DWORD")] uint dwTlsIndex);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.TlsSetValue"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TlsSetValue([NativeTypeName("DWORD")] uint dwTlsIndex, [NativeTypeName("LPVOID")] void* lpTlsValue);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.TlsFree"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TlsFree([NativeTypeName("DWORD")] uint dwTlsIndex);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateProcessA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessA([NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPSTR")] sbyte* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateProcessW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessW([NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessShutdownParameters"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessShutdownParameters([NativeTypeName("DWORD")] uint dwLevel, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessVersion"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessVersion([NativeTypeName("DWORD")] uint ProcessId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetStartupInfoW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void GetStartupInfoW([NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateProcessAsUserW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessAsUserW([NativeTypeName("HANDLE")] void* hToken, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentProcessToken"]/*' />
        [return: NativeTypeName("HANDLE")]
        public static void* GetCurrentProcessToken()
        {
            return (void*)(unchecked((long)(-4)));
        }

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentThreadToken"]/*' />
        [return: NativeTypeName("HANDLE")]
        public static void* GetCurrentThreadToken()
        {
            return (void*)(unchecked((long)(-5)));
        }

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentThreadEffectiveToken"]/*' />
        [return: NativeTypeName("HANDLE")]
        public static void* GetCurrentThreadEffectiveToken()
        {
            return (void*)(unchecked((long)(-6)));
        }

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadToken"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadToken([NativeTypeName("PHANDLE")] void** Thread, [NativeTypeName("HANDLE")] void* Token);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenProcessToken"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenProcessToken([NativeTypeName("HANDLE")] void* ProcessHandle, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PHANDLE")] void** TokenHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenThreadToken"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenThreadToken([NativeTypeName("HANDLE")] void* ThreadHandle, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("BOOL")] int OpenAsSelf, [NativeTypeName("PHANDLE")] void** TokenHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetPriorityClass"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPriorityClass([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD")] uint dwPriorityClass);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetPriorityClass"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPriorityClass([NativeTypeName("HANDLE")] void* hProcess);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadStackGuarantee"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadStackGuarantee([NativeTypeName("PULONG")] uint* StackSizeInBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ProcessIdToSessionId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ProcessIdToSessionId([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("DWORD *")] uint* pSessionId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessId([NativeTypeName("HANDLE")] void* Process);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadId"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetThreadId([NativeTypeName("HANDLE")] void* Thread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FlushProcessWriteBuffers"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void FlushProcessWriteBuffers();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessIdOfThread"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessIdOfThread([NativeTypeName("HANDLE")] void* Thread);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.InitializeProcThreadAttributeList"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeProcThreadAttributeList([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] _PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList, [NativeTypeName("DWORD")] uint dwAttributeCount, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PSIZE_T")] ulong* lpSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteProcThreadAttributeList"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void DeleteProcThreadAttributeList([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] _PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UpdateProcThreadAttribute"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateProcThreadAttribute([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] _PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong Attribute, [NativeTypeName("PVOID")] void* lpValue, [NativeTypeName("SIZE_T")] ulong cbSize, [NativeTypeName("PVOID")] void* lpPreviousValue, [NativeTypeName("PSIZE_T")] ulong* lpReturnSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessDynamicEHContinuationTargets"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDynamicEHContinuationTargets([NativeTypeName("HANDLE")] void* Process, ushort NumberOfTargets, [NativeTypeName("PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET")] PROCESS_DYNAMIC_EH_CONTINUATION_TARGET* Targets);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessDynamicEnforcedCetCompatibleRanges"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDynamicEnforcedCetCompatibleRanges([NativeTypeName("HANDLE")] void* Process, ushort NumberOfRanges, [NativeTypeName("PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE")] PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE* Ranges);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessAffinityUpdateMode"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessAffinityUpdateMode([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryProcessAffinityUpdateMode"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryProcessAffinityUpdateMode([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateRemoteThreadEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateRemoteThreadEx([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] ulong dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] _PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentThreadStackLimits"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void GetCurrentThreadStackLimits([NativeTypeName("PULONG_PTR")] ulong* LowLimit, [NativeTypeName("PULONG_PTR")] ulong* HighLimit);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadContext"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadContext([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("LPCONTEXT")] CONTEXT* lpContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessMitigationPolicy"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessMitigationPolicy([NativeTypeName("HANDLE")] void* hProcess, PROCESS_MITIGATION_POLICY MitigationPolicy, [NativeTypeName("PVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] ulong dwLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadContext"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadContext([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("const CONTEXT *")] CONTEXT* lpContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessMitigationPolicy"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessMitigationPolicy(PROCESS_MITIGATION_POLICY MitigationPolicy, [NativeTypeName("PVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] ulong dwLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FlushInstructionCache"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushInstructionCache([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] ulong dwSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadTimes"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadTimes([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime, [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.OpenProcess"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* OpenProcess([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("DWORD")] uint dwProcessId);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsProcessorFeaturePresent"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessorFeaturePresent([NativeTypeName("DWORD")] uint ProcessorFeature);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessHandleCount"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessHandleCount([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("PDWORD")] uint* pdwHandleCount);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentProcessorNumber"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentProcessorNumber();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadIdealProcessorEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadIdealProcessorEx([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpPreviousIdealProcessor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadIdealProcessorEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadIdealProcessorEx([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCurrentProcessorNumberEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void GetCurrentProcessorNumberEx([NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* ProcNumber);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessPriorityBoost"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessPriorityBoost([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("PBOOL")] int* pDisablePriorityBoost);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessPriorityBoost"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessPriorityBoost([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("BOOL")] int bDisablePriorityBoost);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadIOPendingFlag"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadIOPendingFlag([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("PBOOL")] int* lpIOIsPending);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetSystemTimes"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemTimes([NativeTypeName("PFILETIME")] FILETIME* lpIdleTime, [NativeTypeName("PFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("PFILETIME")] FILETIME* lpUserTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadInformation([NativeTypeName("HANDLE")] void* hThread, THREAD_INFORMATION_CLASS ThreadInformationClass, [NativeTypeName("LPVOID")] void* ThreadInformation, [NativeTypeName("DWORD")] uint ThreadInformationSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadInformation([NativeTypeName("HANDLE")] void* hThread, THREAD_INFORMATION_CLASS ThreadInformationClass, [NativeTypeName("LPVOID")] void* ThreadInformation, [NativeTypeName("DWORD")] uint ThreadInformationSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.IsProcessCritical"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessCritical([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("PBOOL")] int* Critical);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProtectedPolicy"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProtectedPolicy([NativeTypeName("LPCGUID")] Guid* PolicyGuid, [NativeTypeName("ULONG_PTR")] ulong PolicyValue, [NativeTypeName("PULONG_PTR")] ulong* OldPolicyValue);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryProtectedPolicy"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryProtectedPolicy([NativeTypeName("LPCGUID")] Guid* PolicyGuid, [NativeTypeName("PULONG_PTR")] ulong* PolicyValue);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadIdealProcessor"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetThreadIdealProcessor([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("DWORD")] uint dwIdealProcessor);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessInformation([NativeTypeName("HANDLE")] void* hProcess, PROCESS_INFORMATION_CLASS ProcessInformationClass, [NativeTypeName("LPVOID")] void* ProcessInformation, [NativeTypeName("DWORD")] uint ProcessInformationSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessInformation([NativeTypeName("HANDLE")] void* hProcess, PROCESS_INFORMATION_CLASS ProcessInformationClass, [NativeTypeName("LPVOID")] void* ProcessInformation, [NativeTypeName("DWORD")] uint ProcessInformationSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetSystemCpuSetInformation"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemCpuSetInformation([NativeTypeName("PSYSTEM_CPU_SET_INFORMATION")] SYSTEM_CPU_SET_INFORMATION* Information, [NativeTypeName("ULONG")] uint BufferLength, [NativeTypeName("PULONG")] uint* ReturnedLength, [NativeTypeName("HANDLE")] void* Process, [NativeTypeName("ULONG")] uint Flags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessDefaultCpuSets"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDefaultCpuSets([NativeTypeName("HANDLE")] void* Process, [NativeTypeName("PULONG")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount, [NativeTypeName("PULONG")] uint* RequiredIdCount);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetProcessDefaultCpuSets"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDefaultCpuSets([NativeTypeName("HANDLE")] void* Process, [NativeTypeName("const ULONG *")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadSelectedCpuSets"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadSelectedCpuSets([NativeTypeName("HANDLE")] void* Thread, [NativeTypeName("PULONG")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount, [NativeTypeName("PULONG")] uint* RequiredIdCount);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadSelectedCpuSets"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadSelectedCpuSets([NativeTypeName("HANDLE")] void* Thread, [NativeTypeName("const ULONG *")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateProcessAsUserA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessAsUserA([NativeTypeName("HANDLE")] void* hToken, [NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPSTR")] sbyte* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetProcessShutdownParameters"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessShutdownParameters([NativeTypeName("LPDWORD")] uint* lpdwLevel, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetThreadDescription"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetThreadDescription([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("PCWSTR")] ushort* lpThreadDescription);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetThreadDescription"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThreadDescription([NativeTypeName("HANDLE")] void* hThread, [NativeTypeName("PWSTR *")] ushort** ppszThreadDescription);

        [NativeTypeName("#define TLS_OUT_OF_INDEXES ((DWORD)0xFFFFFFFF)")]
        public const uint TLS_OUT_OF_INDEXES = ((uint)(0xFFFFFFFF));

        [NativeTypeName("#define CreateProcess CreateProcessW")]
        public static readonly delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, SECURITY_ATTRIBUTES*, int, uint, void*, ushort*, STARTUPINFOW*, PROCESS_INFORMATION*, int> CreateProcess = &CreateProcessW;

        [NativeTypeName("#define GetStartupInfo GetStartupInfoW")]
        public static readonly delegate*<STARTUPINFOW*, void> GetStartupInfo = &GetStartupInfoW;

        [NativeTypeName("#define CreateProcessAsUser CreateProcessAsUserW")]
        public static readonly delegate*<void*, ushort*, ushort*, SECURITY_ATTRIBUTES*, SECURITY_ATTRIBUTES*, int, uint, void*, ushort*, STARTUPINFOW*, PROCESS_INFORMATION*, int> CreateProcessAsUser = &CreateProcessAsUserW;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_REPLACE_VALUE 0x00000001")]
        public const int PROC_THREAD_ATTRIBUTE_REPLACE_VALUE = 0x00000001;

        [NativeTypeName("#define PROCESS_AFFINITY_ENABLE_AUTO_UPDATE 0x00000001UL")]
        public const uint PROCESS_AFFINITY_ENABLE_AUTO_UPDATE = 0x00000001U;

        [NativeTypeName("#define THREAD_POWER_THROTTLING_CURRENT_VERSION 1")]
        public const int THREAD_POWER_THROTTLING_CURRENT_VERSION = 1;

        [NativeTypeName("#define THREAD_POWER_THROTTLING_EXECUTION_SPEED 0x1")]
        public const int THREAD_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

        [NativeTypeName("#define THREAD_POWER_THROTTLING_VALID_FLAGS (THREAD_POWER_THROTTLING_EXECUTION_SPEED)")]
        public const int THREAD_POWER_THROTTLING_VALID_FLAGS = (0x1);

        [NativeTypeName("#define PME_CURRENT_VERSION 1")]
        public const int PME_CURRENT_VERSION = 1;

        [NativeTypeName("#define PME_FAILFAST_ON_COMMIT_FAIL_DISABLE 0x0")]
        public const int PME_FAILFAST_ON_COMMIT_FAIL_DISABLE = 0x0;

        [NativeTypeName("#define PME_FAILFAST_ON_COMMIT_FAIL_ENABLE 0x1")]
        public const int PME_FAILFAST_ON_COMMIT_FAIL_ENABLE = 0x1;

        [NativeTypeName("#define PROCESS_POWER_THROTTLING_CURRENT_VERSION 1")]
        public const int PROCESS_POWER_THROTTLING_CURRENT_VERSION = 1;

        [NativeTypeName("#define PROCESS_POWER_THROTTLING_EXECUTION_SPEED 0x1")]
        public const int PROCESS_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

        [NativeTypeName("#define PROCESS_POWER_THROTTLING_VALID_FLAGS (PROCESS_POWER_THROTTLING_EXECUTION_SPEED)")]
        public const int PROCESS_POWER_THROTTLING_VALID_FLAGS = (0x1);

        [NativeTypeName("#define PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND 0x1")]
        public const int PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND = 0x1;

        [NativeTypeName("#define PROCESS_LEAP_SECOND_INFO_VALID_FLAGS (PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND)")]
        public const int PROCESS_LEAP_SECOND_INFO_VALID_FLAGS = (0x1);
    }
}

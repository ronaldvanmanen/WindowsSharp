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

using System.Runtime.InteropServices;

namespace DirectXSharp.Interop
{
    public static unsafe partial class NativeMethods
    {
        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CompareFileTime"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CompareFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime1, [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime2);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateDirectoryA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateDirectoryW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] void* hTemplateFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] void* hTemplateFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DefineDosDeviceW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DefineDosDeviceW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpDeviceName, [NativeTypeName("LPCWSTR")] ushort* lpTargetPath);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.DeleteVolumeMountPointW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FileTimeToLocalFileTime"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileTimeToLocalFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLocalFileTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindClose"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindClose([NativeTypeName("HANDLE")] void* hFindFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindCloseChangeNotification"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindCloseChangeNotification([NativeTypeName("HANDLE")] void* hChangeHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstChangeNotificationA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstChangeNotificationA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstChangeNotificationW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstChangeNotificationW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstFileExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstFileExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstFileExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstFileExW([NativeTypeName("LPCWSTR")] ushort* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstVolumeW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstVolumeW([NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextChangeNotification"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextChangeNotification([NativeTypeName("HANDLE")] void* hChangeHandle);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextFileA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileA([NativeTypeName("HANDLE")] void* hFindFile, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextFileW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileW([NativeTypeName("HANDLE")] void* hFindFile, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextVolumeW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeW([NativeTypeName("HANDLE")] void* hFindVolume, [NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindVolumeClose"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindVolumeClose([NativeTypeName("HANDLE")] void* hFindVolume);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FlushFileBuffers"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushFileBuffers([NativeTypeName("HANDLE")] void* hFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDiskFreeSpaceA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDiskFreeSpaceW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDiskFreeSpaceExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceExA([NativeTypeName("LPCSTR")] sbyte* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDiskFreeSpaceExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceExW([NativeTypeName("LPCWSTR")] ushort* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDiskSpaceInformationA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDiskSpaceInformationA([NativeTypeName("LPCSTR")] sbyte* rootPath, DISK_SPACE_INFORMATION* diskSpaceInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDiskSpaceInformationW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDiskSpaceInformationW([NativeTypeName("LPCWSTR")] ushort* rootPath, DISK_SPACE_INFORMATION* diskSpaceInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDriveTypeA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetDriveTypeA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetDriveTypeW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetDriveTypeW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileAttributesA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileAttributesW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileAttributesExA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileAttributesExW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesExW([NativeTypeName("LPCWSTR")] ushort* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileInformationByHandle"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileInformationByHandle([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPBY_HANDLE_FILE_INFORMATION")] BY_HANDLE_FILE_INFORMATION* lpFileInformation);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileSize"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileSize([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileSizeEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileSizeEx([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpFileSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileType"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileType([NativeTypeName("HANDLE")] void* hFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFinalPathNameByHandleA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFinalPathNameByHandleA([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPSTR")] sbyte* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFinalPathNameByHandleW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFinalPathNameByHandleW([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPWSTR")] ushort* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFileTime"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileTime([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastAccessTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastWriteTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFullPathNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetFullPathNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetLogicalDrives"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDrives();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetLogicalDriveStringsW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDriveStringsW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetLongPathNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetLongPathNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameW([NativeTypeName("LPCWSTR")] ushort* lpszShortPath, [NativeTypeName("LPWSTR")] ushort* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetShortPathNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetShortPathNameW([NativeTypeName("LPCWSTR")] ushort* lpszLongPath, [NativeTypeName("LPWSTR")] ushort* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetTempFileNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetTempFileNameW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("LPCWSTR")] ushort* lpPrefixString, uint uUnique, [NativeTypeName("LPWSTR")] ushort* lpTempFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumeInformationByHandleW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationByHandleW([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumeInformationW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumePathNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNameW([NativeTypeName("LPCWSTR")] ushort* lpszFileName, [NativeTypeName("LPWSTR")] ushort* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LocalFileTimeToFileTime"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LocalFileTimeToFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpLocalFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LockFile"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockFile([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.LockFileEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockFileEx([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.QueryDosDeviceW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryDosDeviceW([NativeTypeName("LPCWSTR")] ushort* lpDeviceName, [NativeTypeName("LPWSTR")] ushort* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadFile"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFile([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadFileEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFileEx([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.ReadFileScatter"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFileScatter([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT []")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RemoveDirectoryA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.RemoveDirectoryW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetEndOfFile"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEndOfFile([NativeTypeName("HANDLE")] void* hFile);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileAttributesA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileAttributesW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileInformationByHandle"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileInformationByHandle([NativeTypeName("HANDLE")] void* hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFilePointer"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetFilePointer([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LONG")] int lDistanceToMove, [NativeTypeName("PLONG")] int* lpDistanceToMoveHigh, [NativeTypeName("DWORD")] uint dwMoveMethod);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFilePointerEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFilePointerEx([NativeTypeName("HANDLE")] void* hFile, LARGE_INTEGER liDistanceToMove, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpNewFilePointer, [NativeTypeName("DWORD")] uint dwMoveMethod);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileTime"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileTime([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("const FILETIME *")] FILETIME* lpCreationTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastAccessTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastWriteTime);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileValidData"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileValidData([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LONGLONG")] long ValidDataLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UnlockFile"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnlockFile([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.UnlockFileEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnlockFileEx([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteFile"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFile([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteFileEx"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFileEx([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.WriteFileGather"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFileGather([NativeTypeName("HANDLE")] void* hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT []")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetTempPathW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTempPathW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumeNameForVolumeMountPointW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeNameForVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumePathNamesForVolumeNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNamesForVolumeNameW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeName, [NativeTypeName("LPWCH")] ushort* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.CreateFile2"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CreateFile2([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("LPCREATEFILE2_EXTENDED_PARAMETERS")] CREATEFILE2_EXTENDED_PARAMETERS* pCreateExParams);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileIoOverlappedRange"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileIoOverlappedRange([NativeTypeName("HANDLE")] void* FileHandle, [NativeTypeName("PUCHAR")] byte* OverlappedRangeStart, [NativeTypeName("ULONG")] uint Length);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCompressedFileSizeA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetCompressedFileSizeW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstStreamW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstStreamW([NativeTypeName("LPCWSTR")] ushort* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextStreamW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextStreamW([NativeTypeName("HANDLE")] void* hFindStream, [NativeTypeName("LPVOID")] void* lpFindStreamData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.AreFileApisANSI"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreFileApisANSI();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetTempPathA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTempPathA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindFirstFileNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* FindFirstFileNameW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.FindNextFileNameW"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileNameW([NativeTypeName("HANDLE")] void* hFindStream, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetVolumeInformationA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPSTR")] sbyte* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPSTR")] sbyte* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.GetTempFileNameA"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetTempFileNameA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPCSTR")] sbyte* lpPrefixString, uint uUnique, [NativeTypeName("LPSTR")] sbyte* lpTempFileName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileApisToOEM"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void SetFileApisToOEM();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.SetFileApisToANSI"]/*' />
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern void SetFileApisToANSI();

        [NativeTypeName("#define CREATE_NEW 1")]
        public const int CREATE_NEW = 1;

        [NativeTypeName("#define CREATE_ALWAYS 2")]
        public const int CREATE_ALWAYS = 2;

        [NativeTypeName("#define OPEN_EXISTING 3")]
        public const int OPEN_EXISTING = 3;

        [NativeTypeName("#define OPEN_ALWAYS 4")]
        public const int OPEN_ALWAYS = 4;

        [NativeTypeName("#define TRUNCATE_EXISTING 5")]
        public const int TRUNCATE_EXISTING = 5;

        [NativeTypeName("#define INVALID_FILE_SIZE ((DWORD)0xFFFFFFFF)")]
        public const uint INVALID_FILE_SIZE = ((uint)(0xFFFFFFFF));

        [NativeTypeName("#define INVALID_SET_FILE_POINTER ((DWORD)-1)")]
        public const uint INVALID_SET_FILE_POINTER = unchecked((uint)(-1));

        [NativeTypeName("#define INVALID_FILE_ATTRIBUTES ((DWORD)-1)")]
        public const uint INVALID_FILE_ATTRIBUTES = unchecked((uint)(-1));

        [NativeTypeName("#define CreateDirectory CreateDirectoryW")]
        public static readonly delegate*<ushort*, SECURITY_ATTRIBUTES*, int> CreateDirectory = &CreateDirectoryW;

        [NativeTypeName("#define CreateFile CreateFileW")]
        public static readonly delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, uint, uint, void*, void*> CreateFile = &CreateFileW;

        [NativeTypeName("#define DefineDosDevice DefineDosDeviceW")]
        public static readonly delegate*<uint, ushort*, ushort*, int> DefineDosDevice = &DefineDosDeviceW;

        [NativeTypeName("#define DeleteFile DeleteFileW")]
        public static readonly delegate*<ushort*, int> DeleteFile = &DeleteFileW;

        [NativeTypeName("#define DeleteVolumeMountPoint DeleteVolumeMountPointW")]
        public static readonly delegate*<ushort*, int> DeleteVolumeMountPoint = &DeleteVolumeMountPointW;

        [NativeTypeName("#define FindFirstChangeNotification FindFirstChangeNotificationW")]
        public static readonly delegate*<ushort*, int, uint, void*> FindFirstChangeNotification = &FindFirstChangeNotificationW;

        [NativeTypeName("#define FindFirstFile FindFirstFileW")]
        public static readonly delegate*<ushort*, WIN32_FIND_DATAW*, void*> FindFirstFile = &FindFirstFileW;

        [NativeTypeName("#define FindFirstFileEx FindFirstFileExW")]
        public static readonly delegate*<ushort*, FINDEX_INFO_LEVELS, void*, FINDEX_SEARCH_OPS, void*, uint, void*> FindFirstFileEx = &FindFirstFileExW;

        [NativeTypeName("#define FindFirstVolume FindFirstVolumeW")]
        public static readonly delegate*<ushort*, uint, void*> FindFirstVolume = &FindFirstVolumeW;

        [NativeTypeName("#define FindNextFile FindNextFileW")]
        public static readonly delegate*<void*, WIN32_FIND_DATAW*, int> FindNextFile = &FindNextFileW;

        [NativeTypeName("#define FindNextVolume FindNextVolumeW")]
        public static readonly delegate*<void*, ushort*, uint, int> FindNextVolume = &FindNextVolumeW;

        [NativeTypeName("#define GetDiskFreeSpace GetDiskFreeSpaceW")]
        public static readonly delegate*<ushort*, uint*, uint*, uint*, uint*, int> GetDiskFreeSpace = &GetDiskFreeSpaceW;

        [NativeTypeName("#define GetDiskFreeSpaceEx GetDiskFreeSpaceExW")]
        public static readonly delegate*<ushort*, ULARGE_INTEGER*, ULARGE_INTEGER*, ULARGE_INTEGER*, int> GetDiskFreeSpaceEx = &GetDiskFreeSpaceExW;

        [NativeTypeName("#define GetDiskSpaceInformation GetDiskSpaceInformationW")]
        public static readonly delegate*<ushort*, DISK_SPACE_INFORMATION*, int> GetDiskSpaceInformation = &GetDiskSpaceInformationW;

        [NativeTypeName("#define GetDriveType GetDriveTypeW")]
        public static readonly delegate*<ushort*, uint> GetDriveType = &GetDriveTypeW;

        [NativeTypeName("#define GetFileAttributes GetFileAttributesW")]
        public static readonly delegate*<ushort*, uint> GetFileAttributes = &GetFileAttributesW;

        [NativeTypeName("#define GetFileAttributesEx GetFileAttributesExW")]
        public static readonly delegate*<ushort*, GET_FILEEX_INFO_LEVELS, void*, int> GetFileAttributesEx = &GetFileAttributesExW;

        [NativeTypeName("#define GetFinalPathNameByHandle GetFinalPathNameByHandleW")]
        public static readonly delegate*<void*, ushort*, uint, uint, uint> GetFinalPathNameByHandle = &GetFinalPathNameByHandleW;

        [NativeTypeName("#define GetFullPathName GetFullPathNameW")]
        public static readonly delegate*<ushort*, uint, ushort*, ushort**, uint> GetFullPathName = &GetFullPathNameW;

        [NativeTypeName("#define GetLogicalDriveStrings GetLogicalDriveStringsW")]
        public static readonly delegate*<uint, ushort*, uint> GetLogicalDriveStrings = &GetLogicalDriveStringsW;

        [NativeTypeName("#define GetLongPathName GetLongPathNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> GetLongPathName = &GetLongPathNameW;

        [NativeTypeName("#define GetShortPathName GetShortPathNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> GetShortPathName = &GetShortPathNameW;

        [NativeTypeName("#define GetTempFileName GetTempFileNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, ushort*, uint> GetTempFileName = &GetTempFileNameW;

        [NativeTypeName("#define GetVolumeInformation GetVolumeInformationW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint*, uint*, uint*, ushort*, uint, int> GetVolumeInformation = &GetVolumeInformationW;

        [NativeTypeName("#define GetVolumePathName GetVolumePathNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, int> GetVolumePathName = &GetVolumePathNameW;

        [NativeTypeName("#define QueryDosDevice QueryDosDeviceW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> QueryDosDevice = &QueryDosDeviceW;

        [NativeTypeName("#define RemoveDirectory RemoveDirectoryW")]
        public static readonly delegate*<ushort*, int> RemoveDirectory = &RemoveDirectoryW;

        [NativeTypeName("#define SetFileAttributes SetFileAttributesW")]
        public static readonly delegate*<ushort*, uint, int> SetFileAttributes = &SetFileAttributesW;

        [NativeTypeName("#define GetTempPath GetTempPathW")]
        public static readonly delegate*<uint, ushort*, uint> GetTempPath = &GetTempPathW;

        [NativeTypeName("#define GetVolumeNameForVolumeMountPoint GetVolumeNameForVolumeMountPointW")]
        public static readonly delegate*<ushort*, ushort*, uint, int> GetVolumeNameForVolumeMountPoint = &GetVolumeNameForVolumeMountPointW;

        [NativeTypeName("#define GetVolumePathNamesForVolumeName GetVolumePathNamesForVolumeNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint*, int> GetVolumePathNamesForVolumeName = &GetVolumePathNamesForVolumeNameW;

        [NativeTypeName("#define GetCompressedFileSize GetCompressedFileSizeW")]
        public static readonly delegate*<ushort*, uint*, uint> GetCompressedFileSize = &GetCompressedFileSizeW;
    }
}

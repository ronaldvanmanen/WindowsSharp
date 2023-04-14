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

using WindowsSharp.Internals;
using WindowsSharp.Interop;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp
{
    public sealed unsafe class WindowClass : IDisposable
    {
        private readonly WNDCLASSW _wndclass;

        private bool _disposed;

        public WindowClass(string className, uint style)
        {
            if (className is null)
            {
                throw new ArgumentNullException(nameof(className));
            }

            var lpszClassName = new MarshaledString(className);
            var wndclass = new WNDCLASSW
            {
                style = style,
                lpfnWndProc = &WindowProc,
                cbClsExtra = 0,
                cbWndExtra = 0,
                hInstance = null,
                hIcon = null,
                hCursor = null,
                hbrBackground = null,
                lpszMenuName = null,
                lpszClassName = lpszClassName
            };

            var retval = NativeMethods.RegisterClass(&wndclass);
            if (retval == 0)
            {
                var error = Marshal.GetLastPInvokeError();
                var exception = new Win32Exception(error);
                throw exception;
            }

            _wndclass = wndclass;
            _disposed = false;
        }

        ~WindowClass()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        private void Dispose(bool _)
        {
            if (_disposed)
            {
                return;
            }

            try
            {
                var retval = NativeMethods.UnregisterClass(_wndclass.lpszClassName, null);
                if (retval == 0)
                {
                    var error = Marshal.GetLastPInvokeError();
                    var exception = new Win32Exception(error);
                    throw exception;
                }
            }
            finally
            {
                _disposed = true;
            }
        }

        public Window CreateWindow(string windowName, uint style)
        {
            ThrowIfDisposed();

            if (windowName is null)
            {
                throw new ArgumentNullException(nameof(windowName));
            }

            var lpszWindowName = new MarshaledString(windowName);

            var handle = NativeMethods.CreateWindowW(
                _wndclass.lpszClassName,
                lpszWindowName,
                style,
                0,    // Initial X
                0,    // Initial Y
                0,    // Width
                0,    // Height
                null,
                null,
                null,
                null);

            if (handle == null)
            {
                var error = Marshal.GetLastPInvokeError();
                var exception = new Win32Exception(error);
                throw exception;
            }

            return new Window(handle);
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
            {
                var type = GetType();
                var exception = new ObjectDisposedException(type.FullName);
                throw exception;
            }
        }

        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        private static long WindowProc(HWND__* hwnd, uint msg, ulong wparam, long lparam)
        {
            return NativeMethods.DefWindowProcW(hwnd, msg, wparam, lparam);
        }
    }
}

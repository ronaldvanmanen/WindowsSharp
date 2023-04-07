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
using System.Collections.Generic;
using DirectXSharp.Interop;

namespace DirectXSharp
{
    public sealed unsafe class Monitor
    {
        private static readonly Dictionary<IntPtr, Monitor> _lookupTable = new Dictionary<IntPtr, Monitor>();

        private readonly HMONITOR__* _handle;

        private Monitor(HMONITOR__* handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException(nameof(handle));
            }

            _handle = handle;
        }

        public static Monitor FromHandle(HMONITOR__* handle)
        {
            lock (_lookupTable)
            {
                var wrappedHandle = new IntPtr(handle);
                if (!_lookupTable.TryGetValue(wrappedHandle, out var monitor))
                {
                    monitor = new Monitor(handle);
                    _lookupTable.Add(wrappedHandle, monitor);
                    return monitor;
                }
                return monitor;
            }
        }

        public static Monitor? FromPoint(POINT point)
        {
            lock (_lookupTable)
            {
                var handle = NativeMethods.MonitorFromPoint(point, NativeMethods.MONITOR_DEFAULTTONULL);
                if (handle == null)
                {
                    return null;
                }
                return FromHandle(handle);
            }
        }
    }
}

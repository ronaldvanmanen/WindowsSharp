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
using DirectXSharp.Interop;
using static DirectXSharp.Direct3D9Error;

namespace DirectXSharp
{
    public sealed unsafe class Direct3D9Ex : IDisposable
    {
        private IDirect3D9Ex* _handle;

        public Direct3D9Ex()
        : this(NativeMethods.D3D_SDK_VERSION)
        { }

        public Direct3D9Ex(uint sdkVersion)
        {
            fixed (IDirect3D9Ex** handle = &_handle)
            {
                ThrowOnFailure(
                    NativeMethods.Direct3DCreate9Ex(sdkVersion, handle)
                );
            }
        }

        ~Direct3D9Ex()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_handle != null)
            {
                _handle->Release();
                _handle = null;
            }
        }

        public Direct3DDevice9Ex CreateDeviceEx(uint adapter, D3DDEVTYPE deviceType, HWND__* focusWindow, uint behaviorFlags, D3DPRESENT_PARAMETERS* presentationParameters)
        {
            IDirect3DDevice9Ex* handle = null;

            ThrowOnFailure(
               _handle->CreateDeviceEx(
                    adapter,
                    deviceType,
                    focusWindow,
                    behaviorFlags,
                    presentationParameters,
                    null,
                    &handle)
            );

            return new Direct3DDevice9Ex(handle);
        }

        public static implicit operator Direct3D9(Direct3D9Ex instance)
        {
            fixed (Guid* riid = &NativeMethods.IID_IDirect3D9)
            {
                IDirect3D9* handle = null;
                instance._handle->QueryInterface(riid, (void**)&handle);
                return new Direct3D9(handle);
            }
        }
    }
}

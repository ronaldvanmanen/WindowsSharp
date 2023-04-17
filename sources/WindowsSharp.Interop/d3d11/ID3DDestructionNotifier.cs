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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier"]/*' />
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    [NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3DDestructionNotifier
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier*, Guid*, void**, int>)(lpVtbl[0]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier*, uint>)(lpVtbl[1]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier*, uint>)(lpVtbl[2]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.RegisterDestructionCallback"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, void* pData, uint* pCallbackID)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier*, delegate* unmanaged<void*, void>, void*, uint*, int>)(lpVtbl[3]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
        }

        /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.UnregisterDestructionCallback"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterDestructionCallback(uint callbackID)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier*, uint, int>)(lpVtbl[4]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackID);
        }
    }
}

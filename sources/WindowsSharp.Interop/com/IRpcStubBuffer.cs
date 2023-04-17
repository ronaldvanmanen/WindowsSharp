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
    /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer"]/*' />
    [Guid("D5F56AFC-593B-101A-B569-08002B2DBF7A")]
    [NativeTypeName("struct IRpcStubBuffer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRpcStubBuffer
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[1]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[2]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.Connect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Connect(IUnknown* pUnkServer)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, IUnknown*, int>)(lpVtbl[3]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pUnkServer);
        }

        /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.Disconnect"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void Disconnect()
        {
            ((delegate* unmanaged<IRpcStubBuffer*, void>)(lpVtbl[4]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.Invoke"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke(RPCOLEMESSAGE* _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, RPCOLEMESSAGE*, IRpcChannelBuffer*, int>)(lpVtbl[5]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), _prpcmsg, _pRpcChannelBuffer);
        }

        /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.IsIIDSupported"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public IRpcStubBuffer* IsIIDSupported([NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, Guid*, IRpcStubBuffer*>)(lpVtbl[6]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid);
        }

        /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.CountRefs"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("ULONG")]
        public uint CountRefs()
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[7]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.DebugServerQueryInterface"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int DebugServerQueryInterface(void** ppv)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, void**, int>)(lpVtbl[8]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), ppv);
        }

        /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.DebugServerRelease"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void DebugServerRelease(void* pv)
        {
            ((delegate* unmanaged<IRpcStubBuffer*, void*, void>)(lpVtbl[9]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pv);
        }
    }
}

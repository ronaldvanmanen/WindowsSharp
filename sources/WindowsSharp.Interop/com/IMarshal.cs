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
    /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal"]/*' />
    [Guid("00000003-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMarshal : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMarshal
    {
        public void** lpVtbl;

        /// <inheritdoc cref="IUnknown.QueryInterface" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMarshal*, Guid*, void**, int>)(lpVtbl[0]))((IMarshal*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        /// <inheritdoc cref="IUnknown.AddRef" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMarshal*, uint>)(lpVtbl[1]))((IMarshal*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref="IUnknown.Release" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMarshal*, uint>)(lpVtbl[2]))((IMarshal*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.GetUnmarshalClass"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnmarshalClass([NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid)
        {
            return ((delegate* unmanaged<IMarshal*, Guid*, void*, uint, void*, uint, Guid*, int>)(lpVtbl[3]))((IMarshal*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        }

        /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.GetMarshalSizeMax"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetMarshalSizeMax([NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize)
        {
            return ((delegate* unmanaged<IMarshal*, Guid*, void*, uint, void*, uint, uint*, int>)(lpVtbl[4]))((IMarshal*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        }

        /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.MarshalInterface"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int MarshalInterface(IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags)
        {
            return ((delegate* unmanaged<IMarshal*, IStream*, Guid*, void*, uint, void*, uint, int>)(lpVtbl[5]))((IMarshal*)Unsafe.AsPointer(ref this), pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
        }

        /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.UnmarshalInterface"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int UnmarshalInterface(IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IMarshal*, IStream*, Guid*, void**, int>)(lpVtbl[6]))((IMarshal*)Unsafe.AsPointer(ref this), pStm, riid, ppv);
        }

        /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.ReleaseMarshalData"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseMarshalData(IStream* pStm)
        {
            return ((delegate* unmanaged<IMarshal*, IStream*, int>)(lpVtbl[7]))((IMarshal*)Unsafe.AsPointer(ref this), pStm);
        }

        /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.DisconnectObject"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int DisconnectObject([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IMarshal*, uint, int>)(lpVtbl[8]))((IMarshal*)Unsafe.AsPointer(ref this), dwReserved);
        }
    }
}

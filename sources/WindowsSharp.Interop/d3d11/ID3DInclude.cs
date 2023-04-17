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

using System.Runtime.CompilerServices;

namespace WindowsSharp.Interop
{
    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude"]/*' />
    public unsafe partial struct ID3DInclude
    {
        public void** lpVtbl;

        /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Open"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int Open(D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes)
        {
            return ((delegate* unmanaged<ID3DInclude*, D3D_INCLUDE_TYPE, sbyte*, void*, void**, uint*, int>)(lpVtbl[0]))((ID3DInclude*)Unsafe.AsPointer(ref this), IncludeType, pFileName, pParentData, ppData, pBytes);
        }

        /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Close"]/*' />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("LPCVOID")] void* pData)
        {
            return ((delegate* unmanaged<ID3DInclude*, void*, int>)(lpVtbl[1]))((ID3DInclude*)Unsafe.AsPointer(ref this), pData);
        }
    }
}

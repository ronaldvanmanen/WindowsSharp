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

namespace WindowsSharp.Interop
{
    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC"]/*' />
    public unsafe partial struct DXGI_SWAP_CHAIN_DESC
    {
        /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferDesc"]/*' />
        public DXGI_MODE_DESC BufferDesc;

        /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.SampleDesc"]/*' />
        public DXGI_SAMPLE_DESC SampleDesc;

        /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferUsage"]/*' />
        [NativeTypeName("DXGI_USAGE")]
        public uint BufferUsage;

        /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferCount"]/*' />
        public uint BufferCount;

        /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.OutputWindow"]/*' />
        [NativeTypeName("HWND")]
        public HWND__* OutputWindow;

        /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.Windowed"]/*' />
        [NativeTypeName("BOOL")]
        public int Windowed;

        /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.SwapEffect"]/*' />
        public DXGI_SWAP_EFFECT SwapEffect;

        /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.Flags"]/*' />
        public uint Flags;
    }
}

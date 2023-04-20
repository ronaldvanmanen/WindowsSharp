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
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC"]/*' />
    public unsafe partial struct D3D11_PARAMETER_DESC
    {
        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Name"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.SemanticName"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* SemanticName;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Type"]/*' />
        public D3D_SHADER_VARIABLE_TYPE Type;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Class"]/*' />
        public D3D_SHADER_VARIABLE_CLASS Class;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Rows"]/*' />
        public uint Rows;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Columns"]/*' />
        public uint Columns;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.InterpolationMode"]/*' />
        public D3D_INTERPOLATION_MODE InterpolationMode;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Flags"]/*' />
        public D3D_PARAMETER_FLAGS Flags;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.FirstInRegister"]/*' />
        public uint FirstInRegister;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.FirstInComponent"]/*' />
        public uint FirstInComponent;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.FirstOutRegister"]/*' />
        public uint FirstOutRegister;

        /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.FirstOutComponent"]/*' />
        public uint FirstOutComponent;
    }
}

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
    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS"]/*' />
    public enum D3D_SHADER_VARIABLE_CLASS
    {
        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_SCALAR"]/*' />
        D3D_SVC_SCALAR = 0,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_VECTOR"]/*' />
        D3D_SVC_VECTOR = (D3D_SVC_SCALAR + 1),

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_MATRIX_ROWS"]/*' />
        D3D_SVC_MATRIX_ROWS = (D3D_SVC_VECTOR + 1),

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_MATRIX_COLUMNS"]/*' />
        D3D_SVC_MATRIX_COLUMNS = (D3D_SVC_MATRIX_ROWS + 1),

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_OBJECT"]/*' />
        D3D_SVC_OBJECT = (D3D_SVC_MATRIX_COLUMNS + 1),

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_STRUCT"]/*' />
        D3D_SVC_STRUCT = (D3D_SVC_OBJECT + 1),

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_INTERFACE_CLASS"]/*' />
        D3D_SVC_INTERFACE_CLASS = (D3D_SVC_STRUCT + 1),

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_INTERFACE_POINTER"]/*' />
        D3D_SVC_INTERFACE_POINTER = (D3D_SVC_INTERFACE_CLASS + 1),

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_SCALAR"]/*' />
        D3D10_SVC_SCALAR = D3D_SVC_SCALAR,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_VECTOR"]/*' />
        D3D10_SVC_VECTOR = D3D_SVC_VECTOR,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_MATRIX_ROWS"]/*' />
        D3D10_SVC_MATRIX_ROWS = D3D_SVC_MATRIX_ROWS,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_MATRIX_COLUMNS"]/*' />
        D3D10_SVC_MATRIX_COLUMNS = D3D_SVC_MATRIX_COLUMNS,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_OBJECT"]/*' />
        D3D10_SVC_OBJECT = D3D_SVC_OBJECT,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_STRUCT"]/*' />
        D3D10_SVC_STRUCT = D3D_SVC_STRUCT,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D11_SVC_INTERFACE_CLASS"]/*' />
        D3D11_SVC_INTERFACE_CLASS = D3D_SVC_INTERFACE_CLASS,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D11_SVC_INTERFACE_POINTER"]/*' />
        D3D11_SVC_INTERFACE_POINTER = D3D_SVC_INTERFACE_POINTER,

        /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_FORCE_DWORD"]/*' />
        D3D_SVC_FORCE_DWORD = 0x7fffffff,
    }
}

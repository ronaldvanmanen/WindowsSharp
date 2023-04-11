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

using System.Numerics;
using DirectXSharp.Interop;

namespace DirectXSharp.In.WPF
{
    internal static class Matrix4x4Extensions
    {
        public static D3DMATRIX ToD3DMATRIX(this Matrix4x4 matrix)
        {
            return new D3DMATRIX
            {
                Anonymous = new D3DMATRIX._Anonymous_e__Union
                {
                    Anonymous = new D3DMATRIX._Anonymous_e__Union._Anonymous_e__Struct
                    {
                        _11 = matrix.M11,
                        _12 = matrix.M12,
                        _13 = matrix.M13,
                        _14 = matrix.M14,
                        _21 = matrix.M21,
                        _22 = matrix.M22,
                        _23 = matrix.M23,
                        _24 = matrix.M24,
                        _31 = matrix.M31,
                        _32 = matrix.M32,
                        _33 = matrix.M33,
                        _34 = matrix.M34,
                        _41 = matrix.M41,
                        _42 = matrix.M42,
                        _43 = matrix.M43,
                        _44 = matrix.M44,
                    }
                }
            };
        }
    }
}

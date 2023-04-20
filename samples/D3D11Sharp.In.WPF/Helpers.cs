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
using WindowsSharp.Internals;
using WindowsSharp.Interop;
using static WindowsSharp.Interop.NativeMethods;

namespace D3D11Sharp.In.WPF
{
    internal static class Helpers
    {
        public static unsafe D3DBlob CompileShaderFromFile(string fileName, string entryPoint, string shaderModel)
        {
            ID3DBlob* pErrorBlob = null;

            using var szFileName = new MarshaledWideString(fileName);
            using var szEntryPoint = new MarshaledString(entryPoint);
            using var szShaderModel = new MarshaledString(shaderModel);

            ID3DBlob* pCodeBlob = null;

            var result = D3DCompileFromFile(szFileName, null, null, szEntryPoint, szShaderModel,
                0, 0, &pCodeBlob, &pErrorBlob);

            if (result != 0)
            {
                if (pErrorBlob != null)
                {
                    throw new InvalidOperationException(
                        new string((sbyte*)pErrorBlob->GetBufferPointer())
                    );
                }
            }

            if (pErrorBlob != null)
            {
                pErrorBlob->Release();
            }

            return new D3DBlob(pCodeBlob);
        }
    }
}

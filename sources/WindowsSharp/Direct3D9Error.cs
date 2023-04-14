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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using WindowsSharp.Interop;

namespace WindowsSharp
{
    [Serializable]
    public sealed class Direct3D9Error : Exception
    {
        public int ErrorCode { get; }

        public Direct3D9Error(int errorCode)
        {
            ErrorCode = errorCode;
        }

        public Direct3D9Error(int errorCode, string? message)
        : base(message)
        {
            ErrorCode = errorCode;
        }

        public Direct3D9Error(int errorCode, string? message, Exception? innerException)
        : base(message, innerException)
        {
            ErrorCode = errorCode;
        }

        private Direct3D9Error(SerializationInfo info, StreamingContext context)
        : base(info, context)
        { }

        public static unsafe void ThrowOnFailure(int returnCode)
        {
            if (!Succeeded(returnCode, out var error))
            {
                throw error;
            }
        }

        public static bool Succeeded(int returnCode, [NotNullWhen(false)] out Direct3D9Error? error)
        {
            var succeeded = returnCode == NativeMethods.D3D_OK;
            error = succeeded ? default : new Direct3D9Error(returnCode);
            return succeeded;
        }
    }
}

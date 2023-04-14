﻿// This file is part of WindowsSharp
//
// Copyright (C) 2021-2023 Ronald van Manen <rvanmanen@gmail.com>
//
// This software is provided 'as-is', without any express or implied
// warranty.  In no event will the authors be held liable for any damages
// arising from the use of this software.
// 
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it
// freely, subject to the following restrictions:
//
// 1. The origin of this software must not be misrepresented; you must not
//    claim that you wrote the original software. If you use this software
//    in a product, an acknowledgment in the product documentation would be
//    appreciated but is not required.
// 2. Altered source versions must be plainly marked as such, and must not be
//    misrepresented as being the original software.
// 3. This notice may not be removed or altered from any source distribution.

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsSharp.Internals
{
    public unsafe struct MarshaledString : IDisposable
    {
        public MarshaledString(string input)
        {
            int length;
            IntPtr value;

            if (input is null)
            {
                length = 0;
                value = IntPtr.Zero;
            }
            else
            {
                var bytes = (input.Length != 0) ? Encoding.Unicode.GetBytes(input) : Array.Empty<byte>();
                var byteLength = bytes.Length;
                value = Marshal.AllocHGlobal(byteLength + 2);
                length = byteLength / 2;
                Marshal.Copy(bytes, 0, value, byteLength);
                Marshal.WriteInt16(value, byteLength, 0);
            }

            Length = length;
            Value = (ushort*)value;
        }

        public ReadOnlySpan<ushort> AsSpan() => new(Value, Length);

        public int Length { get; private set; }

        public ushort* Value { get; private set; }

        public void Dispose()
        {
            if (Value != null)
            {
                Marshal.FreeHGlobal((IntPtr)Value);
                Value = null;
                Length = 0;
            }
        }

        public static implicit operator ushort*(in MarshaledString value) => value.Value;

        public override string ToString()
        {
            var span = new ReadOnlySpan<ushort>(Value, Length);
            return span.AsString();
        }
    }
}

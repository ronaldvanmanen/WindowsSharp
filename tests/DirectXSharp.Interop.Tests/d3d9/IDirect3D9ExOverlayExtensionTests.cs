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

using System;
using System.Runtime.InteropServices;
using Xunit;
using static DirectXSharp.Interop.NativeMethods;

namespace DirectXSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDirect3D9ExOverlayExtension" /> struct.</summary>
    public static unsafe partial class IDirect3D9ExOverlayExtensionTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDirect3D9ExOverlayExtension" /> struct is correct.</summary>
        [Fact]
        public static void GuidOfTest()
        {
            Assert.Equal(typeof(IDirect3D9ExOverlayExtension).GUID, IID_IDirect3D9ExOverlayExtension);
        }

        /// <summary>Validates that the <see cref="IDirect3D9ExOverlayExtension" /> struct is blittable.</summary>
        [Fact]
        public static void IsBlittableTest()
        {
            Assert.Equal(sizeof(IDirect3D9ExOverlayExtension), Marshal.SizeOf<IDirect3D9ExOverlayExtension>());
        }

        /// <summary>Validates that the <see cref="IDirect3D9ExOverlayExtension" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Fact]
        public static void IsLayoutSequentialTest()
        {
            Assert.True(typeof(IDirect3D9ExOverlayExtension).IsLayoutSequential);
        }

        /// <summary>Validates that the <see cref="IDirect3D9ExOverlayExtension" /> struct has the correct size.</summary>
        [Fact]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.Equal(8, sizeof(IDirect3D9ExOverlayExtension));
            }
            else
            {
                Assert.Equal(4, sizeof(IDirect3D9ExOverlayExtension));
            }
        }
    }
}

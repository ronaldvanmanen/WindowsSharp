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
    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC"]/*' />
    public unsafe partial struct D3D11_FUNCTION_DESC
    {
        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Version"]/*' />
        public uint Version;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Creator"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* Creator;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Flags"]/*' />
        public uint Flags;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.ConstantBuffers"]/*' />
        public uint ConstantBuffers;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.BoundResources"]/*' />
        public uint BoundResources;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.InstructionCount"]/*' />
        public uint InstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TempRegisterCount"]/*' />
        public uint TempRegisterCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TempArrayCount"]/*' />
        public uint TempArrayCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.DefCount"]/*' />
        public uint DefCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.DclCount"]/*' />
        public uint DclCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureNormalInstructions"]/*' />
        public uint TextureNormalInstructions;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureLoadInstructions"]/*' />
        public uint TextureLoadInstructions;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureCompInstructions"]/*' />
        public uint TextureCompInstructions;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureBiasInstructions"]/*' />
        public uint TextureBiasInstructions;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureGradientInstructions"]/*' />
        public uint TextureGradientInstructions;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.FloatInstructionCount"]/*' />
        public uint FloatInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.IntInstructionCount"]/*' />
        public uint IntInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.UintInstructionCount"]/*' />
        public uint UintInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.StaticFlowControlCount"]/*' />
        public uint StaticFlowControlCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.DynamicFlowControlCount"]/*' />
        public uint DynamicFlowControlCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.MacroInstructionCount"]/*' />
        public uint MacroInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.ArrayInstructionCount"]/*' />
        public uint ArrayInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.MovInstructionCount"]/*' />
        public uint MovInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.MovcInstructionCount"]/*' />
        public uint MovcInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.ConversionInstructionCount"]/*' />
        public uint ConversionInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.BitwiseInstructionCount"]/*' />
        public uint BitwiseInstructionCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.MinFeatureLevel"]/*' />
        public D3D_FEATURE_LEVEL MinFeatureLevel;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.RequiredFeatureFlags"]/*' />
        [NativeTypeName("UINT64")]
        public ulong RequiredFeatureFlags;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Name"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.FunctionParameterCount"]/*' />
        public int FunctionParameterCount;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.HasReturn"]/*' />
        [NativeTypeName("BOOL")]
        public int HasReturn;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Has10Level9VertexShader"]/*' />
        [NativeTypeName("BOOL")]
        public int Has10Level9VertexShader;

        /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Has10Level9PixelShader"]/*' />
        [NativeTypeName("BOOL")]
        public int Has10Level9PixelShader;
    }
}

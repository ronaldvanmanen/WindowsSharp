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
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC"]/*' />
    public unsafe partial struct D3D11_SHADER_DESC
    {
        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.Version"]/*' />
        public uint Version;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.Creator"]/*' />
        [NativeTypeName("LPCSTR")]
        public sbyte* Creator;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.Flags"]/*' />
        public uint Flags;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.ConstantBuffers"]/*' />
        public uint ConstantBuffers;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.BoundResources"]/*' />
        public uint BoundResources;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.InputParameters"]/*' />
        public uint InputParameters;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.OutputParameters"]/*' />
        public uint OutputParameters;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.InstructionCount"]/*' />
        public uint InstructionCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TempRegisterCount"]/*' />
        public uint TempRegisterCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TempArrayCount"]/*' />
        public uint TempArrayCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.DefCount"]/*' />
        public uint DefCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.DclCount"]/*' />
        public uint DclCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureNormalInstructions"]/*' />
        public uint TextureNormalInstructions;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureLoadInstructions"]/*' />
        public uint TextureLoadInstructions;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureCompInstructions"]/*' />
        public uint TextureCompInstructions;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureBiasInstructions"]/*' />
        public uint TextureBiasInstructions;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureGradientInstructions"]/*' />
        public uint TextureGradientInstructions;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.FloatInstructionCount"]/*' />
        public uint FloatInstructionCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.IntInstructionCount"]/*' />
        public uint IntInstructionCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.UintInstructionCount"]/*' />
        public uint UintInstructionCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.StaticFlowControlCount"]/*' />
        public uint StaticFlowControlCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.DynamicFlowControlCount"]/*' />
        public uint DynamicFlowControlCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.MacroInstructionCount"]/*' />
        public uint MacroInstructionCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.ArrayInstructionCount"]/*' />
        public uint ArrayInstructionCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.CutInstructionCount"]/*' />
        public uint CutInstructionCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.EmitInstructionCount"]/*' />
        public uint EmitInstructionCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.GSOutputTopology"]/*' />
        public D3D_PRIMITIVE_TOPOLOGY GSOutputTopology;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.GSMaxOutputVertexCount"]/*' />
        public uint GSMaxOutputVertexCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.InputPrimitive"]/*' />
        public D3D_PRIMITIVE InputPrimitive;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.PatchConstantParameters"]/*' />
        public uint PatchConstantParameters;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cGSInstanceCount"]/*' />
        public uint cGSInstanceCount;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cControlPoints"]/*' />
        public uint cControlPoints;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.HSOutputPrimitive"]/*' />
        public D3D_TESSELLATOR_OUTPUT_PRIMITIVE HSOutputPrimitive;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.HSPartitioning"]/*' />
        public D3D_TESSELLATOR_PARTITIONING HSPartitioning;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TessellatorDomain"]/*' />
        public D3D_TESSELLATOR_DOMAIN TessellatorDomain;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cBarrierInstructions"]/*' />
        public uint cBarrierInstructions;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cInterlockedInstructions"]/*' />
        public uint cInterlockedInstructions;

        /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cTextureStoreInstructions"]/*' />
        public uint cTextureStoreInstructions;
    }
}

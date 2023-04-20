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
using System.Runtime.InteropServices;

namespace WindowsSharp.Interop
{
    public static unsafe partial class NativeMethods
    {
        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DReadFileToBlob"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReadFileToBlob([NativeTypeName("LPCWSTR")] ushort* pFileName, ID3DBlob** ppContents);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DWriteBlobToFile"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DWriteBlobToFile(ID3DBlob* pBlob, [NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("BOOL")] int bOverwrite);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DCompile"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, uint Flags1, uint Flags2, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DCompile2"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompile2([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, uint Flags1, uint Flags2, uint SecondaryDataFlags, [NativeTypeName("LPCVOID")] void* pSecondaryData, [NativeTypeName("SIZE_T")] ulong SecondaryDataSize, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DCompileFromFile"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompileFromFile([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, uint Flags1, uint Flags2, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DPreprocess"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DPreprocess([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, ID3DBlob** ppCodeText, ID3DBlob** ppErrorMsgs);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DGetDebugInfo"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetDebugInfo([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, ID3DBlob** ppDebugInfo);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DReflect"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflect([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, [NativeTypeName("const IID &")] Guid* pInterface, void** ppReflector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DReflectLibrary"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DReflectLibrary([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppReflector);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DDisassemble"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassemble([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, ID3DBlob** ppDisassembly);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DDisassembleRegion"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassembleRegion([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, [NativeTypeName("SIZE_T")] ulong StartByteOffset, [NativeTypeName("SIZE_T")] ulong NumInsts, [NativeTypeName("SIZE_T *")] ulong* pFinishByteOffset, ID3DBlob** ppDisassembly);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DCreateLinker"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateLinker([NativeTypeName("struct ID3D11Linker **")] ID3D11Linker** ppLinker);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DLoadModule"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DLoadModule([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong cbSrcDataSize, [NativeTypeName("struct ID3D11Module **")] ID3D11Module** ppModule);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DCreateFunctionLinkingGraph"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateFunctionLinkingGraph(uint uFlags, [NativeTypeName("struct ID3D11FunctionLinkingGraph **")] ID3D11FunctionLinkingGraph** ppFunctionLinkingGraph);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DGetTraceInstructionOffsets"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetTraceInstructionOffsets([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, uint Flags, [NativeTypeName("SIZE_T")] ulong StartInstIndex, [NativeTypeName("SIZE_T")] ulong NumInsts, [NativeTypeName("SIZE_T *")] ulong* pOffsets, [NativeTypeName("SIZE_T *")] ulong* pTotalInsts);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DGetInputSignatureBlob"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, ID3DBlob** ppSignatureBlob);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DGetOutputSignatureBlob"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, ID3DBlob** ppSignatureBlob);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DGetInputAndOutputSignatureBlob"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetInputAndOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, ID3DBlob** ppSignatureBlob);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DStripShader"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DStripShader([NativeTypeName("LPCVOID")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] ulong BytecodeLength, uint uStripFlags, ID3DBlob** ppStrippedBlob);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DGetBlobPart"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DGetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, D3D_BLOB_PART Part, uint Flags, ID3DBlob** ppPart);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DSetBlobPart"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DSetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, D3D_BLOB_PART Part, uint Flags, [NativeTypeName("LPCVOID")] void* pPart, [NativeTypeName("SIZE_T")] ulong PartSize, ID3DBlob** ppNewShader);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DCreateBlob"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCreateBlob([NativeTypeName("SIZE_T")] ulong Size, ID3DBlob** ppBlob);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DCompressShaders"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DCompressShaders(uint uNumShaders, D3D_SHADER_DATA* pShaderData, uint uFlags, ID3DBlob** ppCompressedData);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DDecompressShaders"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDecompressShaders([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] ulong SrcDataSize, uint uNumShaders, uint uStartIndex, uint* pIndices, uint uFlags, ID3DBlob** ppShaders, uint* pTotalShaders);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DDisassemble10Effect"]/*' />
        [DllImport("D3DCompiler_47.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassemble10Effect([NativeTypeName("struct ID3D10Effect *")] ID3D10Effect* pEffect, uint Flags, ID3DBlob** ppDisassembly);

        [NativeTypeName("#define D3DCOMPILER_DLL_W L\"d3dcompiler_47.dll\"")]
        public const string D3DCOMPILER_DLL_W = "d3dcompiler_47.dll";

        [NativeTypeName("#define D3DCOMPILER_DLL_A \"d3dcompiler_47.dll\"")]
        public static ReadOnlySpan<byte> D3DCOMPILER_DLL_A => new byte[] { 0x64, 0x33, 0x64, 0x63, 0x6F, 0x6D, 0x70, 0x69, 0x6C, 0x65, 0x72, 0x5F, 0x34, 0x37, 0x2E, 0x64, 0x6C, 0x6C, 0x00 };

        [NativeTypeName("#define D3D_COMPILER_VERSION 47")]
        public const int D3D_COMPILER_VERSION = 47;

        [NativeTypeName("#define D3DCOMPILER_DLL D3DCOMPILER_DLL_W")]
        public const string D3DCOMPILER_DLL = "d3dcompiler_47.dll";

        [NativeTypeName("#define D3D_RETURN_PARAMETER_INDEX (-1)")]
        public const int D3D_RETURN_PARAMETER_INDEX = (-1);

        [NativeTypeName("#define D3D_SHADER_REQUIRES_DOUBLES 0x00000001")]
        public const int D3D_SHADER_REQUIRES_DOUBLES = 0x00000001;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL 0x00000002")]
        public const int D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL = 0x00000002;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE 0x00000004")]
        public const int D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE = 0x00000004;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_64_UAVS 0x00000008")]
        public const int D3D_SHADER_REQUIRES_64_UAVS = 0x00000008;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_MINIMUM_PRECISION 0x00000010")]
        public const int D3D_SHADER_REQUIRES_MINIMUM_PRECISION = 0x00000010;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS 0x00000020")]
        public const int D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS = 0x00000020;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS 0x00000040")]
        public const int D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS = 0x00000040;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING 0x00000080")]
        public const int D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING = 0x00000080;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_TILED_RESOURCES 0x00000100")]
        public const int D3D_SHADER_REQUIRES_TILED_RESOURCES = 0x00000100;

        [NativeTypeName("#define D3DCOMPILE_DEBUG (1 << 0)")]
        public const int D3DCOMPILE_DEBUG = (1 << 0);

        [NativeTypeName("#define D3DCOMPILE_SKIP_VALIDATION (1 << 1)")]
        public const int D3DCOMPILE_SKIP_VALIDATION = (1 << 1);

        [NativeTypeName("#define D3DCOMPILE_SKIP_OPTIMIZATION (1 << 2)")]
        public const int D3DCOMPILE_SKIP_OPTIMIZATION = (1 << 2);

        [NativeTypeName("#define D3DCOMPILE_PACK_MATRIX_ROW_MAJOR (1 << 3)")]
        public const int D3DCOMPILE_PACK_MATRIX_ROW_MAJOR = (1 << 3);

        [NativeTypeName("#define D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR (1 << 4)")]
        public const int D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR = (1 << 4);

        [NativeTypeName("#define D3DCOMPILE_PARTIAL_PRECISION (1 << 5)")]
        public const int D3DCOMPILE_PARTIAL_PRECISION = (1 << 5);

        [NativeTypeName("#define D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT (1 << 6)")]
        public const int D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT = (1 << 6);

        [NativeTypeName("#define D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT (1 << 7)")]
        public const int D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT = (1 << 7);

        [NativeTypeName("#define D3DCOMPILE_NO_PRESHADER (1 << 8)")]
        public const int D3DCOMPILE_NO_PRESHADER = (1 << 8);

        [NativeTypeName("#define D3DCOMPILE_AVOID_FLOW_CONTROL (1 << 9)")]
        public const int D3DCOMPILE_AVOID_FLOW_CONTROL = (1 << 9);

        [NativeTypeName("#define D3DCOMPILE_PREFER_FLOW_CONTROL (1 << 10)")]
        public const int D3DCOMPILE_PREFER_FLOW_CONTROL = (1 << 10);

        [NativeTypeName("#define D3DCOMPILE_ENABLE_STRICTNESS (1 << 11)")]
        public const int D3DCOMPILE_ENABLE_STRICTNESS = (1 << 11);

        [NativeTypeName("#define D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY (1 << 12)")]
        public const int D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY = (1 << 12);

        [NativeTypeName("#define D3DCOMPILE_IEEE_STRICTNESS (1 << 13)")]
        public const int D3DCOMPILE_IEEE_STRICTNESS = (1 << 13);

        [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL0 (1 << 14)")]
        public const int D3DCOMPILE_OPTIMIZATION_LEVEL0 = (1 << 14);

        [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL1 0")]
        public const int D3DCOMPILE_OPTIMIZATION_LEVEL1 = 0;

        [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL2 ((1 << 14) | (1 << 15))")]
        public const int D3DCOMPILE_OPTIMIZATION_LEVEL2 = ((1 << 14) | (1 << 15));

        [NativeTypeName("#define D3DCOMPILE_OPTIMIZATION_LEVEL3 (1 << 15)")]
        public const int D3DCOMPILE_OPTIMIZATION_LEVEL3 = (1 << 15);

        [NativeTypeName("#define D3DCOMPILE_RESERVED16 (1 << 16)")]
        public const int D3DCOMPILE_RESERVED16 = (1 << 16);

        [NativeTypeName("#define D3DCOMPILE_RESERVED17 (1 << 17)")]
        public const int D3DCOMPILE_RESERVED17 = (1 << 17);

        [NativeTypeName("#define D3DCOMPILE_WARNINGS_ARE_ERRORS (1 << 18)")]
        public const int D3DCOMPILE_WARNINGS_ARE_ERRORS = (1 << 18);

        [NativeTypeName("#define D3DCOMPILE_RESOURCES_MAY_ALIAS (1 << 19)")]
        public const int D3DCOMPILE_RESOURCES_MAY_ALIAS = (1 << 19);

        [NativeTypeName("#define D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES (1 << 20)")]
        public const int D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES = (1 << 20);

        [NativeTypeName("#define D3DCOMPILE_ALL_RESOURCES_BOUND (1 << 21)")]
        public const int D3DCOMPILE_ALL_RESOURCES_BOUND = (1 << 21);

        [NativeTypeName("#define D3DCOMPILE_DEBUG_NAME_FOR_SOURCE (1 << 22)")]
        public const int D3DCOMPILE_DEBUG_NAME_FOR_SOURCE = (1 << 22);

        [NativeTypeName("#define D3DCOMPILE_DEBUG_NAME_FOR_BINARY (1 << 23)")]
        public const int D3DCOMPILE_DEBUG_NAME_FOR_BINARY = (1 << 23);

        [NativeTypeName("#define D3DCOMPILE_EFFECT_CHILD_EFFECT (1 << 0)")]
        public const int D3DCOMPILE_EFFECT_CHILD_EFFECT = (1 << 0);

        [NativeTypeName("#define D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS (1 << 1)")]
        public const int D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS = (1 << 1);

        [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST 0")]
        public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST = 0;

        [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 (1 << 4)")]
        public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 = (1 << 4);

        [NativeTypeName("#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 (1 << 5)")]
        public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 = (1 << 5);

        [NativeTypeName("#define D3D_COMPILE_STANDARD_FILE_INCLUDE ((ID3DInclude*)(UINT_PTR)1)")]
        public static readonly ID3DInclude* D3D_COMPILE_STANDARD_FILE_INCLUDE = ((ID3DInclude*)((ulong)(1)));

        [NativeTypeName("#define D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS 0x00000001")]
        public const int D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS = 0x00000001;

        [NativeTypeName("#define D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS 0x00000002")]
        public const int D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS = 0x00000002;

        [NativeTypeName("#define D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH 0x00000004")]
        public const int D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH = 0x00000004;

        [NativeTypeName("#define D3D_DISASM_ENABLE_COLOR_CODE 0x00000001")]
        public const int D3D_DISASM_ENABLE_COLOR_CODE = 0x00000001;

        [NativeTypeName("#define D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS 0x00000002")]
        public const int D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS = 0x00000002;

        [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING 0x00000004")]
        public const int D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING = 0x00000004;

        [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_CYCLE 0x00000008")]
        public const int D3D_DISASM_ENABLE_INSTRUCTION_CYCLE = 0x00000008;

        [NativeTypeName("#define D3D_DISASM_DISABLE_DEBUG_INFO 0x00000010")]
        public const int D3D_DISASM_DISABLE_DEBUG_INFO = 0x00000010;

        [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_OFFSET 0x00000020")]
        public const int D3D_DISASM_ENABLE_INSTRUCTION_OFFSET = 0x00000020;

        [NativeTypeName("#define D3D_DISASM_INSTRUCTION_ONLY 0x00000040")]
        public const int D3D_DISASM_INSTRUCTION_ONLY = 0x00000040;

        [NativeTypeName("#define D3D_DISASM_PRINT_HEX_LITERALS 0x00000080")]
        public const int D3D_DISASM_PRINT_HEX_LITERALS = 0x00000080;

        [NativeTypeName("#define D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE 0x00000001")]
        public const int D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE = 0x00000001;

        [NativeTypeName("#define D3D_COMPRESS_SHADER_KEEP_ALL_PARTS 0x00000001")]
        public const int D3D_COMPRESS_SHADER_KEEP_ALL_PARTS = 0x00000001;

        public static readonly Guid IID_ID3D11ShaderReflectionType = new Guid(0x6E6FFA6A, 0x9BAE, 0x4613, 0xA5, 0x1E, 0x91, 0x65, 0x2D, 0x50, 0x8C, 0x21);

        public static readonly Guid IID_ID3D11ShaderReflectionVariable = new Guid(0x51F23923, 0xF3E5, 0x4BD1, 0x91, 0xCB, 0x60, 0x61, 0x77, 0xD8, 0xDB, 0x4C);

        public static readonly Guid IID_ID3D11ShaderReflectionConstantBuffer = new Guid(0xEB62D63D, 0x93DD, 0x4318, 0x8A, 0xE8, 0xC6, 0xF8, 0x3A, 0xD3, 0x71, 0xB8);

        public static readonly Guid IID_ID3D11ShaderReflection = new Guid(0x8D536CA1, 0x0CCA, 0x4956, 0xA8, 0x37, 0x78, 0x69, 0x63, 0x75, 0x55, 0x84);

        public static readonly Guid IID_ID3D11LibraryReflection = new Guid(0x54384F1B, 0x5B3E, 0x4BB7, 0xAE, 0x01, 0x60, 0xBA, 0x30, 0x97, 0xCB, 0xB6);

        public static readonly Guid IID_ID3D11FunctionReflection = new Guid(0x207BCECB, 0xD683, 0x4A06, 0xA8, 0xA3, 0x9B, 0x14, 0x9B, 0x9F, 0x73, 0xA4);

        public static readonly Guid IID_ID3D11FunctionParameterReflection = new Guid(0x42757488, 0x334F, 0x47FE, 0x98, 0x2E, 0x1A, 0x65, 0xD0, 0x8C, 0xC4, 0x62);

        public static readonly Guid IID_ID3D11Module = new Guid(0xCAC701EE, 0x80FC, 0x4122, 0x82, 0x42, 0x10, 0xB3, 0x9C, 0x8C, 0xEC, 0x34);

        public static readonly Guid IID_ID3D11ModuleInstance = new Guid(0x469E07F7, 0x045A, 0x48D5, 0xAA, 0x12, 0x68, 0xA4, 0x78, 0xCD, 0xF7, 0x5D);

        public static readonly Guid IID_ID3D11Linker = new Guid(0x59A6CD0E, 0xE10D, 0x4C1F, 0x88, 0xC0, 0x63, 0xAB, 0xA1, 0xDA, 0xF3, 0x0E);

        public static readonly Guid IID_ID3D11LinkingNode = new Guid(0xD80DD70C, 0x8D2F, 0x4751, 0x94, 0xA1, 0x03, 0xC7, 0x9B, 0x35, 0x56, 0xDB);

        public static readonly Guid IID_ID3D11FunctionLinkingGraph = new Guid(0x54133220, 0x1CE8, 0x43D3, 0x82, 0x36, 0x98, 0x55, 0xC5, 0xCE, 0xEC, 0xFF);
    }
}

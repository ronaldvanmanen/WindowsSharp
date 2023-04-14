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
using static WindowsSharp.Interop.D3DDECLMETHOD;
using static WindowsSharp.Interop.D3DDECLTYPE;
using static WindowsSharp.Interop.D3DDECLUSAGE;
using static WindowsSharp.Interop.D3DRESOURCETYPE;

namespace WindowsSharp.Interop
{
    public static unsafe partial class NativeMethods
    {
        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.Direct3DCreate9"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        public static extern IDirect3D9* Direct3DCreate9(uint SDKVersion);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DPERF_BeginEvent"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        public static extern int D3DPERF_BeginEvent([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] ushort* wszName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DPERF_EndEvent"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        public static extern int D3DPERF_EndEvent();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DPERF_SetMarker"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        public static extern void D3DPERF_SetMarker([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] ushort* wszName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DPERF_SetRegion"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        public static extern void D3DPERF_SetRegion([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] ushort* wszName);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DPERF_QueryRepeatFrame"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D3DPERF_QueryRepeatFrame();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DPERF_SetOptions"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        public static extern void D3DPERF_SetOptions([NativeTypeName("DWORD")] uint dwOptions);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3DPERF_GetStatus"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint D3DPERF_GetStatus();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.Direct3DCreate9Ex"]/*' />
        [DllImport("D3D9.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int Direct3DCreate9Ex(uint SDKVersion, IDirect3D9Ex** param1);

        [NativeTypeName("#define D3D_SDK_VERSION 32")]
        public const int D3D_SDK_VERSION = 32;

        [NativeTypeName("#define D3D9b_SDK_VERSION 31")]
        public const int D3D9b_SDK_VERSION = 31;

        [NativeTypeName("#define D3DMAXUSERCLIPPLANES 32")]
        public const int D3DMAXUSERCLIPPLANES = 32;

        [NativeTypeName("#define D3DCLIPPLANE0 (1 << 0)")]
        public const int D3DCLIPPLANE0 = (1 << 0);

        [NativeTypeName("#define D3DCLIPPLANE1 (1 << 1)")]
        public const int D3DCLIPPLANE1 = (1 << 1);

        [NativeTypeName("#define D3DCLIPPLANE2 (1 << 2)")]
        public const int D3DCLIPPLANE2 = (1 << 2);

        [NativeTypeName("#define D3DCLIPPLANE3 (1 << 3)")]
        public const int D3DCLIPPLANE3 = (1 << 3);

        [NativeTypeName("#define D3DCLIPPLANE4 (1 << 4)")]
        public const int D3DCLIPPLANE4 = (1 << 4);

        [NativeTypeName("#define D3DCLIPPLANE5 (1 << 5)")]
        public const int D3DCLIPPLANE5 = (1 << 5);

        [NativeTypeName("#define D3DCS_LEFT 0x00000001L")]
        public const int D3DCS_LEFT = 0x00000001;

        [NativeTypeName("#define D3DCS_RIGHT 0x00000002L")]
        public const int D3DCS_RIGHT = 0x00000002;

        [NativeTypeName("#define D3DCS_TOP 0x00000004L")]
        public const int D3DCS_TOP = 0x00000004;

        [NativeTypeName("#define D3DCS_BOTTOM 0x00000008L")]
        public const int D3DCS_BOTTOM = 0x00000008;

        [NativeTypeName("#define D3DCS_FRONT 0x00000010L")]
        public const int D3DCS_FRONT = 0x00000010;

        [NativeTypeName("#define D3DCS_BACK 0x00000020L")]
        public const int D3DCS_BACK = 0x00000020;

        [NativeTypeName("#define D3DCS_PLANE0 0x00000040L")]
        public const int D3DCS_PLANE0 = 0x00000040;

        [NativeTypeName("#define D3DCS_PLANE1 0x00000080L")]
        public const int D3DCS_PLANE1 = 0x00000080;

        [NativeTypeName("#define D3DCS_PLANE2 0x00000100L")]
        public const int D3DCS_PLANE2 = 0x00000100;

        [NativeTypeName("#define D3DCS_PLANE3 0x00000200L")]
        public const int D3DCS_PLANE3 = 0x00000200;

        [NativeTypeName("#define D3DCS_PLANE4 0x00000400L")]
        public const int D3DCS_PLANE4 = 0x00000400;

        [NativeTypeName("#define D3DCS_PLANE5 0x00000800L")]
        public const int D3DCS_PLANE5 = 0x00000800;

        [NativeTypeName("#define D3DCS_ALL (D3DCS_LEFT   | \\\r\n                   D3DCS_RIGHT  | \\\r\n                   D3DCS_TOP    | \\\r\n                   D3DCS_BOTTOM | \\\r\n                   D3DCS_FRONT  | \\\r\n                   D3DCS_BACK   | \\\r\n                   D3DCS_PLANE0 | \\\r\n                   D3DCS_PLANE1 | \\\r\n                   D3DCS_PLANE2 | \\\r\n                   D3DCS_PLANE3 | \\\r\n                   D3DCS_PLANE4 | \\\r\n                   D3DCS_PLANE5)")]
        public const int D3DCS_ALL = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800);

        [NativeTypeName("#define D3DCLEAR_TARGET 0x00000001l")]
        public const int D3DCLEAR_TARGET = 0x00000001;

        [NativeTypeName("#define D3DCLEAR_ZBUFFER 0x00000002l")]
        public const int D3DCLEAR_ZBUFFER = 0x00000002;

        [NativeTypeName("#define D3DCLEAR_STENCIL 0x00000004l")]
        public const int D3DCLEAR_STENCIL = 0x00000004;

        [NativeTypeName("#define D3DTS_WORLD D3DTS_WORLDMATRIX(0)")]
        public const D3DTRANSFORMSTATETYPE D3DTS_WORLD = (D3DTRANSFORMSTATETYPE)(0 + 256);

        [NativeTypeName("#define D3DTS_WORLD1 D3DTS_WORLDMATRIX(1)")]
        public const D3DTRANSFORMSTATETYPE D3DTS_WORLD1 = (D3DTRANSFORMSTATETYPE)(1 + 256);

        [NativeTypeName("#define D3DTS_WORLD2 D3DTS_WORLDMATRIX(2)")]
        public const D3DTRANSFORMSTATETYPE D3DTS_WORLD2 = (D3DTRANSFORMSTATETYPE)(2 + 256);

        [NativeTypeName("#define D3DTS_WORLD3 D3DTS_WORLDMATRIX(3)")]
        public const D3DTRANSFORMSTATETYPE D3DTS_WORLD3 = (D3DTRANSFORMSTATETYPE)(3 + 256);

        [NativeTypeName("#define D3D_MAX_SIMULTANEOUS_RENDERTARGETS 4")]
        public const int D3D_MAX_SIMULTANEOUS_RENDERTARGETS = 4;

        [NativeTypeName("#define D3DRENDERSTATE_WRAPBIAS 128UL")]
        public const uint D3DRENDERSTATE_WRAPBIAS = 128U;

        [NativeTypeName("#define D3DWRAP_U 0x00000001L")]
        public const int D3DWRAP_U = 0x00000001;

        [NativeTypeName("#define D3DWRAP_V 0x00000002L")]
        public const int D3DWRAP_V = 0x00000002;

        [NativeTypeName("#define D3DWRAP_W 0x00000004L")]
        public const int D3DWRAP_W = 0x00000004;

        [NativeTypeName("#define D3DWRAPCOORD_0 0x00000001L")]
        public const int D3DWRAPCOORD_0 = 0x00000001;

        [NativeTypeName("#define D3DWRAPCOORD_1 0x00000002L")]
        public const int D3DWRAPCOORD_1 = 0x00000002;

        [NativeTypeName("#define D3DWRAPCOORD_2 0x00000004L")]
        public const int D3DWRAPCOORD_2 = 0x00000004;

        [NativeTypeName("#define D3DWRAPCOORD_3 0x00000008L")]
        public const int D3DWRAPCOORD_3 = 0x00000008;

        [NativeTypeName("#define D3DCOLORWRITEENABLE_RED (1L<<0)")]
        public const int D3DCOLORWRITEENABLE_RED = (1 << 0);

        [NativeTypeName("#define D3DCOLORWRITEENABLE_GREEN (1L<<1)")]
        public const int D3DCOLORWRITEENABLE_GREEN = (1 << 1);

        [NativeTypeName("#define D3DCOLORWRITEENABLE_BLUE (1L<<2)")]
        public const int D3DCOLORWRITEENABLE_BLUE = (1 << 2);

        [NativeTypeName("#define D3DCOLORWRITEENABLE_ALPHA (1L<<3)")]
        public const int D3DCOLORWRITEENABLE_ALPHA = (1 << 3);

        [NativeTypeName("#define D3DDMAPSAMPLER 256")]
        public const int D3DDMAPSAMPLER = 256;

        [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER0 (D3DDMAPSAMPLER+1)")]
        public const int D3DVERTEXTEXTURESAMPLER0 = (256 + 1);

        [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER1 (D3DDMAPSAMPLER+2)")]
        public const int D3DVERTEXTEXTURESAMPLER1 = (256 + 2);

        [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER2 (D3DDMAPSAMPLER+3)")]
        public const int D3DVERTEXTEXTURESAMPLER2 = (256 + 3);

        [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER3 (D3DDMAPSAMPLER+4)")]
        public const int D3DVERTEXTEXTURESAMPLER3 = (256 + 4);

        [NativeTypeName("#define D3DTSS_TCI_PASSTHRU 0x00000000")]
        public const int D3DTSS_TCI_PASSTHRU = 0x00000000;

        [NativeTypeName("#define D3DTSS_TCI_CAMERASPACENORMAL 0x00010000")]
        public const int D3DTSS_TCI_CAMERASPACENORMAL = 0x00010000;

        [NativeTypeName("#define D3DTSS_TCI_CAMERASPACEPOSITION 0x00020000")]
        public const int D3DTSS_TCI_CAMERASPACEPOSITION = 0x00020000;

        [NativeTypeName("#define D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR 0x00030000")]
        public const int D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR = 0x00030000;

        [NativeTypeName("#define D3DTSS_TCI_SPHEREMAP 0x00040000")]
        public const int D3DTSS_TCI_SPHEREMAP = 0x00040000;

        [NativeTypeName("#define D3DTA_SELECTMASK 0x0000000f")]
        public const int D3DTA_SELECTMASK = 0x0000000f;

        [NativeTypeName("#define D3DTA_DIFFUSE 0x00000000")]
        public const int D3DTA_DIFFUSE = 0x00000000;

        [NativeTypeName("#define D3DTA_CURRENT 0x00000001")]
        public const int D3DTA_CURRENT = 0x00000001;

        [NativeTypeName("#define D3DTA_TEXTURE 0x00000002")]
        public const int D3DTA_TEXTURE = 0x00000002;

        [NativeTypeName("#define D3DTA_TFACTOR 0x00000003")]
        public const int D3DTA_TFACTOR = 0x00000003;

        [NativeTypeName("#define D3DTA_SPECULAR 0x00000004")]
        public const int D3DTA_SPECULAR = 0x00000004;

        [NativeTypeName("#define D3DTA_TEMP 0x00000005")]
        public const int D3DTA_TEMP = 0x00000005;

        [NativeTypeName("#define D3DTA_CONSTANT 0x00000006")]
        public const int D3DTA_CONSTANT = 0x00000006;

        [NativeTypeName("#define D3DTA_COMPLEMENT 0x00000010")]
        public const int D3DTA_COMPLEMENT = 0x00000010;

        [NativeTypeName("#define D3DTA_ALPHAREPLICATE 0x00000020")]
        public const int D3DTA_ALPHAREPLICATE = 0x00000020;

        [NativeTypeName("#define D3DPV_DONOTCOPYDATA (1 << 0)")]
        public const int D3DPV_DONOTCOPYDATA = (1 << 0);

        [NativeTypeName("#define D3DFVF_RESERVED0 0x001")]
        public const int D3DFVF_RESERVED0 = 0x001;

        [NativeTypeName("#define D3DFVF_POSITION_MASK 0x400E")]
        public const int D3DFVF_POSITION_MASK = 0x400E;

        [NativeTypeName("#define D3DFVF_XYZ 0x002")]
        public const int D3DFVF_XYZ = 0x002;

        [NativeTypeName("#define D3DFVF_XYZRHW 0x004")]
        public const int D3DFVF_XYZRHW = 0x004;

        [NativeTypeName("#define D3DFVF_XYZB1 0x006")]
        public const int D3DFVF_XYZB1 = 0x006;

        [NativeTypeName("#define D3DFVF_XYZB2 0x008")]
        public const int D3DFVF_XYZB2 = 0x008;

        [NativeTypeName("#define D3DFVF_XYZB3 0x00a")]
        public const int D3DFVF_XYZB3 = 0x00a;

        [NativeTypeName("#define D3DFVF_XYZB4 0x00c")]
        public const int D3DFVF_XYZB4 = 0x00c;

        [NativeTypeName("#define D3DFVF_XYZB5 0x00e")]
        public const int D3DFVF_XYZB5 = 0x00e;

        [NativeTypeName("#define D3DFVF_XYZW 0x4002")]
        public const int D3DFVF_XYZW = 0x4002;

        [NativeTypeName("#define D3DFVF_NORMAL 0x010")]
        public const int D3DFVF_NORMAL = 0x010;

        [NativeTypeName("#define D3DFVF_PSIZE 0x020")]
        public const int D3DFVF_PSIZE = 0x020;

        [NativeTypeName("#define D3DFVF_DIFFUSE 0x040")]
        public const int D3DFVF_DIFFUSE = 0x040;

        [NativeTypeName("#define D3DFVF_SPECULAR 0x080")]
        public const int D3DFVF_SPECULAR = 0x080;

        [NativeTypeName("#define D3DFVF_TEXCOUNT_MASK 0xf00")]
        public const int D3DFVF_TEXCOUNT_MASK = 0xf00;

        [NativeTypeName("#define D3DFVF_TEXCOUNT_SHIFT 8")]
        public const int D3DFVF_TEXCOUNT_SHIFT = 8;

        [NativeTypeName("#define D3DFVF_TEX0 0x000")]
        public const int D3DFVF_TEX0 = 0x000;

        [NativeTypeName("#define D3DFVF_TEX1 0x100")]
        public const int D3DFVF_TEX1 = 0x100;

        [NativeTypeName("#define D3DFVF_TEX2 0x200")]
        public const int D3DFVF_TEX2 = 0x200;

        [NativeTypeName("#define D3DFVF_TEX3 0x300")]
        public const int D3DFVF_TEX3 = 0x300;

        [NativeTypeName("#define D3DFVF_TEX4 0x400")]
        public const int D3DFVF_TEX4 = 0x400;

        [NativeTypeName("#define D3DFVF_TEX5 0x500")]
        public const int D3DFVF_TEX5 = 0x500;

        [NativeTypeName("#define D3DFVF_TEX6 0x600")]
        public const int D3DFVF_TEX6 = 0x600;

        [NativeTypeName("#define D3DFVF_TEX7 0x700")]
        public const int D3DFVF_TEX7 = 0x700;

        [NativeTypeName("#define D3DFVF_TEX8 0x800")]
        public const int D3DFVF_TEX8 = 0x800;

        [NativeTypeName("#define D3DFVF_LASTBETA_UBYTE4 0x1000")]
        public const int D3DFVF_LASTBETA_UBYTE4 = 0x1000;

        [NativeTypeName("#define D3DFVF_LASTBETA_D3DCOLOR 0x8000")]
        public const int D3DFVF_LASTBETA_D3DCOLOR = 0x8000;

        [NativeTypeName("#define D3DFVF_RESERVED2 0x6000")]
        public const int D3DFVF_RESERVED2 = 0x6000;

        [NativeTypeName("#define MAXD3DDECLUSAGE D3DDECLUSAGE_SAMPLE")]
        public const D3DDECLUSAGE MAXD3DDECLUSAGE = D3DDECLUSAGE_SAMPLE;

        [NativeTypeName("#define MAXD3DDECLUSAGEINDEX 15")]
        public const int MAXD3DDECLUSAGEINDEX = 15;

        [NativeTypeName("#define MAXD3DDECLLENGTH 64")]
        public const int MAXD3DDECLLENGTH = 64;

        [NativeTypeName("#define MAXD3DDECLMETHOD D3DDECLMETHOD_LOOKUPPRESAMPLED")]
        public const D3DDECLMETHOD MAXD3DDECLMETHOD = D3DDECLMETHOD_LOOKUPPRESAMPLED;

        [NativeTypeName("#define MAXD3DDECLTYPE D3DDECLTYPE_UNUSED")]
        public const D3DDECLTYPE MAXD3DDECLTYPE = D3DDECLTYPE_UNUSED;

        [NativeTypeName("#define D3DDP_MAXTEXCOORD 8")]
        public const int D3DDP_MAXTEXCOORD = 8;

        [NativeTypeName("#define D3DSTREAMSOURCE_INDEXEDDATA (1<<30)")]
        public const int D3DSTREAMSOURCE_INDEXEDDATA = (1 << 30);

        [NativeTypeName("#define D3DSTREAMSOURCE_INSTANCEDATA (2<<30)")]
        public const int D3DSTREAMSOURCE_INSTANCEDATA = (2 << 30);

        [NativeTypeName("#define D3DSI_OPCODE_MASK 0x0000FFFF")]
        public const int D3DSI_OPCODE_MASK = 0x0000FFFF;

        [NativeTypeName("#define D3DSI_INSTLENGTH_MASK 0x0F000000")]
        public const int D3DSI_INSTLENGTH_MASK = 0x0F000000;

        [NativeTypeName("#define D3DSI_INSTLENGTH_SHIFT 24")]
        public const int D3DSI_INSTLENGTH_SHIFT = 24;

        [NativeTypeName("#define D3DSINCOSCONST1 -1.5500992e-006f")]
        public const float D3DSINCOSCONST1 = -1.5500992e-006f;

        [NativeTypeName("#define D3DSINCOSCONST2 -0.020833334f")]
        public const float D3DSINCOSCONST2 = -0.020833334f;

        [NativeTypeName("#define D3DSI_COISSUE 0x40000000")]
        public const int D3DSI_COISSUE = 0x40000000;

        [NativeTypeName("#define D3DSP_OPCODESPECIFICCONTROL_MASK 0x00ff0000")]
        public const int D3DSP_OPCODESPECIFICCONTROL_MASK = 0x00ff0000;

        [NativeTypeName("#define D3DSP_OPCODESPECIFICCONTROL_SHIFT 16")]
        public const int D3DSP_OPCODESPECIFICCONTROL_SHIFT = 16;

        [NativeTypeName("#define D3DSI_TEXLD_PROJECT (0x01 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)")]
        public const int D3DSI_TEXLD_PROJECT = (0x01 << 16);

        [NativeTypeName("#define D3DSI_TEXLD_BIAS (0x02 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)")]
        public const int D3DSI_TEXLD_BIAS = (0x02 << 16);

        [NativeTypeName("#define D3DSHADER_COMPARISON_SHIFT D3DSP_OPCODESPECIFICCONTROL_SHIFT")]
        public const int D3DSHADER_COMPARISON_SHIFT = 16;

        [NativeTypeName("#define D3DSHADER_COMPARISON_MASK (0x7<<D3DSHADER_COMPARISON_SHIFT)")]
        public const int D3DSHADER_COMPARISON_MASK = (0x7 << 16);

        [NativeTypeName("#define D3DSHADER_INSTRUCTION_PREDICATED (0x1 << 28)")]
        public const int D3DSHADER_INSTRUCTION_PREDICATED = (0x1 << 28);

        [NativeTypeName("#define D3DSP_DCL_USAGE_SHIFT 0")]
        public const int D3DSP_DCL_USAGE_SHIFT = 0;

        [NativeTypeName("#define D3DSP_DCL_USAGE_MASK 0x0000000f")]
        public const int D3DSP_DCL_USAGE_MASK = 0x0000000f;

        [NativeTypeName("#define D3DSP_DCL_USAGEINDEX_SHIFT 16")]
        public const int D3DSP_DCL_USAGEINDEX_SHIFT = 16;

        [NativeTypeName("#define D3DSP_DCL_USAGEINDEX_MASK 0x000f0000")]
        public const int D3DSP_DCL_USAGEINDEX_MASK = 0x000f0000;

        [NativeTypeName("#define D3DSP_TEXTURETYPE_SHIFT 27")]
        public const int D3DSP_TEXTURETYPE_SHIFT = 27;

        [NativeTypeName("#define D3DSP_TEXTURETYPE_MASK 0x78000000")]
        public const int D3DSP_TEXTURETYPE_MASK = 0x78000000;

        [NativeTypeName("#define D3DSP_REGNUM_MASK 0x000007FF")]
        public const int D3DSP_REGNUM_MASK = 0x000007FF;

        [NativeTypeName("#define D3DSP_WRITEMASK_0 0x00010000")]
        public const int D3DSP_WRITEMASK_0 = 0x00010000;

        [NativeTypeName("#define D3DSP_WRITEMASK_1 0x00020000")]
        public const int D3DSP_WRITEMASK_1 = 0x00020000;

        [NativeTypeName("#define D3DSP_WRITEMASK_2 0x00040000")]
        public const int D3DSP_WRITEMASK_2 = 0x00040000;

        [NativeTypeName("#define D3DSP_WRITEMASK_3 0x00080000")]
        public const int D3DSP_WRITEMASK_3 = 0x00080000;

        [NativeTypeName("#define D3DSP_WRITEMASK_ALL 0x000F0000")]
        public const int D3DSP_WRITEMASK_ALL = 0x000F0000;

        [NativeTypeName("#define D3DSP_DSTMOD_SHIFT 20")]
        public const int D3DSP_DSTMOD_SHIFT = 20;

        [NativeTypeName("#define D3DSP_DSTMOD_MASK 0x00F00000")]
        public const int D3DSP_DSTMOD_MASK = 0x00F00000;

        [NativeTypeName("#define D3DSPDM_NONE (0<<D3DSP_DSTMOD_SHIFT)")]
        public const int D3DSPDM_NONE = (0 << 20);

        [NativeTypeName("#define D3DSPDM_SATURATE (1<<D3DSP_DSTMOD_SHIFT)")]
        public const int D3DSPDM_SATURATE = (1 << 20);

        [NativeTypeName("#define D3DSPDM_PARTIALPRECISION (2<<D3DSP_DSTMOD_SHIFT)")]
        public const int D3DSPDM_PARTIALPRECISION = (2 << 20);

        [NativeTypeName("#define D3DSPDM_MSAMPCENTROID (4<<D3DSP_DSTMOD_SHIFT)")]
        public const int D3DSPDM_MSAMPCENTROID = (4 << 20);

        [NativeTypeName("#define D3DSP_DSTSHIFT_SHIFT 24")]
        public const int D3DSP_DSTSHIFT_SHIFT = 24;

        [NativeTypeName("#define D3DSP_DSTSHIFT_MASK 0x0F000000")]
        public const int D3DSP_DSTSHIFT_MASK = 0x0F000000;

        [NativeTypeName("#define D3DSP_REGTYPE_SHIFT 28")]
        public const int D3DSP_REGTYPE_SHIFT = 28;

        [NativeTypeName("#define D3DSP_REGTYPE_SHIFT2 8")]
        public const int D3DSP_REGTYPE_SHIFT2 = 8;

        [NativeTypeName("#define D3DSP_REGTYPE_MASK 0x70000000")]
        public const int D3DSP_REGTYPE_MASK = 0x70000000;

        [NativeTypeName("#define D3DSP_REGTYPE_MASK2 0x00001800")]
        public const int D3DSP_REGTYPE_MASK2 = 0x00001800;

        [NativeTypeName("#define D3DVS_ADDRESSMODE_SHIFT 13")]
        public const int D3DVS_ADDRESSMODE_SHIFT = 13;

        [NativeTypeName("#define D3DVS_ADDRESSMODE_MASK (1 << D3DVS_ADDRESSMODE_SHIFT)")]
        public const int D3DVS_ADDRESSMODE_MASK = (1 << 13);

        [NativeTypeName("#define D3DSHADER_ADDRESSMODE_SHIFT 13")]
        public const int D3DSHADER_ADDRESSMODE_SHIFT = 13;

        [NativeTypeName("#define D3DSHADER_ADDRESSMODE_MASK (1 << D3DSHADER_ADDRESSMODE_SHIFT)")]
        public const int D3DSHADER_ADDRESSMODE_MASK = (1 << 13);

        [NativeTypeName("#define D3DVS_SWIZZLE_SHIFT 16")]
        public const int D3DVS_SWIZZLE_SHIFT = 16;

        [NativeTypeName("#define D3DVS_SWIZZLE_MASK 0x00FF0000")]
        public const int D3DVS_SWIZZLE_MASK = 0x00FF0000;

        [NativeTypeName("#define D3DVS_X_X (0 << D3DVS_SWIZZLE_SHIFT)")]
        public const int D3DVS_X_X = (0 << 16);

        [NativeTypeName("#define D3DVS_X_Y (1 << D3DVS_SWIZZLE_SHIFT)")]
        public const int D3DVS_X_Y = (1 << 16);

        [NativeTypeName("#define D3DVS_X_Z (2 << D3DVS_SWIZZLE_SHIFT)")]
        public const int D3DVS_X_Z = (2 << 16);

        [NativeTypeName("#define D3DVS_X_W (3 << D3DVS_SWIZZLE_SHIFT)")]
        public const int D3DVS_X_W = (3 << 16);

        [NativeTypeName("#define D3DVS_Y_X (0 << (D3DVS_SWIZZLE_SHIFT + 2))")]
        public const int D3DVS_Y_X = (0 << (16 + 2));

        [NativeTypeName("#define D3DVS_Y_Y (1 << (D3DVS_SWIZZLE_SHIFT + 2))")]
        public const int D3DVS_Y_Y = (1 << (16 + 2));

        [NativeTypeName("#define D3DVS_Y_Z (2 << (D3DVS_SWIZZLE_SHIFT + 2))")]
        public const int D3DVS_Y_Z = (2 << (16 + 2));

        [NativeTypeName("#define D3DVS_Y_W (3 << (D3DVS_SWIZZLE_SHIFT + 2))")]
        public const int D3DVS_Y_W = (3 << (16 + 2));

        [NativeTypeName("#define D3DVS_Z_X (0 << (D3DVS_SWIZZLE_SHIFT + 4))")]
        public const int D3DVS_Z_X = (0 << (16 + 4));

        [NativeTypeName("#define D3DVS_Z_Y (1 << (D3DVS_SWIZZLE_SHIFT + 4))")]
        public const int D3DVS_Z_Y = (1 << (16 + 4));

        [NativeTypeName("#define D3DVS_Z_Z (2 << (D3DVS_SWIZZLE_SHIFT + 4))")]
        public const int D3DVS_Z_Z = (2 << (16 + 4));

        [NativeTypeName("#define D3DVS_Z_W (3 << (D3DVS_SWIZZLE_SHIFT + 4))")]
        public const int D3DVS_Z_W = (3 << (16 + 4));

        [NativeTypeName("#define D3DVS_W_X (0 << (D3DVS_SWIZZLE_SHIFT + 6))")]
        public const int D3DVS_W_X = (0 << (16 + 6));

        [NativeTypeName("#define D3DVS_W_Y (1 << (D3DVS_SWIZZLE_SHIFT + 6))")]
        public const int D3DVS_W_Y = (1 << (16 + 6));

        [NativeTypeName("#define D3DVS_W_Z (2 << (D3DVS_SWIZZLE_SHIFT + 6))")]
        public const int D3DVS_W_Z = (2 << (16 + 6));

        [NativeTypeName("#define D3DVS_W_W (3 << (D3DVS_SWIZZLE_SHIFT + 6))")]
        public const int D3DVS_W_W = (3 << (16 + 6));

        [NativeTypeName("#define D3DVS_NOSWIZZLE (D3DVS_X_X | D3DVS_Y_Y | D3DVS_Z_Z | D3DVS_W_W)")]
        public const int D3DVS_NOSWIZZLE = ((0 << 16) | (1 << (16 + 2)) | (2 << (16 + 4)) | (3 << (16 + 6)));

        [NativeTypeName("#define D3DSP_SWIZZLE_SHIFT 16")]
        public const int D3DSP_SWIZZLE_SHIFT = 16;

        [NativeTypeName("#define D3DSP_SWIZZLE_MASK 0x00FF0000")]
        public const int D3DSP_SWIZZLE_MASK = 0x00FF0000;

        [NativeTypeName("#define D3DSP_NOSWIZZLE ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_NOSWIZZLE = ((0 << (16 + 0)) | (1 << (16 + 2)) | (2 << (16 + 4)) | (3 << (16 + 6)));

        [NativeTypeName("#define D3DSP_REPLICATERED ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_REPLICATERED = ((0 << (16 + 0)) | (0 << (16 + 2)) | (0 << (16 + 4)) | (0 << (16 + 6)));

        [NativeTypeName("#define D3DSP_REPLICATEGREEN ( (1 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_REPLICATEGREEN = ((1 << (16 + 0)) | (1 << (16 + 2)) | (1 << (16 + 4)) | (1 << (16 + 6)));

        [NativeTypeName("#define D3DSP_REPLICATEBLUE ( (2 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_REPLICATEBLUE = ((2 << (16 + 0)) | (2 << (16 + 2)) | (2 << (16 + 4)) | (2 << (16 + 6)));

        [NativeTypeName("#define D3DSP_REPLICATEALPHA ( (3 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_REPLICATEALPHA = ((3 << (16 + 0)) | (3 << (16 + 2)) | (3 << (16 + 4)) | (3 << (16 + 6)));

        [NativeTypeName("#define D3DSP_SRCMOD_SHIFT 24")]
        public const int D3DSP_SRCMOD_SHIFT = 24;

        [NativeTypeName("#define D3DSP_SRCMOD_MASK 0x0F000000")]
        public const int D3DSP_SRCMOD_MASK = 0x0F000000;

        [NativeTypeName("#define D3DSP_MIN_PRECISION_SHIFT 14")]
        public const int D3DSP_MIN_PRECISION_SHIFT = 14;

        [NativeTypeName("#define D3DSP_MIN_PRECISION_MASK 0x0000C000")]
        public const int D3DSP_MIN_PRECISION_MASK = 0x0000C000;

        [NativeTypeName("#define D3DSI_COMMENTSIZE_SHIFT 16")]
        public const int D3DSI_COMMENTSIZE_SHIFT = 16;

        [NativeTypeName("#define D3DSI_COMMENTSIZE_MASK 0x7FFF0000")]
        public const int D3DSI_COMMENTSIZE_MASK = 0x7FFF0000;

        [NativeTypeName("#define D3DFVF_TEXTUREFORMAT2 0")]
        public const int D3DFVF_TEXTUREFORMAT2 = 0;

        [NativeTypeName("#define D3DFVF_TEXTUREFORMAT1 3")]
        public const int D3DFVF_TEXTUREFORMAT1 = 3;

        [NativeTypeName("#define D3DFVF_TEXTUREFORMAT3 1")]
        public const int D3DFVF_TEXTUREFORMAT3 = 1;

        [NativeTypeName("#define D3DFVF_TEXTUREFORMAT4 2")]
        public const int D3DFVF_TEXTUREFORMAT4 = 2;

        [NativeTypeName("#define D3DPRESENT_RATE_DEFAULT 0x00000000")]
        public const int D3DPRESENT_RATE_DEFAULT = 0x00000000;

        [NativeTypeName("#define D3DPRESENTFLAG_LOCKABLE_BACKBUFFER 0x00000001")]
        public const int D3DPRESENTFLAG_LOCKABLE_BACKBUFFER = 0x00000001;

        [NativeTypeName("#define D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL 0x00000002")]
        public const int D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL = 0x00000002;

        [NativeTypeName("#define D3DPRESENTFLAG_DEVICECLIP 0x00000004")]
        public const int D3DPRESENTFLAG_DEVICECLIP = 0x00000004;

        [NativeTypeName("#define D3DPRESENTFLAG_VIDEO 0x00000010")]
        public const int D3DPRESENTFLAG_VIDEO = 0x00000010;

        [NativeTypeName("#define D3DPRESENTFLAG_NOAUTOROTATE 0x00000020")]
        public const int D3DPRESENTFLAG_NOAUTOROTATE = 0x00000020;

        [NativeTypeName("#define D3DPRESENTFLAG_UNPRUNEDMODE 0x00000040")]
        public const int D3DPRESENTFLAG_UNPRUNEDMODE = 0x00000040;

        [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_LIMITEDRGB 0x00000080")]
        public const int D3DPRESENTFLAG_OVERLAY_LIMITEDRGB = 0x00000080;

        [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_YCbCr_BT709 0x00000100")]
        public const int D3DPRESENTFLAG_OVERLAY_YCbCr_BT709 = 0x00000100;

        [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC 0x00000200")]
        public const int D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC = 0x00000200;

        [NativeTypeName("#define D3DPRESENTFLAG_RESTRICTED_CONTENT 0x00000400")]
        public const int D3DPRESENTFLAG_RESTRICTED_CONTENT = 0x00000400;

        [NativeTypeName("#define D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER 0x00000800")]
        public const int D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER = 0x00000800;

        [NativeTypeName("#define D3DUSAGE_RENDERTARGET (0x00000001L)")]
        public const int D3DUSAGE_RENDERTARGET = (0x00000001);

        [NativeTypeName("#define D3DUSAGE_DEPTHSTENCIL (0x00000002L)")]
        public const int D3DUSAGE_DEPTHSTENCIL = (0x00000002);

        [NativeTypeName("#define D3DUSAGE_DYNAMIC (0x00000200L)")]
        public const int D3DUSAGE_DYNAMIC = (0x00000200);

        [NativeTypeName("#define D3DUSAGE_NONSECURE (0x00800000L)")]
        public const int D3DUSAGE_NONSECURE = (0x00800000);

        [NativeTypeName("#define D3DUSAGE_AUTOGENMIPMAP (0x00000400L)")]
        public const int D3DUSAGE_AUTOGENMIPMAP = (0x00000400);

        [NativeTypeName("#define D3DUSAGE_DMAP (0x00004000L)")]
        public const int D3DUSAGE_DMAP = (0x00004000);

        [NativeTypeName("#define D3DUSAGE_QUERY_LEGACYBUMPMAP (0x00008000L)")]
        public const int D3DUSAGE_QUERY_LEGACYBUMPMAP = (0x00008000);

        [NativeTypeName("#define D3DUSAGE_QUERY_SRGBREAD (0x00010000L)")]
        public const int D3DUSAGE_QUERY_SRGBREAD = (0x00010000);

        [NativeTypeName("#define D3DUSAGE_QUERY_FILTER (0x00020000L)")]
        public const int D3DUSAGE_QUERY_FILTER = (0x00020000);

        [NativeTypeName("#define D3DUSAGE_QUERY_SRGBWRITE (0x00040000L)")]
        public const int D3DUSAGE_QUERY_SRGBWRITE = (0x00040000);

        [NativeTypeName("#define D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING (0x00080000L)")]
        public const int D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING = (0x00080000);

        [NativeTypeName("#define D3DUSAGE_QUERY_VERTEXTEXTURE (0x00100000L)")]
        public const int D3DUSAGE_QUERY_VERTEXTEXTURE = (0x00100000);

        [NativeTypeName("#define D3DUSAGE_QUERY_WRAPANDMIP (0x00200000L)")]
        public const int D3DUSAGE_QUERY_WRAPANDMIP = (0x00200000);

        [NativeTypeName("#define D3DUSAGE_WRITEONLY (0x00000008L)")]
        public const int D3DUSAGE_WRITEONLY = (0x00000008);

        [NativeTypeName("#define D3DUSAGE_SOFTWAREPROCESSING (0x00000010L)")]
        public const int D3DUSAGE_SOFTWAREPROCESSING = (0x00000010);

        [NativeTypeName("#define D3DUSAGE_DONOTCLIP (0x00000020L)")]
        public const int D3DUSAGE_DONOTCLIP = (0x00000020);

        [NativeTypeName("#define D3DUSAGE_POINTS (0x00000040L)")]
        public const int D3DUSAGE_POINTS = (0x00000040);

        [NativeTypeName("#define D3DUSAGE_RTPATCHES (0x00000080L)")]
        public const int D3DUSAGE_RTPATCHES = (0x00000080);

        [NativeTypeName("#define D3DUSAGE_NPATCHES (0x00000100L)")]
        public const int D3DUSAGE_NPATCHES = (0x00000100);

        [NativeTypeName("#define D3DUSAGE_TEXTAPI (0x10000000L)")]
        public const int D3DUSAGE_TEXTAPI = (0x10000000);

        [NativeTypeName("#define D3DUSAGE_RESTRICTED_CONTENT (0x00000800L)")]
        public const int D3DUSAGE_RESTRICTED_CONTENT = (0x00000800);

        [NativeTypeName("#define D3DUSAGE_RESTRICT_SHARED_RESOURCE (0x00002000L)")]
        public const int D3DUSAGE_RESTRICT_SHARED_RESOURCE = (0x00002000);

        [NativeTypeName("#define D3DUSAGE_RESTRICT_SHARED_RESOURCE_DRIVER (0x00001000L)")]
        public const int D3DUSAGE_RESTRICT_SHARED_RESOURCE_DRIVER = (0x00001000);

        [NativeTypeName("#define D3DLOCK_READONLY 0x00000010L")]
        public const int D3DLOCK_READONLY = 0x00000010;

        [NativeTypeName("#define D3DLOCK_DISCARD 0x00002000L")]
        public const int D3DLOCK_DISCARD = 0x00002000;

        [NativeTypeName("#define D3DLOCK_NOOVERWRITE 0x00001000L")]
        public const int D3DLOCK_NOOVERWRITE = 0x00001000;

        [NativeTypeName("#define D3DLOCK_NOSYSLOCK 0x00000800L")]
        public const int D3DLOCK_NOSYSLOCK = 0x00000800;

        [NativeTypeName("#define D3DLOCK_DONOTWAIT 0x00004000L")]
        public const int D3DLOCK_DONOTWAIT = 0x00004000;

        [NativeTypeName("#define D3DLOCK_NO_DIRTY_UPDATE 0x00008000L")]
        public const int D3DLOCK_NO_DIRTY_UPDATE = 0x00008000;

        [NativeTypeName("#define MAX_DEVICE_IDENTIFIER_STRING 512")]
        public const int MAX_DEVICE_IDENTIFIER_STRING = 512;

        [NativeTypeName("#define D3DISSUE_END (1 << 0)")]
        public const int D3DISSUE_END = (1 << 0);

        [NativeTypeName("#define D3DISSUE_BEGIN (1 << 1)")]
        public const int D3DISSUE_BEGIN = (1 << 1);

        [NativeTypeName("#define D3DGETDATA_FLUSH (1 << 0)")]
        public const int D3DGETDATA_FLUSH = (1 << 0);

        [NativeTypeName("#define D3DRTYPECOUNT (D3DRTYPE_INDEXBUFFER+1)")]
        public const int D3DRTYPECOUNT = ((int)(D3DRTYPE_INDEXBUFFER) + 1);

        [NativeTypeName("#define D3DCOMPOSERECTS_MAXNUMRECTS 0xFFFF")]
        public const int D3DCOMPOSERECTS_MAXNUMRECTS = 0xFFFF;

        [NativeTypeName("#define D3DCONVOLUTIONMONO_MAXWIDTH 7")]
        public const int D3DCONVOLUTIONMONO_MAXWIDTH = 7;

        [NativeTypeName("#define D3DCONVOLUTIONMONO_MAXHEIGHT D3DCONVOLUTIONMONO_MAXWIDTH")]
        public const int D3DCONVOLUTIONMONO_MAXHEIGHT = 7;

        [NativeTypeName("#define D3DFMT_A1_SURFACE_MAXWIDTH 8192")]
        public const int D3DFMT_A1_SURFACE_MAXWIDTH = 8192;

        [NativeTypeName("#define D3DFMT_A1_SURFACE_MAXHEIGHT 2048")]
        public const int D3DFMT_A1_SURFACE_MAXHEIGHT = 2048;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_MINIMUM 0x28000000")]
        public const int D3D9_RESOURCE_PRIORITY_MINIMUM = 0x28000000;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_LOW 0x50000000")]
        public const int D3D9_RESOURCE_PRIORITY_LOW = 0x50000000;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_NORMAL 0x78000000")]
        public const int D3D9_RESOURCE_PRIORITY_NORMAL = 0x78000000;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_HIGH 0xa0000000")]
        public const uint D3D9_RESOURCE_PRIORITY_HIGH = 0xa0000000;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_MAXIMUM 0xc8000000")]
        public const uint D3D9_RESOURCE_PRIORITY_MAXIMUM = 0xc8000000;

        [NativeTypeName("#define D3D_OMAC_SIZE 16")]
        public const int D3D_OMAC_SIZE = 16;

        [NativeTypeName("#define D3DVS20CAPS_PREDICATION (1<<0)")]
        public const int D3DVS20CAPS_PREDICATION = (1 << 0);

        [NativeTypeName("#define D3DVS20_MAX_DYNAMICFLOWCONTROLDEPTH 24")]
        public const int D3DVS20_MAX_DYNAMICFLOWCONTROLDEPTH = 24;

        [NativeTypeName("#define D3DVS20_MIN_DYNAMICFLOWCONTROLDEPTH 0")]
        public const int D3DVS20_MIN_DYNAMICFLOWCONTROLDEPTH = 0;

        [NativeTypeName("#define D3DVS20_MAX_NUMTEMPS 32")]
        public const int D3DVS20_MAX_NUMTEMPS = 32;

        [NativeTypeName("#define D3DVS20_MIN_NUMTEMPS 12")]
        public const int D3DVS20_MIN_NUMTEMPS = 12;

        [NativeTypeName("#define D3DVS20_MAX_STATICFLOWCONTROLDEPTH 4")]
        public const int D3DVS20_MAX_STATICFLOWCONTROLDEPTH = 4;

        [NativeTypeName("#define D3DVS20_MIN_STATICFLOWCONTROLDEPTH 1")]
        public const int D3DVS20_MIN_STATICFLOWCONTROLDEPTH = 1;

        [NativeTypeName("#define D3DPS20CAPS_ARBITRARYSWIZZLE (1<<0)")]
        public const int D3DPS20CAPS_ARBITRARYSWIZZLE = (1 << 0);

        [NativeTypeName("#define D3DPS20CAPS_GRADIENTINSTRUCTIONS (1<<1)")]
        public const int D3DPS20CAPS_GRADIENTINSTRUCTIONS = (1 << 1);

        [NativeTypeName("#define D3DPS20CAPS_PREDICATION (1<<2)")]
        public const int D3DPS20CAPS_PREDICATION = (1 << 2);

        [NativeTypeName("#define D3DPS20CAPS_NODEPENDENTREADLIMIT (1<<3)")]
        public const int D3DPS20CAPS_NODEPENDENTREADLIMIT = (1 << 3);

        [NativeTypeName("#define D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT (1<<4)")]
        public const int D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT = (1 << 4);

        [NativeTypeName("#define D3DPS20_MAX_DYNAMICFLOWCONTROLDEPTH 24")]
        public const int D3DPS20_MAX_DYNAMICFLOWCONTROLDEPTH = 24;

        [NativeTypeName("#define D3DPS20_MIN_DYNAMICFLOWCONTROLDEPTH 0")]
        public const int D3DPS20_MIN_DYNAMICFLOWCONTROLDEPTH = 0;

        [NativeTypeName("#define D3DPS20_MAX_NUMTEMPS 32")]
        public const int D3DPS20_MAX_NUMTEMPS = 32;

        [NativeTypeName("#define D3DPS20_MIN_NUMTEMPS 12")]
        public const int D3DPS20_MIN_NUMTEMPS = 12;

        [NativeTypeName("#define D3DPS20_MAX_STATICFLOWCONTROLDEPTH 4")]
        public const int D3DPS20_MAX_STATICFLOWCONTROLDEPTH = 4;

        [NativeTypeName("#define D3DPS20_MIN_STATICFLOWCONTROLDEPTH 0")]
        public const int D3DPS20_MIN_STATICFLOWCONTROLDEPTH = 0;

        [NativeTypeName("#define D3DPS20_MAX_NUMINSTRUCTIONSLOTS 512")]
        public const int D3DPS20_MAX_NUMINSTRUCTIONSLOTS = 512;

        [NativeTypeName("#define D3DPS20_MIN_NUMINSTRUCTIONSLOTS 96")]
        public const int D3DPS20_MIN_NUMINSTRUCTIONSLOTS = 96;

        [NativeTypeName("#define D3DMIN30SHADERINSTRUCTIONS 512")]
        public const int D3DMIN30SHADERINSTRUCTIONS = 512;

        [NativeTypeName("#define D3DMAX30SHADERINSTRUCTIONS 32768")]
        public const int D3DMAX30SHADERINSTRUCTIONS = 32768;

        [NativeTypeName("#define D3DOVERLAYCAPS_FULLRANGERGB 0x00000001")]
        public const int D3DOVERLAYCAPS_FULLRANGERGB = 0x00000001;

        [NativeTypeName("#define D3DOVERLAYCAPS_LIMITEDRANGERGB 0x00000002")]
        public const int D3DOVERLAYCAPS_LIMITEDRANGERGB = 0x00000002;

        [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT601 0x00000004")]
        public const int D3DOVERLAYCAPS_YCbCr_BT601 = 0x00000004;

        [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT709 0x00000008")]
        public const int D3DOVERLAYCAPS_YCbCr_BT709 = 0x00000008;

        [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT601_xvYCC 0x00000010")]
        public const int D3DOVERLAYCAPS_YCbCr_BT601_xvYCC = 0x00000010;

        [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT709_xvYCC 0x00000020")]
        public const int D3DOVERLAYCAPS_YCbCr_BT709_xvYCC = 0x00000020;

        [NativeTypeName("#define D3DOVERLAYCAPS_STRETCHX 0x00000040")]
        public const int D3DOVERLAYCAPS_STRETCHX = 0x00000040;

        [NativeTypeName("#define D3DOVERLAYCAPS_STRETCHY 0x00000080")]
        public const int D3DOVERLAYCAPS_STRETCHY = 0x00000080;

        [NativeTypeName("#define D3DCPCAPS_SOFTWARE 0x00000001")]
        public const int D3DCPCAPS_SOFTWARE = 0x00000001;

        [NativeTypeName("#define D3DCPCAPS_HARDWARE 0x00000002")]
        public const int D3DCPCAPS_HARDWARE = 0x00000002;

        [NativeTypeName("#define D3DCPCAPS_PROTECTIONALWAYSON 0x00000004")]
        public const int D3DCPCAPS_PROTECTIONALWAYSON = 0x00000004;

        [NativeTypeName("#define D3DCPCAPS_PARTIALDECRYPTION 0x00000008")]
        public const int D3DCPCAPS_PARTIALDECRYPTION = 0x00000008;

        [NativeTypeName("#define D3DCPCAPS_CONTENTKEY 0x00000010")]
        public const int D3DCPCAPS_CONTENTKEY = 0x00000010;

        [NativeTypeName("#define D3DCPCAPS_FRESHENSESSIONKEY 0x00000020")]
        public const int D3DCPCAPS_FRESHENSESSIONKEY = 0x00000020;

        [NativeTypeName("#define D3DCPCAPS_ENCRYPTEDREADBACK 0x00000040")]
        public const int D3DCPCAPS_ENCRYPTEDREADBACK = 0x00000040;

        [NativeTypeName("#define D3DCPCAPS_ENCRYPTEDREADBACKKEY 0x00000080")]
        public const int D3DCPCAPS_ENCRYPTEDREADBACKKEY = 0x00000080;

        [NativeTypeName("#define D3DCPCAPS_SEQUENTIAL_CTR_IV 0x00000100")]
        public const int D3DCPCAPS_SEQUENTIAL_CTR_IV = 0x00000100;

        [NativeTypeName("#define D3DCPCAPS_ENCRYPTSLICEDATAONLY 0x00000200")]
        public const int D3DCPCAPS_ENCRYPTSLICEDATAONLY = 0x00000200;

        [NativeTypeName("#define D3DCAPS_OVERLAY 0x00000800L")]
        public const int D3DCAPS_OVERLAY = 0x00000800;

        [NativeTypeName("#define D3DCAPS_READ_SCANLINE 0x00020000L")]
        public const int D3DCAPS_READ_SCANLINE = 0x00020000;

        [NativeTypeName("#define D3DCAPS2_FULLSCREENGAMMA 0x00020000L")]
        public const int D3DCAPS2_FULLSCREENGAMMA = 0x00020000;

        [NativeTypeName("#define D3DCAPS2_CANCALIBRATEGAMMA 0x00100000L")]
        public const int D3DCAPS2_CANCALIBRATEGAMMA = 0x00100000;

        [NativeTypeName("#define D3DCAPS2_RESERVED 0x02000000L")]
        public const int D3DCAPS2_RESERVED = 0x02000000;

        [NativeTypeName("#define D3DCAPS2_CANMANAGERESOURCE 0x10000000L")]
        public const int D3DCAPS2_CANMANAGERESOURCE = 0x10000000;

        [NativeTypeName("#define D3DCAPS2_DYNAMICTEXTURES 0x20000000L")]
        public const int D3DCAPS2_DYNAMICTEXTURES = 0x20000000;

        [NativeTypeName("#define D3DCAPS2_CANAUTOGENMIPMAP 0x40000000L")]
        public const int D3DCAPS2_CANAUTOGENMIPMAP = 0x40000000;

        [NativeTypeName("#define D3DCAPS2_CANSHARERESOURCE 0x80000000L")]
        public const uint D3DCAPS2_CANSHARERESOURCE = 0x80000000;

        [NativeTypeName("#define D3DCAPS3_RESERVED 0x8000001fL")]
        public const uint D3DCAPS3_RESERVED = 0x8000001f;

        [NativeTypeName("#define D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD 0x00000020L")]
        public const int D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD = 0x00000020;

        [NativeTypeName("#define D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION 0x00000080L")]
        public const int D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION = 0x00000080;

        [NativeTypeName("#define D3DCAPS3_COPY_TO_VIDMEM 0x00000100L")]
        public const int D3DCAPS3_COPY_TO_VIDMEM = 0x00000100;

        [NativeTypeName("#define D3DCAPS3_COPY_TO_SYSTEMMEM 0x00000200L")]
        public const int D3DCAPS3_COPY_TO_SYSTEMMEM = 0x00000200;

        [NativeTypeName("#define D3DCAPS3_DXVAHD 0x00000400L")]
        public const int D3DCAPS3_DXVAHD = 0x00000400;

        [NativeTypeName("#define D3DCAPS3_DXVAHD_LIMITED 0x00000800L")]
        public const int D3DCAPS3_DXVAHD_LIMITED = 0x00000800;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_DEFAULT 0x00000000L")]
        public const int D3DPRESENT_INTERVAL_DEFAULT = 0x00000000;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_ONE 0x00000001L")]
        public const int D3DPRESENT_INTERVAL_ONE = 0x00000001;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_TWO 0x00000002L")]
        public const int D3DPRESENT_INTERVAL_TWO = 0x00000002;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_THREE 0x00000004L")]
        public const int D3DPRESENT_INTERVAL_THREE = 0x00000004;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_FOUR 0x00000008L")]
        public const int D3DPRESENT_INTERVAL_FOUR = 0x00000008;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_IMMEDIATE 0x80000000L")]
        public const uint D3DPRESENT_INTERVAL_IMMEDIATE = 0x80000000;

        [NativeTypeName("#define D3DCURSORCAPS_COLOR 0x00000001L")]
        public const int D3DCURSORCAPS_COLOR = 0x00000001;

        [NativeTypeName("#define D3DCURSORCAPS_LOWRES 0x00000002L")]
        public const int D3DCURSORCAPS_LOWRES = 0x00000002;

        [NativeTypeName("#define D3DDEVCAPS_EXECUTESYSTEMMEMORY 0x00000010L")]
        public const int D3DDEVCAPS_EXECUTESYSTEMMEMORY = 0x00000010;

        [NativeTypeName("#define D3DDEVCAPS_EXECUTEVIDEOMEMORY 0x00000020L")]
        public const int D3DDEVCAPS_EXECUTEVIDEOMEMORY = 0x00000020;

        [NativeTypeName("#define D3DDEVCAPS_TLVERTEXSYSTEMMEMORY 0x00000040L")]
        public const int D3DDEVCAPS_TLVERTEXSYSTEMMEMORY = 0x00000040;

        [NativeTypeName("#define D3DDEVCAPS_TLVERTEXVIDEOMEMORY 0x00000080L")]
        public const int D3DDEVCAPS_TLVERTEXVIDEOMEMORY = 0x00000080;

        [NativeTypeName("#define D3DDEVCAPS_TEXTURESYSTEMMEMORY 0x00000100L")]
        public const int D3DDEVCAPS_TEXTURESYSTEMMEMORY = 0x00000100;

        [NativeTypeName("#define D3DDEVCAPS_TEXTUREVIDEOMEMORY 0x00000200L")]
        public const int D3DDEVCAPS_TEXTUREVIDEOMEMORY = 0x00000200;

        [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMTLVERTEX 0x00000400L")]
        public const int D3DDEVCAPS_DRAWPRIMTLVERTEX = 0x00000400;

        [NativeTypeName("#define D3DDEVCAPS_CANRENDERAFTERFLIP 0x00000800L")]
        public const int D3DDEVCAPS_CANRENDERAFTERFLIP = 0x00000800;

        [NativeTypeName("#define D3DDEVCAPS_TEXTURENONLOCALVIDMEM 0x00001000L")]
        public const int D3DDEVCAPS_TEXTURENONLOCALVIDMEM = 0x00001000;

        [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMITIVES2 0x00002000L")]
        public const int D3DDEVCAPS_DRAWPRIMITIVES2 = 0x00002000;

        [NativeTypeName("#define D3DDEVCAPS_SEPARATETEXTUREMEMORIES 0x00004000L")]
        public const int D3DDEVCAPS_SEPARATETEXTUREMEMORIES = 0x00004000;

        [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMITIVES2EX 0x00008000L")]
        public const int D3DDEVCAPS_DRAWPRIMITIVES2EX = 0x00008000;

        [NativeTypeName("#define D3DDEVCAPS_HWTRANSFORMANDLIGHT 0x00010000L")]
        public const int D3DDEVCAPS_HWTRANSFORMANDLIGHT = 0x00010000;

        [NativeTypeName("#define D3DDEVCAPS_CANBLTSYSTONONLOCAL 0x00020000L")]
        public const int D3DDEVCAPS_CANBLTSYSTONONLOCAL = 0x00020000;

        [NativeTypeName("#define D3DDEVCAPS_HWRASTERIZATION 0x00080000L")]
        public const int D3DDEVCAPS_HWRASTERIZATION = 0x00080000;

        [NativeTypeName("#define D3DDEVCAPS_PUREDEVICE 0x00100000L")]
        public const int D3DDEVCAPS_PUREDEVICE = 0x00100000;

        [NativeTypeName("#define D3DDEVCAPS_QUINTICRTPATCHES 0x00200000L")]
        public const int D3DDEVCAPS_QUINTICRTPATCHES = 0x00200000;

        [NativeTypeName("#define D3DDEVCAPS_RTPATCHES 0x00400000L")]
        public const int D3DDEVCAPS_RTPATCHES = 0x00400000;

        [NativeTypeName("#define D3DDEVCAPS_RTPATCHHANDLEZERO 0x00800000L")]
        public const int D3DDEVCAPS_RTPATCHHANDLEZERO = 0x00800000;

        [NativeTypeName("#define D3DDEVCAPS_NPATCHES 0x01000000L")]
        public const int D3DDEVCAPS_NPATCHES = 0x01000000;

        [NativeTypeName("#define D3DPMISCCAPS_MASKZ 0x00000002L")]
        public const int D3DPMISCCAPS_MASKZ = 0x00000002;

        [NativeTypeName("#define D3DPMISCCAPS_CULLNONE 0x00000010L")]
        public const int D3DPMISCCAPS_CULLNONE = 0x00000010;

        [NativeTypeName("#define D3DPMISCCAPS_CULLCW 0x00000020L")]
        public const int D3DPMISCCAPS_CULLCW = 0x00000020;

        [NativeTypeName("#define D3DPMISCCAPS_CULLCCW 0x00000040L")]
        public const int D3DPMISCCAPS_CULLCCW = 0x00000040;

        [NativeTypeName("#define D3DPMISCCAPS_COLORWRITEENABLE 0x00000080L")]
        public const int D3DPMISCCAPS_COLORWRITEENABLE = 0x00000080;

        [NativeTypeName("#define D3DPMISCCAPS_CLIPPLANESCALEDPOINTS 0x00000100L")]
        public const int D3DPMISCCAPS_CLIPPLANESCALEDPOINTS = 0x00000100;

        [NativeTypeName("#define D3DPMISCCAPS_CLIPTLVERTS 0x00000200L")]
        public const int D3DPMISCCAPS_CLIPTLVERTS = 0x00000200;

        [NativeTypeName("#define D3DPMISCCAPS_TSSARGTEMP 0x00000400L")]
        public const int D3DPMISCCAPS_TSSARGTEMP = 0x00000400;

        [NativeTypeName("#define D3DPMISCCAPS_BLENDOP 0x00000800L")]
        public const int D3DPMISCCAPS_BLENDOP = 0x00000800;

        [NativeTypeName("#define D3DPMISCCAPS_NULLREFERENCE 0x00001000L")]
        public const int D3DPMISCCAPS_NULLREFERENCE = 0x00001000;

        [NativeTypeName("#define D3DPMISCCAPS_INDEPENDENTWRITEMASKS 0x00004000L")]
        public const int D3DPMISCCAPS_INDEPENDENTWRITEMASKS = 0x00004000;

        [NativeTypeName("#define D3DPMISCCAPS_PERSTAGECONSTANT 0x00008000L")]
        public const int D3DPMISCCAPS_PERSTAGECONSTANT = 0x00008000;

        [NativeTypeName("#define D3DPMISCCAPS_FOGANDSPECULARALPHA 0x00010000L")]
        public const int D3DPMISCCAPS_FOGANDSPECULARALPHA = 0x00010000;

        [NativeTypeName("#define D3DPMISCCAPS_SEPARATEALPHABLEND 0x00020000L")]
        public const int D3DPMISCCAPS_SEPARATEALPHABLEND = 0x00020000;

        [NativeTypeName("#define D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS 0x00040000L")]
        public const int D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS = 0x00040000;

        [NativeTypeName("#define D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING 0x00080000L")]
        public const int D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING = 0x00080000;

        [NativeTypeName("#define D3DPMISCCAPS_FOGVERTEXCLAMPED 0x00100000L")]
        public const int D3DPMISCCAPS_FOGVERTEXCLAMPED = 0x00100000;

        [NativeTypeName("#define D3DPMISCCAPS_POSTBLENDSRGBCONVERT 0x00200000L")]
        public const int D3DPMISCCAPS_POSTBLENDSRGBCONVERT = 0x00200000;

        [NativeTypeName("#define D3DLINECAPS_TEXTURE 0x00000001L")]
        public const int D3DLINECAPS_TEXTURE = 0x00000001;

        [NativeTypeName("#define D3DLINECAPS_ZTEST 0x00000002L")]
        public const int D3DLINECAPS_ZTEST = 0x00000002;

        [NativeTypeName("#define D3DLINECAPS_BLEND 0x00000004L")]
        public const int D3DLINECAPS_BLEND = 0x00000004;

        [NativeTypeName("#define D3DLINECAPS_ALPHACMP 0x00000008L")]
        public const int D3DLINECAPS_ALPHACMP = 0x00000008;

        [NativeTypeName("#define D3DLINECAPS_FOG 0x00000010L")]
        public const int D3DLINECAPS_FOG = 0x00000010;

        [NativeTypeName("#define D3DLINECAPS_ANTIALIAS 0x00000020L")]
        public const int D3DLINECAPS_ANTIALIAS = 0x00000020;

        [NativeTypeName("#define D3DPRASTERCAPS_DITHER 0x00000001L")]
        public const int D3DPRASTERCAPS_DITHER = 0x00000001;

        [NativeTypeName("#define D3DPRASTERCAPS_ZTEST 0x00000010L")]
        public const int D3DPRASTERCAPS_ZTEST = 0x00000010;

        [NativeTypeName("#define D3DPRASTERCAPS_FOGVERTEX 0x00000080L")]
        public const int D3DPRASTERCAPS_FOGVERTEX = 0x00000080;

        [NativeTypeName("#define D3DPRASTERCAPS_FOGTABLE 0x00000100L")]
        public const int D3DPRASTERCAPS_FOGTABLE = 0x00000100;

        [NativeTypeName("#define D3DPRASTERCAPS_MIPMAPLODBIAS 0x00002000L")]
        public const int D3DPRASTERCAPS_MIPMAPLODBIAS = 0x00002000;

        [NativeTypeName("#define D3DPRASTERCAPS_ZBUFFERLESSHSR 0x00008000L")]
        public const int D3DPRASTERCAPS_ZBUFFERLESSHSR = 0x00008000;

        [NativeTypeName("#define D3DPRASTERCAPS_FOGRANGE 0x00010000L")]
        public const int D3DPRASTERCAPS_FOGRANGE = 0x00010000;

        [NativeTypeName("#define D3DPRASTERCAPS_ANISOTROPY 0x00020000L")]
        public const int D3DPRASTERCAPS_ANISOTROPY = 0x00020000;

        [NativeTypeName("#define D3DPRASTERCAPS_WBUFFER 0x00040000L")]
        public const int D3DPRASTERCAPS_WBUFFER = 0x00040000;

        [NativeTypeName("#define D3DPRASTERCAPS_WFOG 0x00100000L")]
        public const int D3DPRASTERCAPS_WFOG = 0x00100000;

        [NativeTypeName("#define D3DPRASTERCAPS_ZFOG 0x00200000L")]
        public const int D3DPRASTERCAPS_ZFOG = 0x00200000;

        [NativeTypeName("#define D3DPRASTERCAPS_COLORPERSPECTIVE 0x00400000L")]
        public const int D3DPRASTERCAPS_COLORPERSPECTIVE = 0x00400000;

        [NativeTypeName("#define D3DPRASTERCAPS_SCISSORTEST 0x01000000L")]
        public const int D3DPRASTERCAPS_SCISSORTEST = 0x01000000;

        [NativeTypeName("#define D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS 0x02000000L")]
        public const int D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS = 0x02000000;

        [NativeTypeName("#define D3DPRASTERCAPS_DEPTHBIAS 0x04000000L")]
        public const int D3DPRASTERCAPS_DEPTHBIAS = 0x04000000;

        [NativeTypeName("#define D3DPRASTERCAPS_MULTISAMPLE_TOGGLE 0x08000000L")]
        public const int D3DPRASTERCAPS_MULTISAMPLE_TOGGLE = 0x08000000;

        [NativeTypeName("#define D3DPCMPCAPS_NEVER 0x00000001L")]
        public const int D3DPCMPCAPS_NEVER = 0x00000001;

        [NativeTypeName("#define D3DPCMPCAPS_LESS 0x00000002L")]
        public const int D3DPCMPCAPS_LESS = 0x00000002;

        [NativeTypeName("#define D3DPCMPCAPS_EQUAL 0x00000004L")]
        public const int D3DPCMPCAPS_EQUAL = 0x00000004;

        [NativeTypeName("#define D3DPCMPCAPS_LESSEQUAL 0x00000008L")]
        public const int D3DPCMPCAPS_LESSEQUAL = 0x00000008;

        [NativeTypeName("#define D3DPCMPCAPS_GREATER 0x00000010L")]
        public const int D3DPCMPCAPS_GREATER = 0x00000010;

        [NativeTypeName("#define D3DPCMPCAPS_NOTEQUAL 0x00000020L")]
        public const int D3DPCMPCAPS_NOTEQUAL = 0x00000020;

        [NativeTypeName("#define D3DPCMPCAPS_GREATEREQUAL 0x00000040L")]
        public const int D3DPCMPCAPS_GREATEREQUAL = 0x00000040;

        [NativeTypeName("#define D3DPCMPCAPS_ALWAYS 0x00000080L")]
        public const int D3DPCMPCAPS_ALWAYS = 0x00000080;

        [NativeTypeName("#define D3DPBLENDCAPS_ZERO 0x00000001L")]
        public const int D3DPBLENDCAPS_ZERO = 0x00000001;

        [NativeTypeName("#define D3DPBLENDCAPS_ONE 0x00000002L")]
        public const int D3DPBLENDCAPS_ONE = 0x00000002;

        [NativeTypeName("#define D3DPBLENDCAPS_SRCCOLOR 0x00000004L")]
        public const int D3DPBLENDCAPS_SRCCOLOR = 0x00000004;

        [NativeTypeName("#define D3DPBLENDCAPS_INVSRCCOLOR 0x00000008L")]
        public const int D3DPBLENDCAPS_INVSRCCOLOR = 0x00000008;

        [NativeTypeName("#define D3DPBLENDCAPS_SRCALPHA 0x00000010L")]
        public const int D3DPBLENDCAPS_SRCALPHA = 0x00000010;

        [NativeTypeName("#define D3DPBLENDCAPS_INVSRCALPHA 0x00000020L")]
        public const int D3DPBLENDCAPS_INVSRCALPHA = 0x00000020;

        [NativeTypeName("#define D3DPBLENDCAPS_DESTALPHA 0x00000040L")]
        public const int D3DPBLENDCAPS_DESTALPHA = 0x00000040;

        [NativeTypeName("#define D3DPBLENDCAPS_INVDESTALPHA 0x00000080L")]
        public const int D3DPBLENDCAPS_INVDESTALPHA = 0x00000080;

        [NativeTypeName("#define D3DPBLENDCAPS_DESTCOLOR 0x00000100L")]
        public const int D3DPBLENDCAPS_DESTCOLOR = 0x00000100;

        [NativeTypeName("#define D3DPBLENDCAPS_INVDESTCOLOR 0x00000200L")]
        public const int D3DPBLENDCAPS_INVDESTCOLOR = 0x00000200;

        [NativeTypeName("#define D3DPBLENDCAPS_SRCALPHASAT 0x00000400L")]
        public const int D3DPBLENDCAPS_SRCALPHASAT = 0x00000400;

        [NativeTypeName("#define D3DPBLENDCAPS_BOTHSRCALPHA 0x00000800L")]
        public const int D3DPBLENDCAPS_BOTHSRCALPHA = 0x00000800;

        [NativeTypeName("#define D3DPBLENDCAPS_BOTHINVSRCALPHA 0x00001000L")]
        public const int D3DPBLENDCAPS_BOTHINVSRCALPHA = 0x00001000;

        [NativeTypeName("#define D3DPBLENDCAPS_BLENDFACTOR 0x00002000L")]
        public const int D3DPBLENDCAPS_BLENDFACTOR = 0x00002000;

        [NativeTypeName("#define D3DPBLENDCAPS_SRCCOLOR2 0x00004000L")]
        public const int D3DPBLENDCAPS_SRCCOLOR2 = 0x00004000;

        [NativeTypeName("#define D3DPBLENDCAPS_INVSRCCOLOR2 0x00008000L")]
        public const int D3DPBLENDCAPS_INVSRCCOLOR2 = 0x00008000;

        [NativeTypeName("#define D3DPSHADECAPS_COLORGOURAUDRGB 0x00000008L")]
        public const int D3DPSHADECAPS_COLORGOURAUDRGB = 0x00000008;

        [NativeTypeName("#define D3DPSHADECAPS_SPECULARGOURAUDRGB 0x00000200L")]
        public const int D3DPSHADECAPS_SPECULARGOURAUDRGB = 0x00000200;

        [NativeTypeName("#define D3DPSHADECAPS_ALPHAGOURAUDBLEND 0x00004000L")]
        public const int D3DPSHADECAPS_ALPHAGOURAUDBLEND = 0x00004000;

        [NativeTypeName("#define D3DPSHADECAPS_FOGGOURAUD 0x00080000L")]
        public const int D3DPSHADECAPS_FOGGOURAUD = 0x00080000;

        [NativeTypeName("#define D3DPTEXTURECAPS_PERSPECTIVE 0x00000001L")]
        public const int D3DPTEXTURECAPS_PERSPECTIVE = 0x00000001;

        [NativeTypeName("#define D3DPTEXTURECAPS_POW2 0x00000002L")]
        public const int D3DPTEXTURECAPS_POW2 = 0x00000002;

        [NativeTypeName("#define D3DPTEXTURECAPS_ALPHA 0x00000004L")]
        public const int D3DPTEXTURECAPS_ALPHA = 0x00000004;

        [NativeTypeName("#define D3DPTEXTURECAPS_SQUAREONLY 0x00000020L")]
        public const int D3DPTEXTURECAPS_SQUAREONLY = 0x00000020;

        [NativeTypeName("#define D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE 0x00000040L")]
        public const int D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE = 0x00000040;

        [NativeTypeName("#define D3DPTEXTURECAPS_ALPHAPALETTE 0x00000080L")]
        public const int D3DPTEXTURECAPS_ALPHAPALETTE = 0x00000080;

        [NativeTypeName("#define D3DPTEXTURECAPS_NONPOW2CONDITIONAL 0x00000100L")]
        public const int D3DPTEXTURECAPS_NONPOW2CONDITIONAL = 0x00000100;

        [NativeTypeName("#define D3DPTEXTURECAPS_PROJECTED 0x00000400L")]
        public const int D3DPTEXTURECAPS_PROJECTED = 0x00000400;

        [NativeTypeName("#define D3DPTEXTURECAPS_CUBEMAP 0x00000800L")]
        public const int D3DPTEXTURECAPS_CUBEMAP = 0x00000800;

        [NativeTypeName("#define D3DPTEXTURECAPS_VOLUMEMAP 0x00002000L")]
        public const int D3DPTEXTURECAPS_VOLUMEMAP = 0x00002000;

        [NativeTypeName("#define D3DPTEXTURECAPS_MIPMAP 0x00004000L")]
        public const int D3DPTEXTURECAPS_MIPMAP = 0x00004000;

        [NativeTypeName("#define D3DPTEXTURECAPS_MIPVOLUMEMAP 0x00008000L")]
        public const int D3DPTEXTURECAPS_MIPVOLUMEMAP = 0x00008000;

        [NativeTypeName("#define D3DPTEXTURECAPS_MIPCUBEMAP 0x00010000L")]
        public const int D3DPTEXTURECAPS_MIPCUBEMAP = 0x00010000;

        [NativeTypeName("#define D3DPTEXTURECAPS_CUBEMAP_POW2 0x00020000L")]
        public const int D3DPTEXTURECAPS_CUBEMAP_POW2 = 0x00020000;

        [NativeTypeName("#define D3DPTEXTURECAPS_VOLUMEMAP_POW2 0x00040000L")]
        public const int D3DPTEXTURECAPS_VOLUMEMAP_POW2 = 0x00040000;

        [NativeTypeName("#define D3DPTEXTURECAPS_NOPROJECTEDBUMPENV 0x00200000L")]
        public const int D3DPTEXTURECAPS_NOPROJECTEDBUMPENV = 0x00200000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFPOINT 0x00000100L")]
        public const int D3DPTFILTERCAPS_MINFPOINT = 0x00000100;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFLINEAR 0x00000200L")]
        public const int D3DPTFILTERCAPS_MINFLINEAR = 0x00000200;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFANISOTROPIC 0x00000400L")]
        public const int D3DPTFILTERCAPS_MINFANISOTROPIC = 0x00000400;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFPYRAMIDALQUAD 0x00000800L")]
        public const int D3DPTFILTERCAPS_MINFPYRAMIDALQUAD = 0x00000800;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFGAUSSIANQUAD 0x00001000L")]
        public const int D3DPTFILTERCAPS_MINFGAUSSIANQUAD = 0x00001000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MIPFPOINT 0x00010000L")]
        public const int D3DPTFILTERCAPS_MIPFPOINT = 0x00010000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MIPFLINEAR 0x00020000L")]
        public const int D3DPTFILTERCAPS_MIPFLINEAR = 0x00020000;

        [NativeTypeName("#define D3DPTFILTERCAPS_CONVOLUTIONMONO 0x00040000L")]
        public const int D3DPTFILTERCAPS_CONVOLUTIONMONO = 0x00040000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFPOINT 0x01000000L")]
        public const int D3DPTFILTERCAPS_MAGFPOINT = 0x01000000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFLINEAR 0x02000000L")]
        public const int D3DPTFILTERCAPS_MAGFLINEAR = 0x02000000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFANISOTROPIC 0x04000000L")]
        public const int D3DPTFILTERCAPS_MAGFANISOTROPIC = 0x04000000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD 0x08000000L")]
        public const int D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD = 0x08000000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFGAUSSIANQUAD 0x10000000L")]
        public const int D3DPTFILTERCAPS_MAGFGAUSSIANQUAD = 0x10000000;

        [NativeTypeName("#define D3DPTADDRESSCAPS_WRAP 0x00000001L")]
        public const int D3DPTADDRESSCAPS_WRAP = 0x00000001;

        [NativeTypeName("#define D3DPTADDRESSCAPS_MIRROR 0x00000002L")]
        public const int D3DPTADDRESSCAPS_MIRROR = 0x00000002;

        [NativeTypeName("#define D3DPTADDRESSCAPS_CLAMP 0x00000004L")]
        public const int D3DPTADDRESSCAPS_CLAMP = 0x00000004;

        [NativeTypeName("#define D3DPTADDRESSCAPS_BORDER 0x00000008L")]
        public const int D3DPTADDRESSCAPS_BORDER = 0x00000008;

        [NativeTypeName("#define D3DPTADDRESSCAPS_INDEPENDENTUV 0x00000010L")]
        public const int D3DPTADDRESSCAPS_INDEPENDENTUV = 0x00000010;

        [NativeTypeName("#define D3DPTADDRESSCAPS_MIRRORONCE 0x00000020L")]
        public const int D3DPTADDRESSCAPS_MIRRORONCE = 0x00000020;

        [NativeTypeName("#define D3DSTENCILCAPS_KEEP 0x00000001L")]
        public const int D3DSTENCILCAPS_KEEP = 0x00000001;

        [NativeTypeName("#define D3DSTENCILCAPS_ZERO 0x00000002L")]
        public const int D3DSTENCILCAPS_ZERO = 0x00000002;

        [NativeTypeName("#define D3DSTENCILCAPS_REPLACE 0x00000004L")]
        public const int D3DSTENCILCAPS_REPLACE = 0x00000004;

        [NativeTypeName("#define D3DSTENCILCAPS_INCRSAT 0x00000008L")]
        public const int D3DSTENCILCAPS_INCRSAT = 0x00000008;

        [NativeTypeName("#define D3DSTENCILCAPS_DECRSAT 0x00000010L")]
        public const int D3DSTENCILCAPS_DECRSAT = 0x00000010;

        [NativeTypeName("#define D3DSTENCILCAPS_INVERT 0x00000020L")]
        public const int D3DSTENCILCAPS_INVERT = 0x00000020;

        [NativeTypeName("#define D3DSTENCILCAPS_INCR 0x00000040L")]
        public const int D3DSTENCILCAPS_INCR = 0x00000040;

        [NativeTypeName("#define D3DSTENCILCAPS_DECR 0x00000080L")]
        public const int D3DSTENCILCAPS_DECR = 0x00000080;

        [NativeTypeName("#define D3DSTENCILCAPS_TWOSIDED 0x00000100L")]
        public const int D3DSTENCILCAPS_TWOSIDED = 0x00000100;

        [NativeTypeName("#define D3DTEXOPCAPS_DISABLE 0x00000001L")]
        public const int D3DTEXOPCAPS_DISABLE = 0x00000001;

        [NativeTypeName("#define D3DTEXOPCAPS_SELECTARG1 0x00000002L")]
        public const int D3DTEXOPCAPS_SELECTARG1 = 0x00000002;

        [NativeTypeName("#define D3DTEXOPCAPS_SELECTARG2 0x00000004L")]
        public const int D3DTEXOPCAPS_SELECTARG2 = 0x00000004;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATE 0x00000008L")]
        public const int D3DTEXOPCAPS_MODULATE = 0x00000008;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATE2X 0x00000010L")]
        public const int D3DTEXOPCAPS_MODULATE2X = 0x00000010;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATE4X 0x00000020L")]
        public const int D3DTEXOPCAPS_MODULATE4X = 0x00000020;

        [NativeTypeName("#define D3DTEXOPCAPS_ADD 0x00000040L")]
        public const int D3DTEXOPCAPS_ADD = 0x00000040;

        [NativeTypeName("#define D3DTEXOPCAPS_ADDSIGNED 0x00000080L")]
        public const int D3DTEXOPCAPS_ADDSIGNED = 0x00000080;

        [NativeTypeName("#define D3DTEXOPCAPS_ADDSIGNED2X 0x00000100L")]
        public const int D3DTEXOPCAPS_ADDSIGNED2X = 0x00000100;

        [NativeTypeName("#define D3DTEXOPCAPS_SUBTRACT 0x00000200L")]
        public const int D3DTEXOPCAPS_SUBTRACT = 0x00000200;

        [NativeTypeName("#define D3DTEXOPCAPS_ADDSMOOTH 0x00000400L")]
        public const int D3DTEXOPCAPS_ADDSMOOTH = 0x00000400;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDDIFFUSEALPHA 0x00000800L")]
        public const int D3DTEXOPCAPS_BLENDDIFFUSEALPHA = 0x00000800;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDTEXTUREALPHA 0x00001000L")]
        public const int D3DTEXOPCAPS_BLENDTEXTUREALPHA = 0x00001000;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDFACTORALPHA 0x00002000L")]
        public const int D3DTEXOPCAPS_BLENDFACTORALPHA = 0x00002000;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDTEXTUREALPHAPM 0x00004000L")]
        public const int D3DTEXOPCAPS_BLENDTEXTUREALPHAPM = 0x00004000;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDCURRENTALPHA 0x00008000L")]
        public const int D3DTEXOPCAPS_BLENDCURRENTALPHA = 0x00008000;

        [NativeTypeName("#define D3DTEXOPCAPS_PREMODULATE 0x00010000L")]
        public const int D3DTEXOPCAPS_PREMODULATE = 0x00010000;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR 0x00020000L")]
        public const int D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR = 0x00020000;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA 0x00040000L")]
        public const int D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA = 0x00040000;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR 0x00080000L")]
        public const int D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR = 0x00080000;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA 0x00100000L")]
        public const int D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA = 0x00100000;

        [NativeTypeName("#define D3DTEXOPCAPS_BUMPENVMAP 0x00200000L")]
        public const int D3DTEXOPCAPS_BUMPENVMAP = 0x00200000;

        [NativeTypeName("#define D3DTEXOPCAPS_BUMPENVMAPLUMINANCE 0x00400000L")]
        public const int D3DTEXOPCAPS_BUMPENVMAPLUMINANCE = 0x00400000;

        [NativeTypeName("#define D3DTEXOPCAPS_DOTPRODUCT3 0x00800000L")]
        public const int D3DTEXOPCAPS_DOTPRODUCT3 = 0x00800000;

        [NativeTypeName("#define D3DTEXOPCAPS_MULTIPLYADD 0x01000000L")]
        public const int D3DTEXOPCAPS_MULTIPLYADD = 0x01000000;

        [NativeTypeName("#define D3DTEXOPCAPS_LERP 0x02000000L")]
        public const int D3DTEXOPCAPS_LERP = 0x02000000;

        [NativeTypeName("#define D3DFVFCAPS_TEXCOORDCOUNTMASK 0x0000ffffL")]
        public const int D3DFVFCAPS_TEXCOORDCOUNTMASK = 0x0000ffff;

        [NativeTypeName("#define D3DFVFCAPS_DONOTSTRIPELEMENTS 0x00080000L")]
        public const int D3DFVFCAPS_DONOTSTRIPELEMENTS = 0x00080000;

        [NativeTypeName("#define D3DFVFCAPS_PSIZE 0x00100000L")]
        public const int D3DFVFCAPS_PSIZE = 0x00100000;

        [NativeTypeName("#define D3DVTXPCAPS_TEXGEN 0x00000001L")]
        public const int D3DVTXPCAPS_TEXGEN = 0x00000001;

        [NativeTypeName("#define D3DVTXPCAPS_MATERIALSOURCE7 0x00000002L")]
        public const int D3DVTXPCAPS_MATERIALSOURCE7 = 0x00000002;

        [NativeTypeName("#define D3DVTXPCAPS_DIRECTIONALLIGHTS 0x00000008L")]
        public const int D3DVTXPCAPS_DIRECTIONALLIGHTS = 0x00000008;

        [NativeTypeName("#define D3DVTXPCAPS_POSITIONALLIGHTS 0x00000010L")]
        public const int D3DVTXPCAPS_POSITIONALLIGHTS = 0x00000010;

        [NativeTypeName("#define D3DVTXPCAPS_LOCALVIEWER 0x00000020L")]
        public const int D3DVTXPCAPS_LOCALVIEWER = 0x00000020;

        [NativeTypeName("#define D3DVTXPCAPS_TWEENING 0x00000040L")]
        public const int D3DVTXPCAPS_TWEENING = 0x00000040;

        [NativeTypeName("#define D3DVTXPCAPS_TEXGEN_SPHEREMAP 0x00000100L")]
        public const int D3DVTXPCAPS_TEXGEN_SPHEREMAP = 0x00000100;

        [NativeTypeName("#define D3DVTXPCAPS_NO_TEXGEN_NONLOCALVIEWER 0x00000200L")]
        public const int D3DVTXPCAPS_NO_TEXGEN_NONLOCALVIEWER = 0x00000200;

        [NativeTypeName("#define D3DDEVCAPS2_STREAMOFFSET 0x00000001L")]
        public const int D3DDEVCAPS2_STREAMOFFSET = 0x00000001;

        [NativeTypeName("#define D3DDEVCAPS2_DMAPNPATCH 0x00000002L")]
        public const int D3DDEVCAPS2_DMAPNPATCH = 0x00000002;

        [NativeTypeName("#define D3DDEVCAPS2_ADAPTIVETESSRTPATCH 0x00000004L")]
        public const int D3DDEVCAPS2_ADAPTIVETESSRTPATCH = 0x00000004;

        [NativeTypeName("#define D3DDEVCAPS2_ADAPTIVETESSNPATCH 0x00000008L")]
        public const int D3DDEVCAPS2_ADAPTIVETESSNPATCH = 0x00000008;

        [NativeTypeName("#define D3DDEVCAPS2_CAN_STRETCHRECT_FROM_TEXTURES 0x00000010L")]
        public const int D3DDEVCAPS2_CAN_STRETCHRECT_FROM_TEXTURES = 0x00000010;

        [NativeTypeName("#define D3DDEVCAPS2_PRESAMPLEDDMAPNPATCH 0x00000020L")]
        public const int D3DDEVCAPS2_PRESAMPLEDDMAPNPATCH = 0x00000020;

        [NativeTypeName("#define D3DDEVCAPS2_VERTEXELEMENTSCANSHARESTREAMOFFSET 0x00000040L")]
        public const int D3DDEVCAPS2_VERTEXELEMENTSCANSHARESTREAMOFFSET = 0x00000040;

        [NativeTypeName("#define D3DDTCAPS_UBYTE4 0x00000001L")]
        public const int D3DDTCAPS_UBYTE4 = 0x00000001;

        [NativeTypeName("#define D3DDTCAPS_UBYTE4N 0x00000002L")]
        public const int D3DDTCAPS_UBYTE4N = 0x00000002;

        [NativeTypeName("#define D3DDTCAPS_SHORT2N 0x00000004L")]
        public const int D3DDTCAPS_SHORT2N = 0x00000004;

        [NativeTypeName("#define D3DDTCAPS_SHORT4N 0x00000008L")]
        public const int D3DDTCAPS_SHORT4N = 0x00000008;

        [NativeTypeName("#define D3DDTCAPS_USHORT2N 0x00000010L")]
        public const int D3DDTCAPS_USHORT2N = 0x00000010;

        [NativeTypeName("#define D3DDTCAPS_USHORT4N 0x00000020L")]
        public const int D3DDTCAPS_USHORT4N = 0x00000020;

        [NativeTypeName("#define D3DDTCAPS_UDEC3 0x00000040L")]
        public const int D3DDTCAPS_UDEC3 = 0x00000040;

        [NativeTypeName("#define D3DDTCAPS_DEC3N 0x00000080L")]
        public const int D3DDTCAPS_DEC3N = 0x00000080;

        [NativeTypeName("#define D3DDTCAPS_FLOAT16_2 0x00000100L")]
        public const int D3DDTCAPS_FLOAT16_2 = 0x00000100;

        [NativeTypeName("#define D3DDTCAPS_FLOAT16_4 0x00000200L")]
        public const int D3DDTCAPS_FLOAT16_4 = 0x00000200;

        [NativeTypeName("#define D3DSPD_IUNKNOWN 0x00000001L")]
        public const int D3DSPD_IUNKNOWN = 0x00000001;

        [NativeTypeName("#define D3DCREATE_FPU_PRESERVE 0x00000002L")]
        public const int D3DCREATE_FPU_PRESERVE = 0x00000002;

        [NativeTypeName("#define D3DCREATE_MULTITHREADED 0x00000004L")]
        public const int D3DCREATE_MULTITHREADED = 0x00000004;

        [NativeTypeName("#define D3DCREATE_PUREDEVICE 0x00000010L")]
        public const int D3DCREATE_PUREDEVICE = 0x00000010;

        [NativeTypeName("#define D3DCREATE_SOFTWARE_VERTEXPROCESSING 0x00000020L")]
        public const int D3DCREATE_SOFTWARE_VERTEXPROCESSING = 0x00000020;

        [NativeTypeName("#define D3DCREATE_HARDWARE_VERTEXPROCESSING 0x00000040L")]
        public const int D3DCREATE_HARDWARE_VERTEXPROCESSING = 0x00000040;

        [NativeTypeName("#define D3DCREATE_MIXED_VERTEXPROCESSING 0x00000080L")]
        public const int D3DCREATE_MIXED_VERTEXPROCESSING = 0x00000080;

        [NativeTypeName("#define D3DCREATE_DISABLE_DRIVER_MANAGEMENT 0x00000100L")]
        public const int D3DCREATE_DISABLE_DRIVER_MANAGEMENT = 0x00000100;

        [NativeTypeName("#define D3DCREATE_ADAPTERGROUP_DEVICE 0x00000200L")]
        public const int D3DCREATE_ADAPTERGROUP_DEVICE = 0x00000200;

        [NativeTypeName("#define D3DCREATE_DISABLE_DRIVER_MANAGEMENT_EX 0x00000400L")]
        public const int D3DCREATE_DISABLE_DRIVER_MANAGEMENT_EX = 0x00000400;

        [NativeTypeName("#define D3DCREATE_NOWINDOWCHANGES 0x00000800L")]
        public const int D3DCREATE_NOWINDOWCHANGES = 0x00000800;

        [NativeTypeName("#define D3DCREATE_DISABLE_PSGP_THREADING 0x00002000L")]
        public const int D3DCREATE_DISABLE_PSGP_THREADING = 0x00002000;

        [NativeTypeName("#define D3DCREATE_ENABLE_PRESENTSTATS 0x00004000L")]
        public const int D3DCREATE_ENABLE_PRESENTSTATS = 0x00004000;

        [NativeTypeName("#define D3DCREATE_DISABLE_PRINTSCREEN 0x00008000L")]
        public const int D3DCREATE_DISABLE_PRINTSCREEN = 0x00008000;

        [NativeTypeName("#define D3DCREATE_SCREENSAVER 0x10000000L")]
        public const int D3DCREATE_SCREENSAVER = 0x10000000;

        [NativeTypeName("#define D3DADAPTER_DEFAULT 0")]
        public const int D3DADAPTER_DEFAULT = 0;

        [NativeTypeName("#define D3DENUM_WHQL_LEVEL 0x00000002L")]
        public const int D3DENUM_WHQL_LEVEL = 0x00000002;

        [NativeTypeName("#define D3DENUM_NO_DRIVERVERSION 0x00000004L")]
        public const int D3DENUM_NO_DRIVERVERSION = 0x00000004;

        [NativeTypeName("#define D3DPRESENT_BACK_BUFFERS_MAX 3L")]
        public const int D3DPRESENT_BACK_BUFFERS_MAX = 3;

        [NativeTypeName("#define D3DPRESENT_BACK_BUFFERS_MAX_EX 30L")]
        public const int D3DPRESENT_BACK_BUFFERS_MAX_EX = 30;

        [NativeTypeName("#define D3DSGR_NO_CALIBRATION 0x00000000L")]
        public const int D3DSGR_NO_CALIBRATION = 0x00000000;

        [NativeTypeName("#define D3DSGR_CALIBRATE 0x00000001L")]
        public const int D3DSGR_CALIBRATE = 0x00000001;

        [NativeTypeName("#define D3DCURSOR_IMMEDIATE_UPDATE 0x00000001L")]
        public const int D3DCURSOR_IMMEDIATE_UPDATE = 0x00000001;

        [NativeTypeName("#define D3DPRESENT_DONOTWAIT 0x00000001L")]
        public const int D3DPRESENT_DONOTWAIT = 0x00000001;

        [NativeTypeName("#define D3DPRESENT_LINEAR_CONTENT 0x00000002L")]
        public const int D3DPRESENT_LINEAR_CONTENT = 0x00000002;

        [NativeTypeName("#define D3DPRESENT_DONOTFLIP 0x00000004L")]
        public const int D3DPRESENT_DONOTFLIP = 0x00000004;

        [NativeTypeName("#define D3DPRESENT_FLIPRESTART 0x00000008L")]
        public const int D3DPRESENT_FLIPRESTART = 0x00000008;

        [NativeTypeName("#define D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR 0x00000010L")]
        public const int D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR = 0x00000010;

        [NativeTypeName("#define D3DPRESENT_UPDATEOVERLAYONLY 0x00000020L")]
        public const int D3DPRESENT_UPDATEOVERLAYONLY = 0x00000020;

        [NativeTypeName("#define D3DPRESENT_HIDEOVERLAY 0x00000040L")]
        public const int D3DPRESENT_HIDEOVERLAY = 0x00000040;

        [NativeTypeName("#define D3DPRESENT_UPDATECOLORKEY 0x00000080L")]
        public const int D3DPRESENT_UPDATECOLORKEY = 0x00000080;

        [NativeTypeName("#define D3DPRESENT_FORCEIMMEDIATE 0x00000100L")]
        public const int D3DPRESENT_FORCEIMMEDIATE = 0x00000100;

        [NativeTypeName("#define _FACD3D 0x876")]
        public const int _FACD3D = 0x876;

        [NativeTypeName("#define D3D_OK S_OK")]
        public const int D3D_OK = ((int)(0));

        [NativeTypeName("#define D3DERR_WRONGTEXTUREFORMAT MAKE_D3DHRESULT(2072)")]
        public const int D3DERR_WRONGTEXTUREFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2072))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDCOLOROPERATION MAKE_D3DHRESULT(2073)")]
        public const int D3DERR_UNSUPPORTEDCOLOROPERATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2073))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDCOLORARG MAKE_D3DHRESULT(2074)")]
        public const int D3DERR_UNSUPPORTEDCOLORARG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2074))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDALPHAOPERATION MAKE_D3DHRESULT(2075)")]
        public const int D3DERR_UNSUPPORTEDALPHAOPERATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2075))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDALPHAARG MAKE_D3DHRESULT(2076)")]
        public const int D3DERR_UNSUPPORTEDALPHAARG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2076))));

        [NativeTypeName("#define D3DERR_TOOMANYOPERATIONS MAKE_D3DHRESULT(2077)")]
        public const int D3DERR_TOOMANYOPERATIONS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2077))));

        [NativeTypeName("#define D3DERR_CONFLICTINGTEXTUREFILTER MAKE_D3DHRESULT(2078)")]
        public const int D3DERR_CONFLICTINGTEXTUREFILTER = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2078))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDFACTORVALUE MAKE_D3DHRESULT(2079)")]
        public const int D3DERR_UNSUPPORTEDFACTORVALUE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2079))));

        [NativeTypeName("#define D3DERR_CONFLICTINGRENDERSTATE MAKE_D3DHRESULT(2081)")]
        public const int D3DERR_CONFLICTINGRENDERSTATE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2081))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDTEXTUREFILTER MAKE_D3DHRESULT(2082)")]
        public const int D3DERR_UNSUPPORTEDTEXTUREFILTER = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2082))));

        [NativeTypeName("#define D3DERR_CONFLICTINGTEXTUREPALETTE MAKE_D3DHRESULT(2086)")]
        public const int D3DERR_CONFLICTINGTEXTUREPALETTE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2086))));

        [NativeTypeName("#define D3DERR_DRIVERINTERNALERROR MAKE_D3DHRESULT(2087)")]
        public const int D3DERR_DRIVERINTERNALERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2087))));

        [NativeTypeName("#define D3DERR_NOTFOUND MAKE_D3DHRESULT(2150)")]
        public const int D3DERR_NOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2150))));

        [NativeTypeName("#define D3DERR_MOREDATA MAKE_D3DHRESULT(2151)")]
        public const int D3DERR_MOREDATA = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2151))));

        [NativeTypeName("#define D3DERR_DEVICELOST MAKE_D3DHRESULT(2152)")]
        public const int D3DERR_DEVICELOST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2152))));

        [NativeTypeName("#define D3DERR_DEVICENOTRESET MAKE_D3DHRESULT(2153)")]
        public const int D3DERR_DEVICENOTRESET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2153))));

        [NativeTypeName("#define D3DERR_NOTAVAILABLE MAKE_D3DHRESULT(2154)")]
        public const int D3DERR_NOTAVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2154))));

        [NativeTypeName("#define D3DERR_OUTOFVIDEOMEMORY MAKE_D3DHRESULT(380)")]
        public const int D3DERR_OUTOFVIDEOMEMORY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(380))));

        [NativeTypeName("#define D3DERR_INVALIDDEVICE MAKE_D3DHRESULT(2155)")]
        public const int D3DERR_INVALIDDEVICE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2155))));

        [NativeTypeName("#define D3DERR_INVALIDCALL MAKE_D3DHRESULT(2156)")]
        public const int D3DERR_INVALIDCALL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2156))));

        [NativeTypeName("#define D3DERR_DRIVERINVALIDCALL MAKE_D3DHRESULT(2157)")]
        public const int D3DERR_DRIVERINVALIDCALL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2157))));

        [NativeTypeName("#define D3DERR_WASSTILLDRAWING MAKE_D3DHRESULT(540)")]
        public const int D3DERR_WASSTILLDRAWING = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(540))));

        [NativeTypeName("#define D3DOK_NOAUTOGEN MAKE_D3DSTATUS(2159)")]
        public const int D3DOK_NOAUTOGEN = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2159))));

        [NativeTypeName("#define D3DERR_DEVICEREMOVED MAKE_D3DHRESULT(2160)")]
        public const int D3DERR_DEVICEREMOVED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2160))));

        [NativeTypeName("#define S_NOT_RESIDENT MAKE_D3DSTATUS(2165)")]
        public const int S_NOT_RESIDENT = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2165))));

        [NativeTypeName("#define S_RESIDENT_IN_SHARED_MEMORY MAKE_D3DSTATUS(2166)")]
        public const int S_RESIDENT_IN_SHARED_MEMORY = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2166))));

        [NativeTypeName("#define S_PRESENT_MODE_CHANGED MAKE_D3DSTATUS(2167)")]
        public const int S_PRESENT_MODE_CHANGED = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2167))));

        [NativeTypeName("#define S_PRESENT_OCCLUDED MAKE_D3DSTATUS(2168)")]
        public const int S_PRESENT_OCCLUDED = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2168))));

        [NativeTypeName("#define D3DERR_DEVICEHUNG MAKE_D3DHRESULT(2164)")]
        public const int D3DERR_DEVICEHUNG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2164))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDOVERLAY MAKE_D3DHRESULT(2171)")]
        public const int D3DERR_UNSUPPORTEDOVERLAY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2171))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDOVERLAYFORMAT MAKE_D3DHRESULT(2172)")]
        public const int D3DERR_UNSUPPORTEDOVERLAYFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2172))));

        [NativeTypeName("#define D3DERR_CANNOTPROTECTCONTENT MAKE_D3DHRESULT(2173)")]
        public const int D3DERR_CANNOTPROTECTCONTENT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2173))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDCRYPTO MAKE_D3DHRESULT(2174)")]
        public const int D3DERR_UNSUPPORTEDCRYPTO = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2174))));

        [NativeTypeName("#define D3DERR_PRESENT_STATISTICS_DISJOINT MAKE_D3DHRESULT(2180)")]
        public const int D3DERR_PRESENT_STATISTICS_DISJOINT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2180))));

        public static readonly Guid IID_IDirect3D9 = new Guid(0x81BDCBCA, 0x64D4, 0x426D, 0xAE, 0x8D, 0xAD, 0x01, 0x47, 0xF4, 0x27, 0x5C);

        public static readonly Guid IID_IDirect3DDevice9 = new Guid(0xD0223B96, 0xBF7A, 0x43FD, 0x92, 0xBD, 0xA4, 0x3B, 0x0D, 0x82, 0xB9, 0xEB);

        public static readonly Guid IID_IDirect3DStateBlock9 = new Guid(0xB07C4FE5, 0x310D, 0x4BA8, 0xA2, 0x3C, 0x4F, 0x0F, 0x20, 0x6F, 0x21, 0x8B);

        public static readonly Guid IID_IDirect3DSwapChain9 = new Guid(0x794950F2, 0xADFC, 0x458A, 0x90, 0x5E, 0x10, 0xA1, 0x0B, 0x0B, 0x50, 0x3B);

        public static readonly Guid IID_IDirect3DResource9 = new Guid(0x05EEC05D, 0x8F7D, 0x4362, 0xB9, 0x99, 0xD1, 0xBA, 0xF3, 0x57, 0xC7, 0x04);

        public static readonly Guid IID_IDirect3DVertexDeclaration9 = new Guid(0xDD13C59C, 0x36FA, 0x4098, 0xA8, 0xFB, 0xC7, 0xED, 0x39, 0xDC, 0x85, 0x46);

        public static readonly Guid IID_IDirect3DVertexShader9 = new Guid(0xEFC5557E, 0x6265, 0x4613, 0x8A, 0x94, 0x43, 0x85, 0x78, 0x89, 0xEB, 0x36);

        public static readonly Guid IID_IDirect3DPixelShader9 = new Guid(0x6D3BDBDC, 0x5B02, 0x4415, 0xB8, 0x52, 0xCE, 0x5E, 0x8B, 0xCC, 0xB2, 0x89);

        public static readonly Guid IID_IDirect3DBaseTexture9 = new Guid(0x580CA87E, 0x1D3C, 0x4D54, 0x99, 0x1D, 0xB7, 0xD3, 0xE3, 0xC2, 0x98, 0xCE);

        public static readonly Guid IID_IDirect3DTexture9 = new Guid(0x85C31227, 0x3DE5, 0x4F00, 0x9B, 0x3A, 0xF1, 0x1A, 0xC3, 0x8C, 0x18, 0xB5);

        public static readonly Guid IID_IDirect3DVolumeTexture9 = new Guid(0x2518526C, 0xE789, 0x4111, 0xA7, 0xB9, 0x47, 0xEF, 0x32, 0x8D, 0x13, 0xE6);

        public static readonly Guid IID_IDirect3DCubeTexture9 = new Guid(0xFFF32F81, 0xD953, 0x473A, 0x92, 0x23, 0x93, 0xD6, 0x52, 0xAB, 0xA9, 0x3F);

        public static readonly Guid IID_IDirect3DVertexBuffer9 = new Guid(0xB64BB1B5, 0xFD70, 0x4DF6, 0xBF, 0x91, 0x19, 0xD0, 0xA1, 0x24, 0x55, 0xE3);

        public static readonly Guid IID_IDirect3DIndexBuffer9 = new Guid(0x7C9DD65E, 0xD3F7, 0x4529, 0xAC, 0xEE, 0x78, 0x58, 0x30, 0xAC, 0xDE, 0x35);

        public static readonly Guid IID_IDirect3DSurface9 = new Guid(0x0CFBAF3A, 0x9FF6, 0x429A, 0x99, 0xB3, 0xA2, 0x79, 0x6A, 0xF8, 0xB8, 0x9B);

        public static readonly Guid IID_IDirect3DVolume9 = new Guid(0x24F416E6, 0x1F67, 0x4AA7, 0xB8, 0x8E, 0xD3, 0x3F, 0x6F, 0x31, 0x28, 0xA1);

        public static readonly Guid IID_IDirect3DQuery9 = new Guid(0xD9771460, 0xA695, 0x4F26, 0xBB, 0xD3, 0x27, 0xB8, 0x40, 0xB5, 0x41, 0xCC);

        public static readonly Guid IID_IDirect3D9Ex = new Guid(0x02177241, 0x69FC, 0x400C, 0x8F, 0xF1, 0x93, 0xA4, 0x4D, 0xF6, 0x86, 0x1D);

        public static readonly Guid IID_IDirect3DDevice9Ex = new Guid(0xB18B10CE, 0x2649, 0x405A, 0x87, 0x0F, 0x95, 0xF7, 0x77, 0xD4, 0x31, 0x3A);

        public static readonly Guid IID_IDirect3DSwapChain9Ex = new Guid(0x91886CAF, 0x1C3D, 0x4D2E, 0xA0, 0xAB, 0x3E, 0x4C, 0x7D, 0x8D, 0x33, 0x03);

        public static readonly Guid IID_IDirect3D9ExOverlayExtension = new Guid(0x187AEB13, 0xAAF5, 0x4C59, 0x87, 0x6D, 0xE0, 0x59, 0x08, 0x8C, 0x0D, 0xF8);

        public static readonly Guid IID_IDirect3DDevice9Video = new Guid(0x26DC4561, 0xA1EE, 0x4AE7, 0x96, 0xDA, 0x11, 0x8A, 0x36, 0xC0, 0xEC, 0x95);

        public static readonly Guid IID_IDirect3DAuthenticatedChannel9 = new Guid(0xFF24BEEE, 0xDA21, 0x4BEB, 0x98, 0xB5, 0xD2, 0xF8, 0x99, 0xF9, 0x8A, 0xF9);

        public static readonly Guid IID_IDirect3DCryptoSession9 = new Guid(0xFA0AB799, 0x7A9C, 0x48CA, 0x8C, 0x5B, 0x23, 0x7E, 0x71, 0xA5, 0x44, 0x34);
    }
}

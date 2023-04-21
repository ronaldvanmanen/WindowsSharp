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
        [NativeTypeName("const CD3D11_DEFAULT")]
        public static readonly CD3D11_DEFAULT D3D11_DEFAULT = new CD3D11_DEFAULT();

        [NativeTypeName("const CD3D11_VIDEO_DEFAULT")]
        public static readonly CD3D11_VIDEO_DEFAULT D3D11_VIDEO_DEFAULT = new CD3D11_VIDEO_DEFAULT();

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3D11CreateDevice"]/*' />
        [DllImport("D3D11.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11CreateDevice(IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] HINSTANCE__* Software, uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, D3D_FEATURE_LEVEL* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <include file='NativeMethods.xml' path='doc/member[@name="NativeMethods.D3D11CreateDeviceAndSwapChain"]/*' />
        [DllImport("D3D11.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11CreateDeviceAndSwapChain(IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] HINSTANCE__* Software, uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, D3D_FEATURE_LEVEL* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION 2048")]
        public const int D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION = 2048;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION 2048")]
        public const int D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION = 2048;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION 512")]
        public const int D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION = 512;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION 256")]
        public const int D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = 256;

        [NativeTypeName("#define D3D_FL9_1_DEFAULT_MAX_ANISOTROPY 2")]
        public const int D3D_FL9_1_DEFAULT_MAX_ANISOTROPY = 2;

        [NativeTypeName("#define D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT 65535")]
        public const int D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT = 65535;

        [NativeTypeName("#define D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT 1048575")]
        public const int D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT = 1048575;

        [NativeTypeName("#define D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT 1")]
        public const int D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT = 1;

        [NativeTypeName("#define D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT 4")]
        public const int D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT = 4;

        [NativeTypeName("#define D3D_FL9_1_MAX_TEXTURE_REPEAT 128")]
        public const int D3D_FL9_1_MAX_TEXTURE_REPEAT = 128;

        [NativeTypeName("#define D3D_FL9_2_MAX_TEXTURE_REPEAT 2048")]
        public const int D3D_FL9_2_MAX_TEXTURE_REPEAT = 2048;

        [NativeTypeName("#define D3D_FL9_3_MAX_TEXTURE_REPEAT 8192")]
        public const int D3D_FL9_3_MAX_TEXTURE_REPEAT = 8192;

        [NativeTypeName("#define IID_ID3DBlob IID_ID3D10Blob")]
        public static readonly Guid IID_ID3DBlob = IID_ID3D10Blob;

        [NativeTypeName("#define D3D_COMPONENT_MASK_X 1")]
        public const int D3D_COMPONENT_MASK_X = 1;

        [NativeTypeName("#define D3D_COMPONENT_MASK_Y 2")]
        public const int D3D_COMPONENT_MASK_Y = 2;

        [NativeTypeName("#define D3D_COMPONENT_MASK_Z 4")]
        public const int D3D_COMPONENT_MASK_Z = 4;

        [NativeTypeName("#define D3D_COMPONENT_MASK_W 8")]
        public const int D3D_COMPONENT_MASK_W = 8;

        [NativeTypeName("#define D3D11_16BIT_INDEX_STRIP_CUT_VALUE ( 0xffff )")]
        public const int D3D11_16BIT_INDEX_STRIP_CUT_VALUE = (0xffff);

        [NativeTypeName("#define D3D11_32BIT_INDEX_STRIP_CUT_VALUE ( 0xffffffff )")]
        public const uint D3D11_32BIT_INDEX_STRIP_CUT_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D11_8BIT_INDEX_STRIP_CUT_VALUE ( 0xff )")]
        public const int D3D11_8BIT_INDEX_STRIP_CUT_VALUE = (0xff);

        [NativeTypeName("#define D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT ( 9 )")]
        public const int D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = (9);

        [NativeTypeName("#define D3D11_CLIP_OR_CULL_DISTANCE_COUNT ( 8 )")]
        public const int D3D11_CLIP_OR_CULL_DISTANCE_COUNT = (8);

        [NativeTypeName("#define D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT ( 2 )")]
        public const int D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = (2);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT ( 14 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = (14);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS ( 4 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT ( 15 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = (15);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT ( 15 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = (15);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT ( 64 )")]
        public const int D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = (64);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT ( 1 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT ( 128 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = (128);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT ( 128 )")]
        public const int D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = (128);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT ( 16 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT = (16);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT ( 16 )")]
        public const int D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT = (16);

        [NativeTypeName("#define D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT ( 32 )")]
        public const int D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = (32);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_COUNT ( 4096 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_COUNT = (4096);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST ( 3 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = (3);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS ( 3 )")]
        public const int D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS = (3);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX ( 10 )")]
        public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = (10);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN ( -10 )")]
        public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = (-10);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE ( -8 )")]
        public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = (-8);

        [NativeTypeName("#define D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE ( 7 )")]
        public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = (7);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 256 )")]
        public const int D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (256);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP ( 64 )")]
        public const int D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP = (64);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 240 )")]
        public const int D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (240);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP ( 68 )")]
        public const int D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP = (68);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 224 )")]
        public const int D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (224);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP ( 72 )")]
        public const int D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP = (72);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 208 )")]
        public const int D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (208);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP ( 76 )")]
        public const int D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP = (76);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 192 )")]
        public const int D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (192);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP ( 84 )")]
        public const int D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP = (84);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 176 )")]
        public const int D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (176);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP ( 92 )")]
        public const int D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP = (92);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 160 )")]
        public const int D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (160);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP ( 100 )")]
        public const int D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP = (100);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 144 )")]
        public const int D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (144);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP ( 112 )")]
        public const int D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP = (112);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 128 )")]
        public const int D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (128);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP ( 128 )")]
        public const int D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP = (128);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 112 )")]
        public const int D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (112);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP ( 144 )")]
        public const int D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP = (144);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 96 )")]
        public const int D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (96);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP ( 168 )")]
        public const int D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP = (168);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 80 )")]
        public const int D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (80);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP ( 204 )")]
        public const int D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP = (204);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 64 )")]
        public const int D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (64);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP ( 256 )")]
        public const int D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP = (256);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 48 )")]
        public const int D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (48);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP ( 340 )")]
        public const int D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP = (340);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 32 )")]
        public const int D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (32);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP ( 512 )")]
        public const int D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP = (512);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 16 )")]
        public const int D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = (16);

        [NativeTypeName("#define D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP ( 768 )")]
        public const int D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP = (768);

        [NativeTypeName("#define D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION ( 1 )")]
        public const int D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION = (1);

        [NativeTypeName("#define D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT ( 256 )")]
        public const int D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT = (256);

        [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 768 )")]
        public const int D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP = (768);

        [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_X ( 768 )")]
        public const int D3D11_CS_4_X_THREAD_GROUP_MAX_X = (768);

        [NativeTypeName("#define D3D11_CS_4_X_THREAD_GROUP_MAX_Y ( 768 )")]
        public const int D3D11_CS_4_X_THREAD_GROUP_MAX_Y = (768);

        [NativeTypeName("#define D3D11_CS_4_X_UAV_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_4_X_UAV_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION ( 65535 )")]
        public const int D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION = (65535);

        [NativeTypeName("#define D3D11_CS_TGSM_REGISTER_COUNT ( 8192 )")]
        public const int D3D11_CS_TGSM_REGISTER_COUNT = (8192);

        [NativeTypeName("#define D3D11_CS_TGSM_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_CS_TGSM_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D11_CS_THREADGROUPID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_THREADGROUPID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D11_CS_THREADIDINGROUP_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_THREADIDINGROUP_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_THREADID_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D11_CS_THREADID_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D11_CS_THREADID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_CS_THREADID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 1024 )")]
        public const int D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP = (1024);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_X ( 1024 )")]
        public const int D3D11_CS_THREAD_GROUP_MAX_X = (1024);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_Y ( 1024 )")]
        public const int D3D11_CS_THREAD_GROUP_MAX_Y = (1024);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MAX_Z ( 64 )")]
        public const int D3D11_CS_THREAD_GROUP_MAX_Z = (64);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_X ( 1 )")]
        public const int D3D11_CS_THREAD_GROUP_MIN_X = (1);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_Y ( 1 )")]
        public const int D3D11_CS_THREAD_GROUP_MIN_Y = (1);

        [NativeTypeName("#define D3D11_CS_THREAD_GROUP_MIN_Z ( 1 )")]
        public const int D3D11_CS_THREAD_GROUP_MIN_Z = (1);

        [NativeTypeName("#define D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL ( 16384 )")]
        public const int D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL = (16384);

        [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_ALPHA ( 1.0f )")]
        public const float D3D11_DEFAULT_BLEND_FACTOR_ALPHA = (1.0f);

        [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_BLUE ( 1.0f )")]
        public const float D3D11_DEFAULT_BLEND_FACTOR_BLUE = (1.0f);

        [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_GREEN ( 1.0f )")]
        public const float D3D11_DEFAULT_BLEND_FACTOR_GREEN = (1.0f);

        [NativeTypeName("#define D3D11_DEFAULT_BLEND_FACTOR_RED ( 1.0f )")]
        public const float D3D11_DEFAULT_BLEND_FACTOR_RED = (1.0f);

        [NativeTypeName("#define D3D11_DEFAULT_BORDER_COLOR_COMPONENT ( 0.0f )")]
        public const float D3D11_DEFAULT_BORDER_COLOR_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_DEPTH_BIAS ( 0 )")]
        public const int D3D11_DEFAULT_DEPTH_BIAS = (0);

        [NativeTypeName("#define D3D11_DEFAULT_DEPTH_BIAS_CLAMP ( 0.0f )")]
        public const float D3D11_DEFAULT_DEPTH_BIAS_CLAMP = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_MAX_ANISOTROPY ( 16 )")]
        public const int D3D11_DEFAULT_MAX_ANISOTROPY = (16);

        [NativeTypeName("#define D3D11_DEFAULT_MIP_LOD_BIAS ( 0.0f )")]
        public const float D3D11_DEFAULT_MIP_LOD_BIAS = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX ( 0 )")]
        public const int D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
        public const uint D3D11_DEFAULT_SAMPLE_MASK = (0xffffffff);

        [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_ENDX ( 0 )")]
        public const int D3D11_DEFAULT_SCISSOR_ENDX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_ENDY ( 0 )")]
        public const int D3D11_DEFAULT_SCISSOR_ENDY = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_STARTX ( 0 )")]
        public const int D3D11_DEFAULT_SCISSOR_STARTX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SCISSOR_STARTY ( 0 )")]
        public const int D3D11_DEFAULT_SCISSOR_STARTY = (0);

        [NativeTypeName("#define D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS ( 0.0f )")]
        public const float D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_STENCIL_READ_MASK ( 0xff )")]
        public const int D3D11_DEFAULT_STENCIL_READ_MASK = (0xff);

        [NativeTypeName("#define D3D11_DEFAULT_STENCIL_REFERENCE ( 0 )")]
        public const int D3D11_DEFAULT_STENCIL_REFERENCE = (0);

        [NativeTypeName("#define D3D11_DEFAULT_STENCIL_WRITE_MASK ( 0xff )")]
        public const int D3D11_DEFAULT_STENCIL_WRITE_MASK = (0xff);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_HEIGHT ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_HEIGHT = (0);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_MAX_DEPTH ( 0.0f )")]
        public const float D3D11_DEFAULT_VIEWPORT_MAX_DEPTH = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_MIN_DEPTH ( 0.0f )")]
        public const float D3D11_DEFAULT_VIEWPORT_MIN_DEPTH = (0.0f);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_TOPLEFTX ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTX = (0);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_TOPLEFTY ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTY = (0);

        [NativeTypeName("#define D3D11_DEFAULT_VIEWPORT_WIDTH ( 0 )")]
        public const int D3D11_DEFAULT_VIEWPORT_WIDTH = (0);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS ( 3 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS = (3);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT ( 1 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_DS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_DS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_DS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
        public const double D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);

        [NativeTypeName("#define D3D11_FLOAT32_MAX ( 3.402823466e+38f )")]
        public const float D3D11_FLOAT32_MAX = (3.402823466e+38f);

        [NativeTypeName("#define D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
        public const float D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR ( 2.4f )")]
        public const float D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = (2.4f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR ( 1.0f )")]
        public const float D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = (1.0f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_OFFSET ( 0.055f )")]
        public const float D3D11_FLOAT_TO_SRGB_OFFSET = (0.055f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_SCALE_1 ( 12.92f )")]
        public const float D3D11_FLOAT_TO_SRGB_SCALE_1 = (12.92f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_SCALE_2 ( 1.055f )")]
        public const float D3D11_FLOAT_TO_SRGB_SCALE_2 = (1.055f);

        [NativeTypeName("#define D3D11_FLOAT_TO_SRGB_THRESHOLD ( 0.0031308f )")]
        public const float D3D11_FLOAT_TO_SRGB_THRESHOLD = (0.0031308f);

        [NativeTypeName("#define D3D11_FTOI_INSTRUCTION_MAX_INPUT ( 2147483647.999f )")]
        public const float D3D11_FTOI_INSTRUCTION_MAX_INPUT = (2147483647.999f);

        [NativeTypeName("#define D3D11_FTOI_INSTRUCTION_MIN_INPUT ( -2147483648.999f )")]
        public const float D3D11_FTOI_INSTRUCTION_MIN_INPUT = (-2147483648.999f);

        [NativeTypeName("#define D3D11_FTOU_INSTRUCTION_MAX_INPUT ( 4294967295.999f )")]
        public const float D3D11_FTOU_INSTRUCTION_MAX_INPUT = (4294967295.999f);

        [NativeTypeName("#define D3D11_FTOU_INSTRUCTION_MIN_INPUT ( 0.0f )")]
        public const float D3D11_FTOU_INSTRUCTION_MIN_INPUT = (0.0f);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST ( 2 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS ( 1 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT ( 1 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_GS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_GS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_GS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_GS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_GS_INPUT_REGISTER_VERTICES ( 32 )")]
        public const int D3D11_GS_INPUT_REGISTER_VERTICES = (32);

        [NativeTypeName("#define D3D11_GS_MAX_INSTANCE_COUNT ( 32 )")]
        public const int D3D11_GS_MAX_INSTANCE_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES ( 1024 )")]
        public const int D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES = (1024);

        [NativeTypeName("#define D3D11_GS_OUTPUT_ELEMENTS ( 32 )")]
        public const int D3D11_GS_OUTPUT_ELEMENTS = (32);

        [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_GS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_GS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_GS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
        public const uint D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
        public const uint D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND = (0xffffffff);

        [NativeTypeName("#define D3D11_HS_MAXTESSFACTOR_LOWER_BOUND ( 1.0f )")]
        public const float D3D11_HS_MAXTESSFACTOR_LOWER_BOUND = (1.0f);

        [NativeTypeName("#define D3D11_HS_MAXTESSFACTOR_UPPER_BOUND ( 64.0f )")]
        public const float D3D11_HS_MAXTESSFACTOR_UPPER_BOUND = (64.0f);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = (3968);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT ( 1 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS ( 128 )")]
        public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS = (128);

        [NativeTypeName("#define D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
        public const int D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = (0);

        [NativeTypeName("#define D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY ( 0 )")]
        public const int D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY = (0);

        [NativeTypeName("#define D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
        public const int D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = (0);

        [NativeTypeName("#define D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT ( 1 )")]
        public const int D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = (1);

        [NativeTypeName("#define D3D11_IA_INSTANCE_ID_BIT_COUNT ( 32 )")]
        public const int D3D11_IA_INSTANCE_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT ( 32 )")]
        public const int D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT ( 32 )")]
        public const int D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_PRIMITIVE_ID_BIT_COUNT ( 32 )")]
        public const int D3D11_IA_PRIMITIVE_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_VERTEX_ID_BIT_COUNT ( 32 )")]
        public const int D3D11_IA_VERTEX_ID_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 32 )")]
        public const int D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (32);

        [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 128 )")]
        public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (128);

        [NativeTypeName("#define D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 32 )")]
        public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT ( 0xffffffff )")]
        public const uint D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = (0xffffffff);

        [NativeTypeName("#define D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER ( 0xffffffff )")]
        public const uint D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER = (0xffffffff);

        [NativeTypeName("#define D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL ( 0xffffffff )")]
        public const uint D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL = (0xffffffff);

        [NativeTypeName("#define D3D11_KEEP_UNORDERED_ACCESS_VIEWS ( 0xffffffff )")]
        public const uint D3D11_KEEP_UNORDERED_ACCESS_VIEWS = (0xffffffff);

        [NativeTypeName("#define D3D11_LINEAR_GAMMA ( 1.0f )")]
        public const float D3D11_LINEAR_GAMMA = (1.0f);

        [NativeTypeName("#define D3D11_MAJOR_VERSION ( 11 )")]
        public const int D3D11_MAJOR_VERSION = (11);

        [NativeTypeName("#define D3D11_MAX_BORDER_COLOR_COMPONENT ( 1.0f )")]
        public const float D3D11_MAX_BORDER_COLOR_COMPONENT = (1.0f);

        [NativeTypeName("#define D3D11_MAX_DEPTH ( 1.0f )")]
        public const float D3D11_MAX_DEPTH = (1.0f);

        [NativeTypeName("#define D3D11_MAX_MAXANISOTROPY ( 16 )")]
        public const int D3D11_MAX_MAXANISOTROPY = (16);

        [NativeTypeName("#define D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT ( 32 )")]
        public const int D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT = (32);

        [NativeTypeName("#define D3D11_MAX_POSITION_VALUE ( 3.402823466e+34f )")]
        public const float D3D11_MAX_POSITION_VALUE = (3.402823466e+34f);

        [NativeTypeName("#define D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP ( 17 )")]
        public const int D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP = (17);

        [NativeTypeName("#define D3D11_MINOR_VERSION ( 0 )")]
        public const int D3D11_MINOR_VERSION = (0);

        [NativeTypeName("#define D3D11_MIN_BORDER_COLOR_COMPONENT ( 0.0f )")]
        public const float D3D11_MIN_BORDER_COLOR_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D11_MIN_DEPTH ( 0.0f )")]
        public const float D3D11_MIN_DEPTH = (0.0f);

        [NativeTypeName("#define D3D11_MIN_MAXANISOTROPY ( 0 )")]
        public const int D3D11_MIN_MAXANISOTROPY = (0);

        [NativeTypeName("#define D3D11_MIP_LOD_BIAS_MAX ( 15.99f )")]
        public const float D3D11_MIP_LOD_BIAS_MAX = (15.99f);

        [NativeTypeName("#define D3D11_MIP_LOD_BIAS_MIN ( -16.0f )")]
        public const float D3D11_MIP_LOD_BIAS_MIN = (-16.0f);

        [NativeTypeName("#define D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D11_MIP_LOD_RANGE_BIT_COUNT ( 8 )")]
        public const int D3D11_MIP_LOD_RANGE_BIT_COUNT = (8);

        [NativeTypeName("#define D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH ( 1.4f )")]
        public const float D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = (1.4f);

        [NativeTypeName("#define D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT ( 0 )")]
        public const int D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = (0);

        [NativeTypeName("#define D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 15 )")]
        public const int D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT = (15);

        [NativeTypeName("#define D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
        public const int D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = (16);

        [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_PS_CS_UAV_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_COUNT ( 8 )")]
        public const int D3D11_PS_CS_UAV_REGISTER_COUNT = (8);

        [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_READS_PER_INST ( 1 )")]
        public const int D3D11_PS_CS_UAV_REGISTER_READS_PER_INST = (1);

        [NativeTypeName("#define D3D11_PS_CS_UAV_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_PS_CS_UAV_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_PS_FRONTFACING_DEFAULT_VALUE ( 0xffffffff )")]
        public const uint D3D11_PS_FRONTFACING_DEFAULT_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D11_PS_FRONTFACING_FALSE_VALUE ( 0 )")]
        public const int D3D11_PS_FRONTFACING_FALSE_VALUE = (0);

        [NativeTypeName("#define D3D11_PS_FRONTFACING_TRUE_VALUE ( 0xffffffff )")]
        public const uint D3D11_PS_FRONTFACING_TRUE_VALUE = (0xffffffff);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_PS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_PS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_PS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_PS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_PS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.0f )")]
        public const float D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.0f);

        [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT ( 1 )")]
        public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS ( 1 )")]
        public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS = (1);

        [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_OUTPUT_MASK_REGISTER_COUNT ( 1 )")]
        public const int D3D11_PS_OUTPUT_MASK_REGISTER_COUNT = (1);

        [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_PS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_PS_OUTPUT_REGISTER_COUNT ( 8 )")]
        public const int D3D11_PS_OUTPUT_REGISTER_COUNT = (8);

        [NativeTypeName("#define D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.5f )")]
        public const float D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.5f);

        [NativeTypeName("#define D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT ( 16 )")]
        public const int D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT = (16);

        [NativeTypeName("#define D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP ( 27 )")]
        public const int D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = (27);

        [NativeTypeName("#define D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
        public const int D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

        [NativeTypeName("#define D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 32 )")]
        public const int D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (32);

        [NativeTypeName("#define D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP ( 32 )")]
        public const int D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = (32);

        [NativeTypeName("#define D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION ( 16384 )")]
        public const int D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = (16384);

        [NativeTypeName("#define D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT ( 1024 )")]
        public const int D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = (1024);

        [NativeTypeName("#define D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
        public const int D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

        [NativeTypeName("#define D3D11_REQ_MAXANISOTROPY ( 16 )")]
        public const int D3D11_REQ_MAXANISOTROPY = (16);

        [NativeTypeName("#define D3D11_REQ_MIP_LEVELS ( 15 )")]
        public const int D3D11_REQ_MIP_LEVELS = (15);

        [NativeTypeName("#define D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES ( 2048 )")]
        public const int D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = (2048);

        [NativeTypeName("#define D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH ( 16384 )")]
        public const int D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = (16384);

        [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM ( 128 )")]
        public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM = (128);

        [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM ( 0.25f )")]
        public const float D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM = (0.25f);

        [NativeTypeName("#define D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM ( 2048 )")]
        public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM = (2048);

        [NativeTypeName("#define D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP ( 20 )")]
        public const int D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP = (20);

        [NativeTypeName("#define D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
        public const int D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE = (4096);

        [NativeTypeName("#define D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION ( 2048 )")]
        public const int D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = (2048);

        [NativeTypeName("#define D3D11_REQ_TEXTURE1D_U_DIMENSION ( 16384 )")]
        public const int D3D11_REQ_TEXTURE1D_U_DIMENSION = (16384);

        [NativeTypeName("#define D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION ( 2048 )")]
        public const int D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = (2048);

        [NativeTypeName("#define D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 16384 )")]
        public const int D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION = (16384);

        [NativeTypeName("#define D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
        public const int D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = (2048);

        [NativeTypeName("#define D3D11_REQ_TEXTURECUBE_DIMENSION ( 16384 )")]
        public const int D3D11_REQ_TEXTURECUBE_DIMENSION = (16384);

        [NativeTypeName("#define D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL ( 0 )")]
        public const int D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = (0);

        [NativeTypeName("#define D3D11_SHADER_MAJOR_VERSION ( 5 )")]
        public const int D3D11_SHADER_MAJOR_VERSION = (5);

        [NativeTypeName("#define D3D11_SHADER_MAX_INSTANCES ( 65535 )")]
        public const int D3D11_SHADER_MAX_INSTANCES = (65535);

        [NativeTypeName("#define D3D11_SHADER_MAX_INTERFACES ( 253 )")]
        public const int D3D11_SHADER_MAX_INTERFACES = (253);

        [NativeTypeName("#define D3D11_SHADER_MAX_INTERFACE_CALL_SITES ( 4096 )")]
        public const int D3D11_SHADER_MAX_INTERFACE_CALL_SITES = (4096);

        [NativeTypeName("#define D3D11_SHADER_MAX_TYPES ( 65535 )")]
        public const int D3D11_SHADER_MAX_TYPES = (65535);

        [NativeTypeName("#define D3D11_SHADER_MINOR_VERSION ( 0 )")]
        public const int D3D11_SHADER_MINOR_VERSION = (0);

        [NativeTypeName("#define D3D11_SHIFT_INSTRUCTION_PAD_VALUE ( 0 )")]
        public const int D3D11_SHIFT_INSTRUCTION_PAD_VALUE = (0);

        [NativeTypeName("#define D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT ( 5 )")]
        public const int D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = (5);

        [NativeTypeName("#define D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ( 8 )")]
        public const int D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT = (8);

        [NativeTypeName("#define D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
        public const int D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);

        [NativeTypeName("#define D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 512 )")]
        public const int D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (512);

        [NativeTypeName("#define D3D11_SO_BUFFER_SLOT_COUNT ( 4 )")]
        public const int D3D11_SO_BUFFER_SLOT_COUNT = (4);

        [NativeTypeName("#define D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP ( 0xffffffff )")]
        public const uint D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP = (0xffffffff);

        [NativeTypeName("#define D3D11_SO_NO_RASTERIZED_STREAM ( 0xffffffff )")]
        public const uint D3D11_SO_NO_RASTERIZED_STREAM = (0xffffffff);

        [NativeTypeName("#define D3D11_SO_OUTPUT_COMPONENT_COUNT ( 128 )")]
        public const int D3D11_SO_OUTPUT_COMPONENT_COUNT = (128);

        [NativeTypeName("#define D3D11_SO_STREAM_COUNT ( 4 )")]
        public const int D3D11_SO_STREAM_COUNT = (4);

        [NativeTypeName("#define D3D11_SPEC_DATE_DAY ( 16 )")]
        public const int D3D11_SPEC_DATE_DAY = (16);

        [NativeTypeName("#define D3D11_SPEC_DATE_MONTH ( 05 )")]
        public const int D3D11_SPEC_DATE_MONTH = (05);

        [NativeTypeName("#define D3D11_SPEC_DATE_YEAR ( 2011 )")]
        public const int D3D11_SPEC_DATE_YEAR = (2011);

        [NativeTypeName("#define D3D11_SPEC_VERSION ( 1.07 )")]
        public const double D3D11_SPEC_VERSION = (1.07);

        [NativeTypeName("#define D3D11_SRGB_GAMMA ( 2.2f )")]
        public const float D3D11_SRGB_GAMMA = (2.2f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 ( 12.92f )")]
        public const float D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 = (12.92f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 ( 1.055f )")]
        public const float D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 = (1.055f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_EXPONENT ( 2.4f )")]
        public const float D3D11_SRGB_TO_FLOAT_EXPONENT = (2.4f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_OFFSET ( 0.055f )")]
        public const float D3D11_SRGB_TO_FLOAT_OFFSET = (0.055f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_THRESHOLD ( 0.04045f )")]
        public const float D3D11_SRGB_TO_FLOAT_THRESHOLD = (0.04045f);

        [NativeTypeName("#define D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP ( 0.5f )")]
        public const float D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = (0.5f);

        [NativeTypeName("#define D3D11_STANDARD_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_STANDARD_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED ( 64 )")]
        public const int D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = (64);

        [NativeTypeName("#define D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE ( 4 )")]
        public const int D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = (4);

        [NativeTypeName("#define D3D11_STANDARD_PIXEL_COMPONENT_COUNT ( 128 )")]
        public const int D3D11_STANDARD_PIXEL_COMPONENT_COUNT = (128);

        [NativeTypeName("#define D3D11_STANDARD_PIXEL_ELEMENT_COUNT ( 32 )")]
        public const int D3D11_STANDARD_PIXEL_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D11_STANDARD_VECTOR_SIZE ( 4 )")]
        public const int D3D11_STANDARD_VECTOR_SIZE = (4);

        [NativeTypeName("#define D3D11_STANDARD_VERTEX_ELEMENT_COUNT ( 32 )")]
        public const int D3D11_STANDARD_VERTEX_ELEMENT_COUNT = (32);

        [NativeTypeName("#define D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT ( 64 )")]
        public const int D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = (64);

        [NativeTypeName("#define D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
        public const int D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT = (8);

        [NativeTypeName("#define D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR ( 63 )")]
        public const int D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR = (63);

        [NativeTypeName("#define D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR ( 64 )")]
        public const int D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR = (64);

        [NativeTypeName("#define D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR ( 2 )")]
        public const int D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR = (2);

        [NativeTypeName("#define D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 1 )")]
        public const int D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR = (1);

        [NativeTypeName("#define D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR ( 1 )")]
        public const int D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR = (1);

        [NativeTypeName("#define D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
        public const int D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT = (16);

        [NativeTypeName("#define D3D11_UNBOUND_MEMORY_ACCESS_RESULT ( 0 )")]
        public const int D3D11_UNBOUND_MEMORY_ACCESS_RESULT = (0);

        [NativeTypeName("#define D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX ( 15 )")]
        public const int D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = (15);

        [NativeTypeName("#define D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ( 16 )")]
        public const int D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = (16);

        [NativeTypeName("#define D3D11_VIEWPORT_BOUNDS_MAX ( 32767 )")]
        public const int D3D11_VIEWPORT_BOUNDS_MAX = (32767);

        [NativeTypeName("#define D3D11_VIEWPORT_BOUNDS_MIN ( -32768 )")]
        public const int D3D11_VIEWPORT_BOUNDS_MIN = (-32768);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_VS_INPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_VS_INPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
        public const int D3D11_VS_INPUT_REGISTER_READS_PER_INST = (2);

        [NativeTypeName("#define D3D11_VS_INPUT_REGISTER_READ_PORTS ( 1 )")]
        public const int D3D11_VS_INPUT_REGISTER_READ_PORTS = (1);

        [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
        public const int D3D11_VS_OUTPUT_REGISTER_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
        public const int D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

        [NativeTypeName("#define D3D11_VS_OUTPUT_REGISTER_COUNT ( 32 )")]
        public const int D3D11_VS_OUTPUT_REGISTER_COUNT = (32);

        [NativeTypeName("#define D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT ( 10 )")]
        public const int D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = (10);

        [NativeTypeName("#define D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 25 )")]
        public const int D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (25);

        [NativeTypeName("#define D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP ( 25 )")]
        public const int D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = (25);

        [NativeTypeName("#define D3D11_1_UAV_SLOT_COUNT ( 64 )")]
        public const int D3D11_1_UAV_SLOT_COUNT = (64);

        [NativeTypeName("#define D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES ( 65536 )")]
        public const int D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES = (65536);

        [NativeTypeName("#define D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS ( 4 )")]
        public const int D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS = (4);

        [NativeTypeName("#define D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT ( 256 )")]
        public const int D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT = (256);

        [NativeTypeName("#define _FACD3D11 ( 0x87c )")]
        public const int _FACD3D11 = (0x87c);

        [NativeTypeName("#define _FACD3D11DEBUG ( ( _FACD3D11 + 1 )  )")]
        public const int _FACD3D11DEBUG = (((0x87c) + 1));

        [NativeTypeName("#define D3D11_APPEND_ALIGNED_ELEMENT ( 0xffffffff )")]
        public const uint D3D11_APPEND_ALIGNED_ELEMENT = (0xffffffff);

        [NativeTypeName("#define D3D11_FILTER_REDUCTION_TYPE_MASK ( 0x3 )")]
        public const int D3D11_FILTER_REDUCTION_TYPE_MASK = (0x3);

        [NativeTypeName("#define D3D11_FILTER_REDUCTION_TYPE_SHIFT ( 7 )")]
        public const int D3D11_FILTER_REDUCTION_TYPE_SHIFT = (7);

        [NativeTypeName("#define D3D11_FILTER_TYPE_MASK ( 0x3 )")]
        public const int D3D11_FILTER_TYPE_MASK = (0x3);

        [NativeTypeName("#define D3D11_MIN_FILTER_SHIFT ( 4 )")]
        public const int D3D11_MIN_FILTER_SHIFT = (4);

        [NativeTypeName("#define D3D11_MAG_FILTER_SHIFT ( 2 )")]
        public const int D3D11_MAG_FILTER_SHIFT = (2);

        [NativeTypeName("#define D3D11_MIP_FILTER_SHIFT ( 0 )")]
        public const int D3D11_MIP_FILTER_SHIFT = (0);

        [NativeTypeName("#define D3D11_COMPARISON_FILTERING_BIT ( 0x80 )")]
        public const int D3D11_COMPARISON_FILTERING_BIT = (0x80);

        [NativeTypeName("#define D3D11_ANISOTROPIC_FILTERING_BIT ( 0x40 )")]
        public const int D3D11_ANISOTROPIC_FILTERING_BIT = (0x40);

        [NativeTypeName("#define D3D11_SDK_VERSION ( 7 )")]
        public const int D3D11_SDK_VERSION = (7);

        public static readonly Guid IID_ID3D10Blob = new Guid(0x8BA5FB08, 0x5195, 0x40E2, 0xAC, 0x58, 0x0D, 0x98, 0x9C, 0x3A, 0x01, 0x02);

        public static readonly Guid IID_ID3DDestructionNotifier = new Guid(0xA06EB39A, 0x50DA, 0x425B, 0x8C, 0x31, 0x4E, 0xEC, 0xD6, 0xC2, 0x70, 0xF3);

        public static readonly Guid IID_ID3D11DeviceChild = new Guid(0x1841E5C8, 0x16B0, 0x489B, 0xBC, 0xC8, 0x44, 0xCF, 0xB0, 0xD5, 0xDE, 0xAE);

        public static readonly Guid IID_ID3D11DepthStencilState = new Guid(0x03823EFB, 0x8D8F, 0x4E1C, 0x9A, 0xA2, 0xF6, 0x4B, 0xB2, 0xCB, 0xFD, 0xF1);

        public static readonly Guid IID_ID3D11BlendState = new Guid(0x75B68FAA, 0x347D, 0x4159, 0x8F, 0x45, 0xA0, 0x64, 0x0F, 0x01, 0xCD, 0x9A);

        public static readonly Guid IID_ID3D11RasterizerState = new Guid(0x9BB4AB81, 0xAB1A, 0x4D8F, 0xB5, 0x06, 0xFC, 0x04, 0x20, 0x0B, 0x6E, 0xE7);

        public static readonly Guid IID_ID3D11Resource = new Guid(0xDC8E63F3, 0xD12B, 0x4952, 0xB4, 0x7B, 0x5E, 0x45, 0x02, 0x6A, 0x86, 0x2D);

        public static readonly Guid IID_ID3D11Buffer = new Guid(0x48570B85, 0xD1EE, 0x4FCD, 0xA2, 0x50, 0xEB, 0x35, 0x07, 0x22, 0xB0, 0x37);

        public static readonly Guid IID_ID3D11Texture1D = new Guid(0xF8FB5C27, 0xC6B3, 0x4F75, 0xA4, 0xC8, 0x43, 0x9A, 0xF2, 0xEF, 0x56, 0x4C);

        public static readonly Guid IID_ID3D11Texture2D = new Guid(0x6F15AAF2, 0xD208, 0x4E89, 0x9A, 0xB4, 0x48, 0x95, 0x35, 0xD3, 0x4F, 0x9C);

        public static readonly Guid IID_ID3D11Texture3D = new Guid(0x037E866E, 0xF56D, 0x4357, 0xA8, 0xAF, 0x9D, 0xAB, 0xBE, 0x6E, 0x25, 0x0E);

        public static readonly Guid IID_ID3D11View = new Guid(0x839D1216, 0xBB2E, 0x412B, 0xB7, 0xF4, 0xA9, 0xDB, 0xEB, 0xE0, 0x8E, 0xD1);

        public static readonly Guid IID_ID3D11ShaderResourceView = new Guid(0xB0E06FE0, 0x8192, 0x4E1A, 0xB1, 0xCA, 0x36, 0xD7, 0x41, 0x47, 0x10, 0xB2);

        public static readonly Guid IID_ID3D11RenderTargetView = new Guid(0xDFDBA067, 0x0B8D, 0x4865, 0x87, 0x5B, 0xD7, 0xB4, 0x51, 0x6C, 0xC1, 0x64);

        public static readonly Guid IID_ID3D11DepthStencilView = new Guid(0x9FDAC92A, 0x1876, 0x48C3, 0xAF, 0xAD, 0x25, 0xB9, 0x4F, 0x84, 0xA9, 0xB6);

        public static readonly Guid IID_ID3D11UnorderedAccessView = new Guid(0x28ACF509, 0x7F5C, 0x48F6, 0x86, 0x11, 0xF3, 0x16, 0x01, 0x0A, 0x63, 0x80);

        public static readonly Guid IID_ID3D11VertexShader = new Guid(0x3B301D64, 0xD678, 0x4289, 0x88, 0x97, 0x22, 0xF8, 0x92, 0x8B, 0x72, 0xF3);

        public static readonly Guid IID_ID3D11HullShader = new Guid(0x8E5C6061, 0x628A, 0x4C8E, 0x82, 0x64, 0xBB, 0xE4, 0x5C, 0xB3, 0xD5, 0xDD);

        public static readonly Guid IID_ID3D11DomainShader = new Guid(0xF582C508, 0x0F36, 0x490C, 0x99, 0x77, 0x31, 0xEE, 0xCE, 0x26, 0x8C, 0xFA);

        public static readonly Guid IID_ID3D11GeometryShader = new Guid(0x38325B96, 0xEFFB, 0x4022, 0xBA, 0x02, 0x2E, 0x79, 0x5B, 0x70, 0x27, 0x5C);

        public static readonly Guid IID_ID3D11PixelShader = new Guid(0xEA82E40D, 0x51DC, 0x4F33, 0x93, 0xD4, 0xDB, 0x7C, 0x91, 0x25, 0xAE, 0x8C);

        public static readonly Guid IID_ID3D11ComputeShader = new Guid(0x4F5B196E, 0xC2BD, 0x495E, 0xBD, 0x01, 0x1F, 0xDE, 0xD3, 0x8E, 0x49, 0x69);

        public static readonly Guid IID_ID3D11InputLayout = new Guid(0xE4819DDC, 0x4CF0, 0x4025, 0xBD, 0x26, 0x5D, 0xE8, 0x2A, 0x3E, 0x07, 0xB7);

        public static readonly Guid IID_ID3D11SamplerState = new Guid(0xDA6FEA51, 0x564C, 0x4487, 0x98, 0x10, 0xF0, 0xD0, 0xF9, 0xB4, 0xE3, 0xA5);

        public static readonly Guid IID_ID3D11Asynchronous = new Guid(0x4B35D0CD, 0x1E15, 0x4258, 0x9C, 0x98, 0x1B, 0x13, 0x33, 0xF6, 0xDD, 0x3B);

        public static readonly Guid IID_ID3D11Query = new Guid(0xD6C00747, 0x87B7, 0x425E, 0xB8, 0x4D, 0x44, 0xD1, 0x08, 0x56, 0x0A, 0xFD);

        public static readonly Guid IID_ID3D11Predicate = new Guid(0x9EB576DD, 0x9F77, 0x4D86, 0x81, 0xAA, 0x8B, 0xAB, 0x5F, 0xE4, 0x90, 0xE2);

        public static readonly Guid IID_ID3D11Counter = new Guid(0x6E8C49FB, 0xA371, 0x4770, 0xB4, 0x40, 0x29, 0x08, 0x60, 0x22, 0xB7, 0x41);

        public static readonly Guid IID_ID3D11ClassInstance = new Guid(0xA6CD7FAA, 0xB0B7, 0x4A2F, 0x94, 0x36, 0x86, 0x62, 0xA6, 0x57, 0x97, 0xCB);

        public static readonly Guid IID_ID3D11ClassLinkage = new Guid(0xDDF57CBA, 0x9543, 0x46E4, 0xA1, 0x2B, 0xF2, 0x07, 0xA0, 0xFE, 0x7F, 0xED);

        public static readonly Guid IID_ID3D11CommandList = new Guid(0xA24BC4D1, 0x769E, 0x43F7, 0x80, 0x13, 0x98, 0xFF, 0x56, 0x6C, 0x18, 0xE2);

        public static readonly Guid IID_ID3D11DeviceContext = new Guid(0xC0BFA96C, 0xE089, 0x44FB, 0x8E, 0xAF, 0x26, 0xF8, 0x79, 0x61, 0x90, 0xDA);

        public static readonly Guid IID_ID3D11VideoDecoder = new Guid(0x3C9C5B51, 0x995D, 0x48D1, 0x9B, 0x8D, 0xFA, 0x5C, 0xAE, 0xDE, 0xD6, 0x5C);

        public static readonly Guid IID_ID3D11VideoProcessorEnumerator = new Guid(0x31627037, 0x53AB, 0x4200, 0x90, 0x61, 0x05, 0xFA, 0xA9, 0xAB, 0x45, 0xF9);

        public static readonly Guid IID_ID3D11VideoProcessor = new Guid(0x1D7B0652, 0x185F, 0x41C6, 0x85, 0xCE, 0x0C, 0x5B, 0xE3, 0xD4, 0xAE, 0x6C);

        public static readonly Guid IID_ID3D11AuthenticatedChannel = new Guid(0x3015A308, 0xDCBD, 0x47AA, 0xA7, 0x47, 0x19, 0x24, 0x86, 0xD1, 0x4D, 0x4A);

        public static readonly Guid IID_ID3D11CryptoSession = new Guid(0x9B32F9AD, 0xBDCC, 0x40A6, 0xA3, 0x9D, 0xD5, 0xC8, 0x65, 0x84, 0x57, 0x20);

        public static readonly Guid IID_ID3D11VideoDecoderOutputView = new Guid(0xC2931AEA, 0x2A85, 0x4F20, 0x86, 0x0F, 0xFB, 0xA1, 0xFD, 0x25, 0x6E, 0x18);

        public static readonly Guid IID_ID3D11VideoProcessorInputView = new Guid(0x11EC5A5F, 0x51DC, 0x4945, 0xAB, 0x34, 0x6E, 0x8C, 0x21, 0x30, 0x0E, 0xA5);

        public static readonly Guid IID_ID3D11VideoProcessorOutputView = new Guid(0xA048285E, 0x25A9, 0x4527, 0xBD, 0x93, 0xD6, 0x8B, 0x68, 0xC4, 0x42, 0x54);

        public static readonly Guid IID_ID3D11VideoContext = new Guid(0x61F21C45, 0x3C0E, 0x4A74, 0x9C, 0xEA, 0x67, 0x10, 0x0D, 0x9A, 0xD5, 0xE4);

        public static readonly Guid IID_ID3D11VideoDevice = new Guid(0x10EC4D5B, 0x975A, 0x4689, 0xB9, 0xE4, 0xD0, 0xAA, 0xC3, 0x0F, 0xE3, 0x33);

        public static readonly Guid IID_ID3D11Device = new Guid(0xDB6F6DDB, 0xAC77, 0x4E88, 0x82, 0x53, 0x81, 0x9D, 0xF9, 0xBB, 0xF1, 0x40);
    }
}

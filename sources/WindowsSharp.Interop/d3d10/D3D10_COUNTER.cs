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
    /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER"]/*' />
    public enum D3D10_COUNTER
    {
        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_GPU_IDLE"]/*' />
        D3D10_COUNTER_GPU_IDLE = 0,

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_VERTEX_PROCESSING"]/*' />
        D3D10_COUNTER_VERTEX_PROCESSING = (D3D10_COUNTER_GPU_IDLE + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_GEOMETRY_PROCESSING"]/*' />
        D3D10_COUNTER_GEOMETRY_PROCESSING = (D3D10_COUNTER_VERTEX_PROCESSING + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_PIXEL_PROCESSING"]/*' />
        D3D10_COUNTER_PIXEL_PROCESSING = (D3D10_COUNTER_GEOMETRY_PROCESSING + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_OTHER_GPU_PROCESSING"]/*' />
        D3D10_COUNTER_OTHER_GPU_PROCESSING = (D3D10_COUNTER_PIXEL_PROCESSING + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_HOST_ADAPTER_BANDWIDTH_UTILIZATION"]/*' />
        D3D10_COUNTER_HOST_ADAPTER_BANDWIDTH_UTILIZATION = (D3D10_COUNTER_OTHER_GPU_PROCESSING + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_LOCAL_VIDMEM_BANDWIDTH_UTILIZATION"]/*' />
        D3D10_COUNTER_LOCAL_VIDMEM_BANDWIDTH_UTILIZATION = (D3D10_COUNTER_HOST_ADAPTER_BANDWIDTH_UTILIZATION + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_VERTEX_THROUGHPUT_UTILIZATION"]/*' />
        D3D10_COUNTER_VERTEX_THROUGHPUT_UTILIZATION = (D3D10_COUNTER_LOCAL_VIDMEM_BANDWIDTH_UTILIZATION + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_TRIANGLE_SETUP_THROUGHPUT_UTILIZATION"]/*' />
        D3D10_COUNTER_TRIANGLE_SETUP_THROUGHPUT_UTILIZATION = (D3D10_COUNTER_VERTEX_THROUGHPUT_UTILIZATION + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_FILLRATE_THROUGHPUT_UTILIZATION"]/*' />
        D3D10_COUNTER_FILLRATE_THROUGHPUT_UTILIZATION = (D3D10_COUNTER_TRIANGLE_SETUP_THROUGHPUT_UTILIZATION + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_VS_MEMORY_LIMITED"]/*' />
        D3D10_COUNTER_VS_MEMORY_LIMITED = (D3D10_COUNTER_FILLRATE_THROUGHPUT_UTILIZATION + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_VS_COMPUTATION_LIMITED"]/*' />
        D3D10_COUNTER_VS_COMPUTATION_LIMITED = (D3D10_COUNTER_VS_MEMORY_LIMITED + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_GS_MEMORY_LIMITED"]/*' />
        D3D10_COUNTER_GS_MEMORY_LIMITED = (D3D10_COUNTER_VS_COMPUTATION_LIMITED + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_GS_COMPUTATION_LIMITED"]/*' />
        D3D10_COUNTER_GS_COMPUTATION_LIMITED = (D3D10_COUNTER_GS_MEMORY_LIMITED + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_PS_MEMORY_LIMITED"]/*' />
        D3D10_COUNTER_PS_MEMORY_LIMITED = (D3D10_COUNTER_GS_COMPUTATION_LIMITED + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_PS_COMPUTATION_LIMITED"]/*' />
        D3D10_COUNTER_PS_COMPUTATION_LIMITED = (D3D10_COUNTER_PS_MEMORY_LIMITED + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_POST_TRANSFORM_CACHE_HIT_RATE"]/*' />
        D3D10_COUNTER_POST_TRANSFORM_CACHE_HIT_RATE = (D3D10_COUNTER_PS_COMPUTATION_LIMITED + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_TEXTURE_CACHE_HIT_RATE"]/*' />
        D3D10_COUNTER_TEXTURE_CACHE_HIT_RATE = (D3D10_COUNTER_POST_TRANSFORM_CACHE_HIT_RATE + 1),

        /// <include file='D3D10_COUNTER.xml' path='doc/member[@name="D3D10_COUNTER.D3D10_COUNTER_DEVICE_DEPENDENT_0"]/*' />
        D3D10_COUNTER_DEVICE_DEPENDENT_0 = 0x40000000,
    }
}

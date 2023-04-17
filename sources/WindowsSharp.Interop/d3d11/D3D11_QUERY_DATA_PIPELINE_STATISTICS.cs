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
    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS"]/*' />
    public partial struct D3D11_QUERY_DATA_PIPELINE_STATISTICS
    {
        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.IAVertices"]/*' />
        [NativeTypeName("UINT64")]
        public ulong IAVertices;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.IAPrimitives"]/*' />
        [NativeTypeName("UINT64")]
        public ulong IAPrimitives;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.VSInvocations"]/*' />
        [NativeTypeName("UINT64")]
        public ulong VSInvocations;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.GSInvocations"]/*' />
        [NativeTypeName("UINT64")]
        public ulong GSInvocations;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.GSPrimitives"]/*' />
        [NativeTypeName("UINT64")]
        public ulong GSPrimitives;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.CInvocations"]/*' />
        [NativeTypeName("UINT64")]
        public ulong CInvocations;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.CPrimitives"]/*' />
        [NativeTypeName("UINT64")]
        public ulong CPrimitives;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.PSInvocations"]/*' />
        [NativeTypeName("UINT64")]
        public ulong PSInvocations;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.HSInvocations"]/*' />
        [NativeTypeName("UINT64")]
        public ulong HSInvocations;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.DSInvocations"]/*' />
        [NativeTypeName("UINT64")]
        public ulong DSInvocations;

        /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.CSInvocations"]/*' />
        [NativeTypeName("UINT64")]
        public ulong CSInvocations;
    }
}

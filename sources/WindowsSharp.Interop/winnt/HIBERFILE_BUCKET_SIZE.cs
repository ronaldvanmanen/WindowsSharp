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
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE"]/*' />
    public enum HIBERFILE_BUCKET_SIZE
    {
        /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket1GB"]/*' />
        HiberFileBucket1GB = 0,

        /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket2GB"]/*' />
        HiberFileBucket2GB,

        /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket4GB"]/*' />
        HiberFileBucket4GB,

        /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket8GB"]/*' />
        HiberFileBucket8GB,

        /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket16GB"]/*' />
        HiberFileBucket16GB,

        /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket32GB"]/*' />
        HiberFileBucket32GB,

        /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucketUnlimited"]/*' />
        HiberFileBucketUnlimited,

        /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucketMax"]/*' />
        HiberFileBucketMax,
    }
}

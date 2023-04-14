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
    /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines"]/*' />
    public enum ReplacesCorHdrNumericDefines
    {
        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_ILONLY"]/*' />
        COMIMAGE_FLAGS_ILONLY = 0x00000001,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_32BITREQUIRED"]/*' />
        COMIMAGE_FLAGS_32BITREQUIRED = 0x00000002,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_IL_LIBRARY"]/*' />
        COMIMAGE_FLAGS_IL_LIBRARY = 0x00000004,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_STRONGNAMESIGNED"]/*' />
        COMIMAGE_FLAGS_STRONGNAMESIGNED = 0x00000008,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_NATIVE_ENTRYPOINT"]/*' />
        COMIMAGE_FLAGS_NATIVE_ENTRYPOINT = 0x00000010,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_TRACKDEBUGDATA"]/*' />
        COMIMAGE_FLAGS_TRACKDEBUGDATA = 0x00010000,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_32BITPREFERRED"]/*' />
        COMIMAGE_FLAGS_32BITPREFERRED = 0x00020000,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VERSION_MAJOR_V2"]/*' />
        COR_VERSION_MAJOR_V2 = 2,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VERSION_MAJOR"]/*' />
        COR_VERSION_MAJOR = COR_VERSION_MAJOR_V2,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VERSION_MINOR"]/*' />
        COR_VERSION_MINOR = 5,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_DELETED_NAME_LENGTH"]/*' />
        COR_DELETED_NAME_LENGTH = 8,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLEGAP_NAME_LENGTH"]/*' />
        COR_VTABLEGAP_NAME_LENGTH = 8,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.NATIVE_TYPE_MAX_CB"]/*' />
        NATIVE_TYPE_MAX_CB = 1,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE"]/*' />
        COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE = 0xFF,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.IMAGE_COR_MIH_METHODRVA"]/*' />
        IMAGE_COR_MIH_METHODRVA = 0x01,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.IMAGE_COR_MIH_EHRVA"]/*' />
        IMAGE_COR_MIH_EHRVA = 0x02,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.IMAGE_COR_MIH_BASICBLOCK"]/*' />
        IMAGE_COR_MIH_BASICBLOCK = 0x08,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_32BIT"]/*' />
        COR_VTABLE_32BIT = 0x01,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_64BIT"]/*' />
        COR_VTABLE_64BIT = 0x02,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_FROM_UNMANAGED"]/*' />
        COR_VTABLE_FROM_UNMANAGED = 0x04,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN"]/*' />
        COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN = 0x08,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.COR_VTABLE_CALL_MOST_DERIVED"]/*' />
        COR_VTABLE_CALL_MOST_DERIVED = 0x10,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.IMAGE_COR_EATJ_THUNK_SIZE"]/*' />
        IMAGE_COR_EATJ_THUNK_SIZE = 32,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.MAX_CLASS_NAME"]/*' />
        MAX_CLASS_NAME = 1024,

        /// <include file='ReplacesCorHdrNumericDefines.xml' path='doc/member[@name="ReplacesCorHdrNumericDefines.MAX_PACKAGE_NAME"]/*' />
        MAX_PACKAGE_NAME = 1024,
    }
}

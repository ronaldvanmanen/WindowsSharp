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
    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE"]/*' />
    public enum D3D_SHADER_INPUT_TYPE
    {
        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_CBUFFER"]/*' />
        D3D_SIT_CBUFFER = 0,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_TBUFFER"]/*' />
        D3D_SIT_TBUFFER = (D3D_SIT_CBUFFER + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_TEXTURE"]/*' />
        D3D_SIT_TEXTURE = (D3D_SIT_TBUFFER + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_SAMPLER"]/*' />
        D3D_SIT_SAMPLER = (D3D_SIT_TEXTURE + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWTYPED"]/*' />
        D3D_SIT_UAV_RWTYPED = (D3D_SIT_SAMPLER + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_STRUCTURED"]/*' />
        D3D_SIT_STRUCTURED = (D3D_SIT_UAV_RWTYPED + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWSTRUCTURED"]/*' />
        D3D_SIT_UAV_RWSTRUCTURED = (D3D_SIT_STRUCTURED + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_BYTEADDRESS"]/*' />
        D3D_SIT_BYTEADDRESS = (D3D_SIT_UAV_RWSTRUCTURED + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWBYTEADDRESS"]/*' />
        D3D_SIT_UAV_RWBYTEADDRESS = (D3D_SIT_BYTEADDRESS + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_APPEND_STRUCTURED"]/*' />
        D3D_SIT_UAV_APPEND_STRUCTURED = (D3D_SIT_UAV_RWBYTEADDRESS + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_CONSUME_STRUCTURED"]/*' />
        D3D_SIT_UAV_CONSUME_STRUCTURED = (D3D_SIT_UAV_APPEND_STRUCTURED + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER"]/*' />
        D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER = (D3D_SIT_UAV_CONSUME_STRUCTURED + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_RTACCELERATIONSTRUCTURE"]/*' />
        D3D_SIT_RTACCELERATIONSTRUCTURE = (D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_FEEDBACKTEXTURE"]/*' />
        D3D_SIT_UAV_FEEDBACKTEXTURE = (D3D_SIT_RTACCELERATIONSTRUCTURE + 1),

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_CBUFFER"]/*' />
        D3D10_SIT_CBUFFER = D3D_SIT_CBUFFER,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_TBUFFER"]/*' />
        D3D10_SIT_TBUFFER = D3D_SIT_TBUFFER,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_TEXTURE"]/*' />
        D3D10_SIT_TEXTURE = D3D_SIT_TEXTURE,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_SAMPLER"]/*' />
        D3D10_SIT_SAMPLER = D3D_SIT_SAMPLER,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWTYPED"]/*' />
        D3D11_SIT_UAV_RWTYPED = D3D_SIT_UAV_RWTYPED,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_STRUCTURED"]/*' />
        D3D11_SIT_STRUCTURED = D3D_SIT_STRUCTURED,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWSTRUCTURED"]/*' />
        D3D11_SIT_UAV_RWSTRUCTURED = D3D_SIT_UAV_RWSTRUCTURED,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_BYTEADDRESS"]/*' />
        D3D11_SIT_BYTEADDRESS = D3D_SIT_BYTEADDRESS,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWBYTEADDRESS"]/*' />
        D3D11_SIT_UAV_RWBYTEADDRESS = D3D_SIT_UAV_RWBYTEADDRESS,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_APPEND_STRUCTURED"]/*' />
        D3D11_SIT_UAV_APPEND_STRUCTURED = D3D_SIT_UAV_APPEND_STRUCTURED,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_CONSUME_STRUCTURED"]/*' />
        D3D11_SIT_UAV_CONSUME_STRUCTURED = D3D_SIT_UAV_CONSUME_STRUCTURED,

        /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER"]/*' />
        D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER = D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER,
    }
}

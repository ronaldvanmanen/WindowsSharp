// WindowsSharp
//
// Copyright (C) 2021 Ronald van Manen <rvanmanen@gmail.com>
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
    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE"]/*' />
    public enum D3DSHADER_INSTRUCTION_OPCODE_TYPE
    {
        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_NOP"]/*' />
        D3DSIO_NOP = 0,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MOV"]/*' />
        D3DSIO_MOV,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ADD"]/*' />
        D3DSIO_ADD,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SUB"]/*' />
        D3DSIO_SUB,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MAD"]/*' />
        D3DSIO_MAD,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MUL"]/*' />
        D3DSIO_MUL,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_RCP"]/*' />
        D3DSIO_RCP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_RSQ"]/*' />
        D3DSIO_RSQ,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DP3"]/*' />
        D3DSIO_DP3,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DP4"]/*' />
        D3DSIO_DP4,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MIN"]/*' />
        D3DSIO_MIN,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MAX"]/*' />
        D3DSIO_MAX,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SLT"]/*' />
        D3DSIO_SLT,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SGE"]/*' />
        D3DSIO_SGE,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_EXP"]/*' />
        D3DSIO_EXP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LOG"]/*' />
        D3DSIO_LOG,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LIT"]/*' />
        D3DSIO_LIT,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DST"]/*' />
        D3DSIO_DST,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LRP"]/*' />
        D3DSIO_LRP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_FRC"]/*' />
        D3DSIO_FRC,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M4x4"]/*' />
        D3DSIO_M4x4,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M4x3"]/*' />
        D3DSIO_M4x3,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M3x4"]/*' />
        D3DSIO_M3x4,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M3x3"]/*' />
        D3DSIO_M3x3,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M3x2"]/*' />
        D3DSIO_M3x2,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CALL"]/*' />
        D3DSIO_CALL,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CALLNZ"]/*' />
        D3DSIO_CALLNZ,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LOOP"]/*' />
        D3DSIO_LOOP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_RET"]/*' />
        D3DSIO_RET,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ENDLOOP"]/*' />
        D3DSIO_ENDLOOP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LABEL"]/*' />
        D3DSIO_LABEL,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DCL"]/*' />
        D3DSIO_DCL,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_POW"]/*' />
        D3DSIO_POW,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CRS"]/*' />
        D3DSIO_CRS,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SGN"]/*' />
        D3DSIO_SGN,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ABS"]/*' />
        D3DSIO_ABS,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_NRM"]/*' />
        D3DSIO_NRM,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SINCOS"]/*' />
        D3DSIO_SINCOS,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_REP"]/*' />
        D3DSIO_REP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ENDREP"]/*' />
        D3DSIO_ENDREP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_IF"]/*' />
        D3DSIO_IF,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_IFC"]/*' />
        D3DSIO_IFC,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ELSE"]/*' />
        D3DSIO_ELSE,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ENDIF"]/*' />
        D3DSIO_ENDIF,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_BREAK"]/*' />
        D3DSIO_BREAK,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_BREAKC"]/*' />
        D3DSIO_BREAKC,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MOVA"]/*' />
        D3DSIO_MOVA,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DEFB"]/*' />
        D3DSIO_DEFB,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DEFI"]/*' />
        D3DSIO_DEFI,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXCOORD"]/*' />
        D3DSIO_TEXCOORD = 64,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXKILL"]/*' />
        D3DSIO_TEXKILL,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEX"]/*' />
        D3DSIO_TEX,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXBEM"]/*' />
        D3DSIO_TEXBEM,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXBEML"]/*' />
        D3DSIO_TEXBEML,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXREG2AR"]/*' />
        D3DSIO_TEXREG2AR,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXREG2GB"]/*' />
        D3DSIO_TEXREG2GB,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x2PAD"]/*' />
        D3DSIO_TEXM3x2PAD,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x2TEX"]/*' />
        D3DSIO_TEXM3x2TEX,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3PAD"]/*' />
        D3DSIO_TEXM3x3PAD,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3TEX"]/*' />
        D3DSIO_TEXM3x3TEX,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_RESERVED0"]/*' />
        D3DSIO_RESERVED0,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3SPEC"]/*' />
        D3DSIO_TEXM3x3SPEC,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3VSPEC"]/*' />
        D3DSIO_TEXM3x3VSPEC,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_EXPP"]/*' />
        D3DSIO_EXPP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LOGP"]/*' />
        D3DSIO_LOGP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CND"]/*' />
        D3DSIO_CND,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DEF"]/*' />
        D3DSIO_DEF,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXREG2RGB"]/*' />
        D3DSIO_TEXREG2RGB,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXDP3TEX"]/*' />
        D3DSIO_TEXDP3TEX,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x2DEPTH"]/*' />
        D3DSIO_TEXM3x2DEPTH,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXDP3"]/*' />
        D3DSIO_TEXDP3,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3"]/*' />
        D3DSIO_TEXM3x3,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXDEPTH"]/*' />
        D3DSIO_TEXDEPTH,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CMP"]/*' />
        D3DSIO_CMP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_BEM"]/*' />
        D3DSIO_BEM,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DP2ADD"]/*' />
        D3DSIO_DP2ADD,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DSX"]/*' />
        D3DSIO_DSX,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DSY"]/*' />
        D3DSIO_DSY,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXLDD"]/*' />
        D3DSIO_TEXLDD,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SETP"]/*' />
        D3DSIO_SETP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXLDL"]/*' />
        D3DSIO_TEXLDL,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_BREAKP"]/*' />
        D3DSIO_BREAKP,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_PHASE"]/*' />
        D3DSIO_PHASE = 0xFFFD,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_COMMENT"]/*' />
        D3DSIO_COMMENT = 0xFFFE,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_END"]/*' />
        D3DSIO_END = 0xFFFF,

        /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_FORCE_DWORD"]/*' />
        D3DSIO_FORCE_DWORD = 0x7fffffff,
    }
}

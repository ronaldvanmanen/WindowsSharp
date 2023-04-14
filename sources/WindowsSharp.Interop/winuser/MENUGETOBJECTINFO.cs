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
    /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO"]/*' />
    public unsafe partial struct MENUGETOBJECTINFO
    {
        /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.dwFlags"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.uPos"]/*' />
        public uint uPos;

        /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.hmenu"]/*' />
        [NativeTypeName("HMENU")]
        public HMENU__* hmenu;

        /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.riid"]/*' />
        [NativeTypeName("PVOID")]
        public void* riid;

        /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.pvObj"]/*' />
        [NativeTypeName("PVOID")]
        public void* pvObj;
    }
}

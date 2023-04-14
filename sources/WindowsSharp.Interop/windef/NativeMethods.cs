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
    public static unsafe partial class NativeMethods
    {
        [NativeTypeName("#define HFILE_ERROR ((HFILE)-1)")]
        public const int HFILE_ERROR = ((int)(-1));

        [NativeTypeName("#define APP_LOCAL_DEVICE_ID_SIZE 32")]
        public const int APP_LOCAL_DEVICE_ID_SIZE = 32;

        [NativeTypeName("#define DM_UPDATE 1")]
        public const int DM_UPDATE = 1;

        [NativeTypeName("#define DM_COPY 2")]
        public const int DM_COPY = 2;

        [NativeTypeName("#define DM_PROMPT 4")]
        public const int DM_PROMPT = 4;

        [NativeTypeName("#define DM_MODIFY 8")]
        public const int DM_MODIFY = 8;

        [NativeTypeName("#define DM_IN_BUFFER DM_MODIFY")]
        public const int DM_IN_BUFFER = 8;

        [NativeTypeName("#define DM_IN_PROMPT DM_PROMPT")]
        public const int DM_IN_PROMPT = 4;

        [NativeTypeName("#define DM_OUT_BUFFER DM_COPY")]
        public const int DM_OUT_BUFFER = 2;

        [NativeTypeName("#define DM_OUT_DEFAULT DM_UPDATE")]
        public const int DM_OUT_DEFAULT = 1;

        [NativeTypeName("#define DC_FIELDS 1")]
        public const int DC_FIELDS = 1;

        [NativeTypeName("#define DC_PAPERS 2")]
        public const int DC_PAPERS = 2;

        [NativeTypeName("#define DC_PAPERSIZE 3")]
        public const int DC_PAPERSIZE = 3;

        [NativeTypeName("#define DC_MINEXTENT 4")]
        public const int DC_MINEXTENT = 4;

        [NativeTypeName("#define DC_MAXEXTENT 5")]
        public const int DC_MAXEXTENT = 5;

        [NativeTypeName("#define DC_BINS 6")]
        public const int DC_BINS = 6;

        [NativeTypeName("#define DC_DUPLEX 7")]
        public const int DC_DUPLEX = 7;

        [NativeTypeName("#define DC_SIZE 8")]
        public const int DC_SIZE = 8;

        [NativeTypeName("#define DC_EXTRA 9")]
        public const int DC_EXTRA = 9;

        [NativeTypeName("#define DC_VERSION 10")]
        public const int DC_VERSION = 10;

        [NativeTypeName("#define DC_DRIVER 11")]
        public const int DC_DRIVER = 11;

        [NativeTypeName("#define DC_BINNAMES 12")]
        public const int DC_BINNAMES = 12;

        [NativeTypeName("#define DC_ENUMRESOLUTIONS 13")]
        public const int DC_ENUMRESOLUTIONS = 13;

        [NativeTypeName("#define DC_FILEDEPENDENCIES 14")]
        public const int DC_FILEDEPENDENCIES = 14;

        [NativeTypeName("#define DC_TRUETYPE 15")]
        public const int DC_TRUETYPE = 15;

        [NativeTypeName("#define DC_PAPERNAMES 16")]
        public const int DC_PAPERNAMES = 16;

        [NativeTypeName("#define DC_ORIENTATION 17")]
        public const int DC_ORIENTATION = 17;

        [NativeTypeName("#define DC_COPIES 18")]
        public const int DC_COPIES = 18;

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_UNAWARE ((DPI_AWARENESS_CONTEXT)-1)")]
        public static readonly DPI_AWARENESS_CONTEXT__* DPI_AWARENESS_CONTEXT_UNAWARE = unchecked((DPI_AWARENESS_CONTEXT__*)(-1));

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_SYSTEM_AWARE ((DPI_AWARENESS_CONTEXT)-2)")]
        public static readonly DPI_AWARENESS_CONTEXT__* DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = unchecked((DPI_AWARENESS_CONTEXT__*)(-2));

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE ((DPI_AWARENESS_CONTEXT)-3)")]
        public static readonly DPI_AWARENESS_CONTEXT__* DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = unchecked((DPI_AWARENESS_CONTEXT__*)(-3));

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 ((DPI_AWARENESS_CONTEXT)-4)")]
        public static readonly DPI_AWARENESS_CONTEXT__* DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 = unchecked((DPI_AWARENESS_CONTEXT__*)(-4));

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED ((DPI_AWARENESS_CONTEXT)-5)")]
        public static readonly DPI_AWARENESS_CONTEXT__* DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED = unchecked((DPI_AWARENESS_CONTEXT__*)(-5));
    }
}

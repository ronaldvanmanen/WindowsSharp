using System;

namespace D3D9Sharp
{
    [AttributeUsage(AttributeTargets.Struct)]
    public sealed class FlexibleVertexFormatAttribute : Attribute
    {
        public FlexibleVertexFormatAttribute(uint format)
        {
            Format = format;
        }

        public uint Format { get; }
    }
}

using System.Windows;
using DirectXSharp.Interop;

namespace WpfApp
{
    internal static class PointExtensions
    {
        public static POINT ToPOINT(this Point point)
        {
            return new POINT
            {
                x = (int)point.X,
                y = (int)point.Y
            };
        }
    }
}

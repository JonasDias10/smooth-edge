using System.Runtime.InteropServices;

namespace SplitScreen.WindowManagement
{

    [StructLayout(LayoutKind.Sequential)]
    internal struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    };
}

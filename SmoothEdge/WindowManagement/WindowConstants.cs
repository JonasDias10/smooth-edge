namespace SmoothEdge.WindowManagement
{
    internal static class WindowConstants
    {
        // GWL_STYLE constant
        public const int GWL_STYLE = -16;

        // Window styles
        public const int WS_BORDER = 0x00800000;
        public const int WS_DLGFRAME = 0x00400000;
        public const int WS_THICKFRAME = 0x00040000;
        public const int WS_CAPTION = WS_BORDER | WS_DLGFRAME;

        // SetWindowPos flags
        public const int SWP_NOSIZE = 0x0001;
        public const int SWP_NOMOVE = 0x0002;
        public const int SWP_NOZORDER = 0x0004;
        public const int SWP_FRAMECHANGED = 0x0020;
    }
}

using System.Text;

namespace SmoothEdge.WindowManagement
{
    internal class WindowManager
    {
        public static List<IntPtr> GetOpenWindows()
        {
            List<IntPtr> openWindows = [];
            WindowHelper.EnumWindows(delegate (IntPtr hWnd, IntPtr lParam)
            {
                if (WindowHelper.IsWindowVisible(hWnd))
                {
                    StringBuilder sb = new(256);
                    WindowHelper.GetWindowText(hWnd, sb, sb.Capacity);
                    if (sb.Length > 0)
                    {
                        openWindows.Add(hWnd);
                    }
                }
                return true;
            }, IntPtr.Zero);
            return openWindows;
        }

        public static List<string> GetOpenWindowTitles(List<IntPtr> windows)
        {
            List<string> titles = [];
            foreach (var window in windows)
            {
                StringBuilder sb = new StringBuilder(256);
                WindowHelper.GetWindowText(window, sb, sb.Capacity);
                titles.Add(sb.ToString());
            }
            return titles;
        }

        public static string GetWindowTitle(IntPtr hWnd)
        {
            StringBuilder sb = new(256);
            WindowHelper.GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        public static uint GetWindowProcessId(IntPtr hWnd)
        {
            WindowHelper.GetWindowThreadProcessId(hWnd, out uint processId);
            return processId;
        }

        public static void RemoveWindowBorder(IntPtr hWnd)
        {
            nint style = WindowHelper.GetWindowLong(hWnd, WindowHelper.GWL_STYLE);
            style &= ~WindowHelper.WS_CAPTION;
            WindowHelper.SetWindowLong(hWnd, WindowHelper.GWL_STYLE, style);
            WindowHelper.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, 
                WindowHelper.SWP_NOSIZE | WindowHelper.SWP_NOMOVE | WindowHelper.SWP_NOZORDER | WindowHelper.SWP_FRAMECHANGED);
        }
    }
}

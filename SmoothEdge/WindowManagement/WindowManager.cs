using System.Text;

namespace SmoothEdge.WindowManagement
{
    internal class WindowManager
    {

        public List<IntPtr> GetOpenWindows()
        {
            List<IntPtr> openWindows = new List<IntPtr>();
            WindowHelper.EnumWindows(delegate (IntPtr hWnd, IntPtr lParam)
            {
                if (WindowHelper.IsWindowVisible(hWnd))
                {
                    StringBuilder sb = new StringBuilder(256);
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

        public List<string> GetOpenWindowTitles(List<IntPtr> windows)
        {
            List<string> titles = new List<string>();
            foreach (var window in windows)
            {
                StringBuilder sb = new StringBuilder(256);
                WindowHelper.GetWindowText(window, sb, sb.Capacity);
                titles.Add(sb.ToString());
            }
            return titles;
        }

        public void ArrangeWindows(IntPtr window1, IntPtr window2, bool horizontal)
        {
            RECT rect;
            WindowHelper.GetWindowRect(WindowHelper.GetForegroundWindow(), out rect);
            int screenWidth = rect.Right - rect.Left;
            int screenHeight = rect.Bottom - rect.Top;

            if (horizontal)
            {
                WindowHelper.MoveWindow(window1, 0, 0, screenWidth / 2, screenHeight, true);
                WindowHelper.MoveWindow(window2, screenWidth / 2, 0, screenWidth / 2, screenHeight, true);
            } else
            {
                WindowHelper.MoveWindow(window1, 0, 0, screenWidth, screenHeight / 2, true);
                WindowHelper.MoveWindow(window2, 0, screenHeight / 2, screenWidth, screenHeight / 2, true);
            }

            RemoveWindowBorder(window1);
            RemoveWindowBorder(window2);

            WindowHelper.SetForegroundWindow(window1);
        }

        private void RemoveWindowBorder(IntPtr hWnd)
        {
            int style = WindowHelper.GetWindowLong(hWnd, WindowHelper.GWL_STYLE);
            style &= ~WindowHelper.WS_CAPTION;
            WindowHelper.SetWindowLong(hWnd, WindowHelper.GWL_STYLE, style);
            WindowHelper.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, WindowHelper.SWP_NOSIZE | WindowHelper.SWP_NOMOVE | WindowHelper.SWP_NOZORDER | WindowHelper.SWP_FRAMECHANGED);
        }
    }
}

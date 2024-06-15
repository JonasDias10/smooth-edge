using System.Text;

namespace SmoothEdge.WindowManagement
{
    /// <summary>
    /// Provides methods for interacting with windows and retrieving window information.
    /// </summary>
    internal class WindowManager
    {
        /// <summary>
        /// Retrieves a list of handles for all visible windows with a non-empty title.
        /// </summary>
        /// <returns>List of IntPtr handles to open windows.</returns>
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

        /// <summary>
        /// Retrieves the titles of windows corresponding to the given list of window handles.
        /// </summary>
        /// <param name="windows">List of IntPtr handles to windows.</param>
        /// <returns>List of window titles.</returns>
        public static List<string> GetOpenWindowTitles(List<IntPtr> windows)
        {
            List<string> titles = [];
            foreach (var window in windows)
            {
                StringBuilder sb = new(256);
                WindowHelper.GetWindowText(window, sb, sb.Capacity);
                titles.Add(sb.ToString());
            }
            return titles;
        }

        /// <summary>
        /// Retrieves the title of the specified window.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <returns>Title of the window.</returns>
        public static string GetWindowTitle(IntPtr hWnd)
        {
            StringBuilder sb = new(256);
            WindowHelper.GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        /// <summary>
        /// Retrieves the process identifier associated with the specified window.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <returns>Process identifier.</returns>
        public static uint GetWindowProcessId(IntPtr hWnd)
        {
            WindowHelper.GetWindowThreadProcessId(hWnd, out uint processId);
            return processId;
        }

        /// <summary>
        /// Removes the border (caption) from the specified window.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        public static void RemoveWindowBorder(IntPtr hWnd)
        {
            nint style = WindowHelper.GetWindowLong(hWnd, WindowConstants.GWL_STYLE);
            style &= ~WindowConstants.WS_CAPTION;
            WindowHelper.SetWindowLong(hWnd, WindowConstants.GWL_STYLE, style);
            WindowHelper.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0,
                WindowConstants.SWP_NOSIZE | WindowConstants.SWP_NOMOVE | WindowConstants.SWP_NOZORDER | WindowConstants.SWP_FRAMECHANGED);
        }
    }
}

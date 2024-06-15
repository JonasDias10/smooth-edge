using System.Runtime.InteropServices;
using System.Text;

namespace SmoothEdge.WindowManagement
{
    /// <summary>
    /// Helper class for window management operations using Win32 API.
    /// </summary>
    internal static class WindowHelper
    {
        /// <summary>
        /// Delegate for EnumWindows function callback.
        /// </summary>
        /// <param name="hWnd">Handle to a window.</param>
        /// <param name="lParam">Application-defined value given in EnumWindows.</param>
        /// <returns>True to continue enumerating, false to stop.</returns>
        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        /// <summary>
        /// Enumerates all top-level windows on the screen by passing the handle to each window, in turn, to an application-defined callback function.
        /// </summary>
        /// <param name="lpEnumFunc">A delegate to the callback function.</param>
        /// <param name="lParam">An application-defined value to be passed to the callback function.</param>
        /// <returns>True if the function succeeds, false if it fails.</returns>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        /// <summary>
        /// Determines the visibility state of the specified window.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <returns>True if the window is visible, false if it is not visible or an error occurred.</returns>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        /// <summary>
        /// Retrieves the text of the specified window's title bar (if it has one).
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="lpString">StringBuilder that receives the text.</param>
        /// <param name="nMaxCount">Maximum number of characters to copy to the buffer, including the null character.</param>
        /// <returns>The length of the copied string, in characters, not including the terminating null character.</returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// Changes an attribute of the specified window. The function also sets a 32-bit value at the specified offset into the extra window memory.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nIndex">Zero-based offset to the value to be set.</param>
        /// <param name="dwNewLong">New value.</param>
        /// <returns>Previous value of the specified offset.</returns>
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong32(IntPtr hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// Changes an attribute of the specified window. The function also sets a value at the specified offset into the extra window memory.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nIndex">Zero-based offset to the value to be set.</param>
        /// <param name="dwNewLong">New value.</param>
        /// <returns>Previous value of the specified offset.</returns>
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtr")]
        public static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        /// <summary>
        /// Retrieves information about the specified window. The function also retrieves a value at the specified offset into the extra window memory.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nIndex">Zero-based offset to the value to be retrieved.</param>
        /// <returns>Value at the specified offset.</returns>
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong32(IntPtr hWnd, int nIndex);

        /// <summary>
        /// Retrieves information about the specified window. The function also retrieves a value at the specified offset into the extra window memory.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nIndex">Zero-based offset to the value to be retrieved.</param>
        /// <returns>Value at the specified offset.</returns>
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetWindowLongPtr")]
        public static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

        /// <summary>
        /// Changes the size, position, and Z order of a child, pop-up, or top-level window.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="hWndInsertAfter">Handle to the window to precede the positioned window in the Z order.</param>
        /// <param name="X">New position of the left side of the window.</param>
        /// <param name="Y">New position of the top of the window.</param>
        /// <param name="cx">New width of the window.</param>
        /// <param name="cy">New height of the window.</param>
        /// <param name="uFlags">Combination of SWP_* flags.</param>
        /// <returns>True if the function succeeds, false if it fails.</returns>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        /// <summary>
        /// Retrieves the identifier of the thread that created the specified window and, optionally, the identifier of the process that created the window.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="lpdwProcessId">Receives the process identifier.</param>
        /// <returns>The identifier of the thread that created the window.</returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        /// <summary>
        /// Retrieves information about the specified window. The function also retrieves a value at the specified offset into the extra window memory.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nIndex">Zero-based offset to the value to be retrieved.</param>
        /// <returns>Value at the specified offset.</returns>
        public static IntPtr GetWindowLong(IntPtr hWnd, int nIndex)
        {
            return IntPtr.Size == 8
                ? GetWindowLongPtr64(hWnd, nIndex)
                : new IntPtr(GetWindowLong32(hWnd, nIndex));
        }

        /// <summary>
        /// Changes an attribute of the specified window. The function also sets a value at the specified offset into the extra window memory.
        /// </summary>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nIndex">Zero-based offset to the value to be set.</param>
        /// <param name="dwNewLong">New value.</param>
        /// <returns>Previous value of the specified offset.</returns>
        public static IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            return IntPtr.Size == 8
                ? SetWindowLongPtr64(hWnd, nIndex, dwNewLong)
                : new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
        }
    }
}

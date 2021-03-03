using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Advikit_Plays.Controller {
    [StructLayout(LayoutKind.Sequential)]
    public struct WinPoint {
        public int X;
        public int Y;

        public static explicit operator Point(WinPoint point) {
            return new Point(point.X, point.Y);
        }

        public static explicit operator WinPoint(Point point) {
            WinPoint pt = new WinPoint();
            pt.X = (int)point.X;
            pt.Y = (int)point.Y;
            return pt;
        }
    }
    class WinApi {
        #region API methods

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        public static extern bool ScreenToClient(IntPtr hWnd, ref WinPoint lpPoint);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }


        #endregion
    }
}

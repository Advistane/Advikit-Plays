using Interceptor;
using System;
using System.Diagnostics;
using System.Drawing;

namespace Advikit_Plays.Controller {
	class Controller {
        private Process target = null;
        private Input input;

        public Controller() {
            input = new Input
            {
                KeyboardFilterMode = KeyboardFilterMode.All
            };
            input.Load();
        }

        protected bool FindTarget(string processName) {
            Process[] processRunning = Process.GetProcesses();
            foreach (Process pr in processRunning) {
                if (pr.ProcessName == processName || pr.MainWindowTitle.Contains(processName)) {
                    target = pr;
                    WinApi.RECT rct = new WinApi.RECT();
                    WinApi.GetWindowRect(pr.MainWindowHandle, ref rct);
                    Console.WriteLine("Found: " + pr.MainWindowTitle + ". Left, Right: " + rct.Left.ToString() + ", " + rct.Right.ToString());
                    return true;
                }
            }
            return false;
        }

        protected void MoveMouse(int x, int y, bool bounded) {
            if (target == null) {
                return;
            }
            if (!bounded) {
                input.MoveMouseBy(x, y);
            } else {
                Point mouseLoc = new Point();
                WinApi.RECT gameLoc = new WinApi.RECT();
                WinApi.GetCursorPos(ref mouseLoc);
                WinApi.GetWindowRect(this.target.MainWindowHandle, ref gameLoc);

                int moveX = x, moveY = y;
                if (mouseLoc.X + moveX > gameLoc.Right) {
                    moveX = gameLoc.Right - mouseLoc.X - 5;
                } else if (mouseLoc.X + moveX < gameLoc.Left) {
                    moveX = gameLoc.Left - mouseLoc.X + 5;
                }

                if (mouseLoc.Y - moveY < gameLoc.Top) {
                    moveY = mouseLoc.Y - gameLoc.Top  - 20;
                } else if (mouseLoc.Y - moveY > gameLoc.Bottom) {
                    moveY = mouseLoc.Y - gameLoc.Bottom  + 5;
                }

                input.MoveMouseBy(moveX, moveY);
            }
        }

        protected void LeftClick() {
            if (target == null) {
                return;
            }
            input.SendLeftClick();
        }
    }
}

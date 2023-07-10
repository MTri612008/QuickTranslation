using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuicklyTranslate
{
    internal class HotKey
    {
        private static IntPtr _hookID = IntPtr.Zero;
        private const int WM_KEYDOWN = 0x0100;
        private const int WH_KEYBOARD_LL = 13;
        private static LowLevelKeyboardProc _proc = HookCallback;
        public static ScForm2 scForm2;
        public HotKey() {
            HookKeyboard();
        }
        //static Form1 form1 = new Form1();
        #region Windows

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int ncode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        #endregion
        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                setHotKey(vkCode);
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        static Keys previoursKey = Keys.Separator;
        static bool ishotkey = false;
        private static void setHotKey(int vkCode)
        {
            // ScForm scForm;

            if (previoursKey == Keys.LControlKey && (Keys)(vkCode) == Keys.F3)
            {
               
              
                    scForm2 = new ScForm2();
                    Form1.FullScCapture();
                    scForm2.BackgroundImage = Clipboard.GetImage();
                    scForm2.Show();

                
            }
            if(previoursKey==Keys.LControlKey&&(Keys)(vkCode) == Keys.F2)
            {
                Form1 form1 = new Form1();
                form1.HideBt.Hide();
                form1.TopMost = true;
                form1.Show();
            }

            previoursKey = (Keys)vkCode;
        }
        static void HookKeyboard()
        {
            _hookID = SetHook(_proc);
            Application.Run(new Form1());
            UnhookWindowsHookEx(_hookID);
        }
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
    }
}

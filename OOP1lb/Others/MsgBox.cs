using System.Runtime.InteropServices;

namespace OOP1lb.Others
{
    public class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, string text, string caption, uint type);
    }
}


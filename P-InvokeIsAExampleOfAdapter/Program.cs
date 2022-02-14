using System.Runtime.InteropServices;

MessageBox(IntPtr.Zero, "Your Text is here", "Attention!", 0);

[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

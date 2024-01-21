namespace Nulo.Core.Utilities {

    internal static partial class NativeMethods {
        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WNDPROC_NDSO_SHOWME = RegisterWindowMessage("WNDPROC_NDSO_SHOWME");

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);
    }
}
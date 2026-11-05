using System.Runtime.InteropServices;

namespace SwE.Patches;

// TODO: Try using actual patches to run this as soon as the window loads? However this may be a lifecycle issu
internal static class WindowTitlePatch
{
    private const string Title = "Risk of Rain 2: Somewhere Else";
    
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern System.IntPtr FindWindow(string className, string windowName);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern bool SetWindowText(System.IntPtr handle, string windowName);
    
    public static void Apply()
    {
        var handle = FindWindow("UnityWndClass", null);
        if (handle != System.IntPtr.Zero) SetWindowText(handle, Title);
    }
}
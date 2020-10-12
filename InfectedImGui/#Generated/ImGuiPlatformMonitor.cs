// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 36)]
public unsafe partial struct ImGuiPlatformMonitor
{
    [FieldOffset(0)] public ImVec2 MainPos;

    [FieldOffset(8)] public ImVec2 MainSize;

    [FieldOffset(16)] public ImVec2 WorkPos;

    [FieldOffset(24)] public ImVec2 WorkSize;

    [FieldOffset(32)] public float DpiScale;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImGuiPlatformMonitor@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImGuiPlatformMonitor* @this);

    public unsafe void Constructor()
    {
        fixed (ImGuiPlatformMonitor* @this = &this)
        { Constructor_PInvoke(@this); }
    }
}

// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 24)]
public unsafe partial struct ImGuiListClipper
{
    [FieldOffset(0)] public int DisplayStart;

    [FieldOffset(4)] public int DisplayEnd;

    [FieldOffset(8)] public int ItemsCount;

    [FieldOffset(12)] public int StepNo;

    [FieldOffset(16)] public float ItemsHeight;

    [FieldOffset(20)] public float StartPosY;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImGuiListClipper@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImGuiListClipper* @this);

    public unsafe void Constructor()
    {
        fixed (ImGuiListClipper* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??_DImGuiListClipper@@QEAAXXZ", ExactSpelling = true)]
    private static extern void Destructor_PInvoke(ImGuiListClipper* @this);

    public unsafe void Destructor()
    {
        fixed (ImGuiListClipper* @this = &this)
        { Destructor_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Begin@ImGuiListClipper@@QEAAXHM@Z", ExactSpelling = true)]
    private static extern void Begin_PInvoke(ImGuiListClipper* @this, int items_count, float items_height);

    public unsafe void Begin(int items_count, float items_height)
    {
        fixed (ImGuiListClipper* @this = &this)
        { Begin_PInvoke(@this, items_count, items_height); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?End@ImGuiListClipper@@QEAAXXZ", ExactSpelling = true)]
    private static extern void End_PInvoke(ImGuiListClipper* @this);

    public unsafe void End()
    {
        fixed (ImGuiListClipper* @this = &this)
        { End_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Step@ImGuiListClipper@@QEAA_NXZ", ExactSpelling = true)]
    private static extern bool Step_PInvoke(ImGuiListClipper* @this);

    public unsafe bool Step()
    {
        fixed (ImGuiListClipper* @this = &this)
        { return Step_PInvoke(@this); }
    }
}

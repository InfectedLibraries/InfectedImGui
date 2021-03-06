// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct ImGuiWindowSettings
    {
        [FieldOffset(0)] public uint ID;

        [FieldOffset(4)] public ImVec2ih Pos;

        [FieldOffset(8)] public ImVec2ih Size;

        [FieldOffset(12)] public ImVec2ih ViewportPos;

        [FieldOffset(16)] public uint ViewportId;

        [FieldOffset(20)] public uint DockId;

        [FieldOffset(24)] public uint ClassId;

        [FieldOffset(28)] public short DockOrder;

        [FieldOffset(30)] [MarshalAs(UnmanagedType.I1)] public bool Collapsed;

        [FieldOffset(31)] [MarshalAs(UnmanagedType.I1)] public bool WantApply;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper57", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiWindowSettings* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (ImGuiWindowSettings* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetName@ImGuiWindowSettings@@QEAAPEADXZ", ExactSpelling = true)]
        private static extern byte* GetName_PInvoke(ImGuiWindowSettings* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe byte* GetName()
        {
            fixed (ImGuiWindowSettings* @this = &this)
            { return GetName_PInvoke(@this); }
        }
    }
}

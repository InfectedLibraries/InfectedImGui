// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public unsafe partial struct ImGuiOldColumnData
    {
        [FieldOffset(0)] public float OffsetNorm;

        [FieldOffset(4)] public float OffsetNormBeforeResize;

        [FieldOffset(8)] public ImGuiOldColumnFlags Flags;

        [FieldOffset(12)] public ImRect ClipRect;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper52", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiOldColumnData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (ImGuiOldColumnData* @this = &this)
            { Constructor_PInvoke(@this); }
        }
    }
}

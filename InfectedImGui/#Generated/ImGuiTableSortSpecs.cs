// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct ImGuiTableSortSpecs
    {
        [FieldOffset(0)] public ImGuiTableColumnSortSpecs* Specs;

        [FieldOffset(8)] public int SpecsCount;

        [FieldOffset(12)] [MarshalAs(UnmanagedType.I1)] public bool SpecsDirty;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper7", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiTableSortSpecs* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (ImGuiTableSortSpecs* @this = &this)
            { Constructor_PInvoke(@this); }
        }
    }
}

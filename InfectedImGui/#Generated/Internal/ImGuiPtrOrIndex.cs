// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct ImGuiPtrOrIndex
    {
        [FieldOffset(0)] public void* Ptr;

        [FieldOffset(8)] public int Index;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper50", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiPtrOrIndex* @this, void* ptr);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(void* ptr)
        {
            fixed (ImGuiPtrOrIndex* @this = &this)
            { Constructor_PInvoke(@this, ptr); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper51", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiPtrOrIndex* @this, int index);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(int index)
        {
            fixed (ImGuiPtrOrIndex* @this = &this)
            { Constructor_PInvoke(@this, index); }
        }
    }
}

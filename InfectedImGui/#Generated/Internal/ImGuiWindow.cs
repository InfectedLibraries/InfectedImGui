// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using InfectedImGui.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 1144)]
    public unsafe partial struct ImGuiWindow
    {
        [FieldOffset(0)] public byte* Name;

        [FieldOffset(8)] public uint ID;

        [FieldOffset(12)] public ImGuiWindowFlags Flags;

        [FieldOffset(16)] public ImGuiWindowFlags FlagsPreviousFrame;

        [FieldOffset(20)] public ImGuiWindowClass WindowClass;

        [FieldOffset(56)] public ImGuiViewportP* Viewport;

        [FieldOffset(64)] public uint ViewportId;

        [FieldOffset(68)] public ImVec2 ViewportPos;

        [FieldOffset(76)] public int ViewportAllowPlatformMonitorExtend;

        [FieldOffset(80)] public ImVec2 Pos;

        [FieldOffset(88)] public ImVec2 Size;

        [FieldOffset(96)] public ImVec2 SizeFull;

        [FieldOffset(104)] public ImVec2 ContentSize;

        [FieldOffset(112)] public ImVec2 ContentSizeIdeal;

        [FieldOffset(120)] public ImVec2 ContentSizeExplicit;

        [FieldOffset(128)] public ImVec2 WindowPadding;

        [FieldOffset(136)] public float WindowRounding;

        [FieldOffset(140)] public float WindowBorderSize;

        [FieldOffset(144)] public int NameBufLen;

        [FieldOffset(148)] public uint MoveId;

        [FieldOffset(152)] public uint ChildId;

        [FieldOffset(156)] public ImVec2 Scroll;

        [FieldOffset(164)] public ImVec2 ScrollMax;

        [FieldOffset(172)] public ImVec2 ScrollTarget;

        [FieldOffset(180)] public ImVec2 ScrollTargetCenterRatio;

        [FieldOffset(188)] public ImVec2 ScrollTargetEdgeSnapDist;

        [FieldOffset(196)] public ImVec2 ScrollbarSizes;

        [FieldOffset(204)] [MarshalAs(UnmanagedType.I1)] public bool ScrollbarX;

        [FieldOffset(205)] [MarshalAs(UnmanagedType.I1)] public bool ScrollbarY;

        [FieldOffset(206)] [MarshalAs(UnmanagedType.I1)] public bool ViewportOwned;

        [FieldOffset(207)] [MarshalAs(UnmanagedType.I1)] public bool Active;

        [FieldOffset(208)] [MarshalAs(UnmanagedType.I1)] public bool WasActive;

        [FieldOffset(209)] [MarshalAs(UnmanagedType.I1)] public bool WriteAccessed;

        [FieldOffset(210)] [MarshalAs(UnmanagedType.I1)] public bool Collapsed;

        [FieldOffset(211)] [MarshalAs(UnmanagedType.I1)] public bool WantCollapseToggle;

        [FieldOffset(212)] [MarshalAs(UnmanagedType.I1)] public bool SkipItems;

        [FieldOffset(213)] [MarshalAs(UnmanagedType.I1)] public bool Appearing;

        [FieldOffset(214)] [MarshalAs(UnmanagedType.I1)] public bool Hidden;

        [FieldOffset(215)] [MarshalAs(UnmanagedType.I1)] public bool IsFallbackWindow;

        [FieldOffset(216)] [MarshalAs(UnmanagedType.I1)] public bool HasCloseButton;

        [FieldOffset(217)] public sbyte ResizeBorderHeld;

        [FieldOffset(218)] public short BeginCount;

        [FieldOffset(220)] public short BeginOrderWithinParent;

        [FieldOffset(222)] public short BeginOrderWithinContext;

        [FieldOffset(224)] public uint PopupId;

        [FieldOffset(228)] public sbyte AutoFitFramesX;

        [FieldOffset(229)] public sbyte AutoFitFramesY;

        [FieldOffset(230)] public sbyte AutoFitChildAxises;

        [FieldOffset(231)] [MarshalAs(UnmanagedType.I1)] public bool AutoFitOnlyGrows;

        [FieldOffset(232)] public ImGuiDir AutoPosLastDirection;

        [FieldOffset(236)] public sbyte HiddenFramesCanSkipItems;

        [FieldOffset(237)] public sbyte HiddenFramesCannotSkipItems;

        [FieldOffset(238)] public sbyte HiddenFramesForRenderOnly;

        [FieldOffset(239)] public sbyte DisableInputsFrames;

        [FieldOffset(240)] private uint __SetWindowPosAllowFlags__backingField;
        public ImGuiCond SetWindowPosAllowFlags
        {
            get => (ImGuiCond)((__SetWindowPosAllowFlags__backingField >> 0) & 0xFFU);
            set
            {
                uint shiftedValue = (((uint)value) & 0xFFU) << 0;
                uint otherBits = __SetWindowPosAllowFlags__backingField & 0xFFFFFF00U;
                __SetWindowPosAllowFlags__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(240)] private uint __SetWindowSizeAllowFlags__backingField;
        public ImGuiCond SetWindowSizeAllowFlags
        {
            get => (ImGuiCond)((__SetWindowSizeAllowFlags__backingField >> 8) & 0xFFU);
            set
            {
                uint shiftedValue = (((uint)value) & 0xFFU) << 8;
                uint otherBits = __SetWindowSizeAllowFlags__backingField & 0xFFFF00FFU;
                __SetWindowSizeAllowFlags__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(240)] private uint __SetWindowCollapsedAllowFlags__backingField;
        public ImGuiCond SetWindowCollapsedAllowFlags
        {
            get => (ImGuiCond)((__SetWindowCollapsedAllowFlags__backingField >> 16) & 0xFFU);
            set
            {
                uint shiftedValue = (((uint)value) & 0xFFU) << 16;
                uint otherBits = __SetWindowCollapsedAllowFlags__backingField & 0xFF00FFFFU;
                __SetWindowCollapsedAllowFlags__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(240)] private uint __SetWindowDockAllowFlags__backingField;
        public ImGuiCond SetWindowDockAllowFlags
        {
            get => (ImGuiCond)((__SetWindowDockAllowFlags__backingField >> 24) & 0xFFU);
            set
            {
                uint shiftedValue = (((uint)value) & 0xFFU) << 24;
                uint otherBits = __SetWindowDockAllowFlags__backingField & 0xFFFFFFU;
                __SetWindowDockAllowFlags__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(244)] public ImVec2 SetWindowPosVal;

        [FieldOffset(252)] public ImVec2 SetWindowPosPivot;

        [FieldOffset(264)] public ImVector<uint> IDStack;

        [FieldOffset(280)] public ImGuiWindowTempData DC;

        [FieldOffset(584)] public ImRect OuterRectClipped;

        [FieldOffset(600)] public ImRect InnerRect;

        [FieldOffset(616)] public ImRect InnerClipRect;

        [FieldOffset(632)] public ImRect WorkRect;

        [FieldOffset(648)] public ImRect ParentWorkRect;

        [FieldOffset(664)] public ImRect ClipRect;

        [FieldOffset(680)] public ImRect ContentRegionRect;

        [FieldOffset(696)] public ImVec2ih HitTestHoleSize;

        [FieldOffset(700)] public ImVec2ih HitTestHoleOffset;

        [FieldOffset(704)] public int LastFrameActive;

        [FieldOffset(708)] public int LastFrameJustFocused;

        [FieldOffset(712)] public float LastTimeActive;

        [FieldOffset(716)] public float ItemWidthDefault;

        [FieldOffset(720)] public ImGuiStorage StateStorage;

        [FieldOffset(736)] public ImVector<ImGuiOldColumns> ColumnsStorage;

        [FieldOffset(752)] public float FontWindowScale;

        [FieldOffset(756)] public float FontDpiScale;

        [FieldOffset(760)] public int SettingsOffset;

        [FieldOffset(768)] public ImDrawList* DrawList;

        [FieldOffset(776)] public ImDrawList DrawListInst;

        [FieldOffset(976)] public ImGuiWindow* ParentWindow;

        [FieldOffset(984)] public ImGuiWindow* RootWindow;

        [FieldOffset(992)] public ImGuiWindow* RootWindowDockStop;

        [FieldOffset(1000)] public ImGuiWindow* RootWindowForTitleBarHighlight;

        [FieldOffset(1008)] public ImGuiWindow* RootWindowForNav;

        [FieldOffset(1016)] public ImGuiWindow* NavLastChildNavWindow;

        [FieldOffset(1024)] public ConstantArray_ImGuiID_2 NavLastIds;

        [FieldOffset(1032)] public ConstantArray_ImRect_2 NavRectRel;

        [FieldOffset(1064)] public int MemoryDrawListIdxCapacity;

        [FieldOffset(1068)] public int MemoryDrawListVtxCapacity;

        [FieldOffset(1072)] [MarshalAs(UnmanagedType.I1)] public bool MemoryCompacted;

        [FieldOffset(1073)] private byte __DockIsActive__backingField;
        public bool DockIsActive
        {
            get => ((__DockIsActive__backingField >> 0) & 0x1U) != 0;
            set
            {
                uint shiftedValue = ((value ? 1U : 0U) & 0x1U) << 0;
                uint otherBits = __DockIsActive__backingField & 0xFEU;
                __DockIsActive__backingField = (byte)(otherBits | shiftedValue);
            }
        }

        [FieldOffset(1073)] private byte __DockTabIsVisible__backingField;
        public bool DockTabIsVisible
        {
            get => ((__DockTabIsVisible__backingField >> 1) & 0x1U) != 0;
            set
            {
                uint shiftedValue = ((value ? 1U : 0U) & 0x1U) << 1;
                uint otherBits = __DockTabIsVisible__backingField & 0xFDU;
                __DockTabIsVisible__backingField = (byte)(otherBits | shiftedValue);
            }
        }

        [FieldOffset(1073)] private byte __DockTabWantClose__backingField;
        public bool DockTabWantClose
        {
            get => ((__DockTabWantClose__backingField >> 2) & 0x1U) != 0;
            set
            {
                uint shiftedValue = ((value ? 1U : 0U) & 0x1U) << 2;
                uint otherBits = __DockTabWantClose__backingField & 0xFBU;
                __DockTabWantClose__backingField = (byte)(otherBits | shiftedValue);
            }
        }

        [FieldOffset(1074)] public short DockOrder;

        [FieldOffset(1076)] public ImGuiWindowDockStyle DockStyle;

        [FieldOffset(1104)] public ImGuiDockNode* DockNode;

        [FieldOffset(1112)] public ImGuiDockNode* DockNodeAsHost;

        [FieldOffset(1120)] public uint DockId;

        [FieldOffset(1124)] public ImGuiItemStatusFlags DockTabItemStatusFlags;

        [FieldOffset(1128)] public ImRect DockTabItemRect;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImGuiWindow@@QEAA@PEAUImGuiContext@@PEBD@Z", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiWindow* @this, ImGuiContext* context, byte* name);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(ImGuiContext* context, byte* name)
        {
            fixed (ImGuiWindow* @this = &this)
            { Constructor_PInvoke(@this, context, name); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??1ImGuiWindow@@QEAA@XZ", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(ImGuiWindow* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (ImGuiWindow* @this = &this)
            { Destructor_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetID@ImGuiWindow@@QEAAIPEBD0@Z", ExactSpelling = true)]
        private static extern uint GetID_PInvoke(ImGuiWindow* @this, byte* str, byte* str_end);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint GetID(byte* str, byte* str_end = null)
        {
            fixed (ImGuiWindow* @this = &this)
            { return GetID_PInvoke(@this, str, str_end); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetID@ImGuiWindow@@QEAAIPEBX@Z", ExactSpelling = true)]
        private static extern uint GetID_PInvoke(ImGuiWindow* @this, void* ptr);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint GetID(void* ptr)
        {
            fixed (ImGuiWindow* @this = &this)
            { return GetID_PInvoke(@this, ptr); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetID@ImGuiWindow@@QEAAIH@Z", ExactSpelling = true)]
        private static extern uint GetID_PInvoke(ImGuiWindow* @this, int n);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint GetID(int n)
        {
            fixed (ImGuiWindow* @this = &this)
            { return GetID_PInvoke(@this, n); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetIDNoKeepAlive@ImGuiWindow@@QEAAIPEBD0@Z", ExactSpelling = true)]
        private static extern uint GetIDNoKeepAlive_PInvoke(ImGuiWindow* @this, byte* str, byte* str_end);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint GetIDNoKeepAlive(byte* str, byte* str_end = null)
        {
            fixed (ImGuiWindow* @this = &this)
            { return GetIDNoKeepAlive_PInvoke(@this, str, str_end); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetIDNoKeepAlive@ImGuiWindow@@QEAAIPEBX@Z", ExactSpelling = true)]
        private static extern uint GetIDNoKeepAlive_PInvoke(ImGuiWindow* @this, void* ptr);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint GetIDNoKeepAlive(void* ptr)
        {
            fixed (ImGuiWindow* @this = &this)
            { return GetIDNoKeepAlive_PInvoke(@this, ptr); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetIDNoKeepAlive@ImGuiWindow@@QEAAIH@Z", ExactSpelling = true)]
        private static extern uint GetIDNoKeepAlive_PInvoke(ImGuiWindow* @this, int n);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint GetIDNoKeepAlive(int n)
        {
            fixed (ImGuiWindow* @this = &this)
            { return GetIDNoKeepAlive_PInvoke(@this, n); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetIDFromRectangle@ImGuiWindow@@QEAAIAEBUImRect@@@Z", ExactSpelling = true)]
        private static extern uint GetIDFromRectangle_PInvoke(ImGuiWindow* @this, ImRect* r_abs);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe uint GetIDFromRectangle(ImRect* r_abs)
        {
            fixed (ImGuiWindow* @this = &this)
            { return GetIDFromRectangle_PInvoke(@this, r_abs); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Rect@ImGuiWindow@@QEBA?AUImRect@@XZ", ExactSpelling = true)]
        private static extern ImRect* Rect_PInvoke(ImGuiWindow* @this, out ImRect __returnBuffer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ImRect Rect()
        {
            fixed (ImGuiWindow* @this = &this)
            {
                ImRect __returnBuffer;
                Rect_PInvoke(@this, out __returnBuffer);
                return __returnBuffer;
            }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?CalcFontSize@ImGuiWindow@@QEBAMXZ", ExactSpelling = true)]
        private static extern float CalcFontSize_PInvoke(ImGuiWindow* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float CalcFontSize()
        {
            fixed (ImGuiWindow* @this = &this)
            { return CalcFontSize_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?TitleBarHeight@ImGuiWindow@@QEBAMXZ", ExactSpelling = true)]
        private static extern float TitleBarHeight_PInvoke(ImGuiWindow* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float TitleBarHeight()
        {
            fixed (ImGuiWindow* @this = &this)
            { return TitleBarHeight_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?TitleBarRect@ImGuiWindow@@QEBA?AUImRect@@XZ", ExactSpelling = true)]
        private static extern ImRect* TitleBarRect_PInvoke(ImGuiWindow* @this, out ImRect __returnBuffer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ImRect TitleBarRect()
        {
            fixed (ImGuiWindow* @this = &this)
            {
                ImRect __returnBuffer;
                TitleBarRect_PInvoke(@this, out __returnBuffer);
                return __returnBuffer;
            }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?MenuBarHeight@ImGuiWindow@@QEBAMXZ", ExactSpelling = true)]
        private static extern float MenuBarHeight_PInvoke(ImGuiWindow* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe float MenuBarHeight()
        {
            fixed (ImGuiWindow* @this = &this)
            { return MenuBarHeight_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?MenuBarRect@ImGuiWindow@@QEBA?AUImRect@@XZ", ExactSpelling = true)]
        private static extern ImRect* MenuBarRect_PInvoke(ImGuiWindow* @this, out ImRect __returnBuffer);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ImRect MenuBarRect()
        {
            fixed (ImGuiWindow* @this = &this)
            {
                ImRect __returnBuffer;
                MenuBarRect_PInvoke(@this, out __returnBuffer);
                return __returnBuffer;
            }
        }
    }
}
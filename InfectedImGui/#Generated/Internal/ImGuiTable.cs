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
    [StructLayout(LayoutKind.Explicit, Size = 600)]
    public unsafe partial struct ImGuiTable
    {
        [FieldOffset(0)] public uint ID;

        [FieldOffset(4)] public ImGuiTableFlags Flags;

        [FieldOffset(8)] public void* RawData;

        [FieldOffset(64)] public ulong EnabledMaskByDisplayOrder;

        [FieldOffset(72)] public ulong EnabledMaskByIndex;

        [FieldOffset(80)] public ulong VisibleMaskByIndex;

        [FieldOffset(88)] public ulong RequestOutputMaskByIndex;

        [FieldOffset(96)] public ImGuiTableFlags SettingsLoadedFlags;

        [FieldOffset(100)] public int SettingsOffset;

        [FieldOffset(104)] public int LastFrameActive;

        [FieldOffset(108)] public int ColumnsCount;

        [FieldOffset(112)] public int CurrentRow;

        [FieldOffset(116)] public int CurrentColumn;

        [FieldOffset(120)] public short InstanceCurrent;

        [FieldOffset(122)] public short InstanceInteracted;

        [FieldOffset(124)] public float RowPosY1;

        [FieldOffset(128)] public float RowPosY2;

        [FieldOffset(132)] public float RowMinHeight;

        [FieldOffset(136)] public float RowTextBaseline;

        [FieldOffset(140)] public float RowIndentOffsetX;

        [FieldOffset(144)] private uint __RowFlags__backingField;
        public ImGuiTableRowFlags RowFlags
        {
            get => (ImGuiTableRowFlags)((__RowFlags__backingField >> 0) & 0xFFFFU);
            set
            {
                uint shiftedValue = (((uint)value) & 0xFFFFU) << 0;
                uint otherBits = __RowFlags__backingField & 0xFFFF0000U;
                __RowFlags__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(144)] private uint __LastRowFlags__backingField;
        public ImGuiTableRowFlags LastRowFlags
        {
            get => (ImGuiTableRowFlags)((__LastRowFlags__backingField >> 16) & 0xFFFFU);
            set
            {
                uint shiftedValue = (((uint)value) & 0xFFFFU) << 16;
                uint otherBits = __LastRowFlags__backingField & 0xFFFFU;
                __LastRowFlags__backingField = otherBits | shiftedValue;
            }
        }

        [FieldOffset(148)] public int RowBgColorCounter;

        [FieldOffset(152)] public ConstantArray_ImU32_2 RowBgColor;

        [FieldOffset(160)] public uint BorderColorStrong;

        [FieldOffset(164)] public uint BorderColorLight;

        [FieldOffset(168)] public float BorderX1;

        [FieldOffset(172)] public float BorderX2;

        [FieldOffset(176)] public float HostIndentX;

        [FieldOffset(180)] public float MinColumnWidth;

        [FieldOffset(184)] public float OuterPaddingX;

        [FieldOffset(188)] public float CellPaddingX;

        [FieldOffset(192)] public float CellPaddingY;

        [FieldOffset(196)] public float CellSpacingX1;

        [FieldOffset(200)] public float CellSpacingX2;

        [FieldOffset(204)] public float LastOuterHeight;

        [FieldOffset(208)] public float LastFirstRowHeight;

        [FieldOffset(212)] public float InnerWidth;

        [FieldOffset(216)] public float ColumnsGivenWidth;

        [FieldOffset(220)] public float ColumnsAutoFitWidth;

        [FieldOffset(224)] public float ResizedColumnNextWidth;

        [FieldOffset(228)] public float ResizeLockMinContentsX2;

        [FieldOffset(232)] public float RefScale;

        [FieldOffset(236)] public ImRect OuterRect;

        [FieldOffset(252)] public ImRect InnerRect;

        [FieldOffset(268)] public ImRect WorkRect;

        [FieldOffset(284)] public ImRect InnerClipRect;

        [FieldOffset(300)] public ImRect BgClipRect;

        [FieldOffset(316)] public ImRect Bg0ClipRectForDrawCmd;

        [FieldOffset(332)] public ImRect Bg2ClipRectForDrawCmd;

        [FieldOffset(348)] public ImRect HostClipRect;

        [FieldOffset(364)] public ImRect HostBackupWorkRect;

        [FieldOffset(380)] public ImRect HostBackupParentWorkRect;

        [FieldOffset(396)] public ImRect HostBackupInnerClipRect;

        [FieldOffset(412)] public ImVec2 HostBackupPrevLineSize;

        [FieldOffset(420)] public ImVec2 HostBackupCurrLineSize;

        [FieldOffset(428)] public ImVec2 HostBackupCursorMaxPos;

        [FieldOffset(436)] public ImVec2 UserOuterSize;

        [FieldOffset(444)] public ImVec1 HostBackupColumnsOffset;

        [FieldOffset(448)] public float HostBackupItemWidth;

        [FieldOffset(452)] public int HostBackupItemWidthStackSize;

        [FieldOffset(456)] public ImGuiWindow* OuterWindow;

        [FieldOffset(464)] public ImGuiWindow* InnerWindow;

        [FieldOffset(472)] public ImGuiTextBuffer ColumnsNames;

        [FieldOffset(488)] public ImDrawListSplitter DrawSplitter;

        [FieldOffset(512)] public ImGuiTableColumnSortSpecs SortSpecsSingle;

        [FieldOffset(528)] public ImVector<ImGuiTableColumnSortSpecs> SortSpecsMulti;

        [FieldOffset(544)] public ImGuiTableSortSpecs SortSpecs;

        [FieldOffset(560)] public sbyte SortSpecsCount;

        [FieldOffset(561)] public sbyte ColumnsEnabledCount;

        [FieldOffset(562)] public sbyte ColumnsEnabledFixedCount;

        [FieldOffset(563)] public sbyte DeclColumnsCount;

        [FieldOffset(564)] public sbyte HoveredColumnBody;

        [FieldOffset(565)] public sbyte HoveredColumnBorder;

        [FieldOffset(566)] public sbyte AutoFitSingleColumn;

        [FieldOffset(567)] public sbyte ResizedColumn;

        [FieldOffset(568)] public sbyte LastResizedColumn;

        [FieldOffset(569)] public sbyte HeldHeaderColumn;

        [FieldOffset(570)] public sbyte ReorderColumn;

        [FieldOffset(571)] public sbyte ReorderColumnDir;

        [FieldOffset(572)] public sbyte LeftMostEnabledColumn;

        [FieldOffset(573)] public sbyte RightMostEnabledColumn;

        [FieldOffset(574)] public sbyte LeftMostStretchedColumn;

        [FieldOffset(575)] public sbyte RightMostStretchedColumn;

        [FieldOffset(576)] public sbyte ContextPopupColumn;

        [FieldOffset(577)] public sbyte FreezeRowsRequest;

        [FieldOffset(578)] public sbyte FreezeRowsCount;

        [FieldOffset(579)] public sbyte FreezeColumnsRequest;

        [FieldOffset(580)] public sbyte FreezeColumnsCount;

        [FieldOffset(581)] public sbyte RowCellDataCurrent;

        [FieldOffset(582)] public byte DummyDrawChannel;

        [FieldOffset(583)] public byte Bg2DrawChannelCurrent;

        [FieldOffset(584)] public byte Bg2DrawChannelUnfrozen;

        [FieldOffset(585)] [MarshalAs(UnmanagedType.I1)] public bool IsLayoutLocked;

        [FieldOffset(586)] [MarshalAs(UnmanagedType.I1)] public bool IsInsideRow;

        [FieldOffset(587)] [MarshalAs(UnmanagedType.I1)] public bool IsInitializing;

        [FieldOffset(588)] [MarshalAs(UnmanagedType.I1)] public bool IsSortSpecsDirty;

        [FieldOffset(589)] [MarshalAs(UnmanagedType.I1)] public bool IsUsingHeaders;

        [FieldOffset(590)] [MarshalAs(UnmanagedType.I1)] public bool IsContextPopupOpen;

        [FieldOffset(591)] [MarshalAs(UnmanagedType.I1)] public bool IsSettingsRequestLoad;

        [FieldOffset(592)] [MarshalAs(UnmanagedType.I1)] public bool IsSettingsDirty;

        [FieldOffset(593)] [MarshalAs(UnmanagedType.I1)] public bool IsDefaultDisplayOrder;

        [FieldOffset(594)] [MarshalAs(UnmanagedType.I1)] public bool IsResetAllRequest;

        [FieldOffset(595)] [MarshalAs(UnmanagedType.I1)] public bool IsResetDisplayOrderRequest;

        [FieldOffset(596)] [MarshalAs(UnmanagedType.I1)] public bool IsUnfrozenRows;

        [FieldOffset(597)] [MarshalAs(UnmanagedType.I1)] public bool IsDefaultSizingPolicy;

        [FieldOffset(598)] [MarshalAs(UnmanagedType.I1)] public bool MemoryCompacted;

        [FieldOffset(599)] [MarshalAs(UnmanagedType.I1)] public bool HostSkipItems;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper66", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiTable* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (ImGuiTable* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper67", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(ImGuiTable* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (ImGuiTable* @this = &this)
            { Destructor_PInvoke(@this); }
        }
    }
}

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
    [StructLayout(LayoutKind.Explicit, Size = 16224)]
    public unsafe partial struct ImGuiContext
    {
        [FieldOffset(0)] [MarshalAs(UnmanagedType.I1)] public bool Initialized;

        [FieldOffset(1)] [MarshalAs(UnmanagedType.I1)] public bool FontAtlasOwnedByContext;

        [FieldOffset(8)] public ImGuiIO IO;

        [FieldOffset(5464)] public ImGuiPlatformIO PlatformIO;

        [FieldOffset(5688)] public ImGuiStyle Style;

        [FieldOffset(6764)] public ImGuiConfigFlags ConfigFlagsCurrFrame;

        [FieldOffset(6768)] public ImGuiConfigFlags ConfigFlagsLastFrame;

        [FieldOffset(6776)] public ImFont* Font;

        [FieldOffset(6784)] public float FontSize;

        [FieldOffset(6788)] public float FontBaseSize;

        [FieldOffset(6792)] public ImDrawListSharedData DrawListSharedData;

        [FieldOffset(7008)] public double Time;

        [FieldOffset(7016)] public int FrameCount;

        [FieldOffset(7020)] public int FrameCountEnded;

        [FieldOffset(7024)] public int FrameCountPlatformEnded;

        [FieldOffset(7028)] public int FrameCountRendered;

        [FieldOffset(7032)] [MarshalAs(UnmanagedType.I1)] public bool WithinFrameScope;

        [FieldOffset(7033)] [MarshalAs(UnmanagedType.I1)] public bool WithinFrameScopeWithImplicitWindow;

        [FieldOffset(7034)] [MarshalAs(UnmanagedType.I1)] public bool WithinEndChild;

        [FieldOffset(7035)] [MarshalAs(UnmanagedType.I1)] public bool GcCompactAll;

        [FieldOffset(7036)] [MarshalAs(UnmanagedType.I1)] public bool TestEngineHookItems;

        [FieldOffset(7040)] public uint TestEngineHookIdInfo;

        [FieldOffset(7048)] public void* TestEngine;

        [FieldOffset(7056)] public ImVector<Pointer<ImGuiWindow>> Windows;

        [FieldOffset(7072)] public ImVector<Pointer<ImGuiWindow>> WindowsFocusOrder;

        [FieldOffset(7088)] public ImVector<Pointer<ImGuiWindow>> WindowsTempSortBuffer;

        [FieldOffset(7104)] public ImVector<Pointer<ImGuiWindow>> CurrentWindowStack;

        [FieldOffset(7120)] public ImGuiStorage WindowsById;

        [FieldOffset(7136)] public int WindowsActiveCount;

        [FieldOffset(7144)] public ImGuiWindow* CurrentWindow;

        [FieldOffset(7152)] public ImGuiWindow* HoveredWindow;

        [FieldOffset(7160)] public ImGuiWindow* HoveredRootWindow;

        [FieldOffset(7168)] public ImGuiWindow* HoveredWindowUnderMovingWindow;

        [FieldOffset(7176)] public ImGuiDockNode* HoveredDockNode;

        [FieldOffset(7184)] public ImGuiWindow* MovingWindow;

        [FieldOffset(7192)] public ImGuiWindow* WheelingWindow;

        [FieldOffset(7200)] public ImVec2 WheelingWindowRefMousePos;

        [FieldOffset(7208)] public float WheelingWindowTimer;

        [FieldOffset(7212)] public uint HoveredId;

        [FieldOffset(7216)] public uint HoveredIdPreviousFrame;

        [FieldOffset(7220)] [MarshalAs(UnmanagedType.I1)] public bool HoveredIdAllowOverlap;

        [FieldOffset(7221)] [MarshalAs(UnmanagedType.I1)] public bool HoveredIdUsingMouseWheel;

        [FieldOffset(7222)] [MarshalAs(UnmanagedType.I1)] public bool HoveredIdPreviousFrameUsingMouseWheel;

        [FieldOffset(7223)] [MarshalAs(UnmanagedType.I1)] public bool HoveredIdDisabled;

        [FieldOffset(7224)] public float HoveredIdTimer;

        [FieldOffset(7228)] public float HoveredIdNotActiveTimer;

        [FieldOffset(7232)] public uint ActiveId;

        [FieldOffset(7236)] public uint ActiveIdIsAlive;

        [FieldOffset(7240)] public float ActiveIdTimer;

        [FieldOffset(7244)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdIsJustActivated;

        [FieldOffset(7245)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdAllowOverlap;

        [FieldOffset(7246)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdNoClearOnFocusLoss;

        [FieldOffset(7247)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdHasBeenPressedBefore;

        [FieldOffset(7248)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdHasBeenEditedBefore;

        [FieldOffset(7249)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdHasBeenEditedThisFrame;

        [FieldOffset(7250)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdUsingMouseWheel;

        [FieldOffset(7252)] public uint ActiveIdUsingNavDirMask;

        [FieldOffset(7256)] public uint ActiveIdUsingNavInputMask;

        [FieldOffset(7264)] public ulong ActiveIdUsingKeyInputMask;

        [FieldOffset(7272)] public ImVec2 ActiveIdClickOffset;

        [FieldOffset(7280)] public ImGuiWindow* ActiveIdWindow;

        [FieldOffset(7288)] public ImGuiInputSource ActiveIdSource;

        [FieldOffset(7292)] public int ActiveIdMouseButton;

        [FieldOffset(7296)] public uint ActiveIdPreviousFrame;

        [FieldOffset(7300)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdPreviousFrameIsAlive;

        [FieldOffset(7301)] [MarshalAs(UnmanagedType.I1)] public bool ActiveIdPreviousFrameHasBeenEditedBefore;

        [FieldOffset(7304)] public ImGuiWindow* ActiveIdPreviousFrameWindow;

        [FieldOffset(7312)] public uint LastActiveId;

        [FieldOffset(7316)] public float LastActiveIdTimer;

        [FieldOffset(7320)] public ImGuiNextWindowData NextWindowData;

        [FieldOffset(7472)] public ImGuiNextItemData NextItemData;

        [FieldOffset(7496)] public ImVector<ImGuiColorMod> ColorStack;

        [FieldOffset(7512)] public ImVector<ImGuiStyleMod> StyleVarStack;

        [FieldOffset(7528)] public ImVector<Pointer<ImFont>> FontStack;

        [FieldOffset(7544)] public ImVector<uint> FocusScopeStack;

        [FieldOffset(7560)] public ImVector<int> ItemFlagsStack;

        [FieldOffset(7576)] public ImVector<ImGuiGroupData> GroupStack;

        [FieldOffset(7592)] public ImVector<ImGuiPopupData> OpenPopupStack;

        [FieldOffset(7608)] public ImVector<ImGuiPopupData> BeginPopupStack;

        [FieldOffset(7624)] public ImVector<Pointer<ImGuiViewportP>> Viewports;

        [FieldOffset(7640)] public float CurrentDpiScale;

        [FieldOffset(7648)] public ImGuiViewportP* CurrentViewport;

        [FieldOffset(7656)] public ImGuiViewportP* MouseViewport;

        [FieldOffset(7664)] public ImGuiViewportP* MouseLastHoveredViewport;

        [FieldOffset(7672)] public uint PlatformLastFocusedViewportId;

        [FieldOffset(7676)] public int ViewportFrontMostStampCount;

        [FieldOffset(7680)] public ImGuiWindow* NavWindow;

        [FieldOffset(7688)] public uint NavId;

        [FieldOffset(7692)] public uint NavFocusScopeId;

        [FieldOffset(7696)] public uint NavActivateId;

        [FieldOffset(7700)] public uint NavActivateDownId;

        [FieldOffset(7704)] public uint NavActivatePressedId;

        [FieldOffset(7708)] public uint NavInputId;

        [FieldOffset(7712)] public uint NavJustTabbedId;

        [FieldOffset(7716)] public uint NavJustMovedToId;

        [FieldOffset(7720)] public uint NavJustMovedToFocusScopeId;

        [FieldOffset(7724)] public ImGuiKeyModFlags NavJustMovedToKeyMods;

        [FieldOffset(7728)] public uint NavNextActivateId;

        [FieldOffset(7732)] public ImGuiInputSource NavInputSource;

        [FieldOffset(7736)] public ImRect NavScoringRect;

        [FieldOffset(7752)] public int NavScoringCount;

        [FieldOffset(7756)] public ImGuiNavLayer NavLayer;

        [FieldOffset(7760)] public int NavIdTabCounter;

        [FieldOffset(7764)] [MarshalAs(UnmanagedType.I1)] public bool NavIdIsAlive;

        [FieldOffset(7765)] [MarshalAs(UnmanagedType.I1)] public bool NavMousePosDirty;

        [FieldOffset(7766)] [MarshalAs(UnmanagedType.I1)] public bool NavDisableHighlight;

        [FieldOffset(7767)] [MarshalAs(UnmanagedType.I1)] public bool NavDisableMouseHover;

        [FieldOffset(7768)] [MarshalAs(UnmanagedType.I1)] public bool NavAnyRequest;

        [FieldOffset(7769)] [MarshalAs(UnmanagedType.I1)] public bool NavInitRequest;

        [FieldOffset(7770)] [MarshalAs(UnmanagedType.I1)] public bool NavInitRequestFromMove;

        [FieldOffset(7772)] public uint NavInitResultId;

        [FieldOffset(7776)] public ImRect NavInitResultRectRel;

        [FieldOffset(7792)] [MarshalAs(UnmanagedType.I1)] public bool NavMoveRequest;

        [FieldOffset(7796)] public ImGuiNavMoveFlags NavMoveRequestFlags;

        [FieldOffset(7800)] public ImGuiNavForward NavMoveRequestForward;

        [FieldOffset(7804)] public ImGuiKeyModFlags NavMoveRequestKeyMods;

        [FieldOffset(7808)] public ImGuiDir NavMoveDir;

        [FieldOffset(7812)] public ImGuiDir NavMoveDirLast;

        [FieldOffset(7816)] public ImGuiDir NavMoveClipDir;

        [FieldOffset(7824)] public ImGuiNavMoveResult NavMoveResultLocal;

        [FieldOffset(7872)] public ImGuiNavMoveResult NavMoveResultLocalVisibleSet;

        [FieldOffset(7920)] public ImGuiNavMoveResult NavMoveResultOther;

        [FieldOffset(7968)] public ImGuiWindow* NavWrapRequestWindow;

        [FieldOffset(7976)] public ImGuiNavMoveFlags NavWrapRequestFlags;

        [FieldOffset(7984)] public ImGuiWindow* NavWindowingTarget;

        [FieldOffset(7992)] public ImGuiWindow* NavWindowingTargetAnim;

        [FieldOffset(8000)] public ImGuiWindow* NavWindowingListWindow;

        [FieldOffset(8008)] public float NavWindowingTimer;

        [FieldOffset(8012)] public float NavWindowingHighlightAlpha;

        [FieldOffset(8016)] [MarshalAs(UnmanagedType.I1)] public bool NavWindowingToggleLayer;

        [FieldOffset(8024)] public ImGuiWindow* FocusRequestCurrWindow;

        [FieldOffset(8032)] public ImGuiWindow* FocusRequestNextWindow;

        [FieldOffset(8040)] public int FocusRequestCurrCounterRegular;

        [FieldOffset(8044)] public int FocusRequestCurrCounterTabStop;

        [FieldOffset(8048)] public int FocusRequestNextCounterRegular;

        [FieldOffset(8052)] public int FocusRequestNextCounterTabStop;

        [FieldOffset(8056)] [MarshalAs(UnmanagedType.I1)] public bool FocusTabPressed;

        [FieldOffset(8060)] public float DimBgRatio;

        [FieldOffset(8064)] public ImGuiMouseCursor MouseCursor;

        [FieldOffset(8068)] [MarshalAs(UnmanagedType.I1)] public bool DragDropActive;

        [FieldOffset(8069)] [MarshalAs(UnmanagedType.I1)] public bool DragDropWithinSource;

        [FieldOffset(8070)] [MarshalAs(UnmanagedType.I1)] public bool DragDropWithinTarget;

        [FieldOffset(8072)] public ImGuiDragDropFlags DragDropSourceFlags;

        [FieldOffset(8076)] public int DragDropSourceFrameCount;

        [FieldOffset(8080)] public int DragDropMouseButton;

        [FieldOffset(8088)] public ImGuiPayload DragDropPayload;

        [FieldOffset(8152)] public ImRect DragDropTargetRect;

        [FieldOffset(8168)] public uint DragDropTargetId;

        [FieldOffset(8172)] public ImGuiDragDropFlags DragDropAcceptFlags;

        [FieldOffset(8176)] public float DragDropAcceptIdCurrRectSurface;

        [FieldOffset(8180)] public uint DragDropAcceptIdCurr;

        [FieldOffset(8184)] public uint DragDropAcceptIdPrev;

        [FieldOffset(8188)] public int DragDropAcceptFrameCount;

        [FieldOffset(8192)] public uint DragDropHoldJustPressedId;

        [FieldOffset(8200)] public ImVector<byte> DragDropPayloadBufHeap;

        [FieldOffset(8216)] public ConstantArray_unsigned__UNICODE_0020__char_16 DragDropPayloadBufLocal;

        [FieldOffset(8232)] public ImGuiTable* CurrentTable;

        [FieldOffset(8280)] public ImVector<ImGuiPtrOrIndex> CurrentTableStack;

        [FieldOffset(8296)] public ImVector<float> TablesLastTimeActive;

        [FieldOffset(8312)] public ImVector<ImDrawChannel> DrawChannelsTempMergeBuffer;

        [FieldOffset(8328)] public ImGuiTabBar* CurrentTabBar;

        [FieldOffset(8376)] public ImVector<ImGuiPtrOrIndex> CurrentTabBarStack;

        [FieldOffset(8392)] public ImVector<ImGuiShrinkWidthItem> ShrinkWidthBuffer;

        [FieldOffset(8408)] public ImVec2 LastValidMousePos;

        [FieldOffset(8416)] public ImGuiInputTextState InputTextState;

        [FieldOffset(12152)] public ImFont InputTextPasswordFont;

        [FieldOffset(12264)] public uint TempInputId;

        [FieldOffset(12268)] public ImGuiColorEditFlags ColorEditOptions;

        [FieldOffset(12272)] public float ColorEditLastHue;

        [FieldOffset(12276)] public float ColorEditLastSat;

        [FieldOffset(12280)] public ConstantArray_float_3 ColorEditLastColor;

        [FieldOffset(12292)] public ImVec4 ColorPickerRef;

        [FieldOffset(12308)] public float SliderCurrentAccum;

        [FieldOffset(12312)] [MarshalAs(UnmanagedType.I1)] public bool SliderCurrentAccumDirty;

        [FieldOffset(12313)] [MarshalAs(UnmanagedType.I1)] public bool DragCurrentAccumDirty;

        [FieldOffset(12316)] public float DragCurrentAccum;

        [FieldOffset(12320)] public float DragSpeedDefaultRatio;

        [FieldOffset(12324)] public float ScrollbarClickDeltaToGrabCenter;

        [FieldOffset(12328)] public int TooltipOverrideCount;

        [FieldOffset(12332)] public float TooltipSlowDelay;

        [FieldOffset(12336)] public ImVector<byte> ClipboardHandlerData;

        [FieldOffset(12352)] public ImVector<uint> MenusIdSubmittedThisFrame;

        [FieldOffset(12368)] public ImVec2 PlatformImePos;

        [FieldOffset(12376)] public ImVec2 PlatformImeLastPos;

        [FieldOffset(12384)] public ImGuiViewportP* PlatformImePosViewport;

        [FieldOffset(12392)] public byte PlatformLocaleDecimalPoint;

        [FieldOffset(12400)] public ImGuiDockContext DockContext;

        [FieldOffset(12456)] [MarshalAs(UnmanagedType.I1)] public bool SettingsLoaded;

        [FieldOffset(12460)] public float SettingsDirtyTimer;

        [FieldOffset(12464)] public ImGuiTextBuffer SettingsIniData;

        [FieldOffset(12480)] public ImVector<ImGuiSettingsHandler> SettingsHandlers;

        [FieldOffset(12528)] public ImVector<ImGuiContextHook> Hooks;

        [FieldOffset(12544)] public uint HookIdNext;

        [FieldOffset(12548)] [MarshalAs(UnmanagedType.I1)] public bool LogEnabled;

        [FieldOffset(12552)] public ImGuiLogType LogType;

        [FieldOffset(12560)] public void* LogFile;

        [FieldOffset(12568)] public ImGuiTextBuffer LogBuffer;

        [FieldOffset(12584)] public byte* LogNextPrefix;

        [FieldOffset(12592)] public byte* LogNextSuffix;

        [FieldOffset(12600)] public float LogLinePosY;

        [FieldOffset(12604)] [MarshalAs(UnmanagedType.I1)] public bool LogLineFirstItem;

        [FieldOffset(12608)] public int LogDepthRef;

        [FieldOffset(12612)] public int LogDepthToExpand;

        [FieldOffset(12616)] public int LogDepthToExpandDefault;

        [FieldOffset(12620)] [MarshalAs(UnmanagedType.I1)] public bool DebugItemPickerActive;

        [FieldOffset(12624)] public uint DebugItemPickerBreakId;

        [FieldOffset(12628)] public ImGuiMetricsConfig DebugMetricsConfig;

        [FieldOffset(12644)] public ConstantArray_float_120 FramerateSecPerFrame;

        [FieldOffset(13124)] public int FramerateSecPerFrameIdx;

        [FieldOffset(13128)] public float FramerateSecPerFrameAccum;

        [FieldOffset(13132)] public int WantCaptureMouseNextFrame;

        [FieldOffset(13136)] public int WantCaptureKeyboardNextFrame;

        [FieldOffset(13140)] public int WantTextInputNextFrame;

        [FieldOffset(13144)] public ConstantArray_char_3073 TempBuffer;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper62", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiContext* @this, ImFontAtlas* shared_font_atlas);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor(ImFontAtlas* shared_font_atlas)
        {
            fixed (ImGuiContext* @this = &this)
            { Constructor_PInvoke(@this, shared_font_atlas); }
        }
    }
}

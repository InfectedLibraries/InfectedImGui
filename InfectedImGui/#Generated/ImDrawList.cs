// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 224)]
public unsafe partial struct ImDrawList
{
    [FieldOffset(0)] public ImVector<ImDrawCmd> CmdBuffer;

    [FieldOffset(16)] public ImVector<ushort> IdxBuffer;

    [FieldOffset(32)] public ImVector<ImDrawVert> VtxBuffer;

    [FieldOffset(48)] public int Flags;

    [FieldOffset(56)] public ImDrawListSharedData* _Data;

    [FieldOffset(64)] public byte* _OwnerName;

    [FieldOffset(72)] public uint _VtxCurrentIdx;

    [FieldOffset(80)] public ImDrawVert* _VtxWritePtr;

    [FieldOffset(88)] public ushort* _IdxWritePtr;

    [FieldOffset(96)] public ImVector<ImVec4> _ClipRectStack;

    [FieldOffset(112)] public ImVector<nint> _TextureIdStack;

    [FieldOffset(128)] public ImVector<ImVec2> _Path;

    [FieldOffset(144)] public ImDrawCmd _CmdHeader;

    [FieldOffset(200)] public ImDrawListSplitter _Splitter;

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImDrawList@@QEAA@PEBUImDrawListSharedData@@@Z", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImDrawList* @this, ImDrawListSharedData* shared_data);

    public unsafe void Constructor(ImDrawListSharedData* shared_data)
    {
        fixed (ImDrawList* @this = &this)
        { Constructor_PInvoke(@this, shared_data); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??_DImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void Destructor_PInvoke(ImDrawList* @this);

    public unsafe void Destructor()
    {
        fixed (ImDrawList* @this = &this)
        { Destructor_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PushClipRect@ImDrawList@@QEAAXUImVec2@@0_N@Z", ExactSpelling = true)]
    private static extern void PushClipRect_PInvoke(ImDrawList* @this, ImVec2 clip_rect_min, ImVec2 clip_rect_max, bool intersect_with_current_clip_rect);

    public unsafe void PushClipRect(ImVec2 clip_rect_min, ImVec2 clip_rect_max, bool intersect_with_current_clip_rect)
    {
        fixed (ImDrawList* @this = &this)
        { PushClipRect_PInvoke(@this, clip_rect_min, clip_rect_max, intersect_with_current_clip_rect); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PushClipRectFullScreen@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void PushClipRectFullScreen_PInvoke(ImDrawList* @this);

    public unsafe void PushClipRectFullScreen()
    {
        fixed (ImDrawList* @this = &this)
        { PushClipRectFullScreen_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PopClipRect@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void PopClipRect_PInvoke(ImDrawList* @this);

    public unsafe void PopClipRect()
    {
        fixed (ImDrawList* @this = &this)
        { PopClipRect_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PushTextureID@ImDrawList@@QEAAXPEAX@Z", ExactSpelling = true)]
    private static extern void PushTextureID_PInvoke(ImDrawList* @this, void* texture_id);

    public unsafe void PushTextureID(void* texture_id)
    {
        fixed (ImDrawList* @this = &this)
        { PushTextureID_PInvoke(@this, texture_id); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PopTextureID@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void PopTextureID_PInvoke(ImDrawList* @this);

    public unsafe void PopTextureID()
    {
        fixed (ImDrawList* @this = &this)
        { PopTextureID_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetClipRectMin@ImDrawList@@QEBA?AUImVec2@@XZ", ExactSpelling = true)]
    private static extern ImVec2 GetClipRectMin_PInvoke(ImDrawList* @this);

    public unsafe ImVec2 GetClipRectMin()
    {
        fixed (ImDrawList* @this = &this)
        { return GetClipRectMin_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetClipRectMax@ImDrawList@@QEBA?AUImVec2@@XZ", ExactSpelling = true)]
    private static extern ImVec2 GetClipRectMax_PInvoke(ImDrawList* @this);

    public unsafe ImVec2 GetClipRectMax()
    {
        fixed (ImDrawList* @this = &this)
        { return GetClipRectMax_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddLine@ImDrawList@@QEAAXAEBUImVec2@@0IM@Z", ExactSpelling = true)]
    private static extern void AddLine_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, uint col, float thickness);

    public unsafe void AddLine(ImVec2* p1, ImVec2* p2, uint col, float thickness)
    {
        fixed (ImDrawList* @this = &this)
        { AddLine_PInvoke(@this, p1, p2, col, thickness); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddRect@ImDrawList@@QEAAXAEBUImVec2@@0IMHM@Z", ExactSpelling = true)]
    private static extern void AddRect_PInvoke(ImDrawList* @this, ImVec2* p_min, ImVec2* p_max, uint col, float rounding, int rounding_corners, float thickness);

    public unsafe void AddRect(ImVec2* p_min, ImVec2* p_max, uint col, float rounding, int rounding_corners, float thickness)
    {
        fixed (ImDrawList* @this = &this)
        { AddRect_PInvoke(@this, p_min, p_max, col, rounding, rounding_corners, thickness); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddRectFilled@ImDrawList@@QEAAXAEBUImVec2@@0IMH@Z", ExactSpelling = true)]
    private static extern void AddRectFilled_PInvoke(ImDrawList* @this, ImVec2* p_min, ImVec2* p_max, uint col, float rounding, int rounding_corners);

    public unsafe void AddRectFilled(ImVec2* p_min, ImVec2* p_max, uint col, float rounding, int rounding_corners)
    {
        fixed (ImDrawList* @this = &this)
        { AddRectFilled_PInvoke(@this, p_min, p_max, col, rounding, rounding_corners); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddRectFilledMultiColor@ImDrawList@@QEAAXAEBUImVec2@@0IIII@Z", ExactSpelling = true)]
    private static extern void AddRectFilledMultiColor_PInvoke(ImDrawList* @this, ImVec2* p_min, ImVec2* p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);

    public unsafe void AddRectFilledMultiColor(ImVec2* p_min, ImVec2* p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
    {
        fixed (ImDrawList* @this = &this)
        { AddRectFilledMultiColor_PInvoke(@this, p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddQuad@ImDrawList@@QEAAXAEBUImVec2@@000IM@Z", ExactSpelling = true)]
    private static extern void AddQuad_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col, float thickness);

    public unsafe void AddQuad(ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col, float thickness)
    {
        fixed (ImDrawList* @this = &this)
        { AddQuad_PInvoke(@this, p1, p2, p3, p4, col, thickness); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddQuadFilled@ImDrawList@@QEAAXAEBUImVec2@@000I@Z", ExactSpelling = true)]
    private static extern void AddQuadFilled_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col);

    public unsafe void AddQuadFilled(ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { AddQuadFilled_PInvoke(@this, p1, p2, p3, p4, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddTriangle@ImDrawList@@QEAAXAEBUImVec2@@00IM@Z", ExactSpelling = true)]
    private static extern void AddTriangle_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col, float thickness);

    public unsafe void AddTriangle(ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col, float thickness)
    {
        fixed (ImDrawList* @this = &this)
        { AddTriangle_PInvoke(@this, p1, p2, p3, col, thickness); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddTriangleFilled@ImDrawList@@QEAAXAEBUImVec2@@00I@Z", ExactSpelling = true)]
    private static extern void AddTriangleFilled_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col);

    public unsafe void AddTriangleFilled(ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { AddTriangleFilled_PInvoke(@this, p1, p2, p3, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddCircle@ImDrawList@@QEAAXAEBUImVec2@@MIHM@Z", ExactSpelling = true)]
    private static extern void AddCircle_PInvoke(ImDrawList* @this, ImVec2* center, float radius, uint col, int num_segments, float thickness);

    public unsafe void AddCircle(ImVec2* center, float radius, uint col, int num_segments, float thickness)
    {
        fixed (ImDrawList* @this = &this)
        { AddCircle_PInvoke(@this, center, radius, col, num_segments, thickness); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddCircleFilled@ImDrawList@@QEAAXAEBUImVec2@@MIH@Z", ExactSpelling = true)]
    private static extern void AddCircleFilled_PInvoke(ImDrawList* @this, ImVec2* center, float radius, uint col, int num_segments);

    public unsafe void AddCircleFilled(ImVec2* center, float radius, uint col, int num_segments)
    {
        fixed (ImDrawList* @this = &this)
        { AddCircleFilled_PInvoke(@this, center, radius, col, num_segments); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddNgon@ImDrawList@@QEAAXAEBUImVec2@@MIHM@Z", ExactSpelling = true)]
    private static extern void AddNgon_PInvoke(ImDrawList* @this, ImVec2* center, float radius, uint col, int num_segments, float thickness);

    public unsafe void AddNgon(ImVec2* center, float radius, uint col, int num_segments, float thickness)
    {
        fixed (ImDrawList* @this = &this)
        { AddNgon_PInvoke(@this, center, radius, col, num_segments, thickness); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddNgonFilled@ImDrawList@@QEAAXAEBUImVec2@@MIH@Z", ExactSpelling = true)]
    private static extern void AddNgonFilled_PInvoke(ImDrawList* @this, ImVec2* center, float radius, uint col, int num_segments);

    public unsafe void AddNgonFilled(ImVec2* center, float radius, uint col, int num_segments)
    {
        fixed (ImDrawList* @this = &this)
        { AddNgonFilled_PInvoke(@this, center, radius, col, num_segments); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddText@ImDrawList@@QEAAXAEBUImVec2@@IPEBD1@Z", ExactSpelling = true)]
    private static extern void AddText_PInvoke(ImDrawList* @this, ImVec2* pos, uint col, byte* text_begin, byte* text_end);

    public unsafe void AddText(ImVec2* pos, uint col, byte* text_begin, byte* text_end)
    {
        fixed (ImDrawList* @this = &this)
        { AddText_PInvoke(@this, pos, col, text_begin, text_end); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddText@ImDrawList@@QEAAXPEBUImFont@@MAEBUImVec2@@IPEBD2MPEBUImVec4@@@Z", ExactSpelling = true)]
    private static extern void AddText_PInvoke(ImDrawList* @this, ImFont* font, float font_size, ImVec2* pos, uint col, byte* text_begin, byte* text_end, float wrap_width, ImVec4* cpu_fine_clip_rect);

    public unsafe void AddText(ImFont* font, float font_size, ImVec2* pos, uint col, byte* text_begin, byte* text_end, float wrap_width, ImVec4* cpu_fine_clip_rect)
    {
        fixed (ImDrawList* @this = &this)
        { AddText_PInvoke(@this, font, font_size, pos, col, text_begin, text_end, wrap_width, cpu_fine_clip_rect); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddPolyline@ImDrawList@@QEAAXPEBUImVec2@@HI_NM@Z", ExactSpelling = true)]
    private static extern void AddPolyline_PInvoke(ImDrawList* @this, ImVec2* points, int num_points, uint col, bool closed, float thickness);

    public unsafe void AddPolyline(ImVec2* points, int num_points, uint col, bool closed, float thickness)
    {
        fixed (ImDrawList* @this = &this)
        { AddPolyline_PInvoke(@this, points, num_points, col, closed, thickness); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddConvexPolyFilled@ImDrawList@@QEAAXPEBUImVec2@@HI@Z", ExactSpelling = true)]
    private static extern void AddConvexPolyFilled_PInvoke(ImDrawList* @this, ImVec2* points, int num_points, uint col);

    public unsafe void AddConvexPolyFilled(ImVec2* points, int num_points, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { AddConvexPolyFilled_PInvoke(@this, points, num_points, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddBezierCurve@ImDrawList@@QEAAXAEBUImVec2@@000IMH@Z", ExactSpelling = true)]
    private static extern void AddBezierCurve_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col, float thickness, int num_segments);

    public unsafe void AddBezierCurve(ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col, float thickness, int num_segments)
    {
        fixed (ImDrawList* @this = &this)
        { AddBezierCurve_PInvoke(@this, p1, p2, p3, p4, col, thickness, num_segments); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddImage@ImDrawList@@QEAAXPEAXAEBUImVec2@@111I@Z", ExactSpelling = true)]
    private static extern void AddImage_PInvoke(ImDrawList* @this, void* user_texture_id, ImVec2* p_min, ImVec2* p_max, ImVec2* uv_min, ImVec2* uv_max, uint col);

    public unsafe void AddImage(void* user_texture_id, ImVec2* p_min, ImVec2* p_max, ImVec2* uv_min, ImVec2* uv_max, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { AddImage_PInvoke(@this, user_texture_id, p_min, p_max, uv_min, uv_max, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddImageQuad@ImDrawList@@QEAAXPEAXAEBUImVec2@@1111111I@Z", ExactSpelling = true)]
    private static extern void AddImageQuad_PInvoke(ImDrawList* @this, void* user_texture_id, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, ImVec2* uv1, ImVec2* uv2, ImVec2* uv3, ImVec2* uv4, uint col);

    public unsafe void AddImageQuad(void* user_texture_id, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, ImVec2* uv1, ImVec2* uv2, ImVec2* uv3, ImVec2* uv4, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { AddImageQuad_PInvoke(@this, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddImageRounded@ImDrawList@@QEAAXPEAXAEBUImVec2@@111IMH@Z", ExactSpelling = true)]
    private static extern void AddImageRounded_PInvoke(ImDrawList* @this, void* user_texture_id, ImVec2* p_min, ImVec2* p_max, ImVec2* uv_min, ImVec2* uv_max, uint col, float rounding, int rounding_corners);

    public unsafe void AddImageRounded(void* user_texture_id, ImVec2* p_min, ImVec2* p_max, ImVec2* uv_min, ImVec2* uv_max, uint col, float rounding, int rounding_corners)
    {
        fixed (ImDrawList* @this = &this)
        { AddImageRounded_PInvoke(@this, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, rounding_corners); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathClear@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void PathClear_PInvoke(ImDrawList* @this);

    public unsafe void PathClear()
    {
        fixed (ImDrawList* @this = &this)
        { PathClear_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathLineTo@ImDrawList@@QEAAXAEBUImVec2@@@Z", ExactSpelling = true)]
    private static extern void PathLineTo_PInvoke(ImDrawList* @this, ImVec2* pos);

    public unsafe void PathLineTo(ImVec2* pos)
    {
        fixed (ImDrawList* @this = &this)
        { PathLineTo_PInvoke(@this, pos); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathLineToMergeDuplicate@ImDrawList@@QEAAXAEBUImVec2@@@Z", ExactSpelling = true)]
    private static extern void PathLineToMergeDuplicate_PInvoke(ImDrawList* @this, ImVec2* pos);

    public unsafe void PathLineToMergeDuplicate(ImVec2* pos)
    {
        fixed (ImDrawList* @this = &this)
        { PathLineToMergeDuplicate_PInvoke(@this, pos); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathFillConvex@ImDrawList@@QEAAXI@Z", ExactSpelling = true)]
    private static extern void PathFillConvex_PInvoke(ImDrawList* @this, uint col);

    public unsafe void PathFillConvex(uint col)
    {
        fixed (ImDrawList* @this = &this)
        { PathFillConvex_PInvoke(@this, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathStroke@ImDrawList@@QEAAXI_NM@Z", ExactSpelling = true)]
    private static extern void PathStroke_PInvoke(ImDrawList* @this, uint col, bool closed, float thickness);

    public unsafe void PathStroke(uint col, bool closed, float thickness)
    {
        fixed (ImDrawList* @this = &this)
        { PathStroke_PInvoke(@this, col, closed, thickness); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathArcTo@ImDrawList@@QEAAXAEBUImVec2@@MMMH@Z", ExactSpelling = true)]
    private static extern void PathArcTo_PInvoke(ImDrawList* @this, ImVec2* center, float radius, float a_min, float a_max, int num_segments);

    public unsafe void PathArcTo(ImVec2* center, float radius, float a_min, float a_max, int num_segments)
    {
        fixed (ImDrawList* @this = &this)
        { PathArcTo_PInvoke(@this, center, radius, a_min, a_max, num_segments); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathArcToFast@ImDrawList@@QEAAXAEBUImVec2@@MHH@Z", ExactSpelling = true)]
    private static extern void PathArcToFast_PInvoke(ImDrawList* @this, ImVec2* center, float radius, int a_min_of_12, int a_max_of_12);

    public unsafe void PathArcToFast(ImVec2* center, float radius, int a_min_of_12, int a_max_of_12)
    {
        fixed (ImDrawList* @this = &this)
        { PathArcToFast_PInvoke(@this, center, radius, a_min_of_12, a_max_of_12); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathBezierCurveTo@ImDrawList@@QEAAXAEBUImVec2@@00H@Z", ExactSpelling = true)]
    private static extern void PathBezierCurveTo_PInvoke(ImDrawList* @this, ImVec2* p2, ImVec2* p3, ImVec2* p4, int num_segments);

    public unsafe void PathBezierCurveTo(ImVec2* p2, ImVec2* p3, ImVec2* p4, int num_segments)
    {
        fixed (ImDrawList* @this = &this)
        { PathBezierCurveTo_PInvoke(@this, p2, p3, p4, num_segments); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PathRect@ImDrawList@@QEAAXAEBUImVec2@@0MH@Z", ExactSpelling = true)]
    private static extern void PathRect_PInvoke(ImDrawList* @this, ImVec2* rect_min, ImVec2* rect_max, float rounding, int rounding_corners);

    public unsafe void PathRect(ImVec2* rect_min, ImVec2* rect_max, float rounding, int rounding_corners)
    {
        fixed (ImDrawList* @this = &this)
        { PathRect_PInvoke(@this, rect_min, rect_max, rounding, rounding_corners); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddCallback@ImDrawList@@QEAAXP6AXPEBU1@PEBUImDrawCmd@@@ZPEAX@Z", ExactSpelling = true)]
    private static extern void AddCallback_PInvoke(ImDrawList* @this, delegate* unmanaged[Cdecl]<ImDrawList*, ImDrawCmd*, void>* callback, void* callback_data);

    public unsafe void AddCallback(delegate* unmanaged[Cdecl]<ImDrawList*, ImDrawCmd*, void>* callback, void* callback_data)
    {
        fixed (ImDrawList* @this = &this)
        { AddCallback_PInvoke(@this, callback, callback_data); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddDrawCmd@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void AddDrawCmd_PInvoke(ImDrawList* @this);

    public unsafe void AddDrawCmd()
    {
        fixed (ImDrawList* @this = &this)
        { AddDrawCmd_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?CloneOutput@ImDrawList@@QEBAPEAU1@XZ", ExactSpelling = true)]
    private static extern ImDrawList* CloneOutput_PInvoke(ImDrawList* @this);

    public unsafe ImDrawList* CloneOutput()
    {
        fixed (ImDrawList* @this = &this)
        { return CloneOutput_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ChannelsSplit@ImDrawList@@QEAAXH@Z", ExactSpelling = true)]
    private static extern void ChannelsSplit_PInvoke(ImDrawList* @this, int count);

    public unsafe void ChannelsSplit(int count)
    {
        fixed (ImDrawList* @this = &this)
        { ChannelsSplit_PInvoke(@this, count); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ChannelsMerge@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void ChannelsMerge_PInvoke(ImDrawList* @this);

    public unsafe void ChannelsMerge()
    {
        fixed (ImDrawList* @this = &this)
        { ChannelsMerge_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ChannelsSetCurrent@ImDrawList@@QEAAXH@Z", ExactSpelling = true)]
    private static extern void ChannelsSetCurrent_PInvoke(ImDrawList* @this, int n);

    public unsafe void ChannelsSetCurrent(int n)
    {
        fixed (ImDrawList* @this = &this)
        { ChannelsSetCurrent_PInvoke(@this, n); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PrimReserve@ImDrawList@@QEAAXHH@Z", ExactSpelling = true)]
    private static extern void PrimReserve_PInvoke(ImDrawList* @this, int idx_count, int vtx_count);

    public unsafe void PrimReserve(int idx_count, int vtx_count)
    {
        fixed (ImDrawList* @this = &this)
        { PrimReserve_PInvoke(@this, idx_count, vtx_count); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PrimUnreserve@ImDrawList@@QEAAXHH@Z", ExactSpelling = true)]
    private static extern void PrimUnreserve_PInvoke(ImDrawList* @this, int idx_count, int vtx_count);

    public unsafe void PrimUnreserve(int idx_count, int vtx_count)
    {
        fixed (ImDrawList* @this = &this)
        { PrimUnreserve_PInvoke(@this, idx_count, vtx_count); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PrimRect@ImDrawList@@QEAAXAEBUImVec2@@0I@Z", ExactSpelling = true)]
    private static extern void PrimRect_PInvoke(ImDrawList* @this, ImVec2* a, ImVec2* b, uint col);

    public unsafe void PrimRect(ImVec2* a, ImVec2* b, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { PrimRect_PInvoke(@this, a, b, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PrimRectUV@ImDrawList@@QEAAXAEBUImVec2@@000I@Z", ExactSpelling = true)]
    private static extern void PrimRectUV_PInvoke(ImDrawList* @this, ImVec2* a, ImVec2* b, ImVec2* uv_a, ImVec2* uv_b, uint col);

    public unsafe void PrimRectUV(ImVec2* a, ImVec2* b, ImVec2* uv_a, ImVec2* uv_b, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { PrimRectUV_PInvoke(@this, a, b, uv_a, uv_b, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PrimQuadUV@ImDrawList@@QEAAXAEBUImVec2@@0000000I@Z", ExactSpelling = true)]
    private static extern void PrimQuadUV_PInvoke(ImDrawList* @this, ImVec2* a, ImVec2* b, ImVec2* c, ImVec2* d, ImVec2* uv_a, ImVec2* uv_b, ImVec2* uv_c, ImVec2* uv_d, uint col);

    public unsafe void PrimQuadUV(ImVec2* a, ImVec2* b, ImVec2* c, ImVec2* d, ImVec2* uv_a, ImVec2* uv_b, ImVec2* uv_c, ImVec2* uv_d, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { PrimQuadUV_PInvoke(@this, a, b, c, d, uv_a, uv_b, uv_c, uv_d, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PrimWriteVtx@ImDrawList@@QEAAXAEBUImVec2@@0I@Z", ExactSpelling = true)]
    private static extern void PrimWriteVtx_PInvoke(ImDrawList* @this, ImVec2* pos, ImVec2* uv, uint col);

    public unsafe void PrimWriteVtx(ImVec2* pos, ImVec2* uv, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { PrimWriteVtx_PInvoke(@this, pos, uv, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PrimWriteIdx@ImDrawList@@QEAAXG@Z", ExactSpelling = true)]
    private static extern void PrimWriteIdx_PInvoke(ImDrawList* @this, ushort idx);

    public unsafe void PrimWriteIdx(ushort idx)
    {
        fixed (ImDrawList* @this = &this)
        { PrimWriteIdx_PInvoke(@this, idx); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?PrimVtx@ImDrawList@@QEAAXAEBUImVec2@@0I@Z", ExactSpelling = true)]
    private static extern void PrimVtx_PInvoke(ImDrawList* @this, ImVec2* pos, ImVec2* uv, uint col);

    public unsafe void PrimVtx(ImVec2* pos, ImVec2* uv, uint col)
    {
        fixed (ImDrawList* @this = &this)
        { PrimVtx_PInvoke(@this, pos, uv, col); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_ResetForNewFrame@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void _ResetForNewFrame_PInvoke(ImDrawList* @this);

    public unsafe void _ResetForNewFrame()
    {
        fixed (ImDrawList* @this = &this)
        { _ResetForNewFrame_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_ClearFreeMemory@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void _ClearFreeMemory_PInvoke(ImDrawList* @this);

    public unsafe void _ClearFreeMemory()
    {
        fixed (ImDrawList* @this = &this)
        { _ClearFreeMemory_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_PopUnusedDrawCmd@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void _PopUnusedDrawCmd_PInvoke(ImDrawList* @this);

    public unsafe void _PopUnusedDrawCmd()
    {
        fixed (ImDrawList* @this = &this)
        { _PopUnusedDrawCmd_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_OnChangedClipRect@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void _OnChangedClipRect_PInvoke(ImDrawList* @this);

    public unsafe void _OnChangedClipRect()
    {
        fixed (ImDrawList* @this = &this)
        { _OnChangedClipRect_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_OnChangedTextureID@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void _OnChangedTextureID_PInvoke(ImDrawList* @this);

    public unsafe void _OnChangedTextureID()
    {
        fixed (ImDrawList* @this = &this)
        { _OnChangedTextureID_PInvoke(@this); }
    }

    [DllImport("TODO.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?_OnChangedVtxOffset@ImDrawList@@QEAAXXZ", ExactSpelling = true)]
    private static extern void _OnChangedVtxOffset_PInvoke(ImDrawList* @this);

    public unsafe void _OnChangedVtxOffset()
    {
        fixed (ImDrawList* @this = &this)
        { _OnChangedVtxOffset_PInvoke(@this); }
    }
}
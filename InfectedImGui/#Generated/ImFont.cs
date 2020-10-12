// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 112)]
public unsafe partial struct ImFont
{
    [FieldOffset(0)] public ImVector<float> IndexAdvanceX;

    [FieldOffset(16)] public float FallbackAdvanceX;

    [FieldOffset(20)] public float FontSize;

    [FieldOffset(24)] public ImVector<ushort> IndexLookup;

    [FieldOffset(40)] public ImVector<ImFontGlyph> Glyphs;

    [FieldOffset(56)] public ImFontGlyph* FallbackGlyph;

    [FieldOffset(64)] public ImFontAtlas* ContainerAtlas;

    [FieldOffset(72)] public ImFontConfig* ConfigData;

    [FieldOffset(80)] public short ConfigDataCount;

    [FieldOffset(82)] public ushort FallbackChar;

    [FieldOffset(84)] public ushort EllipsisChar;

    [FieldOffset(86)] public bool DirtyLookupTables;

    [FieldOffset(88)] public float Scale;

    [FieldOffset(92)] public float Ascent;

    [FieldOffset(96)] public float Descent;

    [FieldOffset(100)] public int MetricsTotalSurface;

    [FieldOffset(104)] public ConstantArray_ImU8_2 Used4kPagesMap;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImFont@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImFont* @this);

    public unsafe void Constructor()
    {
        fixed (ImFont* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??_DImFont@@QEAAXXZ", ExactSpelling = true)]
    private static extern void Destructor_PInvoke(ImFont* @this);

    public unsafe void Destructor()
    {
        fixed (ImFont* @this = &this)
        { Destructor_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?FindGlyph@ImFont@@QEBAPEBUImFontGlyph@@G@Z", ExactSpelling = true)]
    private static extern ImFontGlyph* FindGlyph_PInvoke(ImFont* @this, ushort c);

    public unsafe ImFontGlyph* FindGlyph(ushort c)
    {
        fixed (ImFont* @this = &this)
        { return FindGlyph_PInvoke(@this, c); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?FindGlyphNoFallback@ImFont@@QEBAPEBUImFontGlyph@@G@Z", ExactSpelling = true)]
    private static extern ImFontGlyph* FindGlyphNoFallback_PInvoke(ImFont* @this, ushort c);

    public unsafe ImFontGlyph* FindGlyphNoFallback(ushort c)
    {
        fixed (ImFont* @this = &this)
        { return FindGlyphNoFallback_PInvoke(@this, c); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetCharAdvance@ImFont@@QEBAMG@Z", ExactSpelling = true)]
    private static extern float GetCharAdvance_PInvoke(ImFont* @this, ushort c);

    public unsafe float GetCharAdvance(ushort c)
    {
        fixed (ImFont* @this = &this)
        { return GetCharAdvance_PInvoke(@this, c); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?IsLoaded@ImFont@@QEBA_NXZ", ExactSpelling = true)]
    private static extern bool IsLoaded_PInvoke(ImFont* @this);

    public unsafe bool IsLoaded()
    {
        fixed (ImFont* @this = &this)
        { return IsLoaded_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetDebugName@ImFont@@QEBAPEBDXZ", ExactSpelling = true)]
    private static extern byte* GetDebugName_PInvoke(ImFont* @this);

    public unsafe byte* GetDebugName()
    {
        fixed (ImFont* @this = &this)
        { return GetDebugName_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?CalcTextSizeA@ImFont@@QEBA?AUImVec2@@MMMPEBD0PEAPEBD@Z", ExactSpelling = true)]
    private static extern ImVec2 CalcTextSizeA_PInvoke(ImFont* @this, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);

    public unsafe ImVec2 CalcTextSizeA(float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining)
    {
        fixed (ImFont* @this = &this)
        { return CalcTextSizeA_PInvoke(@this, size, max_width, wrap_width, text_begin, text_end, remaining); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?CalcWordWrapPositionA@ImFont@@QEBAPEBDMPEBD0M@Z", ExactSpelling = true)]
    private static extern byte* CalcWordWrapPositionA_PInvoke(ImFont* @this, float scale, byte* text, byte* text_end, float wrap_width);

    public unsafe byte* CalcWordWrapPositionA(float scale, byte* text, byte* text_end, float wrap_width)
    {
        fixed (ImFont* @this = &this)
        { return CalcWordWrapPositionA_PInvoke(@this, scale, text, text_end, wrap_width); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?RenderChar@ImFont@@QEBAXPEAUImDrawList@@MUImVec2@@IG@Z", ExactSpelling = true)]
    private static extern void RenderChar_PInvoke(ImFont* @this, ImDrawList* draw_list, float size, ImVec2 pos, uint col, ushort c);

    public unsafe void RenderChar(ImDrawList* draw_list, float size, ImVec2 pos, uint col, ushort c)
    {
        fixed (ImFont* @this = &this)
        { RenderChar_PInvoke(@this, draw_list, size, pos, col, c); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?RenderText@ImFont@@QEBAXPEAUImDrawList@@MUImVec2@@IAEBUImVec4@@PEBD3M_N@Z", ExactSpelling = true)]
    private static extern void RenderText_PInvoke(ImFont* @this, ImDrawList* draw_list, float size, ImVec2 pos, uint col, ImVec4* clip_rect, byte* text_begin, byte* text_end, float wrap_width, bool cpu_fine_clip);

    public unsafe void RenderText(ImDrawList* draw_list, float size, ImVec2 pos, uint col, ImVec4* clip_rect, byte* text_begin, byte* text_end, float wrap_width, bool cpu_fine_clip)
    {
        fixed (ImFont* @this = &this)
        { RenderText_PInvoke(@this, draw_list, size, pos, col, clip_rect, text_begin, text_end, wrap_width, cpu_fine_clip); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?BuildLookupTable@ImFont@@QEAAXXZ", ExactSpelling = true)]
    private static extern void BuildLookupTable_PInvoke(ImFont* @this);

    public unsafe void BuildLookupTable()
    {
        fixed (ImFont* @this = &this)
        { BuildLookupTable_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClearOutputData@ImFont@@QEAAXXZ", ExactSpelling = true)]
    private static extern void ClearOutputData_PInvoke(ImFont* @this);

    public unsafe void ClearOutputData()
    {
        fixed (ImFont* @this = &this)
        { ClearOutputData_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GrowIndex@ImFont@@QEAAXH@Z", ExactSpelling = true)]
    private static extern void GrowIndex_PInvoke(ImFont* @this, int new_size);

    public unsafe void GrowIndex(int new_size)
    {
        fixed (ImFont* @this = &this)
        { GrowIndex_PInvoke(@this, new_size); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddGlyph@ImFont@@QEAAXPEBUImFontConfig@@GMMMMMMMMM@Z", ExactSpelling = true)]
    private static extern void AddGlyph_PInvoke(ImFont* @this, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);

    public unsafe void AddGlyph(ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
    {
        fixed (ImFont* @this = &this)
        { AddGlyph_PInvoke(@this, src_cfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddRemapChar@ImFont@@QEAAXGG_N@Z", ExactSpelling = true)]
    private static extern void AddRemapChar_PInvoke(ImFont* @this, ushort dst, ushort src, bool overwrite_dst);

    public unsafe void AddRemapChar(ushort dst, ushort src, bool overwrite_dst)
    {
        fixed (ImFont* @this = &this)
        { AddRemapChar_PInvoke(@this, dst, src, overwrite_dst); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetGlyphVisible@ImFont@@QEAAXG_N@Z", ExactSpelling = true)]
    private static extern void SetGlyphVisible_PInvoke(ImFont* @this, ushort c, bool visible);

    public unsafe void SetGlyphVisible(ushort c, bool visible)
    {
        fixed (ImFont* @this = &this)
        { SetGlyphVisible_PInvoke(@this, c, visible); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetFallbackChar@ImFont@@QEAAXG@Z", ExactSpelling = true)]
    private static extern void SetFallbackChar_PInvoke(ImFont* @this, ushort c);

    public unsafe void SetFallbackChar(ushort c)
    {
        fixed (ImFont* @this = &this)
        { SetFallbackChar_PInvoke(@this, c); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?IsGlyphRangeUnused@ImFont@@QEAA_NII@Z", ExactSpelling = true)]
    private static extern bool IsGlyphRangeUnused_PInvoke(ImFont* @this, uint c_begin, uint c_last);

    public unsafe bool IsGlyphRangeUnused(uint c_begin, uint c_last)
    {
        fixed (ImFont* @this = &this)
        { return IsGlyphRangeUnused_PInvoke(@this, c_begin, c_last); }
    }
}

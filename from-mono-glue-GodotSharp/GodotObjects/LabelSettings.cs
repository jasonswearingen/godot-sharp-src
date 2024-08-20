namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.LabelSettings"/> is a resource that provides common settings to customize the text in a <see cref="Godot.Label"/>. It will take priority over the properties defined in <see cref="Godot.Control.Theme"/>. The resource can be shared between multiple labels and changed on the fly, so it's convenient and flexible way to setup text style.</para>
/// </summary>
public partial class LabelSettings : Resource
{
    /// <summary>
    /// <para>Vertical space between lines when the text is multiline.</para>
    /// </summary>
    public float LineSpacing
    {
        get
        {
            return GetLineSpacing();
        }
        set
        {
            SetLineSpacing(value);
        }
    }

    /// <summary>
    /// <para><see cref="Godot.Font"/> used for the text.</para>
    /// </summary>
    public Font Font
    {
        get
        {
            return GetFont();
        }
        set
        {
            SetFont(value);
        }
    }

    /// <summary>
    /// <para>Size of the text.</para>
    /// </summary>
    public int FontSize
    {
        get
        {
            return GetFontSize();
        }
        set
        {
            SetFontSize(value);
        }
    }

    /// <summary>
    /// <para>Color of the text.</para>
    /// </summary>
    public Color FontColor
    {
        get
        {
            return GetFontColor();
        }
        set
        {
            SetFontColor(value);
        }
    }

    /// <summary>
    /// <para>Text outline size.</para>
    /// </summary>
    public int OutlineSize
    {
        get
        {
            return GetOutlineSize();
        }
        set
        {
            SetOutlineSize(value);
        }
    }

    /// <summary>
    /// <para>The color of the outline.</para>
    /// </summary>
    public Color OutlineColor
    {
        get
        {
            return GetOutlineColor();
        }
        set
        {
            SetOutlineColor(value);
        }
    }

    /// <summary>
    /// <para>Size of the shadow effect.</para>
    /// </summary>
    public int ShadowSize
    {
        get
        {
            return GetShadowSize();
        }
        set
        {
            SetShadowSize(value);
        }
    }

    /// <summary>
    /// <para>Color of the shadow effect. If alpha is <c>0</c>, no shadow will be drawn.</para>
    /// </summary>
    public Color ShadowColor
    {
        get
        {
            return GetShadowColor();
        }
        set
        {
            SetShadowColor(value);
        }
    }

    /// <summary>
    /// <para>Offset of the shadow effect, in pixels.</para>
    /// </summary>
    public Vector2 ShadowOffset
    {
        get
        {
            return GetShadowOffset();
        }
        set
        {
            SetShadowOffset(value);
        }
    }

    private static readonly System.Type CachedType = typeof(LabelSettings);

    private static readonly StringName NativeName = "LabelSettings";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public LabelSettings() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal LabelSettings(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLineSpacing, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetLineSpacing(float spacing)
    {
        NativeCalls.godot_icall_1_62(MethodBind0, GodotObject.GetPtr(this), spacing);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLineSpacing, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetLineSpacing()
    {
        return NativeCalls.godot_icall_0_63(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFont, 1262170328ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFont(Font font)
    {
        NativeCalls.godot_icall_1_55(MethodBind2, GodotObject.GetPtr(this), GodotObject.GetPtr(font));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFont, 3229501585ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Font GetFont()
    {
        return (Font)NativeCalls.godot_icall_0_58(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFontSize, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFontSize(int size)
    {
        NativeCalls.godot_icall_1_36(MethodBind4, GodotObject.GetPtr(this), size);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFontSize, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetFontSize()
    {
        return NativeCalls.godot_icall_0_37(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFontColor, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetFontColor(Color color)
    {
        NativeCalls.godot_icall_1_195(MethodBind6, GodotObject.GetPtr(this), &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFontColor, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetFontColor()
    {
        return NativeCalls.godot_icall_0_196(MethodBind7, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOutlineSize, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetOutlineSize(int size)
    {
        NativeCalls.godot_icall_1_36(MethodBind8, GodotObject.GetPtr(this), size);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOutlineSize, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetOutlineSize()
    {
        return NativeCalls.godot_icall_0_37(MethodBind9, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOutlineColor, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetOutlineColor(Color color)
    {
        NativeCalls.godot_icall_1_195(MethodBind10, GodotObject.GetPtr(this), &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOutlineColor, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetOutlineColor()
    {
        return NativeCalls.godot_icall_0_196(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetShadowSize, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetShadowSize(int size)
    {
        NativeCalls.godot_icall_1_36(MethodBind12, GodotObject.GetPtr(this), size);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetShadowSize, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetShadowSize()
    {
        return NativeCalls.godot_icall_0_37(MethodBind13, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetShadowColor, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetShadowColor(Color color)
    {
        NativeCalls.godot_icall_1_195(MethodBind14, GodotObject.GetPtr(this), &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetShadowColor, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetShadowColor()
    {
        return NativeCalls.godot_icall_0_196(MethodBind15, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetShadowOffset, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetShadowOffset(Vector2 offset)
    {
        NativeCalls.godot_icall_1_34(MethodBind16, GodotObject.GetPtr(this), &offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetShadowOffset, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetShadowOffset()
    {
        return NativeCalls.godot_icall_0_35(MethodBind17, GodotObject.GetPtr(this));
    }

    /// <summary>
    /// Invokes the method with the given name, using the given arguments.
    /// This method is used by Godot to invoke methods from the engine side.
    /// Do not call or override this method.
    /// </summary>
    /// <param name="method">Name of the method to invoke.</param>
    /// <param name="args">Arguments to use with the invoked method.</param>
    /// <param name="ret">Value returned by the invoked method.</param>
#pragma warning disable CS0618 // Member is obsolete
    protected internal override bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret)
    {
        return base.InvokeGodotClassMethod(method, args, out ret);
    }
#pragma warning restore CS0618

    /// <summary>
    /// Check if the type contains a method with the given name.
    /// This method is used by Godot to check if a method exists before invoking it.
    /// Do not call or override this method.
    /// </summary>
    /// <param name="method">Name of the method to check for.</param>

    protected internal override bool HasGodotClassMethod(in godot_string_name method)
    {
        return base.HasGodotClassMethod(method);
    }

    /// <summary>
    /// Check if the type contains a signal with the given name.
    /// This method is used by Godot to check if a signal exists before raising it.
    /// Do not call or override this method.
    /// </summary>
    /// <param name="signal">Name of the signal to check for.</param>

    protected internal override bool HasGodotClassSignal(in godot_string_name signal)
    {
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : Resource.PropertyName
    {
        /// <summary>
        /// Cached name for the 'line_spacing' property.
        /// </summary>
        public static readonly StringName LineSpacing = "line_spacing";
        /// <summary>
        /// Cached name for the 'font' property.
        /// </summary>
        public static readonly StringName Font = "font";
        /// <summary>
        /// Cached name for the 'font_size' property.
        /// </summary>
        public static readonly StringName FontSize = "font_size";
        /// <summary>
        /// Cached name for the 'font_color' property.
        /// </summary>
        public static readonly StringName FontColor = "font_color";
        /// <summary>
        /// Cached name for the 'outline_size' property.
        /// </summary>
        public static readonly StringName OutlineSize = "outline_size";
        /// <summary>
        /// Cached name for the 'outline_color' property.
        /// </summary>
        public static readonly StringName OutlineColor = "outline_color";
        /// <summary>
        /// Cached name for the 'shadow_size' property.
        /// </summary>
        public static readonly StringName ShadowSize = "shadow_size";
        /// <summary>
        /// Cached name for the 'shadow_color' property.
        /// </summary>
        public static readonly StringName ShadowColor = "shadow_color";
        /// <summary>
        /// Cached name for the 'shadow_offset' property.
        /// </summary>
        public static readonly StringName ShadowOffset = "shadow_offset";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Resource.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_line_spacing' method.
        /// </summary>
        public static readonly StringName SetLineSpacing = "set_line_spacing";
        /// <summary>
        /// Cached name for the 'get_line_spacing' method.
        /// </summary>
        public static readonly StringName GetLineSpacing = "get_line_spacing";
        /// <summary>
        /// Cached name for the 'set_font' method.
        /// </summary>
        public static readonly StringName SetFont = "set_font";
        /// <summary>
        /// Cached name for the 'get_font' method.
        /// </summary>
        public static readonly StringName GetFont = "get_font";
        /// <summary>
        /// Cached name for the 'set_font_size' method.
        /// </summary>
        public static readonly StringName SetFontSize = "set_font_size";
        /// <summary>
        /// Cached name for the 'get_font_size' method.
        /// </summary>
        public static readonly StringName GetFontSize = "get_font_size";
        /// <summary>
        /// Cached name for the 'set_font_color' method.
        /// </summary>
        public static readonly StringName SetFontColor = "set_font_color";
        /// <summary>
        /// Cached name for the 'get_font_color' method.
        /// </summary>
        public static readonly StringName GetFontColor = "get_font_color";
        /// <summary>
        /// Cached name for the 'set_outline_size' method.
        /// </summary>
        public static readonly StringName SetOutlineSize = "set_outline_size";
        /// <summary>
        /// Cached name for the 'get_outline_size' method.
        /// </summary>
        public static readonly StringName GetOutlineSize = "get_outline_size";
        /// <summary>
        /// Cached name for the 'set_outline_color' method.
        /// </summary>
        public static readonly StringName SetOutlineColor = "set_outline_color";
        /// <summary>
        /// Cached name for the 'get_outline_color' method.
        /// </summary>
        public static readonly StringName GetOutlineColor = "get_outline_color";
        /// <summary>
        /// Cached name for the 'set_shadow_size' method.
        /// </summary>
        public static readonly StringName SetShadowSize = "set_shadow_size";
        /// <summary>
        /// Cached name for the 'get_shadow_size' method.
        /// </summary>
        public static readonly StringName GetShadowSize = "get_shadow_size";
        /// <summary>
        /// Cached name for the 'set_shadow_color' method.
        /// </summary>
        public static readonly StringName SetShadowColor = "set_shadow_color";
        /// <summary>
        /// Cached name for the 'get_shadow_color' method.
        /// </summary>
        public static readonly StringName GetShadowColor = "get_shadow_color";
        /// <summary>
        /// Cached name for the 'set_shadow_offset' method.
        /// </summary>
        public static readonly StringName SetShadowOffset = "set_shadow_offset";
        /// <summary>
        /// Cached name for the 'get_shadow_offset' method.
        /// </summary>
        public static readonly StringName GetShadowOffset = "get_shadow_offset";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Resource.SignalName
    {
    }
}

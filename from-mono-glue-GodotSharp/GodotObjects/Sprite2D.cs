namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>A node that displays a 2D texture. The texture displayed can be a region from a larger atlas texture, or a frame from a sprite sheet animation.</para>
/// </summary>
public partial class Sprite2D : Node2D
{
    /// <summary>
    /// <para><see cref="Godot.Texture2D"/> object to draw.</para>
    /// </summary>
    public Texture2D Texture
    {
        get
        {
            return GetTexture();
        }
        set
        {
            SetTexture(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, texture is centered.</para>
    /// <para><b>Note:</b> For games with a pixel art aesthetic, textures may appear deformed when centered. This is caused by their position being between pixels. To prevent this, set this property to <see langword="false"/>, or consider enabling <c>ProjectSettings.rendering/2d/snap/snap_2d_vertices_to_pixel</c> and <c>ProjectSettings.rendering/2d/snap/snap_2d_transforms_to_pixel</c>.</para>
    /// </summary>
    public bool Centered
    {
        get
        {
            return IsCentered();
        }
        set
        {
            SetCentered(value);
        }
    }

    /// <summary>
    /// <para>The texture's drawing offset.</para>
    /// </summary>
    public Vector2 Offset
    {
        get
        {
            return GetOffset();
        }
        set
        {
            SetOffset(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, texture is flipped horizontally.</para>
    /// </summary>
    public bool FlipH
    {
        get
        {
            return IsFlippedH();
        }
        set
        {
            SetFlipH(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, texture is flipped vertically.</para>
    /// </summary>
    public bool FlipV
    {
        get
        {
            return IsFlippedV();
        }
        set
        {
            SetFlipV(value);
        }
    }

    /// <summary>
    /// <para>The number of columns in the sprite sheet. When this property is changed, <see cref="Godot.Sprite2D.Frame"/> is adjusted so that the same visual frame is maintained (same row and column). If that's impossible, <see cref="Godot.Sprite2D.Frame"/> is reset to <c>0</c>.</para>
    /// </summary>
    public int Hframes
    {
        get
        {
            return GetHframes();
        }
        set
        {
            SetHframes(value);
        }
    }

    /// <summary>
    /// <para>The number of rows in the sprite sheet. When this property is changed, <see cref="Godot.Sprite2D.Frame"/> is adjusted so that the same visual frame is maintained (same row and column). If that's impossible, <see cref="Godot.Sprite2D.Frame"/> is reset to <c>0</c>.</para>
    /// </summary>
    public int Vframes
    {
        get
        {
            return GetVframes();
        }
        set
        {
            SetVframes(value);
        }
    }

    /// <summary>
    /// <para>Current frame to display from sprite sheet. <see cref="Godot.Sprite2D.Hframes"/> or <see cref="Godot.Sprite2D.Vframes"/> must be greater than 1. This property is automatically adjusted when <see cref="Godot.Sprite2D.Hframes"/> or <see cref="Godot.Sprite2D.Vframes"/> are changed to keep pointing to the same visual frame (same column and row). If that's impossible, this value is reset to <c>0</c>.</para>
    /// </summary>
    public int Frame
    {
        get
        {
            return GetFrame();
        }
        set
        {
            SetFrame(value);
        }
    }

    /// <summary>
    /// <para>Coordinates of the frame to display from sprite sheet. This is as an alias for the <see cref="Godot.Sprite2D.Frame"/> property. <see cref="Godot.Sprite2D.Hframes"/> or <see cref="Godot.Sprite2D.Vframes"/> must be greater than 1.</para>
    /// </summary>
    public Vector2I FrameCoords
    {
        get
        {
            return GetFrameCoords();
        }
        set
        {
            SetFrameCoords(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, texture is cut from a larger atlas texture. See <see cref="Godot.Sprite2D.RegionRect"/>.</para>
    /// </summary>
    public bool RegionEnabled
    {
        get
        {
            return IsRegionEnabled();
        }
        set
        {
            SetRegionEnabled(value);
        }
    }

    /// <summary>
    /// <para>The region of the atlas texture to display. <see cref="Godot.Sprite2D.RegionEnabled"/> must be <see langword="true"/>.</para>
    /// </summary>
    public Rect2 RegionRect
    {
        get
        {
            return GetRegionRect();
        }
        set
        {
            SetRegionRect(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the outermost pixels get blurred out. <see cref="Godot.Sprite2D.RegionEnabled"/> must be <see langword="true"/>.</para>
    /// </summary>
    public bool RegionFilterClipEnabled
    {
        get
        {
            return IsRegionFilterClipEnabled();
        }
        set
        {
            SetRegionFilterClipEnabled(value);
        }
    }

    private static readonly System.Type CachedType = typeof(Sprite2D);

    private static readonly StringName NativeName = "Sprite2D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public Sprite2D() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal Sprite2D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTexture, 4051416890ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTexture(Texture2D texture)
    {
        NativeCalls.godot_icall_1_55(MethodBind0, GodotObject.GetPtr(this), GodotObject.GetPtr(texture));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTexture, 3635182373ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Texture2D GetTexture()
    {
        return (Texture2D)NativeCalls.godot_icall_0_58(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCentered, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCentered(bool centered)
    {
        NativeCalls.godot_icall_1_41(MethodBind2, GodotObject.GetPtr(this), centered.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsCentered, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsCentered()
    {
        return NativeCalls.godot_icall_0_40(MethodBind3, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOffset, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetOffset(Vector2 offset)
    {
        NativeCalls.godot_icall_1_34(MethodBind4, GodotObject.GetPtr(this), &offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOffset, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetOffset()
    {
        return NativeCalls.godot_icall_0_35(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFlipH, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFlipH(bool flipH)
    {
        NativeCalls.godot_icall_1_41(MethodBind6, GodotObject.GetPtr(this), flipH.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsFlippedH, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsFlippedH()
    {
        return NativeCalls.godot_icall_0_40(MethodBind7, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFlipV, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFlipV(bool flipV)
    {
        NativeCalls.godot_icall_1_41(MethodBind8, GodotObject.GetPtr(this), flipV.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsFlippedV, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsFlippedV()
    {
        return NativeCalls.godot_icall_0_40(MethodBind9, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRegionEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRegionEnabled(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind10, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsRegionEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsRegionEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind11, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsPixelOpaque, 556197845ul);

    /// <summary>
    /// <para>Returns <see langword="true"/>, if the pixel at the given position is opaque and <see langword="false"/> in other case. The position is in local coordinates.</para>
    /// <para><b>Note:</b> It also returns <see langword="false"/>, if the sprite's texture is <see langword="null"/> or if the given position is invalid.</para>
    /// </summary>
    public unsafe bool IsPixelOpaque(Vector2 pos)
    {
        return NativeCalls.godot_icall_1_184(MethodBind12, GodotObject.GetPtr(this), &pos).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRegionRect, 2046264180ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetRegionRect(Rect2 rect)
    {
        NativeCalls.godot_icall_1_174(MethodBind13, GodotObject.GetPtr(this), &rect);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRegionRect, 1639390495ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Rect2 GetRegionRect()
    {
        return NativeCalls.godot_icall_0_175(MethodBind14, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRegionFilterClipEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRegionFilterClipEnabled(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind15, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsRegionFilterClipEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsRegionFilterClipEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind16, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFrame, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFrame(int frame)
    {
        NativeCalls.godot_icall_1_36(MethodBind17, GodotObject.GetPtr(this), frame);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFrame, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetFrame()
    {
        return NativeCalls.godot_icall_0_37(MethodBind18, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFrameCoords, 1130785943ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetFrameCoords(Vector2I coords)
    {
        NativeCalls.godot_icall_1_32(MethodBind19, GodotObject.GetPtr(this), &coords);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFrameCoords, 3690982128ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2I GetFrameCoords()
    {
        return NativeCalls.godot_icall_0_33(MethodBind20, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetVframes, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetVframes(int vframes)
    {
        NativeCalls.godot_icall_1_36(MethodBind21, GodotObject.GetPtr(this), vframes);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetVframes, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetVframes()
    {
        return NativeCalls.godot_icall_0_37(MethodBind22, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHframes, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHframes(int hframes)
    {
        NativeCalls.godot_icall_1_36(MethodBind23, GodotObject.GetPtr(this), hframes);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHframes, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetHframes()
    {
        return NativeCalls.godot_icall_0_37(MethodBind24, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRect, 1639390495ul);

    /// <summary>
    /// <para>Returns a <see cref="Godot.Rect2"/> representing the Sprite2D's boundary in local coordinates. Can be used to detect if the Sprite2D was clicked.</para>
    /// <para><b>Example:</b></para>
    /// <para><code>
    /// public override void _Input(InputEvent @event)
    /// {
    ///     if (@event is InputEventMouseButton inputEventMouse)
    ///     {
    ///         if (inputEventMouse.Pressed &amp;&amp; inputEventMouse.ButtonIndex == MouseButton.Left)
    ///         {
    ///             if (GetRect().HasPoint(ToLocal(inputEventMouse.Position)))
    ///             {
    ///                 GD.Print("A click!");
    ///             }
    ///         }
    ///     }
    /// }
    /// </code></para>
    /// </summary>
    public Rect2 GetRect()
    {
        return NativeCalls.godot_icall_0_175(MethodBind25, GodotObject.GetPtr(this));
    }

    /// <summary>
    /// <para>Emitted when the <see cref="Godot.Sprite2D.Frame"/> changes.</para>
    /// </summary>
    public event Action FrameChanged
    {
        add => Connect(SignalName.FrameChanged, Callable.From(value));
        remove => Disconnect(SignalName.FrameChanged, Callable.From(value));
    }

    /// <summary>
    /// <para>Emitted when the <see cref="Godot.Sprite2D.Texture"/> changes.</para>
    /// </summary>
    public event Action TextureChanged
    {
        add => Connect(SignalName.TextureChanged, Callable.From(value));
        remove => Disconnect(SignalName.TextureChanged, Callable.From(value));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_frame_changed = "FrameChanged";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_texture_changed = "TextureChanged";

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
        if (signal == SignalName.FrameChanged)
        {
            if (HasGodotClassSignal(SignalProxyName_frame_changed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.TextureChanged)
        {
            if (HasGodotClassSignal(SignalProxyName_texture_changed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : Node2D.PropertyName
    {
        /// <summary>
        /// Cached name for the 'texture' property.
        /// </summary>
        public static readonly StringName Texture = "texture";
        /// <summary>
        /// Cached name for the 'centered' property.
        /// </summary>
        public static readonly StringName Centered = "centered";
        /// <summary>
        /// Cached name for the 'offset' property.
        /// </summary>
        public static readonly StringName Offset = "offset";
        /// <summary>
        /// Cached name for the 'flip_h' property.
        /// </summary>
        public static readonly StringName FlipH = "flip_h";
        /// <summary>
        /// Cached name for the 'flip_v' property.
        /// </summary>
        public static readonly StringName FlipV = "flip_v";
        /// <summary>
        /// Cached name for the 'hframes' property.
        /// </summary>
        public static readonly StringName Hframes = "hframes";
        /// <summary>
        /// Cached name for the 'vframes' property.
        /// </summary>
        public static readonly StringName Vframes = "vframes";
        /// <summary>
        /// Cached name for the 'frame' property.
        /// </summary>
        public static readonly StringName Frame = "frame";
        /// <summary>
        /// Cached name for the 'frame_coords' property.
        /// </summary>
        public static readonly StringName FrameCoords = "frame_coords";
        /// <summary>
        /// Cached name for the 'region_enabled' property.
        /// </summary>
        public static readonly StringName RegionEnabled = "region_enabled";
        /// <summary>
        /// Cached name for the 'region_rect' property.
        /// </summary>
        public static readonly StringName RegionRect = "region_rect";
        /// <summary>
        /// Cached name for the 'region_filter_clip_enabled' property.
        /// </summary>
        public static readonly StringName RegionFilterClipEnabled = "region_filter_clip_enabled";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Node2D.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_texture' method.
        /// </summary>
        public static readonly StringName SetTexture = "set_texture";
        /// <summary>
        /// Cached name for the 'get_texture' method.
        /// </summary>
        public static readonly StringName GetTexture = "get_texture";
        /// <summary>
        /// Cached name for the 'set_centered' method.
        /// </summary>
        public static readonly StringName SetCentered = "set_centered";
        /// <summary>
        /// Cached name for the 'is_centered' method.
        /// </summary>
        public static readonly StringName IsCentered = "is_centered";
        /// <summary>
        /// Cached name for the 'set_offset' method.
        /// </summary>
        public static readonly StringName SetOffset = "set_offset";
        /// <summary>
        /// Cached name for the 'get_offset' method.
        /// </summary>
        public static readonly StringName GetOffset = "get_offset";
        /// <summary>
        /// Cached name for the 'set_flip_h' method.
        /// </summary>
        public static readonly StringName SetFlipH = "set_flip_h";
        /// <summary>
        /// Cached name for the 'is_flipped_h' method.
        /// </summary>
        public static readonly StringName IsFlippedH = "is_flipped_h";
        /// <summary>
        /// Cached name for the 'set_flip_v' method.
        /// </summary>
        public static readonly StringName SetFlipV = "set_flip_v";
        /// <summary>
        /// Cached name for the 'is_flipped_v' method.
        /// </summary>
        public static readonly StringName IsFlippedV = "is_flipped_v";
        /// <summary>
        /// Cached name for the 'set_region_enabled' method.
        /// </summary>
        public static readonly StringName SetRegionEnabled = "set_region_enabled";
        /// <summary>
        /// Cached name for the 'is_region_enabled' method.
        /// </summary>
        public static readonly StringName IsRegionEnabled = "is_region_enabled";
        /// <summary>
        /// Cached name for the 'is_pixel_opaque' method.
        /// </summary>
        public static readonly StringName IsPixelOpaque = "is_pixel_opaque";
        /// <summary>
        /// Cached name for the 'set_region_rect' method.
        /// </summary>
        public static readonly StringName SetRegionRect = "set_region_rect";
        /// <summary>
        /// Cached name for the 'get_region_rect' method.
        /// </summary>
        public static readonly StringName GetRegionRect = "get_region_rect";
        /// <summary>
        /// Cached name for the 'set_region_filter_clip_enabled' method.
        /// </summary>
        public static readonly StringName SetRegionFilterClipEnabled = "set_region_filter_clip_enabled";
        /// <summary>
        /// Cached name for the 'is_region_filter_clip_enabled' method.
        /// </summary>
        public static readonly StringName IsRegionFilterClipEnabled = "is_region_filter_clip_enabled";
        /// <summary>
        /// Cached name for the 'set_frame' method.
        /// </summary>
        public static readonly StringName SetFrame = "set_frame";
        /// <summary>
        /// Cached name for the 'get_frame' method.
        /// </summary>
        public static readonly StringName GetFrame = "get_frame";
        /// <summary>
        /// Cached name for the 'set_frame_coords' method.
        /// </summary>
        public static readonly StringName SetFrameCoords = "set_frame_coords";
        /// <summary>
        /// Cached name for the 'get_frame_coords' method.
        /// </summary>
        public static readonly StringName GetFrameCoords = "get_frame_coords";
        /// <summary>
        /// Cached name for the 'set_vframes' method.
        /// </summary>
        public static readonly StringName SetVframes = "set_vframes";
        /// <summary>
        /// Cached name for the 'get_vframes' method.
        /// </summary>
        public static readonly StringName GetVframes = "get_vframes";
        /// <summary>
        /// Cached name for the 'set_hframes' method.
        /// </summary>
        public static readonly StringName SetHframes = "set_hframes";
        /// <summary>
        /// Cached name for the 'get_hframes' method.
        /// </summary>
        public static readonly StringName GetHframes = "get_hframes";
        /// <summary>
        /// Cached name for the 'get_rect' method.
        /// </summary>
        public static readonly StringName GetRect = "get_rect";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Node2D.SignalName
    {
        /// <summary>
        /// Cached name for the 'frame_changed' signal.
        /// </summary>
        public static readonly StringName FrameChanged = "frame_changed";
        /// <summary>
        /// Cached name for the 'texture_changed' signal.
        /// </summary>
        public static readonly StringName TextureChanged = "texture_changed";
    }
}

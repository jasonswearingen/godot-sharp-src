namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Composition layers allow 2D viewports to be displayed inside of the headset by the XR compositor through special projections that retain their quality. This allows for rendering clear text while keeping the layer at a native resolution.</para>
/// <para><b>Note:</b> If the OpenXR runtime doesn't support the given composition layer type, a fallback mesh can be generated with a <see cref="Godot.ViewportTexture"/>, in order to emulate the composition layer.</para>
/// </summary>
public partial class OpenXRCompositionLayer : Node3D
{
    /// <summary>
    /// <para>The <see cref="Godot.SubViewport"/> to render on the composition layer.</para>
    /// </summary>
    public SubViewport LayerViewport
    {
        get
        {
            return GetLayerViewport();
        }
        set
        {
            SetLayerViewport(value);
        }
    }

    /// <summary>
    /// <para>The sort order for this composition layer. Higher numbers will be shown in front of lower numbers.</para>
    /// <para><b>Note:</b> This will have no effect if a fallback mesh is being used.</para>
    /// </summary>
    public int SortOrder
    {
        get
        {
            return GetSortOrder();
        }
        set
        {
            SetSortOrder(value);
        }
    }

    /// <summary>
    /// <para>Enables the blending the layer using its alpha channel.</para>
    /// <para>Can be combined with <see cref="Godot.Viewport.TransparentBg"/> to give the layer a transparent background.</para>
    /// </summary>
    public bool AlphaBlend
    {
        get
        {
            return GetAlphaBlend();
        }
        set
        {
            SetAlphaBlend(value);
        }
    }

    /// <summary>
    /// <para>Enables a technique called "hole punching", which allows putting the composition layer behind the main projection layer (i.e. setting <see cref="Godot.OpenXRCompositionLayer.SortOrder"/> to a negative value) while "punching a hole" through everything rendered by Godot so that the layer is still visible.</para>
    /// <para>This can be used to create the illusion that the composition layer exists in the same 3D space as everything rendered by Godot, allowing objects to appear to pass both behind or in front of the composition layer.</para>
    /// </summary>
    public bool EnableHolePunch
    {
        get
        {
            return GetEnableHolePunch();
        }
        set
        {
            SetEnableHolePunch(value);
        }
    }

    private static readonly System.Type CachedType = typeof(OpenXRCompositionLayer);

    private static readonly StringName NativeName = "OpenXRCompositionLayer";

    internal OpenXRCompositionLayer() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal OpenXRCompositionLayer(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLayerViewport, 3888077664ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetLayerViewport(SubViewport viewport)
    {
        NativeCalls.godot_icall_1_55(MethodBind0, GodotObject.GetPtr(this), GodotObject.GetPtr(viewport));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLayerViewport, 3750751911ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public SubViewport GetLayerViewport()
    {
        return (SubViewport)NativeCalls.godot_icall_0_52(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEnableHolePunch, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEnableHolePunch(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind2, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEnableHolePunch, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetEnableHolePunch()
    {
        return NativeCalls.godot_icall_0_40(MethodBind3, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSortOrder, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSortOrder(int order)
    {
        NativeCalls.godot_icall_1_36(MethodBind4, GodotObject.GetPtr(this), order);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSortOrder, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetSortOrder()
    {
        return NativeCalls.godot_icall_0_37(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAlphaBlend, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAlphaBlend(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind6, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAlphaBlend, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetAlphaBlend()
    {
        return NativeCalls.godot_icall_0_40(MethodBind7, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsNativelySupported, 36873697ul);

    /// <summary>
    /// <para>Returns true if the OpenXR runtime natively supports this composition layer type.</para>
    /// <para><b>Note:</b> This will only return an accurate result after the OpenXR session has started.</para>
    /// </summary>
    public bool IsNativelySupported()
    {
        return NativeCalls.godot_icall_0_40(MethodBind8, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IntersectsRay, 1091262597ul);

    /// <summary>
    /// <para>Returns UV coordinates where the given ray intersects with the composition layer. <paramref name="origin"/> and <paramref name="direction"/> must be in global space.</para>
    /// <para>Returns <c>Vector2(-1.0, -1.0)</c> if the ray doesn't intersect.</para>
    /// </summary>
    public unsafe Vector2 IntersectsRay(Vector3 origin, Vector3 direction)
    {
        return NativeCalls.godot_icall_2_814(MethodBind9, GodotObject.GetPtr(this), &origin, &direction);
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
    public new class PropertyName : Node3D.PropertyName
    {
        /// <summary>
        /// Cached name for the 'layer_viewport' property.
        /// </summary>
        public static readonly StringName LayerViewport = "layer_viewport";
        /// <summary>
        /// Cached name for the 'sort_order' property.
        /// </summary>
        public static readonly StringName SortOrder = "sort_order";
        /// <summary>
        /// Cached name for the 'alpha_blend' property.
        /// </summary>
        public static readonly StringName AlphaBlend = "alpha_blend";
        /// <summary>
        /// Cached name for the 'enable_hole_punch' property.
        /// </summary>
        public static readonly StringName EnableHolePunch = "enable_hole_punch";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Node3D.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_layer_viewport' method.
        /// </summary>
        public static readonly StringName SetLayerViewport = "set_layer_viewport";
        /// <summary>
        /// Cached name for the 'get_layer_viewport' method.
        /// </summary>
        public static readonly StringName GetLayerViewport = "get_layer_viewport";
        /// <summary>
        /// Cached name for the 'set_enable_hole_punch' method.
        /// </summary>
        public static readonly StringName SetEnableHolePunch = "set_enable_hole_punch";
        /// <summary>
        /// Cached name for the 'get_enable_hole_punch' method.
        /// </summary>
        public static readonly StringName GetEnableHolePunch = "get_enable_hole_punch";
        /// <summary>
        /// Cached name for the 'set_sort_order' method.
        /// </summary>
        public static readonly StringName SetSortOrder = "set_sort_order";
        /// <summary>
        /// Cached name for the 'get_sort_order' method.
        /// </summary>
        public static readonly StringName GetSortOrder = "get_sort_order";
        /// <summary>
        /// Cached name for the 'set_alpha_blend' method.
        /// </summary>
        public static readonly StringName SetAlphaBlend = "set_alpha_blend";
        /// <summary>
        /// Cached name for the 'get_alpha_blend' method.
        /// </summary>
        public static readonly StringName GetAlphaBlend = "get_alpha_blend";
        /// <summary>
        /// Cached name for the 'is_natively_supported' method.
        /// </summary>
        public static readonly StringName IsNativelySupported = "is_natively_supported";
        /// <summary>
        /// Cached name for the 'intersects_ray' method.
        /// </summary>
        public static readonly StringName IntersectsRay = "intersects_ray";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Node3D.SignalName
    {
    }
}

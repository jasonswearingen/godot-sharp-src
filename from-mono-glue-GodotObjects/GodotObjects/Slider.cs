namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Abstract base class for sliders, used to adjust a value by moving a grabber along a horizontal or vertical axis. Sliders are <see cref="Godot.Range"/>-based controls.</para>
/// </summary>
public partial class Slider : Range
{
    /// <summary>
    /// <para>If <see langword="true"/>, the slider can be interacted with. If <see langword="false"/>, the value can be changed only by code.</para>
    /// </summary>
    public bool Editable
    {
        get
        {
            return IsEditable();
        }
        set
        {
            SetEditable(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the value can be changed using the mouse wheel.</para>
    /// </summary>
    public bool Scrollable
    {
        get
        {
            return IsScrollable();
        }
        set
        {
            SetScrollable(value);
        }
    }

    /// <summary>
    /// <para>Number of ticks displayed on the slider, including border ticks. Ticks are uniformly-distributed value markers.</para>
    /// </summary>
    public int TickCount
    {
        get
        {
            return GetTicks();
        }
        set
        {
            SetTicks(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the slider will display ticks for minimum and maximum values.</para>
    /// </summary>
    public bool TicksOnBorders
    {
        get
        {
            return GetTicksOnBorders();
        }
        set
        {
            SetTicksOnBorders(value);
        }
    }

    private static readonly System.Type CachedType = typeof(Slider);

    private static readonly StringName NativeName = "Slider";

    internal Slider() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal Slider(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTicks, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTicks(int count)
    {
        NativeCalls.godot_icall_1_36(MethodBind0, GodotObject.GetPtr(this), count);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTicks, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetTicks()
    {
        return NativeCalls.godot_icall_0_37(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTicksOnBorders, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetTicksOnBorders()
    {
        return NativeCalls.godot_icall_0_40(MethodBind2, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTicksOnBorders, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTicksOnBorders(bool ticksOnBorder)
    {
        NativeCalls.godot_icall_1_41(MethodBind3, GodotObject.GetPtr(this), ticksOnBorder.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEditable, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEditable(bool editable)
    {
        NativeCalls.godot_icall_1_41(MethodBind4, GodotObject.GetPtr(this), editable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsEditable, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsEditable()
    {
        return NativeCalls.godot_icall_0_40(MethodBind5, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetScrollable, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetScrollable(bool scrollable)
    {
        NativeCalls.godot_icall_1_41(MethodBind6, GodotObject.GetPtr(this), scrollable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsScrollable, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsScrollable()
    {
        return NativeCalls.godot_icall_0_40(MethodBind7, GodotObject.GetPtr(this)).ToBool();
    }

    /// <summary>
    /// <para>Emitted when dragging is started. This is emitted before the corresponding <see cref="Godot.Range.ValueChanged"/> signal.</para>
    /// </summary>
    public event Action DragStarted
    {
        add => Connect(SignalName.DragStarted, Callable.From(value));
        remove => Disconnect(SignalName.DragStarted, Callable.From(value));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.Slider.DragEnded"/> event of a <see cref="Godot.Slider"/> class.
    /// </summary>
    public delegate void DragEndedEventHandler(bool valueChanged);

    private static void DragEndedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((DragEndedEventHandler)delegateObj)(VariantUtils.ConvertTo<bool>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when dragging stops. If <c>valueChanged</c> is true, <see cref="Godot.Range.Value"/> is different from the value when you started the dragging.</para>
    /// </summary>
    public unsafe event DragEndedEventHandler DragEnded
    {
        add => Connect(SignalName.DragEnded, Callable.CreateWithUnsafeTrampoline(value, &DragEndedTrampoline));
        remove => Disconnect(SignalName.DragEnded, Callable.CreateWithUnsafeTrampoline(value, &DragEndedTrampoline));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_drag_started = "DragStarted";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_drag_ended = "DragEnded";

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
        if (signal == SignalName.DragStarted)
        {
            if (HasGodotClassSignal(SignalProxyName_drag_started.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.DragEnded)
        {
            if (HasGodotClassSignal(SignalProxyName_drag_ended.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : Range.PropertyName
    {
        /// <summary>
        /// Cached name for the 'editable' property.
        /// </summary>
        public static readonly StringName Editable = "editable";
        /// <summary>
        /// Cached name for the 'scrollable' property.
        /// </summary>
        public static readonly StringName Scrollable = "scrollable";
        /// <summary>
        /// Cached name for the 'tick_count' property.
        /// </summary>
        public static readonly StringName TickCount = "tick_count";
        /// <summary>
        /// Cached name for the 'ticks_on_borders' property.
        /// </summary>
        public static readonly StringName TicksOnBorders = "ticks_on_borders";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Range.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_ticks' method.
        /// </summary>
        public static readonly StringName SetTicks = "set_ticks";
        /// <summary>
        /// Cached name for the 'get_ticks' method.
        /// </summary>
        public static readonly StringName GetTicks = "get_ticks";
        /// <summary>
        /// Cached name for the 'get_ticks_on_borders' method.
        /// </summary>
        public static readonly StringName GetTicksOnBorders = "get_ticks_on_borders";
        /// <summary>
        /// Cached name for the 'set_ticks_on_borders' method.
        /// </summary>
        public static readonly StringName SetTicksOnBorders = "set_ticks_on_borders";
        /// <summary>
        /// Cached name for the 'set_editable' method.
        /// </summary>
        public static readonly StringName SetEditable = "set_editable";
        /// <summary>
        /// Cached name for the 'is_editable' method.
        /// </summary>
        public static readonly StringName IsEditable = "is_editable";
        /// <summary>
        /// Cached name for the 'set_scrollable' method.
        /// </summary>
        public static readonly StringName SetScrollable = "set_scrollable";
        /// <summary>
        /// Cached name for the 'is_scrollable' method.
        /// </summary>
        public static readonly StringName IsScrollable = "is_scrollable";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Range.SignalName
    {
        /// <summary>
        /// Cached name for the 'drag_started' signal.
        /// </summary>
        public static readonly StringName DragStarted = "drag_started";
        /// <summary>
        /// Cached name for the 'drag_ended' signal.
        /// </summary>
        public static readonly StringName DragEnded = "drag_ended";
    }
}

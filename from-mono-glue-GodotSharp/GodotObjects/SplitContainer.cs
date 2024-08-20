namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>A container that accepts only two child controls, then arranges them horizontally or vertically and creates a divisor between them. The divisor can be dragged around to change the size relation between the child controls.</para>
/// </summary>
public partial class SplitContainer : Container
{
    public enum DraggerVisibilityEnum : long
    {
        /// <summary>
        /// <para>The split dragger is visible when the cursor hovers it.</para>
        /// </summary>
        Visible = 0,
        /// <summary>
        /// <para>The split dragger is never visible.</para>
        /// </summary>
        Hidden = 1,
        /// <summary>
        /// <para>The split dragger is never visible and its space collapsed.</para>
        /// </summary>
        HiddenCollapsed = 2
    }

    /// <summary>
    /// <para>The initial offset of the splitting between the two <see cref="Godot.Control"/>s, with <c>0</c> being at the end of the first <see cref="Godot.Control"/>.</para>
    /// </summary>
    public int SplitOffset
    {
        get
        {
            return GetSplitOffset();
        }
        set
        {
            SetSplitOffset(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the area of the first <see cref="Godot.Control"/> will be collapsed and the dragger will be disabled.</para>
    /// </summary>
    public bool Collapsed
    {
        get
        {
            return IsCollapsed();
        }
        set
        {
            SetCollapsed(value);
        }
    }

    /// <summary>
    /// <para>Determines the dragger's visibility. See <see cref="Godot.SplitContainer.DraggerVisibilityEnum"/> for details.</para>
    /// </summary>
    public SplitContainer.DraggerVisibilityEnum DraggerVisibility
    {
        get
        {
            return GetDraggerVisibility();
        }
        set
        {
            SetDraggerVisibility(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the <see cref="Godot.SplitContainer"/> will arrange its children vertically, rather than horizontally.</para>
    /// <para>Can't be changed when using <see cref="Godot.HSplitContainer"/> and <see cref="Godot.VSplitContainer"/>.</para>
    /// </summary>
    public bool Vertical
    {
        get
        {
            return IsVertical();
        }
        set
        {
            SetVertical(value);
        }
    }

    private static readonly System.Type CachedType = typeof(SplitContainer);

    private static readonly StringName NativeName = "SplitContainer";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public SplitContainer() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal SplitContainer(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSplitOffset, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSplitOffset(int offset)
    {
        NativeCalls.godot_icall_1_36(MethodBind0, GodotObject.GetPtr(this), offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSplitOffset, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetSplitOffset()
    {
        return NativeCalls.godot_icall_0_37(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClampSplitOffset, 3218959716ul);

    /// <summary>
    /// <para>Clamps the <see cref="Godot.SplitContainer.SplitOffset"/> value to not go outside the currently possible minimal and maximum values.</para>
    /// </summary>
    public void ClampSplitOffset()
    {
        NativeCalls.godot_icall_0_3(MethodBind2, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCollapsed, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCollapsed(bool collapsed)
    {
        NativeCalls.godot_icall_1_41(MethodBind3, GodotObject.GetPtr(this), collapsed.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsCollapsed, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsCollapsed()
    {
        return NativeCalls.godot_icall_0_40(MethodBind4, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDraggerVisibility, 1168273952ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDraggerVisibility(SplitContainer.DraggerVisibilityEnum mode)
    {
        NativeCalls.godot_icall_1_36(MethodBind5, GodotObject.GetPtr(this), (int)mode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDraggerVisibility, 967297479ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public SplitContainer.DraggerVisibilityEnum GetDraggerVisibility()
    {
        return (SplitContainer.DraggerVisibilityEnum)NativeCalls.godot_icall_0_37(MethodBind6, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetVertical, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetVertical(bool vertical)
    {
        NativeCalls.godot_icall_1_41(MethodBind7, GodotObject.GetPtr(this), vertical.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsVertical, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsVertical()
    {
        return NativeCalls.godot_icall_0_40(MethodBind8, GodotObject.GetPtr(this)).ToBool();
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.SplitContainer.Dragged"/> event of a <see cref="Godot.SplitContainer"/> class.
    /// </summary>
    public delegate void DraggedEventHandler(long offset);

    private static void DraggedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((DraggedEventHandler)delegateObj)(VariantUtils.ConvertTo<long>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when the dragger is dragged by user.</para>
    /// </summary>
    public unsafe event DraggedEventHandler Dragged
    {
        add => Connect(SignalName.Dragged, Callable.CreateWithUnsafeTrampoline(value, &DraggedTrampoline));
        remove => Disconnect(SignalName.Dragged, Callable.CreateWithUnsafeTrampoline(value, &DraggedTrampoline));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_dragged = "Dragged";

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
        if (signal == SignalName.Dragged)
        {
            if (HasGodotClassSignal(SignalProxyName_dragged.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : Container.PropertyName
    {
        /// <summary>
        /// Cached name for the 'split_offset' property.
        /// </summary>
        public static readonly StringName SplitOffset = "split_offset";
        /// <summary>
        /// Cached name for the 'collapsed' property.
        /// </summary>
        public static readonly StringName Collapsed = "collapsed";
        /// <summary>
        /// Cached name for the 'dragger_visibility' property.
        /// </summary>
        public static readonly StringName DraggerVisibility = "dragger_visibility";
        /// <summary>
        /// Cached name for the 'vertical' property.
        /// </summary>
        public static readonly StringName Vertical = "vertical";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Container.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_split_offset' method.
        /// </summary>
        public static readonly StringName SetSplitOffset = "set_split_offset";
        /// <summary>
        /// Cached name for the 'get_split_offset' method.
        /// </summary>
        public static readonly StringName GetSplitOffset = "get_split_offset";
        /// <summary>
        /// Cached name for the 'clamp_split_offset' method.
        /// </summary>
        public static readonly StringName ClampSplitOffset = "clamp_split_offset";
        /// <summary>
        /// Cached name for the 'set_collapsed' method.
        /// </summary>
        public static readonly StringName SetCollapsed = "set_collapsed";
        /// <summary>
        /// Cached name for the 'is_collapsed' method.
        /// </summary>
        public static readonly StringName IsCollapsed = "is_collapsed";
        /// <summary>
        /// Cached name for the 'set_dragger_visibility' method.
        /// </summary>
        public static readonly StringName SetDraggerVisibility = "set_dragger_visibility";
        /// <summary>
        /// Cached name for the 'get_dragger_visibility' method.
        /// </summary>
        public static readonly StringName GetDraggerVisibility = "get_dragger_visibility";
        /// <summary>
        /// Cached name for the 'set_vertical' method.
        /// </summary>
        public static readonly StringName SetVertical = "set_vertical";
        /// <summary>
        /// Cached name for the 'is_vertical' method.
        /// </summary>
        public static readonly StringName IsVertical = "is_vertical";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Container.SignalName
    {
        /// <summary>
        /// Cached name for the 'dragged' signal.
        /// </summary>
        public static readonly StringName Dragged = "dragged";
    }
}

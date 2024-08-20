namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.SkeletonModifier3D"/> retrieves a target <see cref="Godot.Skeleton3D"/> by having a <see cref="Godot.Skeleton3D"/> parent.</para>
/// <para>If there is <see cref="Godot.AnimationMixer"/>, modification always performs after playback process of the <see cref="Godot.AnimationMixer"/>.</para>
/// <para>This node should be used to implement custom IK solvers, constraints, or skeleton physics.</para>
/// </summary>
public partial class SkeletonModifier3D : Node3D
{
    /// <summary>
    /// <para>If <see langword="true"/>, the <see cref="Godot.SkeletonModifier3D"/> will be processing.</para>
    /// </summary>
    public bool Active
    {
        get
        {
            return IsActive();
        }
        set
        {
            SetActive(value);
        }
    }

    /// <summary>
    /// <para>Sets the influence of the modification.</para>
    /// <para><b>Note:</b> This value is used by <see cref="Godot.Skeleton3D"/> to blend, so the <see cref="Godot.SkeletonModifier3D"/> should always apply only 100% of the result without interpolation.</para>
    /// </summary>
    public float Influence
    {
        get
        {
            return GetInfluence();
        }
        set
        {
            SetInfluence(value);
        }
    }

    private static readonly System.Type CachedType = typeof(SkeletonModifier3D);

    private static readonly StringName NativeName = "SkeletonModifier3D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public SkeletonModifier3D() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal SkeletonModifier3D(bool memoryOwn) : base(memoryOwn) { }

    /// <summary>
    /// <para>Override this virtual method to implement a custom skeleton modifier. You should do things like get the <see cref="Godot.Skeleton3D"/>'s current pose and apply the pose here.</para>
    /// <para><see cref="Godot.SkeletonModifier3D._ProcessModification()"/> must not apply <see cref="Godot.SkeletonModifier3D.Influence"/> to bone poses because the <see cref="Godot.Skeleton3D"/> automatically applies influence to all bone poses set by the modifier.</para>
    /// </summary>
    public virtual void _ProcessModification()
    {
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSkeleton, 1488626673ul);

    /// <summary>
    /// <para>Get parent <see cref="Godot.Skeleton3D"/> node if found.</para>
    /// </summary>
    public Skeleton3D GetSkeleton()
    {
        return (Skeleton3D)NativeCalls.godot_icall_0_52(MethodBind0, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetActive, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetActive(bool active)
    {
        NativeCalls.godot_icall_1_41(MethodBind1, GodotObject.GetPtr(this), active.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsActive, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsActive()
    {
        return NativeCalls.godot_icall_0_40(MethodBind2, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetInfluence, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetInfluence(float influence)
    {
        NativeCalls.godot_icall_1_62(MethodBind3, GodotObject.GetPtr(this), influence);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetInfluence, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetInfluence()
    {
        return NativeCalls.godot_icall_0_63(MethodBind4, GodotObject.GetPtr(this));
    }

    /// <summary>
    /// <para>Notifies when the modification have been finished.</para>
    /// <para><b>Note:</b> If you want to get the modified bone pose by the modifier, you must use <see cref="Godot.Skeleton3D.GetBonePose(int)"/> or <see cref="Godot.Skeleton3D.GetBoneGlobalPose(int)"/> at the moment this signal is fired.</para>
    /// </summary>
    public event Action ModificationProcessed
    {
        add => Connect(SignalName.ModificationProcessed, Callable.From(value));
        remove => Disconnect(SignalName.ModificationProcessed, Callable.From(value));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__process_modification = "_ProcessModification";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_modification_processed = "ModificationProcessed";

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
        if ((method == MethodProxyName__process_modification || method == MethodName._ProcessModification) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__process_modification.NativeValue))
        {
            _ProcessModification();
            ret = default;
            return true;
        }
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
        if (method == MethodName._ProcessModification)
        {
            if (HasGodotClassMethod(MethodProxyName__process_modification.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
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
        if (signal == SignalName.ModificationProcessed)
        {
            if (HasGodotClassSignal(SignalProxyName_modification_processed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : Node3D.PropertyName
    {
        /// <summary>
        /// Cached name for the 'active' property.
        /// </summary>
        public static readonly StringName Active = "active";
        /// <summary>
        /// Cached name for the 'influence' property.
        /// </summary>
        public static readonly StringName Influence = "influence";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Node3D.MethodName
    {
        /// <summary>
        /// Cached name for the '_process_modification' method.
        /// </summary>
        public static readonly StringName _ProcessModification = "_process_modification";
        /// <summary>
        /// Cached name for the 'get_skeleton' method.
        /// </summary>
        public static readonly StringName GetSkeleton = "get_skeleton";
        /// <summary>
        /// Cached name for the 'set_active' method.
        /// </summary>
        public static readonly StringName SetActive = "set_active";
        /// <summary>
        /// Cached name for the 'is_active' method.
        /// </summary>
        public static readonly StringName IsActive = "is_active";
        /// <summary>
        /// Cached name for the 'set_influence' method.
        /// </summary>
        public static readonly StringName SetInfluence = "set_influence";
        /// <summary>
        /// Cached name for the 'get_influence' method.
        /// </summary>
        public static readonly StringName GetInfluence = "get_influence";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Node3D.SignalName
    {
        /// <summary>
        /// Cached name for the 'modification_processed' signal.
        /// </summary>
        public static readonly StringName ModificationProcessed = "modification_processed";
    }
}

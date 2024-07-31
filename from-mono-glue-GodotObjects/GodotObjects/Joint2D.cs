namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Abstract base class for all joints in 2D physics. 2D joints bind together two physics bodies (<see cref="Godot.Joint2D.NodeA"/> and <see cref="Godot.Joint2D.NodeB"/>) and apply a constraint.</para>
/// </summary>
public partial class Joint2D : Node2D
{
    /// <summary>
    /// <para>Path to the first body (A) attached to the joint. The node must inherit <see cref="Godot.PhysicsBody2D"/>.</para>
    /// </summary>
    public NodePath NodeA
    {
        get
        {
            return GetNodeA();
        }
        set
        {
            SetNodeA(value);
        }
    }

    /// <summary>
    /// <para>Path to the second body (B) attached to the joint. The node must inherit <see cref="Godot.PhysicsBody2D"/>.</para>
    /// </summary>
    public NodePath NodeB
    {
        get
        {
            return GetNodeB();
        }
        set
        {
            SetNodeB(value);
        }
    }

    /// <summary>
    /// <para>When <see cref="Godot.Joint2D.NodeA"/> and <see cref="Godot.Joint2D.NodeB"/> move in different directions the <see cref="Godot.Joint2D.Bias"/> controls how fast the joint pulls them back to their original position. The lower the <see cref="Godot.Joint2D.Bias"/> the more the two bodies can pull on the joint.</para>
    /// <para>When set to <c>0</c>, the default value from <c>ProjectSettings.physics/2d/solver/default_constraint_bias</c> is used.</para>
    /// </summary>
    public float Bias
    {
        get
        {
            return GetBias();
        }
        set
        {
            SetBias(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the two bodies bound together do not collide with each other.</para>
    /// </summary>
    public bool DisableCollision
    {
        get
        {
            return GetExcludeNodesFromCollision();
        }
        set
        {
            SetExcludeNodesFromCollision(value);
        }
    }

    private static readonly System.Type CachedType = typeof(Joint2D);

    private static readonly StringName NativeName = "Joint2D";

    internal Joint2D() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal Joint2D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNodeA, 1348162250ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNodeA(NodePath node)
    {
        NativeCalls.godot_icall_1_116(MethodBind0, GodotObject.GetPtr(this), (godot_node_path)(node?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNodeA, 4075236667ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NodePath GetNodeA()
    {
        return NativeCalls.godot_icall_0_117(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNodeB, 1348162250ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNodeB(NodePath node)
    {
        NativeCalls.godot_icall_1_116(MethodBind2, GodotObject.GetPtr(this), (godot_node_path)(node?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNodeB, 4075236667ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NodePath GetNodeB()
    {
        return NativeCalls.godot_icall_0_117(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBias, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBias(float bias)
    {
        NativeCalls.godot_icall_1_62(MethodBind4, GodotObject.GetPtr(this), bias);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBias, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetBias()
    {
        return NativeCalls.godot_icall_0_63(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetExcludeNodesFromCollision, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetExcludeNodesFromCollision(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind6, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetExcludeNodesFromCollision, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetExcludeNodesFromCollision()
    {
        return NativeCalls.godot_icall_0_40(MethodBind7, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRid, 2944877500ul);

    /// <summary>
    /// <para>Returns the joint's internal <see cref="Godot.Rid"/> from the <see cref="Godot.PhysicsServer2D"/>.</para>
    /// </summary>
    public Rid GetRid()
    {
        return NativeCalls.godot_icall_0_217(MethodBind8, GodotObject.GetPtr(this));
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
    public new class PropertyName : Node2D.PropertyName
    {
        /// <summary>
        /// Cached name for the 'node_a' property.
        /// </summary>
        public static readonly StringName NodeA = "node_a";
        /// <summary>
        /// Cached name for the 'node_b' property.
        /// </summary>
        public static readonly StringName NodeB = "node_b";
        /// <summary>
        /// Cached name for the 'bias' property.
        /// </summary>
        public static readonly StringName Bias = "bias";
        /// <summary>
        /// Cached name for the 'disable_collision' property.
        /// </summary>
        public static readonly StringName DisableCollision = "disable_collision";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Node2D.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_node_a' method.
        /// </summary>
        public static readonly StringName SetNodeA = "set_node_a";
        /// <summary>
        /// Cached name for the 'get_node_a' method.
        /// </summary>
        public static readonly StringName GetNodeA = "get_node_a";
        /// <summary>
        /// Cached name for the 'set_node_b' method.
        /// </summary>
        public static readonly StringName SetNodeB = "set_node_b";
        /// <summary>
        /// Cached name for the 'get_node_b' method.
        /// </summary>
        public static readonly StringName GetNodeB = "get_node_b";
        /// <summary>
        /// Cached name for the 'set_bias' method.
        /// </summary>
        public static readonly StringName SetBias = "set_bias";
        /// <summary>
        /// Cached name for the 'get_bias' method.
        /// </summary>
        public static readonly StringName GetBias = "get_bias";
        /// <summary>
        /// Cached name for the 'set_exclude_nodes_from_collision' method.
        /// </summary>
        public static readonly StringName SetExcludeNodesFromCollision = "set_exclude_nodes_from_collision";
        /// <summary>
        /// Cached name for the 'get_exclude_nodes_from_collision' method.
        /// </summary>
        public static readonly StringName GetExcludeNodesFromCollision = "get_exclude_nodes_from_collision";
        /// <summary>
        /// Cached name for the 'get_rid' method.
        /// </summary>
        public static readonly StringName GetRid = "get_rid";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Node2D.SignalName
    {
    }
}

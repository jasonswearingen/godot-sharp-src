namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Most basic 3D game object, with a <see cref="Godot.Transform3D"/> and visibility settings. All other 3D game objects inherit from <see cref="Godot.Node3D"/>. Use <see cref="Godot.Node3D"/> as a parent node to move, scale, rotate and show/hide children in a 3D project.</para>
/// <para>Affine operations (rotate, scale, translate) happen in parent's local coordinate system, unless the <see cref="Godot.Node3D"/> object is set as top-level. Affine operations in this coordinate system correspond to direct affine operations on the <see cref="Godot.Node3D"/>'s transform. The word local below refers to this coordinate system. The coordinate system that is attached to the <see cref="Godot.Node3D"/> object itself is referred to as object-local coordinate system.</para>
/// <para><b>Note:</b> Unless otherwise specified, all methods that have angle parameters must have angles specified as <i>radians</i>. To convert degrees to radians, use <c>@GlobalScope.deg_to_rad</c>.</para>
/// <para><b>Note:</b> Be aware that "Spatial" nodes are now called "Node3D" starting with Godot 4. Any Godot 3.x references to "Spatial" nodes refer to "Node3D" in Godot 4.</para>
/// </summary>
public partial class Node3D : Node
{
    /// <summary>
    /// <para><see cref="Godot.Node3D"/> nodes receive this notification when their global transform changes. This means that either the current or a parent node changed its transform.</para>
    /// <para>In order for <see cref="Godot.Node3D.NotificationTransformChanged"/> to work, users first need to ask for it, with <see cref="Godot.Node3D.SetNotifyTransform(bool)"/>. The notification is also sent if the node is in the editor context and it has at least one valid gizmo.</para>
    /// </summary>
    public const long NotificationTransformChanged = 2000;
    /// <summary>
    /// <para><see cref="Godot.Node3D"/> nodes receive this notification when they are registered to new <see cref="Godot.World3D"/> resource.</para>
    /// </summary>
    public const long NotificationEnterWorld = 41;
    /// <summary>
    /// <para><see cref="Godot.Node3D"/> nodes receive this notification when they are unregistered from current <see cref="Godot.World3D"/> resource.</para>
    /// </summary>
    public const long NotificationExitWorld = 42;
    /// <summary>
    /// <para><see cref="Godot.Node3D"/> nodes receive this notification when their visibility changes.</para>
    /// </summary>
    public const long NotificationVisibilityChanged = 43;
    /// <summary>
    /// <para><see cref="Godot.Node3D"/> nodes receive this notification when their local transform changes. This is not received when the transform of a parent node is changed.</para>
    /// <para>In order for <see cref="Godot.Node3D.NotificationLocalTransformChanged"/> to work, users first need to ask for it, with <see cref="Godot.Node3D.SetNotifyLocalTransform(bool)"/>.</para>
    /// </summary>
    public const long NotificationLocalTransformChanged = 44;

    public enum RotationEditModeEnum : long
    {
        /// <summary>
        /// <para>The rotation is edited using <see cref="Godot.Vector3"/> Euler angles.</para>
        /// </summary>
        Euler = 0,
        /// <summary>
        /// <para>The rotation is edited using a <see cref="Godot.Quaternion"/>.</para>
        /// </summary>
        Quaternion = 1,
        /// <summary>
        /// <para>The rotation is edited using a <see cref="Godot.Basis"/>. In this mode, <see cref="Godot.Node3D.Scale"/> can't be edited separately.</para>
        /// </summary>
        Basis = 2
    }

    /// <summary>
    /// <para>Local space <see cref="Godot.Transform3D"/> of this node, with respect to the parent node.</para>
    /// </summary>
    public Transform3D Transform
    {
        get
        {
            return GetTransform();
        }
        set
        {
            SetTransform(value);
        }
    }

    /// <summary>
    /// <para>World3D space (global) <see cref="Godot.Transform3D"/> of this node.</para>
    /// </summary>
    public Transform3D GlobalTransform
    {
        get
        {
            return GetGlobalTransform();
        }
        set
        {
            SetGlobalTransform(value);
        }
    }

    /// <summary>
    /// <para>Local position or translation of this node relative to the parent. This is equivalent to <c>transform.origin</c>.</para>
    /// </summary>
    public Vector3 Position
    {
        get
        {
            return GetPosition();
        }
        set
        {
            SetPosition(value);
        }
    }

    /// <summary>
    /// <para>Rotation part of the local transformation in radians, specified in terms of Euler angles. The angles construct a rotation in the order specified by the <see cref="Godot.Node3D.RotationOrder"/> property.</para>
    /// <para><b>Note:</b> In the mathematical sense, rotation is a matrix and not a vector. The three Euler angles, which are the three independent parameters of the Euler-angle parametrization of the rotation matrix, are stored in a <see cref="Godot.Vector3"/> data structure not because the rotation is a vector, but only because <see cref="Godot.Vector3"/> exists as a convenient data-structure to store 3 floating-point numbers. Therefore, applying affine operations on the rotation "vector" is not meaningful.</para>
    /// <para><b>Note:</b> This property is edited in the inspector in degrees. If you want to use degrees in a script, use <see cref="Godot.Node3D.RotationDegrees"/>.</para>
    /// </summary>
    public Vector3 Rotation
    {
        get
        {
            return GetRotation();
        }
        set
        {
            SetRotation(value);
        }
    }

    /// <summary>
    /// <para>Helper property to access <see cref="Godot.Node3D.Rotation"/> in degrees instead of radians.</para>
    /// </summary>
    public Vector3 RotationDegrees
    {
        get
        {
            return GetRotationDegrees();
        }
        set
        {
            SetRotationDegrees(value);
        }
    }

    /// <summary>
    /// <para>Access to the node rotation as a <see cref="Godot.Quaternion"/>. This property is ideal for tweening complex rotations.</para>
    /// </summary>
    public Quaternion Quaternion
    {
        get
        {
            return GetQuaternion();
        }
        set
        {
            SetQuaternion(value);
        }
    }

    /// <summary>
    /// <para>Basis of the <see cref="Godot.Node3D.Transform"/> property. Represents the rotation, scale, and shear of this node.</para>
    /// </summary>
    public Basis Basis
    {
        get
        {
            return GetBasis();
        }
        set
        {
            SetBasis(value);
        }
    }

    /// <summary>
    /// <para>Scale part of the local transformation.</para>
    /// <para><b>Note:</b> Mixed negative scales in 3D are not decomposable from the transformation matrix. Due to the way scale is represented with transformation matrices in Godot, the scale values will either be all positive or all negative.</para>
    /// <para><b>Note:</b> Not all nodes are visually scaled by the <see cref="Godot.Node3D.Scale"/> property. For example, <see cref="Godot.Light3D"/>s are not visually affected by <see cref="Godot.Node3D.Scale"/>.</para>
    /// </summary>
    public Vector3 Scale
    {
        get
        {
            return GetScale();
        }
        set
        {
            SetScale(value);
        }
    }

    /// <summary>
    /// <para>Specify how rotation (and scale) will be presented in the editor.</para>
    /// </summary>
    public Node3D.RotationEditModeEnum RotationEditMode
    {
        get
        {
            return GetRotationEditMode();
        }
        set
        {
            SetRotationEditMode(value);
        }
    }

    /// <summary>
    /// <para>Specify the axis rotation order of the <see cref="Godot.Node3D.Rotation"/> property. The final orientation is constructed by rotating the Euler angles in the order specified by this property.</para>
    /// </summary>
    public EulerOrder RotationOrder
    {
        get
        {
            return GetRotationOrder();
        }
        set
        {
            SetRotationOrder(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the node will not inherit its transformations from its parent. Node transformations are only in global space.</para>
    /// </summary>
    public bool TopLevel
    {
        get
        {
            return IsSetAsTopLevel();
        }
        set
        {
            SetAsTopLevel(value);
        }
    }

    /// <summary>
    /// <para>Global position of this node. This is equivalent to <c>global_transform.origin</c>.</para>
    /// </summary>
    public Vector3 GlobalPosition
    {
        get
        {
            return GetGlobalPosition();
        }
        set
        {
            SetGlobalPosition(value);
        }
    }

    /// <summary>
    /// <para>Global basis of this node. This is equivalent to <c>global_transform.basis</c>.</para>
    /// </summary>
    public Basis GlobalBasis
    {
        get
        {
            return GetGlobalBasis();
        }
        set
        {
            SetGlobalBasis(value);
        }
    }

    /// <summary>
    /// <para>Rotation part of the global transformation in radians, specified in terms of YXZ-Euler angles in the format (X angle, Y angle, Z angle).</para>
    /// <para><b>Note:</b> In the mathematical sense, rotation is a matrix and not a vector. The three Euler angles, which are the three independent parameters of the Euler-angle parametrization of the rotation matrix, are stored in a <see cref="Godot.Vector3"/> data structure not because the rotation is a vector, but only because <see cref="Godot.Vector3"/> exists as a convenient data-structure to store 3 floating-point numbers. Therefore, applying affine operations on the rotation "vector" is not meaningful.</para>
    /// </summary>
    public Vector3 GlobalRotation
    {
        get
        {
            return GetGlobalRotation();
        }
        set
        {
            SetGlobalRotation(value);
        }
    }

    /// <summary>
    /// <para>Helper property to access <see cref="Godot.Node3D.GlobalRotation"/> in degrees instead of radians.</para>
    /// </summary>
    public Vector3 GlobalRotationDegrees
    {
        get
        {
            return GetGlobalRotationDegrees();
        }
        set
        {
            SetGlobalRotationDegrees(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, this node is drawn. The node is only visible if all of its ancestors are visible as well (in other words, <see cref="Godot.Node3D.IsVisibleInTree()"/> must return <see langword="true"/>).</para>
    /// </summary>
    public bool Visible
    {
        get
        {
            return IsVisible();
        }
        set
        {
            SetVisible(value);
        }
    }

    /// <summary>
    /// <para>Defines the visibility range parent for this node and its subtree. The visibility parent must be a GeometryInstance3D. Any visual instance will only be visible if the visibility parent (and all of its visibility ancestors) is hidden by being closer to the camera than its own <see cref="Godot.GeometryInstance3D.VisibilityRangeBegin"/>. Nodes hidden via the <see cref="Godot.Node3D.Visible"/> property are essentially removed from the visibility dependency tree, so dependent instances will not take the hidden node or its ancestors into account.</para>
    /// </summary>
    public NodePath VisibilityParent
    {
        get
        {
            return GetVisibilityParent();
        }
        set
        {
            SetVisibilityParent(value);
        }
    }

    private static readonly System.Type CachedType = typeof(Node3D);

    private static readonly StringName NativeName = "Node3D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public Node3D() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal Node3D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTransform, 2952846383ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetTransform(Transform3D local)
    {
        NativeCalls.godot_icall_1_537(MethodBind0, GodotObject.GetPtr(this), &local);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTransform, 3229777777ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Transform3D GetTransform()
    {
        return NativeCalls.godot_icall_0_178(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPosition, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetPosition(Vector3 position)
    {
        NativeCalls.godot_icall_1_163(MethodBind2, GodotObject.GetPtr(this), &position);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPosition, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetPosition()
    {
        return NativeCalls.godot_icall_0_118(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRotation, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetRotation(Vector3 eulerRadians)
    {
        NativeCalls.godot_icall_1_163(MethodBind4, GodotObject.GetPtr(this), &eulerRadians);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRotation, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetRotation()
    {
        return NativeCalls.godot_icall_0_118(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRotationDegrees, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetRotationDegrees(Vector3 eulerDegrees)
    {
        NativeCalls.godot_icall_1_163(MethodBind6, GodotObject.GetPtr(this), &eulerDegrees);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRotationDegrees, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetRotationDegrees()
    {
        return NativeCalls.godot_icall_0_118(MethodBind7, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRotationOrder, 1820889989ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRotationOrder(EulerOrder order)
    {
        NativeCalls.godot_icall_1_36(MethodBind8, GodotObject.GetPtr(this), (int)order);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRotationOrder, 916939469ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public EulerOrder GetRotationOrder()
    {
        return (EulerOrder)NativeCalls.godot_icall_0_37(MethodBind9, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRotationEditMode, 141483330ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRotationEditMode(Node3D.RotationEditModeEnum editMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind10, GodotObject.GetPtr(this), (int)editMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRotationEditMode, 1572188370ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Node3D.RotationEditModeEnum GetRotationEditMode()
    {
        return (Node3D.RotationEditModeEnum)NativeCalls.godot_icall_0_37(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetScale, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetScale(Vector3 scale)
    {
        NativeCalls.godot_icall_1_163(MethodBind12, GodotObject.GetPtr(this), &scale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetScale, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetScale()
    {
        return NativeCalls.godot_icall_0_118(MethodBind13, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetQuaternion, 1727505552ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetQuaternion(Quaternion quaternion)
    {
        NativeCalls.godot_icall_1_538(MethodBind14, GodotObject.GetPtr(this), &quaternion);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetQuaternion, 1222331677ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Quaternion GetQuaternion()
    {
        return NativeCalls.godot_icall_0_119(MethodBind15, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBasis, 1055510324ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetBasis(Basis basis)
    {
        NativeCalls.godot_icall_1_540(MethodBind16, GodotObject.GetPtr(this), &basis);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBasis, 2716978435ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Basis GetBasis()
    {
        return NativeCalls.godot_icall_0_539(MethodBind17, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGlobalTransform, 2952846383ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetGlobalTransform(Transform3D global)
    {
        NativeCalls.godot_icall_1_537(MethodBind18, GodotObject.GetPtr(this), &global);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGlobalTransform, 3229777777ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Transform3D GetGlobalTransform()
    {
        return NativeCalls.godot_icall_0_178(MethodBind19, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGlobalPosition, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetGlobalPosition(Vector3 position)
    {
        NativeCalls.godot_icall_1_163(MethodBind20, GodotObject.GetPtr(this), &position);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGlobalPosition, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetGlobalPosition()
    {
        return NativeCalls.godot_icall_0_118(MethodBind21, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGlobalBasis, 1055510324ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetGlobalBasis(Basis basis)
    {
        NativeCalls.godot_icall_1_540(MethodBind22, GodotObject.GetPtr(this), &basis);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGlobalBasis, 2716978435ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Basis GetGlobalBasis()
    {
        return NativeCalls.godot_icall_0_539(MethodBind23, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGlobalRotation, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetGlobalRotation(Vector3 eulerRadians)
    {
        NativeCalls.godot_icall_1_163(MethodBind24, GodotObject.GetPtr(this), &eulerRadians);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGlobalRotation, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetGlobalRotation()
    {
        return NativeCalls.godot_icall_0_118(MethodBind25, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGlobalRotationDegrees, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetGlobalRotationDegrees(Vector3 eulerDegrees)
    {
        NativeCalls.godot_icall_1_163(MethodBind26, GodotObject.GetPtr(this), &eulerDegrees);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGlobalRotationDegrees, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetGlobalRotationDegrees()
    {
        return NativeCalls.godot_icall_0_118(MethodBind27, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetParentNode3D, 151077316ul);

    /// <summary>
    /// <para>Returns the parent <see cref="Godot.Node3D"/>, or <see langword="null"/> if no parent exists, the parent is not of type <see cref="Godot.Node3D"/>, or <see cref="Godot.Node3D.TopLevel"/> is <see langword="true"/>.</para>
    /// <para><b>Note:</b> Calling this method is not equivalent to <c>get_parent() as Node3D</c>, which does not take <see cref="Godot.Node3D.TopLevel"/> into account.</para>
    /// </summary>
    public Node3D GetParentNode3D()
    {
        return (Node3D)NativeCalls.godot_icall_0_52(MethodBind28, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetIgnoreTransformNotification, 2586408642ul);

    /// <summary>
    /// <para>Sets whether the node ignores notification that its transformation (global or local) changed.</para>
    /// </summary>
    public void SetIgnoreTransformNotification(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind29, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind30 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAsTopLevel, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAsTopLevel(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind30, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind31 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsSetAsTopLevel, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsSetAsTopLevel()
    {
        return NativeCalls.godot_icall_0_40(MethodBind31, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind32 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDisableScale, 2586408642ul);

    /// <summary>
    /// <para>Sets whether the node uses a scale of <c>(1, 1, 1)</c> or its local transformation scale. Changes to the local transformation scale are preserved.</para>
    /// </summary>
    public void SetDisableScale(bool disable)
    {
        NativeCalls.godot_icall_1_41(MethodBind32, GodotObject.GetPtr(this), disable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind33 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsScaleDisabled, 36873697ul);

    /// <summary>
    /// <para>Returns whether this node uses a scale of <c>(1, 1, 1)</c> or its local transformation scale.</para>
    /// </summary>
    public bool IsScaleDisabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind33, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind34 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetWorld3D, 317588385ul);

    /// <summary>
    /// <para>Returns the current <see cref="Godot.World3D"/> resource this <see cref="Godot.Node3D"/> node is registered to.</para>
    /// </summary>
    public World3D GetWorld3D()
    {
        return (World3D)NativeCalls.godot_icall_0_58(MethodBind34, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind35 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ForceUpdateTransform, 3218959716ul);

    /// <summary>
    /// <para>Forces the transform to update. Transform changes in physics are not instant for performance reasons. Transforms are accumulated and then set. Use this if you need an up-to-date transform when doing physics operations.</para>
    /// </summary>
    public void ForceUpdateTransform()
    {
        NativeCalls.godot_icall_0_3(MethodBind35, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind36 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetVisibilityParent, 1348162250ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetVisibilityParent(NodePath path)
    {
        NativeCalls.godot_icall_1_116(MethodBind36, GodotObject.GetPtr(this), (godot_node_path)(path?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind37 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetVisibilityParent, 4075236667ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NodePath GetVisibilityParent()
    {
        return NativeCalls.godot_icall_0_117(MethodBind37, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind38 = ClassDB_get_method_with_compatibility(NativeName, MethodName.UpdateGizmos, 3218959716ul);

    /// <summary>
    /// <para>Updates all the <see cref="Godot.Node3D"/> gizmos attached to this node.</para>
    /// </summary>
    public void UpdateGizmos()
    {
        NativeCalls.godot_icall_0_3(MethodBind38, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind39 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddGizmo, 1544533845ul);

    /// <summary>
    /// <para>Attach an editor gizmo to this <see cref="Godot.Node3D"/>.</para>
    /// <para><b>Note:</b> The gizmo object would typically be an instance of <c>EditorNode3DGizmo</c>, but the argument type is kept generic to avoid creating a dependency on editor classes in <see cref="Godot.Node3D"/>.</para>
    /// </summary>
    public void AddGizmo(Node3DGizmo gizmo)
    {
        NativeCalls.godot_icall_1_55(MethodBind39, GodotObject.GetPtr(this), GodotObject.GetPtr(gizmo));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind40 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGizmos, 3995934104ul);

    /// <summary>
    /// <para>Returns all the gizmos attached to this <see cref="Godot.Node3D"/>.</para>
    /// </summary>
    public Godot.Collections.Array<Node3DGizmo> GetGizmos()
    {
        return new Godot.Collections.Array<Node3DGizmo>(NativeCalls.godot_icall_0_112(MethodBind40, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind41 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClearGizmos, 3218959716ul);

    /// <summary>
    /// <para>Clear all gizmos attached to this <see cref="Godot.Node3D"/>.</para>
    /// </summary>
    public void ClearGizmos()
    {
        NativeCalls.godot_icall_0_3(MethodBind41, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind42 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSubgizmoSelection, 3317607635ul);

    /// <summary>
    /// <para>Set subgizmo selection for this node in the editor.</para>
    /// <para><b>Note:</b> The gizmo object would typically be an instance of <c>EditorNode3DGizmo</c>, but the argument type is kept generic to avoid creating a dependency on editor classes in <see cref="Godot.Node3D"/>.</para>
    /// </summary>
    public unsafe void SetSubgizmoSelection(Node3DGizmo gizmo, int id, Transform3D transform)
    {
        NativeCalls.godot_icall_3_783(MethodBind42, GodotObject.GetPtr(this), GodotObject.GetPtr(gizmo), id, &transform);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind43 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClearSubgizmoSelection, 3218959716ul);

    /// <summary>
    /// <para>Clears subgizmo selection for this node in the editor. Useful when subgizmo IDs become invalid after a property change.</para>
    /// </summary>
    public void ClearSubgizmoSelection()
    {
        NativeCalls.godot_icall_0_3(MethodBind43, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind44 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetVisible, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetVisible(bool visible)
    {
        NativeCalls.godot_icall_1_41(MethodBind44, GodotObject.GetPtr(this), visible.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind45 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsVisible, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsVisible()
    {
        return NativeCalls.godot_icall_0_40(MethodBind45, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind46 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsVisibleInTree, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the node is present in the <see cref="Godot.SceneTree"/>, its <see cref="Godot.Node3D.Visible"/> property is <see langword="true"/> and all its ancestors are also visible. If any ancestor is hidden, this node will not be visible in the scene tree.</para>
    /// </summary>
    public bool IsVisibleInTree()
    {
        return NativeCalls.godot_icall_0_40(MethodBind46, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind47 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Show, 3218959716ul);

    /// <summary>
    /// <para>Enables rendering of this node. Changes <see cref="Godot.Node3D.Visible"/> to <see langword="true"/>.</para>
    /// </summary>
    public void Show()
    {
        NativeCalls.godot_icall_0_3(MethodBind47, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind48 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Hide, 3218959716ul);

    /// <summary>
    /// <para>Disables rendering of this node. Changes <see cref="Godot.Node3D.Visible"/> to <see langword="false"/>.</para>
    /// </summary>
    public void Hide()
    {
        NativeCalls.godot_icall_0_3(MethodBind48, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind49 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNotifyLocalTransform, 2586408642ul);

    /// <summary>
    /// <para>Sets whether the node notifies about its local transformation changes. <see cref="Godot.Node3D"/> will not propagate this by default.</para>
    /// </summary>
    public void SetNotifyLocalTransform(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind49, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind50 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsLocalTransformNotificationEnabled, 36873697ul);

    /// <summary>
    /// <para>Returns whether node notifies about its local transformation changes. <see cref="Godot.Node3D"/> will not propagate this by default.</para>
    /// </summary>
    public bool IsLocalTransformNotificationEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind50, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind51 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNotifyTransform, 2586408642ul);

    /// <summary>
    /// <para>Sets whether the node notifies about its global and local transformation changes. <see cref="Godot.Node3D"/> will not propagate this by default, unless it is in the editor context and it has a valid gizmo.</para>
    /// </summary>
    public void SetNotifyTransform(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind51, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind52 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsTransformNotificationEnabled, 36873697ul);

    /// <summary>
    /// <para>Returns whether the node notifies about its global and local transformation changes. <see cref="Godot.Node3D"/> will not propagate this by default.</para>
    /// </summary>
    public bool IsTransformNotificationEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind52, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind53 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Rotate, 3436291937ul);

    /// <summary>
    /// <para>Rotates the local transformation around axis, a unit <see cref="Godot.Vector3"/>, by specified angle in radians.</para>
    /// </summary>
    public unsafe void Rotate(Vector3 axis, float angle)
    {
        NativeCalls.godot_icall_2_784(MethodBind53, GodotObject.GetPtr(this), &axis, angle);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind54 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalRotate, 3436291937ul);

    /// <summary>
    /// <para>Rotates the global (world) transformation around axis, a unit <see cref="Godot.Vector3"/>, by specified angle in radians. The rotation axis is in global coordinate system.</para>
    /// </summary>
    public unsafe void GlobalRotate(Vector3 axis, float angle)
    {
        NativeCalls.godot_icall_2_784(MethodBind54, GodotObject.GetPtr(this), &axis, angle);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind55 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalScale, 3460891852ul);

    /// <summary>
    /// <para>Scales the global (world) transformation by the given <see cref="Godot.Vector3"/> scale factors.</para>
    /// </summary>
    public unsafe void GlobalScale(Vector3 scale)
    {
        NativeCalls.godot_icall_1_163(MethodBind55, GodotObject.GetPtr(this), &scale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind56 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalTranslate, 3460891852ul);

    /// <summary>
    /// <para>Moves the global (world) transformation by <see cref="Godot.Vector3"/> offset. The offset is in global coordinate system.</para>
    /// </summary>
    public unsafe void GlobalTranslate(Vector3 offset)
    {
        NativeCalls.godot_icall_1_163(MethodBind56, GodotObject.GetPtr(this), &offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind57 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RotateObjectLocal, 3436291937ul);

    /// <summary>
    /// <para>Rotates the local transformation around axis, a unit <see cref="Godot.Vector3"/>, by specified angle in radians. The rotation axis is in object-local coordinate system.</para>
    /// </summary>
    public unsafe void RotateObjectLocal(Vector3 axis, float angle)
    {
        NativeCalls.godot_icall_2_784(MethodBind57, GodotObject.GetPtr(this), &axis, angle);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind58 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScaleObjectLocal, 3460891852ul);

    /// <summary>
    /// <para>Scales the local transformation by given 3D scale factors in object-local coordinate system.</para>
    /// </summary>
    public unsafe void ScaleObjectLocal(Vector3 scale)
    {
        NativeCalls.godot_icall_1_163(MethodBind58, GodotObject.GetPtr(this), &scale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind59 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TranslateObjectLocal, 3460891852ul);

    /// <summary>
    /// <para>Changes the node's position by the given offset <see cref="Godot.Vector3"/> in local space.</para>
    /// </summary>
    public unsafe void TranslateObjectLocal(Vector3 offset)
    {
        NativeCalls.godot_icall_1_163(MethodBind59, GodotObject.GetPtr(this), &offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind60 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RotateX, 373806689ul);

    /// <summary>
    /// <para>Rotates the local transformation around the X axis by angle in radians.</para>
    /// </summary>
    public void RotateX(float angle)
    {
        NativeCalls.godot_icall_1_62(MethodBind60, GodotObject.GetPtr(this), angle);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind61 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RotateY, 373806689ul);

    /// <summary>
    /// <para>Rotates the local transformation around the Y axis by angle in radians.</para>
    /// </summary>
    public void RotateY(float angle)
    {
        NativeCalls.godot_icall_1_62(MethodBind61, GodotObject.GetPtr(this), angle);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind62 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RotateZ, 373806689ul);

    /// <summary>
    /// <para>Rotates the local transformation around the Z axis by angle in radians.</para>
    /// </summary>
    public void RotateZ(float angle)
    {
        NativeCalls.godot_icall_1_62(MethodBind62, GodotObject.GetPtr(this), angle);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind63 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Translate, 3460891852ul);

    /// <summary>
    /// <para>Changes the node's position by the given offset <see cref="Godot.Vector3"/>.</para>
    /// <para>Note that the translation <paramref name="offset"/> is affected by the node's scale, so if scaled by e.g. <c>(10, 1, 1)</c>, a translation by an offset of <c>(2, 0, 0)</c> would actually add 20 (<c>2 * 10</c>) to the X coordinate.</para>
    /// </summary>
    public unsafe void Translate(Vector3 offset)
    {
        NativeCalls.godot_icall_1_163(MethodBind63, GodotObject.GetPtr(this), &offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind64 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Orthonormalize, 3218959716ul);

    /// <summary>
    /// <para>Resets this node's transformations (like scale, skew and taper) preserving its rotation and translation by performing Gram-Schmidt orthonormalization on this node's <see cref="Godot.Transform3D"/>.</para>
    /// </summary>
    public void Orthonormalize()
    {
        NativeCalls.godot_icall_0_3(MethodBind64, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind65 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetIdentity, 3218959716ul);

    /// <summary>
    /// <para>Reset all transformations for this node (sets its <see cref="Godot.Transform3D"/> to the identity matrix).</para>
    /// </summary>
    public void SetIdentity()
    {
        NativeCalls.godot_icall_0_3(MethodBind65, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind66 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LookAt, 2882425029ul);

    /// <summary>
    /// <para>Rotates the node so that the local forward axis (-Z, <c>Vector3.FORWARD</c>) points toward the <paramref name="target"/> position.</para>
    /// <para>The local up axis (+Y) points as close to the <paramref name="up"/> vector as possible while staying perpendicular to the local forward axis. The resulting transform is orthogonal, and the scale is preserved. Non-uniform scaling may not work correctly.</para>
    /// <para>The <paramref name="target"/> position cannot be the same as the node's position, the <paramref name="up"/> vector cannot be zero, and the direction from the node's position to the <paramref name="target"/> vector cannot be parallel to the <paramref name="up"/> vector.</para>
    /// <para>Operations take place in global space, which means that the node must be in the scene tree.</para>
    /// <para>If <paramref name="useModelFront"/> is <see langword="true"/>, the +Z axis (asset front) is treated as forward (implies +X is left) and points toward the <paramref name="target"/> position. By default, the -Z axis (camera forward) is treated as forward (implies +X is right).</para>
    /// </summary>
    /// <param name="up">If the parameter is null, then the default value is <c>new Vector3(0, 1, 0)</c>.</param>
    public unsafe void LookAt(Vector3 target, Nullable<Vector3> up = null, bool useModelFront = false)
    {
        Vector3 upOrDefVal = up.HasValue ? up.Value : new Vector3(0, 1, 0);
        NativeCalls.godot_icall_3_785(MethodBind66, GodotObject.GetPtr(this), &target, &upOrDefVal, useModelFront.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind67 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LookAtFromPosition, 2086826090ul);

    /// <summary>
    /// <para>Moves the node to the specified <paramref name="position"/>, and then rotates the node to point toward the <paramref name="target"/> as per <see cref="Godot.Node3D.LookAt(Vector3, Nullable{Vector3}, bool)"/>. Operations take place in global space.</para>
    /// </summary>
    /// <param name="up">If the parameter is null, then the default value is <c>new Vector3(0, 1, 0)</c>.</param>
    public unsafe void LookAtFromPosition(Vector3 position, Vector3 target, Nullable<Vector3> up = null, bool useModelFront = false)
    {
        Vector3 upOrDefVal = up.HasValue ? up.Value : new Vector3(0, 1, 0);
        NativeCalls.godot_icall_4_786(MethodBind67, GodotObject.GetPtr(this), &position, &target, &upOrDefVal, useModelFront.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind68 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ToLocal, 192990374ul);

    /// <summary>
    /// <para>Transforms <paramref name="globalPoint"/> from world space to this node's local space.</para>
    /// </summary>
    public unsafe Vector3 ToLocal(Vector3 globalPoint)
    {
        return NativeCalls.godot_icall_1_27(MethodBind68, GodotObject.GetPtr(this), &globalPoint);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind69 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ToGlobal, 192990374ul);

    /// <summary>
    /// <para>Transforms <paramref name="localPoint"/> from this node's local space to world space.</para>
    /// </summary>
    public unsafe Vector3 ToGlobal(Vector3 localPoint)
    {
        return NativeCalls.godot_icall_1_27(MethodBind69, GodotObject.GetPtr(this), &localPoint);
    }

    /// <summary>
    /// <para>Emitted when node visibility changes.</para>
    /// </summary>
    public event Action VisibilityChanged
    {
        add => Connect(SignalName.VisibilityChanged, Callable.From(value));
        remove => Disconnect(SignalName.VisibilityChanged, Callable.From(value));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_visibility_changed = "VisibilityChanged";

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
        if (signal == SignalName.VisibilityChanged)
        {
            if (HasGodotClassSignal(SignalProxyName_visibility_changed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : Node.PropertyName
    {
        /// <summary>
        /// Cached name for the 'transform' property.
        /// </summary>
        public static readonly StringName Transform = "transform";
        /// <summary>
        /// Cached name for the 'global_transform' property.
        /// </summary>
        public static readonly StringName GlobalTransform = "global_transform";
        /// <summary>
        /// Cached name for the 'position' property.
        /// </summary>
        public static readonly StringName Position = "position";
        /// <summary>
        /// Cached name for the 'rotation' property.
        /// </summary>
        public static readonly StringName Rotation = "rotation";
        /// <summary>
        /// Cached name for the 'rotation_degrees' property.
        /// </summary>
        public static readonly StringName RotationDegrees = "rotation_degrees";
        /// <summary>
        /// Cached name for the 'quaternion' property.
        /// </summary>
        public static readonly StringName Quaternion = "quaternion";
        /// <summary>
        /// Cached name for the 'basis' property.
        /// </summary>
        public static readonly StringName Basis = "basis";
        /// <summary>
        /// Cached name for the 'scale' property.
        /// </summary>
        public static readonly StringName Scale = "scale";
        /// <summary>
        /// Cached name for the 'rotation_edit_mode' property.
        /// </summary>
        public static readonly StringName RotationEditMode = "rotation_edit_mode";
        /// <summary>
        /// Cached name for the 'rotation_order' property.
        /// </summary>
        public static readonly StringName RotationOrder = "rotation_order";
        /// <summary>
        /// Cached name for the 'top_level' property.
        /// </summary>
        public static readonly StringName TopLevel = "top_level";
        /// <summary>
        /// Cached name for the 'global_position' property.
        /// </summary>
        public static readonly StringName GlobalPosition = "global_position";
        /// <summary>
        /// Cached name for the 'global_basis' property.
        /// </summary>
        public static readonly StringName GlobalBasis = "global_basis";
        /// <summary>
        /// Cached name for the 'global_rotation' property.
        /// </summary>
        public static readonly StringName GlobalRotation = "global_rotation";
        /// <summary>
        /// Cached name for the 'global_rotation_degrees' property.
        /// </summary>
        public static readonly StringName GlobalRotationDegrees = "global_rotation_degrees";
        /// <summary>
        /// Cached name for the 'visible' property.
        /// </summary>
        public static readonly StringName Visible = "visible";
        /// <summary>
        /// Cached name for the 'visibility_parent' property.
        /// </summary>
        public static readonly StringName VisibilityParent = "visibility_parent";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Node.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_transform' method.
        /// </summary>
        public static readonly StringName SetTransform = "set_transform";
        /// <summary>
        /// Cached name for the 'get_transform' method.
        /// </summary>
        public static readonly StringName GetTransform = "get_transform";
        /// <summary>
        /// Cached name for the 'set_position' method.
        /// </summary>
        public static readonly StringName SetPosition = "set_position";
        /// <summary>
        /// Cached name for the 'get_position' method.
        /// </summary>
        public static readonly StringName GetPosition = "get_position";
        /// <summary>
        /// Cached name for the 'set_rotation' method.
        /// </summary>
        public static readonly StringName SetRotation = "set_rotation";
        /// <summary>
        /// Cached name for the 'get_rotation' method.
        /// </summary>
        public static readonly StringName GetRotation = "get_rotation";
        /// <summary>
        /// Cached name for the 'set_rotation_degrees' method.
        /// </summary>
        public static readonly StringName SetRotationDegrees = "set_rotation_degrees";
        /// <summary>
        /// Cached name for the 'get_rotation_degrees' method.
        /// </summary>
        public static readonly StringName GetRotationDegrees = "get_rotation_degrees";
        /// <summary>
        /// Cached name for the 'set_rotation_order' method.
        /// </summary>
        public static readonly StringName SetRotationOrder = "set_rotation_order";
        /// <summary>
        /// Cached name for the 'get_rotation_order' method.
        /// </summary>
        public static readonly StringName GetRotationOrder = "get_rotation_order";
        /// <summary>
        /// Cached name for the 'set_rotation_edit_mode' method.
        /// </summary>
        public static readonly StringName SetRotationEditMode = "set_rotation_edit_mode";
        /// <summary>
        /// Cached name for the 'get_rotation_edit_mode' method.
        /// </summary>
        public static readonly StringName GetRotationEditMode = "get_rotation_edit_mode";
        /// <summary>
        /// Cached name for the 'set_scale' method.
        /// </summary>
        public static readonly StringName SetScale = "set_scale";
        /// <summary>
        /// Cached name for the 'get_scale' method.
        /// </summary>
        public static readonly StringName GetScale = "get_scale";
        /// <summary>
        /// Cached name for the 'set_quaternion' method.
        /// </summary>
        public static readonly StringName SetQuaternion = "set_quaternion";
        /// <summary>
        /// Cached name for the 'get_quaternion' method.
        /// </summary>
        public static readonly StringName GetQuaternion = "get_quaternion";
        /// <summary>
        /// Cached name for the 'set_basis' method.
        /// </summary>
        public static readonly StringName SetBasis = "set_basis";
        /// <summary>
        /// Cached name for the 'get_basis' method.
        /// </summary>
        public static readonly StringName GetBasis = "get_basis";
        /// <summary>
        /// Cached name for the 'set_global_transform' method.
        /// </summary>
        public static readonly StringName SetGlobalTransform = "set_global_transform";
        /// <summary>
        /// Cached name for the 'get_global_transform' method.
        /// </summary>
        public static readonly StringName GetGlobalTransform = "get_global_transform";
        /// <summary>
        /// Cached name for the 'set_global_position' method.
        /// </summary>
        public static readonly StringName SetGlobalPosition = "set_global_position";
        /// <summary>
        /// Cached name for the 'get_global_position' method.
        /// </summary>
        public static readonly StringName GetGlobalPosition = "get_global_position";
        /// <summary>
        /// Cached name for the 'set_global_basis' method.
        /// </summary>
        public static readonly StringName SetGlobalBasis = "set_global_basis";
        /// <summary>
        /// Cached name for the 'get_global_basis' method.
        /// </summary>
        public static readonly StringName GetGlobalBasis = "get_global_basis";
        /// <summary>
        /// Cached name for the 'set_global_rotation' method.
        /// </summary>
        public static readonly StringName SetGlobalRotation = "set_global_rotation";
        /// <summary>
        /// Cached name for the 'get_global_rotation' method.
        /// </summary>
        public static readonly StringName GetGlobalRotation = "get_global_rotation";
        /// <summary>
        /// Cached name for the 'set_global_rotation_degrees' method.
        /// </summary>
        public static readonly StringName SetGlobalRotationDegrees = "set_global_rotation_degrees";
        /// <summary>
        /// Cached name for the 'get_global_rotation_degrees' method.
        /// </summary>
        public static readonly StringName GetGlobalRotationDegrees = "get_global_rotation_degrees";
        /// <summary>
        /// Cached name for the 'get_parent_node_3d' method.
        /// </summary>
        public static readonly StringName GetParentNode3D = "get_parent_node_3d";
        /// <summary>
        /// Cached name for the 'set_ignore_transform_notification' method.
        /// </summary>
        public static readonly StringName SetIgnoreTransformNotification = "set_ignore_transform_notification";
        /// <summary>
        /// Cached name for the 'set_as_top_level' method.
        /// </summary>
        public static readonly StringName SetAsTopLevel = "set_as_top_level";
        /// <summary>
        /// Cached name for the 'is_set_as_top_level' method.
        /// </summary>
        public static readonly StringName IsSetAsTopLevel = "is_set_as_top_level";
        /// <summary>
        /// Cached name for the 'set_disable_scale' method.
        /// </summary>
        public static readonly StringName SetDisableScale = "set_disable_scale";
        /// <summary>
        /// Cached name for the 'is_scale_disabled' method.
        /// </summary>
        public static readonly StringName IsScaleDisabled = "is_scale_disabled";
        /// <summary>
        /// Cached name for the 'get_world_3d' method.
        /// </summary>
        public static readonly StringName GetWorld3D = "get_world_3d";
        /// <summary>
        /// Cached name for the 'force_update_transform' method.
        /// </summary>
        public static readonly StringName ForceUpdateTransform = "force_update_transform";
        /// <summary>
        /// Cached name for the 'set_visibility_parent' method.
        /// </summary>
        public static readonly StringName SetVisibilityParent = "set_visibility_parent";
        /// <summary>
        /// Cached name for the 'get_visibility_parent' method.
        /// </summary>
        public static readonly StringName GetVisibilityParent = "get_visibility_parent";
        /// <summary>
        /// Cached name for the 'update_gizmos' method.
        /// </summary>
        public static readonly StringName UpdateGizmos = "update_gizmos";
        /// <summary>
        /// Cached name for the 'add_gizmo' method.
        /// </summary>
        public static readonly StringName AddGizmo = "add_gizmo";
        /// <summary>
        /// Cached name for the 'get_gizmos' method.
        /// </summary>
        public static readonly StringName GetGizmos = "get_gizmos";
        /// <summary>
        /// Cached name for the 'clear_gizmos' method.
        /// </summary>
        public static readonly StringName ClearGizmos = "clear_gizmos";
        /// <summary>
        /// Cached name for the 'set_subgizmo_selection' method.
        /// </summary>
        public static readonly StringName SetSubgizmoSelection = "set_subgizmo_selection";
        /// <summary>
        /// Cached name for the 'clear_subgizmo_selection' method.
        /// </summary>
        public static readonly StringName ClearSubgizmoSelection = "clear_subgizmo_selection";
        /// <summary>
        /// Cached name for the 'set_visible' method.
        /// </summary>
        public static readonly StringName SetVisible = "set_visible";
        /// <summary>
        /// Cached name for the 'is_visible' method.
        /// </summary>
        public static readonly StringName IsVisible = "is_visible";
        /// <summary>
        /// Cached name for the 'is_visible_in_tree' method.
        /// </summary>
        public static readonly StringName IsVisibleInTree = "is_visible_in_tree";
        /// <summary>
        /// Cached name for the 'show' method.
        /// </summary>
        public static readonly StringName Show = "show";
        /// <summary>
        /// Cached name for the 'hide' method.
        /// </summary>
        public static readonly StringName Hide = "hide";
        /// <summary>
        /// Cached name for the 'set_notify_local_transform' method.
        /// </summary>
        public static readonly StringName SetNotifyLocalTransform = "set_notify_local_transform";
        /// <summary>
        /// Cached name for the 'is_local_transform_notification_enabled' method.
        /// </summary>
        public static readonly StringName IsLocalTransformNotificationEnabled = "is_local_transform_notification_enabled";
        /// <summary>
        /// Cached name for the 'set_notify_transform' method.
        /// </summary>
        public static readonly StringName SetNotifyTransform = "set_notify_transform";
        /// <summary>
        /// Cached name for the 'is_transform_notification_enabled' method.
        /// </summary>
        public static readonly StringName IsTransformNotificationEnabled = "is_transform_notification_enabled";
        /// <summary>
        /// Cached name for the 'rotate' method.
        /// </summary>
        public static readonly StringName Rotate = "rotate";
        /// <summary>
        /// Cached name for the 'global_rotate' method.
        /// </summary>
        public static readonly StringName GlobalRotate = "global_rotate";
        /// <summary>
        /// Cached name for the 'global_scale' method.
        /// </summary>
        public static readonly StringName GlobalScale = "global_scale";
        /// <summary>
        /// Cached name for the 'global_translate' method.
        /// </summary>
        public static readonly StringName GlobalTranslate = "global_translate";
        /// <summary>
        /// Cached name for the 'rotate_object_local' method.
        /// </summary>
        public static readonly StringName RotateObjectLocal = "rotate_object_local";
        /// <summary>
        /// Cached name for the 'scale_object_local' method.
        /// </summary>
        public static readonly StringName ScaleObjectLocal = "scale_object_local";
        /// <summary>
        /// Cached name for the 'translate_object_local' method.
        /// </summary>
        public static readonly StringName TranslateObjectLocal = "translate_object_local";
        /// <summary>
        /// Cached name for the 'rotate_x' method.
        /// </summary>
        public static readonly StringName RotateX = "rotate_x";
        /// <summary>
        /// Cached name for the 'rotate_y' method.
        /// </summary>
        public static readonly StringName RotateY = "rotate_y";
        /// <summary>
        /// Cached name for the 'rotate_z' method.
        /// </summary>
        public static readonly StringName RotateZ = "rotate_z";
        /// <summary>
        /// Cached name for the 'translate' method.
        /// </summary>
        public static readonly StringName Translate = "translate";
        /// <summary>
        /// Cached name for the 'orthonormalize' method.
        /// </summary>
        public static readonly StringName Orthonormalize = "orthonormalize";
        /// <summary>
        /// Cached name for the 'set_identity' method.
        /// </summary>
        public static readonly StringName SetIdentity = "set_identity";
        /// <summary>
        /// Cached name for the 'look_at' method.
        /// </summary>
        public static readonly StringName LookAt = "look_at";
        /// <summary>
        /// Cached name for the 'look_at_from_position' method.
        /// </summary>
        public static readonly StringName LookAtFromPosition = "look_at_from_position";
        /// <summary>
        /// Cached name for the 'to_local' method.
        /// </summary>
        public static readonly StringName ToLocal = "to_local";
        /// <summary>
        /// Cached name for the 'to_global' method.
        /// </summary>
        public static readonly StringName ToGlobal = "to_global";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Node.SignalName
    {
        /// <summary>
        /// Cached name for the 'visibility_changed' signal.
        /// </summary>
        public static readonly StringName VisibilityChanged = "visibility_changed";
    }
}

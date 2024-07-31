namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>This class extends <see cref="Godot.PhysicsDirectBodyState3D"/> by providing additional virtual methods that can be overridden. When these methods are overridden, they will be called instead of the internal methods of the physics server.</para>
/// <para>Intended for use with GDExtension to create custom implementations of <see cref="Godot.PhysicsDirectBodyState3D"/>.</para>
/// </summary>
public partial class PhysicsDirectBodyState3DExtension : PhysicsDirectBodyState3D
{
    private static readonly System.Type CachedType = typeof(PhysicsDirectBodyState3DExtension);

    private static readonly StringName NativeName = "PhysicsDirectBodyState3DExtension";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public PhysicsDirectBodyState3DExtension() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal PhysicsDirectBodyState3DExtension(bool memoryOwn) : base(memoryOwn) { }

    public virtual unsafe void _AddConstantCentralForce(Vector3 force)
    {
    }

    public virtual unsafe void _AddConstantForce(Vector3 force, Vector3 position)
    {
    }

    public virtual unsafe void _AddConstantTorque(Vector3 torque)
    {
    }

    public virtual unsafe void _ApplyCentralForce(Vector3 force)
    {
    }

    public virtual unsafe void _ApplyCentralImpulse(Vector3 impulse)
    {
    }

    public virtual unsafe void _ApplyForce(Vector3 force, Vector3 position)
    {
    }

    public virtual unsafe void _ApplyImpulse(Vector3 impulse, Vector3 position)
    {
    }

    public virtual unsafe void _ApplyTorque(Vector3 torque)
    {
    }

    public virtual unsafe void _ApplyTorqueImpulse(Vector3 impulse)
    {
    }

    public virtual Vector3 _GetAngularVelocity()
    {
        return default;
    }

    public virtual Vector3 _GetCenterOfMass()
    {
        return default;
    }

    public virtual Vector3 _GetCenterOfMassLocal()
    {
        return default;
    }

    public virtual Vector3 _GetConstantForce()
    {
        return default;
    }

    public virtual Vector3 _GetConstantTorque()
    {
        return default;
    }

    public virtual Rid _GetContactCollider(int contactIdx)
    {
        return default;
    }

    public virtual ulong _GetContactColliderId(int contactIdx)
    {
        return default;
    }

    public virtual GodotObject _GetContactColliderObject(int contactIdx)
    {
        return default;
    }

    public virtual Vector3 _GetContactColliderPosition(int contactIdx)
    {
        return default;
    }

    public virtual int _GetContactColliderShape(int contactIdx)
    {
        return default;
    }

    public virtual Vector3 _GetContactColliderVelocityAtPosition(int contactIdx)
    {
        return default;
    }

    public virtual int _GetContactCount()
    {
        return default;
    }

    public virtual Vector3 _GetContactImpulse(int contactIdx)
    {
        return default;
    }

    public virtual Vector3 _GetContactLocalNormal(int contactIdx)
    {
        return default;
    }

    public virtual Vector3 _GetContactLocalPosition(int contactIdx)
    {
        return default;
    }

    public virtual int _GetContactLocalShape(int contactIdx)
    {
        return default;
    }

    public virtual Vector3 _GetContactLocalVelocityAtPosition(int contactIdx)
    {
        return default;
    }

    public virtual Vector3 _GetInverseInertia()
    {
        return default;
    }

    public virtual Basis _GetInverseInertiaTensor()
    {
        return default;
    }

    public virtual float _GetInverseMass()
    {
        return default;
    }

    public virtual Vector3 _GetLinearVelocity()
    {
        return default;
    }

    public virtual Basis _GetPrincipalInertiaAxes()
    {
        return default;
    }

    public virtual PhysicsDirectSpaceState3D _GetSpaceState()
    {
        return default;
    }

    public virtual float _GetStep()
    {
        return default;
    }

    public virtual float _GetTotalAngularDamp()
    {
        return default;
    }

    public virtual Vector3 _GetTotalGravity()
    {
        return default;
    }

    public virtual float _GetTotalLinearDamp()
    {
        return default;
    }

    public virtual Transform3D _GetTransform()
    {
        return default;
    }

    public virtual unsafe Vector3 _GetVelocityAtLocalPosition(Vector3 localPosition)
    {
        return default;
    }

    public virtual void _IntegrateForces()
    {
    }

    public virtual bool _IsSleeping()
    {
        return default;
    }

    public virtual unsafe void _SetAngularVelocity(Vector3 velocity)
    {
    }

    public virtual unsafe void _SetConstantForce(Vector3 force)
    {
    }

    public virtual unsafe void _SetConstantTorque(Vector3 torque)
    {
    }

    public virtual unsafe void _SetLinearVelocity(Vector3 velocity)
    {
    }

    public virtual void _SetSleepState(bool enabled)
    {
    }

    public virtual unsafe void _SetTransform(Transform3D transform)
    {
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__add_constant_central_force = "_AddConstantCentralForce";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__add_constant_force = "_AddConstantForce";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__add_constant_torque = "_AddConstantTorque";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__apply_central_force = "_ApplyCentralForce";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__apply_central_impulse = "_ApplyCentralImpulse";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__apply_force = "_ApplyForce";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__apply_impulse = "_ApplyImpulse";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__apply_torque = "_ApplyTorque";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__apply_torque_impulse = "_ApplyTorqueImpulse";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_angular_velocity = "_GetAngularVelocity";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_center_of_mass = "_GetCenterOfMass";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_center_of_mass_local = "_GetCenterOfMassLocal";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_constant_force = "_GetConstantForce";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_constant_torque = "_GetConstantTorque";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_collider = "_GetContactCollider";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_collider_id = "_GetContactColliderId";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_collider_object = "_GetContactColliderObject";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_collider_position = "_GetContactColliderPosition";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_collider_shape = "_GetContactColliderShape";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_collider_velocity_at_position = "_GetContactColliderVelocityAtPosition";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_count = "_GetContactCount";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_impulse = "_GetContactImpulse";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_local_normal = "_GetContactLocalNormal";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_local_position = "_GetContactLocalPosition";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_local_shape = "_GetContactLocalShape";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_contact_local_velocity_at_position = "_GetContactLocalVelocityAtPosition";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_inverse_inertia = "_GetInverseInertia";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_inverse_inertia_tensor = "_GetInverseInertiaTensor";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_inverse_mass = "_GetInverseMass";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_linear_velocity = "_GetLinearVelocity";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_principal_inertia_axes = "_GetPrincipalInertiaAxes";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_space_state = "_GetSpaceState";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_step = "_GetStep";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_total_angular_damp = "_GetTotalAngularDamp";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_total_gravity = "_GetTotalGravity";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_total_linear_damp = "_GetTotalLinearDamp";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_transform = "_GetTransform";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_velocity_at_local_position = "_GetVelocityAtLocalPosition";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__integrate_forces = "_IntegrateForces";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__is_sleeping = "_IsSleeping";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__set_angular_velocity = "_SetAngularVelocity";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__set_constant_force = "_SetConstantForce";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__set_constant_torque = "_SetConstantTorque";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__set_linear_velocity = "_SetLinearVelocity";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__set_sleep_state = "_SetSleepState";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__set_transform = "_SetTransform";

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
        if ((method == MethodProxyName__add_constant_central_force || method == MethodName._AddConstantCentralForce) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__add_constant_central_force.NativeValue))
        {
            _AddConstantCentralForce(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__add_constant_force || method == MethodName._AddConstantForce) && args.Count == 2 && HasGodotClassMethod((godot_string_name)MethodProxyName__add_constant_force.NativeValue))
        {
            _AddConstantForce(VariantUtils.ConvertTo<Vector3>(args[0]), VariantUtils.ConvertTo<Vector3>(args[1]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__add_constant_torque || method == MethodName._AddConstantTorque) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__add_constant_torque.NativeValue))
        {
            _AddConstantTorque(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__apply_central_force || method == MethodName._ApplyCentralForce) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__apply_central_force.NativeValue))
        {
            _ApplyCentralForce(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__apply_central_impulse || method == MethodName._ApplyCentralImpulse) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__apply_central_impulse.NativeValue))
        {
            _ApplyCentralImpulse(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__apply_force || method == MethodName._ApplyForce) && args.Count == 2 && HasGodotClassMethod((godot_string_name)MethodProxyName__apply_force.NativeValue))
        {
            _ApplyForce(VariantUtils.ConvertTo<Vector3>(args[0]), VariantUtils.ConvertTo<Vector3>(args[1]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__apply_impulse || method == MethodName._ApplyImpulse) && args.Count == 2 && HasGodotClassMethod((godot_string_name)MethodProxyName__apply_impulse.NativeValue))
        {
            _ApplyImpulse(VariantUtils.ConvertTo<Vector3>(args[0]), VariantUtils.ConvertTo<Vector3>(args[1]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__apply_torque || method == MethodName._ApplyTorque) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__apply_torque.NativeValue))
        {
            _ApplyTorque(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__apply_torque_impulse || method == MethodName._ApplyTorqueImpulse) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__apply_torque_impulse.NativeValue))
        {
            _ApplyTorqueImpulse(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__get_angular_velocity || method == MethodName._GetAngularVelocity) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_angular_velocity.NativeValue))
        {
            var callRet = _GetAngularVelocity();
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_center_of_mass || method == MethodName._GetCenterOfMass) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_center_of_mass.NativeValue))
        {
            var callRet = _GetCenterOfMass();
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_center_of_mass_local || method == MethodName._GetCenterOfMassLocal) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_center_of_mass_local.NativeValue))
        {
            var callRet = _GetCenterOfMassLocal();
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_constant_force || method == MethodName._GetConstantForce) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_constant_force.NativeValue))
        {
            var callRet = _GetConstantForce();
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_constant_torque || method == MethodName._GetConstantTorque) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_constant_torque.NativeValue))
        {
            var callRet = _GetConstantTorque();
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_collider || method == MethodName._GetContactCollider) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_collider.NativeValue))
        {
            var callRet = _GetContactCollider(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<Rid>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_collider_id || method == MethodName._GetContactColliderId) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_collider_id.NativeValue))
        {
            var callRet = _GetContactColliderId(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<ulong>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_collider_object || method == MethodName._GetContactColliderObject) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_collider_object.NativeValue))
        {
            var callRet = _GetContactColliderObject(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<GodotObject>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_collider_position || method == MethodName._GetContactColliderPosition) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_collider_position.NativeValue))
        {
            var callRet = _GetContactColliderPosition(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_collider_shape || method == MethodName._GetContactColliderShape) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_collider_shape.NativeValue))
        {
            var callRet = _GetContactColliderShape(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<int>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_collider_velocity_at_position || method == MethodName._GetContactColliderVelocityAtPosition) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_collider_velocity_at_position.NativeValue))
        {
            var callRet = _GetContactColliderVelocityAtPosition(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_count || method == MethodName._GetContactCount) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_count.NativeValue))
        {
            var callRet = _GetContactCount();
            ret = VariantUtils.CreateFrom<int>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_impulse || method == MethodName._GetContactImpulse) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_impulse.NativeValue))
        {
            var callRet = _GetContactImpulse(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_local_normal || method == MethodName._GetContactLocalNormal) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_local_normal.NativeValue))
        {
            var callRet = _GetContactLocalNormal(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_local_position || method == MethodName._GetContactLocalPosition) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_local_position.NativeValue))
        {
            var callRet = _GetContactLocalPosition(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_local_shape || method == MethodName._GetContactLocalShape) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_local_shape.NativeValue))
        {
            var callRet = _GetContactLocalShape(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<int>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_contact_local_velocity_at_position || method == MethodName._GetContactLocalVelocityAtPosition) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_contact_local_velocity_at_position.NativeValue))
        {
            var callRet = _GetContactLocalVelocityAtPosition(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_inverse_inertia || method == MethodName._GetInverseInertia) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_inverse_inertia.NativeValue))
        {
            var callRet = _GetInverseInertia();
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_inverse_inertia_tensor || method == MethodName._GetInverseInertiaTensor) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_inverse_inertia_tensor.NativeValue))
        {
            var callRet = _GetInverseInertiaTensor();
            ret = VariantUtils.CreateFrom<Basis>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_inverse_mass || method == MethodName._GetInverseMass) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_inverse_mass.NativeValue))
        {
            var callRet = _GetInverseMass();
            ret = VariantUtils.CreateFrom<float>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_linear_velocity || method == MethodName._GetLinearVelocity) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_linear_velocity.NativeValue))
        {
            var callRet = _GetLinearVelocity();
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_principal_inertia_axes || method == MethodName._GetPrincipalInertiaAxes) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_principal_inertia_axes.NativeValue))
        {
            var callRet = _GetPrincipalInertiaAxes();
            ret = VariantUtils.CreateFrom<Basis>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_space_state || method == MethodName._GetSpaceState) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_space_state.NativeValue))
        {
            var callRet = _GetSpaceState();
            ret = VariantUtils.CreateFrom<PhysicsDirectSpaceState3D>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_step || method == MethodName._GetStep) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_step.NativeValue))
        {
            var callRet = _GetStep();
            ret = VariantUtils.CreateFrom<float>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_total_angular_damp || method == MethodName._GetTotalAngularDamp) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_total_angular_damp.NativeValue))
        {
            var callRet = _GetTotalAngularDamp();
            ret = VariantUtils.CreateFrom<float>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_total_gravity || method == MethodName._GetTotalGravity) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_total_gravity.NativeValue))
        {
            var callRet = _GetTotalGravity();
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_total_linear_damp || method == MethodName._GetTotalLinearDamp) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_total_linear_damp.NativeValue))
        {
            var callRet = _GetTotalLinearDamp();
            ret = VariantUtils.CreateFrom<float>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_transform || method == MethodName._GetTransform) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_transform.NativeValue))
        {
            var callRet = _GetTransform();
            ret = VariantUtils.CreateFrom<Transform3D>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_velocity_at_local_position || method == MethodName._GetVelocityAtLocalPosition) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_velocity_at_local_position.NativeValue))
        {
            var callRet = _GetVelocityAtLocalPosition(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = VariantUtils.CreateFrom<Vector3>(callRet);
            return true;
        }
        if ((method == MethodProxyName__integrate_forces || method == MethodName._IntegrateForces) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__integrate_forces.NativeValue))
        {
            _IntegrateForces();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__is_sleeping || method == MethodName._IsSleeping) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__is_sleeping.NativeValue))
        {
            var callRet = _IsSleeping();
            ret = VariantUtils.CreateFrom<bool>(callRet);
            return true;
        }
        if ((method == MethodProxyName__set_angular_velocity || method == MethodName._SetAngularVelocity) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__set_angular_velocity.NativeValue))
        {
            _SetAngularVelocity(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__set_constant_force || method == MethodName._SetConstantForce) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__set_constant_force.NativeValue))
        {
            _SetConstantForce(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__set_constant_torque || method == MethodName._SetConstantTorque) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__set_constant_torque.NativeValue))
        {
            _SetConstantTorque(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__set_linear_velocity || method == MethodName._SetLinearVelocity) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__set_linear_velocity.NativeValue))
        {
            _SetLinearVelocity(VariantUtils.ConvertTo<Vector3>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__set_sleep_state || method == MethodName._SetSleepState) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__set_sleep_state.NativeValue))
        {
            _SetSleepState(VariantUtils.ConvertTo<bool>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__set_transform || method == MethodName._SetTransform) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__set_transform.NativeValue))
        {
            _SetTransform(VariantUtils.ConvertTo<Transform3D>(args[0]));
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
        if (method == MethodName._AddConstantCentralForce)
        {
            if (HasGodotClassMethod(MethodProxyName__add_constant_central_force.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._AddConstantForce)
        {
            if (HasGodotClassMethod(MethodProxyName__add_constant_force.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._AddConstantTorque)
        {
            if (HasGodotClassMethod(MethodProxyName__add_constant_torque.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._ApplyCentralForce)
        {
            if (HasGodotClassMethod(MethodProxyName__apply_central_force.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._ApplyCentralImpulse)
        {
            if (HasGodotClassMethod(MethodProxyName__apply_central_impulse.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._ApplyForce)
        {
            if (HasGodotClassMethod(MethodProxyName__apply_force.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._ApplyImpulse)
        {
            if (HasGodotClassMethod(MethodProxyName__apply_impulse.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._ApplyTorque)
        {
            if (HasGodotClassMethod(MethodProxyName__apply_torque.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._ApplyTorqueImpulse)
        {
            if (HasGodotClassMethod(MethodProxyName__apply_torque_impulse.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetAngularVelocity)
        {
            if (HasGodotClassMethod(MethodProxyName__get_angular_velocity.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetCenterOfMass)
        {
            if (HasGodotClassMethod(MethodProxyName__get_center_of_mass.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetCenterOfMassLocal)
        {
            if (HasGodotClassMethod(MethodProxyName__get_center_of_mass_local.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetConstantForce)
        {
            if (HasGodotClassMethod(MethodProxyName__get_constant_force.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetConstantTorque)
        {
            if (HasGodotClassMethod(MethodProxyName__get_constant_torque.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactCollider)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_collider.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactColliderId)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_collider_id.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactColliderObject)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_collider_object.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactColliderPosition)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_collider_position.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactColliderShape)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_collider_shape.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactColliderVelocityAtPosition)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_collider_velocity_at_position.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactCount)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_count.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactImpulse)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_impulse.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactLocalNormal)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_local_normal.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactLocalPosition)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_local_position.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactLocalShape)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_local_shape.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetContactLocalVelocityAtPosition)
        {
            if (HasGodotClassMethod(MethodProxyName__get_contact_local_velocity_at_position.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetInverseInertia)
        {
            if (HasGodotClassMethod(MethodProxyName__get_inverse_inertia.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetInverseInertiaTensor)
        {
            if (HasGodotClassMethod(MethodProxyName__get_inverse_inertia_tensor.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetInverseMass)
        {
            if (HasGodotClassMethod(MethodProxyName__get_inverse_mass.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetLinearVelocity)
        {
            if (HasGodotClassMethod(MethodProxyName__get_linear_velocity.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetPrincipalInertiaAxes)
        {
            if (HasGodotClassMethod(MethodProxyName__get_principal_inertia_axes.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetSpaceState)
        {
            if (HasGodotClassMethod(MethodProxyName__get_space_state.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetStep)
        {
            if (HasGodotClassMethod(MethodProxyName__get_step.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetTotalAngularDamp)
        {
            if (HasGodotClassMethod(MethodProxyName__get_total_angular_damp.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetTotalGravity)
        {
            if (HasGodotClassMethod(MethodProxyName__get_total_gravity.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetTotalLinearDamp)
        {
            if (HasGodotClassMethod(MethodProxyName__get_total_linear_damp.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetTransform)
        {
            if (HasGodotClassMethod(MethodProxyName__get_transform.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetVelocityAtLocalPosition)
        {
            if (HasGodotClassMethod(MethodProxyName__get_velocity_at_local_position.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._IntegrateForces)
        {
            if (HasGodotClassMethod(MethodProxyName__integrate_forces.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._IsSleeping)
        {
            if (HasGodotClassMethod(MethodProxyName__is_sleeping.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._SetAngularVelocity)
        {
            if (HasGodotClassMethod(MethodProxyName__set_angular_velocity.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._SetConstantForce)
        {
            if (HasGodotClassMethod(MethodProxyName__set_constant_force.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._SetConstantTorque)
        {
            if (HasGodotClassMethod(MethodProxyName__set_constant_torque.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._SetLinearVelocity)
        {
            if (HasGodotClassMethod(MethodProxyName__set_linear_velocity.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._SetSleepState)
        {
            if (HasGodotClassMethod(MethodProxyName__set_sleep_state.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._SetTransform)
        {
            if (HasGodotClassMethod(MethodProxyName__set_transform.NativeValue.DangerousSelfRef))
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
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : PhysicsDirectBodyState3D.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : PhysicsDirectBodyState3D.MethodName
    {
        /// <summary>
        /// Cached name for the '_add_constant_central_force' method.
        /// </summary>
        public static readonly StringName _AddConstantCentralForce = "_add_constant_central_force";
        /// <summary>
        /// Cached name for the '_add_constant_force' method.
        /// </summary>
        public static readonly StringName _AddConstantForce = "_add_constant_force";
        /// <summary>
        /// Cached name for the '_add_constant_torque' method.
        /// </summary>
        public static readonly StringName _AddConstantTorque = "_add_constant_torque";
        /// <summary>
        /// Cached name for the '_apply_central_force' method.
        /// </summary>
        public static readonly StringName _ApplyCentralForce = "_apply_central_force";
        /// <summary>
        /// Cached name for the '_apply_central_impulse' method.
        /// </summary>
        public static readonly StringName _ApplyCentralImpulse = "_apply_central_impulse";
        /// <summary>
        /// Cached name for the '_apply_force' method.
        /// </summary>
        public static readonly StringName _ApplyForce = "_apply_force";
        /// <summary>
        /// Cached name for the '_apply_impulse' method.
        /// </summary>
        public static readonly StringName _ApplyImpulse = "_apply_impulse";
        /// <summary>
        /// Cached name for the '_apply_torque' method.
        /// </summary>
        public static readonly StringName _ApplyTorque = "_apply_torque";
        /// <summary>
        /// Cached name for the '_apply_torque_impulse' method.
        /// </summary>
        public static readonly StringName _ApplyTorqueImpulse = "_apply_torque_impulse";
        /// <summary>
        /// Cached name for the '_get_angular_velocity' method.
        /// </summary>
        public static readonly StringName _GetAngularVelocity = "_get_angular_velocity";
        /// <summary>
        /// Cached name for the '_get_center_of_mass' method.
        /// </summary>
        public static readonly StringName _GetCenterOfMass = "_get_center_of_mass";
        /// <summary>
        /// Cached name for the '_get_center_of_mass_local' method.
        /// </summary>
        public static readonly StringName _GetCenterOfMassLocal = "_get_center_of_mass_local";
        /// <summary>
        /// Cached name for the '_get_constant_force' method.
        /// </summary>
        public static readonly StringName _GetConstantForce = "_get_constant_force";
        /// <summary>
        /// Cached name for the '_get_constant_torque' method.
        /// </summary>
        public static readonly StringName _GetConstantTorque = "_get_constant_torque";
        /// <summary>
        /// Cached name for the '_get_contact_collider' method.
        /// </summary>
        public static readonly StringName _GetContactCollider = "_get_contact_collider";
        /// <summary>
        /// Cached name for the '_get_contact_collider_id' method.
        /// </summary>
        public static readonly StringName _GetContactColliderId = "_get_contact_collider_id";
        /// <summary>
        /// Cached name for the '_get_contact_collider_object' method.
        /// </summary>
        public static readonly StringName _GetContactColliderObject = "_get_contact_collider_object";
        /// <summary>
        /// Cached name for the '_get_contact_collider_position' method.
        /// </summary>
        public static readonly StringName _GetContactColliderPosition = "_get_contact_collider_position";
        /// <summary>
        /// Cached name for the '_get_contact_collider_shape' method.
        /// </summary>
        public static readonly StringName _GetContactColliderShape = "_get_contact_collider_shape";
        /// <summary>
        /// Cached name for the '_get_contact_collider_velocity_at_position' method.
        /// </summary>
        public static readonly StringName _GetContactColliderVelocityAtPosition = "_get_contact_collider_velocity_at_position";
        /// <summary>
        /// Cached name for the '_get_contact_count' method.
        /// </summary>
        public static readonly StringName _GetContactCount = "_get_contact_count";
        /// <summary>
        /// Cached name for the '_get_contact_impulse' method.
        /// </summary>
        public static readonly StringName _GetContactImpulse = "_get_contact_impulse";
        /// <summary>
        /// Cached name for the '_get_contact_local_normal' method.
        /// </summary>
        public static readonly StringName _GetContactLocalNormal = "_get_contact_local_normal";
        /// <summary>
        /// Cached name for the '_get_contact_local_position' method.
        /// </summary>
        public static readonly StringName _GetContactLocalPosition = "_get_contact_local_position";
        /// <summary>
        /// Cached name for the '_get_contact_local_shape' method.
        /// </summary>
        public static readonly StringName _GetContactLocalShape = "_get_contact_local_shape";
        /// <summary>
        /// Cached name for the '_get_contact_local_velocity_at_position' method.
        /// </summary>
        public static readonly StringName _GetContactLocalVelocityAtPosition = "_get_contact_local_velocity_at_position";
        /// <summary>
        /// Cached name for the '_get_inverse_inertia' method.
        /// </summary>
        public static readonly StringName _GetInverseInertia = "_get_inverse_inertia";
        /// <summary>
        /// Cached name for the '_get_inverse_inertia_tensor' method.
        /// </summary>
        public static readonly StringName _GetInverseInertiaTensor = "_get_inverse_inertia_tensor";
        /// <summary>
        /// Cached name for the '_get_inverse_mass' method.
        /// </summary>
        public static readonly StringName _GetInverseMass = "_get_inverse_mass";
        /// <summary>
        /// Cached name for the '_get_linear_velocity' method.
        /// </summary>
        public static readonly StringName _GetLinearVelocity = "_get_linear_velocity";
        /// <summary>
        /// Cached name for the '_get_principal_inertia_axes' method.
        /// </summary>
        public static readonly StringName _GetPrincipalInertiaAxes = "_get_principal_inertia_axes";
        /// <summary>
        /// Cached name for the '_get_space_state' method.
        /// </summary>
        public static readonly StringName _GetSpaceState = "_get_space_state";
        /// <summary>
        /// Cached name for the '_get_step' method.
        /// </summary>
        public static readonly StringName _GetStep = "_get_step";
        /// <summary>
        /// Cached name for the '_get_total_angular_damp' method.
        /// </summary>
        public static readonly StringName _GetTotalAngularDamp = "_get_total_angular_damp";
        /// <summary>
        /// Cached name for the '_get_total_gravity' method.
        /// </summary>
        public static readonly StringName _GetTotalGravity = "_get_total_gravity";
        /// <summary>
        /// Cached name for the '_get_total_linear_damp' method.
        /// </summary>
        public static readonly StringName _GetTotalLinearDamp = "_get_total_linear_damp";
        /// <summary>
        /// Cached name for the '_get_transform' method.
        /// </summary>
        public static readonly StringName _GetTransform = "_get_transform";
        /// <summary>
        /// Cached name for the '_get_velocity_at_local_position' method.
        /// </summary>
        public static readonly StringName _GetVelocityAtLocalPosition = "_get_velocity_at_local_position";
        /// <summary>
        /// Cached name for the '_integrate_forces' method.
        /// </summary>
        public static readonly StringName _IntegrateForces = "_integrate_forces";
        /// <summary>
        /// Cached name for the '_is_sleeping' method.
        /// </summary>
        public static readonly StringName _IsSleeping = "_is_sleeping";
        /// <summary>
        /// Cached name for the '_set_angular_velocity' method.
        /// </summary>
        public static readonly StringName _SetAngularVelocity = "_set_angular_velocity";
        /// <summary>
        /// Cached name for the '_set_constant_force' method.
        /// </summary>
        public static readonly StringName _SetConstantForce = "_set_constant_force";
        /// <summary>
        /// Cached name for the '_set_constant_torque' method.
        /// </summary>
        public static readonly StringName _SetConstantTorque = "_set_constant_torque";
        /// <summary>
        /// Cached name for the '_set_linear_velocity' method.
        /// </summary>
        public static readonly StringName _SetLinearVelocity = "_set_linear_velocity";
        /// <summary>
        /// Cached name for the '_set_sleep_state' method.
        /// </summary>
        public static readonly StringName _SetSleepState = "_set_sleep_state";
        /// <summary>
        /// Cached name for the '_set_transform' method.
        /// </summary>
        public static readonly StringName _SetTransform = "_set_transform";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : PhysicsDirectBodyState3D.SignalName
    {
    }
}

namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Provides direct access to a physics space in the <see cref="Godot.PhysicsServer2D"/>. It's used mainly to do queries against objects and areas residing in a given space.</para>
/// </summary>
public partial class PhysicsDirectSpaceState2D : GodotObject
{
    private static readonly System.Type CachedType = typeof(PhysicsDirectSpaceState2D);

    private static readonly StringName NativeName = "PhysicsDirectSpaceState2D";

    internal PhysicsDirectSpaceState2D() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal PhysicsDirectSpaceState2D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IntersectPoint, 2118456068ul);

    /// <summary>
    /// <para>Checks whether a point is inside any solid shape. Position and other parameters are defined through <see cref="Godot.PhysicsPointQueryParameters2D"/>. The shapes the point is inside of are returned in an array containing dictionaries with the following fields:</para>
    /// <para><c>collider</c>: The colliding object.</para>
    /// <para><c>collider_id</c>: The colliding object's ID.</para>
    /// <para><c>rid</c>: The intersecting object's <see cref="Godot.Rid"/>.</para>
    /// <para><c>shape</c>: The shape index of the colliding shape.</para>
    /// <para>The number of intersections can be limited with the <paramref name="maxResults"/> parameter, to reduce the processing time.</para>
    /// <para><b>Note:</b> <see cref="Godot.ConcavePolygonShape2D"/>s and <see cref="Godot.CollisionPolygon2D"/>s in <c>Segments</c> build mode are not solid shapes. Therefore, they will not be detected.</para>
    /// </summary>
    public Godot.Collections.Array<Godot.Collections.Dictionary> IntersectPoint(PhysicsPointQueryParameters2D parameters, int maxResults = 32)
    {
        return new Godot.Collections.Array<Godot.Collections.Dictionary>(NativeCalls.godot_icall_2_834(MethodBind0, GodotObject.GetPtr(this), GodotObject.GetPtr(parameters), maxResults));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IntersectRay, 1590275562ul);

    /// <summary>
    /// <para>Intersects a ray in a given space. Ray position and other parameters are defined through <see cref="Godot.PhysicsRayQueryParameters2D"/>. The returned object is a dictionary with the following fields:</para>
    /// <para><c>collider</c>: The colliding object.</para>
    /// <para><c>collider_id</c>: The colliding object's ID.</para>
    /// <para><c>normal</c>: The object's surface normal at the intersection point, or <c>Vector2(0, 0)</c> if the ray starts inside the shape and <see cref="Godot.PhysicsRayQueryParameters2D.HitFromInside"/> is <see langword="true"/>.</para>
    /// <para><c>position</c>: The intersection point.</para>
    /// <para><c>rid</c>: The intersecting object's <see cref="Godot.Rid"/>.</para>
    /// <para><c>shape</c>: The shape index of the colliding shape.</para>
    /// <para>If the ray did not intersect anything, then an empty dictionary is returned instead.</para>
    /// </summary>
    public Godot.Collections.Dictionary IntersectRay(PhysicsRayQueryParameters2D parameters)
    {
        return NativeCalls.godot_icall_1_835(MethodBind1, GodotObject.GetPtr(this), GodotObject.GetPtr(parameters));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IntersectShape, 2488867228ul);

    /// <summary>
    /// <para>Checks the intersections of a shape, given through a <see cref="Godot.PhysicsShapeQueryParameters2D"/> object, against the space. The intersected shapes are returned in an array containing dictionaries with the following fields:</para>
    /// <para><c>collider</c>: The colliding object.</para>
    /// <para><c>collider_id</c>: The colliding object's ID.</para>
    /// <para><c>rid</c>: The intersecting object's <see cref="Godot.Rid"/>.</para>
    /// <para><c>shape</c>: The shape index of the colliding shape.</para>
    /// <para>The number of intersections can be limited with the <paramref name="maxResults"/> parameter, to reduce the processing time.</para>
    /// </summary>
    public Godot.Collections.Array<Godot.Collections.Dictionary> IntersectShape(PhysicsShapeQueryParameters2D parameters, int maxResults = 32)
    {
        return new Godot.Collections.Array<Godot.Collections.Dictionary>(NativeCalls.godot_icall_2_834(MethodBind2, GodotObject.GetPtr(this), GodotObject.GetPtr(parameters), maxResults));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CastMotion, 711275086ul);

    /// <summary>
    /// <para>Checks how far a <see cref="Godot.Shape2D"/> can move without colliding. All the parameters for the query, including the shape and the motion, are supplied through a <see cref="Godot.PhysicsShapeQueryParameters2D"/> object.</para>
    /// <para>Returns an array with the safe and unsafe proportions (between 0 and 1) of the motion. The safe proportion is the maximum fraction of the motion that can be made without a collision. The unsafe proportion is the minimum fraction of the distance that must be moved for a collision. If no collision is detected a result of <c>[1.0, 1.0]</c> will be returned.</para>
    /// <para><b>Note:</b> Any <see cref="Godot.Shape2D"/>s that the shape is already colliding with e.g. inside of, will be ignored. Use <see cref="Godot.PhysicsDirectSpaceState2D.CollideShape(PhysicsShapeQueryParameters2D, int)"/> to determine the <see cref="Godot.Shape2D"/>s that the shape is already colliding with.</para>
    /// </summary>
    public float[] CastMotion(PhysicsShapeQueryParameters2D parameters)
    {
        return NativeCalls.godot_icall_1_836(MethodBind3, GodotObject.GetPtr(this), GodotObject.GetPtr(parameters));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CollideShape, 2488867228ul);

    /// <summary>
    /// <para>Checks the intersections of a shape, given through a <see cref="Godot.PhysicsShapeQueryParameters2D"/> object, against the space. The resulting array contains a list of points where the shape intersects another. Like with <see cref="Godot.PhysicsDirectSpaceState2D.IntersectShape(PhysicsShapeQueryParameters2D, int)"/>, the number of returned results can be limited to save processing time.</para>
    /// <para>Returned points are a list of pairs of contact points. For each pair the first one is in the shape passed in <see cref="Godot.PhysicsShapeQueryParameters2D"/> object, second one is in the collided shape from the physics space.</para>
    /// </summary>
    public Godot.Collections.Array<Vector2> CollideShape(PhysicsShapeQueryParameters2D parameters, int maxResults = 32)
    {
        return new Godot.Collections.Array<Vector2>(NativeCalls.godot_icall_2_834(MethodBind4, GodotObject.GetPtr(this), GodotObject.GetPtr(parameters), maxResults));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRestInfo, 2803666496ul);

    /// <summary>
    /// <para>Checks the intersections of a shape, given through a <see cref="Godot.PhysicsShapeQueryParameters2D"/> object, against the space. If it collides with more than one shape, the nearest one is selected. If the shape did not intersect anything, then an empty dictionary is returned instead.</para>
    /// <para><b>Note:</b> This method does not take into account the <c>motion</c> property of the object. The returned object is a dictionary containing the following fields:</para>
    /// <para><c>collider_id</c>: The colliding object's ID.</para>
    /// <para><c>linear_velocity</c>: The colliding object's velocity <see cref="Godot.Vector2"/>. If the object is an <see cref="Godot.Area2D"/>, the result is <c>(0, 0)</c>.</para>
    /// <para><c>normal</c>: The object's surface normal at the intersection point.</para>
    /// <para><c>point</c>: The intersection point.</para>
    /// <para><c>rid</c>: The intersecting object's <see cref="Godot.Rid"/>.</para>
    /// <para><c>shape</c>: The shape index of the colliding shape.</para>
    /// </summary>
    public Godot.Collections.Dictionary GetRestInfo(PhysicsShapeQueryParameters2D parameters)
    {
        return NativeCalls.godot_icall_1_835(MethodBind5, GodotObject.GetPtr(this), GodotObject.GetPtr(parameters));
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
    public new class PropertyName : GodotObject.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : GodotObject.MethodName
    {
        /// <summary>
        /// Cached name for the 'intersect_point' method.
        /// </summary>
        public static readonly StringName IntersectPoint = "intersect_point";
        /// <summary>
        /// Cached name for the 'intersect_ray' method.
        /// </summary>
        public static readonly StringName IntersectRay = "intersect_ray";
        /// <summary>
        /// Cached name for the 'intersect_shape' method.
        /// </summary>
        public static readonly StringName IntersectShape = "intersect_shape";
        /// <summary>
        /// Cached name for the 'cast_motion' method.
        /// </summary>
        public static readonly StringName CastMotion = "cast_motion";
        /// <summary>
        /// Cached name for the 'collide_shape' method.
        /// </summary>
        public static readonly StringName CollideShape = "collide_shape";
        /// <summary>
        /// Cached name for the 'get_rest_info' method.
        /// </summary>
        public static readonly StringName GetRestInfo = "get_rest_info";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
    }
}
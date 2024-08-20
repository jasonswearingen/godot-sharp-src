namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>A 2D agent used to pathfind to a position while avoiding static and dynamic obstacles. The calculation can be used by the parent node to dynamically move it along the path. Requires navigation data to work correctly.</para>
/// <para>Dynamic obstacles are avoided using RVO collision avoidance. Avoidance is computed before physics, so the pathfinding information can be used safely in the physics step.</para>
/// <para><b>Note:</b> After setting the <see cref="Godot.NavigationAgent2D.TargetPosition"/> property, the <see cref="Godot.NavigationAgent2D.GetNextPathPosition()"/> method must be used once every physics frame to update the internal path logic of the navigation agent. The vector position it returns should be used as the next movement position for the agent's parent node.</para>
/// </summary>
public partial class NavigationAgent2D : Node
{
    /// <summary>
    /// <para>If set, a new navigation path from the current agent position to the <see cref="Godot.NavigationAgent2D.TargetPosition"/> is requested from the NavigationServer.</para>
    /// </summary>
    public Vector2 TargetPosition
    {
        get
        {
            return GetTargetPosition();
        }
        set
        {
            SetTargetPosition(value);
        }
    }

    /// <summary>
    /// <para>The distance threshold before a path point is considered to be reached. This allows agents to not have to hit a path point on the path exactly, but only to reach its general area. If this value is set too high, the NavigationAgent will skip points on the path, which can lead to it leaving the navigation mesh. If this value is set too low, the NavigationAgent will be stuck in a repath loop because it will constantly overshoot the distance to the next point on each physics frame update.</para>
    /// </summary>
    public float PathDesiredDistance
    {
        get
        {
            return GetPathDesiredDistance();
        }
        set
        {
            SetPathDesiredDistance(value);
        }
    }

    /// <summary>
    /// <para>The distance threshold before the target is considered to be reached. On reaching the target, <see cref="Godot.NavigationAgent2D.TargetReached"/> is emitted and navigation ends (see <see cref="Godot.NavigationAgent2D.IsNavigationFinished()"/> and <see cref="Godot.NavigationAgent2D.NavigationFinished"/>).</para>
    /// <para>You can make navigation end early by setting this property to a value greater than <see cref="Godot.NavigationAgent2D.PathDesiredDistance"/> (navigation will end before reaching the last waypoint).</para>
    /// <para>You can also make navigation end closer to the target than each individual path position by setting this property to a value lower than <see cref="Godot.NavigationAgent2D.PathDesiredDistance"/> (navigation won't immediately end when reaching the last waypoint). However, if the value set is too low, the agent will be stuck in a repath loop because it will constantly overshoot the distance to the target on each physics frame update.</para>
    /// </summary>
    public float TargetDesiredDistance
    {
        get
        {
            return GetTargetDesiredDistance();
        }
        set
        {
            SetTargetDesiredDistance(value);
        }
    }

    /// <summary>
    /// <para>The maximum distance the agent is allowed away from the ideal path to the final position. This can happen due to trying to avoid collisions. When the maximum distance is exceeded, it recalculates the ideal path.</para>
    /// </summary>
    public float PathMaxDistance
    {
        get
        {
            return GetPathMaxDistance();
        }
        set
        {
            SetPathMaxDistance(value);
        }
    }

    /// <summary>
    /// <para>A bitfield determining which navigation layers of navigation regions this agent will use to calculate a path. Changing it during runtime will clear the current navigation path and generate a new one, according to the new navigation layers.</para>
    /// </summary>
    public uint NavigationLayers
    {
        get
        {
            return GetNavigationLayers();
        }
        set
        {
            SetNavigationLayers(value);
        }
    }

    /// <summary>
    /// <para>The pathfinding algorithm used in the path query.</para>
    /// </summary>
    public NavigationPathQueryParameters2D.PathfindingAlgorithmEnum PathfindingAlgorithm
    {
        get
        {
            return GetPathfindingAlgorithm();
        }
        set
        {
            SetPathfindingAlgorithm(value);
        }
    }

    /// <summary>
    /// <para>The path postprocessing applied to the raw path corridor found by the <see cref="Godot.NavigationAgent2D.PathfindingAlgorithm"/>.</para>
    /// </summary>
    public NavigationPathQueryParameters2D.PathPostProcessing PathPostprocessing
    {
        get
        {
            return GetPathPostprocessing();
        }
        set
        {
            SetPathPostprocessing(value);
        }
    }

    /// <summary>
    /// <para>Additional information to return with the navigation path.</para>
    /// </summary>
    public NavigationPathQueryParameters2D.PathMetadataFlags PathMetadataFlags
    {
        get
        {
            return GetPathMetadataFlags();
        }
        set
        {
            SetPathMetadataFlags(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/> a simplified version of the path will be returned with less critical path points removed. The simplification amount is controlled by <see cref="Godot.NavigationAgent2D.SimplifyEpsilon"/>. The simplification uses a variant of Ramer-Douglas-Peucker algorithm for curve point decimation.</para>
    /// <para>Path simplification can be helpful to mitigate various path following issues that can arise with certain agent types and script behaviors. E.g. "steering" agents or avoidance in "open fields".</para>
    /// </summary>
    public bool SimplifyPath
    {
        get
        {
            return GetSimplifyPath();
        }
        set
        {
            SetSimplifyPath(value);
        }
    }

    /// <summary>
    /// <para>The path simplification amount in worlds units.</para>
    /// </summary>
    public float SimplifyEpsilon
    {
        get
        {
            return GetSimplifyEpsilon();
        }
        set
        {
            SetSimplifyEpsilon(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/> the agent is registered for an RVO avoidance callback on the <see cref="Godot.NavigationServer2D"/>. When <see cref="Godot.NavigationAgent2D.Velocity"/> is used and the processing is completed a <c>safe_velocity</c> Vector2 is received with a signal connection to <see cref="Godot.NavigationAgent2D.VelocityComputed"/>. Avoidance processing with many registered agents has a significant performance cost and should only be enabled on agents that currently require it.</para>
    /// </summary>
    public bool AvoidanceEnabled
    {
        get
        {
            return GetAvoidanceEnabled();
        }
        set
        {
            SetAvoidanceEnabled(value);
        }
    }

    /// <summary>
    /// <para>Sets the new wanted velocity for the agent. The avoidance simulation will try to fulfill this velocity if possible but will modify it to avoid collision with other agents and obstacles. When an agent is teleported to a new position, use <see cref="Godot.NavigationAgent2D.SetVelocityForced(Vector2)"/> as well to reset the internal simulation velocity.</para>
    /// </summary>
    public Vector2 Velocity
    {
        get
        {
            return GetVelocity();
        }
        set
        {
            SetVelocity(value);
        }
    }

    /// <summary>
    /// <para>The radius of the avoidance agent. This is the "body" of the avoidance agent and not the avoidance maneuver starting radius (which is controlled by <see cref="Godot.NavigationAgent2D.NeighborDistance"/>).</para>
    /// <para>Does not affect normal pathfinding. To change an actor's pathfinding radius bake <see cref="Godot.NavigationMesh"/> resources with a different <see cref="Godot.NavigationMesh.AgentRadius"/> property and use different navigation maps for each actor size.</para>
    /// </summary>
    public float Radius
    {
        get
        {
            return GetRadius();
        }
        set
        {
            SetRadius(value);
        }
    }

    /// <summary>
    /// <para>The distance to search for other agents.</para>
    /// </summary>
    public float NeighborDistance
    {
        get
        {
            return GetNeighborDistance();
        }
        set
        {
            SetNeighborDistance(value);
        }
    }

    /// <summary>
    /// <para>The maximum number of neighbors for the agent to consider.</para>
    /// </summary>
    public int MaxNeighbors
    {
        get
        {
            return GetMaxNeighbors();
        }
        set
        {
            SetMaxNeighbors(value);
        }
    }

    /// <summary>
    /// <para>The minimal amount of time for which this agent's velocities, that are computed with the collision avoidance algorithm, are safe with respect to other agents. The larger the number, the sooner the agent will respond to other agents, but less freedom in choosing its velocities. A too high value will slow down agents movement considerably. Must be positive.</para>
    /// </summary>
    public float TimeHorizonAgents
    {
        get
        {
            return GetTimeHorizonAgents();
        }
        set
        {
            SetTimeHorizonAgents(value);
        }
    }

    /// <summary>
    /// <para>The minimal amount of time for which this agent's velocities, that are computed with the collision avoidance algorithm, are safe with respect to static avoidance obstacles. The larger the number, the sooner the agent will respond to static avoidance obstacles, but less freedom in choosing its velocities. A too high value will slow down agents movement considerably. Must be positive.</para>
    /// </summary>
    public float TimeHorizonObstacles
    {
        get
        {
            return GetTimeHorizonObstacles();
        }
        set
        {
            SetTimeHorizonObstacles(value);
        }
    }

    /// <summary>
    /// <para>The maximum speed that an agent can move.</para>
    /// </summary>
    public float MaxSpeed
    {
        get
        {
            return GetMaxSpeed();
        }
        set
        {
            SetMaxSpeed(value);
        }
    }

    /// <summary>
    /// <para>A bitfield determining the avoidance layers for this NavigationAgent. Other agents with a matching bit on the <see cref="Godot.NavigationAgent2D.AvoidanceMask"/> will avoid this agent.</para>
    /// </summary>
    public uint AvoidanceLayers
    {
        get
        {
            return GetAvoidanceLayers();
        }
        set
        {
            SetAvoidanceLayers(value);
        }
    }

    /// <summary>
    /// <para>A bitfield determining what other avoidance agents and obstacles this NavigationAgent will avoid when a bit matches at least one of their <see cref="Godot.NavigationAgent2D.AvoidanceLayers"/>.</para>
    /// </summary>
    public uint AvoidanceMask
    {
        get
        {
            return GetAvoidanceMask();
        }
        set
        {
            SetAvoidanceMask(value);
        }
    }

    /// <summary>
    /// <para>The agent does not adjust the velocity for other agents that would match the <see cref="Godot.NavigationAgent2D.AvoidanceMask"/> but have a lower <see cref="Godot.NavigationAgent2D.AvoidancePriority"/>. This in turn makes the other agents with lower priority adjust their velocities even more to avoid collision with this agent.</para>
    /// </summary>
    public float AvoidancePriority
    {
        get
        {
            return GetAvoidancePriority();
        }
        set
        {
            SetAvoidancePriority(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/> shows debug visuals for this agent.</para>
    /// </summary>
    public bool DebugEnabled
    {
        get
        {
            return GetDebugEnabled();
        }
        set
        {
            SetDebugEnabled(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/> uses the defined <see cref="Godot.NavigationAgent2D.DebugPathCustomColor"/> for this agent instead of global color.</para>
    /// </summary>
    public bool DebugUseCustom
    {
        get
        {
            return GetDebugUseCustom();
        }
        set
        {
            SetDebugUseCustom(value);
        }
    }

    /// <summary>
    /// <para>If <see cref="Godot.NavigationAgent2D.DebugUseCustom"/> is <see langword="true"/> uses this color for this agent instead of global color.</para>
    /// </summary>
    public Color DebugPathCustomColor
    {
        get
        {
            return GetDebugPathCustomColor();
        }
        set
        {
            SetDebugPathCustomColor(value);
        }
    }

    /// <summary>
    /// <para>If <see cref="Godot.NavigationAgent2D.DebugUseCustom"/> is <see langword="true"/> uses this rasterized point size for rendering path points for this agent instead of global point size.</para>
    /// </summary>
    public float DebugPathCustomPointSize
    {
        get
        {
            return GetDebugPathCustomPointSize();
        }
        set
        {
            SetDebugPathCustomPointSize(value);
        }
    }

    /// <summary>
    /// <para>If <see cref="Godot.NavigationAgent2D.DebugUseCustom"/> is <see langword="true"/> uses this line width for rendering paths for this agent instead of global line width.</para>
    /// </summary>
    public float DebugPathCustomLineWidth
    {
        get
        {
            return GetDebugPathCustomLineWidth();
        }
        set
        {
            SetDebugPathCustomLineWidth(value);
        }
    }

    private static readonly System.Type CachedType = typeof(NavigationAgent2D);

    private static readonly StringName NativeName = "NavigationAgent2D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public NavigationAgent2D() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal NavigationAgent2D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRid, 2944877500ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.Rid"/> of this agent on the <see cref="Godot.NavigationServer2D"/>.</para>
    /// </summary>
    public Rid GetRid()
    {
        return NativeCalls.godot_icall_0_217(MethodBind0, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAvoidanceEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAvoidanceEnabled(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind1, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAvoidanceEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetAvoidanceEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind2, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPathDesiredDistance, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPathDesiredDistance(float desiredDistance)
    {
        NativeCalls.godot_icall_1_62(MethodBind3, GodotObject.GetPtr(this), desiredDistance);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPathDesiredDistance, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetPathDesiredDistance()
    {
        return NativeCalls.godot_icall_0_63(MethodBind4, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTargetDesiredDistance, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTargetDesiredDistance(float desiredDistance)
    {
        NativeCalls.godot_icall_1_62(MethodBind5, GodotObject.GetPtr(this), desiredDistance);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTargetDesiredDistance, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetTargetDesiredDistance()
    {
        return NativeCalls.godot_icall_0_63(MethodBind6, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRadius, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRadius(float radius)
    {
        NativeCalls.godot_icall_1_62(MethodBind7, GodotObject.GetPtr(this), radius);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRadius, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetRadius()
    {
        return NativeCalls.godot_icall_0_63(MethodBind8, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNeighborDistance, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNeighborDistance(float neighborDistance)
    {
        NativeCalls.godot_icall_1_62(MethodBind9, GodotObject.GetPtr(this), neighborDistance);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNeighborDistance, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetNeighborDistance()
    {
        return NativeCalls.godot_icall_0_63(MethodBind10, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMaxNeighbors, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMaxNeighbors(int maxNeighbors)
    {
        NativeCalls.godot_icall_1_36(MethodBind11, GodotObject.GetPtr(this), maxNeighbors);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMaxNeighbors, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetMaxNeighbors()
    {
        return NativeCalls.godot_icall_0_37(MethodBind12, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTimeHorizonAgents, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTimeHorizonAgents(float timeHorizon)
    {
        NativeCalls.godot_icall_1_62(MethodBind13, GodotObject.GetPtr(this), timeHorizon);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTimeHorizonAgents, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetTimeHorizonAgents()
    {
        return NativeCalls.godot_icall_0_63(MethodBind14, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTimeHorizonObstacles, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTimeHorizonObstacles(float timeHorizon)
    {
        NativeCalls.godot_icall_1_62(MethodBind15, GodotObject.GetPtr(this), timeHorizon);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTimeHorizonObstacles, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetTimeHorizonObstacles()
    {
        return NativeCalls.godot_icall_0_63(MethodBind16, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMaxSpeed, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMaxSpeed(float maxSpeed)
    {
        NativeCalls.godot_icall_1_62(MethodBind17, GodotObject.GetPtr(this), maxSpeed);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMaxSpeed, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetMaxSpeed()
    {
        return NativeCalls.godot_icall_0_63(MethodBind18, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPathMaxDistance, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPathMaxDistance(float maxSpeed)
    {
        NativeCalls.godot_icall_1_62(MethodBind19, GodotObject.GetPtr(this), maxSpeed);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPathMaxDistance, 191475506ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetPathMaxDistance()
    {
        return NativeCalls.godot_icall_0_63(MethodBind20, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNavigationLayers, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNavigationLayers(uint navigationLayers)
    {
        NativeCalls.godot_icall_1_192(MethodBind21, GodotObject.GetPtr(this), navigationLayers);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNavigationLayers, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetNavigationLayers()
    {
        return NativeCalls.godot_icall_0_193(MethodBind22, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNavigationLayerValue, 300928843ul);

    /// <summary>
    /// <para>Based on <paramref name="value"/>, enables or disables the specified layer in the <see cref="Godot.NavigationAgent2D.NavigationLayers"/> bitmask, given a <paramref name="layerNumber"/> between 1 and 32.</para>
    /// </summary>
    public void SetNavigationLayerValue(int layerNumber, bool value)
    {
        NativeCalls.godot_icall_2_74(MethodBind23, GodotObject.GetPtr(this), layerNumber, value.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNavigationLayerValue, 1116898809ul);

    /// <summary>
    /// <para>Returns whether or not the specified layer of the <see cref="Godot.NavigationAgent2D.NavigationLayers"/> bitmask is enabled, given a <paramref name="layerNumber"/> between 1 and 32.</para>
    /// </summary>
    public bool GetNavigationLayerValue(int layerNumber)
    {
        return NativeCalls.godot_icall_1_75(MethodBind24, GodotObject.GetPtr(this), layerNumber).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPathfindingAlgorithm, 2783519915ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPathfindingAlgorithm(NavigationPathQueryParameters2D.PathfindingAlgorithmEnum pathfindingAlgorithm)
    {
        NativeCalls.godot_icall_1_36(MethodBind25, GodotObject.GetPtr(this), (int)pathfindingAlgorithm);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPathfindingAlgorithm, 3000421146ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NavigationPathQueryParameters2D.PathfindingAlgorithmEnum GetPathfindingAlgorithm()
    {
        return (NavigationPathQueryParameters2D.PathfindingAlgorithmEnum)NativeCalls.godot_icall_0_37(MethodBind26, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPathPostprocessing, 2864409082ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPathPostprocessing(NavigationPathQueryParameters2D.PathPostProcessing pathPostprocessing)
    {
        NativeCalls.godot_icall_1_36(MethodBind27, GodotObject.GetPtr(this), (int)pathPostprocessing);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPathPostprocessing, 3798118993ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NavigationPathQueryParameters2D.PathPostProcessing GetPathPostprocessing()
    {
        return (NavigationPathQueryParameters2D.PathPostProcessing)NativeCalls.godot_icall_0_37(MethodBind28, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPathMetadataFlags, 24274129ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPathMetadataFlags(NavigationPathQueryParameters2D.PathMetadataFlags flags)
    {
        NativeCalls.godot_icall_1_36(MethodBind29, GodotObject.GetPtr(this), (int)flags);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind30 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPathMetadataFlags, 488152976ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NavigationPathQueryParameters2D.PathMetadataFlags GetPathMetadataFlags()
    {
        return (NavigationPathQueryParameters2D.PathMetadataFlags)NativeCalls.godot_icall_0_37(MethodBind30, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind31 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNavigationMap, 2722037293ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.Rid"/> of the navigation map this NavigationAgent node should use and also updates the <c>agent</c> on the NavigationServer.</para>
    /// </summary>
    public void SetNavigationMap(Rid navigationMap)
    {
        NativeCalls.godot_icall_1_255(MethodBind31, GodotObject.GetPtr(this), navigationMap);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind32 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNavigationMap, 2944877500ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.Rid"/> of the navigation map for this NavigationAgent node. This function returns always the map set on the NavigationAgent node and not the map of the abstract agent on the NavigationServer. If the agent map is changed directly with the NavigationServer API the NavigationAgent node will not be aware of the map change. Use <see cref="Godot.NavigationAgent2D.SetNavigationMap(Rid)"/> to change the navigation map for the NavigationAgent and also update the agent on the NavigationServer.</para>
    /// </summary>
    public Rid GetNavigationMap()
    {
        return NativeCalls.godot_icall_0_217(MethodBind32, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind33 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTargetPosition, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetTargetPosition(Vector2 position)
    {
        NativeCalls.godot_icall_1_34(MethodBind33, GodotObject.GetPtr(this), &position);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind34 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTargetPosition, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetTargetPosition()
    {
        return NativeCalls.godot_icall_0_35(MethodBind34, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind35 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSimplifyPath, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSimplifyPath(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind35, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind36 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSimplifyPath, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetSimplifyPath()
    {
        return NativeCalls.godot_icall_0_40(MethodBind36, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind37 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSimplifyEpsilon, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSimplifyEpsilon(float epsilon)
    {
        NativeCalls.godot_icall_1_62(MethodBind37, GodotObject.GetPtr(this), epsilon);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind38 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSimplifyEpsilon, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetSimplifyEpsilon()
    {
        return NativeCalls.godot_icall_0_63(MethodBind38, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind39 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNextPathPosition, 1497962370ul);

    /// <summary>
    /// <para>Returns the next position in global coordinates that can be moved to, making sure that there are no static objects in the way. If the agent does not have a navigation path, it will return the position of the agent's parent. The use of this function once every physics frame is required to update the internal path logic of the NavigationAgent.</para>
    /// </summary>
    public Vector2 GetNextPathPosition()
    {
        return NativeCalls.godot_icall_0_35(MethodBind39, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind40 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetVelocityForced, 743155724ul);

    /// <summary>
    /// <para>Replaces the internal velocity in the collision avoidance simulation with <paramref name="velocity"/>. When an agent is teleported to a new position this function should be used in the same frame. If called frequently this function can get agents stuck.</para>
    /// </summary>
    public unsafe void SetVelocityForced(Vector2 velocity)
    {
        NativeCalls.godot_icall_1_34(MethodBind40, GodotObject.GetPtr(this), &velocity);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind41 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetVelocity, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetVelocity(Vector2 velocity)
    {
        NativeCalls.godot_icall_1_34(MethodBind41, GodotObject.GetPtr(this), &velocity);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind42 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetVelocity, 1497962370ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetVelocity()
    {
        return NativeCalls.godot_icall_0_35(MethodBind42, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind43 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DistanceToTarget, 1740695150ul);

    /// <summary>
    /// <para>Returns the distance to the target position, using the agent's global position. The user must set <see cref="Godot.NavigationAgent2D.TargetPosition"/> in order for this to be accurate.</para>
    /// </summary>
    public float DistanceToTarget()
    {
        return NativeCalls.godot_icall_0_63(MethodBind43, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind44 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCurrentNavigationResult, 166799483ul);

    /// <summary>
    /// <para>Returns the path query result for the path the agent is currently following.</para>
    /// </summary>
    public NavigationPathQueryResult2D GetCurrentNavigationResult()
    {
        return (NavigationPathQueryResult2D)NativeCalls.godot_icall_0_58(MethodBind44, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind45 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCurrentNavigationPath, 2961356807ul);

    /// <summary>
    /// <para>Returns this agent's current path from start to finish in global coordinates. The path only updates when the target position is changed or the agent requires a repath. The path array is not intended to be used in direct path movement as the agent has its own internal path logic that would get corrupted by changing the path array manually. Use the intended <see cref="Godot.NavigationAgent2D.GetNextPathPosition()"/> once every physics frame to receive the next path point for the agents movement as this function also updates the internal path logic.</para>
    /// </summary>
    public Vector2[] GetCurrentNavigationPath()
    {
        return NativeCalls.godot_icall_0_204(MethodBind45, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind46 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCurrentNavigationPathIndex, 3905245786ul);

    /// <summary>
    /// <para>Returns which index the agent is currently on in the navigation path's <see cref="Godot.Vector2"/>[].</para>
    /// </summary>
    public int GetCurrentNavigationPathIndex()
    {
        return NativeCalls.godot_icall_0_37(MethodBind46, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind47 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsTargetReached, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the agent reached the target, i.e. the agent moved within <see cref="Godot.NavigationAgent2D.TargetDesiredDistance"/> of the <see cref="Godot.NavigationAgent2D.TargetPosition"/>. It may not always be possible to reach the target but it should always be possible to reach the final position. See <see cref="Godot.NavigationAgent2D.GetFinalPosition()"/>.</para>
    /// </summary>
    public bool IsTargetReached()
    {
        return NativeCalls.godot_icall_0_40(MethodBind47, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind48 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsTargetReachable, 2240911060ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if <see cref="Godot.NavigationAgent2D.GetFinalPosition()"/> is within <see cref="Godot.NavigationAgent2D.TargetDesiredDistance"/> of the <see cref="Godot.NavigationAgent2D.TargetPosition"/>.</para>
    /// </summary>
    public bool IsTargetReachable()
    {
        return NativeCalls.godot_icall_0_40(MethodBind48, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind49 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsNavigationFinished, 2240911060ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the agent's navigation has finished. If the target is reachable, navigation ends when the target is reached. If the target is unreachable, navigation ends when the last waypoint of the path is reached.</para>
    /// <para><b>Note:</b> While <see langword="true"/> prefer to stop calling update functions like <see cref="Godot.NavigationAgent2D.GetNextPathPosition()"/>. This avoids jittering the standing agent due to calling repeated path updates.</para>
    /// </summary>
    public bool IsNavigationFinished()
    {
        return NativeCalls.godot_icall_0_40(MethodBind49, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind50 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFinalPosition, 1497962370ul);

    /// <summary>
    /// <para>Returns the reachable final position of the current navigation path in global coordinates. This position can change if the agent needs to update the navigation path which makes the agent emit the <see cref="Godot.NavigationAgent2D.PathChanged"/> signal.</para>
    /// </summary>
    public Vector2 GetFinalPosition()
    {
        return NativeCalls.godot_icall_0_35(MethodBind50, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind51 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAvoidanceLayers, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAvoidanceLayers(uint layers)
    {
        NativeCalls.godot_icall_1_192(MethodBind51, GodotObject.GetPtr(this), layers);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind52 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAvoidanceLayers, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetAvoidanceLayers()
    {
        return NativeCalls.godot_icall_0_193(MethodBind52, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind53 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAvoidanceMask, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAvoidanceMask(uint mask)
    {
        NativeCalls.godot_icall_1_192(MethodBind53, GodotObject.GetPtr(this), mask);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind54 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAvoidanceMask, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetAvoidanceMask()
    {
        return NativeCalls.godot_icall_0_193(MethodBind54, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind55 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAvoidanceLayerValue, 300928843ul);

    /// <summary>
    /// <para>Based on <paramref name="value"/>, enables or disables the specified layer in the <see cref="Godot.NavigationAgent2D.AvoidanceLayers"/> bitmask, given a <paramref name="layerNumber"/> between 1 and 32.</para>
    /// </summary>
    public void SetAvoidanceLayerValue(int layerNumber, bool value)
    {
        NativeCalls.godot_icall_2_74(MethodBind55, GodotObject.GetPtr(this), layerNumber, value.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind56 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAvoidanceLayerValue, 1116898809ul);

    /// <summary>
    /// <para>Returns whether or not the specified layer of the <see cref="Godot.NavigationAgent2D.AvoidanceLayers"/> bitmask is enabled, given a <paramref name="layerNumber"/> between 1 and 32.</para>
    /// </summary>
    public bool GetAvoidanceLayerValue(int layerNumber)
    {
        return NativeCalls.godot_icall_1_75(MethodBind56, GodotObject.GetPtr(this), layerNumber).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind57 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAvoidanceMaskValue, 300928843ul);

    /// <summary>
    /// <para>Based on <paramref name="value"/>, enables or disables the specified mask in the <see cref="Godot.NavigationAgent2D.AvoidanceMask"/> bitmask, given a <paramref name="maskNumber"/> between 1 and 32.</para>
    /// </summary>
    public void SetAvoidanceMaskValue(int maskNumber, bool value)
    {
        NativeCalls.godot_icall_2_74(MethodBind57, GodotObject.GetPtr(this), maskNumber, value.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind58 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAvoidanceMaskValue, 1116898809ul);

    /// <summary>
    /// <para>Returns whether or not the specified mask of the <see cref="Godot.NavigationAgent2D.AvoidanceMask"/> bitmask is enabled, given a <paramref name="maskNumber"/> between 1 and 32.</para>
    /// </summary>
    public bool GetAvoidanceMaskValue(int maskNumber)
    {
        return NativeCalls.godot_icall_1_75(MethodBind58, GodotObject.GetPtr(this), maskNumber).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind59 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAvoidancePriority, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAvoidancePriority(float priority)
    {
        NativeCalls.godot_icall_1_62(MethodBind59, GodotObject.GetPtr(this), priority);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind60 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAvoidancePriority, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetAvoidancePriority()
    {
        return NativeCalls.godot_icall_0_63(MethodBind60, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind61 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDebugEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDebugEnabled(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind61, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind62 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDebugEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetDebugEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind62, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind63 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDebugUseCustom, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDebugUseCustom(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind63, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind64 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDebugUseCustom, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetDebugUseCustom()
    {
        return NativeCalls.godot_icall_0_40(MethodBind64, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind65 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDebugPathCustomColor, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetDebugPathCustomColor(Color color)
    {
        NativeCalls.godot_icall_1_195(MethodBind65, GodotObject.GetPtr(this), &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind66 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDebugPathCustomColor, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetDebugPathCustomColor()
    {
        return NativeCalls.godot_icall_0_196(MethodBind66, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind67 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDebugPathCustomPointSize, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDebugPathCustomPointSize(float pointSize)
    {
        NativeCalls.godot_icall_1_62(MethodBind67, GodotObject.GetPtr(this), pointSize);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind68 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDebugPathCustomPointSize, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetDebugPathCustomPointSize()
    {
        return NativeCalls.godot_icall_0_63(MethodBind68, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind69 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDebugPathCustomLineWidth, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDebugPathCustomLineWidth(float lineWidth)
    {
        NativeCalls.godot_icall_1_62(MethodBind69, GodotObject.GetPtr(this), lineWidth);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind70 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDebugPathCustomLineWidth, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetDebugPathCustomLineWidth()
    {
        return NativeCalls.godot_icall_0_63(MethodBind70, GodotObject.GetPtr(this));
    }

    /// <summary>
    /// <para>Emitted when the agent had to update the loaded path:</para>
    /// <para>- because path was previously empty.</para>
    /// <para>- because navigation map has changed.</para>
    /// <para>- because agent pushed further away from the current path segment than the <see cref="Godot.NavigationAgent2D.PathMaxDistance"/>.</para>
    /// </summary>
    public event Action PathChanged
    {
        add => Connect(SignalName.PathChanged, Callable.From(value));
        remove => Disconnect(SignalName.PathChanged, Callable.From(value));
    }

    /// <summary>
    /// <para>Signals that the agent reached the target, i.e. the agent moved within <see cref="Godot.NavigationAgent2D.TargetDesiredDistance"/> of the <see cref="Godot.NavigationAgent2D.TargetPosition"/>. This signal is emitted only once per loaded path.</para>
    /// <para>This signal will be emitted just before <see cref="Godot.NavigationAgent2D.NavigationFinished"/> when the target is reachable.</para>
    /// <para>It may not always be possible to reach the target but it should always be possible to reach the final position. See <see cref="Godot.NavigationAgent2D.GetFinalPosition()"/>.</para>
    /// </summary>
    public event Action TargetReached
    {
        add => Connect(SignalName.TargetReached, Callable.From(value));
        remove => Disconnect(SignalName.TargetReached, Callable.From(value));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.NavigationAgent2D.WaypointReached"/> event of a <see cref="Godot.NavigationAgent2D"/> class.
    /// </summary>
    public delegate void WaypointReachedEventHandler(Godot.Collections.Dictionary details);

    private static void WaypointReachedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((WaypointReachedEventHandler)delegateObj)(VariantUtils.ConvertTo<Godot.Collections.Dictionary>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Signals that the agent reached a waypoint. Emitted when the agent moves within <see cref="Godot.NavigationAgent2D.PathDesiredDistance"/> of the next position of the path.</para>
    /// <para>The details dictionary may contain the following keys depending on the value of <see cref="Godot.NavigationAgent2D.PathMetadataFlags"/>:</para>
    /// <para>- <c>position</c>: The position of the waypoint that was reached.</para>
    /// <para>- <c>type</c>: The type of navigation primitive (region or link) that contains this waypoint.</para>
    /// <para>- <c>rid</c>: The <see cref="Godot.Rid"/> of the containing navigation primitive (region or link).</para>
    /// <para>- <c>owner</c>: The object which manages the containing navigation primitive (region or link).</para>
    /// </summary>
    public unsafe event WaypointReachedEventHandler WaypointReached
    {
        add => Connect(SignalName.WaypointReached, Callable.CreateWithUnsafeTrampoline(value, &WaypointReachedTrampoline));
        remove => Disconnect(SignalName.WaypointReached, Callable.CreateWithUnsafeTrampoline(value, &WaypointReachedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.NavigationAgent2D.LinkReached"/> event of a <see cref="Godot.NavigationAgent2D"/> class.
    /// </summary>
    public delegate void LinkReachedEventHandler(Godot.Collections.Dictionary details);

    private static void LinkReachedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((LinkReachedEventHandler)delegateObj)(VariantUtils.ConvertTo<Godot.Collections.Dictionary>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Signals that the agent reached a navigation link. Emitted when the agent moves within <see cref="Godot.NavigationAgent2D.PathDesiredDistance"/> of the next position of the path when that position is a navigation link.</para>
    /// <para>The details dictionary may contain the following keys depending on the value of <see cref="Godot.NavigationAgent2D.PathMetadataFlags"/>:</para>
    /// <para>- <c>position</c>: The start position of the link that was reached.</para>
    /// <para>- <c>type</c>: Always <see cref="Godot.NavigationPathQueryResult2D.PathSegmentType.Link"/>.</para>
    /// <para>- <c>rid</c>: The <see cref="Godot.Rid"/> of the link.</para>
    /// <para>- <c>owner</c>: The object which manages the link (usually <see cref="Godot.NavigationLink2D"/>).</para>
    /// <para>- <c>link_entry_position</c>: If <c>owner</c> is available and the owner is a <see cref="Godot.NavigationLink2D"/>, it will contain the global position of the link's point the agent is entering.</para>
    /// <para>- <c>link_exit_position</c>: If <c>owner</c> is available and the owner is a <see cref="Godot.NavigationLink2D"/>, it will contain the global position of the link's point which the agent is exiting.</para>
    /// </summary>
    public unsafe event LinkReachedEventHandler LinkReached
    {
        add => Connect(SignalName.LinkReached, Callable.CreateWithUnsafeTrampoline(value, &LinkReachedTrampoline));
        remove => Disconnect(SignalName.LinkReached, Callable.CreateWithUnsafeTrampoline(value, &LinkReachedTrampoline));
    }

    /// <summary>
    /// <para>Signals that the agent's navigation has finished. If the target is reachable, navigation ends when the target is reached. If the target is unreachable, navigation ends when the last waypoint of the path is reached. This signal is emitted only once per loaded path.</para>
    /// <para>This signal will be emitted just after <see cref="Godot.NavigationAgent2D.TargetReached"/> when the target is reachable.</para>
    /// </summary>
    public event Action NavigationFinished
    {
        add => Connect(SignalName.NavigationFinished, Callable.From(value));
        remove => Disconnect(SignalName.NavigationFinished, Callable.From(value));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.NavigationAgent2D.VelocityComputed"/> event of a <see cref="Godot.NavigationAgent2D"/> class.
    /// </summary>
    public delegate void VelocityComputedEventHandler(Vector2 safeVelocity);

    private static void VelocityComputedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((VelocityComputedEventHandler)delegateObj)(VariantUtils.ConvertTo<Vector2>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Notifies when the collision avoidance velocity is calculated. Emitted every update as long as <see cref="Godot.NavigationAgent2D.AvoidanceEnabled"/> is <see langword="true"/> and the agent has a navigation map.</para>
    /// </summary>
    public unsafe event VelocityComputedEventHandler VelocityComputed
    {
        add => Connect(SignalName.VelocityComputed, Callable.CreateWithUnsafeTrampoline(value, &VelocityComputedTrampoline));
        remove => Disconnect(SignalName.VelocityComputed, Callable.CreateWithUnsafeTrampoline(value, &VelocityComputedTrampoline));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_path_changed = "PathChanged";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_target_reached = "TargetReached";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_waypoint_reached = "WaypointReached";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_link_reached = "LinkReached";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_navigation_finished = "NavigationFinished";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_velocity_computed = "VelocityComputed";

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
        if (signal == SignalName.PathChanged)
        {
            if (HasGodotClassSignal(SignalProxyName_path_changed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.TargetReached)
        {
            if (HasGodotClassSignal(SignalProxyName_target_reached.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.WaypointReached)
        {
            if (HasGodotClassSignal(SignalProxyName_waypoint_reached.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.LinkReached)
        {
            if (HasGodotClassSignal(SignalProxyName_link_reached.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.NavigationFinished)
        {
            if (HasGodotClassSignal(SignalProxyName_navigation_finished.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.VelocityComputed)
        {
            if (HasGodotClassSignal(SignalProxyName_velocity_computed.NativeValue.DangerousSelfRef))
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
        /// Cached name for the 'target_position' property.
        /// </summary>
        public static readonly StringName TargetPosition = "target_position";
        /// <summary>
        /// Cached name for the 'path_desired_distance' property.
        /// </summary>
        public static readonly StringName PathDesiredDistance = "path_desired_distance";
        /// <summary>
        /// Cached name for the 'target_desired_distance' property.
        /// </summary>
        public static readonly StringName TargetDesiredDistance = "target_desired_distance";
        /// <summary>
        /// Cached name for the 'path_max_distance' property.
        /// </summary>
        public static readonly StringName PathMaxDistance = "path_max_distance";
        /// <summary>
        /// Cached name for the 'navigation_layers' property.
        /// </summary>
        public static readonly StringName NavigationLayers = "navigation_layers";
        /// <summary>
        /// Cached name for the 'pathfinding_algorithm' property.
        /// </summary>
        public static readonly StringName PathfindingAlgorithm = "pathfinding_algorithm";
        /// <summary>
        /// Cached name for the 'path_postprocessing' property.
        /// </summary>
        public static readonly StringName PathPostprocessing = "path_postprocessing";
        /// <summary>
        /// Cached name for the 'path_metadata_flags' property.
        /// </summary>
        public static readonly StringName PathMetadataFlags = "path_metadata_flags";
        /// <summary>
        /// Cached name for the 'simplify_path' property.
        /// </summary>
        public static readonly StringName SimplifyPath = "simplify_path";
        /// <summary>
        /// Cached name for the 'simplify_epsilon' property.
        /// </summary>
        public static readonly StringName SimplifyEpsilon = "simplify_epsilon";
        /// <summary>
        /// Cached name for the 'avoidance_enabled' property.
        /// </summary>
        public static readonly StringName AvoidanceEnabled = "avoidance_enabled";
        /// <summary>
        /// Cached name for the 'velocity' property.
        /// </summary>
        public static readonly StringName Velocity = "velocity";
        /// <summary>
        /// Cached name for the 'radius' property.
        /// </summary>
        public static readonly StringName Radius = "radius";
        /// <summary>
        /// Cached name for the 'neighbor_distance' property.
        /// </summary>
        public static readonly StringName NeighborDistance = "neighbor_distance";
        /// <summary>
        /// Cached name for the 'max_neighbors' property.
        /// </summary>
        public static readonly StringName MaxNeighbors = "max_neighbors";
        /// <summary>
        /// Cached name for the 'time_horizon_agents' property.
        /// </summary>
        public static readonly StringName TimeHorizonAgents = "time_horizon_agents";
        /// <summary>
        /// Cached name for the 'time_horizon_obstacles' property.
        /// </summary>
        public static readonly StringName TimeHorizonObstacles = "time_horizon_obstacles";
        /// <summary>
        /// Cached name for the 'max_speed' property.
        /// </summary>
        public static readonly StringName MaxSpeed = "max_speed";
        /// <summary>
        /// Cached name for the 'avoidance_layers' property.
        /// </summary>
        public static readonly StringName AvoidanceLayers = "avoidance_layers";
        /// <summary>
        /// Cached name for the 'avoidance_mask' property.
        /// </summary>
        public static readonly StringName AvoidanceMask = "avoidance_mask";
        /// <summary>
        /// Cached name for the 'avoidance_priority' property.
        /// </summary>
        public static readonly StringName AvoidancePriority = "avoidance_priority";
        /// <summary>
        /// Cached name for the 'debug_enabled' property.
        /// </summary>
        public static readonly StringName DebugEnabled = "debug_enabled";
        /// <summary>
        /// Cached name for the 'debug_use_custom' property.
        /// </summary>
        public static readonly StringName DebugUseCustom = "debug_use_custom";
        /// <summary>
        /// Cached name for the 'debug_path_custom_color' property.
        /// </summary>
        public static readonly StringName DebugPathCustomColor = "debug_path_custom_color";
        /// <summary>
        /// Cached name for the 'debug_path_custom_point_size' property.
        /// </summary>
        public static readonly StringName DebugPathCustomPointSize = "debug_path_custom_point_size";
        /// <summary>
        /// Cached name for the 'debug_path_custom_line_width' property.
        /// </summary>
        public static readonly StringName DebugPathCustomLineWidth = "debug_path_custom_line_width";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Node.MethodName
    {
        /// <summary>
        /// Cached name for the 'get_rid' method.
        /// </summary>
        public static readonly StringName GetRid = "get_rid";
        /// <summary>
        /// Cached name for the 'set_avoidance_enabled' method.
        /// </summary>
        public static readonly StringName SetAvoidanceEnabled = "set_avoidance_enabled";
        /// <summary>
        /// Cached name for the 'get_avoidance_enabled' method.
        /// </summary>
        public static readonly StringName GetAvoidanceEnabled = "get_avoidance_enabled";
        /// <summary>
        /// Cached name for the 'set_path_desired_distance' method.
        /// </summary>
        public static readonly StringName SetPathDesiredDistance = "set_path_desired_distance";
        /// <summary>
        /// Cached name for the 'get_path_desired_distance' method.
        /// </summary>
        public static readonly StringName GetPathDesiredDistance = "get_path_desired_distance";
        /// <summary>
        /// Cached name for the 'set_target_desired_distance' method.
        /// </summary>
        public static readonly StringName SetTargetDesiredDistance = "set_target_desired_distance";
        /// <summary>
        /// Cached name for the 'get_target_desired_distance' method.
        /// </summary>
        public static readonly StringName GetTargetDesiredDistance = "get_target_desired_distance";
        /// <summary>
        /// Cached name for the 'set_radius' method.
        /// </summary>
        public static readonly StringName SetRadius = "set_radius";
        /// <summary>
        /// Cached name for the 'get_radius' method.
        /// </summary>
        public static readonly StringName GetRadius = "get_radius";
        /// <summary>
        /// Cached name for the 'set_neighbor_distance' method.
        /// </summary>
        public static readonly StringName SetNeighborDistance = "set_neighbor_distance";
        /// <summary>
        /// Cached name for the 'get_neighbor_distance' method.
        /// </summary>
        public static readonly StringName GetNeighborDistance = "get_neighbor_distance";
        /// <summary>
        /// Cached name for the 'set_max_neighbors' method.
        /// </summary>
        public static readonly StringName SetMaxNeighbors = "set_max_neighbors";
        /// <summary>
        /// Cached name for the 'get_max_neighbors' method.
        /// </summary>
        public static readonly StringName GetMaxNeighbors = "get_max_neighbors";
        /// <summary>
        /// Cached name for the 'set_time_horizon_agents' method.
        /// </summary>
        public static readonly StringName SetTimeHorizonAgents = "set_time_horizon_agents";
        /// <summary>
        /// Cached name for the 'get_time_horizon_agents' method.
        /// </summary>
        public static readonly StringName GetTimeHorizonAgents = "get_time_horizon_agents";
        /// <summary>
        /// Cached name for the 'set_time_horizon_obstacles' method.
        /// </summary>
        public static readonly StringName SetTimeHorizonObstacles = "set_time_horizon_obstacles";
        /// <summary>
        /// Cached name for the 'get_time_horizon_obstacles' method.
        /// </summary>
        public static readonly StringName GetTimeHorizonObstacles = "get_time_horizon_obstacles";
        /// <summary>
        /// Cached name for the 'set_max_speed' method.
        /// </summary>
        public static readonly StringName SetMaxSpeed = "set_max_speed";
        /// <summary>
        /// Cached name for the 'get_max_speed' method.
        /// </summary>
        public static readonly StringName GetMaxSpeed = "get_max_speed";
        /// <summary>
        /// Cached name for the 'set_path_max_distance' method.
        /// </summary>
        public static readonly StringName SetPathMaxDistance = "set_path_max_distance";
        /// <summary>
        /// Cached name for the 'get_path_max_distance' method.
        /// </summary>
        public static readonly StringName GetPathMaxDistance = "get_path_max_distance";
        /// <summary>
        /// Cached name for the 'set_navigation_layers' method.
        /// </summary>
        public static readonly StringName SetNavigationLayers = "set_navigation_layers";
        /// <summary>
        /// Cached name for the 'get_navigation_layers' method.
        /// </summary>
        public static readonly StringName GetNavigationLayers = "get_navigation_layers";
        /// <summary>
        /// Cached name for the 'set_navigation_layer_value' method.
        /// </summary>
        public static readonly StringName SetNavigationLayerValue = "set_navigation_layer_value";
        /// <summary>
        /// Cached name for the 'get_navigation_layer_value' method.
        /// </summary>
        public static readonly StringName GetNavigationLayerValue = "get_navigation_layer_value";
        /// <summary>
        /// Cached name for the 'set_pathfinding_algorithm' method.
        /// </summary>
        public static readonly StringName SetPathfindingAlgorithm = "set_pathfinding_algorithm";
        /// <summary>
        /// Cached name for the 'get_pathfinding_algorithm' method.
        /// </summary>
        public static readonly StringName GetPathfindingAlgorithm = "get_pathfinding_algorithm";
        /// <summary>
        /// Cached name for the 'set_path_postprocessing' method.
        /// </summary>
        public static readonly StringName SetPathPostprocessing = "set_path_postprocessing";
        /// <summary>
        /// Cached name for the 'get_path_postprocessing' method.
        /// </summary>
        public static readonly StringName GetPathPostprocessing = "get_path_postprocessing";
        /// <summary>
        /// Cached name for the 'set_path_metadata_flags' method.
        /// </summary>
        public static readonly StringName SetPathMetadataFlags = "set_path_metadata_flags";
        /// <summary>
        /// Cached name for the 'get_path_metadata_flags' method.
        /// </summary>
        public static readonly StringName GetPathMetadataFlags = "get_path_metadata_flags";
        /// <summary>
        /// Cached name for the 'set_navigation_map' method.
        /// </summary>
        public static readonly StringName SetNavigationMap = "set_navigation_map";
        /// <summary>
        /// Cached name for the 'get_navigation_map' method.
        /// </summary>
        public static readonly StringName GetNavigationMap = "get_navigation_map";
        /// <summary>
        /// Cached name for the 'set_target_position' method.
        /// </summary>
        public static readonly StringName SetTargetPosition = "set_target_position";
        /// <summary>
        /// Cached name for the 'get_target_position' method.
        /// </summary>
        public static readonly StringName GetTargetPosition = "get_target_position";
        /// <summary>
        /// Cached name for the 'set_simplify_path' method.
        /// </summary>
        public static readonly StringName SetSimplifyPath = "set_simplify_path";
        /// <summary>
        /// Cached name for the 'get_simplify_path' method.
        /// </summary>
        public static readonly StringName GetSimplifyPath = "get_simplify_path";
        /// <summary>
        /// Cached name for the 'set_simplify_epsilon' method.
        /// </summary>
        public static readonly StringName SetSimplifyEpsilon = "set_simplify_epsilon";
        /// <summary>
        /// Cached name for the 'get_simplify_epsilon' method.
        /// </summary>
        public static readonly StringName GetSimplifyEpsilon = "get_simplify_epsilon";
        /// <summary>
        /// Cached name for the 'get_next_path_position' method.
        /// </summary>
        public static readonly StringName GetNextPathPosition = "get_next_path_position";
        /// <summary>
        /// Cached name for the 'set_velocity_forced' method.
        /// </summary>
        public static readonly StringName SetVelocityForced = "set_velocity_forced";
        /// <summary>
        /// Cached name for the 'set_velocity' method.
        /// </summary>
        public static readonly StringName SetVelocity = "set_velocity";
        /// <summary>
        /// Cached name for the 'get_velocity' method.
        /// </summary>
        public static readonly StringName GetVelocity = "get_velocity";
        /// <summary>
        /// Cached name for the 'distance_to_target' method.
        /// </summary>
        public static readonly StringName DistanceToTarget = "distance_to_target";
        /// <summary>
        /// Cached name for the 'get_current_navigation_result' method.
        /// </summary>
        public static readonly StringName GetCurrentNavigationResult = "get_current_navigation_result";
        /// <summary>
        /// Cached name for the 'get_current_navigation_path' method.
        /// </summary>
        public static readonly StringName GetCurrentNavigationPath = "get_current_navigation_path";
        /// <summary>
        /// Cached name for the 'get_current_navigation_path_index' method.
        /// </summary>
        public static readonly StringName GetCurrentNavigationPathIndex = "get_current_navigation_path_index";
        /// <summary>
        /// Cached name for the 'is_target_reached' method.
        /// </summary>
        public static readonly StringName IsTargetReached = "is_target_reached";
        /// <summary>
        /// Cached name for the 'is_target_reachable' method.
        /// </summary>
        public static readonly StringName IsTargetReachable = "is_target_reachable";
        /// <summary>
        /// Cached name for the 'is_navigation_finished' method.
        /// </summary>
        public static readonly StringName IsNavigationFinished = "is_navigation_finished";
        /// <summary>
        /// Cached name for the 'get_final_position' method.
        /// </summary>
        public static readonly StringName GetFinalPosition = "get_final_position";
        /// <summary>
        /// Cached name for the 'set_avoidance_layers' method.
        /// </summary>
        public static readonly StringName SetAvoidanceLayers = "set_avoidance_layers";
        /// <summary>
        /// Cached name for the 'get_avoidance_layers' method.
        /// </summary>
        public static readonly StringName GetAvoidanceLayers = "get_avoidance_layers";
        /// <summary>
        /// Cached name for the 'set_avoidance_mask' method.
        /// </summary>
        public static readonly StringName SetAvoidanceMask = "set_avoidance_mask";
        /// <summary>
        /// Cached name for the 'get_avoidance_mask' method.
        /// </summary>
        public static readonly StringName GetAvoidanceMask = "get_avoidance_mask";
        /// <summary>
        /// Cached name for the 'set_avoidance_layer_value' method.
        /// </summary>
        public static readonly StringName SetAvoidanceLayerValue = "set_avoidance_layer_value";
        /// <summary>
        /// Cached name for the 'get_avoidance_layer_value' method.
        /// </summary>
        public static readonly StringName GetAvoidanceLayerValue = "get_avoidance_layer_value";
        /// <summary>
        /// Cached name for the 'set_avoidance_mask_value' method.
        /// </summary>
        public static readonly StringName SetAvoidanceMaskValue = "set_avoidance_mask_value";
        /// <summary>
        /// Cached name for the 'get_avoidance_mask_value' method.
        /// </summary>
        public static readonly StringName GetAvoidanceMaskValue = "get_avoidance_mask_value";
        /// <summary>
        /// Cached name for the 'set_avoidance_priority' method.
        /// </summary>
        public static readonly StringName SetAvoidancePriority = "set_avoidance_priority";
        /// <summary>
        /// Cached name for the 'get_avoidance_priority' method.
        /// </summary>
        public static readonly StringName GetAvoidancePriority = "get_avoidance_priority";
        /// <summary>
        /// Cached name for the 'set_debug_enabled' method.
        /// </summary>
        public static readonly StringName SetDebugEnabled = "set_debug_enabled";
        /// <summary>
        /// Cached name for the 'get_debug_enabled' method.
        /// </summary>
        public static readonly StringName GetDebugEnabled = "get_debug_enabled";
        /// <summary>
        /// Cached name for the 'set_debug_use_custom' method.
        /// </summary>
        public static readonly StringName SetDebugUseCustom = "set_debug_use_custom";
        /// <summary>
        /// Cached name for the 'get_debug_use_custom' method.
        /// </summary>
        public static readonly StringName GetDebugUseCustom = "get_debug_use_custom";
        /// <summary>
        /// Cached name for the 'set_debug_path_custom_color' method.
        /// </summary>
        public static readonly StringName SetDebugPathCustomColor = "set_debug_path_custom_color";
        /// <summary>
        /// Cached name for the 'get_debug_path_custom_color' method.
        /// </summary>
        public static readonly StringName GetDebugPathCustomColor = "get_debug_path_custom_color";
        /// <summary>
        /// Cached name for the 'set_debug_path_custom_point_size' method.
        /// </summary>
        public static readonly StringName SetDebugPathCustomPointSize = "set_debug_path_custom_point_size";
        /// <summary>
        /// Cached name for the 'get_debug_path_custom_point_size' method.
        /// </summary>
        public static readonly StringName GetDebugPathCustomPointSize = "get_debug_path_custom_point_size";
        /// <summary>
        /// Cached name for the 'set_debug_path_custom_line_width' method.
        /// </summary>
        public static readonly StringName SetDebugPathCustomLineWidth = "set_debug_path_custom_line_width";
        /// <summary>
        /// Cached name for the 'get_debug_path_custom_line_width' method.
        /// </summary>
        public static readonly StringName GetDebugPathCustomLineWidth = "get_debug_path_custom_line_width";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Node.SignalName
    {
        /// <summary>
        /// Cached name for the 'path_changed' signal.
        /// </summary>
        public static readonly StringName PathChanged = "path_changed";
        /// <summary>
        /// Cached name for the 'target_reached' signal.
        /// </summary>
        public static readonly StringName TargetReached = "target_reached";
        /// <summary>
        /// Cached name for the 'waypoint_reached' signal.
        /// </summary>
        public static readonly StringName WaypointReached = "waypoint_reached";
        /// <summary>
        /// Cached name for the 'link_reached' signal.
        /// </summary>
        public static readonly StringName LinkReached = "link_reached";
        /// <summary>
        /// Cached name for the 'navigation_finished' signal.
        /// </summary>
        public static readonly StringName NavigationFinished = "navigation_finished";
        /// <summary>
        /// Cached name for the 'velocity_computed' signal.
        /// </summary>
        public static readonly StringName VelocityComputed = "velocity_computed";
    }
}

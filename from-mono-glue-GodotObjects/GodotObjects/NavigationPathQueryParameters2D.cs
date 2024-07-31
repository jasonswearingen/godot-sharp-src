namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>By changing various properties of this object, such as the start and target position, you can configure path queries to the <see cref="Godot.NavigationServer2D"/>.</para>
/// </summary>
public partial class NavigationPathQueryParameters2D : RefCounted
{
    public enum PathfindingAlgorithmEnum : long
    {
        /// <summary>
        /// <para>The path query uses the default A* pathfinding algorithm.</para>
        /// </summary>
        Astar = 0
    }

    public enum PathPostProcessing : long
    {
        /// <summary>
        /// <para>Applies a funnel algorithm to the raw path corridor found by the pathfinding algorithm. This will result in the shortest path possible inside the path corridor. This postprocessing very much depends on the navigation mesh polygon layout and the created corridor. Especially tile- or gridbased layouts can face artificial corners with diagonal movement due to a jagged path corridor imposed by the cell shapes.</para>
        /// </summary>
        Corridorfunnel = 0,
        /// <summary>
        /// <para>Centers every path position in the middle of the traveled navigation mesh polygon edge. This creates better paths for tile- or gridbased layouts that restrict the movement to the cells center.</para>
        /// </summary>
        Edgecentered = 1
    }

    [System.Flags]
    public enum PathMetadataFlags : long
    {
        /// <summary>
        /// <para>Don't include any additional metadata about the returned path.</para>
        /// </summary>
        None = 0,
        /// <summary>
        /// <para>Include the type of navigation primitive (region or link) that each point of the path goes through.</para>
        /// </summary>
        Types = 1,
        /// <summary>
        /// <para>Include the <see cref="Godot.Rid"/>s of the regions and links that each point of the path goes through.</para>
        /// </summary>
        Rids = 2,
        /// <summary>
        /// <para>Include the <c>ObjectID</c>s of the <see cref="Godot.GodotObject"/>s which manage the regions and links each point of the path goes through.</para>
        /// </summary>
        Owners = 4,
        /// <summary>
        /// <para>Include all available metadata about the returned path.</para>
        /// </summary>
        All = 7
    }

    /// <summary>
    /// <para>The navigation map <see cref="Godot.Rid"/> used in the path query.</para>
    /// </summary>
    public Rid Map
    {
        get
        {
            return GetMap();
        }
        set
        {
            SetMap(value);
        }
    }

    /// <summary>
    /// <para>The pathfinding start position in global coordinates.</para>
    /// </summary>
    public Vector2 StartPosition
    {
        get
        {
            return GetStartPosition();
        }
        set
        {
            SetStartPosition(value);
        }
    }

    /// <summary>
    /// <para>The pathfinding target position in global coordinates.</para>
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
    /// <para>The navigation layers the query will use (as a bitmask).</para>
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
    /// <para>The path postprocessing applied to the raw path corridor found by the <see cref="Godot.NavigationPathQueryParameters2D.PathfindingAlgorithm"/>.</para>
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
    /// <para>Additional information to include with the navigation path.</para>
    /// </summary>
    public NavigationPathQueryParameters2D.PathMetadataFlags MetadataFlags
    {
        get
        {
            return GetMetadataFlags();
        }
        set
        {
            SetMetadataFlags(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/> a simplified version of the path will be returned with less critical path points removed. The simplification amount is controlled by <see cref="Godot.NavigationPathQueryParameters2D.SimplifyEpsilon"/>. The simplification uses a variant of Ramer-Douglas-Peucker algorithm for curve point decimation.</para>
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

    private static readonly System.Type CachedType = typeof(NavigationPathQueryParameters2D);

    private static readonly StringName NativeName = "NavigationPathQueryParameters2D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public NavigationPathQueryParameters2D() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal NavigationPathQueryParameters2D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPathfindingAlgorithm, 2783519915ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPathfindingAlgorithm(NavigationPathQueryParameters2D.PathfindingAlgorithmEnum pathfindingAlgorithm)
    {
        NativeCalls.godot_icall_1_36(MethodBind0, GodotObject.GetPtr(this), (int)pathfindingAlgorithm);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPathfindingAlgorithm, 3000421146ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NavigationPathQueryParameters2D.PathfindingAlgorithmEnum GetPathfindingAlgorithm()
    {
        return (NavigationPathQueryParameters2D.PathfindingAlgorithmEnum)NativeCalls.godot_icall_0_37(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPathPostprocessing, 2864409082ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPathPostprocessing(NavigationPathQueryParameters2D.PathPostProcessing pathPostprocessing)
    {
        NativeCalls.godot_icall_1_36(MethodBind2, GodotObject.GetPtr(this), (int)pathPostprocessing);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPathPostprocessing, 3798118993ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NavigationPathQueryParameters2D.PathPostProcessing GetPathPostprocessing()
    {
        return (NavigationPathQueryParameters2D.PathPostProcessing)NativeCalls.godot_icall_0_37(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMap, 2722037293ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMap(Rid map)
    {
        NativeCalls.godot_icall_1_255(MethodBind4, GodotObject.GetPtr(this), map);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMap, 2944877500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Rid GetMap()
    {
        return NativeCalls.godot_icall_0_217(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetStartPosition, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetStartPosition(Vector2 startPosition)
    {
        NativeCalls.godot_icall_1_34(MethodBind6, GodotObject.GetPtr(this), &startPosition);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetStartPosition, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetStartPosition()
    {
        return NativeCalls.godot_icall_0_35(MethodBind7, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTargetPosition, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetTargetPosition(Vector2 targetPosition)
    {
        NativeCalls.godot_icall_1_34(MethodBind8, GodotObject.GetPtr(this), &targetPosition);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTargetPosition, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetTargetPosition()
    {
        return NativeCalls.godot_icall_0_35(MethodBind9, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNavigationLayers, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNavigationLayers(uint navigationLayers)
    {
        NativeCalls.godot_icall_1_192(MethodBind10, GodotObject.GetPtr(this), navigationLayers);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNavigationLayers, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetNavigationLayers()
    {
        return NativeCalls.godot_icall_0_193(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMetadataFlags, 24274129ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMetadataFlags(NavigationPathQueryParameters2D.PathMetadataFlags flags)
    {
        NativeCalls.godot_icall_1_36(MethodBind12, GodotObject.GetPtr(this), (int)flags);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMetadataFlags, 488152976ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NavigationPathQueryParameters2D.PathMetadataFlags GetMetadataFlags()
    {
        return (NavigationPathQueryParameters2D.PathMetadataFlags)NativeCalls.godot_icall_0_37(MethodBind13, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSimplifyPath, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSimplifyPath(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind14, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSimplifyPath, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetSimplifyPath()
    {
        return NativeCalls.godot_icall_0_40(MethodBind15, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSimplifyEpsilon, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSimplifyEpsilon(float epsilon)
    {
        NativeCalls.godot_icall_1_62(MethodBind16, GodotObject.GetPtr(this), epsilon);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSimplifyEpsilon, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetSimplifyEpsilon()
    {
        return NativeCalls.godot_icall_0_63(MethodBind17, GodotObject.GetPtr(this));
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
    public new class PropertyName : RefCounted.PropertyName
    {
        /// <summary>
        /// Cached name for the 'map' property.
        /// </summary>
        public static readonly StringName Map = "map";
        /// <summary>
        /// Cached name for the 'start_position' property.
        /// </summary>
        public static readonly StringName StartPosition = "start_position";
        /// <summary>
        /// Cached name for the 'target_position' property.
        /// </summary>
        public static readonly StringName TargetPosition = "target_position";
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
        /// Cached name for the 'metadata_flags' property.
        /// </summary>
        public static readonly StringName MetadataFlags = "metadata_flags";
        /// <summary>
        /// Cached name for the 'simplify_path' property.
        /// </summary>
        public static readonly StringName SimplifyPath = "simplify_path";
        /// <summary>
        /// Cached name for the 'simplify_epsilon' property.
        /// </summary>
        public static readonly StringName SimplifyEpsilon = "simplify_epsilon";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : RefCounted.MethodName
    {
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
        /// Cached name for the 'set_map' method.
        /// </summary>
        public static readonly StringName SetMap = "set_map";
        /// <summary>
        /// Cached name for the 'get_map' method.
        /// </summary>
        public static readonly StringName GetMap = "get_map";
        /// <summary>
        /// Cached name for the 'set_start_position' method.
        /// </summary>
        public static readonly StringName SetStartPosition = "set_start_position";
        /// <summary>
        /// Cached name for the 'get_start_position' method.
        /// </summary>
        public static readonly StringName GetStartPosition = "get_start_position";
        /// <summary>
        /// Cached name for the 'set_target_position' method.
        /// </summary>
        public static readonly StringName SetTargetPosition = "set_target_position";
        /// <summary>
        /// Cached name for the 'get_target_position' method.
        /// </summary>
        public static readonly StringName GetTargetPosition = "get_target_position";
        /// <summary>
        /// Cached name for the 'set_navigation_layers' method.
        /// </summary>
        public static readonly StringName SetNavigationLayers = "set_navigation_layers";
        /// <summary>
        /// Cached name for the 'get_navigation_layers' method.
        /// </summary>
        public static readonly StringName GetNavigationLayers = "get_navigation_layers";
        /// <summary>
        /// Cached name for the 'set_metadata_flags' method.
        /// </summary>
        public static readonly StringName SetMetadataFlags = "set_metadata_flags";
        /// <summary>
        /// Cached name for the 'get_metadata_flags' method.
        /// </summary>
        public static readonly StringName GetMetadataFlags = "get_metadata_flags";
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
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : RefCounted.SignalName
    {
    }
}

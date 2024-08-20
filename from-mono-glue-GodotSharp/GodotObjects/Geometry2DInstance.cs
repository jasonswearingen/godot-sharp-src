namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Provides a set of helper functions to create geometric shapes, compute intersections between shapes, and process various other geometric operations in 2D.</para>
/// </summary>
[GodotClassName("Geometry2D")]
public partial class Geometry2DInstance : GodotObject
{
    private static readonly System.Type CachedType = typeof(Geometry2DInstance);

    private static readonly StringName NativeName = "Geometry2D";

    internal Geometry2DInstance() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal Geometry2DInstance(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsPointInCircle, 2929491703ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if <paramref name="point"/> is inside the circle or if it's located exactly <i>on</i> the circle's boundary, otherwise returns <see langword="false"/>.</para>
    /// </summary>
    public unsafe bool IsPointInCircle(Vector2 point, Vector2 circlePosition, float circleRadius)
    {
        return NativeCalls.godot_icall_3_545(MethodBind0, GodotObject.GetPtr(this), &point, &circlePosition, circleRadius).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SegmentIntersectsCircle, 1356928167ul);

    /// <summary>
    /// <para>Given the 2D segment (<paramref name="segmentFrom"/>, <paramref name="segmentTo"/>), returns the position on the segment (as a number between 0 and 1) at which the segment hits the circle that is located at position <paramref name="circlePosition"/> and has radius <paramref name="circleRadius"/>. If the segment does not intersect the circle, -1 is returned (this is also the case if the line extending the segment would intersect the circle, but the segment does not).</para>
    /// </summary>
    public unsafe float SegmentIntersectsCircle(Vector2 segmentFrom, Vector2 segmentTo, Vector2 circlePosition, float circleRadius)
    {
        return NativeCalls.godot_icall_4_546(MethodBind1, GodotObject.GetPtr(this), &segmentFrom, &segmentTo, &circlePosition, circleRadius);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SegmentIntersectsSegment, 2058025344ul);

    /// <summary>
    /// <para>Checks if the two segments (<paramref name="fromA"/>, <paramref name="toA"/>) and (<paramref name="fromB"/>, <paramref name="toB"/>) intersect. If yes, return the point of intersection as <see cref="Godot.Vector2"/>. If no intersection takes place, returns <see langword="null"/>.</para>
    /// </summary>
    public unsafe Variant SegmentIntersectsSegment(Vector2 fromA, Vector2 toA, Vector2 fromB, Vector2 toB)
    {
        return NativeCalls.godot_icall_4_547(MethodBind2, GodotObject.GetPtr(this), &fromA, &toA, &fromB, &toB);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LineIntersectsLine, 2058025344ul);

    /// <summary>
    /// <para>Checks if the two lines (<paramref name="fromA"/>, <paramref name="dirA"/>) and (<paramref name="fromB"/>, <paramref name="dirB"/>) intersect. If yes, return the point of intersection as <see cref="Godot.Vector2"/>. If no intersection takes place, returns <see langword="null"/>.</para>
    /// <para><b>Note:</b> The lines are specified using direction vectors, not end points.</para>
    /// </summary>
    public unsafe Variant LineIntersectsLine(Vector2 fromA, Vector2 dirA, Vector2 fromB, Vector2 dirB)
    {
        return NativeCalls.godot_icall_4_547(MethodBind3, GodotObject.GetPtr(this), &fromA, &dirA, &fromB, &dirB);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetClosestPointsBetweenSegments, 3344690961ul);

    /// <summary>
    /// <para>Given the two 2D segments (<paramref name="p1"/>, <paramref name="q1"/>) and (<paramref name="p2"/>, <paramref name="q2"/>), finds those two points on the two segments that are closest to each other. Returns a <see cref="Godot.Vector2"/>[] that contains this point on (<paramref name="p1"/>, <paramref name="q1"/>) as well the accompanying point on (<paramref name="p2"/>, <paramref name="q2"/>).</para>
    /// </summary>
    public unsafe Vector2[] GetClosestPointsBetweenSegments(Vector2 p1, Vector2 q1, Vector2 p2, Vector2 q2)
    {
        return NativeCalls.godot_icall_4_548(MethodBind4, GodotObject.GetPtr(this), &p1, &q1, &p2, &q2);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetClosestPointToSegment, 4172901909ul);

    /// <summary>
    /// <para>Returns the 2D point on the 2D segment (<paramref name="s1"/>, <paramref name="s2"/>) that is closest to <paramref name="point"/>. The returned point will always be inside the specified segment.</para>
    /// </summary>
    public unsafe Vector2 GetClosestPointToSegment(Vector2 point, Vector2 s1, Vector2 s2)
    {
        return NativeCalls.godot_icall_3_549(MethodBind5, GodotObject.GetPtr(this), &point, &s1, &s2);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetClosestPointToSegmentUncapped, 4172901909ul);

    /// <summary>
    /// <para>Returns the 2D point on the 2D line defined by (<paramref name="s1"/>, <paramref name="s2"/>) that is closest to <paramref name="point"/>. The returned point can be inside the segment (<paramref name="s1"/>, <paramref name="s2"/>) or outside of it, i.e. somewhere on the line extending from the segment.</para>
    /// </summary>
    public unsafe Vector2 GetClosestPointToSegmentUncapped(Vector2 point, Vector2 s1, Vector2 s2)
    {
        return NativeCalls.godot_icall_3_549(MethodBind6, GodotObject.GetPtr(this), &point, &s1, &s2);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.PointIsInsideTriangle, 1025948137ul);

    /// <summary>
    /// <para>Returns if <paramref name="point"/> is inside the triangle specified by <paramref name="a"/>, <paramref name="b"/> and <paramref name="c"/>.</para>
    /// </summary>
    public unsafe bool PointIsInsideTriangle(Vector2 point, Vector2 a, Vector2 b, Vector2 c)
    {
        return NativeCalls.godot_icall_4_550(MethodBind7, GodotObject.GetPtr(this), &point, &a, &b, &c).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsPolygonClockwise, 1361156557ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if <paramref name="polygon"/>'s vertices are ordered in clockwise order, otherwise returns <see langword="false"/>.</para>
    /// <para><b>Note:</b> Assumes a Cartesian coordinate system where <c>+x</c> is right and <c>+y</c> is up. If using screen coordinates (<c>+y</c> is down), the result will need to be flipped (i.e. a <see langword="true"/> result will indicate counter-clockwise).</para>
    /// </summary>
    public bool IsPolygonClockwise(Vector2[] polygon)
    {
        return NativeCalls.godot_icall_1_185(MethodBind8, GodotObject.GetPtr(this), polygon).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsPointInPolygon, 738277916ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if <paramref name="point"/> is inside <paramref name="polygon"/> or if it's located exactly <i>on</i> polygon's boundary, otherwise returns <see langword="false"/>.</para>
    /// </summary>
    public unsafe bool IsPointInPolygon(Vector2 point, Vector2[] polygon)
    {
        return NativeCalls.godot_icall_2_551(MethodBind9, GodotObject.GetPtr(this), &point, polygon).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TriangulatePolygon, 1389921771ul);

    /// <summary>
    /// <para>Triangulates the polygon specified by the points in <paramref name="polygon"/>. Returns a <see cref="int"/>[] where each triangle consists of three consecutive point indices into <paramref name="polygon"/> (i.e. the returned array will have <c>n * 3</c> elements, with <c>n</c> being the number of found triangles). Output triangles will always be counter clockwise, and the contour will be flipped if it's clockwise. If the triangulation did not succeed, an empty <see cref="int"/>[] is returned.</para>
    /// </summary>
    public int[] TriangulatePolygon(Vector2[] polygon)
    {
        return NativeCalls.godot_icall_1_552(MethodBind10, GodotObject.GetPtr(this), polygon);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TriangulateDelaunay, 1389921771ul);

    /// <summary>
    /// <para>Triangulates the area specified by discrete set of <paramref name="points"/> such that no point is inside the circumcircle of any resulting triangle. Returns a <see cref="int"/>[] where each triangle consists of three consecutive point indices into <paramref name="points"/> (i.e. the returned array will have <c>n * 3</c> elements, with <c>n</c> being the number of found triangles). If the triangulation did not succeed, an empty <see cref="int"/>[] is returned.</para>
    /// </summary>
    public int[] TriangulateDelaunay(Vector2[] points)
    {
        return NativeCalls.godot_icall_1_552(MethodBind11, GodotObject.GetPtr(this), points);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ConvexHull, 2004331998ul);

    /// <summary>
    /// <para>Given an array of <see cref="Godot.Vector2"/>s, returns the convex hull as a list of points in counterclockwise order. The last point is the same as the first one.</para>
    /// </summary>
    public Vector2[] ConvexHull(Vector2[] points)
    {
        return NativeCalls.godot_icall_1_553(MethodBind12, GodotObject.GetPtr(this), points);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DecomposePolygonInConvex, 3982393695ul);

    /// <summary>
    /// <para>Decomposes the <paramref name="polygon"/> into multiple convex hulls and returns an array of <see cref="Godot.Vector2"/>[].</para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> DecomposePolygonInConvex(Vector2[] polygon)
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_1_554(MethodBind13, GodotObject.GetPtr(this), polygon));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.MergePolygons, 3637387053ul);

    /// <summary>
    /// <para>Merges (combines) <paramref name="polygonA"/> and <paramref name="polygonB"/> and returns an array of merged polygons. This performs <see cref="Godot.Geometry2D.PolyBooleanOperation.Union"/> between polygons.</para>
    /// <para>The operation may result in an outer polygon (boundary) and multiple inner polygons (holes) produced which could be distinguished by calling <see cref="Godot.Geometry2DInstance.IsPolygonClockwise(Vector2[])"/>.</para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> MergePolygons(Vector2[] polygonA, Vector2[] polygonB)
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_2_555(MethodBind14, GodotObject.GetPtr(this), polygonA, polygonB));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipPolygons, 3637387053ul);

    /// <summary>
    /// <para>Clips <paramref name="polygonA"/> against <paramref name="polygonB"/> and returns an array of clipped polygons. This performs <see cref="Godot.Geometry2D.PolyBooleanOperation.Difference"/> between polygons. Returns an empty array if <paramref name="polygonB"/> completely overlaps <paramref name="polygonA"/>.</para>
    /// <para>If <paramref name="polygonB"/> is enclosed by <paramref name="polygonA"/>, returns an outer polygon (boundary) and inner polygon (hole) which could be distinguished by calling <see cref="Godot.Geometry2DInstance.IsPolygonClockwise(Vector2[])"/>.</para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> ClipPolygons(Vector2[] polygonA, Vector2[] polygonB)
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_2_555(MethodBind15, GodotObject.GetPtr(this), polygonA, polygonB));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IntersectPolygons, 3637387053ul);

    /// <summary>
    /// <para>Intersects <paramref name="polygonA"/> with <paramref name="polygonB"/> and returns an array of intersected polygons. This performs <see cref="Godot.Geometry2D.PolyBooleanOperation.Intersection"/> between polygons. In other words, returns common area shared by polygons. Returns an empty array if no intersection occurs.</para>
    /// <para>The operation may result in an outer polygon (boundary) and inner polygon (hole) produced which could be distinguished by calling <see cref="Godot.Geometry2DInstance.IsPolygonClockwise(Vector2[])"/>.</para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> IntersectPolygons(Vector2[] polygonA, Vector2[] polygonB)
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_2_555(MethodBind16, GodotObject.GetPtr(this), polygonA, polygonB));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ExcludePolygons, 3637387053ul);

    /// <summary>
    /// <para>Mutually excludes common area defined by intersection of <paramref name="polygonA"/> and <paramref name="polygonB"/> (see <see cref="Godot.Geometry2DInstance.IntersectPolygons(Vector2[], Vector2[])"/>) and returns an array of excluded polygons. This performs <see cref="Godot.Geometry2D.PolyBooleanOperation.Xor"/> between polygons. In other words, returns all but common area between polygons.</para>
    /// <para>The operation may result in an outer polygon (boundary) and inner polygon (hole) produced which could be distinguished by calling <see cref="Godot.Geometry2DInstance.IsPolygonClockwise(Vector2[])"/>.</para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> ExcludePolygons(Vector2[] polygonA, Vector2[] polygonB)
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_2_555(MethodBind17, GodotObject.GetPtr(this), polygonA, polygonB));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipPolylineWithPolygon, 3637387053ul);

    /// <summary>
    /// <para>Clips <paramref name="polyline"/> against <paramref name="polygon"/> and returns an array of clipped polylines. This performs <see cref="Godot.Geometry2D.PolyBooleanOperation.Difference"/> between the polyline and the polygon. This operation can be thought of as cutting a line with a closed shape.</para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> ClipPolylineWithPolygon(Vector2[] polyline, Vector2[] polygon)
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_2_555(MethodBind18, GodotObject.GetPtr(this), polyline, polygon));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IntersectPolylineWithPolygon, 3637387053ul);

    /// <summary>
    /// <para>Intersects <paramref name="polyline"/> with <paramref name="polygon"/> and returns an array of intersected polylines. This performs <see cref="Godot.Geometry2D.PolyBooleanOperation.Intersection"/> between the polyline and the polygon. This operation can be thought of as chopping a line with a closed shape.</para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> IntersectPolylineWithPolygon(Vector2[] polyline, Vector2[] polygon)
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_2_555(MethodBind19, GodotObject.GetPtr(this), polyline, polygon));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.OffsetPolygon, 1275354010ul);

    /// <summary>
    /// <para>Inflates or deflates <paramref name="polygon"/> by <paramref name="delta"/> units (pixels). If <paramref name="delta"/> is positive, makes the polygon grow outward. If <paramref name="delta"/> is negative, shrinks the polygon inward. Returns an array of polygons because inflating/deflating may result in multiple discrete polygons. Returns an empty array if <paramref name="delta"/> is negative and the absolute value of it approximately exceeds the minimum bounding rectangle dimensions of the polygon.</para>
    /// <para>Each polygon's vertices will be rounded as determined by <paramref name="joinType"/>, see <see cref="Godot.Geometry2D.PolyJoinType"/>.</para>
    /// <para>The operation may result in an outer polygon (boundary) and inner polygon (hole) produced which could be distinguished by calling <see cref="Godot.Geometry2DInstance.IsPolygonClockwise(Vector2[])"/>.</para>
    /// <para><b>Note:</b> To translate the polygon's vertices specifically, multiply them to a <see cref="Godot.Transform2D"/>:</para>
    /// <para><code>
    /// var polygon = new Vector2[] { new Vector2(0, 0), new Vector2(100, 0), new Vector2(100, 100), new Vector2(0, 100) };
    /// var offset = new Vector2(50, 50);
    /// polygon = new Transform2D(0, offset) * polygon;
    /// GD.Print((Variant)polygon); // prints [(50, 50), (150, 50), (150, 150), (50, 150)]
    /// </code></para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> OffsetPolygon(Vector2[] polygon, float delta, Geometry2D.PolyJoinType joinType = (Geometry2D.PolyJoinType)(0))
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_3_556(MethodBind20, GodotObject.GetPtr(this), polygon, delta, (int)joinType));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.OffsetPolyline, 2328231778ul);

    /// <summary>
    /// <para>Inflates or deflates <paramref name="polyline"/> by <paramref name="delta"/> units (pixels), producing polygons. If <paramref name="delta"/> is positive, makes the polyline grow outward. Returns an array of polygons because inflating/deflating may result in multiple discrete polygons. If <paramref name="delta"/> is negative, returns an empty array.</para>
    /// <para>Each polygon's vertices will be rounded as determined by <paramref name="joinType"/>, see <see cref="Godot.Geometry2D.PolyJoinType"/>.</para>
    /// <para>Each polygon's endpoints will be rounded as determined by <paramref name="endType"/>, see <see cref="Godot.Geometry2D.PolyEndType"/>.</para>
    /// <para>The operation may result in an outer polygon (boundary) and inner polygon (hole) produced which could be distinguished by calling <see cref="Godot.Geometry2DInstance.IsPolygonClockwise(Vector2[])"/>.</para>
    /// </summary>
    public Godot.Collections.Array<Vector2[]> OffsetPolyline(Vector2[] polyline, float delta, Geometry2D.PolyJoinType joinType = (Geometry2D.PolyJoinType)(0), Geometry2D.PolyEndType endType = (Geometry2D.PolyEndType)(3))
    {
        return new Godot.Collections.Array<Vector2[]>(NativeCalls.godot_icall_4_557(MethodBind21, GodotObject.GetPtr(this), polyline, delta, (int)joinType, (int)endType));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.MakeAtlas, 1337682371ul);

    /// <summary>
    /// <para>Given an array of <see cref="Godot.Vector2"/>s representing tiles, builds an atlas. The returned dictionary has two keys: <c>points</c> is a <see cref="Godot.Vector2"/>[] that specifies the positions of each tile, <c>size</c> contains the overall size of the whole atlas as <see cref="Godot.Vector2I"/>.</para>
    /// </summary>
    public Godot.Collections.Dictionary MakeAtlas(Vector2[] sizes)
    {
        return NativeCalls.godot_icall_1_558(MethodBind22, GodotObject.GetPtr(this), sizes);
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
        /// Cached name for the 'is_point_in_circle' method.
        /// </summary>
        public static readonly StringName IsPointInCircle = "is_point_in_circle";
        /// <summary>
        /// Cached name for the 'segment_intersects_circle' method.
        /// </summary>
        public static readonly StringName SegmentIntersectsCircle = "segment_intersects_circle";
        /// <summary>
        /// Cached name for the 'segment_intersects_segment' method.
        /// </summary>
        public static readonly StringName SegmentIntersectsSegment = "segment_intersects_segment";
        /// <summary>
        /// Cached name for the 'line_intersects_line' method.
        /// </summary>
        public static readonly StringName LineIntersectsLine = "line_intersects_line";
        /// <summary>
        /// Cached name for the 'get_closest_points_between_segments' method.
        /// </summary>
        public static readonly StringName GetClosestPointsBetweenSegments = "get_closest_points_between_segments";
        /// <summary>
        /// Cached name for the 'get_closest_point_to_segment' method.
        /// </summary>
        public static readonly StringName GetClosestPointToSegment = "get_closest_point_to_segment";
        /// <summary>
        /// Cached name for the 'get_closest_point_to_segment_uncapped' method.
        /// </summary>
        public static readonly StringName GetClosestPointToSegmentUncapped = "get_closest_point_to_segment_uncapped";
        /// <summary>
        /// Cached name for the 'point_is_inside_triangle' method.
        /// </summary>
        public static readonly StringName PointIsInsideTriangle = "point_is_inside_triangle";
        /// <summary>
        /// Cached name for the 'is_polygon_clockwise' method.
        /// </summary>
        public static readonly StringName IsPolygonClockwise = "is_polygon_clockwise";
        /// <summary>
        /// Cached name for the 'is_point_in_polygon' method.
        /// </summary>
        public static readonly StringName IsPointInPolygon = "is_point_in_polygon";
        /// <summary>
        /// Cached name for the 'triangulate_polygon' method.
        /// </summary>
        public static readonly StringName TriangulatePolygon = "triangulate_polygon";
        /// <summary>
        /// Cached name for the 'triangulate_delaunay' method.
        /// </summary>
        public static readonly StringName TriangulateDelaunay = "triangulate_delaunay";
        /// <summary>
        /// Cached name for the 'convex_hull' method.
        /// </summary>
        public static readonly StringName ConvexHull = "convex_hull";
        /// <summary>
        /// Cached name for the 'decompose_polygon_in_convex' method.
        /// </summary>
        public static readonly StringName DecomposePolygonInConvex = "decompose_polygon_in_convex";
        /// <summary>
        /// Cached name for the 'merge_polygons' method.
        /// </summary>
        public static readonly StringName MergePolygons = "merge_polygons";
        /// <summary>
        /// Cached name for the 'clip_polygons' method.
        /// </summary>
        public static readonly StringName ClipPolygons = "clip_polygons";
        /// <summary>
        /// Cached name for the 'intersect_polygons' method.
        /// </summary>
        public static readonly StringName IntersectPolygons = "intersect_polygons";
        /// <summary>
        /// Cached name for the 'exclude_polygons' method.
        /// </summary>
        public static readonly StringName ExcludePolygons = "exclude_polygons";
        /// <summary>
        /// Cached name for the 'clip_polyline_with_polygon' method.
        /// </summary>
        public static readonly StringName ClipPolylineWithPolygon = "clip_polyline_with_polygon";
        /// <summary>
        /// Cached name for the 'intersect_polyline_with_polygon' method.
        /// </summary>
        public static readonly StringName IntersectPolylineWithPolygon = "intersect_polyline_with_polygon";
        /// <summary>
        /// Cached name for the 'offset_polygon' method.
        /// </summary>
        public static readonly StringName OffsetPolygon = "offset_polygon";
        /// <summary>
        /// Cached name for the 'offset_polyline' method.
        /// </summary>
        public static readonly StringName OffsetPolyline = "offset_polyline";
        /// <summary>
        /// Cached name for the 'make_atlas' method.
        /// </summary>
        public static readonly StringName MakeAtlas = "make_atlas";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
    }
}

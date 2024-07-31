namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>The <see cref="Godot.CameraServer"/> keeps track of different cameras accessible in Godot. These are external cameras such as webcams or the cameras on your phone.</para>
/// <para>It is notably used to provide AR modules with a video feed from the camera.</para>
/// <para><b>Note:</b> This class is currently only implemented on macOS and iOS. To get a <see cref="Godot.CameraFeed"/> on iOS, the camera plugin from <a href="https://github.com/godotengine/godot-ios-plugins">godot-ios-plugins</a> is required. On other platforms, no <see cref="Godot.CameraFeed"/>s will be available.</para>
/// </summary>
[GodotClassName("CameraServer")]
public partial class CameraServerInstance : GodotObject
{
    private static readonly System.Type CachedType = typeof(CameraServerInstance);

    private static readonly StringName NativeName = "CameraServer";

    internal CameraServerInstance() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal CameraServerInstance(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFeed, 361927068ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.CameraFeed"/> corresponding to the camera with the given <paramref name="index"/>.</para>
    /// </summary>
    public CameraFeed GetFeed(int index)
    {
        return (CameraFeed)NativeCalls.godot_icall_1_66(MethodBind0, GodotObject.GetPtr(this), index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFeedCount, 2455072627ul);

    /// <summary>
    /// <para>Returns the number of <see cref="Godot.CameraFeed"/>s registered.</para>
    /// </summary>
    public int GetFeedCount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Feeds, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of <see cref="Godot.CameraFeed"/>s.</para>
    /// </summary>
    public Godot.Collections.Array<CameraFeed> Feeds()
    {
        return new Godot.Collections.Array<CameraFeed>(NativeCalls.godot_icall_0_112(MethodBind2, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddFeed, 3204782488ul);

    /// <summary>
    /// <para>Adds the camera <paramref name="feed"/> to the camera server.</para>
    /// </summary>
    public void AddFeed(CameraFeed feed)
    {
        NativeCalls.godot_icall_1_55(MethodBind3, GodotObject.GetPtr(this), GodotObject.GetPtr(feed));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RemoveFeed, 3204782488ul);

    /// <summary>
    /// <para>Removes the specified camera <paramref name="feed"/>.</para>
    /// </summary>
    public void RemoveFeed(CameraFeed feed)
    {
        NativeCalls.godot_icall_1_55(MethodBind4, GodotObject.GetPtr(this), GodotObject.GetPtr(feed));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.CameraServerInstance.CameraFeedAdded"/> event of a <see cref="Godot.CameraServerInstance"/> class.
    /// </summary>
    public delegate void CameraFeedAddedEventHandler(long id);

    private static void CameraFeedAddedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((CameraFeedAddedEventHandler)delegateObj)(VariantUtils.ConvertTo<long>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when a <see cref="Godot.CameraFeed"/> is added (e.g. a webcam is plugged in).</para>
    /// </summary>
    public unsafe event CameraFeedAddedEventHandler CameraFeedAdded
    {
        add => Connect(SignalName.CameraFeedAdded, Callable.CreateWithUnsafeTrampoline(value, &CameraFeedAddedTrampoline));
        remove => Disconnect(SignalName.CameraFeedAdded, Callable.CreateWithUnsafeTrampoline(value, &CameraFeedAddedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.CameraServerInstance.CameraFeedRemoved"/> event of a <see cref="Godot.CameraServerInstance"/> class.
    /// </summary>
    public delegate void CameraFeedRemovedEventHandler(long id);

    private static void CameraFeedRemovedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((CameraFeedRemovedEventHandler)delegateObj)(VariantUtils.ConvertTo<long>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when a <see cref="Godot.CameraFeed"/> is removed (e.g. a webcam is unplugged).</para>
    /// </summary>
    public unsafe event CameraFeedRemovedEventHandler CameraFeedRemoved
    {
        add => Connect(SignalName.CameraFeedRemoved, Callable.CreateWithUnsafeTrampoline(value, &CameraFeedRemovedTrampoline));
        remove => Disconnect(SignalName.CameraFeedRemoved, Callable.CreateWithUnsafeTrampoline(value, &CameraFeedRemovedTrampoline));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_camera_feed_added = "CameraFeedAdded";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_camera_feed_removed = "CameraFeedRemoved";

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
        if (signal == SignalName.CameraFeedAdded)
        {
            if (HasGodotClassSignal(SignalProxyName_camera_feed_added.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.CameraFeedRemoved)
        {
            if (HasGodotClassSignal(SignalProxyName_camera_feed_removed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
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
        /// Cached name for the 'get_feed' method.
        /// </summary>
        public static readonly StringName GetFeed = "get_feed";
        /// <summary>
        /// Cached name for the 'get_feed_count' method.
        /// </summary>
        public static readonly StringName GetFeedCount = "get_feed_count";
        /// <summary>
        /// Cached name for the 'feeds' method.
        /// </summary>
        public static readonly StringName Feeds = "feeds";
        /// <summary>
        /// Cached name for the 'add_feed' method.
        /// </summary>
        public static readonly StringName AddFeed = "add_feed";
        /// <summary>
        /// Cached name for the 'remove_feed' method.
        /// </summary>
        public static readonly StringName RemoveFeed = "remove_feed";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
        /// <summary>
        /// Cached name for the 'camera_feed_added' signal.
        /// </summary>
        public static readonly StringName CameraFeedAdded = "camera_feed_added";
        /// <summary>
        /// Cached name for the 'camera_feed_removed' signal.
        /// </summary>
        public static readonly StringName CameraFeedRemoved = "camera_feed_removed";
    }
}

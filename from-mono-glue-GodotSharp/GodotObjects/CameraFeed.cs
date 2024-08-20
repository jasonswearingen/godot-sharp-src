namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>A camera feed gives you access to a single physical camera attached to your device. When enabled, Godot will start capturing frames from the camera which can then be used. See also <see cref="Godot.CameraServer"/>.</para>
/// <para><b>Note:</b> Many cameras will return YCbCr images which are split into two textures and need to be combined in a shader. Godot does this automatically for you if you set the environment to show the camera image in the background.</para>
/// </summary>
public partial class CameraFeed : RefCounted
{
    public enum FeedDataType : long
    {
        /// <summary>
        /// <para>No image set for the feed.</para>
        /// </summary>
        Noimage = 0,
        /// <summary>
        /// <para>Feed supplies RGB images.</para>
        /// </summary>
        Rgb = 1,
        /// <summary>
        /// <para>Feed supplies YCbCr images that need to be converted to RGB.</para>
        /// </summary>
        Ycbcr = 2,
        /// <summary>
        /// <para>Feed supplies separate Y and CbCr images that need to be combined and converted to RGB.</para>
        /// </summary>
        YcbcrSep = 3
    }

    public enum FeedPosition : long
    {
        /// <summary>
        /// <para>Unspecified position.</para>
        /// </summary>
        Unspecified = 0,
        /// <summary>
        /// <para>Camera is mounted at the front of the device.</para>
        /// </summary>
        Front = 1,
        /// <summary>
        /// <para>Camera is mounted at the back of the device.</para>
        /// </summary>
        Back = 2
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the feed is active.</para>
    /// </summary>
    public bool FeedIsActive
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
    /// <para>The transform applied to the camera's image.</para>
    /// </summary>
    public Transform2D FeedTransform
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

    private static readonly System.Type CachedType = typeof(CameraFeed);

    private static readonly StringName NativeName = "CameraFeed";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public CameraFeed() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal CameraFeed(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetId, 3905245786ul);

    /// <summary>
    /// <para>Returns the unique ID for this feed.</para>
    /// </summary>
    public int GetId()
    {
        return NativeCalls.godot_icall_0_37(MethodBind0, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsActive, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsActive()
    {
        return NativeCalls.godot_icall_0_40(MethodBind1, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetActive, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetActive(bool active)
    {
        NativeCalls.godot_icall_1_41(MethodBind2, GodotObject.GetPtr(this), active.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetName, 201670096ul);

    /// <summary>
    /// <para>Returns the camera's name.</para>
    /// </summary>
    public string GetName()
    {
        return NativeCalls.godot_icall_0_57(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPosition, 2711679033ul);

    /// <summary>
    /// <para>Returns the position of camera on the device.</para>
    /// </summary>
    public CameraFeed.FeedPosition GetPosition()
    {
        return (CameraFeed.FeedPosition)NativeCalls.godot_icall_0_37(MethodBind4, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTransform, 3814499831ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Transform2D GetTransform()
    {
        return NativeCalls.godot_icall_0_201(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTransform, 2761652528ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetTransform(Transform2D transform)
    {
        NativeCalls.godot_icall_1_200(MethodBind6, GodotObject.GetPtr(this), &transform);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDatatype, 1477782850ul);

    /// <summary>
    /// <para>Returns feed image data type.</para>
    /// </summary>
    public CameraFeed.FeedDataType GetDatatype()
    {
        return (CameraFeed.FeedDataType)NativeCalls.godot_icall_0_37(MethodBind7, GodotObject.GetPtr(this));
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
        /// Cached name for the 'feed_is_active' property.
        /// </summary>
        public static readonly StringName FeedIsActive = "feed_is_active";
        /// <summary>
        /// Cached name for the 'feed_transform' property.
        /// </summary>
        public static readonly StringName FeedTransform = "feed_transform";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : RefCounted.MethodName
    {
        /// <summary>
        /// Cached name for the 'get_id' method.
        /// </summary>
        public static readonly StringName GetId = "get_id";
        /// <summary>
        /// Cached name for the 'is_active' method.
        /// </summary>
        public static readonly StringName IsActive = "is_active";
        /// <summary>
        /// Cached name for the 'set_active' method.
        /// </summary>
        public static readonly StringName SetActive = "set_active";
        /// <summary>
        /// Cached name for the 'get_name' method.
        /// </summary>
        public static readonly StringName GetName = "get_name";
        /// <summary>
        /// Cached name for the 'get_position' method.
        /// </summary>
        public static readonly StringName GetPosition = "get_position";
        /// <summary>
        /// Cached name for the 'get_transform' method.
        /// </summary>
        public static readonly StringName GetTransform = "get_transform";
        /// <summary>
        /// Cached name for the 'set_transform' method.
        /// </summary>
        public static readonly StringName SetTransform = "set_transform";
        /// <summary>
        /// Cached name for the 'get_datatype' method.
        /// </summary>
        public static readonly StringName GetDatatype = "get_datatype";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : RefCounted.SignalName
    {
    }
}

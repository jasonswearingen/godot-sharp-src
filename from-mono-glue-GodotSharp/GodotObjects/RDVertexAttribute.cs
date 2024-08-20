namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>This object is used by <see cref="Godot.RenderingDevice"/>.</para>
/// </summary>
public partial class RDVertexAttribute : RefCounted
{
    public uint Location
    {
        get
        {
            return GetLocation();
        }
        set
        {
            SetLocation(value);
        }
    }

    public uint Offset
    {
        get
        {
            return GetOffset();
        }
        set
        {
            SetOffset(value);
        }
    }

    public RenderingDevice.DataFormat Format
    {
        get
        {
            return GetFormat();
        }
        set
        {
            SetFormat(value);
        }
    }

    public uint Stride
    {
        get
        {
            return GetStride();
        }
        set
        {
            SetStride(value);
        }
    }

    public RenderingDevice.VertexFrequency Frequency
    {
        get
        {
            return GetFrequency();
        }
        set
        {
            SetFrequency(value);
        }
    }

    private static readonly System.Type CachedType = typeof(RDVertexAttribute);

    private static readonly StringName NativeName = "RDVertexAttribute";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public RDVertexAttribute() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal RDVertexAttribute(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLocation, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetLocation(uint pMember)
    {
        NativeCalls.godot_icall_1_192(MethodBind0, GodotObject.GetPtr(this), pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLocation, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetLocation()
    {
        return NativeCalls.godot_icall_0_193(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOffset, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetOffset(uint pMember)
    {
        NativeCalls.godot_icall_1_192(MethodBind2, GodotObject.GetPtr(this), pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOffset, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetOffset()
    {
        return NativeCalls.godot_icall_0_193(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFormat, 565531219ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFormat(RenderingDevice.DataFormat pMember)
    {
        NativeCalls.godot_icall_1_36(MethodBind4, GodotObject.GetPtr(this), (int)pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFormat, 2235804183ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public RenderingDevice.DataFormat GetFormat()
    {
        return (RenderingDevice.DataFormat)NativeCalls.godot_icall_0_37(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetStride, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetStride(uint pMember)
    {
        NativeCalls.godot_icall_1_192(MethodBind6, GodotObject.GetPtr(this), pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetStride, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetStride()
    {
        return NativeCalls.godot_icall_0_193(MethodBind7, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFrequency, 522141836ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFrequency(RenderingDevice.VertexFrequency pMember)
    {
        NativeCalls.godot_icall_1_36(MethodBind8, GodotObject.GetPtr(this), (int)pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFrequency, 4154106413ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public RenderingDevice.VertexFrequency GetFrequency()
    {
        return (RenderingDevice.VertexFrequency)NativeCalls.godot_icall_0_37(MethodBind9, GodotObject.GetPtr(this));
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
        /// Cached name for the 'location' property.
        /// </summary>
        public static readonly StringName Location = "location";
        /// <summary>
        /// Cached name for the 'offset' property.
        /// </summary>
        public static readonly StringName Offset = "offset";
        /// <summary>
        /// Cached name for the 'format' property.
        /// </summary>
        public static readonly StringName Format = "format";
        /// <summary>
        /// Cached name for the 'stride' property.
        /// </summary>
        public static readonly StringName Stride = "stride";
        /// <summary>
        /// Cached name for the 'frequency' property.
        /// </summary>
        public static readonly StringName Frequency = "frequency";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : RefCounted.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_location' method.
        /// </summary>
        public static readonly StringName SetLocation = "set_location";
        /// <summary>
        /// Cached name for the 'get_location' method.
        /// </summary>
        public static readonly StringName GetLocation = "get_location";
        /// <summary>
        /// Cached name for the 'set_offset' method.
        /// </summary>
        public static readonly StringName SetOffset = "set_offset";
        /// <summary>
        /// Cached name for the 'get_offset' method.
        /// </summary>
        public static readonly StringName GetOffset = "get_offset";
        /// <summary>
        /// Cached name for the 'set_format' method.
        /// </summary>
        public static readonly StringName SetFormat = "set_format";
        /// <summary>
        /// Cached name for the 'get_format' method.
        /// </summary>
        public static readonly StringName GetFormat = "get_format";
        /// <summary>
        /// Cached name for the 'set_stride' method.
        /// </summary>
        public static readonly StringName SetStride = "set_stride";
        /// <summary>
        /// Cached name for the 'get_stride' method.
        /// </summary>
        public static readonly StringName GetStride = "get_stride";
        /// <summary>
        /// Cached name for the 'set_frequency' method.
        /// </summary>
        public static readonly StringName SetFrequency = "set_frequency";
        /// <summary>
        /// Cached name for the 'get_frequency' method.
        /// </summary>
        public static readonly StringName GetFrequency = "get_frequency";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : RefCounted.SignalName
    {
    }
}

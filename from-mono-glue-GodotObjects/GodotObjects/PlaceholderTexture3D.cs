namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>This class is used when loading a project that uses a <see cref="Godot.Texture3D"/> subclass in 2 conditions:</para>
/// <para>- When running the project exported in dedicated server mode, only the texture's dimensions are kept (as they may be relied upon for gameplay purposes or positioning of other elements). This allows reducing the exported PCK's size significantly.</para>
/// <para>- When this subclass is missing due to using a different engine version or build (e.g. modules disabled).</para>
/// <para><b>Note:</b> This is not intended to be used as an actual texture for rendering. It is not guaranteed to work like one in shaders or materials (for example when calculating UV).</para>
/// </summary>
public partial class PlaceholderTexture3D : Texture3D
{
    /// <summary>
    /// <para>The texture's size (in pixels).</para>
    /// </summary>
    public Vector3I Size
    {
        get
        {
            return GetSize();
        }
        set
        {
            SetSize(value);
        }
    }

    private static readonly System.Type CachedType = typeof(PlaceholderTexture3D);

    private static readonly StringName NativeName = "PlaceholderTexture3D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public PlaceholderTexture3D() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal PlaceholderTexture3D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSize, 560364750ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetSize(Vector3I size)
    {
        NativeCalls.godot_icall_1_867(MethodBind0, GodotObject.GetPtr(this), &size);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSize, 2785653706ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3I GetSize()
    {
        return NativeCalls.godot_icall_0_868(MethodBind1, GodotObject.GetPtr(this));
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
    public new class PropertyName : Texture3D.PropertyName
    {
        /// <summary>
        /// Cached name for the 'size' property.
        /// </summary>
        public static readonly StringName Size = "size";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Texture3D.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_size' method.
        /// </summary>
        public static readonly StringName SetSize = "set_size";
        /// <summary>
        /// Cached name for the 'get_size' method.
        /// </summary>
        public static readonly StringName GetSize = "get_size";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Texture3D.SignalName
    {
    }
}

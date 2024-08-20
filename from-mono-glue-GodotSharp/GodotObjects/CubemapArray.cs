namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.CubemapArray"/>s are made of an array of <see cref="Godot.Cubemap"/>s. Like <see cref="Godot.Cubemap"/>s, they are made of multiple textures, the amount of which must be divisible by 6 (one for each face of the cube).</para>
/// <para>The primary benefit of <see cref="Godot.CubemapArray"/>s is that they can be accessed in shader code using a single texture reference. In other words, you can pass multiple <see cref="Godot.Cubemap"/>s into a shader using a single <see cref="Godot.CubemapArray"/>. <see cref="Godot.Cubemap"/>s are allocated in adjacent cache regions on the GPU, which makes <see cref="Godot.CubemapArray"/>s the most efficient way to store multiple <see cref="Godot.Cubemap"/>s.</para>
/// <para><b>Note:</b> Godot uses <see cref="Godot.CubemapArray"/>s internally for many effects, including the <see cref="Godot.Sky"/> if you set <c>ProjectSettings.rendering/reflections/sky_reflections/texture_array_reflections</c> to <see langword="true"/>. To create such a texture file yourself, reimport your image files using the import presets of the File System dock.</para>
/// <para><b>Note:</b> <see cref="Godot.CubemapArray"/> is not supported in the OpenGL 3 rendering backend.</para>
/// </summary>
public partial class CubemapArray : ImageTextureLayered
{
    private static readonly System.Type CachedType = typeof(CubemapArray);

    private static readonly StringName NativeName = "CubemapArray";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public CubemapArray() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal CubemapArray(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CreatePlaceholder, 121922552ul);

    /// <summary>
    /// <para>Creates a placeholder version of this resource (<see cref="Godot.PlaceholderCubemapArray"/>).</para>
    /// </summary>
    public Resource CreatePlaceholder()
    {
        return (Resource)NativeCalls.godot_icall_0_58(MethodBind0, GodotObject.GetPtr(this));
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
    public new class PropertyName : ImageTextureLayered.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : ImageTextureLayered.MethodName
    {
        /// <summary>
        /// Cached name for the 'create_placeholder' method.
        /// </summary>
        public static readonly StringName CreatePlaceholder = "create_placeholder";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : ImageTextureLayered.SignalName
    {
    }
}

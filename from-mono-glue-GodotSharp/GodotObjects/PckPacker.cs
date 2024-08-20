namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>The <see cref="Godot.PckPacker"/> is used to create packages that can be loaded into a running project using <see cref="Godot.ProjectSettings.LoadResourcePack(string, bool, int)"/>.</para>
/// <para><code>
/// var packer = new PckPacker();
/// packer.PckStart("test.pck");
/// packer.AddFile("res://text.txt", "text.txt");
/// packer.Flush();
/// </code></para>
/// <para>The above <see cref="Godot.PckPacker"/> creates package <c>test.pck</c>, then adds a file named <c>text.txt</c> at the root of the package.</para>
/// </summary>
[GodotClassName("PCKPacker")]
public partial class PckPacker : RefCounted
{
    private static readonly System.Type CachedType = typeof(PckPacker);

    private static readonly StringName NativeName = "PCKPacker";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public PckPacker() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal PckPacker(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.PckStart, 508410629ul);

    /// <summary>
    /// <para>Creates a new PCK file with the name <paramref name="pckName"/>. The <c>.pck</c> file extension isn't added automatically, so it should be part of <paramref name="pckName"/> (even though it's not required).</para>
    /// </summary>
    public Error PckStart(string pckName, int alignment = 32, string key = "0000000000000000000000000000000000000000000000000000000000000000", bool encryptDirectory = false)
    {
        return (Error)NativeCalls.godot_icall_4_820(MethodBind0, GodotObject.GetPtr(this), pckName, alignment, key, encryptDirectory.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddFile, 2215643711ul);

    /// <summary>
    /// <para>Adds the <paramref name="sourcePath"/> file to the current PCK package at the <paramref name="pckPath"/> internal path (should start with <c>res://</c>).</para>
    /// </summary>
    public Error AddFile(string pckPath, string sourcePath, bool encrypt = false)
    {
        return (Error)NativeCalls.godot_icall_3_821(MethodBind1, GodotObject.GetPtr(this), pckPath, sourcePath, encrypt.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Flush, 1633102583ul);

    /// <summary>
    /// <para>Writes the files specified using all <see cref="Godot.PckPacker.AddFile(string, string, bool)"/> calls since the last flush. If <paramref name="verbose"/> is <see langword="true"/>, a list of files added will be printed to the console for easier debugging.</para>
    /// </summary>
    public Error Flush(bool verbose = false)
    {
        return (Error)NativeCalls.godot_icall_1_604(MethodBind2, GodotObject.GetPtr(this), verbose.ToGodotBool());
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
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : RefCounted.MethodName
    {
        /// <summary>
        /// Cached name for the 'pck_start' method.
        /// </summary>
        public static readonly StringName PckStart = "pck_start";
        /// <summary>
        /// Cached name for the 'add_file' method.
        /// </summary>
        public static readonly StringName AddFile = "add_file";
        /// <summary>
        /// Cached name for the 'flush' method.
        /// </summary>
        public static readonly StringName Flush = "flush";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : RefCounted.SignalName
    {
    }
}

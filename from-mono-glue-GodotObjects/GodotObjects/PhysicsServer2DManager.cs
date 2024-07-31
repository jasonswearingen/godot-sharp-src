namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.PhysicsServer2DManager"/> is the API for registering <see cref="Godot.PhysicsServer2D"/> implementations and for setting the default implementation.</para>
/// <para><b>Note:</b> It is not possible to switch physics servers at runtime. This class is only used on startup at the server initialization level, by Godot itself and possibly by GDExtensions.</para>
/// </summary>
public static partial class PhysicsServer2DManager
{
    private static readonly StringName NativeName = "PhysicsServer2DManager";

    private static PhysicsServer2DManagerInstance singleton;

    public static PhysicsServer2DManagerInstance Singleton =>
        singleton ??= (PhysicsServer2DManagerInstance)InteropUtils.EngineGetSingleton("PhysicsServer2DManager");

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.RegisterServer, 2137474292ul);

    /// <summary>
    /// <para>Register a <see cref="Godot.PhysicsServer2D"/> implementation by passing a <paramref name="name"/> and a <see cref="Godot.Callable"/> that returns a <see cref="Godot.PhysicsServer2D"/> object.</para>
    /// </summary>
    public static void RegisterServer(string name, Callable createCallback)
    {
        NativeCalls.godot_icall_2_439(MethodBind0, GodotObject.GetPtr(Singleton), name, createCallback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDefaultServer, 2956805083ul);

    /// <summary>
    /// <para>Set the default <see cref="Godot.PhysicsServer2D"/> implementation to the one identified by <paramref name="name"/>, if <paramref name="priority"/> is greater than the priority of the current default implementation.</para>
    /// </summary>
    public static void SetDefaultServer(string name, int priority)
    {
        NativeCalls.godot_icall_2_367(MethodBind1, GodotObject.GetPtr(Singleton), name, priority);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public class PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public class MethodName
    {
        /// <summary>
        /// Cached name for the 'register_server' method.
        /// </summary>
        public static readonly StringName RegisterServer = "register_server";
        /// <summary>
        /// Cached name for the 'set_default_server' method.
        /// </summary>
        public static readonly StringName SetDefaultServer = "set_default_server";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public class SignalName
    {
    }
}

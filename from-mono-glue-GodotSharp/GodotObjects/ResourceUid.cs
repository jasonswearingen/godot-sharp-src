namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Resource UIDs (Unique IDentifiers) allow the engine to keep references between resources intact, even if files can renamed or moved. They can be accessed with <c>uid://</c>.</para>
/// <para><see cref="Godot.ResourceUid"/> keeps track of all registered resource UIDs in a project, generates new UIDs, and converts between their string and integer representations.</para>
/// </summary>
[GodotClassName("ResourceUID")]
public static partial class ResourceUid
{
    /// <summary>
    /// <para>The value to use for an invalid UID, for example if the resource could not be loaded.</para>
    /// <para>Its text representation is <c>uid://&lt;invalid&gt;</c>.</para>
    /// </summary>
    public const long InvalidId = -1;

    private static readonly StringName NativeName = "ResourceUID";

    private static ResourceUidInstance singleton;

    public static ResourceUidInstance Singleton =>
        singleton ??= (ResourceUidInstance)InteropUtils.EngineGetSingleton("ResourceUID");

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.IdToText, 844755477ul);

    /// <summary>
    /// <para>Converts the given UID to a <c>uid://</c> string value.</para>
    /// </summary>
    public static string IdToText(long id)
    {
        return NativeCalls.godot_icall_1_813(MethodBind0, GodotObject.GetPtr(Singleton), id);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.TextToId, 1321353865ul);

    /// <summary>
    /// <para>Extracts the UID value from the given <c>uid://</c> string.</para>
    /// </summary>
    public static long TextToId(string textId)
    {
        return NativeCalls.godot_icall_1_1071(MethodBind1, GodotObject.GetPtr(Singleton), textId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.CreateId, 2455072627ul);

    /// <summary>
    /// <para>Generates a random resource UID which is guaranteed to be unique within the list of currently loaded UIDs.</para>
    /// <para>In order for this UID to be registered, you must call <see cref="Godot.ResourceUid.AddId(long, string)"/> or <see cref="Godot.ResourceUid.SetId(long, string)"/>.</para>
    /// </summary>
    public static long CreateId()
    {
        return NativeCalls.godot_icall_0_4(MethodBind2, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.HasId, 1116898809ul);

    /// <summary>
    /// <para>Returns whether the given UID value is known to the cache.</para>
    /// </summary>
    public static bool HasId(long id)
    {
        return NativeCalls.godot_icall_1_11(MethodBind3, GodotObject.GetPtr(Singleton), id).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.AddId, 501894301ul);

    /// <summary>
    /// <para>Adds a new UID value which is mapped to the given resource path.</para>
    /// <para>Fails with an error if the UID already exists, so be sure to check <see cref="Godot.ResourceUid.HasId(long)"/> beforehand, or use <see cref="Godot.ResourceUid.SetId(long, string)"/> instead.</para>
    /// </summary>
    public static void AddId(long id, string path)
    {
        NativeCalls.godot_icall_2_1074(MethodBind4, GodotObject.GetPtr(Singleton), id, path);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.SetId, 501894301ul);

    /// <summary>
    /// <para>Updates the resource path of an existing UID.</para>
    /// <para>Fails with an error if the UID does not exist, so be sure to check <see cref="Godot.ResourceUid.HasId(long)"/> beforehand, or use <see cref="Godot.ResourceUid.AddId(long, string)"/> instead.</para>
    /// </summary>
    public static void SetId(long id, string path)
    {
        NativeCalls.godot_icall_2_1074(MethodBind5, GodotObject.GetPtr(Singleton), id, path);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetIdPath, 844755477ul);

    /// <summary>
    /// <para>Returns the path that the given UID value refers to.</para>
    /// <para>Fails with an error if the UID does not exist, so be sure to check <see cref="Godot.ResourceUid.HasId(long)"/> beforehand.</para>
    /// </summary>
    public static string GetIdPath(long id)
    {
        return NativeCalls.godot_icall_1_813(MethodBind6, GodotObject.GetPtr(Singleton), id);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.RemoveId, 1286410249ul);

    /// <summary>
    /// <para>Removes a loaded UID value from the cache.</para>
    /// <para>Fails with an error if the UID does not exist, so be sure to check <see cref="Godot.ResourceUid.HasId(long)"/> beforehand.</para>
    /// </summary>
    public static void RemoveId(long id)
    {
        NativeCalls.godot_icall_1_10(MethodBind7, GodotObject.GetPtr(Singleton), id);
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
        /// Cached name for the 'id_to_text' method.
        /// </summary>
        public static readonly StringName IdToText = "id_to_text";
        /// <summary>
        /// Cached name for the 'text_to_id' method.
        /// </summary>
        public static readonly StringName TextToId = "text_to_id";
        /// <summary>
        /// Cached name for the 'create_id' method.
        /// </summary>
        public static readonly StringName CreateId = "create_id";
        /// <summary>
        /// Cached name for the 'has_id' method.
        /// </summary>
        public static readonly StringName HasId = "has_id";
        /// <summary>
        /// Cached name for the 'add_id' method.
        /// </summary>
        public static readonly StringName AddId = "add_id";
        /// <summary>
        /// Cached name for the 'set_id' method.
        /// </summary>
        public static readonly StringName SetId = "set_id";
        /// <summary>
        /// Cached name for the 'get_id_path' method.
        /// </summary>
        public static readonly StringName GetIdPath = "get_id_path";
        /// <summary>
        /// Cached name for the 'remove_id' method.
        /// </summary>
        public static readonly StringName RemoveId = "remove_id";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public class SignalName
    {
    }
}

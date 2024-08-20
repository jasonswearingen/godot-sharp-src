namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>This object stores suggested bindings for an interaction profile. Interaction profiles define the metadata for a tracked XR device such as an XR controller.</para>
/// <para>For more information see the <a href="https://www.khronos.org/registry/OpenXR/specs/1.0/html/xrspec.html#semantic-path-interaction-profiles">interaction profiles info in the OpenXR specification</a>.</para>
/// </summary>
public partial class OpenXRInteractionProfile : Resource
{
    /// <summary>
    /// <para>The interaction profile path identifying the XR device.</para>
    /// </summary>
    public string InteractionProfilePath
    {
        get
        {
            return GetInteractionProfilePath();
        }
        set
        {
            SetInteractionProfilePath(value);
        }
    }

    /// <summary>
    /// <para>Action bindings for this interaction profile.</para>
    /// </summary>
    public Godot.Collections.Array Bindings
    {
        get
        {
            return GetBindings();
        }
        set
        {
            SetBindings(value);
        }
    }

    private static readonly System.Type CachedType = typeof(OpenXRInteractionProfile);

    private static readonly StringName NativeName = "OpenXRInteractionProfile";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public OpenXRInteractionProfile() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal OpenXRInteractionProfile(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetInteractionProfilePath, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetInteractionProfilePath(string interactionProfilePath)
    {
        NativeCalls.godot_icall_1_56(MethodBind0, GodotObject.GetPtr(this), interactionProfilePath);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetInteractionProfilePath, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetInteractionProfilePath()
    {
        return NativeCalls.godot_icall_0_57(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBindingCount, 3905245786ul);

    /// <summary>
    /// <para>Get the number of bindings in this interaction profile.</para>
    /// </summary>
    public int GetBindingCount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind2, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBinding, 3934429652ul);

    /// <summary>
    /// <para>Retrieve the binding at this index.</para>
    /// </summary>
    public OpenXRIPBinding GetBinding(int index)
    {
        return (OpenXRIPBinding)NativeCalls.godot_icall_1_66(MethodBind3, GodotObject.GetPtr(this), index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBindings, 381264803ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBindings(Godot.Collections.Array bindings)
    {
        NativeCalls.godot_icall_1_130(MethodBind4, GodotObject.GetPtr(this), (godot_array)(bindings ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBindings, 3995934104ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array GetBindings()
    {
        return NativeCalls.godot_icall_0_112(MethodBind5, GodotObject.GetPtr(this));
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
    public new class PropertyName : Resource.PropertyName
    {
        /// <summary>
        /// Cached name for the 'interaction_profile_path' property.
        /// </summary>
        public static readonly StringName InteractionProfilePath = "interaction_profile_path";
        /// <summary>
        /// Cached name for the 'bindings' property.
        /// </summary>
        public static readonly StringName Bindings = "bindings";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Resource.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_interaction_profile_path' method.
        /// </summary>
        public static readonly StringName SetInteractionProfilePath = "set_interaction_profile_path";
        /// <summary>
        /// Cached name for the 'get_interaction_profile_path' method.
        /// </summary>
        public static readonly StringName GetInteractionProfilePath = "get_interaction_profile_path";
        /// <summary>
        /// Cached name for the 'get_binding_count' method.
        /// </summary>
        public static readonly StringName GetBindingCount = "get_binding_count";
        /// <summary>
        /// Cached name for the 'get_binding' method.
        /// </summary>
        public static readonly StringName GetBinding = "get_binding";
        /// <summary>
        /// Cached name for the 'set_bindings' method.
        /// </summary>
        public static readonly StringName SetBindings = "set_bindings";
        /// <summary>
        /// Cached name for the 'get_bindings' method.
        /// </summary>
        public static readonly StringName GetBindings = "get_bindings";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Resource.SignalName
    {
    }
}

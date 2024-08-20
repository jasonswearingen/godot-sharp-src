namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Once added to the scene tree and enabled using <see cref="Godot.AudioListener3D.MakeCurrent()"/>, this node will override the location sounds are heard from. This can be used to listen from a location different from the <see cref="Godot.Camera3D"/>.</para>
/// </summary>
public partial class AudioListener3D : Node3D
{
    private static readonly System.Type CachedType = typeof(AudioListener3D);

    private static readonly StringName NativeName = "AudioListener3D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public AudioListener3D() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal AudioListener3D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.MakeCurrent, 3218959716ul);

    /// <summary>
    /// <para>Enables the listener. This will override the current camera's listener.</para>
    /// </summary>
    public void MakeCurrent()
    {
        NativeCalls.godot_icall_0_3(MethodBind0, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClearCurrent, 3218959716ul);

    /// <summary>
    /// <para>Disables the listener to use the current camera's listener instead.</para>
    /// </summary>
    public void ClearCurrent()
    {
        NativeCalls.godot_icall_0_3(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsCurrent, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the listener was made current using <see cref="Godot.AudioListener3D.MakeCurrent()"/>, <see langword="false"/> otherwise.</para>
    /// <para><b>Note:</b> There may be more than one AudioListener3D marked as "current" in the scene tree, but only the one that was made current last will be used.</para>
    /// </summary>
    public bool IsCurrent()
    {
        return NativeCalls.godot_icall_0_40(MethodBind2, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetListenerTransform, 3229777777ul);

    /// <summary>
    /// <para>Returns the listener's global orthonormalized <see cref="Godot.Transform3D"/>.</para>
    /// </summary>
    public Transform3D GetListenerTransform()
    {
        return NativeCalls.godot_icall_0_178(MethodBind3, GodotObject.GetPtr(this));
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
    public new class PropertyName : Node3D.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Node3D.MethodName
    {
        /// <summary>
        /// Cached name for the 'make_current' method.
        /// </summary>
        public static readonly StringName MakeCurrent = "make_current";
        /// <summary>
        /// Cached name for the 'clear_current' method.
        /// </summary>
        public static readonly StringName ClearCurrent = "clear_current";
        /// <summary>
        /// Cached name for the 'is_current' method.
        /// </summary>
        public static readonly StringName IsCurrent = "is_current";
        /// <summary>
        /// Cached name for the 'get_listener_transform' method.
        /// </summary>
        public static readonly StringName GetListenerTransform = "get_listener_transform";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Node3D.SignalName
    {
    }
}

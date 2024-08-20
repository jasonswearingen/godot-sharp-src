namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Translated to <c>uniform vec2</c> in the shader language.</para>
/// </summary>
public partial class VisualShaderNodeVec2Parameter : VisualShaderNodeParameter
{
    /// <summary>
    /// <para>Enables usage of the <see cref="Godot.VisualShaderNodeVec2Parameter.DefaultValue"/>.</para>
    /// </summary>
    public bool DefaultValueEnabled
    {
        get
        {
            return IsDefaultValueEnabled();
        }
        set
        {
            SetDefaultValueEnabled(value);
        }
    }

    /// <summary>
    /// <para>A default value to be assigned within the shader.</para>
    /// </summary>
    public Vector2 DefaultValue
    {
        get
        {
            return GetDefaultValue();
        }
        set
        {
            SetDefaultValue(value);
        }
    }

    private static readonly System.Type CachedType = typeof(VisualShaderNodeVec2Parameter);

    private static readonly StringName NativeName = "VisualShaderNodeVec2Parameter";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public VisualShaderNodeVec2Parameter() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal VisualShaderNodeVec2Parameter(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDefaultValueEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDefaultValueEnabled(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind0, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsDefaultValueEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsDefaultValueEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind1, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDefaultValue, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetDefaultValue(Vector2 value)
    {
        NativeCalls.godot_icall_1_34(MethodBind2, GodotObject.GetPtr(this), &value);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDefaultValue, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetDefaultValue()
    {
        return NativeCalls.godot_icall_0_35(MethodBind3, GodotObject.GetPtr(this));
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
    public new class PropertyName : VisualShaderNodeParameter.PropertyName
    {
        /// <summary>
        /// Cached name for the 'default_value_enabled' property.
        /// </summary>
        public static readonly StringName DefaultValueEnabled = "default_value_enabled";
        /// <summary>
        /// Cached name for the 'default_value' property.
        /// </summary>
        public static readonly StringName DefaultValue = "default_value";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : VisualShaderNodeParameter.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_default_value_enabled' method.
        /// </summary>
        public static readonly StringName SetDefaultValueEnabled = "set_default_value_enabled";
        /// <summary>
        /// Cached name for the 'is_default_value_enabled' method.
        /// </summary>
        public static readonly StringName IsDefaultValueEnabled = "is_default_value_enabled";
        /// <summary>
        /// Cached name for the 'set_default_value' method.
        /// </summary>
        public static readonly StringName SetDefaultValue = "set_default_value";
        /// <summary>
        /// Cached name for the 'get_default_value' method.
        /// </summary>
        public static readonly StringName GetDefaultValue = "get_default_value";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : VisualShaderNodeParameter.SignalName
    {
    }
}

namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>This animation node can be used to cause a seek command to happen to any sub-children of the animation graph. Use to play an <see cref="Godot.Animation"/> from the start or a certain playback position inside the <see cref="Godot.AnimationNodeBlendTree"/>.</para>
/// <para>After setting the time and changing the animation playback, the time seek node automatically goes into sleep mode on the next process frame by setting its <c>seek_request</c> value to <c>-1.0</c>.</para>
/// <para><code>
/// // Play child animation from the start.
/// animationTree.Set("parameters/TimeSeek/seek_request", 0.0);
/// 
/// // Play child animation from 12 second timestamp.
/// animationTree.Set("parameters/TimeSeek/seek_request", 12.0);
/// </code></para>
/// </summary>
public partial class AnimationNodeTimeSeek : AnimationNode
{
    private static readonly System.Type CachedType = typeof(AnimationNodeTimeSeek);

    private static readonly StringName NativeName = "AnimationNodeTimeSeek";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public AnimationNodeTimeSeek() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal AnimationNodeTimeSeek(bool memoryOwn) : base(memoryOwn) { }

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
    public new class PropertyName : AnimationNode.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : AnimationNode.MethodName
    {
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : AnimationNode.SignalName
    {
    }
}

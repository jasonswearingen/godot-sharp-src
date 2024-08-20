namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Can play, loop, pause a scroll through audio. See <see cref="Godot.AudioStream"/> and <see cref="Godot.AudioStreamOggVorbis"/> for usage.</para>
/// </summary>
public partial class AudioStreamPlayback : RefCounted
{
    private static readonly System.Type CachedType = typeof(AudioStreamPlayback);

    private static readonly StringName NativeName = "AudioStreamPlayback";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public AudioStreamPlayback() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal AudioStreamPlayback(bool memoryOwn) : base(memoryOwn) { }

    /// <summary>
    /// <para>Overridable method. Should return how many times this audio stream has looped. Most built-in playbacks always return <c>0</c>.</para>
    /// </summary>
    public virtual int _GetLoopCount()
    {
        return default;
    }

    /// <summary>
    /// <para>Return the current value of a playback parameter by name (see <see cref="Godot.AudioStream._GetParameterList()"/>).</para>
    /// </summary>
    public virtual Variant _GetParameter(StringName name)
    {
        return default;
    }

    /// <summary>
    /// <para>Overridable method. Should return the current progress along the audio stream, in seconds.</para>
    /// </summary>
    public virtual double _GetPlaybackPosition()
    {
        return default;
    }

    /// <summary>
    /// <para>Overridable method. Should return <see langword="true"/> if this playback is active and playing its audio stream.</para>
    /// </summary>
    public virtual bool _IsPlaying()
    {
        return default;
    }

    /// <summary>
    /// <para>Override this method to customize what happens when seeking this audio stream at the given <paramref name="position"/>, such as by calling <see cref="Godot.AudioStreamPlayer.Seek(float)"/>.</para>
    /// </summary>
    public virtual void _Seek(double position)
    {
    }

    /// <summary>
    /// <para>Set the current value of a playback parameter by name (see <see cref="Godot.AudioStream._GetParameterList()"/>).</para>
    /// </summary>
    public virtual void _SetParameter(StringName name, Variant value)
    {
    }

    /// <summary>
    /// <para>Override this method to customize what happens when the playback starts at the given position, such as by calling <see cref="Godot.AudioStreamPlayer.Play(float)"/>.</para>
    /// </summary>
    public virtual void _Start(double fromPos)
    {
    }

    /// <summary>
    /// <para>Override this method to customize what happens when the playback is stopped, such as by calling <see cref="Godot.AudioStreamPlayer.Stop()"/>.</para>
    /// </summary>
    public virtual void _Stop()
    {
    }

    /// <summary>
    /// <para>Overridable method. Called whenever the audio stream is mixed if the playback is active and <see cref="Godot.AudioServer.SetEnableTaggingUsedAudioStreams(bool)"/> has been set to <see langword="true"/>. Editor plugins may use this method to "tag" the current position along the audio stream and display it in a preview.</para>
    /// </summary>
    public virtual void _TagUsedStreams()
    {
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSamplePlayback, 3195455091ul);

    /// <summary>
    /// <para>Associates <see cref="Godot.AudioSamplePlayback"/> to this <see cref="Godot.AudioStreamPlayback"/> for playing back the audio sample of this stream.</para>
    /// </summary>
    public void SetSamplePlayback(AudioSamplePlayback playbackSample)
    {
        NativeCalls.godot_icall_1_55(MethodBind0, GodotObject.GetPtr(this), GodotObject.GetPtr(playbackSample));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSamplePlayback, 3482738536ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.AudioSamplePlayback"/> associated with this <see cref="Godot.AudioStreamPlayback"/> for playing back the audio sample of this stream.</para>
    /// </summary>
    public AudioSamplePlayback GetSamplePlayback()
    {
        return (AudioSamplePlayback)NativeCalls.godot_icall_0_58(MethodBind1, GodotObject.GetPtr(this));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_loop_count = "_GetLoopCount";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_parameter = "_GetParameter";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_playback_position = "_GetPlaybackPosition";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__is_playing = "_IsPlaying";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__seek = "_Seek";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__set_parameter = "_SetParameter";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__start = "_Start";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__stop = "_Stop";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__tag_used_streams = "_TagUsedStreams";

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
        if ((method == MethodProxyName__get_loop_count || method == MethodName._GetLoopCount) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_loop_count.NativeValue))
        {
            var callRet = _GetLoopCount();
            ret = VariantUtils.CreateFrom<int>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_parameter || method == MethodName._GetParameter) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_parameter.NativeValue))
        {
            var callRet = _GetParameter(VariantUtils.ConvertTo<StringName>(args[0]));
            ret = VariantUtils.CreateFrom<Variant>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_playback_position || method == MethodName._GetPlaybackPosition) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_playback_position.NativeValue))
        {
            var callRet = _GetPlaybackPosition();
            ret = VariantUtils.CreateFrom<double>(callRet);
            return true;
        }
        if ((method == MethodProxyName__is_playing || method == MethodName._IsPlaying) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__is_playing.NativeValue))
        {
            var callRet = _IsPlaying();
            ret = VariantUtils.CreateFrom<bool>(callRet);
            return true;
        }
        if ((method == MethodProxyName__seek || method == MethodName._Seek) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__seek.NativeValue))
        {
            _Seek(VariantUtils.ConvertTo<double>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__set_parameter || method == MethodName._SetParameter) && args.Count == 2 && HasGodotClassMethod((godot_string_name)MethodProxyName__set_parameter.NativeValue))
        {
            _SetParameter(VariantUtils.ConvertTo<StringName>(args[0]), VariantUtils.ConvertTo<Variant>(args[1]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__start || method == MethodName._Start) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__start.NativeValue))
        {
            _Start(VariantUtils.ConvertTo<double>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__stop || method == MethodName._Stop) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__stop.NativeValue))
        {
            _Stop();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__tag_used_streams || method == MethodName._TagUsedStreams) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__tag_used_streams.NativeValue))
        {
            _TagUsedStreams();
            ret = default;
            return true;
        }
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
        if (method == MethodName._GetLoopCount)
        {
            if (HasGodotClassMethod(MethodProxyName__get_loop_count.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetParameter)
        {
            if (HasGodotClassMethod(MethodProxyName__get_parameter.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetPlaybackPosition)
        {
            if (HasGodotClassMethod(MethodProxyName__get_playback_position.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._IsPlaying)
        {
            if (HasGodotClassMethod(MethodProxyName__is_playing.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._Seek)
        {
            if (HasGodotClassMethod(MethodProxyName__seek.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._SetParameter)
        {
            if (HasGodotClassMethod(MethodProxyName__set_parameter.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._Start)
        {
            if (HasGodotClassMethod(MethodProxyName__start.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._Stop)
        {
            if (HasGodotClassMethod(MethodProxyName__stop.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._TagUsedStreams)
        {
            if (HasGodotClassMethod(MethodProxyName__tag_used_streams.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
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
        /// Cached name for the '_get_loop_count' method.
        /// </summary>
        public static readonly StringName _GetLoopCount = "_get_loop_count";
        /// <summary>
        /// Cached name for the '_get_parameter' method.
        /// </summary>
        public static readonly StringName _GetParameter = "_get_parameter";
        /// <summary>
        /// Cached name for the '_get_playback_position' method.
        /// </summary>
        public static readonly StringName _GetPlaybackPosition = "_get_playback_position";
        /// <summary>
        /// Cached name for the '_is_playing' method.
        /// </summary>
        public static readonly StringName _IsPlaying = "_is_playing";
        /// <summary>
        /// Cached name for the '_seek' method.
        /// </summary>
        public static readonly StringName _Seek = "_seek";
        /// <summary>
        /// Cached name for the '_set_parameter' method.
        /// </summary>
        public static readonly StringName _SetParameter = "_set_parameter";
        /// <summary>
        /// Cached name for the '_start' method.
        /// </summary>
        public static readonly StringName _Start = "_start";
        /// <summary>
        /// Cached name for the '_stop' method.
        /// </summary>
        public static readonly StringName _Stop = "_stop";
        /// <summary>
        /// Cached name for the '_tag_used_streams' method.
        /// </summary>
        public static readonly StringName _TagUsedStreams = "_tag_used_streams";
        /// <summary>
        /// Cached name for the 'set_sample_playback' method.
        /// </summary>
        public static readonly StringName SetSamplePlayback = "set_sample_playback";
        /// <summary>
        /// Cached name for the 'get_sample_playback' method.
        /// </summary>
        public static readonly StringName GetSamplePlayback = "get_sample_playback";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : RefCounted.SignalName
    {
    }
}

namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.OpenXRApiExtension"/> makes OpenXR available for GDExtension. It provides the OpenXR API to GDExtension through the <see cref="Godot.OpenXRApiExtension.GetInstanceProcAddr(string)"/> method, and the OpenXR instance through <see cref="Godot.OpenXRApiExtension.GetInstance()"/>.</para>
/// <para>It also provides methods for querying the status of OpenXR initialization, and helper methods for ease of use of the API with GDExtension.</para>
/// </summary>
[GodotClassName("OpenXRAPIExtension")]
public partial class OpenXRApiExtension : RefCounted
{
    public enum OpenXRAlphaBlendModeSupport : long
    {
        /// <summary>
        /// <para>Means that <see cref="Godot.XRInterface.EnvironmentBlendModeEnum.AlphaBlend"/> isn't supported at all.</para>
        /// </summary>
        None = 0,
        /// <summary>
        /// <para>Means that <see cref="Godot.XRInterface.EnvironmentBlendModeEnum.AlphaBlend"/> is really supported.</para>
        /// </summary>
        Real = 1,
        /// <summary>
        /// <para>Means that <see cref="Godot.XRInterface.EnvironmentBlendModeEnum.AlphaBlend"/> is emulated.</para>
        /// </summary>
        Emulating = 2
    }

    private static readonly System.Type CachedType = typeof(OpenXRApiExtension);

    private static readonly StringName NativeName = "OpenXRAPIExtension";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public OpenXRApiExtension() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal OpenXRApiExtension(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetInstance, 2455072627ul);

    /// <summary>
    /// <para>Returns the <a href="https://registry.khronos.org/OpenXR/specs/1.0/man/html/XrInstance.html">XrInstance</a> created during the initialization of the OpenXR API.</para>
    /// </summary>
    public ulong GetInstance()
    {
        return NativeCalls.godot_icall_0_344(MethodBind0, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSystemId, 2455072627ul);

    /// <summary>
    /// <para>Returns the id of the system, which is a <a href="https://registry.khronos.org/OpenXR/specs/1.0/man/html/XrSystemId.html">XrSystemId</a> cast to an integer.</para>
    /// </summary>
    public ulong GetSystemId()
    {
        return NativeCalls.godot_icall_0_344(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSession, 2455072627ul);

    /// <summary>
    /// <para>Returns the OpenXR session, which is an <a href="https://registry.khronos.org/OpenXR/specs/1.0/man/html/XrSession.html">XrSession</a> cast to an integer.</para>
    /// </summary>
    public ulong GetSession()
    {
        return NativeCalls.godot_icall_0_344(MethodBind2, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.XRResult, 3886436197ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the provided <a href="https://registry.khronos.org/OpenXR/specs/1.0/man/html/XrResult.html">XrResult</a> (cast to an integer) is successful. Otherwise returns <see langword="false"/> and prints the <a href="https://registry.khronos.org/OpenXR/specs/1.0/man/html/XrResult.html">XrResult</a> converted to a string, with the specified additional information.</para>
    /// </summary>
    public bool XRResult(ulong result, string format, Godot.Collections.Array args)
    {
        return NativeCalls.godot_icall_3_809(MethodBind3, GodotObject.GetPtr(this), result, format, (godot_array)(args ?? new()).NativeValue).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.OpenxrIsEnabled, 2703660260ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if OpenXR is enabled.</para>
    /// </summary>
    public static bool OpenxrIsEnabled(bool checkRunInEditor)
    {
        return NativeCalls.godot_icall_1_810(MethodBind4, checkRunInEditor.ToGodotBool()).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetInstanceProcAddr, 1597066294ul);

    /// <summary>
    /// <para>Returns the function pointer of the OpenXR function with the specified name, cast to an integer. If the function with the given name does not exist, the method returns <c>0</c>.</para>
    /// <para><b>Note:</b> <c>openxr/util.h</c> contains utility macros for acquiring OpenXR functions, e.g. <c>GDEXTENSION_INIT_XR_FUNC_V(xrCreateAction)</c>.</para>
    /// </summary>
    public ulong GetInstanceProcAddr(string name)
    {
        return NativeCalls.godot_icall_1_811(MethodBind5, GodotObject.GetPtr(this), name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetErrorString, 990163283ul);

    /// <summary>
    /// <para>Returns an error string for the given <a href="https://registry.khronos.org/OpenXR/specs/1.0/man/html/XrResult.html">XrResult</a>.</para>
    /// </summary>
    public string GetErrorString(ulong result)
    {
        return NativeCalls.godot_icall_1_812(MethodBind6, GodotObject.GetPtr(this), result);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSwapchainFormatName, 990163283ul);

    /// <summary>
    /// <para>Returns the name of the specified swapchain format.</para>
    /// </summary>
    public string GetSwapchainFormatName(long swapchainFormat)
    {
        return NativeCalls.godot_icall_1_813(MethodBind7, GodotObject.GetPtr(this), swapchainFormat);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsInitialized, 2240911060ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if OpenXR is initialized.</para>
    /// </summary>
    public bool IsInitialized()
    {
        return NativeCalls.godot_icall_0_40(MethodBind8, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsRunning, 2240911060ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if OpenXR is running (<a href="https://registry.khronos.org/OpenXR/specs/1.0/man/html/xrBeginSession.html">xrBeginSession</a> was successfully called and the swapchains were created).</para>
    /// </summary>
    public bool IsRunning()
    {
        return NativeCalls.godot_icall_0_40(MethodBind9, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPlaySpace, 2455072627ul);

    /// <summary>
    /// <para>Returns the play space, which is an <a href="https://registry.khronos.org/OpenXR/specs/1.0/man/html/XrSpace.html">XrSpace</a> cast to an integer.</para>
    /// </summary>
    public ulong GetPlaySpace()
    {
        return NativeCalls.godot_icall_0_344(MethodBind10, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPredictedDisplayTime, 2455072627ul);

    /// <summary>
    /// <para>Returns the predicted display timing for the current frame.</para>
    /// </summary>
    public long GetPredictedDisplayTime()
    {
        return NativeCalls.godot_icall_0_4(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNextFrameTime, 2455072627ul);

    /// <summary>
    /// <para>Returns the predicted display timing for the next frame.</para>
    /// </summary>
    public long GetNextFrameTime()
    {
        return NativeCalls.godot_icall_0_4(MethodBind12, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CanRender, 2240911060ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if OpenXR is initialized for rendering with an XR viewport.</para>
    /// </summary>
    public bool CanRender()
    {
        return NativeCalls.godot_icall_0_40(MethodBind13, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHandTracker, 3744713108ul);

    /// <summary>
    /// <para>Returns the corresponding <c>XRHandTrackerEXT</c> handle for the given hand index value.</para>
    /// </summary>
    public ulong GetHandTracker(int handIndex)
    {
        return NativeCalls.godot_icall_1_381(MethodBind14, GodotObject.GetPtr(this), handIndex);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RegisterCompositionLayerProvider, 1997997368ul);

    /// <summary>
    /// <para>Registers the given extension as a composition layer provider.</para>
    /// </summary>
    public void RegisterCompositionLayerProvider(OpenXRExtensionWrapperExtension extension)
    {
        NativeCalls.godot_icall_1_55(MethodBind15, GodotObject.GetPtr(this), GodotObject.GetPtr(extension));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.UnregisterCompositionLayerProvider, 1997997368ul);

    /// <summary>
    /// <para>Unregisters the given extension as a composition layer provider.</para>
    /// </summary>
    public void UnregisterCompositionLayerProvider(OpenXRExtensionWrapperExtension extension)
    {
        NativeCalls.godot_icall_1_55(MethodBind16, GodotObject.GetPtr(this), GodotObject.GetPtr(extension));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmulateEnvironmentBlendModeAlphaBlend, 2586408642ul);

    /// <summary>
    /// <para>If set to <see langword="true"/>, an OpenXR extension is loaded which is capable of emulating the <see cref="Godot.XRInterface.EnvironmentBlendModeEnum.AlphaBlend"/> blend mode.</para>
    /// </summary>
    public void SetEmulateEnvironmentBlendModeAlphaBlend(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind17, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsEnvironmentBlendModeAlphaSupported, 1579290861ul);

    /// <summary>
    /// <para>Returns <see cref="Godot.OpenXRApiExtension.OpenXRAlphaBlendModeSupport"/> denoting if <see cref="Godot.XRInterface.EnvironmentBlendModeEnum.AlphaBlend"/> is really supported, emulated or not supported at all.</para>
    /// </summary>
    public OpenXRApiExtension.OpenXRAlphaBlendModeSupport IsEnvironmentBlendModeAlphaSupported()
    {
        return (OpenXRApiExtension.OpenXRAlphaBlendModeSupport)NativeCalls.godot_icall_0_37(MethodBind18, GodotObject.GetPtr(this));
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
        /// Cached name for the 'get_instance' method.
        /// </summary>
        public static readonly StringName GetInstance = "get_instance";
        /// <summary>
        /// Cached name for the 'get_system_id' method.
        /// </summary>
        public static readonly StringName GetSystemId = "get_system_id";
        /// <summary>
        /// Cached name for the 'get_session' method.
        /// </summary>
        public static readonly StringName GetSession = "get_session";
        /// <summary>
        /// Cached name for the 'xr_result' method.
        /// </summary>
        public static readonly StringName XRResult = "xr_result";
        /// <summary>
        /// Cached name for the 'openxr_is_enabled' method.
        /// </summary>
        public static readonly StringName OpenxrIsEnabled = "openxr_is_enabled";
        /// <summary>
        /// Cached name for the 'get_instance_proc_addr' method.
        /// </summary>
        public static readonly StringName GetInstanceProcAddr = "get_instance_proc_addr";
        /// <summary>
        /// Cached name for the 'get_error_string' method.
        /// </summary>
        public static readonly StringName GetErrorString = "get_error_string";
        /// <summary>
        /// Cached name for the 'get_swapchain_format_name' method.
        /// </summary>
        public static readonly StringName GetSwapchainFormatName = "get_swapchain_format_name";
        /// <summary>
        /// Cached name for the 'is_initialized' method.
        /// </summary>
        public static readonly StringName IsInitialized = "is_initialized";
        /// <summary>
        /// Cached name for the 'is_running' method.
        /// </summary>
        public static readonly StringName IsRunning = "is_running";
        /// <summary>
        /// Cached name for the 'get_play_space' method.
        /// </summary>
        public static readonly StringName GetPlaySpace = "get_play_space";
        /// <summary>
        /// Cached name for the 'get_predicted_display_time' method.
        /// </summary>
        public static readonly StringName GetPredictedDisplayTime = "get_predicted_display_time";
        /// <summary>
        /// Cached name for the 'get_next_frame_time' method.
        /// </summary>
        public static readonly StringName GetNextFrameTime = "get_next_frame_time";
        /// <summary>
        /// Cached name for the 'can_render' method.
        /// </summary>
        public static readonly StringName CanRender = "can_render";
        /// <summary>
        /// Cached name for the 'get_hand_tracker' method.
        /// </summary>
        public static readonly StringName GetHandTracker = "get_hand_tracker";
        /// <summary>
        /// Cached name for the 'register_composition_layer_provider' method.
        /// </summary>
        public static readonly StringName RegisterCompositionLayerProvider = "register_composition_layer_provider";
        /// <summary>
        /// Cached name for the 'unregister_composition_layer_provider' method.
        /// </summary>
        public static readonly StringName UnregisterCompositionLayerProvider = "unregister_composition_layer_provider";
        /// <summary>
        /// Cached name for the 'set_emulate_environment_blend_mode_alpha_blend' method.
        /// </summary>
        public static readonly StringName SetEmulateEnvironmentBlendModeAlphaBlend = "set_emulate_environment_blend_mode_alpha_blend";
        /// <summary>
        /// Cached name for the 'is_environment_blend_mode_alpha_supported' method.
        /// </summary>
        public static readonly StringName IsEnvironmentBlendModeAlphaSupported = "is_environment_blend_mode_alpha_supported";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : RefCounted.SignalName
    {
    }
}

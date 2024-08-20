namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.OpenXRExtensionWrapperExtension"/> allows clients to implement OpenXR extensions with GDExtension. The extension should be registered with <see cref="Godot.OpenXRExtensionWrapperExtension.RegisterExtensionWrapper()"/>.</para>
/// </summary>
public partial class OpenXRExtensionWrapperExtension : GodotObject
{
    private static readonly System.Type CachedType = typeof(OpenXRExtensionWrapperExtension);

    private static readonly StringName NativeName = "OpenXRExtensionWrapperExtension";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public OpenXRExtensionWrapperExtension() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal OpenXRExtensionWrapperExtension(bool memoryOwn) : base(memoryOwn) { }

    /// <summary>
    /// <para>Returns a pointer to an <c>XrCompositionLayerBaseHeader</c> struct to provide the given composition layer.</para>
    /// <para>This will only be called if the extension previously registered itself with <see cref="Godot.OpenXRApiExtension.RegisterCompositionLayerProvider(OpenXRExtensionWrapperExtension)"/>.</para>
    /// </summary>
    public virtual ulong _GetCompositionLayer(int index)
    {
        return default;
    }

    /// <summary>
    /// <para>Returns the number of composition layers this extension wrapper provides via <see cref="Godot.OpenXRExtensionWrapperExtension._GetCompositionLayer(int)"/>.</para>
    /// <para>This will only be called if the extension previously registered itself with <see cref="Godot.OpenXRApiExtension.RegisterCompositionLayerProvider(OpenXRExtensionWrapperExtension)"/>.</para>
    /// </summary>
    public virtual int _GetCompositionLayerCount()
    {
        return default;
    }

    /// <summary>
    /// <para>Returns an integer that will be used to sort the given composition layer provided via <see cref="Godot.OpenXRExtensionWrapperExtension._GetCompositionLayer(int)"/>. Lower numbers will move the layer to the front of the list, and higher numbers to the end. The default projection layer has an order of <c>0</c>, so layers provided by this method should probably be above or below (but not exactly) <c>0</c>.</para>
    /// <para>This will only be called if the extension previously registered itself with <see cref="Godot.OpenXRApiExtension.RegisterCompositionLayerProvider(OpenXRExtensionWrapperExtension)"/>.</para>
    /// </summary>
    public virtual int _GetCompositionLayerOrder(int index)
    {
        return default;
    }

    /// <summary>
    /// <para>Returns a <see cref="Godot.Collections.Dictionary"/> of OpenXR extensions related to this extension. The <see cref="Godot.Collections.Dictionary"/> should contain the name of the extension, mapped to a <c>bool *</c> cast to an integer:</para>
    /// <para>- If the <c>bool *</c> is a <c>nullptr</c> this extension is mandatory.</para>
    /// <para>- If the <c>bool *</c> points to a boolean, the boolean will be updated to <see langword="true"/> if the extension is enabled.</para>
    /// </summary>
    public virtual Godot.Collections.Dictionary _GetRequestedExtensions()
    {
        return default;
    }

    /// <summary>
    /// <para>Returns a <see cref="string"/>[] of positional tracker names that are used within the extension wrapper.</para>
    /// </summary>
    public virtual string[] _GetSuggestedTrackerNames()
    {
        return default;
    }

    /// <summary>
    /// <para>Gets an array of <see cref="Godot.Collections.Dictionary"/>s that represent properties, just like <see cref="Godot.GodotObject._GetPropertyList()"/>, that will be added to <see cref="Godot.OpenXRCompositionLayer"/> nodes.</para>
    /// </summary>
    public virtual Godot.Collections.Array<Godot.Collections.Dictionary> _GetViewportCompositionLayerExtensionProperties()
    {
        return default;
    }

    /// <summary>
    /// <para>Gets a <see cref="Godot.Collections.Dictionary"/> containing the default values for the properties returned by <see cref="Godot.OpenXRExtensionWrapperExtension._GetViewportCompositionLayerExtensionProperties()"/>.</para>
    /// </summary>
    public virtual Godot.Collections.Dictionary _GetViewportCompositionLayerExtensionPropertyDefaults()
    {
        return default;
    }

    /// <summary>
    /// <para>Called before the OpenXR instance is created.</para>
    /// </summary>
    public virtual void _OnBeforeInstanceCreated()
    {
    }

    /// <summary>
    /// <para>Called right after the OpenXR instance is created.</para>
    /// </summary>
    public virtual void _OnInstanceCreated(ulong instance)
    {
    }

    /// <summary>
    /// <para>Called right before the OpenXR instance is destroyed.</para>
    /// </summary>
    public virtual void _OnInstanceDestroyed()
    {
    }

    /// <summary>
    /// <para>Called right after the main swapchains are (re)created.</para>
    /// </summary>
    public virtual void _OnMainSwapchainsCreated()
    {
    }

    /// <summary>
    /// <para>Called right before the XR viewports begin their rendering step.</para>
    /// </summary>
    public virtual void _OnPreRender()
    {
    }

    /// <summary>
    /// <para>Called as part of the OpenXR process handling. This happens right before general and physics processing steps of the main loop. During this step controller data is queried and made available to game logic.</para>
    /// </summary>
    public virtual void _OnProcess()
    {
    }

    /// <summary>
    /// <para>Allows extensions to register additional controller metadata. This function is called even when the OpenXR API is not constructed as the metadata needs to be available to the editor.</para>
    /// <para>Extensions should also provide metadata regardless of whether they are supported on the host system. The controller data is used to setup action maps for users who may have access to the relevant hardware.</para>
    /// </summary>
    public virtual void _OnRegisterMetadata()
    {
    }

    /// <summary>
    /// <para>Called right after the OpenXR session is created.</para>
    /// </summary>
    public virtual void _OnSessionCreated(ulong session)
    {
    }

    /// <summary>
    /// <para>Called right before the OpenXR session is destroyed.</para>
    /// </summary>
    public virtual void _OnSessionDestroyed()
    {
    }

    /// <summary>
    /// <para>Called when the OpenXR session state is changed to exiting.</para>
    /// </summary>
    public virtual void _OnStateExiting()
    {
    }

    /// <summary>
    /// <para>Called when the OpenXR session state is changed to focused. This state is the active state when the game runs.</para>
    /// </summary>
    public virtual void _OnStateFocused()
    {
    }

    /// <summary>
    /// <para>Called when the OpenXR session state is changed to idle.</para>
    /// </summary>
    public virtual void _OnStateIdle()
    {
    }

    /// <summary>
    /// <para>Called when the OpenXR session state is changed to loss pending.</para>
    /// </summary>
    public virtual void _OnStateLossPending()
    {
    }

    /// <summary>
    /// <para>Called when the OpenXR session state is changed to ready. This means OpenXR is ready to set up the session.</para>
    /// </summary>
    public virtual void _OnStateReady()
    {
    }

    /// <summary>
    /// <para>Called when the OpenXR session state is changed to stopping.</para>
    /// </summary>
    public virtual void _OnStateStopping()
    {
    }

    /// <summary>
    /// <para>Called when the OpenXR session state is changed to synchronized. OpenXR also returns to this state when the application loses focus.</para>
    /// </summary>
    public virtual void _OnStateSynchronized()
    {
    }

    /// <summary>
    /// <para>Called when the OpenXR session state is changed to visible. This means OpenXR is now ready to receive frames.</para>
    /// </summary>
    public virtual void _OnStateVisible()
    {
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOpenxrApi, 1637791613ul);

    /// <summary>
    /// <para>Returns the created <see cref="Godot.OpenXRApiExtension"/>, which can be used to access the OpenXR API.</para>
    /// </summary>
    public OpenXRApiExtension GetOpenxrApi()
    {
        return (OpenXRApiExtension)NativeCalls.godot_icall_0_58(MethodBind0, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RegisterExtensionWrapper, 3218959716ul);

    /// <summary>
    /// <para>Registers the extension. This should happen at core module initialization level.</para>
    /// </summary>
    public void RegisterExtensionWrapper()
    {
        NativeCalls.godot_icall_0_3(MethodBind1, GodotObject.GetPtr(this));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_composition_layer = "_GetCompositionLayer";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_composition_layer_count = "_GetCompositionLayerCount";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_composition_layer_order = "_GetCompositionLayerOrder";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_requested_extensions = "_GetRequestedExtensions";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_suggested_tracker_names = "_GetSuggestedTrackerNames";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_viewport_composition_layer_extension_properties = "_GetViewportCompositionLayerExtensionProperties";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_viewport_composition_layer_extension_property_defaults = "_GetViewportCompositionLayerExtensionPropertyDefaults";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_before_instance_created = "_OnBeforeInstanceCreated";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_instance_created = "_OnInstanceCreated";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_instance_destroyed = "_OnInstanceDestroyed";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_main_swapchains_created = "_OnMainSwapchainsCreated";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_pre_render = "_OnPreRender";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_process = "_OnProcess";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_register_metadata = "_OnRegisterMetadata";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_session_created = "_OnSessionCreated";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_session_destroyed = "_OnSessionDestroyed";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_state_exiting = "_OnStateExiting";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_state_focused = "_OnStateFocused";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_state_idle = "_OnStateIdle";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_state_loss_pending = "_OnStateLossPending";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_state_ready = "_OnStateReady";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_state_stopping = "_OnStateStopping";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_state_synchronized = "_OnStateSynchronized";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__on_state_visible = "_OnStateVisible";

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
        if ((method == MethodProxyName__get_composition_layer || method == MethodName._GetCompositionLayer) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_composition_layer.NativeValue))
        {
            var callRet = _GetCompositionLayer(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<ulong>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_composition_layer_count || method == MethodName._GetCompositionLayerCount) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_composition_layer_count.NativeValue))
        {
            var callRet = _GetCompositionLayerCount();
            ret = VariantUtils.CreateFrom<int>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_composition_layer_order || method == MethodName._GetCompositionLayerOrder) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_composition_layer_order.NativeValue))
        {
            var callRet = _GetCompositionLayerOrder(VariantUtils.ConvertTo<int>(args[0]));
            ret = VariantUtils.CreateFrom<int>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_requested_extensions || method == MethodName._GetRequestedExtensions) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_requested_extensions.NativeValue))
        {
            var callRet = _GetRequestedExtensions();
            ret = VariantUtils.CreateFrom<Godot.Collections.Dictionary>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_suggested_tracker_names || method == MethodName._GetSuggestedTrackerNames) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_suggested_tracker_names.NativeValue))
        {
            var callRet = _GetSuggestedTrackerNames();
            ret = VariantUtils.CreateFrom<string[]>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_viewport_composition_layer_extension_properties || method == MethodName._GetViewportCompositionLayerExtensionProperties) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_viewport_composition_layer_extension_properties.NativeValue))
        {
            var callRet = _GetViewportCompositionLayerExtensionProperties();
            ret = VariantUtils.CreateFromArray(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_viewport_composition_layer_extension_property_defaults || method == MethodName._GetViewportCompositionLayerExtensionPropertyDefaults) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_viewport_composition_layer_extension_property_defaults.NativeValue))
        {
            var callRet = _GetViewportCompositionLayerExtensionPropertyDefaults();
            ret = VariantUtils.CreateFrom<Godot.Collections.Dictionary>(callRet);
            return true;
        }
        if ((method == MethodProxyName__on_before_instance_created || method == MethodName._OnBeforeInstanceCreated) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_before_instance_created.NativeValue))
        {
            _OnBeforeInstanceCreated();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_instance_created || method == MethodName._OnInstanceCreated) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_instance_created.NativeValue))
        {
            _OnInstanceCreated(VariantUtils.ConvertTo<ulong>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_instance_destroyed || method == MethodName._OnInstanceDestroyed) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_instance_destroyed.NativeValue))
        {
            _OnInstanceDestroyed();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_main_swapchains_created || method == MethodName._OnMainSwapchainsCreated) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_main_swapchains_created.NativeValue))
        {
            _OnMainSwapchainsCreated();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_pre_render || method == MethodName._OnPreRender) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_pre_render.NativeValue))
        {
            _OnPreRender();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_process || method == MethodName._OnProcess) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_process.NativeValue))
        {
            _OnProcess();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_register_metadata || method == MethodName._OnRegisterMetadata) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_register_metadata.NativeValue))
        {
            _OnRegisterMetadata();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_session_created || method == MethodName._OnSessionCreated) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_session_created.NativeValue))
        {
            _OnSessionCreated(VariantUtils.ConvertTo<ulong>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_session_destroyed || method == MethodName._OnSessionDestroyed) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_session_destroyed.NativeValue))
        {
            _OnSessionDestroyed();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_state_exiting || method == MethodName._OnStateExiting) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_state_exiting.NativeValue))
        {
            _OnStateExiting();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_state_focused || method == MethodName._OnStateFocused) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_state_focused.NativeValue))
        {
            _OnStateFocused();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_state_idle || method == MethodName._OnStateIdle) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_state_idle.NativeValue))
        {
            _OnStateIdle();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_state_loss_pending || method == MethodName._OnStateLossPending) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_state_loss_pending.NativeValue))
        {
            _OnStateLossPending();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_state_ready || method == MethodName._OnStateReady) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_state_ready.NativeValue))
        {
            _OnStateReady();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_state_stopping || method == MethodName._OnStateStopping) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_state_stopping.NativeValue))
        {
            _OnStateStopping();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_state_synchronized || method == MethodName._OnStateSynchronized) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_state_synchronized.NativeValue))
        {
            _OnStateSynchronized();
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__on_state_visible || method == MethodName._OnStateVisible) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__on_state_visible.NativeValue))
        {
            _OnStateVisible();
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
        if (method == MethodName._GetCompositionLayer)
        {
            if (HasGodotClassMethod(MethodProxyName__get_composition_layer.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetCompositionLayerCount)
        {
            if (HasGodotClassMethod(MethodProxyName__get_composition_layer_count.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetCompositionLayerOrder)
        {
            if (HasGodotClassMethod(MethodProxyName__get_composition_layer_order.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetRequestedExtensions)
        {
            if (HasGodotClassMethod(MethodProxyName__get_requested_extensions.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetSuggestedTrackerNames)
        {
            if (HasGodotClassMethod(MethodProxyName__get_suggested_tracker_names.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetViewportCompositionLayerExtensionProperties)
        {
            if (HasGodotClassMethod(MethodProxyName__get_viewport_composition_layer_extension_properties.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetViewportCompositionLayerExtensionPropertyDefaults)
        {
            if (HasGodotClassMethod(MethodProxyName__get_viewport_composition_layer_extension_property_defaults.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnBeforeInstanceCreated)
        {
            if (HasGodotClassMethod(MethodProxyName__on_before_instance_created.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnInstanceCreated)
        {
            if (HasGodotClassMethod(MethodProxyName__on_instance_created.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnInstanceDestroyed)
        {
            if (HasGodotClassMethod(MethodProxyName__on_instance_destroyed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnMainSwapchainsCreated)
        {
            if (HasGodotClassMethod(MethodProxyName__on_main_swapchains_created.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnPreRender)
        {
            if (HasGodotClassMethod(MethodProxyName__on_pre_render.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnProcess)
        {
            if (HasGodotClassMethod(MethodProxyName__on_process.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnRegisterMetadata)
        {
            if (HasGodotClassMethod(MethodProxyName__on_register_metadata.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnSessionCreated)
        {
            if (HasGodotClassMethod(MethodProxyName__on_session_created.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnSessionDestroyed)
        {
            if (HasGodotClassMethod(MethodProxyName__on_session_destroyed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnStateExiting)
        {
            if (HasGodotClassMethod(MethodProxyName__on_state_exiting.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnStateFocused)
        {
            if (HasGodotClassMethod(MethodProxyName__on_state_focused.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnStateIdle)
        {
            if (HasGodotClassMethod(MethodProxyName__on_state_idle.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnStateLossPending)
        {
            if (HasGodotClassMethod(MethodProxyName__on_state_loss_pending.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnStateReady)
        {
            if (HasGodotClassMethod(MethodProxyName__on_state_ready.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnStateStopping)
        {
            if (HasGodotClassMethod(MethodProxyName__on_state_stopping.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnStateSynchronized)
        {
            if (HasGodotClassMethod(MethodProxyName__on_state_synchronized.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._OnStateVisible)
        {
            if (HasGodotClassMethod(MethodProxyName__on_state_visible.NativeValue.DangerousSelfRef))
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
    public new class PropertyName : GodotObject.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : GodotObject.MethodName
    {
        /// <summary>
        /// Cached name for the '_get_composition_layer' method.
        /// </summary>
        public static readonly StringName _GetCompositionLayer = "_get_composition_layer";
        /// <summary>
        /// Cached name for the '_get_composition_layer_count' method.
        /// </summary>
        public static readonly StringName _GetCompositionLayerCount = "_get_composition_layer_count";
        /// <summary>
        /// Cached name for the '_get_composition_layer_order' method.
        /// </summary>
        public static readonly StringName _GetCompositionLayerOrder = "_get_composition_layer_order";
        /// <summary>
        /// Cached name for the '_get_requested_extensions' method.
        /// </summary>
        public static readonly StringName _GetRequestedExtensions = "_get_requested_extensions";
        /// <summary>
        /// Cached name for the '_get_suggested_tracker_names' method.
        /// </summary>
        public static readonly StringName _GetSuggestedTrackerNames = "_get_suggested_tracker_names";
        /// <summary>
        /// Cached name for the '_get_viewport_composition_layer_extension_properties' method.
        /// </summary>
        public static readonly StringName _GetViewportCompositionLayerExtensionProperties = "_get_viewport_composition_layer_extension_properties";
        /// <summary>
        /// Cached name for the '_get_viewport_composition_layer_extension_property_defaults' method.
        /// </summary>
        public static readonly StringName _GetViewportCompositionLayerExtensionPropertyDefaults = "_get_viewport_composition_layer_extension_property_defaults";
        /// <summary>
        /// Cached name for the '_on_before_instance_created' method.
        /// </summary>
        public static readonly StringName _OnBeforeInstanceCreated = "_on_before_instance_created";
        /// <summary>
        /// Cached name for the '_on_instance_created' method.
        /// </summary>
        public static readonly StringName _OnInstanceCreated = "_on_instance_created";
        /// <summary>
        /// Cached name for the '_on_instance_destroyed' method.
        /// </summary>
        public static readonly StringName _OnInstanceDestroyed = "_on_instance_destroyed";
        /// <summary>
        /// Cached name for the '_on_main_swapchains_created' method.
        /// </summary>
        public static readonly StringName _OnMainSwapchainsCreated = "_on_main_swapchains_created";
        /// <summary>
        /// Cached name for the '_on_pre_render' method.
        /// </summary>
        public static readonly StringName _OnPreRender = "_on_pre_render";
        /// <summary>
        /// Cached name for the '_on_process' method.
        /// </summary>
        public static readonly StringName _OnProcess = "_on_process";
        /// <summary>
        /// Cached name for the '_on_register_metadata' method.
        /// </summary>
        public static readonly StringName _OnRegisterMetadata = "_on_register_metadata";
        /// <summary>
        /// Cached name for the '_on_session_created' method.
        /// </summary>
        public static readonly StringName _OnSessionCreated = "_on_session_created";
        /// <summary>
        /// Cached name for the '_on_session_destroyed' method.
        /// </summary>
        public static readonly StringName _OnSessionDestroyed = "_on_session_destroyed";
        /// <summary>
        /// Cached name for the '_on_state_exiting' method.
        /// </summary>
        public static readonly StringName _OnStateExiting = "_on_state_exiting";
        /// <summary>
        /// Cached name for the '_on_state_focused' method.
        /// </summary>
        public static readonly StringName _OnStateFocused = "_on_state_focused";
        /// <summary>
        /// Cached name for the '_on_state_idle' method.
        /// </summary>
        public static readonly StringName _OnStateIdle = "_on_state_idle";
        /// <summary>
        /// Cached name for the '_on_state_loss_pending' method.
        /// </summary>
        public static readonly StringName _OnStateLossPending = "_on_state_loss_pending";
        /// <summary>
        /// Cached name for the '_on_state_ready' method.
        /// </summary>
        public static readonly StringName _OnStateReady = "_on_state_ready";
        /// <summary>
        /// Cached name for the '_on_state_stopping' method.
        /// </summary>
        public static readonly StringName _OnStateStopping = "_on_state_stopping";
        /// <summary>
        /// Cached name for the '_on_state_synchronized' method.
        /// </summary>
        public static readonly StringName _OnStateSynchronized = "_on_state_synchronized";
        /// <summary>
        /// Cached name for the '_on_state_visible' method.
        /// </summary>
        public static readonly StringName _OnStateVisible = "_on_state_visible";
        /// <summary>
        /// Cached name for the 'get_openxr_api' method.
        /// </summary>
        public static readonly StringName GetOpenxrApi = "get_openxr_api";
        /// <summary>
        /// Cached name for the 'register_extension_wrapper' method.
        /// </summary>
        public static readonly StringName RegisterExtensionWrapper = "register_extension_wrapper";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
    }
}

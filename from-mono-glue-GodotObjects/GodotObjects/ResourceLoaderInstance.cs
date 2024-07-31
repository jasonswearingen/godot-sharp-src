namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>A singleton used to load resource files from the filesystem.</para>
/// <para>It uses the many <see cref="Godot.ResourceFormatLoader"/> classes registered in the engine (either built-in or from a plugin) to load files into memory and convert them to a format that can be used by the engine.</para>
/// <para><b>Note:</b> You have to import the files into the engine first to load them using <see cref="Godot.ResourceLoaderInstance.Load(string, string, ResourceLoader.CacheMode)"/>. If you want to load <see cref="Godot.Image"/>s at run-time, you may use <see cref="Godot.Image.Load(string)"/>. If you want to import audio files, you can use the snippet described in <see cref="Godot.AudioStreamMP3.Data"/>.</para>
/// </summary>
[GodotClassName("ResourceLoader")]
public partial class ResourceLoaderInstance : GodotObject
{
    private static readonly System.Type CachedType = typeof(ResourceLoaderInstance);

    private static readonly StringName NativeName = "ResourceLoader";

    internal ResourceLoaderInstance() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal ResourceLoaderInstance(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LoadThreadedRequest, 3614384323ul);

    /// <summary>
    /// <para>Loads the resource using threads. If <paramref name="useSubThreads"/> is <see langword="true"/>, multiple threads will be used to load the resource, which makes loading faster, but may affect the main thread (and thus cause game slowdowns).</para>
    /// <para>The <paramref name="cacheMode"/> property defines whether and how the cache should be used or updated when loading the resource. See <see cref="Godot.ResourceLoader.CacheMode"/> for details.</para>
    /// </summary>
    public Error LoadThreadedRequest(string path, string typeHint = "", bool useSubThreads = false, ResourceLoader.CacheMode cacheMode = (ResourceLoader.CacheMode)(1))
    {
        return (Error)NativeCalls.godot_icall_4_1068(MethodBind0, GodotObject.GetPtr(this), path, typeHint, useSubThreads.ToGodotBool(), (int)cacheMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LoadThreadedGetStatus, 4137685479ul);

    /// <summary>
    /// <para>Returns the status of a threaded loading operation started with <see cref="Godot.ResourceLoaderInstance.LoadThreadedRequest(string, string, bool, ResourceLoader.CacheMode)"/> for the resource at <paramref name="path"/>. See <see cref="Godot.ResourceLoader.ThreadLoadStatus"/> for possible return values.</para>
    /// <para>An array variable can optionally be passed via <paramref name="progress"/>, and will return a one-element array containing the percentage of completion of the threaded loading.</para>
    /// <para><b>Note:</b> The recommended way of using this method is to call it during different frames (e.g., in <see cref="Godot.Node._Process(double)"/>, instead of a loop).</para>
    /// </summary>
    public ResourceLoader.ThreadLoadStatus LoadThreadedGetStatus(string path, Godot.Collections.Array progress = null)
    {
        return (ResourceLoader.ThreadLoadStatus)NativeCalls.godot_icall_2_1069(MethodBind1, GodotObject.GetPtr(this), path, (godot_array)(progress ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LoadThreadedGet, 1748875256ul);

    /// <summary>
    /// <para>Returns the resource loaded by <see cref="Godot.ResourceLoaderInstance.LoadThreadedRequest(string, string, bool, ResourceLoader.CacheMode)"/>.</para>
    /// <para>If this is called before the loading thread is done (i.e. <see cref="Godot.ResourceLoaderInstance.LoadThreadedGetStatus(string, Godot.Collections.Array)"/> is not <see cref="Godot.ResourceLoader.ThreadLoadStatus.Loaded"/>), the calling thread will be blocked until the resource has finished loading. However, it's recommended to use <see cref="Godot.ResourceLoaderInstance.LoadThreadedGetStatus(string, Godot.Collections.Array)"/> to known when the load has actually completed.</para>
    /// </summary>
    public Resource LoadThreadedGet(string path)
    {
        return (Resource)NativeCalls.godot_icall_1_523(MethodBind2, GodotObject.GetPtr(this), path);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Load, 3358495409ul);

    /// <summary>
    /// <para>Loads a resource at the given <paramref name="path"/>, caching the result for further access.</para>
    /// <para>The registered <see cref="Godot.ResourceFormatLoader"/>s are queried sequentially to find the first one which can handle the file's extension, and then attempt loading. If loading fails, the remaining ResourceFormatLoaders are also attempted.</para>
    /// <para>An optional <paramref name="typeHint"/> can be used to further specify the <see cref="Godot.Resource"/> type that should be handled by the <see cref="Godot.ResourceFormatLoader"/>. Anything that inherits from <see cref="Godot.Resource"/> can be used as a type hint, for example <see cref="Godot.Image"/>.</para>
    /// <para>The <paramref name="cacheMode"/> property defines whether and how the cache should be used or updated when loading the resource. See <see cref="Godot.ResourceLoader.CacheMode"/> for details.</para>
    /// <para>Returns an empty resource if no <see cref="Godot.ResourceFormatLoader"/> could handle the file, and prints an error if no file is found at the specified path.</para>
    /// <para>GDScript has a simplified <c>@GDScript.load</c> built-in method which can be used in most situations, leaving the use of <see cref="Godot.ResourceLoader"/> for more advanced scenarios.</para>
    /// <para><b>Note:</b> If <c>ProjectSettings.editor/export/convert_text_resources_to_binary</c> is <see langword="true"/>, <c>@GDScript.load</c> will not be able to read converted files in an exported project. If you rely on run-time loading of files present within the PCK, set <c>ProjectSettings.editor/export/convert_text_resources_to_binary</c> to <see langword="false"/>.</para>
    /// <para><b>Note:</b> Relative paths will be prefixed with <c>"res://"</c> before loading, to avoid unexpected results make sure your paths are absolute.</para>
    /// </summary>
    public Resource Load(string path, string typeHint = "", ResourceLoader.CacheMode cacheMode = (ResourceLoader.CacheMode)(1))
    {
        return (Resource)NativeCalls.godot_icall_3_1070(MethodBind3, GodotObject.GetPtr(this), path, typeHint, (int)cacheMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRecognizedExtensionsForType, 3538744774ul);

    /// <summary>
    /// <para>Returns the list of recognized extensions for a resource type.</para>
    /// </summary>
    public string[] GetRecognizedExtensionsForType(string type)
    {
        return NativeCalls.godot_icall_1_296(MethodBind4, GodotObject.GetPtr(this), type);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddResourceFormatLoader, 2896595483ul);

    /// <summary>
    /// <para>Registers a new <see cref="Godot.ResourceFormatLoader"/>. The ResourceLoader will use the ResourceFormatLoader as described in <see cref="Godot.ResourceLoaderInstance.Load(string, string, ResourceLoader.CacheMode)"/>.</para>
    /// <para>This method is performed implicitly for ResourceFormatLoaders written in GDScript (see <see cref="Godot.ResourceFormatLoader"/> for more information).</para>
    /// </summary>
    public void AddResourceFormatLoader(ResourceFormatLoader formatLoader, bool atFront = false)
    {
        NativeCalls.godot_icall_2_441(MethodBind5, GodotObject.GetPtr(this), GodotObject.GetPtr(formatLoader), atFront.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RemoveResourceFormatLoader, 405397102ul);

    /// <summary>
    /// <para>Unregisters the given <see cref="Godot.ResourceFormatLoader"/>.</para>
    /// </summary>
    public void RemoveResourceFormatLoader(ResourceFormatLoader formatLoader)
    {
        NativeCalls.godot_icall_1_55(MethodBind6, GodotObject.GetPtr(this), GodotObject.GetPtr(formatLoader));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAbortOnMissingResources, 2586408642ul);

    /// <summary>
    /// <para>Changes the behavior on missing sub-resources. The default behavior is to abort loading.</para>
    /// </summary>
    public void SetAbortOnMissingResources(bool abort)
    {
        NativeCalls.godot_icall_1_41(MethodBind7, GodotObject.GetPtr(this), abort.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDependencies, 3538744774ul);

    /// <summary>
    /// <para>Returns the dependencies for the resource at the given <paramref name="path"/>.</para>
    /// <para><b>Note:</b> The dependencies are returned with slices separated by <c>::</c>. You can use <c>String.get_slice</c> to get their components.</para>
    /// <para><code>
    /// for dep in ResourceLoader.get_dependencies(path):
    ///     print(dep.get_slice("::", 0)) # Prints UID.
    ///     print(dep.get_slice("::", 2)) # Prints path.
    /// </code></para>
    /// </summary>
    public string[] GetDependencies(string path)
    {
        return NativeCalls.godot_icall_1_296(MethodBind8, GodotObject.GetPtr(this), path);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.HasCached, 2323990056ul);

    /// <summary>
    /// <para>Returns whether a cached resource is available for the given <paramref name="path"/>.</para>
    /// <para>Once a resource has been loaded by the engine, it is cached in memory for faster access, and future calls to the <see cref="Godot.ResourceLoaderInstance.Load(string, string, ResourceLoader.CacheMode)"/> method will use the cached version. The cached resource can be overridden by using <see cref="Godot.Resource.TakeOverPath(string)"/> on a new resource for that same path.</para>
    /// </summary>
    public bool HasCached(string path)
    {
        return NativeCalls.godot_icall_1_124(MethodBind9, GodotObject.GetPtr(this), path).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Exists, 4185558881ul);

    /// <summary>
    /// <para>Returns whether a recognized resource exists for the given <paramref name="path"/>.</para>
    /// <para>An optional <paramref name="typeHint"/> can be used to further specify the <see cref="Godot.Resource"/> type that should be handled by the <see cref="Godot.ResourceFormatLoader"/>. Anything that inherits from <see cref="Godot.Resource"/> can be used as a type hint, for example <see cref="Godot.Image"/>.</para>
    /// <para><b>Note:</b> If you use <see cref="Godot.Resource.TakeOverPath(string)"/>, this method will return <see langword="true"/> for the taken path even if the resource wasn't saved (i.e. exists only in resource cache).</para>
    /// </summary>
    public bool Exists(string path, string typeHint = "")
    {
        return NativeCalls.godot_icall_2_295(MethodBind10, GodotObject.GetPtr(this), path, typeHint).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetResourceUid, 1597066294ul);

    /// <summary>
    /// <para>Returns the ID associated with a given resource path, or <c>-1</c> when no such ID exists.</para>
    /// </summary>
    public long GetResourceUid(string path)
    {
        return NativeCalls.godot_icall_1_1071(MethodBind11, GodotObject.GetPtr(this), path);
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
    public new class PropertyName : GodotObject.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : GodotObject.MethodName
    {
        /// <summary>
        /// Cached name for the 'load_threaded_request' method.
        /// </summary>
        public static readonly StringName LoadThreadedRequest = "load_threaded_request";
        /// <summary>
        /// Cached name for the 'load_threaded_get_status' method.
        /// </summary>
        public static readonly StringName LoadThreadedGetStatus = "load_threaded_get_status";
        /// <summary>
        /// Cached name for the 'load_threaded_get' method.
        /// </summary>
        public static readonly StringName LoadThreadedGet = "load_threaded_get";
        /// <summary>
        /// Cached name for the 'load' method.
        /// </summary>
        public static readonly StringName Load = "load";
        /// <summary>
        /// Cached name for the 'get_recognized_extensions_for_type' method.
        /// </summary>
        public static readonly StringName GetRecognizedExtensionsForType = "get_recognized_extensions_for_type";
        /// <summary>
        /// Cached name for the 'add_resource_format_loader' method.
        /// </summary>
        public static readonly StringName AddResourceFormatLoader = "add_resource_format_loader";
        /// <summary>
        /// Cached name for the 'remove_resource_format_loader' method.
        /// </summary>
        public static readonly StringName RemoveResourceFormatLoader = "remove_resource_format_loader";
        /// <summary>
        /// Cached name for the 'set_abort_on_missing_resources' method.
        /// </summary>
        public static readonly StringName SetAbortOnMissingResources = "set_abort_on_missing_resources";
        /// <summary>
        /// Cached name for the 'get_dependencies' method.
        /// </summary>
        public static readonly StringName GetDependencies = "get_dependencies";
        /// <summary>
        /// Cached name for the 'has_cached' method.
        /// </summary>
        public static readonly StringName HasCached = "has_cached";
        /// <summary>
        /// Cached name for the 'exists' method.
        /// </summary>
        public static readonly StringName Exists = "exists";
        /// <summary>
        /// Cached name for the 'get_resource_uid' method.
        /// </summary>
        public static readonly StringName GetResourceUid = "get_resource_uid";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
    }
}

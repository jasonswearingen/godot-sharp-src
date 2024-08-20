namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.EditorSceneFormatImporter"/> allows to define an importer script for a third-party 3D format.</para>
/// <para>To use <see cref="Godot.EditorSceneFormatImporter"/>, register it using the <see cref="Godot.EditorPlugin.AddSceneFormatImporterPlugin(EditorSceneFormatImporter, bool)"/> method first.</para>
/// </summary>
public partial class EditorSceneFormatImporter : RefCounted
{
    public const long ImportScene = 1;
    public const long ImportAnimation = 2;
    public const long ImportFailOnMissingDependencies = 4;
    public const long ImportGenerateTangentArrays = 8;
    public const long ImportUseNamedSkinBinds = 16;
    public const long ImportDiscardMeshesAndMaterials = 32;
    public const long ImportForceDisableMeshCompression = 64;

    private static readonly System.Type CachedType = typeof(EditorSceneFormatImporter);

    private static readonly StringName NativeName = "EditorSceneFormatImporter";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public EditorSceneFormatImporter() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal EditorSceneFormatImporter(bool memoryOwn) : base(memoryOwn) { }

    public virtual string[] _GetExtensions()
    {
        return default;
    }

    public virtual uint _GetImportFlags()
    {
        return default;
    }

    public virtual void _GetImportOptions(string path)
    {
    }

    public virtual Variant _GetOptionVisibility(string path, bool forAnimation, string option)
    {
        return default;
    }

    public virtual GodotObject _ImportScene(string path, uint flags, Godot.Collections.Dictionary options)
    {
        return default;
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_extensions = "_GetExtensions";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_import_flags = "_GetImportFlags";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_import_options = "_GetImportOptions";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__get_option_visibility = "_GetOptionVisibility";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__import_scene = "_ImportScene";

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
        if ((method == MethodProxyName__get_extensions || method == MethodName._GetExtensions) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_extensions.NativeValue))
        {
            var callRet = _GetExtensions();
            ret = VariantUtils.CreateFrom<string[]>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_import_flags || method == MethodName._GetImportFlags) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_import_flags.NativeValue))
        {
            var callRet = _GetImportFlags();
            ret = VariantUtils.CreateFrom<uint>(callRet);
            return true;
        }
        if ((method == MethodProxyName__get_import_options || method == MethodName._GetImportOptions) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_import_options.NativeValue))
        {
            _GetImportOptions(VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__get_option_visibility || method == MethodName._GetOptionVisibility) && args.Count == 3 && HasGodotClassMethod((godot_string_name)MethodProxyName__get_option_visibility.NativeValue))
        {
            var callRet = _GetOptionVisibility(VariantUtils.ConvertTo<string>(args[0]), VariantUtils.ConvertTo<bool>(args[1]), VariantUtils.ConvertTo<string>(args[2]));
            ret = VariantUtils.CreateFrom<Variant>(callRet);
            return true;
        }
        if ((method == MethodProxyName__import_scene || method == MethodName._ImportScene) && args.Count == 3 && HasGodotClassMethod((godot_string_name)MethodProxyName__import_scene.NativeValue))
        {
            var callRet = _ImportScene(VariantUtils.ConvertTo<string>(args[0]), VariantUtils.ConvertTo<uint>(args[1]), VariantUtils.ConvertTo<Godot.Collections.Dictionary>(args[2]));
            ret = VariantUtils.CreateFrom<GodotObject>(callRet);
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
        if (method == MethodName._GetExtensions)
        {
            if (HasGodotClassMethod(MethodProxyName__get_extensions.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetImportFlags)
        {
            if (HasGodotClassMethod(MethodProxyName__get_import_flags.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetImportOptions)
        {
            if (HasGodotClassMethod(MethodProxyName__get_import_options.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._GetOptionVisibility)
        {
            if (HasGodotClassMethod(MethodProxyName__get_option_visibility.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._ImportScene)
        {
            if (HasGodotClassMethod(MethodProxyName__import_scene.NativeValue.DangerousSelfRef))
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
        /// Cached name for the '_get_extensions' method.
        /// </summary>
        public static readonly StringName _GetExtensions = "_get_extensions";
        /// <summary>
        /// Cached name for the '_get_import_flags' method.
        /// </summary>
        public static readonly StringName _GetImportFlags = "_get_import_flags";
        /// <summary>
        /// Cached name for the '_get_import_options' method.
        /// </summary>
        public static readonly StringName _GetImportOptions = "_get_import_options";
        /// <summary>
        /// Cached name for the '_get_option_visibility' method.
        /// </summary>
        public static readonly StringName _GetOptionVisibility = "_get_option_visibility";
        /// <summary>
        /// Cached name for the '_import_scene' method.
        /// </summary>
        public static readonly StringName _ImportScene = "_import_scene";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : RefCounted.SignalName
    {
    }
}

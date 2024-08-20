namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Stores variables that can be accessed from everywhere. Use <see cref="Godot.ProjectSettingsInstance.GetSetting(string, Variant)"/>, <see cref="Godot.ProjectSettingsInstance.SetSetting(string, Variant)"/> or <see cref="Godot.ProjectSettingsInstance.HasSetting(string)"/> to access them. Variables stored in <c>project.godot</c> are also loaded into <see cref="Godot.ProjectSettings"/>, making this object very useful for reading custom game configuration options.</para>
/// <para>When naming a Project Settings property, use the full path to the setting including the category. For example, <c>"application/config/name"</c> for the project name. Category and property names can be viewed in the Project Settings dialog.</para>
/// <para><b>Feature tags:</b> Project settings can be overridden for specific platforms and configurations (debug, release, ...) using <a href="$DOCS_URL/tutorials/export/feature_tags.html">feature tags</a>.</para>
/// <para><b>Overriding:</b> Any project setting can be overridden by creating a file named <c>override.cfg</c> in the project's root directory. This can also be used in exported projects by placing this file in the same directory as the project binary. Overriding will still take the base project settings' <a href="$DOCS_URL/tutorials/export/feature_tags.html">feature tags</a> in account. Therefore, make sure to <i>also</i> override the setting with the desired feature tags if you want them to override base project settings on all platforms and configurations.</para>
/// </summary>
[GodotClassName("ProjectSettings")]
public partial class ProjectSettingsInstance : GodotObject
{
    private static readonly System.Type CachedType = typeof(ProjectSettingsInstance);

    private static readonly StringName NativeName = "ProjectSettings";

    internal ProjectSettingsInstance() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal ProjectSettingsInstance(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.HasSetting, 3927539163ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if a configuration value is present.</para>
    /// </summary>
    public bool HasSetting(string name)
    {
        return NativeCalls.godot_icall_1_124(MethodBind0, GodotObject.GetPtr(this), name).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSetting, 402577236ul);

    /// <summary>
    /// <para>Sets the value of a setting.</para>
    /// <para><b>Example:</b></para>
    /// <para><code>
    /// ProjectSettings.SetSetting("application/config/name", "Example");
    /// </code></para>
    /// <para>This can also be used to erase custom project settings. To do this change the setting value to <see langword="null"/>.</para>
    /// </summary>
    public void SetSetting(string name, Variant value)
    {
        NativeCalls.godot_icall_2_446(MethodBind1, GodotObject.GetPtr(this), name, value);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSetting, 223050753ul);

    /// <summary>
    /// <para>Returns the value of the setting identified by <paramref name="name"/>. If the setting doesn't exist and <paramref name="defaultValue"/> is specified, the value of <paramref name="defaultValue"/> is returned. Otherwise, <see langword="null"/> is returned.</para>
    /// <para><b>Example:</b></para>
    /// <para><code>
    /// GD.Print(ProjectSettings.GetSetting("application/config/name"));
    /// GD.Print(ProjectSettings.GetSetting("application/config/custom_description", "No description specified."));
    /// </code></para>
    /// <para><b>Note:</b> This method doesn't take potential feature overrides into account automatically. Use <see cref="Godot.ProjectSettingsInstance.GetSettingWithOverride(StringName)"/> to handle seamlessly.</para>
    /// </summary>
    public Variant GetSetting(string name, Variant defaultValue = default)
    {
        return NativeCalls.godot_icall_2_883(MethodBind2, GodotObject.GetPtr(this), name, defaultValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSettingWithOverride, 2760726917ul);

    /// <summary>
    /// <para>Similar to <see cref="Godot.ProjectSettingsInstance.GetSetting(string, Variant)"/>, but applies feature tag overrides if any exists and is valid.</para>
    /// <para><b>Example:</b></para>
    /// <para>If the following setting override exists "application/config/name.windows", and the following code is executed:</para>
    /// <para><code>
    /// GD.Print(ProjectSettings.GetSettingWithOverride("application/config/name"));
    /// </code></para>
    /// <para>Then the overridden setting will be returned instead if the project is running on the <i>Windows</i> operating system.</para>
    /// </summary>
    public Variant GetSettingWithOverride(StringName name)
    {
        return NativeCalls.godot_icall_1_135(MethodBind3, GodotObject.GetPtr(this), (godot_string_name)(name?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGlobalClassList, 2915620761ul);

    /// <summary>
    /// <para>Returns an <see cref="Godot.Collections.Array"/> of registered global classes. Each global class is represented as a <see cref="Godot.Collections.Dictionary"/> that contains the following entries:</para>
    /// <para>- <c>base</c> is a name of the base class;</para>
    /// <para>- <c>class</c> is a name of the registered global class;</para>
    /// <para>- <c>icon</c> is a path to a custom icon of the global class, if it has any;</para>
    /// <para>- <c>language</c> is a name of a programming language in which the global class is written;</para>
    /// <para>- <c>path</c> is a path to a file containing the global class.</para>
    /// <para><b>Note:</b> Both the script and the icon paths are local to the project filesystem, i.e. they start with <c>res://</c>.</para>
    /// </summary>
    public Godot.Collections.Array<Godot.Collections.Dictionary> GetGlobalClassList()
    {
        return new Godot.Collections.Array<Godot.Collections.Dictionary>(NativeCalls.godot_icall_0_112(MethodBind4, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOrder, 2956805083ul);

    /// <summary>
    /// <para>Sets the order of a configuration value (influences when saved to the config file).</para>
    /// </summary>
    public void SetOrder(string name, int position)
    {
        NativeCalls.godot_icall_2_367(MethodBind5, GodotObject.GetPtr(this), name, position);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOrder, 1321353865ul);

    /// <summary>
    /// <para>Returns the order of a configuration value (influences when saved to the config file).</para>
    /// </summary>
    public int GetOrder(string name)
    {
        return NativeCalls.godot_icall_1_127(MethodBind6, GodotObject.GetPtr(this), name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetInitialValue, 402577236ul);

    /// <summary>
    /// <para>Sets the specified setting's initial value. This is the value the setting reverts to.</para>
    /// </summary>
    public void SetInitialValue(string name, Variant value)
    {
        NativeCalls.godot_icall_2_446(MethodBind7, GodotObject.GetPtr(this), name, value);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAsBasic, 2678287736ul);

    /// <summary>
    /// <para>Defines if the specified setting is considered basic or advanced. Basic settings will always be shown in the project settings. Advanced settings will only be shown if the user enables the "Advanced Settings" option.</para>
    /// </summary>
    public void SetAsBasic(string name, bool basic)
    {
        NativeCalls.godot_icall_2_420(MethodBind8, GodotObject.GetPtr(this), name, basic.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAsInternal, 2678287736ul);

    /// <summary>
    /// <para>Defines if the specified setting is considered internal. An internal setting won't show up in the Project Settings dialog. This is mostly useful for addons that need to store their own internal settings without exposing them directly to the user.</para>
    /// </summary>
    public void SetAsInternal(string name, bool @internal)
    {
        NativeCalls.godot_icall_2_420(MethodBind9, GodotObject.GetPtr(this), name, @internal.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddPropertyInfo, 4155329257ul);

    /// <summary>
    /// <para>Adds a custom property info to a property. The dictionary must contain:</para>
    /// <para>- <c>"name"</c>: <see cref="string"/> (the property's name)</para>
    /// <para>- <c>"type"</c>: <see cref="int"/> (see <see cref="Godot.Variant.Type"/>)</para>
    /// <para>- optionally <c>"hint"</c>: <see cref="int"/> (see <see cref="Godot.PropertyHint"/>) and <c>"hint_string"</c>: <see cref="string"/></para>
    /// <para><b>Example:</b></para>
    /// <para><code>
    /// ProjectSettings.Singleton.Set("category/property_name", 0);
    /// 
    /// var propertyInfo = new Godot.Collections.Dictionary
    /// {
    ///     {"name", "category/propertyName"},
    ///     {"type", (int)Variant.Type.Int},
    ///     {"hint", (int)PropertyHint.Enum},
    ///     {"hint_string", "one,two,three"},
    /// };
    /// 
    /// ProjectSettings.AddPropertyInfo(propertyInfo);
    /// </code></para>
    /// </summary>
    public void AddPropertyInfo(Godot.Collections.Dictionary hint)
    {
        NativeCalls.godot_icall_1_113(MethodBind10, GodotObject.GetPtr(this), (godot_dictionary)(hint ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRestartIfChanged, 2678287736ul);

    /// <summary>
    /// <para>Sets whether a setting requires restarting the editor to properly take effect.</para>
    /// <para><b>Note:</b> This is just a hint to display to the user that the editor must be restarted for changes to take effect. Enabling <see cref="Godot.ProjectSettingsInstance.SetRestartIfChanged(string, bool)"/> does <i>not</i> delay the setting being set when changed.</para>
    /// </summary>
    public void SetRestartIfChanged(string name, bool restart)
    {
        NativeCalls.godot_icall_2_420(MethodBind11, GodotObject.GetPtr(this), name, restart.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Clear, 83702148ul);

    /// <summary>
    /// <para>Clears the whole configuration (not recommended, may break things).</para>
    /// </summary>
    public void Clear(string name)
    {
        NativeCalls.godot_icall_1_56(MethodBind12, GodotObject.GetPtr(this), name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LocalizePath, 3135753539ul);

    /// <summary>
    /// <para>Returns the localized path (starting with <c>res://</c>) corresponding to the absolute, native OS <paramref name="path"/>. See also <see cref="Godot.ProjectSettingsInstance.GlobalizePath(string)"/>.</para>
    /// </summary>
    public string LocalizePath(string path)
    {
        return NativeCalls.godot_icall_1_271(MethodBind13, GodotObject.GetPtr(this), path);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalizePath, 3135753539ul);

    /// <summary>
    /// <para>Returns the absolute, native OS path corresponding to the localized <paramref name="path"/> (starting with <c>res://</c> or <c>user://</c>). The returned path will vary depending on the operating system and user preferences. See <a href="$DOCS_URL/tutorials/io/data_paths.html">File paths in Godot projects</a> to see what those paths convert to. See also <see cref="Godot.ProjectSettingsInstance.LocalizePath(string)"/>.</para>
    /// <para><b>Note:</b> <see cref="Godot.ProjectSettingsInstance.GlobalizePath(string)"/> with <c>res://</c> will not work in an exported project. Instead, prepend the executable's base directory to the path when running from an exported project:</para>
    /// <para><code>
    /// var path = ""
    /// if OS.has_feature("editor"):
    ///     # Running from an editor binary.
    ///     # `path` will contain the absolute path to `hello.txt` located in the project root.
    ///     path = ProjectSettings.globalize_path("res://hello.txt")
    /// else:
    ///     # Running from an exported project.
    ///     # `path` will contain the absolute path to `hello.txt` next to the executable.
    ///     # This is *not* identical to using `ProjectSettings.globalize_path()` with a `res://` path,
    ///     # but is close enough in spirit.
    ///     path = OS.get_executable_path().get_base_dir().path_join("hello.txt")
    /// </code></para>
    /// </summary>
    public string GlobalizePath(string path)
    {
        return NativeCalls.godot_icall_1_271(MethodBind14, GodotObject.GetPtr(this), path);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Save, 166280745ul);

    /// <summary>
    /// <para>Saves the configuration to the <c>project.godot</c> file.</para>
    /// <para><b>Note:</b> This method is intended to be used by editor plugins, as modified <see cref="Godot.ProjectSettings"/> can't be loaded back in the running app. If you want to change project settings in exported projects, use <see cref="Godot.ProjectSettingsInstance.SaveCustom(string)"/> to save <c>override.cfg</c> file.</para>
    /// </summary>
    public Error Save()
    {
        return (Error)NativeCalls.godot_icall_0_37(MethodBind15, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LoadResourcePack, 708980503ul);

    /// <summary>
    /// <para>Loads the contents of the .pck or .zip file specified by <paramref name="pack"/> into the resource filesystem (<c>res://</c>). Returns <see langword="true"/> on success.</para>
    /// <para><b>Note:</b> If a file from <paramref name="pack"/> shares the same path as a file already in the resource filesystem, any attempts to load that file will use the file from <paramref name="pack"/> unless <paramref name="replaceFiles"/> is set to <see langword="false"/>.</para>
    /// <para><b>Note:</b> The optional <paramref name="offset"/> parameter can be used to specify the offset in bytes to the start of the resource pack. This is only supported for .pck files.</para>
    /// </summary>
    public bool LoadResourcePack(string pack, bool replaceFiles = true, int offset = 0)
    {
        return NativeCalls.godot_icall_3_884(MethodBind16, GodotObject.GetPtr(this), pack, replaceFiles.ToGodotBool(), offset).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SaveCustom, 166001499ul);

    /// <summary>
    /// <para>Saves the configuration to a custom file. The file extension must be <c>.godot</c> (to save in text-based <see cref="Godot.ConfigFile"/> format) or <c>.binary</c> (to save in binary format). You can also save <c>override.cfg</c> file, which is also text, but can be used in exported projects unlike other formats.</para>
    /// </summary>
    public Error SaveCustom(string file)
    {
        return (Error)NativeCalls.godot_icall_1_127(MethodBind17, GodotObject.GetPtr(this), file);
    }

    /// <summary>
    /// <para>Emitted when any setting is changed, up to once per process frame.</para>
    /// </summary>
    public event Action SettingsChanged
    {
        add => Connect(SignalName.SettingsChanged, Callable.From(value));
        remove => Disconnect(SignalName.SettingsChanged, Callable.From(value));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_settings_changed = "SettingsChanged";

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
        if (signal == SignalName.SettingsChanged)
        {
            if (HasGodotClassSignal(SignalProxyName_settings_changed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
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
        /// Cached name for the 'has_setting' method.
        /// </summary>
        public static readonly StringName HasSetting = "has_setting";
        /// <summary>
        /// Cached name for the 'set_setting' method.
        /// </summary>
        public static readonly StringName SetSetting = "set_setting";
        /// <summary>
        /// Cached name for the 'get_setting' method.
        /// </summary>
        public static readonly StringName GetSetting = "get_setting";
        /// <summary>
        /// Cached name for the 'get_setting_with_override' method.
        /// </summary>
        public static readonly StringName GetSettingWithOverride = "get_setting_with_override";
        /// <summary>
        /// Cached name for the 'get_global_class_list' method.
        /// </summary>
        public static readonly StringName GetGlobalClassList = "get_global_class_list";
        /// <summary>
        /// Cached name for the 'set_order' method.
        /// </summary>
        public static readonly StringName SetOrder = "set_order";
        /// <summary>
        /// Cached name for the 'get_order' method.
        /// </summary>
        public static readonly StringName GetOrder = "get_order";
        /// <summary>
        /// Cached name for the 'set_initial_value' method.
        /// </summary>
        public static readonly StringName SetInitialValue = "set_initial_value";
        /// <summary>
        /// Cached name for the 'set_as_basic' method.
        /// </summary>
        public static readonly StringName SetAsBasic = "set_as_basic";
        /// <summary>
        /// Cached name for the 'set_as_internal' method.
        /// </summary>
        public static readonly StringName SetAsInternal = "set_as_internal";
        /// <summary>
        /// Cached name for the 'add_property_info' method.
        /// </summary>
        public static readonly StringName AddPropertyInfo = "add_property_info";
        /// <summary>
        /// Cached name for the 'set_restart_if_changed' method.
        /// </summary>
        public static readonly StringName SetRestartIfChanged = "set_restart_if_changed";
        /// <summary>
        /// Cached name for the 'clear' method.
        /// </summary>
        public static readonly StringName Clear = "clear";
        /// <summary>
        /// Cached name for the 'localize_path' method.
        /// </summary>
        public static readonly StringName LocalizePath = "localize_path";
        /// <summary>
        /// Cached name for the 'globalize_path' method.
        /// </summary>
        public static readonly StringName GlobalizePath = "globalize_path";
        /// <summary>
        /// Cached name for the 'save' method.
        /// </summary>
        public static readonly StringName Save = "save";
        /// <summary>
        /// Cached name for the 'load_resource_pack' method.
        /// </summary>
        public static readonly StringName LoadResourcePack = "load_resource_pack";
        /// <summary>
        /// Cached name for the 'save_custom' method.
        /// </summary>
        public static readonly StringName SaveCustom = "save_custom";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
        /// <summary>
        /// Cached name for the 'settings_changed' signal.
        /// </summary>
        public static readonly StringName SettingsChanged = "settings_changed";
    }
}

namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Object that holds the project-independent editor settings. These settings are generally visible in the <b>Editor &gt; Editor Settings</b> menu.</para>
/// <para>Property names use slash delimiters to distinguish sections. Setting values can be of any <see cref="Godot.Variant"/> type. It's recommended to use <c>snake_case</c> for editor settings to be consistent with the Godot editor itself.</para>
/// <para>Accessing the settings can be done using the following methods, such as:</para>
/// <para><code>
/// EditorSettings settings = EditorInterface.Singleton.GetEditorSettings();
/// // `settings.set("some/property", value)` also works as this class overrides `_set()` internally.
/// settings.SetSetting("some/property", Value);
/// // `settings.get("some/property", value)` also works as this class overrides `_get()` internally.
/// settings.GetSetting("some/property");
/// Godot.Collections.Array&lt;Godot.Collections.Dictionary&gt; listOfSettings = settings.GetPropertyList();
/// </code></para>
/// <para><b>Note:</b> This class shouldn't be instantiated directly. Instead, access the singleton using <see cref="Godot.EditorInterface.GetEditorSettings()"/>.</para>
/// </summary>
public partial class EditorSettings : Resource
{
    /// <summary>
    /// <para>Emitted after any editor setting has changed. It's used by various editor plugins to update their visuals on theme changes or logic on configuration changes.</para>
    /// </summary>
    public const long NotificationEditorSettingsChanged = 10000;

    private static readonly System.Type CachedType = typeof(EditorSettings);

    private static readonly StringName NativeName = "EditorSettings";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public EditorSettings() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal EditorSettings(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.HasSetting, 3927539163ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the setting specified by <paramref name="name"/> exists, <see langword="false"/> otherwise.</para>
    /// </summary>
    public bool HasSetting(string name)
    {
        return NativeCalls.godot_icall_1_124(MethodBind0, GodotObject.GetPtr(this), name).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSetting, 402577236ul);

    /// <summary>
    /// <para>Sets the <paramref name="value"/> of the setting specified by <paramref name="name"/>. This is equivalent to using <see cref="Godot.GodotObject.Set(StringName, Variant)"/> on the EditorSettings instance.</para>
    /// </summary>
    public void SetSetting(string name, Variant value)
    {
        NativeCalls.godot_icall_2_446(MethodBind1, GodotObject.GetPtr(this), name, value);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSetting, 1868160156ul);

    /// <summary>
    /// <para>Returns the value of the setting specified by <paramref name="name"/>. This is equivalent to using <see cref="Godot.GodotObject.Get(StringName)"/> on the EditorSettings instance.</para>
    /// </summary>
    public Variant GetSetting(string name)
    {
        return NativeCalls.godot_icall_1_448(MethodBind2, GodotObject.GetPtr(this), name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Erase, 83702148ul);

    /// <summary>
    /// <para>Erases the setting whose name is specified by <paramref name="property"/>.</para>
    /// </summary>
    public void Erase(string property)
    {
        NativeCalls.godot_icall_1_56(MethodBind3, GodotObject.GetPtr(this), property);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetInitialValue, 1529169264ul);

    /// <summary>
    /// <para>Sets the initial value of the setting specified by <paramref name="name"/> to <paramref name="value"/>. This is used to provide a value for the Revert button in the Editor Settings. If <paramref name="updateCurrent"/> is true, the current value of the setting will be set to <paramref name="value"/> as well.</para>
    /// </summary>
    public void SetInitialValue(StringName name, Variant value, bool updateCurrent)
    {
        EditorNativeCalls.godot_icall_3_449(MethodBind4, GodotObject.GetPtr(this), (godot_string_name)(name?.NativeValue ?? default), value, updateCurrent.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddPropertyInfo, 4155329257ul);

    /// <summary>
    /// <para>Adds a custom property info to a property. The dictionary must contain:</para>
    /// <para>- <c>name</c>: <see cref="string"/> (the name of the property)</para>
    /// <para>- <c>type</c>: <see cref="int"/> (see <see cref="Godot.Variant.Type"/>)</para>
    /// <para>- optionally <c>hint</c>: <see cref="int"/> (see <see cref="Godot.PropertyHint"/>) and <c>hint_string</c>: <see cref="string"/></para>
    /// <para><b>Example:</b></para>
    /// <para><code>
    /// var settings = GetEditorInterface().GetEditorSettings();
    /// settings.Set("category/property_name", 0);
    /// 
    /// var propertyInfo = new Godot.Collections.Dictionary
    /// {
    ///     {"name", "category/propertyName"},
    ///     {"type", Variant.Type.Int},
    ///     {"hint", PropertyHint.Enum},
    ///     {"hint_string", "one,two,three"}
    /// };
    /// 
    /// settings.AddPropertyInfo(propertyInfo);
    /// </code></para>
    /// </summary>
    public void AddPropertyInfo(Godot.Collections.Dictionary info)
    {
        NativeCalls.godot_icall_1_113(MethodBind5, GodotObject.GetPtr(this), (godot_dictionary)(info ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetProjectMetadata, 2504492430ul);

    /// <summary>
    /// <para>Sets project-specific metadata with the <paramref name="section"/>, <paramref name="key"/> and <paramref name="data"/> specified. This metadata is stored outside the project folder and therefore won't be checked into version control. See also <see cref="Godot.EditorSettings.GetProjectMetadata(string, string, Variant)"/>.</para>
    /// </summary>
    public void SetProjectMetadata(string section, string key, Variant data)
    {
        NativeCalls.godot_icall_3_293(MethodBind6, GodotObject.GetPtr(this), section, key, data);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetProjectMetadata, 89809366ul);

    /// <summary>
    /// <para>Returns project-specific metadata for the <paramref name="section"/> and <paramref name="key"/> specified. If the metadata doesn't exist, <paramref name="default"/> will be returned instead. See also <see cref="Godot.EditorSettings.SetProjectMetadata(string, string, Variant)"/>.</para>
    /// </summary>
    public Variant GetProjectMetadata(string section, string key, Variant @default = default)
    {
        return NativeCalls.godot_icall_3_294(MethodBind7, GodotObject.GetPtr(this), section, key, @default);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFavorites, 4015028928ul);

    /// <summary>
    /// <para>Sets the list of favorite files and directories for this project.</para>
    /// </summary>
    public void SetFavorites(string[] dirs)
    {
        NativeCalls.godot_icall_1_171(MethodBind8, GodotObject.GetPtr(this), dirs);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFavorites, 1139954409ul);

    /// <summary>
    /// <para>Returns the list of favorite files and directories for this project.</para>
    /// </summary>
    public string[] GetFavorites()
    {
        return NativeCalls.godot_icall_0_115(MethodBind9, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRecentDirs, 4015028928ul);

    /// <summary>
    /// <para>Sets the list of recently visited folders in the file dialog for this project.</para>
    /// </summary>
    public void SetRecentDirs(string[] dirs)
    {
        NativeCalls.godot_icall_1_171(MethodBind10, GodotObject.GetPtr(this), dirs);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRecentDirs, 1139954409ul);

    /// <summary>
    /// <para>Returns the list of recently visited folders in the file dialog for this project.</para>
    /// </summary>
    public string[] GetRecentDirs()
    {
        return NativeCalls.godot_icall_0_115(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBuiltinActionOverride, 1209351045ul);

    /// <summary>
    /// <para>Overrides the built-in editor action <paramref name="name"/> with the input actions defined in <paramref name="actionsList"/>.</para>
    /// </summary>
    public void SetBuiltinActionOverride(string name, Godot.Collections.Array<InputEvent> actionsList)
    {
        NativeCalls.godot_icall_2_406(MethodBind12, GodotObject.GetPtr(this), name, (godot_array)(actionsList ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CheckChangedSettingsInGroup, 3927539163ul);

    /// <summary>
    /// <para>Checks if any settings with the prefix <paramref name="settingPrefix"/> exist in the set of changed settings. See also <see cref="Godot.EditorSettings.GetChangedSettings()"/>.</para>
    /// </summary>
    public bool CheckChangedSettingsInGroup(string settingPrefix)
    {
        return NativeCalls.godot_icall_1_124(MethodBind13, GodotObject.GetPtr(this), settingPrefix).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetChangedSettings, 1139954409ul);

    /// <summary>
    /// <para>Gets an array of the settings which have been changed since the last save. Note that internally <c>changed_settings</c> is cleared after a successful save, so generally the most appropriate place to use this method is when processing <see cref="Godot.EditorSettings.NotificationEditorSettingsChanged"/>.</para>
    /// </summary>
    public string[] GetChangedSettings()
    {
        return NativeCalls.godot_icall_0_115(MethodBind14, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.MarkSettingChanged, 83702148ul);

    /// <summary>
    /// <para>Marks the passed editor setting as being changed, see <see cref="Godot.EditorSettings.GetChangedSettings()"/>. Only settings which exist (see <see cref="Godot.EditorSettings.HasSetting(string)"/>) will be accepted.</para>
    /// </summary>
    public void MarkSettingChanged(string setting)
    {
        NativeCalls.godot_icall_1_56(MethodBind15, GodotObject.GetPtr(this), setting);
    }

    /// <summary>
    /// <para>Emitted after any editor setting has changed.</para>
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
    public new class PropertyName : Resource.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Resource.MethodName
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
        /// Cached name for the 'erase' method.
        /// </summary>
        public static readonly StringName Erase = "erase";
        /// <summary>
        /// Cached name for the 'set_initial_value' method.
        /// </summary>
        public static readonly StringName SetInitialValue = "set_initial_value";
        /// <summary>
        /// Cached name for the 'add_property_info' method.
        /// </summary>
        public static readonly StringName AddPropertyInfo = "add_property_info";
        /// <summary>
        /// Cached name for the 'set_project_metadata' method.
        /// </summary>
        public static readonly StringName SetProjectMetadata = "set_project_metadata";
        /// <summary>
        /// Cached name for the 'get_project_metadata' method.
        /// </summary>
        public static readonly StringName GetProjectMetadata = "get_project_metadata";
        /// <summary>
        /// Cached name for the 'set_favorites' method.
        /// </summary>
        public static readonly StringName SetFavorites = "set_favorites";
        /// <summary>
        /// Cached name for the 'get_favorites' method.
        /// </summary>
        public static readonly StringName GetFavorites = "get_favorites";
        /// <summary>
        /// Cached name for the 'set_recent_dirs' method.
        /// </summary>
        public static readonly StringName SetRecentDirs = "set_recent_dirs";
        /// <summary>
        /// Cached name for the 'get_recent_dirs' method.
        /// </summary>
        public static readonly StringName GetRecentDirs = "get_recent_dirs";
        /// <summary>
        /// Cached name for the 'set_builtin_action_override' method.
        /// </summary>
        public static readonly StringName SetBuiltinActionOverride = "set_builtin_action_override";
        /// <summary>
        /// Cached name for the 'check_changed_settings_in_group' method.
        /// </summary>
        public static readonly StringName CheckChangedSettingsInGroup = "check_changed_settings_in_group";
        /// <summary>
        /// Cached name for the 'get_changed_settings' method.
        /// </summary>
        public static readonly StringName GetChangedSettings = "get_changed_settings";
        /// <summary>
        /// Cached name for the 'mark_setting_changed' method.
        /// </summary>
        public static readonly StringName MarkSettingChanged = "mark_setting_changed";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Resource.SignalName
    {
        /// <summary>
        /// Cached name for the 'settings_changed' signal.
        /// </summary>
        public static readonly StringName SettingsChanged = "settings_changed";
    }
}

namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>The server that manages all language translations. Translations can be added to or removed from it.</para>
/// </summary>
[GodotClassName("TranslationServer")]
public partial class TranslationServerInstance : GodotObject
{
    /// <summary>
    /// <para>If <see langword="true"/>, enables the use of pseudolocalization. See <c>ProjectSettings.internationalization/pseudolocalization/use_pseudolocalization</c> for details.</para>
    /// </summary>
    public bool PseudolocalizationEnabled
    {
        get
        {
            return IsPseudolocalizationEnabled();
        }
        set
        {
            SetPseudolocalizationEnabled(value);
        }
    }

    private static readonly System.Type CachedType = typeof(TranslationServerInstance);

    private static readonly StringName NativeName = "TranslationServer";

    internal TranslationServerInstance() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal TranslationServerInstance(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLocale, 83702148ul);

    /// <summary>
    /// <para>Sets the locale of the project. The <paramref name="locale"/> string will be standardized to match known locales (e.g. <c>en-US</c> would be matched to <c>en_US</c>).</para>
    /// <para>If translations have been loaded beforehand for the new locale, they will be applied.</para>
    /// </summary>
    public void SetLocale(string locale)
    {
        NativeCalls.godot_icall_1_56(MethodBind0, GodotObject.GetPtr(this), locale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLocale, 201670096ul);

    /// <summary>
    /// <para>Returns the current locale of the project.</para>
    /// <para>See also <see cref="Godot.OS.GetLocale()"/> and <see cref="Godot.OS.GetLocaleLanguage()"/> to query the locale of the user system.</para>
    /// </summary>
    public string GetLocale()
    {
        return NativeCalls.godot_icall_0_57(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetToolLocale, 2841200299ul);

    /// <summary>
    /// <para>Returns the current locale of the editor.</para>
    /// <para><b>Note:</b> When called from an exported project returns the same value as <see cref="Godot.TranslationServerInstance.GetLocale()"/>.</para>
    /// </summary>
    public string GetToolLocale()
    {
        return NativeCalls.godot_icall_0_57(MethodBind2, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CompareLocales, 2878152881ul);

    /// <summary>
    /// <para>Compares two locales and returns a similarity score between <c>0</c> (no match) and <c>10</c> (full match).</para>
    /// </summary>
    public int CompareLocales(string localeA, string localeB)
    {
        return NativeCalls.godot_icall_2_298(MethodBind3, GodotObject.GetPtr(this), localeA, localeB);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.StandardizeLocale, 3135753539ul);

    /// <summary>
    /// <para>Returns a <paramref name="locale"/> string standardized to match known locales (e.g. <c>en-US</c> would be matched to <c>en_US</c>).</para>
    /// </summary>
    public string StandardizeLocale(string locale)
    {
        return NativeCalls.godot_icall_1_271(MethodBind4, GodotObject.GetPtr(this), locale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAllLanguages, 1139954409ul);

    /// <summary>
    /// <para>Returns array of known language codes.</para>
    /// </summary>
    public string[] GetAllLanguages()
    {
        return NativeCalls.godot_icall_0_115(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLanguageName, 3135753539ul);

    /// <summary>
    /// <para>Returns a readable language name for the <paramref name="language"/> code.</para>
    /// </summary>
    public string GetLanguageName(string language)
    {
        return NativeCalls.godot_icall_1_271(MethodBind6, GodotObject.GetPtr(this), language);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAllScripts, 1139954409ul);

    /// <summary>
    /// <para>Returns an array of known script codes.</para>
    /// </summary>
    public string[] GetAllScripts()
    {
        return NativeCalls.godot_icall_0_115(MethodBind7, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetScriptName, 3135753539ul);

    /// <summary>
    /// <para>Returns a readable script name for the <paramref name="script"/> code.</para>
    /// </summary>
    public string GetScriptName(string script)
    {
        return NativeCalls.godot_icall_1_271(MethodBind8, GodotObject.GetPtr(this), script);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAllCountries, 1139954409ul);

    /// <summary>
    /// <para>Returns an array of known country codes.</para>
    /// </summary>
    public string[] GetAllCountries()
    {
        return NativeCalls.godot_icall_0_115(MethodBind9, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCountryName, 3135753539ul);

    /// <summary>
    /// <para>Returns a readable country name for the <paramref name="country"/> code.</para>
    /// </summary>
    public string GetCountryName(string country)
    {
        return NativeCalls.godot_icall_1_271(MethodBind10, GodotObject.GetPtr(this), country);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLocaleName, 3135753539ul);

    /// <summary>
    /// <para>Returns a locale's language and its variant (e.g. <c>"en_US"</c> would return <c>"English (United States)"</c>).</para>
    /// </summary>
    public string GetLocaleName(string locale)
    {
        return NativeCalls.godot_icall_1_271(MethodBind11, GodotObject.GetPtr(this), locale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Translate, 58037827ul);

    /// <summary>
    /// <para>Returns the current locale's translation for the given message (key) and context.</para>
    /// </summary>
    public StringName Translate(StringName message, StringName context = null)
    {
        return NativeCalls.godot_icall_2_1289(MethodBind12, GodotObject.GetPtr(this), (godot_string_name)(message?.NativeValue ?? default), (godot_string_name)(context?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TranslatePlural, 1333931916ul);

    /// <summary>
    /// <para>Returns the current locale's translation for the given message (key), plural message and context.</para>
    /// <para>The number <paramref name="n"/> is the number or quantity of the plural object. It will be used to guide the translation system to fetch the correct plural form for the selected language.</para>
    /// </summary>
    public StringName TranslatePlural(StringName message, StringName pluralMessage, int n, StringName context = null)
    {
        return NativeCalls.godot_icall_4_1290(MethodBind13, GodotObject.GetPtr(this), (godot_string_name)(message?.NativeValue ?? default), (godot_string_name)(pluralMessage?.NativeValue ?? default), n, (godot_string_name)(context?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddTranslation, 1466479800ul);

    /// <summary>
    /// <para>Adds a <see cref="Godot.Translation"/> resource.</para>
    /// </summary>
    public void AddTranslation(Translation translation)
    {
        NativeCalls.godot_icall_1_55(MethodBind14, GodotObject.GetPtr(this), GodotObject.GetPtr(translation));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RemoveTranslation, 1466479800ul);

    /// <summary>
    /// <para>Removes the given translation from the server.</para>
    /// </summary>
    public void RemoveTranslation(Translation translation)
    {
        NativeCalls.godot_icall_1_55(MethodBind15, GodotObject.GetPtr(this), GodotObject.GetPtr(translation));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTranslationObject, 2065240175ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.Translation"/> instance based on the <paramref name="locale"/> passed in.</para>
    /// <para>It will return <see langword="null"/> if there is no <see cref="Godot.Translation"/> instance that matches the <paramref name="locale"/>.</para>
    /// </summary>
    public Translation GetTranslationObject(string locale)
    {
        return (Translation)NativeCalls.godot_icall_1_523(MethodBind16, GodotObject.GetPtr(this), locale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Clear, 3218959716ul);

    /// <summary>
    /// <para>Clears the server from all translations.</para>
    /// </summary>
    public void Clear()
    {
        NativeCalls.godot_icall_0_3(MethodBind17, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLoadedLocales, 1139954409ul);

    /// <summary>
    /// <para>Returns an array of all loaded locales of the project.</para>
    /// </summary>
    public string[] GetLoadedLocales()
    {
        return NativeCalls.godot_icall_0_115(MethodBind18, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsPseudolocalizationEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsPseudolocalizationEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind19, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPseudolocalizationEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPseudolocalizationEnabled(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind20, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ReloadPseudolocalization, 3218959716ul);

    /// <summary>
    /// <para>Reparses the pseudolocalization options and reloads the translation.</para>
    /// </summary>
    public void ReloadPseudolocalization()
    {
        NativeCalls.godot_icall_0_3(MethodBind21, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Pseudolocalize, 1965194235ul);

    /// <summary>
    /// <para>Returns the pseudolocalized string based on the <paramref name="message"/> passed in.</para>
    /// </summary>
    public StringName Pseudolocalize(StringName message)
    {
        return NativeCalls.godot_icall_1_154(MethodBind22, GodotObject.GetPtr(this), (godot_string_name)(message?.NativeValue ?? default));
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
        /// <summary>
        /// Cached name for the 'pseudolocalization_enabled' property.
        /// </summary>
        public static readonly StringName PseudolocalizationEnabled = "pseudolocalization_enabled";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : GodotObject.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_locale' method.
        /// </summary>
        public static readonly StringName SetLocale = "set_locale";
        /// <summary>
        /// Cached name for the 'get_locale' method.
        /// </summary>
        public static readonly StringName GetLocale = "get_locale";
        /// <summary>
        /// Cached name for the 'get_tool_locale' method.
        /// </summary>
        public static readonly StringName GetToolLocale = "get_tool_locale";
        /// <summary>
        /// Cached name for the 'compare_locales' method.
        /// </summary>
        public static readonly StringName CompareLocales = "compare_locales";
        /// <summary>
        /// Cached name for the 'standardize_locale' method.
        /// </summary>
        public static readonly StringName StandardizeLocale = "standardize_locale";
        /// <summary>
        /// Cached name for the 'get_all_languages' method.
        /// </summary>
        public static readonly StringName GetAllLanguages = "get_all_languages";
        /// <summary>
        /// Cached name for the 'get_language_name' method.
        /// </summary>
        public static readonly StringName GetLanguageName = "get_language_name";
        /// <summary>
        /// Cached name for the 'get_all_scripts' method.
        /// </summary>
        public static readonly StringName GetAllScripts = "get_all_scripts";
        /// <summary>
        /// Cached name for the 'get_script_name' method.
        /// </summary>
        public static readonly StringName GetScriptName = "get_script_name";
        /// <summary>
        /// Cached name for the 'get_all_countries' method.
        /// </summary>
        public static readonly StringName GetAllCountries = "get_all_countries";
        /// <summary>
        /// Cached name for the 'get_country_name' method.
        /// </summary>
        public static readonly StringName GetCountryName = "get_country_name";
        /// <summary>
        /// Cached name for the 'get_locale_name' method.
        /// </summary>
        public static readonly StringName GetLocaleName = "get_locale_name";
        /// <summary>
        /// Cached name for the 'translate' method.
        /// </summary>
        public static readonly StringName Translate = "translate";
        /// <summary>
        /// Cached name for the 'translate_plural' method.
        /// </summary>
        public static readonly StringName TranslatePlural = "translate_plural";
        /// <summary>
        /// Cached name for the 'add_translation' method.
        /// </summary>
        public static readonly StringName AddTranslation = "add_translation";
        /// <summary>
        /// Cached name for the 'remove_translation' method.
        /// </summary>
        public static readonly StringName RemoveTranslation = "remove_translation";
        /// <summary>
        /// Cached name for the 'get_translation_object' method.
        /// </summary>
        public static readonly StringName GetTranslationObject = "get_translation_object";
        /// <summary>
        /// Cached name for the 'clear' method.
        /// </summary>
        public static readonly StringName Clear = "clear";
        /// <summary>
        /// Cached name for the 'get_loaded_locales' method.
        /// </summary>
        public static readonly StringName GetLoadedLocales = "get_loaded_locales";
        /// <summary>
        /// Cached name for the 'is_pseudolocalization_enabled' method.
        /// </summary>
        public static readonly StringName IsPseudolocalizationEnabled = "is_pseudolocalization_enabled";
        /// <summary>
        /// Cached name for the 'set_pseudolocalization_enabled' method.
        /// </summary>
        public static readonly StringName SetPseudolocalizationEnabled = "set_pseudolocalization_enabled";
        /// <summary>
        /// Cached name for the 'reload_pseudolocalization' method.
        /// </summary>
        public static readonly StringName ReloadPseudolocalization = "reload_pseudolocalization";
        /// <summary>
        /// Cached name for the 'pseudolocalize' method.
        /// </summary>
        public static readonly StringName Pseudolocalize = "pseudolocalize";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
    }
}

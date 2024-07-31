namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>The server that manages all language translations. Translations can be added to or removed from it.</para>
/// </summary>
public static partial class TranslationServer
{
    /// <summary>
    /// <para>If <see langword="true"/>, enables the use of pseudolocalization. See <c>ProjectSettings.internationalization/pseudolocalization/use_pseudolocalization</c> for details.</para>
    /// </summary>
    public static bool PseudolocalizationEnabled
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

    private static readonly StringName NativeName = "TranslationServer";

    private static TranslationServerInstance singleton;

    public static TranslationServerInstance Singleton =>
        singleton ??= (TranslationServerInstance)InteropUtils.EngineGetSingleton("TranslationServer");

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLocale, 83702148ul);

    /// <summary>
    /// <para>Sets the locale of the project. The <paramref name="locale"/> string will be standardized to match known locales (e.g. <c>en-US</c> would be matched to <c>en_US</c>).</para>
    /// <para>If translations have been loaded beforehand for the new locale, they will be applied.</para>
    /// </summary>
    public static void SetLocale(string locale)
    {
        NativeCalls.godot_icall_1_56(MethodBind0, GodotObject.GetPtr(Singleton), locale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLocale, 201670096ul);

    /// <summary>
    /// <para>Returns the current locale of the project.</para>
    /// <para>See also <see cref="Godot.OS.GetLocale()"/> and <see cref="Godot.OS.GetLocaleLanguage()"/> to query the locale of the user system.</para>
    /// </summary>
    public static string GetLocale()
    {
        return NativeCalls.godot_icall_0_57(MethodBind1, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetToolLocale, 2841200299ul);

    /// <summary>
    /// <para>Returns the current locale of the editor.</para>
    /// <para><b>Note:</b> When called from an exported project returns the same value as <see cref="Godot.TranslationServer.GetLocale()"/>.</para>
    /// </summary>
    public static string GetToolLocale()
    {
        return NativeCalls.godot_icall_0_57(MethodBind2, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.CompareLocales, 2878152881ul);

    /// <summary>
    /// <para>Compares two locales and returns a similarity score between <c>0</c> (no match) and <c>10</c> (full match).</para>
    /// </summary>
    public static int CompareLocales(string localeA, string localeB)
    {
        return NativeCalls.godot_icall_2_298(MethodBind3, GodotObject.GetPtr(Singleton), localeA, localeB);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.StandardizeLocale, 3135753539ul);

    /// <summary>
    /// <para>Returns a <paramref name="locale"/> string standardized to match known locales (e.g. <c>en-US</c> would be matched to <c>en_US</c>).</para>
    /// </summary>
    public static string StandardizeLocale(string locale)
    {
        return NativeCalls.godot_icall_1_271(MethodBind4, GodotObject.GetPtr(Singleton), locale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAllLanguages, 1139954409ul);

    /// <summary>
    /// <para>Returns array of known language codes.</para>
    /// </summary>
    public static string[] GetAllLanguages()
    {
        return NativeCalls.godot_icall_0_115(MethodBind5, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLanguageName, 3135753539ul);

    /// <summary>
    /// <para>Returns a readable language name for the <paramref name="language"/> code.</para>
    /// </summary>
    public static string GetLanguageName(string language)
    {
        return NativeCalls.godot_icall_1_271(MethodBind6, GodotObject.GetPtr(Singleton), language);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAllScripts, 1139954409ul);

    /// <summary>
    /// <para>Returns an array of known script codes.</para>
    /// </summary>
    public static string[] GetAllScripts()
    {
        return NativeCalls.godot_icall_0_115(MethodBind7, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetScriptName, 3135753539ul);

    /// <summary>
    /// <para>Returns a readable script name for the <paramref name="script"/> code.</para>
    /// </summary>
    public static string GetScriptName(string script)
    {
        return NativeCalls.godot_icall_1_271(MethodBind8, GodotObject.GetPtr(Singleton), script);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAllCountries, 1139954409ul);

    /// <summary>
    /// <para>Returns an array of known country codes.</para>
    /// </summary>
    public static string[] GetAllCountries()
    {
        return NativeCalls.godot_icall_0_115(MethodBind9, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCountryName, 3135753539ul);

    /// <summary>
    /// <para>Returns a readable country name for the <paramref name="country"/> code.</para>
    /// </summary>
    public static string GetCountryName(string country)
    {
        return NativeCalls.godot_icall_1_271(MethodBind10, GodotObject.GetPtr(Singleton), country);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLocaleName, 3135753539ul);

    /// <summary>
    /// <para>Returns a locale's language and its variant (e.g. <c>"en_US"</c> would return <c>"English (United States)"</c>).</para>
    /// </summary>
    public static string GetLocaleName(string locale)
    {
        return NativeCalls.godot_icall_1_271(MethodBind11, GodotObject.GetPtr(Singleton), locale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.Translate, 58037827ul);

    /// <summary>
    /// <para>Returns the current locale's translation for the given message (key) and context.</para>
    /// </summary>
    public static StringName Translate(StringName message, StringName context = null)
    {
        return NativeCalls.godot_icall_2_1289(MethodBind12, GodotObject.GetPtr(Singleton), (godot_string_name)(message?.NativeValue ?? default), (godot_string_name)(context?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.TranslatePlural, 1333931916ul);

    /// <summary>
    /// <para>Returns the current locale's translation for the given message (key), plural message and context.</para>
    /// <para>The number <paramref name="n"/> is the number or quantity of the plural object. It will be used to guide the translation system to fetch the correct plural form for the selected language.</para>
    /// </summary>
    public static StringName TranslatePlural(StringName message, StringName pluralMessage, int n, StringName context = null)
    {
        return NativeCalls.godot_icall_4_1290(MethodBind13, GodotObject.GetPtr(Singleton), (godot_string_name)(message?.NativeValue ?? default), (godot_string_name)(pluralMessage?.NativeValue ?? default), n, (godot_string_name)(context?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.AddTranslation, 1466479800ul);

    /// <summary>
    /// <para>Adds a <see cref="Godot.Translation"/> resource.</para>
    /// </summary>
    public static void AddTranslation(Translation translation)
    {
        NativeCalls.godot_icall_1_55(MethodBind14, GodotObject.GetPtr(Singleton), GodotObject.GetPtr(translation));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.RemoveTranslation, 1466479800ul);

    /// <summary>
    /// <para>Removes the given translation from the server.</para>
    /// </summary>
    public static void RemoveTranslation(Translation translation)
    {
        NativeCalls.godot_icall_1_55(MethodBind15, GodotObject.GetPtr(Singleton), GodotObject.GetPtr(translation));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTranslationObject, 2065240175ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.Translation"/> instance based on the <paramref name="locale"/> passed in.</para>
    /// <para>It will return <see langword="null"/> if there is no <see cref="Godot.Translation"/> instance that matches the <paramref name="locale"/>.</para>
    /// </summary>
    public static Translation GetTranslationObject(string locale)
    {
        return (Translation)NativeCalls.godot_icall_1_523(MethodBind16, GodotObject.GetPtr(Singleton), locale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.Clear, 3218959716ul);

    /// <summary>
    /// <para>Clears the server from all translations.</para>
    /// </summary>
    public static void Clear()
    {
        NativeCalls.godot_icall_0_3(MethodBind17, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLoadedLocales, 1139954409ul);

    /// <summary>
    /// <para>Returns an array of all loaded locales of the project.</para>
    /// </summary>
    public static string[] GetLoadedLocales()
    {
        return NativeCalls.godot_icall_0_115(MethodBind18, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.IsPseudolocalizationEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool IsPseudolocalizationEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind19, GodotObject.GetPtr(Singleton)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPseudolocalizationEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void SetPseudolocalizationEnabled(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind20, GodotObject.GetPtr(Singleton), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.ReloadPseudolocalization, 3218959716ul);

    /// <summary>
    /// <para>Reparses the pseudolocalization options and reloads the translation.</para>
    /// </summary>
    public static void ReloadPseudolocalization()
    {
        NativeCalls.godot_icall_0_3(MethodBind21, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.Pseudolocalize, 1965194235ul);

    /// <summary>
    /// <para>Returns the pseudolocalized string based on the <paramref name="message"/> passed in.</para>
    /// </summary>
    public static StringName Pseudolocalize(StringName message)
    {
        return NativeCalls.godot_icall_1_154(MethodBind22, GodotObject.GetPtr(Singleton), (godot_string_name)(message?.NativeValue ?? default));
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public class PropertyName
    {
        /// <summary>
        /// Cached name for the 'pseudolocalization_enabled' property.
        /// </summary>
        public static readonly StringName PseudolocalizationEnabled = "pseudolocalization_enabled";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public class MethodName
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
    public class SignalName
    {
    }
}

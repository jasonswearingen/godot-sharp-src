namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.DisplayServer"/> handles everything related to window management. It is separated from <see cref="Godot.OS"/> as a single operating system may support multiple display servers.</para>
/// <para><b>Headless mode:</b> Starting the engine with the <c>--headless</c> <a href="$DOCS_URL/tutorials/editor/command_line_tutorial.html">command line argument</a> disables all rendering and window management functions. Most functions from <see cref="Godot.DisplayServer"/> will return dummy values in this case.</para>
/// </summary>
[GodotClassName("DisplayServer")]
public partial class DisplayServerInstance : GodotObject
{
    private static readonly System.Type CachedType = typeof(DisplayServerInstance);

    private static readonly StringName NativeName = "DisplayServer";

    internal DisplayServerInstance() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal DisplayServerInstance(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.HasFeature, 334065950ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the specified <paramref name="feature"/> is supported by the current <see cref="Godot.DisplayServer"/>, <see langword="false"/> otherwise.</para>
    /// </summary>
    public bool HasFeature(DisplayServer.Feature feature)
    {
        return NativeCalls.godot_icall_1_75(MethodBind0, GodotObject.GetPtr(this), (int)feature).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetName, 201670096ul);

    /// <summary>
    /// <para>Returns the name of the <see cref="Godot.DisplayServer"/> currently in use. Most operating systems only have a single <see cref="Godot.DisplayServer"/>, but Linux has access to more than one <see cref="Godot.DisplayServer"/> (currently X11 and Wayland).</para>
    /// <para>The names of built-in display servers are <c>Windows</c>, <c>macOS</c>, <c>X11</c> (Linux), <c>Wayland</c> (Linux), <c>Android</c>, <c>iOS</c>, <c>web</c> (HTML5), and <c>headless</c> (when started with the <c>--headless</c> <a href="$DOCS_URL/tutorials/editor/command_line_tutorial.html">command line argument</a>).</para>
    /// </summary>
    public string GetName()
    {
        return NativeCalls.godot_icall_0_57(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.HelpSetSearchCallbacks, 1687350599ul);

    /// <summary>
    /// <para>Sets native help system search callbacks.</para>
    /// <para><paramref name="searchCallback"/> has the following arguments: <c>String search_string, int result_limit</c> and return a <see cref="Godot.Collections.Dictionary"/> with "key, display name" pairs for the search results. Called when the user enters search terms in the <c>Help</c> menu.</para>
    /// <para><paramref name="actionCallback"/> has the following arguments: <c>String key</c>. Called when the user selects a search result in the <c>Help</c> menu.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    public void HelpSetSearchCallbacks(Callable searchCallback, Callable actionCallback)
    {
        NativeCalls.godot_icall_2_348(MethodBind2, GodotObject.GetPtr(this), searchCallback, actionCallback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetPopupCallbacks, 3893727526ul);

    /// <summary>
    /// <para>Registers callables to emit when the menu is respectively about to show or closed. Callback methods should have zero arguments.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetPopupCallbacks(string menuRoot, Callable openCallback, Callable closeCallback)
    {
        NativeCalls.godot_icall_3_349(MethodBind3, GodotObject.GetPtr(this), menuRoot, openCallback, closeCallback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddSubmenuItem, 2828985934ul);

    /// <summary>
    /// <para>Adds an item that will act as a submenu of the global menu <paramref name="menuRoot"/>. The <paramref name="submenu"/> argument is the ID of the global menu root that will be shown when the item is clicked.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddSubmenuItem(string menuRoot, string label, string submenu, int index = -1)
    {
        return NativeCalls.godot_icall_4_350(MethodBind4, GodotObject.GetPtr(this), menuRoot, label, submenu, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddItem, 3401266716ul);

    /// <summary>
    /// <para>Adds a new item with text <paramref name="label"/> to the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para>An <paramref name="accelerator"/> can optionally be defined, which is a keyboard shortcut that can be pressed to trigger the menu button even if it's not currently open. The <paramref name="accelerator"/> is generally a combination of <see cref="Godot.KeyModifierMask"/>s and <see cref="Godot.Key"/>s using bitwise OR such as <c>KEY_MASK_CTRL | KEY_A</c> (Ctrl + A).</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> and <paramref name="keyCallback"/> Callables need to accept exactly one Variant parameter, the parameter passed to the Callables will be the value passed to <paramref name="tag"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddItem(string menuRoot, string label, Callable callback = default, Callable keyCallback = default, Variant tag = default, Key accelerator = (Key)(0), int index = -1)
    {
        return NativeCalls.godot_icall_7_351(MethodBind5, GodotObject.GetPtr(this), menuRoot, label, callback, keyCallback, tag, (int)accelerator, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddCheckItem, 3401266716ul);

    /// <summary>
    /// <para>Adds a new checkable item with text <paramref name="label"/> to the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para>An <paramref name="accelerator"/> can optionally be defined, which is a keyboard shortcut that can be pressed to trigger the menu button even if it's not currently open. The <paramref name="accelerator"/> is generally a combination of <see cref="Godot.KeyModifierMask"/>s and <see cref="Godot.Key"/>s using bitwise OR such as <c>KEY_MASK_CTRL | KEY_A</c> (Ctrl + A).</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> and <paramref name="keyCallback"/> Callables need to accept exactly one Variant parameter, the parameter passed to the Callables will be the value passed to <paramref name="tag"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddCheckItem(string menuRoot, string label, Callable callback = default, Callable keyCallback = default, Variant tag = default, Key accelerator = (Key)(0), int index = -1)
    {
        return NativeCalls.godot_icall_7_351(MethodBind6, GodotObject.GetPtr(this), menuRoot, label, callback, keyCallback, tag, (int)accelerator, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddIconItem, 4245856523ul);

    /// <summary>
    /// <para>Adds a new item with text <paramref name="label"/> and icon <paramref name="icon"/> to the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para>An <paramref name="accelerator"/> can optionally be defined, which is a keyboard shortcut that can be pressed to trigger the menu button even if it's not currently open. The <paramref name="accelerator"/> is generally a combination of <see cref="Godot.KeyModifierMask"/>s and <see cref="Godot.Key"/>s using bitwise OR such as <c>KEY_MASK_CTRL | KEY_A</c> (Ctrl + A).</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> and <paramref name="keyCallback"/> Callables need to accept exactly one Variant parameter, the parameter passed to the Callables will be the value passed to <paramref name="tag"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddIconItem(string menuRoot, Texture2D icon, string label, Callable callback = default, Callable keyCallback = default, Variant tag = default, Key accelerator = (Key)(0), int index = -1)
    {
        return NativeCalls.godot_icall_8_352(MethodBind7, GodotObject.GetPtr(this), menuRoot, GodotObject.GetPtr(icon), label, callback, keyCallback, tag, (int)accelerator, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddIconCheckItem, 4245856523ul);

    /// <summary>
    /// <para>Adds a new checkable item with text <paramref name="label"/> and icon <paramref name="icon"/> to the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para>An <paramref name="accelerator"/> can optionally be defined, which is a keyboard shortcut that can be pressed to trigger the menu button even if it's not currently open. The <paramref name="accelerator"/> is generally a combination of <see cref="Godot.KeyModifierMask"/>s and <see cref="Godot.Key"/>s using bitwise OR such as <c>KEY_MASK_CTRL | KEY_A</c> (Ctrl + A).</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> and <paramref name="keyCallback"/> Callables need to accept exactly one Variant parameter, the parameter passed to the Callables will be the value passed to <paramref name="tag"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddIconCheckItem(string menuRoot, Texture2D icon, string label, Callable callback = default, Callable keyCallback = default, Variant tag = default, Key accelerator = (Key)(0), int index = -1)
    {
        return NativeCalls.godot_icall_8_352(MethodBind8, GodotObject.GetPtr(this), menuRoot, GodotObject.GetPtr(icon), label, callback, keyCallback, tag, (int)accelerator, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddRadioCheckItem, 3401266716ul);

    /// <summary>
    /// <para>Adds a new radio-checkable item with text <paramref name="label"/> to the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para>An <paramref name="accelerator"/> can optionally be defined, which is a keyboard shortcut that can be pressed to trigger the menu button even if it's not currently open. The <paramref name="accelerator"/> is generally a combination of <see cref="Godot.KeyModifierMask"/>s and <see cref="Godot.Key"/>s using bitwise OR such as <c>KEY_MASK_CTRL | KEY_A</c> (Ctrl + A).</para>
    /// <para><b>Note:</b> Radio-checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually. See <see cref="Godot.DisplayServerInstance.GlobalMenuSetItemChecked(string, int, bool)"/> for more info on how to control it.</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> and <paramref name="keyCallback"/> Callables need to accept exactly one Variant parameter, the parameter passed to the Callables will be the value passed to <paramref name="tag"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddRadioCheckItem(string menuRoot, string label, Callable callback = default, Callable keyCallback = default, Variant tag = default, Key accelerator = (Key)(0), int index = -1)
    {
        return NativeCalls.godot_icall_7_351(MethodBind9, GodotObject.GetPtr(this), menuRoot, label, callback, keyCallback, tag, (int)accelerator, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddIconRadioCheckItem, 4245856523ul);

    /// <summary>
    /// <para>Adds a new radio-checkable item with text <paramref name="label"/> and icon <paramref name="icon"/> to the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para>An <paramref name="accelerator"/> can optionally be defined, which is a keyboard shortcut that can be pressed to trigger the menu button even if it's not currently open. The <paramref name="accelerator"/> is generally a combination of <see cref="Godot.KeyModifierMask"/>s and <see cref="Godot.Key"/>s using bitwise OR such as <c>KEY_MASK_CTRL | KEY_A</c> (Ctrl + A).</para>
    /// <para><b>Note:</b> Radio-checkable items just display a checkmark, but don't have any built-in checking behavior and must be checked/unchecked manually. See <see cref="Godot.DisplayServerInstance.GlobalMenuSetItemChecked(string, int, bool)"/> for more info on how to control it.</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> and <paramref name="keyCallback"/> Callables need to accept exactly one Variant parameter, the parameter passed to the Callables will be the value passed to <paramref name="tag"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddIconRadioCheckItem(string menuRoot, Texture2D icon, string label, Callable callback = default, Callable keyCallback = default, Variant tag = default, Key accelerator = (Key)(0), int index = -1)
    {
        return NativeCalls.godot_icall_8_352(MethodBind10, GodotObject.GetPtr(this), menuRoot, GodotObject.GetPtr(icon), label, callback, keyCallback, tag, (int)accelerator, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddMultistateItem, 3431222859ul);

    /// <summary>
    /// <para>Adds a new item with text <paramref name="label"/> to the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para>Contrarily to normal binary items, multistate items can have more than two states, as defined by <paramref name="maxStates"/>. Each press or activate of the item will increase the state by one. The default value is defined by <paramref name="defaultState"/>.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para>An <paramref name="accelerator"/> can optionally be defined, which is a keyboard shortcut that can be pressed to trigger the menu button even if it's not currently open. The <paramref name="accelerator"/> is generally a combination of <see cref="Godot.KeyModifierMask"/>s and <see cref="Godot.Key"/>s using bitwise OR such as <c>KEY_MASK_CTRL | KEY_A</c> (Ctrl + A).</para>
    /// <para><b>Note:</b> By default, there's no indication of the current item state, it should be changed manually.</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> and <paramref name="keyCallback"/> Callables need to accept exactly one Variant parameter, the parameter passed to the Callables will be the value passed to <paramref name="tag"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddMultistateItem(string menuRoot, string label, int maxStates, int defaultState, Callable callback = default, Callable keyCallback = default, Variant tag = default, Key accelerator = (Key)(0), int index = -1)
    {
        return NativeCalls.godot_icall_9_353(MethodBind11, GodotObject.GetPtr(this), menuRoot, label, maxStates, defaultState, callback, keyCallback, tag, (int)accelerator, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuAddSeparator, 3214812433ul);

    /// <summary>
    /// <para>Adds a separator between items to the global menu with ID <paramref name="menuRoot"/>. Separators also occupy an index.</para>
    /// <para>Returns index of the inserted item, it's not guaranteed to be the same as <paramref name="index"/> value.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuAddSeparator(string menuRoot, int index = -1)
    {
        return NativeCalls.godot_icall_2_354(MethodBind12, GodotObject.GetPtr(this), menuRoot, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemIndexFromText, 2878152881ul);

    /// <summary>
    /// <para>Returns the index of the item with the specified <paramref name="text"/>. Indices are automatically assigned to each item by the engine, and cannot be set manually.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuGetItemIndexFromText(string menuRoot, string text)
    {
        return NativeCalls.godot_icall_2_298(MethodBind13, GodotObject.GetPtr(this), menuRoot, text);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemIndexFromTag, 2941063483ul);

    /// <summary>
    /// <para>Returns the index of the item with the specified <paramref name="tag"/>. Indices are automatically assigned to each item by the engine, and cannot be set manually.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuGetItemIndexFromTag(string menuRoot, Variant tag)
    {
        return NativeCalls.godot_icall_2_355(MethodBind14, GodotObject.GetPtr(this), menuRoot, tag);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuIsItemChecked, 3511468594ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the item at index <paramref name="idx"/> is checked.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public bool GlobalMenuIsItemChecked(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_356(MethodBind15, GodotObject.GetPtr(this), menuRoot, idx).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuIsItemCheckable, 3511468594ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the item at index <paramref name="idx"/> is checkable in some way, i.e. if it has a checkbox or radio button.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public bool GlobalMenuIsItemCheckable(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_356(MethodBind16, GodotObject.GetPtr(this), menuRoot, idx).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuIsItemRadioCheckable, 3511468594ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the item at index <paramref name="idx"/> has radio button-style checkability.</para>
    /// <para><b>Note:</b> This is purely cosmetic; you must add the logic for checking/unchecking items in radio groups.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public bool GlobalMenuIsItemRadioCheckable(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_356(MethodBind17, GodotObject.GetPtr(this), menuRoot, idx).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemCallback, 748666903ul);

    /// <summary>
    /// <para>Returns the callback of the item at index <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public Callable GlobalMenuGetItemCallback(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_357(MethodBind18, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemKeyCallback, 748666903ul);

    /// <summary>
    /// <para>Returns the callback of the item accelerator at index <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public Callable GlobalMenuGetItemKeyCallback(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_357(MethodBind19, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemTag, 330672633ul);

    /// <summary>
    /// <para>Returns the metadata of the specified item, which might be of any type. You can set it with <see cref="Godot.DisplayServerInstance.GlobalMenuSetItemTag(string, int, Variant)"/>, which provides a simple way of assigning context data to items.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public Variant GlobalMenuGetItemTag(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_358(MethodBind20, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemText, 591067909ul);

    /// <summary>
    /// <para>Returns the text of the item at index <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public string GlobalMenuGetItemText(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_359(MethodBind21, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemSubmenu, 591067909ul);

    /// <summary>
    /// <para>Returns the submenu ID of the item at index <paramref name="idx"/>. See <see cref="Godot.DisplayServerInstance.GlobalMenuAddSubmenuItem(string, string, string, int)"/> for more info on how to add a submenu.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public string GlobalMenuGetItemSubmenu(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_359(MethodBind22, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemAccelerator, 936065394ul);

    /// <summary>
    /// <para>Returns the accelerator of the item at index <paramref name="idx"/>. Accelerators are special combinations of keys that activate the item, no matter which control is focused.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public Key GlobalMenuGetItemAccelerator(string menuRoot, int idx)
    {
        return (Key)NativeCalls.godot_icall_2_354(MethodBind23, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuIsItemDisabled, 3511468594ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the item at index <paramref name="idx"/> is disabled. When it is disabled it can't be selected, or its action invoked.</para>
    /// <para>See <see cref="Godot.DisplayServerInstance.GlobalMenuSetItemDisabled(string, int, bool)"/> for more info on how to disable an item.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public bool GlobalMenuIsItemDisabled(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_356(MethodBind24, GodotObject.GetPtr(this), menuRoot, idx).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuIsItemHidden, 3511468594ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the item at index <paramref name="idx"/> is hidden.</para>
    /// <para>See <see cref="Godot.DisplayServerInstance.GlobalMenuSetItemHidden(string, int, bool)"/> for more info on how to hide an item.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public bool GlobalMenuIsItemHidden(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_356(MethodBind25, GodotObject.GetPtr(this), menuRoot, idx).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemTooltip, 591067909ul);

    /// <summary>
    /// <para>Returns the tooltip associated with the specified index <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public string GlobalMenuGetItemTooltip(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_359(MethodBind26, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemState, 3422818498ul);

    /// <summary>
    /// <para>Returns the state of a multistate item. See <see cref="Godot.DisplayServerInstance.GlobalMenuAddMultistateItem(string, string, int, int, Callable, Callable, Variant, Key, int)"/> for details.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuGetItemState(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_354(MethodBind27, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemMaxStates, 3422818498ul);

    /// <summary>
    /// <para>Returns number of states of a multistate item. See <see cref="Godot.DisplayServerInstance.GlobalMenuAddMultistateItem(string, string, int, int, Callable, Callable, Variant, Key, int)"/> for details.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuGetItemMaxStates(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_354(MethodBind28, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemIcon, 3591713183ul);

    /// <summary>
    /// <para>Returns the icon of the item at index <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public Texture2D GlobalMenuGetItemIcon(string menuRoot, int idx)
    {
        return (Texture2D)NativeCalls.godot_icall_2_360(MethodBind29, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind30 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemIndentationLevel, 3422818498ul);

    /// <summary>
    /// <para>Returns the horizontal offset of the item at the given <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuGetItemIndentationLevel(string menuRoot, int idx)
    {
        return NativeCalls.godot_icall_2_354(MethodBind30, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind31 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemChecked, 4108344793ul);

    /// <summary>
    /// <para>Sets the checkstate status of the item at index <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemChecked(string menuRoot, int idx, bool @checked)
    {
        NativeCalls.godot_icall_3_361(MethodBind31, GodotObject.GetPtr(this), menuRoot, idx, @checked.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind32 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemCheckable, 4108344793ul);

    /// <summary>
    /// <para>Sets whether the item at index <paramref name="idx"/> has a checkbox. If <see langword="false"/>, sets the type of the item to plain text.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemCheckable(string menuRoot, int idx, bool checkable)
    {
        NativeCalls.godot_icall_3_361(MethodBind32, GodotObject.GetPtr(this), menuRoot, idx, checkable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind33 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemRadioCheckable, 4108344793ul);

    /// <summary>
    /// <para>Sets the type of the item at the specified index <paramref name="idx"/> to radio button. If <see langword="false"/>, sets the type of the item to plain text.</para>
    /// <para><b>Note:</b> This is purely cosmetic; you must add the logic for checking/unchecking items in radio groups.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemRadioCheckable(string menuRoot, int idx, bool checkable)
    {
        NativeCalls.godot_icall_3_361(MethodBind33, GodotObject.GetPtr(this), menuRoot, idx, checkable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind34 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemCallback, 3809915389ul);

    /// <summary>
    /// <para>Sets the callback of the item at index <paramref name="idx"/>. Callback is emitted when an item is pressed.</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> Callable needs to accept exactly one Variant parameter, the parameter passed to the Callable will be the value passed to the <c>tag</c> parameter when the menu item was created.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemCallback(string menuRoot, int idx, Callable callback)
    {
        NativeCalls.godot_icall_3_362(MethodBind34, GodotObject.GetPtr(this), menuRoot, idx, callback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind35 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemHoverCallbacks, 3809915389ul);

    /// <summary>
    /// <para>Sets the callback of the item at index <paramref name="idx"/>. The callback is emitted when an item is hovered.</para>
    /// <para><b>Note:</b> The <paramref name="callback"/> Callable needs to accept exactly one Variant parameter, the parameter passed to the Callable will be the value passed to the <c>tag</c> parameter when the menu item was created.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemHoverCallbacks(string menuRoot, int idx, Callable callback)
    {
        NativeCalls.godot_icall_3_362(MethodBind35, GodotObject.GetPtr(this), menuRoot, idx, callback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind36 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemKeyCallback, 3809915389ul);

    /// <summary>
    /// <para>Sets the callback of the item at index <paramref name="idx"/>. Callback is emitted when its accelerator is activated.</para>
    /// <para><b>Note:</b> The <paramref name="keyCallback"/> Callable needs to accept exactly one Variant parameter, the parameter passed to the Callable will be the value passed to the <c>tag</c> parameter when the menu item was created.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemKeyCallback(string menuRoot, int idx, Callable keyCallback)
    {
        NativeCalls.godot_icall_3_362(MethodBind36, GodotObject.GetPtr(this), menuRoot, idx, keyCallback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind37 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemTag, 453659863ul);

    /// <summary>
    /// <para>Sets the metadata of an item, which may be of any type. You can later get it with <see cref="Godot.DisplayServerInstance.GlobalMenuGetItemTag(string, int)"/>, which provides a simple way of assigning context data to items.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemTag(string menuRoot, int idx, Variant tag)
    {
        NativeCalls.godot_icall_3_363(MethodBind37, GodotObject.GetPtr(this), menuRoot, idx, tag);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind38 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemText, 965966136ul);

    /// <summary>
    /// <para>Sets the text of the item at index <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemText(string menuRoot, int idx, string text)
    {
        NativeCalls.godot_icall_3_364(MethodBind38, GodotObject.GetPtr(this), menuRoot, idx, text);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind39 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemSubmenu, 965966136ul);

    /// <summary>
    /// <para>Sets the submenu of the item at index <paramref name="idx"/>. The submenu is the ID of a global menu root that would be shown when the item is clicked.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemSubmenu(string menuRoot, int idx, string submenu)
    {
        NativeCalls.godot_icall_3_364(MethodBind39, GodotObject.GetPtr(this), menuRoot, idx, submenu);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind40 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemAccelerator, 566943293ul);

    /// <summary>
    /// <para>Sets the accelerator of the item at index <paramref name="idx"/>. <paramref name="keycode"/> can be a single <see cref="Godot.Key"/>, or a combination of <see cref="Godot.KeyModifierMask"/>s and <see cref="Godot.Key"/>s using bitwise OR such as <c>KEY_MASK_CTRL | KEY_A</c> (Ctrl + A).</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemAccelerator(string menuRoot, int idx, Key keycode)
    {
        NativeCalls.godot_icall_3_365(MethodBind40, GodotObject.GetPtr(this), menuRoot, idx, (int)keycode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind41 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemDisabled, 4108344793ul);

    /// <summary>
    /// <para>Enables/disables the item at index <paramref name="idx"/>. When it is disabled, it can't be selected and its action can't be invoked.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemDisabled(string menuRoot, int idx, bool disabled)
    {
        NativeCalls.godot_icall_3_361(MethodBind41, GodotObject.GetPtr(this), menuRoot, idx, disabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind42 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemHidden, 4108344793ul);

    /// <summary>
    /// <para>Hides/shows the item at index <paramref name="idx"/>. When it is hidden, an item does not appear in a menu and its action cannot be invoked.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemHidden(string menuRoot, int idx, bool hidden)
    {
        NativeCalls.godot_icall_3_361(MethodBind42, GodotObject.GetPtr(this), menuRoot, idx, hidden.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind43 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemTooltip, 965966136ul);

    /// <summary>
    /// <para>Sets the <see cref="string"/> tooltip of the item at the specified index <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemTooltip(string menuRoot, int idx, string tooltip)
    {
        NativeCalls.godot_icall_3_364(MethodBind43, GodotObject.GetPtr(this), menuRoot, idx, tooltip);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind44 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemState, 3474840532ul);

    /// <summary>
    /// <para>Sets the state of a multistate item. See <see cref="Godot.DisplayServerInstance.GlobalMenuAddMultistateItem(string, string, int, int, Callable, Callable, Variant, Key, int)"/> for details.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemState(string menuRoot, int idx, int state)
    {
        NativeCalls.godot_icall_3_365(MethodBind44, GodotObject.GetPtr(this), menuRoot, idx, state);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind45 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemMaxStates, 3474840532ul);

    /// <summary>
    /// <para>Sets number of state of a multistate item. See <see cref="Godot.DisplayServerInstance.GlobalMenuAddMultistateItem(string, string, int, int, Callable, Callable, Variant, Key, int)"/> for details.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemMaxStates(string menuRoot, int idx, int maxStates)
    {
        NativeCalls.godot_icall_3_365(MethodBind45, GodotObject.GetPtr(this), menuRoot, idx, maxStates);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind46 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemIcon, 3201338066ul);

    /// <summary>
    /// <para>Replaces the <see cref="Godot.Texture2D"/> icon of the specified <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Note:</b> This method is not supported by macOS "_dock" menu items.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemIcon(string menuRoot, int idx, Texture2D icon)
    {
        NativeCalls.godot_icall_3_366(MethodBind46, GodotObject.GetPtr(this), menuRoot, idx, GodotObject.GetPtr(icon));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind47 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuSetItemIndentationLevel, 3474840532ul);

    /// <summary>
    /// <para>Sets the horizontal offset of the item at the given <paramref name="idx"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuSetItemIndentationLevel(string menuRoot, int idx, int level)
    {
        NativeCalls.godot_icall_3_365(MethodBind47, GodotObject.GetPtr(this), menuRoot, idx, level);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind48 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetItemCount, 1321353865ul);

    /// <summary>
    /// <para>Returns number of items in the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public int GlobalMenuGetItemCount(string menuRoot)
    {
        return NativeCalls.godot_icall_1_127(MethodBind48, GodotObject.GetPtr(this), menuRoot);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind49 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuRemoveItem, 2956805083ul);

    /// <summary>
    /// <para>Removes the item at index <paramref name="idx"/> from the global menu <paramref name="menuRoot"/>.</para>
    /// <para><b>Note:</b> The indices of items after the removed item will be shifted by one.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuRemoveItem(string menuRoot, int idx)
    {
        NativeCalls.godot_icall_2_367(MethodBind49, GodotObject.GetPtr(this), menuRoot, idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind50 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuClear, 83702148ul);

    /// <summary>
    /// <para>Removes all items from the global menu with ID <paramref name="menuRoot"/>.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// <para><b>Supported system menu IDs:</b></para>
    /// <para><code>
    /// "_main" - Main menu (macOS).
    /// "_dock" - Dock popup menu (macOS).
    /// "_apple" - Apple menu (macOS, custom items added before "Services").
    /// "_window" - Window menu (macOS, custom items added after "Bring All to Front").
    /// "_help" - Help menu (macOS).
    /// </code></para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public void GlobalMenuClear(string menuRoot)
    {
        NativeCalls.godot_icall_1_56(MethodBind50, GodotObject.GetPtr(this), menuRoot);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind51 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GlobalMenuGetSystemMenuRoots, 3102165223ul);

    /// <summary>
    /// <para>Returns Dictionary of supported system menu IDs and names.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    [Obsolete("Use 'NativeMenu' or 'PopupMenu' instead.")]
    public Godot.Collections.Dictionary GlobalMenuGetSystemMenuRoots()
    {
        return NativeCalls.godot_icall_0_114(MethodBind51, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind52 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsIsSpeaking, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the synthesizer is generating speech, or have utterance waiting in the queue.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Wayland), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public bool TtsIsSpeaking()
    {
        return NativeCalls.godot_icall_0_40(MethodBind52, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind53 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsIsPaused, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the synthesizer is in a paused state.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Wayland), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public bool TtsIsPaused()
    {
        return NativeCalls.godot_icall_0_40(MethodBind53, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind54 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsGetVoices, 3995934104ul);

    /// <summary>
    /// <para>Returns an <see cref="Godot.Collections.Array"/> of voice information dictionaries.</para>
    /// <para>Each <see cref="Godot.Collections.Dictionary"/> contains two <see cref="string"/> entries:</para>
    /// <para>- <c>name</c> is voice name.</para>
    /// <para>- <c>id</c> is voice identifier.</para>
    /// <para>- <c>language</c> is language code in <c>lang_Variant</c> format. The <c>lang</c> part is a 2 or 3-letter code based on the ISO-639 standard, in lowercase. The <c>Variant</c> part is an engine-dependent string describing country, region or/and dialect.</para>
    /// <para>Note that Godot depends on system libraries for text-to-speech functionality. These libraries are installed by default on Windows and macOS, but not on all Linux distributions. If they are not present, this method will return an empty list. This applies to both Godot users on Linux, as well as end-users on Linux running Godot games that use text-to-speech.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Wayland), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public Godot.Collections.Array<Godot.Collections.Dictionary> TtsGetVoices()
    {
        return new Godot.Collections.Array<Godot.Collections.Dictionary>(NativeCalls.godot_icall_0_112(MethodBind54, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind55 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsGetVoicesForLanguage, 4291131558ul);

    /// <summary>
    /// <para>Returns an <see cref="string"/>[] of voice identifiers for the <paramref name="language"/>.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Wayland), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public string[] TtsGetVoicesForLanguage(string language)
    {
        return NativeCalls.godot_icall_1_296(MethodBind55, GodotObject.GetPtr(this), language);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind56 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsSpeak, 903992738ul);

    /// <summary>
    /// <para>Adds an utterance to the queue. If <paramref name="interrupt"/> is <see langword="true"/>, the queue is cleared first.</para>
    /// <para>- <paramref name="voice"/> identifier is one of the <c>"id"</c> values returned by <see cref="Godot.DisplayServerInstance.TtsGetVoices()"/> or one of the values returned by <see cref="Godot.DisplayServerInstance.TtsGetVoicesForLanguage(string)"/>.</para>
    /// <para>- <paramref name="volume"/> ranges from <c>0</c> (lowest) to <c>100</c> (highest).</para>
    /// <para>- <paramref name="pitch"/> ranges from <c>0.0</c> (lowest) to <c>2.0</c> (highest), <c>1.0</c> is default pitch for the current voice.</para>
    /// <para>- <paramref name="rate"/> ranges from <c>0.1</c> (lowest) to <c>10.0</c> (highest), <c>1.0</c> is a normal speaking rate. Other values act as a percentage relative.</para>
    /// <para>- <paramref name="utteranceId"/> is passed as a parameter to the callback functions.</para>
    /// <para><b>Note:</b> On Windows and Linux (X11/Wayland), utterance <paramref name="text"/> can use SSML markup. SSML support is engine and voice dependent. If the engine does not support SSML, you should strip out all XML markup before calling <see cref="Godot.DisplayServerInstance.TtsSpeak(string, string, int, float, float, int, bool)"/>.</para>
    /// <para><b>Note:</b> The granularity of pitch, rate, and volume is engine and voice dependent. Values may be truncated.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Wayland), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public void TtsSpeak(string text, string voice, int volume = 50, float pitch = 1f, float rate = 1f, int utteranceId = 0, bool interrupt = false)
    {
        NativeCalls.godot_icall_7_368(MethodBind56, GodotObject.GetPtr(this), text, voice, volume, pitch, rate, utteranceId, interrupt.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind57 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsPause, 3218959716ul);

    /// <summary>
    /// <para>Puts the synthesizer into a paused state.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Wayland), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public void TtsPause()
    {
        NativeCalls.godot_icall_0_3(MethodBind57, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind58 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsResume, 3218959716ul);

    /// <summary>
    /// <para>Resumes the synthesizer if it was paused.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Wayland), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public void TtsResume()
    {
        NativeCalls.godot_icall_0_3(MethodBind58, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind59 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsStop, 3218959716ul);

    /// <summary>
    /// <para>Stops synthesis in progress and removes all utterances from the queue.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Linux), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public void TtsStop()
    {
        NativeCalls.godot_icall_0_3(MethodBind59, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind60 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TtsSetUtteranceCallback, 109679083ul);

    /// <summary>
    /// <para>Adds a callback, which is called when the utterance has started, finished, canceled or reached a text boundary.</para>
    /// <para>- <see cref="Godot.DisplayServer.TtsUtteranceEvent.Started"/>, <see cref="Godot.DisplayServer.TtsUtteranceEvent.Ended"/>, and <see cref="Godot.DisplayServer.TtsUtteranceEvent.Canceled"/> callable's method should take one <see cref="int"/> parameter, the utterance ID.</para>
    /// <para>- <see cref="Godot.DisplayServer.TtsUtteranceEvent.Boundary"/> callable's method should take two <see cref="int"/> parameters, the index of the character and the utterance ID.</para>
    /// <para><b>Note:</b> The granularity of the boundary callbacks is engine dependent.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, Web, Linux (X11/Wayland), macOS, and Windows.</para>
    /// <para><b>Note:</b> <c>ProjectSettings.audio/general/text_to_speech</c> should be <see langword="true"/> to use text-to-speech.</para>
    /// </summary>
    public void TtsSetUtteranceCallback(DisplayServer.TtsUtteranceEvent @event, Callable callable)
    {
        NativeCalls.godot_icall_2_369(MethodBind60, GodotObject.GetPtr(this), (int)@event, callable);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind61 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsDarkModeSupported, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if OS supports dark mode.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, macOS, Windows, and Linux (X11/Wayland).</para>
    /// </summary>
    public bool IsDarkModeSupported()
    {
        return NativeCalls.godot_icall_0_40(MethodBind61, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind62 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsDarkMode, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if OS is using dark mode.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, macOS, Windows, and Linux (X11/Wayland).</para>
    /// </summary>
    public bool IsDarkMode()
    {
        return NativeCalls.godot_icall_0_40(MethodBind62, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind63 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAccentColor, 3444240500ul);

    /// <summary>
    /// <para>Returns OS theme accent color. Returns <c>Color(0, 0, 0, 0)</c>, if accent color is unknown.</para>
    /// <para><b>Note:</b> This method is implemented on macOS and Windows.</para>
    /// </summary>
    public Color GetAccentColor()
    {
        return NativeCalls.godot_icall_0_196(MethodBind63, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind64 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBaseColor, 3444240500ul);

    /// <summary>
    /// <para>Returns the OS theme base color (default control background). Returns <c>Color(0, 0, 0, 0)</c> if the base color is unknown.</para>
    /// <para><b>Note:</b> This method is implemented on macOS and Windows.</para>
    /// </summary>
    public Color GetBaseColor()
    {
        return NativeCalls.godot_icall_0_196(MethodBind64, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind65 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSystemThemeChangeCallback, 1611583062ul);

    /// <summary>
    /// <para>Sets the <paramref name="callable"/> that should be called when system theme settings are changed. Callback method should have zero arguments.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS, macOS, Windows, and Linux (X11/Wayland).</para>
    /// </summary>
    public void SetSystemThemeChangeCallback(Callable callable)
    {
        NativeCalls.godot_icall_1_370(MethodBind65, GodotObject.GetPtr(this), callable);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind66 = ClassDB_get_method_with_compatibility(NativeName, MethodName.MouseSetMode, 348288463ul);

    /// <summary>
    /// <para>Sets the current mouse mode. See also <see cref="Godot.DisplayServerInstance.MouseGetMode()"/>.</para>
    /// </summary>
    public void MouseSetMode(DisplayServer.MouseMode mouseMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind66, GodotObject.GetPtr(this), (int)mouseMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind67 = ClassDB_get_method_with_compatibility(NativeName, MethodName.MouseGetMode, 1353961651ul);

    /// <summary>
    /// <para>Returns the current mouse mode. See also <see cref="Godot.DisplayServerInstance.MouseSetMode(DisplayServer.MouseMode)"/>.</para>
    /// </summary>
    public DisplayServer.MouseMode MouseGetMode()
    {
        return (DisplayServer.MouseMode)NativeCalls.godot_icall_0_37(MethodBind67, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind68 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WarpMouse, 1130785943ul);

    /// <summary>
    /// <para>Sets the mouse cursor position to the given <paramref name="position"/> relative to an origin at the upper left corner of the currently focused game Window Manager window.</para>
    /// <para><b>Note:</b> <see cref="Godot.DisplayServerInstance.WarpMouse(Vector2I)"/> is only supported on Windows, macOS, and Linux (X11/Wayland). It has no effect on Android, iOS, and Web.</para>
    /// </summary>
    public unsafe void WarpMouse(Vector2I position)
    {
        NativeCalls.godot_icall_1_32(MethodBind68, GodotObject.GetPtr(this), &position);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind69 = ClassDB_get_method_with_compatibility(NativeName, MethodName.MouseGetPosition, 3690982128ul);

    /// <summary>
    /// <para>Returns the mouse cursor's current position in screen coordinates.</para>
    /// </summary>
    public Vector2I MouseGetPosition()
    {
        return NativeCalls.godot_icall_0_33(MethodBind69, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind70 = ClassDB_get_method_with_compatibility(NativeName, MethodName.MouseGetButtonState, 2512161324ul);

    /// <summary>
    /// <para>Returns the current state of mouse buttons (whether each button is pressed) as a bitmask. If multiple mouse buttons are pressed at the same time, the bits are added together. Equivalent to <see cref="Godot.Input.GetMouseButtonMask()"/>.</para>
    /// </summary>
    public MouseButtonMask MouseGetButtonState()
    {
        return (MouseButtonMask)NativeCalls.godot_icall_0_37(MethodBind70, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind71 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipboardSet, 83702148ul);

    /// <summary>
    /// <para>Sets the user's clipboard content to the given string.</para>
    /// </summary>
    public void ClipboardSet(string clipboard)
    {
        NativeCalls.godot_icall_1_56(MethodBind71, GodotObject.GetPtr(this), clipboard);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind72 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipboardGet, 201670096ul);

    /// <summary>
    /// <para>Returns the user's clipboard as a string if possible.</para>
    /// </summary>
    public string ClipboardGet()
    {
        return NativeCalls.godot_icall_0_57(MethodBind72, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind73 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipboardGetImage, 4190603485ul);

    /// <summary>
    /// <para>Returns the user's clipboard as an image if possible.</para>
    /// <para><b>Note:</b> This method uses the copied pixel data, e.g. from a image editing software or a web browser, not an image file copied from file explorer.</para>
    /// </summary>
    public Image ClipboardGetImage()
    {
        return (Image)NativeCalls.godot_icall_0_58(MethodBind73, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind74 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipboardHas, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if there is a text content on the user's clipboard.</para>
    /// </summary>
    public bool ClipboardHas()
    {
        return NativeCalls.godot_icall_0_40(MethodBind74, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind75 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipboardHasImage, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if there is an image content on the user's clipboard.</para>
    /// </summary>
    public bool ClipboardHasImage()
    {
        return NativeCalls.godot_icall_0_40(MethodBind75, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind76 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipboardSetPrimary, 83702148ul);

    /// <summary>
    /// <para>Sets the user's <a href="https://unix.stackexchange.com/questions/139191/whats-the-difference-between-primary-selection-and-clipboard-buffer">primary</a> clipboard content to the given string. This is the clipboard that is set when the user selects text in any application, rather than when pressing Ctrl + C. The clipboard data can then be pasted by clicking the middle mouse button in any application that supports the primary clipboard mechanism.</para>
    /// <para><b>Note:</b> This method is only implemented on Linux (X11/Wayland).</para>
    /// </summary>
    public void ClipboardSetPrimary(string clipboardPrimary)
    {
        NativeCalls.godot_icall_1_56(MethodBind76, GodotObject.GetPtr(this), clipboardPrimary);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind77 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClipboardGetPrimary, 201670096ul);

    /// <summary>
    /// <para>Returns the user's <a href="https://unix.stackexchange.com/questions/139191/whats-the-difference-between-primary-selection-and-clipboard-buffer">primary</a> clipboard as a string if possible. This is the clipboard that is set when the user selects text in any application, rather than when pressing Ctrl + C. The clipboard data can then be pasted by clicking the middle mouse button in any application that supports the primary clipboard mechanism.</para>
    /// <para><b>Note:</b> This method is only implemented on Linux (X11/Wayland).</para>
    /// </summary>
    public string ClipboardGetPrimary()
    {
        return NativeCalls.godot_icall_0_57(MethodBind77, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind78 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDisplayCutouts, 3995934104ul);

    /// <summary>
    /// <para>Returns an <see cref="Godot.Collections.Array"/> of <see cref="Godot.Rect2"/>, each of which is the bounding rectangle for a display cutout or notch. These are non-functional areas on edge-to-edge screens used by cameras and sensors. Returns an empty array if the device does not have cutouts. See also <see cref="Godot.DisplayServerInstance.GetDisplaySafeArea()"/>.</para>
    /// <para><b>Note:</b> Currently only implemented on Android. Other platforms will return an empty array even if they do have display cutouts or notches.</para>
    /// </summary>
    public Godot.Collections.Array<Rect2> GetDisplayCutouts()
    {
        return new Godot.Collections.Array<Rect2>(NativeCalls.godot_icall_0_112(MethodBind78, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind79 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDisplaySafeArea, 410525958ul);

    /// <summary>
    /// <para>Returns the unobscured area of the display where interactive controls should be rendered. See also <see cref="Godot.DisplayServerInstance.GetDisplayCutouts()"/>.</para>
    /// </summary>
    public Rect2I GetDisplaySafeArea()
    {
        return NativeCalls.godot_icall_0_31(MethodBind79, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind80 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetScreenCount, 3905245786ul);

    /// <summary>
    /// <para>Returns the number of displays available.</para>
    /// </summary>
    public int GetScreenCount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind80, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind81 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPrimaryScreen, 3905245786ul);

    /// <summary>
    /// <para>Returns index of the primary screen.</para>
    /// </summary>
    public int GetPrimaryScreen()
    {
        return NativeCalls.godot_icall_0_37(MethodBind81, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind82 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetKeyboardFocusScreen, 3905245786ul);

    /// <summary>
    /// <para>Returns the index of the screen containing the window with the keyboard focus, or the primary screen if there's no focused window.</para>
    /// </summary>
    public int GetKeyboardFocusScreen()
    {
        return NativeCalls.godot_icall_0_37(MethodBind82, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind83 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetScreenFromRect, 741354659ul);

    /// <summary>
    /// <para>Returns index of the screen which contains specified rectangle.</para>
    /// </summary>
    public unsafe int GetScreenFromRect(Rect2 rect)
    {
        return NativeCalls.godot_icall_1_371(MethodBind83, GodotObject.GetPtr(this), &rect);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind84 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetPosition, 1725937825ul);

    /// <summary>
    /// <para>Returns the screen's top-left corner position in pixels. On multi-monitor setups, the screen position is relative to the virtual desktop area. On multi-monitor setups with different screen resolutions or orientations, the origin may be located outside any display like this:</para>
    /// <para><code>
    /// * (0, 0)        +-------+
    ///                 |       |
    /// +-------------+ |       |
    /// |             | |       |
    /// |             | |       |
    /// +-------------+ +-------+
    /// </code></para>
    /// <para>See also <see cref="Godot.DisplayServerInstance.ScreenGetSize(int)"/>.</para>
    /// <para><b>Note:</b> On Linux (Wayland) this method always returns <c>(0, 0)</c>.</para>
    /// </summary>
    public Vector2I ScreenGetPosition(int screen = -1)
    {
        return NativeCalls.godot_icall_1_372(MethodBind84, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind85 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetSize, 1725937825ul);

    /// <summary>
    /// <para>Returns the screen's size in pixels. See also <see cref="Godot.DisplayServerInstance.ScreenGetPosition(int)"/> and <see cref="Godot.DisplayServerInstance.ScreenGetUsableRect(int)"/>.</para>
    /// </summary>
    public Vector2I ScreenGetSize(int screen = -1)
    {
        return NativeCalls.godot_icall_1_372(MethodBind85, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind86 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetUsableRect, 2439012528ul);

    /// <summary>
    /// <para>Returns the portion of the screen that is not obstructed by a status bar in pixels. See also <see cref="Godot.DisplayServerInstance.ScreenGetSize(int)"/>.</para>
    /// </summary>
    public Rect2I ScreenGetUsableRect(int screen = -1)
    {
        return NativeCalls.godot_icall_1_373(MethodBind86, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind87 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetDpi, 181039630ul);

    /// <summary>
    /// <para>Returns the dots per inch density of the specified screen. If <paramref name="screen"/> is <see cref="Godot.DisplayServer.ScreenOfMainWindow"/> (the default value), a screen with the main window will be used.</para>
    /// <para><b>Note:</b> On macOS, returned value is inaccurate if fractional display scaling mode is used.</para>
    /// <para><b>Note:</b> On Android devices, the actual screen densities are grouped into six generalized densities:</para>
    /// <para><code>
    ///    ldpi - 120 dpi
    ///    mdpi - 160 dpi
    ///    hdpi - 240 dpi
    ///   xhdpi - 320 dpi
    ///  xxhdpi - 480 dpi
    /// xxxhdpi - 640 dpi
    /// </code></para>
    /// <para><b>Note:</b> This method is implemented on Android, Linux (X11/Wayland), macOS and Windows. Returns <c>72</c> on unsupported platforms.</para>
    /// </summary>
    public int ScreenGetDpi(int screen = -1)
    {
        return NativeCalls.godot_icall_1_69(MethodBind87, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind88 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetScale, 909105437ul);

    /// <summary>
    /// <para>Returns the scale factor of the specified screen by index.</para>
    /// <para><b>Note:</b> On macOS, the returned value is <c>2.0</c> for hiDPI (Retina) screens, and <c>1.0</c> for all other cases.</para>
    /// <para><b>Note:</b> On Linux (Wayland), the returned value is accurate only when <paramref name="screen"/> is <see cref="Godot.DisplayServer.ScreenOfMainWindow"/>. Due to API limitations, passing a direct index will return a rounded-up integer, if the screen has a fractional scale (e.g. <c>1.25</c> would get rounded up to <c>2.0</c>).</para>
    /// <para><b>Note:</b> This method is implemented only on macOS and Linux (Wayland).</para>
    /// </summary>
    public float ScreenGetScale(int screen = -1)
    {
        return NativeCalls.godot_icall_1_67(MethodBind88, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind89 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsTouchscreenAvailable, 3323674545ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if touch events are available (Android or iOS), the capability is detected on the Web platform or if <c>ProjectSettings.input_devices/pointing/emulate_touch_from_mouse</c> is <see langword="true"/>.</para>
    /// </summary>
    public bool IsTouchscreenAvailable()
    {
        return NativeCalls.godot_icall_0_40(MethodBind89, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind90 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetMaxScale, 1740695150ul);

    /// <summary>
    /// <para>Returns the greatest scale factor of all screens.</para>
    /// <para><b>Note:</b> On macOS returned value is <c>2.0</c> if there is at least one hiDPI (Retina) screen in the system, and <c>1.0</c> in all other cases.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    public float ScreenGetMaxScale()
    {
        return NativeCalls.godot_icall_0_63(MethodBind90, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind91 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetRefreshRate, 909105437ul);

    /// <summary>
    /// <para>Returns the current refresh rate of the specified screen. If <paramref name="screen"/> is <see cref="Godot.DisplayServer.ScreenOfMainWindow"/> (the default value), a screen with the main window will be used.</para>
    /// <para><b>Note:</b> Returns <c>-1.0</c> if the DisplayServer fails to find the refresh rate for the specified screen. On Web, <see cref="Godot.DisplayServerInstance.ScreenGetRefreshRate(int)"/> will always return <c>-1.0</c> as there is no way to retrieve the refresh rate on that platform.</para>
    /// <para>To fallback to a default refresh rate if the method fails, try:</para>
    /// <para><code>
    /// var refresh_rate = DisplayServer.screen_get_refresh_rate()
    /// if refresh_rate &lt; 0:
    ///     refresh_rate = 60.0
    /// </code></para>
    /// </summary>
    public float ScreenGetRefreshRate(int screen = -1)
    {
        return NativeCalls.godot_icall_1_67(MethodBind91, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind92 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetPixel, 1532707496ul);

    /// <summary>
    /// <para>Returns color of the display pixel at the <paramref name="position"/>.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11), macOS, and Windows.</para>
    /// <para><b>Note:</b> On macOS, this method requires "Screen Recording" permission, if permission is not granted it will return desktop wallpaper color.</para>
    /// </summary>
    public unsafe Color ScreenGetPixel(Vector2I position)
    {
        return NativeCalls.godot_icall_1_374(MethodBind92, GodotObject.GetPtr(this), &position);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind93 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetImage, 3813388802ul);

    /// <summary>
    /// <para>Returns screenshot of the <paramref name="screen"/>.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11), macOS, and Windows.</para>
    /// <para><b>Note:</b> On macOS, this method requires "Screen Recording" permission, if permission is not granted it will return desktop wallpaper color.</para>
    /// </summary>
    public Image ScreenGetImage(int screen = -1)
    {
        return (Image)NativeCalls.godot_icall_1_66(MethodBind93, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind94 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenSetOrientation, 2211511631ul);

    /// <summary>
    /// <para>Sets the <paramref name="screen"/>'s <paramref name="orientation"/>. See also <see cref="Godot.DisplayServerInstance.ScreenGetOrientation(int)"/>.</para>
    /// <para><b>Note:</b> On iOS, this method has no effect if <c>ProjectSettings.display/window/handheld/orientation</c> is not set to <see cref="Godot.DisplayServer.ScreenOrientation.Sensor"/>.</para>
    /// </summary>
    public void ScreenSetOrientation(DisplayServer.ScreenOrientation orientation, int screen = -1)
    {
        NativeCalls.godot_icall_2_73(MethodBind94, GodotObject.GetPtr(this), (int)orientation, screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind95 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetOrientation, 133818562ul);

    /// <summary>
    /// <para>Returns the <paramref name="screen"/>'s current orientation. See also <see cref="Godot.DisplayServerInstance.ScreenSetOrientation(DisplayServer.ScreenOrientation, int)"/>.</para>
    /// <para><b>Note:</b> This method is implemented on Android and iOS.</para>
    /// </summary>
    public DisplayServer.ScreenOrientation ScreenGetOrientation(int screen = -1)
    {
        return (DisplayServer.ScreenOrientation)NativeCalls.godot_icall_1_69(MethodBind95, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind96 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenSetKeepOn, 2586408642ul);

    /// <summary>
    /// <para>Sets whether the screen should never be turned off by the operating system's power-saving measures. See also <see cref="Godot.DisplayServerInstance.ScreenIsKeptOn()"/>.</para>
    /// </summary>
    public void ScreenSetKeepOn(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind96, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind97 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenIsKeptOn, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the screen should never be turned off by the operating system's power-saving measures. See also <see cref="Godot.DisplayServerInstance.ScreenSetKeepOn(bool)"/>.</para>
    /// </summary>
    public bool ScreenIsKeptOn()
    {
        return NativeCalls.godot_icall_0_40(MethodBind97, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind98 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetWindowList, 1930428628ul);

    /// <summary>
    /// <para>Returns the list of Godot window IDs belonging to this process.</para>
    /// <para><b>Note:</b> Native dialogs are not included in this list.</para>
    /// </summary>
    public int[] GetWindowList()
    {
        return NativeCalls.godot_icall_0_143(MethodBind98, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind99 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetWindowAtScreenPosition, 2485466453ul);

    /// <summary>
    /// <para>Returns the ID of the window at the specified screen <paramref name="position"/> (in pixels). On multi-monitor setups, the screen position is relative to the virtual desktop area. On multi-monitor setups with different screen resolutions or orientations, the origin may be located outside any display like this:</para>
    /// <para><code>
    /// * (0, 0)        +-------+
    ///                 |       |
    /// +-------------+ |       |
    /// |             | |       |
    /// |             | |       |
    /// +-------------+ +-------+
    /// </code></para>
    /// </summary>
    public unsafe int GetWindowAtScreenPosition(Vector2I position)
    {
        return NativeCalls.godot_icall_1_375(MethodBind99, GodotObject.GetPtr(this), &position);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind100 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetNativeHandle, 1096425680ul);

    /// <summary>
    /// <para>Returns internal structure pointers for use in plugins.</para>
    /// <para><b>Note:</b> This method is implemented on Android, Linux (X11/Wayland), macOS, and Windows.</para>
    /// </summary>
    public long WindowGetNativeHandle(DisplayServer.HandleType handleType, int windowId = 0)
    {
        return NativeCalls.godot_icall_2_376(MethodBind100, GodotObject.GetPtr(this), (int)handleType, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind101 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetActivePopup, 3905245786ul);

    /// <summary>
    /// <para>Returns ID of the active popup window, or <see cref="Godot.DisplayServer.InvalidWindowId"/> if there is none.</para>
    /// </summary>
    public int WindowGetActivePopup()
    {
        return NativeCalls.godot_icall_0_37(MethodBind101, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind102 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetPopupSafeRect, 3317281434ul);

    /// <summary>
    /// <para>Sets the bounding box of control, or menu item that was used to open the popup window, in the screen coordinate system. Clicking this area will not auto-close this popup.</para>
    /// </summary>
    public unsafe void WindowSetPopupSafeRect(int window, Rect2I rect)
    {
        NativeCalls.godot_icall_2_198(MethodBind102, GodotObject.GetPtr(this), window, &rect);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind103 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetPopupSafeRect, 2161169500ul);

    /// <summary>
    /// <para>Returns the bounding box of control, or menu item that was used to open the popup window, in the screen coordinate system.</para>
    /// </summary>
    public Rect2I WindowGetPopupSafeRect(int window)
    {
        return NativeCalls.godot_icall_1_373(MethodBind103, GodotObject.GetPtr(this), window);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind104 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetTitle, 441246282ul);

    /// <summary>
    /// <para>Sets the title of the given window to <paramref name="title"/>.</para>
    /// <para><b>Note:</b> It's recommended to change this value using <see cref="Godot.Window.Title"/> instead.</para>
    /// <para><b>Note:</b> Avoid changing the window title every frame, as this can cause performance issues on certain window managers. Try to change the window title only a few times per second at most.</para>
    /// </summary>
    public void WindowSetTitle(string title, int windowId = 0)
    {
        NativeCalls.godot_icall_2_367(MethodBind104, GodotObject.GetPtr(this), title, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind105 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetTitleSize, 2925301799ul);

    /// <summary>
    /// <para>Returns the estimated window title bar size (including text and window buttons) for the window specified by <paramref name="windowId"/> (in pixels). This method does not change the window title.</para>
    /// <para><b>Note:</b> This method is implemented on macOS and Windows.</para>
    /// </summary>
    public Vector2I WindowGetTitleSize(string title, int windowId = 0)
    {
        return NativeCalls.godot_icall_2_377(MethodBind105, GodotObject.GetPtr(this), title, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind106 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetMousePassthrough, 1993637420ul);

    /// <summary>
    /// <para>Sets a polygonal region of the window which accepts mouse events. Mouse events outside the region will be passed through.</para>
    /// <para>Passing an empty array will disable passthrough support (all mouse events will be intercepted by the window, which is the default behavior).</para>
    /// <para><code>
    /// // Set region, using Path2D node.
    /// DisplayServer.WindowSetMousePassthrough(GetNode&lt;Path2D&gt;("Path2D").Curve.GetBakedPoints());
    /// 
    /// // Set region, using Polygon2D node.
    /// DisplayServer.WindowSetMousePassthrough(GetNode&lt;Polygon2D&gt;("Polygon2D").Polygon);
    /// 
    /// // Reset region to default.
    /// DisplayServer.WindowSetMousePassthrough(new Vector2[] {});
    /// </code></para>
    /// <para><b>Note:</b> On Windows, the portion of a window that lies outside the region is not drawn, while on Linux (X11) and macOS it is.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11), macOS and Windows.</para>
    /// </summary>
    public void WindowSetMousePassthrough(Vector2[] region, int windowId = 0)
    {
        NativeCalls.godot_icall_2_378(MethodBind106, GodotObject.GetPtr(this), region, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind107 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetCurrentScreen, 1591665591ul);

    /// <summary>
    /// <para>Returns the screen the window specified by <paramref name="windowId"/> is currently positioned on. If the screen overlaps multiple displays, the screen where the window's center is located is returned. See also <see cref="Godot.DisplayServerInstance.WindowSetCurrentScreen(int, int)"/>.</para>
    /// </summary>
    public int WindowGetCurrentScreen(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_69(MethodBind107, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind108 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetCurrentScreen, 2230941749ul);

    /// <summary>
    /// <para>Moves the window specified by <paramref name="windowId"/> to the specified <paramref name="screen"/>. See also <see cref="Godot.DisplayServerInstance.WindowGetCurrentScreen(int)"/>.</para>
    /// </summary>
    public void WindowSetCurrentScreen(int screen, int windowId = 0)
    {
        NativeCalls.godot_icall_2_73(MethodBind108, GodotObject.GetPtr(this), screen, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind109 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetPosition, 763922886ul);

    /// <summary>
    /// <para>Returns the position of the client area of the given window on the screen.</para>
    /// </summary>
    public Vector2I WindowGetPosition(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_372(MethodBind109, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind110 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetPositionWithDecorations, 763922886ul);

    /// <summary>
    /// <para>Returns the position of the given window on the screen including the borders drawn by the operating system. See also <see cref="Godot.DisplayServerInstance.WindowGetPosition(int)"/>.</para>
    /// </summary>
    public Vector2I WindowGetPositionWithDecorations(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_372(MethodBind110, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind111 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetPosition, 2019273902ul);

    /// <summary>
    /// <para>Sets the position of the given window to <paramref name="position"/>. On multi-monitor setups, the screen position is relative to the virtual desktop area. On multi-monitor setups with different screen resolutions or orientations, the origin may be located outside any display like this:</para>
    /// <para><code>
    /// * (0, 0)        +-------+
    ///                 |       |
    /// +-------------+ |       |
    /// |             | |       |
    /// |             | |       |
    /// +-------------+ +-------+
    /// </code></para>
    /// <para>See also <see cref="Godot.DisplayServerInstance.WindowGetPosition(int)"/> and <see cref="Godot.DisplayServerInstance.WindowSetSize(Vector2I, int)"/>.</para>
    /// <para><b>Note:</b> It's recommended to change this value using <see cref="Godot.Window.Position"/> instead.</para>
    /// <para><b>Note:</b> On Linux (Wayland): this method is a no-op.</para>
    /// </summary>
    public unsafe void WindowSetPosition(Vector2I position, int windowId = 0)
    {
        NativeCalls.godot_icall_2_379(MethodBind111, GodotObject.GetPtr(this), &position, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind112 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetSize, 763922886ul);

    /// <summary>
    /// <para>Returns the size of the window specified by <paramref name="windowId"/> (in pixels), excluding the borders drawn by the operating system. This is also called the "client area". See also <see cref="Godot.DisplayServerInstance.WindowGetSizeWithDecorations(int)"/>, <see cref="Godot.DisplayServerInstance.WindowSetSize(Vector2I, int)"/> and <see cref="Godot.DisplayServerInstance.WindowGetPosition(int)"/>.</para>
    /// </summary>
    public Vector2I WindowGetSize(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_372(MethodBind112, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind113 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetSize, 2019273902ul);

    /// <summary>
    /// <para>Sets the size of the given window to <paramref name="size"/> (in pixels). See also <see cref="Godot.DisplayServerInstance.WindowGetSize(int)"/> and <see cref="Godot.DisplayServerInstance.WindowGetPosition(int)"/>.</para>
    /// <para><b>Note:</b> It's recommended to change this value using <see cref="Godot.Window.Size"/> instead.</para>
    /// </summary>
    public unsafe void WindowSetSize(Vector2I size, int windowId = 0)
    {
        NativeCalls.godot_icall_2_379(MethodBind113, GodotObject.GetPtr(this), &size, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind114 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetRectChangedCallback, 1091192925ul);

    /// <summary>
    /// <para>Sets the <paramref name="callback"/> that will be called when the window specified by <paramref name="windowId"/> is moved or resized.</para>
    /// <para><b>Warning:</b> Advanced users only! Adding such a callback to a <see cref="Godot.Window"/> node will override its default implementation, which can introduce bugs.</para>
    /// </summary>
    public void WindowSetRectChangedCallback(Callable callback, int windowId = 0)
    {
        NativeCalls.godot_icall_2_380(MethodBind114, GodotObject.GetPtr(this), callback, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind115 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetWindowEventCallback, 1091192925ul);

    /// <summary>
    /// <para>Sets the <paramref name="callback"/> that will be called when an event occurs in the window specified by <paramref name="windowId"/>.</para>
    /// <para><b>Warning:</b> Advanced users only! Adding such a callback to a <see cref="Godot.Window"/> node will override its default implementation, which can introduce bugs.</para>
    /// </summary>
    public void WindowSetWindowEventCallback(Callable callback, int windowId = 0)
    {
        NativeCalls.godot_icall_2_380(MethodBind115, GodotObject.GetPtr(this), callback, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind116 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetInputEventCallback, 1091192925ul);

    /// <summary>
    /// <para>Sets the <paramref name="callback"/> that should be called when any <see cref="Godot.InputEvent"/> is sent to the window specified by <paramref name="windowId"/>.</para>
    /// <para><b>Warning:</b> Advanced users only! Adding such a callback to a <see cref="Godot.Window"/> node will override its default implementation, which can introduce bugs.</para>
    /// </summary>
    public void WindowSetInputEventCallback(Callable callback, int windowId = 0)
    {
        NativeCalls.godot_icall_2_380(MethodBind116, GodotObject.GetPtr(this), callback, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind117 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetInputTextCallback, 1091192925ul);

    /// <summary>
    /// <para>Sets the <paramref name="callback"/> that should be called when text is entered using the virtual keyboard to the window specified by <paramref name="windowId"/>.</para>
    /// <para><b>Warning:</b> Advanced users only! Adding such a callback to a <see cref="Godot.Window"/> node will override its default implementation, which can introduce bugs.</para>
    /// </summary>
    public void WindowSetInputTextCallback(Callable callback, int windowId = 0)
    {
        NativeCalls.godot_icall_2_380(MethodBind117, GodotObject.GetPtr(this), callback, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind118 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetDropFilesCallback, 1091192925ul);

    /// <summary>
    /// <para>Sets the <paramref name="callback"/> that should be called when files are dropped from the operating system's file manager to the window specified by <paramref name="windowId"/>. <paramref name="callback"/> should take one <see cref="string"/>[] argument, which is the list of dropped files.</para>
    /// <para><b>Warning:</b> Advanced users only! Adding such a callback to a <see cref="Godot.Window"/> node will override its default implementation, which can introduce bugs.</para>
    /// <para><b>Note:</b> This method is implemented on Windows, macOS, Linux (X11/Wayland), and Web.</para>
    /// </summary>
    public void WindowSetDropFilesCallback(Callable callback, int windowId = 0)
    {
        NativeCalls.godot_icall_2_380(MethodBind118, GodotObject.GetPtr(this), callback, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind119 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetAttachedInstanceId, 1591665591ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.GodotObject.GetInstanceId()"/> of the <see cref="Godot.Window"/> the <paramref name="windowId"/> is attached to.</para>
    /// </summary>
    public ulong WindowGetAttachedInstanceId(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_381(MethodBind119, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind120 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetMaxSize, 763922886ul);

    /// <summary>
    /// <para>Returns the window's maximum size (in pixels). See also <see cref="Godot.DisplayServerInstance.WindowSetMaxSize(Vector2I, int)"/>.</para>
    /// </summary>
    public Vector2I WindowGetMaxSize(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_372(MethodBind120, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind121 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetMaxSize, 2019273902ul);

    /// <summary>
    /// <para>Sets the maximum size of the window specified by <paramref name="windowId"/> in pixels. Normally, the user will not be able to drag the window to make it larger than the specified size. See also <see cref="Godot.DisplayServerInstance.WindowGetMaxSize(int)"/>.</para>
    /// <para><b>Note:</b> It's recommended to change this value using <see cref="Godot.Window.MaxSize"/> instead.</para>
    /// <para><b>Note:</b> Using third-party tools, it is possible for users to disable window geometry restrictions and therefore bypass this limit.</para>
    /// </summary>
    public unsafe void WindowSetMaxSize(Vector2I maxSize, int windowId = 0)
    {
        NativeCalls.godot_icall_2_379(MethodBind121, GodotObject.GetPtr(this), &maxSize, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind122 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetMinSize, 763922886ul);

    /// <summary>
    /// <para>Returns the window's minimum size (in pixels). See also <see cref="Godot.DisplayServerInstance.WindowSetMinSize(Vector2I, int)"/>.</para>
    /// </summary>
    public Vector2I WindowGetMinSize(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_372(MethodBind122, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind123 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetMinSize, 2019273902ul);

    /// <summary>
    /// <para>Sets the minimum size for the given window to <paramref name="minSize"/> in pixels. Normally, the user will not be able to drag the window to make it smaller than the specified size. See also <see cref="Godot.DisplayServerInstance.WindowGetMinSize(int)"/>.</para>
    /// <para><b>Note:</b> It's recommended to change this value using <see cref="Godot.Window.MinSize"/> instead.</para>
    /// <para><b>Note:</b> By default, the main window has a minimum size of <c>Vector2i(64, 64)</c>. This prevents issues that can arise when the window is resized to a near-zero size.</para>
    /// <para><b>Note:</b> Using third-party tools, it is possible for users to disable window geometry restrictions and therefore bypass this limit.</para>
    /// </summary>
    public unsafe void WindowSetMinSize(Vector2I minSize, int windowId = 0)
    {
        NativeCalls.godot_icall_2_379(MethodBind123, GodotObject.GetPtr(this), &minSize, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind124 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetSizeWithDecorations, 763922886ul);

    /// <summary>
    /// <para>Returns the size of the window specified by <paramref name="windowId"/> (in pixels), including the borders drawn by the operating system. See also <see cref="Godot.DisplayServerInstance.WindowGetSize(int)"/>.</para>
    /// </summary>
    public Vector2I WindowGetSizeWithDecorations(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_372(MethodBind124, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind125 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetMode, 2185728461ul);

    /// <summary>
    /// <para>Returns the mode of the given window.</para>
    /// </summary>
    public DisplayServer.WindowMode WindowGetMode(int windowId = 0)
    {
        return (DisplayServer.WindowMode)NativeCalls.godot_icall_1_69(MethodBind125, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind126 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetMode, 1319965401ul);

    /// <summary>
    /// <para>Sets window mode for the given window to <paramref name="mode"/>. See <see cref="Godot.DisplayServer.WindowMode"/> for possible values and how each mode behaves.</para>
    /// <para><b>Note:</b> Setting the window to full screen forcibly sets the borderless flag to <see langword="true"/>, so make sure to set it back to <see langword="false"/> when not wanted.</para>
    /// </summary>
    public void WindowSetMode(DisplayServer.WindowMode mode, int windowId = 0)
    {
        NativeCalls.godot_icall_2_73(MethodBind126, GodotObject.GetPtr(this), (int)mode, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind127 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetFlag, 254894155ul);

    /// <summary>
    /// <para>Enables or disables the given window's given <paramref name="flag"/>. See <see cref="Godot.DisplayServer.WindowFlags"/> for possible values and their behavior.</para>
    /// </summary>
    public void WindowSetFlag(DisplayServer.WindowFlags flag, bool enabled, int windowId = 0)
    {
        NativeCalls.godot_icall_3_382(MethodBind127, GodotObject.GetPtr(this), (int)flag, enabled.ToGodotBool(), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind128 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetFlag, 802816991ul);

    /// <summary>
    /// <para>Returns the current value of the given window's <paramref name="flag"/>.</para>
    /// </summary>
    public bool WindowGetFlag(DisplayServer.WindowFlags flag, int windowId = 0)
    {
        return NativeCalls.godot_icall_2_38(MethodBind128, GodotObject.GetPtr(this), (int)flag, windowId).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind129 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetWindowButtonsOffset, 2019273902ul);

    /// <summary>
    /// <para>When <see cref="Godot.DisplayServer.WindowFlags.ExtendToTitle"/> flag is set, set offset to the center of the first titlebar button.</para>
    /// <para><b>Note:</b> This flag is implemented only on macOS.</para>
    /// </summary>
    public unsafe void WindowSetWindowButtonsOffset(Vector2I offset, int windowId = 0)
    {
        NativeCalls.godot_icall_2_379(MethodBind129, GodotObject.GetPtr(this), &offset, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind130 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetSafeTitleMargins, 2295066620ul);

    /// <summary>
    /// <para>Returns left margins (<c>x</c>), right margins (<c>y</c>) and height (<c>z</c>) of the title that are safe to use (contains no buttons or other elements) when <see cref="Godot.DisplayServer.WindowFlags.ExtendToTitle"/> flag is set.</para>
    /// </summary>
    public Vector3I WindowGetSafeTitleMargins(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_383(MethodBind130, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind131 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowRequestAttention, 1995695955ul);

    /// <summary>
    /// <para>Makes the window specified by <paramref name="windowId"/> request attention, which is materialized by the window title and taskbar entry blinking until the window is focused. This usually has no visible effect if the window is currently focused. The exact behavior varies depending on the operating system.</para>
    /// </summary>
    public void WindowRequestAttention(int windowId = 0)
    {
        NativeCalls.godot_icall_1_36(MethodBind131, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind132 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowMoveToForeground, 1995695955ul);

    /// <summary>
    /// <para>Moves the window specified by <paramref name="windowId"/> to the foreground, so that it is visible over other windows.</para>
    /// </summary>
    public void WindowMoveToForeground(int windowId = 0)
    {
        NativeCalls.godot_icall_1_36(MethodBind132, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind133 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowIsFocused, 1051549951ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the window specified by <paramref name="windowId"/> is focused.</para>
    /// </summary>
    public bool WindowIsFocused(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_75(MethodBind133, GodotObject.GetPtr(this), windowId).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind134 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowCanDraw, 1051549951ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if anything can be drawn in the window specified by <paramref name="windowId"/>, <see langword="false"/> otherwise. Using the <c>--disable-render-loop</c> command line argument or a headless build will return <see langword="false"/>.</para>
    /// </summary>
    public bool WindowCanDraw(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_75(MethodBind134, GodotObject.GetPtr(this), windowId).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind135 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetTransient, 3937882851ul);

    /// <summary>
    /// <para>Sets window transient parent. Transient window is will be destroyed with its transient parent and will return focus to their parent when closed. The transient window is displayed on top of a non-exclusive full-screen parent window. Transient windows can't enter full-screen mode.</para>
    /// <para><b>Note:</b> It's recommended to change this value using <see cref="Godot.Window.Transient"/> instead.</para>
    /// <para><b>Note:</b> The behavior might be different depending on the platform.</para>
    /// </summary>
    public void WindowSetTransient(int windowId, int parentWindowId)
    {
        NativeCalls.godot_icall_2_73(MethodBind135, GodotObject.GetPtr(this), windowId, parentWindowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind136 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetExclusive, 300928843ul);

    /// <summary>
    /// <para>If set to <see langword="true"/>, this window will always stay on top of its parent window, parent window will ignore input while this window is opened.</para>
    /// <para><b>Note:</b> On macOS, exclusive windows are confined to the same space (virtual desktop or screen) as the parent window.</para>
    /// <para><b>Note:</b> This method is implemented on macOS and Windows.</para>
    /// </summary>
    public void WindowSetExclusive(int windowId, bool exclusive)
    {
        NativeCalls.godot_icall_2_74(MethodBind136, GodotObject.GetPtr(this), windowId, exclusive.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind137 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetImeActive, 1661950165ul);

    /// <summary>
    /// <para>Sets whether <a href="https://en.wikipedia.org/wiki/Input_method">Input Method Editor</a> should be enabled for the window specified by <paramref name="windowId"/>. See also <see cref="Godot.DisplayServerInstance.WindowSetImePosition(Vector2I, int)"/>.</para>
    /// </summary>
    public void WindowSetImeActive(bool active, int windowId = 0)
    {
        NativeCalls.godot_icall_2_384(MethodBind137, GodotObject.GetPtr(this), active.ToGodotBool(), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind138 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetImePosition, 2019273902ul);

    /// <summary>
    /// <para>Sets the position of the <a href="https://en.wikipedia.org/wiki/Input_method">Input Method Editor</a> popup for the specified <paramref name="windowId"/>. Only effective if <see cref="Godot.DisplayServerInstance.WindowSetImeActive(bool, int)"/> was set to <see langword="true"/> for the specified <paramref name="windowId"/>.</para>
    /// </summary>
    public unsafe void WindowSetImePosition(Vector2I position, int windowId = 0)
    {
        NativeCalls.godot_icall_2_379(MethodBind138, GodotObject.GetPtr(this), &position, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind139 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowSetVsyncMode, 2179333492ul);

    /// <summary>
    /// <para>Sets the V-Sync mode of the given window. See also <c>ProjectSettings.display/window/vsync/vsync_mode</c>.</para>
    /// <para>See <see cref="Godot.DisplayServer.VSyncMode"/> for possible values and how they affect the behavior of your application.</para>
    /// <para>Depending on the platform and used renderer, the engine will fall back to <see cref="Godot.DisplayServer.VSyncMode.Enabled"/> if the desired mode is not supported.</para>
    /// <para><b>Note:</b> V-Sync modes other than <see cref="Godot.DisplayServer.VSyncMode.Enabled"/> are only supported in the Forward+ and Mobile rendering methods, not Compatibility.</para>
    /// </summary>
    public void WindowSetVsyncMode(DisplayServer.VSyncMode vsyncMode, int windowId = 0)
    {
        NativeCalls.godot_icall_2_73(MethodBind139, GodotObject.GetPtr(this), (int)vsyncMode, windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind140 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowGetVsyncMode, 578873795ul);

    /// <summary>
    /// <para>Returns the V-Sync mode of the given window.</para>
    /// </summary>
    public DisplayServer.VSyncMode WindowGetVsyncMode(int windowId = 0)
    {
        return (DisplayServer.VSyncMode)NativeCalls.godot_icall_1_69(MethodBind140, GodotObject.GetPtr(this), windowId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind141 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowIsMaximizeAllowed, 1051549951ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the given window can be maximized (the maximize button is enabled).</para>
    /// </summary>
    public bool WindowIsMaximizeAllowed(int windowId = 0)
    {
        return NativeCalls.godot_icall_1_75(MethodBind141, GodotObject.GetPtr(this), windowId).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind142 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowMaximizeOnTitleDblClick, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/>, if double-click on a window title should maximize it.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    public bool WindowMaximizeOnTitleDblClick()
    {
        return NativeCalls.godot_icall_0_40(MethodBind142, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind143 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WindowMinimizeOnTitleDblClick, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/>, if double-click on a window title should minimize it.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    public bool WindowMinimizeOnTitleDblClick()
    {
        return NativeCalls.godot_icall_0_40(MethodBind143, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind144 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ImeGetSelection, 3690982128ul);

    /// <summary>
    /// <para>Returns the text selection in the <a href="https://en.wikipedia.org/wiki/Input_method">Input Method Editor</a> composition string, with the <see cref="Godot.Vector2I"/>'s <c>x</c> component being the caret position and <c>y</c> being the length of the selection.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    public Vector2I ImeGetSelection()
    {
        return NativeCalls.godot_icall_0_33(MethodBind144, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind145 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ImeGetText, 201670096ul);

    /// <summary>
    /// <para>Returns the composition string contained within the <a href="https://en.wikipedia.org/wiki/Input_method">Input Method Editor</a> window.</para>
    /// <para><b>Note:</b> This method is implemented only on macOS.</para>
    /// </summary>
    public string ImeGetText()
    {
        return NativeCalls.godot_icall_0_57(MethodBind145, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind146 = ClassDB_get_method_with_compatibility(NativeName, MethodName.VirtualKeyboardShow, 3042891259ul);

    /// <summary>
    /// <para>Shows the virtual keyboard if the platform has one.</para>
    /// <para><paramref name="existingText"/> parameter is useful for implementing your own <see cref="Godot.LineEdit"/> or <see cref="Godot.TextEdit"/>, as it tells the virtual keyboard what text has already been typed (the virtual keyboard uses it for auto-correct and predictions).</para>
    /// <para><paramref name="position"/> parameter is the screen space <see cref="Godot.Rect2"/> of the edited text.</para>
    /// <para><paramref name="type"/> parameter allows configuring which type of virtual keyboard to show.</para>
    /// <para><paramref name="maxLength"/> limits the number of characters that can be entered if different from <c>-1</c>.</para>
    /// <para><paramref name="cursorStart"/> can optionally define the current text cursor position if <paramref name="cursorEnd"/> is not set.</para>
    /// <para><paramref name="cursorStart"/> and <paramref name="cursorEnd"/> can optionally define the current text selection.</para>
    /// <para><b>Note:</b> This method is implemented on Android, iOS and Web.</para>
    /// </summary>
    /// <param name="position">If the parameter is null, then the default value is <c>new Rect2(new Vector2(0, 0), new Vector2(0, 0))</c>.</param>
    public unsafe void VirtualKeyboardShow(string existingText, Nullable<Rect2> position = null, DisplayServer.VirtualKeyboardType type = (DisplayServer.VirtualKeyboardType)(0), int maxLength = -1, int cursorStart = -1, int cursorEnd = -1)
    {
        Rect2 positionOrDefVal = position.HasValue ? position.Value : new Rect2(new Vector2(0, 0), new Vector2(0, 0));
        NativeCalls.godot_icall_6_385(MethodBind146, GodotObject.GetPtr(this), existingText, &positionOrDefVal, (int)type, maxLength, cursorStart, cursorEnd);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind147 = ClassDB_get_method_with_compatibility(NativeName, MethodName.VirtualKeyboardHide, 3218959716ul);

    /// <summary>
    /// <para>Hides the virtual keyboard if it is shown, does nothing otherwise.</para>
    /// </summary>
    public void VirtualKeyboardHide()
    {
        NativeCalls.godot_icall_0_3(MethodBind147, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind148 = ClassDB_get_method_with_compatibility(NativeName, MethodName.VirtualKeyboardGetHeight, 3905245786ul);

    /// <summary>
    /// <para>Returns the on-screen keyboard's height in pixels. Returns 0 if there is no keyboard or if it is currently hidden.</para>
    /// </summary>
    public int VirtualKeyboardGetHeight()
    {
        return NativeCalls.godot_icall_0_37(MethodBind148, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind149 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CursorSetShape, 2026291549ul);

    /// <summary>
    /// <para>Sets the default mouse cursor shape. The cursor's appearance will vary depending on the user's operating system and mouse cursor theme. See also <see cref="Godot.DisplayServerInstance.CursorGetShape()"/> and <see cref="Godot.DisplayServerInstance.CursorSetCustomImage(Resource, DisplayServer.CursorShape, Nullable{Vector2})"/>.</para>
    /// </summary>
    public void CursorSetShape(DisplayServer.CursorShape shape)
    {
        NativeCalls.godot_icall_1_36(MethodBind149, GodotObject.GetPtr(this), (int)shape);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind150 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CursorGetShape, 1087724927ul);

    /// <summary>
    /// <para>Returns the default mouse cursor shape set by <see cref="Godot.DisplayServerInstance.CursorSetShape(DisplayServer.CursorShape)"/>.</para>
    /// </summary>
    public DisplayServer.CursorShape CursorGetShape()
    {
        return (DisplayServer.CursorShape)NativeCalls.godot_icall_0_37(MethodBind150, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind151 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CursorSetCustomImage, 1816663697ul);

    /// <summary>
    /// <para>Sets a custom mouse cursor image for the given <paramref name="shape"/>. This means the user's operating system and mouse cursor theme will no longer influence the mouse cursor's appearance.</para>
    /// <para><paramref name="cursor"/> can be either a <see cref="Godot.Texture2D"/> or an <see cref="Godot.Image"/>, and it should not be larger than 256×256 to display correctly. Optionally, <paramref name="hotspot"/> can be set to offset the image's position relative to the click point. By default, <paramref name="hotspot"/> is set to the top-left corner of the image. See also <see cref="Godot.DisplayServerInstance.CursorSetShape(DisplayServer.CursorShape)"/>.</para>
    /// </summary>
    /// <param name="hotspot">If the parameter is null, then the default value is <c>new Vector2(0, 0)</c>.</param>
    public unsafe void CursorSetCustomImage(Resource cursor, DisplayServer.CursorShape shape = (DisplayServer.CursorShape)(0), Nullable<Vector2> hotspot = null)
    {
        Vector2 hotspotOrDefVal = hotspot.HasValue ? hotspot.Value : new Vector2(0, 0);
        NativeCalls.godot_icall_3_386(MethodBind151, GodotObject.GetPtr(this), GodotObject.GetPtr(cursor), (int)shape, &hotspotOrDefVal);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind152 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSwapCancelOk, 2240911060ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if positions of <b>OK</b> and <b>Cancel</b> buttons are swapped in dialogs. This is enabled by default on Windows to follow interface conventions, and be toggled by changing <c>ProjectSettings.gui/common/swap_cancel_ok</c>.</para>
    /// <para><b>Note:</b> This doesn't affect native dialogs such as the ones spawned by <see cref="Godot.DisplayServer.DialogShow(string, string, string[], Callable)"/>.</para>
    /// </summary>
    public bool GetSwapCancelOk()
    {
        return NativeCalls.godot_icall_0_40(MethodBind152, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind153 = ClassDB_get_method_with_compatibility(NativeName, MethodName.EnableForStealingFocus, 1286410249ul);

    /// <summary>
    /// <para>Allows the <paramref name="processId"/> PID to steal focus from this window. In other words, this disables the operating system's focus stealing protection for the specified PID.</para>
    /// <para><b>Note:</b> This method is implemented only on Windows.</para>
    /// </summary>
    public void EnableForStealingFocus(long processId)
    {
        NativeCalls.godot_icall_1_10(MethodBind153, GodotObject.GetPtr(this), processId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind154 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DialogShow, 4115553226ul);

    /// <summary>
    /// <para>Shows a text dialog which uses the operating system's native look-and-feel. <paramref name="callback"/> should accept a single <see cref="int"/> parameter which corresponds to the index of the pressed button.</para>
    /// <para><b>Note:</b> This method is implemented if the display server has the <see cref="Godot.DisplayServer.Feature.NativeDialog"/> feature. Supported platforms include macOS and Windows.</para>
    /// </summary>
    public Error DialogShow(string title, string description, string[] buttons, Callable callback)
    {
        return (Error)NativeCalls.godot_icall_4_387(MethodBind154, GodotObject.GetPtr(this), title, description, buttons, callback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind155 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DialogInputText, 3088703427ul);

    /// <summary>
    /// <para>Shows a text input dialog which uses the operating system's native look-and-feel. <paramref name="callback"/> should accept a single <see cref="string"/> parameter which contains the text field's contents.</para>
    /// <para><b>Note:</b> This method is implemented if the display server has the <see cref="Godot.DisplayServer.Feature.NativeDialogInput"/> feature. Supported platforms include macOS and Windows.</para>
    /// </summary>
    public Error DialogInputText(string title, string description, string existingText, Callable callback)
    {
        return (Error)NativeCalls.godot_icall_4_388(MethodBind155, GodotObject.GetPtr(this), title, description, existingText, callback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind156 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FileDialogShow, 1531299078ul);

    /// <summary>
    /// <para>Displays OS native dialog for selecting files or directories in the file system.</para>
    /// <para>Each filter string in the <paramref name="filters"/> array should be formatted like this: <c>*.txt,*.doc;Text Files</c>. The description text of the filter is optional and can be omitted. See also <see cref="Godot.FileDialog.Filters"/>.</para>
    /// <para>Callbacks have the following arguments: <c>status: bool, selected_paths: PackedStringArray, selected_filter_index: int</c>.</para>
    /// <para><b>Note:</b> This method is implemented if the display server has the <see cref="Godot.DisplayServer.Feature.NativeDialogFile"/> feature. Supported platforms include Linux (X11/Wayland), Windows, and macOS.</para>
    /// <para><b>Note:</b> <paramref name="currentDirectory"/> might be ignored.</para>
    /// <para><b>Note:</b> On Linux, <paramref name="showHidden"/> is ignored.</para>
    /// <para><b>Note:</b> On macOS, native file dialogs have no title.</para>
    /// <para><b>Note:</b> On macOS, sandboxed apps will save security-scoped bookmarks to retain access to the opened folders across multiple sessions. Use <see cref="Godot.OS.GetGrantedPermissions()"/> to get a list of saved bookmarks.</para>
    /// </summary>
    public Error FileDialogShow(string title, string currentDirectory, string fileName, bool showHidden, DisplayServer.FileDialogMode mode, string[] filters, Callable callback)
    {
        return (Error)NativeCalls.godot_icall_7_389(MethodBind156, GodotObject.GetPtr(this), title, currentDirectory, fileName, showHidden.ToGodotBool(), (int)mode, filters, callback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind157 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FileDialogWithOptionsShow, 1305318754ul);

    /// <summary>
    /// <para>Displays OS native dialog for selecting files or directories in the file system with additional user selectable options.</para>
    /// <para>Each filter string in the <paramref name="filters"/> array should be formatted like this: <c>*.txt,*.doc;Text Files</c>. The description text of the filter is optional and can be omitted. See also <see cref="Godot.FileDialog.Filters"/>.</para>
    /// <para><paramref name="options"/> is array of <see cref="Godot.Collections.Dictionary"/>s with the following keys:</para>
    /// <para>- <c>"name"</c> - option's name <see cref="string"/>.</para>
    /// <para>- <c>"values"</c> - <see cref="string"/>[] of values. If empty, boolean option (check box) is used.</para>
    /// <para>- <c>"default"</c> - default selected option index (<see cref="int"/>) or default boolean value (<see cref="bool"/>).</para>
    /// <para>Callbacks have the following arguments: <c>status: bool, selected_paths: PackedStringArray, selected_filter_index: int, selected_option: Dictionary</c>.</para>
    /// <para><b>Note:</b> This method is implemented if the display server has the <see cref="Godot.DisplayServer.Feature.NativeDialogFile"/> feature. Supported platforms include Linux (X11/Wayland), Windows, and macOS.</para>
    /// <para><b>Note:</b> <paramref name="currentDirectory"/> might be ignored.</para>
    /// <para><b>Note:</b> On Linux (X11), <paramref name="showHidden"/> is ignored.</para>
    /// <para><b>Note:</b> On macOS, native file dialogs have no title.</para>
    /// <para><b>Note:</b> On macOS, sandboxed apps will save security-scoped bookmarks to retain access to the opened folders across multiple sessions. Use <see cref="Godot.OS.GetGrantedPermissions()"/> to get a list of saved bookmarks.</para>
    /// </summary>
    public Error FileDialogWithOptionsShow(string title, string currentDirectory, string root, string fileName, bool showHidden, DisplayServer.FileDialogMode mode, string[] filters, Godot.Collections.Array<Godot.Collections.Dictionary> options, Callable callback)
    {
        return (Error)NativeCalls.godot_icall_9_390(MethodBind157, GodotObject.GetPtr(this), title, currentDirectory, root, fileName, showHidden.ToGodotBool(), (int)mode, filters, (godot_array)(options ?? new()).NativeValue, callback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind158 = ClassDB_get_method_with_compatibility(NativeName, MethodName.KeyboardGetLayoutCount, 3905245786ul);

    /// <summary>
    /// <para>Returns the number of keyboard layouts.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11/Wayland), macOS and Windows.</para>
    /// </summary>
    public int KeyboardGetLayoutCount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind158, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind159 = ClassDB_get_method_with_compatibility(NativeName, MethodName.KeyboardGetCurrentLayout, 3905245786ul);

    /// <summary>
    /// <para>Returns active keyboard layout index.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11/Wayland), macOS, and Windows.</para>
    /// </summary>
    public int KeyboardGetCurrentLayout()
    {
        return NativeCalls.godot_icall_0_37(MethodBind159, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind160 = ClassDB_get_method_with_compatibility(NativeName, MethodName.KeyboardSetCurrentLayout, 1286410249ul);

    /// <summary>
    /// <para>Sets the active keyboard layout.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11/Wayland), macOS and Windows.</para>
    /// </summary>
    public void KeyboardSetCurrentLayout(int index)
    {
        NativeCalls.godot_icall_1_36(MethodBind160, GodotObject.GetPtr(this), index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind161 = ClassDB_get_method_with_compatibility(NativeName, MethodName.KeyboardGetLayoutLanguage, 844755477ul);

    /// <summary>
    /// <para>Returns the ISO-639/BCP-47 language code of the keyboard layout at position <paramref name="index"/>.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11/Wayland), macOS and Windows.</para>
    /// </summary>
    public string KeyboardGetLayoutLanguage(int index)
    {
        return NativeCalls.godot_icall_1_126(MethodBind161, GodotObject.GetPtr(this), index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind162 = ClassDB_get_method_with_compatibility(NativeName, MethodName.KeyboardGetLayoutName, 844755477ul);

    /// <summary>
    /// <para>Returns the localized name of the keyboard layout at position <paramref name="index"/>.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11/Wayland), macOS and Windows.</para>
    /// </summary>
    public string KeyboardGetLayoutName(int index)
    {
        return NativeCalls.godot_icall_1_126(MethodBind162, GodotObject.GetPtr(this), index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind163 = ClassDB_get_method_with_compatibility(NativeName, MethodName.KeyboardGetKeycodeFromPhysical, 3447613187ul);

    /// <summary>
    /// <para>Converts a physical (US QWERTY) <paramref name="keycode"/> to one in the active keyboard layout.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11/Wayland), macOS and Windows.</para>
    /// </summary>
    public Key KeyboardGetKeycodeFromPhysical(Key keycode)
    {
        return (Key)NativeCalls.godot_icall_1_69(MethodBind163, GodotObject.GetPtr(this), (int)keycode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind164 = ClassDB_get_method_with_compatibility(NativeName, MethodName.KeyboardGetLabelFromPhysical, 3447613187ul);

    /// <summary>
    /// <para>Converts a physical (US QWERTY) <paramref name="keycode"/> to localized label printed on the key in the active keyboard layout.</para>
    /// <para><b>Note:</b> This method is implemented on Linux (X11/Wayland), macOS and Windows.</para>
    /// </summary>
    public Key KeyboardGetLabelFromPhysical(Key keycode)
    {
        return (Key)NativeCalls.godot_icall_1_69(MethodBind164, GodotObject.GetPtr(this), (int)keycode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind165 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ProcessEvents, 3218959716ul);

    /// <summary>
    /// <para>Perform window manager processing, including input flushing. See also <see cref="Godot.DisplayServerInstance.ForceProcessAndDropEvents()"/>, <see cref="Godot.Input.FlushBufferedEvents()"/> and <see cref="Godot.Input.UseAccumulatedInput"/>.</para>
    /// </summary>
    public void ProcessEvents()
    {
        NativeCalls.godot_icall_0_3(MethodBind165, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind166 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ForceProcessAndDropEvents, 3218959716ul);

    /// <summary>
    /// <para>Forces window manager processing while ignoring all <see cref="Godot.InputEvent"/>s. See also <see cref="Godot.DisplayServerInstance.ProcessEvents()"/>.</para>
    /// <para><b>Note:</b> This method is implemented on Windows and macOS.</para>
    /// </summary>
    public void ForceProcessAndDropEvents()
    {
        NativeCalls.godot_icall_0_3(MethodBind166, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind167 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNativeIcon, 83702148ul);

    /// <summary>
    /// <para>Sets the window icon (usually displayed in the top-left corner) in the operating system's <i>native</i> format. The file at <paramref name="fileName"/> must be in <c>.ico</c> format on Windows or <c>.icns</c> on macOS. By using specially crafted <c>.ico</c> or <c>.icns</c> icons, <see cref="Godot.DisplayServerInstance.SetNativeIcon(string)"/> allows specifying different icons depending on the size the icon is displayed at. This size is determined by the operating system and user preferences (including the display scale factor). To use icons in other formats, use <see cref="Godot.DisplayServerInstance.SetIcon(Image)"/> instead.</para>
    /// <para><b>Note:</b> Requires support for <see cref="Godot.DisplayServer.Feature.NativeIcon"/>.</para>
    /// </summary>
    public void SetNativeIcon(string fileName)
    {
        NativeCalls.godot_icall_1_56(MethodBind167, GodotObject.GetPtr(this), fileName);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind168 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetIcon, 532598488ul);

    /// <summary>
    /// <para>Sets the window icon (usually displayed in the top-left corner) with an <see cref="Godot.Image"/>. To use icons in the operating system's native format, use <see cref="Godot.DisplayServerInstance.SetNativeIcon(string)"/> instead.</para>
    /// <para><b>Note:</b> Requires support for <see cref="Godot.DisplayServer.Feature.Icon"/>.</para>
    /// </summary>
    public void SetIcon(Image image)
    {
        NativeCalls.godot_icall_1_55(MethodBind168, GodotObject.GetPtr(this), GodotObject.GetPtr(image));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind169 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CreateStatusIndicator, 1904285171ul);

    /// <summary>
    /// <para>Creates a new application status indicator with the specified icon, tooltip, and activation callback.</para>
    /// <para><paramref name="callback"/> should take two arguments: the pressed mouse button (one of the <see cref="Godot.MouseButton"/> constants) and the click position in screen coordinates (a <see cref="Godot.Vector2I"/>).</para>
    /// </summary>
    public int CreateStatusIndicator(Texture2D icon, string tooltip, Callable callback)
    {
        return NativeCalls.godot_icall_3_391(MethodBind169, GodotObject.GetPtr(this), GodotObject.GetPtr(icon), tooltip, callback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind170 = ClassDB_get_method_with_compatibility(NativeName, MethodName.StatusIndicatorSetIcon, 666127730ul);

    /// <summary>
    /// <para>Sets the application status indicator icon.</para>
    /// <para><b>Note:</b> This method is implemented on macOS and Windows.</para>
    /// </summary>
    public void StatusIndicatorSetIcon(int id, Texture2D icon)
    {
        NativeCalls.godot_icall_2_65(MethodBind170, GodotObject.GetPtr(this), id, GodotObject.GetPtr(icon));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind171 = ClassDB_get_method_with_compatibility(NativeName, MethodName.StatusIndicatorSetTooltip, 501894301ul);

    /// <summary>
    /// <para>Sets the application status indicator tooltip.</para>
    /// <para><b>Note:</b> This method is implemented on macOS and Windows.</para>
    /// </summary>
    public void StatusIndicatorSetTooltip(int id, string tooltip)
    {
        NativeCalls.godot_icall_2_167(MethodBind171, GodotObject.GetPtr(this), id, tooltip);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind172 = ClassDB_get_method_with_compatibility(NativeName, MethodName.StatusIndicatorSetMenu, 4040184819ul);

    /// <summary>
    /// <para>Sets the application status indicator native popup menu.</para>
    /// <para><b>Note:</b> On macOS, the menu is activated by any mouse button. Its activation callback is <i>not</i> triggered.</para>
    /// <para><b>Note:</b> On Windows, the menu is activated by the right mouse button, selecting the status icon and pressing Shift + F10, or the applications key. The menu's activation callback for the other mouse buttons is still triggered.</para>
    /// <para><b>Note:</b> Native popup is only supported if <see cref="Godot.NativeMenu"/> supports the <see cref="Godot.NativeMenu.Feature.PopupMenu"/> feature.</para>
    /// </summary>
    public void StatusIndicatorSetMenu(int id, Rid menuRid)
    {
        NativeCalls.godot_icall_2_392(MethodBind172, GodotObject.GetPtr(this), id, menuRid);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind173 = ClassDB_get_method_with_compatibility(NativeName, MethodName.StatusIndicatorSetCallback, 957362965ul);

    /// <summary>
    /// <para>Sets the application status indicator activation callback. <paramref name="callback"/> should take two arguments: <see cref="int"/> mouse button index (one of <see cref="Godot.MouseButton"/> values) and <see cref="Godot.Vector2I"/> click position in screen coordinates.</para>
    /// <para><b>Note:</b> This method is implemented on macOS and Windows.</para>
    /// </summary>
    public void StatusIndicatorSetCallback(int id, Callable callback)
    {
        NativeCalls.godot_icall_2_369(MethodBind173, GodotObject.GetPtr(this), id, callback);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind174 = ClassDB_get_method_with_compatibility(NativeName, MethodName.StatusIndicatorGetRect, 3327874267ul);

    /// <summary>
    /// <para>Returns the rectangle for the given status indicator <paramref name="id"/> in screen coordinates. If the status indicator is not visible, returns an empty <see cref="Godot.Rect2"/>.</para>
    /// <para><b>Note:</b> This method is implemented on macOS and Windows.</para>
    /// </summary>
    public Rect2 StatusIndicatorGetRect(int id)
    {
        return NativeCalls.godot_icall_1_393(MethodBind174, GodotObject.GetPtr(this), id);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind175 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DeleteStatusIndicator, 1286410249ul);

    /// <summary>
    /// <para>Removes the application status indicator.</para>
    /// </summary>
    public void DeleteStatusIndicator(int id)
    {
        NativeCalls.godot_icall_1_36(MethodBind175, GodotObject.GetPtr(this), id);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind176 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TabletGetDriverCount, 3905245786ul);

    /// <summary>
    /// <para>Returns the total number of available tablet drivers.</para>
    /// <para><b>Note:</b> This method is implemented only on Windows.</para>
    /// </summary>
    public int TabletGetDriverCount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind176, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind177 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TabletGetDriverName, 844755477ul);

    /// <summary>
    /// <para>Returns the tablet driver name for the given index.</para>
    /// <para><b>Note:</b> This method is implemented only on Windows.</para>
    /// </summary>
    public string TabletGetDriverName(int idx)
    {
        return NativeCalls.godot_icall_1_126(MethodBind177, GodotObject.GetPtr(this), idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind178 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TabletGetCurrentDriver, 201670096ul);

    /// <summary>
    /// <para>Returns current active tablet driver name.</para>
    /// <para><b>Note:</b> This method is implemented only on Windows.</para>
    /// </summary>
    public string TabletGetCurrentDriver()
    {
        return NativeCalls.godot_icall_0_57(MethodBind178, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind179 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TabletSetCurrentDriver, 83702148ul);

    /// <summary>
    /// <para>Set active tablet driver name.</para>
    /// <para>Supported drivers:</para>
    /// <para>- <c>winink</c>: Windows Ink API, default (Windows 8.1+ required).</para>
    /// <para>- <c>wintab</c>: Wacom Wintab API (compatible device driver required).</para>
    /// <para>- <c>dummy</c>: Dummy driver, tablet input is disabled.</para>
    /// <para><b>Note:</b> This method is implemented only on Windows.</para>
    /// </summary>
    public void TabletSetCurrentDriver(string name)
    {
        NativeCalls.godot_icall_1_56(MethodBind179, GodotObject.GetPtr(this), name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind180 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsWindowTransparencyAvailable, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the window background can be made transparent. This method returns <see langword="false"/> if <c>ProjectSettings.display/window/per_pixel_transparency/allowed</c> is set to <see langword="false"/>, or if transparency is not supported by the renderer or OS compositor.</para>
    /// </summary>
    public bool IsWindowTransparencyAvailable()
    {
        return NativeCalls.godot_icall_0_40(MethodBind180, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind181 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RegisterAdditionalOutput, 3975164845ul);

    /// <summary>
    /// <para>Registers an <see cref="Godot.GodotObject"/> which represents an additional output that will be rendered too, beyond normal windows. The <see cref="Godot.GodotObject"/> is only used as an identifier, which can be later passed to <see cref="Godot.DisplayServerInstance.UnregisterAdditionalOutput(GodotObject)"/>.</para>
    /// <para>This can be used to prevent Godot from skipping rendering when no normal windows are visible.</para>
    /// </summary>
    public void RegisterAdditionalOutput(GodotObject @object)
    {
        NativeCalls.godot_icall_1_55(MethodBind181, GodotObject.GetPtr(this), GodotObject.GetPtr(@object));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind182 = ClassDB_get_method_with_compatibility(NativeName, MethodName.UnregisterAdditionalOutput, 3975164845ul);

    /// <summary>
    /// <para>Unregisters an <see cref="Godot.GodotObject"/> representing an additional output, that was registered via <see cref="Godot.DisplayServerInstance.RegisterAdditionalOutput(GodotObject)"/>.</para>
    /// </summary>
    public void UnregisterAdditionalOutput(GodotObject @object)
    {
        NativeCalls.godot_icall_1_55(MethodBind182, GodotObject.GetPtr(this), GodotObject.GetPtr(@object));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind183 = ClassDB_get_method_with_compatibility(NativeName, MethodName.HasAdditionalOutputs, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if any additional outputs have been registered via <see cref="Godot.DisplayServerInstance.RegisterAdditionalOutput(GodotObject)"/>.</para>
    /// </summary>
    public bool HasAdditionalOutputs()
    {
        return NativeCalls.godot_icall_0_40(MethodBind183, GodotObject.GetPtr(this)).ToBool();
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
        /// Cached name for the 'has_feature' method.
        /// </summary>
        public static readonly StringName HasFeature = "has_feature";
        /// <summary>
        /// Cached name for the 'get_name' method.
        /// </summary>
        public static readonly StringName GetName = "get_name";
        /// <summary>
        /// Cached name for the 'help_set_search_callbacks' method.
        /// </summary>
        public static readonly StringName HelpSetSearchCallbacks = "help_set_search_callbacks";
        /// <summary>
        /// Cached name for the 'global_menu_set_popup_callbacks' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetPopupCallbacks = "global_menu_set_popup_callbacks";
        /// <summary>
        /// Cached name for the 'global_menu_add_submenu_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddSubmenuItem = "global_menu_add_submenu_item";
        /// <summary>
        /// Cached name for the 'global_menu_add_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddItem = "global_menu_add_item";
        /// <summary>
        /// Cached name for the 'global_menu_add_check_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddCheckItem = "global_menu_add_check_item";
        /// <summary>
        /// Cached name for the 'global_menu_add_icon_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddIconItem = "global_menu_add_icon_item";
        /// <summary>
        /// Cached name for the 'global_menu_add_icon_check_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddIconCheckItem = "global_menu_add_icon_check_item";
        /// <summary>
        /// Cached name for the 'global_menu_add_radio_check_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddRadioCheckItem = "global_menu_add_radio_check_item";
        /// <summary>
        /// Cached name for the 'global_menu_add_icon_radio_check_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddIconRadioCheckItem = "global_menu_add_icon_radio_check_item";
        /// <summary>
        /// Cached name for the 'global_menu_add_multistate_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddMultistateItem = "global_menu_add_multistate_item";
        /// <summary>
        /// Cached name for the 'global_menu_add_separator' method.
        /// </summary>
        public static readonly StringName GlobalMenuAddSeparator = "global_menu_add_separator";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_index_from_text' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemIndexFromText = "global_menu_get_item_index_from_text";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_index_from_tag' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemIndexFromTag = "global_menu_get_item_index_from_tag";
        /// <summary>
        /// Cached name for the 'global_menu_is_item_checked' method.
        /// </summary>
        public static readonly StringName GlobalMenuIsItemChecked = "global_menu_is_item_checked";
        /// <summary>
        /// Cached name for the 'global_menu_is_item_checkable' method.
        /// </summary>
        public static readonly StringName GlobalMenuIsItemCheckable = "global_menu_is_item_checkable";
        /// <summary>
        /// Cached name for the 'global_menu_is_item_radio_checkable' method.
        /// </summary>
        public static readonly StringName GlobalMenuIsItemRadioCheckable = "global_menu_is_item_radio_checkable";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_callback' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemCallback = "global_menu_get_item_callback";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_key_callback' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemKeyCallback = "global_menu_get_item_key_callback";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_tag' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemTag = "global_menu_get_item_tag";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_text' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemText = "global_menu_get_item_text";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_submenu' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemSubmenu = "global_menu_get_item_submenu";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_accelerator' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemAccelerator = "global_menu_get_item_accelerator";
        /// <summary>
        /// Cached name for the 'global_menu_is_item_disabled' method.
        /// </summary>
        public static readonly StringName GlobalMenuIsItemDisabled = "global_menu_is_item_disabled";
        /// <summary>
        /// Cached name for the 'global_menu_is_item_hidden' method.
        /// </summary>
        public static readonly StringName GlobalMenuIsItemHidden = "global_menu_is_item_hidden";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_tooltip' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemTooltip = "global_menu_get_item_tooltip";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_state' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemState = "global_menu_get_item_state";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_max_states' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemMaxStates = "global_menu_get_item_max_states";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_icon' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemIcon = "global_menu_get_item_icon";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_indentation_level' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemIndentationLevel = "global_menu_get_item_indentation_level";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_checked' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemChecked = "global_menu_set_item_checked";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_checkable' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemCheckable = "global_menu_set_item_checkable";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_radio_checkable' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemRadioCheckable = "global_menu_set_item_radio_checkable";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_callback' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemCallback = "global_menu_set_item_callback";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_hover_callbacks' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemHoverCallbacks = "global_menu_set_item_hover_callbacks";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_key_callback' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemKeyCallback = "global_menu_set_item_key_callback";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_tag' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemTag = "global_menu_set_item_tag";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_text' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemText = "global_menu_set_item_text";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_submenu' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemSubmenu = "global_menu_set_item_submenu";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_accelerator' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemAccelerator = "global_menu_set_item_accelerator";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_disabled' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemDisabled = "global_menu_set_item_disabled";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_hidden' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemHidden = "global_menu_set_item_hidden";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_tooltip' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemTooltip = "global_menu_set_item_tooltip";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_state' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemState = "global_menu_set_item_state";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_max_states' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemMaxStates = "global_menu_set_item_max_states";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_icon' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemIcon = "global_menu_set_item_icon";
        /// <summary>
        /// Cached name for the 'global_menu_set_item_indentation_level' method.
        /// </summary>
        public static readonly StringName GlobalMenuSetItemIndentationLevel = "global_menu_set_item_indentation_level";
        /// <summary>
        /// Cached name for the 'global_menu_get_item_count' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetItemCount = "global_menu_get_item_count";
        /// <summary>
        /// Cached name for the 'global_menu_remove_item' method.
        /// </summary>
        public static readonly StringName GlobalMenuRemoveItem = "global_menu_remove_item";
        /// <summary>
        /// Cached name for the 'global_menu_clear' method.
        /// </summary>
        public static readonly StringName GlobalMenuClear = "global_menu_clear";
        /// <summary>
        /// Cached name for the 'global_menu_get_system_menu_roots' method.
        /// </summary>
        public static readonly StringName GlobalMenuGetSystemMenuRoots = "global_menu_get_system_menu_roots";
        /// <summary>
        /// Cached name for the 'tts_is_speaking' method.
        /// </summary>
        public static readonly StringName TtsIsSpeaking = "tts_is_speaking";
        /// <summary>
        /// Cached name for the 'tts_is_paused' method.
        /// </summary>
        public static readonly StringName TtsIsPaused = "tts_is_paused";
        /// <summary>
        /// Cached name for the 'tts_get_voices' method.
        /// </summary>
        public static readonly StringName TtsGetVoices = "tts_get_voices";
        /// <summary>
        /// Cached name for the 'tts_get_voices_for_language' method.
        /// </summary>
        public static readonly StringName TtsGetVoicesForLanguage = "tts_get_voices_for_language";
        /// <summary>
        /// Cached name for the 'tts_speak' method.
        /// </summary>
        public static readonly StringName TtsSpeak = "tts_speak";
        /// <summary>
        /// Cached name for the 'tts_pause' method.
        /// </summary>
        public static readonly StringName TtsPause = "tts_pause";
        /// <summary>
        /// Cached name for the 'tts_resume' method.
        /// </summary>
        public static readonly StringName TtsResume = "tts_resume";
        /// <summary>
        /// Cached name for the 'tts_stop' method.
        /// </summary>
        public static readonly StringName TtsStop = "tts_stop";
        /// <summary>
        /// Cached name for the 'tts_set_utterance_callback' method.
        /// </summary>
        public static readonly StringName TtsSetUtteranceCallback = "tts_set_utterance_callback";
        /// <summary>
        /// Cached name for the 'is_dark_mode_supported' method.
        /// </summary>
        public static readonly StringName IsDarkModeSupported = "is_dark_mode_supported";
        /// <summary>
        /// Cached name for the 'is_dark_mode' method.
        /// </summary>
        public static readonly StringName IsDarkMode = "is_dark_mode";
        /// <summary>
        /// Cached name for the 'get_accent_color' method.
        /// </summary>
        public static readonly StringName GetAccentColor = "get_accent_color";
        /// <summary>
        /// Cached name for the 'get_base_color' method.
        /// </summary>
        public static readonly StringName GetBaseColor = "get_base_color";
        /// <summary>
        /// Cached name for the 'set_system_theme_change_callback' method.
        /// </summary>
        public static readonly StringName SetSystemThemeChangeCallback = "set_system_theme_change_callback";
        /// <summary>
        /// Cached name for the 'mouse_set_mode' method.
        /// </summary>
        public static readonly StringName MouseSetMode = "mouse_set_mode";
        /// <summary>
        /// Cached name for the 'mouse_get_mode' method.
        /// </summary>
        public static readonly StringName MouseGetMode = "mouse_get_mode";
        /// <summary>
        /// Cached name for the 'warp_mouse' method.
        /// </summary>
        public static readonly StringName WarpMouse = "warp_mouse";
        /// <summary>
        /// Cached name for the 'mouse_get_position' method.
        /// </summary>
        public static readonly StringName MouseGetPosition = "mouse_get_position";
        /// <summary>
        /// Cached name for the 'mouse_get_button_state' method.
        /// </summary>
        public static readonly StringName MouseGetButtonState = "mouse_get_button_state";
        /// <summary>
        /// Cached name for the 'clipboard_set' method.
        /// </summary>
        public static readonly StringName ClipboardSet = "clipboard_set";
        /// <summary>
        /// Cached name for the 'clipboard_get' method.
        /// </summary>
        public static readonly StringName ClipboardGet = "clipboard_get";
        /// <summary>
        /// Cached name for the 'clipboard_get_image' method.
        /// </summary>
        public static readonly StringName ClipboardGetImage = "clipboard_get_image";
        /// <summary>
        /// Cached name for the 'clipboard_has' method.
        /// </summary>
        public static readonly StringName ClipboardHas = "clipboard_has";
        /// <summary>
        /// Cached name for the 'clipboard_has_image' method.
        /// </summary>
        public static readonly StringName ClipboardHasImage = "clipboard_has_image";
        /// <summary>
        /// Cached name for the 'clipboard_set_primary' method.
        /// </summary>
        public static readonly StringName ClipboardSetPrimary = "clipboard_set_primary";
        /// <summary>
        /// Cached name for the 'clipboard_get_primary' method.
        /// </summary>
        public static readonly StringName ClipboardGetPrimary = "clipboard_get_primary";
        /// <summary>
        /// Cached name for the 'get_display_cutouts' method.
        /// </summary>
        public static readonly StringName GetDisplayCutouts = "get_display_cutouts";
        /// <summary>
        /// Cached name for the 'get_display_safe_area' method.
        /// </summary>
        public static readonly StringName GetDisplaySafeArea = "get_display_safe_area";
        /// <summary>
        /// Cached name for the 'get_screen_count' method.
        /// </summary>
        public static readonly StringName GetScreenCount = "get_screen_count";
        /// <summary>
        /// Cached name for the 'get_primary_screen' method.
        /// </summary>
        public static readonly StringName GetPrimaryScreen = "get_primary_screen";
        /// <summary>
        /// Cached name for the 'get_keyboard_focus_screen' method.
        /// </summary>
        public static readonly StringName GetKeyboardFocusScreen = "get_keyboard_focus_screen";
        /// <summary>
        /// Cached name for the 'get_screen_from_rect' method.
        /// </summary>
        public static readonly StringName GetScreenFromRect = "get_screen_from_rect";
        /// <summary>
        /// Cached name for the 'screen_get_position' method.
        /// </summary>
        public static readonly StringName ScreenGetPosition = "screen_get_position";
        /// <summary>
        /// Cached name for the 'screen_get_size' method.
        /// </summary>
        public static readonly StringName ScreenGetSize = "screen_get_size";
        /// <summary>
        /// Cached name for the 'screen_get_usable_rect' method.
        /// </summary>
        public static readonly StringName ScreenGetUsableRect = "screen_get_usable_rect";
        /// <summary>
        /// Cached name for the 'screen_get_dpi' method.
        /// </summary>
        public static readonly StringName ScreenGetDpi = "screen_get_dpi";
        /// <summary>
        /// Cached name for the 'screen_get_scale' method.
        /// </summary>
        public static readonly StringName ScreenGetScale = "screen_get_scale";
        /// <summary>
        /// Cached name for the 'is_touchscreen_available' method.
        /// </summary>
        public static readonly StringName IsTouchscreenAvailable = "is_touchscreen_available";
        /// <summary>
        /// Cached name for the 'screen_get_max_scale' method.
        /// </summary>
        public static readonly StringName ScreenGetMaxScale = "screen_get_max_scale";
        /// <summary>
        /// Cached name for the 'screen_get_refresh_rate' method.
        /// </summary>
        public static readonly StringName ScreenGetRefreshRate = "screen_get_refresh_rate";
        /// <summary>
        /// Cached name for the 'screen_get_pixel' method.
        /// </summary>
        public static readonly StringName ScreenGetPixel = "screen_get_pixel";
        /// <summary>
        /// Cached name for the 'screen_get_image' method.
        /// </summary>
        public static readonly StringName ScreenGetImage = "screen_get_image";
        /// <summary>
        /// Cached name for the 'screen_set_orientation' method.
        /// </summary>
        public static readonly StringName ScreenSetOrientation = "screen_set_orientation";
        /// <summary>
        /// Cached name for the 'screen_get_orientation' method.
        /// </summary>
        public static readonly StringName ScreenGetOrientation = "screen_get_orientation";
        /// <summary>
        /// Cached name for the 'screen_set_keep_on' method.
        /// </summary>
        public static readonly StringName ScreenSetKeepOn = "screen_set_keep_on";
        /// <summary>
        /// Cached name for the 'screen_is_kept_on' method.
        /// </summary>
        public static readonly StringName ScreenIsKeptOn = "screen_is_kept_on";
        /// <summary>
        /// Cached name for the 'get_window_list' method.
        /// </summary>
        public static readonly StringName GetWindowList = "get_window_list";
        /// <summary>
        /// Cached name for the 'get_window_at_screen_position' method.
        /// </summary>
        public static readonly StringName GetWindowAtScreenPosition = "get_window_at_screen_position";
        /// <summary>
        /// Cached name for the 'window_get_native_handle' method.
        /// </summary>
        public static readonly StringName WindowGetNativeHandle = "window_get_native_handle";
        /// <summary>
        /// Cached name for the 'window_get_active_popup' method.
        /// </summary>
        public static readonly StringName WindowGetActivePopup = "window_get_active_popup";
        /// <summary>
        /// Cached name for the 'window_set_popup_safe_rect' method.
        /// </summary>
        public static readonly StringName WindowSetPopupSafeRect = "window_set_popup_safe_rect";
        /// <summary>
        /// Cached name for the 'window_get_popup_safe_rect' method.
        /// </summary>
        public static readonly StringName WindowGetPopupSafeRect = "window_get_popup_safe_rect";
        /// <summary>
        /// Cached name for the 'window_set_title' method.
        /// </summary>
        public static readonly StringName WindowSetTitle = "window_set_title";
        /// <summary>
        /// Cached name for the 'window_get_title_size' method.
        /// </summary>
        public static readonly StringName WindowGetTitleSize = "window_get_title_size";
        /// <summary>
        /// Cached name for the 'window_set_mouse_passthrough' method.
        /// </summary>
        public static readonly StringName WindowSetMousePassthrough = "window_set_mouse_passthrough";
        /// <summary>
        /// Cached name for the 'window_get_current_screen' method.
        /// </summary>
        public static readonly StringName WindowGetCurrentScreen = "window_get_current_screen";
        /// <summary>
        /// Cached name for the 'window_set_current_screen' method.
        /// </summary>
        public static readonly StringName WindowSetCurrentScreen = "window_set_current_screen";
        /// <summary>
        /// Cached name for the 'window_get_position' method.
        /// </summary>
        public static readonly StringName WindowGetPosition = "window_get_position";
        /// <summary>
        /// Cached name for the 'window_get_position_with_decorations' method.
        /// </summary>
        public static readonly StringName WindowGetPositionWithDecorations = "window_get_position_with_decorations";
        /// <summary>
        /// Cached name for the 'window_set_position' method.
        /// </summary>
        public static readonly StringName WindowSetPosition = "window_set_position";
        /// <summary>
        /// Cached name for the 'window_get_size' method.
        /// </summary>
        public static readonly StringName WindowGetSize = "window_get_size";
        /// <summary>
        /// Cached name for the 'window_set_size' method.
        /// </summary>
        public static readonly StringName WindowSetSize = "window_set_size";
        /// <summary>
        /// Cached name for the 'window_set_rect_changed_callback' method.
        /// </summary>
        public static readonly StringName WindowSetRectChangedCallback = "window_set_rect_changed_callback";
        /// <summary>
        /// Cached name for the 'window_set_window_event_callback' method.
        /// </summary>
        public static readonly StringName WindowSetWindowEventCallback = "window_set_window_event_callback";
        /// <summary>
        /// Cached name for the 'window_set_input_event_callback' method.
        /// </summary>
        public static readonly StringName WindowSetInputEventCallback = "window_set_input_event_callback";
        /// <summary>
        /// Cached name for the 'window_set_input_text_callback' method.
        /// </summary>
        public static readonly StringName WindowSetInputTextCallback = "window_set_input_text_callback";
        /// <summary>
        /// Cached name for the 'window_set_drop_files_callback' method.
        /// </summary>
        public static readonly StringName WindowSetDropFilesCallback = "window_set_drop_files_callback";
        /// <summary>
        /// Cached name for the 'window_get_attached_instance_id' method.
        /// </summary>
        public static readonly StringName WindowGetAttachedInstanceId = "window_get_attached_instance_id";
        /// <summary>
        /// Cached name for the 'window_get_max_size' method.
        /// </summary>
        public static readonly StringName WindowGetMaxSize = "window_get_max_size";
        /// <summary>
        /// Cached name for the 'window_set_max_size' method.
        /// </summary>
        public static readonly StringName WindowSetMaxSize = "window_set_max_size";
        /// <summary>
        /// Cached name for the 'window_get_min_size' method.
        /// </summary>
        public static readonly StringName WindowGetMinSize = "window_get_min_size";
        /// <summary>
        /// Cached name for the 'window_set_min_size' method.
        /// </summary>
        public static readonly StringName WindowSetMinSize = "window_set_min_size";
        /// <summary>
        /// Cached name for the 'window_get_size_with_decorations' method.
        /// </summary>
        public static readonly StringName WindowGetSizeWithDecorations = "window_get_size_with_decorations";
        /// <summary>
        /// Cached name for the 'window_get_mode' method.
        /// </summary>
        public static readonly StringName WindowGetMode = "window_get_mode";
        /// <summary>
        /// Cached name for the 'window_set_mode' method.
        /// </summary>
        public static readonly StringName WindowSetMode = "window_set_mode";
        /// <summary>
        /// Cached name for the 'window_set_flag' method.
        /// </summary>
        public static readonly StringName WindowSetFlag = "window_set_flag";
        /// <summary>
        /// Cached name for the 'window_get_flag' method.
        /// </summary>
        public static readonly StringName WindowGetFlag = "window_get_flag";
        /// <summary>
        /// Cached name for the 'window_set_window_buttons_offset' method.
        /// </summary>
        public static readonly StringName WindowSetWindowButtonsOffset = "window_set_window_buttons_offset";
        /// <summary>
        /// Cached name for the 'window_get_safe_title_margins' method.
        /// </summary>
        public static readonly StringName WindowGetSafeTitleMargins = "window_get_safe_title_margins";
        /// <summary>
        /// Cached name for the 'window_request_attention' method.
        /// </summary>
        public static readonly StringName WindowRequestAttention = "window_request_attention";
        /// <summary>
        /// Cached name for the 'window_move_to_foreground' method.
        /// </summary>
        public static readonly StringName WindowMoveToForeground = "window_move_to_foreground";
        /// <summary>
        /// Cached name for the 'window_is_focused' method.
        /// </summary>
        public static readonly StringName WindowIsFocused = "window_is_focused";
        /// <summary>
        /// Cached name for the 'window_can_draw' method.
        /// </summary>
        public static readonly StringName WindowCanDraw = "window_can_draw";
        /// <summary>
        /// Cached name for the 'window_set_transient' method.
        /// </summary>
        public static readonly StringName WindowSetTransient = "window_set_transient";
        /// <summary>
        /// Cached name for the 'window_set_exclusive' method.
        /// </summary>
        public static readonly StringName WindowSetExclusive = "window_set_exclusive";
        /// <summary>
        /// Cached name for the 'window_set_ime_active' method.
        /// </summary>
        public static readonly StringName WindowSetImeActive = "window_set_ime_active";
        /// <summary>
        /// Cached name for the 'window_set_ime_position' method.
        /// </summary>
        public static readonly StringName WindowSetImePosition = "window_set_ime_position";
        /// <summary>
        /// Cached name for the 'window_set_vsync_mode' method.
        /// </summary>
        public static readonly StringName WindowSetVsyncMode = "window_set_vsync_mode";
        /// <summary>
        /// Cached name for the 'window_get_vsync_mode' method.
        /// </summary>
        public static readonly StringName WindowGetVsyncMode = "window_get_vsync_mode";
        /// <summary>
        /// Cached name for the 'window_is_maximize_allowed' method.
        /// </summary>
        public static readonly StringName WindowIsMaximizeAllowed = "window_is_maximize_allowed";
        /// <summary>
        /// Cached name for the 'window_maximize_on_title_dbl_click' method.
        /// </summary>
        public static readonly StringName WindowMaximizeOnTitleDblClick = "window_maximize_on_title_dbl_click";
        /// <summary>
        /// Cached name for the 'window_minimize_on_title_dbl_click' method.
        /// </summary>
        public static readonly StringName WindowMinimizeOnTitleDblClick = "window_minimize_on_title_dbl_click";
        /// <summary>
        /// Cached name for the 'ime_get_selection' method.
        /// </summary>
        public static readonly StringName ImeGetSelection = "ime_get_selection";
        /// <summary>
        /// Cached name for the 'ime_get_text' method.
        /// </summary>
        public static readonly StringName ImeGetText = "ime_get_text";
        /// <summary>
        /// Cached name for the 'virtual_keyboard_show' method.
        /// </summary>
        public static readonly StringName VirtualKeyboardShow = "virtual_keyboard_show";
        /// <summary>
        /// Cached name for the 'virtual_keyboard_hide' method.
        /// </summary>
        public static readonly StringName VirtualKeyboardHide = "virtual_keyboard_hide";
        /// <summary>
        /// Cached name for the 'virtual_keyboard_get_height' method.
        /// </summary>
        public static readonly StringName VirtualKeyboardGetHeight = "virtual_keyboard_get_height";
        /// <summary>
        /// Cached name for the 'cursor_set_shape' method.
        /// </summary>
        public static readonly StringName CursorSetShape = "cursor_set_shape";
        /// <summary>
        /// Cached name for the 'cursor_get_shape' method.
        /// </summary>
        public static readonly StringName CursorGetShape = "cursor_get_shape";
        /// <summary>
        /// Cached name for the 'cursor_set_custom_image' method.
        /// </summary>
        public static readonly StringName CursorSetCustomImage = "cursor_set_custom_image";
        /// <summary>
        /// Cached name for the 'get_swap_cancel_ok' method.
        /// </summary>
        public static readonly StringName GetSwapCancelOk = "get_swap_cancel_ok";
        /// <summary>
        /// Cached name for the 'enable_for_stealing_focus' method.
        /// </summary>
        public static readonly StringName EnableForStealingFocus = "enable_for_stealing_focus";
        /// <summary>
        /// Cached name for the 'dialog_show' method.
        /// </summary>
        public static readonly StringName DialogShow = "dialog_show";
        /// <summary>
        /// Cached name for the 'dialog_input_text' method.
        /// </summary>
        public static readonly StringName DialogInputText = "dialog_input_text";
        /// <summary>
        /// Cached name for the 'file_dialog_show' method.
        /// </summary>
        public static readonly StringName FileDialogShow = "file_dialog_show";
        /// <summary>
        /// Cached name for the 'file_dialog_with_options_show' method.
        /// </summary>
        public static readonly StringName FileDialogWithOptionsShow = "file_dialog_with_options_show";
        /// <summary>
        /// Cached name for the 'keyboard_get_layout_count' method.
        /// </summary>
        public static readonly StringName KeyboardGetLayoutCount = "keyboard_get_layout_count";
        /// <summary>
        /// Cached name for the 'keyboard_get_current_layout' method.
        /// </summary>
        public static readonly StringName KeyboardGetCurrentLayout = "keyboard_get_current_layout";
        /// <summary>
        /// Cached name for the 'keyboard_set_current_layout' method.
        /// </summary>
        public static readonly StringName KeyboardSetCurrentLayout = "keyboard_set_current_layout";
        /// <summary>
        /// Cached name for the 'keyboard_get_layout_language' method.
        /// </summary>
        public static readonly StringName KeyboardGetLayoutLanguage = "keyboard_get_layout_language";
        /// <summary>
        /// Cached name for the 'keyboard_get_layout_name' method.
        /// </summary>
        public static readonly StringName KeyboardGetLayoutName = "keyboard_get_layout_name";
        /// <summary>
        /// Cached name for the 'keyboard_get_keycode_from_physical' method.
        /// </summary>
        public static readonly StringName KeyboardGetKeycodeFromPhysical = "keyboard_get_keycode_from_physical";
        /// <summary>
        /// Cached name for the 'keyboard_get_label_from_physical' method.
        /// </summary>
        public static readonly StringName KeyboardGetLabelFromPhysical = "keyboard_get_label_from_physical";
        /// <summary>
        /// Cached name for the 'process_events' method.
        /// </summary>
        public static readonly StringName ProcessEvents = "process_events";
        /// <summary>
        /// Cached name for the 'force_process_and_drop_events' method.
        /// </summary>
        public static readonly StringName ForceProcessAndDropEvents = "force_process_and_drop_events";
        /// <summary>
        /// Cached name for the 'set_native_icon' method.
        /// </summary>
        public static readonly StringName SetNativeIcon = "set_native_icon";
        /// <summary>
        /// Cached name for the 'set_icon' method.
        /// </summary>
        public static readonly StringName SetIcon = "set_icon";
        /// <summary>
        /// Cached name for the 'create_status_indicator' method.
        /// </summary>
        public static readonly StringName CreateStatusIndicator = "create_status_indicator";
        /// <summary>
        /// Cached name for the 'status_indicator_set_icon' method.
        /// </summary>
        public static readonly StringName StatusIndicatorSetIcon = "status_indicator_set_icon";
        /// <summary>
        /// Cached name for the 'status_indicator_set_tooltip' method.
        /// </summary>
        public static readonly StringName StatusIndicatorSetTooltip = "status_indicator_set_tooltip";
        /// <summary>
        /// Cached name for the 'status_indicator_set_menu' method.
        /// </summary>
        public static readonly StringName StatusIndicatorSetMenu = "status_indicator_set_menu";
        /// <summary>
        /// Cached name for the 'status_indicator_set_callback' method.
        /// </summary>
        public static readonly StringName StatusIndicatorSetCallback = "status_indicator_set_callback";
        /// <summary>
        /// Cached name for the 'status_indicator_get_rect' method.
        /// </summary>
        public static readonly StringName StatusIndicatorGetRect = "status_indicator_get_rect";
        /// <summary>
        /// Cached name for the 'delete_status_indicator' method.
        /// </summary>
        public static readonly StringName DeleteStatusIndicator = "delete_status_indicator";
        /// <summary>
        /// Cached name for the 'tablet_get_driver_count' method.
        /// </summary>
        public static readonly StringName TabletGetDriverCount = "tablet_get_driver_count";
        /// <summary>
        /// Cached name for the 'tablet_get_driver_name' method.
        /// </summary>
        public static readonly StringName TabletGetDriverName = "tablet_get_driver_name";
        /// <summary>
        /// Cached name for the 'tablet_get_current_driver' method.
        /// </summary>
        public static readonly StringName TabletGetCurrentDriver = "tablet_get_current_driver";
        /// <summary>
        /// Cached name for the 'tablet_set_current_driver' method.
        /// </summary>
        public static readonly StringName TabletSetCurrentDriver = "tablet_set_current_driver";
        /// <summary>
        /// Cached name for the 'is_window_transparency_available' method.
        /// </summary>
        public static readonly StringName IsWindowTransparencyAvailable = "is_window_transparency_available";
        /// <summary>
        /// Cached name for the 'register_additional_output' method.
        /// </summary>
        public static readonly StringName RegisterAdditionalOutput = "register_additional_output";
        /// <summary>
        /// Cached name for the 'unregister_additional_output' method.
        /// </summary>
        public static readonly StringName UnregisterAdditionalOutput = "unregister_additional_output";
        /// <summary>
        /// Cached name for the 'has_additional_outputs' method.
        /// </summary>
        public static readonly StringName HasAdditionalOutputs = "has_additional_outputs";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
    }
}

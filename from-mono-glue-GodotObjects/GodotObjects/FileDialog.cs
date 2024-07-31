namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.FileDialog"/> is a preset dialog used to choose files and directories in the filesystem. It supports filter masks. <see cref="Godot.FileDialog"/> automatically sets its window title according to the <see cref="Godot.FileDialog.FileMode"/>. If you want to use a custom title, disable this by setting <see cref="Godot.FileDialog.ModeOverridesTitle"/> to <see langword="false"/>.</para>
/// </summary>
public partial class FileDialog : ConfirmationDialog
{
    public enum FileModeEnum : long
    {
        /// <summary>
        /// <para>The dialog allows selecting one, and only one file.</para>
        /// </summary>
        OpenFile = 0,
        /// <summary>
        /// <para>The dialog allows selecting multiple files.</para>
        /// </summary>
        OpenFiles = 1,
        /// <summary>
        /// <para>The dialog only allows selecting a directory, disallowing the selection of any file.</para>
        /// </summary>
        OpenDir = 2,
        /// <summary>
        /// <para>The dialog allows selecting one file or directory.</para>
        /// </summary>
        OpenAny = 3,
        /// <summary>
        /// <para>The dialog will warn when a file exists.</para>
        /// </summary>
        SaveFile = 4
    }

    public enum AccessEnum : long
    {
        /// <summary>
        /// <para>The dialog only allows accessing files under the <see cref="Godot.Resource"/> path (<c>res://</c>).</para>
        /// </summary>
        Resources = 0,
        /// <summary>
        /// <para>The dialog only allows accessing files under user data path (<c>user://</c>).</para>
        /// </summary>
        Userdata = 1,
        /// <summary>
        /// <para>The dialog allows accessing files on the whole file system.</para>
        /// </summary>
        Filesystem = 2
    }

    /// <summary>
    /// <para>If <see langword="true"/>, changing the <see cref="Godot.FileDialog.FileMode"/> property will set the window title accordingly (e.g. setting <see cref="Godot.FileDialog.FileMode"/> to <see cref="Godot.FileDialog.FileModeEnum.OpenFile"/> will change the window title to "Open a File").</para>
    /// </summary>
    public bool ModeOverridesTitle
    {
        get
        {
            return IsModeOverridingTitle();
        }
        set
        {
            SetModeOverridesTitle(value);
        }
    }

    /// <summary>
    /// <para>The dialog's open or save mode, which affects the selection behavior. See <see cref="Godot.FileDialog.FileModeEnum"/>.</para>
    /// </summary>
    public FileDialog.FileModeEnum FileMode
    {
        get
        {
            return GetFileMode();
        }
        set
        {
            SetFileMode(value);
        }
    }

    /// <summary>
    /// <para>The file system access scope. See <see cref="Godot.FileDialog.AccessEnum"/> constants.</para>
    /// <para><b>Warning:</b> In Web builds, FileDialog cannot access the host file system. In sandboxed Linux and macOS environments, <see cref="Godot.FileDialog.UseNativeDialog"/> is automatically used to allow limited access to host file system.</para>
    /// </summary>
    public FileDialog.AccessEnum Access
    {
        get
        {
            return GetAccess();
        }
        set
        {
            SetAccess(value);
        }
    }

    /// <summary>
    /// <para>If non-empty, the given sub-folder will be "root" of this <see cref="Godot.FileDialog"/>, i.e. user won't be able to go to its parent directory.</para>
    /// <para><b>Note:</b> This property is ignored by native file dialogs.</para>
    /// </summary>
    public string RootSubfolder
    {
        get
        {
            return GetRootSubfolder();
        }
        set
        {
            SetRootSubfolder(value);
        }
    }

    /// <summary>
    /// <para>The available file type filters. Each filter string in the array should be formatted like this: <c>*.txt,*.doc;Text Files</c>. The description text of the filter is optional and can be omitted.</para>
    /// </summary>
    public string[] Filters
    {
        get
        {
            return GetFilters();
        }
        set
        {
            SetFilters(value);
        }
    }

    /// <summary>
    /// <para>The number of additional <see cref="Godot.OptionButton"/>s and <see cref="Godot.CheckBox"/>es in the dialog.</para>
    /// </summary>
    public int OptionCount
    {
        get
        {
            return GetOptionCount();
        }
        set
        {
            SetOptionCount(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the dialog will show hidden files.</para>
    /// <para><b>Note:</b> This property is ignored by native file dialogs on Linux.</para>
    /// </summary>
    public bool ShowHiddenFiles
    {
        get
        {
            return IsShowingHiddenFiles();
        }
        set
        {
            SetShowHiddenFiles(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, <see cref="Godot.FileDialog.Access"/> is set to <see cref="Godot.FileDialog.AccessEnum.Filesystem"/>, and it is supported by the current <see cref="Godot.DisplayServer"/>, OS native dialog will be used instead of custom one.</para>
    /// <para><b>Note:</b> On Linux and macOS, sandboxed apps always use native dialogs to access the host file system.</para>
    /// <para><b>Note:</b> On macOS, sandboxed apps will save security-scoped bookmarks to retain access to the opened folders across multiple sessions. Use <see cref="Godot.OS.GetGrantedPermissions()"/> to get a list of saved bookmarks.</para>
    /// <para><b>Note:</b> Native dialogs are isolated from the base process, file dialog properties can't be modified once the dialog is shown.</para>
    /// </summary>
    public bool UseNativeDialog
    {
        get
        {
            return GetUseNativeDialog();
        }
        set
        {
            SetUseNativeDialog(value);
        }
    }

    /// <summary>
    /// <para>The current working directory of the file dialog.</para>
    /// <para><b>Note:</b> For native file dialogs, this property is only treated as a hint and may not be respected by specific OS implementations.</para>
    /// </summary>
    public string CurrentDir
    {
        get
        {
            return GetCurrentDir();
        }
        set
        {
            SetCurrentDir(value);
        }
    }

    /// <summary>
    /// <para>The currently selected file of the file dialog.</para>
    /// </summary>
    public string CurrentFile
    {
        get
        {
            return GetCurrentFile();
        }
        set
        {
            SetCurrentFile(value);
        }
    }

    /// <summary>
    /// <para>The currently selected file path of the file dialog.</para>
    /// </summary>
    public string CurrentPath
    {
        get
        {
            return GetCurrentPath();
        }
        set
        {
            SetCurrentPath(value);
        }
    }

    private static readonly System.Type CachedType = typeof(FileDialog);

    private static readonly StringName NativeName = "FileDialog";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public FileDialog() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal FileDialog(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ClearFilters, 3218959716ul);

    /// <summary>
    /// <para>Clear all the added filters in the dialog.</para>
    /// </summary>
    public void ClearFilters()
    {
        NativeCalls.godot_icall_0_3(MethodBind0, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddFilter, 3388804757ul);

    /// <summary>
    /// <para>Adds a comma-delimited file name <paramref name="filter"/> option to the <see cref="Godot.FileDialog"/> with an optional <paramref name="description"/>, which restricts what files can be picked.</para>
    /// <para>A <paramref name="filter"/> should be of the form <c>"filename.extension"</c>, where filename and extension can be <c>*</c> to match any string. Filters starting with <c>.</c> (i.e. empty filenames) are not allowed.</para>
    /// <para>For example, a <paramref name="filter"/> of <c>"*.png, *.jpg"</c> and a <paramref name="description"/> of <c>"Images"</c> results in filter text "Images (*.png, *.jpg)".</para>
    /// </summary>
    public void AddFilter(string filter, string description = "")
    {
        NativeCalls.godot_icall_2_270(MethodBind1, GodotObject.GetPtr(this), filter, description);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFilters, 4015028928ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFilters(string[] filters)
    {
        NativeCalls.godot_icall_1_171(MethodBind2, GodotObject.GetPtr(this), filters);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFilters, 1139954409ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string[] GetFilters()
    {
        return NativeCalls.godot_icall_0_115(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOptionName, 844755477ul);

    /// <summary>
    /// <para>Returns the name of the <see cref="Godot.OptionButton"/> or <see cref="Godot.CheckBox"/> with index <paramref name="option"/>.</para>
    /// </summary>
    public string GetOptionName(int option)
    {
        return NativeCalls.godot_icall_1_126(MethodBind4, GodotObject.GetPtr(this), option);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOptionValues, 647634434ul);

    /// <summary>
    /// <para>Returns an array of values of the <see cref="Godot.OptionButton"/> with index <paramref name="option"/>.</para>
    /// </summary>
    public string[] GetOptionValues(int option)
    {
        return NativeCalls.godot_icall_1_411(MethodBind5, GodotObject.GetPtr(this), option);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOptionDefault, 923996154ul);

    /// <summary>
    /// <para>Returns the default value index of the <see cref="Godot.OptionButton"/> or <see cref="Godot.CheckBox"/> with index <paramref name="option"/>.</para>
    /// </summary>
    public int GetOptionDefault(int option)
    {
        return NativeCalls.godot_icall_1_69(MethodBind6, GodotObject.GetPtr(this), option);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOptionName, 501894301ul);

    /// <summary>
    /// <para>Sets the name of the <see cref="Godot.OptionButton"/> or <see cref="Godot.CheckBox"/> with index <paramref name="option"/>.</para>
    /// </summary>
    public void SetOptionName(int option, string name)
    {
        NativeCalls.godot_icall_2_167(MethodBind7, GodotObject.GetPtr(this), option, name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOptionValues, 3353661094ul);

    /// <summary>
    /// <para>Sets the option values of the <see cref="Godot.OptionButton"/> with index <paramref name="option"/>.</para>
    /// </summary>
    public void SetOptionValues(int option, string[] values)
    {
        NativeCalls.godot_icall_2_412(MethodBind8, GodotObject.GetPtr(this), option, values);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOptionDefault, 3937882851ul);

    /// <summary>
    /// <para>Sets the default value index of the <see cref="Godot.OptionButton"/> or <see cref="Godot.CheckBox"/> with index <paramref name="option"/>.</para>
    /// </summary>
    public void SetOptionDefault(int option, int defaultValueIndex)
    {
        NativeCalls.godot_icall_2_73(MethodBind9, GodotObject.GetPtr(this), option, defaultValueIndex);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOptionCount, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetOptionCount(int count)
    {
        NativeCalls.godot_icall_1_36(MethodBind10, GodotObject.GetPtr(this), count);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOptionCount, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetOptionCount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddOption, 149592325ul);

    /// <summary>
    /// <para>Adds an additional <see cref="Godot.OptionButton"/> to the file dialog. If <paramref name="values"/> is empty, a <see cref="Godot.CheckBox"/> is added instead.</para>
    /// <para><paramref name="defaultValueIndex"/> should be an index of the value in the <paramref name="values"/>. If <paramref name="values"/> is empty it should be either <c>1</c> (checked), or <c>0</c> (unchecked).</para>
    /// </summary>
    public void AddOption(string name, string[] values, int defaultValueIndex)
    {
        NativeCalls.godot_icall_3_413(MethodBind12, GodotObject.GetPtr(this), name, values, defaultValueIndex);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSelectedOptions, 3102165223ul);

    /// <summary>
    /// <para>Returns a <see cref="Godot.Collections.Dictionary"/> with the selected values of the additional <see cref="Godot.OptionButton"/>s and/or <see cref="Godot.CheckBox"/>es. <see cref="Godot.Collections.Dictionary"/> keys are names and values are selected value indices.</para>
    /// </summary>
    public Godot.Collections.Dictionary GetSelectedOptions()
    {
        return NativeCalls.godot_icall_0_114(MethodBind13, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCurrentDir, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetCurrentDir()
    {
        return NativeCalls.godot_icall_0_57(MethodBind14, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCurrentFile, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetCurrentFile()
    {
        return NativeCalls.godot_icall_0_57(MethodBind15, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCurrentPath, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetCurrentPath()
    {
        return NativeCalls.godot_icall_0_57(MethodBind16, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCurrentDir, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCurrentDir(string dir)
    {
        NativeCalls.godot_icall_1_56(MethodBind17, GodotObject.GetPtr(this), dir);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCurrentFile, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCurrentFile(string file)
    {
        NativeCalls.godot_icall_1_56(MethodBind18, GodotObject.GetPtr(this), file);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCurrentPath, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCurrentPath(string path)
    {
        NativeCalls.godot_icall_1_56(MethodBind19, GodotObject.GetPtr(this), path);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetModeOverridesTitle, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetModeOverridesTitle(bool @override)
    {
        NativeCalls.godot_icall_1_41(MethodBind20, GodotObject.GetPtr(this), @override.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsModeOverridingTitle, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsModeOverridingTitle()
    {
        return NativeCalls.godot_icall_0_40(MethodBind21, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFileMode, 3654936397ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFileMode(FileDialog.FileModeEnum mode)
    {
        NativeCalls.godot_icall_1_36(MethodBind22, GodotObject.GetPtr(this), (int)mode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFileMode, 4074825319ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public FileDialog.FileModeEnum GetFileMode()
    {
        return (FileDialog.FileModeEnum)NativeCalls.godot_icall_0_37(MethodBind23, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetVBox, 915758477ul);

    /// <summary>
    /// <para>Returns the vertical box container of the dialog, custom controls can be added to it.</para>
    /// <para><b>Warning:</b> This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
    /// <para><b>Note:</b> Changes to this node are ignored by native file dialogs, use <see cref="Godot.FileDialog.AddOption(string, string[], int)"/> to add custom elements to the dialog instead.</para>
    /// </summary>
    public VBoxContainer GetVBox()
    {
        return (VBoxContainer)NativeCalls.godot_icall_0_52(MethodBind24, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLineEdit, 4071694264ul);

    /// <summary>
    /// <para>Returns the LineEdit for the selected file.</para>
    /// <para><b>Warning:</b> This is a required internal node, removing and freeing it may cause a crash. If you wish to hide it or any of its children, use their <see cref="Godot.CanvasItem.Visible"/> property.</para>
    /// </summary>
    public LineEdit GetLineEdit()
    {
        return (LineEdit)NativeCalls.godot_icall_0_52(MethodBind25, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAccess, 4104413466ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAccess(FileDialog.AccessEnum access)
    {
        NativeCalls.godot_icall_1_36(MethodBind26, GodotObject.GetPtr(this), (int)access);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAccess, 3344081076ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public FileDialog.AccessEnum GetAccess()
    {
        return (FileDialog.AccessEnum)NativeCalls.godot_icall_0_37(MethodBind27, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRootSubfolder, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRootSubfolder(string dir)
    {
        NativeCalls.godot_icall_1_56(MethodBind28, GodotObject.GetPtr(this), dir);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRootSubfolder, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetRootSubfolder()
    {
        return NativeCalls.godot_icall_0_57(MethodBind29, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind30 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetShowHiddenFiles, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetShowHiddenFiles(bool show)
    {
        NativeCalls.godot_icall_1_41(MethodBind30, GodotObject.GetPtr(this), show.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind31 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsShowingHiddenFiles, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsShowingHiddenFiles()
    {
        return NativeCalls.godot_icall_0_40(MethodBind31, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind32 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUseNativeDialog, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetUseNativeDialog(bool native)
    {
        NativeCalls.godot_icall_1_41(MethodBind32, GodotObject.GetPtr(this), native.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind33 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUseNativeDialog, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetUseNativeDialog()
    {
        return NativeCalls.godot_icall_0_40(MethodBind33, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind34 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DeselectAll, 3218959716ul);

    /// <summary>
    /// <para>Clear all currently selected items in the dialog.</para>
    /// </summary>
    public void DeselectAll()
    {
        NativeCalls.godot_icall_0_3(MethodBind34, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind35 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Invalidate, 3218959716ul);

    /// <summary>
    /// <para>Invalidate and update the current dialog content list.</para>
    /// <para><b>Note:</b> This method does nothing on native file dialogs.</para>
    /// </summary>
    public void Invalidate()
    {
        NativeCalls.godot_icall_0_3(MethodBind35, GodotObject.GetPtr(this));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.FileDialog.FileSelected"/> event of a <see cref="Godot.FileDialog"/> class.
    /// </summary>
    public delegate void FileSelectedEventHandler(string path);

    private static void FileSelectedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((FileSelectedEventHandler)delegateObj)(VariantUtils.ConvertTo<string>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when the user selects a file by double-clicking it or pressing the <b>OK</b> button.</para>
    /// </summary>
    public unsafe event FileSelectedEventHandler FileSelected
    {
        add => Connect(SignalName.FileSelected, Callable.CreateWithUnsafeTrampoline(value, &FileSelectedTrampoline));
        remove => Disconnect(SignalName.FileSelected, Callable.CreateWithUnsafeTrampoline(value, &FileSelectedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.FileDialog.FilesSelected"/> event of a <see cref="Godot.FileDialog"/> class.
    /// </summary>
    public delegate void FilesSelectedEventHandler(string[] paths);

    private static void FilesSelectedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((FilesSelectedEventHandler)delegateObj)(VariantUtils.ConvertTo<string[]>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when the user selects multiple files.</para>
    /// </summary>
    public unsafe event FilesSelectedEventHandler FilesSelected
    {
        add => Connect(SignalName.FilesSelected, Callable.CreateWithUnsafeTrampoline(value, &FilesSelectedTrampoline));
        remove => Disconnect(SignalName.FilesSelected, Callable.CreateWithUnsafeTrampoline(value, &FilesSelectedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.FileDialog.DirSelected"/> event of a <see cref="Godot.FileDialog"/> class.
    /// </summary>
    public delegate void DirSelectedEventHandler(string dir);

    private static void DirSelectedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((DirSelectedEventHandler)delegateObj)(VariantUtils.ConvertTo<string>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when the user selects a directory.</para>
    /// </summary>
    public unsafe event DirSelectedEventHandler DirSelected
    {
        add => Connect(SignalName.DirSelected, Callable.CreateWithUnsafeTrampoline(value, &DirSelectedTrampoline));
        remove => Disconnect(SignalName.DirSelected, Callable.CreateWithUnsafeTrampoline(value, &DirSelectedTrampoline));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_file_selected = "FileSelected";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_files_selected = "FilesSelected";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_dir_selected = "DirSelected";

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
        if (signal == SignalName.FileSelected)
        {
            if (HasGodotClassSignal(SignalProxyName_file_selected.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.FilesSelected)
        {
            if (HasGodotClassSignal(SignalProxyName_files_selected.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.DirSelected)
        {
            if (HasGodotClassSignal(SignalProxyName_dir_selected.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : ConfirmationDialog.PropertyName
    {
        /// <summary>
        /// Cached name for the 'mode_overrides_title' property.
        /// </summary>
        public static readonly StringName ModeOverridesTitle = "mode_overrides_title";
        /// <summary>
        /// Cached name for the 'file_mode' property.
        /// </summary>
        public static readonly StringName FileMode = "file_mode";
        /// <summary>
        /// Cached name for the 'access' property.
        /// </summary>
        public static readonly StringName Access = "access";
        /// <summary>
        /// Cached name for the 'root_subfolder' property.
        /// </summary>
        public static readonly StringName RootSubfolder = "root_subfolder";
        /// <summary>
        /// Cached name for the 'filters' property.
        /// </summary>
        public static readonly StringName Filters = "filters";
        /// <summary>
        /// Cached name for the 'option_count' property.
        /// </summary>
        public static readonly StringName OptionCount = "option_count";
        /// <summary>
        /// Cached name for the 'show_hidden_files' property.
        /// </summary>
        public static readonly StringName ShowHiddenFiles = "show_hidden_files";
        /// <summary>
        /// Cached name for the 'use_native_dialog' property.
        /// </summary>
        public static readonly StringName UseNativeDialog = "use_native_dialog";
        /// <summary>
        /// Cached name for the 'current_dir' property.
        /// </summary>
        public static readonly StringName CurrentDir = "current_dir";
        /// <summary>
        /// Cached name for the 'current_file' property.
        /// </summary>
        public static readonly StringName CurrentFile = "current_file";
        /// <summary>
        /// Cached name for the 'current_path' property.
        /// </summary>
        public static readonly StringName CurrentPath = "current_path";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : ConfirmationDialog.MethodName
    {
        /// <summary>
        /// Cached name for the 'clear_filters' method.
        /// </summary>
        public static readonly StringName ClearFilters = "clear_filters";
        /// <summary>
        /// Cached name for the 'add_filter' method.
        /// </summary>
        public static readonly StringName AddFilter = "add_filter";
        /// <summary>
        /// Cached name for the 'set_filters' method.
        /// </summary>
        public static readonly StringName SetFilters = "set_filters";
        /// <summary>
        /// Cached name for the 'get_filters' method.
        /// </summary>
        public static readonly StringName GetFilters = "get_filters";
        /// <summary>
        /// Cached name for the 'get_option_name' method.
        /// </summary>
        public static readonly StringName GetOptionName = "get_option_name";
        /// <summary>
        /// Cached name for the 'get_option_values' method.
        /// </summary>
        public static readonly StringName GetOptionValues = "get_option_values";
        /// <summary>
        /// Cached name for the 'get_option_default' method.
        /// </summary>
        public static readonly StringName GetOptionDefault = "get_option_default";
        /// <summary>
        /// Cached name for the 'set_option_name' method.
        /// </summary>
        public static readonly StringName SetOptionName = "set_option_name";
        /// <summary>
        /// Cached name for the 'set_option_values' method.
        /// </summary>
        public static readonly StringName SetOptionValues = "set_option_values";
        /// <summary>
        /// Cached name for the 'set_option_default' method.
        /// </summary>
        public static readonly StringName SetOptionDefault = "set_option_default";
        /// <summary>
        /// Cached name for the 'set_option_count' method.
        /// </summary>
        public static readonly StringName SetOptionCount = "set_option_count";
        /// <summary>
        /// Cached name for the 'get_option_count' method.
        /// </summary>
        public static readonly StringName GetOptionCount = "get_option_count";
        /// <summary>
        /// Cached name for the 'add_option' method.
        /// </summary>
        public static readonly StringName AddOption = "add_option";
        /// <summary>
        /// Cached name for the 'get_selected_options' method.
        /// </summary>
        public static readonly StringName GetSelectedOptions = "get_selected_options";
        /// <summary>
        /// Cached name for the 'get_current_dir' method.
        /// </summary>
        public static readonly StringName GetCurrentDir = "get_current_dir";
        /// <summary>
        /// Cached name for the 'get_current_file' method.
        /// </summary>
        public static readonly StringName GetCurrentFile = "get_current_file";
        /// <summary>
        /// Cached name for the 'get_current_path' method.
        /// </summary>
        public static readonly StringName GetCurrentPath = "get_current_path";
        /// <summary>
        /// Cached name for the 'set_current_dir' method.
        /// </summary>
        public static readonly StringName SetCurrentDir = "set_current_dir";
        /// <summary>
        /// Cached name for the 'set_current_file' method.
        /// </summary>
        public static readonly StringName SetCurrentFile = "set_current_file";
        /// <summary>
        /// Cached name for the 'set_current_path' method.
        /// </summary>
        public static readonly StringName SetCurrentPath = "set_current_path";
        /// <summary>
        /// Cached name for the 'set_mode_overrides_title' method.
        /// </summary>
        public static readonly StringName SetModeOverridesTitle = "set_mode_overrides_title";
        /// <summary>
        /// Cached name for the 'is_mode_overriding_title' method.
        /// </summary>
        public static readonly StringName IsModeOverridingTitle = "is_mode_overriding_title";
        /// <summary>
        /// Cached name for the 'set_file_mode' method.
        /// </summary>
        public static readonly StringName SetFileMode = "set_file_mode";
        /// <summary>
        /// Cached name for the 'get_file_mode' method.
        /// </summary>
        public static readonly StringName GetFileMode = "get_file_mode";
        /// <summary>
        /// Cached name for the 'get_vbox' method.
        /// </summary>
        public static readonly StringName GetVBox = "get_vbox";
        /// <summary>
        /// Cached name for the 'get_line_edit' method.
        /// </summary>
        public static readonly StringName GetLineEdit = "get_line_edit";
        /// <summary>
        /// Cached name for the 'set_access' method.
        /// </summary>
        public static readonly StringName SetAccess = "set_access";
        /// <summary>
        /// Cached name for the 'get_access' method.
        /// </summary>
        public static readonly StringName GetAccess = "get_access";
        /// <summary>
        /// Cached name for the 'set_root_subfolder' method.
        /// </summary>
        public static readonly StringName SetRootSubfolder = "set_root_subfolder";
        /// <summary>
        /// Cached name for the 'get_root_subfolder' method.
        /// </summary>
        public static readonly StringName GetRootSubfolder = "get_root_subfolder";
        /// <summary>
        /// Cached name for the 'set_show_hidden_files' method.
        /// </summary>
        public static readonly StringName SetShowHiddenFiles = "set_show_hidden_files";
        /// <summary>
        /// Cached name for the 'is_showing_hidden_files' method.
        /// </summary>
        public static readonly StringName IsShowingHiddenFiles = "is_showing_hidden_files";
        /// <summary>
        /// Cached name for the 'set_use_native_dialog' method.
        /// </summary>
        public static readonly StringName SetUseNativeDialog = "set_use_native_dialog";
        /// <summary>
        /// Cached name for the 'get_use_native_dialog' method.
        /// </summary>
        public static readonly StringName GetUseNativeDialog = "get_use_native_dialog";
        /// <summary>
        /// Cached name for the 'deselect_all' method.
        /// </summary>
        public static readonly StringName DeselectAll = "deselect_all";
        /// <summary>
        /// Cached name for the 'invalidate' method.
        /// </summary>
        public static readonly StringName Invalidate = "invalidate";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : ConfirmationDialog.SignalName
    {
        /// <summary>
        /// Cached name for the 'file_selected' signal.
        /// </summary>
        public static readonly StringName FileSelected = "file_selected";
        /// <summary>
        /// Cached name for the 'files_selected' signal.
        /// </summary>
        public static readonly StringName FilesSelected = "files_selected";
        /// <summary>
        /// Cached name for the 'dir_selected' signal.
        /// </summary>
        public static readonly StringName DirSelected = "dir_selected";
    }
}

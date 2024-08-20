namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>A custom control for editing properties that can be added to the <see cref="Godot.EditorInspector"/>. It is added via <see cref="Godot.EditorInspectorPlugin"/>.</para>
/// </summary>
public partial class EditorProperty : Container
{
    /// <summary>
    /// <para>Set this property to change the label (if you want to show one).</para>
    /// </summary>
    public string Label
    {
        get
        {
            return GetLabel();
        }
        set
        {
            SetLabel(value);
        }
    }

    /// <summary>
    /// <para>Used by the inspector, set to <see langword="true"/> when the property is read-only.</para>
    /// </summary>
    public bool ReadOnly
    {
        get
        {
            return IsReadOnly();
        }
        set
        {
            SetReadOnly(value);
        }
    }

    /// <summary>
    /// <para>Used by the inspector, set to <see langword="true"/> when the property is checkable.</para>
    /// </summary>
    public bool Checkable
    {
        get
        {
            return IsCheckable();
        }
        set
        {
            SetCheckable(value);
        }
    }

    /// <summary>
    /// <para>Used by the inspector, set to <see langword="true"/> when the property is checked.</para>
    /// </summary>
    public bool Checked
    {
        get
        {
            return IsChecked();
        }
        set
        {
            SetChecked(value);
        }
    }

    /// <summary>
    /// <para>Used by the inspector, set to <see langword="true"/> when the property is drawn with the editor theme's warning color. This is used for editable children's properties.</para>
    /// </summary>
    public bool DrawWarning
    {
        get
        {
            return IsDrawWarning();
        }
        set
        {
            SetDrawWarning(value);
        }
    }

    /// <summary>
    /// <para>Used by the inspector, set to <see langword="true"/> when the property can add keys for animation.</para>
    /// </summary>
    public bool Keying
    {
        get
        {
            return IsKeying();
        }
        set
        {
            SetKeying(value);
        }
    }

    /// <summary>
    /// <para>Used by the inspector, set to <see langword="true"/> when the property can be deleted by the user.</para>
    /// </summary>
    public bool Deletable
    {
        get
        {
            return IsDeletable();
        }
        set
        {
            SetDeletable(value);
        }
    }

    private static readonly System.Type CachedType = typeof(EditorProperty);

    private static readonly StringName NativeName = "EditorProperty";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public EditorProperty() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal EditorProperty(bool memoryOwn) : base(memoryOwn) { }

    /// <summary>
    /// <para>Called when the read-only status of the property is changed. It may be used to change custom controls into a read-only or modifiable state.</para>
    /// </summary>
    public virtual void _SetReadOnly(bool readOnly)
    {
    }

    /// <summary>
    /// <para>When this virtual function is called, you must update your editor.</para>
    /// </summary>
    public virtual void _UpdateProperty()
    {
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLabel, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetLabel(string text)
    {
        NativeCalls.godot_icall_1_56(MethodBind0, GodotObject.GetPtr(this), text);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLabel, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetLabel()
    {
        return NativeCalls.godot_icall_0_57(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetReadOnly, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetReadOnly(bool readOnly)
    {
        NativeCalls.godot_icall_1_41(MethodBind2, GodotObject.GetPtr(this), readOnly.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsReadOnly, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsReadOnly()
    {
        return NativeCalls.godot_icall_0_40(MethodBind3, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCheckable, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCheckable(bool checkable)
    {
        NativeCalls.godot_icall_1_41(MethodBind4, GodotObject.GetPtr(this), checkable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsCheckable, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsCheckable()
    {
        return NativeCalls.godot_icall_0_40(MethodBind5, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetChecked, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetChecked(bool @checked)
    {
        NativeCalls.godot_icall_1_41(MethodBind6, GodotObject.GetPtr(this), @checked.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsChecked, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsChecked()
    {
        return NativeCalls.godot_icall_0_40(MethodBind7, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDrawWarning, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDrawWarning(bool drawWarning)
    {
        NativeCalls.godot_icall_1_41(MethodBind8, GodotObject.GetPtr(this), drawWarning.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsDrawWarning, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsDrawWarning()
    {
        return NativeCalls.godot_icall_0_40(MethodBind9, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetKeying, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetKeying(bool keying)
    {
        NativeCalls.godot_icall_1_41(MethodBind10, GodotObject.GetPtr(this), keying.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsKeying, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsKeying()
    {
        return NativeCalls.godot_icall_0_40(MethodBind11, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDeletable, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDeletable(bool deletable)
    {
        NativeCalls.godot_icall_1_41(MethodBind12, GodotObject.GetPtr(this), deletable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsDeletable, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsDeletable()
    {
        return NativeCalls.godot_icall_0_40(MethodBind13, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEditedProperty, 2002593661ul);

    /// <summary>
    /// <para>Gets the edited property. If your editor is for a single property (added via <see cref="Godot.EditorInspectorPlugin._ParseProperty(GodotObject, Variant.Type, string, PropertyHint, string, PropertyUsageFlags, bool)"/>), then this will return the property.</para>
    /// </summary>
    public StringName GetEditedProperty()
    {
        return NativeCalls.godot_icall_0_60(MethodBind14, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEditedObject, 2050059866ul);

    /// <summary>
    /// <para>Gets the edited object.</para>
    /// </summary>
    public GodotObject GetEditedObject()
    {
        return (GodotObject)NativeCalls.godot_icall_0_52(MethodBind15, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.UpdateProperty, 3218959716ul);

    /// <summary>
    /// <para>Forces refresh of the property display.</para>
    /// </summary>
    public void UpdateProperty()
    {
        NativeCalls.godot_icall_0_3(MethodBind16, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddFocusable, 1496901182ul);

    /// <summary>
    /// <para>If any of the controls added can gain keyboard focus, add it here. This ensures that focus will be restored if the inspector is refreshed.</para>
    /// </summary>
    public void AddFocusable(Control control)
    {
        NativeCalls.godot_icall_1_55(MethodBind17, GodotObject.GetPtr(this), GodotObject.GetPtr(control));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBottomEditor, 1496901182ul);

    /// <summary>
    /// <para>Puts the <paramref name="editor"/> control below the property label. The control must be previously added using <see cref="Godot.Node.AddChild(Node, bool, Node.InternalMode)"/>.</para>
    /// </summary>
    public void SetBottomEditor(Control editor)
    {
        NativeCalls.godot_icall_1_55(MethodBind18, GodotObject.GetPtr(this), GodotObject.GetPtr(editor));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.EmitChanged, 3069422438ul);

    /// <summary>
    /// <para>If one or several properties have changed, this must be called. <paramref name="field"/> is used in case your editor can modify fields separately (as an example, Vector3.x). The <paramref name="changing"/> argument avoids the editor requesting this property to be refreshed (leave as <see langword="false"/> if unsure).</para>
    /// </summary>
    public void EmitChanged(StringName property, Variant value, StringName field = null, bool changing = false)
    {
        EditorNativeCalls.godot_icall_4_443(MethodBind19, GodotObject.GetPtr(this), (godot_string_name)(property?.NativeValue ?? default), value, (godot_string_name)(field?.NativeValue ?? default), changing.ToGodotBool());
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.PropertyChanged"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void PropertyChangedEventHandler(StringName property, Variant value, StringName field, bool changing);

    private static void PropertyChangedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 4);
        ((PropertyChangedEventHandler)delegateObj)(VariantUtils.ConvertTo<StringName>(args[0]), VariantUtils.ConvertTo<Variant>(args[1]), VariantUtils.ConvertTo<StringName>(args[2]), VariantUtils.ConvertTo<bool>(args[3]));
        ret = default;
    }

    /// <summary>
    /// <para>Do not emit this manually, use the <see cref="Godot.EditorProperty.EmitChanged(StringName, Variant, StringName, bool)"/> method instead.</para>
    /// </summary>
    public unsafe event PropertyChangedEventHandler PropertyChanged
    {
        add => Connect(SignalName.PropertyChanged, Callable.CreateWithUnsafeTrampoline(value, &PropertyChangedTrampoline));
        remove => Disconnect(SignalName.PropertyChanged, Callable.CreateWithUnsafeTrampoline(value, &PropertyChangedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.MultiplePropertiesChanged"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void MultiplePropertiesChangedEventHandler(string[] properties, Godot.Collections.Array value);

    private static void MultiplePropertiesChangedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 2);
        ((MultiplePropertiesChangedEventHandler)delegateObj)(VariantUtils.ConvertTo<string[]>(args[0]), VariantUtils.ConvertTo<Godot.Collections.Array>(args[1]));
        ret = default;
    }

    /// <summary>
    /// <para>Emit it if you want multiple properties modified at the same time. Do not use if added via <see cref="Godot.EditorInspectorPlugin._ParseProperty(GodotObject, Variant.Type, string, PropertyHint, string, PropertyUsageFlags, bool)"/>.</para>
    /// </summary>
    public unsafe event MultiplePropertiesChangedEventHandler MultiplePropertiesChanged
    {
        add => Connect(SignalName.MultiplePropertiesChanged, Callable.CreateWithUnsafeTrampoline(value, &MultiplePropertiesChangedTrampoline));
        remove => Disconnect(SignalName.MultiplePropertiesChanged, Callable.CreateWithUnsafeTrampoline(value, &MultiplePropertiesChangedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.PropertyKeyed"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void PropertyKeyedEventHandler(StringName property);

    private static void PropertyKeyedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((PropertyKeyedEventHandler)delegateObj)(VariantUtils.ConvertTo<StringName>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emit it if you want to add this value as an animation key (check for keying being enabled first).</para>
    /// </summary>
    public unsafe event PropertyKeyedEventHandler PropertyKeyed
    {
        add => Connect(SignalName.PropertyKeyed, Callable.CreateWithUnsafeTrampoline(value, &PropertyKeyedTrampoline));
        remove => Disconnect(SignalName.PropertyKeyed, Callable.CreateWithUnsafeTrampoline(value, &PropertyKeyedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.PropertyDeleted"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void PropertyDeletedEventHandler(StringName property);

    private static void PropertyDeletedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 1);
        ((PropertyDeletedEventHandler)delegateObj)(VariantUtils.ConvertTo<StringName>(args[0]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when a property was deleted. Used internally.</para>
    /// </summary>
    public unsafe event PropertyDeletedEventHandler PropertyDeleted
    {
        add => Connect(SignalName.PropertyDeleted, Callable.CreateWithUnsafeTrampoline(value, &PropertyDeletedTrampoline));
        remove => Disconnect(SignalName.PropertyDeleted, Callable.CreateWithUnsafeTrampoline(value, &PropertyDeletedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.PropertyKeyedWithValue"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void PropertyKeyedWithValueEventHandler(StringName property, Variant value);

    private static void PropertyKeyedWithValueTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 2);
        ((PropertyKeyedWithValueEventHandler)delegateObj)(VariantUtils.ConvertTo<StringName>(args[0]), VariantUtils.ConvertTo<Variant>(args[1]));
        ret = default;
    }

    /// <summary>
    /// <para>Emit it if you want to key a property with a single value.</para>
    /// </summary>
    public unsafe event PropertyKeyedWithValueEventHandler PropertyKeyedWithValue
    {
        add => Connect(SignalName.PropertyKeyedWithValue, Callable.CreateWithUnsafeTrampoline(value, &PropertyKeyedWithValueTrampoline));
        remove => Disconnect(SignalName.PropertyKeyedWithValue, Callable.CreateWithUnsafeTrampoline(value, &PropertyKeyedWithValueTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.PropertyChecked"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void PropertyCheckedEventHandler(StringName property, bool @checked);

    private static void PropertyCheckedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 2);
        ((PropertyCheckedEventHandler)delegateObj)(VariantUtils.ConvertTo<StringName>(args[0]), VariantUtils.ConvertTo<bool>(args[1]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when a property was checked. Used internally.</para>
    /// </summary>
    public unsafe event PropertyCheckedEventHandler PropertyChecked
    {
        add => Connect(SignalName.PropertyChecked, Callable.CreateWithUnsafeTrampoline(value, &PropertyCheckedTrampoline));
        remove => Disconnect(SignalName.PropertyChecked, Callable.CreateWithUnsafeTrampoline(value, &PropertyCheckedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.PropertyPinned"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void PropertyPinnedEventHandler(StringName property, bool pinned);

    private static void PropertyPinnedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 2);
        ((PropertyPinnedEventHandler)delegateObj)(VariantUtils.ConvertTo<StringName>(args[0]), VariantUtils.ConvertTo<bool>(args[1]));
        ret = default;
    }

    /// <summary>
    /// <para>Emit it if you want to mark (or unmark) the value of a property for being saved regardless of being equal to the default value.</para>
    /// <para>The default value is the one the property will get when the node is just instantiated and can come from an ancestor scene in the inheritance/instantiation chain, a script or a builtin class.</para>
    /// </summary>
    public unsafe event PropertyPinnedEventHandler PropertyPinned
    {
        add => Connect(SignalName.PropertyPinned, Callable.CreateWithUnsafeTrampoline(value, &PropertyPinnedTrampoline));
        remove => Disconnect(SignalName.PropertyPinned, Callable.CreateWithUnsafeTrampoline(value, &PropertyPinnedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.PropertyCanRevertChanged"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void PropertyCanRevertChangedEventHandler(StringName property, bool canRevert);

    private static void PropertyCanRevertChangedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 2);
        ((PropertyCanRevertChangedEventHandler)delegateObj)(VariantUtils.ConvertTo<StringName>(args[0]), VariantUtils.ConvertTo<bool>(args[1]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when the revertability (i.e., whether it has a non-default value and thus is displayed with a revert icon) of a property has changed.</para>
    /// </summary>
    public unsafe event PropertyCanRevertChangedEventHandler PropertyCanRevertChanged
    {
        add => Connect(SignalName.PropertyCanRevertChanged, Callable.CreateWithUnsafeTrampoline(value, &PropertyCanRevertChangedTrampoline));
        remove => Disconnect(SignalName.PropertyCanRevertChanged, Callable.CreateWithUnsafeTrampoline(value, &PropertyCanRevertChangedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.ResourceSelected"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void ResourceSelectedEventHandler(string path, Resource resource);

    private static void ResourceSelectedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 2);
        ((ResourceSelectedEventHandler)delegateObj)(VariantUtils.ConvertTo<string>(args[0]), VariantUtils.ConvertTo<Resource>(args[1]));
        ret = default;
    }

    /// <summary>
    /// <para>If you want a sub-resource to be edited, emit this signal with the resource.</para>
    /// </summary>
    public unsafe event ResourceSelectedEventHandler ResourceSelected
    {
        add => Connect(SignalName.ResourceSelected, Callable.CreateWithUnsafeTrampoline(value, &ResourceSelectedTrampoline));
        remove => Disconnect(SignalName.ResourceSelected, Callable.CreateWithUnsafeTrampoline(value, &ResourceSelectedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.ObjectIdSelected"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void ObjectIdSelectedEventHandler(StringName property, long id);

    private static void ObjectIdSelectedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 2);
        ((ObjectIdSelectedEventHandler)delegateObj)(VariantUtils.ConvertTo<StringName>(args[0]), VariantUtils.ConvertTo<long>(args[1]));
        ret = default;
    }

    /// <summary>
    /// <para>Used by sub-inspectors. Emit it if what was selected was an Object ID.</para>
    /// </summary>
    public unsafe event ObjectIdSelectedEventHandler ObjectIdSelected
    {
        add => Connect(SignalName.ObjectIdSelected, Callable.CreateWithUnsafeTrampoline(value, &ObjectIdSelectedTrampoline));
        remove => Disconnect(SignalName.ObjectIdSelected, Callable.CreateWithUnsafeTrampoline(value, &ObjectIdSelectedTrampoline));
    }

    /// <summary>
    /// Represents the method that handles the <see cref="Godot.EditorProperty.Selected"/> event of a <see cref="Godot.EditorProperty"/> class.
    /// </summary>
    public delegate void SelectedEventHandler(string path, long focusableIdx);

    private static void SelectedTrampoline(object delegateObj, NativeVariantPtrArgs args, out godot_variant ret)
    {
        Callable.ThrowIfArgCountMismatch(args, 2);
        ((SelectedEventHandler)delegateObj)(VariantUtils.ConvertTo<string>(args[0]), VariantUtils.ConvertTo<long>(args[1]));
        ret = default;
    }

    /// <summary>
    /// <para>Emitted when selected. Used internally.</para>
    /// </summary>
    public unsafe event SelectedEventHandler Selected
    {
        add => Connect(SignalName.Selected, Callable.CreateWithUnsafeTrampoline(value, &SelectedTrampoline));
        remove => Disconnect(SignalName.Selected, Callable.CreateWithUnsafeTrampoline(value, &SelectedTrampoline));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__set_read_only = "_SetReadOnly";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName MethodProxyName__update_property = "_UpdateProperty";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_property_changed = "PropertyChanged";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_multiple_properties_changed = "MultiplePropertiesChanged";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_property_keyed = "PropertyKeyed";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_property_deleted = "PropertyDeleted";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_property_keyed_with_value = "PropertyKeyedWithValue";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_property_checked = "PropertyChecked";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_property_pinned = "PropertyPinned";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_property_can_revert_changed = "PropertyCanRevertChanged";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_resource_selected = "ResourceSelected";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_object_id_selected = "ObjectIdSelected";

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_selected = "Selected";

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
        if ((method == MethodProxyName__set_read_only || method == MethodName._SetReadOnly) && args.Count == 1 && HasGodotClassMethod((godot_string_name)MethodProxyName__set_read_only.NativeValue))
        {
            _SetReadOnly(VariantUtils.ConvertTo<bool>(args[0]));
            ret = default;
            return true;
        }
        if ((method == MethodProxyName__update_property || method == MethodName._UpdateProperty) && args.Count == 0 && HasGodotClassMethod((godot_string_name)MethodProxyName__update_property.NativeValue))
        {
            _UpdateProperty();
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
        if (method == MethodName._SetReadOnly)
        {
            if (HasGodotClassMethod(MethodProxyName__set_read_only.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (method == MethodName._UpdateProperty)
        {
            if (HasGodotClassMethod(MethodProxyName__update_property.NativeValue.DangerousSelfRef))
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
        if (signal == SignalName.PropertyChanged)
        {
            if (HasGodotClassSignal(SignalProxyName_property_changed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.MultiplePropertiesChanged)
        {
            if (HasGodotClassSignal(SignalProxyName_multiple_properties_changed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.PropertyKeyed)
        {
            if (HasGodotClassSignal(SignalProxyName_property_keyed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.PropertyDeleted)
        {
            if (HasGodotClassSignal(SignalProxyName_property_deleted.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.PropertyKeyedWithValue)
        {
            if (HasGodotClassSignal(SignalProxyName_property_keyed_with_value.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.PropertyChecked)
        {
            if (HasGodotClassSignal(SignalProxyName_property_checked.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.PropertyPinned)
        {
            if (HasGodotClassSignal(SignalProxyName_property_pinned.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.PropertyCanRevertChanged)
        {
            if (HasGodotClassSignal(SignalProxyName_property_can_revert_changed.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.ResourceSelected)
        {
            if (HasGodotClassSignal(SignalProxyName_resource_selected.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.ObjectIdSelected)
        {
            if (HasGodotClassSignal(SignalProxyName_object_id_selected.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        if (signal == SignalName.Selected)
        {
            if (HasGodotClassSignal(SignalProxyName_selected.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : Container.PropertyName
    {
        /// <summary>
        /// Cached name for the 'label' property.
        /// </summary>
        public static readonly StringName Label = "label";
        /// <summary>
        /// Cached name for the 'read_only' property.
        /// </summary>
        public static readonly StringName ReadOnly = "read_only";
        /// <summary>
        /// Cached name for the 'checkable' property.
        /// </summary>
        public static readonly StringName Checkable = "checkable";
        /// <summary>
        /// Cached name for the 'checked' property.
        /// </summary>
        public static readonly StringName Checked = "checked";
        /// <summary>
        /// Cached name for the 'draw_warning' property.
        /// </summary>
        public static readonly StringName DrawWarning = "draw_warning";
        /// <summary>
        /// Cached name for the 'keying' property.
        /// </summary>
        public static readonly StringName Keying = "keying";
        /// <summary>
        /// Cached name for the 'deletable' property.
        /// </summary>
        public static readonly StringName Deletable = "deletable";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Container.MethodName
    {
        /// <summary>
        /// Cached name for the '_set_read_only' method.
        /// </summary>
        public static readonly StringName _SetReadOnly = "_set_read_only";
        /// <summary>
        /// Cached name for the '_update_property' method.
        /// </summary>
        public static readonly StringName _UpdateProperty = "_update_property";
        /// <summary>
        /// Cached name for the 'set_label' method.
        /// </summary>
        public static readonly StringName SetLabel = "set_label";
        /// <summary>
        /// Cached name for the 'get_label' method.
        /// </summary>
        public static readonly StringName GetLabel = "get_label";
        /// <summary>
        /// Cached name for the 'set_read_only' method.
        /// </summary>
        public static readonly StringName SetReadOnly = "set_read_only";
        /// <summary>
        /// Cached name for the 'is_read_only' method.
        /// </summary>
        public static readonly StringName IsReadOnly = "is_read_only";
        /// <summary>
        /// Cached name for the 'set_checkable' method.
        /// </summary>
        public static readonly StringName SetCheckable = "set_checkable";
        /// <summary>
        /// Cached name for the 'is_checkable' method.
        /// </summary>
        public static readonly StringName IsCheckable = "is_checkable";
        /// <summary>
        /// Cached name for the 'set_checked' method.
        /// </summary>
        public static readonly StringName SetChecked = "set_checked";
        /// <summary>
        /// Cached name for the 'is_checked' method.
        /// </summary>
        public static readonly StringName IsChecked = "is_checked";
        /// <summary>
        /// Cached name for the 'set_draw_warning' method.
        /// </summary>
        public static readonly StringName SetDrawWarning = "set_draw_warning";
        /// <summary>
        /// Cached name for the 'is_draw_warning' method.
        /// </summary>
        public static readonly StringName IsDrawWarning = "is_draw_warning";
        /// <summary>
        /// Cached name for the 'set_keying' method.
        /// </summary>
        public static readonly StringName SetKeying = "set_keying";
        /// <summary>
        /// Cached name for the 'is_keying' method.
        /// </summary>
        public static readonly StringName IsKeying = "is_keying";
        /// <summary>
        /// Cached name for the 'set_deletable' method.
        /// </summary>
        public static readonly StringName SetDeletable = "set_deletable";
        /// <summary>
        /// Cached name for the 'is_deletable' method.
        /// </summary>
        public static readonly StringName IsDeletable = "is_deletable";
        /// <summary>
        /// Cached name for the 'get_edited_property' method.
        /// </summary>
        public static readonly StringName GetEditedProperty = "get_edited_property";
        /// <summary>
        /// Cached name for the 'get_edited_object' method.
        /// </summary>
        public static readonly StringName GetEditedObject = "get_edited_object";
        /// <summary>
        /// Cached name for the 'update_property' method.
        /// </summary>
        public static readonly StringName UpdateProperty = "update_property";
        /// <summary>
        /// Cached name for the 'add_focusable' method.
        /// </summary>
        public static readonly StringName AddFocusable = "add_focusable";
        /// <summary>
        /// Cached name for the 'set_bottom_editor' method.
        /// </summary>
        public static readonly StringName SetBottomEditor = "set_bottom_editor";
        /// <summary>
        /// Cached name for the 'emit_changed' method.
        /// </summary>
        public static readonly StringName EmitChanged = "emit_changed";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Container.SignalName
    {
        /// <summary>
        /// Cached name for the 'property_changed' signal.
        /// </summary>
        public static readonly StringName PropertyChanged = "property_changed";
        /// <summary>
        /// Cached name for the 'multiple_properties_changed' signal.
        /// </summary>
        public static readonly StringName MultiplePropertiesChanged = "multiple_properties_changed";
        /// <summary>
        /// Cached name for the 'property_keyed' signal.
        /// </summary>
        public static readonly StringName PropertyKeyed = "property_keyed";
        /// <summary>
        /// Cached name for the 'property_deleted' signal.
        /// </summary>
        public static readonly StringName PropertyDeleted = "property_deleted";
        /// <summary>
        /// Cached name for the 'property_keyed_with_value' signal.
        /// </summary>
        public static readonly StringName PropertyKeyedWithValue = "property_keyed_with_value";
        /// <summary>
        /// Cached name for the 'property_checked' signal.
        /// </summary>
        public static readonly StringName PropertyChecked = "property_checked";
        /// <summary>
        /// Cached name for the 'property_pinned' signal.
        /// </summary>
        public static readonly StringName PropertyPinned = "property_pinned";
        /// <summary>
        /// Cached name for the 'property_can_revert_changed' signal.
        /// </summary>
        public static readonly StringName PropertyCanRevertChanged = "property_can_revert_changed";
        /// <summary>
        /// Cached name for the 'resource_selected' signal.
        /// </summary>
        public static readonly StringName ResourceSelected = "resource_selected";
        /// <summary>
        /// Cached name for the 'object_id_selected' signal.
        /// </summary>
        public static readonly StringName ObjectIdSelected = "object_id_selected";
        /// <summary>
        /// Cached name for the 'selected' signal.
        /// </summary>
        public static readonly StringName Selected = "selected";
    }
}

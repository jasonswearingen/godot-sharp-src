namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>This object is used by <see cref="Godot.RenderingDevice"/>.</para>
/// </summary>
public partial class RDTextureFormat : RefCounted
{
    /// <summary>
    /// <para>The texture's pixel data format.</para>
    /// </summary>
    public RenderingDevice.DataFormat Format
    {
        get
        {
            return GetFormat();
        }
        set
        {
            SetFormat(value);
        }
    }

    /// <summary>
    /// <para>The texture's width (in pixels).</para>
    /// </summary>
    public uint Width
    {
        get
        {
            return GetWidth();
        }
        set
        {
            SetWidth(value);
        }
    }

    /// <summary>
    /// <para>The texture's height (in pixels).</para>
    /// </summary>
    public uint Height
    {
        get
        {
            return GetHeight();
        }
        set
        {
            SetHeight(value);
        }
    }

    /// <summary>
    /// <para>The texture's depth (in pixels). This is always <c>1</c> for 2D textures.</para>
    /// </summary>
    public uint Depth
    {
        get
        {
            return GetDepth();
        }
        set
        {
            SetDepth(value);
        }
    }

    /// <summary>
    /// <para>The number of layers in the texture. Only relevant for 2D texture arrays.</para>
    /// </summary>
    public uint ArrayLayers
    {
        get
        {
            return GetArrayLayers();
        }
        set
        {
            SetArrayLayers(value);
        }
    }

    /// <summary>
    /// <para>The number of mipmaps available in the texture.</para>
    /// </summary>
    public uint Mipmaps
    {
        get
        {
            return GetMipmaps();
        }
        set
        {
            SetMipmaps(value);
        }
    }

    /// <summary>
    /// <para>The texture type.</para>
    /// </summary>
    public RenderingDevice.TextureType TextureType
    {
        get
        {
            return GetTextureType();
        }
        set
        {
            SetTextureType(value);
        }
    }

    /// <summary>
    /// <para>The number of samples used when sampling the texture.</para>
    /// </summary>
    public RenderingDevice.TextureSamples Samples
    {
        get
        {
            return GetSamples();
        }
        set
        {
            SetSamples(value);
        }
    }

    /// <summary>
    /// <para>The texture's usage bits, which determine what can be done using the texture.</para>
    /// </summary>
    public RenderingDevice.TextureUsageBits UsageBits
    {
        get
        {
            return GetUsageBits();
        }
        set
        {
            SetUsageBits(value);
        }
    }

    private static readonly System.Type CachedType = typeof(RDTextureFormat);

    private static readonly StringName NativeName = "RDTextureFormat";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public RDTextureFormat() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal RDTextureFormat(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFormat, 565531219ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFormat(RenderingDevice.DataFormat pMember)
    {
        NativeCalls.godot_icall_1_36(MethodBind0, GodotObject.GetPtr(this), (int)pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFormat, 2235804183ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public RenderingDevice.DataFormat GetFormat()
    {
        return (RenderingDevice.DataFormat)NativeCalls.godot_icall_0_37(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetWidth, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetWidth(uint pMember)
    {
        NativeCalls.godot_icall_1_192(MethodBind2, GodotObject.GetPtr(this), pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetWidth, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetWidth()
    {
        return NativeCalls.godot_icall_0_193(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHeight, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHeight(uint pMember)
    {
        NativeCalls.godot_icall_1_192(MethodBind4, GodotObject.GetPtr(this), pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHeight, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetHeight()
    {
        return NativeCalls.godot_icall_0_193(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDepth, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDepth(uint pMember)
    {
        NativeCalls.godot_icall_1_192(MethodBind6, GodotObject.GetPtr(this), pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDepth, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetDepth()
    {
        return NativeCalls.godot_icall_0_193(MethodBind7, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetArrayLayers, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetArrayLayers(uint pMember)
    {
        NativeCalls.godot_icall_1_192(MethodBind8, GodotObject.GetPtr(this), pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetArrayLayers, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetArrayLayers()
    {
        return NativeCalls.godot_icall_0_193(MethodBind9, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMipmaps, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMipmaps(uint pMember)
    {
        NativeCalls.godot_icall_1_192(MethodBind10, GodotObject.GetPtr(this), pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMipmaps, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint GetMipmaps()
    {
        return NativeCalls.godot_icall_0_193(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTextureType, 652343381ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTextureType(RenderingDevice.TextureType pMember)
    {
        NativeCalls.godot_icall_1_36(MethodBind12, GodotObject.GetPtr(this), (int)pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTextureType, 4036357416ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public RenderingDevice.TextureType GetTextureType()
    {
        return (RenderingDevice.TextureType)NativeCalls.godot_icall_0_37(MethodBind13, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSamples, 3774171498ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSamples(RenderingDevice.TextureSamples pMember)
    {
        NativeCalls.godot_icall_1_36(MethodBind14, GodotObject.GetPtr(this), (int)pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSamples, 407791724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public RenderingDevice.TextureSamples GetSamples()
    {
        return (RenderingDevice.TextureSamples)NativeCalls.godot_icall_0_37(MethodBind15, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUsageBits, 245642367ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetUsageBits(RenderingDevice.TextureUsageBits pMember)
    {
        NativeCalls.godot_icall_1_36(MethodBind16, GodotObject.GetPtr(this), (int)pMember);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUsageBits, 1313398998ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public RenderingDevice.TextureUsageBits GetUsageBits()
    {
        return (RenderingDevice.TextureUsageBits)NativeCalls.godot_icall_0_37(MethodBind17, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddShareableFormat, 565531219ul);

    public void AddShareableFormat(RenderingDevice.DataFormat format)
    {
        NativeCalls.godot_icall_1_36(MethodBind18, GodotObject.GetPtr(this), (int)format);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RemoveShareableFormat, 565531219ul);

    public void RemoveShareableFormat(RenderingDevice.DataFormat format)
    {
        NativeCalls.godot_icall_1_36(MethodBind19, GodotObject.GetPtr(this), (int)format);
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
    public new class PropertyName : RefCounted.PropertyName
    {
        /// <summary>
        /// Cached name for the 'format' property.
        /// </summary>
        public static readonly StringName Format = "format";
        /// <summary>
        /// Cached name for the 'width' property.
        /// </summary>
        public static readonly StringName Width = "width";
        /// <summary>
        /// Cached name for the 'height' property.
        /// </summary>
        public static readonly StringName Height = "height";
        /// <summary>
        /// Cached name for the 'depth' property.
        /// </summary>
        public static readonly StringName Depth = "depth";
        /// <summary>
        /// Cached name for the 'array_layers' property.
        /// </summary>
        public static readonly StringName ArrayLayers = "array_layers";
        /// <summary>
        /// Cached name for the 'mipmaps' property.
        /// </summary>
        public static readonly StringName Mipmaps = "mipmaps";
        /// <summary>
        /// Cached name for the 'texture_type' property.
        /// </summary>
        public static readonly StringName TextureType = "texture_type";
        /// <summary>
        /// Cached name for the 'samples' property.
        /// </summary>
        public static readonly StringName Samples = "samples";
        /// <summary>
        /// Cached name for the 'usage_bits' property.
        /// </summary>
        public static readonly StringName UsageBits = "usage_bits";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : RefCounted.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_format' method.
        /// </summary>
        public static readonly StringName SetFormat = "set_format";
        /// <summary>
        /// Cached name for the 'get_format' method.
        /// </summary>
        public static readonly StringName GetFormat = "get_format";
        /// <summary>
        /// Cached name for the 'set_width' method.
        /// </summary>
        public static readonly StringName SetWidth = "set_width";
        /// <summary>
        /// Cached name for the 'get_width' method.
        /// </summary>
        public static readonly StringName GetWidth = "get_width";
        /// <summary>
        /// Cached name for the 'set_height' method.
        /// </summary>
        public static readonly StringName SetHeight = "set_height";
        /// <summary>
        /// Cached name for the 'get_height' method.
        /// </summary>
        public static readonly StringName GetHeight = "get_height";
        /// <summary>
        /// Cached name for the 'set_depth' method.
        /// </summary>
        public static readonly StringName SetDepth = "set_depth";
        /// <summary>
        /// Cached name for the 'get_depth' method.
        /// </summary>
        public static readonly StringName GetDepth = "get_depth";
        /// <summary>
        /// Cached name for the 'set_array_layers' method.
        /// </summary>
        public static readonly StringName SetArrayLayers = "set_array_layers";
        /// <summary>
        /// Cached name for the 'get_array_layers' method.
        /// </summary>
        public static readonly StringName GetArrayLayers = "get_array_layers";
        /// <summary>
        /// Cached name for the 'set_mipmaps' method.
        /// </summary>
        public static readonly StringName SetMipmaps = "set_mipmaps";
        /// <summary>
        /// Cached name for the 'get_mipmaps' method.
        /// </summary>
        public static readonly StringName GetMipmaps = "get_mipmaps";
        /// <summary>
        /// Cached name for the 'set_texture_type' method.
        /// </summary>
        public static readonly StringName SetTextureType = "set_texture_type";
        /// <summary>
        /// Cached name for the 'get_texture_type' method.
        /// </summary>
        public static readonly StringName GetTextureType = "get_texture_type";
        /// <summary>
        /// Cached name for the 'set_samples' method.
        /// </summary>
        public static readonly StringName SetSamples = "set_samples";
        /// <summary>
        /// Cached name for the 'get_samples' method.
        /// </summary>
        public static readonly StringName GetSamples = "get_samples";
        /// <summary>
        /// Cached name for the 'set_usage_bits' method.
        /// </summary>
        public static readonly StringName SetUsageBits = "set_usage_bits";
        /// <summary>
        /// Cached name for the 'get_usage_bits' method.
        /// </summary>
        public static readonly StringName GetUsageBits = "get_usage_bits";
        /// <summary>
        /// Cached name for the 'add_shareable_format' method.
        /// </summary>
        public static readonly StringName AddShareableFormat = "add_shareable_format";
        /// <summary>
        /// Cached name for the 'remove_shareable_format' method.
        /// </summary>
        public static readonly StringName RemoveShareableFormat = "remove_shareable_format";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : RefCounted.SignalName
    {
    }
}

namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Uses the <see cref="Godot.FastNoiseLite"/> library or other noise generators to fill the texture data of your desired size. <see cref="Godot.NoiseTexture2D"/> can also generate normal map textures.</para>
/// <para>The class uses <see cref="Godot.GodotThread"/>s to generate the texture data internally, so <see cref="Godot.Texture2D.GetImage()"/> may return <see langword="null"/> if the generation process has not completed yet. In that case, you need to wait for the texture to be generated before accessing the image and the generated byte data:</para>
/// <para><code>
/// var texture = NoiseTexture2D.new()
/// texture.noise = FastNoiseLite.new()
/// await texture.changed
/// var image = texture.get_image()
/// var data = image.get_data()
/// </code></para>
/// </summary>
public partial class NoiseTexture2D : Texture2D
{
    /// <summary>
    /// <para>Width of the generated texture (in pixels).</para>
    /// </summary>
    public int Width
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
    /// <para>Height of the generated texture (in pixels).</para>
    /// </summary>
    public int Height
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
    /// <para>If <see langword="true"/>, inverts the noise texture. White becomes black, black becomes white.</para>
    /// </summary>
    public bool Invert
    {
        get
        {
            return GetInvert();
        }
        set
        {
            SetInvert(value);
        }
    }

    /// <summary>
    /// <para>Determines whether the noise image is calculated in 3D space. May result in reduced contrast.</para>
    /// </summary>
    public bool In3DSpace
    {
        get
        {
            return IsIn3DSpace();
        }
        set
        {
            SetIn3DSpace(value);
        }
    }

    /// <summary>
    /// <para>Determines whether mipmaps are generated for this texture. Enabling this results in less texture aliasing in the distance, at the cost of increasing memory usage by roughly 33% and making the noise texture generation take longer.</para>
    /// <para><b>Note:</b> <see cref="Godot.NoiseTexture2D.GenerateMipmaps"/> requires mipmap filtering to be enabled on the material using the <see cref="Godot.NoiseTexture2D"/> to have an effect.</para>
    /// </summary>
    public bool GenerateMipmaps
    {
        get
        {
            return IsGeneratingMipmaps();
        }
        set
        {
            SetGenerateMipmaps(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, a seamless texture is requested from the <see cref="Godot.Noise"/> resource.</para>
    /// <para><b>Note:</b> Seamless noise textures may take longer to generate and/or can have a lower contrast compared to non-seamless noise depending on the used <see cref="Godot.Noise"/> resource. This is because some implementations use higher dimensions for generating seamless noise.</para>
    /// <para><b>Note:</b> The default <see cref="Godot.FastNoiseLite"/> implementation uses the fallback path for seamless generation. If using a <see cref="Godot.NoiseTexture2D.Width"/> or <see cref="Godot.NoiseTexture2D.Height"/> lower than the default, you may need to increase <see cref="Godot.NoiseTexture2D.SeamlessBlendSkirt"/> to make seamless blending more effective.</para>
    /// </summary>
    public bool Seamless
    {
        get
        {
            return GetSeamless();
        }
        set
        {
            SetSeamless(value);
        }
    }

    /// <summary>
    /// <para>Used for the default/fallback implementation of the seamless texture generation. It determines the distance over which the seams are blended. High values may result in less details and contrast. See <see cref="Godot.Noise"/> for further details.</para>
    /// <para><b>Note:</b> If using a <see cref="Godot.NoiseTexture2D.Width"/> or <see cref="Godot.NoiseTexture2D.Height"/> lower than the default, you may need to increase <see cref="Godot.NoiseTexture2D.SeamlessBlendSkirt"/> to make seamless blending more effective.</para>
    /// </summary>
    public float SeamlessBlendSkirt
    {
        get
        {
            return GetSeamlessBlendSkirt();
        }
        set
        {
            SetSeamlessBlendSkirt(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the resulting texture contains a normal map created from the original noise interpreted as a bump map.</para>
    /// </summary>
    public bool AsNormalMap
    {
        get
        {
            return IsNormalMap();
        }
        set
        {
            SetAsNormalMap(value);
        }
    }

    /// <summary>
    /// <para>Strength of the bump maps used in this texture. A higher value will make the bump maps appear larger while a lower value will make them appear softer.</para>
    /// </summary>
    public float BumpStrength
    {
        get
        {
            return GetBumpStrength();
        }
        set
        {
            SetBumpStrength(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the noise image coming from the noise generator is normalized to the range <c>0.0</c> to <c>1.0</c>.</para>
    /// <para>Turning normalization off can affect the contrast and allows you to generate non repeating tileable noise textures.</para>
    /// </summary>
    public bool Normalize
    {
        get
        {
            return IsNormalized();
        }
        set
        {
            SetNormalize(value);
        }
    }

    /// <summary>
    /// <para>A <see cref="Godot.Gradient"/> which is used to map the luminance of each pixel to a color value.</para>
    /// </summary>
    public Gradient ColorRamp
    {
        get
        {
            return GetColorRamp();
        }
        set
        {
            SetColorRamp(value);
        }
    }

    /// <summary>
    /// <para>The instance of the <see cref="Godot.Noise"/> object.</para>
    /// </summary>
    public Noise Noise
    {
        get
        {
            return GetNoise();
        }
        set
        {
            SetNoise(value);
        }
    }

    private static readonly System.Type CachedType = typeof(NoiseTexture2D);

    private static readonly StringName NativeName = "NoiseTexture2D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public NoiseTexture2D() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal NoiseTexture2D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetWidth, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetWidth(int width)
    {
        NativeCalls.godot_icall_1_36(MethodBind0, GodotObject.GetPtr(this), width);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHeight, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHeight(int height)
    {
        NativeCalls.godot_icall_1_36(MethodBind1, GodotObject.GetPtr(this), height);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetInvert, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetInvert(bool invert)
    {
        NativeCalls.godot_icall_1_41(MethodBind2, GodotObject.GetPtr(this), invert.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetInvert, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetInvert()
    {
        return NativeCalls.godot_icall_0_40(MethodBind3, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetIn3DSpace, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetIn3DSpace(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind4, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsIn3DSpace, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsIn3DSpace()
    {
        return NativeCalls.godot_icall_0_40(MethodBind5, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGenerateMipmaps, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetGenerateMipmaps(bool invert)
    {
        NativeCalls.godot_icall_1_41(MethodBind6, GodotObject.GetPtr(this), invert.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsGeneratingMipmaps, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsGeneratingMipmaps()
    {
        return NativeCalls.godot_icall_0_40(MethodBind7, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSeamless, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSeamless(bool seamless)
    {
        NativeCalls.godot_icall_1_41(MethodBind8, GodotObject.GetPtr(this), seamless.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSeamless, 2240911060ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetSeamless()
    {
        return NativeCalls.godot_icall_0_40(MethodBind9, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSeamlessBlendSkirt, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSeamlessBlendSkirt(float seamlessBlendSkirt)
    {
        NativeCalls.godot_icall_1_62(MethodBind10, GodotObject.GetPtr(this), seamlessBlendSkirt);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSeamlessBlendSkirt, 191475506ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetSeamlessBlendSkirt()
    {
        return NativeCalls.godot_icall_0_63(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAsNormalMap, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAsNormalMap(bool asNormalMap)
    {
        NativeCalls.godot_icall_1_41(MethodBind12, GodotObject.GetPtr(this), asNormalMap.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsNormalMap, 2240911060ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsNormalMap()
    {
        return NativeCalls.godot_icall_0_40(MethodBind13, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBumpStrength, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBumpStrength(float bumpStrength)
    {
        NativeCalls.godot_icall_1_62(MethodBind14, GodotObject.GetPtr(this), bumpStrength);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBumpStrength, 191475506ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetBumpStrength()
    {
        return NativeCalls.godot_icall_0_63(MethodBind15, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNormalize, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNormalize(bool normalize)
    {
        NativeCalls.godot_icall_1_41(MethodBind16, GodotObject.GetPtr(this), normalize.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsNormalized, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsNormalized()
    {
        return NativeCalls.godot_icall_0_40(MethodBind17, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetColorRamp, 2756054477ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetColorRamp(Gradient gradient)
    {
        NativeCalls.godot_icall_1_55(MethodBind18, GodotObject.GetPtr(this), GodotObject.GetPtr(gradient));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetColorRamp, 132272999ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Gradient GetColorRamp()
    {
        return (Gradient)NativeCalls.godot_icall_0_58(MethodBind19, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNoise, 4135492439ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNoise(Noise noise)
    {
        NativeCalls.godot_icall_1_55(MethodBind20, GodotObject.GetPtr(this), GodotObject.GetPtr(noise));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNoise, 185851837ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Noise GetNoise()
    {
        return (Noise)NativeCalls.godot_icall_0_58(MethodBind21, GodotObject.GetPtr(this));
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
    public new class PropertyName : Texture2D.PropertyName
    {
        /// <summary>
        /// Cached name for the 'width' property.
        /// </summary>
        public static readonly StringName Width = "width";
        /// <summary>
        /// Cached name for the 'height' property.
        /// </summary>
        public static readonly StringName Height = "height";
        /// <summary>
        /// Cached name for the 'invert' property.
        /// </summary>
        public static readonly StringName Invert = "invert";
        /// <summary>
        /// Cached name for the 'in_3d_space' property.
        /// </summary>
        public static readonly StringName In3DSpace = "in_3d_space";
        /// <summary>
        /// Cached name for the 'generate_mipmaps' property.
        /// </summary>
        public static readonly StringName GenerateMipmaps = "generate_mipmaps";
        /// <summary>
        /// Cached name for the 'seamless' property.
        /// </summary>
        public static readonly StringName Seamless = "seamless";
        /// <summary>
        /// Cached name for the 'seamless_blend_skirt' property.
        /// </summary>
        public static readonly StringName SeamlessBlendSkirt = "seamless_blend_skirt";
        /// <summary>
        /// Cached name for the 'as_normal_map' property.
        /// </summary>
        public static readonly StringName AsNormalMap = "as_normal_map";
        /// <summary>
        /// Cached name for the 'bump_strength' property.
        /// </summary>
        public static readonly StringName BumpStrength = "bump_strength";
        /// <summary>
        /// Cached name for the 'normalize' property.
        /// </summary>
        public static readonly StringName Normalize = "normalize";
        /// <summary>
        /// Cached name for the 'color_ramp' property.
        /// </summary>
        public static readonly StringName ColorRamp = "color_ramp";
        /// <summary>
        /// Cached name for the 'noise' property.
        /// </summary>
        public static readonly StringName Noise = "noise";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Texture2D.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_width' method.
        /// </summary>
        public static readonly StringName SetWidth = "set_width";
        /// <summary>
        /// Cached name for the 'set_height' method.
        /// </summary>
        public static readonly StringName SetHeight = "set_height";
        /// <summary>
        /// Cached name for the 'set_invert' method.
        /// </summary>
        public static readonly StringName SetInvert = "set_invert";
        /// <summary>
        /// Cached name for the 'get_invert' method.
        /// </summary>
        public static readonly StringName GetInvert = "get_invert";
        /// <summary>
        /// Cached name for the 'set_in_3d_space' method.
        /// </summary>
        public static readonly StringName SetIn3DSpace = "set_in_3d_space";
        /// <summary>
        /// Cached name for the 'is_in_3d_space' method.
        /// </summary>
        public static readonly StringName IsIn3DSpace = "is_in_3d_space";
        /// <summary>
        /// Cached name for the 'set_generate_mipmaps' method.
        /// </summary>
        public static readonly StringName SetGenerateMipmaps = "set_generate_mipmaps";
        /// <summary>
        /// Cached name for the 'is_generating_mipmaps' method.
        /// </summary>
        public static readonly StringName IsGeneratingMipmaps = "is_generating_mipmaps";
        /// <summary>
        /// Cached name for the 'set_seamless' method.
        /// </summary>
        public static readonly StringName SetSeamless = "set_seamless";
        /// <summary>
        /// Cached name for the 'get_seamless' method.
        /// </summary>
        public static readonly StringName GetSeamless = "get_seamless";
        /// <summary>
        /// Cached name for the 'set_seamless_blend_skirt' method.
        /// </summary>
        public static readonly StringName SetSeamlessBlendSkirt = "set_seamless_blend_skirt";
        /// <summary>
        /// Cached name for the 'get_seamless_blend_skirt' method.
        /// </summary>
        public static readonly StringName GetSeamlessBlendSkirt = "get_seamless_blend_skirt";
        /// <summary>
        /// Cached name for the 'set_as_normal_map' method.
        /// </summary>
        public static readonly StringName SetAsNormalMap = "set_as_normal_map";
        /// <summary>
        /// Cached name for the 'is_normal_map' method.
        /// </summary>
        public static readonly StringName IsNormalMap = "is_normal_map";
        /// <summary>
        /// Cached name for the 'set_bump_strength' method.
        /// </summary>
        public static readonly StringName SetBumpStrength = "set_bump_strength";
        /// <summary>
        /// Cached name for the 'get_bump_strength' method.
        /// </summary>
        public static readonly StringName GetBumpStrength = "get_bump_strength";
        /// <summary>
        /// Cached name for the 'set_normalize' method.
        /// </summary>
        public static readonly StringName SetNormalize = "set_normalize";
        /// <summary>
        /// Cached name for the 'is_normalized' method.
        /// </summary>
        public static readonly StringName IsNormalized = "is_normalized";
        /// <summary>
        /// Cached name for the 'set_color_ramp' method.
        /// </summary>
        public static readonly StringName SetColorRamp = "set_color_ramp";
        /// <summary>
        /// Cached name for the 'get_color_ramp' method.
        /// </summary>
        public static readonly StringName GetColorRamp = "get_color_ramp";
        /// <summary>
        /// Cached name for the 'set_noise' method.
        /// </summary>
        public static readonly StringName SetNoise = "set_noise";
        /// <summary>
        /// Cached name for the 'get_noise' method.
        /// </summary>
        public static readonly StringName GetNoise = "get_noise";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Texture2D.SignalName
    {
    }
}
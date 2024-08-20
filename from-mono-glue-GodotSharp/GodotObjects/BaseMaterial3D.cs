namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>This class serves as a default material with a wide variety of rendering features and properties without the need to write shader code. See the tutorial below for details.</para>
/// </summary>
public partial class BaseMaterial3D : Material
{
    public enum TextureParam : long
    {
        /// <summary>
        /// <para>Texture specifying per-pixel color.</para>
        /// </summary>
        Albedo = 0,
        /// <summary>
        /// <para>Texture specifying per-pixel metallic value.</para>
        /// </summary>
        Metallic = 1,
        /// <summary>
        /// <para>Texture specifying per-pixel roughness value.</para>
        /// </summary>
        Roughness = 2,
        /// <summary>
        /// <para>Texture specifying per-pixel emission color.</para>
        /// </summary>
        Emission = 3,
        /// <summary>
        /// <para>Texture specifying per-pixel normal vector.</para>
        /// </summary>
        Normal = 4,
        /// <summary>
        /// <para>Texture specifying per-pixel rim value.</para>
        /// </summary>
        Rim = 5,
        /// <summary>
        /// <para>Texture specifying per-pixel clearcoat value.</para>
        /// </summary>
        Clearcoat = 6,
        /// <summary>
        /// <para>Texture specifying per-pixel flowmap direction for use with <see cref="Godot.BaseMaterial3D.Anisotropy"/>.</para>
        /// </summary>
        Flowmap = 7,
        /// <summary>
        /// <para>Texture specifying per-pixel ambient occlusion value.</para>
        /// </summary>
        AmbientOcclusion = 8,
        /// <summary>
        /// <para>Texture specifying per-pixel height.</para>
        /// </summary>
        Heightmap = 9,
        /// <summary>
        /// <para>Texture specifying per-pixel subsurface scattering.</para>
        /// </summary>
        SubsurfaceScattering = 10,
        /// <summary>
        /// <para>Texture specifying per-pixel transmittance for subsurface scattering.</para>
        /// </summary>
        SubsurfaceTransmittance = 11,
        /// <summary>
        /// <para>Texture specifying per-pixel backlight color.</para>
        /// </summary>
        Backlight = 12,
        /// <summary>
        /// <para>Texture specifying per-pixel refraction strength.</para>
        /// </summary>
        Refraction = 13,
        /// <summary>
        /// <para>Texture specifying per-pixel detail mask blending value.</para>
        /// </summary>
        DetailMask = 14,
        /// <summary>
        /// <para>Texture specifying per-pixel detail color.</para>
        /// </summary>
        DetailAlbedo = 15,
        /// <summary>
        /// <para>Texture specifying per-pixel detail normal.</para>
        /// </summary>
        DetailNormal = 16,
        /// <summary>
        /// <para>Texture holding ambient occlusion, roughness, and metallic.</para>
        /// </summary>
        Orm = 17,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.BaseMaterial3D.TextureParam"/> enum.</para>
        /// </summary>
        Max = 18
    }

    public enum TextureFilterEnum : long
    {
        /// <summary>
        /// <para>The texture filter reads from the nearest pixel only. This makes the texture look pixelated from up close, and grainy from a distance (due to mipmaps not being sampled).</para>
        /// </summary>
        Nearest = 0,
        /// <summary>
        /// <para>The texture filter blends between the nearest 4 pixels. This makes the texture look smooth from up close, and grainy from a distance (due to mipmaps not being sampled).</para>
        /// </summary>
        Linear = 1,
        /// <summary>
        /// <para>The texture filter reads from the nearest pixel and blends between the nearest 2 mipmaps (or uses the nearest mipmap if <c>ProjectSettings.rendering/textures/default_filters/use_nearest_mipmap_filter</c> is <see langword="true"/>). This makes the texture look pixelated from up close, and smooth from a distance.</para>
        /// </summary>
        NearestWithMipmaps = 2,
        /// <summary>
        /// <para>The texture filter blends between the nearest 4 pixels and between the nearest 2 mipmaps (or uses the nearest mipmap if <c>ProjectSettings.rendering/textures/default_filters/use_nearest_mipmap_filter</c> is <see langword="true"/>). This makes the texture look smooth from up close, and smooth from a distance.</para>
        /// </summary>
        LinearWithMipmaps = 3,
        /// <summary>
        /// <para>The texture filter reads from the nearest pixel and blends between 2 mipmaps (or uses the nearest mipmap if <c>ProjectSettings.rendering/textures/default_filters/use_nearest_mipmap_filter</c> is <see langword="true"/>) based on the angle between the surface and the camera view. This makes the texture look pixelated from up close, and smooth from a distance. Anisotropic filtering improves texture quality on surfaces that are almost in line with the camera, but is slightly slower. The anisotropic filtering level can be changed by adjusting <c>ProjectSettings.rendering/textures/default_filters/anisotropic_filtering_level</c>.</para>
        /// </summary>
        NearestWithMipmapsAnisotropic = 4,
        /// <summary>
        /// <para>The texture filter blends between the nearest 4 pixels and blends between 2 mipmaps (or uses the nearest mipmap if <c>ProjectSettings.rendering/textures/default_filters/use_nearest_mipmap_filter</c> is <see langword="true"/>) based on the angle between the surface and the camera view. This makes the texture look smooth from up close, and smooth from a distance. Anisotropic filtering improves texture quality on surfaces that are almost in line with the camera, but is slightly slower. The anisotropic filtering level can be changed by adjusting <c>ProjectSettings.rendering/textures/default_filters/anisotropic_filtering_level</c>.</para>
        /// </summary>
        LinearWithMipmapsAnisotropic = 5,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.BaseMaterial3D.TextureFilterEnum"/> enum.</para>
        /// </summary>
        Max = 6
    }

    public enum DetailUV : long
    {
        /// <summary>
        /// <para>Use <c>UV</c> with the detail texture.</para>
        /// </summary>
        UV1 = 0,
        /// <summary>
        /// <para>Use <c>UV2</c> with the detail texture.</para>
        /// </summary>
        UV2 = 1
    }

    public enum TransparencyEnum : long
    {
        /// <summary>
        /// <para>The material will not use transparency. This is the fastest to render.</para>
        /// </summary>
        Disabled = 0,
        /// <summary>
        /// <para>The material will use the texture's alpha values for transparency. This is the slowest to render, and disables shadow casting.</para>
        /// </summary>
        Alpha = 1,
        /// <summary>
        /// <para>The material will cut off all values below a threshold, the rest will remain opaque. The opaque portions will be rendered in the depth prepass. This is faster to render than alpha blending, but slower than opaque rendering. This also supports casting shadows.</para>
        /// </summary>
        AlphaScissor = 2,
        /// <summary>
        /// <para>The material will cut off all values below a spatially-deterministic threshold, the rest will remain opaque. This is faster to render than alpha blending, but slower than opaque rendering. This also supports casting shadows. Alpha hashing is suited for hair rendering.</para>
        /// </summary>
        AlphaHash = 3,
        /// <summary>
        /// <para>The material will use the texture's alpha value for transparency, but will discard fragments with an alpha of less than 0.99 during the depth prepass and fragments with an alpha less than 0.1 during the shadow pass. This also supports casting shadows.</para>
        /// </summary>
        AlphaDepthPrePass = 4,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.BaseMaterial3D.TransparencyEnum"/> enum.</para>
        /// </summary>
        Max = 5
    }

    public enum ShadingModeEnum : long
    {
        /// <summary>
        /// <para>The object will not receive shadows. This is the fastest to render, but it disables all interactions with lights.</para>
        /// </summary>
        Unshaded = 0,
        /// <summary>
        /// <para>The object will be shaded per pixel. Useful for realistic shading effects.</para>
        /// </summary>
        PerPixel = 1,
        /// <summary>
        /// <para>The object will be shaded per vertex. Useful when you want cheaper shaders and do not care about visual quality. Not implemented yet (this mode will act like <see cref="Godot.BaseMaterial3D.ShadingModeEnum.PerPixel"/>).</para>
        /// </summary>
        PerVertex = 2,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.BaseMaterial3D.ShadingModeEnum"/> enum.</para>
        /// </summary>
        Max = 3
    }

    public enum Feature : long
    {
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.EmissionEnabled"/>.</para>
        /// </summary>
        Emission = 0,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.NormalEnabled"/>.</para>
        /// </summary>
        NormalMapping = 1,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.RimEnabled"/>.</para>
        /// </summary>
        Rim = 2,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.ClearcoatEnabled"/>.</para>
        /// </summary>
        Clearcoat = 3,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.AnisotropyEnabled"/>.</para>
        /// </summary>
        Anisotropy = 4,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.AOEnabled"/>.</para>
        /// </summary>
        AmbientOcclusion = 5,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.HeightmapEnabled"/>.</para>
        /// </summary>
        HeightMapping = 6,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.SubsurfScatterEnabled"/>.</para>
        /// </summary>
        SubsurfaceScattering = 7,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.SubsurfScatterTransmittanceEnabled"/>.</para>
        /// </summary>
        SubsurfaceTransmittance = 8,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.BacklightEnabled"/>.</para>
        /// </summary>
        Backlight = 9,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.RefractionEnabled"/>.</para>
        /// </summary>
        Refraction = 10,
        /// <summary>
        /// <para>Constant for setting <see cref="Godot.BaseMaterial3D.DetailEnabled"/>.</para>
        /// </summary>
        Detail = 11,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.BaseMaterial3D.Feature"/> enum.</para>
        /// </summary>
        Max = 12
    }

    public enum BlendModeEnum : long
    {
        /// <summary>
        /// <para>Default blend mode. The color of the object is blended over the background based on the object's alpha value.</para>
        /// </summary>
        Mix = 0,
        /// <summary>
        /// <para>The color of the object is added to the background.</para>
        /// </summary>
        Add = 1,
        /// <summary>
        /// <para>The color of the object is subtracted from the background.</para>
        /// </summary>
        Sub = 2,
        /// <summary>
        /// <para>The color of the object is multiplied by the background.</para>
        /// </summary>
        Mul = 3,
        /// <summary>
        /// <para>The color of the object is added to the background and the alpha channel is used to mask out the background. This is effectively a hybrid of the blend mix and add modes, useful for effects like fire where you want the flame to add but the smoke to mix. By default, this works with unshaded materials using premultiplied textures. For shaded materials, use the <c>PREMUL_ALPHA_FACTOR</c> built-in so that lighting can be modulated as well.</para>
        /// </summary>
        PremultAlpha = 4
    }

    public enum AlphaAntiAliasing : long
    {
        /// <summary>
        /// <para>Disables Alpha AntiAliasing for the material.</para>
        /// </summary>
        Off = 0,
        /// <summary>
        /// <para>Enables AlphaToCoverage. Alpha values in the material are passed to the AntiAliasing sample mask.</para>
        /// </summary>
        AlphaToCoverage = 1,
        /// <summary>
        /// <para>Enables AlphaToCoverage and forces all non-zero alpha values to <c>1</c>. Alpha values in the material are passed to the AntiAliasing sample mask.</para>
        /// </summary>
        AlphaToCoverageAndToOne = 2
    }

    public enum DepthDrawModeEnum : long
    {
        /// <summary>
        /// <para>Default depth draw mode. Depth is drawn only for opaque objects during the opaque prepass (if any) and during the opaque pass.</para>
        /// </summary>
        OpaqueOnly = 0,
        /// <summary>
        /// <para>Objects will write to depth during the opaque and the transparent passes. Transparent objects that are close to the camera may obscure other transparent objects behind them.</para>
        /// <para><b>Note:</b> This does not influence whether transparent objects are included in the depth prepass or not. For that, see <see cref="Godot.BaseMaterial3D.TransparencyEnum"/>.</para>
        /// </summary>
        Always = 1,
        /// <summary>
        /// <para>Objects will not write their depth to the depth buffer, even during the depth prepass (if enabled).</para>
        /// </summary>
        Disabled = 2
    }

    public enum CullModeEnum : long
    {
        /// <summary>
        /// <para>Default cull mode. The back of the object is culled when not visible. Back face triangles will be culled when facing the camera. This results in only the front side of triangles being drawn. For closed-surface meshes, this means that only the exterior of the mesh will be visible.</para>
        /// </summary>
        Back = 0,
        /// <summary>
        /// <para>Front face triangles will be culled when facing the camera. This results in only the back side of triangles being drawn. For closed-surface meshes, this means that the interior of the mesh will be drawn instead of the exterior.</para>
        /// </summary>
        Front = 1,
        /// <summary>
        /// <para>No face culling is performed; both the front face and back face will be visible.</para>
        /// </summary>
        Disabled = 2
    }

    public enum Flags : long
    {
        /// <summary>
        /// <para>Disables the depth test, so this object is drawn on top of all others drawn before it. This puts the object in the transparent draw pass where it is sorted based on distance to camera. Objects drawn after it in the draw order may cover it. This also disables writing to depth.</para>
        /// </summary>
        DisableDepthTest = 0,
        /// <summary>
        /// <para>Set <c>ALBEDO</c> to the per-vertex color specified in the mesh.</para>
        /// </summary>
        AlbedoFromVertexColor = 1,
        /// <summary>
        /// <para>Vertex colors are considered to be stored in sRGB color space and are converted to linear color space during rendering. See also <see cref="Godot.BaseMaterial3D.VertexColorIsSrgb"/>.</para>
        /// <para><b>Note:</b> Only effective when using the Forward+ and Mobile rendering methods.</para>
        /// </summary>
        SrgbVertexColor = 2,
        /// <summary>
        /// <para>Uses point size to alter the size of primitive points. Also changes the albedo texture lookup to use <c>POINT_COORD</c> instead of <c>UV</c>.</para>
        /// </summary>
        UsePointSize = 3,
        /// <summary>
        /// <para>Object is scaled by depth so that it always appears the same size on screen.</para>
        /// </summary>
        FixedSize = 4,
        /// <summary>
        /// <para>Shader will keep the scale set for the mesh. Otherwise the scale is lost when billboarding. Only applies when <see cref="Godot.BaseMaterial3D.BillboardMode"/> is <see cref="Godot.BaseMaterial3D.BillboardModeEnum.Enabled"/>.</para>
        /// </summary>
        BillboardKeepScale = 5,
        /// <summary>
        /// <para>Use triplanar texture lookup for all texture lookups that would normally use <c>UV</c>.</para>
        /// </summary>
        Uv1UseTriplanar = 6,
        /// <summary>
        /// <para>Use triplanar texture lookup for all texture lookups that would normally use <c>UV2</c>.</para>
        /// </summary>
        UV2UseTriplanar = 7,
        /// <summary>
        /// <para>Use triplanar texture lookup for all texture lookups that would normally use <c>UV</c>.</para>
        /// </summary>
        Uv1UseWorldTriplanar = 8,
        /// <summary>
        /// <para>Use triplanar texture lookup for all texture lookups that would normally use <c>UV2</c>.</para>
        /// </summary>
        UV2UseWorldTriplanar = 9,
        /// <summary>
        /// <para>Use <c>UV2</c> coordinates to look up from the <see cref="Godot.BaseMaterial3D.AOTexture"/>.</para>
        /// </summary>
        AOOnUV2 = 10,
        /// <summary>
        /// <para>Use <c>UV2</c> coordinates to look up from the <see cref="Godot.BaseMaterial3D.EmissionTexture"/>.</para>
        /// </summary>
        EmissionOnUV2 = 11,
        /// <summary>
        /// <para>Forces the shader to convert albedo from sRGB space to linear space. See also <see cref="Godot.BaseMaterial3D.AlbedoTextureForceSrgb"/>.</para>
        /// </summary>
        AlbedoTextureForceSrgb = 12,
        /// <summary>
        /// <para>Disables receiving shadows from other objects.</para>
        /// </summary>
        DontReceiveShadows = 13,
        /// <summary>
        /// <para>Disables receiving ambient light.</para>
        /// </summary>
        DisableAmbientLight = 14,
        /// <summary>
        /// <para>Enables the shadow to opacity feature.</para>
        /// </summary>
        UseShadowToOpacity = 15,
        /// <summary>
        /// <para>Enables the texture to repeat when UV coordinates are outside the 0-1 range. If using one of the linear filtering modes, this can result in artifacts at the edges of a texture when the sampler filters across the edges of the texture.</para>
        /// </summary>
        UseTextureRepeat = 16,
        /// <summary>
        /// <para>Invert values read from a depth texture to convert them to height values (heightmap).</para>
        /// </summary>
        InvertHeightmap = 17,
        /// <summary>
        /// <para>Enables the skin mode for subsurface scattering which is used to improve the look of subsurface scattering when used for human skin.</para>
        /// </summary>
        SubsurfaceModeSkin = 18,
        /// <summary>
        /// <para>Enables parts of the shader required for <see cref="Godot.GpuParticles3D"/> trails to function. This also requires using a mesh with appropriate skinning, such as <see cref="Godot.RibbonTrailMesh"/> or <see cref="Godot.TubeTrailMesh"/>. Enabling this feature outside of materials used in <see cref="Godot.GpuParticles3D"/> meshes will break material rendering.</para>
        /// </summary>
        ParticleTrailsMode = 19,
        /// <summary>
        /// <para>Enables multichannel signed distance field rendering shader.</para>
        /// </summary>
        AlbedoTextureMsdf = 20,
        /// <summary>
        /// <para>Disables receiving depth-based or volumetric fog.</para>
        /// </summary>
        DisableFog = 21,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.BaseMaterial3D.Flags"/> enum.</para>
        /// </summary>
        Max = 22
    }

    public enum DiffuseModeEnum : long
    {
        /// <summary>
        /// <para>Default diffuse scattering algorithm.</para>
        /// </summary>
        Burley = 0,
        /// <summary>
        /// <para>Diffuse scattering ignores roughness.</para>
        /// </summary>
        Lambert = 1,
        /// <summary>
        /// <para>Extends Lambert to cover more than 90 degrees when roughness increases.</para>
        /// </summary>
        LambertWrap = 2,
        /// <summary>
        /// <para>Uses a hard cut for lighting, with smoothing affected by roughness.</para>
        /// </summary>
        Toon = 3
    }

    public enum SpecularModeEnum : long
    {
        /// <summary>
        /// <para>Default specular blob.</para>
        /// </summary>
        SchlickGgx = 0,
        /// <summary>
        /// <para>Toon blob which changes size based on roughness.</para>
        /// </summary>
        Toon = 1,
        /// <summary>
        /// <para>No specular blob. This is slightly faster to render than other specular modes.</para>
        /// </summary>
        Disabled = 2
    }

    public enum BillboardModeEnum : long
    {
        /// <summary>
        /// <para>Billboard mode is disabled.</para>
        /// </summary>
        Disabled = 0,
        /// <summary>
        /// <para>The object's Z axis will always face the camera.</para>
        /// </summary>
        Enabled = 1,
        /// <summary>
        /// <para>The object's X axis will always face the camera.</para>
        /// </summary>
        FixedY = 2,
        /// <summary>
        /// <para>Used for particle systems when assigned to <see cref="Godot.GpuParticles3D"/> and <see cref="Godot.CpuParticles3D"/> nodes (flipbook animation). Enables <c>particles_anim_*</c> properties.</para>
        /// <para>The <see cref="Godot.ParticleProcessMaterial.AnimSpeedMin"/> or <see cref="Godot.CpuParticles3D.AnimSpeedMin"/> should also be set to a value bigger than zero for the animation to play.</para>
        /// </summary>
        Particles = 3
    }

    public enum TextureChannel : long
    {
        /// <summary>
        /// <para>Used to read from the red channel of a texture.</para>
        /// </summary>
        Red = 0,
        /// <summary>
        /// <para>Used to read from the green channel of a texture.</para>
        /// </summary>
        Green = 1,
        /// <summary>
        /// <para>Used to read from the blue channel of a texture.</para>
        /// </summary>
        Blue = 2,
        /// <summary>
        /// <para>Used to read from the alpha channel of a texture.</para>
        /// </summary>
        Alpha = 3,
        /// <summary>
        /// <para>Used to read from the linear (non-perceptual) average of the red, green and blue channels of a texture.</para>
        /// </summary>
        Grayscale = 4
    }

    public enum EmissionOperatorEnum : long
    {
        /// <summary>
        /// <para>Adds the emission color to the color from the emission texture.</para>
        /// </summary>
        Add = 0,
        /// <summary>
        /// <para>Multiplies the emission color by the color from the emission texture.</para>
        /// </summary>
        Multiply = 1
    }

    public enum DistanceFadeModeEnum : long
    {
        /// <summary>
        /// <para>Do not use distance fade.</para>
        /// </summary>
        Disabled = 0,
        /// <summary>
        /// <para>Smoothly fades the object out based on each pixel's distance from the camera using the alpha channel.</para>
        /// </summary>
        PixelAlpha = 1,
        /// <summary>
        /// <para>Smoothly fades the object out based on each pixel's distance from the camera using a dithering approach. Dithering discards pixels based on a set pattern to smoothly fade without enabling transparency. On certain hardware, this can be faster than <see cref="Godot.BaseMaterial3D.DistanceFadeModeEnum.PixelAlpha"/>.</para>
        /// </summary>
        PixelDither = 2,
        /// <summary>
        /// <para>Smoothly fades the object out based on the object's distance from the camera using a dithering approach. Dithering discards pixels based on a set pattern to smoothly fade without enabling transparency. On certain hardware, this can be faster than <see cref="Godot.BaseMaterial3D.DistanceFadeModeEnum.PixelAlpha"/> and <see cref="Godot.BaseMaterial3D.DistanceFadeModeEnum.PixelDither"/>.</para>
        /// </summary>
        ObjectDither = 3
    }

    /// <summary>
    /// <para>The material's transparency mode. Some transparency modes will disable shadow casting. Any transparency mode other than <see cref="Godot.BaseMaterial3D.TransparencyEnum.Disabled"/> has a greater performance impact compared to opaque rendering. See also <see cref="Godot.BaseMaterial3D.BlendMode"/>.</para>
    /// </summary>
    public BaseMaterial3D.TransparencyEnum Transparency
    {
        get
        {
            return GetTransparency();
        }
        set
        {
            SetTransparency(value);
        }
    }

    /// <summary>
    /// <para>Threshold at which the alpha scissor will discard values. Higher values will result in more pixels being discarded. If the material becomes too opaque at a distance, try increasing <see cref="Godot.BaseMaterial3D.AlphaScissorThreshold"/>. If the material disappears at a distance, try decreasing <see cref="Godot.BaseMaterial3D.AlphaScissorThreshold"/>.</para>
    /// </summary>
    public float AlphaScissorThreshold
    {
        get
        {
            return GetAlphaScissorThreshold();
        }
        set
        {
            SetAlphaScissorThreshold(value);
        }
    }

    /// <summary>
    /// <para>The hashing scale for Alpha Hash. Recommended values between <c>0</c> and <c>2</c>.</para>
    /// </summary>
    public float AlphaHashScale
    {
        get
        {
            return GetAlphaHashScale();
        }
        set
        {
            SetAlphaHashScale(value);
        }
    }

    /// <summary>
    /// <para>The type of alpha antialiasing to apply. See <see cref="Godot.BaseMaterial3D.AlphaAntiAliasing"/>.</para>
    /// </summary>
    public BaseMaterial3D.AlphaAntiAliasing AlphaAntialiasingMode
    {
        get
        {
            return GetAlphaAntialiasing();
        }
        set
        {
            SetAlphaAntialiasing(value);
        }
    }

    /// <summary>
    /// <para>Threshold at which antialiasing will be applied on the alpha channel.</para>
    /// </summary>
    public float AlphaAntialiasingEdge
    {
        get
        {
            return GetAlphaAntialiasingEdge();
        }
        set
        {
            SetAlphaAntialiasingEdge(value);
        }
    }

    /// <summary>
    /// <para>The material's blend mode.</para>
    /// <para><b>Note:</b> Values other than <c>Mix</c> force the object into the transparent pipeline. See <see cref="Godot.BaseMaterial3D.BlendModeEnum"/>.</para>
    /// </summary>
    public BaseMaterial3D.BlendModeEnum BlendMode
    {
        get
        {
            return GetBlendMode();
        }
        set
        {
            SetBlendMode(value);
        }
    }

    /// <summary>
    /// <para>Determines which side of the triangle to cull depending on whether the triangle faces towards or away from the camera. See <see cref="Godot.BaseMaterial3D.CullModeEnum"/>.</para>
    /// </summary>
    public BaseMaterial3D.CullModeEnum CullMode
    {
        get
        {
            return GetCullMode();
        }
        set
        {
            SetCullMode(value);
        }
    }

    /// <summary>
    /// <para>Determines when depth rendering takes place. See <see cref="Godot.BaseMaterial3D.DepthDrawModeEnum"/>. See also <see cref="Godot.BaseMaterial3D.Transparency"/>.</para>
    /// </summary>
    public BaseMaterial3D.DepthDrawModeEnum DepthDrawMode
    {
        get
        {
            return GetDepthDrawMode();
        }
        set
        {
            SetDepthDrawMode(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, depth testing is disabled and the object will be drawn in render order.</para>
    /// </summary>
    public bool NoDepthTest
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(0));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(0), value);
        }
    }

    /// <summary>
    /// <para>Sets whether the shading takes place, per-pixel, per-vertex or unshaded. Per-vertex lighting is faster, making it the best choice for mobile applications, however it looks considerably worse than per-pixel. Unshaded rendering is the fastest, but disables all interactions with lights.</para>
    /// <para><b>Note:</b> Setting the shading mode vertex shading currently has no effect, as vertex shading is not implemented yet.</para>
    /// </summary>
    public BaseMaterial3D.ShadingModeEnum ShadingMode
    {
        get
        {
            return GetShadingMode();
        }
        set
        {
            SetShadingMode(value);
        }
    }

    /// <summary>
    /// <para>The algorithm used for diffuse light scattering. See <see cref="Godot.BaseMaterial3D.DiffuseModeEnum"/>.</para>
    /// </summary>
    public BaseMaterial3D.DiffuseModeEnum DiffuseMode
    {
        get
        {
            return GetDiffuseMode();
        }
        set
        {
            SetDiffuseMode(value);
        }
    }

    /// <summary>
    /// <para>The method for rendering the specular blob. See <see cref="Godot.BaseMaterial3D.SpecularModeEnum"/>.</para>
    /// <para><b>Note:</b> <see cref="Godot.BaseMaterial3D.SpecularMode"/> only applies to the specular blob. It does not affect specular reflections from the sky, screen-space reflections, <see cref="Godot.VoxelGI"/>, SDFGI or <see cref="Godot.ReflectionProbe"/>s. To disable reflections from these sources as well, set <see cref="Godot.BaseMaterial3D.MetallicSpecular"/> to <c>0.0</c> instead.</para>
    /// </summary>
    public BaseMaterial3D.SpecularModeEnum SpecularMode
    {
        get
        {
            return GetSpecularMode();
        }
        set
        {
            SetSpecularMode(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the object receives no ambient light.</para>
    /// </summary>
    public bool DisableAmbientLight
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(14));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(14), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the object will not be affected by fog (neither volumetric nor depth fog). This is useful for unshaded or transparent materials (e.g. particles), which without this setting will be affected even if fully transparent.</para>
    /// </summary>
    public bool DisableFog
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(21));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(21), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the vertex color is used as albedo color.</para>
    /// </summary>
    public bool VertexColorUseAsAlbedo
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(1));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(1), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, vertex colors are considered to be stored in sRGB color space and are converted to linear color space during rendering. If <see langword="false"/>, vertex colors are considered to be stored in linear color space and are rendered as-is. See also <see cref="Godot.BaseMaterial3D.AlbedoTextureForceSrgb"/>.</para>
    /// <para><b>Note:</b> Only effective when using the Forward+ and Mobile rendering methods, not Compatibility.</para>
    /// </summary>
    public bool VertexColorIsSrgb
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(2));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(2), value);
        }
    }

    /// <summary>
    /// <para>The material's base color.</para>
    /// <para><b>Note:</b> If <see cref="Godot.BaseMaterial3D.DetailEnabled"/> is <see langword="true"/> and a <see cref="Godot.BaseMaterial3D.DetailAlbedo"/> texture is specified, <see cref="Godot.BaseMaterial3D.AlbedoColor"/> will <i>not</i> modulate the detail texture. This can be used to color partial areas of a material by not specifying an albedo texture and using a transparent <see cref="Godot.BaseMaterial3D.DetailAlbedo"/> texture instead.</para>
    /// </summary>
    public Color AlbedoColor
    {
        get
        {
            return GetAlbedo();
        }
        set
        {
            SetAlbedo(value);
        }
    }

    /// <summary>
    /// <para>Texture to multiply by <see cref="Godot.BaseMaterial3D.AlbedoColor"/>. Used for basic texturing of objects.</para>
    /// <para>If the texture appears unexpectedly too dark or too bright, check <see cref="Godot.BaseMaterial3D.AlbedoTextureForceSrgb"/>.</para>
    /// </summary>
    public Texture2D AlbedoTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(0));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(0), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, forces a conversion of the <see cref="Godot.BaseMaterial3D.AlbedoTexture"/> from sRGB color space to linear color space. See also <see cref="Godot.BaseMaterial3D.VertexColorIsSrgb"/>.</para>
    /// <para>This should only be enabled when needed (typically when using a <see cref="Godot.ViewportTexture"/> as <see cref="Godot.BaseMaterial3D.AlbedoTexture"/>). If <see cref="Godot.BaseMaterial3D.AlbedoTextureForceSrgb"/> is <see langword="true"/> when it shouldn't be, the texture will appear to be too dark. If <see cref="Godot.BaseMaterial3D.AlbedoTextureForceSrgb"/> is <see langword="false"/> when it shouldn't be, the texture will appear to be too bright.</para>
    /// </summary>
    public bool AlbedoTextureForceSrgb
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(12));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(12), value);
        }
    }

    /// <summary>
    /// <para>Enables multichannel signed distance field rendering shader. Use <see cref="Godot.BaseMaterial3D.MsdfPixelRange"/> and <see cref="Godot.BaseMaterial3D.MsdfOutlineSize"/> to configure MSDF parameters.</para>
    /// </summary>
    public bool AlbedoTextureMsdf
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(20));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(20), value);
        }
    }

    /// <summary>
    /// <para>The Occlusion/Roughness/Metallic texture to use. This is a more efficient replacement of <see cref="Godot.BaseMaterial3D.AOTexture"/>, <see cref="Godot.BaseMaterial3D.RoughnessTexture"/> and <see cref="Godot.BaseMaterial3D.MetallicTexture"/> in <see cref="Godot.OrmMaterial3D"/>. Ambient occlusion is stored in the red channel. Roughness map is stored in the green channel. Metallic map is stored in the blue channel. The alpha channel is ignored.</para>
    /// </summary>
    public Texture2D OrmTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(17));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(17), value);
        }
    }

    /// <summary>
    /// <para>A high value makes the material appear more like a metal. Non-metals use their albedo as the diffuse color and add diffuse to the specular reflection. With non-metals, the reflection appears on top of the albedo color. Metals use their albedo as a multiplier to the specular reflection and set the diffuse color to black resulting in a tinted reflection. Materials work better when fully metal or fully non-metal, values between <c>0</c> and <c>1</c> should only be used for blending between metal and non-metal sections. To alter the amount of reflection use <see cref="Godot.BaseMaterial3D.Roughness"/>.</para>
    /// </summary>
    public float Metallic
    {
        get
        {
            return GetMetallic();
        }
        set
        {
            SetMetallic(value);
        }
    }

    /// <summary>
    /// <para>Adjusts the strength of specular reflections. Specular reflections are composed of scene reflections and the specular lobe which is the bright spot that is reflected from light sources. When set to <c>0.0</c>, no specular reflections will be visible. This differs from the <see cref="Godot.BaseMaterial3D.SpecularModeEnum.Disabled"/> <see cref="Godot.BaseMaterial3D.SpecularModeEnum"/> as <see cref="Godot.BaseMaterial3D.SpecularModeEnum.Disabled"/> only applies to the specular lobe from the light source.</para>
    /// <para><b>Note:</b> Unlike <see cref="Godot.BaseMaterial3D.Metallic"/>, this is not energy-conserving, so it should be left at <c>0.5</c> in most cases. See also <see cref="Godot.BaseMaterial3D.Roughness"/>.</para>
    /// </summary>
    public float MetallicSpecular
    {
        get
        {
            return GetSpecular();
        }
        set
        {
            SetSpecular(value);
        }
    }

    /// <summary>
    /// <para>Texture used to specify metallic for an object. This is multiplied by <see cref="Godot.BaseMaterial3D.Metallic"/>.</para>
    /// </summary>
    public Texture2D MetallicTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(1));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(1), value);
        }
    }

    /// <summary>
    /// <para>Specifies the channel of the <see cref="Godot.BaseMaterial3D.MetallicTexture"/> in which the metallic information is stored. This is useful when you store the information for multiple effects in a single texture. For example if you stored metallic in the red channel, roughness in the blue, and ambient occlusion in the green you could reduce the number of textures you use.</para>
    /// </summary>
    public BaseMaterial3D.TextureChannel MetallicTextureChannel
    {
        get
        {
            return GetMetallicTextureChannel();
        }
        set
        {
            SetMetallicTextureChannel(value);
        }
    }

    /// <summary>
    /// <para>Surface reflection. A value of <c>0</c> represents a perfect mirror while a value of <c>1</c> completely blurs the reflection. See also <see cref="Godot.BaseMaterial3D.Metallic"/>.</para>
    /// </summary>
    public float Roughness
    {
        get
        {
            return GetRoughness();
        }
        set
        {
            SetRoughness(value);
        }
    }

    /// <summary>
    /// <para>Texture used to control the roughness per-pixel. Multiplied by <see cref="Godot.BaseMaterial3D.Roughness"/>.</para>
    /// </summary>
    public Texture2D RoughnessTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(2));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(2), value);
        }
    }

    /// <summary>
    /// <para>Specifies the channel of the <see cref="Godot.BaseMaterial3D.RoughnessTexture"/> in which the roughness information is stored. This is useful when you store the information for multiple effects in a single texture. For example if you stored metallic in the red channel, roughness in the blue, and ambient occlusion in the green you could reduce the number of textures you use.</para>
    /// </summary>
    public BaseMaterial3D.TextureChannel RoughnessTextureChannel
    {
        get
        {
            return GetRoughnessTextureChannel();
        }
        set
        {
            SetRoughnessTextureChannel(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the body emits light. Emitting light makes the object appear brighter. The object can also cast light on other objects if a <see cref="Godot.VoxelGI"/>, SDFGI, or <see cref="Godot.LightmapGI"/> is used and this object is used in baked lighting.</para>
    /// </summary>
    public bool EmissionEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(0));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(0), value);
        }
    }

    /// <summary>
    /// <para>The emitted light's color. See <see cref="Godot.BaseMaterial3D.EmissionEnabled"/>.</para>
    /// </summary>
    public Color Emission
    {
        get
        {
            return GetEmission();
        }
        set
        {
            SetEmission(value);
        }
    }

    /// <summary>
    /// <para>Multiplier for emitted light. See <see cref="Godot.BaseMaterial3D.EmissionEnabled"/>.</para>
    /// </summary>
    public float EmissionEnergyMultiplier
    {
        get
        {
            return GetEmissionEnergyMultiplier();
        }
        set
        {
            SetEmissionEnergyMultiplier(value);
        }
    }

    /// <summary>
    /// <para>Luminance of emitted light, measured in nits (candela per square meter). Only available when <c>ProjectSettings.rendering/lights_and_shadows/use_physical_light_units</c> is enabled. The default is roughly equivalent to an indoor lightbulb.</para>
    /// </summary>
    public float EmissionIntensity
    {
        get
        {
            return GetEmissionIntensity();
        }
        set
        {
            SetEmissionIntensity(value);
        }
    }

    /// <summary>
    /// <para>Sets how <see cref="Godot.BaseMaterial3D.Emission"/> interacts with <see cref="Godot.BaseMaterial3D.EmissionTexture"/>. Can either add or multiply. See <see cref="Godot.BaseMaterial3D.EmissionOperatorEnum"/> for options.</para>
    /// </summary>
    public BaseMaterial3D.EmissionOperatorEnum EmissionOperator
    {
        get
        {
            return GetEmissionOperator();
        }
        set
        {
            SetEmissionOperator(value);
        }
    }

    /// <summary>
    /// <para>Use <c>UV2</c> to read from the <see cref="Godot.BaseMaterial3D.EmissionTexture"/>.</para>
    /// </summary>
    public bool EmissionOnUV2
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(11));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(11), value);
        }
    }

    /// <summary>
    /// <para>Texture that specifies how much surface emits light at a given point.</para>
    /// </summary>
    public Texture2D EmissionTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(3));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(3), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, normal mapping is enabled. This has a slight performance cost, especially on mobile GPUs.</para>
    /// </summary>
    public bool NormalEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(1));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(1), value);
        }
    }

    /// <summary>
    /// <para>The strength of the normal map's effect.</para>
    /// </summary>
    public float NormalScale
    {
        get
        {
            return GetNormalScale();
        }
        set
        {
            SetNormalScale(value);
        }
    }

    /// <summary>
    /// <para>Texture used to specify the normal at a given pixel. The <see cref="Godot.BaseMaterial3D.NormalTexture"/> only uses the red and green channels; the blue and alpha channels are ignored. The normal read from <see cref="Godot.BaseMaterial3D.NormalTexture"/> is oriented around the surface normal provided by the <see cref="Godot.Mesh"/>.</para>
    /// <para><b>Note:</b> The mesh must have both normals and tangents defined in its vertex data. Otherwise, the normal map won't render correctly and will only appear to darken the whole surface. If creating geometry with <see cref="Godot.SurfaceTool"/>, you can use <see cref="Godot.SurfaceTool.GenerateNormals(bool)"/> and <see cref="Godot.SurfaceTool.GenerateTangents()"/> to automatically generate normals and tangents respectively.</para>
    /// <para><b>Note:</b> Godot expects the normal map to use X+, Y+, and Z+ coordinates. See <a href="http://wiki.polycount.com/wiki/Normal_Map_Technical_Details#Common_Swizzle_Coordinates">this page</a> for a comparison of normal map coordinates expected by popular engines.</para>
    /// <para><b>Note:</b> If <see cref="Godot.BaseMaterial3D.DetailEnabled"/> is <see langword="true"/>, the <see cref="Godot.BaseMaterial3D.DetailAlbedo"/> texture is drawn <i>below</i> the <see cref="Godot.BaseMaterial3D.NormalTexture"/>. To display a normal map <i>above</i> the <see cref="Godot.BaseMaterial3D.DetailAlbedo"/> texture, use <see cref="Godot.BaseMaterial3D.DetailNormal"/> instead.</para>
    /// </summary>
    public Texture2D NormalTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(4));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(4), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, rim effect is enabled. Rim lighting increases the brightness at glancing angles on an object.</para>
    /// <para><b>Note:</b> Rim lighting is not visible if the material's <see cref="Godot.BaseMaterial3D.ShadingMode"/> is <see cref="Godot.BaseMaterial3D.ShadingModeEnum.Unshaded"/>.</para>
    /// </summary>
    public bool RimEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(2));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(2), value);
        }
    }

    /// <summary>
    /// <para>Sets the strength of the rim lighting effect.</para>
    /// </summary>
    public float Rim
    {
        get
        {
            return GetRim();
        }
        set
        {
            SetRim(value);
        }
    }

    /// <summary>
    /// <para>The amount of to blend light and albedo color when rendering rim effect. If <c>0</c> the light color is used, while <c>1</c> means albedo color is used. An intermediate value generally works best.</para>
    /// </summary>
    public float RimTint
    {
        get
        {
            return GetRimTint();
        }
        set
        {
            SetRimTint(value);
        }
    }

    /// <summary>
    /// <para>Texture used to set the strength of the rim lighting effect per-pixel. Multiplied by <see cref="Godot.BaseMaterial3D.Rim"/>.</para>
    /// </summary>
    public Texture2D RimTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(5));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(5), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, clearcoat rendering is enabled. Adds a secondary transparent pass to the lighting calculation resulting in an added specular blob. This makes materials appear as if they have a clear layer on them that can be either glossy or rough.</para>
    /// <para><b>Note:</b> Clearcoat rendering is not visible if the material's <see cref="Godot.BaseMaterial3D.ShadingMode"/> is <see cref="Godot.BaseMaterial3D.ShadingModeEnum.Unshaded"/>.</para>
    /// </summary>
    public bool ClearcoatEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(3));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(3), value);
        }
    }

    /// <summary>
    /// <para>Sets the strength of the clearcoat effect. Setting to <c>0</c> looks the same as disabling the clearcoat effect.</para>
    /// </summary>
    public float Clearcoat
    {
        get
        {
            return GetClearcoat();
        }
        set
        {
            SetClearcoat(value);
        }
    }

    /// <summary>
    /// <para>Sets the roughness of the clearcoat pass. A higher value results in a rougher clearcoat while a lower value results in a smoother clearcoat.</para>
    /// </summary>
    public float ClearcoatRoughness
    {
        get
        {
            return GetClearcoatRoughness();
        }
        set
        {
            SetClearcoatRoughness(value);
        }
    }

    /// <summary>
    /// <para>Texture that defines the strength of the clearcoat effect and the glossiness of the clearcoat. Strength is specified in the red channel while glossiness is specified in the green channel.</para>
    /// </summary>
    public Texture2D ClearcoatTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(6));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(6), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, anisotropy is enabled. Anisotropy changes the shape of the specular blob and aligns it to tangent space. This is useful for brushed aluminium and hair reflections.</para>
    /// <para><b>Note:</b> Mesh tangents are needed for anisotropy to work. If the mesh does not contain tangents, the anisotropy effect will appear broken.</para>
    /// <para><b>Note:</b> Material anisotropy should not to be confused with anisotropic texture filtering, which can be enabled by setting <see cref="Godot.BaseMaterial3D.TextureFilter"/> to <see cref="Godot.BaseMaterial3D.TextureFilterEnum.LinearWithMipmapsAnisotropic"/>.</para>
    /// </summary>
    public bool AnisotropyEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(4));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(4), value);
        }
    }

    /// <summary>
    /// <para>The strength of the anisotropy effect. This is multiplied by <see cref="Godot.BaseMaterial3D.AnisotropyFlowmap"/>'s alpha channel if a texture is defined there and the texture contains an alpha channel.</para>
    /// </summary>
    public float Anisotropy
    {
        get
        {
            return GetAnisotropy();
        }
        set
        {
            SetAnisotropy(value);
        }
    }

    /// <summary>
    /// <para>Texture that offsets the tangent map for anisotropy calculations and optionally controls the anisotropy effect (if an alpha channel is present). The flowmap texture is expected to be a derivative map, with the red channel representing distortion on the X axis and green channel representing distortion on the Y axis. Values below 0.5 will result in negative distortion, whereas values above 0.5 will result in positive distortion.</para>
    /// <para>If present, the texture's alpha channel will be used to multiply the strength of the <see cref="Godot.BaseMaterial3D.Anisotropy"/> effect. Fully opaque pixels will keep the anisotropy effect's original strength while fully transparent pixels will disable the anisotropy effect entirely. The flowmap texture's blue channel is ignored.</para>
    /// </summary>
    public Texture2D AnisotropyFlowmap
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(7));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(7), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, ambient occlusion is enabled. Ambient occlusion darkens areas based on the <see cref="Godot.BaseMaterial3D.AOTexture"/>.</para>
    /// </summary>
    public bool AOEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(5));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(5), value);
        }
    }

    /// <summary>
    /// <para>Amount that ambient occlusion affects lighting from lights. If <c>0</c>, ambient occlusion only affects ambient light. If <c>1</c>, ambient occlusion affects lights just as much as it affects ambient light. This can be used to impact the strength of the ambient occlusion effect, but typically looks unrealistic.</para>
    /// </summary>
    public float AOLightAffect
    {
        get
        {
            return GetAOLightAffect();
        }
        set
        {
            SetAOLightAffect(value);
        }
    }

    /// <summary>
    /// <para>Texture that defines the amount of ambient occlusion for a given point on the object.</para>
    /// </summary>
    public Texture2D AOTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(8));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(8), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, use <c>UV2</c> coordinates to look up from the <see cref="Godot.BaseMaterial3D.AOTexture"/>.</para>
    /// </summary>
    public bool AOOnUV2
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(10));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(10), value);
        }
    }

    /// <summary>
    /// <para>Specifies the channel of the <see cref="Godot.BaseMaterial3D.AOTexture"/> in which the ambient occlusion information is stored. This is useful when you store the information for multiple effects in a single texture. For example if you stored metallic in the red channel, roughness in the blue, and ambient occlusion in the green you could reduce the number of textures you use.</para>
    /// </summary>
    public BaseMaterial3D.TextureChannel AOTextureChannel
    {
        get
        {
            return GetAOTextureChannel();
        }
        set
        {
            SetAOTextureChannel(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, height mapping is enabled (also called "parallax mapping" or "depth mapping"). See also <see cref="Godot.BaseMaterial3D.NormalEnabled"/>. Height mapping is a demanding feature on the GPU, so it should only be used on materials where it makes a significant visual difference.</para>
    /// <para><b>Note:</b> Height mapping is not supported if triplanar mapping is used on the same material. The value of <see cref="Godot.BaseMaterial3D.HeightmapEnabled"/> will be ignored if <see cref="Godot.BaseMaterial3D.Uv1Triplanar"/> is enabled.</para>
    /// </summary>
    public bool HeightmapEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(6));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(6), value);
        }
    }

    /// <summary>
    /// <para>The heightmap scale to use for the parallax effect (see <see cref="Godot.BaseMaterial3D.HeightmapEnabled"/>). The default value is tuned so that the highest point (value = 255) appears to be 5 cm higher than the lowest point (value = 0). Higher values result in a deeper appearance, but may result in artifacts appearing when looking at the material from oblique angles, especially when the camera moves. Negative values can be used to invert the parallax effect, but this is different from inverting the texture using <see cref="Godot.BaseMaterial3D.HeightmapFlipTexture"/> as the material will also appear to be "closer" to the camera. In most cases, <see cref="Godot.BaseMaterial3D.HeightmapScale"/> should be kept to a positive value.</para>
    /// <para><b>Note:</b> If the height map effect looks strange regardless of this value, try adjusting <see cref="Godot.BaseMaterial3D.HeightmapFlipBinormal"/> and <see cref="Godot.BaseMaterial3D.HeightmapFlipTangent"/>. See also <see cref="Godot.BaseMaterial3D.HeightmapTexture"/> for recommendations on authoring heightmap textures, as the way the heightmap texture is authored affects how <see cref="Godot.BaseMaterial3D.HeightmapScale"/> behaves.</para>
    /// </summary>
    public float HeightmapScale
    {
        get
        {
            return GetHeightmapScale();
        }
        set
        {
            SetHeightmapScale(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, uses parallax occlusion mapping to represent depth in the material instead of simple offset mapping (see <see cref="Godot.BaseMaterial3D.HeightmapEnabled"/>). This results in a more convincing depth effect, but is much more expensive on the GPU. Only enable this on materials where it makes a significant visual difference.</para>
    /// </summary>
    public bool HeightmapDeepParallax
    {
        get
        {
            return IsHeightmapDeepParallaxEnabled();
        }
        set
        {
            SetHeightmapDeepParallax(value);
        }
    }

    /// <summary>
    /// <para>The number of layers to use for parallax occlusion mapping when the camera is far away from the material. Higher values result in a more convincing depth effect, especially in materials that have steep height changes. Higher values have a significant cost on the GPU, so it should only be increased on materials where it makes a significant visual difference.</para>
    /// <para><b>Note:</b> Only effective if <see cref="Godot.BaseMaterial3D.HeightmapDeepParallax"/> is <see langword="true"/>.</para>
    /// </summary>
    public int HeightmapMinLayers
    {
        get
        {
            return GetHeightmapDeepParallaxMinLayers();
        }
        set
        {
            SetHeightmapDeepParallaxMinLayers(value);
        }
    }

    /// <summary>
    /// <para>The number of layers to use for parallax occlusion mapping when the camera is up close to the material. Higher values result in a more convincing depth effect, especially in materials that have steep height changes. Higher values have a significant cost on the GPU, so it should only be increased on materials where it makes a significant visual difference.</para>
    /// <para><b>Note:</b> Only effective if <see cref="Godot.BaseMaterial3D.HeightmapDeepParallax"/> is <see langword="true"/>.</para>
    /// </summary>
    public int HeightmapMaxLayers
    {
        get
        {
            return GetHeightmapDeepParallaxMaxLayers();
        }
        set
        {
            SetHeightmapDeepParallaxMaxLayers(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, flips the mesh's tangent vectors when interpreting the height map. If the heightmap effect looks strange when the camera moves (even with a reasonable <see cref="Godot.BaseMaterial3D.HeightmapScale"/>), try setting this to <see langword="true"/>.</para>
    /// </summary>
    public bool HeightmapFlipTangent
    {
        get
        {
            return GetHeightmapDeepParallaxFlipTangent();
        }
        set
        {
            SetHeightmapDeepParallaxFlipTangent(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, flips the mesh's binormal vectors when interpreting the height map. If the heightmap effect looks strange when the camera moves (even with a reasonable <see cref="Godot.BaseMaterial3D.HeightmapScale"/>), try setting this to <see langword="true"/>.</para>
    /// </summary>
    public bool HeightmapFlipBinormal
    {
        get
        {
            return GetHeightmapDeepParallaxFlipBinormal();
        }
        set
        {
            SetHeightmapDeepParallaxFlipBinormal(value);
        }
    }

    /// <summary>
    /// <para>The texture to use as a height map. See also <see cref="Godot.BaseMaterial3D.HeightmapEnabled"/>.</para>
    /// <para>For best results, the texture should be normalized (with <see cref="Godot.BaseMaterial3D.HeightmapScale"/> reduced to compensate). In <a href="https://gimp.org">GIMP</a>, this can be done using <b>Colors &gt; Auto &gt; Equalize</b>. If the texture only uses a small part of its available range, the parallax effect may look strange, especially when the camera moves.</para>
    /// <para><b>Note:</b> To reduce memory usage and improve loading times, you may be able to use a lower-resolution heightmap texture as most heightmaps are only comprised of low-frequency data.</para>
    /// </summary>
    public Texture2D HeightmapTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(9));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(9), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, interprets the height map texture as a depth map, with brighter values appearing to be "lower" in altitude compared to darker values.</para>
    /// <para>This can be enabled for compatibility with some materials authored for Godot 3.x. This is not necessary if the Invert import option was used to invert the depth map in Godot 3.x, in which case <see cref="Godot.BaseMaterial3D.HeightmapFlipTexture"/> should remain <see langword="false"/>.</para>
    /// </summary>
    public bool HeightmapFlipTexture
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(17));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(17), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, subsurface scattering is enabled. Emulates light that penetrates an object's surface, is scattered, and then emerges. Subsurface scattering quality is controlled by <c>ProjectSettings.rendering/environment/subsurface_scattering/subsurface_scattering_quality</c>.</para>
    /// </summary>
    public bool SubsurfScatterEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(7));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(7), value);
        }
    }

    /// <summary>
    /// <para>The strength of the subsurface scattering effect. The depth of the effect is also controlled by <c>ProjectSettings.rendering/environment/subsurface_scattering/subsurface_scattering_scale</c>, which is set globally.</para>
    /// </summary>
    public float SubsurfScatterStrength
    {
        get
        {
            return GetSubsurfaceScatteringStrength();
        }
        set
        {
            SetSubsurfaceScatteringStrength(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, subsurface scattering will use a special mode optimized for the color and density of human skin, such as boosting the intensity of the red channel in subsurface scattering.</para>
    /// </summary>
    public bool SubsurfScatterSkinMode
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(18));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(18), value);
        }
    }

    /// <summary>
    /// <para>Texture used to control the subsurface scattering strength. Stored in the red texture channel. Multiplied by <see cref="Godot.BaseMaterial3D.SubsurfScatterStrength"/>.</para>
    /// </summary>
    public Texture2D SubsurfScatterTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(10));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(10), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, enables subsurface scattering transmittance. Only effective if <see cref="Godot.BaseMaterial3D.SubsurfScatterEnabled"/> is <see langword="true"/>. See also <see cref="Godot.BaseMaterial3D.BacklightEnabled"/>.</para>
    /// </summary>
    public bool SubsurfScatterTransmittanceEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(8));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(8), value);
        }
    }

    /// <summary>
    /// <para>The color to multiply the subsurface scattering transmittance effect with. Ignored if <see cref="Godot.BaseMaterial3D.SubsurfScatterSkinMode"/> is <see langword="true"/>.</para>
    /// </summary>
    public Color SubsurfScatterTransmittanceColor
    {
        get
        {
            return GetTransmittanceColor();
        }
        set
        {
            SetTransmittanceColor(value);
        }
    }

    /// <summary>
    /// <para>The texture to use for multiplying the intensity of the subsurface scattering transmittance intensity. See also <see cref="Godot.BaseMaterial3D.SubsurfScatterTexture"/>. Ignored if <see cref="Godot.BaseMaterial3D.SubsurfScatterSkinMode"/> is <see langword="true"/>.</para>
    /// </summary>
    public Texture2D SubsurfScatterTransmittanceTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(11));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(11), value);
        }
    }

    /// <summary>
    /// <para>The depth of the subsurface scattering transmittance effect.</para>
    /// </summary>
    public float SubsurfScatterTransmittanceDepth
    {
        get
        {
            return GetTransmittanceDepth();
        }
        set
        {
            SetTransmittanceDepth(value);
        }
    }

    /// <summary>
    /// <para>The intensity of the subsurface scattering transmittance effect.</para>
    /// </summary>
    public float SubsurfScatterTransmittanceBoost
    {
        get
        {
            return GetTransmittanceBoost();
        }
        set
        {
            SetTransmittanceBoost(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the backlight effect is enabled. See also <see cref="Godot.BaseMaterial3D.SubsurfScatterTransmittanceEnabled"/>.</para>
    /// </summary>
    public bool BacklightEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(9));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(9), value);
        }
    }

    /// <summary>
    /// <para>The color used by the backlight effect. Represents the light passing through an object.</para>
    /// </summary>
    public Color Backlight
    {
        get
        {
            return GetBacklight();
        }
        set
        {
            SetBacklight(value);
        }
    }

    /// <summary>
    /// <para>Texture used to control the backlight effect per-pixel. Added to <see cref="Godot.BaseMaterial3D.Backlight"/>.</para>
    /// </summary>
    public Texture2D BacklightTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(12));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(12), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the refraction effect is enabled. Distorts transparency based on light from behind the object.</para>
    /// </summary>
    public bool RefractionEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(10));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(10), value);
        }
    }

    /// <summary>
    /// <para>The strength of the refraction effect.</para>
    /// </summary>
    public float RefractionScale
    {
        get
        {
            return GetRefraction();
        }
        set
        {
            SetRefraction(value);
        }
    }

    /// <summary>
    /// <para>Texture that controls the strength of the refraction per-pixel. Multiplied by <see cref="Godot.BaseMaterial3D.RefractionScale"/>.</para>
    /// </summary>
    public Texture2D RefractionTexture
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(13));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(13), value);
        }
    }

    /// <summary>
    /// <para>Specifies the channel of the <see cref="Godot.BaseMaterial3D.RefractionTexture"/> in which the refraction information is stored. This is useful when you store the information for multiple effects in a single texture. For example if you stored refraction in the red channel, roughness in the blue, and ambient occlusion in the green you could reduce the number of textures you use.</para>
    /// </summary>
    public BaseMaterial3D.TextureChannel RefractionTextureChannel
    {
        get
        {
            return GetRefractionTextureChannel();
        }
        set
        {
            SetRefractionTextureChannel(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, enables the detail overlay. Detail is a second texture that gets mixed over the surface of the object based on <see cref="Godot.BaseMaterial3D.DetailMask"/> and <see cref="Godot.BaseMaterial3D.DetailAlbedo"/>'s alpha channel. This can be used to add variation to objects, or to blend between two different albedo/normal textures.</para>
    /// </summary>
    public bool DetailEnabled
    {
        get
        {
            return GetFeature((BaseMaterial3D.Feature)(11));
        }
        set
        {
            SetFeature((BaseMaterial3D.Feature)(11), value);
        }
    }

    /// <summary>
    /// <para>Texture used to specify how the detail textures get blended with the base textures. <see cref="Godot.BaseMaterial3D.DetailMask"/> can be used together with <see cref="Godot.BaseMaterial3D.DetailAlbedo"/>'s alpha channel (if any).</para>
    /// </summary>
    public Texture2D DetailMask
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(14));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(14), value);
        }
    }

    /// <summary>
    /// <para>Specifies how the <see cref="Godot.BaseMaterial3D.DetailAlbedo"/> should blend with the current <c>ALBEDO</c>. See <see cref="Godot.BaseMaterial3D.BlendModeEnum"/> for options.</para>
    /// </summary>
    public BaseMaterial3D.BlendModeEnum DetailBlendMode
    {
        get
        {
            return GetDetailBlendMode();
        }
        set
        {
            SetDetailBlendMode(value);
        }
    }

    /// <summary>
    /// <para>Specifies whether to use <c>UV</c> or <c>UV2</c> for the detail layer. See <see cref="Godot.BaseMaterial3D.DetailUV"/> for options.</para>
    /// </summary>
    public BaseMaterial3D.DetailUV DetailUVLayer
    {
        get
        {
            return GetDetailUV();
        }
        set
        {
            SetDetailUV(value);
        }
    }

    /// <summary>
    /// <para>Texture that specifies the color of the detail overlay. <see cref="Godot.BaseMaterial3D.DetailAlbedo"/>'s alpha channel is used as a mask, even when the material is opaque. To use a dedicated texture as a mask, see <see cref="Godot.BaseMaterial3D.DetailMask"/>.</para>
    /// <para><b>Note:</b> <see cref="Godot.BaseMaterial3D.DetailAlbedo"/> is <i>not</i> modulated by <see cref="Godot.BaseMaterial3D.AlbedoColor"/>.</para>
    /// </summary>
    public Texture2D DetailAlbedo
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(15));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(15), value);
        }
    }

    /// <summary>
    /// <para>Texture that specifies the per-pixel normal of the detail overlay. The <see cref="Godot.BaseMaterial3D.DetailNormal"/> texture only uses the red and green channels; the blue and alpha channels are ignored. The normal read from <see cref="Godot.BaseMaterial3D.DetailNormal"/> is oriented around the surface normal provided by the <see cref="Godot.Mesh"/>.</para>
    /// <para><b>Note:</b> Godot expects the normal map to use X+, Y+, and Z+ coordinates. See <a href="http://wiki.polycount.com/wiki/Normal_Map_Technical_Details#Common_Swizzle_Coordinates">this page</a> for a comparison of normal map coordinates expected by popular engines.</para>
    /// </summary>
    public Texture2D DetailNormal
    {
        get
        {
            return GetTexture((BaseMaterial3D.TextureParam)(16));
        }
        set
        {
            SetTexture((BaseMaterial3D.TextureParam)(16), value);
        }
    }

    /// <summary>
    /// <para>How much to scale the <c>UV</c> coordinates. This is multiplied by <c>UV</c> in the vertex function. The Z component is used when <see cref="Godot.BaseMaterial3D.Uv1Triplanar"/> is enabled, but it is not used anywhere else.</para>
    /// </summary>
    public Vector3 Uv1Scale
    {
        get
        {
            return GetUv1Scale();
        }
        set
        {
            SetUv1Scale(value);
        }
    }

    /// <summary>
    /// <para>How much to offset the <c>UV</c> coordinates. This amount will be added to <c>UV</c> in the vertex function. This can be used to offset a texture. The Z component is used when <see cref="Godot.BaseMaterial3D.Uv1Triplanar"/> is enabled, but it is not used anywhere else.</para>
    /// </summary>
    public Vector3 Uv1Offset
    {
        get
        {
            return GetUv1Offset();
        }
        set
        {
            SetUv1Offset(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, instead of using <c>UV</c> textures will use a triplanar texture lookup to determine how to apply textures. Triplanar uses the orientation of the object's surface to blend between texture coordinates. It reads from the source texture 3 times, once for each axis and then blends between the results based on how closely the pixel aligns with each axis. This is often used for natural features to get a realistic blend of materials. Because triplanar texturing requires many more texture reads per-pixel it is much slower than normal UV texturing. Additionally, because it is blending the texture between the three axes, it is unsuitable when you are trying to achieve crisp texturing.</para>
    /// </summary>
    public bool Uv1Triplanar
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(6));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(6), value);
        }
    }

    /// <summary>
    /// <para>A lower number blends the texture more softly while a higher number blends the texture more sharply.</para>
    /// <para><b>Note:</b> <see cref="Godot.BaseMaterial3D.Uv1TriplanarSharpness"/> is clamped between <c>0.0</c> and <c>150.0</c> (inclusive) as values outside that range can look broken depending on the mesh.</para>
    /// </summary>
    public float Uv1TriplanarSharpness
    {
        get
        {
            return GetUv1TriplanarBlendSharpness();
        }
        set
        {
            SetUv1TriplanarBlendSharpness(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, triplanar mapping for <c>UV</c> is calculated in world space rather than object local space. See also <see cref="Godot.BaseMaterial3D.Uv1Triplanar"/>.</para>
    /// </summary>
    public bool Uv1WorldTriplanar
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(8));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(8), value);
        }
    }

    /// <summary>
    /// <para>How much to scale the <c>UV2</c> coordinates. This is multiplied by <c>UV2</c> in the vertex function. The Z component is used when <see cref="Godot.BaseMaterial3D.UV2Triplanar"/> is enabled, but it is not used anywhere else.</para>
    /// </summary>
    public Vector3 UV2Scale
    {
        get
        {
            return GetUV2Scale();
        }
        set
        {
            SetUV2Scale(value);
        }
    }

    /// <summary>
    /// <para>How much to offset the <c>UV2</c> coordinates. This amount will be added to <c>UV2</c> in the vertex function. This can be used to offset a texture. The Z component is used when <see cref="Godot.BaseMaterial3D.UV2Triplanar"/> is enabled, but it is not used anywhere else.</para>
    /// </summary>
    public Vector3 UV2Offset
    {
        get
        {
            return GetUV2Offset();
        }
        set
        {
            SetUV2Offset(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, instead of using <c>UV2</c> textures will use a triplanar texture lookup to determine how to apply textures. Triplanar uses the orientation of the object's surface to blend between texture coordinates. It reads from the source texture 3 times, once for each axis and then blends between the results based on how closely the pixel aligns with each axis. This is often used for natural features to get a realistic blend of materials. Because triplanar texturing requires many more texture reads per-pixel it is much slower than normal UV texturing. Additionally, because it is blending the texture between the three axes, it is unsuitable when you are trying to achieve crisp texturing.</para>
    /// </summary>
    public bool UV2Triplanar
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(7));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(7), value);
        }
    }

    /// <summary>
    /// <para>A lower number blends the texture more softly while a higher number blends the texture more sharply.</para>
    /// <para><b>Note:</b> <see cref="Godot.BaseMaterial3D.UV2TriplanarSharpness"/> is clamped between <c>0.0</c> and <c>150.0</c> (inclusive) as values outside that range can look broken depending on the mesh.</para>
    /// </summary>
    public float UV2TriplanarSharpness
    {
        get
        {
            return GetUV2TriplanarBlendSharpness();
        }
        set
        {
            SetUV2TriplanarBlendSharpness(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, triplanar mapping for <c>UV2</c> is calculated in world space rather than object local space. See also <see cref="Godot.BaseMaterial3D.UV2Triplanar"/>.</para>
    /// </summary>
    public bool UV2WorldTriplanar
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(9));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(9), value);
        }
    }

    /// <summary>
    /// <para>Filter flags for the texture. See <see cref="Godot.BaseMaterial3D.TextureFilterEnum"/> for options.</para>
    /// <para><b>Note:</b> <see cref="Godot.BaseMaterial3D.HeightmapTexture"/> is always sampled with linear filtering, even if nearest-neighbor filtering is selected here. This is to ensure the heightmap effect looks as intended. If you need sharper height transitions between pixels, resize the heightmap texture in an image editor with nearest-neighbor filtering.</para>
    /// </summary>
    public BaseMaterial3D.TextureFilterEnum TextureFilter
    {
        get
        {
            return GetTextureFilter();
        }
        set
        {
            SetTextureFilter(value);
        }
    }

    /// <summary>
    /// <para>Repeat flags for the texture. See <see cref="Godot.BaseMaterial3D.TextureFilterEnum"/> for options.</para>
    /// </summary>
    public bool TextureRepeat
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(16));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(16), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the object receives no shadow that would otherwise be cast onto it.</para>
    /// </summary>
    public bool DisableReceiveShadows
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(13));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(13), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, enables the "shadow to opacity" render mode where lighting modifies the alpha so shadowed areas are opaque and non-shadowed areas are transparent. Useful for overlaying shadows onto a camera feed in AR.</para>
    /// </summary>
    public bool ShadowToOpacity
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(15));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(15), value);
        }
    }

    /// <summary>
    /// <para>Controls how the object faces the camera. See <see cref="Godot.BaseMaterial3D.BillboardModeEnum"/>.</para>
    /// <para><b>Note:</b> When billboarding is enabled and the material also casts shadows, billboards will face <b>the</b> camera in the scene when rendering shadows. In scenes with multiple cameras, the intended shadow cannot be determined and this will result in undefined behavior. See <a href="https://github.com/godotengine/godot/pull/72638">GitHub Pull Request #72638</a> for details.</para>
    /// <para><b>Note:</b> Billboard mode is not suitable for VR because the left-right vector of the camera is not horizontal when the screen is attached to your head instead of on the table. See <a href="https://github.com/godotengine/godot/issues/41567">GitHub issue #41567</a> for details.</para>
    /// </summary>
    public BaseMaterial3D.BillboardModeEnum BillboardMode
    {
        get
        {
            return GetBillboardMode();
        }
        set
        {
            SetBillboardMode(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the shader will keep the scale set for the mesh. Otherwise, the scale is lost when billboarding. Only applies when <see cref="Godot.BaseMaterial3D.BillboardMode"/> is not <see cref="Godot.BaseMaterial3D.BillboardModeEnum.Disabled"/>.</para>
    /// </summary>
    public bool BillboardKeepScale
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(5));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(5), value);
        }
    }

    /// <summary>
    /// <para>The number of horizontal frames in the particle sprite sheet. Only enabled when using <see cref="Godot.BaseMaterial3D.BillboardModeEnum.Particles"/>. See <see cref="Godot.BaseMaterial3D.BillboardMode"/>.</para>
    /// </summary>
    public int ParticlesAnimHFrames
    {
        get
        {
            return GetParticlesAnimHFrames();
        }
        set
        {
            SetParticlesAnimHFrames(value);
        }
    }

    /// <summary>
    /// <para>The number of vertical frames in the particle sprite sheet. Only enabled when using <see cref="Godot.BaseMaterial3D.BillboardModeEnum.Particles"/>. See <see cref="Godot.BaseMaterial3D.BillboardMode"/>.</para>
    /// </summary>
    public int ParticlesAnimVFrames
    {
        get
        {
            return GetParticlesAnimVFrames();
        }
        set
        {
            SetParticlesAnimVFrames(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, particle animations are looped. Only enabled when using <see cref="Godot.BaseMaterial3D.BillboardModeEnum.Particles"/>. See <see cref="Godot.BaseMaterial3D.BillboardMode"/>.</para>
    /// </summary>
    public bool ParticlesAnimLoop
    {
        get
        {
            return GetParticlesAnimLoop();
        }
        set
        {
            SetParticlesAnimLoop(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, enables the vertex grow setting. This can be used to create mesh-based outlines using a second material pass and its <see cref="Godot.BaseMaterial3D.CullMode"/> set to <see cref="Godot.BaseMaterial3D.CullModeEnum.Front"/>. See also <see cref="Godot.BaseMaterial3D.GrowAmount"/>.</para>
    /// <para><b>Note:</b> Vertex growth cannot create new vertices, which means that visible gaps may occur in sharp corners. This can be alleviated by designing the mesh to use smooth normals exclusively using <a href="https://wiki.polycount.com/wiki/Face_weighted_normals">face weighted normals</a> in the 3D authoring software. In this case, grow will be able to join every outline together, just like in the original mesh.</para>
    /// </summary>
    public bool Grow
    {
        get
        {
            return IsGrowEnabled();
        }
        set
        {
            SetGrowEnabled(value);
        }
    }

    /// <summary>
    /// <para>Grows object vertices in the direction of their normals. Only effective if <see cref="Godot.BaseMaterial3D.Grow"/> is <see langword="true"/>.</para>
    /// </summary>
    public float GrowAmount
    {
        get
        {
            return GetGrow();
        }
        set
        {
            SetGrow(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the object is rendered at the same size regardless of distance.</para>
    /// </summary>
    public bool FixedSize
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(4));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(4), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, render point size can be changed.</para>
    /// <para><b>Note:</b> This is only effective for objects whose geometry is point-based rather than triangle-based. See also <see cref="Godot.BaseMaterial3D.PointSize"/>.</para>
    /// </summary>
    public bool UsePointSize
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(3));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(3), value);
        }
    }

    /// <summary>
    /// <para>The point size in pixels. See <see cref="Godot.BaseMaterial3D.UsePointSize"/>.</para>
    /// </summary>
    public float PointSize
    {
        get
        {
            return GetPointSize();
        }
        set
        {
            SetPointSize(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, enables parts of the shader required for <see cref="Godot.GpuParticles3D"/> trails to function. This also requires using a mesh with appropriate skinning, such as <see cref="Godot.RibbonTrailMesh"/> or <see cref="Godot.TubeTrailMesh"/>. Enabling this feature outside of materials used in <see cref="Godot.GpuParticles3D"/> meshes will break material rendering.</para>
    /// </summary>
    public bool UseParticleTrails
    {
        get
        {
            return GetFlag((BaseMaterial3D.Flags)(19));
        }
        set
        {
            SetFlag((BaseMaterial3D.Flags)(19), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the proximity fade effect is enabled. The proximity fade effect fades out each pixel based on its distance to another object.</para>
    /// </summary>
    public bool ProximityFadeEnabled
    {
        get
        {
            return IsProximityFadeEnabled();
        }
        set
        {
            SetProximityFadeEnabled(value);
        }
    }

    /// <summary>
    /// <para>Distance over which the fade effect takes place. The larger the distance the longer it takes for an object to fade.</para>
    /// </summary>
    public float ProximityFadeDistance
    {
        get
        {
            return GetProximityFadeDistance();
        }
        set
        {
            SetProximityFadeDistance(value);
        }
    }

    /// <summary>
    /// <para>The width of the range around the shape between the minimum and maximum representable signed distance.</para>
    /// </summary>
    public float MsdfPixelRange
    {
        get
        {
            return GetMsdfPixelRange();
        }
        set
        {
            SetMsdfPixelRange(value);
        }
    }

    /// <summary>
    /// <para>The width of the shape outline.</para>
    /// </summary>
    public float MsdfOutlineSize
    {
        get
        {
            return GetMsdfOutlineSize();
        }
        set
        {
            SetMsdfOutlineSize(value);
        }
    }

    /// <summary>
    /// <para>Specifies which type of fade to use. Can be any of the <see cref="Godot.BaseMaterial3D.DistanceFadeModeEnum"/>s.</para>
    /// </summary>
    public BaseMaterial3D.DistanceFadeModeEnum DistanceFadeMode
    {
        get
        {
            return GetDistanceFade();
        }
        set
        {
            SetDistanceFade(value);
        }
    }

    /// <summary>
    /// <para>Distance at which the object starts to become visible. If the object is less than this distance away, it will be invisible.</para>
    /// <para><b>Note:</b> If <see cref="Godot.BaseMaterial3D.DistanceFadeMinDistance"/> is greater than <see cref="Godot.BaseMaterial3D.DistanceFadeMaxDistance"/>, the behavior will be reversed. The object will start to fade away at <see cref="Godot.BaseMaterial3D.DistanceFadeMaxDistance"/> and will fully disappear once it reaches <see cref="Godot.BaseMaterial3D.DistanceFadeMinDistance"/>.</para>
    /// </summary>
    public float DistanceFadeMinDistance
    {
        get
        {
            return GetDistanceFadeMinDistance();
        }
        set
        {
            SetDistanceFadeMinDistance(value);
        }
    }

    /// <summary>
    /// <para>Distance at which the object appears fully opaque.</para>
    /// <para><b>Note:</b> If <see cref="Godot.BaseMaterial3D.DistanceFadeMaxDistance"/> is less than <see cref="Godot.BaseMaterial3D.DistanceFadeMinDistance"/>, the behavior will be reversed. The object will start to fade away at <see cref="Godot.BaseMaterial3D.DistanceFadeMaxDistance"/> and will fully disappear once it reaches <see cref="Godot.BaseMaterial3D.DistanceFadeMinDistance"/>.</para>
    /// </summary>
    public float DistanceFadeMaxDistance
    {
        get
        {
            return GetDistanceFadeMaxDistance();
        }
        set
        {
            SetDistanceFadeMaxDistance(value);
        }
    }

    private static readonly System.Type CachedType = typeof(BaseMaterial3D);

    private static readonly StringName NativeName = "BaseMaterial3D";

    internal BaseMaterial3D() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: true);
        }
    }

    internal BaseMaterial3D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAlbedo, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetAlbedo(Color albedo)
    {
        NativeCalls.godot_icall_1_195(MethodBind0, GodotObject.GetPtr(this), &albedo);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAlbedo, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetAlbedo()
    {
        return NativeCalls.godot_icall_0_196(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTransparency, 3435651667ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTransparency(BaseMaterial3D.TransparencyEnum transparency)
    {
        NativeCalls.godot_icall_1_36(MethodBind2, GodotObject.GetPtr(this), (int)transparency);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTransparency, 990903061ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.TransparencyEnum GetTransparency()
    {
        return (BaseMaterial3D.TransparencyEnum)NativeCalls.godot_icall_0_37(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAlphaAntialiasing, 3212649852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAlphaAntialiasing(BaseMaterial3D.AlphaAntiAliasing alphaAA)
    {
        NativeCalls.godot_icall_1_36(MethodBind4, GodotObject.GetPtr(this), (int)alphaAA);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAlphaAntialiasing, 2889939400ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.AlphaAntiAliasing GetAlphaAntialiasing()
    {
        return (BaseMaterial3D.AlphaAntiAliasing)NativeCalls.godot_icall_0_37(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAlphaAntialiasingEdge, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAlphaAntialiasingEdge(float edge)
    {
        NativeCalls.godot_icall_1_62(MethodBind6, GodotObject.GetPtr(this), edge);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAlphaAntialiasingEdge, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetAlphaAntialiasingEdge()
    {
        return NativeCalls.godot_icall_0_63(MethodBind7, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetShadingMode, 3368750322ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetShadingMode(BaseMaterial3D.ShadingModeEnum shadingMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind8, GodotObject.GetPtr(this), (int)shadingMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetShadingMode, 2132070559ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.ShadingModeEnum GetShadingMode()
    {
        return (BaseMaterial3D.ShadingModeEnum)NativeCalls.godot_icall_0_37(MethodBind9, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSpecular, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSpecular(float specular)
    {
        NativeCalls.godot_icall_1_62(MethodBind10, GodotObject.GetPtr(this), specular);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSpecular, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetSpecular()
    {
        return NativeCalls.godot_icall_0_63(MethodBind11, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMetallic, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMetallic(float metallic)
    {
        NativeCalls.godot_icall_1_62(MethodBind12, GodotObject.GetPtr(this), metallic);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMetallic, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetMetallic()
    {
        return NativeCalls.godot_icall_0_63(MethodBind13, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRoughness, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRoughness(float roughness)
    {
        NativeCalls.godot_icall_1_62(MethodBind14, GodotObject.GetPtr(this), roughness);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRoughness, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetRoughness()
    {
        return NativeCalls.godot_icall_0_63(MethodBind15, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmission, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetEmission(Color emission)
    {
        NativeCalls.godot_icall_1_195(MethodBind16, GodotObject.GetPtr(this), &emission);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmission, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetEmission()
    {
        return NativeCalls.godot_icall_0_196(MethodBind17, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionEnergyMultiplier, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmissionEnergyMultiplier(float emissionEnergyMultiplier)
    {
        NativeCalls.godot_icall_1_62(MethodBind18, GodotObject.GetPtr(this), emissionEnergyMultiplier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionEnergyMultiplier, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetEmissionEnergyMultiplier()
    {
        return NativeCalls.godot_icall_0_63(MethodBind19, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionIntensity, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmissionIntensity(float emissionEnergyMultiplier)
    {
        NativeCalls.godot_icall_1_62(MethodBind20, GodotObject.GetPtr(this), emissionEnergyMultiplier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionIntensity, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetEmissionIntensity()
    {
        return NativeCalls.godot_icall_0_63(MethodBind21, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNormalScale, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNormalScale(float normalScale)
    {
        NativeCalls.godot_icall_1_62(MethodBind22, GodotObject.GetPtr(this), normalScale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNormalScale, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetNormalScale()
    {
        return NativeCalls.godot_icall_0_63(MethodBind23, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRim, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRim(float rim)
    {
        NativeCalls.godot_icall_1_62(MethodBind24, GodotObject.GetPtr(this), rim);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRim, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetRim()
    {
        return NativeCalls.godot_icall_0_63(MethodBind25, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRimTint, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRimTint(float rimTint)
    {
        NativeCalls.godot_icall_1_62(MethodBind26, GodotObject.GetPtr(this), rimTint);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRimTint, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetRimTint()
    {
        return NativeCalls.godot_icall_0_63(MethodBind27, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetClearcoat, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetClearcoat(float clearcoat)
    {
        NativeCalls.godot_icall_1_62(MethodBind28, GodotObject.GetPtr(this), clearcoat);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetClearcoat, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetClearcoat()
    {
        return NativeCalls.godot_icall_0_63(MethodBind29, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind30 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetClearcoatRoughness, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetClearcoatRoughness(float clearcoatRoughness)
    {
        NativeCalls.godot_icall_1_62(MethodBind30, GodotObject.GetPtr(this), clearcoatRoughness);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind31 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetClearcoatRoughness, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetClearcoatRoughness()
    {
        return NativeCalls.godot_icall_0_63(MethodBind31, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind32 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAnisotropy, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAnisotropy(float anisotropy)
    {
        NativeCalls.godot_icall_1_62(MethodBind32, GodotObject.GetPtr(this), anisotropy);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind33 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAnisotropy, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetAnisotropy()
    {
        return NativeCalls.godot_icall_0_63(MethodBind33, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind34 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHeightmapScale, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHeightmapScale(float heightmapScale)
    {
        NativeCalls.godot_icall_1_62(MethodBind34, GodotObject.GetPtr(this), heightmapScale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind35 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHeightmapScale, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetHeightmapScale()
    {
        return NativeCalls.godot_icall_0_63(MethodBind35, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind36 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSubsurfaceScatteringStrength, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSubsurfaceScatteringStrength(float strength)
    {
        NativeCalls.godot_icall_1_62(MethodBind36, GodotObject.GetPtr(this), strength);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind37 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSubsurfaceScatteringStrength, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetSubsurfaceScatteringStrength()
    {
        return NativeCalls.godot_icall_0_63(MethodBind37, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind38 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTransmittanceColor, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetTransmittanceColor(Color color)
    {
        NativeCalls.godot_icall_1_195(MethodBind38, GodotObject.GetPtr(this), &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind39 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTransmittanceColor, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetTransmittanceColor()
    {
        return NativeCalls.godot_icall_0_196(MethodBind39, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind40 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTransmittanceDepth, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTransmittanceDepth(float depth)
    {
        NativeCalls.godot_icall_1_62(MethodBind40, GodotObject.GetPtr(this), depth);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind41 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTransmittanceDepth, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetTransmittanceDepth()
    {
        return NativeCalls.godot_icall_0_63(MethodBind41, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind42 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTransmittanceBoost, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTransmittanceBoost(float boost)
    {
        NativeCalls.godot_icall_1_62(MethodBind42, GodotObject.GetPtr(this), boost);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind43 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTransmittanceBoost, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetTransmittanceBoost()
    {
        return NativeCalls.godot_icall_0_63(MethodBind43, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind44 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBacklight, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetBacklight(Color backlight)
    {
        NativeCalls.godot_icall_1_195(MethodBind44, GodotObject.GetPtr(this), &backlight);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind45 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBacklight, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetBacklight()
    {
        return NativeCalls.godot_icall_0_196(MethodBind45, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind46 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRefraction, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRefraction(float refraction)
    {
        NativeCalls.godot_icall_1_62(MethodBind46, GodotObject.GetPtr(this), refraction);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind47 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRefraction, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetRefraction()
    {
        return NativeCalls.godot_icall_0_63(MethodBind47, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind48 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPointSize, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPointSize(float pointSize)
    {
        NativeCalls.godot_icall_1_62(MethodBind48, GodotObject.GetPtr(this), pointSize);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind49 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPointSize, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetPointSize()
    {
        return NativeCalls.godot_icall_0_63(MethodBind49, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind50 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDetailUV, 456801921ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDetailUV(BaseMaterial3D.DetailUV detailUV)
    {
        NativeCalls.godot_icall_1_36(MethodBind50, GodotObject.GetPtr(this), (int)detailUV);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind51 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDetailUV, 2306920512ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.DetailUV GetDetailUV()
    {
        return (BaseMaterial3D.DetailUV)NativeCalls.godot_icall_0_37(MethodBind51, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind52 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBlendMode, 2830186259ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBlendMode(BaseMaterial3D.BlendModeEnum blendMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind52, GodotObject.GetPtr(this), (int)blendMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind53 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBlendMode, 4022690962ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.BlendModeEnum GetBlendMode()
    {
        return (BaseMaterial3D.BlendModeEnum)NativeCalls.godot_icall_0_37(MethodBind53, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind54 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDepthDrawMode, 1456584748ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDepthDrawMode(BaseMaterial3D.DepthDrawModeEnum depthDrawMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind54, GodotObject.GetPtr(this), (int)depthDrawMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind55 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDepthDrawMode, 2578197639ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.DepthDrawModeEnum GetDepthDrawMode()
    {
        return (BaseMaterial3D.DepthDrawModeEnum)NativeCalls.godot_icall_0_37(MethodBind55, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind56 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCullMode, 2338909218ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCullMode(BaseMaterial3D.CullModeEnum cullMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind56, GodotObject.GetPtr(this), (int)cullMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind57 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCullMode, 1941499586ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.CullModeEnum GetCullMode()
    {
        return (BaseMaterial3D.CullModeEnum)NativeCalls.godot_icall_0_37(MethodBind57, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind58 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDiffuseMode, 1045299638ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDiffuseMode(BaseMaterial3D.DiffuseModeEnum diffuseMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind58, GodotObject.GetPtr(this), (int)diffuseMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind59 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDiffuseMode, 3973617136ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.DiffuseModeEnum GetDiffuseMode()
    {
        return (BaseMaterial3D.DiffuseModeEnum)NativeCalls.godot_icall_0_37(MethodBind59, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind60 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSpecularMode, 584737147ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSpecularMode(BaseMaterial3D.SpecularModeEnum specularMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind60, GodotObject.GetPtr(this), (int)specularMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind61 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSpecularMode, 2569953298ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.SpecularModeEnum GetSpecularMode()
    {
        return (BaseMaterial3D.SpecularModeEnum)NativeCalls.godot_icall_0_37(MethodBind61, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind62 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFlag, 3070159527ul);

    /// <summary>
    /// <para>If <see langword="true"/>, enables the specified flag. Flags are optional behavior that can be turned on and off. Only one flag can be enabled at a time with this function, the flag enumerators cannot be bit-masked together to enable or disable multiple flags at once. Flags can also be enabled by setting the corresponding member to <see langword="true"/>. See <see cref="Godot.BaseMaterial3D.Flags"/> enumerator for options.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFlag(BaseMaterial3D.Flags flag, bool enable)
    {
        NativeCalls.godot_icall_2_74(MethodBind62, GodotObject.GetPtr(this), (int)flag, enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind63 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFlag, 1286410065ul);

    /// <summary>
    /// <para>Returns <see langword="true"/>, if the specified flag is enabled. See <see cref="Godot.BaseMaterial3D.Flags"/> enumerator for options.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetFlag(BaseMaterial3D.Flags flag)
    {
        return NativeCalls.godot_icall_1_75(MethodBind63, GodotObject.GetPtr(this), (int)flag).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind64 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTextureFilter, 22904437ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTextureFilter(BaseMaterial3D.TextureFilterEnum mode)
    {
        NativeCalls.godot_icall_1_36(MethodBind64, GodotObject.GetPtr(this), (int)mode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind65 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTextureFilter, 3289213076ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.TextureFilterEnum GetTextureFilter()
    {
        return (BaseMaterial3D.TextureFilterEnum)NativeCalls.godot_icall_0_37(MethodBind65, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind66 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFeature, 2819288693ul);

    /// <summary>
    /// <para>If <see langword="true"/>, enables the specified <see cref="Godot.BaseMaterial3D.Feature"/>. Many features that are available in <see cref="Godot.BaseMaterial3D"/>s need to be enabled before use. This way the cost for using the feature is only incurred when specified. Features can also be enabled by setting the corresponding member to <see langword="true"/>.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFeature(BaseMaterial3D.Feature feature, bool enable)
    {
        NativeCalls.godot_icall_2_74(MethodBind66, GodotObject.GetPtr(this), (int)feature, enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind67 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFeature, 1965241794ul);

    /// <summary>
    /// <para>Returns <see langword="true"/>, if the specified <see cref="Godot.BaseMaterial3D.Feature"/> is enabled.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetFeature(BaseMaterial3D.Feature feature)
    {
        return NativeCalls.godot_icall_1_75(MethodBind67, GodotObject.GetPtr(this), (int)feature).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind68 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTexture, 464208135ul);

    /// <summary>
    /// <para>Sets the texture for the slot specified by <paramref name="param"/>. See <see cref="Godot.BaseMaterial3D.TextureParam"/> for available slots.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTexture(BaseMaterial3D.TextureParam param, Texture2D texture)
    {
        NativeCalls.godot_icall_2_65(MethodBind68, GodotObject.GetPtr(this), (int)param, GodotObject.GetPtr(texture));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind69 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTexture, 329605813ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.Texture2D"/> associated with the specified <see cref="Godot.BaseMaterial3D.TextureParam"/>.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Texture2D GetTexture(BaseMaterial3D.TextureParam param)
    {
        return (Texture2D)NativeCalls.godot_icall_1_66(MethodBind69, GodotObject.GetPtr(this), (int)param);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind70 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDetailBlendMode, 2830186259ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDetailBlendMode(BaseMaterial3D.BlendModeEnum detailBlendMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind70, GodotObject.GetPtr(this), (int)detailBlendMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind71 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDetailBlendMode, 4022690962ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.BlendModeEnum GetDetailBlendMode()
    {
        return (BaseMaterial3D.BlendModeEnum)NativeCalls.godot_icall_0_37(MethodBind71, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind72 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUv1Scale, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetUv1Scale(Vector3 scale)
    {
        NativeCalls.godot_icall_1_163(MethodBind72, GodotObject.GetPtr(this), &scale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind73 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUv1Scale, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetUv1Scale()
    {
        return NativeCalls.godot_icall_0_118(MethodBind73, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind74 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUv1Offset, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetUv1Offset(Vector3 offset)
    {
        NativeCalls.godot_icall_1_163(MethodBind74, GodotObject.GetPtr(this), &offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind75 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUv1Offset, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetUv1Offset()
    {
        return NativeCalls.godot_icall_0_118(MethodBind75, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind76 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUv1TriplanarBlendSharpness, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetUv1TriplanarBlendSharpness(float sharpness)
    {
        NativeCalls.godot_icall_1_62(MethodBind76, GodotObject.GetPtr(this), sharpness);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind77 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUv1TriplanarBlendSharpness, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetUv1TriplanarBlendSharpness()
    {
        return NativeCalls.godot_icall_0_63(MethodBind77, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind78 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUV2Scale, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetUV2Scale(Vector3 scale)
    {
        NativeCalls.godot_icall_1_163(MethodBind78, GodotObject.GetPtr(this), &scale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind79 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUV2Scale, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetUV2Scale()
    {
        return NativeCalls.godot_icall_0_118(MethodBind79, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind80 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUV2Offset, 3460891852ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetUV2Offset(Vector3 offset)
    {
        NativeCalls.godot_icall_1_163(MethodBind80, GodotObject.GetPtr(this), &offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind81 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUV2Offset, 3360562783ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector3 GetUV2Offset()
    {
        return NativeCalls.godot_icall_0_118(MethodBind81, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind82 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUV2TriplanarBlendSharpness, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetUV2TriplanarBlendSharpness(float sharpness)
    {
        NativeCalls.godot_icall_1_62(MethodBind82, GodotObject.GetPtr(this), sharpness);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind83 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUV2TriplanarBlendSharpness, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetUV2TriplanarBlendSharpness()
    {
        return NativeCalls.godot_icall_0_63(MethodBind83, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind84 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBillboardMode, 4202036497ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBillboardMode(BaseMaterial3D.BillboardModeEnum mode)
    {
        NativeCalls.godot_icall_1_36(MethodBind84, GodotObject.GetPtr(this), (int)mode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind85 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBillboardMode, 1283840139ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.BillboardModeEnum GetBillboardMode()
    {
        return (BaseMaterial3D.BillboardModeEnum)NativeCalls.godot_icall_0_37(MethodBind85, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind86 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetParticlesAnimHFrames, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetParticlesAnimHFrames(int frames)
    {
        NativeCalls.godot_icall_1_36(MethodBind86, GodotObject.GetPtr(this), frames);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind87 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetParticlesAnimHFrames, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetParticlesAnimHFrames()
    {
        return NativeCalls.godot_icall_0_37(MethodBind87, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind88 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetParticlesAnimVFrames, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetParticlesAnimVFrames(int frames)
    {
        NativeCalls.godot_icall_1_36(MethodBind88, GodotObject.GetPtr(this), frames);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind89 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetParticlesAnimVFrames, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetParticlesAnimVFrames()
    {
        return NativeCalls.godot_icall_0_37(MethodBind89, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind90 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetParticlesAnimLoop, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetParticlesAnimLoop(bool loop)
    {
        NativeCalls.godot_icall_1_41(MethodBind90, GodotObject.GetPtr(this), loop.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind91 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetParticlesAnimLoop, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetParticlesAnimLoop()
    {
        return NativeCalls.godot_icall_0_40(MethodBind91, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind92 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHeightmapDeepParallax, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHeightmapDeepParallax(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind92, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind93 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsHeightmapDeepParallaxEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsHeightmapDeepParallaxEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind93, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind94 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHeightmapDeepParallaxMinLayers, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHeightmapDeepParallaxMinLayers(int layer)
    {
        NativeCalls.godot_icall_1_36(MethodBind94, GodotObject.GetPtr(this), layer);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind95 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHeightmapDeepParallaxMinLayers, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetHeightmapDeepParallaxMinLayers()
    {
        return NativeCalls.godot_icall_0_37(MethodBind95, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind96 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHeightmapDeepParallaxMaxLayers, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHeightmapDeepParallaxMaxLayers(int layer)
    {
        NativeCalls.godot_icall_1_36(MethodBind96, GodotObject.GetPtr(this), layer);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind97 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHeightmapDeepParallaxMaxLayers, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetHeightmapDeepParallaxMaxLayers()
    {
        return NativeCalls.godot_icall_0_37(MethodBind97, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind98 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHeightmapDeepParallaxFlipTangent, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHeightmapDeepParallaxFlipTangent(bool flip)
    {
        NativeCalls.godot_icall_1_41(MethodBind98, GodotObject.GetPtr(this), flip.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind99 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHeightmapDeepParallaxFlipTangent, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetHeightmapDeepParallaxFlipTangent()
    {
        return NativeCalls.godot_icall_0_40(MethodBind99, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind100 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHeightmapDeepParallaxFlipBinormal, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetHeightmapDeepParallaxFlipBinormal(bool flip)
    {
        NativeCalls.godot_icall_1_41(MethodBind100, GodotObject.GetPtr(this), flip.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind101 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHeightmapDeepParallaxFlipBinormal, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetHeightmapDeepParallaxFlipBinormal()
    {
        return NativeCalls.godot_icall_0_40(MethodBind101, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind102 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGrow, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetGrow(float amount)
    {
        NativeCalls.godot_icall_1_62(MethodBind102, GodotObject.GetPtr(this), amount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind103 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGrow, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetGrow()
    {
        return NativeCalls.godot_icall_0_63(MethodBind103, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind104 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionOperator, 3825128922ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmissionOperator(BaseMaterial3D.EmissionOperatorEnum @operator)
    {
        NativeCalls.godot_icall_1_36(MethodBind104, GodotObject.GetPtr(this), (int)@operator);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind105 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionOperator, 974205018ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.EmissionOperatorEnum GetEmissionOperator()
    {
        return (BaseMaterial3D.EmissionOperatorEnum)NativeCalls.godot_icall_0_37(MethodBind105, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind106 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAOLightAffect, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAOLightAffect(float amount)
    {
        NativeCalls.godot_icall_1_62(MethodBind106, GodotObject.GetPtr(this), amount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind107 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAOLightAffect, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetAOLightAffect()
    {
        return NativeCalls.godot_icall_0_63(MethodBind107, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind108 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAlphaScissorThreshold, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAlphaScissorThreshold(float threshold)
    {
        NativeCalls.godot_icall_1_62(MethodBind108, GodotObject.GetPtr(this), threshold);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind109 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAlphaScissorThreshold, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetAlphaScissorThreshold()
    {
        return NativeCalls.godot_icall_0_63(MethodBind109, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind110 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAlphaHashScale, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAlphaHashScale(float threshold)
    {
        NativeCalls.godot_icall_1_62(MethodBind110, GodotObject.GetPtr(this), threshold);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind111 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAlphaHashScale, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetAlphaHashScale()
    {
        return NativeCalls.godot_icall_0_63(MethodBind111, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind112 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGrowEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetGrowEnabled(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind112, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind113 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsGrowEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsGrowEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind113, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind114 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMetallicTextureChannel, 744167988ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMetallicTextureChannel(BaseMaterial3D.TextureChannel channel)
    {
        NativeCalls.godot_icall_1_36(MethodBind114, GodotObject.GetPtr(this), (int)channel);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind115 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMetallicTextureChannel, 568133867ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.TextureChannel GetMetallicTextureChannel()
    {
        return (BaseMaterial3D.TextureChannel)NativeCalls.godot_icall_0_37(MethodBind115, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind116 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRoughnessTextureChannel, 744167988ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRoughnessTextureChannel(BaseMaterial3D.TextureChannel channel)
    {
        NativeCalls.godot_icall_1_36(MethodBind116, GodotObject.GetPtr(this), (int)channel);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind117 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRoughnessTextureChannel, 568133867ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.TextureChannel GetRoughnessTextureChannel()
    {
        return (BaseMaterial3D.TextureChannel)NativeCalls.godot_icall_0_37(MethodBind117, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind118 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAOTextureChannel, 744167988ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAOTextureChannel(BaseMaterial3D.TextureChannel channel)
    {
        NativeCalls.godot_icall_1_36(MethodBind118, GodotObject.GetPtr(this), (int)channel);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind119 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAOTextureChannel, 568133867ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.TextureChannel GetAOTextureChannel()
    {
        return (BaseMaterial3D.TextureChannel)NativeCalls.godot_icall_0_37(MethodBind119, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind120 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRefractionTextureChannel, 744167988ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRefractionTextureChannel(BaseMaterial3D.TextureChannel channel)
    {
        NativeCalls.godot_icall_1_36(MethodBind120, GodotObject.GetPtr(this), (int)channel);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind121 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRefractionTextureChannel, 568133867ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.TextureChannel GetRefractionTextureChannel()
    {
        return (BaseMaterial3D.TextureChannel)NativeCalls.godot_icall_0_37(MethodBind121, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind122 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetProximityFadeEnabled, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetProximityFadeEnabled(bool enabled)
    {
        NativeCalls.godot_icall_1_41(MethodBind122, GodotObject.GetPtr(this), enabled.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind123 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsProximityFadeEnabled, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsProximityFadeEnabled()
    {
        return NativeCalls.godot_icall_0_40(MethodBind123, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind124 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetProximityFadeDistance, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetProximityFadeDistance(float distance)
    {
        NativeCalls.godot_icall_1_62(MethodBind124, GodotObject.GetPtr(this), distance);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind125 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetProximityFadeDistance, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetProximityFadeDistance()
    {
        return NativeCalls.godot_icall_0_63(MethodBind125, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind126 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMsdfPixelRange, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMsdfPixelRange(float range)
    {
        NativeCalls.godot_icall_1_62(MethodBind126, GodotObject.GetPtr(this), range);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind127 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMsdfPixelRange, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetMsdfPixelRange()
    {
        return NativeCalls.godot_icall_0_63(MethodBind127, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind128 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMsdfOutlineSize, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMsdfOutlineSize(float size)
    {
        NativeCalls.godot_icall_1_62(MethodBind128, GodotObject.GetPtr(this), size);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind129 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMsdfOutlineSize, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetMsdfOutlineSize()
    {
        return NativeCalls.godot_icall_0_63(MethodBind129, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind130 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDistanceFade, 1379478617ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDistanceFade(BaseMaterial3D.DistanceFadeModeEnum mode)
    {
        NativeCalls.godot_icall_1_36(MethodBind130, GodotObject.GetPtr(this), (int)mode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind131 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDistanceFade, 2694575734ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public BaseMaterial3D.DistanceFadeModeEnum GetDistanceFade()
    {
        return (BaseMaterial3D.DistanceFadeModeEnum)NativeCalls.godot_icall_0_37(MethodBind131, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind132 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDistanceFadeMaxDistance, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDistanceFadeMaxDistance(float distance)
    {
        NativeCalls.godot_icall_1_62(MethodBind132, GodotObject.GetPtr(this), distance);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind133 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDistanceFadeMaxDistance, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetDistanceFadeMaxDistance()
    {
        return NativeCalls.godot_icall_0_63(MethodBind133, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind134 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDistanceFadeMinDistance, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDistanceFadeMinDistance(float distance)
    {
        NativeCalls.godot_icall_1_62(MethodBind134, GodotObject.GetPtr(this), distance);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind135 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDistanceFadeMinDistance, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetDistanceFadeMinDistance()
    {
        return NativeCalls.godot_icall_0_63(MethodBind135, GodotObject.GetPtr(this));
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
    public new class PropertyName : Material.PropertyName
    {
        /// <summary>
        /// Cached name for the 'transparency' property.
        /// </summary>
        public static readonly StringName Transparency = "transparency";
        /// <summary>
        /// Cached name for the 'alpha_scissor_threshold' property.
        /// </summary>
        public static readonly StringName AlphaScissorThreshold = "alpha_scissor_threshold";
        /// <summary>
        /// Cached name for the 'alpha_hash_scale' property.
        /// </summary>
        public static readonly StringName AlphaHashScale = "alpha_hash_scale";
        /// <summary>
        /// Cached name for the 'alpha_antialiasing_mode' property.
        /// </summary>
        public static readonly StringName AlphaAntialiasingMode = "alpha_antialiasing_mode";
        /// <summary>
        /// Cached name for the 'alpha_antialiasing_edge' property.
        /// </summary>
        public static readonly StringName AlphaAntialiasingEdge = "alpha_antialiasing_edge";
        /// <summary>
        /// Cached name for the 'blend_mode' property.
        /// </summary>
        public static readonly StringName BlendMode = "blend_mode";
        /// <summary>
        /// Cached name for the 'cull_mode' property.
        /// </summary>
        public static readonly StringName CullMode = "cull_mode";
        /// <summary>
        /// Cached name for the 'depth_draw_mode' property.
        /// </summary>
        public static readonly StringName DepthDrawMode = "depth_draw_mode";
        /// <summary>
        /// Cached name for the 'no_depth_test' property.
        /// </summary>
        public static readonly StringName NoDepthTest = "no_depth_test";
        /// <summary>
        /// Cached name for the 'shading_mode' property.
        /// </summary>
        public static readonly StringName ShadingMode = "shading_mode";
        /// <summary>
        /// Cached name for the 'diffuse_mode' property.
        /// </summary>
        public static readonly StringName DiffuseMode = "diffuse_mode";
        /// <summary>
        /// Cached name for the 'specular_mode' property.
        /// </summary>
        public static readonly StringName SpecularMode = "specular_mode";
        /// <summary>
        /// Cached name for the 'disable_ambient_light' property.
        /// </summary>
        public static readonly StringName DisableAmbientLight = "disable_ambient_light";
        /// <summary>
        /// Cached name for the 'disable_fog' property.
        /// </summary>
        public static readonly StringName DisableFog = "disable_fog";
        /// <summary>
        /// Cached name for the 'vertex_color_use_as_albedo' property.
        /// </summary>
        public static readonly StringName VertexColorUseAsAlbedo = "vertex_color_use_as_albedo";
        /// <summary>
        /// Cached name for the 'vertex_color_is_srgb' property.
        /// </summary>
        public static readonly StringName VertexColorIsSrgb = "vertex_color_is_srgb";
        /// <summary>
        /// Cached name for the 'albedo_color' property.
        /// </summary>
        public static readonly StringName AlbedoColor = "albedo_color";
        /// <summary>
        /// Cached name for the 'albedo_texture' property.
        /// </summary>
        public static readonly StringName AlbedoTexture = "albedo_texture";
        /// <summary>
        /// Cached name for the 'albedo_texture_force_srgb' property.
        /// </summary>
        public static readonly StringName AlbedoTextureForceSrgb = "albedo_texture_force_srgb";
        /// <summary>
        /// Cached name for the 'albedo_texture_msdf' property.
        /// </summary>
        public static readonly StringName AlbedoTextureMsdf = "albedo_texture_msdf";
        /// <summary>
        /// Cached name for the 'orm_texture' property.
        /// </summary>
        public static readonly StringName OrmTexture = "orm_texture";
        /// <summary>
        /// Cached name for the 'metallic' property.
        /// </summary>
        public static readonly StringName Metallic = "metallic";
        /// <summary>
        /// Cached name for the 'metallic_specular' property.
        /// </summary>
        public static readonly StringName MetallicSpecular = "metallic_specular";
        /// <summary>
        /// Cached name for the 'metallic_texture' property.
        /// </summary>
        public static readonly StringName MetallicTexture = "metallic_texture";
        /// <summary>
        /// Cached name for the 'metallic_texture_channel' property.
        /// </summary>
        public static readonly StringName MetallicTextureChannel = "metallic_texture_channel";
        /// <summary>
        /// Cached name for the 'roughness' property.
        /// </summary>
        public static readonly StringName Roughness = "roughness";
        /// <summary>
        /// Cached name for the 'roughness_texture' property.
        /// </summary>
        public static readonly StringName RoughnessTexture = "roughness_texture";
        /// <summary>
        /// Cached name for the 'roughness_texture_channel' property.
        /// </summary>
        public static readonly StringName RoughnessTextureChannel = "roughness_texture_channel";
        /// <summary>
        /// Cached name for the 'emission_enabled' property.
        /// </summary>
        public static readonly StringName EmissionEnabled = "emission_enabled";
        /// <summary>
        /// Cached name for the 'emission' property.
        /// </summary>
        public static readonly StringName Emission = "emission";
        /// <summary>
        /// Cached name for the 'emission_energy_multiplier' property.
        /// </summary>
        public static readonly StringName EmissionEnergyMultiplier = "emission_energy_multiplier";
        /// <summary>
        /// Cached name for the 'emission_intensity' property.
        /// </summary>
        public static readonly StringName EmissionIntensity = "emission_intensity";
        /// <summary>
        /// Cached name for the 'emission_operator' property.
        /// </summary>
        public static readonly StringName EmissionOperator = "emission_operator";
        /// <summary>
        /// Cached name for the 'emission_on_uv2' property.
        /// </summary>
        public static readonly StringName EmissionOnUV2 = "emission_on_uv2";
        /// <summary>
        /// Cached name for the 'emission_texture' property.
        /// </summary>
        public static readonly StringName EmissionTexture = "emission_texture";
        /// <summary>
        /// Cached name for the 'normal_enabled' property.
        /// </summary>
        public static readonly StringName NormalEnabled = "normal_enabled";
        /// <summary>
        /// Cached name for the 'normal_scale' property.
        /// </summary>
        public static readonly StringName NormalScale = "normal_scale";
        /// <summary>
        /// Cached name for the 'normal_texture' property.
        /// </summary>
        public static readonly StringName NormalTexture = "normal_texture";
        /// <summary>
        /// Cached name for the 'rim_enabled' property.
        /// </summary>
        public static readonly StringName RimEnabled = "rim_enabled";
        /// <summary>
        /// Cached name for the 'rim' property.
        /// </summary>
        public static readonly StringName Rim = "rim";
        /// <summary>
        /// Cached name for the 'rim_tint' property.
        /// </summary>
        public static readonly StringName RimTint = "rim_tint";
        /// <summary>
        /// Cached name for the 'rim_texture' property.
        /// </summary>
        public static readonly StringName RimTexture = "rim_texture";
        /// <summary>
        /// Cached name for the 'clearcoat_enabled' property.
        /// </summary>
        public static readonly StringName ClearcoatEnabled = "clearcoat_enabled";
        /// <summary>
        /// Cached name for the 'clearcoat' property.
        /// </summary>
        public static readonly StringName Clearcoat = "clearcoat";
        /// <summary>
        /// Cached name for the 'clearcoat_roughness' property.
        /// </summary>
        public static readonly StringName ClearcoatRoughness = "clearcoat_roughness";
        /// <summary>
        /// Cached name for the 'clearcoat_texture' property.
        /// </summary>
        public static readonly StringName ClearcoatTexture = "clearcoat_texture";
        /// <summary>
        /// Cached name for the 'anisotropy_enabled' property.
        /// </summary>
        public static readonly StringName AnisotropyEnabled = "anisotropy_enabled";
        /// <summary>
        /// Cached name for the 'anisotropy' property.
        /// </summary>
        public static readonly StringName Anisotropy = "anisotropy";
        /// <summary>
        /// Cached name for the 'anisotropy_flowmap' property.
        /// </summary>
        public static readonly StringName AnisotropyFlowmap = "anisotropy_flowmap";
        /// <summary>
        /// Cached name for the 'ao_enabled' property.
        /// </summary>
        public static readonly StringName AOEnabled = "ao_enabled";
        /// <summary>
        /// Cached name for the 'ao_light_affect' property.
        /// </summary>
        public static readonly StringName AOLightAffect = "ao_light_affect";
        /// <summary>
        /// Cached name for the 'ao_texture' property.
        /// </summary>
        public static readonly StringName AOTexture = "ao_texture";
        /// <summary>
        /// Cached name for the 'ao_on_uv2' property.
        /// </summary>
        public static readonly StringName AOOnUV2 = "ao_on_uv2";
        /// <summary>
        /// Cached name for the 'ao_texture_channel' property.
        /// </summary>
        public static readonly StringName AOTextureChannel = "ao_texture_channel";
        /// <summary>
        /// Cached name for the 'heightmap_enabled' property.
        /// </summary>
        public static readonly StringName HeightmapEnabled = "heightmap_enabled";
        /// <summary>
        /// Cached name for the 'heightmap_scale' property.
        /// </summary>
        public static readonly StringName HeightmapScale = "heightmap_scale";
        /// <summary>
        /// Cached name for the 'heightmap_deep_parallax' property.
        /// </summary>
        public static readonly StringName HeightmapDeepParallax = "heightmap_deep_parallax";
        /// <summary>
        /// Cached name for the 'heightmap_min_layers' property.
        /// </summary>
        public static readonly StringName HeightmapMinLayers = "heightmap_min_layers";
        /// <summary>
        /// Cached name for the 'heightmap_max_layers' property.
        /// </summary>
        public static readonly StringName HeightmapMaxLayers = "heightmap_max_layers";
        /// <summary>
        /// Cached name for the 'heightmap_flip_tangent' property.
        /// </summary>
        public static readonly StringName HeightmapFlipTangent = "heightmap_flip_tangent";
        /// <summary>
        /// Cached name for the 'heightmap_flip_binormal' property.
        /// </summary>
        public static readonly StringName HeightmapFlipBinormal = "heightmap_flip_binormal";
        /// <summary>
        /// Cached name for the 'heightmap_texture' property.
        /// </summary>
        public static readonly StringName HeightmapTexture = "heightmap_texture";
        /// <summary>
        /// Cached name for the 'heightmap_flip_texture' property.
        /// </summary>
        public static readonly StringName HeightmapFlipTexture = "heightmap_flip_texture";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_enabled' property.
        /// </summary>
        public static readonly StringName SubsurfScatterEnabled = "subsurf_scatter_enabled";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_strength' property.
        /// </summary>
        public static readonly StringName SubsurfScatterStrength = "subsurf_scatter_strength";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_skin_mode' property.
        /// </summary>
        public static readonly StringName SubsurfScatterSkinMode = "subsurf_scatter_skin_mode";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_texture' property.
        /// </summary>
        public static readonly StringName SubsurfScatterTexture = "subsurf_scatter_texture";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_transmittance_enabled' property.
        /// </summary>
        public static readonly StringName SubsurfScatterTransmittanceEnabled = "subsurf_scatter_transmittance_enabled";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_transmittance_color' property.
        /// </summary>
        public static readonly StringName SubsurfScatterTransmittanceColor = "subsurf_scatter_transmittance_color";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_transmittance_texture' property.
        /// </summary>
        public static readonly StringName SubsurfScatterTransmittanceTexture = "subsurf_scatter_transmittance_texture";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_transmittance_depth' property.
        /// </summary>
        public static readonly StringName SubsurfScatterTransmittanceDepth = "subsurf_scatter_transmittance_depth";
        /// <summary>
        /// Cached name for the 'subsurf_scatter_transmittance_boost' property.
        /// </summary>
        public static readonly StringName SubsurfScatterTransmittanceBoost = "subsurf_scatter_transmittance_boost";
        /// <summary>
        /// Cached name for the 'backlight_enabled' property.
        /// </summary>
        public static readonly StringName BacklightEnabled = "backlight_enabled";
        /// <summary>
        /// Cached name for the 'backlight' property.
        /// </summary>
        public static readonly StringName Backlight = "backlight";
        /// <summary>
        /// Cached name for the 'backlight_texture' property.
        /// </summary>
        public static readonly StringName BacklightTexture = "backlight_texture";
        /// <summary>
        /// Cached name for the 'refraction_enabled' property.
        /// </summary>
        public static readonly StringName RefractionEnabled = "refraction_enabled";
        /// <summary>
        /// Cached name for the 'refraction_scale' property.
        /// </summary>
        public static readonly StringName RefractionScale = "refraction_scale";
        /// <summary>
        /// Cached name for the 'refraction_texture' property.
        /// </summary>
        public static readonly StringName RefractionTexture = "refraction_texture";
        /// <summary>
        /// Cached name for the 'refraction_texture_channel' property.
        /// </summary>
        public static readonly StringName RefractionTextureChannel = "refraction_texture_channel";
        /// <summary>
        /// Cached name for the 'detail_enabled' property.
        /// </summary>
        public static readonly StringName DetailEnabled = "detail_enabled";
        /// <summary>
        /// Cached name for the 'detail_mask' property.
        /// </summary>
        public static readonly StringName DetailMask = "detail_mask";
        /// <summary>
        /// Cached name for the 'detail_blend_mode' property.
        /// </summary>
        public static readonly StringName DetailBlendMode = "detail_blend_mode";
        /// <summary>
        /// Cached name for the 'detail_uv_layer' property.
        /// </summary>
        public static readonly StringName DetailUVLayer = "detail_uv_layer";
        /// <summary>
        /// Cached name for the 'detail_albedo' property.
        /// </summary>
        public static readonly StringName DetailAlbedo = "detail_albedo";
        /// <summary>
        /// Cached name for the 'detail_normal' property.
        /// </summary>
        public static readonly StringName DetailNormal = "detail_normal";
        /// <summary>
        /// Cached name for the 'uv1_scale' property.
        /// </summary>
        public static readonly StringName Uv1Scale = "uv1_scale";
        /// <summary>
        /// Cached name for the 'uv1_offset' property.
        /// </summary>
        public static readonly StringName Uv1Offset = "uv1_offset";
        /// <summary>
        /// Cached name for the 'uv1_triplanar' property.
        /// </summary>
        public static readonly StringName Uv1Triplanar = "uv1_triplanar";
        /// <summary>
        /// Cached name for the 'uv1_triplanar_sharpness' property.
        /// </summary>
        public static readonly StringName Uv1TriplanarSharpness = "uv1_triplanar_sharpness";
        /// <summary>
        /// Cached name for the 'uv1_world_triplanar' property.
        /// </summary>
        public static readonly StringName Uv1WorldTriplanar = "uv1_world_triplanar";
        /// <summary>
        /// Cached name for the 'uv2_scale' property.
        /// </summary>
        public static readonly StringName UV2Scale = "uv2_scale";
        /// <summary>
        /// Cached name for the 'uv2_offset' property.
        /// </summary>
        public static readonly StringName UV2Offset = "uv2_offset";
        /// <summary>
        /// Cached name for the 'uv2_triplanar' property.
        /// </summary>
        public static readonly StringName UV2Triplanar = "uv2_triplanar";
        /// <summary>
        /// Cached name for the 'uv2_triplanar_sharpness' property.
        /// </summary>
        public static readonly StringName UV2TriplanarSharpness = "uv2_triplanar_sharpness";
        /// <summary>
        /// Cached name for the 'uv2_world_triplanar' property.
        /// </summary>
        public static readonly StringName UV2WorldTriplanar = "uv2_world_triplanar";
        /// <summary>
        /// Cached name for the 'texture_filter' property.
        /// </summary>
        public static readonly StringName TextureFilter = "texture_filter";
        /// <summary>
        /// Cached name for the 'texture_repeat' property.
        /// </summary>
        public static readonly StringName TextureRepeat = "texture_repeat";
        /// <summary>
        /// Cached name for the 'disable_receive_shadows' property.
        /// </summary>
        public static readonly StringName DisableReceiveShadows = "disable_receive_shadows";
        /// <summary>
        /// Cached name for the 'shadow_to_opacity' property.
        /// </summary>
        public static readonly StringName ShadowToOpacity = "shadow_to_opacity";
        /// <summary>
        /// Cached name for the 'billboard_mode' property.
        /// </summary>
        public static readonly StringName BillboardMode = "billboard_mode";
        /// <summary>
        /// Cached name for the 'billboard_keep_scale' property.
        /// </summary>
        public static readonly StringName BillboardKeepScale = "billboard_keep_scale";
        /// <summary>
        /// Cached name for the 'particles_anim_h_frames' property.
        /// </summary>
        public static readonly StringName ParticlesAnimHFrames = "particles_anim_h_frames";
        /// <summary>
        /// Cached name for the 'particles_anim_v_frames' property.
        /// </summary>
        public static readonly StringName ParticlesAnimVFrames = "particles_anim_v_frames";
        /// <summary>
        /// Cached name for the 'particles_anim_loop' property.
        /// </summary>
        public static readonly StringName ParticlesAnimLoop = "particles_anim_loop";
        /// <summary>
        /// Cached name for the 'grow' property.
        /// </summary>
        public static readonly StringName Grow = "grow";
        /// <summary>
        /// Cached name for the 'grow_amount' property.
        /// </summary>
        public static readonly StringName GrowAmount = "grow_amount";
        /// <summary>
        /// Cached name for the 'fixed_size' property.
        /// </summary>
        public static readonly StringName FixedSize = "fixed_size";
        /// <summary>
        /// Cached name for the 'use_point_size' property.
        /// </summary>
        public static readonly StringName UsePointSize = "use_point_size";
        /// <summary>
        /// Cached name for the 'point_size' property.
        /// </summary>
        public static readonly StringName PointSize = "point_size";
        /// <summary>
        /// Cached name for the 'use_particle_trails' property.
        /// </summary>
        public static readonly StringName UseParticleTrails = "use_particle_trails";
        /// <summary>
        /// Cached name for the 'proximity_fade_enabled' property.
        /// </summary>
        public static readonly StringName ProximityFadeEnabled = "proximity_fade_enabled";
        /// <summary>
        /// Cached name for the 'proximity_fade_distance' property.
        /// </summary>
        public static readonly StringName ProximityFadeDistance = "proximity_fade_distance";
        /// <summary>
        /// Cached name for the 'msdf_pixel_range' property.
        /// </summary>
        public static readonly StringName MsdfPixelRange = "msdf_pixel_range";
        /// <summary>
        /// Cached name for the 'msdf_outline_size' property.
        /// </summary>
        public static readonly StringName MsdfOutlineSize = "msdf_outline_size";
        /// <summary>
        /// Cached name for the 'distance_fade_mode' property.
        /// </summary>
        public static readonly StringName DistanceFadeMode = "distance_fade_mode";
        /// <summary>
        /// Cached name for the 'distance_fade_min_distance' property.
        /// </summary>
        public static readonly StringName DistanceFadeMinDistance = "distance_fade_min_distance";
        /// <summary>
        /// Cached name for the 'distance_fade_max_distance' property.
        /// </summary>
        public static readonly StringName DistanceFadeMaxDistance = "distance_fade_max_distance";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Material.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_albedo' method.
        /// </summary>
        public static readonly StringName SetAlbedo = "set_albedo";
        /// <summary>
        /// Cached name for the 'get_albedo' method.
        /// </summary>
        public static readonly StringName GetAlbedo = "get_albedo";
        /// <summary>
        /// Cached name for the 'set_transparency' method.
        /// </summary>
        public static readonly StringName SetTransparency = "set_transparency";
        /// <summary>
        /// Cached name for the 'get_transparency' method.
        /// </summary>
        public static readonly StringName GetTransparency = "get_transparency";
        /// <summary>
        /// Cached name for the 'set_alpha_antialiasing' method.
        /// </summary>
        public static readonly StringName SetAlphaAntialiasing = "set_alpha_antialiasing";
        /// <summary>
        /// Cached name for the 'get_alpha_antialiasing' method.
        /// </summary>
        public static readonly StringName GetAlphaAntialiasing = "get_alpha_antialiasing";
        /// <summary>
        /// Cached name for the 'set_alpha_antialiasing_edge' method.
        /// </summary>
        public static readonly StringName SetAlphaAntialiasingEdge = "set_alpha_antialiasing_edge";
        /// <summary>
        /// Cached name for the 'get_alpha_antialiasing_edge' method.
        /// </summary>
        public static readonly StringName GetAlphaAntialiasingEdge = "get_alpha_antialiasing_edge";
        /// <summary>
        /// Cached name for the 'set_shading_mode' method.
        /// </summary>
        public static readonly StringName SetShadingMode = "set_shading_mode";
        /// <summary>
        /// Cached name for the 'get_shading_mode' method.
        /// </summary>
        public static readonly StringName GetShadingMode = "get_shading_mode";
        /// <summary>
        /// Cached name for the 'set_specular' method.
        /// </summary>
        public static readonly StringName SetSpecular = "set_specular";
        /// <summary>
        /// Cached name for the 'get_specular' method.
        /// </summary>
        public static readonly StringName GetSpecular = "get_specular";
        /// <summary>
        /// Cached name for the 'set_metallic' method.
        /// </summary>
        public static readonly StringName SetMetallic = "set_metallic";
        /// <summary>
        /// Cached name for the 'get_metallic' method.
        /// </summary>
        public static readonly StringName GetMetallic = "get_metallic";
        /// <summary>
        /// Cached name for the 'set_roughness' method.
        /// </summary>
        public static readonly StringName SetRoughness = "set_roughness";
        /// <summary>
        /// Cached name for the 'get_roughness' method.
        /// </summary>
        public static readonly StringName GetRoughness = "get_roughness";
        /// <summary>
        /// Cached name for the 'set_emission' method.
        /// </summary>
        public static readonly StringName SetEmission = "set_emission";
        /// <summary>
        /// Cached name for the 'get_emission' method.
        /// </summary>
        public static readonly StringName GetEmission = "get_emission";
        /// <summary>
        /// Cached name for the 'set_emission_energy_multiplier' method.
        /// </summary>
        public static readonly StringName SetEmissionEnergyMultiplier = "set_emission_energy_multiplier";
        /// <summary>
        /// Cached name for the 'get_emission_energy_multiplier' method.
        /// </summary>
        public static readonly StringName GetEmissionEnergyMultiplier = "get_emission_energy_multiplier";
        /// <summary>
        /// Cached name for the 'set_emission_intensity' method.
        /// </summary>
        public static readonly StringName SetEmissionIntensity = "set_emission_intensity";
        /// <summary>
        /// Cached name for the 'get_emission_intensity' method.
        /// </summary>
        public static readonly StringName GetEmissionIntensity = "get_emission_intensity";
        /// <summary>
        /// Cached name for the 'set_normal_scale' method.
        /// </summary>
        public static readonly StringName SetNormalScale = "set_normal_scale";
        /// <summary>
        /// Cached name for the 'get_normal_scale' method.
        /// </summary>
        public static readonly StringName GetNormalScale = "get_normal_scale";
        /// <summary>
        /// Cached name for the 'set_rim' method.
        /// </summary>
        public static readonly StringName SetRim = "set_rim";
        /// <summary>
        /// Cached name for the 'get_rim' method.
        /// </summary>
        public static readonly StringName GetRim = "get_rim";
        /// <summary>
        /// Cached name for the 'set_rim_tint' method.
        /// </summary>
        public static readonly StringName SetRimTint = "set_rim_tint";
        /// <summary>
        /// Cached name for the 'get_rim_tint' method.
        /// </summary>
        public static readonly StringName GetRimTint = "get_rim_tint";
        /// <summary>
        /// Cached name for the 'set_clearcoat' method.
        /// </summary>
        public static readonly StringName SetClearcoat = "set_clearcoat";
        /// <summary>
        /// Cached name for the 'get_clearcoat' method.
        /// </summary>
        public static readonly StringName GetClearcoat = "get_clearcoat";
        /// <summary>
        /// Cached name for the 'set_clearcoat_roughness' method.
        /// </summary>
        public static readonly StringName SetClearcoatRoughness = "set_clearcoat_roughness";
        /// <summary>
        /// Cached name for the 'get_clearcoat_roughness' method.
        /// </summary>
        public static readonly StringName GetClearcoatRoughness = "get_clearcoat_roughness";
        /// <summary>
        /// Cached name for the 'set_anisotropy' method.
        /// </summary>
        public static readonly StringName SetAnisotropy = "set_anisotropy";
        /// <summary>
        /// Cached name for the 'get_anisotropy' method.
        /// </summary>
        public static readonly StringName GetAnisotropy = "get_anisotropy";
        /// <summary>
        /// Cached name for the 'set_heightmap_scale' method.
        /// </summary>
        public static readonly StringName SetHeightmapScale = "set_heightmap_scale";
        /// <summary>
        /// Cached name for the 'get_heightmap_scale' method.
        /// </summary>
        public static readonly StringName GetHeightmapScale = "get_heightmap_scale";
        /// <summary>
        /// Cached name for the 'set_subsurface_scattering_strength' method.
        /// </summary>
        public static readonly StringName SetSubsurfaceScatteringStrength = "set_subsurface_scattering_strength";
        /// <summary>
        /// Cached name for the 'get_subsurface_scattering_strength' method.
        /// </summary>
        public static readonly StringName GetSubsurfaceScatteringStrength = "get_subsurface_scattering_strength";
        /// <summary>
        /// Cached name for the 'set_transmittance_color' method.
        /// </summary>
        public static readonly StringName SetTransmittanceColor = "set_transmittance_color";
        /// <summary>
        /// Cached name for the 'get_transmittance_color' method.
        /// </summary>
        public static readonly StringName GetTransmittanceColor = "get_transmittance_color";
        /// <summary>
        /// Cached name for the 'set_transmittance_depth' method.
        /// </summary>
        public static readonly StringName SetTransmittanceDepth = "set_transmittance_depth";
        /// <summary>
        /// Cached name for the 'get_transmittance_depth' method.
        /// </summary>
        public static readonly StringName GetTransmittanceDepth = "get_transmittance_depth";
        /// <summary>
        /// Cached name for the 'set_transmittance_boost' method.
        /// </summary>
        public static readonly StringName SetTransmittanceBoost = "set_transmittance_boost";
        /// <summary>
        /// Cached name for the 'get_transmittance_boost' method.
        /// </summary>
        public static readonly StringName GetTransmittanceBoost = "get_transmittance_boost";
        /// <summary>
        /// Cached name for the 'set_backlight' method.
        /// </summary>
        public static readonly StringName SetBacklight = "set_backlight";
        /// <summary>
        /// Cached name for the 'get_backlight' method.
        /// </summary>
        public static readonly StringName GetBacklight = "get_backlight";
        /// <summary>
        /// Cached name for the 'set_refraction' method.
        /// </summary>
        public static readonly StringName SetRefraction = "set_refraction";
        /// <summary>
        /// Cached name for the 'get_refraction' method.
        /// </summary>
        public static readonly StringName GetRefraction = "get_refraction";
        /// <summary>
        /// Cached name for the 'set_point_size' method.
        /// </summary>
        public static readonly StringName SetPointSize = "set_point_size";
        /// <summary>
        /// Cached name for the 'get_point_size' method.
        /// </summary>
        public static readonly StringName GetPointSize = "get_point_size";
        /// <summary>
        /// Cached name for the 'set_detail_uv' method.
        /// </summary>
        public static readonly StringName SetDetailUV = "set_detail_uv";
        /// <summary>
        /// Cached name for the 'get_detail_uv' method.
        /// </summary>
        public static readonly StringName GetDetailUV = "get_detail_uv";
        /// <summary>
        /// Cached name for the 'set_blend_mode' method.
        /// </summary>
        public static readonly StringName SetBlendMode = "set_blend_mode";
        /// <summary>
        /// Cached name for the 'get_blend_mode' method.
        /// </summary>
        public static readonly StringName GetBlendMode = "get_blend_mode";
        /// <summary>
        /// Cached name for the 'set_depth_draw_mode' method.
        /// </summary>
        public static readonly StringName SetDepthDrawMode = "set_depth_draw_mode";
        /// <summary>
        /// Cached name for the 'get_depth_draw_mode' method.
        /// </summary>
        public static readonly StringName GetDepthDrawMode = "get_depth_draw_mode";
        /// <summary>
        /// Cached name for the 'set_cull_mode' method.
        /// </summary>
        public static readonly StringName SetCullMode = "set_cull_mode";
        /// <summary>
        /// Cached name for the 'get_cull_mode' method.
        /// </summary>
        public static readonly StringName GetCullMode = "get_cull_mode";
        /// <summary>
        /// Cached name for the 'set_diffuse_mode' method.
        /// </summary>
        public static readonly StringName SetDiffuseMode = "set_diffuse_mode";
        /// <summary>
        /// Cached name for the 'get_diffuse_mode' method.
        /// </summary>
        public static readonly StringName GetDiffuseMode = "get_diffuse_mode";
        /// <summary>
        /// Cached name for the 'set_specular_mode' method.
        /// </summary>
        public static readonly StringName SetSpecularMode = "set_specular_mode";
        /// <summary>
        /// Cached name for the 'get_specular_mode' method.
        /// </summary>
        public static readonly StringName GetSpecularMode = "get_specular_mode";
        /// <summary>
        /// Cached name for the 'set_flag' method.
        /// </summary>
        public static readonly StringName SetFlag = "set_flag";
        /// <summary>
        /// Cached name for the 'get_flag' method.
        /// </summary>
        public static readonly StringName GetFlag = "get_flag";
        /// <summary>
        /// Cached name for the 'set_texture_filter' method.
        /// </summary>
        public static readonly StringName SetTextureFilter = "set_texture_filter";
        /// <summary>
        /// Cached name for the 'get_texture_filter' method.
        /// </summary>
        public static readonly StringName GetTextureFilter = "get_texture_filter";
        /// <summary>
        /// Cached name for the 'set_feature' method.
        /// </summary>
        public static readonly StringName SetFeature = "set_feature";
        /// <summary>
        /// Cached name for the 'get_feature' method.
        /// </summary>
        public static readonly StringName GetFeature = "get_feature";
        /// <summary>
        /// Cached name for the 'set_texture' method.
        /// </summary>
        public static readonly StringName SetTexture = "set_texture";
        /// <summary>
        /// Cached name for the 'get_texture' method.
        /// </summary>
        public static readonly StringName GetTexture = "get_texture";
        /// <summary>
        /// Cached name for the 'set_detail_blend_mode' method.
        /// </summary>
        public static readonly StringName SetDetailBlendMode = "set_detail_blend_mode";
        /// <summary>
        /// Cached name for the 'get_detail_blend_mode' method.
        /// </summary>
        public static readonly StringName GetDetailBlendMode = "get_detail_blend_mode";
        /// <summary>
        /// Cached name for the 'set_uv1_scale' method.
        /// </summary>
        public static readonly StringName SetUv1Scale = "set_uv1_scale";
        /// <summary>
        /// Cached name for the 'get_uv1_scale' method.
        /// </summary>
        public static readonly StringName GetUv1Scale = "get_uv1_scale";
        /// <summary>
        /// Cached name for the 'set_uv1_offset' method.
        /// </summary>
        public static readonly StringName SetUv1Offset = "set_uv1_offset";
        /// <summary>
        /// Cached name for the 'get_uv1_offset' method.
        /// </summary>
        public static readonly StringName GetUv1Offset = "get_uv1_offset";
        /// <summary>
        /// Cached name for the 'set_uv1_triplanar_blend_sharpness' method.
        /// </summary>
        public static readonly StringName SetUv1TriplanarBlendSharpness = "set_uv1_triplanar_blend_sharpness";
        /// <summary>
        /// Cached name for the 'get_uv1_triplanar_blend_sharpness' method.
        /// </summary>
        public static readonly StringName GetUv1TriplanarBlendSharpness = "get_uv1_triplanar_blend_sharpness";
        /// <summary>
        /// Cached name for the 'set_uv2_scale' method.
        /// </summary>
        public static readonly StringName SetUV2Scale = "set_uv2_scale";
        /// <summary>
        /// Cached name for the 'get_uv2_scale' method.
        /// </summary>
        public static readonly StringName GetUV2Scale = "get_uv2_scale";
        /// <summary>
        /// Cached name for the 'set_uv2_offset' method.
        /// </summary>
        public static readonly StringName SetUV2Offset = "set_uv2_offset";
        /// <summary>
        /// Cached name for the 'get_uv2_offset' method.
        /// </summary>
        public static readonly StringName GetUV2Offset = "get_uv2_offset";
        /// <summary>
        /// Cached name for the 'set_uv2_triplanar_blend_sharpness' method.
        /// </summary>
        public static readonly StringName SetUV2TriplanarBlendSharpness = "set_uv2_triplanar_blend_sharpness";
        /// <summary>
        /// Cached name for the 'get_uv2_triplanar_blend_sharpness' method.
        /// </summary>
        public static readonly StringName GetUV2TriplanarBlendSharpness = "get_uv2_triplanar_blend_sharpness";
        /// <summary>
        /// Cached name for the 'set_billboard_mode' method.
        /// </summary>
        public static readonly StringName SetBillboardMode = "set_billboard_mode";
        /// <summary>
        /// Cached name for the 'get_billboard_mode' method.
        /// </summary>
        public static readonly StringName GetBillboardMode = "get_billboard_mode";
        /// <summary>
        /// Cached name for the 'set_particles_anim_h_frames' method.
        /// </summary>
        public static readonly StringName SetParticlesAnimHFrames = "set_particles_anim_h_frames";
        /// <summary>
        /// Cached name for the 'get_particles_anim_h_frames' method.
        /// </summary>
        public static readonly StringName GetParticlesAnimHFrames = "get_particles_anim_h_frames";
        /// <summary>
        /// Cached name for the 'set_particles_anim_v_frames' method.
        /// </summary>
        public static readonly StringName SetParticlesAnimVFrames = "set_particles_anim_v_frames";
        /// <summary>
        /// Cached name for the 'get_particles_anim_v_frames' method.
        /// </summary>
        public static readonly StringName GetParticlesAnimVFrames = "get_particles_anim_v_frames";
        /// <summary>
        /// Cached name for the 'set_particles_anim_loop' method.
        /// </summary>
        public static readonly StringName SetParticlesAnimLoop = "set_particles_anim_loop";
        /// <summary>
        /// Cached name for the 'get_particles_anim_loop' method.
        /// </summary>
        public static readonly StringName GetParticlesAnimLoop = "get_particles_anim_loop";
        /// <summary>
        /// Cached name for the 'set_heightmap_deep_parallax' method.
        /// </summary>
        public static readonly StringName SetHeightmapDeepParallax = "set_heightmap_deep_parallax";
        /// <summary>
        /// Cached name for the 'is_heightmap_deep_parallax_enabled' method.
        /// </summary>
        public static readonly StringName IsHeightmapDeepParallaxEnabled = "is_heightmap_deep_parallax_enabled";
        /// <summary>
        /// Cached name for the 'set_heightmap_deep_parallax_min_layers' method.
        /// </summary>
        public static readonly StringName SetHeightmapDeepParallaxMinLayers = "set_heightmap_deep_parallax_min_layers";
        /// <summary>
        /// Cached name for the 'get_heightmap_deep_parallax_min_layers' method.
        /// </summary>
        public static readonly StringName GetHeightmapDeepParallaxMinLayers = "get_heightmap_deep_parallax_min_layers";
        /// <summary>
        /// Cached name for the 'set_heightmap_deep_parallax_max_layers' method.
        /// </summary>
        public static readonly StringName SetHeightmapDeepParallaxMaxLayers = "set_heightmap_deep_parallax_max_layers";
        /// <summary>
        /// Cached name for the 'get_heightmap_deep_parallax_max_layers' method.
        /// </summary>
        public static readonly StringName GetHeightmapDeepParallaxMaxLayers = "get_heightmap_deep_parallax_max_layers";
        /// <summary>
        /// Cached name for the 'set_heightmap_deep_parallax_flip_tangent' method.
        /// </summary>
        public static readonly StringName SetHeightmapDeepParallaxFlipTangent = "set_heightmap_deep_parallax_flip_tangent";
        /// <summary>
        /// Cached name for the 'get_heightmap_deep_parallax_flip_tangent' method.
        /// </summary>
        public static readonly StringName GetHeightmapDeepParallaxFlipTangent = "get_heightmap_deep_parallax_flip_tangent";
        /// <summary>
        /// Cached name for the 'set_heightmap_deep_parallax_flip_binormal' method.
        /// </summary>
        public static readonly StringName SetHeightmapDeepParallaxFlipBinormal = "set_heightmap_deep_parallax_flip_binormal";
        /// <summary>
        /// Cached name for the 'get_heightmap_deep_parallax_flip_binormal' method.
        /// </summary>
        public static readonly StringName GetHeightmapDeepParallaxFlipBinormal = "get_heightmap_deep_parallax_flip_binormal";
        /// <summary>
        /// Cached name for the 'set_grow' method.
        /// </summary>
        public static readonly StringName SetGrow = "set_grow";
        /// <summary>
        /// Cached name for the 'get_grow' method.
        /// </summary>
        public static readonly StringName GetGrow = "get_grow";
        /// <summary>
        /// Cached name for the 'set_emission_operator' method.
        /// </summary>
        public static readonly StringName SetEmissionOperator = "set_emission_operator";
        /// <summary>
        /// Cached name for the 'get_emission_operator' method.
        /// </summary>
        public static readonly StringName GetEmissionOperator = "get_emission_operator";
        /// <summary>
        /// Cached name for the 'set_ao_light_affect' method.
        /// </summary>
        public static readonly StringName SetAOLightAffect = "set_ao_light_affect";
        /// <summary>
        /// Cached name for the 'get_ao_light_affect' method.
        /// </summary>
        public static readonly StringName GetAOLightAffect = "get_ao_light_affect";
        /// <summary>
        /// Cached name for the 'set_alpha_scissor_threshold' method.
        /// </summary>
        public static readonly StringName SetAlphaScissorThreshold = "set_alpha_scissor_threshold";
        /// <summary>
        /// Cached name for the 'get_alpha_scissor_threshold' method.
        /// </summary>
        public static readonly StringName GetAlphaScissorThreshold = "get_alpha_scissor_threshold";
        /// <summary>
        /// Cached name for the 'set_alpha_hash_scale' method.
        /// </summary>
        public static readonly StringName SetAlphaHashScale = "set_alpha_hash_scale";
        /// <summary>
        /// Cached name for the 'get_alpha_hash_scale' method.
        /// </summary>
        public static readonly StringName GetAlphaHashScale = "get_alpha_hash_scale";
        /// <summary>
        /// Cached name for the 'set_grow_enabled' method.
        /// </summary>
        public static readonly StringName SetGrowEnabled = "set_grow_enabled";
        /// <summary>
        /// Cached name for the 'is_grow_enabled' method.
        /// </summary>
        public static readonly StringName IsGrowEnabled = "is_grow_enabled";
        /// <summary>
        /// Cached name for the 'set_metallic_texture_channel' method.
        /// </summary>
        public static readonly StringName SetMetallicTextureChannel = "set_metallic_texture_channel";
        /// <summary>
        /// Cached name for the 'get_metallic_texture_channel' method.
        /// </summary>
        public static readonly StringName GetMetallicTextureChannel = "get_metallic_texture_channel";
        /// <summary>
        /// Cached name for the 'set_roughness_texture_channel' method.
        /// </summary>
        public static readonly StringName SetRoughnessTextureChannel = "set_roughness_texture_channel";
        /// <summary>
        /// Cached name for the 'get_roughness_texture_channel' method.
        /// </summary>
        public static readonly StringName GetRoughnessTextureChannel = "get_roughness_texture_channel";
        /// <summary>
        /// Cached name for the 'set_ao_texture_channel' method.
        /// </summary>
        public static readonly StringName SetAOTextureChannel = "set_ao_texture_channel";
        /// <summary>
        /// Cached name for the 'get_ao_texture_channel' method.
        /// </summary>
        public static readonly StringName GetAOTextureChannel = "get_ao_texture_channel";
        /// <summary>
        /// Cached name for the 'set_refraction_texture_channel' method.
        /// </summary>
        public static readonly StringName SetRefractionTextureChannel = "set_refraction_texture_channel";
        /// <summary>
        /// Cached name for the 'get_refraction_texture_channel' method.
        /// </summary>
        public static readonly StringName GetRefractionTextureChannel = "get_refraction_texture_channel";
        /// <summary>
        /// Cached name for the 'set_proximity_fade_enabled' method.
        /// </summary>
        public static readonly StringName SetProximityFadeEnabled = "set_proximity_fade_enabled";
        /// <summary>
        /// Cached name for the 'is_proximity_fade_enabled' method.
        /// </summary>
        public static readonly StringName IsProximityFadeEnabled = "is_proximity_fade_enabled";
        /// <summary>
        /// Cached name for the 'set_proximity_fade_distance' method.
        /// </summary>
        public static readonly StringName SetProximityFadeDistance = "set_proximity_fade_distance";
        /// <summary>
        /// Cached name for the 'get_proximity_fade_distance' method.
        /// </summary>
        public static readonly StringName GetProximityFadeDistance = "get_proximity_fade_distance";
        /// <summary>
        /// Cached name for the 'set_msdf_pixel_range' method.
        /// </summary>
        public static readonly StringName SetMsdfPixelRange = "set_msdf_pixel_range";
        /// <summary>
        /// Cached name for the 'get_msdf_pixel_range' method.
        /// </summary>
        public static readonly StringName GetMsdfPixelRange = "get_msdf_pixel_range";
        /// <summary>
        /// Cached name for the 'set_msdf_outline_size' method.
        /// </summary>
        public static readonly StringName SetMsdfOutlineSize = "set_msdf_outline_size";
        /// <summary>
        /// Cached name for the 'get_msdf_outline_size' method.
        /// </summary>
        public static readonly StringName GetMsdfOutlineSize = "get_msdf_outline_size";
        /// <summary>
        /// Cached name for the 'set_distance_fade' method.
        /// </summary>
        public static readonly StringName SetDistanceFade = "set_distance_fade";
        /// <summary>
        /// Cached name for the 'get_distance_fade' method.
        /// </summary>
        public static readonly StringName GetDistanceFade = "get_distance_fade";
        /// <summary>
        /// Cached name for the 'set_distance_fade_max_distance' method.
        /// </summary>
        public static readonly StringName SetDistanceFadeMaxDistance = "set_distance_fade_max_distance";
        /// <summary>
        /// Cached name for the 'get_distance_fade_max_distance' method.
        /// </summary>
        public static readonly StringName GetDistanceFadeMaxDistance = "get_distance_fade_max_distance";
        /// <summary>
        /// Cached name for the 'set_distance_fade_min_distance' method.
        /// </summary>
        public static readonly StringName SetDistanceFadeMinDistance = "set_distance_fade_min_distance";
        /// <summary>
        /// Cached name for the 'get_distance_fade_min_distance' method.
        /// </summary>
        public static readonly StringName GetDistanceFadeMinDistance = "get_distance_fade_min_distance";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Material.SignalName
    {
    }
}

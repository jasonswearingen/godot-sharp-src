namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Contains all nodes and resources of a GLTF file. This is used by <see cref="Godot.GltfDocument"/> as data storage, which allows <see cref="Godot.GltfDocument"/> and all <see cref="Godot.GltfDocumentExtension"/> classes to remain stateless.</para>
/// <para>GLTFState can be populated by <see cref="Godot.GltfDocument"/> reading a file or by converting a Godot scene. Then the data can either be used to create a Godot scene or save to a GLTF file. The code that converts to/from a Godot scene can be intercepted at arbitrary points by <see cref="Godot.GltfDocumentExtension"/> classes. This allows for custom data to be stored in the GLTF file or for custom data to be converted to/from Godot nodes.</para>
/// </summary>
[GodotClassName("GLTFState")]
public partial class GltfState : Resource
{
    /// <summary>
    /// <para>Discards all embedded textures and uses untextured materials.</para>
    /// </summary>
    public const long HandleBinaryDiscardTextures = 0;
    /// <summary>
    /// <para>Extracts embedded textures to be reimported and compressed. Editor only. Acts as uncompressed at runtime.</para>
    /// </summary>
    public const long HandleBinaryExtractTextures = 1;
    /// <summary>
    /// <para>Embeds textures VRAM compressed with Basis Universal into the generated scene.</para>
    /// </summary>
    public const long HandleBinaryEmbedAsBasisu = 2;
    /// <summary>
    /// <para>Embeds textures compressed losslessly into the generated scene, matching old behavior.</para>
    /// </summary>
    public const long HandleBinaryEmbedAsUncompressed = 3;

    /// <summary>
    /// <para>The original raw JSON document corresponding to this GLTFState.</para>
    /// </summary>
    public Godot.Collections.Dictionary Json
    {
        get
        {
            return GetJson();
        }
        set
        {
            SetJson(value);
        }
    }

    public int MajorVersion
    {
        get
        {
            return GetMajorVersion();
        }
        set
        {
            SetMajorVersion(value);
        }
    }

    public int MinorVersion
    {
        get
        {
            return GetMinorVersion();
        }
        set
        {
            SetMinorVersion(value);
        }
    }

    /// <summary>
    /// <para>The copyright string in the asset header of the GLTF file. This is set during import if present and export if non-empty. See the GLTF asset header documentation for more information.</para>
    /// </summary>
    public string Copyright
    {
        get
        {
            return GetCopyright();
        }
        set
        {
            SetCopyright(value);
        }
    }

    /// <summary>
    /// <para>The binary buffer attached to a .glb file.</para>
    /// </summary>
    public byte[] GlbData
    {
        get
        {
            return GetGlbData();
        }
        set
        {
            SetGlbData(value);
        }
    }

    public bool UseNamedSkinBinds
    {
        get
        {
            return GetUseNamedSkinBinds();
        }
        set
        {
            SetUseNamedSkinBinds(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfNode> Nodes
    {
        get
        {
            return GetNodes();
        }
        set
        {
            SetNodes(value);
        }
    }

    public Godot.Collections.Array<byte[]> Buffers
    {
        get
        {
            return GetBuffers();
        }
        set
        {
            SetBuffers(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfBufferView> BufferViews
    {
        get
        {
            return GetBufferViews();
        }
        set
        {
            SetBufferViews(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfAccessor> Accessors
    {
        get
        {
            return GetAccessors();
        }
        set
        {
            SetAccessors(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfMesh> Meshes
    {
        get
        {
            return GetMeshes();
        }
        set
        {
            SetMeshes(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<Material> Materials
    {
        get
        {
            return GetMaterials();
        }
        set
        {
            SetMaterials(value);
        }
    }

    /// <summary>
    /// <para>The name of the scene. When importing, if not specified, this will be the file name. When exporting, if specified, the scene name will be saved to the GLTF file.</para>
    /// </summary>
    public string SceneName
    {
        get
        {
            return GetSceneName();
        }
        set
        {
            SetSceneName(value);
        }
    }

    /// <summary>
    /// <para>The folder path associated with this GLTF data. This is used to find other files the GLTF file references, like images or binary buffers. This will be set during import when appending from a file, and will be set during export when writing to a file.</para>
    /// </summary>
    public string BasePath
    {
        get
        {
            return GetBasePath();
        }
        set
        {
            SetBasePath(value);
        }
    }

    /// <summary>
    /// <para>The file name associated with this GLTF data. If it ends with <c>.gltf</c>, this is text-based GLTF, otherwise this is binary GLB. This will be set during import when appending from a file, and will be set during export when writing to a file. If writing to a buffer, this will be an empty string.</para>
    /// </summary>
    public string FileName
    {
        get
        {
            return GetFileName();
        }
        set
        {
            SetFileName(value);
        }
    }

    /// <summary>
    /// <para>The root nodes of the GLTF file. Typically, a GLTF file will only have one scene, and therefore one root node. However, a GLTF file may have multiple scenes and therefore multiple root nodes, which will be generated as siblings of each other and as children of the root node of the generated Godot scene.</para>
    /// </summary>
    public int[] RootNodes
    {
        get
        {
            return GetRootNodes();
        }
        set
        {
            SetRootNodes(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfTexture> Textures
    {
        get
        {
            return GetTextures();
        }
        set
        {
            SetTextures(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfTextureSampler> TextureSamplers
    {
        get
        {
            return GetTextureSamplers();
        }
        set
        {
            SetTextureSamplers(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<Texture2D> Images
    {
        get
        {
            return GetImages();
        }
        set
        {
            SetImages(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfSkin> Skins
    {
        get
        {
            return GetSkins();
        }
        set
        {
            SetSkins(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfCamera> Cameras
    {
        get
        {
            return GetCameras();
        }
        set
        {
            SetCameras(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfLight> Lights
    {
        get
        {
            return GetLights();
        }
        set
        {
            SetLights(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<string> UniqueNames
    {
        get
        {
            return GetUniqueNames();
        }
        set
        {
            SetUniqueNames(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<string> UniqueAnimationNames
    {
        get
        {
            return GetUniqueAnimationNames();
        }
        set
        {
            SetUniqueAnimationNames(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfSkeleton> Skeletons
    {
        get
        {
            return GetSkeletons();
        }
        set
        {
            SetSkeletons(value);
        }
    }

    public bool CreateAnimations
    {
        get
        {
            return GetCreateAnimations();
        }
        set
        {
            SetCreateAnimations(value);
        }
    }

    /// <summary>
    /// <para>True to force all GLTFNodes in the document to be bones of a single Skeleton3D godot node.</para>
    /// </summary>
    public bool ImportAsSkeletonBones
    {
        get
        {
            return GetImportAsSkeletonBones();
        }
        set
        {
            SetImportAsSkeletonBones(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<GltfAnimation> Animations
    {
        get
        {
            return GetAnimations();
        }
        set
        {
            SetAnimations(value);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int HandleBinaryImage
    {
        get
        {
            return GetHandleBinaryImage();
        }
        set
        {
            SetHandleBinaryImage(value);
        }
    }

    /// <summary>
    /// <para>The baking fps of the animation for either import or export.</para>
    /// </summary>
    public double BakeFps
    {
        get
        {
            return GetBakeFps();
        }
        set
        {
            SetBakeFps(value);
        }
    }

    private static readonly System.Type CachedType = typeof(GltfState);

    private static readonly StringName NativeName = "GLTFState";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public GltfState() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal GltfState(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddUsedExtension, 2678287736ul);

    /// <summary>
    /// <para>Appends an extension to the list of extensions used by this GLTF file during serialization. If <paramref name="required"/> is true, the extension will also be added to the list of required extensions. Do not run this in <see cref="Godot.GltfDocumentExtension._ExportPost(GltfState)"/>, as that stage is too late to add extensions. The final list is sorted alphabetically.</para>
    /// </summary>
    public void AddUsedExtension(string extensionName, bool required)
    {
        NativeCalls.godot_icall_2_420(MethodBind0, GodotObject.GetPtr(this), extensionName, required.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AppendDataToBuffers, 1460416665ul);

    /// <summary>
    /// <para>Appends the given byte array data to the buffers and creates a <see cref="Godot.GltfBufferView"/> for it. The index of the destination <see cref="Godot.GltfBufferView"/> is returned. If <paramref name="deduplication"/> is true, the buffers will first be searched for duplicate data, otherwise new bytes will always be appended.</para>
    /// </summary>
    public int AppendDataToBuffers(byte[] data, bool deduplication)
    {
        return NativeCalls.godot_icall_2_542(MethodBind1, GodotObject.GetPtr(this), data, deduplication.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetJson, 2382534195ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Dictionary GetJson()
    {
        return NativeCalls.godot_icall_0_114(MethodBind2, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetJson, 4155329257ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetJson(Godot.Collections.Dictionary json)
    {
        NativeCalls.godot_icall_1_113(MethodBind3, GodotObject.GetPtr(this), (godot_dictionary)(json ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMajorVersion, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetMajorVersion()
    {
        return NativeCalls.godot_icall_0_37(MethodBind4, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMajorVersion, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMajorVersion(int majorVersion)
    {
        NativeCalls.godot_icall_1_36(MethodBind5, GodotObject.GetPtr(this), majorVersion);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMinorVersion, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetMinorVersion()
    {
        return NativeCalls.godot_icall_0_37(MethodBind6, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMinorVersion, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMinorVersion(int minorVersion)
    {
        NativeCalls.godot_icall_1_36(MethodBind7, GodotObject.GetPtr(this), minorVersion);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCopyright, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetCopyright()
    {
        return NativeCalls.godot_icall_0_57(MethodBind8, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCopyright, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCopyright(string copyright)
    {
        NativeCalls.godot_icall_1_56(MethodBind9, GodotObject.GetPtr(this), copyright);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGlbData, 2115431945ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public byte[] GetGlbData()
    {
        return NativeCalls.godot_icall_0_2(MethodBind10, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGlbData, 2971499966ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetGlbData(byte[] glbData)
    {
        NativeCalls.godot_icall_1_187(MethodBind11, GodotObject.GetPtr(this), glbData);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUseNamedSkinBinds, 2240911060ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetUseNamedSkinBinds()
    {
        return NativeCalls.godot_icall_0_40(MethodBind12, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUseNamedSkinBinds, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetUseNamedSkinBinds(bool useNamedSkinBinds)
    {
        NativeCalls.godot_icall_1_41(MethodBind13, GodotObject.GetPtr(this), useNamedSkinBinds.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNodes, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of all <see cref="Godot.GltfNode"/>s in the GLTF file. These are the nodes that <see cref="Godot.GltfNode.Children"/> and <see cref="Godot.GltfState.RootNodes"/> refer to. This includes nodes that may not be generated in the Godot scene, or nodes that may generate multiple Godot scene nodes.</para>
    /// </summary>
    public Godot.Collections.Array<GltfNode> GetNodes()
    {
        return new Godot.Collections.Array<GltfNode>(NativeCalls.godot_icall_0_112(MethodBind14, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNodes, 381264803ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.GltfNode"/>s in the state. These are the nodes that <see cref="Godot.GltfNode.Children"/> and <see cref="Godot.GltfState.RootNodes"/> refer to. Some of the nodes set here may not be generated in the Godot scene, or may generate multiple Godot scene nodes.</para>
    /// </summary>
    public void SetNodes(Godot.Collections.Array<GltfNode> nodes)
    {
        NativeCalls.godot_icall_1_130(MethodBind15, GodotObject.GetPtr(this), (godot_array)(nodes ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBuffers, 2915620761ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Godot.Collections.Array<byte[]> GetBuffers()
    {
        return new Godot.Collections.Array<byte[]>(NativeCalls.godot_icall_0_112(MethodBind16, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBuffers, 381264803ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBuffers(Godot.Collections.Array<byte[]> buffers)
    {
        NativeCalls.godot_icall_1_130(MethodBind17, GodotObject.GetPtr(this), (godot_array)(buffers ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBufferViews, 2915620761ul);

    public Godot.Collections.Array<GltfBufferView> GetBufferViews()
    {
        return new Godot.Collections.Array<GltfBufferView>(NativeCalls.godot_icall_0_112(MethodBind18, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBufferViews, 381264803ul);

    public void SetBufferViews(Godot.Collections.Array<GltfBufferView> bufferViews)
    {
        NativeCalls.godot_icall_1_130(MethodBind19, GodotObject.GetPtr(this), (godot_array)(bufferViews ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAccessors, 2915620761ul);

    public Godot.Collections.Array<GltfAccessor> GetAccessors()
    {
        return new Godot.Collections.Array<GltfAccessor>(NativeCalls.godot_icall_0_112(MethodBind20, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAccessors, 381264803ul);

    public void SetAccessors(Godot.Collections.Array<GltfAccessor> accessors)
    {
        NativeCalls.godot_icall_1_130(MethodBind21, GodotObject.GetPtr(this), (godot_array)(accessors ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMeshes, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of all <see cref="Godot.GltfMesh"/>es in the GLTF file. These are the meshes that the <see cref="Godot.GltfNode.Mesh"/> index refers to.</para>
    /// </summary>
    public Godot.Collections.Array<GltfMesh> GetMeshes()
    {
        return new Godot.Collections.Array<GltfMesh>(NativeCalls.godot_icall_0_112(MethodBind22, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMeshes, 381264803ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.GltfMesh"/>es in the state. These are the meshes that the <see cref="Godot.GltfNode.Mesh"/> index refers to.</para>
    /// </summary>
    public void SetMeshes(Godot.Collections.Array<GltfMesh> meshes)
    {
        NativeCalls.godot_icall_1_130(MethodBind23, GodotObject.GetPtr(this), (godot_array)(meshes ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAnimationPlayersCount, 3744713108ul);

    /// <summary>
    /// <para>Returns the number of <see cref="Godot.AnimationPlayer"/> nodes in this <see cref="Godot.GltfState"/>. These nodes are only used during the export process when converting Godot <see cref="Godot.AnimationPlayer"/> nodes to GLTF animations.</para>
    /// </summary>
    public int GetAnimationPlayersCount(int idx)
    {
        return NativeCalls.godot_icall_1_69(MethodBind24, GodotObject.GetPtr(this), idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAnimationPlayer, 925043400ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.AnimationPlayer"/> node with the given index. These nodes are only used during the export process when converting Godot <see cref="Godot.AnimationPlayer"/> nodes to GLTF animations.</para>
    /// </summary>
    public AnimationPlayer GetAnimationPlayer(int idx)
    {
        return (AnimationPlayer)NativeCalls.godot_icall_1_302(MethodBind25, GodotObject.GetPtr(this), idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMaterials, 2915620761ul);

    public Godot.Collections.Array<Material> GetMaterials()
    {
        return new Godot.Collections.Array<Material>(NativeCalls.godot_icall_0_112(MethodBind26, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMaterials, 381264803ul);

    public void SetMaterials(Godot.Collections.Array<Material> materials)
    {
        NativeCalls.godot_icall_1_130(MethodBind27, GodotObject.GetPtr(this), (godot_array)(materials ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSceneName, 2841200299ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetSceneName()
    {
        return NativeCalls.godot_icall_0_57(MethodBind28, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSceneName, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSceneName(string sceneName)
    {
        NativeCalls.godot_icall_1_56(MethodBind29, GodotObject.GetPtr(this), sceneName);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind30 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBasePath, 2841200299ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetBasePath()
    {
        return NativeCalls.godot_icall_0_57(MethodBind30, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind31 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBasePath, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBasePath(string basePath)
    {
        NativeCalls.godot_icall_1_56(MethodBind31, GodotObject.GetPtr(this), basePath);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind32 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFileName, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetFileName()
    {
        return NativeCalls.godot_icall_0_57(MethodBind32, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind33 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFileName, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFileName(string fileName)
    {
        NativeCalls.godot_icall_1_56(MethodBind33, GodotObject.GetPtr(this), fileName);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind34 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRootNodes, 969006518ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int[] GetRootNodes()
    {
        return NativeCalls.godot_icall_0_143(MethodBind34, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind35 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRootNodes, 3614634198ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRootNodes(int[] rootNodes)
    {
        NativeCalls.godot_icall_1_142(MethodBind35, GodotObject.GetPtr(this), rootNodes);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind36 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTextures, 2915620761ul);

    public Godot.Collections.Array<GltfTexture> GetTextures()
    {
        return new Godot.Collections.Array<GltfTexture>(NativeCalls.godot_icall_0_112(MethodBind36, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind37 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTextures, 381264803ul);

    public void SetTextures(Godot.Collections.Array<GltfTexture> textures)
    {
        NativeCalls.godot_icall_1_130(MethodBind37, GodotObject.GetPtr(this), (godot_array)(textures ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind38 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTextureSamplers, 2915620761ul);

    /// <summary>
    /// <para>Retrieves the array of texture samplers that are used by the textures contained in the GLTF.</para>
    /// </summary>
    public Godot.Collections.Array<GltfTextureSampler> GetTextureSamplers()
    {
        return new Godot.Collections.Array<GltfTextureSampler>(NativeCalls.godot_icall_0_112(MethodBind38, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind39 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTextureSamplers, 381264803ul);

    /// <summary>
    /// <para>Sets the array of texture samplers that are used by the textures contained in the GLTF.</para>
    /// </summary>
    public void SetTextureSamplers(Godot.Collections.Array<GltfTextureSampler> textureSamplers)
    {
        NativeCalls.godot_icall_1_130(MethodBind39, GodotObject.GetPtr(this), (godot_array)(textureSamplers ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind40 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetImages, 2915620761ul);

    /// <summary>
    /// <para>Gets the images of the GLTF file as an array of <see cref="Godot.Texture2D"/>s. These are the images that the <see cref="Godot.GltfTexture.SrcImage"/> index refers to.</para>
    /// </summary>
    public Godot.Collections.Array<Texture2D> GetImages()
    {
        return new Godot.Collections.Array<Texture2D>(NativeCalls.godot_icall_0_112(MethodBind40, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind41 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetImages, 381264803ul);

    /// <summary>
    /// <para>Sets the images in the state stored as an array of <see cref="Godot.Texture2D"/>s. This can be used during export. These are the images that the <see cref="Godot.GltfTexture.SrcImage"/> index refers to.</para>
    /// </summary>
    public void SetImages(Godot.Collections.Array<Texture2D> images)
    {
        NativeCalls.godot_icall_1_130(MethodBind41, GodotObject.GetPtr(this), (godot_array)(images ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind42 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSkins, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of all <see cref="Godot.GltfSkin"/>s in the GLTF file. These are the skins that the <see cref="Godot.GltfNode.Skin"/> index refers to.</para>
    /// </summary>
    public Godot.Collections.Array<GltfSkin> GetSkins()
    {
        return new Godot.Collections.Array<GltfSkin>(NativeCalls.godot_icall_0_112(MethodBind42, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind43 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSkins, 381264803ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.GltfSkin"/>s in the state. These are the skins that the <see cref="Godot.GltfNode.Skin"/> index refers to.</para>
    /// </summary>
    public void SetSkins(Godot.Collections.Array<GltfSkin> skins)
    {
        NativeCalls.godot_icall_1_130(MethodBind43, GodotObject.GetPtr(this), (godot_array)(skins ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind44 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCameras, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of all <see cref="Godot.GltfCamera"/>s in the GLTF file. These are the cameras that the <see cref="Godot.GltfNode.Camera"/> index refers to.</para>
    /// </summary>
    public Godot.Collections.Array<GltfCamera> GetCameras()
    {
        return new Godot.Collections.Array<GltfCamera>(NativeCalls.godot_icall_0_112(MethodBind44, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind45 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCameras, 381264803ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.GltfCamera"/>s in the state. These are the cameras that the <see cref="Godot.GltfNode.Camera"/> index refers to.</para>
    /// </summary>
    public void SetCameras(Godot.Collections.Array<GltfCamera> cameras)
    {
        NativeCalls.godot_icall_1_130(MethodBind45, GodotObject.GetPtr(this), (godot_array)(cameras ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind46 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLights, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of all <see cref="Godot.GltfLight"/>s in the GLTF file. These are the lights that the <see cref="Godot.GltfNode.Light"/> index refers to.</para>
    /// </summary>
    public Godot.Collections.Array<GltfLight> GetLights()
    {
        return new Godot.Collections.Array<GltfLight>(NativeCalls.godot_icall_0_112(MethodBind46, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind47 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLights, 381264803ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.GltfLight"/>s in the state. These are the lights that the <see cref="Godot.GltfNode.Light"/> index refers to.</para>
    /// </summary>
    public void SetLights(Godot.Collections.Array<GltfLight> lights)
    {
        NativeCalls.godot_icall_1_130(MethodBind47, GodotObject.GetPtr(this), (godot_array)(lights ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind48 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUniqueNames, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of unique node names. This is used in both the import process and export process.</para>
    /// </summary>
    public Godot.Collections.Array<string> GetUniqueNames()
    {
        return new Godot.Collections.Array<string>(NativeCalls.godot_icall_0_112(MethodBind48, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind49 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUniqueNames, 381264803ul);

    /// <summary>
    /// <para>Sets the unique node names in the state. This is used in both the import process and export process.</para>
    /// </summary>
    public void SetUniqueNames(Godot.Collections.Array<string> uniqueNames)
    {
        NativeCalls.godot_icall_1_130(MethodBind49, GodotObject.GetPtr(this), (godot_array)(uniqueNames ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind50 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUniqueAnimationNames, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of unique animation names. This is only used during the import process.</para>
    /// </summary>
    public Godot.Collections.Array<string> GetUniqueAnimationNames()
    {
        return new Godot.Collections.Array<string>(NativeCalls.godot_icall_0_112(MethodBind50, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind51 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUniqueAnimationNames, 381264803ul);

    /// <summary>
    /// <para>Sets the unique animation names in the state. This is only used during the import process.</para>
    /// </summary>
    public void SetUniqueAnimationNames(Godot.Collections.Array<string> uniqueAnimationNames)
    {
        NativeCalls.godot_icall_1_130(MethodBind51, GodotObject.GetPtr(this), (godot_array)(uniqueAnimationNames ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind52 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSkeletons, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of all <see cref="Godot.GltfSkeleton"/>s in the GLTF file. These are the skeletons that the <see cref="Godot.GltfNode.Skeleton"/> index refers to.</para>
    /// </summary>
    public Godot.Collections.Array<GltfSkeleton> GetSkeletons()
    {
        return new Godot.Collections.Array<GltfSkeleton>(NativeCalls.godot_icall_0_112(MethodBind52, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind53 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSkeletons, 381264803ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.GltfSkeleton"/>s in the state. These are the skeletons that the <see cref="Godot.GltfNode.Skeleton"/> index refers to.</para>
    /// </summary>
    public void SetSkeletons(Godot.Collections.Array<GltfSkeleton> skeletons)
    {
        NativeCalls.godot_icall_1_130(MethodBind53, GodotObject.GetPtr(this), (godot_array)(skeletons ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind54 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCreateAnimations, 2240911060ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetCreateAnimations()
    {
        return NativeCalls.godot_icall_0_40(MethodBind54, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind55 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCreateAnimations, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCreateAnimations(bool createAnimations)
    {
        NativeCalls.godot_icall_1_41(MethodBind55, GodotObject.GetPtr(this), createAnimations.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind56 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetImportAsSkeletonBones, 2240911060ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetImportAsSkeletonBones()
    {
        return NativeCalls.godot_icall_0_40(MethodBind56, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind57 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetImportAsSkeletonBones, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetImportAsSkeletonBones(bool importAsSkeletonBones)
    {
        NativeCalls.godot_icall_1_41(MethodBind57, GodotObject.GetPtr(this), importAsSkeletonBones.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind58 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAnimations, 2915620761ul);

    /// <summary>
    /// <para>Returns an array of all <see cref="Godot.GltfAnimation"/>s in the GLTF file. When importing, these will be generated as animations in an <see cref="Godot.AnimationPlayer"/> node. When exporting, these will be generated from Godot <see cref="Godot.AnimationPlayer"/> nodes.</para>
    /// </summary>
    public Godot.Collections.Array<GltfAnimation> GetAnimations()
    {
        return new Godot.Collections.Array<GltfAnimation>(NativeCalls.godot_icall_0_112(MethodBind58, GodotObject.GetPtr(this)));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind59 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAnimations, 381264803ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.GltfAnimation"/>s in the state. When importing, these will be generated as animations in an <see cref="Godot.AnimationPlayer"/> node. When exporting, these will be generated from Godot <see cref="Godot.AnimationPlayer"/> nodes.</para>
    /// </summary>
    public void SetAnimations(Godot.Collections.Array<GltfAnimation> animations)
    {
        NativeCalls.godot_icall_1_130(MethodBind59, GodotObject.GetPtr(this), (godot_array)(animations ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind60 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSceneNode, 4253421667ul);

    /// <summary>
    /// <para>Returns the Godot scene node that corresponds to the same index as the <see cref="Godot.GltfNode"/> it was generated from. This is the inverse of <see cref="Godot.GltfState.GetNodeIndex(Node)"/>. Useful during the import process.</para>
    /// <para><b>Note:</b> Not every <see cref="Godot.GltfNode"/> will have a scene node generated, and not every generated scene node will have a corresponding <see cref="Godot.GltfNode"/>. If there is no scene node for this <see cref="Godot.GltfNode"/> index, <see langword="null"/> is returned.</para>
    /// </summary>
    public Node GetSceneNode(int idx)
    {
        return (Node)NativeCalls.godot_icall_1_302(MethodBind60, GodotObject.GetPtr(this), idx);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind61 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNodeIndex, 1205807060ul);

    /// <summary>
    /// <para>Returns the index of the <see cref="Godot.GltfNode"/> corresponding to this Godot scene node. This is the inverse of <see cref="Godot.GltfState.GetSceneNode(int)"/>. Useful during the export process.</para>
    /// <para><b>Note:</b> Not every Godot scene node will have a corresponding <see cref="Godot.GltfNode"/>, and not every <see cref="Godot.GltfNode"/> will have a scene node generated. If there is no <see cref="Godot.GltfNode"/> index for this scene node, <c>-1</c> is returned.</para>
    /// </summary>
    public int GetNodeIndex(Node sceneNode)
    {
        return NativeCalls.godot_icall_1_338(MethodBind61, GodotObject.GetPtr(this), GodotObject.GetPtr(sceneNode));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind62 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAdditionalData, 2138907829ul);

    /// <summary>
    /// <para>Gets additional arbitrary data in this <see cref="Godot.GltfState"/> instance. This can be used to keep per-file state data in <see cref="Godot.GltfDocumentExtension"/> classes, which is important because they are stateless.</para>
    /// <para>The argument should be the <see cref="Godot.GltfDocumentExtension"/> name (does not have to match the extension name in the GLTF file), and the return value can be anything you set. If nothing was set, the return value is null.</para>
    /// </summary>
    public Variant GetAdditionalData(StringName extensionName)
    {
        return NativeCalls.godot_icall_1_135(MethodBind62, GodotObject.GetPtr(this), (godot_string_name)(extensionName?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind63 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAdditionalData, 3776071444ul);

    /// <summary>
    /// <para>Sets additional arbitrary data in this <see cref="Godot.GltfState"/> instance. This can be used to keep per-file state data in <see cref="Godot.GltfDocumentExtension"/> classes, which is important because they are stateless.</para>
    /// <para>The first argument should be the <see cref="Godot.GltfDocumentExtension"/> name (does not have to match the extension name in the GLTF file), and the second argument can be anything you want.</para>
    /// </summary>
    public void SetAdditionalData(StringName extensionName, Variant additionalData)
    {
        NativeCalls.godot_icall_2_134(MethodBind63, GodotObject.GetPtr(this), (godot_string_name)(extensionName?.NativeValue ?? default), additionalData);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind64 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetHandleBinaryImage, 2455072627ul);

    public int GetHandleBinaryImage()
    {
        return NativeCalls.godot_icall_0_37(MethodBind64, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind65 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetHandleBinaryImage, 1286410249ul);

    public void SetHandleBinaryImage(int method)
    {
        NativeCalls.godot_icall_1_36(MethodBind65, GodotObject.GetPtr(this), method);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind66 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBakeFps, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBakeFps(double value)
    {
        NativeCalls.godot_icall_1_120(MethodBind66, GodotObject.GetPtr(this), value);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind67 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBakeFps, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public double GetBakeFps()
    {
        return NativeCalls.godot_icall_0_136(MethodBind67, GodotObject.GetPtr(this));
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
    public new class PropertyName : Resource.PropertyName
    {
        /// <summary>
        /// Cached name for the 'json' property.
        /// </summary>
        public static readonly StringName Json = "json";
        /// <summary>
        /// Cached name for the 'major_version' property.
        /// </summary>
        public static readonly StringName MajorVersion = "major_version";
        /// <summary>
        /// Cached name for the 'minor_version' property.
        /// </summary>
        public static readonly StringName MinorVersion = "minor_version";
        /// <summary>
        /// Cached name for the 'copyright' property.
        /// </summary>
        public static readonly StringName Copyright = "copyright";
        /// <summary>
        /// Cached name for the 'glb_data' property.
        /// </summary>
        public static readonly StringName GlbData = "glb_data";
        /// <summary>
        /// Cached name for the 'use_named_skin_binds' property.
        /// </summary>
        public static readonly StringName UseNamedSkinBinds = "use_named_skin_binds";
        /// <summary>
        /// Cached name for the 'nodes' property.
        /// </summary>
        public static readonly StringName Nodes = "nodes";
        /// <summary>
        /// Cached name for the 'buffers' property.
        /// </summary>
        public static readonly StringName Buffers = "buffers";
        /// <summary>
        /// Cached name for the 'buffer_views' property.
        /// </summary>
        public static readonly StringName BufferViews = "buffer_views";
        /// <summary>
        /// Cached name for the 'accessors' property.
        /// </summary>
        public static readonly StringName Accessors = "accessors";
        /// <summary>
        /// Cached name for the 'meshes' property.
        /// </summary>
        public static readonly StringName Meshes = "meshes";
        /// <summary>
        /// Cached name for the 'materials' property.
        /// </summary>
        public static readonly StringName Materials = "materials";
        /// <summary>
        /// Cached name for the 'scene_name' property.
        /// </summary>
        public static readonly StringName SceneName = "scene_name";
        /// <summary>
        /// Cached name for the 'base_path' property.
        /// </summary>
        public static readonly StringName BasePath = "base_path";
        /// <summary>
        /// Cached name for the 'filename' property.
        /// </summary>
        public static readonly StringName FileName = "filename";
        /// <summary>
        /// Cached name for the 'root_nodes' property.
        /// </summary>
        public static readonly StringName RootNodes = "root_nodes";
        /// <summary>
        /// Cached name for the 'textures' property.
        /// </summary>
        public static readonly StringName Textures = "textures";
        /// <summary>
        /// Cached name for the 'texture_samplers' property.
        /// </summary>
        public static readonly StringName TextureSamplers = "texture_samplers";
        /// <summary>
        /// Cached name for the 'images' property.
        /// </summary>
        public static readonly StringName Images = "images";
        /// <summary>
        /// Cached name for the 'skins' property.
        /// </summary>
        public static readonly StringName Skins = "skins";
        /// <summary>
        /// Cached name for the 'cameras' property.
        /// </summary>
        public static readonly StringName Cameras = "cameras";
        /// <summary>
        /// Cached name for the 'lights' property.
        /// </summary>
        public static readonly StringName Lights = "lights";
        /// <summary>
        /// Cached name for the 'unique_names' property.
        /// </summary>
        public static readonly StringName UniqueNames = "unique_names";
        /// <summary>
        /// Cached name for the 'unique_animation_names' property.
        /// </summary>
        public static readonly StringName UniqueAnimationNames = "unique_animation_names";
        /// <summary>
        /// Cached name for the 'skeletons' property.
        /// </summary>
        public static readonly StringName Skeletons = "skeletons";
        /// <summary>
        /// Cached name for the 'create_animations' property.
        /// </summary>
        public static readonly StringName CreateAnimations = "create_animations";
        /// <summary>
        /// Cached name for the 'import_as_skeleton_bones' property.
        /// </summary>
        public static readonly StringName ImportAsSkeletonBones = "import_as_skeleton_bones";
        /// <summary>
        /// Cached name for the 'animations' property.
        /// </summary>
        public static readonly StringName Animations = "animations";
        /// <summary>
        /// Cached name for the 'handle_binary_image' property.
        /// </summary>
        public static readonly StringName HandleBinaryImage = "handle_binary_image";
        /// <summary>
        /// Cached name for the 'bake_fps' property.
        /// </summary>
        public static readonly StringName BakeFps = "bake_fps";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Resource.MethodName
    {
        /// <summary>
        /// Cached name for the 'add_used_extension' method.
        /// </summary>
        public static readonly StringName AddUsedExtension = "add_used_extension";
        /// <summary>
        /// Cached name for the 'append_data_to_buffers' method.
        /// </summary>
        public static readonly StringName AppendDataToBuffers = "append_data_to_buffers";
        /// <summary>
        /// Cached name for the 'get_json' method.
        /// </summary>
        public static readonly StringName GetJson = "get_json";
        /// <summary>
        /// Cached name for the 'set_json' method.
        /// </summary>
        public static readonly StringName SetJson = "set_json";
        /// <summary>
        /// Cached name for the 'get_major_version' method.
        /// </summary>
        public static readonly StringName GetMajorVersion = "get_major_version";
        /// <summary>
        /// Cached name for the 'set_major_version' method.
        /// </summary>
        public static readonly StringName SetMajorVersion = "set_major_version";
        /// <summary>
        /// Cached name for the 'get_minor_version' method.
        /// </summary>
        public static readonly StringName GetMinorVersion = "get_minor_version";
        /// <summary>
        /// Cached name for the 'set_minor_version' method.
        /// </summary>
        public static readonly StringName SetMinorVersion = "set_minor_version";
        /// <summary>
        /// Cached name for the 'get_copyright' method.
        /// </summary>
        public static readonly StringName GetCopyright = "get_copyright";
        /// <summary>
        /// Cached name for the 'set_copyright' method.
        /// </summary>
        public static readonly StringName SetCopyright = "set_copyright";
        /// <summary>
        /// Cached name for the 'get_glb_data' method.
        /// </summary>
        public static readonly StringName GetGlbData = "get_glb_data";
        /// <summary>
        /// Cached name for the 'set_glb_data' method.
        /// </summary>
        public static readonly StringName SetGlbData = "set_glb_data";
        /// <summary>
        /// Cached name for the 'get_use_named_skin_binds' method.
        /// </summary>
        public static readonly StringName GetUseNamedSkinBinds = "get_use_named_skin_binds";
        /// <summary>
        /// Cached name for the 'set_use_named_skin_binds' method.
        /// </summary>
        public static readonly StringName SetUseNamedSkinBinds = "set_use_named_skin_binds";
        /// <summary>
        /// Cached name for the 'get_nodes' method.
        /// </summary>
        public static readonly StringName GetNodes = "get_nodes";
        /// <summary>
        /// Cached name for the 'set_nodes' method.
        /// </summary>
        public static readonly StringName SetNodes = "set_nodes";
        /// <summary>
        /// Cached name for the 'get_buffers' method.
        /// </summary>
        public static readonly StringName GetBuffers = "get_buffers";
        /// <summary>
        /// Cached name for the 'set_buffers' method.
        /// </summary>
        public static readonly StringName SetBuffers = "set_buffers";
        /// <summary>
        /// Cached name for the 'get_buffer_views' method.
        /// </summary>
        public static readonly StringName GetBufferViews = "get_buffer_views";
        /// <summary>
        /// Cached name for the 'set_buffer_views' method.
        /// </summary>
        public static readonly StringName SetBufferViews = "set_buffer_views";
        /// <summary>
        /// Cached name for the 'get_accessors' method.
        /// </summary>
        public static readonly StringName GetAccessors = "get_accessors";
        /// <summary>
        /// Cached name for the 'set_accessors' method.
        /// </summary>
        public static readonly StringName SetAccessors = "set_accessors";
        /// <summary>
        /// Cached name for the 'get_meshes' method.
        /// </summary>
        public static readonly StringName GetMeshes = "get_meshes";
        /// <summary>
        /// Cached name for the 'set_meshes' method.
        /// </summary>
        public static readonly StringName SetMeshes = "set_meshes";
        /// <summary>
        /// Cached name for the 'get_animation_players_count' method.
        /// </summary>
        public static readonly StringName GetAnimationPlayersCount = "get_animation_players_count";
        /// <summary>
        /// Cached name for the 'get_animation_player' method.
        /// </summary>
        public static readonly StringName GetAnimationPlayer = "get_animation_player";
        /// <summary>
        /// Cached name for the 'get_materials' method.
        /// </summary>
        public static readonly StringName GetMaterials = "get_materials";
        /// <summary>
        /// Cached name for the 'set_materials' method.
        /// </summary>
        public static readonly StringName SetMaterials = "set_materials";
        /// <summary>
        /// Cached name for the 'get_scene_name' method.
        /// </summary>
        public static readonly StringName GetSceneName = "get_scene_name";
        /// <summary>
        /// Cached name for the 'set_scene_name' method.
        /// </summary>
        public static readonly StringName SetSceneName = "set_scene_name";
        /// <summary>
        /// Cached name for the 'get_base_path' method.
        /// </summary>
        public static readonly StringName GetBasePath = "get_base_path";
        /// <summary>
        /// Cached name for the 'set_base_path' method.
        /// </summary>
        public static readonly StringName SetBasePath = "set_base_path";
        /// <summary>
        /// Cached name for the 'get_filename' method.
        /// </summary>
        public static readonly StringName GetFileName = "get_filename";
        /// <summary>
        /// Cached name for the 'set_filename' method.
        /// </summary>
        public static readonly StringName SetFileName = "set_filename";
        /// <summary>
        /// Cached name for the 'get_root_nodes' method.
        /// </summary>
        public static readonly StringName GetRootNodes = "get_root_nodes";
        /// <summary>
        /// Cached name for the 'set_root_nodes' method.
        /// </summary>
        public static readonly StringName SetRootNodes = "set_root_nodes";
        /// <summary>
        /// Cached name for the 'get_textures' method.
        /// </summary>
        public static readonly StringName GetTextures = "get_textures";
        /// <summary>
        /// Cached name for the 'set_textures' method.
        /// </summary>
        public static readonly StringName SetTextures = "set_textures";
        /// <summary>
        /// Cached name for the 'get_texture_samplers' method.
        /// </summary>
        public static readonly StringName GetTextureSamplers = "get_texture_samplers";
        /// <summary>
        /// Cached name for the 'set_texture_samplers' method.
        /// </summary>
        public static readonly StringName SetTextureSamplers = "set_texture_samplers";
        /// <summary>
        /// Cached name for the 'get_images' method.
        /// </summary>
        public static readonly StringName GetImages = "get_images";
        /// <summary>
        /// Cached name for the 'set_images' method.
        /// </summary>
        public static readonly StringName SetImages = "set_images";
        /// <summary>
        /// Cached name for the 'get_skins' method.
        /// </summary>
        public static readonly StringName GetSkins = "get_skins";
        /// <summary>
        /// Cached name for the 'set_skins' method.
        /// </summary>
        public static readonly StringName SetSkins = "set_skins";
        /// <summary>
        /// Cached name for the 'get_cameras' method.
        /// </summary>
        public static readonly StringName GetCameras = "get_cameras";
        /// <summary>
        /// Cached name for the 'set_cameras' method.
        /// </summary>
        public static readonly StringName SetCameras = "set_cameras";
        /// <summary>
        /// Cached name for the 'get_lights' method.
        /// </summary>
        public static readonly StringName GetLights = "get_lights";
        /// <summary>
        /// Cached name for the 'set_lights' method.
        /// </summary>
        public static readonly StringName SetLights = "set_lights";
        /// <summary>
        /// Cached name for the 'get_unique_names' method.
        /// </summary>
        public static readonly StringName GetUniqueNames = "get_unique_names";
        /// <summary>
        /// Cached name for the 'set_unique_names' method.
        /// </summary>
        public static readonly StringName SetUniqueNames = "set_unique_names";
        /// <summary>
        /// Cached name for the 'get_unique_animation_names' method.
        /// </summary>
        public static readonly StringName GetUniqueAnimationNames = "get_unique_animation_names";
        /// <summary>
        /// Cached name for the 'set_unique_animation_names' method.
        /// </summary>
        public static readonly StringName SetUniqueAnimationNames = "set_unique_animation_names";
        /// <summary>
        /// Cached name for the 'get_skeletons' method.
        /// </summary>
        public static readonly StringName GetSkeletons = "get_skeletons";
        /// <summary>
        /// Cached name for the 'set_skeletons' method.
        /// </summary>
        public static readonly StringName SetSkeletons = "set_skeletons";
        /// <summary>
        /// Cached name for the 'get_create_animations' method.
        /// </summary>
        public static readonly StringName GetCreateAnimations = "get_create_animations";
        /// <summary>
        /// Cached name for the 'set_create_animations' method.
        /// </summary>
        public static readonly StringName SetCreateAnimations = "set_create_animations";
        /// <summary>
        /// Cached name for the 'get_import_as_skeleton_bones' method.
        /// </summary>
        public static readonly StringName GetImportAsSkeletonBones = "get_import_as_skeleton_bones";
        /// <summary>
        /// Cached name for the 'set_import_as_skeleton_bones' method.
        /// </summary>
        public static readonly StringName SetImportAsSkeletonBones = "set_import_as_skeleton_bones";
        /// <summary>
        /// Cached name for the 'get_animations' method.
        /// </summary>
        public static readonly StringName GetAnimations = "get_animations";
        /// <summary>
        /// Cached name for the 'set_animations' method.
        /// </summary>
        public static readonly StringName SetAnimations = "set_animations";
        /// <summary>
        /// Cached name for the 'get_scene_node' method.
        /// </summary>
        public static readonly StringName GetSceneNode = "get_scene_node";
        /// <summary>
        /// Cached name for the 'get_node_index' method.
        /// </summary>
        public static readonly StringName GetNodeIndex = "get_node_index";
        /// <summary>
        /// Cached name for the 'get_additional_data' method.
        /// </summary>
        public static readonly StringName GetAdditionalData = "get_additional_data";
        /// <summary>
        /// Cached name for the 'set_additional_data' method.
        /// </summary>
        public static readonly StringName SetAdditionalData = "set_additional_data";
        /// <summary>
        /// Cached name for the 'get_handle_binary_image' method.
        /// </summary>
        public static readonly StringName GetHandleBinaryImage = "get_handle_binary_image";
        /// <summary>
        /// Cached name for the 'set_handle_binary_image' method.
        /// </summary>
        public static readonly StringName SetHandleBinaryImage = "set_handle_binary_image";
        /// <summary>
        /// Cached name for the 'set_bake_fps' method.
        /// </summary>
        public static readonly StringName SetBakeFps = "set_bake_fps";
        /// <summary>
        /// Cached name for the 'get_bake_fps' method.
        /// </summary>
        public static readonly StringName GetBakeFps = "get_bake_fps";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Resource.SignalName
    {
    }
}

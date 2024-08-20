namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>GLTFDocument supports reading data from a glTF file, buffer, or Godot scene. This data can then be written to the filesystem, buffer, or used to create a Godot scene.</para>
/// <para>All of the data in a GLTF scene is stored in the <see cref="Godot.GltfState"/> class. GLTFDocument processes state objects, but does not contain any scene data itself. GLTFDocument has member variables to store export configuration settings such as the image format, but is otherwise stateless. Multiple scenes can be processed with the same settings using the same GLTFDocument object and different <see cref="Godot.GltfState"/> objects.</para>
/// <para>GLTFDocument can be extended with arbitrary functionality by extending the <see cref="Godot.GltfDocumentExtension"/> class and registering it with GLTFDocument via <see cref="Godot.GltfDocument.RegisterGltfDocumentExtension(GltfDocumentExtension, bool)"/>. This allows for custom data to be imported and exported.</para>
/// </summary>
[GodotClassName("GLTFDocument")]
public partial class GltfDocument : Resource
{
    public enum RootNodeModeEnum : long
    {
        /// <summary>
        /// <para>Treat the Godot scene's root node as the root node of the glTF file, and mark it as the single root node via the <c>GODOT_single_root</c> glTF extension. This will be parsed the same as <see cref="Godot.GltfDocument.RootNodeModeEnum.KeepRoot"/> if the implementation does not support <c>GODOT_single_root</c>.</para>
        /// </summary>
        SingleRoot = 0,
        /// <summary>
        /// <para>Treat the Godot scene's root node as the root node of the glTF file, but do not mark it as anything special. An extra root node will be generated when importing into Godot. This uses only vanilla glTF features. This is equivalent to the behavior in Godot 4.1 and earlier.</para>
        /// </summary>
        KeepRoot = 1,
        /// <summary>
        /// <para>Treat the Godot scene's root node as the name of the glTF scene, and add all of its children as root nodes of the glTF file. This uses only vanilla glTF features. This avoids an extra root node, but only the name of the Godot scene's root node will be preserved, as it will not be saved as a node.</para>
        /// </summary>
        MultiRoot = 2
    }

    /// <summary>
    /// <para>The user-friendly name of the export image format. This is used when exporting the GLTF file, including writing to a file and writing to a byte array.</para>
    /// <para>By default, Godot allows the following options: "None", "PNG", "JPEG", "Lossless WebP", and "Lossy WebP". Support for more image formats can be added in <see cref="Godot.GltfDocumentExtension"/> classes.</para>
    /// </summary>
    public string ImageFormat
    {
        get
        {
            return GetImageFormat();
        }
        set
        {
            SetImageFormat(value);
        }
    }

    /// <summary>
    /// <para>If <see cref="Godot.GltfDocument.ImageFormat"/> is a lossy image format, this determines the lossy quality of the image. On a range of <c>0.0</c> to <c>1.0</c>, where <c>0.0</c> is the lowest quality and <c>1.0</c> is the highest quality. A lossy quality of <c>1.0</c> is not the same as lossless.</para>
    /// </summary>
    public float LossyQuality
    {
        get
        {
            return GetLossyQuality();
        }
        set
        {
            SetLossyQuality(value);
        }
    }

    /// <summary>
    /// <para>How to process the root node during export. See <see cref="Godot.GltfDocument.RootNodeModeEnum"/> for details. The default and recommended value is <see cref="Godot.GltfDocument.RootNodeModeEnum.SingleRoot"/>.</para>
    /// <para><b>Note:</b> Regardless of how the glTF file is exported, when importing, the root node type and name can be overridden in the scene import settings tab.</para>
    /// </summary>
    public GltfDocument.RootNodeModeEnum RootNodeMode
    {
        get
        {
            return GetRootNodeMode();
        }
        set
        {
            SetRootNodeMode(value);
        }
    }

    private static readonly System.Type CachedType = typeof(GltfDocument);

    private static readonly StringName NativeName = "GLTFDocument";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public GltfDocument() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal GltfDocument(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetImageFormat, 83702148ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetImageFormat(string imageFormat)
    {
        NativeCalls.godot_icall_1_56(MethodBind0, GodotObject.GetPtr(this), imageFormat);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetImageFormat, 201670096ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string GetImageFormat()
    {
        return NativeCalls.godot_icall_0_57(MethodBind1, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLossyQuality, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetLossyQuality(float lossyQuality)
    {
        NativeCalls.godot_icall_1_62(MethodBind2, GodotObject.GetPtr(this), lossyQuality);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLossyQuality, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetLossyQuality()
    {
        return NativeCalls.godot_icall_0_63(MethodBind3, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRootNodeMode, 463633402ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRootNodeMode(GltfDocument.RootNodeModeEnum rootNodeMode)
    {
        NativeCalls.godot_icall_1_36(MethodBind4, GodotObject.GetPtr(this), (int)rootNodeMode);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRootNodeMode, 948057992ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public GltfDocument.RootNodeModeEnum GetRootNodeMode()
    {
        return (GltfDocument.RootNodeModeEnum)NativeCalls.godot_icall_0_37(MethodBind5, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AppendFromFile, 866380864ul);

    /// <summary>
    /// <para>Takes a path to a GLTF file and imports the data at that file path to the given <see cref="Godot.GltfState"/> object through the <paramref name="state"/> parameter.</para>
    /// <para><b>Note:</b> The <paramref name="basePath"/> tells <see cref="Godot.GltfDocument.AppendFromFile(string, GltfState, uint, string)"/> where to find dependencies and can be empty.</para>
    /// </summary>
    public Error AppendFromFile(string path, GltfState state, uint flags = (uint)(0), string basePath = "")
    {
        return (Error)NativeCalls.godot_icall_4_529(MethodBind6, GodotObject.GetPtr(this), path, GodotObject.GetPtr(state), flags, basePath);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AppendFromBuffer, 1616081266ul);

    /// <summary>
    /// <para>Takes a <see cref="byte"/>[] defining a GLTF and imports the data to the given <see cref="Godot.GltfState"/> object through the <paramref name="state"/> parameter.</para>
    /// <para><b>Note:</b> The <paramref name="basePath"/> tells <see cref="Godot.GltfDocument.AppendFromBuffer(byte[], string, GltfState, uint)"/> where to find dependencies and can be empty.</para>
    /// </summary>
    public Error AppendFromBuffer(byte[] bytes, string basePath, GltfState state, uint flags = (uint)(0))
    {
        return (Error)NativeCalls.godot_icall_4_530(MethodBind7, GodotObject.GetPtr(this), bytes, basePath, GodotObject.GetPtr(state), flags);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AppendFromScene, 1622574258ul);

    /// <summary>
    /// <para>Takes a Godot Engine scene node and exports it and its descendants to the given <see cref="Godot.GltfState"/> object through the <paramref name="state"/> parameter.</para>
    /// </summary>
    public Error AppendFromScene(Node node, GltfState state, uint flags = (uint)(0))
    {
        return (Error)NativeCalls.godot_icall_3_531(MethodBind8, GodotObject.GetPtr(this), GodotObject.GetPtr(node), GodotObject.GetPtr(state), flags);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GenerateScene, 596118388ul);

    /// <summary>
    /// <para>Takes a <see cref="Godot.GltfState"/> object through the <paramref name="state"/> parameter and returns a Godot Engine scene node.</para>
    /// <para>The <paramref name="bakeFps"/> parameter overrides the bake_fps in <paramref name="state"/>.</para>
    /// </summary>
    public Node GenerateScene(GltfState state, float bakeFps = (float)(30), bool trimming = false, bool removeImmutableTracks = true)
    {
        return (Node)NativeCalls.godot_icall_4_532(MethodBind9, GodotObject.GetPtr(this), GodotObject.GetPtr(state), bakeFps, trimming.ToGodotBool(), removeImmutableTracks.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GenerateBuffer, 741783455ul);

    /// <summary>
    /// <para>Takes a <see cref="Godot.GltfState"/> object through the <paramref name="state"/> parameter and returns a GLTF <see cref="byte"/>[].</para>
    /// </summary>
    public byte[] GenerateBuffer(GltfState state)
    {
        return NativeCalls.godot_icall_1_526(MethodBind10, GodotObject.GetPtr(this), GodotObject.GetPtr(state));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WriteToFilesystem, 1784551478ul);

    /// <summary>
    /// <para>Takes a <see cref="Godot.GltfState"/> object through the <paramref name="state"/> parameter and writes a glTF file to the filesystem.</para>
    /// <para><b>Note:</b> The extension of the glTF file determines if it is a .glb binary file or a .gltf text file.</para>
    /// </summary>
    public Error WriteToFilesystem(GltfState state, string path)
    {
        return (Error)NativeCalls.godot_icall_2_533(MethodBind11, GodotObject.GetPtr(this), GodotObject.GetPtr(state), path);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RegisterGltfDocumentExtension, 3752678331ul);

    /// <summary>
    /// <para>Registers the given <see cref="Godot.GltfDocumentExtension"/> instance with GLTFDocument. If <paramref name="firstPriority"/> is true, this extension will be run first. Otherwise, it will be run last.</para>
    /// <para><b>Note:</b> Like GLTFDocument itself, all GLTFDocumentExtension classes must be stateless in order to function properly. If you need to store data, use the <c>set_additional_data</c> and <c>get_additional_data</c> methods in <see cref="Godot.GltfState"/> or <see cref="Godot.GltfNode"/>.</para>
    /// </summary>
    public static void RegisterGltfDocumentExtension(GltfDocumentExtension extension, bool firstPriority = false)
    {
        NativeCalls.godot_icall_2_534(MethodBind12, GodotObject.GetPtr(extension), firstPriority.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.UnregisterGltfDocumentExtension, 2684415758ul);

    /// <summary>
    /// <para>Unregisters the given <see cref="Godot.GltfDocumentExtension"/> instance.</para>
    /// </summary>
    public static void UnregisterGltfDocumentExtension(GltfDocumentExtension extension)
    {
        NativeCalls.godot_icall_1_535(MethodBind13, GodotObject.GetPtr(extension));
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
        /// Cached name for the 'image_format' property.
        /// </summary>
        public static readonly StringName ImageFormat = "image_format";
        /// <summary>
        /// Cached name for the 'lossy_quality' property.
        /// </summary>
        public static readonly StringName LossyQuality = "lossy_quality";
        /// <summary>
        /// Cached name for the 'root_node_mode' property.
        /// </summary>
        public static readonly StringName RootNodeMode = "root_node_mode";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Resource.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_image_format' method.
        /// </summary>
        public static readonly StringName SetImageFormat = "set_image_format";
        /// <summary>
        /// Cached name for the 'get_image_format' method.
        /// </summary>
        public static readonly StringName GetImageFormat = "get_image_format";
        /// <summary>
        /// Cached name for the 'set_lossy_quality' method.
        /// </summary>
        public static readonly StringName SetLossyQuality = "set_lossy_quality";
        /// <summary>
        /// Cached name for the 'get_lossy_quality' method.
        /// </summary>
        public static readonly StringName GetLossyQuality = "get_lossy_quality";
        /// <summary>
        /// Cached name for the 'set_root_node_mode' method.
        /// </summary>
        public static readonly StringName SetRootNodeMode = "set_root_node_mode";
        /// <summary>
        /// Cached name for the 'get_root_node_mode' method.
        /// </summary>
        public static readonly StringName GetRootNodeMode = "get_root_node_mode";
        /// <summary>
        /// Cached name for the 'append_from_file' method.
        /// </summary>
        public static readonly StringName AppendFromFile = "append_from_file";
        /// <summary>
        /// Cached name for the 'append_from_buffer' method.
        /// </summary>
        public static readonly StringName AppendFromBuffer = "append_from_buffer";
        /// <summary>
        /// Cached name for the 'append_from_scene' method.
        /// </summary>
        public static readonly StringName AppendFromScene = "append_from_scene";
        /// <summary>
        /// Cached name for the 'generate_scene' method.
        /// </summary>
        public static readonly StringName GenerateScene = "generate_scene";
        /// <summary>
        /// Cached name for the 'generate_buffer' method.
        /// </summary>
        public static readonly StringName GenerateBuffer = "generate_buffer";
        /// <summary>
        /// Cached name for the 'write_to_filesystem' method.
        /// </summary>
        public static readonly StringName WriteToFilesystem = "write_to_filesystem";
        /// <summary>
        /// Cached name for the 'register_gltf_document_extension' method.
        /// </summary>
        public static readonly StringName RegisterGltfDocumentExtension = "register_gltf_document_extension";
        /// <summary>
        /// Cached name for the 'unregister_gltf_document_extension' method.
        /// </summary>
        public static readonly StringName UnregisterGltfDocumentExtension = "unregister_gltf_document_extension";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Resource.SignalName
    {
    }
}

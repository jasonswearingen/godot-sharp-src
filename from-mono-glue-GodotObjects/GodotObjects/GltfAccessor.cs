namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>GLTFAccessor is a data structure representing GLTF a <c>accessor</c> that would be found in the <c>"accessors"</c> array. A buffer is a blob of binary data. A buffer view is a slice of a buffer. An accessor is a typed interpretation of the data in a buffer view.</para>
/// <para>Most custom data stored in GLTF does not need accessors, only buffer views (see <see cref="Godot.GltfBufferView"/>). Accessors are for more advanced use cases such as interleaved mesh data encoded for the GPU.</para>
/// </summary>
[GodotClassName("GLTFAccessor")]
public partial class GltfAccessor : Resource
{
    public enum GltfAccessorType : long
    {
        /// <summary>
        /// <para>Accessor type "SCALAR". For the glTF object model, this can be used to map to a single float, int, or bool value, or a float array.</para>
        /// </summary>
        Scalar = 0,
        /// <summary>
        /// <para>Accessor type "VEC2". For the glTF object model, this maps to "float2", represented in the glTF JSON as an array of two floats.</para>
        /// </summary>
        Vec2 = 1,
        /// <summary>
        /// <para>Accessor type "VEC3". For the glTF object model, this maps to "float3", represented in the glTF JSON as an array of three floats.</para>
        /// </summary>
        Vec3 = 2,
        /// <summary>
        /// <para>Accessor type "VEC4". For the glTF object model, this maps to "float4", represented in the glTF JSON as an array of four floats.</para>
        /// </summary>
        Vec4 = 3,
        /// <summary>
        /// <para>Accessor type "MAT2". For the glTF object model, this maps to "float2x2", represented in the glTF JSON as an array of four floats.</para>
        /// </summary>
        Mat2 = 4,
        /// <summary>
        /// <para>Accessor type "MAT3". For the glTF object model, this maps to "float3x3", represented in the glTF JSON as an array of nine floats.</para>
        /// </summary>
        Mat3 = 5,
        /// <summary>
        /// <para>Accessor type "MAT4". For the glTF object model, this maps to "float4x4", represented in the glTF JSON as an array of sixteen floats.</para>
        /// </summary>
        Mat4 = 6
    }

    /// <summary>
    /// <para>The index of the buffer view this accessor is referencing. If <c>-1</c>, this accessor is not referencing any buffer view.</para>
    /// </summary>
    public int BufferView
    {
        get
        {
            return GetBufferView();
        }
        set
        {
            SetBufferView(value);
        }
    }

    /// <summary>
    /// <para>The offset relative to the start of the buffer view in bytes.</para>
    /// </summary>
    public int ByteOffset
    {
        get
        {
            return GetByteOffset();
        }
        set
        {
            SetByteOffset(value);
        }
    }

    /// <summary>
    /// <para>The GLTF component type as an enum. Possible values are 5120 for "BYTE", 5121 for "UNSIGNED_BYTE", 5122 for "SHORT", 5123 for "UNSIGNED_SHORT", 5125 for "UNSIGNED_INT", and 5126 for "FLOAT". A value of 5125 or "UNSIGNED_INT" must not be used for any accessor that is not referenced by mesh.primitive.indices.</para>
    /// </summary>
    public int ComponentType
    {
        get
        {
            return GetComponentType();
        }
        set
        {
            SetComponentType(value);
        }
    }

    /// <summary>
    /// <para>Specifies whether integer data values are normalized before usage.</para>
    /// </summary>
    public bool Normalized
    {
        get
        {
            return GetNormalized();
        }
        set
        {
            SetNormalized(value);
        }
    }

    /// <summary>
    /// <para>The number of elements referenced by this accessor.</para>
    /// </summary>
    public int Count
    {
        get
        {
            return GetCount();
        }
        set
        {
            SetCount(value);
        }
    }

    /// <summary>
    /// <para>The GLTF accessor type as an enum. Possible values are 0 for "SCALAR", 1 for "VEC2", 2 for "VEC3", 3 for "VEC4", 4 for "MAT2", 5 for "MAT3", and 6 for "MAT4".</para>
    /// </summary>
    public GltfAccessor.GltfAccessorType AccessorType
    {
        get
        {
            return GetAccessorType();
        }
        set
        {
            SetAccessorType(value);
        }
    }

    /// <summary>
    /// <para>The GLTF accessor type as an enum. Use <see cref="Godot.GltfAccessor.AccessorType"/> instead.</para>
    /// </summary>
    [Obsolete("Use 'Godot.GltfAccessor.AccessorType' instead.")]
    public int Type
    {
        get
        {
            return GetType();
        }
        set
        {
            SetType(value);
        }
    }

    /// <summary>
    /// <para>Minimum value of each component in this accessor.</para>
    /// </summary>
    public double[] Min
    {
        get
        {
            return GetMin();
        }
        set
        {
            SetMin(value);
        }
    }

    /// <summary>
    /// <para>Maximum value of each component in this accessor.</para>
    /// </summary>
    public double[] Max
    {
        get
        {
            return GetMax();
        }
        set
        {
            SetMax(value);
        }
    }

    /// <summary>
    /// <para>Number of deviating accessor values stored in the sparse array.</para>
    /// </summary>
    public int SparseCount
    {
        get
        {
            return GetSparseCount();
        }
        set
        {
            SetSparseCount(value);
        }
    }

    /// <summary>
    /// <para>The index of the buffer view with sparse indices. The referenced buffer view MUST NOT have its target or byteStride properties defined. The buffer view and the optional byteOffset MUST be aligned to the componentType byte length.</para>
    /// </summary>
    public int SparseIndicesBufferView
    {
        get
        {
            return GetSparseIndicesBufferView();
        }
        set
        {
            SetSparseIndicesBufferView(value);
        }
    }

    /// <summary>
    /// <para>The offset relative to the start of the buffer view in bytes.</para>
    /// </summary>
    public int SparseIndicesByteOffset
    {
        get
        {
            return GetSparseIndicesByteOffset();
        }
        set
        {
            SetSparseIndicesByteOffset(value);
        }
    }

    /// <summary>
    /// <para>The indices component data type as an enum. Possible values are 5121 for "UNSIGNED_BYTE", 5123 for "UNSIGNED_SHORT", and 5125 for "UNSIGNED_INT".</para>
    /// </summary>
    public int SparseIndicesComponentType
    {
        get
        {
            return GetSparseIndicesComponentType();
        }
        set
        {
            SetSparseIndicesComponentType(value);
        }
    }

    /// <summary>
    /// <para>The index of the bufferView with sparse values. The referenced buffer view MUST NOT have its target or byteStride properties defined.</para>
    /// </summary>
    public int SparseValuesBufferView
    {
        get
        {
            return GetSparseValuesBufferView();
        }
        set
        {
            SetSparseValuesBufferView(value);
        }
    }

    /// <summary>
    /// <para>The offset relative to the start of the bufferView in bytes.</para>
    /// </summary>
    public int SparseValuesByteOffset
    {
        get
        {
            return GetSparseValuesByteOffset();
        }
        set
        {
            SetSparseValuesByteOffset(value);
        }
    }

    private static readonly System.Type CachedType = typeof(GltfAccessor);

    private static readonly StringName NativeName = "GLTFAccessor";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public GltfAccessor() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal GltfAccessor(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetBufferView, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetBufferView()
    {
        return NativeCalls.godot_icall_0_37(MethodBind0, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetBufferView, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetBufferView(int bufferView)
    {
        NativeCalls.godot_icall_1_36(MethodBind1, GodotObject.GetPtr(this), bufferView);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetByteOffset, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetByteOffset()
    {
        return NativeCalls.godot_icall_0_37(MethodBind2, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetByteOffset, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetByteOffset(int byteOffset)
    {
        NativeCalls.godot_icall_1_36(MethodBind3, GodotObject.GetPtr(this), byteOffset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetComponentType, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetComponentType()
    {
        return NativeCalls.godot_icall_0_37(MethodBind4, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetComponentType, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetComponentType(int componentType)
    {
        NativeCalls.godot_icall_1_36(MethodBind5, GodotObject.GetPtr(this), componentType);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetNormalized, 2240911060ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetNormalized()
    {
        return NativeCalls.godot_icall_0_40(MethodBind6, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetNormalized, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetNormalized(bool normalized)
    {
        NativeCalls.godot_icall_1_41(MethodBind7, GodotObject.GetPtr(this), normalized.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCount, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetCount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind8, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetCount, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetCount(int count)
    {
        NativeCalls.godot_icall_1_36(MethodBind9, GodotObject.GetPtr(this), count);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAccessorType, 679305214ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public GltfAccessor.GltfAccessorType GetAccessorType()
    {
        return (GltfAccessor.GltfAccessorType)NativeCalls.godot_icall_0_37(MethodBind10, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAccessorType, 2347728198ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAccessorType(GltfAccessor.GltfAccessorType accessorType)
    {
        NativeCalls.godot_icall_1_36(MethodBind11, GodotObject.GetPtr(this), (int)accessorType);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetType, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetType()
    {
        return NativeCalls.godot_icall_0_37(MethodBind12, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetType, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetType(int type)
    {
        NativeCalls.godot_icall_1_36(MethodBind13, GodotObject.GetPtr(this), type);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMin, 148677866ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public double[] GetMin()
    {
        return NativeCalls.godot_icall_0_524(MethodBind14, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMin, 2576592201ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMin(double[] min)
    {
        NativeCalls.godot_icall_1_525(MethodBind15, GodotObject.GetPtr(this), min);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMax, 148677866ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public double[] GetMax()
    {
        return NativeCalls.godot_icall_0_524(MethodBind16, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetMax, 2576592201ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetMax(double[] max)
    {
        NativeCalls.godot_icall_1_525(MethodBind17, GodotObject.GetPtr(this), max);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSparseCount, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetSparseCount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind18, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSparseCount, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSparseCount(int sparseCount)
    {
        NativeCalls.godot_icall_1_36(MethodBind19, GodotObject.GetPtr(this), sparseCount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSparseIndicesBufferView, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetSparseIndicesBufferView()
    {
        return NativeCalls.godot_icall_0_37(MethodBind20, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSparseIndicesBufferView, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSparseIndicesBufferView(int sparseIndicesBufferView)
    {
        NativeCalls.godot_icall_1_36(MethodBind21, GodotObject.GetPtr(this), sparseIndicesBufferView);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSparseIndicesByteOffset, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetSparseIndicesByteOffset()
    {
        return NativeCalls.godot_icall_0_37(MethodBind22, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSparseIndicesByteOffset, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSparseIndicesByteOffset(int sparseIndicesByteOffset)
    {
        NativeCalls.godot_icall_1_36(MethodBind23, GodotObject.GetPtr(this), sparseIndicesByteOffset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSparseIndicesComponentType, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetSparseIndicesComponentType()
    {
        return NativeCalls.godot_icall_0_37(MethodBind24, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSparseIndicesComponentType, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSparseIndicesComponentType(int sparseIndicesComponentType)
    {
        NativeCalls.godot_icall_1_36(MethodBind25, GodotObject.GetPtr(this), sparseIndicesComponentType);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSparseValuesBufferView, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetSparseValuesBufferView()
    {
        return NativeCalls.godot_icall_0_37(MethodBind26, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSparseValuesBufferView, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSparseValuesBufferView(int sparseValuesBufferView)
    {
        NativeCalls.godot_icall_1_36(MethodBind27, GodotObject.GetPtr(this), sparseValuesBufferView);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSparseValuesByteOffset, 2455072627ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetSparseValuesByteOffset()
    {
        return NativeCalls.godot_icall_0_37(MethodBind28, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSparseValuesByteOffset, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSparseValuesByteOffset(int sparseValuesByteOffset)
    {
        NativeCalls.godot_icall_1_36(MethodBind29, GodotObject.GetPtr(this), sparseValuesByteOffset);
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
        /// Cached name for the 'buffer_view' property.
        /// </summary>
        public static readonly StringName BufferView = "buffer_view";
        /// <summary>
        /// Cached name for the 'byte_offset' property.
        /// </summary>
        public static readonly StringName ByteOffset = "byte_offset";
        /// <summary>
        /// Cached name for the 'component_type' property.
        /// </summary>
        public static readonly StringName ComponentType = "component_type";
        /// <summary>
        /// Cached name for the 'normalized' property.
        /// </summary>
        public static readonly StringName Normalized = "normalized";
        /// <summary>
        /// Cached name for the 'count' property.
        /// </summary>
        public static readonly StringName Count = "count";
        /// <summary>
        /// Cached name for the 'accessor_type' property.
        /// </summary>
        public static readonly StringName AccessorType = "accessor_type";
        /// <summary>
        /// Cached name for the 'type' property.
        /// </summary>
        public static readonly StringName Type = "type";
        /// <summary>
        /// Cached name for the 'min' property.
        /// </summary>
        public static readonly StringName Min = "min";
        /// <summary>
        /// Cached name for the 'max' property.
        /// </summary>
        public static readonly StringName Max = "max";
        /// <summary>
        /// Cached name for the 'sparse_count' property.
        /// </summary>
        public static readonly StringName SparseCount = "sparse_count";
        /// <summary>
        /// Cached name for the 'sparse_indices_buffer_view' property.
        /// </summary>
        public static readonly StringName SparseIndicesBufferView = "sparse_indices_buffer_view";
        /// <summary>
        /// Cached name for the 'sparse_indices_byte_offset' property.
        /// </summary>
        public static readonly StringName SparseIndicesByteOffset = "sparse_indices_byte_offset";
        /// <summary>
        /// Cached name for the 'sparse_indices_component_type' property.
        /// </summary>
        public static readonly StringName SparseIndicesComponentType = "sparse_indices_component_type";
        /// <summary>
        /// Cached name for the 'sparse_values_buffer_view' property.
        /// </summary>
        public static readonly StringName SparseValuesBufferView = "sparse_values_buffer_view";
        /// <summary>
        /// Cached name for the 'sparse_values_byte_offset' property.
        /// </summary>
        public static readonly StringName SparseValuesByteOffset = "sparse_values_byte_offset";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Resource.MethodName
    {
        /// <summary>
        /// Cached name for the 'get_buffer_view' method.
        /// </summary>
        public static readonly StringName GetBufferView = "get_buffer_view";
        /// <summary>
        /// Cached name for the 'set_buffer_view' method.
        /// </summary>
        public static readonly StringName SetBufferView = "set_buffer_view";
        /// <summary>
        /// Cached name for the 'get_byte_offset' method.
        /// </summary>
        public static readonly StringName GetByteOffset = "get_byte_offset";
        /// <summary>
        /// Cached name for the 'set_byte_offset' method.
        /// </summary>
        public static readonly StringName SetByteOffset = "set_byte_offset";
        /// <summary>
        /// Cached name for the 'get_component_type' method.
        /// </summary>
        public static readonly StringName GetComponentType = "get_component_type";
        /// <summary>
        /// Cached name for the 'set_component_type' method.
        /// </summary>
        public static readonly StringName SetComponentType = "set_component_type";
        /// <summary>
        /// Cached name for the 'get_normalized' method.
        /// </summary>
        public static readonly StringName GetNormalized = "get_normalized";
        /// <summary>
        /// Cached name for the 'set_normalized' method.
        /// </summary>
        public static readonly StringName SetNormalized = "set_normalized";
        /// <summary>
        /// Cached name for the 'get_count' method.
        /// </summary>
        public static readonly StringName GetCount = "get_count";
        /// <summary>
        /// Cached name for the 'set_count' method.
        /// </summary>
        public static readonly StringName SetCount = "set_count";
        /// <summary>
        /// Cached name for the 'get_accessor_type' method.
        /// </summary>
        public static readonly StringName GetAccessorType = "get_accessor_type";
        /// <summary>
        /// Cached name for the 'set_accessor_type' method.
        /// </summary>
        public static readonly StringName SetAccessorType = "set_accessor_type";
        /// <summary>
        /// Cached name for the 'get_type' method.
        /// </summary>
        public static readonly StringName GetType = "get_type";
        /// <summary>
        /// Cached name for the 'set_type' method.
        /// </summary>
        public static readonly StringName SetType = "set_type";
        /// <summary>
        /// Cached name for the 'get_min' method.
        /// </summary>
        public static readonly StringName GetMin = "get_min";
        /// <summary>
        /// Cached name for the 'set_min' method.
        /// </summary>
        public static readonly StringName SetMin = "set_min";
        /// <summary>
        /// Cached name for the 'get_max' method.
        /// </summary>
        public static readonly StringName GetMax = "get_max";
        /// <summary>
        /// Cached name for the 'set_max' method.
        /// </summary>
        public static readonly StringName SetMax = "set_max";
        /// <summary>
        /// Cached name for the 'get_sparse_count' method.
        /// </summary>
        public static readonly StringName GetSparseCount = "get_sparse_count";
        /// <summary>
        /// Cached name for the 'set_sparse_count' method.
        /// </summary>
        public static readonly StringName SetSparseCount = "set_sparse_count";
        /// <summary>
        /// Cached name for the 'get_sparse_indices_buffer_view' method.
        /// </summary>
        public static readonly StringName GetSparseIndicesBufferView = "get_sparse_indices_buffer_view";
        /// <summary>
        /// Cached name for the 'set_sparse_indices_buffer_view' method.
        /// </summary>
        public static readonly StringName SetSparseIndicesBufferView = "set_sparse_indices_buffer_view";
        /// <summary>
        /// Cached name for the 'get_sparse_indices_byte_offset' method.
        /// </summary>
        public static readonly StringName GetSparseIndicesByteOffset = "get_sparse_indices_byte_offset";
        /// <summary>
        /// Cached name for the 'set_sparse_indices_byte_offset' method.
        /// </summary>
        public static readonly StringName SetSparseIndicesByteOffset = "set_sparse_indices_byte_offset";
        /// <summary>
        /// Cached name for the 'get_sparse_indices_component_type' method.
        /// </summary>
        public static readonly StringName GetSparseIndicesComponentType = "get_sparse_indices_component_type";
        /// <summary>
        /// Cached name for the 'set_sparse_indices_component_type' method.
        /// </summary>
        public static readonly StringName SetSparseIndicesComponentType = "set_sparse_indices_component_type";
        /// <summary>
        /// Cached name for the 'get_sparse_values_buffer_view' method.
        /// </summary>
        public static readonly StringName GetSparseValuesBufferView = "get_sparse_values_buffer_view";
        /// <summary>
        /// Cached name for the 'set_sparse_values_buffer_view' method.
        /// </summary>
        public static readonly StringName SetSparseValuesBufferView = "set_sparse_values_buffer_view";
        /// <summary>
        /// Cached name for the 'get_sparse_values_byte_offset' method.
        /// </summary>
        public static readonly StringName GetSparseValuesByteOffset = "get_sparse_values_byte_offset";
        /// <summary>
        /// Cached name for the 'set_sparse_values_byte_offset' method.
        /// </summary>
        public static readonly StringName SetSparseValuesByteOffset = "set_sparse_values_byte_offset";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Resource.SignalName
    {
    }
}

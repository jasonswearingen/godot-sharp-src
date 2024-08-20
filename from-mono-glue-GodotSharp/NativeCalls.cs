namespace Godot;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Godot.NativeInterop;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "RedundantUnsafeContext")]
[SuppressMessage("ReSharper", "RedundantNameQualifier")]
[System.Runtime.CompilerServices.SkipLocalsInit]
internal static class NativeCalls
{
    internal static ulong godot_api_hash = 4070621931;

    private const int VarArgsSpanThreshold = 10;

    internal static unsafe int godot_icall_3_0(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, byte[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe byte[] godot_icall_1_1(IntPtr method, IntPtr ptr, byte[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe byte[] godot_icall_0_2(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_0_3(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, null);
    }

    internal static unsafe long godot_icall_0_4(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_5(IntPtr method, IntPtr ptr, long arg1, Vector2* arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_1_6(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_7(IntPtr method, IntPtr ptr, long arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_1_8(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe void godot_icall_2_9(IntPtr method, IntPtr ptr, long arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_10(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_1_11(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long[] godot_icall_1_12(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe long[] godot_icall_0_13(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_14(IntPtr method, IntPtr ptr, long arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_15(IntPtr method, IntPtr ptr, long arg1, long arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_3_16(IntPtr method, IntPtr ptr, long arg1, long arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_2_17(IntPtr method, IntPtr ptr, Vector2* arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2 godot_icall_1_18(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2[] godot_icall_3_19(IntPtr method, IntPtr ptr, long arg1, long arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe long[] godot_icall_3_20(IntPtr method, IntPtr ptr, long arg1, long arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe Vector2[] godot_icall_2_21(IntPtr method, IntPtr ptr, long arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe long[] godot_icall_2_22(IntPtr method, IntPtr ptr, long arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_3_23(IntPtr method, IntPtr ptr, long arg1, Vector3* arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector3 godot_icall_1_24(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_25(IntPtr method, IntPtr ptr, long arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe long godot_icall_2_26(IntPtr method, IntPtr ptr, Vector3* arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_1_27(IntPtr method, IntPtr ptr, Vector3* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3[] godot_icall_3_28(IntPtr method, IntPtr ptr, long arg1, long arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Vector3[] godot_icall_2_29(IntPtr method, IntPtr ptr, long arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_1_30(IntPtr method, IntPtr ptr, Rect2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rect2I godot_icall_0_31(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2I ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_32(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2I godot_icall_0_33(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_34(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_0_35(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_36(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_0_37(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return (int)(ret);
    }

    internal static unsafe godot_bool godot_icall_2_38(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_1_39(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_0_40(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_41(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_42(IntPtr method, IntPtr ptr, Vector2I* arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_43(IntPtr method, IntPtr ptr, Vector2I* arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_1_44(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe void godot_icall_2_45(IntPtr method, IntPtr ptr, Rect2I* arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_46(IntPtr method, IntPtr ptr, Rect2I* arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_1_47(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2[] godot_icall_3_48(IntPtr method, IntPtr ptr, Vector2I* arg1, Vector2I* arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[3] { arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_3_49(IntPtr method, IntPtr ptr, Vector2I* arg1, Vector2I* arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[3] { arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector2[] godot_icall_2_50(IntPtr method, IntPtr ptr, Vector2I* arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_51(IntPtr method, IntPtr ptr, Vector2I* arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_0_52(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe GodotObject godot_icall_3_53(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe GodotObject godot_icall_1_54(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_1_55(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_56(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string godot_icall_0_57(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe GodotObject godot_icall_0_58(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_1_59(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe StringName godot_icall_0_60(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_string_name ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_61(IntPtr method, IntPtr ptr, godot_string_name arg1, float arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_62(IntPtr method, IntPtr ptr, float arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_0_63(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return (float)ret;
    }

    internal static unsafe void godot_icall_2_64(IntPtr method, IntPtr ptr, int arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_65(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_1_66(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe float godot_icall_1_67(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe int godot_icall_2_68(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_1_69(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe NodePath godot_icall_1_70(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_node_path ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return NodePath.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_2_71(IntPtr method, IntPtr ptr, int arg1, godot_node_path arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_2_72(IntPtr method, IntPtr ptr, godot_node_path arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_73(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_74(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_1_75(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_3_76(IntPtr method, IntPtr ptr, int arg1, double arg2, Vector3* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_77(IntPtr method, IntPtr ptr, int arg1, double arg2, Quaternion* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_78(IntPtr method, IntPtr ptr, int arg1, double arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Vector3 godot_icall_3_79(IntPtr method, IntPtr ptr, int arg1, double arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Quaternion godot_icall_3_80(IntPtr method, IntPtr ptr, int arg1, double arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Quaternion ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe float godot_icall_3_81(IntPtr method, IntPtr ptr, int arg1, double arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe int godot_icall_4_82(IntPtr method, IntPtr ptr, int arg1, double arg2, Variant arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_83(IntPtr method, IntPtr ptr, int arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_84(IntPtr method, IntPtr ptr, int arg1, int arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_85(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_86(IntPtr method, IntPtr ptr, int arg1, int arg2, double arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_2_87(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe Variant godot_icall_2_88(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe double godot_icall_2_89(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_5_90(IntPtr method, IntPtr ptr, int arg1, double arg2, int arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3_in, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Variant godot_icall_3_91(IntPtr method, IntPtr ptr, int arg1, double arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe StringName godot_icall_2_92(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_string_name ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_93(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe int godot_icall_5_94(IntPtr method, IntPtr ptr, int arg1, double arg2, float arg3, Vector2* arg4, Vector2* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3_in, arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_4_95(IntPtr method, IntPtr ptr, int arg1, int arg2, Vector2* arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_2_96(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe float godot_icall_2_97(IntPtr method, IntPtr ptr, int arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe int godot_icall_5_98(IntPtr method, IntPtr ptr, int arg1, double arg2, IntPtr arg3, float arg4, float arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        double arg4_in = arg4;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_3_99(IntPtr method, IntPtr ptr, int arg1, int arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_2_100(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe int godot_icall_3_101(IntPtr method, IntPtr ptr, int arg1, double arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_3_102(IntPtr method, IntPtr ptr, int arg1, int arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_103(IntPtr method, IntPtr ptr, uint arg1, uint arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_3_104(IntPtr method, IntPtr ptr, int arg1, double arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Variant godot_icall_2_105(IntPtr method, IntPtr ptr, int arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector3 godot_icall_2_106(IntPtr method, IntPtr ptr, int arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Quaternion godot_icall_2_107(IntPtr method, IntPtr ptr, int arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Quaternion ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_2_108(IntPtr method, IntPtr ptr, godot_string_name arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_109(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_1_110(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_1_111(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe Godot.Collections.Array godot_icall_0_112(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_1_113(IntPtr method, IntPtr ptr, godot_dictionary arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_0_114(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe string[] godot_icall_0_115(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_1_116(IntPtr method, IntPtr ptr, godot_node_path arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe NodePath godot_icall_0_117(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_node_path ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return NodePath.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector3 godot_icall_0_118(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe Quaternion godot_icall_0_119(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Quaternion ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_120(IntPtr method, IntPtr ptr, double arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_121(IntPtr method, IntPtr ptr, godot_string_name arg1, double arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe StringName godot_icall_1_122(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_string_name ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Variant godot_icall_5_123(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, Variant arg3, IntPtr arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        long arg2_in = arg2;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3_in, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe godot_bool godot_icall_1_124(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_2_125(IntPtr method, IntPtr ptr, int arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe string godot_icall_1_126(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int godot_icall_1_127(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_128(IntPtr method, IntPtr ptr, godot_node_path arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_1_129(IntPtr method, IntPtr ptr, godot_node_path arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_130(IntPtr method, IntPtr ptr, godot_array arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_131(IntPtr method, IntPtr ptr, godot_string_name arg1, double arg2, double arg3, godot_bool arg4, godot_bool arg5, float arg6, int arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg6_in = arg6;
        long arg7_in = arg7;
        void** call_args = stackalloc void*[7] { &arg1, &arg2, &arg3, &arg4, &arg5, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe double godot_icall_9_132(IntPtr method, IntPtr ptr, godot_string_name arg1, IntPtr arg2, double arg3, godot_bool arg4, godot_bool arg5, float arg6, int arg7, godot_bool arg8, godot_bool arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        double arg6_in = arg6;
        long arg7_in = arg7;
        void** call_args = stackalloc void*[9] { &arg1, &arg2, &arg3, &arg4, &arg5, &arg6_in, &arg7_in, &arg8, &arg9 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe double godot_icall_8_133(IntPtr method, IntPtr ptr, int arg1, double arg2, godot_bool arg3, godot_bool arg4, float arg5, int arg6, godot_bool arg7, godot_bool arg8)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        double arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[8] { &arg1_in, &arg2, &arg3, &arg4, &arg5_in, &arg6_in, &arg7, &arg8 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_134(IntPtr method, IntPtr ptr, godot_string_name arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Variant godot_icall_1_135(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe double godot_icall_0_136(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_137(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_138(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_139(IntPtr method, IntPtr ptr, int arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_1_140(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_141(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_142(IntPtr method, IntPtr ptr, int[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int[] godot_icall_0_143(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_3_144(IntPtr method, IntPtr ptr, godot_string_name arg1, IntPtr arg2, Vector2* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_145(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_146(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_147(IntPtr method, IntPtr ptr, godot_string_name arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_1_148(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_149(IntPtr method, IntPtr ptr, godot_string_name arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_2_150(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_151(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe StringName godot_icall_1_152(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_string_name ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_2_153(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe StringName godot_icall_1_154(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_string_name ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_155(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, double arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe double godot_icall_2_156(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_157(IntPtr method, IntPtr ptr, godot_string_name arg1, double arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_158(IntPtr method, IntPtr ptr, godot_string_name arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_159(IntPtr method, IntPtr ptr, godot_string_name arg1, double arg2, double arg3, float arg4, godot_bool arg5, int arg6, int arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg4_in = arg4;
        long arg6_in = arg6;
        long arg7_in = arg7;
        void** call_args = stackalloc void*[7] { &arg1, &arg2, &arg3, &arg4_in, &arg5, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_160(IntPtr method, IntPtr ptr, double arg1, godot_bool arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_161(IntPtr method, IntPtr ptr, double arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_1_162(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_163(IntPtr method, IntPtr ptr, Vector3* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_164(IntPtr method, IntPtr ptr, int arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_165(IntPtr method, IntPtr ptr, int arg1, godot_array arg2, godot_array arg3, godot_dictionary arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_166(IntPtr method, IntPtr ptr, int arg1, int arg2, byte[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_167(IntPtr method, IntPtr ptr, int arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_2_168(IntPtr method, IntPtr ptr, Transform3D* arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_1_169(IntPtr method, IntPtr ptr, Aabb* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Aabb godot_icall_0_170(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Aabb ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_171(IntPtr method, IntPtr ptr, string[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_172(IntPtr method, IntPtr ptr, Vector3[] arg1, int[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        using godot_packed_int32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_173(IntPtr method, IntPtr ptr, Vector3[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_174(IntPtr method, IntPtr ptr, Rect2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rect2 godot_icall_0_175(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe Vector2[] godot_icall_1_176(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Vector2 godot_icall_3_177(IntPtr method, IntPtr ptr, float arg1, float arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        double arg1_in = arg1;
        double arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Transform3D godot_icall_0_178(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform3D ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_1_179(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_3_180(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_3_181(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_3_182(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_183(IntPtr method, IntPtr ptr, int arg1, int arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_1_184(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_1_185(IntPtr method, IntPtr ptr, Vector2[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_9_186(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, int arg5, float arg6, godot_bool arg7, int arg8, godot_bool arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        double arg6_in = arg6;
        long arg8_in = arg8;
        void** call_args = stackalloc void*[9] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7, &arg8_in, &arg9 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_187(IntPtr method, IntPtr ptr, byte[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_1_188(IntPtr method, byte[] arg1)
    {
        using godot_ref ret = default;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_1_189(IntPtr method, string arg1)
    {
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe long godot_icall_6_190(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, float arg3, float arg4, int arg5, godot_string_name arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        double arg2_in = arg2;
        double arg3_in = arg3;
        double arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[6] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_4_191(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, float arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        double arg2_in = arg2;
        double arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_192(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe uint godot_icall_0_193(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return (uint)(ret);
    }

    internal static unsafe void godot_icall_3_194(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_195(IntPtr method, IntPtr ptr, Color* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Color godot_icall_0_196(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Color ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_197(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_198(IntPtr method, IntPtr ptr, int arg1, Rect2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_199(IntPtr method, IntPtr ptr, Rect2I* arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_1_200(IntPtr method, IntPtr ptr, Transform2D* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform2D godot_icall_0_201(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform2D ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_1_202(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_1_203(IntPtr method, IntPtr ptr, Vector2[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2[] godot_icall_0_204(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_1_205(IntPtr method, IntPtr ptr, Color[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_color_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Color[] godot_icall_0_206(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_color_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedColorArrayToSystemArray(ret);
    }

    internal static unsafe Vector3[] godot_icall_0_207(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Variant godot_icall_1_208(IntPtr method, IntPtr ptr, Variant[] arg1, godot_string_name caller)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        int vararg_length = arg1.Length;
        int total_length = 0 + vararg_length;
        Span<godot_variant.movable> varargs_span = vararg_length <= VarArgsSpanThreshold ?
            stackalloc godot_variant.movable[VarArgsSpanThreshold] :
            new godot_variant.movable[vararg_length];
        Span<IntPtr> call_args_span = total_length <= VarArgsSpanThreshold ?
            stackalloc IntPtr[VarArgsSpanThreshold] :
            new IntPtr[total_length];
        fixed (godot_variant.movable* varargs = &MemoryMarshal.GetReference(varargs_span))
        fixed (IntPtr* call_args = &MemoryMarshal.GetReference(call_args_span))
        {
            for (int i = 0; i < vararg_length; i++)
            {
                varargs[i] = arg1[i].NativeVar;
                call_args[0 + i] = new IntPtr(&varargs[i]);
            }
            godot_variant ret = NativeFuncs.godotsharp_method_bind_call(method, ptr, (godot_variant**)call_args, total_length, out godot_variant_call_error vcall_error);
            ExceptionUtils.DebugCheckCallError(caller, ptr, (godot_variant**)call_args, total_length, vcall_error);
            return Variant.CreateTakingOwnershipOfDisposableValue(ret);
        }
    }

    internal static unsafe GodotObject godot_icall_1_209(IntPtr method, IntPtr ptr, double arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe Vector3 godot_icall_1_210(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2 godot_icall_1_211(IntPtr method, IntPtr ptr, Vector3* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_1_212(IntPtr method, IntPtr ptr, Vector3* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_2_213(IntPtr method, IntPtr ptr, Vector2* arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_214(IntPtr method, IntPtr ptr, float arg1, float arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg1_in = arg1;
        double arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_215(IntPtr method, IntPtr ptr, float arg1, Vector2* arg2, float arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg1_in = arg1;
        double arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Projection godot_icall_0_216(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Projection ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_0_217(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_5_218(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Color* arg3, float arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg4_in = arg4;
        void** call_args = stackalloc void*[5] { arg1, arg2, arg3, &arg4_in, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_219(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Color* arg3, float arg4, float arg5, godot_bool arg6, godot_bool arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg4_in = arg4;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[7] { arg1, arg2, arg3, &arg4_in, &arg5_in, &arg6, &arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_220(IntPtr method, IntPtr ptr, Vector2[] arg1, Color* arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_221(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        using godot_packed_color_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg2);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_8_222(IntPtr method, IntPtr ptr, Vector2* arg1, float arg2, float arg3, float arg4, int arg5, Color* arg6, float arg7, godot_bool arg8)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        double arg3_in = arg3;
        double arg4_in = arg4;
        long arg5_in = arg5;
        double arg7_in = arg7;
        void** call_args = stackalloc void*[8] { arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, arg6, &arg7_in, &arg8 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_223(IntPtr method, IntPtr ptr, Rect2* arg1, Color* arg2, godot_bool arg3, float arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg4_in = arg4;
        void** call_args = stackalloc void*[5] { arg1, arg2, &arg3, &arg4_in, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_224(IntPtr method, IntPtr ptr, Vector2* arg1, float arg2, Color* arg3, godot_bool arg4, float arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[6] { arg1, &arg2_in, arg3, &arg4, &arg5_in, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_225(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2* arg2, Color* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_226(IntPtr method, IntPtr ptr, IntPtr arg1, Rect2* arg2, godot_bool arg3, Color* arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, arg2, &arg3, arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_227(IntPtr method, IntPtr ptr, IntPtr arg1, Rect2* arg2, Rect2* arg3, Color* arg4, godot_bool arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[6] { &arg1, arg2, arg3, arg4, &arg5, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_228(IntPtr method, IntPtr ptr, IntPtr arg1, Rect2* arg2, Rect2* arg3, Color* arg4, double arg5, double arg6, double arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[7] { &arg1, arg2, arg3, arg4, &arg5, &arg6, &arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_229(IntPtr method, IntPtr ptr, IntPtr arg1, Rect2* arg2, Rect2* arg3, Color* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_230(IntPtr method, IntPtr ptr, IntPtr arg1, Rect2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_231(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, Vector2[] arg3, IntPtr arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        using godot_packed_color_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg2);
        using godot_packed_vector2_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg3);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_232(IntPtr method, IntPtr ptr, Vector2[] arg1, Color* arg2, Vector2[] arg3, IntPtr arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        using godot_packed_vector2_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg3);
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_10_233(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2* arg2, string arg3, int arg4, float arg5, int arg6, Color* arg7, int arg8, int arg9, int arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        long arg8_in = arg8;
        long arg9_in = arg9;
        long arg10_in = arg10;
        void** call_args = stackalloc void*[10] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, arg7, &arg8_in, &arg9_in, &arg10_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_12_234(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2* arg2, string arg3, int arg4, float arg5, int arg6, int arg7, Color* arg8, int arg9, int arg10, int arg11, int arg12)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg9_in = arg9;
        long arg10_in = arg10;
        long arg11_in = arg11;
        long arg12_in = arg12;
        void** call_args = stackalloc void*[12] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, arg8, &arg9_in, &arg10_in, &arg11_in, &arg12_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_11_235(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2* arg2, string arg3, int arg4, float arg5, int arg6, int arg7, Color* arg8, int arg9, int arg10, int arg11)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg9_in = arg9;
        long arg10_in = arg10;
        long arg11_in = arg11;
        void** call_args = stackalloc void*[11] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, arg8, &arg9_in, &arg10_in, &arg11_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_13_236(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2* arg2, string arg3, int arg4, float arg5, int arg6, int arg7, int arg8, Color* arg9, int arg10, int arg11, int arg12, int arg13)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg8_in = arg8;
        long arg10_in = arg10;
        long arg11_in = arg11;
        long arg12_in = arg12;
        long arg13_in = arg13;
        void** call_args = stackalloc void*[13] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, arg9, &arg10_in, &arg11_in, &arg12_in, &arg13_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_237(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2* arg2, string arg3, int arg4, Color* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[5] { &arg1, arg2, &arg3_in, &arg4_in, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_238(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2* arg2, string arg3, int arg4, int arg5, Color* arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[6] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_239(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, Transform2D* arg3, Color* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_240(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_241(IntPtr method, IntPtr ptr, Vector2* arg1, float arg2, Vector2* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[3] { arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_242(IntPtr method, IntPtr ptr, double arg1, double arg2, double arg3, double arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_1_243(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_2_244(IntPtr method, IntPtr ptr, uint arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_1_245(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_246(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        using godot_packed_color_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg2);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_247(IntPtr method, IntPtr ptr, Vector2[] arg1, Color* arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_248(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Color* arg3, float arg4, float arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg4_in = arg4;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[6] { arg1, arg2, arg3, &arg4_in, &arg5_in, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_249(IntPtr method, IntPtr ptr, Rect2* arg1, Color* arg2, godot_bool arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { arg1, arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_250(IntPtr method, IntPtr ptr, Vector2* arg1, float arg2, Color* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[3] { arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe byte godot_icall_0_251(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return (byte)(ret);
    }

    internal static unsafe void godot_icall_1_252(IntPtr method, IntPtr ptr, byte arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe ushort godot_icall_0_253(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return (ushort)(ret);
    }

    internal static unsafe void godot_icall_1_254(IntPtr method, IntPtr ptr, ushort arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_255(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_1_256(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe float godot_icall_1_257(IntPtr method, IntPtr ptr, Vector3* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe string[] godot_icall_1_258(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_259(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_260(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Variant godot_icall_2_261(IntPtr method, IntPtr ptr, IntPtr arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe int godot_icall_3_262(IntPtr method, IntPtr ptr, IntPtr arg1, godot_string_name arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Variant godot_icall_2_263(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe godot_bool godot_icall_3_264(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_3_265(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe string[] godot_icall_2_266(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe long godot_icall_2_267(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe string[] godot_icall_3_268(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe StringName godot_icall_3_269(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_string_name ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_2_270(IntPtr method, IntPtr ptr, string arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string godot_icall_1_271(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe void godot_icall_3_272(IntPtr method, IntPtr ptr, string arg1, string arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_273(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3, Color* arg4, IntPtr arg5, Variant arg6, int arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        godot_variant arg6_in = (godot_variant)arg6.NativeVar;
        long arg7_in = arg7;
        void** call_args = stackalloc void*[7] { &arg1_in, &arg2_in, &arg3_in, arg4, &arg5, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_1_274(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe string godot_icall_2_275(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe void godot_icall_2_276(IntPtr method, IntPtr ptr, string arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Color godot_icall_1_277(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Color ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_278(IntPtr method, IntPtr ptr, string arg1, string arg2, Color* arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe uint godot_icall_1_279(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (uint)(ret);
    }

    internal static unsafe void godot_icall_2_280(IntPtr method, IntPtr ptr, uint arg1, Transform2D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform2D godot_icall_1_281(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform2D ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_1_282(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_2_283(IntPtr method, IntPtr ptr, uint arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_1_284(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe void godot_icall_2_285(IntPtr method, IntPtr ptr, uint arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_1_286(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_2_287(IntPtr method, IntPtr ptr, uint arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe int godot_icall_2_288(IntPtr method, IntPtr ptr, uint arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_289(IntPtr method, IntPtr ptr, uint arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe uint godot_icall_1_290(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (uint)(ret);
    }

    internal static unsafe void godot_icall_2_291(IntPtr method, IntPtr ptr, uint arg1, Transform3D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform3D godot_icall_1_292(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform3D ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_293(IntPtr method, IntPtr ptr, string arg1, string arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Variant godot_icall_3_294(IntPtr method, IntPtr ptr, string arg1, string arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe godot_bool godot_icall_2_295(IntPtr method, IntPtr ptr, string arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe string[] godot_icall_1_296(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe int godot_icall_2_297(IntPtr method, IntPtr ptr, string arg1, byte[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_298(IntPtr method, IntPtr ptr, string arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_4_299(IntPtr method, IntPtr ptr, int arg1, float arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_300(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_301(IntPtr method, IntPtr ptr, Vector2* arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_1_302(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_2_303(IntPtr method, IntPtr ptr, godot_string_name arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_2_304(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe int godot_icall_2_305(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Color godot_icall_2_306(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Color ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe string godot_icall_1_307(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int godot_icall_1_308(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_309(IntPtr method, IntPtr ptr, Variant arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_310(IntPtr method, IntPtr ptr, in Callable arg1, in Callable arg2, in Callable arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe byte[] godot_icall_1_311(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe GodotObject godot_icall_4_312(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, string arg3, string arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe byte[] godot_icall_3_313(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe godot_bool godot_icall_4_314(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, byte[] arg3, IntPtr arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe byte[] godot_icall_2_315(IntPtr method, IntPtr ptr, IntPtr arg1, byte[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe byte[] godot_icall_3_316(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, byte[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe godot_bool godot_icall_2_317(IntPtr method, IntPtr ptr, byte[] arg1, byte[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_2_318(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe string godot_icall_1_319(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int godot_icall_5_320(IntPtr method, IntPtr ptr, Vector2* arg1, float arg2, float arg3, int arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        double arg2_in = arg2;
        double arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_321(IntPtr method, IntPtr ptr, int arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe float godot_icall_1_322(IntPtr method, IntPtr ptr, float arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe void godot_icall_4_323(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Vector2* arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_2_324(IntPtr method, IntPtr ptr, int arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2 godot_icall_1_325(IntPtr method, IntPtr ptr, float arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2 godot_icall_2_326(IntPtr method, IntPtr ptr, float arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Transform2D godot_icall_2_327(IntPtr method, IntPtr ptr, float arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform2D ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2[] godot_icall_2_328(IntPtr method, IntPtr ptr, int arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        long arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_4_329(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, Vector3* arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_330(IntPtr method, IntPtr ptr, int arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector3 godot_icall_1_331(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_2_332(IntPtr method, IntPtr ptr, int arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        long arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_1_333(IntPtr method, IntPtr ptr, float arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_2_334(IntPtr method, IntPtr ptr, float arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Transform3D godot_icall_3_335(IntPtr method, IntPtr ptr, float arg1, godot_bool arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform3D ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe float[] godot_icall_0_336(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedFloat32ArrayToSystemArray(ret);
    }

    internal static unsafe Vector3[] godot_icall_2_337(IntPtr method, IntPtr ptr, int arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        long arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe int godot_icall_1_338(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_0_339(IntPtr method)
    {
        long ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, null, &ret);
        return (int)(ret);
    }

    internal static unsafe string[] godot_icall_1_340(IntPtr method, string arg1)
    {
        using godot_packed_string_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe string godot_icall_1_341(IntPtr method, int arg1)
    {
        using godot_string ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int godot_icall_1_342(IntPtr method, string arg1)
    {
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe godot_bool godot_icall_1_343(IntPtr method, string arg1)
    {
        godot_bool ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return ret;
    }

    internal static unsafe ulong godot_icall_0_344(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        ulong ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_3_345(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_346(IntPtr method, string arg1, string arg2, int arg3)
    {
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_347(IntPtr method, string arg1, string arg2)
    {
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_348(IntPtr method, IntPtr ptr, in Callable arg1, in Callable arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_349(IntPtr method, IntPtr ptr, string arg1, in Callable arg2, in Callable arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_4_350(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_7_351(IntPtr method, IntPtr ptr, string arg1, string arg2, in Callable arg3, in Callable arg4, Variant arg5, int arg6, int arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        using godot_callable arg4_in = Marshaling.ConvertCallableToNative(in arg4);
        godot_variant arg5_in = (godot_variant)arg5.NativeVar;
        long arg6_in = arg6;
        long arg7_in = arg7;
        void** call_args = stackalloc void*[7] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_8_352(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, string arg3, in Callable arg4, in Callable arg5, Variant arg6, int arg7, int arg8)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_callable arg4_in = Marshaling.ConvertCallableToNative(in arg4);
        using godot_callable arg5_in = Marshaling.ConvertCallableToNative(in arg5);
        godot_variant arg6_in = (godot_variant)arg6.NativeVar;
        long arg7_in = arg7;
        long arg8_in = arg8;
        void** call_args = stackalloc void*[8] { &arg1_in, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_9_353(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3, int arg4, in Callable arg5, in Callable arg6, Variant arg7, int arg8, int arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        long arg4_in = arg4;
        using godot_callable arg5_in = Marshaling.ConvertCallableToNative(in arg5);
        using godot_callable arg6_in = Marshaling.ConvertCallableToNative(in arg6);
        godot_variant arg7_in = (godot_variant)arg7.NativeVar;
        long arg8_in = arg8;
        long arg9_in = arg9;
        void** call_args = stackalloc void*[9] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_354(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_355(IntPtr method, IntPtr ptr, string arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe godot_bool godot_icall_2_356(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Callable godot_icall_2_357(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertCallableToManaged(in ret);
    }

    internal static unsafe Variant godot_icall_2_358(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe string godot_icall_2_359(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe GodotObject godot_icall_2_360(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_3_361(IntPtr method, IntPtr ptr, string arg1, int arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_362(IntPtr method, IntPtr ptr, string arg1, int arg2, in Callable arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_363(IntPtr method, IntPtr ptr, string arg1, int arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_364(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_365(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_366(IntPtr method, IntPtr ptr, string arg1, int arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_367(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_368(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3, float arg4, float arg5, int arg6, godot_bool arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        double arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[7] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_369(IntPtr method, IntPtr ptr, int arg1, in Callable arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_370(IntPtr method, IntPtr ptr, in Callable arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_1_371(IntPtr method, IntPtr ptr, Rect2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Vector2I godot_icall_1_372(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rect2I godot_icall_1_373(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2I ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Color godot_icall_1_374(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Color ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_1_375(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe long godot_icall_2_376(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2I godot_icall_2_377(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_378(IntPtr method, IntPtr ptr, Vector2[] arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_379(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_380(IntPtr method, IntPtr ptr, in Callable arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe ulong godot_icall_1_381(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        ulong ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_382(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector3I godot_icall_1_383(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3I ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_384(IntPtr method, IntPtr ptr, godot_bool arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_385(IntPtr method, IntPtr ptr, string arg1, Rect2* arg2, int arg3, int arg4, int arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1_in, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_386(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, Vector2* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_4_387(IntPtr method, IntPtr ptr, string arg1, string arg2, string[] arg3, in Callable arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_packed_string_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg3);
        using godot_callable arg4_in = Marshaling.ConvertCallableToNative(in arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_388(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3, in Callable arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_callable arg4_in = Marshaling.ConvertCallableToNative(in arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_7_389(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3, godot_bool arg4, int arg5, string[] arg6, in Callable arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg5_in = arg5;
        using godot_packed_string_array arg6_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg6);
        using godot_callable arg7_in = Marshaling.ConvertCallableToNative(in arg7);
        void** call_args = stackalloc void*[7] { &arg1_in, &arg2_in, &arg3_in, &arg4, &arg5_in, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_9_390(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3, string arg4, godot_bool arg5, int arg6, string[] arg7, godot_array arg8, in Callable arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        long arg6_in = arg6;
        using godot_packed_string_array arg7_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg7);
        using godot_callable arg9_in = Marshaling.ConvertCallableToNative(in arg9);
        void** call_args = stackalloc void*[9] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5, &arg6_in, &arg7_in, &arg8, &arg9_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_391(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, in Callable arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_392(IntPtr method, IntPtr ptr, int arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rect2 godot_icall_1_393(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_6_394(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_395(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_4_396(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_397(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_398(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_2_399(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe double godot_icall_1_400(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_401(IntPtr method, IntPtr ptr, string arg1, int arg2, byte[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_5_402(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_403(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_404(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_406(IntPtr method, IntPtr ptr, string arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string[] godot_icall_1_411(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_412(IntPtr method, IntPtr ptr, int arg1, string[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_413(IntPtr method, IntPtr ptr, string arg1, string[] arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_420(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_421(IntPtr method, IntPtr ptr, IntPtr arg1, Rect2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_422(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_423(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2I* arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_435(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_439(IntPtr method, IntPtr ptr, string arg1, in Callable arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_441(IntPtr method, IntPtr ptr, IntPtr arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_446(IntPtr method, IntPtr ptr, string arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Variant godot_icall_1_448(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_452(IntPtr method, IntPtr ptr, IntPtr arg1, godot_string_name arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_459(IntPtr method, IntPtr ptr, ulong arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_1_460(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_2_461(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_462(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_bool arg2, godot_array arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_463(IntPtr method, IntPtr ptr, godot_string_name arg1, in Callable arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_464(IntPtr method, IntPtr ptr, godot_bool arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_465(IntPtr method, IntPtr ptr, IntPtr arg1, godot_bool arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_2_466(IntPtr method, IntPtr ptr, int arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_2_467(IntPtr method, IntPtr ptr, string arg1, string[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Variant godot_icall_4_468(IntPtr method, IntPtr ptr, godot_array arg1, IntPtr arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_2_469(IntPtr method, string arg1, int arg2)
    {
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_3_470(IntPtr method, string arg1, int arg2, byte[] arg3)
    {
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_3_471(IntPtr method, string arg1, int arg2, string arg3)
    {
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_3_472(IntPtr method, string arg1, int arg2, int arg3)
    {
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe byte[] godot_icall_1_473(IntPtr method, string arg1)
    {
        using godot_packed_byte_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe string godot_icall_1_474(IntPtr method, string arg1)
    {
        using godot_string ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int godot_icall_1_475(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe byte[] godot_icall_1_476(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe Variant godot_icall_1_477(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_2_478(IntPtr method, IntPtr ptr, string[] arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_479(IntPtr method, IntPtr ptr, Variant arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe ulong godot_icall_1_480(IntPtr method, string arg1)
    {
        ulong ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_2_481(IntPtr method, string arg1, int arg2)
    {
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_482(IntPtr method, string arg1, godot_bool arg2)
    {
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Rid godot_icall_9_483(IntPtr method, IntPtr ptr, godot_dictionary arg1, int arg2, float arg3, Transform2D* arg4, int arg5, int arg6, int arg7, int arg8, float arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg2_in = arg2;
        double arg3_in = arg3;
        long arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg8_in = arg8;
        double arg9_in = arg9;
        void** call_args = stackalloc void*[9] { &arg1, &arg2_in, &arg3_in, arg4, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2 godot_icall_7_484(IntPtr method, IntPtr ptr, string arg1, int arg2, float arg3, int arg4, int arg5, int arg6, int arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        double arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        void** call_args = stackalloc void*[7] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2 godot_icall_9_485(IntPtr method, IntPtr ptr, string arg1, int arg2, float arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        double arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg8_in = arg8;
        long arg9_in = arg9;
        void** call_args = stackalloc void*[9] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_10_486(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, string arg3, int arg4, float arg5, int arg6, Color* arg7, int arg8, int arg9, int arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        long arg8_in = arg8;
        long arg9_in = arg9;
        long arg10_in = arg10;
        void** call_args = stackalloc void*[10] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, arg7, &arg8_in, &arg9_in, &arg10_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_12_487(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, string arg3, int arg4, float arg5, int arg6, int arg7, Color* arg8, int arg9, int arg10, int arg11, int arg12)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg9_in = arg9;
        long arg10_in = arg10;
        long arg11_in = arg11;
        long arg12_in = arg12;
        void** call_args = stackalloc void*[12] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, arg8, &arg9_in, &arg10_in, &arg11_in, &arg12_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_11_488(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, string arg3, int arg4, float arg5, int arg6, int arg7, Color* arg8, int arg9, int arg10, int arg11)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg9_in = arg9;
        long arg10_in = arg10;
        long arg11_in = arg11;
        void** call_args = stackalloc void*[11] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, arg8, &arg9_in, &arg10_in, &arg11_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_13_489(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, string arg3, int arg4, float arg5, int arg6, int arg7, int arg8, Color* arg9, int arg10, int arg11, int arg12, int arg13)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg8_in = arg8;
        long arg10_in = arg10;
        long arg11_in = arg11;
        long arg12_in = arg12;
        long arg13_in = arg13;
        void** call_args = stackalloc void*[13] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, arg9, &arg10_in, &arg11_in, &arg12_in, &arg13_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_2_490(IntPtr method, IntPtr ptr, long arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe float godot_icall_5_491(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, long arg3, int arg4, Color* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[5] { &arg1, arg2, &arg3, &arg4_in, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe float godot_icall_6_492(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, long arg3, int arg4, int arg5, Color* arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[6] { &arg1, arg2, &arg3, &arg4_in, &arg5_in, arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe Rid godot_icall_8_493(IntPtr method, IntPtr ptr, godot_dictionary arg1, int arg2, float arg3, Transform2D* arg4, int arg5, int arg6, int arg7, int arg8)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg2_in = arg2;
        double arg3_in = arg3;
        long arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg8_in = arg8;
        void** call_args = stackalloc void*[8] { &arg1, &arg2_in, &arg3_in, arg4, &arg5_in, &arg6_in, &arg7_in, &arg8_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_4_494(IntPtr method, IntPtr ptr, godot_dictionary arg1, int arg2, float arg3, Transform2D* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_495(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_496(IntPtr method, IntPtr ptr, int arg1, godot_dictionary arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_497(IntPtr method, IntPtr ptr, int arg1, Transform2D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform2D godot_icall_1_498(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform2D ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_499(IntPtr method, IntPtr ptr, int arg1, int arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_500(IntPtr method, IntPtr ptr, int arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe long godot_icall_1_501(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_2_502(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_3_503(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_504(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3, IntPtr arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_3_505(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_4_506(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3, int[] arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        using godot_packed_int32_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int[] godot_icall_3_507(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe int[] godot_icall_2_508(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_4_509(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_3_510(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_511(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_3_512(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_513(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3, Rect2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rect2 godot_icall_3_514(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_515(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_3_516(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_3_517(IntPtr method, IntPtr ptr, int arg1, int arg2, Vector2I* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_518(IntPtr method, IntPtr ptr, int arg1, int arg2, Vector2I* arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_3_519(IntPtr method, IntPtr ptr, int arg1, int arg2, Vector2I* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_520(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, long arg3, long arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_3_521(IntPtr method, IntPtr ptr, int arg1, long arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Rid godot_icall_3_522(IntPtr method, godot_array arg1, godot_array arg2, uint arg3)
    {
        Rid ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_1_523(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe double[] godot_icall_0_524(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float64_array ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertNativePackedFloat64ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_1_525(IntPtr method, IntPtr ptr, double[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float64_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedFloat64Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe byte[] godot_icall_1_526(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe GodotObject godot_icall_1_527(IntPtr method, IntPtr arg1)
    {
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_1_528(IntPtr method, godot_dictionary arg1)
    {
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe int godot_icall_4_529(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, uint arg3, string arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg3_in = arg3;
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_530(IntPtr method, IntPtr ptr, byte[] arg1, string arg2, IntPtr arg3, uint arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_531(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_4_532(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe int godot_icall_2_533(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_534(IntPtr method, IntPtr arg1, godot_bool arg2)
    {
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, null);
    }

    internal static unsafe void godot_icall_1_535(IntPtr method, IntPtr arg1)
    {
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, null);
    }

    internal static unsafe void godot_icall_1_536(IntPtr method, IntPtr ptr, float[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_537(IntPtr method, IntPtr ptr, Transform3D* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_538(IntPtr method, IntPtr ptr, Quaternion* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Basis godot_icall_0_539(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Basis ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_540(IntPtr method, IntPtr ptr, Basis* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_1_541(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe int godot_icall_2_542(IntPtr method, IntPtr ptr, byte[] arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_5_543(IntPtr method, IntPtr ptr, Transform2D* arg1, Vector2* arg2, Color* arg3, Color* arg4, uint arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { arg1, arg2, arg3, arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_544(IntPtr method, IntPtr ptr, Transform3D* arg1, Vector3* arg2, Color* arg3, Color* arg4, uint arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { arg1, arg2, arg3, arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_3_545(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { arg1, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe float godot_icall_4_546(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Vector2* arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe Variant godot_icall_4_547(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Vector2* arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector2[] godot_icall_4_548(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Vector2* arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Vector2 godot_icall_3_549(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Vector2* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[3] { arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_4_550(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2, Vector2* arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_2_551(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int[] godot_icall_1_552(IntPtr method, IntPtr ptr, Vector2[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe Vector2[] godot_icall_1_553(IntPtr method, IntPtr ptr, Vector2[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_554(IntPtr method, IntPtr ptr, Vector2[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_555(IntPtr method, IntPtr ptr, Vector2[] arg1, Vector2[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_3_556(IntPtr method, IntPtr ptr, Vector2[] arg1, float arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        double arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_4_557(IntPtr method, IntPtr ptr, Vector2[] arg1, float arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        double arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_1_558(IntPtr method, IntPtr ptr, Vector2[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector3[] godot_icall_1_559(IntPtr method, IntPtr ptr, godot_array arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_560(IntPtr method, IntPtr ptr, Vector3* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_4_561(IntPtr method, IntPtr ptr, float arg1, float arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        double arg1_in = arg1;
        double arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_5_562(IntPtr method, IntPtr ptr, float arg1, float arg2, int arg3, int arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        double arg1_in = arg1;
        double arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector3[] godot_icall_4_563(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, Vector3* arg3, Vector3* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Vector3 godot_icall_3_564(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, Vector3* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[3] { arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_4_565(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, Vector3* arg3, Vector3* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Variant godot_icall_5_566(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, Vector3* arg3, Vector3* arg4, Vector3* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[5] { arg1, arg2, arg3, arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector3[] godot_icall_4_567(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, Vector3* arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Vector3[] godot_icall_4_568(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, float arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        double arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { arg1, arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Vector3[] godot_icall_3_569(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, godot_array arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        void** call_args = stackalloc void*[3] { arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Vector3[] godot_icall_2_570(IntPtr method, IntPtr ptr, Vector3[] arg1, Plane* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe int[] godot_icall_1_571(IntPtr method, IntPtr ptr, Vector3[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_572(IntPtr method, IntPtr ptr, float arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_573(IntPtr method, IntPtr ptr, int arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Color godot_icall_1_574(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Color ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Color godot_icall_1_575(IntPtr method, IntPtr ptr, float arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Color ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_4_576(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2, godot_string_name arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe godot_bool godot_icall_4_577(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2, godot_string_name arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg2_in = arg2;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_578(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2, godot_string_name arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_579(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2, godot_string_name arg3, int arg4, float arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg4_in = arg4;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_580(IntPtr method, IntPtr ptr, Vector2* arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_581(IntPtr method, IntPtr ptr, Rect2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector2[] godot_icall_2_582(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_583(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_10_584(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2, int arg3, Color* arg4, godot_bool arg5, int arg6, Color* arg7, IntPtr arg8, IntPtr arg9, godot_bool arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[10] { &arg1_in, &arg2, &arg3_in, arg4, &arg5, &arg6_in, arg7, &arg8, &arg9, &arg10 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_585(IntPtr method, IntPtr ptr, Vector3I* arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_1_586(IntPtr method, IntPtr ptr, Vector3I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Basis godot_icall_1_587(IntPtr method, IntPtr ptr, Vector3I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Basis ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Basis godot_icall_1_588(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Basis ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_1_589(IntPtr method, IntPtr ptr, Basis* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Vector3I godot_icall_1_590(IntPtr method, IntPtr ptr, Vector3* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3I ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_1_591(IntPtr method, IntPtr ptr, Vector3I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_1_592(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_593(IntPtr method, IntPtr ptr, godot_bool arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_2_594(IntPtr method, IntPtr ptr, int arg1, byte[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_1_595(IntPtr method, IntPtr ptr, byte[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_596(IntPtr method, IntPtr ptr, string arg1, int arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_597(IntPtr method, IntPtr ptr, int arg1, string arg2, string[] arg3, byte[] arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_packed_string_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg3);
        using godot_packed_byte_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_598(IntPtr method, IntPtr ptr, int arg1, string arg2, string[] arg3, string arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_packed_string_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg3);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe string godot_icall_1_599(IntPtr method, IntPtr ptr, godot_dictionary arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int godot_icall_4_600(IntPtr method, IntPtr ptr, string arg1, string[] arg2, int arg3, string arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        long arg3_in = arg3;
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_601(IntPtr method, IntPtr ptr, string arg1, string[] arg2, int arg3, byte[] arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        long arg3_in = arg3;
        using godot_packed_byte_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_3_602(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string[] godot_icall_2_603(IntPtr method, IntPtr ptr, string arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe int godot_icall_1_604(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_4_605(IntPtr method, int arg1, int arg2, godot_bool arg3, int arg4)
    {
        using godot_ref ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_5_606(IntPtr method, int arg1, int arg2, godot_bool arg3, int arg4, byte[] arg5)
    {
        using godot_ref ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg4_in = arg4;
        using godot_packed_byte_array arg5_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg5);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_5_607(IntPtr method, IntPtr ptr, int arg1, int arg2, godot_bool arg3, int arg4, byte[] arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg4_in = arg4;
        using godot_packed_byte_array arg5_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg5);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_2_608(IntPtr method, IntPtr ptr, string arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe byte[] godot_icall_1_609(IntPtr method, IntPtr ptr, float arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe byte[] godot_icall_1_610(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe int godot_icall_3_611(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe byte[] godot_icall_2_612(IntPtr method, IntPtr ptr, godot_bool arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe int godot_icall_3_613(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_614(IntPtr method, IntPtr ptr, IntPtr arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_615(IntPtr method, IntPtr ptr, IntPtr arg1, Rect2I* arg2, Vector2I* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_616(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, Rect2I* arg3, Vector2I* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_617(IntPtr method, IntPtr ptr, Rect2I* arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_1_618(IntPtr method, IntPtr ptr, Rect2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe Color godot_icall_2_619(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Color ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_620(IntPtr method, IntPtr ptr, Vector2I* arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_621(IntPtr method, IntPtr ptr, int arg1, int arg2, Color* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_2_622(IntPtr method, IntPtr ptr, byte[] arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_6_623(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, godot_bool arg5, godot_array arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_1_624(IntPtr method, IntPtr ptr, godot_array arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_625(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_626(IntPtr method, IntPtr ptr, Plane* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_627(IntPtr method, IntPtr ptr, int arg1, godot_array arg2, godot_array arg3, godot_dictionary arg4, IntPtr arg5, string arg6, ulong arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_string arg6_in = Marshaling.ConvertStringToNative(arg6);
        void** call_args = stackalloc void*[7] { &arg1_in, &arg2, &arg3, &arg4, &arg5, &arg6_in, &arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int[] godot_icall_2_628(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_3_629(IntPtr method, IntPtr ptr, float arg1, float arg2, godot_array arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_2_630(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe float godot_icall_2_631(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe float godot_icall_2_632(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe Vector2 godot_icall_5_633(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, godot_string_name arg3, godot_string_name arg4, float arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2, &arg3, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_634(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg2_in = arg2;
        double arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_635(IntPtr method, IntPtr ptr, godot_string_name arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_3_636(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_bool arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_2_637(IntPtr method, IntPtr ptr, IntPtr arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_2_638(IntPtr method, IntPtr ptr, Transform2D* arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe float godot_icall_1_639(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe godot_bool godot_icall_2_640(IntPtr method, IntPtr ptr, godot_string_name arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_3_641(IntPtr method, IntPtr ptr, IntPtr arg1, godot_string_name arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_1_642(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_2_643(IntPtr method, IntPtr ptr, godot_bool arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe int godot_icall_3_644(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_645(IntPtr method, IntPtr ptr, IntPtr arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_646(IntPtr method, IntPtr ptr, int arg1, Rect2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_647(IntPtr method, IntPtr ptr, int arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Variant godot_icall_1_648(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Rect2 godot_icall_2_649(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_2_650(IntPtr method, IntPtr ptr, Vector2* arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe string godot_icall_4_651(IntPtr method, Variant arg1, string arg2, godot_bool arg3, godot_bool arg4)
    {
        using godot_string ret = default;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe Variant godot_icall_1_652(IntPtr method, string arg1)
    {
        godot_variant ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Variant godot_icall_0_653(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_1_654(IntPtr method, IntPtr ptr, Variant arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Variant godot_icall_2_655(IntPtr method, IntPtr ptr, Variant arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_3_656(IntPtr method, IntPtr ptr, string arg1, Variant arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_657(IntPtr method, IntPtr ptr, Variant arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_658(IntPtr method, IntPtr ptr, string arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_3_659(IntPtr method, IntPtr ptr, int arg1, string arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Variant godot_icall_2_660(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_1_661(IntPtr method, IntPtr ptr, in Callable arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe Variant godot_icall_2_662(IntPtr method, IntPtr ptr, string arg1, Variant[] arg2, godot_string_name caller)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        int vararg_length = arg2.Length;
        int total_length = 1 + vararg_length;
        Span<godot_variant.movable> varargs_span = vararg_length <= VarArgsSpanThreshold ?
            stackalloc godot_variant.movable[VarArgsSpanThreshold] :
            new godot_variant.movable[vararg_length];
        Span<IntPtr> call_args_span = total_length <= VarArgsSpanThreshold ?
            stackalloc IntPtr[VarArgsSpanThreshold] :
            new IntPtr[total_length];
        fixed (godot_variant.movable* varargs = &MemoryMarshal.GetReference(varargs_span))
        fixed (IntPtr* call_args = &MemoryMarshal.GetReference(call_args_span))
        {
            using godot_variant arg1_in = VariantUtils.CreateFromString(arg1);
            call_args[0] = new IntPtr(&arg1_in);
            for (int i = 0; i < vararg_length; i++)
            {
                varargs[i] = arg2[i].NativeVar;
                call_args[1 + i] = new IntPtr(&varargs[i]);
            }
            godot_variant ret = NativeFuncs.godotsharp_method_bind_call(method, ptr, (godot_variant**)call_args, total_length, out godot_variant_call_error vcall_error);
            ExceptionUtils.DebugCheckCallError(caller, ptr, (godot_variant**)call_args, total_length, vcall_error);
            return Variant.CreateTakingOwnershipOfDisposableValue(ret);
        }
    }

    internal static unsafe void godot_icall_3_663(IntPtr method, IntPtr ptr, byte[] arg1, string arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_2_664(IntPtr method, IntPtr ptr, int arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe void godot_icall_4_665(IntPtr method, IntPtr ptr, godot_node_path arg1, Rect2* arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_666(IntPtr method, IntPtr ptr, Vector2* arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string godot_icall_2_667(IntPtr method, IntPtr ptr, Variant arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe string godot_icall_1_668(IntPtr method, IntPtr ptr, byte[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe byte[] godot_icall_1_669(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe GodotObject godot_icall_2_670(IntPtr method, IntPtr ptr, godot_bool arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_1_671(IntPtr method, IntPtr ptr, float arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe int godot_icall_2_672(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_673(IntPtr method, IntPtr ptr, IntPtr arg1, ulong arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_674(IntPtr method, IntPtr ptr, int arg1, Plane* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Plane godot_icall_1_675(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Plane ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_676(IntPtr method, IntPtr ptr, int arg1, int[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_packed_int32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int[] godot_icall_1_677(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_678(IntPtr method, IntPtr ptr, int arg1, float[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_packed_float32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float[] godot_icall_1_679(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedFloat32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_680(IntPtr method, IntPtr ptr, int arg1, Transform3D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_681(IntPtr method, IntPtr ptr, int arg1, uint arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_682(IntPtr method, IntPtr ptr, int arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform3D godot_icall_1_683(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform3D ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_4_684(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, godot_string_name arg3, godot_array arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_685(IntPtr method, IntPtr ptr, IntPtr arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_1_686(IntPtr method, godot_string_name arg1)
    {
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, null);
    }

    internal static unsafe StringName godot_icall_0_687(IntPtr method)
    {
        godot_string_name ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, null, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_0_688(IntPtr method)
    {
        using godot_ref ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, null, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_1_689(IntPtr method, IntPtr ptr, Variant arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe Callable godot_icall_0_690(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return Marshaling.ConvertCallableToManaged(in ret);
    }

    internal static unsafe godot_bool godot_icall_1_691(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2 godot_icall_1_692(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_693(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_694(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_695(IntPtr method, IntPtr ptr, Rid arg1, in Callable arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Callable godot_icall_1_696(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertCallableToManaged(in ret);
    }

    internal static unsafe void godot_icall_2_697(IntPtr method, IntPtr ptr, Rid arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_1_698(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe int godot_icall_5_699(IntPtr method, IntPtr ptr, Rid arg1, string arg2, Rid arg3, Variant arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        godot_variant arg4_in = (godot_variant)arg4.NativeVar;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_7_700(IntPtr method, IntPtr ptr, Rid arg1, string arg2, in Callable arg3, in Callable arg4, Variant arg5, int arg6, int arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        using godot_callable arg4_in = Marshaling.ConvertCallableToNative(in arg4);
        godot_variant arg5_in = (godot_variant)arg5.NativeVar;
        long arg6_in = arg6;
        long arg7_in = arg7;
        void** call_args = stackalloc void*[7] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_8_701(IntPtr method, IntPtr ptr, Rid arg1, IntPtr arg2, string arg3, in Callable arg4, in Callable arg5, Variant arg6, int arg7, int arg8)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_callable arg4_in = Marshaling.ConvertCallableToNative(in arg4);
        using godot_callable arg5_in = Marshaling.ConvertCallableToNative(in arg5);
        godot_variant arg6_in = (godot_variant)arg6.NativeVar;
        long arg7_in = arg7;
        long arg8_in = arg8;
        void** call_args = stackalloc void*[8] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_9_702(IntPtr method, IntPtr ptr, Rid arg1, string arg2, int arg3, int arg4, in Callable arg5, in Callable arg6, Variant arg7, int arg8, int arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        long arg4_in = arg4;
        using godot_callable arg5_in = Marshaling.ConvertCallableToNative(in arg5);
        using godot_callable arg6_in = Marshaling.ConvertCallableToNative(in arg6);
        godot_variant arg7_in = (godot_variant)arg7.NativeVar;
        long arg8_in = arg8;
        long arg9_in = arg9;
        void** call_args = stackalloc void*[9] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_703(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_704(IntPtr method, IntPtr ptr, Rid arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_705(IntPtr method, IntPtr ptr, Rid arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_706(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe godot_bool godot_icall_2_707(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Callable godot_icall_2_708(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertCallableToManaged(in ret);
    }

    internal static unsafe Variant godot_icall_2_709(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe string godot_icall_2_710(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe Rid godot_icall_2_711(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_2_712(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_3_713(IntPtr method, IntPtr ptr, Rid arg1, int arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_714(IntPtr method, IntPtr ptr, Rid arg1, int arg2, in Callable arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_715(IntPtr method, IntPtr ptr, Rid arg1, int arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_716(IntPtr method, IntPtr ptr, Rid arg1, int arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_717(IntPtr method, IntPtr ptr, Rid arg1, int arg2, Rid arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_718(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_719(IntPtr method, IntPtr ptr, Rid arg1, int arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_1_720(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_721(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_722(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, IntPtr arg3, in Callable arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg4_in = Marshaling.ConvertCallableToNative(in arg4);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_723(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, in Callable arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_724(IntPtr method, IntPtr ptr, Vector2[] arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_725(IntPtr method, IntPtr ptr, float[] arg1, int[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg1);
        using godot_packed_int32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_726(IntPtr method, IntPtr ptr, IntPtr arg1, Transform3D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_727(IntPtr method, IntPtr ptr, godot_array arg1, Transform3D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_728(IntPtr method, IntPtr ptr, Vector3[] arg1, Transform3D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_729(IntPtr method, IntPtr ptr, Vector3[] arg1, float arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        double arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_730(IntPtr method, IntPtr ptr, long[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedInt64Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_731(IntPtr method, IntPtr ptr, int arg1, Vector2[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2[] godot_icall_5_732(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Vector2* arg3, godot_bool arg4, uint arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, arg2, arg3, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Vector2 godot_icall_2_733(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_734(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_735(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe uint godot_icall_1_736(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (uint)(ret);
    }

    internal static unsafe Vector2 godot_icall_3_737(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_738(IntPtr method, IntPtr ptr, Rid arg1, ulong arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe ulong godot_icall_1_739(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        ulong ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_2_740(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_741(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rid godot_icall_1_742(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_743(IntPtr method, IntPtr ptr, Rid arg1, uint arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_744(IntPtr method, IntPtr ptr, Rid arg1, Transform2D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform2D godot_icall_1_745(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform2D ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_746(IntPtr method, IntPtr ptr, Rid arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_2_747(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_748(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_749(IntPtr method, IntPtr ptr, Rid arg1, Vector2[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2[] godot_icall_1_750(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Vector2[] godot_icall_2_751(IntPtr method, IntPtr ptr, Vector2[] arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_752(IntPtr method, IntPtr ptr, Rid arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector3 godot_icall_1_753(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3[] godot_icall_5_754(IntPtr method, IntPtr ptr, Rid arg1, Vector3* arg2, Vector3* arg3, godot_bool arg4, uint arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, arg2, arg3, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Vector3 godot_icall_4_755(IntPtr method, IntPtr ptr, Rid arg1, Vector3* arg2, Vector3* arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[4] { &arg1, arg2, arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_2_756(IntPtr method, IntPtr ptr, Rid arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_757(IntPtr method, IntPtr ptr, Rid arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_3_758(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_2_759(IntPtr method, IntPtr ptr, Rid arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_760(IntPtr method, IntPtr ptr, Rid arg1, Transform3D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform3D godot_icall_1_761(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform3D ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_2_762(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_763(IntPtr method, IntPtr ptr, Rid arg1, Vector3[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector3[] godot_icall_1_764(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe Vector3[] godot_icall_2_765(IntPtr method, IntPtr ptr, Vector3[] arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array ret = default;
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector3ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_0_766(IntPtr method)
    {
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, null, null);
    }

    internal static unsafe void godot_icall_3_767(IntPtr method, IntPtr ptr, IntPtr arg1, godot_bool arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_768(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_2_769(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe GodotObject godot_icall_1_770(IntPtr method, IntPtr ptr, godot_node_path arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe GodotObject godot_icall_3_771(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_4_772(IntPtr method, IntPtr ptr, string arg1, string arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_773(IntPtr method, IntPtr ptr, godot_node_path arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe NodePath godot_icall_2_774(IntPtr method, IntPtr ptr, IntPtr arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_node_path ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return NodePath.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_775(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_array arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string godot_icall_2_776(IntPtr method, IntPtr ptr, string arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe string godot_icall_4_777(IntPtr method, IntPtr ptr, string arg1, godot_string_name arg2, int arg3, godot_string_name arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int godot_icall_2_778(IntPtr method, IntPtr ptr, godot_string_name arg1, Variant[] arg2, godot_string_name caller)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        int vararg_length = arg2.Length;
        int total_length = 1 + vararg_length;
        Span<godot_variant.movable> varargs_span = vararg_length <= VarArgsSpanThreshold ?
            stackalloc godot_variant.movable[VarArgsSpanThreshold] :
            new godot_variant.movable[vararg_length];
        Span<IntPtr> call_args_span = total_length <= VarArgsSpanThreshold ?
            stackalloc IntPtr[VarArgsSpanThreshold] :
            new IntPtr[total_length];
        fixed (godot_variant.movable* varargs = &MemoryMarshal.GetReference(varargs_span))
        fixed (IntPtr* call_args = &MemoryMarshal.GetReference(call_args_span))
        {
            using godot_variant arg1_in = VariantUtils.CreateFromStringName(arg1);
            call_args[0] = new IntPtr(&arg1_in);
            for (int i = 0; i < vararg_length; i++)
            {
                varargs[i] = arg2[i].NativeVar;
                call_args[1 + i] = new IntPtr(&varargs[i]);
            }
            using godot_variant vararg_ret = NativeFuncs.godotsharp_method_bind_call(method, ptr, (godot_variant**)call_args, total_length, out godot_variant_call_error vcall_error);
            ExceptionUtils.DebugCheckCallError(caller, ptr, (godot_variant**)call_args, total_length, vcall_error);
            ret = VariantUtils.ConvertToInt64(vararg_ret);
            return (int)(ret);
        }
    }

    internal static unsafe int godot_icall_3_779(IntPtr method, IntPtr ptr, long arg1, godot_string_name arg2, Variant[] arg3, godot_string_name caller)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        int vararg_length = arg3.Length;
        int total_length = 2 + vararg_length;
        Span<godot_variant.movable> varargs_span = vararg_length <= VarArgsSpanThreshold ?
            stackalloc godot_variant.movable[VarArgsSpanThreshold] :
            new godot_variant.movable[vararg_length];
        Span<IntPtr> call_args_span = total_length <= VarArgsSpanThreshold ?
            stackalloc IntPtr[VarArgsSpanThreshold] :
            new IntPtr[total_length];
        fixed (godot_variant.movable* varargs = &MemoryMarshal.GetReference(varargs_span))
        fixed (IntPtr* call_args = &MemoryMarshal.GetReference(call_args_span))
        {
            using godot_variant arg1_in = VariantUtils.CreateFromInt(arg1);
            call_args[0] = new IntPtr(&arg1_in);
            using godot_variant arg2_in = VariantUtils.CreateFromStringName(arg2);
            call_args[1] = new IntPtr(&arg2_in);
            for (int i = 0; i < vararg_length; i++)
            {
                varargs[i] = arg3[i].NativeVar;
                call_args[2 + i] = new IntPtr(&varargs[i]);
            }
            using godot_variant vararg_ret = NativeFuncs.godotsharp_method_bind_call(method, ptr, (godot_variant**)call_args, total_length, out godot_variant_call_error vcall_error);
            ExceptionUtils.DebugCheckCallError(caller, ptr, (godot_variant**)call_args, total_length, vcall_error);
            ret = VariantUtils.ConvertToInt64(vararg_ret);
            return (int)(ret);
        }
    }

    internal static unsafe Variant godot_icall_2_780(IntPtr method, IntPtr ptr, godot_string_name arg1, Variant[] arg2, godot_string_name caller)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        int vararg_length = arg2.Length;
        int total_length = 1 + vararg_length;
        Span<godot_variant.movable> varargs_span = vararg_length <= VarArgsSpanThreshold ?
            stackalloc godot_variant.movable[VarArgsSpanThreshold] :
            new godot_variant.movable[vararg_length];
        Span<IntPtr> call_args_span = total_length <= VarArgsSpanThreshold ?
            stackalloc IntPtr[VarArgsSpanThreshold] :
            new IntPtr[total_length];
        fixed (godot_variant.movable* varargs = &MemoryMarshal.GetReference(varargs_span))
        fixed (IntPtr* call_args = &MemoryMarshal.GetReference(call_args_span))
        {
            using godot_variant arg1_in = VariantUtils.CreateFromStringName(arg1);
            call_args[0] = new IntPtr(&arg1_in);
            for (int i = 0; i < vararg_length; i++)
            {
                varargs[i] = arg2[i].NativeVar;
                call_args[1 + i] = new IntPtr(&varargs[i]);
            }
            godot_variant ret = NativeFuncs.godotsharp_method_bind_call(method, ptr, (godot_variant**)call_args, total_length, out godot_variant_call_error vcall_error);
            ExceptionUtils.DebugCheckCallError(caller, ptr, (godot_variant**)call_args, total_length, vcall_error);
            return Variant.CreateTakingOwnershipOfDisposableValue(ret);
        }
    }

    internal static unsafe void godot_icall_2_781(IntPtr method, IntPtr ptr, float arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform2D godot_icall_1_782(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform2D ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_783(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, Transform3D* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_784(IntPtr method, IntPtr ptr, Vector3* arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_785(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_786(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, Vector3* arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { arg1, arg2, arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_2_787(IntPtr method, IntPtr ptr, float arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        double arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe float godot_icall_3_788(IntPtr method, IntPtr ptr, float arg1, float arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        double arg1_in = arg1;
        double arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe GodotObject godot_icall_5_789(IntPtr method, IntPtr ptr, int arg1, int arg2, godot_bool arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_6_790(IntPtr method, IntPtr ptr, int arg1, int arg2, godot_bool arg3, godot_bool arg4, float arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3, &arg4, &arg5_in, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe Godot.Collections.Array godot_icall_5_791(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_6_792(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, godot_bool arg4, float arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3_in, &arg4, &arg5_in, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe string godot_icall_4_793(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe string[] godot_icall_7_794(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3, string arg4, int arg5, int arg6, godot_bool arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        long arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[7] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe int godot_icall_5_795(IntPtr method, IntPtr ptr, string arg1, string[] arg2, godot_array arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_796(IntPtr method, IntPtr ptr, string arg1, string[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe int godot_icall_3_797(IntPtr method, IntPtr ptr, string arg1, string[] arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_1_798(IntPtr method, IntPtr ptr, string[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_packed_string_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_799(IntPtr method, IntPtr ptr, godot_bool arg1, string[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string godot_icall_2_800(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe void godot_icall_2_801(IntPtr method, IntPtr ptr, godot_node_path arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Variant godot_icall_1_802(IntPtr method, IntPtr ptr, godot_node_path arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Variant godot_icall_2_803(IntPtr method, IntPtr ptr, godot_string_name arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Variant godot_icall_2_804(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe int godot_icall_3_805(IntPtr method, IntPtr ptr, godot_string_name arg1, in Callable arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe godot_bool godot_icall_2_806(IntPtr method, IntPtr ptr, godot_string_name arg1, in Callable arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe string godot_icall_2_807(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe string godot_icall_4_808(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, int arg3, godot_string_name arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe godot_bool godot_icall_3_809(IntPtr method, IntPtr ptr, ulong arg1, string arg2, godot_array arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_1_810(IntPtr method, godot_bool arg1)
    {
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return ret;
    }

    internal static unsafe ulong godot_icall_1_811(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        ulong ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe string godot_icall_1_812(IntPtr method, IntPtr ptr, ulong arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe string godot_icall_1_813(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe Vector2 godot_icall_2_814(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_815(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_816(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3, string arg4, string arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        using godot_string arg5_in = Marshaling.ConvertStringToNative(arg5);
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Quaternion godot_icall_2_817(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Quaternion ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_2_818(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_819(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_4_820(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_821(IntPtr method, IntPtr ptr, string arg1, string arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_1_822(IntPtr method, IntPtr ptr, Variant arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_823(IntPtr method, IntPtr ptr, Variant arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_824(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_825(IntPtr method, IntPtr ptr, int arg1, string arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Transform3D godot_icall_2_826(IntPtr method, Transform3D* arg1, int arg2)
    {
        Transform3D ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_827(IntPtr method, IntPtr ptr, godot_string_name arg1, in Callable arg2, godot_array arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_828(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_4_829(IntPtr method, IntPtr ptr, Vector2* arg1, godot_bool arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { arg1, &arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe godot_bool godot_icall_5_830(IntPtr method, IntPtr ptr, Transform2D* arg1, Vector2* arg2, IntPtr arg3, float arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[5] { arg1, arg2, &arg3, &arg4_in, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_5_831(IntPtr method, IntPtr ptr, Vector3* arg1, godot_bool arg2, float arg3, godot_bool arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        double arg3_in = arg3;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { arg1, &arg2, &arg3_in, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe godot_bool godot_icall_6_832(IntPtr method, IntPtr ptr, Transform3D* arg1, Vector3* arg2, IntPtr arg3, float arg4, godot_bool arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        double arg4_in = arg4;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { arg1, arg2, &arg3, &arg4_in, &arg5, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_833(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_834(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_1_835(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe float[] godot_icall_1_836(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedFloat32ArrayToSystemArray(ret);
    }

    internal static unsafe GodotObject godot_icall_4_837(IntPtr method, Vector2* arg1, Vector2* arg2, uint arg3, godot_array arg4)
    {
        using godot_ref ret = default;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { arg1, arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_4_838(IntPtr method, Vector3* arg1, Vector3* arg2, uint arg3, godot_array arg4)
    {
        using godot_ref ret = default;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { arg1, arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_2_839(IntPtr method, IntPtr ptr, Rid arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Variant godot_icall_1_840(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_841(IntPtr method, IntPtr ptr, Rid arg1, int arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_2_842(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe GodotObject godot_icall_1_843(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_4_844(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Transform2D* arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_845(IntPtr method, IntPtr ptr, Rid arg1, int arg2, Transform2D* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform2D godot_icall_2_846(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform2D ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_847(IntPtr method, IntPtr ptr, Rid arg1, int arg2, godot_bool arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_848(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Vector2* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_849(IntPtr method, IntPtr ptr, Rid arg1, in Callable arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_3_850(IntPtr method, IntPtr ptr, Rid arg1, IntPtr arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_851(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Rid arg3, Rid arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_852(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Vector2* arg3, Vector2* arg4, Rid arg5, Rid arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[6] { &arg1, arg2, arg3, arg4, &arg5, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_853(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Vector2* arg3, Rid arg4, Rid arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, arg2, arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_1_854(IntPtr method, IntPtr ptr, ulong arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_855(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Transform3D* arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_856(IntPtr method, IntPtr ptr, Rid arg1, int arg2, Transform3D* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform3D godot_icall_2_857(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform3D ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_858(IntPtr method, IntPtr ptr, Rid arg1, Vector3* arg2, Vector3* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Aabb godot_icall_1_859(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Aabb ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_860(IntPtr method, IntPtr ptr, Rid arg1, int arg2, Vector3* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_861(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Vector3* arg3, Rid arg4, Vector3* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, &arg2, arg3, &arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_862(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Transform3D* arg3, Rid arg4, Transform3D* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, &arg2, arg3, &arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_863(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_3_864(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe void godot_icall_4_865(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_3_866(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_1_867(IntPtr method, IntPtr ptr, Vector3I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector3I godot_icall_0_868(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3I ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_869(IntPtr method, IntPtr ptr, godot_node_path arg1, float[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_870(IntPtr method, IntPtr ptr, Vector2[] arg1, int[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg1);
        using godot_packed_int32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_871(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_872(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_873(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_874(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[5] { &arg1, &arg2, &arg3_in, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_875(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_876(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_877(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_878(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_879(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_880(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, godot_bool arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_881(IntPtr method, godot_bool arg1)
    {
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_0_882(IntPtr method)
    {
        godot_bool ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, null, &ret);
        return ret;
    }

    internal static unsafe Variant godot_icall_2_883(IntPtr method, IntPtr ptr, string arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe godot_bool godot_icall_3_884(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_1_885(IntPtr method, IntPtr ptr, Variant arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_2_886(IntPtr method, IntPtr ptr, IntPtr arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_887(IntPtr method, IntPtr ptr, int arg1, byte[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe long godot_icall_1_888(IntPtr method, IntPtr ptr, float[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_packed_float32_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_3_889(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe Godot.Collections.Array godot_icall_3_890(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe string godot_icall_5_891(IntPtr method, IntPtr ptr, string arg1, string arg2, godot_bool arg3, int arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe string godot_icall_1_892(IntPtr method, IntPtr ptr, Variant arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe Rid godot_icall_9_893(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, int arg3, uint arg4, int arg5, Vector2I* arg6, uint arg7, uint arg8, godot_bool arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg7_in = arg7;
        long arg8_in = arg8;
        void** call_args = stackalloc void*[9] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, arg6, &arg7_in, &arg8_in, &arg9 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_5_894(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, IntPtr arg3, IntPtr arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[5] { &arg1, &arg2, &arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_4_895(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, godot_string_name arg3, IntPtr arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_896(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_6_897(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, uint arg3, uint arg4, uint arg5, uint arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_7_898(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, uint arg3, uint arg4, uint arg5, uint arg6, IntPtr arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[7] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2I godot_icall_3_899(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_1_900(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_901(IntPtr method, IntPtr ptr, uint arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_1_902(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector3 godot_icall_1_903(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3 ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Projection godot_icall_1_904(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Projection ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_3_905(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, godot_array arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_906(IntPtr method, IntPtr ptr, IntPtr arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_6_907(IntPtr method, IntPtr ptr, IntPtr arg1, Rid arg2, uint arg3, uint arg4, uint arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_9_908(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, ulong arg5, ulong arg6, ulong arg7, ulong arg8, ulong arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[9] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5, &arg6, &arg7, &arg8, &arg9 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_3_909(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, byte[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe byte[] godot_icall_2_910(IntPtr method, IntPtr ptr, Rid arg1, uint arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe int godot_icall_9_911(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Vector3* arg3, Vector3* arg4, Vector3* arg5, uint arg6, uint arg7, uint arg8, uint arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg8_in = arg8;
        long arg9_in = arg9;
        void** call_args = stackalloc void*[9] { &arg1, &arg2, arg3, arg4, arg5, &arg6_in, &arg7_in, &arg8_in, &arg9_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_6_912(IntPtr method, IntPtr ptr, Rid arg1, Color* arg2, uint arg3, uint arg4, uint arg5, uint arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_1_913(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe long godot_icall_2_914(IntPtr method, IntPtr ptr, godot_array arg1, uint arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_3_915(IntPtr method, IntPtr ptr, godot_array arg1, godot_array arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_2_916(IntPtr method, IntPtr ptr, long arg1, uint arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Rid godot_icall_3_917(IntPtr method, IntPtr ptr, godot_array arg1, long arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_4_918(IntPtr method, IntPtr ptr, godot_array arg1, godot_array arg2, long arg3, uint arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_3_919(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_1_920(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_1_921(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_3_922(IntPtr method, IntPtr ptr, uint arg1, byte[] arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_1_923(IntPtr method, IntPtr ptr, godot_array arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_4_924(IntPtr method, IntPtr ptr, uint arg1, long arg2, godot_array arg3, long[] arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        using godot_packed_int64_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedInt64Array(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_4_925(IntPtr method, IntPtr ptr, uint arg1, int arg2, byte[] arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_3_926(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_2_927(IntPtr method, IntPtr ptr, IntPtr arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe byte[] godot_icall_2_928(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe Rid godot_icall_2_929(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_930(IntPtr method, IntPtr ptr, byte[] arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_931(IntPtr method, IntPtr ptr, uint arg1, byte[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_3_932(IntPtr method, IntPtr ptr, uint arg1, byte[] arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_3_933(IntPtr method, IntPtr ptr, uint arg1, int arg2, byte[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_3_934(IntPtr method, IntPtr ptr, godot_array arg1, Rid arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_5_935(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, uint arg3, uint arg4, uint arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_936(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, uint arg3, byte[] arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        using godot_packed_byte_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg4);
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_937(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe byte[] godot_icall_3_938(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe Rid godot_icall_11_939(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3, int arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, int arg9, uint arg10, godot_array arg11)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg4_in = arg4;
        long arg9_in = arg9;
        long arg10_in = arg10;
        void** call_args = stackalloc void*[11] { &arg1, &arg2, &arg3, &arg4_in, &arg5, &arg6, &arg7, &arg8, &arg9_in, &arg10_in, &arg11 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_940(IntPtr method, IntPtr ptr, Rid arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_2_941(IntPtr method, IntPtr ptr, int arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_9_942(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3, int arg4, int arg5, Color[] arg6, float arg7, uint arg8, Rect2* arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        using godot_packed_color_array arg6_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg6);
        double arg7_in = arg7;
        long arg8_in = arg8;
        void** call_args = stackalloc void*[9] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, arg9 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long[] godot_icall_11_943(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, int arg3, int arg4, int arg5, int arg6, Color[] arg7, float arg8, uint arg9, Rect2* arg10, godot_array arg11)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        using godot_packed_color_array arg7_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg7);
        double arg8_in = arg8;
        long arg9_in = arg9;
        void** call_args = stackalloc void*[11] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in, arg10, &arg11 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_944(IntPtr method, IntPtr ptr, long arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_945(IntPtr method, IntPtr ptr, long arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_946(IntPtr method, IntPtr ptr, long arg1, Rid arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_947(IntPtr method, IntPtr ptr, long arg1, byte[] arg2, uint arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_948(IntPtr method, IntPtr ptr, long arg1, godot_bool arg2, uint arg3, uint arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_949(IntPtr method, IntPtr ptr, long arg1, Rect2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe long[] godot_icall_1_950(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_4_951(IntPtr method, IntPtr ptr, long arg1, uint arg2, uint arg3, uint arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe ulong godot_icall_1_952(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        ulong ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe string godot_icall_1_953(IntPtr method, IntPtr ptr, uint arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe void godot_icall_2_954(IntPtr method, IntPtr ptr, Rid arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe ulong godot_icall_3_955(IntPtr method, IntPtr ptr, int arg1, Rid arg2, ulong arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        ulong ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_3_956(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_7_957(IntPtr method, IntPtr ptr, Rid arg1, Color* arg2, uint arg3, uint arg4, uint arg5, uint arg6, int arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg6_in = arg6;
        long arg7_in = arg7;
        void** call_args = stackalloc void*[7] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_10_958(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Vector3* arg3, Vector3* arg4, Vector3* arg5, uint arg6, uint arg7, uint arg8, uint arg9, int arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg6_in = arg6;
        long arg7_in = arg7;
        long arg8_in = arg8;
        long arg9_in = arg9;
        long arg10_in = arg10;
        void** call_args = stackalloc void*[10] { &arg1, &arg2, arg3, arg4, arg5, &arg6_in, &arg7_in, &arg8_in, &arg9_in, &arg10_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_959(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, byte[] arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        using godot_packed_byte_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg3);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_4_960(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, uint arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_5_961(IntPtr method, IntPtr ptr, Rid arg1, uint arg2, uint arg3, byte[] arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        using godot_packed_byte_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg4);
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe long godot_icall_1_962(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_10_963(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3, int arg4, int arg5, Color[] arg6, float arg7, uint arg8, Rect2* arg9, godot_array arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        using godot_packed_color_array arg6_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg6);
        double arg7_in = arg7;
        long arg8_in = arg8;
        void** call_args = stackalloc void*[10] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, arg9, &arg10 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_1_964(IntPtr method, IntPtr ptr, byte[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_2_965(IntPtr method, IntPtr ptr, godot_array arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rid godot_icall_6_966(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, godot_bool arg5, godot_array arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_967(IntPtr method, IntPtr ptr, Rid arg1, IntPtr arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_968(IntPtr method, IntPtr ptr, Rid arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string godot_icall_1_969(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe Rid godot_icall_2_970(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe ulong godot_icall_2_971(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        ulong ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Variant godot_icall_2_972(IntPtr method, IntPtr ptr, Rid arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_4_973(IntPtr method, IntPtr ptr, Rid arg1, godot_string_name arg2, Rid arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rid godot_icall_3_974(IntPtr method, IntPtr ptr, Rid arg1, godot_string_name arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_975(IntPtr method, IntPtr ptr, Rid arg1, godot_string_name arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe uint godot_icall_3_976(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (uint)(ret);
    }

    internal static unsafe uint godot_icall_2_977(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (uint)(ret);
    }

    internal static unsafe void godot_icall_2_978(IntPtr method, IntPtr ptr, Rid arg1, godot_dictionary arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_979(IntPtr method, IntPtr ptr, Rid arg1, int arg2, godot_array arg3, godot_array arg4, godot_dictionary arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, &arg2_in, &arg3, &arg4, &arg5, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_980(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_981(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_2_982(IntPtr method, IntPtr ptr, Rid arg1, Aabb* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_983(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3, byte[] arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        using godot_packed_byte_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg4);
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_984(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3_in, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_985(IntPtr method, IntPtr ptr, Rid arg1, int arg2, Color* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Color godot_icall_2_986(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Color ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_987(IntPtr method, IntPtr ptr, Rid arg1, float[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float[] godot_icall_1_988(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedFloat32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_989(IntPtr method, IntPtr ptr, Rid arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_990(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float arg3, float arg4, float arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        double arg4_in = arg4;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_991(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_992(IntPtr method, IntPtr ptr, Rid arg1, float arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_8_993(IntPtr method, IntPtr ptr, Rid arg1, Transform3D* arg2, Aabb* arg3, Vector3I* arg4, byte[] arg5, byte[] arg6, byte[] arg7, int[] arg8)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array arg5_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg5);
        using godot_packed_byte_array arg6_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg6);
        using godot_packed_byte_array arg7_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg7);
        using godot_packed_int32_array arg8_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg8);
        void** call_args = stackalloc void*[8] { &arg1, arg2, arg3, arg4, &arg5_in, &arg6_in, &arg7_in, &arg8_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector3I godot_icall_1_994(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector3I ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe byte[] godot_icall_1_995(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe int[] godot_icall_1_996(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_3_997(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_998(IntPtr method, IntPtr ptr, Rid arg1, Vector3[] arg2, Color[] arg3, int[] arg4, int[] arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg2);
        using godot_packed_color_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg3);
        using godot_packed_int32_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg4);
        using godot_packed_int32_array arg5_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg5);
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Color[] godot_icall_1_999(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_color_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedColorArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_1000(IntPtr method, IntPtr ptr, Rid arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1001(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1002(IntPtr method, IntPtr ptr, Rid arg1, Transform3D* arg2, Vector3* arg3, Color* arg4, Color* arg5, uint arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, arg2, arg3, arg4, arg5, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1003(IntPtr method, IntPtr ptr, Rid arg1, in Callable arg2, in Callable arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1004(IntPtr method, IntPtr ptr, Rid arg1, Vector3[] arg2, int[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg2);
        using godot_packed_int32_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1005(IntPtr method, IntPtr ptr, Rid arg1, float arg2, float arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        double arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1006(IntPtr method, IntPtr ptr, Rid arg1, float arg2, Vector2* arg3, float arg4, float arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        double arg4_in = arg4;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1007(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1008(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Transform2D* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1009(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_3_1010(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe double godot_icall_1_1011(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_4_1012(IntPtr method, IntPtr ptr, Rid arg1, float arg2, godot_bool arg3, Vector2I* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_2_1013(IntPtr method, IntPtr ptr, Rid arg1, Basis* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1014(IntPtr method, IntPtr ptr, Rid arg1, Color* arg2, int arg3, float arg4, float arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        double arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_13_1015(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float[] arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, float arg11, float arg12, Rid arg13)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_float32_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg3);
        double arg4_in = arg4;
        double arg5_in = arg5;
        double arg6_in = arg6;
        double arg7_in = arg7;
        long arg8_in = arg8;
        double arg9_in = arg9;
        double arg10_in = arg10;
        double arg11_in = arg11;
        double arg12_in = arg12;
        void** call_args = stackalloc void*[13] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in, &arg10_in, &arg11_in, &arg12_in, &arg13 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1016(IntPtr method, IntPtr ptr, Rid arg1, int arg2, float arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        double arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_1017(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float arg3, float arg4, float arg5, godot_bool arg6, Rid arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        double arg4_in = arg4;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[7] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6, &arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1018(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, int arg3, float arg4, float arg5, float arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        double arg4_in = arg4;
        double arg5_in = arg5;
        double arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_10_1019(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9, float arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        double arg4_in = arg4;
        double arg5_in = arg5;
        double arg6_in = arg6;
        double arg7_in = arg7;
        double arg8_in = arg8;
        double arg9_in = arg9;
        double arg10_in = arg10;
        void** call_args = stackalloc void*[10] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in, &arg10_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_11_1020(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, Color* arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9, float arg10, int arg11)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg4_in = arg4;
        double arg5_in = arg5;
        double arg6_in = arg6;
        double arg7_in = arg7;
        double arg8_in = arg8;
        double arg9_in = arg9;
        double arg10_in = arg10;
        long arg11_in = arg11;
        void** call_args = stackalloc void*[11] { &arg1, &arg2, arg3, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in, &arg10_in, &arg11_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_11_1021(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, int arg3, float arg4, int arg5, godot_bool arg6, float arg7, godot_bool arg8, float arg9, float arg10, float arg11)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        double arg4_in = arg4;
        long arg5_in = arg5;
        double arg7_in = arg7;
        double arg9_in = arg9;
        double arg10_in = arg10;
        double arg11_in = arg11;
        void** call_args = stackalloc void*[11] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6, &arg7_in, &arg8, &arg9_in, &arg10_in, &arg11_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_14_1022(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float arg3, Color* arg4, Color* arg5, float arg6, float arg7, float arg8, float arg9, float arg10, godot_bool arg11, float arg12, float arg13, float arg14)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        double arg6_in = arg6;
        double arg7_in = arg7;
        double arg8_in = arg8;
        double arg9_in = arg9;
        double arg10_in = arg10;
        double arg12_in = arg12;
        double arg13_in = arg13;
        double arg14_in = arg14;
        void** call_args = stackalloc void*[14] { &arg1, &arg2, &arg3_in, arg4, arg5, &arg6_in, &arg7_in, &arg8_in, &arg9_in, &arg10_in, &arg11, &arg12_in, &arg13_in, &arg14_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1023(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2, float arg3, int arg4, float arg5, float arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg3_in = arg3;
        long arg4_in = arg4;
        double arg5_in = arg5;
        double arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_3_1024(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, Vector2I* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_3_1025(IntPtr method, IntPtr ptr, godot_bool arg1, float arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1026(IntPtr method, IntPtr ptr, float arg1, float arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg1_in = arg1;
        double arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_8_1027(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float arg3, float arg4, godot_bool arg5, float arg6, float arg7, float arg8)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        double arg4_in = arg4;
        double arg6_in = arg6;
        double arg7_in = arg7;
        double arg8_in = arg8;
        void** call_args = stackalloc void*[8] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5, &arg6_in, &arg7_in, &arg8_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1028(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, float arg3, float arg4, float arg5, float arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        double arg4_in = arg4;
        double arg5_in = arg5;
        double arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, &arg2, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rid godot_icall_2_1029(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_1030(IntPtr method, IntPtr ptr, Rid arg1, float arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1031(IntPtr method, IntPtr ptr, Rid arg1, float arg2, float arg3, float arg4, float arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        double arg3_in = arg3;
        double arg4_in = arg4;
        double arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1032(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Rect2* arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe long[] godot_icall_2_1033(IntPtr method, IntPtr ptr, Aabb* arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe long[] godot_icall_3_1034(IntPtr method, IntPtr ptr, Vector3* arg1, Vector3* arg2, Rid arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        void** call_args = stackalloc void*[3] { arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe long[] godot_icall_2_1035(IntPtr method, IntPtr ptr, godot_array arg1, Rid arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int64_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt64ArrayToSystemArray(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_3_1036(IntPtr method, IntPtr ptr, Rid arg1, godot_array arg2, Vector2I* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_1037(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Vector2* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1038(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1039(IntPtr method, IntPtr ptr, Rid arg1, Color* arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1040(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, Rect2* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1041(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Vector2* arg3, Color* arg4, float arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg5_in = arg5;
        void** call_args = stackalloc void*[6] { &arg1, arg2, arg3, arg4, &arg5_in, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1042(IntPtr method, IntPtr ptr, Rid arg1, Vector2[] arg2, Color[] arg3, float arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        using godot_packed_color_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg3);
        double arg4_in = arg4;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1043(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Color* arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1044(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, float arg3, Color* arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[5] { &arg1, arg2, &arg3_in, arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1045(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Rid arg3, godot_bool arg4, Color* arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[6] { &arg1, arg2, &arg3, &arg4, arg5, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_8_1046(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Rid arg3, Rect2* arg4, Color* arg5, int arg6, float arg7, float arg8)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg6_in = arg6;
        double arg7_in = arg7;
        double arg8_in = arg8;
        void** call_args = stackalloc void*[8] { &arg1, arg2, &arg3, arg4, arg5, &arg6_in, &arg7_in, &arg8_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1047(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Rid arg3, Rect2* arg4, Color* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, arg2, &arg3, arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_1048(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Rid arg3, Rect2* arg4, Color* arg5, godot_bool arg6, godot_bool arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[7] { &arg1, arg2, &arg3, arg4, arg5, &arg6, &arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_10_1049(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Rect2* arg3, Rid arg4, Vector2* arg5, Vector2* arg6, int arg7, int arg8, godot_bool arg9, Color* arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg7_in = arg7;
        long arg8_in = arg8;
        void** call_args = stackalloc void*[10] { &arg1, arg2, arg3, &arg4, arg5, arg6, &arg7_in, &arg8_in, &arg9, arg10 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1050(IntPtr method, IntPtr ptr, Rid arg1, Vector2[] arg2, Color[] arg3, Vector2[] arg4, Rid arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        using godot_packed_color_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg3);
        using godot_packed_vector2_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg4);
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_9_1051(IntPtr method, IntPtr ptr, Rid arg1, int[] arg2, Vector2[] arg3, Color[] arg4, Vector2[] arg5, int[] arg6, float[] arg7, Rid arg8, int arg9)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg2);
        using godot_packed_vector2_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg3);
        using godot_packed_color_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg4);
        using godot_packed_vector2_array arg5_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg5);
        using godot_packed_int32_array arg6_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg6);
        using godot_packed_float32_array arg7_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg7);
        long arg9_in = arg9;
        void** call_args = stackalloc void*[9] { &arg1, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8, &arg9_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1052(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Transform2D* arg3, Color* arg4, Rid arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, &arg2, arg3, arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1053(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Rid arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1054(IntPtr method, IntPtr ptr, Rid arg1, double arg2, double arg3, double arg4, double arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, &arg2, &arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1055(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, Rect2* arg3, in Callable arg4, in Callable arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg4_in = Marshaling.ConvertCallableToNative(in arg4);
        using godot_callable arg5_in = Marshaling.ConvertCallableToNative(in arg5);
        void** call_args = stackalloc void*[5] { &arg1, &arg2, arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1056(IntPtr method, IntPtr ptr, Rid arg1, int arg2, float arg3, godot_bool arg4, float arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        double arg3_in = arg3;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[6] { &arg1, &arg2_in, &arg3_in, &arg4, &arg5_in, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rect2 godot_icall_1_1057(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_1058(IntPtr method, IntPtr ptr, Rid arg1, Vector2[] arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1059(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rid godot_icall_3_1060(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1061(IntPtr method, IntPtr ptr, IntPtr arg1, Color* arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1062(IntPtr method, IntPtr ptr, godot_bool arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1063(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, float arg3, Color* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3_in, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1064(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Color* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1065(IntPtr method, IntPtr ptr, Rid arg1, Vector2[] arg2, Color[] arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        using godot_packed_color_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg3);
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_10_1066(IntPtr method, IntPtr ptr, Rid arg1, godot_bool arg2, Color* arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9, float arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg4_in = arg4;
        double arg5_in = arg5;
        double arg6_in = arg6;
        double arg7_in = arg7;
        double arg8_in = arg8;
        double arg9_in = arg9;
        double arg10_in = arg10;
        void** call_args = stackalloc void*[10] { &arg1, &arg2, arg3, &arg4_in, &arg5_in, &arg6_in, &arg7_in, &arg8_in, &arg9_in, &arg10_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string godot_icall_0_1067(IntPtr method)
    {
        using godot_string ret = default;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, null, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int godot_icall_4_1068(IntPtr method, IntPtr ptr, string arg1, string arg2, godot_bool arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_1069(IntPtr method, IntPtr ptr, string arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_3_1070(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe long godot_icall_1_1071(IntPtr method, IntPtr ptr, string arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_3_1072(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe string[] godot_icall_1_1073(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_1074(IntPtr method, IntPtr ptr, long arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_10_1075(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, Color* arg4, int arg5, Rect2* arg6, Variant arg7, godot_bool arg8, string arg9, godot_bool arg10)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg5_in = arg5;
        godot_variant arg7_in = (godot_variant)arg7.NativeVar;
        using godot_string arg9_in = Marshaling.ConvertStringToNative(arg9);
        void** call_args = stackalloc void*[10] { &arg1, &arg2_in, &arg3_in, arg4, &arg5_in, arg6, &arg7_in, &arg8, &arg9_in, &arg10 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_11_1076(IntPtr method, IntPtr ptr, Variant arg1, int arg2, IntPtr arg3, int arg4, int arg5, Color* arg6, int arg7, Rect2* arg8, godot_bool arg9, string arg10, godot_bool arg11)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        long arg2_in = arg2;
        long arg4_in = arg4;
        long arg5_in = arg5;
        long arg7_in = arg7;
        using godot_string arg10_in = Marshaling.ConvertStringToNative(arg10);
        void** call_args = stackalloc void*[11] { &arg1_in, &arg2_in, &arg3, &arg4_in, &arg5_in, arg6, &arg7_in, arg8, &arg9, &arg10_in, &arg11 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_2_1077(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_6_1078(IntPtr method, IntPtr ptr, int arg1, int arg2, string arg3, int arg4, int arg5, float[] arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        long arg4_in = arg4;
        long arg5_in = arg5;
        using godot_packed_float32_array arg6_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg6);
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1079(IntPtr method, IntPtr ptr, int arg1, int arg2, godot_bool arg3, string arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1080(IntPtr method, IntPtr ptr, Variant arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_1081(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, int arg3, Rect2* arg4, Color* arg5, int arg6, Color* arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg3_in = arg3;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[7] { &arg1_in, &arg2, &arg3_in, arg4, arg5, &arg6_in, arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1082(IntPtr method, IntPtr ptr, Color* arg1, Color* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1083(IntPtr method, IntPtr ptr, IntPtr arg1, godot_dictionary arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_1_1084(IntPtr method, IntPtr ptr, string[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_packed_string_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_6_1085(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, Color* arg4, int arg5, Rect2* arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[6] { &arg1, &arg2_in, &arg3_in, arg4, &arg5_in, arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_4_1086(IntPtr method, IntPtr ptr, byte[] arg1, int arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_1087(IntPtr method, IntPtr ptr, godot_node_path arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_1_1088(IntPtr method, IntPtr ptr, godot_node_path arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe NodePath godot_icall_2_1089(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_node_path ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return NodePath.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_4_1090(IntPtr method, IntPtr ptr, double arg1, godot_bool arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_4_1091(IntPtr method, IntPtr ptr, long arg1, godot_string_name arg2, godot_string_name arg3, Variant[] arg4, godot_string_name caller)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        int vararg_length = arg4.Length;
        int total_length = 3 + vararg_length;
        Span<godot_variant.movable> varargs_span = vararg_length <= VarArgsSpanThreshold ?
            stackalloc godot_variant.movable[VarArgsSpanThreshold] :
            new godot_variant.movable[vararg_length];
        Span<IntPtr> call_args_span = total_length <= VarArgsSpanThreshold ?
            stackalloc IntPtr[VarArgsSpanThreshold] :
            new IntPtr[total_length];
        fixed (godot_variant.movable* varargs = &MemoryMarshal.GetReference(varargs_span))
        fixed (IntPtr* call_args = &MemoryMarshal.GetReference(call_args_span))
        {
            using godot_variant arg1_in = VariantUtils.CreateFromInt(arg1);
            call_args[0] = new IntPtr(&arg1_in);
            using godot_variant arg2_in = VariantUtils.CreateFromStringName(arg2);
            call_args[1] = new IntPtr(&arg2_in);
            using godot_variant arg3_in = VariantUtils.CreateFromStringName(arg3);
            call_args[2] = new IntPtr(&arg3_in);
            for (int i = 0; i < vararg_length; i++)
            {
                varargs[i] = arg4[i].NativeVar;
                call_args[3 + i] = new IntPtr(&varargs[i]);
            }
            NativeFuncs.godotsharp_method_bind_call(method, ptr, (godot_variant**)call_args, total_length, out godot_variant_call_error vcall_error);
            ExceptionUtils.DebugCheckCallError(caller, ptr, (godot_variant**)call_args, total_length, vcall_error);
        }
    }

    internal static unsafe void godot_icall_3_1092(IntPtr method, IntPtr ptr, uint arg1, godot_string_name arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1093(IntPtr method, IntPtr ptr, uint arg1, godot_string_name arg2, string arg3, Variant arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        godot_variant arg4_in = (godot_variant)arg4.NativeVar;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1094(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, Variant[] arg3, godot_string_name caller)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        int vararg_length = arg3.Length;
        int total_length = 2 + vararg_length;
        Span<godot_variant.movable> varargs_span = vararg_length <= VarArgsSpanThreshold ?
            stackalloc godot_variant.movable[VarArgsSpanThreshold] :
            new godot_variant.movable[vararg_length];
        Span<IntPtr> call_args_span = total_length <= VarArgsSpanThreshold ?
            stackalloc IntPtr[VarArgsSpanThreshold] :
            new IntPtr[total_length];
        fixed (godot_variant.movable* varargs = &MemoryMarshal.GetReference(varargs_span))
        fixed (IntPtr* call_args = &MemoryMarshal.GetReference(call_args_span))
        {
            using godot_variant arg1_in = VariantUtils.CreateFromStringName(arg1);
            call_args[0] = new IntPtr(&arg1_in);
            using godot_variant arg2_in = VariantUtils.CreateFromStringName(arg2);
            call_args[1] = new IntPtr(&arg2_in);
            for (int i = 0; i < vararg_length; i++)
            {
                varargs[i] = arg3[i].NativeVar;
                call_args[2 + i] = new IntPtr(&varargs[i]);
            }
            NativeFuncs.godotsharp_method_bind_call(method, ptr, (godot_variant**)call_args, total_length, out godot_variant_call_error vcall_error);
            ExceptionUtils.DebugCheckCallError(caller, ptr, (godot_variant**)call_args, total_length, vcall_error);
        }
    }

    internal static unsafe void godot_icall_3_1095(IntPtr method, IntPtr ptr, godot_string_name arg1, string arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1096(IntPtr method, IntPtr ptr, IntPtr arg1, godot_node_path arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_1_1097(IntPtr method, IntPtr ptr, godot_node_path arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_3_1099(IntPtr method, IntPtr ptr, godot_string_name arg1, IntPtr arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_2_1100(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe godot_bool godot_icall_3_1101(IntPtr method, IntPtr ptr, Transform2D* arg1, IntPtr arg2, Transform2D* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[3] { arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_5_1102(IntPtr method, IntPtr ptr, Transform2D* arg1, Vector2* arg2, IntPtr arg3, Transform2D* arg4, Vector2* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[5] { arg1, arg2, &arg3, arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2[] godot_icall_3_1103(IntPtr method, IntPtr ptr, Transform2D* arg1, IntPtr arg2, Transform2D* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[3] { arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe Vector2[] godot_icall_5_1104(IntPtr method, IntPtr ptr, Transform2D* arg1, Vector2* arg2, IntPtr arg3, Transform2D* arg4, Vector2* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[5] { arg1, arg2, &arg3, arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_1105(IntPtr method, IntPtr ptr, float arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1106(IntPtr method, IntPtr ptr, int arg1, Transform2D* arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1107(IntPtr method, IntPtr ptr, int arg1, Quaternion* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Quaternion godot_icall_1_1108(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Quaternion ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1109(IntPtr method, IntPtr ptr, int arg1, Transform3D* arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_4_1110(IntPtr method, IntPtr ptr, float arg1, float arg2, float arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        double arg1_in = arg1;
        double arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe void godot_icall_2_1111(IntPtr method, IntPtr ptr, string arg1, Transform3D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1112(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2, godot_node_path arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe double godot_icall_1_1113(IntPtr method, IntPtr ptr, godot_string_name arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1114(IntPtr method, IntPtr ptr, godot_string_name arg1, IntPtr arg2, float arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1115(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2, IntPtr arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_2_1116(IntPtr method, IntPtr ptr, godot_string_name arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_1117(IntPtr method, IntPtr ptr, byte[] arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_1_1118(IntPtr method, IntPtr ptr, sbyte arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_1119(IntPtr method, IntPtr ptr, short arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe sbyte godot_icall_0_1120(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return (sbyte)(ret);
    }

    internal static unsafe short godot_icall_0_1121(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return (short)(ret);
    }

    internal static unsafe int godot_icall_2_1122(IntPtr method, IntPtr ptr, godot_bool arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_1123(IntPtr method, IntPtr ptr, int arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_1124(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_2_1125(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_2_1126(IntPtr method, IntPtr ptr, Vector2* arg1, Rect2* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_6_1127(IntPtr method, IntPtr ptr, Vector3[] arg1, Vector2[] arg2, Color[] arg3, Vector2[] arg4, Vector3[] arg5, godot_array arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        using godot_packed_color_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedColorArray(arg3);
        using godot_packed_vector2_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg4);
        using godot_packed_vector3_array arg5_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg5);
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int[] godot_icall_2_1128(IntPtr method, IntPtr ptr, float arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        double arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_2_1129(IntPtr method, IntPtr ptr, godot_array arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1130(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_2_1131(IntPtr method, IntPtr ptr, IntPtr arg1, ulong arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe int godot_icall_2_1132(IntPtr method, IntPtr ptr, ushort arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_2_1133(IntPtr method, IntPtr arg1, string arg2)
    {
        using godot_ref ret = default;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_2_1134(IntPtr method, IntPtr arg1, IntPtr arg2)
    {
        using godot_ref ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_5_1135(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2I godot_icall_3_1136(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2I godot_icall_4_1137(IntPtr method, IntPtr ptr, string arg1, uint arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2I godot_icall_2_1138(IntPtr method, IntPtr ptr, Vector2I* arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2I godot_icall_2_1139(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rect2I godot_icall_2_1140(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2I ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_2_1141(IntPtr method, IntPtr ptr, godot_bool arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int[] godot_icall_1_1142(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_5_1143(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1144(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2, godot_bool arg3, int arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1145(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_4_1146(IntPtr method, IntPtr ptr, int arg1, int arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_1147(IntPtr method, IntPtr ptr, godot_bool arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_4_1148(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1149(IntPtr method, IntPtr ptr, int arg1, int arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_5_1150(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, int arg3, string arg4, Variant arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg3_in = arg3;
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        godot_variant arg5_in = (godot_variant)arg5.NativeVar;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_5_1151(IntPtr method, IntPtr ptr, Variant arg1, Vector2* arg2, int arg3, int arg4, float arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        long arg3_in = arg3;
        long arg4_in = arg4;
        double arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, arg2, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_4_1152(IntPtr method, IntPtr ptr, Variant arg1, Vector2* arg2, int arg3, float arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        long arg3_in = arg3;
        double arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rect2 godot_icall_1_1153(IntPtr method, IntPtr ptr, Variant arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_1154(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Color* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1155(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, int arg3, Color* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3_in, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_1_1156(IntPtr method, IntPtr ptr, float arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        double arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe godot_bool godot_icall_5_1157(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, int arg3, Rect2* arg4, string arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg3_in = arg3;
        using godot_string arg5_in = Marshaling.ConvertStringToNative(arg5);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3_in, arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rect2 godot_icall_2_1158(IntPtr method, IntPtr ptr, int arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        long arg1_in = arg1;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1159(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Color* arg3, Color* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1160(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, int arg3, Color* arg4, Color* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[5] { &arg1, arg2, &arg3_in, arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1161(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, int arg3, int arg4, Color* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[5] { &arg1, arg2, &arg3_in, &arg4_in, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1162(IntPtr method, IntPtr ptr, Rid arg1, byte[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1163(IntPtr method, IntPtr ptr, Rid arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_1_1164(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_1165(IntPtr method, IntPtr ptr, Rid arg1, int arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe long godot_icall_2_1166(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_1167(IntPtr method, IntPtr ptr, Rid arg1, long arg2, double arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe double godot_icall_2_1168(IntPtr method, IntPtr ptr, Rid arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_2_1169(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_1170(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1171(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3, IntPtr arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_3_1172(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_4_1173(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3, int[] arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg4);
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int[] godot_icall_3_1174(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe int[] godot_icall_2_1175(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe Vector2 godot_icall_3_1176(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1177(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_3_1178(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1179(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rect2 godot_icall_3_1180(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1181(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3, Rect2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe long godot_icall_3_1182(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1183(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3, long arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rid godot_icall_3_1184(IntPtr method, IntPtr ptr, Rid arg1, Vector2I* arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[3] { &arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_3_1185(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_1186(IntPtr method, IntPtr ptr, Rid arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_3_1187(IntPtr method, IntPtr ptr, Rid arg1, long arg2, Vector2I* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1188(IntPtr method, IntPtr ptr, Rid arg1, long arg2, Vector2I* arg3, Vector2* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2 godot_icall_3_1189(IntPtr method, IntPtr ptr, Rid arg1, long arg2, Vector2I* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_4_1190(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3, long arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_3_1191(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_2_1192(IntPtr method, IntPtr ptr, Rid arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_6_1193(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, long arg3, Vector2* arg4, long arg5, Color* arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[6] { &arg1, &arg2, &arg3, arg4, &arg5, arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_1194(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, long arg3, long arg4, Vector2* arg5, long arg6, Color* arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[7] { &arg1, &arg2, &arg3, &arg4, arg5, &arg6, arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_2_1195(IntPtr method, IntPtr ptr, Rid arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_1196(IntPtr method, IntPtr ptr, Rid arg1, string arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string[] godot_icall_1_1197(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe Vector2 godot_icall_2_1198(IntPtr method, IntPtr ptr, long arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_5_1199(IntPtr method, IntPtr ptr, Rid arg1, long arg2, Vector2* arg3, long arg4, Color* arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, &arg2, arg3, &arg4, arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rid godot_icall_2_1200(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_7_1201(IntPtr method, IntPtr ptr, Rid arg1, string arg2, godot_array arg3, long arg4, godot_dictionary arg5, string arg6, Variant arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg6_in = Marshaling.ConvertStringToNative(arg6);
        godot_variant arg7_in = (godot_variant)arg7.NativeVar;
        void** call_args = stackalloc void*[7] { &arg1, &arg2_in, &arg3, &arg4, &arg5, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_6_1202(IntPtr method, IntPtr ptr, Rid arg1, Variant arg2, Vector2* arg3, int arg4, long arg5, double arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[6] { &arg1, &arg2_in, arg3, &arg4_in, &arg5, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_5_1203(IntPtr method, IntPtr ptr, Rid arg1, Variant arg2, Vector2* arg3, int arg4, double arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, arg3, &arg4_in, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Variant godot_icall_2_1204(IntPtr method, IntPtr ptr, Rid arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_5_1205(IntPtr method, IntPtr ptr, Rid arg1, long arg2, godot_array arg3, long arg4, godot_dictionary arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, &arg2, &arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rid godot_icall_3_1206(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe double godot_icall_3_1207(IntPtr method, IntPtr ptr, Rid arg1, double arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe double godot_icall_2_1208(IntPtr method, IntPtr ptr, Rid arg1, float[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        using godot_packed_float32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2I godot_icall_1_1209(IntPtr method, IntPtr ptr, Rid arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe int[] godot_icall_5_1210(IntPtr method, IntPtr ptr, Rid arg1, float[] arg2, long arg3, godot_bool arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        using godot_packed_float32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg2);
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, &arg2_in, &arg3, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe int[] godot_icall_4_1211(IntPtr method, IntPtr ptr, Rid arg1, double arg2, long arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe int[] godot_icall_3_1212(IntPtr method, IntPtr ptr, Rid arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_3_1213(IntPtr method, IntPtr ptr, Rid arg1, double arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rect2 godot_icall_2_1214(IntPtr method, IntPtr ptr, Rid arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2I godot_icall_2_1215(IntPtr method, IntPtr ptr, Rid arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_2_1216(IntPtr method, IntPtr ptr, Rid arg1, Variant arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_1217(IntPtr method, IntPtr ptr, Rid arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector2[] godot_icall_3_1218(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe long godot_icall_2_1219(IntPtr method, IntPtr ptr, Rid arg1, double arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2 godot_icall_2_1220(IntPtr method, IntPtr ptr, Rid arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2 ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_2_1221(IntPtr method, IntPtr ptr, Rid arg1, long arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_6_1222(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Vector2* arg3, double arg4, double arg5, Color* arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[6] { &arg1, &arg2, arg3, &arg4, &arg5, arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_7_1223(IntPtr method, IntPtr ptr, Rid arg1, Rid arg2, Vector2* arg3, double arg4, double arg5, long arg6, Color* arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[7] { &arg1, &arg2, arg3, &arg4, &arg5, &arg6, arg7 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_3_1224(IntPtr method, IntPtr ptr, Rid arg1, long arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe string godot_icall_2_1225(IntPtr method, IntPtr ptr, string arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe int[] godot_icall_3_1226(IntPtr method, IntPtr ptr, string arg1, string arg2, long arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe int[] godot_icall_2_1227(IntPtr method, IntPtr ptr, string arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe long godot_icall_2_1228(IntPtr method, IntPtr ptr, string arg1, string[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Godot.Collections.Array godot_icall_3_1229(IntPtr method, IntPtr ptr, int arg1, godot_array arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg1_in = arg1;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe int[] godot_icall_2_1230(IntPtr method, IntPtr ptr, Rid arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_int32_array ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedInt32ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_4_1231(IntPtr method, IntPtr ptr, Rid arg1, Vector2* arg2, Color* arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, arg2, arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1232(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, godot_bool arg3, Color* arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[5] { &arg1, arg2, &arg3, arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_1233(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Rect2* arg3, Color* arg4, godot_bool arg5, godot_bool arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[6] { &arg1, arg2, arg3, arg4, &arg5, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1234(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1235(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1236(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, Color* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1237(IntPtr method, IntPtr ptr, int arg1, godot_string_name arg2, godot_string_name arg3, Variant arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        godot_variant arg4_in = (godot_variant)arg4.NativeVar;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Variant godot_icall_3_1238(IntPtr method, IntPtr ptr, int arg1, godot_string_name arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe godot_bool godot_icall_3_1239(IntPtr method, IntPtr ptr, int arg1, godot_string_name arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1240(IntPtr method, IntPtr ptr, int arg1, godot_string_name arg2, godot_string_name arg3, godot_string_name arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1241(IntPtr method, IntPtr ptr, int arg1, godot_string_name arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe string[] godot_icall_2_1242(IntPtr method, IntPtr ptr, int arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array ret = default;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedStringArrayToSystemArray(ret);
    }

    internal static unsafe int godot_icall_2_1243(IntPtr method, IntPtr ptr, in Callable arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_4_1244(IntPtr method, IntPtr ptr, int arg1, godot_bool arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_3_1245(IntPtr method, IntPtr ptr, int arg1, int arg2, Vector2[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_packed_vector2_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2[] godot_icall_2_1246(IntPtr method, IntPtr ptr, int arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_5_1247(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3, Vector2I* arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, arg2, &arg3_in, arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_3_1248(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Vector2I godot_icall_3_1249(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_3_1250(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe GodotObject godot_icall_2_1251(IntPtr method, IntPtr ptr, int arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe Vector2I godot_icall_3_1252(IntPtr method, IntPtr ptr, Vector2I* arg1, Vector2I* arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        void** call_args = stackalloc void*[3] { arg1, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_1253(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1254(IntPtr method, IntPtr ptr, int arg1, godot_array arg2, int arg3, int arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3_in, &arg4_in, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Array godot_icall_1_1255(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_4_1256(IntPtr method, IntPtr ptr, int arg1, int arg2, Vector2I* arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Vector2I godot_icall_1_1257(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2I godot_icall_2_1258(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_4_1259(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2, Vector2I* arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { arg1, &arg2_in, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector2I godot_icall_1_1260(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector2I ret;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_1_1261(IntPtr method, IntPtr ptr, Vector2I* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe Godot.Collections.Array godot_icall_3_1262(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_1_1263(IntPtr method, IntPtr ptr, godot_array arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe void godot_icall_2_1264(IntPtr method, IntPtr ptr, Vector2I* arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1265(IntPtr method, IntPtr ptr, godot_array arg1, int arg2, int arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_1266(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3, Vector2I* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1_in, arg2, &arg3_in, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_1267(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe godot_bool godot_icall_2_1268(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_6_1269(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3, int arg4, Vector2I* arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1_in, arg2, &arg3_in, &arg4_in, arg5, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_3_1270(IntPtr method, IntPtr ptr, int arg1, Vector2I* arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_2_1271(IntPtr method, IntPtr ptr, Vector2I* arg1, Vector2I* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[2] { arg1, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1272(IntPtr method, IntPtr ptr, Vector2I* arg1, Vector2I* arg2, Vector2I* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { arg1, arg2, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_6_1273(IntPtr method, IntPtr ptr, Vector2I* arg1, Vector2I* arg2, int arg3, Vector2I* arg4, int arg5, Vector2I* arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg3_in = arg3;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[6] { arg1, arg2, &arg3_in, arg4, &arg5_in, arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Vector2[] godot_icall_4_1274(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2I* arg2, Vector2I* arg3, Vector2I* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector2_array ret = default;
        void** call_args = stackalloc void*[4] { &arg1, arg2, arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedVector2ArrayToSystemArray(ret);
    }

    internal static unsafe void godot_icall_3_1275(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2, float arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        double arg3_in = arg3;
        void** call_args = stackalloc void*[3] { arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe float godot_icall_2_1276(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (float)ret;
    }

    internal static unsafe int godot_icall_2_1277(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_3_1278(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_2_1279(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe Rect2I godot_icall_2_1280(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2I ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe godot_bool godot_icall_2_1281(IntPtr method, IntPtr ptr, Vector2I* arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_1_1282(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe string godot_icall_2_1283(IntPtr method, IntPtr ptr, long arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_1284(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe string godot_icall_2_1285(IntPtr method, IntPtr ptr, godot_dictionary arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe long godot_icall_1_1286(IntPtr method, IntPtr ptr, godot_dictionary arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe string godot_icall_2_1287(IntPtr method, IntPtr ptr, godot_bool arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertStringToManaged(ret);
    }

    internal static unsafe void godot_icall_3_1288(IntPtr method, IntPtr ptr, godot_string_name arg1, string[] arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe StringName godot_icall_2_1289(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_string_name ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe StringName godot_icall_4_1290(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, int arg3, godot_string_name arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_string_name ret = default;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return StringName.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe GodotObject godot_icall_2_1291(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe GodotObject godot_icall_1_1292(IntPtr method, IntPtr ptr, IntPtr arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe godot_bool godot_icall_1_1293(IntPtr method, IntPtr ptr, godot_bool arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Rect2 godot_icall_3_1294(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rect2 ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe GodotObject godot_icall_1_1295(IntPtr method, IntPtr ptr, Vector2* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_5_1296(IntPtr method, IntPtr ptr, int arg1, double arg2, double arg3, double arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1297(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, godot_string_name arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Callable godot_icall_1_1298(IntPtr method, IntPtr ptr, int arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable ret = default;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[1] { &arg1_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertCallableToManaged(in ret);
    }

    internal static unsafe void godot_icall_3_1299(IntPtr method, IntPtr ptr, int arg1, Color* arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1300(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, int arg3, godot_bool arg4, string arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg3_in = arg3;
        using godot_string arg5_in = Marshaling.ConvertStringToNative(arg5);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3_in, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_1301(IntPtr method, IntPtr ptr, godot_string_name arg1, Variant[] arg2, godot_string_name caller)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        int vararg_length = arg2.Length;
        int total_length = 1 + vararg_length;
        Span<godot_variant.movable> varargs_span = vararg_length <= VarArgsSpanThreshold ?
            stackalloc godot_variant.movable[VarArgsSpanThreshold] :
            new godot_variant.movable[vararg_length];
        Span<IntPtr> call_args_span = total_length <= VarArgsSpanThreshold ?
            stackalloc IntPtr[VarArgsSpanThreshold] :
            new IntPtr[total_length];
        fixed (godot_variant.movable* varargs = &MemoryMarshal.GetReference(varargs_span))
        fixed (IntPtr* call_args = &MemoryMarshal.GetReference(call_args_span))
        {
            using godot_variant arg1_in = VariantUtils.CreateFromStringName(arg1);
            call_args[0] = new IntPtr(&arg1_in);
            for (int i = 0; i < vararg_length; i++)
            {
                varargs[i] = arg2[i].NativeVar;
                call_args[1 + i] = new IntPtr(&varargs[i]);
            }
            NativeFuncs.godotsharp_method_bind_call(method, ptr, (godot_variant**)call_args, total_length, out godot_variant_call_error vcall_error);
            ExceptionUtils.DebugCheckCallError(caller, ptr, (godot_variant**)call_args, total_length, vcall_error);
        }
    }

    internal static unsafe GodotObject godot_icall_4_1302(IntPtr method, IntPtr ptr, IntPtr arg1, godot_node_path arg2, Variant arg3, double arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_4_1303(IntPtr method, IntPtr ptr, in Callable arg1, Variant arg2, Variant arg3, double arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe godot_bool godot_icall_1_1304(IntPtr method, IntPtr ptr, double arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Variant godot_icall_6_1305(IntPtr method, Variant arg1, Variant arg2, double arg3, double arg4, int arg5, int arg6)
    {
        godot_variant ret = default;
        godot_variant arg1_in = (godot_variant)arg1.NativeVar;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        long arg5_in = arg5;
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3, &arg4, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return Variant.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe int godot_icall_3_1306(IntPtr method, IntPtr ptr, int arg1, int arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_5_1307(IntPtr method, IntPtr ptr, int arg1, int arg2, string arg3, string arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe Rid godot_icall_3_1308(IntPtr method, Rid arg1, uint arg2, godot_array arg3)
    {
        Rid ret;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, IntPtr.Zero, call_args, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_3_1309(IntPtr method, IntPtr ptr, int arg1, float[] arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_packed_float32_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedFloat32Array(arg2);
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_4_1310(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, Vector2* arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_1311(IntPtr method, IntPtr ptr, int arg1, int arg2, Vector2* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe godot_bool godot_icall_5_1312(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_3_1313(IntPtr method, IntPtr ptr, int arg1, Variant arg2, Variant arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_1_1314(IntPtr method, IntPtr ptr, Vector4* arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[1] { arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Vector4 godot_icall_0_1315(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Vector4 ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_7_1316(IntPtr method, IntPtr ptr, Transform3D* arg1, Aabb* arg2, Vector3* arg3, byte[] arg4, byte[] arg5, byte[] arg6, int[] arg7)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array arg4_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg4);
        using godot_packed_byte_array arg5_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg5);
        using godot_packed_byte_array arg6_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg6);
        using godot_packed_int32_array arg7_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg7);
        void** call_args = stackalloc void*[7] { arg1, arg2, arg3, &arg4_in, &arg5_in, &arg6_in, &arg7_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_2_1317(IntPtr method, IntPtr ptr, int arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_1318(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_1_1319(IntPtr method, IntPtr ptr, godot_dictionary arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe GodotObject godot_icall_2_1320(IntPtr method, IntPtr ptr, string arg1, godot_dictionary arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe int godot_icall_3_1321(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_3_1322(IntPtr method, IntPtr ptr, int arg1, string arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe int godot_icall_2_1323(IntPtr method, IntPtr ptr, byte[] arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_packed_byte_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe long godot_icall_3_1324(IntPtr method, IntPtr ptr, in Callable arg1, godot_bool arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe long godot_icall_5_1325(IntPtr method, IntPtr ptr, in Callable arg1, int arg2, int arg3, godot_bool arg4, string arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        using godot_string arg5_in = Marshaling.ConvertStringToNative(arg5);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe uint godot_icall_1_1326(IntPtr method, IntPtr ptr, long arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (uint)(ret);
    }

    internal static unsafe Plane godot_icall_0_1327(IntPtr method, IntPtr ptr)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Plane ret;
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, null, &ret);
        return ret;
    }

    internal static unsafe int godot_icall_1_1328(IntPtr method, IntPtr ptr, ulong arg1)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        void** call_args = stackalloc void*[1] { &arg1 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_6_1329(IntPtr method, IntPtr ptr, string arg1, godot_string_name arg2, double arg3, double arg4, double arg5, double arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2, &arg3, &arg4, &arg5, &arg6 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Transform3D godot_icall_2_1330(IntPtr method, IntPtr ptr, uint arg1, Transform3D* arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Transform3D ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[2] { &arg1_in, arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe Projection godot_icall_4_1331(IntPtr method, IntPtr ptr, uint arg1, double arg2, double arg3, double arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Projection ret;
        long arg1_in = arg1;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe void godot_icall_11_1332(IntPtr method, IntPtr ptr, Rid arg1, Rect2* arg2, Rect2I* arg3, godot_bool arg4, uint arg5, godot_bool arg6, Vector2* arg7, double arg8, double arg9, double arg10, double arg11)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg5_in = arg5;
        void** call_args = stackalloc void*[11] { &arg1, arg2, arg3, &arg4, &arg5_in, &arg6, arg7, &arg8, &arg9, &arg10, &arg11 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1333(IntPtr method, IntPtr ptr, string arg1, double arg2, double arg3, double arg4, double arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_1334(IntPtr method, IntPtr ptr, godot_string_name arg1, Transform3D* arg2, Vector3* arg3, Vector3* arg4, int arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg5_in = arg5;
        void** call_args = stackalloc void*[5] { &arg1, arg2, arg3, arg4, &arg5_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Rid godot_icall_2_1335(IntPtr method, IntPtr ptr, Vector2* arg1, Vector2[] arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        Rid ret;
        using godot_packed_vector2_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedVector2Array(arg2);
        void** call_args = stackalloc void*[2] { arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }

    internal static unsafe byte[] godot_icall_2_1336(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_byte_array ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Marshaling.ConvertNativePackedByteArrayToSystemArray(ret);
    }

    internal static unsafe godot_bool godot_icall_2_1337(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_bool ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return ret;
    }
}

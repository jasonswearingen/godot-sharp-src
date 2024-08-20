namespace Godot;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Godot.NativeInterop;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "RedundantUnsafeContext")]
[SuppressMessage("ReSharper", "RedundantNameQualifier")]
[System.Runtime.CompilerServices.SkipLocalsInit]
internal static class EditorNativeCalls
{
    internal static ulong godot_api_hash = 591096730;

    private const int VarArgsSpanThreshold = 10;


    internal static unsafe void godot_icall_4_405(IntPtr method, IntPtr ptr, string arg1, string arg2, in Callable arg3, string arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_callable arg3_in = Marshaling.ConvertCallableToNative(in arg3);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_407(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2, godot_array arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_408(IntPtr method, IntPtr ptr, string arg1, string[] arg2, string arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_409(IntPtr method, IntPtr ptr, string arg1, byte[] arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_byte_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedByteArray(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_410(IntPtr method, IntPtr ptr, godot_string_name arg1, godot_string_name arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[3] { &arg1, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_2_414(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe int godot_icall_4_415(IntPtr method, IntPtr ptr, string arg1, godot_dictionary arg2, string arg3, Variant arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long ret;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        godot_variant arg4_in = (godot_variant)arg4.NativeVar;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return (int)(ret);
    }

    internal static unsafe void godot_icall_4_416(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, godot_bool arg3, string arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_417(IntPtr method, IntPtr ptr, string arg1, string[] arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_packed_string_array arg2_in = Marshaling.ConvertSystemArrayToNativePackedStringArray(arg2);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_418(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe Godot.Collections.Array godot_icall_2_419(IntPtr method, IntPtr ptr, godot_array arg1, int arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_array ret = default;
        long arg2_in = arg2;
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Array.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_2_424(IntPtr method, IntPtr ptr, in Callable arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg1_in = Marshaling.ConvertCallableToNative(in arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_425(IntPtr method, IntPtr ptr, IntPtr arg1, in Callable arg2, int[] arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_callable arg2_in = Marshaling.ConvertCallableToNative(in arg2);
        using godot_packed_int32_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg3);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_426(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_427(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3_in, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_428(IntPtr method, IntPtr ptr, Vector3[] arg1, IntPtr arg2, godot_bool arg3, Color* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_429(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, Transform3D* arg3, IntPtr arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        void** call_args = stackalloc void*[4] { &arg1, &arg2, arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_430(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, Color* arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        double arg2_in = arg2;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_431(IntPtr method, IntPtr ptr, Vector3[] arg1, IntPtr arg2, int[] arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_packed_vector3_array arg1_in = Marshaling.ConvertSystemArrayToNativePackedVector3Array(arg1);
        using godot_packed_int32_array arg3_in = Marshaling.ConvertSystemArrayToNativePackedInt32Array(arg3);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2, &arg3_in, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_5_432(IntPtr method, IntPtr ptr, string arg1, Color* arg2, godot_bool arg3, godot_bool arg4, godot_bool arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[5] { &arg1_in, arg2, &arg3, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_433(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, godot_bool arg3, Color* arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_434(IntPtr method, IntPtr ptr, string arg1, godot_bool arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_2_436(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_ref ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret.Reference);
    }

    internal static unsafe GodotObject godot_icall_3_437(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_3_438(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, IntPtr arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_440(IntPtr method, IntPtr ptr, string arg1, string arg2, IntPtr arg3, IntPtr arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe GodotObject godot_icall_2_442(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        IntPtr ret = default;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return InteropUtils.UnmanagedGetManaged(ret);
    }

    internal static unsafe void godot_icall_4_443(IntPtr method, IntPtr ptr, godot_string_name arg1, Variant arg2, godot_string_name arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[4] { &arg1, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_444(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, godot_string_name arg3, Variant arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        godot_variant arg4_in = (godot_variant)arg4.NativeVar;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_445(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, godot_string_name arg3, Variant arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg4_in = (godot_variant)arg4.NativeVar;
        void** call_args = stackalloc void*[4] { &arg1, &arg2, &arg3, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_6_447(IntPtr method, IntPtr ptr, int arg1, string arg2, Variant arg3, int arg4, string arg5, int arg6)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        long arg1_in = arg1;
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        godot_variant arg3_in = (godot_variant)arg3.NativeVar;
        long arg4_in = arg4;
        using godot_string arg5_in = Marshaling.ConvertStringToNative(arg5);
        long arg6_in = arg6;
        void** call_args = stackalloc void*[6] { &arg1_in, &arg2_in, &arg3_in, &arg4_in, &arg5_in, &arg6_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_449(IntPtr method, IntPtr ptr, godot_string_name arg1, Variant arg2, godot_bool arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_variant arg2_in = (godot_variant)arg2.NativeVar;
        void** call_args = stackalloc void*[3] { &arg1, &arg2_in, &arg3 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_4_450(IntPtr method, IntPtr ptr, string arg1, int arg2, IntPtr arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }

    internal static unsafe void godot_icall_3_451(IntPtr method, IntPtr ptr, IntPtr arg1, godot_string_name arg2, Variant[] arg3, godot_string_name caller)
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
            using godot_variant arg1_in = VariantUtils.CreateFromGodotObjectPtr(arg1);
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

    internal static unsafe Godot.Collections.Dictionary godot_icall_4_453(IntPtr method, IntPtr ptr, int arg1, int arg2, string arg3, string arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        using godot_string arg4_in = Marshaling.ConvertStringToNative(arg4);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_4_454(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        long arg1_in = arg1;
        long arg2_in = arg2;
        long arg3_in = arg3;
        long arg4_in = arg4;
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3_in, &arg4_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_455(IntPtr method, IntPtr ptr, string arg1, string arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[2] { &arg1_in, &arg2_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_5_456(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3, long arg4, long arg5)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        using godot_string arg3_in = Marshaling.ConvertStringToNative(arg3);
        void** call_args = stackalloc void*[5] { &arg1_in, &arg2_in, &arg3_in, &arg4, &arg5 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_3_457(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        long arg2_in = arg2;
        long arg3_in = arg3;
        void** call_args = stackalloc void*[3] { &arg1_in, &arg2_in, &arg3_in };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe Godot.Collections.Dictionary godot_icall_2_458(IntPtr method, IntPtr ptr, godot_dictionary arg1, godot_array arg2)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        godot_dictionary ret = default;
        void** call_args = stackalloc void*[2] { &arg1, &arg2 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, &ret);
        return Godot.Collections.Dictionary.CreateTakingOwnershipOfDisposableValue(ret);
    }

    internal static unsafe void godot_icall_4_1098(IntPtr method, IntPtr ptr, string arg1, string arg2, godot_bool arg3, godot_bool arg4)
    {
        ExceptionUtils.ThrowIfNullPtr(ptr);
        using godot_string arg1_in = Marshaling.ConvertStringToNative(arg1);
        using godot_string arg2_in = Marshaling.ConvertStringToNative(arg2);
        void** call_args = stackalloc void*[4] { &arg1_in, &arg2_in, &arg3, &arg4 };
        NativeFuncs.godotsharp_method_bind_ptrcall(method, ptr, call_args, null);
    }
}

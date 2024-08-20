namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>The JavaClassWrapper singleton provides a way for the Godot application to send and receive data through the <a href="https://developer.android.com/training/articles/perf-jni">Java Native Interface</a> (JNI).</para>
/// <para><b>Note:</b> This singleton is only available in Android builds.</para>
/// </summary>
public static partial class JavaClassWrapper
{
    private static readonly StringName NativeName = "JavaClassWrapper";

    private static JavaClassWrapperInstance singleton;

    public static JavaClassWrapperInstance Singleton =>
        singleton ??= (JavaClassWrapperInstance)InteropUtils.EngineGetSingleton("JavaClassWrapper");

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.Wrap, 1124367868ul);

    /// <summary>
    /// <para>Wraps a class defined in Java, and returns it as a <see cref="Godot.JavaClass"/> <see cref="Godot.GodotObject"/> type that Godot can interact with.</para>
    /// <para><b>Note:</b> This method only works on Android. On every other platform, this method does nothing and returns an empty <see cref="Godot.JavaClass"/>.</para>
    /// </summary>
    public static JavaClass Wrap(string name)
    {
        return (JavaClass)NativeCalls.godot_icall_1_523(MethodBind0, GodotObject.GetPtr(Singleton), name);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public class PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public class MethodName
    {
        /// <summary>
        /// Cached name for the 'wrap' method.
        /// </summary>
        public static readonly StringName Wrap = "wrap";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public class SignalName
    {
    }
}

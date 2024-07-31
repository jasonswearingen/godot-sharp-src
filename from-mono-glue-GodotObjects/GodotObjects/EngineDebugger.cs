namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.EngineDebugger"/> handles the communication between the editor and the running game. It is active in the running game. Messages can be sent/received through it. It also manages the profilers.</para>
/// </summary>
public static partial class EngineDebugger
{
    private static readonly StringName NativeName = "EngineDebugger";

    private static EngineDebuggerInstance singleton;

    public static EngineDebuggerInstance Singleton =>
        singleton ??= (EngineDebuggerInstance)InteropUtils.EngineGetSingleton("EngineDebugger");

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.IsActive, 2240911060ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the debugger is active otherwise <see langword="false"/>.</para>
    /// </summary>
    public static bool IsActive()
    {
        return NativeCalls.godot_icall_0_40(MethodBind0, GodotObject.GetPtr(Singleton)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.RegisterProfiler, 3651669560ul);

    /// <summary>
    /// <para>Registers a profiler with the given <paramref name="name"/>. See <see cref="Godot.EngineProfiler"/> for more information.</para>
    /// </summary>
    public static void RegisterProfiler(StringName name, EngineProfiler profiler)
    {
        NativeCalls.godot_icall_2_149(MethodBind1, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default), GodotObject.GetPtr(profiler));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.UnregisterProfiler, 3304788590ul);

    /// <summary>
    /// <para>Unregisters a profiler with given <paramref name="name"/>.</para>
    /// </summary>
    public static void UnregisterProfiler(StringName name)
    {
        NativeCalls.godot_icall_1_59(MethodBind2, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.IsProfiling, 2041966384ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if a profiler with the given name is present and active otherwise <see langword="false"/>.</para>
    /// </summary>
    public static bool IsProfiling(StringName name)
    {
        return NativeCalls.godot_icall_1_110(MethodBind3, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.HasProfiler, 2041966384ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if a profiler with the given name is present otherwise <see langword="false"/>.</para>
    /// </summary>
    public static bool HasProfiler(StringName name)
    {
        return NativeCalls.godot_icall_1_110(MethodBind4, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.ProfilerAddFrameData, 1895267858ul);

    /// <summary>
    /// <para>Calls the <c>add</c> callable of the profiler with given <paramref name="name"/> and <paramref name="data"/>.</para>
    /// </summary>
    public static void ProfilerAddFrameData(StringName name, Godot.Collections.Array data)
    {
        NativeCalls.godot_icall_2_461(MethodBind5, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default), (godot_array)(data ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.ProfilerEnable, 3192561009ul);

    /// <summary>
    /// <para>Calls the <c>toggle</c> callable of the profiler with given <paramref name="name"/> and <paramref name="arguments"/>. Enables/Disables the same profiler depending on <paramref name="enable"/> argument.</para>
    /// </summary>
    public static void ProfilerEnable(StringName name, bool enable, Godot.Collections.Array arguments = null)
    {
        NativeCalls.godot_icall_3_462(MethodBind6, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default), enable.ToGodotBool(), (godot_array)(arguments ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.RegisterMessageCapture, 1874754934ul);

    /// <summary>
    /// <para>Registers a message capture with given <paramref name="name"/>. If <paramref name="name"/> is "my_message" then messages starting with "my_message:" will be called with the given callable.</para>
    /// <para>Callable must accept a message string and a data array as argument. If the message and data are valid then callable must return <see langword="true"/> otherwise <see langword="false"/>.</para>
    /// </summary>
    public static void RegisterMessageCapture(StringName name, Callable callable)
    {
        NativeCalls.godot_icall_2_463(MethodBind7, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default), callable);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.UnregisterMessageCapture, 3304788590ul);

    /// <summary>
    /// <para>Unregisters the message capture with given <paramref name="name"/>.</para>
    /// </summary>
    public static void UnregisterMessageCapture(StringName name)
    {
        NativeCalls.godot_icall_1_59(MethodBind8, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.HasCapture, 2041966384ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if a capture with the given name is present otherwise <see langword="false"/>.</para>
    /// </summary>
    public static bool HasCapture(StringName name)
    {
        return NativeCalls.godot_icall_1_110(MethodBind9, GodotObject.GetPtr(Singleton), (godot_string_name)(name?.NativeValue ?? default)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.LinePoll, 3218959716ul);

    /// <summary>
    /// <para>Forces a processing loop of debugger events. The purpose of this method is just processing events every now and then when the script might get too busy, so that bugs like infinite loops can be caught</para>
    /// </summary>
    public static void LinePoll()
    {
        NativeCalls.godot_icall_0_3(MethodBind10, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.SendMessage, 1209351045ul);

    /// <summary>
    /// <para>Sends a message with given <paramref name="message"/> and <paramref name="data"/> array.</para>
    /// </summary>
    public static void SendMessage(string message, Godot.Collections.Array data)
    {
        NativeCalls.godot_icall_2_406(MethodBind11, GodotObject.GetPtr(Singleton), message, (godot_array)(data ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.Debug, 2751962654ul);

    /// <summary>
    /// <para>Starts a debug break in script execution, optionally specifying whether the program can continue based on <paramref name="canContinue"/> and whether the break was due to a breakpoint.</para>
    /// </summary>
    public static void Debug(bool canContinue = true, bool isErrorBreakpoint = false)
    {
        NativeCalls.godot_icall_2_464(MethodBind12, GodotObject.GetPtr(Singleton), canContinue.ToGodotBool(), isErrorBreakpoint.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.ScriptDebug, 2442343672ul);

    /// <summary>
    /// <para>Starts a debug break in script execution, optionally specifying whether the program can continue based on <paramref name="canContinue"/> and whether the break was due to a breakpoint.</para>
    /// </summary>
    public static void ScriptDebug(ScriptLanguage language, bool canContinue = true, bool isErrorBreakpoint = false)
    {
        NativeCalls.godot_icall_3_465(MethodBind13, GodotObject.GetPtr(Singleton), GodotObject.GetPtr(language), canContinue.ToGodotBool(), isErrorBreakpoint.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLinesLeft, 1286410249ul);

    /// <summary>
    /// <para>Sets the current debugging lines that remain.</para>
    /// </summary>
    public static void SetLinesLeft(int lines)
    {
        NativeCalls.godot_icall_1_36(MethodBind14, GodotObject.GetPtr(Singleton), lines);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLinesLeft, 3905245786ul);

    /// <summary>
    /// <para>Returns the number of lines that remain.</para>
    /// </summary>
    public static int GetLinesLeft()
    {
        return NativeCalls.godot_icall_0_37(MethodBind15, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDepth, 1286410249ul);

    /// <summary>
    /// <para>Sets the current debugging depth.</para>
    /// </summary>
    public static void SetDepth(int depth)
    {
        NativeCalls.godot_icall_1_36(MethodBind16, GodotObject.GetPtr(Singleton), depth);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDepth, 3905245786ul);

    /// <summary>
    /// <para>Returns the current debug depth.</para>
    /// </summary>
    public static int GetDepth()
    {
        return NativeCalls.godot_icall_0_37(MethodBind17, GodotObject.GetPtr(Singleton));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.IsBreakpoint, 921227809ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the given <paramref name="source"/> and <paramref name="line"/> represent an existing breakpoint.</para>
    /// </summary>
    public static bool IsBreakpoint(int line, StringName source)
    {
        return NativeCalls.godot_icall_2_466(MethodBind18, GodotObject.GetPtr(Singleton), line, (godot_string_name)(source?.NativeValue ?? default)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.IsSkippingBreakpoints, 36873697ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the debugger is skipping breakpoints otherwise <see langword="false"/>.</para>
    /// </summary>
    public static bool IsSkippingBreakpoints()
    {
        return NativeCalls.godot_icall_0_40(MethodBind19, GodotObject.GetPtr(Singleton)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.InsertBreakpoint, 3780747571ul);

    /// <summary>
    /// <para>Inserts a new breakpoint with the given <paramref name="source"/> and <paramref name="line"/>.</para>
    /// </summary>
    public static void InsertBreakpoint(int line, StringName source)
    {
        NativeCalls.godot_icall_2_164(MethodBind20, GodotObject.GetPtr(Singleton), line, (godot_string_name)(source?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.RemoveBreakpoint, 3780747571ul);

    /// <summary>
    /// <para>Removes a breakpoint with the given <paramref name="source"/> and <paramref name="line"/>.</para>
    /// </summary>
    public static void RemoveBreakpoint(int line, StringName source)
    {
        NativeCalls.godot_icall_2_164(MethodBind21, GodotObject.GetPtr(Singleton), line, (godot_string_name)(source?.NativeValue ?? default));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = GodotObject.ClassDB_get_method_with_compatibility(NativeName, MethodName.ClearBreakpoints, 3218959716ul);

    /// <summary>
    /// <para>Clears all breakpoints.</para>
    /// </summary>
    public static void ClearBreakpoints()
    {
        NativeCalls.godot_icall_0_3(MethodBind22, GodotObject.GetPtr(Singleton));
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
        /// Cached name for the 'is_active' method.
        /// </summary>
        public static readonly StringName IsActive = "is_active";
        /// <summary>
        /// Cached name for the 'register_profiler' method.
        /// </summary>
        public static readonly StringName RegisterProfiler = "register_profiler";
        /// <summary>
        /// Cached name for the 'unregister_profiler' method.
        /// </summary>
        public static readonly StringName UnregisterProfiler = "unregister_profiler";
        /// <summary>
        /// Cached name for the 'is_profiling' method.
        /// </summary>
        public static readonly StringName IsProfiling = "is_profiling";
        /// <summary>
        /// Cached name for the 'has_profiler' method.
        /// </summary>
        public static readonly StringName HasProfiler = "has_profiler";
        /// <summary>
        /// Cached name for the 'profiler_add_frame_data' method.
        /// </summary>
        public static readonly StringName ProfilerAddFrameData = "profiler_add_frame_data";
        /// <summary>
        /// Cached name for the 'profiler_enable' method.
        /// </summary>
        public static readonly StringName ProfilerEnable = "profiler_enable";
        /// <summary>
        /// Cached name for the 'register_message_capture' method.
        /// </summary>
        public static readonly StringName RegisterMessageCapture = "register_message_capture";
        /// <summary>
        /// Cached name for the 'unregister_message_capture' method.
        /// </summary>
        public static readonly StringName UnregisterMessageCapture = "unregister_message_capture";
        /// <summary>
        /// Cached name for the 'has_capture' method.
        /// </summary>
        public static readonly StringName HasCapture = "has_capture";
        /// <summary>
        /// Cached name for the 'line_poll' method.
        /// </summary>
        public static readonly StringName LinePoll = "line_poll";
        /// <summary>
        /// Cached name for the 'send_message' method.
        /// </summary>
        public static readonly StringName SendMessage = "send_message";
        /// <summary>
        /// Cached name for the 'debug' method.
        /// </summary>
        public static readonly StringName Debug = "debug";
        /// <summary>
        /// Cached name for the 'script_debug' method.
        /// </summary>
        public static readonly StringName ScriptDebug = "script_debug";
        /// <summary>
        /// Cached name for the 'set_lines_left' method.
        /// </summary>
        public static readonly StringName SetLinesLeft = "set_lines_left";
        /// <summary>
        /// Cached name for the 'get_lines_left' method.
        /// </summary>
        public static readonly StringName GetLinesLeft = "get_lines_left";
        /// <summary>
        /// Cached name for the 'set_depth' method.
        /// </summary>
        public static readonly StringName SetDepth = "set_depth";
        /// <summary>
        /// Cached name for the 'get_depth' method.
        /// </summary>
        public static readonly StringName GetDepth = "get_depth";
        /// <summary>
        /// Cached name for the 'is_breakpoint' method.
        /// </summary>
        public static readonly StringName IsBreakpoint = "is_breakpoint";
        /// <summary>
        /// Cached name for the 'is_skipping_breakpoints' method.
        /// </summary>
        public static readonly StringName IsSkippingBreakpoints = "is_skipping_breakpoints";
        /// <summary>
        /// Cached name for the 'insert_breakpoint' method.
        /// </summary>
        public static readonly StringName InsertBreakpoint = "insert_breakpoint";
        /// <summary>
        /// Cached name for the 'remove_breakpoint' method.
        /// </summary>
        public static readonly StringName RemoveBreakpoint = "remove_breakpoint";
        /// <summary>
        /// Cached name for the 'clear_breakpoints' method.
        /// </summary>
        public static readonly StringName ClearBreakpoints = "clear_breakpoints";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public class SignalName
    {
    }
}

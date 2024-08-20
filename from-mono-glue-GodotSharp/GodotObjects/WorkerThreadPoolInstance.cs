namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>The <see cref="Godot.WorkerThreadPool"/> singleton allocates a set of <see cref="Godot.GodotThread"/>s (called worker threads) on project startup and provides methods for offloading tasks to them. This can be used for simple multithreading without having to create <see cref="Godot.GodotThread"/>s.</para>
/// <para>Tasks hold the <see cref="Godot.Callable"/> to be run by the threads. <see cref="Godot.WorkerThreadPool"/> can be used to create regular tasks, which will be taken by one worker thread, or group tasks, which can be distributed between multiple worker threads. Group tasks execute the <see cref="Godot.Callable"/> multiple times, which makes them useful for iterating over a lot of elements, such as the enemies in an arena.</para>
/// <para>Here's a sample on how to offload an expensive function to worker threads:</para>
/// <para><code>
/// private List&lt;Node&gt; _enemies = new List&lt;Node&gt;(); // A list to be filled with enemies.
/// 
/// private void ProcessEnemyAI(int enemyIndex)
/// {
///     Node processedEnemy = _enemies[enemyIndex];
///     // Expensive logic here.
/// }
/// 
/// public override void _Process(double delta)
/// {
///     long taskId = WorkerThreadPool.AddGroupTask(Callable.From&lt;int&gt;(ProcessEnemyAI), _enemies.Count);
///     // Other code...
///     WorkerThreadPool.WaitForGroupTaskCompletion(taskId);
///     // Other code that depends on the enemy AI already being processed.
/// }
/// </code></para>
/// <para>The above code relies on the number of elements in the <c>enemies</c> array remaining constant during the multithreaded part.</para>
/// <para><b>Note:</b> Using this singleton could affect performance negatively if the task being distributed between threads is not computationally expensive.</para>
/// </summary>
[GodotClassName("WorkerThreadPool")]
public partial class WorkerThreadPoolInstance : GodotObject
{
    private static readonly System.Type CachedType = typeof(WorkerThreadPoolInstance);

    private static readonly StringName NativeName = "WorkerThreadPool";

    internal WorkerThreadPoolInstance() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal WorkerThreadPoolInstance(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddTask, 3745067146ul);

    /// <summary>
    /// <para>Adds <paramref name="action"/> as a task to be executed by a worker thread. <paramref name="highPriority"/> determines if the task has a high priority or a low priority (default). You can optionally provide a <paramref name="description"/> to help with debugging.</para>
    /// <para>Returns a task ID that can be used by other methods.</para>
    /// <para><b>Warning:</b> Every task must be waited for completion using <see cref="Godot.WorkerThreadPoolInstance.WaitForTaskCompletion(long)"/> or <see cref="Godot.WorkerThreadPoolInstance.WaitForGroupTaskCompletion(long)"/> at some point so that any allocated resources inside the task can be cleaned up.</para>
    /// </summary>
    public long AddTask(Callable action, bool highPriority = false, string description = "")
    {
        return NativeCalls.godot_icall_3_1324(MethodBind0, GodotObject.GetPtr(this), action, highPriority.ToGodotBool(), description);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsTaskCompleted, 1116898809ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the task with the given ID is completed.</para>
    /// <para><b>Note:</b> You should only call this method between adding the task and awaiting its completion.</para>
    /// </summary>
    public bool IsTaskCompleted(long taskId)
    {
        return NativeCalls.godot_icall_1_11(MethodBind1, GodotObject.GetPtr(this), taskId).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WaitForTaskCompletion, 844576869ul);

    /// <summary>
    /// <para>Pauses the thread that calls this method until the task with the given ID is completed.</para>
    /// <para>Returns <see cref="Godot.Error.Ok"/> if the task could be successfully awaited.</para>
    /// <para>Returns <see cref="Godot.Error.InvalidParameter"/> if a task with the passed ID does not exist (maybe because it was already awaited and disposed of).</para>
    /// <para>Returns <see cref="Godot.Error.Busy"/> if the call is made from another running task and, due to task scheduling, there's potential for deadlocking (e.g., the task to await may be at a lower level in the call stack and therefore can't progress). This is an advanced situation that should only matter when some tasks depend on others (in the current implementation, the tricky case is a task trying to wait on an older one).</para>
    /// </summary>
    public Error WaitForTaskCompletion(long taskId)
    {
        return (Error)NativeCalls.godot_icall_1_475(MethodBind2, GodotObject.GetPtr(this), taskId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.AddGroupTask, 1801953219ul);

    /// <summary>
    /// <para>Adds <paramref name="action"/> as a group task to be executed by the worker threads. The <see cref="Godot.Callable"/> will be called a number of times based on <paramref name="elements"/>, with the first thread calling it with the value <c>0</c> as a parameter, and each consecutive execution incrementing this value by 1 until it reaches <c>element - 1</c>.</para>
    /// <para>The number of threads the task is distributed to is defined by <paramref name="tasksNeeded"/>, where the default value <c>-1</c> means it is distributed to all worker threads. <paramref name="highPriority"/> determines if the task has a high priority or a low priority (default). You can optionally provide a <paramref name="description"/> to help with debugging.</para>
    /// <para>Returns a group task ID that can be used by other methods.</para>
    /// <para><b>Warning:</b> Every task must be waited for completion using <see cref="Godot.WorkerThreadPoolInstance.WaitForTaskCompletion(long)"/> or <see cref="Godot.WorkerThreadPoolInstance.WaitForGroupTaskCompletion(long)"/> at some point so that any allocated resources inside the task can be cleaned up.</para>
    /// </summary>
    public long AddGroupTask(Callable action, int elements, int tasksNeeded = -1, bool highPriority = false, string description = "")
    {
        return NativeCalls.godot_icall_5_1325(MethodBind3, GodotObject.GetPtr(this), action, elements, tasksNeeded, highPriority.ToGodotBool(), description);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsGroupTaskCompleted, 1116898809ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the group task with the given ID is completed.</para>
    /// <para><b>Note:</b> You should only call this method between adding the group task and awaiting its completion.</para>
    /// </summary>
    public bool IsGroupTaskCompleted(long groupId)
    {
        return NativeCalls.godot_icall_1_11(MethodBind4, GodotObject.GetPtr(this), groupId).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGroupProcessedElementCount, 923996154ul);

    /// <summary>
    /// <para>Returns how many times the <see cref="Godot.Callable"/> of the group task with the given ID has already been executed by the worker threads.</para>
    /// <para><b>Note:</b> If a thread has started executing the <see cref="Godot.Callable"/> but is yet to finish, it won't be counted.</para>
    /// </summary>
    public uint GetGroupProcessedElementCount(long groupId)
    {
        return NativeCalls.godot_icall_1_1326(MethodBind5, GodotObject.GetPtr(this), groupId);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.WaitForGroupTaskCompletion, 1286410249ul);

    /// <summary>
    /// <para>Pauses the thread that calls this method until the group task with the given ID is completed.</para>
    /// </summary>
    public void WaitForGroupTaskCompletion(long groupId)
    {
        NativeCalls.godot_icall_1_10(MethodBind6, GodotObject.GetPtr(this), groupId);
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
    public new class PropertyName : GodotObject.PropertyName
    {
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : GodotObject.MethodName
    {
        /// <summary>
        /// Cached name for the 'add_task' method.
        /// </summary>
        public static readonly StringName AddTask = "add_task";
        /// <summary>
        /// Cached name for the 'is_task_completed' method.
        /// </summary>
        public static readonly StringName IsTaskCompleted = "is_task_completed";
        /// <summary>
        /// Cached name for the 'wait_for_task_completion' method.
        /// </summary>
        public static readonly StringName WaitForTaskCompletion = "wait_for_task_completion";
        /// <summary>
        /// Cached name for the 'add_group_task' method.
        /// </summary>
        public static readonly StringName AddGroupTask = "add_group_task";
        /// <summary>
        /// Cached name for the 'is_group_task_completed' method.
        /// </summary>
        public static readonly StringName IsGroupTaskCompleted = "is_group_task_completed";
        /// <summary>
        /// Cached name for the 'get_group_processed_element_count' method.
        /// </summary>
        public static readonly StringName GetGroupProcessedElementCount = "get_group_processed_element_count";
        /// <summary>
        /// Cached name for the 'wait_for_group_task_completion' method.
        /// </summary>
        public static readonly StringName WaitForGroupTaskCompletion = "wait_for_group_task_completion";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
    }
}

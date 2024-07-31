namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>Applies <see cref="Godot.VisualShaderNodeUIntOp.Operator"/> to two unsigned integer inputs: <c>a</c> and <c>b</c>.</para>
/// </summary>
public partial class VisualShaderNodeUIntOp : VisualShaderNode
{
    public enum OperatorEnum : long
    {
        /// <summary>
        /// <para>Sums two numbers using <c>a + b</c>.</para>
        /// </summary>
        Add = 0,
        /// <summary>
        /// <para>Subtracts two numbers using <c>a - b</c>.</para>
        /// </summary>
        Sub = 1,
        /// <summary>
        /// <para>Multiplies two numbers using <c>a * b</c>.</para>
        /// </summary>
        Mul = 2,
        /// <summary>
        /// <para>Divides two numbers using <c>a / b</c>.</para>
        /// </summary>
        Div = 3,
        /// <summary>
        /// <para>Calculates the remainder of two numbers using <c>a % b</c>.</para>
        /// </summary>
        Mod = 4,
        /// <summary>
        /// <para>Returns the greater of two numbers. Translates to <c>max(a, b)</c> in the Godot Shader Language.</para>
        /// </summary>
        Max = 5,
        /// <summary>
        /// <para>Returns the lesser of two numbers. Translates to <c>max(a, b)</c> in the Godot Shader Language.</para>
        /// </summary>
        Min = 6,
        /// <summary>
        /// <para>Returns the result of bitwise <c>AND</c> operation on the integer. Translates to <c>a &amp; b</c> in the Godot Shader Language.</para>
        /// </summary>
        BitwiseAnd = 7,
        /// <summary>
        /// <para>Returns the result of bitwise <c>OR</c> operation for two integers. Translates to <c>a | b</c> in the Godot Shader Language.</para>
        /// </summary>
        BitwiseOr = 8,
        /// <summary>
        /// <para>Returns the result of bitwise <c>XOR</c> operation for two integers. Translates to <c>a ^ b</c> in the Godot Shader Language.</para>
        /// </summary>
        BitwiseXor = 9,
        /// <summary>
        /// <para>Returns the result of bitwise left shift operation on the integer. Translates to <c>a &lt;&lt; b</c> in the Godot Shader Language.</para>
        /// </summary>
        BitwiseLeftShift = 10,
        /// <summary>
        /// <para>Returns the result of bitwise right shift operation on the integer. Translates to <c>a &gt;&gt; b</c> in the Godot Shader Language.</para>
        /// </summary>
        BitwiseRightShift = 11,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.VisualShaderNodeUIntOp.OperatorEnum"/> enum.</para>
        /// </summary>
        EnumSize = 12
    }

    /// <summary>
    /// <para>An operator to be applied to the inputs. See <see cref="Godot.VisualShaderNodeUIntOp.OperatorEnum"/> for options.</para>
    /// </summary>
    public VisualShaderNodeUIntOp.OperatorEnum Operator
    {
        get
        {
            return GetOperator();
        }
        set
        {
            SetOperator(value);
        }
    }

    private static readonly System.Type CachedType = typeof(VisualShaderNodeUIntOp);

    private static readonly StringName NativeName = "VisualShaderNodeUIntOp";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public VisualShaderNodeUIntOp() : this(true)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: true);
        }
    }

    internal VisualShaderNodeUIntOp(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOperator, 3463048345ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetOperator(VisualShaderNodeUIntOp.OperatorEnum op)
    {
        NativeCalls.godot_icall_1_36(MethodBind0, GodotObject.GetPtr(this), (int)op);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOperator, 256631461ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public VisualShaderNodeUIntOp.OperatorEnum GetOperator()
    {
        return (VisualShaderNodeUIntOp.OperatorEnum)NativeCalls.godot_icall_0_37(MethodBind1, GodotObject.GetPtr(this));
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
    public new class PropertyName : VisualShaderNode.PropertyName
    {
        /// <summary>
        /// Cached name for the 'operator' property.
        /// </summary>
        public static readonly StringName Operator = "operator";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : VisualShaderNode.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_operator' method.
        /// </summary>
        public static readonly StringName SetOperator = "set_operator";
        /// <summary>
        /// Cached name for the 'get_operator' method.
        /// </summary>
        public static readonly StringName GetOperator = "get_operator";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : VisualShaderNode.SignalName
    {
    }
}

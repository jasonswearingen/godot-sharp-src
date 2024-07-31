namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para><see cref="Godot.RenderingDevice"/> is an abstraction for working with modern low-level graphics APIs such as Vulkan. Compared to <see cref="Godot.RenderingServer"/> (which works with Godot's own rendering subsystems), <see cref="Godot.RenderingDevice"/> is much lower-level and allows working more directly with the underlying graphics APIs. <see cref="Godot.RenderingDevice"/> is used in Godot to provide support for several modern low-level graphics APIs while reducing the amount of code duplication required. <see cref="Godot.RenderingDevice"/> can also be used in your own projects to perform things that are not exposed by <see cref="Godot.RenderingServer"/> or high-level nodes, such as using compute shaders.</para>
/// <para>On startup, Godot creates a global <see cref="Godot.RenderingDevice"/> which can be retrieved using <see cref="Godot.RenderingServer.GetRenderingDevice()"/>. This global <see cref="Godot.RenderingDevice"/> performs drawing to the screen.</para>
/// <para><b>Local RenderingDevices:</b> Using <see cref="Godot.RenderingServer.CreateLocalRenderingDevice()"/>, you can create "secondary" rendering devices to perform drawing and GPU compute operations on separate threads.</para>
/// <para><b>Note:</b> <see cref="Godot.RenderingDevice"/> assumes intermediate knowledge of modern graphics APIs such as Vulkan, Direct3D 12, Metal or WebGPU. These graphics APIs are lower-level than OpenGL or Direct3D 11, requiring you to perform what was previously done by the graphics driver itself. If you have difficulty understanding the concepts used in this class, follow the <a href="https://vulkan-tutorial.com/">Vulkan Tutorial</a> or <a href="https://vkguide.dev/">Vulkan Guide</a>. It's recommended to have existing modern OpenGL or Direct3D 11 knowledge before attempting to learn a low-level graphics API.</para>
/// <para><b>Note:</b> <see cref="Godot.RenderingDevice"/> is not available when running in headless mode or when using the Compatibility rendering method.</para>
/// </summary>
public partial class RenderingDevice : GodotObject
{
    /// <summary>
    /// <para>Returned by functions that return an ID if a value is invalid.</para>
    /// </summary>
    public const long InvalidId = -1;
    /// <summary>
    /// <para>Returned by functions that return a format ID if a value is invalid.</para>
    /// </summary>
    public const long InvalidFormatId = -1;

    public enum DeviceType : long
    {
        /// <summary>
        /// <para>Rendering device type does not match any of the other enum values or is unknown.</para>
        /// </summary>
        Other = 0,
        /// <summary>
        /// <para>Rendering device is an integrated GPU, which is typically <i>(but not always)</i> slower than dedicated GPUs (<see cref="Godot.RenderingDevice.DeviceType.DiscreteGpu"/>). On Android and iOS, the rendering device type is always considered to be <see cref="Godot.RenderingDevice.DeviceType.IntegratedGpu"/>.</para>
        /// </summary>
        IntegratedGpu = 1,
        /// <summary>
        /// <para>Rendering device is a dedicated GPU, which is typically <i>(but not always)</i> faster than integrated GPUs (<see cref="Godot.RenderingDevice.DeviceType.IntegratedGpu"/>).</para>
        /// </summary>
        DiscreteGpu = 2,
        /// <summary>
        /// <para>Rendering device is an emulated GPU in a virtual environment. This is typically much slower than the host GPU, which means the expected performance level on a dedicated GPU will be roughly equivalent to <see cref="Godot.RenderingDevice.DeviceType.IntegratedGpu"/>. Virtual machine GPU passthrough (such as VFIO) will not report the device type as <see cref="Godot.RenderingDevice.DeviceType.VirtualGpu"/>. Instead, the host GPU's device type will be reported as if the GPU was not emulated.</para>
        /// </summary>
        VirtualGpu = 3,
        /// <summary>
        /// <para>Rendering device is provided by software emulation (such as Lavapipe or <a href="https://github.com/google/swiftshader">SwiftShader</a>). This is the slowest kind of rendering device available; it's typically much slower than <see cref="Godot.RenderingDevice.DeviceType.IntegratedGpu"/>.</para>
        /// </summary>
        Cpu = 4,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.DeviceType"/> enum.</para>
        /// </summary>
        Max = 5
    }

    public enum DriverResource : long
    {
        /// <summary>
        /// <para>Specific device object based on a physical device.</para>
        /// <para>- Vulkan: Vulkan device driver resource (<c>VkDevice</c>). (<c>rid</c> argument doesn't apply.)</para>
        /// </summary>
        LogicalDevice = 0,
        /// <summary>
        /// <para>Physical device the specific logical device is based on.</para>
        /// <para>- Vulkan: <c>VkDevice</c>. (<c>rid</c> argument doesn't apply.)</para>
        /// </summary>
        PhysicalDevice = 1,
        /// <summary>
        /// <para>Top-most graphics API entry object.</para>
        /// <para>- Vulkan: <c>VkInstance</c>. (<c>rid</c> argument doesn't apply.)</para>
        /// </summary>
        TopmostObject = 2,
        /// <summary>
        /// <para>The main graphics-compute command queue.</para>
        /// <para>- Vulkan: <c>VkQueue</c>. (<c>rid</c> argument doesn't apply.)</para>
        /// </summary>
        CommandQueue = 3,
        /// <summary>
        /// <para>The specific family the main queue belongs to.</para>
        /// <para>- Vulkan: the queue family index, an <c>uint32_t</c>. (<c>rid</c> argument doesn't apply.)</para>
        /// </summary>
        QueueFamily = 4,
        /// <summary>
        /// <para>- Vulkan: <c>VkImage</c>.</para>
        /// </summary>
        Texture = 5,
        /// <summary>
        /// <para>The view of an owned or shared texture.</para>
        /// <para>- Vulkan: <c>VkImageView</c>.</para>
        /// </summary>
        TextureView = 6,
        /// <summary>
        /// <para>The native id of the data format of the texture.</para>
        /// <para>- Vulkan: <c>VkFormat</c>.</para>
        /// </summary>
        TextureDataFormat = 7,
        /// <summary>
        /// <para>- Vulkan: <c>VkSampler</c>.</para>
        /// </summary>
        Sampler = 8,
        /// <summary>
        /// <para>- Vulkan: <c>VkDescriptorSet</c>.</para>
        /// </summary>
        UniformSet = 9,
        /// <summary>
        /// <para>Buffer of any kind of (storage, vertex, etc.).</para>
        /// <para>- Vulkan: <c>VkBuffer</c>.</para>
        /// </summary>
        Buffer = 10,
        /// <summary>
        /// <para>- Vulkan: <c>VkPipeline</c>.</para>
        /// </summary>
        ComputePipeline = 11,
        /// <summary>
        /// <para>- Vulkan: <c>VkPipeline</c>.</para>
        /// </summary>
        RenderPipeline = 12,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.LogicalDevice' instead.")]
        VulkanDevice = 0,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.PhysicalDevice' instead.")]
        VulkanPhysicalDevice = 1,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.TopmostObject' instead.")]
        VulkanInstance = 2,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.CommandQueue' instead.")]
        VulkanQueue = 3,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.QueueFamily' instead.")]
        VulkanQueueFamilyIndex = 4,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.Texture' instead.")]
        VulkanImage = 5,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.TextureView' instead.")]
        VulkanImageView = 6,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.TextureDataFormat' instead.")]
        VulkanImageNativeTextureFormat = 7,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.Sampler' instead.")]
        VulkanSampler = 8,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.UniformSet' instead.")]
        VulkanDescriptorSet = 9,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.Buffer' instead.")]
        VulkanBuffer = 10,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.ComputePipeline' instead.")]
        VulkanComputePipeline = 11,
        [Obsolete("Use 'Godot.RenderingDevice.DriverResource.RenderPipeline' instead.")]
        VulkanRenderPipeline = 12
    }

    public enum DataFormat : long
    {
        /// <summary>
        /// <para>4-bit-per-channel red/green channel data format, packed into 8 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// <para><b>Note:</b> More information on all data formats can be found on the <a href="https://registry.khronos.org/vulkan/specs/1.1/html/vkspec.html#_identification_of_formats">Identification of formats</a> section of the Vulkan specification, as well as the <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFormat.html">VkFormat</a> enum.</para>
        /// </summary>
        R4G4UnormPack8 = 0,
        /// <summary>
        /// <para>4-bit-per-channel red/green/blue/alpha channel data format, packed into 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R4G4B4A4UnormPack16 = 1,
        /// <summary>
        /// <para>4-bit-per-channel blue/green/red/alpha channel data format, packed into 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        B4G4R4A4UnormPack16 = 2,
        /// <summary>
        /// <para>Red/green/blue channel data format with 5 bits of red, 6 bits of green and 5 bits of blue, packed into 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R5G6B5UnormPack16 = 3,
        /// <summary>
        /// <para>Blue/green/red channel data format with 5 bits of blue, 6 bits of green and 5 bits of red, packed into 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        B5G6R5UnormPack16 = 4,
        /// <summary>
        /// <para>Red/green/blue/alpha channel data format with 5 bits of red, 6 bits of green, 5 bits of blue and 1 bit of alpha, packed into 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R5G5B5A1UnormPack16 = 5,
        /// <summary>
        /// <para>Blue/green/red/alpha channel data format with 5 bits of blue, 6 bits of green, 5 bits of red and 1 bit of alpha, packed into 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        B5G5R5A1UnormPack16 = 6,
        /// <summary>
        /// <para>Alpha/red/green/blue channel data format with 1 bit of alpha, 5 bits of red, 6 bits of green and 5 bits of blue, packed into 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        A1R5G5B5UnormPack16 = 7,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R8Unorm = 8,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point red channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        R8Snorm = 9,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 255.0]</c> range.</para>
        /// </summary>
        R8Uscaled = 10,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point red channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-127.0, 127.0]</c> range.</para>
        /// </summary>
        R8Sscaled = 11,
        /// <summary>
        /// <para>8-bit-per-channel unsigned integer red channel data format. Values are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        R8Uint = 12,
        /// <summary>
        /// <para>8-bit-per-channel signed integer red channel data format. Values are in the <c>[-127, 127]</c> range.</para>
        /// </summary>
        R8Sint = 13,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R8Srgb = 14,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8Unorm = 15,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point red/green channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8Snorm = 16,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 255.0]</c> range.</para>
        /// </summary>
        R8G8Uscaled = 17,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point red/green channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-127.0, 127.0]</c> range.</para>
        /// </summary>
        R8G8Sscaled = 18,
        /// <summary>
        /// <para>8-bit-per-channel unsigned integer red/green channel data format. Values are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        R8G8Uint = 19,
        /// <summary>
        /// <para>8-bit-per-channel signed integer red/green channel data format. Values are in the <c>[-127, 127]</c> range.</para>
        /// </summary>
        R8G8Sint = 20,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8Srgb = 21,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green/blue channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8B8Unorm = 22,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point red/green/blue channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8B8Snorm = 23,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green/blue channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 255.0]</c> range.</para>
        /// </summary>
        R8G8B8Uscaled = 24,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point red/green/blue channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-127.0, 127.0]</c> range.</para>
        /// </summary>
        R8G8B8Sscaled = 25,
        /// <summary>
        /// <para>8-bit-per-channel unsigned integer red/green/blue channel data format. Values are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        R8G8B8Uint = 26,
        /// <summary>
        /// <para>8-bit-per-channel signed integer red/green/blue channel data format. Values are in the <c>[-127, 127]</c> range.</para>
        /// </summary>
        R8G8B8Sint = 27,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green/blue/blue channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8B8Srgb = 28,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point blue/green/red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        B8G8R8Unorm = 29,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point blue/green/red channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        B8G8R8Snorm = 30,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point blue/green/red channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 255.0]</c> range.</para>
        /// </summary>
        B8G8R8Uscaled = 31,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point blue/green/red channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-127.0, 127.0]</c> range.</para>
        /// </summary>
        B8G8R8Sscaled = 32,
        /// <summary>
        /// <para>8-bit-per-channel unsigned integer blue/green/red channel data format. Values are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        B8G8R8Uint = 33,
        /// <summary>
        /// <para>8-bit-per-channel signed integer blue/green/red channel data format. Values are in the <c>[-127, 127]</c> range.</para>
        /// </summary>
        B8G8R8Sint = 34,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point blue/green/red data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        B8G8R8Srgb = 35,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green/blue/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8B8A8Unorm = 36,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point red/green/blue/alpha channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8B8A8Snorm = 37,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green/blue/alpha channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 255.0]</c> range.</para>
        /// </summary>
        R8G8B8A8Uscaled = 38,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point red/green/blue/alpha channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-127.0, 127.0]</c> range.</para>
        /// </summary>
        R8G8B8A8Sscaled = 39,
        /// <summary>
        /// <para>8-bit-per-channel unsigned integer red/green/blue/alpha channel data format. Values are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        R8G8B8A8Uint = 40,
        /// <summary>
        /// <para>8-bit-per-channel signed integer red/green/blue/alpha channel data format. Values are in the <c>[-127, 127]</c> range.</para>
        /// </summary>
        R8G8B8A8Sint = 41,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point red/green/blue/alpha channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R8G8B8A8Srgb = 42,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point blue/green/red/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        B8G8R8A8Unorm = 43,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point blue/green/red/alpha channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        B8G8R8A8Snorm = 44,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point blue/green/red/alpha channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 255.0]</c> range.</para>
        /// </summary>
        B8G8R8A8Uscaled = 45,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point blue/green/red/alpha channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-127.0, 127.0]</c> range.</para>
        /// </summary>
        B8G8R8A8Sscaled = 46,
        /// <summary>
        /// <para>8-bit-per-channel unsigned integer blue/green/red/alpha channel data format. Values are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        B8G8R8A8Uint = 47,
        /// <summary>
        /// <para>8-bit-per-channel signed integer blue/green/red/alpha channel data format. Values are in the <c>[-127, 127]</c> range.</para>
        /// </summary>
        B8G8R8A8Sint = 48,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point blue/green/red/alpha channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        B8G8R8A8Srgb = 49,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point alpha/red/green/blue channel data format with normalized value, packed in 32 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        A8B8G8R8UnormPack32 = 50,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point alpha/red/green/blue channel data format with normalized value, packed in 32 bits. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        A8B8G8R8SnormPack32 = 51,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point alpha/red/green/blue channel data format with scaled value (value is converted from integer to float), packed in 32 bits. Values are in the <c>[0.0, 255.0]</c> range.</para>
        /// </summary>
        A8B8G8R8UscaledPack32 = 52,
        /// <summary>
        /// <para>8-bit-per-channel signed floating-point alpha/red/green/blue channel data format with scaled value (value is converted from integer to float), packed in 32 bits. Values are in the <c>[-127.0, 127.0]</c> range.</para>
        /// </summary>
        A8B8G8R8SscaledPack32 = 53,
        /// <summary>
        /// <para>8-bit-per-channel unsigned integer alpha/red/green/blue channel data format, packed in 32 bits. Values are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        A8B8G8R8UintPack32 = 54,
        /// <summary>
        /// <para>8-bit-per-channel signed integer alpha/red/green/blue channel data format, packed in 32 bits. Values are in the <c>[-127, 127]</c> range.</para>
        /// </summary>
        A8B8G8R8SintPack32 = 55,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point alpha/red/green/blue channel data format with normalized value and non-linear sRGB encoding, packed in 32 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        A8B8G8R8SrgbPack32 = 56,
        /// <summary>
        /// <para>Unsigned floating-point alpha/red/green/blue channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of red, 10 bits of green and 10 bits of blue. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        A2R10G10B10UnormPack32 = 57,
        /// <summary>
        /// <para>Signed floating-point alpha/red/green/blue channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of red, 10 bits of green and 10 bits of blue. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        A2R10G10B10SnormPack32 = 58,
        /// <summary>
        /// <para>Unsigned floating-point alpha/red/green/blue channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of red, 10 bits of green and 10 bits of blue. Values are in the <c>[0.0, 1023.0]</c> range for red/green/blue and <c>[0.0, 3.0]</c> for alpha.</para>
        /// </summary>
        A2R10G10B10UscaledPack32 = 59,
        /// <summary>
        /// <para>Signed floating-point alpha/red/green/blue channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of red, 10 bits of green and 10 bits of blue. Values are in the <c>[-511.0, 511.0]</c> range for red/green/blue and <c>[-1.0, 1.0]</c> for alpha.</para>
        /// </summary>
        A2R10G10B10SscaledPack32 = 60,
        /// <summary>
        /// <para>Unsigned integer alpha/red/green/blue channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of red, 10 bits of green and 10 bits of blue. Values are in the <c>[0, 1023]</c> range for red/green/blue and <c>[0, 3]</c> for alpha.</para>
        /// </summary>
        A2R10G10B10UintPack32 = 61,
        /// <summary>
        /// <para>Signed integer alpha/red/green/blue channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of red, 10 bits of green and 10 bits of blue. Values are in the <c>[-511, 511]</c> range for red/green/blue and <c>[-1, 1]</c> for alpha.</para>
        /// </summary>
        A2R10G10B10SintPack32 = 62,
        /// <summary>
        /// <para>Unsigned floating-point alpha/blue/green/red channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of blue, 10 bits of green and 10 bits of red. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        A2B10G10R10UnormPack32 = 63,
        /// <summary>
        /// <para>Signed floating-point alpha/blue/green/red channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of blue, 10 bits of green and 10 bits of red. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        A2B10G10R10SnormPack32 = 64,
        /// <summary>
        /// <para>Unsigned floating-point alpha/blue/green/red channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of blue, 10 bits of green and 10 bits of red. Values are in the <c>[0.0, 1023.0]</c> range for blue/green/red and <c>[0.0, 3.0]</c> for alpha.</para>
        /// </summary>
        A2B10G10R10UscaledPack32 = 65,
        /// <summary>
        /// <para>Signed floating-point alpha/blue/green/red channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of blue, 10 bits of green and 10 bits of red. Values are in the <c>[-511.0, 511.0]</c> range for blue/green/red and <c>[-1.0, 1.0]</c> for alpha.</para>
        /// </summary>
        A2B10G10R10SscaledPack32 = 66,
        /// <summary>
        /// <para>Unsigned integer alpha/blue/green/red channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of blue, 10 bits of green and 10 bits of red. Values are in the <c>[0, 1023]</c> range for blue/green/red and <c>[0, 3]</c> for alpha.</para>
        /// </summary>
        A2B10G10R10UintPack32 = 67,
        /// <summary>
        /// <para>Signed integer alpha/blue/green/red channel data format with normalized value, packed in 32 bits. Format contains 2 bits of alpha, 10 bits of blue, 10 bits of green and 10 bits of red. Values are in the <c>[-511, 511]</c> range for blue/green/red and <c>[-1, 1]</c> for alpha.</para>
        /// </summary>
        A2B10G10R10SintPack32 = 68,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R16Unorm = 69,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        R16Snorm = 70,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point red channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 65535.0]</c> range.</para>
        /// </summary>
        R16Uscaled = 71,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-32767.0, 32767.0]</c> range.</para>
        /// </summary>
        R16Sscaled = 72,
        /// <summary>
        /// <para>16-bit-per-channel unsigned integer red channel data format. Values are in the <c>[0.0, 65535]</c> range.</para>
        /// </summary>
        R16Uint = 73,
        /// <summary>
        /// <para>16-bit-per-channel signed integer red channel data format. Values are in the <c>[-32767, 32767]</c> range.</para>
        /// </summary>
        R16Sint = 74,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red channel data format with the value stored as-is.</para>
        /// </summary>
        R16Sfloat = 75,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point red/green channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R16G16Unorm = 76,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        R16G16Snorm = 77,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point red/green channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 65535.0]</c> range.</para>
        /// </summary>
        R16G16Uscaled = 78,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-32767.0, 32767.0]</c> range.</para>
        /// </summary>
        R16G16Sscaled = 79,
        /// <summary>
        /// <para>16-bit-per-channel unsigned integer red/green channel data format. Values are in the <c>[0.0, 65535]</c> range.</para>
        /// </summary>
        R16G16Uint = 80,
        /// <summary>
        /// <para>16-bit-per-channel signed integer red/green channel data format. Values are in the <c>[-32767, 32767]</c> range.</para>
        /// </summary>
        R16G16Sint = 81,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green channel data format with the value stored as-is.</para>
        /// </summary>
        R16G16Sfloat = 82,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point red/green/blue channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R16G16B16Unorm = 83,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green/blue channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        R16G16B16Snorm = 84,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point red/green/blue channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 65535.0]</c> range.</para>
        /// </summary>
        R16G16B16Uscaled = 85,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green/blue channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-32767.0, 32767.0]</c> range.</para>
        /// </summary>
        R16G16B16Sscaled = 86,
        /// <summary>
        /// <para>16-bit-per-channel unsigned integer red/green/blue channel data format. Values are in the <c>[0.0, 65535]</c> range.</para>
        /// </summary>
        R16G16B16Uint = 87,
        /// <summary>
        /// <para>16-bit-per-channel signed integer red/green/blue channel data format. Values are in the <c>[-32767, 32767]</c> range.</para>
        /// </summary>
        R16G16B16Sint = 88,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green/blue channel data format with the value stored as-is.</para>
        /// </summary>
        R16G16B16Sfloat = 89,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point red/green/blue/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R16G16B16A16Unorm = 90,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green/blue/alpha channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range.</para>
        /// </summary>
        R16G16B16A16Snorm = 91,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point red/green/blue/alpha channel data format with scaled value (value is converted from integer to float). Values are in the <c>[0.0, 65535.0]</c> range.</para>
        /// </summary>
        R16G16B16A16Uscaled = 92,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green/blue/alpha channel data format with scaled value (value is converted from integer to float). Values are in the <c>[-32767.0, 32767.0]</c> range.</para>
        /// </summary>
        R16G16B16A16Sscaled = 93,
        /// <summary>
        /// <para>16-bit-per-channel unsigned integer red/green/blue/alpha channel data format. Values are in the <c>[0.0, 65535]</c> range.</para>
        /// </summary>
        R16G16B16A16Uint = 94,
        /// <summary>
        /// <para>16-bit-per-channel signed integer red/green/blue/alpha channel data format. Values are in the <c>[-32767, 32767]</c> range.</para>
        /// </summary>
        R16G16B16A16Sint = 95,
        /// <summary>
        /// <para>16-bit-per-channel signed floating-point red/green/blue/alpha channel data format with the value stored as-is.</para>
        /// </summary>
        R16G16B16A16Sfloat = 96,
        /// <summary>
        /// <para>32-bit-per-channel unsigned integer red channel data format. Values are in the <c>[0, 2^32 - 1]</c> range.</para>
        /// </summary>
        R32Uint = 97,
        /// <summary>
        /// <para>32-bit-per-channel signed integer red channel data format. Values are in the <c>[2^31 + 1, 2^31 - 1]</c> range.</para>
        /// </summary>
        R32Sint = 98,
        /// <summary>
        /// <para>32-bit-per-channel signed floating-point red channel data format with the value stored as-is.</para>
        /// </summary>
        R32Sfloat = 99,
        /// <summary>
        /// <para>32-bit-per-channel unsigned integer red/green channel data format. Values are in the <c>[0, 2^32 - 1]</c> range.</para>
        /// </summary>
        R32G32Uint = 100,
        /// <summary>
        /// <para>32-bit-per-channel signed integer red/green channel data format. Values are in the <c>[2^31 + 1, 2^31 - 1]</c> range.</para>
        /// </summary>
        R32G32Sint = 101,
        /// <summary>
        /// <para>32-bit-per-channel signed floating-point red/green channel data format with the value stored as-is.</para>
        /// </summary>
        R32G32Sfloat = 102,
        /// <summary>
        /// <para>32-bit-per-channel unsigned integer red/green/blue channel data format. Values are in the <c>[0, 2^32 - 1]</c> range.</para>
        /// </summary>
        R32G32B32Uint = 103,
        /// <summary>
        /// <para>32-bit-per-channel signed integer red/green/blue channel data format. Values are in the <c>[2^31 + 1, 2^31 - 1]</c> range.</para>
        /// </summary>
        R32G32B32Sint = 104,
        /// <summary>
        /// <para>32-bit-per-channel signed floating-point red/green/blue channel data format with the value stored as-is.</para>
        /// </summary>
        R32G32B32Sfloat = 105,
        /// <summary>
        /// <para>32-bit-per-channel unsigned integer red/green/blue/alpha channel data format. Values are in the <c>[0, 2^32 - 1]</c> range.</para>
        /// </summary>
        R32G32B32A32Uint = 106,
        /// <summary>
        /// <para>32-bit-per-channel signed integer red/green/blue/alpha channel data format. Values are in the <c>[2^31 + 1, 2^31 - 1]</c> range.</para>
        /// </summary>
        R32G32B32A32Sint = 107,
        /// <summary>
        /// <para>32-bit-per-channel signed floating-point red/green/blue/alpha channel data format with the value stored as-is.</para>
        /// </summary>
        R32G32B32A32Sfloat = 108,
        /// <summary>
        /// <para>64-bit-per-channel unsigned integer red channel data format. Values are in the <c>[0, 2^64 - 1]</c> range.</para>
        /// </summary>
        R64Uint = 109,
        /// <summary>
        /// <para>64-bit-per-channel signed integer red channel data format. Values are in the <c>[2^63 + 1, 2^63 - 1]</c> range.</para>
        /// </summary>
        R64Sint = 110,
        /// <summary>
        /// <para>64-bit-per-channel signed floating-point red channel data format with the value stored as-is.</para>
        /// </summary>
        R64Sfloat = 111,
        /// <summary>
        /// <para>64-bit-per-channel unsigned integer red/green channel data format. Values are in the <c>[0, 2^64 - 1]</c> range.</para>
        /// </summary>
        R64G64Uint = 112,
        /// <summary>
        /// <para>64-bit-per-channel signed integer red/green channel data format. Values are in the <c>[2^63 + 1, 2^63 - 1]</c> range.</para>
        /// </summary>
        R64G64Sint = 113,
        /// <summary>
        /// <para>64-bit-per-channel signed floating-point red/green channel data format with the value stored as-is.</para>
        /// </summary>
        R64G64Sfloat = 114,
        /// <summary>
        /// <para>64-bit-per-channel unsigned integer red/green/blue channel data format. Values are in the <c>[0, 2^64 - 1]</c> range.</para>
        /// </summary>
        R64G64B64Uint = 115,
        /// <summary>
        /// <para>64-bit-per-channel signed integer red/green/blue channel data format. Values are in the <c>[2^63 + 1, 2^63 - 1]</c> range.</para>
        /// </summary>
        R64G64B64Sint = 116,
        /// <summary>
        /// <para>64-bit-per-channel signed floating-point red/green/blue channel data format with the value stored as-is.</para>
        /// </summary>
        R64G64B64Sfloat = 117,
        /// <summary>
        /// <para>64-bit-per-channel unsigned integer red/green/blue/alpha channel data format. Values are in the <c>[0, 2^64 - 1]</c> range.</para>
        /// </summary>
        R64G64B64A64Uint = 118,
        /// <summary>
        /// <para>64-bit-per-channel signed integer red/green/blue/alpha channel data format. Values are in the <c>[2^63 + 1, 2^63 - 1]</c> range.</para>
        /// </summary>
        R64G64B64A64Sint = 119,
        /// <summary>
        /// <para>64-bit-per-channel signed floating-point red/green/blue/alpha channel data format with the value stored as-is.</para>
        /// </summary>
        R64G64B64A64Sfloat = 120,
        /// <summary>
        /// <para>Unsigned floating-point blue/green/red data format with the value stored as-is, packed in 32 bits. The format's precision is 10 bits of blue channel, 11 bits of green channel and 11 bits of red channel.</para>
        /// </summary>
        B10G11R11UfloatPack32 = 121,
        /// <summary>
        /// <para>Unsigned floating-point exposure/blue/green/red data format with the value stored as-is, packed in 32 bits. The format's precision is 5 bits of exposure, 9 bits of blue channel, 9 bits of green channel and 9 bits of red channel.</para>
        /// </summary>
        E5B9G9R9UfloatPack32 = 122,
        /// <summary>
        /// <para>16-bit unsigned floating-point depth data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        D16Unorm = 123,
        /// <summary>
        /// <para>24-bit unsigned floating-point depth data format with normalized value, plus 8 unused bits, packed in 32 bits. Values for depth are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        X8D24UnormPack32 = 124,
        /// <summary>
        /// <para>32-bit signed floating-point depth data format with the value stored as-is.</para>
        /// </summary>
        D32Sfloat = 125,
        /// <summary>
        /// <para>8-bit unsigned integer stencil data format.</para>
        /// </summary>
        S8Uint = 126,
        /// <summary>
        /// <para>16-bit unsigned floating-point depth data format with normalized value, plus 8 bits of stencil in unsigned integer format. Values for depth are in the <c>[0.0, 1.0]</c> range. Values for stencil are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        D16UnormS8Uint = 127,
        /// <summary>
        /// <para>24-bit unsigned floating-point depth data format with normalized value, plus 8 bits of stencil in unsigned integer format. Values for depth are in the <c>[0.0, 1.0]</c> range. Values for stencil are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        D24UnormS8Uint = 128,
        /// <summary>
        /// <para>32-bit signed floating-point depth data format with the value stored as-is, plus 8 bits of stencil in unsigned integer format. Values for stencil are in the <c>[0, 255]</c> range.</para>
        /// </summary>
        D32SfloatS8Uint = 129,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 5 bits of red channel, 6 bits of green channel and 5 bits of blue channel. Using BC1 texture compression (also known as S3TC DXT1).</para>
        /// </summary>
        Bc1RgbUnormBlock = 130,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 5 bits of red channel, 6 bits of green channel and 5 bits of blue channel. Using BC1 texture compression (also known as S3TC DXT1).</para>
        /// </summary>
        Bc1RgbSrgbBlock = 131,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 5 bits of red channel, 6 bits of green channel, 5 bits of blue channel and 1 bit of alpha channel. Using BC1 texture compression (also known as S3TC DXT1).</para>
        /// </summary>
        Bc1RgbaUnormBlock = 132,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 5 bits of red channel, 6 bits of green channel, 5 bits of blue channel and 1 bit of alpha channel. Using BC1 texture compression (also known as S3TC DXT1).</para>
        /// </summary>
        Bc1RgbaSrgbBlock = 133,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 5 bits of red channel, 6 bits of green channel, 5 bits of blue channel and 4 bits of alpha channel. Using BC2 texture compression (also known as S3TC DXT3).</para>
        /// </summary>
        Bc2UnormBlock = 134,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 5 bits of red channel, 6 bits of green channel, 5 bits of blue channel and 4 bits of alpha channel. Using BC2 texture compression (also known as S3TC DXT3).</para>
        /// </summary>
        Bc2SrgbBlock = 135,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 5 bits of red channel, 6 bits of green channel, 5 bits of blue channel and 8 bits of alpha channel. Using BC3 texture compression (also known as S3TC DXT5).</para>
        /// </summary>
        Bc3UnormBlock = 136,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 5 bits of red channel, 6 bits of green channel, 5 bits of blue channel and 8 bits of alpha channel. Using BC3 texture compression (also known as S3TC DXT5).</para>
        /// </summary>
        Bc3SrgbBlock = 137,
        /// <summary>
        /// <para>VRAM-compressed unsigned red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 8 bits of red channel. Using BC4 texture compression.</para>
        /// </summary>
        Bc4UnormBlock = 138,
        /// <summary>
        /// <para>VRAM-compressed signed red channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range. The format's precision is 8 bits of red channel. Using BC4 texture compression.</para>
        /// </summary>
        Bc4SnormBlock = 139,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is 8 bits of red channel and 8 bits of green channel. Using BC5 texture compression (also known as S3TC RGTC).</para>
        /// </summary>
        Bc5UnormBlock = 140,
        /// <summary>
        /// <para>VRAM-compressed signed red/green channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range. The format's precision is 8 bits of red channel and 8 bits of green channel. Using BC5 texture compression (also known as S3TC RGTC).</para>
        /// </summary>
        Bc5SnormBlock = 141,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue channel data format with the floating-point value stored as-is. The format's precision is between 10 and 13 bits for the red/green/blue channels. Using BC6H texture compression (also known as BPTC HDR).</para>
        /// </summary>
        Bc6HUfloatBlock = 142,
        /// <summary>
        /// <para>VRAM-compressed signed red/green/blue channel data format with the floating-point value stored as-is. The format's precision is between 10 and 13 bits for the red/green/blue channels. Using BC6H texture compression (also known as BPTC HDR).</para>
        /// </summary>
        Bc6HSfloatBlock = 143,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is between 4 and 7 bits for the red/green/blue channels and between 0 and 8 bits for the alpha channel. Also known as BPTC LDR.</para>
        /// </summary>
        Bc7UnormBlock = 144,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range. The format's precision is between 4 and 7 bits for the red/green/blue channels and between 0 and 8 bits for the alpha channel. Also known as BPTC LDR.</para>
        /// </summary>
        Bc7SrgbBlock = 145,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Using ETC2 texture compression.</para>
        /// </summary>
        Etc2R8G8B8UnormBlock = 146,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range. Using ETC2 texture compression.</para>
        /// </summary>
        Etc2R8G8B8SrgbBlock = 147,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Red/green/blue use 8 bit of precision each, with alpha using 1 bit of precision. Using ETC2 texture compression.</para>
        /// </summary>
        Etc2R8G8B8A1UnormBlock = 148,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range. Red/green/blue use 8 bit of precision each, with alpha using 1 bit of precision. Using ETC2 texture compression.</para>
        /// </summary>
        Etc2R8G8B8A1SrgbBlock = 149,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Red/green/blue use 8 bits of precision each, with alpha using 8 bits of precision. Using ETC2 texture compression.</para>
        /// </summary>
        Etc2R8G8B8A8UnormBlock = 150,
        /// <summary>
        /// <para>VRAM-compressed unsigned red/green/blue/alpha channel data format with normalized value and non-linear sRGB encoding. Values are in the <c>[0.0, 1.0]</c> range. Red/green/blue use 8 bits of precision each, with alpha using 8 bits of precision. Using ETC2 texture compression.</para>
        /// </summary>
        Etc2R8G8B8A8SrgbBlock = 151,
        /// <summary>
        /// <para>11-bit VRAM-compressed unsigned red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Using ETC2 texture compression.</para>
        /// </summary>
        EacR11UnormBlock = 152,
        /// <summary>
        /// <para>11-bit VRAM-compressed signed red channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range. Using ETC2 texture compression.</para>
        /// </summary>
        EacR11SnormBlock = 153,
        /// <summary>
        /// <para>11-bit VRAM-compressed unsigned red/green channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Using ETC2 texture compression.</para>
        /// </summary>
        EacR11G11UnormBlock = 154,
        /// <summary>
        /// <para>11-bit VRAM-compressed signed red/green channel data format with normalized value. Values are in the <c>[-1.0, 1.0]</c> range. Using ETC2 texture compression.</para>
        /// </summary>
        EacR11G11SnormBlock = 155,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 4×4 blocks (highest quality). Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc4X4UnormBlock = 156,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 4×4 blocks (highest quality). Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc4X4SrgbBlock = 157,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 5×4 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc5X4UnormBlock = 158,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 5×4 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc5X4SrgbBlock = 159,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 5×5 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc5X5UnormBlock = 160,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 5×5 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc5X5SrgbBlock = 161,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 6×5 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc6X5UnormBlock = 162,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 6×5 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc6X5SrgbBlock = 163,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 6×6 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc6X6UnormBlock = 164,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 6×6 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc6X6SrgbBlock = 165,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 8×5 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc8X5UnormBlock = 166,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 8×5 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc8X5SrgbBlock = 167,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 8×6 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc8X6UnormBlock = 168,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 8×6 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc8X6SrgbBlock = 169,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 8×8 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc8X8UnormBlock = 170,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 8×8 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc8X8SrgbBlock = 171,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 10×5 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc10X5UnormBlock = 172,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 10×5 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc10X5SrgbBlock = 173,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 10×6 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc10X6UnormBlock = 174,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 10×6 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc10X6SrgbBlock = 175,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 10×8 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc10X8UnormBlock = 176,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 10×8 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc10X8SrgbBlock = 177,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 10×10 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc10X10UnormBlock = 178,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 10×10 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc10X10SrgbBlock = 179,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 12×10 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc12X10UnormBlock = 180,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 12×10 blocks. Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc12X10SrgbBlock = 181,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value, packed in 12 blocks (lowest quality). Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc12X12UnormBlock = 182,
        /// <summary>
        /// <para>VRAM-compressed unsigned floating-point data format with normalized value and non-linear sRGB encoding, packed in 12 blocks (lowest quality). Values are in the <c>[0.0, 1.0]</c> range. Using ASTC compression.</para>
        /// </summary>
        Astc12X12SrgbBlock = 183,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point green/blue/red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G8B8G8R8422Unorm = 184,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point blue/green/red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        B8G8R8G8422Unorm = 185,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, stored across 3 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal and vertical resolution (i.e. 2×2 adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G8B8R83Plane420Unorm = 186,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, stored across 2 separate planes (green + blue/red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal and vertical resolution (i.e. 2×2 adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G8B8R82Plane420Unorm = 187,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, stored across 2 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G8B8R83Plane422Unorm = 188,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, stored across 2 separate planes (green + blue/red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G8B8R82Plane422Unorm = 189,
        /// <summary>
        /// <para>8-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, stored across 3 separate planes. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        G8B8R83Plane444Unorm = 190,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point red channel data with normalized value, plus 6 unused bits, packed in 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R10X6UnormPack16 = 191,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point red/green channel data with normalized value, plus 6 unused bits after each channel, packed in 2×16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R10X6G10X6Unorm2Pack16 = 192,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point red/green/blue/alpha channel data with normalized value, plus 6 unused bits after each channel, packed in 4×16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R10X6G10X6B10X6A10X6Unorm4Pack16 = 193,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point green/blue/green/red channel data with normalized value, plus 6 unused bits after each channel, packed in 4×16 bits. Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel). The green channel is listed twice, but contains different values to allow it to be represented at full resolution.</para>
        /// </summary>
        G10X6B10X6G10X6R10X6422Unorm4Pack16 = 194,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point blue/green/red/green channel data with normalized value, plus 6 unused bits after each channel, packed in 4×16 bits. Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel). The green channel is listed twice, but contains different values to allow it to be represented at full resolution.</para>
        /// </summary>
        B10X6G10X6R10X6G10X6422Unorm4Pack16 = 195,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 2 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal and vertical resolution (i.e. 2×2 adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G10X6B10X6R10X63Plane420Unorm3Pack16 = 196,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 2 separate planes (green + blue/red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal and vertical resolution (i.e. 2×2 adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G10X6B10X6R10X62Plane420Unorm3Pack16 = 197,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 3 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G10X6B10X6R10X63Plane422Unorm3Pack16 = 198,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 3 separate planes (green + blue/red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G10X6B10X6R10X62Plane422Unorm3Pack16 = 199,
        /// <summary>
        /// <para>10-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 3 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        G10X6B10X6R10X63Plane444Unorm3Pack16 = 200,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point red channel data with normalized value, plus 6 unused bits, packed in 16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R12X4UnormPack16 = 201,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point red/green channel data with normalized value, plus 6 unused bits after each channel, packed in 2×16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R12X4G12X4Unorm2Pack16 = 202,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point red/green/blue/alpha channel data with normalized value, plus 6 unused bits after each channel, packed in 4×16 bits. Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        R12X4G12X4B12X4A12X4Unorm4Pack16 = 203,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point green/blue/green/red channel data with normalized value, plus 6 unused bits after each channel, packed in 4×16 bits. Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel). The green channel is listed twice, but contains different values to allow it to be represented at full resolution.</para>
        /// </summary>
        G12X4B12X4G12X4R12X4422Unorm4Pack16 = 204,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point blue/green/red/green channel data with normalized value, plus 6 unused bits after each channel, packed in 4×16 bits. Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel). The green channel is listed twice, but contains different values to allow it to be represented at full resolution.</para>
        /// </summary>
        B12X4G12X4R12X4G12X4422Unorm4Pack16 = 205,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 2 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal and vertical resolution (i.e. 2×2 adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G12X4B12X4R12X43Plane420Unorm3Pack16 = 206,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 2 separate planes (green + blue/red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal and vertical resolution (i.e. 2×2 adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G12X4B12X4R12X42Plane420Unorm3Pack16 = 207,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 3 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G12X4B12X4R12X43Plane422Unorm3Pack16 = 208,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 3 separate planes (green + blue/red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G12X4B12X4R12X42Plane422Unorm3Pack16 = 209,
        /// <summary>
        /// <para>12-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Packed in 3×16 bits and stored across 3 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        G12X4B12X4R12X43Plane444Unorm3Pack16 = 210,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point green/blue/red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G16B16G16R16422Unorm = 211,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point blue/green/red channel data format with normalized value. Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        B16G16R16G16422Unorm = 212,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Stored across 2 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal and vertical resolution (i.e. 2×2 adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G16B16R163Plane420Unorm = 213,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Stored across 2 separate planes (green + blue/red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal and vertical resolution (i.e. 2×2 adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G16B16R162Plane420Unorm = 214,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Stored across 3 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G16B16R163Plane422Unorm = 215,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Stored across 3 separate planes (green + blue/red). Values are in the <c>[0.0, 1.0]</c> range. Blue and red channel data is stored at halved horizontal resolution (i.e. 2 horizontally adjacent pixels will share the same value for the blue/red channel).</para>
        /// </summary>
        G16B16R162Plane422Unorm = 216,
        /// <summary>
        /// <para>16-bit-per-channel unsigned floating-point green/blue/red channel data with normalized value, plus 6 unused bits after each channel. Stored across 3 separate planes (green + blue + red). Values are in the <c>[0.0, 1.0]</c> range.</para>
        /// </summary>
        G16B16R163Plane444Unorm = 217,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.DataFormat"/> enum.</para>
        /// </summary>
        Max = 218
    }

    [System.Flags]
    public enum BarrierMask : long
    {
        /// <summary>
        /// <para>Vertex shader barrier mask.</para>
        /// </summary>
        Vertex = 1,
        /// <summary>
        /// <para>Fragment shader barrier mask.</para>
        /// </summary>
        Fragment = 8,
        /// <summary>
        /// <para>Compute barrier mask.</para>
        /// </summary>
        Compute = 2,
        /// <summary>
        /// <para>Transfer barrier mask.</para>
        /// </summary>
        Transfer = 4,
        /// <summary>
        /// <para>Raster barrier mask (vertex and fragment). Equivalent to <c>BARRIER_MASK_VERTEX | BARRIER_MASK_FRAGMENT</c>.</para>
        /// </summary>
        Raster = 9,
        /// <summary>
        /// <para>Barrier mask for all types (vertex, fragment, compute, transfer).</para>
        /// </summary>
        AllBarriers = 32767,
        /// <summary>
        /// <para>No barrier for any type.</para>
        /// </summary>
        NoBarrier = 32768
    }

    public enum TextureType : long
    {
        /// <summary>
        /// <para>1-dimensional texture.</para>
        /// </summary>
        Type1D = 0,
        /// <summary>
        /// <para>2-dimensional texture.</para>
        /// </summary>
        Type2D = 1,
        /// <summary>
        /// <para>3-dimensional texture.</para>
        /// </summary>
        Type3D = 2,
        /// <summary>
        /// <para><see cref="Godot.Cubemap"/> texture.</para>
        /// </summary>
        Cube = 3,
        /// <summary>
        /// <para>Array of 1-dimensional textures.</para>
        /// </summary>
        Type1DArray = 4,
        /// <summary>
        /// <para>Array of 2-dimensional textures.</para>
        /// </summary>
        Type2DArray = 5,
        /// <summary>
        /// <para>Array of <see cref="Godot.Cubemap"/> textures.</para>
        /// </summary>
        CubeArray = 6,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.TextureType"/> enum.</para>
        /// </summary>
        Max = 7
    }

    public enum TextureSamples : long
    {
        /// <summary>
        /// <para>Perform 1 texture sample (this is the fastest but lowest-quality for antialiasing).</para>
        /// </summary>
        Samples1 = 0,
        /// <summary>
        /// <para>Perform 2 texture samples.</para>
        /// </summary>
        Samples2 = 1,
        /// <summary>
        /// <para>Perform 4 texture samples.</para>
        /// </summary>
        Samples4 = 2,
        /// <summary>
        /// <para>Perform 8 texture samples. Not supported on mobile GPUs (including Apple Silicon).</para>
        /// </summary>
        Samples8 = 3,
        /// <summary>
        /// <para>Perform 16 texture samples. Not supported on mobile GPUs and many desktop GPUs.</para>
        /// </summary>
        Samples16 = 4,
        /// <summary>
        /// <para>Perform 32 texture samples. Not supported on most GPUs.</para>
        /// </summary>
        Samples32 = 5,
        /// <summary>
        /// <para>Perform 64 texture samples (this is the slowest but highest-quality for antialiasing). Not supported on most GPUs.</para>
        /// </summary>
        Samples64 = 6,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.TextureSamples"/> enum.</para>
        /// </summary>
        Max = 7
    }

    [System.Flags]
    public enum TextureUsageBits : long
    {
        /// <summary>
        /// <para>Texture can be sampled.</para>
        /// </summary>
        SamplingBit = 1,
        /// <summary>
        /// <para>Texture can be used as a color attachment in a framebuffer.</para>
        /// </summary>
        ColorAttachmentBit = 2,
        /// <summary>
        /// <para>Texture can be used as a depth/stencil attachment in a framebuffer.</para>
        /// </summary>
        DepthStencilAttachmentBit = 4,
        /// <summary>
        /// <para>Texture can be used as a <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">storage image</a>.</para>
        /// </summary>
        StorageBit = 8,
        /// <summary>
        /// <para>Texture can be used as a <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-storageimage">storage image</a> with support for atomic operations.</para>
        /// </summary>
        StorageAtomicBit = 16,
        /// <summary>
        /// <para>Texture can be read back on the CPU using <see cref="Godot.RenderingDevice.TextureGetData(Rid, uint)"/> faster than without this bit, since it is always kept in the system memory.</para>
        /// </summary>
        CpuReadBit = 32,
        /// <summary>
        /// <para>Texture can be updated using <see cref="Godot.RenderingDevice.TextureUpdate(Rid, uint, byte[])"/>.</para>
        /// </summary>
        CanUpdateBit = 64,
        /// <summary>
        /// <para>Texture can be a source for <see cref="Godot.RenderingDevice.TextureCopy(Rid, Rid, Vector3, Vector3, Vector3, uint, uint, uint, uint)"/>.</para>
        /// </summary>
        CanCopyFromBit = 128,
        /// <summary>
        /// <para>Texture can be a destination for <see cref="Godot.RenderingDevice.TextureCopy(Rid, Rid, Vector3, Vector3, Vector3, uint, uint, uint, uint)"/>.</para>
        /// </summary>
        CanCopyToBit = 256,
        /// <summary>
        /// <para>Texture can be used as a <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#descriptorsets-inputattachment">input attachment</a> in a framebuffer.</para>
        /// </summary>
        InputAttachmentBit = 512
    }

    public enum TextureSwizzle : long
    {
        /// <summary>
        /// <para>Return the sampled value as-is.</para>
        /// </summary>
        Identity = 0,
        /// <summary>
        /// <para>Always return <c>0.0</c> when sampling.</para>
        /// </summary>
        Zero = 1,
        /// <summary>
        /// <para>Always return <c>1.0</c> when sampling.</para>
        /// </summary>
        One = 2,
        /// <summary>
        /// <para>Sample the red color channel.</para>
        /// </summary>
        R = 3,
        /// <summary>
        /// <para>Sample the green color channel.</para>
        /// </summary>
        G = 4,
        /// <summary>
        /// <para>Sample the blue color channel.</para>
        /// </summary>
        B = 5,
        /// <summary>
        /// <para>Sample the alpha channel.</para>
        /// </summary>
        A = 6,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.TextureSwizzle"/> enum.</para>
        /// </summary>
        Max = 7
    }

    public enum TextureSliceType : long
    {
        /// <summary>
        /// <para>2-dimensional texture slice.</para>
        /// </summary>
        Slice2D = 0,
        /// <summary>
        /// <para>Cubemap texture slice.</para>
        /// </summary>
        Cubemap = 1,
        /// <summary>
        /// <para>3-dimensional texture slice.</para>
        /// </summary>
        Slice3D = 2
    }

    public enum SamplerFilter : long
    {
        /// <summary>
        /// <para>Nearest-neighbor sampler filtering. Sampling at higher resolutions than the source will result in a pixelated look.</para>
        /// </summary>
        Nearest = 0,
        /// <summary>
        /// <para>Bilinear sampler filtering. Sampling at higher resolutions than the source will result in a blurry look.</para>
        /// </summary>
        Linear = 1
    }

    public enum SamplerRepeatMode : long
    {
        /// <summary>
        /// <para>Sample with repeating enabled.</para>
        /// </summary>
        Repeat = 0,
        /// <summary>
        /// <para>Sample with mirrored repeating enabled. When sampling outside the <c>[0.0, 1.0]</c> range, return a mirrored version of the sampler. This mirrored version is mirrored again if sampling further away, with the pattern repeating indefinitely.</para>
        /// </summary>
        MirroredRepeat = 1,
        /// <summary>
        /// <para>Sample with repeating disabled. When sampling outside the <c>[0.0, 1.0]</c> range, return the color of the last pixel on the edge.</para>
        /// </summary>
        ClampToEdge = 2,
        /// <summary>
        /// <para>Sample with repeating disabled. When sampling outside the <c>[0.0, 1.0]</c> range, return the specified <see cref="Godot.RDSamplerState.BorderColor"/>.</para>
        /// </summary>
        ClampToBorder = 3,
        /// <summary>
        /// <para>Sample with mirrored repeating enabled, but only once. When sampling in the <c>[-1.0, 0.0]</c> range, return a mirrored version of the sampler. When sampling outside the <c>[-1.0, 1.0]</c> range, return the color of the last pixel on the edge.</para>
        /// </summary>
        MirrorClampToEdge = 4,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.SamplerRepeatMode"/> enum.</para>
        /// </summary>
        Max = 5
    }

    public enum SamplerBorderColor : long
    {
        /// <summary>
        /// <para>Return a floating-point transparent black color when sampling outside the <c>[0.0, 1.0]</c> range. Only effective if the sampler repeat mode is <see cref="Godot.RenderingDevice.SamplerRepeatMode.ClampToBorder"/>.</para>
        /// </summary>
        FloatTransparentBlack = 0,
        /// <summary>
        /// <para>Return a integer transparent black color when sampling outside the <c>[0.0, 1.0]</c> range. Only effective if the sampler repeat mode is <see cref="Godot.RenderingDevice.SamplerRepeatMode.ClampToBorder"/>.</para>
        /// </summary>
        IntTransparentBlack = 1,
        /// <summary>
        /// <para>Return a floating-point opaque black color when sampling outside the <c>[0.0, 1.0]</c> range. Only effective if the sampler repeat mode is <see cref="Godot.RenderingDevice.SamplerRepeatMode.ClampToBorder"/>.</para>
        /// </summary>
        FloatOpaqueBlack = 2,
        /// <summary>
        /// <para>Return a integer opaque black color when sampling outside the <c>[0.0, 1.0]</c> range. Only effective if the sampler repeat mode is <see cref="Godot.RenderingDevice.SamplerRepeatMode.ClampToBorder"/>.</para>
        /// </summary>
        IntOpaqueBlack = 3,
        /// <summary>
        /// <para>Return a floating-point opaque white color when sampling outside the <c>[0.0, 1.0]</c> range. Only effective if the sampler repeat mode is <see cref="Godot.RenderingDevice.SamplerRepeatMode.ClampToBorder"/>.</para>
        /// </summary>
        FloatOpaqueWhite = 4,
        /// <summary>
        /// <para>Return a integer opaque white color when sampling outside the <c>[0.0, 1.0]</c> range. Only effective if the sampler repeat mode is <see cref="Godot.RenderingDevice.SamplerRepeatMode.ClampToBorder"/>.</para>
        /// </summary>
        IntOpaqueWhite = 5,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.SamplerBorderColor"/> enum.</para>
        /// </summary>
        Max = 6
    }

    public enum VertexFrequency : long
    {
        /// <summary>
        /// <para>Vertex attribute addressing is a function of the vertex. This is used to specify the rate at which vertex attributes are pulled from buffers.</para>
        /// </summary>
        Vertex = 0,
        /// <summary>
        /// <para>Vertex attribute addressing is a function of the instance index. This is used to specify the rate at which vertex attributes are pulled from buffers.</para>
        /// </summary>
        Instance = 1
    }

    public enum IndexBufferFormat : long
    {
        /// <summary>
        /// <para>Index buffer in 16-bit unsigned integer format. This limits the maximum index that can be specified to <c>65535</c>.</para>
        /// </summary>
        Uint16 = 0,
        /// <summary>
        /// <para>Index buffer in 32-bit unsigned integer format. This limits the maximum index that can be specified to <c>4294967295</c>.</para>
        /// </summary>
        Uint32 = 1
    }

    [System.Flags]
    public enum StorageBufferUsage : long
    {
        Indirect = 1
    }

    public enum UniformType : long
    {
        /// <summary>
        /// <para>Sampler uniform.</para>
        /// </summary>
        Sampler = 0,
        /// <summary>
        /// <para>Sampler uniform with a texture.</para>
        /// </summary>
        SamplerWithTexture = 1,
        /// <summary>
        /// <para>Texture uniform.</para>
        /// </summary>
        Texture = 2,
        /// <summary>
        /// <para>Image uniform.</para>
        /// </summary>
        Image = 3,
        /// <summary>
        /// <para>Texture buffer uniform.</para>
        /// </summary>
        TextureBuffer = 4,
        /// <summary>
        /// <para>Sampler uniform with a texture buffer.</para>
        /// </summary>
        SamplerWithTextureBuffer = 5,
        /// <summary>
        /// <para>Image buffer uniform.</para>
        /// </summary>
        ImageBuffer = 6,
        /// <summary>
        /// <para>Uniform buffer uniform.</para>
        /// </summary>
        UniformBuffer = 7,
        /// <summary>
        /// <para><a href="https://vkguide.dev/docs/chapter-4/storage_buffers/">Storage buffer</a> uniform.</para>
        /// </summary>
        StorageBuffer = 8,
        /// <summary>
        /// <para>Input attachment uniform.</para>
        /// </summary>
        InputAttachment = 9,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.UniformType"/> enum.</para>
        /// </summary>
        Max = 10
    }

    public enum RenderPrimitive : long
    {
        /// <summary>
        /// <para>Point rendering primitive (with constant size, regardless of distance from camera).</para>
        /// </summary>
        Points = 0,
        /// <summary>
        /// <para>Line list rendering primitive. Lines are drawn separated from each other.</para>
        /// </summary>
        Lines = 1,
        /// <summary>
        /// <para><a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-line-lists-with-adjacency">Line list rendering primitive with adjacency.</a></para>
        /// <para><b>Note:</b> Adjacency is only useful with geometry shaders, which Godot does not expose.</para>
        /// </summary>
        LinesWithAdjacency = 2,
        /// <summary>
        /// <para>Line strip rendering primitive. Lines drawn are connected to the previous vertex.</para>
        /// </summary>
        Linestrips = 3,
        /// <summary>
        /// <para><a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-line-strips-with-adjacency">Line strip rendering primitive with adjacency.</a></para>
        /// <para><b>Note:</b> Adjacency is only useful with geometry shaders, which Godot does not expose.</para>
        /// </summary>
        LinestripsWithAdjacency = 4,
        /// <summary>
        /// <para>Triangle list rendering primitive. Triangles are drawn separated from each other.</para>
        /// </summary>
        Triangles = 5,
        /// <summary>
        /// <para><a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-triangle-lists-with-adjacency">Triangle list rendering primitive with adjacency.</a></para>
        /// <para> <b>Note:</b> Adjacency is only useful with geometry shaders, which Godot does not expose.</para>
        /// </summary>
        TrianglesWithAdjacency = 6,
        /// <summary>
        /// <para>Triangle strip rendering primitive. Triangles drawn are connected to the previous triangle.</para>
        /// </summary>
        TriangleStrips = 7,
        /// <summary>
        /// <para><a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing-triangle-strips-with-adjacency">Triangle strip rendering primitive with adjacency.</a></para>
        /// <para><b>Note:</b> Adjacency is only useful with geometry shaders, which Godot does not expose.</para>
        /// </summary>
        TriangleStripsWithAjacency = 8,
        /// <summary>
        /// <para>Triangle strip rendering primitive with <i>primitive restart</i> enabled. Triangles drawn are connected to the previous triangle, but a primitive restart index can be specified before drawing to create a second triangle strip after the specified index.</para>
        /// <para><b>Note:</b> Only compatible with indexed draws.</para>
        /// </summary>
        TriangleStripsWithRestartIndex = 9,
        /// <summary>
        /// <para>Tessellation patch rendering primitive. Only useful with tessellation shaders, which can be used to deform these patches.</para>
        /// </summary>
        TesselationPatch = 10,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.RenderPrimitive"/> enum.</para>
        /// </summary>
        Max = 11
    }

    public enum PolygonCullMode : long
    {
        /// <summary>
        /// <para>Do not use polygon front face or backface culling.</para>
        /// </summary>
        Disabled = 0,
        /// <summary>
        /// <para>Use polygon frontface culling (faces pointing towards the camera are hidden).</para>
        /// </summary>
        Front = 1,
        /// <summary>
        /// <para>Use polygon backface culling (faces pointing away from the camera are hidden).</para>
        /// </summary>
        Back = 2
    }

    public enum PolygonFrontFace : long
    {
        /// <summary>
        /// <para>Clockwise winding order to determine which face of a polygon is its front face.</para>
        /// </summary>
        Clockwise = 0,
        /// <summary>
        /// <para>Counter-clockwise winding order to determine which face of a polygon is its front face.</para>
        /// </summary>
        CounterClockwise = 1
    }

    public enum StencilOperation : long
    {
        /// <summary>
        /// <para>Keep the current stencil value.</para>
        /// </summary>
        Keep = 0,
        /// <summary>
        /// <para>Set the stencil value to <c>0</c>.</para>
        /// </summary>
        Zero = 1,
        /// <summary>
        /// <para>Replace the existing stencil value with the new one.</para>
        /// </summary>
        Replace = 2,
        /// <summary>
        /// <para>Increment the existing stencil value and clamp to the maximum representable unsigned value if reached. Stencil bits are considered as an unsigned integer.</para>
        /// </summary>
        IncrementAndClamp = 3,
        /// <summary>
        /// <para>Decrement the existing stencil value and clamp to the minimum value if reached. Stencil bits are considered as an unsigned integer.</para>
        /// </summary>
        DecrementAndClamp = 4,
        /// <summary>
        /// <para>Bitwise-invert the existing stencil value.</para>
        /// </summary>
        Invert = 5,
        /// <summary>
        /// <para>Increment the stencil value and wrap around to <c>0</c> if reaching the maximum representable unsigned. Stencil bits are considered as an unsigned integer.</para>
        /// </summary>
        IncrementAndWrap = 6,
        /// <summary>
        /// <para>Decrement the stencil value and wrap around to the maximum representable unsigned if reaching the minimum. Stencil bits are considered as an unsigned integer.</para>
        /// </summary>
        DecrementAndWrap = 7,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.StencilOperation"/> enum.</para>
        /// </summary>
        Max = 8
    }

    public enum CompareOperator : long
    {
        /// <summary>
        /// <para>"Never" comparison (opposite of <see cref="Godot.RenderingDevice.CompareOperator.Always"/>).</para>
        /// </summary>
        Never = 0,
        /// <summary>
        /// <para>"Less than" comparison.</para>
        /// </summary>
        Less = 1,
        /// <summary>
        /// <para>"Equal" comparison.</para>
        /// </summary>
        Equal = 2,
        /// <summary>
        /// <para>"Less than or equal" comparison.</para>
        /// </summary>
        LessOrEqual = 3,
        /// <summary>
        /// <para>"Greater than" comparison.</para>
        /// </summary>
        Greater = 4,
        /// <summary>
        /// <para>"Not equal" comparison.</para>
        /// </summary>
        NotEqual = 5,
        /// <summary>
        /// <para>"Greater than or equal" comparison.</para>
        /// </summary>
        GreaterOrEqual = 6,
        /// <summary>
        /// <para>"Always" comparison (opposite of <see cref="Godot.RenderingDevice.CompareOperator.Never"/>).</para>
        /// </summary>
        Always = 7,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.CompareOperator"/> enum.</para>
        /// </summary>
        Max = 8
    }

    public enum LogicOperation : long
    {
        /// <summary>
        /// <para>Clear logic operation (result is always <c>0</c>). See also <see cref="Godot.RenderingDevice.LogicOperation.Set"/>.</para>
        /// </summary>
        Clear = 0,
        /// <summary>
        /// <para>AND logic operation.</para>
        /// </summary>
        And = 1,
        /// <summary>
        /// <para>AND logic operation with the <i>destination</i> operand being inverted. See also <see cref="Godot.RenderingDevice.LogicOperation.AndInverted"/>.</para>
        /// </summary>
        AndReverse = 2,
        /// <summary>
        /// <para>Copy logic operation (keeps the <i>source</i> value as-is). See also <see cref="Godot.RenderingDevice.LogicOperation.CopyInverted"/> and <see cref="Godot.RenderingDevice.LogicOperation.NoOp"/>.</para>
        /// </summary>
        Copy = 3,
        /// <summary>
        /// <para>AND logic operation with the <i>source</i> operand being inverted. See also <see cref="Godot.RenderingDevice.LogicOperation.AndReverse"/>.</para>
        /// </summary>
        AndInverted = 4,
        /// <summary>
        /// <para>No-op logic operation (keeps the <i>destination</i> value as-is). See also <see cref="Godot.RenderingDevice.LogicOperation.Copy"/>.</para>
        /// </summary>
        NoOp = 5,
        /// <summary>
        /// <para>Exclusive or (XOR) logic operation.</para>
        /// </summary>
        Xor = 6,
        /// <summary>
        /// <para>OR logic operation.</para>
        /// </summary>
        Or = 7,
        /// <summary>
        /// <para>Not-OR (NOR) logic operation.</para>
        /// </summary>
        Nor = 8,
        /// <summary>
        /// <para>Not-XOR (XNOR) logic operation.</para>
        /// </summary>
        Equivalent = 9,
        /// <summary>
        /// <para>Invert logic operation.</para>
        /// </summary>
        Invert = 10,
        /// <summary>
        /// <para>OR logic operation with the <i>destination</i> operand being inverted. See also <see cref="Godot.RenderingDevice.LogicOperation.OrReverse"/>.</para>
        /// </summary>
        OrReverse = 11,
        /// <summary>
        /// <para>NOT logic operation (inverts the value). See also <see cref="Godot.RenderingDevice.LogicOperation.Copy"/>.</para>
        /// </summary>
        CopyInverted = 12,
        /// <summary>
        /// <para>OR logic operation with the <i>source</i> operand being inverted. See also <see cref="Godot.RenderingDevice.LogicOperation.OrReverse"/>.</para>
        /// </summary>
        OrInverted = 13,
        /// <summary>
        /// <para>Not-AND (NAND) logic operation.</para>
        /// </summary>
        Nand = 14,
        /// <summary>
        /// <para>SET logic operation (result is always <c>1</c>). See also <see cref="Godot.RenderingDevice.LogicOperation.Clear"/>.</para>
        /// </summary>
        Set = 15,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.LogicOperation"/> enum.</para>
        /// </summary>
        Max = 16
    }

    public enum BlendFactor : long
    {
        /// <summary>
        /// <para>Constant <c>0.0</c> blend factor.</para>
        /// </summary>
        Zero = 0,
        /// <summary>
        /// <para>Constant <c>1.0</c> blend factor.</para>
        /// </summary>
        One = 1,
        /// <summary>
        /// <para>Color blend factor is <c>source color</c>. Alpha blend factor is <c>source alpha</c>.</para>
        /// </summary>
        SrcColor = 2,
        /// <summary>
        /// <para>Color blend factor is <c>1.0 - source color</c>. Alpha blend factor is <c>1.0 - source alpha</c>.</para>
        /// </summary>
        OneMinusSrcColor = 3,
        /// <summary>
        /// <para>Color blend factor is <c>destination color</c>. Alpha blend factor is <c>destination alpha</c>.</para>
        /// </summary>
        DstColor = 4,
        /// <summary>
        /// <para>Color blend factor is <c>1.0 - destination color</c>. Alpha blend factor is <c>1.0 - destination alpha</c>.</para>
        /// </summary>
        OneMinusDstColor = 5,
        /// <summary>
        /// <para>Color and alpha blend factor is <c>source alpha</c>.</para>
        /// </summary>
        SrcAlpha = 6,
        /// <summary>
        /// <para>Color and alpha blend factor is <c>1.0 - source alpha</c>.</para>
        /// </summary>
        OneMinusSrcAlpha = 7,
        /// <summary>
        /// <para>Color and alpha blend factor is <c>destination alpha</c>.</para>
        /// </summary>
        DstAlpha = 8,
        /// <summary>
        /// <para>Color and alpha blend factor is <c>1.0 - destination alpha</c>.</para>
        /// </summary>
        OneMinusDstAlpha = 9,
        /// <summary>
        /// <para>Color blend factor is <c>blend constant color</c>. Alpha blend factor is <c>blend constant alpha</c> (see <see cref="Godot.RenderingDevice.DrawListSetBlendConstants(long, Color)"/>).</para>
        /// </summary>
        ConstantColor = 10,
        /// <summary>
        /// <para>Color blend factor is <c>1.0 - blend constant color</c>. Alpha blend factor is <c>1.0 - blend constant alpha</c> (see <see cref="Godot.RenderingDevice.DrawListSetBlendConstants(long, Color)"/>).</para>
        /// </summary>
        OneMinusConstantColor = 11,
        /// <summary>
        /// <para>Color and alpha blend factor is <c>blend constant alpha</c> (see <see cref="Godot.RenderingDevice.DrawListSetBlendConstants(long, Color)"/>).</para>
        /// </summary>
        ConstantAlpha = 12,
        /// <summary>
        /// <para>Color and alpha blend factor is <c>1.0 - blend constant alpha</c> (see <see cref="Godot.RenderingDevice.DrawListSetBlendConstants(long, Color)"/>).</para>
        /// </summary>
        OneMinusConstantAlpha = 13,
        /// <summary>
        /// <para>Color blend factor is <c>min(source alpha, 1.0 - destination alpha)</c>. Alpha blend factor is <c>1.0</c>.</para>
        /// </summary>
        SrcAlphaSaturate = 14,
        /// <summary>
        /// <para>Color blend factor is <c>second source color</c>. Alpha blend factor is <c>second source alpha</c>. Only relevant for dual-source blending.</para>
        /// </summary>
        Src1Color = 15,
        /// <summary>
        /// <para>Color blend factor is <c>1.0 - second source color</c>. Alpha blend factor is <c>1.0 - second source alpha</c>. Only relevant for dual-source blending.</para>
        /// </summary>
        OneMinusSrc1Color = 16,
        /// <summary>
        /// <para>Color and alpha blend factor is <c>second source alpha</c>. Only relevant for dual-source blending.</para>
        /// </summary>
        Src1Alpha = 17,
        /// <summary>
        /// <para>Color and alpha blend factor is <c>1.0 - second source alpha</c>. Only relevant for dual-source blending.</para>
        /// </summary>
        OneMinusSrc1Alpha = 18,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.BlendFactor"/> enum.</para>
        /// </summary>
        Max = 19
    }

    public enum BlendOperation : long
    {
        /// <summary>
        /// <para>Additive blending operation (<c>source + destination</c>).</para>
        /// </summary>
        Add = 0,
        /// <summary>
        /// <para>Subtractive blending operation (<c>source - destination</c>).</para>
        /// </summary>
        Subtract = 1,
        /// <summary>
        /// <para>Reverse subtractive blending operation (<c>destination - source</c>).</para>
        /// </summary>
        ReverseSubtract = 2,
        /// <summary>
        /// <para>Minimum blending operation (keep the lowest value of the two).</para>
        /// </summary>
        Minimum = 3,
        /// <summary>
        /// <para>Maximum blending operation (keep the highest value of the two).</para>
        /// </summary>
        Maximum = 4,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.BlendOperation"/> enum.</para>
        /// </summary>
        Max = 5
    }

    [System.Flags]
    public enum PipelineDynamicStateFlags : long
    {
        /// <summary>
        /// <para>Allows dynamically changing the width of rendering lines.</para>
        /// </summary>
        LineWidth = 1,
        /// <summary>
        /// <para>Allows dynamically changing the depth bias.</para>
        /// </summary>
        DepthBias = 2,
        BlendConstants = 4,
        DepthBounds = 8,
        StencilCompareMask = 16,
        StencilWriteMask = 32,
        StencilReference = 64
    }

    public enum InitialAction : long
    {
        /// <summary>
        /// <para>Load the previous contents of the framebuffer.</para>
        /// </summary>
        Load = 0,
        /// <summary>
        /// <para>Clear the whole framebuffer or its specified region.</para>
        /// </summary>
        Clear = 1,
        /// <summary>
        /// <para>Ignore the previous contents of the framebuffer. This is the fastest option if you'll overwrite all of the pixels and don't need to read any of them.</para>
        /// </summary>
        Discard = 2,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.InitialAction"/> enum.</para>
        /// </summary>
        Max = 3,
        [Obsolete("Use 'Godot.RenderingDevice.InitialAction.Clear' instead.")]
        ClearRegion = 1,
        [Obsolete("Use 'Godot.RenderingDevice.InitialAction.Load' instead.")]
        ClearRegionContinue = 1,
        [Obsolete("Use 'Godot.RenderingDevice.InitialAction.Load' instead.")]
        Keep = 0,
        [Obsolete("Use 'Godot.RenderingDevice.InitialAction.Discard' instead.")]
        Drop = 2,
        [Obsolete("Use 'Godot.RenderingDevice.InitialAction.Load' instead.")]
        Continue = 0
    }

    public enum FinalAction : long
    {
        /// <summary>
        /// <para>Store the result of the draw list in the framebuffer. This is generally what you want to do.</para>
        /// </summary>
        Store = 0,
        /// <summary>
        /// <para>Discard the contents of the framebuffer. This is the fastest option if you don't need to use the results of the draw list.</para>
        /// </summary>
        Discard = 1,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.FinalAction"/> enum.</para>
        /// </summary>
        Max = 2,
        [Obsolete("Use 'Godot.RenderingDevice.FinalAction.Store' instead.")]
        Read = 0,
        [Obsolete("Use 'Godot.RenderingDevice.FinalAction.Store' instead.")]
        Continue = 0
    }

    public enum ShaderStage : long
    {
        /// <summary>
        /// <para>Vertex shader stage. This can be used to manipulate vertices from a shader (but not create new vertices).</para>
        /// </summary>
        Vertex = 0,
        /// <summary>
        /// <para>Fragment shader stage (called "pixel shader" in Direct3D). This can be used to manipulate pixels from a shader.</para>
        /// </summary>
        Fragment = 1,
        /// <summary>
        /// <para>Tessellation control shader stage. This can be used to create additional geometry from a shader.</para>
        /// </summary>
        TesselationControl = 2,
        /// <summary>
        /// <para>Tessellation evaluation shader stage. This can be used to create additional geometry from a shader.</para>
        /// </summary>
        TesselationEvaluation = 3,
        /// <summary>
        /// <para>Compute shader stage. This can be used to run arbitrary computing tasks in a shader, performing them on the GPU instead of the CPU.</para>
        /// </summary>
        Compute = 4,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.RenderingDevice.ShaderStage"/> enum.</para>
        /// </summary>
        Max = 5,
        /// <summary>
        /// <para>Vertex shader stage bit (see also <see cref="Godot.RenderingDevice.ShaderStage.Vertex"/>).</para>
        /// </summary>
        VertexBit = 1,
        /// <summary>
        /// <para>Fragment shader stage bit (see also <see cref="Godot.RenderingDevice.ShaderStage.Fragment"/>).</para>
        /// </summary>
        FragmentBit = 2,
        /// <summary>
        /// <para>Tessellation control shader stage bit (see also <see cref="Godot.RenderingDevice.ShaderStage.TesselationControl"/>).</para>
        /// </summary>
        TesselationControlBit = 4,
        /// <summary>
        /// <para>Tessellation evaluation shader stage bit (see also <see cref="Godot.RenderingDevice.ShaderStage.TesselationEvaluation"/>).</para>
        /// </summary>
        TesselationEvaluationBit = 8,
        /// <summary>
        /// <para>Compute shader stage bit (see also <see cref="Godot.RenderingDevice.ShaderStage.Compute"/>).</para>
        /// </summary>
        ComputeBit = 16
    }

    public enum ShaderLanguage : long
    {
        /// <summary>
        /// <para>Khronos' GLSL shading language (used natively by OpenGL and Vulkan). This is the language used for core Godot shaders.</para>
        /// </summary>
        Glsl = 0,
        /// <summary>
        /// <para>Microsoft's High-Level Shading Language (used natively by Direct3D, but can also be used in Vulkan).</para>
        /// </summary>
        Hlsl = 1
    }

    public enum PipelineSpecializationConstantType : long
    {
        /// <summary>
        /// <para>Boolean specialization constant.</para>
        /// </summary>
        Bool = 0,
        /// <summary>
        /// <para>Integer specialization constant.</para>
        /// </summary>
        Int = 1,
        /// <summary>
        /// <para>Floating-point specialization constant.</para>
        /// </summary>
        Float = 2
    }

    public enum Limit : long
    {
        /// <summary>
        /// <para>Maximum number of uniform sets that can be bound at a given time.</para>
        /// </summary>
        MaxBoundUniformSets = 0,
        /// <summary>
        /// <para>Maximum number of color framebuffer attachments that can be used at a given time.</para>
        /// </summary>
        MaxFramebufferColorAttachments = 1,
        /// <summary>
        /// <para>Maximum number of textures that can be used per uniform set.</para>
        /// </summary>
        MaxTexturesPerUniformSet = 2,
        /// <summary>
        /// <para>Maximum number of samplers that can be used per uniform set.</para>
        /// </summary>
        MaxSamplersPerUniformSet = 3,
        /// <summary>
        /// <para>Maximum number of <a href="https://vkguide.dev/docs/chapter-4/storage_buffers/">storage buffers</a> per uniform set.</para>
        /// </summary>
        MaxStorageBuffersPerUniformSet = 4,
        /// <summary>
        /// <para>Maximum number of storage images per uniform set.</para>
        /// </summary>
        MaxStorageImagesPerUniformSet = 5,
        /// <summary>
        /// <para>Maximum number of uniform buffers per uniform set.</para>
        /// </summary>
        MaxUniformBuffersPerUniformSet = 6,
        /// <summary>
        /// <para>Maximum index for an indexed draw command.</para>
        /// </summary>
        MaxDrawIndexedIndex = 7,
        /// <summary>
        /// <para>Maximum height of a framebuffer (in pixels).</para>
        /// </summary>
        MaxFramebufferHeight = 8,
        /// <summary>
        /// <para>Maximum width of a framebuffer (in pixels).</para>
        /// </summary>
        MaxFramebufferWidth = 9,
        /// <summary>
        /// <para>Maximum number of texture array layers.</para>
        /// </summary>
        MaxTextureArrayLayers = 10,
        /// <summary>
        /// <para>Maximum supported 1-dimensional texture size (in pixels on a single axis).</para>
        /// </summary>
        MaxTextureSize1D = 11,
        /// <summary>
        /// <para>Maximum supported 2-dimensional texture size (in pixels on a single axis).</para>
        /// </summary>
        MaxTextureSize2D = 12,
        /// <summary>
        /// <para>Maximum supported 3-dimensional texture size (in pixels on a single axis).</para>
        /// </summary>
        MaxTextureSize3D = 13,
        /// <summary>
        /// <para>Maximum supported cubemap texture size (in pixels on a single axis of a single face).</para>
        /// </summary>
        MaxTextureSizeCube = 14,
        /// <summary>
        /// <para>Maximum number of textures per shader stage.</para>
        /// </summary>
        MaxTexturesPerShaderStage = 15,
        /// <summary>
        /// <para>Maximum number of samplers per shader stage.</para>
        /// </summary>
        MaxSamplersPerShaderStage = 16,
        /// <summary>
        /// <para>Maximum number of <a href="https://vkguide.dev/docs/chapter-4/storage_buffers/">storage buffers</a> per shader stage.</para>
        /// </summary>
        MaxStorageBuffersPerShaderStage = 17,
        /// <summary>
        /// <para>Maximum number of storage images per shader stage.</para>
        /// </summary>
        MaxStorageImagesPerShaderStage = 18,
        /// <summary>
        /// <para>Maximum number of uniform buffers per uniform set.</para>
        /// </summary>
        MaxUniformBuffersPerShaderStage = 19,
        /// <summary>
        /// <para>Maximum size of a push constant. A lot of devices are limited to 128 bytes, so try to avoid exceeding 128 bytes in push constants to ensure compatibility even if your GPU is reporting a higher value.</para>
        /// </summary>
        MaxPushConstantSize = 20,
        /// <summary>
        /// <para>Maximum size of a uniform buffer.</para>
        /// </summary>
        MaxUniformBufferSize = 21,
        /// <summary>
        /// <para>Maximum vertex input attribute offset.</para>
        /// </summary>
        MaxVertexInputAttributeOffset = 22,
        /// <summary>
        /// <para>Maximum number of vertex input attributes.</para>
        /// </summary>
        MaxVertexInputAttributes = 23,
        /// <summary>
        /// <para>Maximum number of vertex input bindings.</para>
        /// </summary>
        MaxVertexInputBindings = 24,
        /// <summary>
        /// <para>Maximum vertex input binding stride.</para>
        /// </summary>
        MaxVertexInputBindingStride = 25,
        /// <summary>
        /// <para>Minimum uniform buffer offset alignment.</para>
        /// </summary>
        MinUniformBufferOffsetAlignment = 26,
        /// <summary>
        /// <para>Maximum shared memory size for compute shaders.</para>
        /// </summary>
        MaxComputeSharedMemorySize = 27,
        /// <summary>
        /// <para>Maximum number of workgroups for compute shaders on the X axis.</para>
        /// </summary>
        MaxComputeWorkgroupCountX = 28,
        /// <summary>
        /// <para>Maximum number of workgroups for compute shaders on the Y axis.</para>
        /// </summary>
        MaxComputeWorkgroupCountY = 29,
        /// <summary>
        /// <para>Maximum number of workgroups for compute shaders on the Z axis.</para>
        /// </summary>
        MaxComputeWorkgroupCountZ = 30,
        /// <summary>
        /// <para>Maximum number of workgroup invocations for compute shaders.</para>
        /// </summary>
        MaxComputeWorkgroupInvocations = 31,
        /// <summary>
        /// <para>Maximum workgroup size for compute shaders on the X axis.</para>
        /// </summary>
        MaxComputeWorkgroupSizeX = 32,
        /// <summary>
        /// <para>Maximum workgroup size for compute shaders on the Y axis.</para>
        /// </summary>
        MaxComputeWorkgroupSizeY = 33,
        /// <summary>
        /// <para>Maximum workgroup size for compute shaders on the Z axis.</para>
        /// </summary>
        MaxComputeWorkgroupSizeZ = 34,
        /// <summary>
        /// <para>Maximum viewport width (in pixels).</para>
        /// </summary>
        MaxViewportDimensionsX = 35,
        /// <summary>
        /// <para>Maximum viewport height (in pixels).</para>
        /// </summary>
        MaxViewportDimensionsY = 36
    }

    public enum MemoryType : long
    {
        /// <summary>
        /// <para>Memory taken by textures.</para>
        /// </summary>
        Textures = 0,
        /// <summary>
        /// <para>Memory taken by buffers.</para>
        /// </summary>
        Buffers = 1,
        /// <summary>
        /// <para>Total memory taken. This is greater than the sum of <see cref="Godot.RenderingDevice.MemoryType.Textures"/> and <see cref="Godot.RenderingDevice.MemoryType.Buffers"/>, as it also includes miscellaneous memory usage.</para>
        /// </summary>
        Total = 2
    }

    private static readonly System.Type CachedType = typeof(RenderingDevice);

    private static readonly StringName NativeName = "RenderingDevice";

    internal RenderingDevice() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(null, NativeName, CachedType, refCounted: false);
        }
    }

    internal RenderingDevice(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureCreate, 3709173589ul);

    /// <summary>
    /// <para>Creates a new texture. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// <para><b>Note:</b> Not to be confused with <see cref="Godot.RenderingServer.Texture2DCreate(Image)"/>, which creates the Godot-specific <see cref="Godot.Texture2D"/> resource as opposed to the graphics API's own texture type.</para>
    /// </summary>
    public Rid TextureCreate(RDTextureFormat format, RDTextureView view, Godot.Collections.Array<byte[]> data = null)
    {
        return NativeCalls.godot_icall_3_905(MethodBind0, GodotObject.GetPtr(this), GodotObject.GetPtr(format), GodotObject.GetPtr(view), (godot_array)(data ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureCreateShared, 3178156134ul);

    /// <summary>
    /// <para>Creates a shared texture using the specified <paramref name="view"/> and the texture information from <paramref name="withTexture"/>.</para>
    /// </summary>
    public Rid TextureCreateShared(RDTextureView view, Rid withTexture)
    {
        return NativeCalls.godot_icall_2_906(MethodBind1, GodotObject.GetPtr(this), GodotObject.GetPtr(view), withTexture);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureCreateSharedFromSlice, 1808971279ul);

    /// <summary>
    /// <para>Creates a shared texture using the specified <paramref name="view"/> and the texture information from <paramref name="withTexture"/>'s <paramref name="layer"/> and <paramref name="mipmap"/>. The number of included mipmaps from the original texture can be controlled using the <paramref name="mipmaps"/> parameter. Only relevant for textures with multiple layers, such as 3D textures, texture arrays and cubemaps. For single-layer textures, use <see cref="Godot.RenderingDevice.TextureCreateShared(RDTextureView, Rid)"/></para>
    /// <para>For 2D textures (which only have one layer), <paramref name="layer"/> must be <c>0</c>.</para>
    /// <para><b>Note:</b> Layer slicing is only supported for 2D texture arrays, not 3D textures or cubemaps.</para>
    /// </summary>
    public Rid TextureCreateSharedFromSlice(RDTextureView view, Rid withTexture, uint layer, uint mipmap, uint mipmaps = (uint)(1), RenderingDevice.TextureSliceType sliceType = (RenderingDevice.TextureSliceType)(0))
    {
        return NativeCalls.godot_icall_6_907(MethodBind2, GodotObject.GetPtr(this), GodotObject.GetPtr(view), withTexture, layer, mipmap, mipmaps, (int)sliceType);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureCreateFromExtension, 1397171480ul);

    /// <summary>
    /// <para>Returns an RID for an existing <paramref name="image"/> (<c>VkImage</c>) with the given <paramref name="type"/>, <paramref name="format"/>, <paramref name="samples"/>, <paramref name="usageFlags"/>, <paramref name="width"/>, <paramref name="height"/>, <paramref name="depth"/>, and <paramref name="layers"/>. This can be used to allow Godot to render onto foreign images.</para>
    /// </summary>
    public Rid TextureCreateFromExtension(RenderingDevice.TextureType type, RenderingDevice.DataFormat format, RenderingDevice.TextureSamples samples, RenderingDevice.TextureUsageBits usageFlags, ulong image, ulong width, ulong height, ulong depth, ulong layers)
    {
        return NativeCalls.godot_icall_9_908(MethodBind3, GodotObject.GetPtr(this), (int)type, (int)format, (int)samples, (int)usageFlags, image, width, height, depth, layers);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureUpdate, 1349464008ul);

    /// <summary>
    /// <para>Updates texture data with new data, replacing the previous data in place. The updated texture data must have the same dimensions and format. For 2D textures (which only have one layer), <paramref name="layer"/> must be <c>0</c>. Returns <see cref="Godot.Error.Ok"/> if the update was successful, <see cref="Godot.Error.InvalidParameter"/> otherwise.</para>
    /// <para><b>Note:</b> Updating textures is forbidden during creation of a draw or compute list.</para>
    /// <para><b>Note:</b> The existing <paramref name="texture"/> can't be updated while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to update this texture.</para>
    /// <para><b>Note:</b> The existing <paramref name="texture"/> requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanUpdateBit"/> to be updatable.</para>
    /// </summary>
    public Error TextureUpdate(Rid texture, uint layer, byte[] data)
    {
        return (Error)NativeCalls.godot_icall_3_909(MethodBind4, GodotObject.GetPtr(this), texture, layer, data);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureGetData, 1859412099ul);

    /// <summary>
    /// <para>Returns the <paramref name="texture"/> data for the specified <paramref name="layer"/> as raw binary data. For 2D textures (which only have one layer), <paramref name="layer"/> must be <c>0</c>.</para>
    /// <para><b>Note:</b> <paramref name="texture"/> can't be retrieved while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to retrieve this texture. Otherwise, an error is printed and a empty <see cref="byte"/>[] is returned.</para>
    /// <para><b>Note:</b> <paramref name="texture"/> requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyFromBit"/> to be retrieved. Otherwise, an error is printed and a empty <see cref="byte"/>[] is returned.</para>
    /// </summary>
    public byte[] TextureGetData(Rid texture, uint layer)
    {
        return NativeCalls.godot_icall_2_910(MethodBind5, GodotObject.GetPtr(this), texture, layer);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureIsFormatSupportedForUsage, 2592520478ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the specified <paramref name="format"/> is supported for the given <paramref name="usageFlags"/>, <see langword="false"/> otherwise.</para>
    /// </summary>
    public bool TextureIsFormatSupportedForUsage(RenderingDevice.DataFormat format, RenderingDevice.TextureUsageBits usageFlags)
    {
        return NativeCalls.godot_icall_2_38(MethodBind6, GodotObject.GetPtr(this), (int)format, (int)usageFlags).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureIsShared, 3521089500ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the <paramref name="texture"/> is shared, <see langword="false"/> otherwise. See <see cref="Godot.RDTextureView"/>.</para>
    /// </summary>
    public bool TextureIsShared(Rid texture)
    {
        return NativeCalls.godot_icall_1_691(MethodBind7, GodotObject.GetPtr(this), texture).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureIsValid, 3521089500ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the <paramref name="texture"/> is valid, <see langword="false"/> otherwise.</para>
    /// </summary>
    public bool TextureIsValid(Rid texture)
    {
        return NativeCalls.godot_icall_1_691(MethodBind8, GodotObject.GetPtr(this), texture).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureCopy, 2859522160ul);

    /// <summary>
    /// <para>Copies the <paramref name="fromTexture"/> to <paramref name="toTexture"/> with the specified <paramref name="fromPos"/>, <paramref name="toPos"/> and <paramref name="size"/> coordinates. The Z axis of the <paramref name="fromPos"/>, <paramref name="toPos"/> and <paramref name="size"/> must be <c>0</c> for 2-dimensional textures. Source and destination mipmaps/layers must also be specified, with these parameters being <c>0</c> for textures without mipmaps or single-layer textures. Returns <see cref="Godot.Error.Ok"/> if the texture copy was successful or <see cref="Godot.Error.InvalidParameter"/> otherwise.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> texture can't be copied while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to copy this texture.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> texture requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyFromBit"/> to be retrieved.</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> can't be copied while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to copy this texture.</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyToBit"/> to be retrieved.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> and <paramref name="toTexture"/> must be of the same type (color or depth).</para>
    /// </summary>
    public unsafe Error TextureCopy(Rid fromTexture, Rid toTexture, Vector3 fromPos, Vector3 toPos, Vector3 size, uint srcMipmap, uint dstMipmap, uint srcLayer, uint dstLayer)
    {
        return (Error)NativeCalls.godot_icall_9_911(MethodBind9, GodotObject.GetPtr(this), fromTexture, toTexture, &fromPos, &toPos, &size, srcMipmap, dstMipmap, srcLayer, dstLayer);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureClear, 3477703247ul);

    /// <summary>
    /// <para>Clears the specified <paramref name="texture"/> by replacing all of its pixels with the specified <paramref name="color"/>. <paramref name="baseMipmap"/> and <paramref name="mipmapCount"/> determine which mipmaps of the texture are affected by this clear operation, while <paramref name="baseLayer"/> and <paramref name="layerCount"/> determine which layers of a 3D texture (or texture array) are affected by this clear operation. For 2D textures (which only have one layer by design), <paramref name="baseLayer"/> must be <c>0</c> and <paramref name="layerCount"/> must be <c>1</c>.</para>
    /// <para><b>Note:</b> <paramref name="texture"/> can't be cleared while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to clear this texture.</para>
    /// </summary>
    public unsafe Error TextureClear(Rid texture, Color color, uint baseMipmap, uint mipmapCount, uint baseLayer, uint layerCount)
    {
        return (Error)NativeCalls.godot_icall_6_912(MethodBind10, GodotObject.GetPtr(this), texture, &color, baseMipmap, mipmapCount, baseLayer, layerCount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureResolveMultisample, 3181288260ul);

    /// <summary>
    /// <para>Resolves the <paramref name="fromTexture"/> texture onto <paramref name="toTexture"/> with multisample antialiasing enabled. This must be used when rendering a framebuffer for MSAA to work. Returns <see cref="Godot.Error.Ok"/> if successful, <see cref="Godot.Error.InvalidParameter"/> otherwise.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> and <paramref name="toTexture"/> textures must have the same dimension, format and type (color or depth).</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> can't be copied while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to resolve this texture.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyFromBit"/> to be retrieved.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> must be multisampled and must also be 2D (or a slice of a 3D/cubemap texture).</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> can't be copied while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to resolve this texture.</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> texture requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyToBit"/> to be retrieved.</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> texture must <b>not</b> be multisampled and must also be 2D (or a slice of a 3D/cubemap texture).</para>
    /// </summary>
    public Error TextureResolveMultisample(Rid fromTexture, Rid toTexture)
    {
        return (Error)NativeCalls.godot_icall_2_706(MethodBind11, GodotObject.GetPtr(this), fromTexture, toTexture);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureGetFormat, 1374471690ul);

    /// <summary>
    /// <para>Returns the data format used to create this texture.</para>
    /// </summary>
    public RDTextureFormat TextureGetFormat(Rid texture)
    {
        return (RDTextureFormat)NativeCalls.godot_icall_1_913(MethodBind12, GodotObject.GetPtr(this), texture);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureGetNativeHandle, 3917799429ul);

    /// <summary>
    /// <para>Returns the internal graphics handle for this texture object. For use when communicating with third-party APIs mostly with GDExtension.</para>
    /// <para><b>Note:</b> This function returns a <c>uint64_t</c> which internally maps to a <c>GLuint</c> (OpenGL) or <c>VkImage</c> (Vulkan).</para>
    /// </summary>
    [Obsolete("Use 'Godot.RenderingDevice.GetDriverResource(RenderingDevice.DriverResource, Rid, ulong)' with 'Godot.RenderingDevice.DriverResource.Texture' instead.")]
    public ulong TextureGetNativeHandle(Rid texture)
    {
        return NativeCalls.godot_icall_1_739(MethodBind13, GodotObject.GetPtr(this), texture);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferFormatCreate, 697032759ul);

    /// <summary>
    /// <para>Creates a new framebuffer format with the specified <paramref name="attachments"/> and <paramref name="viewCount"/>. Returns the new framebuffer's unique framebuffer format ID.</para>
    /// <para>If <paramref name="viewCount"/> is greater than or equal to <c>2</c>, enables multiview which is used for VR rendering. This requires support for the Vulkan multiview extension.</para>
    /// </summary>
    public long FramebufferFormatCreate(Godot.Collections.Array<RDAttachmentFormat> attachments, uint viewCount = (uint)(1))
    {
        return NativeCalls.godot_icall_2_914(MethodBind14, GodotObject.GetPtr(this), (godot_array)(attachments ?? new()).NativeValue, viewCount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferFormatCreateMultipass, 2647479094ul);

    /// <summary>
    /// <para>Creates a multipass framebuffer format with the specified <paramref name="attachments"/>, <paramref name="passes"/> and <paramref name="viewCount"/> and returns its ID. If <paramref name="viewCount"/> is greater than or equal to <c>2</c>, enables multiview which is used for VR rendering. This requires support for the Vulkan multiview extension.</para>
    /// </summary>
    public long FramebufferFormatCreateMultipass(Godot.Collections.Array<RDAttachmentFormat> attachments, Godot.Collections.Array<RDFramebufferPass> passes, uint viewCount = (uint)(1))
    {
        return NativeCalls.godot_icall_3_915(MethodBind15, GodotObject.GetPtr(this), (godot_array)(attachments ?? new()).NativeValue, (godot_array)(passes ?? new()).NativeValue, viewCount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferFormatCreateEmpty, 555930169ul);

    /// <summary>
    /// <para>Creates a new empty framebuffer format with the specified number of <paramref name="samples"/> and returns its ID.</para>
    /// </summary>
    public long FramebufferFormatCreateEmpty(RenderingDevice.TextureSamples samples = (RenderingDevice.TextureSamples)(0))
    {
        return NativeCalls.godot_icall_1_501(MethodBind16, GodotObject.GetPtr(this), (int)samples);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferFormatGetTextureSamples, 4223391010ul);

    /// <summary>
    /// <para>Returns the number of texture samples used for the given framebuffer <paramref name="format"/> ID (returned by <see cref="Godot.RenderingDevice.FramebufferGetFormat(Rid)"/>).</para>
    /// </summary>
    public RenderingDevice.TextureSamples FramebufferFormatGetTextureSamples(long format, uint renderPass = (uint)(0))
    {
        return (RenderingDevice.TextureSamples)NativeCalls.godot_icall_2_916(MethodBind17, GodotObject.GetPtr(this), format, renderPass);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferCreate, 3284231055ul);

    /// <summary>
    /// <para>Creates a new framebuffer. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    public Rid FramebufferCreate(Godot.Collections.Array<Rid> textures, long validateWithFormat = (long)(-1), uint viewCount = (uint)(1))
    {
        return NativeCalls.godot_icall_3_917(MethodBind18, GodotObject.GetPtr(this), (godot_array)(textures ?? new()).NativeValue, validateWithFormat, viewCount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferCreateMultipass, 1750306695ul);

    /// <summary>
    /// <para>Creates a new multipass framebuffer. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    public Rid FramebufferCreateMultipass(Godot.Collections.Array<Rid> textures, Godot.Collections.Array<RDFramebufferPass> passes, long validateWithFormat = (long)(-1), uint viewCount = (uint)(1))
    {
        return NativeCalls.godot_icall_4_918(MethodBind19, GodotObject.GetPtr(this), (godot_array)(textures ?? new()).NativeValue, (godot_array)(passes ?? new()).NativeValue, validateWithFormat, viewCount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferCreateEmpty, 3058360618ul);

    /// <summary>
    /// <para>Creates a new empty framebuffer. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    public unsafe Rid FramebufferCreateEmpty(Vector2I size, RenderingDevice.TextureSamples samples = (RenderingDevice.TextureSamples)(0), long validateWithFormat = (long)(-1))
    {
        return NativeCalls.godot_icall_3_919(MethodBind20, GodotObject.GetPtr(this), &size, (int)samples, validateWithFormat);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferGetFormat, 3917799429ul);

    /// <summary>
    /// <para>Returns the format ID of the framebuffer specified by the <paramref name="framebuffer"/> RID. This ID is guaranteed to be unique for the same formats and does not need to be freed.</para>
    /// </summary>
    public long FramebufferGetFormat(Rid framebuffer)
    {
        return NativeCalls.godot_icall_1_920(MethodBind21, GodotObject.GetPtr(this), framebuffer);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FramebufferIsValid, 4155700596ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the framebuffer specified by the <paramref name="framebuffer"/> RID is valid, <see langword="false"/> otherwise.</para>
    /// </summary>
    public bool FramebufferIsValid(Rid framebuffer)
    {
        return NativeCalls.godot_icall_1_691(MethodBind22, GodotObject.GetPtr(this), framebuffer).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SamplerCreate, 2327892535ul);

    /// <summary>
    /// <para>Creates a new sampler. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    public Rid SamplerCreate(RDSamplerState state)
    {
        return NativeCalls.godot_icall_1_921(MethodBind23, GodotObject.GetPtr(this), GodotObject.GetPtr(state));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SamplerIsFormatSupportedForFilter, 2247922238ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if implementation supports using a texture of <paramref name="format"/> with the given <paramref name="samplerFilter"/>.</para>
    /// </summary>
    public bool SamplerIsFormatSupportedForFilter(RenderingDevice.DataFormat format, RenderingDevice.SamplerFilter samplerFilter)
    {
        return NativeCalls.godot_icall_2_38(MethodBind24, GodotObject.GetPtr(this), (int)format, (int)samplerFilter).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.VertexBufferCreate, 3410049843ul);

    /// <summary>
    /// <para>It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    /// <param name="data">If the parameter is null, then the default value is <c>Array.Empty&lt;byte&gt;()</c>.</param>
    public Rid VertexBufferCreate(uint sizeBytes, byte[] data = null, bool useAsStorage = false)
    {
        byte[] dataOrDefVal = data != null ? data : Array.Empty<byte>();
        return NativeCalls.godot_icall_3_922(MethodBind25, GodotObject.GetPtr(this), sizeBytes, dataOrDefVal, useAsStorage.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.VertexFormatCreate, 1242678479ul);

    /// <summary>
    /// <para>Creates a new vertex format with the specified <paramref name="vertexDescriptions"/>. Returns a unique vertex format ID corresponding to the newly created vertex format.</para>
    /// </summary>
    public long VertexFormatCreate(Godot.Collections.Array<RDVertexAttribute> vertexDescriptions)
    {
        return NativeCalls.godot_icall_1_923(MethodBind26, GodotObject.GetPtr(this), (godot_array)(vertexDescriptions ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.VertexArrayCreate, 3799816279ul);

    /// <summary>
    /// <para>Creates a vertex array based on the specified buffers. Optionally, <paramref name="offsets"/> (in bytes) may be defined for each buffer.</para>
    /// </summary>
    /// <param name="offsets">If the parameter is null, then the default value is <c>Array.Empty&lt;long&gt;()</c>.</param>
    public Rid VertexArrayCreate(uint vertexCount, long vertexFormat, Godot.Collections.Array<Rid> srcBuffers, long[] offsets = null)
    {
        long[] offsetsOrDefVal = offsets != null ? offsets : Array.Empty<long>();
        return NativeCalls.godot_icall_4_924(MethodBind27, GodotObject.GetPtr(this), vertexCount, vertexFormat, (godot_array)(srcBuffers ?? new()).NativeValue, offsetsOrDefVal);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IndexBufferCreate, 3935920523ul);

    /// <summary>
    /// <para>Creates a new index buffer. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    /// <param name="data">If the parameter is null, then the default value is <c>Array.Empty&lt;byte&gt;()</c>.</param>
    public Rid IndexBufferCreate(uint sizeIndices, RenderingDevice.IndexBufferFormat format, byte[] data = null, bool useRestartIndices = false)
    {
        byte[] dataOrDefVal = data != null ? data : Array.Empty<byte>();
        return NativeCalls.godot_icall_4_925(MethodBind28, GodotObject.GetPtr(this), sizeIndices, (int)format, dataOrDefVal, useRestartIndices.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IndexArrayCreate, 2256026069ul);

    /// <summary>
    /// <para>Creates a new index array. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    public Rid IndexArrayCreate(Rid indexBuffer, uint indexOffset, uint indexCount)
    {
        return NativeCalls.godot_icall_3_926(MethodBind29, GodotObject.GetPtr(this), indexBuffer, indexOffset, indexCount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind30 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ShaderCompileSpirVFromSource, 1178973306ul);

    /// <summary>
    /// <para>Compiles a SPIR-V from the shader source code in <paramref name="shaderSource"/> and returns the SPIR-V as a <see cref="Godot.RDShaderSpirV"/>. This intermediate language shader is portable across different GPU models and driver versions, but cannot be run directly by GPUs until compiled into a binary shader using <see cref="Godot.RenderingDevice.ShaderCompileBinaryFromSpirV(RDShaderSpirV, string)"/>.</para>
    /// <para>If <paramref name="allowCache"/> is <see langword="true"/>, make use of the shader cache generated by Godot. This avoids a potentially lengthy shader compilation step if the shader is already in cache. If <paramref name="allowCache"/> is <see langword="false"/>, Godot's shader cache is ignored and the shader will always be recompiled.</para>
    /// </summary>
    public RDShaderSpirV ShaderCompileSpirVFromSource(RDShaderSource shaderSource, bool allowCache = true)
    {
        return (RDShaderSpirV)NativeCalls.godot_icall_2_927(MethodBind30, GodotObject.GetPtr(this), GodotObject.GetPtr(shaderSource), allowCache.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind31 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ShaderCompileBinaryFromSpirV, 134910450ul);

    /// <summary>
    /// <para>Compiles a binary shader from <paramref name="spirVData"/> and returns the compiled binary data as a <see cref="byte"/>[]. This compiled shader is specific to the GPU model and driver version used; it will not work on different GPU models or even different driver versions. See also <see cref="Godot.RenderingDevice.ShaderCompileSpirVFromSource(RDShaderSource, bool)"/>.</para>
    /// <para><paramref name="name"/> is an optional human-readable name that can be given to the compiled shader for organizational purposes.</para>
    /// </summary>
    public byte[] ShaderCompileBinaryFromSpirV(RDShaderSpirV spirVData, string name = "")
    {
        return NativeCalls.godot_icall_2_928(MethodBind31, GodotObject.GetPtr(this), GodotObject.GetPtr(spirVData), name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind32 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ShaderCreateFromSpirV, 342949005ul);

    /// <summary>
    /// <para>Creates a new shader instance from SPIR-V intermediate code. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method. See also <see cref="Godot.RenderingDevice.ShaderCompileSpirVFromSource(RDShaderSource, bool)"/> and <see cref="Godot.RenderingDevice.ShaderCreateFromBytecode(byte[], Rid)"/>.</para>
    /// </summary>
    public Rid ShaderCreateFromSpirV(RDShaderSpirV spirVData, string name = "")
    {
        return NativeCalls.godot_icall_2_929(MethodBind32, GodotObject.GetPtr(this), GodotObject.GetPtr(spirVData), name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind33 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ShaderCreateFromBytecode, 1687031350ul);

    /// <summary>
    /// <para>Creates a new shader instance from a binary compiled shader. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method. See also <see cref="Godot.RenderingDevice.ShaderCompileBinaryFromSpirV(RDShaderSpirV, string)"/> and <see cref="Godot.RenderingDevice.ShaderCreateFromSpirV(RDShaderSpirV, string)"/>.</para>
    /// </summary>
    public Rid ShaderCreateFromBytecode(byte[] binaryData, Rid placeholderRid = default)
    {
        return NativeCalls.godot_icall_2_930(MethodBind33, GodotObject.GetPtr(this), binaryData, placeholderRid);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind34 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ShaderCreatePlaceholder, 529393457ul);

    /// <summary>
    /// <para>Create a placeholder RID by allocating an RID without initializing it for use in <see cref="Godot.RenderingDevice.ShaderCreateFromBytecode(byte[], Rid)"/>. This allows you to create an RID for a shader and pass it around, but defer compiling the shader to a later time.</para>
    /// </summary>
    public Rid ShaderCreatePlaceholder()
    {
        return NativeCalls.godot_icall_0_217(MethodBind34, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind35 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ShaderGetVertexInputAttributeMask, 3917799429ul);

    /// <summary>
    /// <para>Returns the internal vertex input mask. Internally, the vertex input mask is an unsigned integer consisting of the locations (specified in GLSL via. <c>layout(location = ...)</c>) of the input variables (specified in GLSL by the <c>in</c> keyword).</para>
    /// </summary>
    public ulong ShaderGetVertexInputAttributeMask(Rid shader)
    {
        return NativeCalls.godot_icall_1_739(MethodBind35, GodotObject.GetPtr(this), shader);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind36 = ClassDB_get_method_with_compatibility(NativeName, MethodName.UniformBufferCreate, 34556762ul);

    /// <summary>
    /// <para>Creates a new uniform buffer. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    /// <param name="data">If the parameter is null, then the default value is <c>Array.Empty&lt;byte&gt;()</c>.</param>
    public Rid UniformBufferCreate(uint sizeBytes, byte[] data = null)
    {
        byte[] dataOrDefVal = data != null ? data : Array.Empty<byte>();
        return NativeCalls.godot_icall_2_931(MethodBind36, GodotObject.GetPtr(this), sizeBytes, dataOrDefVal);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind37 = ClassDB_get_method_with_compatibility(NativeName, MethodName.StorageBufferCreate, 2316365934ul);

    /// <summary>
    /// <para>Creates a <a href="https://vkguide.dev/docs/chapter-4/storage_buffers/">storage buffer</a> with the specified <paramref name="data"/> and <paramref name="usage"/>. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    /// <param name="data">If the parameter is null, then the default value is <c>Array.Empty&lt;byte&gt;()</c>.</param>
    public Rid StorageBufferCreate(uint sizeBytes, byte[] data = null, RenderingDevice.StorageBufferUsage usage = (RenderingDevice.StorageBufferUsage)(0))
    {
        byte[] dataOrDefVal = data != null ? data : Array.Empty<byte>();
        return NativeCalls.godot_icall_3_932(MethodBind37, GodotObject.GetPtr(this), sizeBytes, dataOrDefVal, (int)usage);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind38 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureBufferCreate, 1470338698ul);

    /// <summary>
    /// <para>Creates a new texture buffer. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    /// <param name="data">If the parameter is null, then the default value is <c>Array.Empty&lt;byte&gt;()</c>.</param>
    public Rid TextureBufferCreate(uint sizeBytes, RenderingDevice.DataFormat format, byte[] data = null)
    {
        byte[] dataOrDefVal = data != null ? data : Array.Empty<byte>();
        return NativeCalls.godot_icall_3_933(MethodBind38, GodotObject.GetPtr(this), sizeBytes, (int)format, dataOrDefVal);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind39 = ClassDB_get_method_with_compatibility(NativeName, MethodName.UniformSetCreate, 2280795797ul);

    /// <summary>
    /// <para>Creates a new uniform set. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    public Rid UniformSetCreate(Godot.Collections.Array<RDUniform> uniforms, Rid shader, uint shaderSet)
    {
        return NativeCalls.godot_icall_3_934(MethodBind39, GodotObject.GetPtr(this), (godot_array)(uniforms ?? new()).NativeValue, shader, shaderSet);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind40 = ClassDB_get_method_with_compatibility(NativeName, MethodName.UniformSetIsValid, 3521089500ul);

    /// <summary>
    /// <para>Checks if the <paramref name="uniformSet"/> is valid, i.e. is owned.</para>
    /// </summary>
    public bool UniformSetIsValid(Rid uniformSet)
    {
        return NativeCalls.godot_icall_1_691(MethodBind40, GodotObject.GetPtr(this), uniformSet).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind41 = ClassDB_get_method_with_compatibility(NativeName, MethodName.BufferCopy, 864257779ul);

    /// <summary>
    /// <para>Copies <paramref name="size"/> bytes from the <paramref name="srcBuffer"/> at <paramref name="srcOffset"/> into <paramref name="dstBuffer"/> at <paramref name="dstOffset"/>.</para>
    /// <para>Prints an error if:</para>
    /// <para>- <paramref name="size"/> exceeds the size of either <paramref name="srcBuffer"/> or <paramref name="dstBuffer"/> at their corresponding offsets</para>
    /// <para>- a draw list is currently active (created by <see cref="Godot.RenderingDevice.DrawListBegin(Rid, RenderingDevice.InitialAction, RenderingDevice.FinalAction, RenderingDevice.InitialAction, RenderingDevice.FinalAction, Color[], float, uint, Nullable{Rect2})"/>)</para>
    /// <para>- a compute list is currently active (created by <see cref="Godot.RenderingDevice.ComputeListBegin()"/>)</para>
    /// </summary>
    public Error BufferCopy(Rid srcBuffer, Rid dstBuffer, uint srcOffset, uint dstOffset, uint size)
    {
        return (Error)NativeCalls.godot_icall_5_935(MethodBind41, GodotObject.GetPtr(this), srcBuffer, dstBuffer, srcOffset, dstOffset, size);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind42 = ClassDB_get_method_with_compatibility(NativeName, MethodName.BufferUpdate, 3454956949ul);

    /// <summary>
    /// <para>Updates a region of <paramref name="sizeBytes"/> bytes, starting at <paramref name="offset"/>, in the buffer, with the specified <paramref name="data"/>.</para>
    /// <para>Prints an error if:</para>
    /// <para>- the region specified by <paramref name="offset"/> + <paramref name="sizeBytes"/> exceeds the buffer</para>
    /// <para>- a draw list is currently active (created by <see cref="Godot.RenderingDevice.DrawListBegin(Rid, RenderingDevice.InitialAction, RenderingDevice.FinalAction, RenderingDevice.InitialAction, RenderingDevice.FinalAction, Color[], float, uint, Nullable{Rect2})"/>)</para>
    /// <para>- a compute list is currently active (created by <see cref="Godot.RenderingDevice.ComputeListBegin()"/>)</para>
    /// </summary>
    public Error BufferUpdate(Rid buffer, uint offset, uint sizeBytes, byte[] data)
    {
        return (Error)NativeCalls.godot_icall_4_936(MethodBind42, GodotObject.GetPtr(this), buffer, offset, sizeBytes, data);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind43 = ClassDB_get_method_with_compatibility(NativeName, MethodName.BufferClear, 2452320800ul);

    /// <summary>
    /// <para>Clears the contents of the <paramref name="buffer"/>, clearing <paramref name="sizeBytes"/> bytes, starting at <paramref name="offset"/>.</para>
    /// <para>Prints an error if:</para>
    /// <para>- the size isn't a multiple of four</para>
    /// <para>- the region specified by <paramref name="offset"/> + <paramref name="sizeBytes"/> exceeds the buffer</para>
    /// <para>- a draw list is currently active (created by <see cref="Godot.RenderingDevice.DrawListBegin(Rid, RenderingDevice.InitialAction, RenderingDevice.FinalAction, RenderingDevice.InitialAction, RenderingDevice.FinalAction, Color[], float, uint, Nullable{Rect2})"/>)</para>
    /// <para>- a compute list is currently active (created by <see cref="Godot.RenderingDevice.ComputeListBegin()"/>)</para>
    /// </summary>
    public Error BufferClear(Rid buffer, uint offset, uint sizeBytes)
    {
        return (Error)NativeCalls.godot_icall_3_937(MethodBind43, GodotObject.GetPtr(this), buffer, offset, sizeBytes);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind44 = ClassDB_get_method_with_compatibility(NativeName, MethodName.BufferGetData, 3101830688ul);

    /// <summary>
    /// <para>Returns a copy of the data of the specified <paramref name="buffer"/>, optionally <paramref name="offsetBytes"/> and <paramref name="sizeBytes"/> can be set to copy only a portion of the buffer.</para>
    /// </summary>
    public byte[] BufferGetData(Rid buffer, uint offsetBytes = (uint)(0), uint sizeBytes = (uint)(0))
    {
        return NativeCalls.godot_icall_3_938(MethodBind44, GodotObject.GetPtr(this), buffer, offsetBytes, sizeBytes);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind45 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RenderPipelineCreate, 2385451958ul);

    /// <summary>
    /// <para>Creates a new render pipeline. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    public Rid RenderPipelineCreate(Rid shader, long framebufferFormat, long vertexFormat, RenderingDevice.RenderPrimitive primitive, RDPipelineRasterizationState rasterizationState, RDPipelineMultisampleState multisampleState, RDPipelineDepthStencilState stencilState, RDPipelineColorBlendState colorBlendState, RenderingDevice.PipelineDynamicStateFlags dynamicStateFlags = (RenderingDevice.PipelineDynamicStateFlags)(0), uint forRenderPass = (uint)(0), Godot.Collections.Array<RDPipelineSpecializationConstant> specializationConstants = null)
    {
        return NativeCalls.godot_icall_11_939(MethodBind45, GodotObject.GetPtr(this), shader, framebufferFormat, vertexFormat, (int)primitive, GodotObject.GetPtr(rasterizationState), GodotObject.GetPtr(multisampleState), GodotObject.GetPtr(stencilState), GodotObject.GetPtr(colorBlendState), (int)dynamicStateFlags, forRenderPass, (godot_array)(specializationConstants ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind46 = ClassDB_get_method_with_compatibility(NativeName, MethodName.RenderPipelineIsValid, 3521089500ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the render pipeline specified by the <paramref name="renderPipeline"/> RID is valid, <see langword="false"/> otherwise.</para>
    /// </summary>
    public bool RenderPipelineIsValid(Rid renderPipeline)
    {
        return NativeCalls.godot_icall_1_691(MethodBind46, GodotObject.GetPtr(this), renderPipeline).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind47 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputePipelineCreate, 1448838280ul);

    /// <summary>
    /// <para>Creates a new compute pipeline. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method.</para>
    /// </summary>
    public Rid ComputePipelineCreate(Rid shader, Godot.Collections.Array<RDPipelineSpecializationConstant> specializationConstants = null)
    {
        return NativeCalls.godot_icall_2_940(MethodBind47, GodotObject.GetPtr(this), shader, (godot_array)(specializationConstants ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind48 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputePipelineIsValid, 3521089500ul);

    /// <summary>
    /// <para>Returns <see langword="true"/> if the compute pipeline specified by the <paramref name="computePipeline"/> RID is valid, <see langword="false"/> otherwise.</para>
    /// </summary>
    public bool ComputePipelineIsValid(Rid computePipeline)
    {
        return NativeCalls.godot_icall_1_691(MethodBind48, GodotObject.GetPtr(this), computePipeline).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind49 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetWidth, 1591665591ul);

    /// <summary>
    /// <para>Returns the window width matching the graphics API context for the given window ID (in pixels). Despite the parameter being named <paramref name="screen"/>, this returns the <i>window</i> size. See also <see cref="Godot.RenderingDevice.ScreenGetHeight(int)"/>.</para>
    /// <para><b>Note:</b> Only the main <see cref="Godot.RenderingDevice"/> returned by <see cref="Godot.RenderingServer.GetRenderingDevice()"/> has a width. If called on a local <see cref="Godot.RenderingDevice"/>, this method prints an error and returns <see cref="Godot.RenderingDevice.InvalidId"/>.</para>
    /// </summary>
    public int ScreenGetWidth(int screen = 0)
    {
        return NativeCalls.godot_icall_1_69(MethodBind49, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind50 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetHeight, 1591665591ul);

    /// <summary>
    /// <para>Returns the window height matching the graphics API context for the given window ID (in pixels). Despite the parameter being named <paramref name="screen"/>, this returns the <i>window</i> size. See also <see cref="Godot.RenderingDevice.ScreenGetWidth(int)"/>.</para>
    /// <para><b>Note:</b> Only the main <see cref="Godot.RenderingDevice"/> returned by <see cref="Godot.RenderingServer.GetRenderingDevice()"/> has a height. If called on a local <see cref="Godot.RenderingDevice"/>, this method prints an error and returns <see cref="Godot.RenderingDevice.InvalidId"/>.</para>
    /// </summary>
    public int ScreenGetHeight(int screen = 0)
    {
        return NativeCalls.godot_icall_1_69(MethodBind50, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind51 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetFramebufferFormat, 1591665591ul);

    /// <summary>
    /// <para>Returns the framebuffer format of the given screen.</para>
    /// <para><b>Note:</b> Only the main <see cref="Godot.RenderingDevice"/> returned by <see cref="Godot.RenderingServer.GetRenderingDevice()"/> has a format. If called on a local <see cref="Godot.RenderingDevice"/>, this method prints an error and returns <see cref="Godot.RenderingDevice.InvalidId"/>.</para>
    /// </summary>
    public long ScreenGetFramebufferFormat(int screen = 0)
    {
        return NativeCalls.godot_icall_1_501(MethodBind51, GodotObject.GetPtr(this), screen);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind52 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListBeginForScreen, 3988079995ul);

    /// <summary>
    /// <para>High-level variant of <see cref="Godot.RenderingDevice.DrawListBegin(Rid, RenderingDevice.InitialAction, RenderingDevice.FinalAction, RenderingDevice.InitialAction, RenderingDevice.FinalAction, Color[], float, uint, Nullable{Rect2})"/>, with the parameters automatically being adjusted for drawing onto the window specified by the <paramref name="screen"/> ID.</para>
    /// <para><b>Note:</b> Cannot be used with local RenderingDevices, as these don't have a screen. If called on a local RenderingDevice, <see cref="Godot.RenderingDevice.DrawListBeginForScreen(int, Nullable{Color})"/> returns <see cref="Godot.RenderingDevice.InvalidId"/>.</para>
    /// </summary>
    /// <param name="clearColor">If the parameter is null, then the default value is <c>new Color(0, 0, 0, 1)</c>.</param>
    public unsafe long DrawListBeginForScreen(int screen = 0, Nullable<Color> clearColor = null)
    {
        Color clearColorOrDefVal = clearColor.HasValue ? clearColor.Value : new Color(0, 0, 0, 1);
        return NativeCalls.godot_icall_2_941(MethodBind52, GodotObject.GetPtr(this), screen, &clearColorOrDefVal);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind53 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListBegin, 2686605154ul);

    /// <summary>
    /// <para>Starts a list of raster drawing commands created with the <c>draw_*</c> methods. The returned value should be passed to other <c>draw_list_*</c> functions.</para>
    /// <para>Multiple draw lists cannot be created at the same time; you must finish the previous draw list first using <see cref="Godot.RenderingDevice.DrawListEnd()"/>.</para>
    /// <para>A simple drawing operation might look like this (code is not a complete example):</para>
    /// <para><code>
    /// var rd = RenderingDevice.new()
    /// var clear_colors = PackedColorArray([Color(0, 0, 0, 0), Color(0, 0, 0, 0), Color(0, 0, 0, 0)])
    /// var draw_list = rd.draw_list_begin(framebuffers[i], RenderingDevice.INITIAL_ACTION_CLEAR, RenderingDevice.FINAL_ACTION_READ, RenderingDevice.INITIAL_ACTION_CLEAR, RenderingDevice.FINAL_ACTION_DISCARD, clear_colors)
    /// 
    /// # Draw opaque.
    /// rd.draw_list_bind_render_pipeline(draw_list, raster_pipeline)
    /// rd.draw_list_bind_uniform_set(draw_list, raster_base_uniform, 0)
    /// rd.draw_list_set_push_constant(draw_list, raster_push_constant, raster_push_constant.size())
    /// rd.draw_list_draw(draw_list, false, 1, slice_triangle_count[i] * 3)
    /// # Draw wire.
    /// rd.draw_list_bind_render_pipeline(draw_list, raster_pipeline_wire)
    /// rd.draw_list_bind_uniform_set(draw_list, raster_base_uniform, 0)
    /// rd.draw_list_set_push_constant(draw_list, raster_push_constant, raster_push_constant.size())
    /// rd.draw_list_draw(draw_list, false, 1, slice_triangle_count[i] * 3)
    /// 
    /// rd.draw_list_end()
    /// </code></para>
    /// </summary>
    /// <param name="clearColorValues">If the parameter is null, then the default value is <c>Array.Empty&lt;Color&gt;()</c>.</param>
    /// <param name="region">If the parameter is null, then the default value is <c>new Rect2(new Vector2(0, 0), new Vector2(0, 0))</c>.</param>
    public unsafe long DrawListBegin(Rid framebuffer, RenderingDevice.InitialAction initialColorAction, RenderingDevice.FinalAction finalColorAction, RenderingDevice.InitialAction initialDepthAction, RenderingDevice.FinalAction finalDepthAction, Color[] clearColorValues = null, float clearDepth = 1f, uint clearStencil = (uint)(0), Nullable<Rect2> region = null)
    {
        Color[] clearColorValuesOrDefVal = clearColorValues != null ? clearColorValues : Array.Empty<Color>();
        Rect2 regionOrDefVal = region.HasValue ? region.Value : new Rect2(new Vector2(0, 0), new Vector2(0, 0));
        return NativeCalls.godot_icall_9_942(MethodBind53, GodotObject.GetPtr(this), framebuffer, (int)initialColorAction, (int)finalColorAction, (int)initialDepthAction, (int)finalDepthAction, clearColorValuesOrDefVal, clearDepth, clearStencil, &regionOrDefVal);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind54 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListBeginSplit, 2406300660ul);

    /// <summary>
    /// <para>This method does nothing and always returns an empty <see cref="long"/>[].</para>
    /// </summary>
    /// <param name="clearColorValues">If the parameter is null, then the default value is <c>Array.Empty&lt;Color&gt;()</c>.</param>
    /// <param name="region">If the parameter is null, then the default value is <c>new Rect2(new Vector2(0, 0), new Vector2(0, 0))</c>.</param>
    [Obsolete("Split draw lists are used automatically by RenderingDevice.")]
    public unsafe long[] DrawListBeginSplit(Rid framebuffer, uint splits, RenderingDevice.InitialAction initialColorAction, RenderingDevice.FinalAction finalColorAction, RenderingDevice.InitialAction initialDepthAction, RenderingDevice.FinalAction finalDepthAction, Color[] clearColorValues = null, float clearDepth = 1f, uint clearStencil = (uint)(0), Nullable<Rect2> region = null, Godot.Collections.Array<Rid> storageTextures = null)
    {
        Color[] clearColorValuesOrDefVal = clearColorValues != null ? clearColorValues : Array.Empty<Color>();
        Rect2 regionOrDefVal = region.HasValue ? region.Value : new Rect2(new Vector2(0, 0), new Vector2(0, 0));
        return NativeCalls.godot_icall_11_943(MethodBind54, GodotObject.GetPtr(this), framebuffer, splits, (int)initialColorAction, (int)finalColorAction, (int)initialDepthAction, (int)finalDepthAction, clearColorValuesOrDefVal, clearDepth, clearStencil, &regionOrDefVal, (godot_array)(storageTextures ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind55 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListSetBlendConstants, 2878471219ul);

    /// <summary>
    /// <para>Sets blend constants for the specified <paramref name="drawList"/> to <paramref name="color"/>. Blend constants are used only if the graphics pipeline is created with <see cref="Godot.RenderingDevice.PipelineDynamicStateFlags.BlendConstants"/> flag set.</para>
    /// </summary>
    public unsafe void DrawListSetBlendConstants(long drawList, Color color)
    {
        NativeCalls.godot_icall_2_944(MethodBind55, GodotObject.GetPtr(this), drawList, &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind56 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListBindRenderPipeline, 4040184819ul);

    /// <summary>
    /// <para>Binds <paramref name="renderPipeline"/> to the specified <paramref name="drawList"/>.</para>
    /// </summary>
    public void DrawListBindRenderPipeline(long drawList, Rid renderPipeline)
    {
        NativeCalls.godot_icall_2_945(MethodBind56, GodotObject.GetPtr(this), drawList, renderPipeline);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind57 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListBindUniformSet, 749655778ul);

    /// <summary>
    /// <para>Binds <paramref name="uniformSet"/> to the specified <paramref name="drawList"/>. A <paramref name="setIndex"/> must also be specified, which is an identifier starting from <c>0</c> that must match the one expected by the draw list.</para>
    /// </summary>
    public void DrawListBindUniformSet(long drawList, Rid uniformSet, uint setIndex)
    {
        NativeCalls.godot_icall_3_946(MethodBind57, GodotObject.GetPtr(this), drawList, uniformSet, setIndex);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind58 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListBindVertexArray, 4040184819ul);

    /// <summary>
    /// <para>Binds <paramref name="vertexArray"/> to the specified <paramref name="drawList"/>.</para>
    /// </summary>
    public void DrawListBindVertexArray(long drawList, Rid vertexArray)
    {
        NativeCalls.godot_icall_2_945(MethodBind58, GodotObject.GetPtr(this), drawList, vertexArray);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind59 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListBindIndexArray, 4040184819ul);

    /// <summary>
    /// <para>Binds <paramref name="indexArray"/> to the specified <paramref name="drawList"/>.</para>
    /// </summary>
    public void DrawListBindIndexArray(long drawList, Rid indexArray)
    {
        NativeCalls.godot_icall_2_945(MethodBind59, GodotObject.GetPtr(this), drawList, indexArray);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind60 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListSetPushConstant, 2772371345ul);

    /// <summary>
    /// <para>Sets the push constant data to <paramref name="buffer"/> for the specified <paramref name="drawList"/>. The shader determines how this binary data is used. The buffer's size in bytes must also be specified in <paramref name="sizeBytes"/> (this can be obtained by calling the <c>PackedByteArray.size</c> method on the passed <paramref name="buffer"/>).</para>
    /// </summary>
    public void DrawListSetPushConstant(long drawList, byte[] buffer, uint sizeBytes)
    {
        NativeCalls.godot_icall_3_947(MethodBind60, GodotObject.GetPtr(this), drawList, buffer, sizeBytes);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind61 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListDraw, 4230067973ul);

    /// <summary>
    /// <para>Submits <paramref name="drawList"/> for rendering on the GPU. This is the raster equivalent to <see cref="Godot.RenderingDevice.ComputeListDispatch(long, uint, uint, uint)"/>.</para>
    /// </summary>
    public void DrawListDraw(long drawList, bool useIndices, uint instances, uint proceduralVertexCount = (uint)(0))
    {
        NativeCalls.godot_icall_4_948(MethodBind61, GodotObject.GetPtr(this), drawList, useIndices.ToGodotBool(), instances, proceduralVertexCount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind62 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListEnableScissor, 244650101ul);

    /// <summary>
    /// <para>Creates a scissor rectangle and enables it for the specified <paramref name="drawList"/>. Scissor rectangles are used for clipping by discarding fragments that fall outside a specified rectangular portion of the screen. See also <see cref="Godot.RenderingDevice.DrawListDisableScissor(long)"/>.</para>
    /// <para><b>Note:</b> The specified <paramref name="rect"/> is automatically intersected with the screen's dimensions, which means it cannot exceed the screen's dimensions.</para>
    /// </summary>
    /// <param name="rect">If the parameter is null, then the default value is <c>new Rect2(new Vector2(0, 0), new Vector2(0, 0))</c>.</param>
    public unsafe void DrawListEnableScissor(long drawList, Nullable<Rect2> rect = null)
    {
        Rect2 rectOrDefVal = rect.HasValue ? rect.Value : new Rect2(new Vector2(0, 0), new Vector2(0, 0));
        NativeCalls.godot_icall_2_949(MethodBind62, GodotObject.GetPtr(this), drawList, &rectOrDefVal);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind63 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListDisableScissor, 1286410249ul);

    /// <summary>
    /// <para>Removes and disables the scissor rectangle for the specified <paramref name="drawList"/>. See also <see cref="Godot.RenderingDevice.DrawListEnableScissor(long, Nullable{Rect2})"/>.</para>
    /// </summary>
    public void DrawListDisableScissor(long drawList)
    {
        NativeCalls.godot_icall_1_10(MethodBind63, GodotObject.GetPtr(this), drawList);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind64 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListSwitchToNextPass, 2455072627ul);

    /// <summary>
    /// <para>Switches to the next draw pass.</para>
    /// </summary>
    public long DrawListSwitchToNextPass()
    {
        return NativeCalls.godot_icall_0_4(MethodBind64, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind65 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListSwitchToNextPassSplit, 2865087369ul);

    /// <summary>
    /// <para>This method does nothing and always returns an empty <see cref="long"/>[].</para>
    /// </summary>
    [Obsolete("Split draw lists are used automatically by RenderingDevice.")]
    public long[] DrawListSwitchToNextPassSplit(uint splits)
    {
        return NativeCalls.godot_icall_1_950(MethodBind65, GodotObject.GetPtr(this), splits);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind66 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListEnd, 3218959716ul);

    /// <summary>
    /// <para>Finishes a list of raster drawing commands created with the <c>draw_*</c> methods.</para>
    /// </summary>
    public void DrawListEnd()
    {
        NativeCalls.godot_icall_0_3(MethodBind66, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind67 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListBegin, 2455072627ul);

    /// <summary>
    /// <para>Starts a list of compute commands created with the <c>compute_*</c> methods. The returned value should be passed to other <c>compute_list_*</c> functions.</para>
    /// <para>Multiple compute lists cannot be created at the same time; you must finish the previous compute list first using <see cref="Godot.RenderingDevice.ComputeListEnd()"/>.</para>
    /// <para>A simple compute operation might look like this (code is not a complete example):</para>
    /// <para><code>
    /// var rd = RenderingDevice.new()
    /// var compute_list = rd.compute_list_begin()
    /// 
    /// rd.compute_list_bind_compute_pipeline(compute_list, compute_shader_dilate_pipeline)
    /// rd.compute_list_bind_uniform_set(compute_list, compute_base_uniform_set, 0)
    /// rd.compute_list_bind_uniform_set(compute_list, dilate_uniform_set, 1)
    /// 
    /// for i in atlas_slices:
    ///     rd.compute_list_set_push_constant(compute_list, push_constant, push_constant.size())
    ///     rd.compute_list_dispatch(compute_list, group_size.x, group_size.y, group_size.z)
    ///     # No barrier, let them run all together.
    /// 
    /// rd.compute_list_end()
    /// </code></para>
    /// </summary>
    public long ComputeListBegin()
    {
        return NativeCalls.godot_icall_0_4(MethodBind67, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind68 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListBindComputePipeline, 4040184819ul);

    /// <summary>
    /// <para>Tells the GPU what compute pipeline to use when processing the compute list. If the shader has changed since the last time this function was called, Godot will unbind all descriptor sets and will re-bind them inside <see cref="Godot.RenderingDevice.ComputeListDispatch(long, uint, uint, uint)"/>.</para>
    /// </summary>
    public void ComputeListBindComputePipeline(long computeList, Rid computePipeline)
    {
        NativeCalls.godot_icall_2_945(MethodBind68, GodotObject.GetPtr(this), computeList, computePipeline);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind69 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListSetPushConstant, 2772371345ul);

    /// <summary>
    /// <para>Sets the push constant data to <paramref name="buffer"/> for the specified <paramref name="computeList"/>. The shader determines how this binary data is used. The buffer's size in bytes must also be specified in <paramref name="sizeBytes"/> (this can be obtained by calling the <c>PackedByteArray.size</c> method on the passed <paramref name="buffer"/>).</para>
    /// </summary>
    public void ComputeListSetPushConstant(long computeList, byte[] buffer, uint sizeBytes)
    {
        NativeCalls.godot_icall_3_947(MethodBind69, GodotObject.GetPtr(this), computeList, buffer, sizeBytes);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind70 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListBindUniformSet, 749655778ul);

    /// <summary>
    /// <para>Binds the <paramref name="uniformSet"/> to this <paramref name="computeList"/>. Godot ensures that all textures in the uniform set have the correct Vulkan access masks. If Godot had to change access masks of textures, it will raise a Vulkan image memory barrier.</para>
    /// </summary>
    public void ComputeListBindUniformSet(long computeList, Rid uniformSet, uint setIndex)
    {
        NativeCalls.godot_icall_3_946(MethodBind70, GodotObject.GetPtr(this), computeList, uniformSet, setIndex);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind71 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListDispatch, 4275841770ul);

    /// <summary>
    /// <para>Submits the compute list for processing on the GPU. This is the compute equivalent to <see cref="Godot.RenderingDevice.DrawListDraw(long, bool, uint, uint)"/>.</para>
    /// </summary>
    public void ComputeListDispatch(long computeList, uint xGroups, uint yGroups, uint zGroups)
    {
        NativeCalls.godot_icall_4_951(MethodBind71, GodotObject.GetPtr(this), computeList, xGroups, yGroups, zGroups);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind72 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListDispatchIndirect, 749655778ul);

    /// <summary>
    /// <para>Submits the compute list for processing on the GPU with the given group counts stored in the <paramref name="buffer"/> at <paramref name="offset"/>. Buffer must have been created with <see cref="Godot.RenderingDevice.StorageBufferUsage.Indirect"/> flag.</para>
    /// </summary>
    public void ComputeListDispatchIndirect(long computeList, Rid buffer, uint offset)
    {
        NativeCalls.godot_icall_3_946(MethodBind72, GodotObject.GetPtr(this), computeList, buffer, offset);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind73 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListAddBarrier, 1286410249ul);

    /// <summary>
    /// <para>Raises a Vulkan compute barrier in the specified <paramref name="computeList"/>.</para>
    /// </summary>
    public void ComputeListAddBarrier(long computeList)
    {
        NativeCalls.godot_icall_1_10(MethodBind73, GodotObject.GetPtr(this), computeList);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind74 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListEnd, 3218959716ul);

    /// <summary>
    /// <para>Finishes a list of compute commands created with the <c>compute_*</c> methods.</para>
    /// </summary>
    public void ComputeListEnd()
    {
        NativeCalls.godot_icall_0_3(MethodBind74, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind75 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FreeRid, 2722037293ul);

    /// <summary>
    /// <para>Tries to free an object in the RenderingDevice. To avoid memory leaks, this should be called after using an object as memory management does not occur automatically when using RenderingDevice directly.</para>
    /// </summary>
    public void FreeRid(Rid rid)
    {
        NativeCalls.godot_icall_1_255(MethodBind75, GodotObject.GetPtr(this), rid);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind76 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CaptureTimestamp, 83702148ul);

    /// <summary>
    /// <para>Creates a timestamp marker with the specified <paramref name="name"/>. This is used for performance reporting with the <see cref="Godot.RenderingDevice.GetCapturedTimestampCpuTime(uint)"/>, <see cref="Godot.RenderingDevice.GetCapturedTimestampGpuTime(uint)"/> and <see cref="Godot.RenderingDevice.GetCapturedTimestampName(uint)"/> methods.</para>
    /// </summary>
    public void CaptureTimestamp(string name)
    {
        NativeCalls.godot_icall_1_56(MethodBind76, GodotObject.GetPtr(this), name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind77 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCapturedTimestampsCount, 3905245786ul);

    /// <summary>
    /// <para>Returns the total number of timestamps (rendering steps) available for profiling.</para>
    /// </summary>
    public uint GetCapturedTimestampsCount()
    {
        return NativeCalls.godot_icall_0_193(MethodBind77, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind78 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCapturedTimestampsFrame, 3905245786ul);

    /// <summary>
    /// <para>Returns the index of the last frame rendered that has rendering timestamps available for querying.</para>
    /// </summary>
    public ulong GetCapturedTimestampsFrame()
    {
        return NativeCalls.godot_icall_0_344(MethodBind78, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind79 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCapturedTimestampGpuTime, 923996154ul);

    /// <summary>
    /// <para>Returns the timestamp in GPU time for the rendering step specified by <paramref name="index"/> (in microseconds since the engine started). See also <see cref="Godot.RenderingDevice.GetCapturedTimestampCpuTime(uint)"/> and <see cref="Godot.RenderingDevice.CaptureTimestamp(string)"/>.</para>
    /// </summary>
    public ulong GetCapturedTimestampGpuTime(uint index)
    {
        return NativeCalls.godot_icall_1_952(MethodBind79, GodotObject.GetPtr(this), index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind80 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCapturedTimestampCpuTime, 923996154ul);

    /// <summary>
    /// <para>Returns the timestamp in CPU time for the rendering step specified by <paramref name="index"/> (in microseconds since the engine started). See also <see cref="Godot.RenderingDevice.GetCapturedTimestampGpuTime(uint)"/> and <see cref="Godot.RenderingDevice.CaptureTimestamp(string)"/>.</para>
    /// </summary>
    public ulong GetCapturedTimestampCpuTime(uint index)
    {
        return NativeCalls.godot_icall_1_952(MethodBind80, GodotObject.GetPtr(this), index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind81 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetCapturedTimestampName, 844755477ul);

    /// <summary>
    /// <para>Returns the timestamp's name for the rendering step specified by <paramref name="index"/>. See also <see cref="Godot.RenderingDevice.CaptureTimestamp(string)"/>.</para>
    /// </summary>
    public string GetCapturedTimestampName(uint index)
    {
        return NativeCalls.godot_icall_1_953(MethodBind81, GodotObject.GetPtr(this), index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind82 = ClassDB_get_method_with_compatibility(NativeName, MethodName.LimitGet, 1559202131ul);

    /// <summary>
    /// <para>Returns the value of the specified <paramref name="limit"/>. This limit varies depending on the current graphics hardware (and sometimes the driver version). If the given limit is exceeded, rendering errors will occur.</para>
    /// <para>Limits for various graphics hardware can be found in the <a href="https://vulkan.gpuinfo.org/">Vulkan Hardware Database</a>.</para>
    /// </summary>
    public ulong LimitGet(RenderingDevice.Limit limit)
    {
        return NativeCalls.godot_icall_1_381(MethodBind82, GodotObject.GetPtr(this), (int)limit);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind83 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFrameDelay, 3905245786ul);

    /// <summary>
    /// <para>Returns the frame count kept by the graphics API. Higher values result in higher input lag, but with more consistent throughput. For the main <see cref="Godot.RenderingDevice"/>, frames are cycled (usually 3 with triple-buffered V-Sync enabled). However, local <see cref="Godot.RenderingDevice"/>s only have 1 frame.</para>
    /// </summary>
    public uint GetFrameDelay()
    {
        return NativeCalls.godot_icall_0_193(MethodBind83, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind84 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Submit, 3218959716ul);

    /// <summary>
    /// <para>Pushes the frame setup and draw command buffers then marks the local device as currently processing (which allows calling <see cref="Godot.RenderingDevice.Sync()"/>).</para>
    /// <para><b>Note:</b> Only available in local RenderingDevices.</para>
    /// </summary>
    public void Submit()
    {
        NativeCalls.godot_icall_0_3(MethodBind84, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind85 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Sync, 3218959716ul);

    /// <summary>
    /// <para>Forces a synchronization between the CPU and GPU, which may be required in certain cases. Only call this when needed, as CPU-GPU synchronization has a performance cost.</para>
    /// <para><b>Note:</b> Only available in local RenderingDevices.</para>
    /// <para><b>Note:</b> <see cref="Godot.RenderingDevice.Sync()"/> can only be called after a <see cref="Godot.RenderingDevice.Submit()"/>.</para>
    /// </summary>
    public void Sync()
    {
        NativeCalls.godot_icall_0_3(MethodBind85, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind86 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Barrier, 3718155691ul);

    /// <summary>
    /// <para>This method does nothing.</para>
    /// </summary>
    [Obsolete("Barriers are automatically inserted by RenderingDevice.")]
    public void Barrier(RenderingDevice.BarrierMask from = (RenderingDevice.BarrierMask)(32767), RenderingDevice.BarrierMask to = (RenderingDevice.BarrierMask)(32767))
    {
        NativeCalls.godot_icall_2_73(MethodBind86, GodotObject.GetPtr(this), (int)from, (int)to);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind87 = ClassDB_get_method_with_compatibility(NativeName, MethodName.FullBarrier, 3218959716ul);

    /// <summary>
    /// <para>This method does nothing.</para>
    /// </summary>
    [Obsolete("Barriers are automatically inserted by RenderingDevice.")]
    public void FullBarrier()
    {
        NativeCalls.godot_icall_0_3(MethodBind87, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind88 = ClassDB_get_method_with_compatibility(NativeName, MethodName.CreateLocalDevice, 2846302423ul);

    /// <summary>
    /// <para>Create a new local <see cref="Godot.RenderingDevice"/>. This is most useful for performing compute operations on the GPU independently from the rest of the engine.</para>
    /// </summary>
    public RenderingDevice CreateLocalDevice()
    {
        return (RenderingDevice)NativeCalls.godot_icall_0_52(MethodBind88, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind89 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetResourceName, 2726140452ul);

    /// <summary>
    /// <para>Sets the resource name for <paramref name="id"/> to <paramref name="name"/>. This is used for debugging with third-party tools such as <a href="https://renderdoc.org/">RenderDoc</a>.</para>
    /// <para>The following types of resources can be named: texture, sampler, vertex buffer, index buffer, uniform buffer, texture buffer, storage buffer, uniform set buffer, shader, render pipeline and compute pipeline. Framebuffers cannot be named. Attempting to name an incompatible resource type will print an error.</para>
    /// <para><b>Note:</b> Resource names are only set when the engine runs in verbose mode (<see cref="Godot.OS.IsStdOutVerbose()"/> = <see langword="true"/>), or when using an engine build compiled with the <c>dev_mode=yes</c> SCons option. The graphics driver must also support the <c>VK_EXT_DEBUG_UTILS_EXTENSION_NAME</c> Vulkan extension for named resources to work.</para>
    /// </summary>
    public void SetResourceName(Rid id, string name)
    {
        NativeCalls.godot_icall_2_954(MethodBind89, GodotObject.GetPtr(this), id, name);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind90 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawCommandBeginLabel, 1636512886ul);

    /// <summary>
    /// <para>Create a command buffer debug label region that can be displayed in third-party tools such as <a href="https://renderdoc.org/">RenderDoc</a>. All regions must be ended with a <see cref="Godot.RenderingDevice.DrawCommandEndLabel()"/> call. When viewed from the linear series of submissions to a single queue, calls to <see cref="Godot.RenderingDevice.DrawCommandBeginLabel(string, Color)"/> and <see cref="Godot.RenderingDevice.DrawCommandEndLabel()"/> must be matched and balanced.</para>
    /// <para>The <c>VK_EXT_DEBUG_UTILS_EXTENSION_NAME</c> Vulkan extension must be available and enabled for command buffer debug label region to work. See also <see cref="Godot.RenderingDevice.DrawCommandEndLabel()"/>.</para>
    /// </summary>
    public unsafe void DrawCommandBeginLabel(string name, Color color)
    {
        NativeCalls.godot_icall_2_276(MethodBind90, GodotObject.GetPtr(this), name, &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind91 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawCommandInsertLabel, 1636512886ul);

    /// <summary>
    /// <para>This method does nothing.</para>
    /// </summary>
    [Obsolete("Inserting labels no longer applies due to command reordering.")]
    public unsafe void DrawCommandInsertLabel(string name, Color color)
    {
        NativeCalls.godot_icall_2_276(MethodBind91, GodotObject.GetPtr(this), name, &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind92 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawCommandEndLabel, 3218959716ul);

    /// <summary>
    /// <para>Ends the command buffer debug label region started by a <see cref="Godot.RenderingDevice.DrawCommandBeginLabel(string, Color)"/> call.</para>
    /// </summary>
    public void DrawCommandEndLabel()
    {
        NativeCalls.godot_icall_0_3(MethodBind92, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind93 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDeviceVendorName, 201670096ul);

    /// <summary>
    /// <para>Returns the vendor of the video adapter (e.g. "NVIDIA Corporation"). Equivalent to <see cref="Godot.RenderingServer.GetVideoAdapterVendor()"/>. See also <see cref="Godot.RenderingDevice.GetDeviceName()"/>.</para>
    /// </summary>
    public string GetDeviceVendorName()
    {
        return NativeCalls.godot_icall_0_57(MethodBind93, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind94 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDeviceName, 201670096ul);

    /// <summary>
    /// <para>Returns the name of the video adapter (e.g. "GeForce GTX 1080/PCIe/SSE2"). Equivalent to <see cref="Godot.RenderingServer.GetVideoAdapterName()"/>. See also <see cref="Godot.RenderingDevice.GetDeviceVendorName()"/>.</para>
    /// </summary>
    public string GetDeviceName()
    {
        return NativeCalls.godot_icall_0_57(MethodBind94, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind95 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDevicePipelineCacheUuid, 201670096ul);

    /// <summary>
    /// <para>Returns the universally unique identifier for the pipeline cache. This is used to cache shader files on disk, which avoids shader recompilations on subsequent engine runs. This UUID varies depending on the graphics card model, but also the driver version. Therefore, updating graphics drivers will invalidate the shader cache.</para>
    /// </summary>
    public string GetDevicePipelineCacheUuid()
    {
        return NativeCalls.godot_icall_0_57(MethodBind95, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind96 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetMemoryUsage, 251690689ul);

    /// <summary>
    /// <para>Returns the memory usage in bytes corresponding to the given <paramref name="type"/>. When using Vulkan, these statistics are calculated by <a href="https://github.com/GPUOpen-LibrariesAndSDKs/VulkanMemoryAllocator">Vulkan Memory Allocator</a>.</para>
    /// </summary>
    public ulong GetMemoryUsage(RenderingDevice.MemoryType type)
    {
        return NativeCalls.godot_icall_1_381(MethodBind96, GodotObject.GetPtr(this), (int)type);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind97 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDriverResource, 501815484ul);

    /// <summary>
    /// <para>Returns the unique identifier of the driver <paramref name="resource"/> for the specified <paramref name="rid"/>. Some driver resource types ignore the specified <paramref name="rid"/> (see <see cref="Godot.RenderingDevice.DriverResource"/> descriptions). <paramref name="index"/> is always ignored but must be specified anyway.</para>
    /// </summary>
    public ulong GetDriverResource(RenderingDevice.DriverResource resource, Rid rid, ulong index)
    {
        return NativeCalls.godot_icall_3_955(MethodBind97, GodotObject.GetPtr(this), (int)resource, rid, index);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind98 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ScreenGetFramebufferFormat, 3905245786ul);

    /// <summary>
    /// <para>Returns the framebuffer format of the given screen.</para>
    /// <para><b>Note:</b> Only the main <see cref="Godot.RenderingDevice"/> returned by <see cref="Godot.RenderingServer.GetRenderingDevice()"/> has a format. If called on a local <see cref="Godot.RenderingDevice"/>, this method prints an error and returns <see cref="Godot.RenderingDevice.InvalidId"/>.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public long ScreenGetFramebufferFormat()
    {
        return NativeCalls.godot_icall_0_4(MethodBind98, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind99 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureResolveMultisample, 594679454ul);

    /// <summary>
    /// <para>Resolves the <paramref name="fromTexture"/> texture onto <paramref name="toTexture"/> with multisample antialiasing enabled. This must be used when rendering a framebuffer for MSAA to work. Returns <see cref="Godot.Error.Ok"/> if successful, <see cref="Godot.Error.InvalidParameter"/> otherwise.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> and <paramref name="toTexture"/> textures must have the same dimension, format and type (color or depth).</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> can't be copied while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to resolve this texture.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyFromBit"/> to be retrieved.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> must be multisampled and must also be 2D (or a slice of a 3D/cubemap texture).</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> can't be copied while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to resolve this texture.</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> texture requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyToBit"/> to be retrieved.</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> texture must <b>not</b> be multisampled and must also be 2D (or a slice of a 3D/cubemap texture).</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Error TextureResolveMultisample(Rid fromTexture, Rid toTexture, RenderingDevice.BarrierMask postBarrier)
    {
        return (Error)NativeCalls.godot_icall_3_956(MethodBind99, GodotObject.GetPtr(this), fromTexture, toTexture, (int)postBarrier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind100 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureClear, 3396867530ul);

    /// <summary>
    /// <para>Clears the specified <paramref name="texture"/> by replacing all of its pixels with the specified <paramref name="color"/>. <paramref name="baseMipmap"/> and <paramref name="mipmapCount"/> determine which mipmaps of the texture are affected by this clear operation, while <paramref name="baseLayer"/> and <paramref name="layerCount"/> determine which layers of a 3D texture (or texture array) are affected by this clear operation. For 2D textures (which only have one layer by design), <paramref name="baseLayer"/> must be <c>0</c> and <paramref name="layerCount"/> must be <c>1</c>.</para>
    /// <para><b>Note:</b> <paramref name="texture"/> can't be cleared while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to clear this texture.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe Error TextureClear(Rid texture, Color color, uint baseMipmap, uint mipmapCount, uint baseLayer, uint layerCount, RenderingDevice.BarrierMask postBarrier)
    {
        return (Error)NativeCalls.godot_icall_7_957(MethodBind100, GodotObject.GetPtr(this), texture, &color, baseMipmap, mipmapCount, baseLayer, layerCount, (int)postBarrier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind101 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureCopy, 2339493201ul);

    /// <summary>
    /// <para>Copies the <paramref name="fromTexture"/> to <paramref name="toTexture"/> with the specified <paramref name="fromPos"/>, <paramref name="toPos"/> and <paramref name="size"/> coordinates. The Z axis of the <paramref name="fromPos"/>, <paramref name="toPos"/> and <paramref name="size"/> must be <c>0</c> for 2-dimensional textures. Source and destination mipmaps/layers must also be specified, with these parameters being <c>0</c> for textures without mipmaps or single-layer textures. Returns <see cref="Godot.Error.Ok"/> if the texture copy was successful or <see cref="Godot.Error.InvalidParameter"/> otherwise.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> texture can't be copied while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to copy this texture.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> texture requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyFromBit"/> to be retrieved.</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> can't be copied while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to copy this texture.</para>
    /// <para><b>Note:</b> <paramref name="toTexture"/> requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanCopyToBit"/> to be retrieved.</para>
    /// <para><b>Note:</b> <paramref name="fromTexture"/> and <paramref name="toTexture"/> must be of the same type (color or depth).</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe Error TextureCopy(Rid fromTexture, Rid toTexture, Vector3 fromPos, Vector3 toPos, Vector3 size, uint srcMipmap, uint dstMipmap, uint srcLayer, uint dstLayer, RenderingDevice.BarrierMask postBarrier)
    {
        return (Error)NativeCalls.godot_icall_10_958(MethodBind101, GodotObject.GetPtr(this), fromTexture, toTexture, &fromPos, &toPos, &size, srcMipmap, dstMipmap, srcLayer, dstLayer, (int)postBarrier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind102 = ClassDB_get_method_with_compatibility(NativeName, MethodName.TextureUpdate, 2096463824ul);

    /// <summary>
    /// <para>Updates texture data with new data, replacing the previous data in place. The updated texture data must have the same dimensions and format. For 2D textures (which only have one layer), <paramref name="layer"/> must be <c>0</c>. Returns <see cref="Godot.Error.Ok"/> if the update was successful, <see cref="Godot.Error.InvalidParameter"/> otherwise.</para>
    /// <para><b>Note:</b> Updating textures is forbidden during creation of a draw or compute list.</para>
    /// <para><b>Note:</b> The existing <paramref name="texture"/> can't be updated while a draw list that uses it as part of a framebuffer is being created. Ensure the draw list is finalized (and that the color/depth texture using it is not set to <see cref="Godot.RenderingDevice.FinalAction.Continue"/>) to update this texture.</para>
    /// <para><b>Note:</b> The existing <paramref name="texture"/> requires the <see cref="Godot.RenderingDevice.TextureUsageBits.CanUpdateBit"/> to be updatable.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Error TextureUpdate(Rid texture, uint layer, byte[] data, RenderingDevice.BarrierMask postBarrier)
    {
        return (Error)NativeCalls.godot_icall_4_959(MethodBind102, GodotObject.GetPtr(this), texture, layer, data, (int)postBarrier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind103 = ClassDB_get_method_with_compatibility(NativeName, MethodName.BufferClear, 2797041220ul);

    /// <summary>
    /// <para>Clears the contents of the <paramref name="buffer"/>, clearing <paramref name="sizeBytes"/> bytes, starting at <paramref name="offset"/>.</para>
    /// <para>Prints an error if:</para>
    /// <para>- the size isn't a multiple of four</para>
    /// <para>- the region specified by <paramref name="offset"/> + <paramref name="sizeBytes"/> exceeds the buffer</para>
    /// <para>- a draw list is currently active (created by <see cref="Godot.RenderingDevice.DrawListBegin(Rid, RenderingDevice.InitialAction, RenderingDevice.FinalAction, RenderingDevice.InitialAction, RenderingDevice.FinalAction, Color[], float, uint, Nullable{Rect2})"/>)</para>
    /// <para>- a compute list is currently active (created by <see cref="Godot.RenderingDevice.ComputeListBegin()"/>)</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Error BufferClear(Rid buffer, uint offset, uint sizeBytes, RenderingDevice.BarrierMask postBarrier)
    {
        return (Error)NativeCalls.godot_icall_4_960(MethodBind103, GodotObject.GetPtr(this), buffer, offset, sizeBytes, (int)postBarrier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind104 = ClassDB_get_method_with_compatibility(NativeName, MethodName.BufferUpdate, 3793150683ul);

    /// <summary>
    /// <para>Updates a region of <paramref name="sizeBytes"/> bytes, starting at <paramref name="offset"/>, in the buffer, with the specified <paramref name="data"/>.</para>
    /// <para>Prints an error if:</para>
    /// <para>- the region specified by <paramref name="offset"/> + <paramref name="sizeBytes"/> exceeds the buffer</para>
    /// <para>- a draw list is currently active (created by <see cref="Godot.RenderingDevice.DrawListBegin(Rid, RenderingDevice.InitialAction, RenderingDevice.FinalAction, RenderingDevice.InitialAction, RenderingDevice.FinalAction, Color[], float, uint, Nullable{Rect2})"/>)</para>
    /// <para>- a compute list is currently active (created by <see cref="Godot.RenderingDevice.ComputeListBegin()"/>)</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Error BufferUpdate(Rid buffer, uint offset, uint sizeBytes, byte[] data, RenderingDevice.BarrierMask postBarrier)
    {
        return (Error)NativeCalls.godot_icall_5_961(MethodBind104, GodotObject.GetPtr(this), buffer, offset, sizeBytes, data, (int)postBarrier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind105 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListBegin, 968564752ul);

    /// <summary>
    /// <para>Starts a list of compute commands created with the <c>compute_*</c> methods. The returned value should be passed to other <c>compute_list_*</c> functions.</para>
    /// <para>Multiple compute lists cannot be created at the same time; you must finish the previous compute list first using <see cref="Godot.RenderingDevice.ComputeListEnd()"/>.</para>
    /// <para>A simple compute operation might look like this (code is not a complete example):</para>
    /// <para><code>
    /// var rd = RenderingDevice.new()
    /// var compute_list = rd.compute_list_begin()
    /// 
    /// rd.compute_list_bind_compute_pipeline(compute_list, compute_shader_dilate_pipeline)
    /// rd.compute_list_bind_uniform_set(compute_list, compute_base_uniform_set, 0)
    /// rd.compute_list_bind_uniform_set(compute_list, dilate_uniform_set, 1)
    /// 
    /// for i in atlas_slices:
    ///     rd.compute_list_set_push_constant(compute_list, push_constant, push_constant.size())
    ///     rd.compute_list_dispatch(compute_list, group_size.x, group_size.y, group_size.z)
    ///     # No barrier, let them run all together.
    /// 
    /// rd.compute_list_end()
    /// </code></para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public long ComputeListBegin(bool allowDrawOverlap)
    {
        return NativeCalls.godot_icall_1_962(MethodBind105, GodotObject.GetPtr(this), allowDrawOverlap.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind106 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListBegin, 2468082605ul);

    /// <summary>
    /// <para>Starts a list of raster drawing commands created with the <c>draw_*</c> methods. The returned value should be passed to other <c>draw_list_*</c> functions.</para>
    /// <para>Multiple draw lists cannot be created at the same time; you must finish the previous draw list first using <see cref="Godot.RenderingDevice.DrawListEnd()"/>.</para>
    /// <para>A simple drawing operation might look like this (code is not a complete example):</para>
    /// <para><code>
    /// var rd = RenderingDevice.new()
    /// var clear_colors = PackedColorArray([Color(0, 0, 0, 0), Color(0, 0, 0, 0), Color(0, 0, 0, 0)])
    /// var draw_list = rd.draw_list_begin(framebuffers[i], RenderingDevice.INITIAL_ACTION_CLEAR, RenderingDevice.FINAL_ACTION_READ, RenderingDevice.INITIAL_ACTION_CLEAR, RenderingDevice.FINAL_ACTION_DISCARD, clear_colors)
    /// 
    /// # Draw opaque.
    /// rd.draw_list_bind_render_pipeline(draw_list, raster_pipeline)
    /// rd.draw_list_bind_uniform_set(draw_list, raster_base_uniform, 0)
    /// rd.draw_list_set_push_constant(draw_list, raster_push_constant, raster_push_constant.size())
    /// rd.draw_list_draw(draw_list, false, 1, slice_triangle_count[i] * 3)
    /// # Draw wire.
    /// rd.draw_list_bind_render_pipeline(draw_list, raster_pipeline_wire)
    /// rd.draw_list_bind_uniform_set(draw_list, raster_base_uniform, 0)
    /// rd.draw_list_set_push_constant(draw_list, raster_push_constant, raster_push_constant.size())
    /// rd.draw_list_draw(draw_list, false, 1, slice_triangle_count[i] * 3)
    /// 
    /// rd.draw_list_end()
    /// </code></para>
    /// </summary>
    /// <param name="clearColorValues">If the parameter is null, then the default value is <c>Array.Empty&lt;Color&gt;()</c>.</param>
    /// <param name="region">If the parameter is null, then the default value is <c>new Rect2(new Vector2(0, 0), new Vector2(0, 0))</c>.</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe long DrawListBegin(Rid framebuffer, RenderingDevice.InitialAction initialColorAction, RenderingDevice.FinalAction finalColorAction, RenderingDevice.InitialAction initialDepthAction, RenderingDevice.FinalAction finalDepthAction, Color[] clearColorValues, float clearDepth, uint clearStencil, Nullable<Rect2> region, Godot.Collections.Array<Rid> storageTextures)
    {
        Color[] clearColorValuesOrDefVal = clearColorValues != null ? clearColorValues : Array.Empty<Color>();
        Rect2 regionOrDefVal = region.HasValue ? region.Value : new Rect2(new Vector2(0, 0), new Vector2(0, 0));
        return NativeCalls.godot_icall_10_963(MethodBind106, GodotObject.GetPtr(this), framebuffer, (int)initialColorAction, (int)finalColorAction, (int)initialDepthAction, (int)finalDepthAction, clearColorValuesOrDefVal, clearDepth, clearStencil, &regionOrDefVal, (godot_array)(storageTextures ?? new()).NativeValue);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind107 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ComputeListEnd, 3920951950ul);

    /// <summary>
    /// <para>Finishes a list of compute commands created with the <c>compute_*</c> methods.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void ComputeListEnd(RenderingDevice.BarrierMask postBarrier)
    {
        NativeCalls.godot_icall_1_36(MethodBind107, GodotObject.GetPtr(this), (int)postBarrier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind108 = ClassDB_get_method_with_compatibility(NativeName, MethodName.DrawListEnd, 3920951950ul);

    /// <summary>
    /// <para>Finishes a list of raster drawing commands created with the <c>draw_*</c> methods.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void DrawListEnd(RenderingDevice.BarrierMask postBarrier)
    {
        NativeCalls.godot_icall_1_36(MethodBind108, GodotObject.GetPtr(this), (int)postBarrier);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind109 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ShaderCreateFromBytecode, 3049171473ul);

    /// <summary>
    /// <para>Creates a new shader instance from a binary compiled shader. It can be accessed with the RID that is returned.</para>
    /// <para>Once finished with your RID, you will want to free the RID using the RenderingDevice's <see cref="Godot.RenderingDevice.FreeRid(Rid)"/> method. See also <see cref="Godot.RenderingDevice.ShaderCompileBinaryFromSpirV(RDShaderSpirV, string)"/> and <see cref="Godot.RenderingDevice.ShaderCreateFromSpirV(RDShaderSpirV, string)"/>.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Rid ShaderCreateFromBytecode(byte[] binaryData)
    {
        return NativeCalls.godot_icall_1_964(MethodBind109, GodotObject.GetPtr(this), binaryData);
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
        /// Cached name for the 'texture_create' method.
        /// </summary>
        public static readonly StringName TextureCreate = "texture_create";
        /// <summary>
        /// Cached name for the 'texture_create_shared' method.
        /// </summary>
        public static readonly StringName TextureCreateShared = "texture_create_shared";
        /// <summary>
        /// Cached name for the 'texture_create_shared_from_slice' method.
        /// </summary>
        public static readonly StringName TextureCreateSharedFromSlice = "texture_create_shared_from_slice";
        /// <summary>
        /// Cached name for the 'texture_create_from_extension' method.
        /// </summary>
        public static readonly StringName TextureCreateFromExtension = "texture_create_from_extension";
        /// <summary>
        /// Cached name for the 'texture_update' method.
        /// </summary>
        public static readonly StringName TextureUpdate = "texture_update";
        /// <summary>
        /// Cached name for the 'texture_get_data' method.
        /// </summary>
        public static readonly StringName TextureGetData = "texture_get_data";
        /// <summary>
        /// Cached name for the 'texture_is_format_supported_for_usage' method.
        /// </summary>
        public static readonly StringName TextureIsFormatSupportedForUsage = "texture_is_format_supported_for_usage";
        /// <summary>
        /// Cached name for the 'texture_is_shared' method.
        /// </summary>
        public static readonly StringName TextureIsShared = "texture_is_shared";
        /// <summary>
        /// Cached name for the 'texture_is_valid' method.
        /// </summary>
        public static readonly StringName TextureIsValid = "texture_is_valid";
        /// <summary>
        /// Cached name for the 'texture_copy' method.
        /// </summary>
        public static readonly StringName TextureCopy = "texture_copy";
        /// <summary>
        /// Cached name for the 'texture_clear' method.
        /// </summary>
        public static readonly StringName TextureClear = "texture_clear";
        /// <summary>
        /// Cached name for the 'texture_resolve_multisample' method.
        /// </summary>
        public static readonly StringName TextureResolveMultisample = "texture_resolve_multisample";
        /// <summary>
        /// Cached name for the 'texture_get_format' method.
        /// </summary>
        public static readonly StringName TextureGetFormat = "texture_get_format";
        /// <summary>
        /// Cached name for the 'texture_get_native_handle' method.
        /// </summary>
        public static readonly StringName TextureGetNativeHandle = "texture_get_native_handle";
        /// <summary>
        /// Cached name for the 'framebuffer_format_create' method.
        /// </summary>
        public static readonly StringName FramebufferFormatCreate = "framebuffer_format_create";
        /// <summary>
        /// Cached name for the 'framebuffer_format_create_multipass' method.
        /// </summary>
        public static readonly StringName FramebufferFormatCreateMultipass = "framebuffer_format_create_multipass";
        /// <summary>
        /// Cached name for the 'framebuffer_format_create_empty' method.
        /// </summary>
        public static readonly StringName FramebufferFormatCreateEmpty = "framebuffer_format_create_empty";
        /// <summary>
        /// Cached name for the 'framebuffer_format_get_texture_samples' method.
        /// </summary>
        public static readonly StringName FramebufferFormatGetTextureSamples = "framebuffer_format_get_texture_samples";
        /// <summary>
        /// Cached name for the 'framebuffer_create' method.
        /// </summary>
        public static readonly StringName FramebufferCreate = "framebuffer_create";
        /// <summary>
        /// Cached name for the 'framebuffer_create_multipass' method.
        /// </summary>
        public static readonly StringName FramebufferCreateMultipass = "framebuffer_create_multipass";
        /// <summary>
        /// Cached name for the 'framebuffer_create_empty' method.
        /// </summary>
        public static readonly StringName FramebufferCreateEmpty = "framebuffer_create_empty";
        /// <summary>
        /// Cached name for the 'framebuffer_get_format' method.
        /// </summary>
        public static readonly StringName FramebufferGetFormat = "framebuffer_get_format";
        /// <summary>
        /// Cached name for the 'framebuffer_is_valid' method.
        /// </summary>
        public static readonly StringName FramebufferIsValid = "framebuffer_is_valid";
        /// <summary>
        /// Cached name for the 'sampler_create' method.
        /// </summary>
        public static readonly StringName SamplerCreate = "sampler_create";
        /// <summary>
        /// Cached name for the 'sampler_is_format_supported_for_filter' method.
        /// </summary>
        public static readonly StringName SamplerIsFormatSupportedForFilter = "sampler_is_format_supported_for_filter";
        /// <summary>
        /// Cached name for the 'vertex_buffer_create' method.
        /// </summary>
        public static readonly StringName VertexBufferCreate = "vertex_buffer_create";
        /// <summary>
        /// Cached name for the 'vertex_format_create' method.
        /// </summary>
        public static readonly StringName VertexFormatCreate = "vertex_format_create";
        /// <summary>
        /// Cached name for the 'vertex_array_create' method.
        /// </summary>
        public static readonly StringName VertexArrayCreate = "vertex_array_create";
        /// <summary>
        /// Cached name for the 'index_buffer_create' method.
        /// </summary>
        public static readonly StringName IndexBufferCreate = "index_buffer_create";
        /// <summary>
        /// Cached name for the 'index_array_create' method.
        /// </summary>
        public static readonly StringName IndexArrayCreate = "index_array_create";
        /// <summary>
        /// Cached name for the 'shader_compile_spirv_from_source' method.
        /// </summary>
        public static readonly StringName ShaderCompileSpirVFromSource = "shader_compile_spirv_from_source";
        /// <summary>
        /// Cached name for the 'shader_compile_binary_from_spirv' method.
        /// </summary>
        public static readonly StringName ShaderCompileBinaryFromSpirV = "shader_compile_binary_from_spirv";
        /// <summary>
        /// Cached name for the 'shader_create_from_spirv' method.
        /// </summary>
        public static readonly StringName ShaderCreateFromSpirV = "shader_create_from_spirv";
        /// <summary>
        /// Cached name for the 'shader_create_from_bytecode' method.
        /// </summary>
        public static readonly StringName ShaderCreateFromBytecode = "shader_create_from_bytecode";
        /// <summary>
        /// Cached name for the 'shader_create_placeholder' method.
        /// </summary>
        public static readonly StringName ShaderCreatePlaceholder = "shader_create_placeholder";
        /// <summary>
        /// Cached name for the 'shader_get_vertex_input_attribute_mask' method.
        /// </summary>
        public static readonly StringName ShaderGetVertexInputAttributeMask = "shader_get_vertex_input_attribute_mask";
        /// <summary>
        /// Cached name for the 'uniform_buffer_create' method.
        /// </summary>
        public static readonly StringName UniformBufferCreate = "uniform_buffer_create";
        /// <summary>
        /// Cached name for the 'storage_buffer_create' method.
        /// </summary>
        public static readonly StringName StorageBufferCreate = "storage_buffer_create";
        /// <summary>
        /// Cached name for the 'texture_buffer_create' method.
        /// </summary>
        public static readonly StringName TextureBufferCreate = "texture_buffer_create";
        /// <summary>
        /// Cached name for the 'uniform_set_create' method.
        /// </summary>
        public static readonly StringName UniformSetCreate = "uniform_set_create";
        /// <summary>
        /// Cached name for the 'uniform_set_is_valid' method.
        /// </summary>
        public static readonly StringName UniformSetIsValid = "uniform_set_is_valid";
        /// <summary>
        /// Cached name for the 'buffer_copy' method.
        /// </summary>
        public static readonly StringName BufferCopy = "buffer_copy";
        /// <summary>
        /// Cached name for the 'buffer_update' method.
        /// </summary>
        public static readonly StringName BufferUpdate = "buffer_update";
        /// <summary>
        /// Cached name for the 'buffer_clear' method.
        /// </summary>
        public static readonly StringName BufferClear = "buffer_clear";
        /// <summary>
        /// Cached name for the 'buffer_get_data' method.
        /// </summary>
        public static readonly StringName BufferGetData = "buffer_get_data";
        /// <summary>
        /// Cached name for the 'render_pipeline_create' method.
        /// </summary>
        public static readonly StringName RenderPipelineCreate = "render_pipeline_create";
        /// <summary>
        /// Cached name for the 'render_pipeline_is_valid' method.
        /// </summary>
        public static readonly StringName RenderPipelineIsValid = "render_pipeline_is_valid";
        /// <summary>
        /// Cached name for the 'compute_pipeline_create' method.
        /// </summary>
        public static readonly StringName ComputePipelineCreate = "compute_pipeline_create";
        /// <summary>
        /// Cached name for the 'compute_pipeline_is_valid' method.
        /// </summary>
        public static readonly StringName ComputePipelineIsValid = "compute_pipeline_is_valid";
        /// <summary>
        /// Cached name for the 'screen_get_width' method.
        /// </summary>
        public static readonly StringName ScreenGetWidth = "screen_get_width";
        /// <summary>
        /// Cached name for the 'screen_get_height' method.
        /// </summary>
        public static readonly StringName ScreenGetHeight = "screen_get_height";
        /// <summary>
        /// Cached name for the 'screen_get_framebuffer_format' method.
        /// </summary>
        public static readonly StringName ScreenGetFramebufferFormat = "screen_get_framebuffer_format";
        /// <summary>
        /// Cached name for the 'draw_list_begin_for_screen' method.
        /// </summary>
        public static readonly StringName DrawListBeginForScreen = "draw_list_begin_for_screen";
        /// <summary>
        /// Cached name for the 'draw_list_begin' method.
        /// </summary>
        public static readonly StringName DrawListBegin = "draw_list_begin";
        /// <summary>
        /// Cached name for the 'draw_list_begin_split' method.
        /// </summary>
        public static readonly StringName DrawListBeginSplit = "draw_list_begin_split";
        /// <summary>
        /// Cached name for the 'draw_list_set_blend_constants' method.
        /// </summary>
        public static readonly StringName DrawListSetBlendConstants = "draw_list_set_blend_constants";
        /// <summary>
        /// Cached name for the 'draw_list_bind_render_pipeline' method.
        /// </summary>
        public static readonly StringName DrawListBindRenderPipeline = "draw_list_bind_render_pipeline";
        /// <summary>
        /// Cached name for the 'draw_list_bind_uniform_set' method.
        /// </summary>
        public static readonly StringName DrawListBindUniformSet = "draw_list_bind_uniform_set";
        /// <summary>
        /// Cached name for the 'draw_list_bind_vertex_array' method.
        /// </summary>
        public static readonly StringName DrawListBindVertexArray = "draw_list_bind_vertex_array";
        /// <summary>
        /// Cached name for the 'draw_list_bind_index_array' method.
        /// </summary>
        public static readonly StringName DrawListBindIndexArray = "draw_list_bind_index_array";
        /// <summary>
        /// Cached name for the 'draw_list_set_push_constant' method.
        /// </summary>
        public static readonly StringName DrawListSetPushConstant = "draw_list_set_push_constant";
        /// <summary>
        /// Cached name for the 'draw_list_draw' method.
        /// </summary>
        public static readonly StringName DrawListDraw = "draw_list_draw";
        /// <summary>
        /// Cached name for the 'draw_list_enable_scissor' method.
        /// </summary>
        public static readonly StringName DrawListEnableScissor = "draw_list_enable_scissor";
        /// <summary>
        /// Cached name for the 'draw_list_disable_scissor' method.
        /// </summary>
        public static readonly StringName DrawListDisableScissor = "draw_list_disable_scissor";
        /// <summary>
        /// Cached name for the 'draw_list_switch_to_next_pass' method.
        /// </summary>
        public static readonly StringName DrawListSwitchToNextPass = "draw_list_switch_to_next_pass";
        /// <summary>
        /// Cached name for the 'draw_list_switch_to_next_pass_split' method.
        /// </summary>
        public static readonly StringName DrawListSwitchToNextPassSplit = "draw_list_switch_to_next_pass_split";
        /// <summary>
        /// Cached name for the 'draw_list_end' method.
        /// </summary>
        public static readonly StringName DrawListEnd = "draw_list_end";
        /// <summary>
        /// Cached name for the 'compute_list_begin' method.
        /// </summary>
        public static readonly StringName ComputeListBegin = "compute_list_begin";
        /// <summary>
        /// Cached name for the 'compute_list_bind_compute_pipeline' method.
        /// </summary>
        public static readonly StringName ComputeListBindComputePipeline = "compute_list_bind_compute_pipeline";
        /// <summary>
        /// Cached name for the 'compute_list_set_push_constant' method.
        /// </summary>
        public static readonly StringName ComputeListSetPushConstant = "compute_list_set_push_constant";
        /// <summary>
        /// Cached name for the 'compute_list_bind_uniform_set' method.
        /// </summary>
        public static readonly StringName ComputeListBindUniformSet = "compute_list_bind_uniform_set";
        /// <summary>
        /// Cached name for the 'compute_list_dispatch' method.
        /// </summary>
        public static readonly StringName ComputeListDispatch = "compute_list_dispatch";
        /// <summary>
        /// Cached name for the 'compute_list_dispatch_indirect' method.
        /// </summary>
        public static readonly StringName ComputeListDispatchIndirect = "compute_list_dispatch_indirect";
        /// <summary>
        /// Cached name for the 'compute_list_add_barrier' method.
        /// </summary>
        public static readonly StringName ComputeListAddBarrier = "compute_list_add_barrier";
        /// <summary>
        /// Cached name for the 'compute_list_end' method.
        /// </summary>
        public static readonly StringName ComputeListEnd = "compute_list_end";
        /// <summary>
        /// Cached name for the 'free_rid' method.
        /// </summary>
        public static readonly StringName FreeRid = "free_rid";
        /// <summary>
        /// Cached name for the 'capture_timestamp' method.
        /// </summary>
        public static readonly StringName CaptureTimestamp = "capture_timestamp";
        /// <summary>
        /// Cached name for the 'get_captured_timestamps_count' method.
        /// </summary>
        public static readonly StringName GetCapturedTimestampsCount = "get_captured_timestamps_count";
        /// <summary>
        /// Cached name for the 'get_captured_timestamps_frame' method.
        /// </summary>
        public static readonly StringName GetCapturedTimestampsFrame = "get_captured_timestamps_frame";
        /// <summary>
        /// Cached name for the 'get_captured_timestamp_gpu_time' method.
        /// </summary>
        public static readonly StringName GetCapturedTimestampGpuTime = "get_captured_timestamp_gpu_time";
        /// <summary>
        /// Cached name for the 'get_captured_timestamp_cpu_time' method.
        /// </summary>
        public static readonly StringName GetCapturedTimestampCpuTime = "get_captured_timestamp_cpu_time";
        /// <summary>
        /// Cached name for the 'get_captured_timestamp_name' method.
        /// </summary>
        public static readonly StringName GetCapturedTimestampName = "get_captured_timestamp_name";
        /// <summary>
        /// Cached name for the 'limit_get' method.
        /// </summary>
        public static readonly StringName LimitGet = "limit_get";
        /// <summary>
        /// Cached name for the 'get_frame_delay' method.
        /// </summary>
        public static readonly StringName GetFrameDelay = "get_frame_delay";
        /// <summary>
        /// Cached name for the 'submit' method.
        /// </summary>
        public static readonly StringName Submit = "submit";
        /// <summary>
        /// Cached name for the 'sync' method.
        /// </summary>
        public static readonly StringName Sync = "sync";
        /// <summary>
        /// Cached name for the 'barrier' method.
        /// </summary>
        public static readonly StringName Barrier = "barrier";
        /// <summary>
        /// Cached name for the 'full_barrier' method.
        /// </summary>
        public static readonly StringName FullBarrier = "full_barrier";
        /// <summary>
        /// Cached name for the 'create_local_device' method.
        /// </summary>
        public static readonly StringName CreateLocalDevice = "create_local_device";
        /// <summary>
        /// Cached name for the 'set_resource_name' method.
        /// </summary>
        public static readonly StringName SetResourceName = "set_resource_name";
        /// <summary>
        /// Cached name for the 'draw_command_begin_label' method.
        /// </summary>
        public static readonly StringName DrawCommandBeginLabel = "draw_command_begin_label";
        /// <summary>
        /// Cached name for the 'draw_command_insert_label' method.
        /// </summary>
        public static readonly StringName DrawCommandInsertLabel = "draw_command_insert_label";
        /// <summary>
        /// Cached name for the 'draw_command_end_label' method.
        /// </summary>
        public static readonly StringName DrawCommandEndLabel = "draw_command_end_label";
        /// <summary>
        /// Cached name for the 'get_device_vendor_name' method.
        /// </summary>
        public static readonly StringName GetDeviceVendorName = "get_device_vendor_name";
        /// <summary>
        /// Cached name for the 'get_device_name' method.
        /// </summary>
        public static readonly StringName GetDeviceName = "get_device_name";
        /// <summary>
        /// Cached name for the 'get_device_pipeline_cache_uuid' method.
        /// </summary>
        public static readonly StringName GetDevicePipelineCacheUuid = "get_device_pipeline_cache_uuid";
        /// <summary>
        /// Cached name for the 'get_memory_usage' method.
        /// </summary>
        public static readonly StringName GetMemoryUsage = "get_memory_usage";
        /// <summary>
        /// Cached name for the 'get_driver_resource' method.
        /// </summary>
        public static readonly StringName GetDriverResource = "get_driver_resource";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : GodotObject.SignalName
    {
    }
}

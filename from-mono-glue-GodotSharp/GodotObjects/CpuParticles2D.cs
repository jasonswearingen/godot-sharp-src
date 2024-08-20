namespace Godot;

using System;
using System.ComponentModel;
using System.Diagnostics;
using Godot.NativeInterop;

#nullable disable
/// <summary>
/// <para>CPU-based 2D particle node used to create a variety of particle systems and effects.</para>
/// <para>See also <see cref="Godot.GpuParticles2D"/>, which provides the same functionality with hardware acceleration, but may not run on older devices.</para>
/// </summary>
[GodotClassName("CPUParticles2D")]
public partial class CpuParticles2D : Node2D
{
    public enum DrawOrderEnum : long
    {
        /// <summary>
        /// <para>Particles are drawn in the order emitted.</para>
        /// </summary>
        Index = 0,
        /// <summary>
        /// <para>Particles are drawn in order of remaining lifetime. In other words, the particle with the highest lifetime is drawn at the front.</para>
        /// </summary>
        Lifetime = 1
    }

    public enum Parameter : long
    {
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set initial velocity properties.</para>
        /// </summary>
        InitialLinearVelocity = 0,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set angular velocity properties.</para>
        /// </summary>
        AngularVelocity = 1,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set orbital velocity properties.</para>
        /// </summary>
        OrbitVelocity = 2,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set linear acceleration properties.</para>
        /// </summary>
        LinearAccel = 3,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set radial acceleration properties.</para>
        /// </summary>
        RadialAccel = 4,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set tangential acceleration properties.</para>
        /// </summary>
        TangentialAccel = 5,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set damping properties.</para>
        /// </summary>
        Damping = 6,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set angle properties.</para>
        /// </summary>
        Angle = 7,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set scale properties.</para>
        /// </summary>
        Scale = 8,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set hue variation properties.</para>
        /// </summary>
        HueVariation = 9,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set animation speed properties.</para>
        /// </summary>
        AnimSpeed = 10,
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)"/>, <see cref="Godot.CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)"/>, and <see cref="Godot.CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)"/> to set animation offset properties.</para>
        /// </summary>
        AnimOffset = 11,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.CpuParticles2D.Parameter"/> enum.</para>
        /// </summary>
        Max = 12
    }

    public enum ParticleFlags : long
    {
        /// <summary>
        /// <para>Use with <see cref="Godot.CpuParticles2D.SetParticleFlag(CpuParticles2D.ParticleFlags, bool)"/> to set <see cref="Godot.CpuParticles2D.ParticleFlagAlignY"/>.</para>
        /// </summary>
        AlignYToVelocity = 0,
        /// <summary>
        /// <para>Present for consistency with 3D particle nodes, not used in 2D.</para>
        /// </summary>
        RotateY = 1,
        /// <summary>
        /// <para>Present for consistency with 3D particle nodes, not used in 2D.</para>
        /// </summary>
        DisableZ = 2,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.CpuParticles2D.ParticleFlags"/> enum.</para>
        /// </summary>
        Max = 3
    }

    public enum EmissionShapeEnum : long
    {
        /// <summary>
        /// <para>All particles will be emitted from a single point.</para>
        /// </summary>
        Point = 0,
        /// <summary>
        /// <para>Particles will be emitted in the volume of a sphere flattened to two dimensions.</para>
        /// </summary>
        Sphere = 1,
        /// <summary>
        /// <para>Particles will be emitted on the surface of a sphere flattened to two dimensions.</para>
        /// </summary>
        SphereSurface = 2,
        /// <summary>
        /// <para>Particles will be emitted in the area of a rectangle.</para>
        /// </summary>
        Rectangle = 3,
        /// <summary>
        /// <para>Particles will be emitted at a position chosen randomly among <see cref="Godot.CpuParticles2D.EmissionPoints"/>. Particle color will be modulated by <see cref="Godot.CpuParticles2D.EmissionColors"/>.</para>
        /// </summary>
        Points = 4,
        /// <summary>
        /// <para>Particles will be emitted at a position chosen randomly among <see cref="Godot.CpuParticles2D.EmissionPoints"/>. Particle velocity and rotation will be set based on <see cref="Godot.CpuParticles2D.EmissionNormals"/>. Particle color will be modulated by <see cref="Godot.CpuParticles2D.EmissionColors"/>.</para>
        /// </summary>
        DirectedPoints = 5,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.CpuParticles2D.EmissionShapeEnum"/> enum.</para>
        /// </summary>
        Max = 6
    }

    /// <summary>
    /// <para>If <see langword="true"/>, particles are being emitted. <see cref="Godot.CpuParticles2D.Emitting"/> can be used to start and stop particles from emitting. However, if <see cref="Godot.CpuParticles2D.OneShot"/> is <see langword="true"/> setting <see cref="Godot.CpuParticles2D.Emitting"/> to <see langword="true"/> will not restart the emission cycle until after all active particles finish processing. You can use the <see cref="Godot.CpuParticles2D.Finished"/> signal to be notified once all active particles finish processing.</para>
    /// </summary>
    public bool Emitting
    {
        get
        {
            return IsEmitting();
        }
        set
        {
            SetEmitting(value);
        }
    }

    /// <summary>
    /// <para>Number of particles emitted in one emission cycle.</para>
    /// </summary>
    public int Amount
    {
        get
        {
            return GetAmount();
        }
        set
        {
            SetAmount(value);
        }
    }

    /// <summary>
    /// <para>Amount of time each particle will exist.</para>
    /// </summary>
    public double Lifetime
    {
        get
        {
            return GetLifetime();
        }
        set
        {
            SetLifetime(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, only one emission cycle occurs. If set <see langword="true"/> during a cycle, emission will stop at the cycle's end.</para>
    /// </summary>
    public bool OneShot
    {
        get
        {
            return GetOneShot();
        }
        set
        {
            SetOneShot(value);
        }
    }

    /// <summary>
    /// <para>Particle system starts as if it had already run for this many seconds.</para>
    /// </summary>
    public double Preprocess
    {
        get
        {
            return GetPreProcessTime();
        }
        set
        {
            SetPreProcessTime(value);
        }
    }

    /// <summary>
    /// <para>Particle system's running speed scaling ratio. A value of <c>0</c> can be used to pause the particles.</para>
    /// </summary>
    public double SpeedScale
    {
        get
        {
            return GetSpeedScale();
        }
        set
        {
            SetSpeedScale(value);
        }
    }

    /// <summary>
    /// <para>How rapidly particles in an emission cycle are emitted. If greater than <c>0</c>, there will be a gap in emissions before the next cycle begins.</para>
    /// </summary>
    public float Explosiveness
    {
        get
        {
            return GetExplosivenessRatio();
        }
        set
        {
            SetExplosivenessRatio(value);
        }
    }

    /// <summary>
    /// <para>Emission lifetime randomness ratio.</para>
    /// </summary>
    public float Randomness
    {
        get
        {
            return GetRandomnessRatio();
        }
        set
        {
            SetRandomnessRatio(value);
        }
    }

    /// <summary>
    /// <para>Particle lifetime randomness ratio.</para>
    /// </summary>
    public double LifetimeRandomness
    {
        get
        {
            return GetLifetimeRandomness();
        }
        set
        {
            SetLifetimeRandomness(value);
        }
    }

    /// <summary>
    /// <para>The particle system's frame rate is fixed to a value. For example, changing the value to 2 will make the particles render at 2 frames per second. Note this does not slow down the simulation of the particle system itself.</para>
    /// </summary>
    public int FixedFps
    {
        get
        {
            return GetFixedFps();
        }
        set
        {
            SetFixedFps(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, results in fractional delta calculation which has a smoother particles display effect.</para>
    /// </summary>
    public bool FractDelta
    {
        get
        {
            return GetFractionalDelta();
        }
        set
        {
            SetFractionalDelta(value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, particles use the parent node's coordinate space (known as local coordinates). This will cause particles to move and rotate along the <see cref="Godot.CpuParticles2D"/> node (and its parents) when it is moved or rotated. If <see langword="false"/>, particles use global coordinates; they will not move or rotate along the <see cref="Godot.CpuParticles2D"/> node (and its parents) when it is moved or rotated.</para>
    /// </summary>
    public bool LocalCoords
    {
        get
        {
            return GetUseLocalCoordinates();
        }
        set
        {
            SetUseLocalCoordinates(value);
        }
    }

    /// <summary>
    /// <para>Particle draw order. Uses <see cref="Godot.CpuParticles2D.DrawOrderEnum"/> values.</para>
    /// </summary>
    public CpuParticles2D.DrawOrderEnum DrawOrder
    {
        get
        {
            return GetDrawOrder();
        }
        set
        {
            SetDrawOrder(value);
        }
    }

    /// <summary>
    /// <para>Particle texture. If <see langword="null"/>, particles will be squares.</para>
    /// </summary>
    public Texture2D Texture
    {
        get
        {
            return GetTexture();
        }
        set
        {
            SetTexture(value);
        }
    }

    /// <summary>
    /// <para>Particles will be emitted inside this region. See <see cref="Godot.CpuParticles2D.EmissionShapeEnum"/> for possible values.</para>
    /// </summary>
    public CpuParticles2D.EmissionShapeEnum EmissionShape
    {
        get
        {
            return GetEmissionShape();
        }
        set
        {
            SetEmissionShape(value);
        }
    }

    /// <summary>
    /// <para>The sphere's radius if <see cref="Godot.CpuParticles2D.EmissionShape"/> is set to <see cref="Godot.CpuParticles2D.EmissionShapeEnum.Sphere"/>.</para>
    /// </summary>
    public float EmissionSphereRadius
    {
        get
        {
            return GetEmissionSphereRadius();
        }
        set
        {
            SetEmissionSphereRadius(value);
        }
    }

    /// <summary>
    /// <para>The rectangle's extents if <see cref="Godot.CpuParticles2D.EmissionShape"/> is set to <see cref="Godot.CpuParticles2D.EmissionShapeEnum.Rectangle"/>.</para>
    /// </summary>
    public Vector2 EmissionRectExtents
    {
        get
        {
            return GetEmissionRectExtents();
        }
        set
        {
            SetEmissionRectExtents(value);
        }
    }

    /// <summary>
    /// <para>Sets the initial positions to spawn particles when using <see cref="Godot.CpuParticles2D.EmissionShapeEnum.Points"/> or <see cref="Godot.CpuParticles2D.EmissionShapeEnum.DirectedPoints"/>.</para>
    /// </summary>
    public Vector2[] EmissionPoints
    {
        get
        {
            return GetEmissionPoints();
        }
        set
        {
            SetEmissionPoints(value);
        }
    }

    /// <summary>
    /// <para>Sets the direction the particles will be emitted in when using <see cref="Godot.CpuParticles2D.EmissionShapeEnum.DirectedPoints"/>.</para>
    /// </summary>
    public Vector2[] EmissionNormals
    {
        get
        {
            return GetEmissionNormals();
        }
        set
        {
            SetEmissionNormals(value);
        }
    }

    /// <summary>
    /// <para>Sets the <see cref="Godot.Color"/>s to modulate particles by when using <see cref="Godot.CpuParticles2D.EmissionShapeEnum.Points"/> or <see cref="Godot.CpuParticles2D.EmissionShapeEnum.DirectedPoints"/>.</para>
    /// </summary>
    public Color[] EmissionColors
    {
        get
        {
            return GetEmissionColors();
        }
        set
        {
            SetEmissionColors(value);
        }
    }

    /// <summary>
    /// <para>Align Y axis of particle with the direction of its velocity.</para>
    /// </summary>
    public bool ParticleFlagAlignY
    {
        get
        {
            return GetParticleFlag((CpuParticles2D.ParticleFlags)(0));
        }
        set
        {
            SetParticleFlag((CpuParticles2D.ParticleFlags)(0), value);
        }
    }

    /// <summary>
    /// <para>Unit vector specifying the particles' emission direction.</para>
    /// </summary>
    public Vector2 Direction
    {
        get
        {
            return GetDirection();
        }
        set
        {
            SetDirection(value);
        }
    }

    /// <summary>
    /// <para>Each particle's initial direction range from <c>+spread</c> to <c>-spread</c> degrees.</para>
    /// </summary>
    public float Spread
    {
        get
        {
            return GetSpread();
        }
        set
        {
            SetSpread(value);
        }
    }

    /// <summary>
    /// <para>Gravity applied to every particle.</para>
    /// </summary>
    public Vector2 Gravity
    {
        get
        {
            return GetGravity();
        }
        set
        {
            SetGravity(value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.InitialVelocityMax"/>.</para>
    /// </summary>
    public float InitialVelocityMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(0));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(0), value);
        }
    }

    /// <summary>
    /// <para>Maximum initial velocity magnitude for each particle. Direction comes from <see cref="Godot.CpuParticles2D.Direction"/> and <see cref="Godot.CpuParticles2D.Spread"/>.</para>
    /// </summary>
    public float InitialVelocityMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(0));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(0), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.AngularVelocityMax"/>.</para>
    /// </summary>
    public float AngularVelocityMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(1));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(1), value);
        }
    }

    /// <summary>
    /// <para>Maximum initial angular velocity (rotation speed) applied to each particle in <i>degrees</i> per second.</para>
    /// </summary>
    public float AngularVelocityMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(1));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(1), value);
        }
    }

    /// <summary>
    /// <para>Each particle's angular velocity will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve AngularVelocityCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(1));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(1), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.OrbitVelocityMax"/>.</para>
    /// </summary>
    public float OrbitVelocityMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(2));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(2), value);
        }
    }

    /// <summary>
    /// <para>Maximum orbital velocity applied to each particle. Makes the particles circle around origin. Specified in number of full rotations around origin per second.</para>
    /// </summary>
    public float OrbitVelocityMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(2));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(2), value);
        }
    }

    /// <summary>
    /// <para>Each particle's orbital velocity will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve OrbitVelocityCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(2));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(2), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.LinearAccelMax"/>.</para>
    /// </summary>
    public float LinearAccelMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(3));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(3), value);
        }
    }

    /// <summary>
    /// <para>Maximum linear acceleration applied to each particle in the direction of motion.</para>
    /// </summary>
    public float LinearAccelMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(3));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(3), value);
        }
    }

    /// <summary>
    /// <para>Each particle's linear acceleration will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve LinearAccelCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(3));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(3), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.RadialAccelMax"/>.</para>
    /// </summary>
    public float RadialAccelMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(4));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(4), value);
        }
    }

    /// <summary>
    /// <para>Maximum radial acceleration applied to each particle. Makes particle accelerate away from the origin or towards it if negative.</para>
    /// </summary>
    public float RadialAccelMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(4));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(4), value);
        }
    }

    /// <summary>
    /// <para>Each particle's radial acceleration will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve RadialAccelCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(4));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(4), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.TangentialAccelMax"/>.</para>
    /// </summary>
    public float TangentialAccelMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(5));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(5), value);
        }
    }

    /// <summary>
    /// <para>Maximum tangential acceleration applied to each particle. Tangential acceleration is perpendicular to the particle's velocity giving the particles a swirling motion.</para>
    /// </summary>
    public float TangentialAccelMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(5));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(5), value);
        }
    }

    /// <summary>
    /// <para>Each particle's tangential acceleration will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve TangentialAccelCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(5));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(5), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.DampingMax"/>.</para>
    /// </summary>
    public float DampingMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(6));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(6), value);
        }
    }

    /// <summary>
    /// <para>The maximum rate at which particles lose velocity. For example value of <c>100</c> means that the particle will go from <c>100</c> velocity to <c>0</c> in <c>1</c> second.</para>
    /// </summary>
    public float DampingMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(6));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(6), value);
        }
    }

    /// <summary>
    /// <para>Damping will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve DampingCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(6));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(6), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.AngleMax"/>.</para>
    /// </summary>
    public float AngleMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(7));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(7), value);
        }
    }

    /// <summary>
    /// <para>Maximum initial rotation applied to each particle, in degrees.</para>
    /// </summary>
    public float AngleMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(7));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(7), value);
        }
    }

    /// <summary>
    /// <para>Each particle's rotation will be animated along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve AngleCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(7));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(7), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.ScaleAmountMax"/>.</para>
    /// </summary>
    public float ScaleAmountMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(8));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(8), value);
        }
    }

    /// <summary>
    /// <para>Maximum initial scale applied to each particle.</para>
    /// </summary>
    public float ScaleAmountMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(8));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(8), value);
        }
    }

    /// <summary>
    /// <para>Each particle's scale will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve ScaleAmountCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(8));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(8), value);
        }
    }

    /// <summary>
    /// <para>If <see langword="true"/>, the scale curve will be split into x and y components. See <see cref="Godot.CpuParticles2D.ScaleCurveX"/> and <see cref="Godot.CpuParticles2D.ScaleCurveY"/>.</para>
    /// </summary>
    public bool SplitScale
    {
        get
        {
            return GetSplitScale();
        }
        set
        {
            SetSplitScale(value);
        }
    }

    /// <summary>
    /// <para>Each particle's horizontal scale will vary along this <see cref="Godot.Curve"/>.</para>
    /// <para><see cref="Godot.CpuParticles2D.SplitScale"/> must be enabled.</para>
    /// </summary>
    public Curve ScaleCurveX
    {
        get
        {
            return GetScaleCurveX();
        }
        set
        {
            SetScaleCurveX(value);
        }
    }

    /// <summary>
    /// <para>Each particle's vertical scale will vary along this <see cref="Godot.Curve"/>.</para>
    /// <para><see cref="Godot.CpuParticles2D.SplitScale"/> must be enabled.</para>
    /// </summary>
    public Curve ScaleCurveY
    {
        get
        {
            return GetScaleCurveY();
        }
        set
        {
            SetScaleCurveY(value);
        }
    }

    /// <summary>
    /// <para>Each particle's initial color. If <see cref="Godot.CpuParticles2D.Texture"/> is defined, it will be multiplied by this color.</para>
    /// </summary>
    public Color Color
    {
        get
        {
            return GetColor();
        }
        set
        {
            SetColor(value);
        }
    }

    /// <summary>
    /// <para>Each particle's color will vary along this <see cref="Godot.Gradient"/> (multiplied with <see cref="Godot.CpuParticles2D.Color"/>).</para>
    /// </summary>
    public Gradient ColorRamp
    {
        get
        {
            return GetColorRamp();
        }
        set
        {
            SetColorRamp(value);
        }
    }

    /// <summary>
    /// <para>Each particle's initial color will vary along this <see cref="Godot.GradientTexture1D"/> (multiplied with <see cref="Godot.CpuParticles2D.Color"/>).</para>
    /// </summary>
    public Gradient ColorInitialRamp
    {
        get
        {
            return GetColorInitialRamp();
        }
        set
        {
            SetColorInitialRamp(value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.HueVariationMax"/>.</para>
    /// </summary>
    public float HueVariationMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(9));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(9), value);
        }
    }

    /// <summary>
    /// <para>Maximum initial hue variation applied to each particle. It will shift the particle color's hue.</para>
    /// </summary>
    public float HueVariationMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(9));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(9), value);
        }
    }

    /// <summary>
    /// <para>Each particle's hue will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve HueVariationCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(9));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(9), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.AnimSpeedMax"/>.</para>
    /// </summary>
    public float AnimSpeedMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(10));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(10), value);
        }
    }

    /// <summary>
    /// <para>Maximum particle animation speed. Animation speed of <c>1</c> means that the particles will make full <c>0</c> to <c>1</c> offset cycle during lifetime, <c>2</c> means <c>2</c> cycles etc.</para>
    /// <para>With animation speed greater than <c>1</c>, remember to enable <see cref="Godot.CanvasItemMaterial.ParticlesAnimLoop"/> property if you want the animation to repeat.</para>
    /// </summary>
    public float AnimSpeedMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(10));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(10), value);
        }
    }

    /// <summary>
    /// <para>Each particle's animation speed will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve AnimSpeedCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(10));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(10), value);
        }
    }

    /// <summary>
    /// <para>Minimum equivalent of <see cref="Godot.CpuParticles2D.AnimOffsetMax"/>.</para>
    /// </summary>
    public float AnimOffsetMin
    {
        get
        {
            return GetParamMin((CpuParticles2D.Parameter)(11));
        }
        set
        {
            SetParamMin((CpuParticles2D.Parameter)(11), value);
        }
    }

    /// <summary>
    /// <para>Maximum animation offset that corresponds to frame index in the texture. <c>0</c> is the first frame, <c>1</c> is the last one. See <see cref="Godot.CanvasItemMaterial.ParticlesAnimation"/>.</para>
    /// </summary>
    public float AnimOffsetMax
    {
        get
        {
            return GetParamMax((CpuParticles2D.Parameter)(11));
        }
        set
        {
            SetParamMax((CpuParticles2D.Parameter)(11), value);
        }
    }

    /// <summary>
    /// <para>Each particle's animation offset will vary along this <see cref="Godot.Curve"/>.</para>
    /// </summary>
    public Curve AnimOffsetCurve
    {
        get
        {
            return GetParamCurve((CpuParticles2D.Parameter)(11));
        }
        set
        {
            SetParamCurve((CpuParticles2D.Parameter)(11), value);
        }
    }

    private static readonly System.Type CachedType = typeof(CpuParticles2D);

    private static readonly StringName NativeName = "CPUParticles2D";

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly unsafe delegate* unmanaged<IntPtr> NativeCtor = ClassDB_get_constructor(NativeName);

    public CpuParticles2D() : this(false)
    {
        unsafe
        {
            ConstructAndInitialize(NativeCtor, NativeName, CachedType, refCounted: false);
        }
    }

    internal CpuParticles2D(bool memoryOwn) : base(memoryOwn) { }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind0 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmitting, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmitting(bool emitting)
    {
        NativeCalls.godot_icall_1_41(MethodBind0, GodotObject.GetPtr(this), emitting.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind1 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetAmount, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetAmount(int amount)
    {
        NativeCalls.godot_icall_1_36(MethodBind1, GodotObject.GetPtr(this), amount);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind2 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLifetime, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetLifetime(double secs)
    {
        NativeCalls.godot_icall_1_120(MethodBind2, GodotObject.GetPtr(this), secs);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind3 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetOneShot, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetOneShot(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind3, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind4 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetPreProcessTime, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetPreProcessTime(double secs)
    {
        NativeCalls.godot_icall_1_120(MethodBind4, GodotObject.GetPtr(this), secs);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind5 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetExplosivenessRatio, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetExplosivenessRatio(float ratio)
    {
        NativeCalls.godot_icall_1_62(MethodBind5, GodotObject.GetPtr(this), ratio);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind6 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetRandomnessRatio, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetRandomnessRatio(float ratio)
    {
        NativeCalls.godot_icall_1_62(MethodBind6, GodotObject.GetPtr(this), ratio);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind7 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetLifetimeRandomness, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetLifetimeRandomness(double random)
    {
        NativeCalls.godot_icall_1_120(MethodBind7, GodotObject.GetPtr(this), random);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind8 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetUseLocalCoordinates, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetUseLocalCoordinates(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind8, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind9 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFixedFps, 1286410249ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFixedFps(int fps)
    {
        NativeCalls.godot_icall_1_36(MethodBind9, GodotObject.GetPtr(this), fps);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind10 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetFractionalDelta, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetFractionalDelta(bool enable)
    {
        NativeCalls.godot_icall_1_41(MethodBind10, GodotObject.GetPtr(this), enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind11 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSpeedScale, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSpeedScale(double scale)
    {
        NativeCalls.godot_icall_1_120(MethodBind11, GodotObject.GetPtr(this), scale);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind12 = ClassDB_get_method_with_compatibility(NativeName, MethodName.IsEmitting, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsEmitting()
    {
        return NativeCalls.godot_icall_0_40(MethodBind12, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind13 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetAmount, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetAmount()
    {
        return NativeCalls.godot_icall_0_37(MethodBind13, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind14 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLifetime, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public double GetLifetime()
    {
        return NativeCalls.godot_icall_0_136(MethodBind14, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind15 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetOneShot, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetOneShot()
    {
        return NativeCalls.godot_icall_0_40(MethodBind15, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind16 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetPreProcessTime, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public double GetPreProcessTime()
    {
        return NativeCalls.godot_icall_0_136(MethodBind16, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind17 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetExplosivenessRatio, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetExplosivenessRatio()
    {
        return NativeCalls.godot_icall_0_63(MethodBind17, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind18 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetRandomnessRatio, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetRandomnessRatio()
    {
        return NativeCalls.godot_icall_0_63(MethodBind18, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind19 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetLifetimeRandomness, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public double GetLifetimeRandomness()
    {
        return NativeCalls.godot_icall_0_136(MethodBind19, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind20 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetUseLocalCoordinates, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetUseLocalCoordinates()
    {
        return NativeCalls.godot_icall_0_40(MethodBind20, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind21 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFixedFps, 3905245786ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int GetFixedFps()
    {
        return NativeCalls.godot_icall_0_37(MethodBind21, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind22 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetFractionalDelta, 36873697ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetFractionalDelta()
    {
        return NativeCalls.godot_icall_0_40(MethodBind22, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind23 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSpeedScale, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public double GetSpeedScale()
    {
        return NativeCalls.godot_icall_0_136(MethodBind23, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind24 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDrawOrder, 4183193490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetDrawOrder(CpuParticles2D.DrawOrderEnum order)
    {
        NativeCalls.godot_icall_1_36(MethodBind24, GodotObject.GetPtr(this), (int)order);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind25 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDrawOrder, 1668655735ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public CpuParticles2D.DrawOrderEnum GetDrawOrder()
    {
        return (CpuParticles2D.DrawOrderEnum)NativeCalls.godot_icall_0_37(MethodBind25, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind26 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetTexture, 4051416890ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetTexture(Texture2D texture)
    {
        NativeCalls.godot_icall_1_55(MethodBind26, GodotObject.GetPtr(this), GodotObject.GetPtr(texture));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind27 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetTexture, 3635182373ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Texture2D GetTexture()
    {
        return (Texture2D)NativeCalls.godot_icall_0_58(MethodBind27, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind28 = ClassDB_get_method_with_compatibility(NativeName, MethodName.Restart, 3218959716ul);

    /// <summary>
    /// <para>Restarts the particle emitter.</para>
    /// </summary>
    public void Restart()
    {
        NativeCalls.godot_icall_0_3(MethodBind28, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind29 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetDirection, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetDirection(Vector2 direction)
    {
        NativeCalls.godot_icall_1_34(MethodBind29, GodotObject.GetPtr(this), &direction);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind30 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetDirection, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetDirection()
    {
        return NativeCalls.godot_icall_0_35(MethodBind30, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind31 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSpread, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSpread(float spread)
    {
        NativeCalls.godot_icall_1_62(MethodBind31, GodotObject.GetPtr(this), spread);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind32 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSpread, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetSpread()
    {
        return NativeCalls.godot_icall_0_63(MethodBind32, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind33 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetParamMin, 3320615296ul);

    /// <summary>
    /// <para>Sets the minimum value for the given parameter.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetParamMin(CpuParticles2D.Parameter param, float value)
    {
        NativeCalls.godot_icall_2_64(MethodBind33, GodotObject.GetPtr(this), (int)param, value);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind34 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetParamMin, 2038050600ul);

    /// <summary>
    /// <para>Returns the minimum value range for the given parameter.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetParamMin(CpuParticles2D.Parameter param)
    {
        return NativeCalls.godot_icall_1_67(MethodBind34, GodotObject.GetPtr(this), (int)param);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind35 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetParamMax, 3320615296ul);

    /// <summary>
    /// <para>Sets the maximum value for the given parameter.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetParamMax(CpuParticles2D.Parameter param, float value)
    {
        NativeCalls.godot_icall_2_64(MethodBind35, GodotObject.GetPtr(this), (int)param, value);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind36 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetParamMax, 2038050600ul);

    /// <summary>
    /// <para>Returns the maximum value range for the given parameter.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetParamMax(CpuParticles2D.Parameter param)
    {
        return NativeCalls.godot_icall_1_67(MethodBind36, GodotObject.GetPtr(this), (int)param);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind37 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetParamCurve, 2959350143ul);

    /// <summary>
    /// <para>Sets the <see cref="Godot.Curve"/> of the parameter specified by <see cref="Godot.CpuParticles2D.Parameter"/>.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetParamCurve(CpuParticles2D.Parameter param, Curve curve)
    {
        NativeCalls.godot_icall_2_65(MethodBind37, GodotObject.GetPtr(this), (int)param, GodotObject.GetPtr(curve));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind38 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetParamCurve, 2603158474ul);

    /// <summary>
    /// <para>Returns the <see cref="Godot.Curve"/> of the parameter specified by <see cref="Godot.CpuParticles2D.Parameter"/>.</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Curve GetParamCurve(CpuParticles2D.Parameter param)
    {
        return (Curve)NativeCalls.godot_icall_1_66(MethodBind38, GodotObject.GetPtr(this), (int)param);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind39 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetColor, 2920490490ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetColor(Color color)
    {
        NativeCalls.godot_icall_1_195(MethodBind39, GodotObject.GetPtr(this), &color);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind40 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetColor, 3444240500ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color GetColor()
    {
        return NativeCalls.godot_icall_0_196(MethodBind40, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind41 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetColorRamp, 2756054477ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetColorRamp(Gradient ramp)
    {
        NativeCalls.godot_icall_1_55(MethodBind41, GodotObject.GetPtr(this), GodotObject.GetPtr(ramp));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind42 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetColorRamp, 132272999ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Gradient GetColorRamp()
    {
        return (Gradient)NativeCalls.godot_icall_0_58(MethodBind42, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind43 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetColorInitialRamp, 2756054477ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetColorInitialRamp(Gradient ramp)
    {
        NativeCalls.godot_icall_1_55(MethodBind43, GodotObject.GetPtr(this), GodotObject.GetPtr(ramp));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind44 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetColorInitialRamp, 132272999ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Gradient GetColorInitialRamp()
    {
        return (Gradient)NativeCalls.godot_icall_0_58(MethodBind44, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind45 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetParticleFlag, 4178137949ul);

    /// <summary>
    /// <para>Enables or disables the given flag (see <see cref="Godot.CpuParticles2D.ParticleFlags"/> for options).</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetParticleFlag(CpuParticles2D.ParticleFlags particleFlag, bool enable)
    {
        NativeCalls.godot_icall_2_74(MethodBind45, GodotObject.GetPtr(this), (int)particleFlag, enable.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind46 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetParticleFlag, 2829976507ul);

    /// <summary>
    /// <para>Returns the enabled state of the given flag (see <see cref="Godot.CpuParticles2D.ParticleFlags"/> for options).</para>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetParticleFlag(CpuParticles2D.ParticleFlags particleFlag)
    {
        return NativeCalls.godot_icall_1_75(MethodBind46, GodotObject.GetPtr(this), (int)particleFlag).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind47 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionShape, 393763892ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmissionShape(CpuParticles2D.EmissionShapeEnum shape)
    {
        NativeCalls.godot_icall_1_36(MethodBind47, GodotObject.GetPtr(this), (int)shape);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind48 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionShape, 1740246024ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public CpuParticles2D.EmissionShapeEnum GetEmissionShape()
    {
        return (CpuParticles2D.EmissionShapeEnum)NativeCalls.godot_icall_0_37(MethodBind48, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind49 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionSphereRadius, 373806689ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmissionSphereRadius(float radius)
    {
        NativeCalls.godot_icall_1_62(MethodBind49, GodotObject.GetPtr(this), radius);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind50 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionSphereRadius, 1740695150ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetEmissionSphereRadius()
    {
        return NativeCalls.godot_icall_0_63(MethodBind50, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind51 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionRectExtents, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetEmissionRectExtents(Vector2 extents)
    {
        NativeCalls.godot_icall_1_34(MethodBind51, GodotObject.GetPtr(this), &extents);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind52 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionRectExtents, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetEmissionRectExtents()
    {
        return NativeCalls.godot_icall_0_35(MethodBind52, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind53 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionPoints, 1509147220ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmissionPoints(Vector2[] array)
    {
        NativeCalls.godot_icall_1_203(MethodBind53, GodotObject.GetPtr(this), array);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind54 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionPoints, 2961356807ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2[] GetEmissionPoints()
    {
        return NativeCalls.godot_icall_0_204(MethodBind54, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind55 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionNormals, 1509147220ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmissionNormals(Vector2[] array)
    {
        NativeCalls.godot_icall_1_203(MethodBind55, GodotObject.GetPtr(this), array);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind56 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionNormals, 2961356807ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2[] GetEmissionNormals()
    {
        return NativeCalls.godot_icall_0_204(MethodBind56, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind57 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetEmissionColors, 3546319833ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetEmissionColors(Color[] array)
    {
        NativeCalls.godot_icall_1_205(MethodBind57, GodotObject.GetPtr(this), array);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind58 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetEmissionColors, 1392750486ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Color[] GetEmissionColors()
    {
        return NativeCalls.godot_icall_0_206(MethodBind58, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind59 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetGravity, 3341600327ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Vector2 GetGravity()
    {
        return NativeCalls.godot_icall_0_35(MethodBind59, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind60 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetGravity, 743155724ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe void SetGravity(Vector2 accelVec)
    {
        NativeCalls.godot_icall_1_34(MethodBind60, GodotObject.GetPtr(this), &accelVec);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind61 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetSplitScale, 2240911060ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool GetSplitScale()
    {
        return NativeCalls.godot_icall_0_40(MethodBind61, GodotObject.GetPtr(this)).ToBool();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind62 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetSplitScale, 2586408642ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetSplitScale(bool splitScale)
    {
        NativeCalls.godot_icall_1_41(MethodBind62, GodotObject.GetPtr(this), splitScale.ToGodotBool());
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind63 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetScaleCurveX, 2460114913ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Curve GetScaleCurveX()
    {
        return (Curve)NativeCalls.godot_icall_0_58(MethodBind63, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind64 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetScaleCurveX, 270443179ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetScaleCurveX(Curve scaleCurve)
    {
        NativeCalls.godot_icall_1_55(MethodBind64, GodotObject.GetPtr(this), GodotObject.GetPtr(scaleCurve));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind65 = ClassDB_get_method_with_compatibility(NativeName, MethodName.GetScaleCurveY, 2460114913ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Curve GetScaleCurveY()
    {
        return (Curve)NativeCalls.godot_icall_0_58(MethodBind65, GodotObject.GetPtr(this));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind66 = ClassDB_get_method_with_compatibility(NativeName, MethodName.SetScaleCurveY, 270443179ul);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetScaleCurveY(Curve scaleCurve)
    {
        NativeCalls.godot_icall_1_55(MethodBind66, GodotObject.GetPtr(this), GodotObject.GetPtr(scaleCurve));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly IntPtr MethodBind67 = ClassDB_get_method_with_compatibility(NativeName, MethodName.ConvertFromParticles, 1078189570ul);

    /// <summary>
    /// <para>Sets this node's properties to match a given <see cref="Godot.GpuParticles2D"/> node with an assigned <see cref="Godot.ParticleProcessMaterial"/>.</para>
    /// </summary>
    public void ConvertFromParticles(Node particles)
    {
        NativeCalls.godot_icall_1_55(MethodBind67, GodotObject.GetPtr(this), GodotObject.GetPtr(particles));
    }

    /// <summary>
    /// <para>Emitted when all active particles have finished processing. When <see cref="Godot.CpuParticles2D.OneShot"/> is disabled, particles will process continuously, so this is never emitted.</para>
    /// </summary>
    public event Action Finished
    {
        add => Connect(SignalName.Finished, Callable.From(value));
        remove => Disconnect(SignalName.Finished, Callable.From(value));
    }

    // ReSharper disable once InconsistentNaming
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static readonly StringName SignalProxyName_finished = "Finished";

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
        if (signal == SignalName.Finished)
        {
            if (HasGodotClassSignal(SignalProxyName_finished.NativeValue.DangerousSelfRef))
            {
                return true;
            }
        }
        return base.HasGodotClassSignal(signal);
    }

    /// <summary>
    /// Cached StringNames for the properties and fields contained in this class, for fast lookup.
    /// </summary>
    public new class PropertyName : Node2D.PropertyName
    {
        /// <summary>
        /// Cached name for the 'emitting' property.
        /// </summary>
        public static readonly StringName Emitting = "emitting";
        /// <summary>
        /// Cached name for the 'amount' property.
        /// </summary>
        public static readonly StringName Amount = "amount";
        /// <summary>
        /// Cached name for the 'lifetime' property.
        /// </summary>
        public static readonly StringName Lifetime = "lifetime";
        /// <summary>
        /// Cached name for the 'one_shot' property.
        /// </summary>
        public static readonly StringName OneShot = "one_shot";
        /// <summary>
        /// Cached name for the 'preprocess' property.
        /// </summary>
        public static readonly StringName Preprocess = "preprocess";
        /// <summary>
        /// Cached name for the 'speed_scale' property.
        /// </summary>
        public static readonly StringName SpeedScale = "speed_scale";
        /// <summary>
        /// Cached name for the 'explosiveness' property.
        /// </summary>
        public static readonly StringName Explosiveness = "explosiveness";
        /// <summary>
        /// Cached name for the 'randomness' property.
        /// </summary>
        public static readonly StringName Randomness = "randomness";
        /// <summary>
        /// Cached name for the 'lifetime_randomness' property.
        /// </summary>
        public static readonly StringName LifetimeRandomness = "lifetime_randomness";
        /// <summary>
        /// Cached name for the 'fixed_fps' property.
        /// </summary>
        public static readonly StringName FixedFps = "fixed_fps";
        /// <summary>
        /// Cached name for the 'fract_delta' property.
        /// </summary>
        public static readonly StringName FractDelta = "fract_delta";
        /// <summary>
        /// Cached name for the 'local_coords' property.
        /// </summary>
        public static readonly StringName LocalCoords = "local_coords";
        /// <summary>
        /// Cached name for the 'draw_order' property.
        /// </summary>
        public static readonly StringName DrawOrder = "draw_order";
        /// <summary>
        /// Cached name for the 'texture' property.
        /// </summary>
        public static readonly StringName Texture = "texture";
        /// <summary>
        /// Cached name for the 'emission_shape' property.
        /// </summary>
        public static readonly StringName EmissionShape = "emission_shape";
        /// <summary>
        /// Cached name for the 'emission_sphere_radius' property.
        /// </summary>
        public static readonly StringName EmissionSphereRadius = "emission_sphere_radius";
        /// <summary>
        /// Cached name for the 'emission_rect_extents' property.
        /// </summary>
        public static readonly StringName EmissionRectExtents = "emission_rect_extents";
        /// <summary>
        /// Cached name for the 'emission_points' property.
        /// </summary>
        public static readonly StringName EmissionPoints = "emission_points";
        /// <summary>
        /// Cached name for the 'emission_normals' property.
        /// </summary>
        public static readonly StringName EmissionNormals = "emission_normals";
        /// <summary>
        /// Cached name for the 'emission_colors' property.
        /// </summary>
        public static readonly StringName EmissionColors = "emission_colors";
        /// <summary>
        /// Cached name for the 'particle_flag_align_y' property.
        /// </summary>
        public static readonly StringName ParticleFlagAlignY = "particle_flag_align_y";
        /// <summary>
        /// Cached name for the 'direction' property.
        /// </summary>
        public static readonly StringName Direction = "direction";
        /// <summary>
        /// Cached name for the 'spread' property.
        /// </summary>
        public static readonly StringName Spread = "spread";
        /// <summary>
        /// Cached name for the 'gravity' property.
        /// </summary>
        public static readonly StringName Gravity = "gravity";
        /// <summary>
        /// Cached name for the 'initial_velocity_min' property.
        /// </summary>
        public static readonly StringName InitialVelocityMin = "initial_velocity_min";
        /// <summary>
        /// Cached name for the 'initial_velocity_max' property.
        /// </summary>
        public static readonly StringName InitialVelocityMax = "initial_velocity_max";
        /// <summary>
        /// Cached name for the 'angular_velocity_min' property.
        /// </summary>
        public static readonly StringName AngularVelocityMin = "angular_velocity_min";
        /// <summary>
        /// Cached name for the 'angular_velocity_max' property.
        /// </summary>
        public static readonly StringName AngularVelocityMax = "angular_velocity_max";
        /// <summary>
        /// Cached name for the 'angular_velocity_curve' property.
        /// </summary>
        public static readonly StringName AngularVelocityCurve = "angular_velocity_curve";
        /// <summary>
        /// Cached name for the 'orbit_velocity_min' property.
        /// </summary>
        public static readonly StringName OrbitVelocityMin = "orbit_velocity_min";
        /// <summary>
        /// Cached name for the 'orbit_velocity_max' property.
        /// </summary>
        public static readonly StringName OrbitVelocityMax = "orbit_velocity_max";
        /// <summary>
        /// Cached name for the 'orbit_velocity_curve' property.
        /// </summary>
        public static readonly StringName OrbitVelocityCurve = "orbit_velocity_curve";
        /// <summary>
        /// Cached name for the 'linear_accel_min' property.
        /// </summary>
        public static readonly StringName LinearAccelMin = "linear_accel_min";
        /// <summary>
        /// Cached name for the 'linear_accel_max' property.
        /// </summary>
        public static readonly StringName LinearAccelMax = "linear_accel_max";
        /// <summary>
        /// Cached name for the 'linear_accel_curve' property.
        /// </summary>
        public static readonly StringName LinearAccelCurve = "linear_accel_curve";
        /// <summary>
        /// Cached name for the 'radial_accel_min' property.
        /// </summary>
        public static readonly StringName RadialAccelMin = "radial_accel_min";
        /// <summary>
        /// Cached name for the 'radial_accel_max' property.
        /// </summary>
        public static readonly StringName RadialAccelMax = "radial_accel_max";
        /// <summary>
        /// Cached name for the 'radial_accel_curve' property.
        /// </summary>
        public static readonly StringName RadialAccelCurve = "radial_accel_curve";
        /// <summary>
        /// Cached name for the 'tangential_accel_min' property.
        /// </summary>
        public static readonly StringName TangentialAccelMin = "tangential_accel_min";
        /// <summary>
        /// Cached name for the 'tangential_accel_max' property.
        /// </summary>
        public static readonly StringName TangentialAccelMax = "tangential_accel_max";
        /// <summary>
        /// Cached name for the 'tangential_accel_curve' property.
        /// </summary>
        public static readonly StringName TangentialAccelCurve = "tangential_accel_curve";
        /// <summary>
        /// Cached name for the 'damping_min' property.
        /// </summary>
        public static readonly StringName DampingMin = "damping_min";
        /// <summary>
        /// Cached name for the 'damping_max' property.
        /// </summary>
        public static readonly StringName DampingMax = "damping_max";
        /// <summary>
        /// Cached name for the 'damping_curve' property.
        /// </summary>
        public static readonly StringName DampingCurve = "damping_curve";
        /// <summary>
        /// Cached name for the 'angle_min' property.
        /// </summary>
        public static readonly StringName AngleMin = "angle_min";
        /// <summary>
        /// Cached name for the 'angle_max' property.
        /// </summary>
        public static readonly StringName AngleMax = "angle_max";
        /// <summary>
        /// Cached name for the 'angle_curve' property.
        /// </summary>
        public static readonly StringName AngleCurve = "angle_curve";
        /// <summary>
        /// Cached name for the 'scale_amount_min' property.
        /// </summary>
        public static readonly StringName ScaleAmountMin = "scale_amount_min";
        /// <summary>
        /// Cached name for the 'scale_amount_max' property.
        /// </summary>
        public static readonly StringName ScaleAmountMax = "scale_amount_max";
        /// <summary>
        /// Cached name for the 'scale_amount_curve' property.
        /// </summary>
        public static readonly StringName ScaleAmountCurve = "scale_amount_curve";
        /// <summary>
        /// Cached name for the 'split_scale' property.
        /// </summary>
        public static readonly StringName SplitScale = "split_scale";
        /// <summary>
        /// Cached name for the 'scale_curve_x' property.
        /// </summary>
        public static readonly StringName ScaleCurveX = "scale_curve_x";
        /// <summary>
        /// Cached name for the 'scale_curve_y' property.
        /// </summary>
        public static readonly StringName ScaleCurveY = "scale_curve_y";
        /// <summary>
        /// Cached name for the 'color' property.
        /// </summary>
        public static readonly StringName Color = "color";
        /// <summary>
        /// Cached name for the 'color_ramp' property.
        /// </summary>
        public static readonly StringName ColorRamp = "color_ramp";
        /// <summary>
        /// Cached name for the 'color_initial_ramp' property.
        /// </summary>
        public static readonly StringName ColorInitialRamp = "color_initial_ramp";
        /// <summary>
        /// Cached name for the 'hue_variation_min' property.
        /// </summary>
        public static readonly StringName HueVariationMin = "hue_variation_min";
        /// <summary>
        /// Cached name for the 'hue_variation_max' property.
        /// </summary>
        public static readonly StringName HueVariationMax = "hue_variation_max";
        /// <summary>
        /// Cached name for the 'hue_variation_curve' property.
        /// </summary>
        public static readonly StringName HueVariationCurve = "hue_variation_curve";
        /// <summary>
        /// Cached name for the 'anim_speed_min' property.
        /// </summary>
        public static readonly StringName AnimSpeedMin = "anim_speed_min";
        /// <summary>
        /// Cached name for the 'anim_speed_max' property.
        /// </summary>
        public static readonly StringName AnimSpeedMax = "anim_speed_max";
        /// <summary>
        /// Cached name for the 'anim_speed_curve' property.
        /// </summary>
        public static readonly StringName AnimSpeedCurve = "anim_speed_curve";
        /// <summary>
        /// Cached name for the 'anim_offset_min' property.
        /// </summary>
        public static readonly StringName AnimOffsetMin = "anim_offset_min";
        /// <summary>
        /// Cached name for the 'anim_offset_max' property.
        /// </summary>
        public static readonly StringName AnimOffsetMax = "anim_offset_max";
        /// <summary>
        /// Cached name for the 'anim_offset_curve' property.
        /// </summary>
        public static readonly StringName AnimOffsetCurve = "anim_offset_curve";
    }

    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : Node2D.MethodName
    {
        /// <summary>
        /// Cached name for the 'set_emitting' method.
        /// </summary>
        public static readonly StringName SetEmitting = "set_emitting";
        /// <summary>
        /// Cached name for the 'set_amount' method.
        /// </summary>
        public static readonly StringName SetAmount = "set_amount";
        /// <summary>
        /// Cached name for the 'set_lifetime' method.
        /// </summary>
        public static readonly StringName SetLifetime = "set_lifetime";
        /// <summary>
        /// Cached name for the 'set_one_shot' method.
        /// </summary>
        public static readonly StringName SetOneShot = "set_one_shot";
        /// <summary>
        /// Cached name for the 'set_pre_process_time' method.
        /// </summary>
        public static readonly StringName SetPreProcessTime = "set_pre_process_time";
        /// <summary>
        /// Cached name for the 'set_explosiveness_ratio' method.
        /// </summary>
        public static readonly StringName SetExplosivenessRatio = "set_explosiveness_ratio";
        /// <summary>
        /// Cached name for the 'set_randomness_ratio' method.
        /// </summary>
        public static readonly StringName SetRandomnessRatio = "set_randomness_ratio";
        /// <summary>
        /// Cached name for the 'set_lifetime_randomness' method.
        /// </summary>
        public static readonly StringName SetLifetimeRandomness = "set_lifetime_randomness";
        /// <summary>
        /// Cached name for the 'set_use_local_coordinates' method.
        /// </summary>
        public static readonly StringName SetUseLocalCoordinates = "set_use_local_coordinates";
        /// <summary>
        /// Cached name for the 'set_fixed_fps' method.
        /// </summary>
        public static readonly StringName SetFixedFps = "set_fixed_fps";
        /// <summary>
        /// Cached name for the 'set_fractional_delta' method.
        /// </summary>
        public static readonly StringName SetFractionalDelta = "set_fractional_delta";
        /// <summary>
        /// Cached name for the 'set_speed_scale' method.
        /// </summary>
        public static readonly StringName SetSpeedScale = "set_speed_scale";
        /// <summary>
        /// Cached name for the 'is_emitting' method.
        /// </summary>
        public static readonly StringName IsEmitting = "is_emitting";
        /// <summary>
        /// Cached name for the 'get_amount' method.
        /// </summary>
        public static readonly StringName GetAmount = "get_amount";
        /// <summary>
        /// Cached name for the 'get_lifetime' method.
        /// </summary>
        public static readonly StringName GetLifetime = "get_lifetime";
        /// <summary>
        /// Cached name for the 'get_one_shot' method.
        /// </summary>
        public static readonly StringName GetOneShot = "get_one_shot";
        /// <summary>
        /// Cached name for the 'get_pre_process_time' method.
        /// </summary>
        public static readonly StringName GetPreProcessTime = "get_pre_process_time";
        /// <summary>
        /// Cached name for the 'get_explosiveness_ratio' method.
        /// </summary>
        public static readonly StringName GetExplosivenessRatio = "get_explosiveness_ratio";
        /// <summary>
        /// Cached name for the 'get_randomness_ratio' method.
        /// </summary>
        public static readonly StringName GetRandomnessRatio = "get_randomness_ratio";
        /// <summary>
        /// Cached name for the 'get_lifetime_randomness' method.
        /// </summary>
        public static readonly StringName GetLifetimeRandomness = "get_lifetime_randomness";
        /// <summary>
        /// Cached name for the 'get_use_local_coordinates' method.
        /// </summary>
        public static readonly StringName GetUseLocalCoordinates = "get_use_local_coordinates";
        /// <summary>
        /// Cached name for the 'get_fixed_fps' method.
        /// </summary>
        public static readonly StringName GetFixedFps = "get_fixed_fps";
        /// <summary>
        /// Cached name for the 'get_fractional_delta' method.
        /// </summary>
        public static readonly StringName GetFractionalDelta = "get_fractional_delta";
        /// <summary>
        /// Cached name for the 'get_speed_scale' method.
        /// </summary>
        public static readonly StringName GetSpeedScale = "get_speed_scale";
        /// <summary>
        /// Cached name for the 'set_draw_order' method.
        /// </summary>
        public static readonly StringName SetDrawOrder = "set_draw_order";
        /// <summary>
        /// Cached name for the 'get_draw_order' method.
        /// </summary>
        public static readonly StringName GetDrawOrder = "get_draw_order";
        /// <summary>
        /// Cached name for the 'set_texture' method.
        /// </summary>
        public static readonly StringName SetTexture = "set_texture";
        /// <summary>
        /// Cached name for the 'get_texture' method.
        /// </summary>
        public static readonly StringName GetTexture = "get_texture";
        /// <summary>
        /// Cached name for the 'restart' method.
        /// </summary>
        public static readonly StringName Restart = "restart";
        /// <summary>
        /// Cached name for the 'set_direction' method.
        /// </summary>
        public static readonly StringName SetDirection = "set_direction";
        /// <summary>
        /// Cached name for the 'get_direction' method.
        /// </summary>
        public static readonly StringName GetDirection = "get_direction";
        /// <summary>
        /// Cached name for the 'set_spread' method.
        /// </summary>
        public static readonly StringName SetSpread = "set_spread";
        /// <summary>
        /// Cached name for the 'get_spread' method.
        /// </summary>
        public static readonly StringName GetSpread = "get_spread";
        /// <summary>
        /// Cached name for the 'set_param_min' method.
        /// </summary>
        public static readonly StringName SetParamMin = "set_param_min";
        /// <summary>
        /// Cached name for the 'get_param_min' method.
        /// </summary>
        public static readonly StringName GetParamMin = "get_param_min";
        /// <summary>
        /// Cached name for the 'set_param_max' method.
        /// </summary>
        public static readonly StringName SetParamMax = "set_param_max";
        /// <summary>
        /// Cached name for the 'get_param_max' method.
        /// </summary>
        public static readonly StringName GetParamMax = "get_param_max";
        /// <summary>
        /// Cached name for the 'set_param_curve' method.
        /// </summary>
        public static readonly StringName SetParamCurve = "set_param_curve";
        /// <summary>
        /// Cached name for the 'get_param_curve' method.
        /// </summary>
        public static readonly StringName GetParamCurve = "get_param_curve";
        /// <summary>
        /// Cached name for the 'set_color' method.
        /// </summary>
        public static readonly StringName SetColor = "set_color";
        /// <summary>
        /// Cached name for the 'get_color' method.
        /// </summary>
        public static readonly StringName GetColor = "get_color";
        /// <summary>
        /// Cached name for the 'set_color_ramp' method.
        /// </summary>
        public static readonly StringName SetColorRamp = "set_color_ramp";
        /// <summary>
        /// Cached name for the 'get_color_ramp' method.
        /// </summary>
        public static readonly StringName GetColorRamp = "get_color_ramp";
        /// <summary>
        /// Cached name for the 'set_color_initial_ramp' method.
        /// </summary>
        public static readonly StringName SetColorInitialRamp = "set_color_initial_ramp";
        /// <summary>
        /// Cached name for the 'get_color_initial_ramp' method.
        /// </summary>
        public static readonly StringName GetColorInitialRamp = "get_color_initial_ramp";
        /// <summary>
        /// Cached name for the 'set_particle_flag' method.
        /// </summary>
        public static readonly StringName SetParticleFlag = "set_particle_flag";
        /// <summary>
        /// Cached name for the 'get_particle_flag' method.
        /// </summary>
        public static readonly StringName GetParticleFlag = "get_particle_flag";
        /// <summary>
        /// Cached name for the 'set_emission_shape' method.
        /// </summary>
        public static readonly StringName SetEmissionShape = "set_emission_shape";
        /// <summary>
        /// Cached name for the 'get_emission_shape' method.
        /// </summary>
        public static readonly StringName GetEmissionShape = "get_emission_shape";
        /// <summary>
        /// Cached name for the 'set_emission_sphere_radius' method.
        /// </summary>
        public static readonly StringName SetEmissionSphereRadius = "set_emission_sphere_radius";
        /// <summary>
        /// Cached name for the 'get_emission_sphere_radius' method.
        /// </summary>
        public static readonly StringName GetEmissionSphereRadius = "get_emission_sphere_radius";
        /// <summary>
        /// Cached name for the 'set_emission_rect_extents' method.
        /// </summary>
        public static readonly StringName SetEmissionRectExtents = "set_emission_rect_extents";
        /// <summary>
        /// Cached name for the 'get_emission_rect_extents' method.
        /// </summary>
        public static readonly StringName GetEmissionRectExtents = "get_emission_rect_extents";
        /// <summary>
        /// Cached name for the 'set_emission_points' method.
        /// </summary>
        public static readonly StringName SetEmissionPoints = "set_emission_points";
        /// <summary>
        /// Cached name for the 'get_emission_points' method.
        /// </summary>
        public static readonly StringName GetEmissionPoints = "get_emission_points";
        /// <summary>
        /// Cached name for the 'set_emission_normals' method.
        /// </summary>
        public static readonly StringName SetEmissionNormals = "set_emission_normals";
        /// <summary>
        /// Cached name for the 'get_emission_normals' method.
        /// </summary>
        public static readonly StringName GetEmissionNormals = "get_emission_normals";
        /// <summary>
        /// Cached name for the 'set_emission_colors' method.
        /// </summary>
        public static readonly StringName SetEmissionColors = "set_emission_colors";
        /// <summary>
        /// Cached name for the 'get_emission_colors' method.
        /// </summary>
        public static readonly StringName GetEmissionColors = "get_emission_colors";
        /// <summary>
        /// Cached name for the 'get_gravity' method.
        /// </summary>
        public static readonly StringName GetGravity = "get_gravity";
        /// <summary>
        /// Cached name for the 'set_gravity' method.
        /// </summary>
        public static readonly StringName SetGravity = "set_gravity";
        /// <summary>
        /// Cached name for the 'get_split_scale' method.
        /// </summary>
        public static readonly StringName GetSplitScale = "get_split_scale";
        /// <summary>
        /// Cached name for the 'set_split_scale' method.
        /// </summary>
        public static readonly StringName SetSplitScale = "set_split_scale";
        /// <summary>
        /// Cached name for the 'get_scale_curve_x' method.
        /// </summary>
        public static readonly StringName GetScaleCurveX = "get_scale_curve_x";
        /// <summary>
        /// Cached name for the 'set_scale_curve_x' method.
        /// </summary>
        public static readonly StringName SetScaleCurveX = "set_scale_curve_x";
        /// <summary>
        /// Cached name for the 'get_scale_curve_y' method.
        /// </summary>
        public static readonly StringName GetScaleCurveY = "get_scale_curve_y";
        /// <summary>
        /// Cached name for the 'set_scale_curve_y' method.
        /// </summary>
        public static readonly StringName SetScaleCurveY = "set_scale_curve_y";
        /// <summary>
        /// Cached name for the 'convert_from_particles' method.
        /// </summary>
        public static readonly StringName ConvertFromParticles = "convert_from_particles";
    }

    /// <summary>
    /// Cached StringNames for the signals contained in this class, for fast lookup.
    /// </summary>
    public new class SignalName : Node2D.SignalName
    {
        /// <summary>
        /// Cached name for the 'finished' signal.
        /// </summary>
        public static readonly StringName Finished = "finished";
    }
}

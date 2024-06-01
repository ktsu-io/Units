#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record AngularAcceleration : Scalar<AngularAcceleration>
{
	private const double RadiansPerSecondSquared = 1;
	private const double DegreesPerSecondSquared = 0.017453292519943295;
	public static AngularAcceleration operator +(AngularAcceleration left, AngularAcceleration right) => Add(left, right);
	public static AngularAcceleration operator -(AngularAcceleration left, AngularAcceleration right) => Subtract(left, right);
	public static AngularAcceleration operator *(AngularAcceleration left, AngularAcceleration right) => Multiply(left, right);
	public static AngularAcceleration operator /(AngularAcceleration left, AngularAcceleration right) => Divide(left, right);
	public static bool operator <(AngularAcceleration left, AngularAcceleration right) => CompareTo(left, right) < 0;
	public static bool operator <=(AngularAcceleration left, AngularAcceleration right) => CompareTo(left, right) <= 0;
	public static bool operator >(AngularAcceleration left, AngularAcceleration right) => CompareTo(left, right) > 0;
	public static bool operator >=(AngularAcceleration left, AngularAcceleration right) => CompareTo(left, right) >= 0;
	public static AngularAcceleration FromRadiansPerSecondSquared(double value) => new() { BaseValue = value / RadiansPerSecondSquared };
	public static AngularAcceleration FromDegreesPerSecondSquared(double value) => new() { BaseValue = value / DegreesPerSecondSquared };
	public double ToRadiansPerSecondSquared() => BaseValue * RadiansPerSecondSquared;
	public double ToDegreesPerSecondSquared() => BaseValue * DegreesPerSecondSquared;
}

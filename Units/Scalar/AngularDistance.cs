#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record AngularDistance : Scalar<AngularDistance>
{
	private const double Radians = 1;
	private const double Degrees = 0.017453292519943295;
	public static AngularDistance operator +(AngularDistance left, AngularDistance right) => Add(left, right);
	public static AngularDistance operator -(AngularDistance left, AngularDistance right) => Subtract(left, right);
	public static AngularDistance operator *(AngularDistance left, AngularDistance right) => Multiply(left, right);
	public static AngularDistance operator /(AngularDistance left, AngularDistance right) => Divide(left, right);
	public static bool operator <(AngularDistance left, AngularDistance right) => CompareTo(left, right) < 0;
	public static bool operator <=(AngularDistance left, AngularDistance right) => CompareTo(left, right) <= 0;
	public static bool operator >(AngularDistance left, AngularDistance right) => CompareTo(left, right) > 0;
	public static bool operator >=(AngularDistance left, AngularDistance right) => CompareTo(left, right) >= 0;
	public static AngularDistance FromRadians(double value) => new() { BaseValue = value / Radians };
	public static AngularDistance FromDegrees(double value) => new() { BaseValue = value / Degrees };
	public double ToRadiansPerSecondSquared() => BaseValue * Radians;
	public double ToDegreesPerSecondSquared() => BaseValue * Degrees;
}

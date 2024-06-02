#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record AngularVelocity : Scalar<AngularVelocity>
{
	private const double RadiansPerSecond = 1;
	private const double DegreesPerSecond = 0.017453292519943295;
	private const double RevolutionsPerMinute = 0.10471975511965977;

	public override string SIBaseUnitName => "rad/s";

	public static AngularVelocity operator +(AngularVelocity left, AngularVelocity right) => Add(left, right);
	public static AngularVelocity operator -(AngularVelocity left, AngularVelocity right) => Subtract(left, right);
	public static AngularVelocity operator *(AngularVelocity left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(AngularVelocity left, AngularVelocity right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static AngularAcceleration operator /(AngularVelocity left, Time right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static AngularVelocity operator *(AngularVelocity left, double right) => Multiply(left, right);
	public static AngularVelocity operator /(AngularVelocity left, double right) => Divide(left, right);
	public static bool operator <(AngularVelocity left, AngularVelocity right) => CompareTo(left, right) < 0;
	public static bool operator <=(AngularVelocity left, AngularVelocity right) => CompareTo(left, right) <= 0;
	public static bool operator >(AngularVelocity left, AngularVelocity right) => CompareTo(left, right) > 0;
	public static bool operator >=(AngularVelocity left, AngularVelocity right) => CompareTo(left, right) >= 0;
	public static AngularVelocity FromRadiansPerSecond(double value) => new() { BaseValue = value / RadiansPerSecond };
	public static AngularVelocity FromDegreesPerSecond(double value) => new() { BaseValue = value / DegreesPerSecond };
	public static AngularVelocity FromRevolutionsPerMinute(double value) => new() { BaseValue = value / RevolutionsPerMinute };
	public double ToRadiansPerSecond() => BaseValue * RadiansPerSecond;
	public double ToDegreesPerSecond() => BaseValue * DegreesPerSecond;
	public double ToRevolutionsPerMinute() => BaseValue * RevolutionsPerMinute;
}

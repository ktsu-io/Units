#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record LinearVelocity : Scalar<LinearVelocity>
{
	private const double MetersPerSecond = 1;
	private const double KilometersPerHour = 3.6;
	private const double FeetPerSecond = 3.2808398950131235;
	private const double MilesPerHour = 2.2369362920544025;
	private const double LightSpeed = 299792458;
	private const double Mach = 0.002938669957977;
	public static LinearVelocity operator +(LinearVelocity left, LinearVelocity right) => Add(left, right);
	public static LinearVelocity operator -(LinearVelocity left, LinearVelocity right) => Subtract(left, right);
	public static LinearVelocity operator *(LinearVelocity left, LinearVelocity right) => Multiply(left, right);
	public static LinearVelocity operator /(LinearVelocity left, LinearVelocity right) => Divide(left, right);
	public static bool operator <(LinearVelocity left, LinearVelocity right) => CompareTo(left, right) < 0;
	public static bool operator <=(LinearVelocity left, LinearVelocity right) => CompareTo(left, right) <= 0;
	public static bool operator >(LinearVelocity left, LinearVelocity right) => CompareTo(left, right) > 0;
	public static bool operator >=(LinearVelocity left, LinearVelocity right) => CompareTo(left, right) >= 0;
	public static LinearVelocity FromMetersPerSecond(double value) => new() { BaseValue = value / MetersPerSecond };
	public static LinearVelocity FromKilometersPerHour(double value) => new() { BaseValue = value / KilometersPerHour };
	public static LinearVelocity FromFeetPerSecond(double value) => new() { BaseValue = value / FeetPerSecond };
	public static LinearVelocity FromMilesPerHour(double value) => new() { BaseValue = value / MilesPerHour };
	public static LinearVelocity FromLightSpeed(double value) => new() { BaseValue = value / LightSpeed };
	public static LinearVelocity FromMach(double value) => new() { BaseValue = value / Mach };
	public double ToMetersPerSecond() => BaseValue * MetersPerSecond;
	public double ToKilometersPerHour() => BaseValue * KilometersPerHour;
	public double ToFeetPerSecond() => BaseValue * FeetPerSecond;
	public double ToMilesPerHour() => BaseValue * MilesPerHour;
	public double ToLightSpeed() => BaseValue * LightSpeed;
	public double ToMach() => BaseValue * Mach;
}

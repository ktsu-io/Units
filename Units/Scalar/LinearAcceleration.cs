#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record LinearAcceleration : Scalar<LinearAcceleration>
{
	private const double MetersPerSecondSquared = 1;
	private const double FeetPerSecondSquared = 0.3048;
	private const double Gravity = 0.10197162129779283;
	public static LinearAcceleration operator +(LinearAcceleration left, LinearAcceleration right) => Add(left, right);
	public static LinearAcceleration operator -(LinearAcceleration left, LinearAcceleration right) => Subtract(left, right);
	public static LinearAcceleration operator *(LinearAcceleration left, LinearAcceleration right) => Multiply(left, right);
	public static LinearAcceleration operator /(LinearAcceleration left, LinearAcceleration right) => Divide(left, right);
	public static bool operator <(LinearAcceleration left, LinearAcceleration right) => CompareTo(left, right) < 0;
	public static bool operator <=(LinearAcceleration left, LinearAcceleration right) => CompareTo(left, right) <= 0;
	public static bool operator >(LinearAcceleration left, LinearAcceleration right) => CompareTo(left, right) > 0;
	public static bool operator >=(LinearAcceleration left, LinearAcceleration right) => CompareTo(left, right) >= 0;
	public static LinearAcceleration FromMetersPerSecondSquared(double value) => new() { BaseValue = value / MetersPerSecondSquared };
	public static LinearAcceleration FromFeetPerSecondSquared(double value) => new() { BaseValue = value / FeetPerSecondSquared };
	public static LinearAcceleration FromGravity(double value) => new() { BaseValue = value / Gravity };
	public double ToMetersPerSecondSquared() => BaseValue * MetersPerSecondSquared;
	public double ToFeetPerSecondSquared() => BaseValue * FeetPerSecondSquared;
	public double ToGravity() => BaseValue * Gravity;
}

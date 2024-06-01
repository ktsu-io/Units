#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Torque : Scalar<Torque>
{
	private const double NewtonMeters = 1;
	private const double FootPounds = 0.7375621492772656;
	public static Torque operator +(Torque left, Torque right) => Add(left, right);
	public static Torque operator -(Torque left, Torque right) => Subtract(left, right);
	public static Torque operator *(Torque left, Torque right) => Multiply(left, right);
	public static Torque operator /(Torque left, Torque right) => Divide(left, right);
	public static bool operator <(Torque left, Torque right) => CompareTo(left, right) < 0;
	public static bool operator <=(Torque left, Torque right) => CompareTo(left, right) <= 0;
	public static bool operator >(Torque left, Torque right) => CompareTo(left, right) > 0;
	public static bool operator >=(Torque left, Torque right) => CompareTo(left, right) >= 0;
	public static Torque FromNewtonMeters(double value) => new() { BaseValue = value / NewtonMeters };
	public static Torque FromFootPounds(double value) => new() { BaseValue = value / FootPounds };
	public double ToNewtonMeters() => BaseValue * NewtonMeters;
	public double ToFootPounds() => BaseValue * FootPounds;
}

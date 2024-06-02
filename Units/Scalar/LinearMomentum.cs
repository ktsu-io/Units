#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record LinearMomentum : Scalar<LinearMomentum>
{
	private const double KilogramMeterPerSecond = 1;
	private const double SlugFootPerSecond = 0.3048;

	public static LinearMomentum operator +(LinearMomentum left, LinearMomentum right) => Add(left, right);
	public static LinearMomentum operator -(LinearMomentum left, LinearMomentum right) => Subtract(left, right);
	public static LinearMomentum operator *(LinearMomentum left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(LinearMomentum left, LinearMomentum right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Force operator /(LinearMomentum left, LinearDistance right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static LinearDistance operator /(LinearMomentum left, Force right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static LinearMomentum operator *(LinearMomentum left, double right) => Multiply(left, right);
	public static LinearMomentum operator /(LinearMomentum left, double right) => Divide(left, right);
	public static bool operator <(LinearMomentum left, LinearMomentum right) => CompareTo(left, right) < 0;
	public static bool operator <=(LinearMomentum left, LinearMomentum right) => CompareTo(left, right) <= 0;
	public static bool operator >(LinearMomentum left, LinearMomentum right) => CompareTo(left, right) > 0;
	public static bool operator >=(LinearMomentum left, LinearMomentum right) => CompareTo(left, right) >= 0;
	public static LinearMomentum FromKilogramMeterPerSecond(double value) => new() { BaseValue = value / KilogramMeterPerSecond };
	public static LinearMomentum FromSlugFootPerSecond(double value) => new() { BaseValue = value / SlugFootPerSecond };
	public double ToKilogramMeterPerSecond() => BaseValue * KilogramMeterPerSecond;
	public double ToSlugFootPerSecond() => BaseValue * SlugFootPerSecond;
}

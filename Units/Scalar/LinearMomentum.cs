#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record LinearMomentum : Scalar<LinearMomentum>
{
	private const double KilogramMetersPerSecond = 1;
	private const double SlugFeetPerSecond = 0.3048;

	protected override string SIBaseUnitName => "kg·m/s";
	public override string ToString() => $"{BaseValue} {SIBaseUnitName}";

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
	public static LinearMomentum FromKilogramMeterPerSecond(double value) => new() { BaseValue = value / KilogramMetersPerSecond };
	public static LinearMomentum FromSlugFootPerSecond(double value) => new() { BaseValue = value / SlugFeetPerSecond };
	public double ToKilogramMeterPerSecond() => BaseValue * KilogramMetersPerSecond;
	public double ToSlugFootPerSecond() => BaseValue * SlugFeetPerSecond;
}

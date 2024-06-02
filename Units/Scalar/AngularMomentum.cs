#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record AngularMomentum : Scalar<AngularMomentum>
{
	private const double KilogramMetersSquaredPerSecond = 1;
	private const double SlugFeetSquaredPerSecond = 0.0421401100938048;

	public static AngularMomentum operator +(AngularMomentum left, AngularMomentum right) => Add(left, right);
	public static AngularMomentum operator -(AngularMomentum left, AngularMomentum right) => Subtract(left, right);
	public static AngularMomentum operator *(AngularMomentum left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(AngularMomentum left, AngularMomentum right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Force operator /(AngularMomentum left, LinearDistance right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static LinearDistance operator /(AngularMomentum left, Force right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static AngularMomentum operator *(AngularMomentum left, double right) => Multiply(left, right);
	public static AngularMomentum operator /(AngularMomentum left, double right) => Divide(left, right);
	public static bool operator <(AngularMomentum left, AngularMomentum right) => CompareTo(left, right) < 0;
	public static bool operator <=(AngularMomentum left, AngularMomentum right) => CompareTo(left, right) <= 0;
	public static bool operator >(AngularMomentum left, AngularMomentum right) => CompareTo(left, right) > 0;
	public static bool operator >=(AngularMomentum left, AngularMomentum right) => CompareTo(left, right) >= 0;
	public static AngularMomentum FromKilogramMetersSquaredPerSecond(double value) => new() { BaseValue = value / KilogramMetersSquaredPerSecond };
	public static AngularMomentum FromSlugFeetSquaredPerSecond(double value) => new() { BaseValue = value / SlugFeetSquaredPerSecond };
	public double ToKilogramMetersSquaredPerSecond() => BaseValue * KilogramMetersSquaredPerSecond;
	public double ToSlugFeetSquaredPerSecond() => BaseValue * SlugFeetSquaredPerSecond;
}

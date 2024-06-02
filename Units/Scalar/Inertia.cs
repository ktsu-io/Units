#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Inertia : Scalar<Inertia>
{
	private const double KilogramMetersSquared = 1;
	private const double SlugFeetSquared = 0.0421401100938048;

	protected override string SIBaseUnitName => "kg·m²";
	public override string ToString() => $"{BaseValue} {SIBaseUnitName}";

	public static Inertia operator +(Inertia left, Inertia right) => Add(left, right);
	public static Inertia operator -(Inertia left, Inertia right) => Subtract(left, right);
	public static Inertia operator *(Inertia left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(Inertia left, Inertia right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Inertia operator *(Inertia left, double right) => Multiply(left, right);
	public static Inertia operator /(Inertia left, double right) => Divide(left, right);
	public static bool operator <(Inertia left, Inertia right) => CompareTo(left, right) < 0;
	public static bool operator <=(Inertia left, Inertia right) => CompareTo(left, right) <= 0;
	public static bool operator >(Inertia left, Inertia right) => CompareTo(left, right) > 0;
	public static bool operator >=(Inertia left, Inertia right) => CompareTo(left, right) >= 0;
	public static Inertia FromKilogramMetersSquared(double value) => new() { BaseValue = value / KilogramMetersSquared };
	public static Inertia FromSlugFeetSquared(double value) => new() { BaseValue = value / SlugFeetSquared };
	public double ToKilogramMetersSquared() => BaseValue * KilogramMetersSquared;
	public double ToSlugFeetSquared() => BaseValue * SlugFeetSquared;
}

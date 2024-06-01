#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Force : Scalar<Force>
{
	private const double Newtons = 1;
	private const double Dynes = 100000;
	private const double PoundsForce = 0.2248089430997107;
	public static Force operator +(Force left, Force right) => Add(left, right);
	public static Force operator -(Force left, Force right) => Subtract(left, right);
	public static Force operator *(Force left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(Force left, Force right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Force operator *(Force left, double right) => Multiply(left, right);
	public static Force operator /(Force left, double right) => Divide(left, right);
	public static bool operator <(Force left, Force right) => CompareTo(left, right) < 0;
	public static bool operator <=(Force left, Force right) => CompareTo(left, right) <= 0;
	public static bool operator >(Force left, Force right) => CompareTo(left, right) > 0;
	public static bool operator >=(Force left, Force right) => CompareTo(left, right) >= 0;
	public static Force FromNewtons(double value) => new() { BaseValue = value / Newtons };
	public static Force FromDynes(double value) => new() { BaseValue = value / Dynes };
	public static Force FromPoundsForce(double value) => new() { BaseValue = value / PoundsForce };
	public double ToNewtons() => BaseValue * Newtons;
	public double ToDynes() => BaseValue * Dynes;
	public double ToPoundsForce() => BaseValue * PoundsForce;
}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Mass : Scalar<Mass>
{
	private const double Kilograms = 1;
	private const double Grams = 1000;
	private const double Pounds = 2.2046226218487757;
	private const double Ounces = 35.27396194958041;

	protected override string SIBaseUnitName => "kg";
	public override string ToString() => $"{BaseValue} {SIBaseUnitName}";

	public static Mass operator +(Mass left, Mass right) => Add(left, right);
	public static Mass operator -(Mass left, Mass right) => Subtract(left, right);
	public static Mass operator *(Mass left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(Mass left, Mass right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Density operator /(Mass left, Volume right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Volume operator /(Mass left, Density right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Mass operator *(Mass left, double right) => Multiply(left, right);
	public static Mass operator /(Mass left, double right) => Divide(left, right);
	public static bool operator <(Mass left, Mass right) => CompareTo(left, right) < 0;
	public static bool operator <=(Mass left, Mass right) => CompareTo(left, right) <= 0;
	public static bool operator >(Mass left, Mass right) => CompareTo(left, right) > 0;
	public static bool operator >=(Mass left, Mass right) => CompareTo(left, right) >= 0;
	public static Mass FromKilograms(double value) => new() { BaseValue = value / Kilograms };
	public static Mass FromGrams(double value) => new() { BaseValue = value / Grams };
	public static Mass FromPounds(double value) => new() { BaseValue = value / Pounds };
	public static Mass FromOunces(double value) => new() { BaseValue = value / Ounces };
	public double ToKilograms() => BaseValue * Kilograms;
	public double ToGrams() => BaseValue * Grams;
	public double ToPounds() => BaseValue * Pounds;
	public double ToOunces() => BaseValue * Ounces;
}

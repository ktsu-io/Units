#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Power : Scalar<Power>
{
	private const double Watt = 1;
	private const double Kilowatt = 0.001;
	private const double Horsepower = 0.001341022089595;
	public static Power operator +(Power left, Power right) => Add(left, right);
	public static Power operator -(Power left, Power right) => Subtract(left, right);
	public static Power operator *(Power left, Power right) => Multiply(left, right);
	public static Power operator /(Power left, Power right) => Divide(left, right);
	public static bool operator <(Power left, Power right) => CompareTo(left, right) < 0;
	public static bool operator <=(Power left, Power right) => CompareTo(left, right) <= 0;
	public static bool operator >(Power left, Power right) => CompareTo(left, right) > 0;
	public static bool operator >=(Power left, Power right) => CompareTo(left, right) >= 0;
	public static Power FromWatt(double value) => new() { BaseValue = value / Watt };
	public static Power FromKilowatt(double value) => new() { BaseValue = value / Kilowatt };
	public static Power FromHorsepower(double value) => new() { BaseValue = value / Horsepower };
	public double ToWatt() => BaseValue * Watt;
	public double ToKilowatt() => BaseValue * Kilowatt;
	public double ToHorsepower() => BaseValue * Horsepower;
}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Pressure : Scalar<Pressure>
{
	private const double Pascals = 1;
	private const double Kilopascals = 0.001;
	private const double Atmospheres = 9.869232667160128E-6;
	private const double Bars = 1E-5;
	private const double PoundsPerSquareInch = 0.00014503773773020923;
	public static Pressure operator +(Pressure left, Pressure right) => Add(left, right);
	public static Pressure operator -(Pressure left, Pressure right) => Subtract(left, right);
	public static Pressure operator *(Pressure left, Pressure right) => Multiply(left, right);
	public static Pressure operator /(Pressure left, Pressure right) => Divide(left, right);
	public static bool operator <(Pressure left, Pressure right) => CompareTo(left, right) < 0;
	public static bool operator <=(Pressure left, Pressure right) => CompareTo(left, right) <= 0;
	public static bool operator >(Pressure left, Pressure right) => CompareTo(left, right) > 0;
	public static bool operator >=(Pressure left, Pressure right) => CompareTo(left, right) >= 0;
	public static Pressure FromPascals(double value) => new() { BaseValue = value / Pascals };
	public static Pressure FromKilopascals(double value) => new() { BaseValue = value / Kilopascals };
	public static Pressure FromAtmospheres(double value) => new() { BaseValue = value / Atmospheres };
	public static Pressure FromBars(double value) => new() { BaseValue = value / Bars };
	public static Pressure FromPoundsPerSquareInch(double value) => new() { BaseValue = value / PoundsPerSquareInch };
	public double ToPascals() => BaseValue * Pascals;
	public double ToKilopascals() => BaseValue * Kilopascals;
	public double ToAtmospheres() => BaseValue * Atmospheres;
	public double ToBars() => BaseValue * Bars;
	public double ToPoundsPerSquareInch() => BaseValue * PoundsPerSquareInch;
}

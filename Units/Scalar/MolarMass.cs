#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record MolarMass : Scalar<MolarMass>
{
	private const double KilogramsPerMole = 1;
	private const double GramsPerMole = 1000;
	private const double PoundsPerMole = 2.2046226218487757;

	protected override string SIBaseUnitName => "kg/mol";
	public override string ToString() => $"{BaseValue} {SIBaseUnitName}";

	public static MolarMass operator +(MolarMass left, MolarMass right) => Add(left, right);
	public static MolarMass operator -(MolarMass left, MolarMass right) => Subtract(left, right);
	public static MolarMass operator *(MolarMass left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(MolarMass left, MolarMass right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Mass operator *(MolarMass left, AmountOfSubstance right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static MolarMass operator *(MolarMass left, double right) => Multiply(left, right);
	public static MolarMass operator /(MolarMass left, double right) => Divide(left, right);
	public static bool operator <(MolarMass left, MolarMass right) => CompareTo(left, right) < 0;
	public static bool operator <=(MolarMass left, MolarMass right) => CompareTo(left, right) <= 0;
	public static bool operator >(MolarMass left, MolarMass right) => CompareTo(left, right) > 0;
	public static bool operator >=(MolarMass left, MolarMass right) => CompareTo(left, right) >= 0;
	public static MolarMass FromKilogramsPerMole(double value) => new() { BaseValue = value / KilogramsPerMole };
	public static MolarMass FromGramsPerMole(double value) => new() { BaseValue = value / GramsPerMole };
	public static MolarMass FromPoundsPerMole(double value) => new() { BaseValue = value / PoundsPerMole };
	public double ToKilogramsPerMole() => BaseValue * KilogramsPerMole;
	public double ToGramsPerMole() => BaseValue * GramsPerMole;
	public double ToPoundsPerMole() => BaseValue * PoundsPerMole;
}

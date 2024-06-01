#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Area : Scalar<Area>
{
	private const double SquareMeters = 1;
	private const double SquareCentimeters = 1e4;
	private const double SquareMillimeters = 1e6;
	private const double SquareKilometers = 1e-6;
	private const double SquareInches = 1550.0031000062;
	private const double SquareFeet = 10.76391041671;
	private const double SquareYards = 1.1959900463011;
	private const double SquareMiles = 3.8610215854245e-7;
	public static Area operator +(Area left, Area right) => Add(left, right);
	public static Area operator -(Area left, Area right) => Subtract(left, right);
	public static Area operator *(Area left, Area right) => Multiply(left, right);
	public static Area operator /(Area left, Area right) => Divide(left, right);
	public static bool operator <(Area left, Area right) => CompareTo(left, right) < 0;
	public static bool operator <=(Area left, Area right) => CompareTo(left, right) <= 0;
	public static bool operator >(Area left, Area right) => CompareTo(left, right) > 0;
	public static bool operator >=(Area left, Area right) => CompareTo(left, right) >= 0;
	public static Area FromSquareMeters(double value) => new() { BaseValue = value / SquareMeters };
	public static Area FromSquareCentimeters(double value) => new() { BaseValue = value / SquareCentimeters };
	public static Area FromSquareMillimeters(double value) => new() { BaseValue = value / SquareMillimeters };
	public static Area FromSquareKilometers(double value) => new() { BaseValue = value / SquareKilometers };
	public static Area FromSquareInches(double value) => new() { BaseValue = value / SquareInches };
	public static Area FromSquareFeet(double value) => new() { BaseValue = value / SquareFeet };
	public static Area FromSquareYards(double value) => new() { BaseValue = value / SquareYards };
	public static Area FromSquareMiles(double value) => new() { BaseValue = value / SquareMiles };
	public double ToSquareMeters() => BaseValue * SquareMeters;
	public double ToSquareCentimeters() => BaseValue * SquareCentimeters;
	public double ToSquareMillimeters() => BaseValue * SquareMillimeters;
	public double ToSquareKilometers() => BaseValue * SquareKilometers;
	public double ToSquareInches() => BaseValue * SquareInches;
	public double ToSquareFeet() => BaseValue * SquareFeet;
	public double ToSquareYards() => BaseValue * SquareYards;
	public double ToSquareMiles() => BaseValue * SquareMiles;
}

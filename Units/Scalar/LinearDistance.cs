#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates
#pragma warning disable CA1062 // Validate arguments of public methods

namespace ktsu.io.Units.Scalar;

public record LinearDistance : Scalar<LinearDistance>
{
	private const double Meters = 1;
	private const double Feet = 0.3048;
	private const double Inches = 0.0254;
	private const double Yards = 0.9144;
	private const double Miles = 1609.344;
	private const double Kilometers = 1000;
	private const double Centimeters = 0.01;
	private const double Millimeters = 0.001;
	private const double NauticalMiles = 1852;
	private const double AstronomicalUnits = 149597870700;
	private const double LightYears = 9460730472580800;
	private const double Parsecs = 30856775814671900;

	protected override string SIBaseUnitName => "m";

	public static LinearDistance operator +(LinearDistance left, LinearDistance right) => Add(left, right);
	public static LinearDistance operator -(LinearDistance left, LinearDistance right) => Subtract(left, right);
	public static Area operator *(LinearDistance left, LinearDistance right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(LinearDistance left, LinearDistance right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static LinearDistance operator *(LinearDistance left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static LinearDistance operator *(LinearDistance left, double right) => Multiply(left, right);
	public static LinearDistance operator /(LinearDistance left, double right) => Divide(left, right);
	public static bool operator <(LinearDistance left, LinearDistance right) => CompareTo(left, right) < 0;
	public static bool operator <=(LinearDistance left, LinearDistance right) => CompareTo(left, right) <= 0;
	public static bool operator >(LinearDistance left, LinearDistance right) => CompareTo(left, right) > 0;
	public static bool operator >=(LinearDistance left, LinearDistance right) => CompareTo(left, right) >= 0;
	public static LinearDistance FromMeters(double value) => new() { BaseValue = value / Meters };
	public static LinearDistance FromFeet(double value) => new() { BaseValue = value / Feet };
	public static LinearDistance FromInches(double value) => new() { BaseValue = value / Inches };
	public static LinearDistance FromYards(double value) => new() { BaseValue = value / Yards };
	public static LinearDistance FromMiles(double value) => new() { BaseValue = value / Miles };
	public static LinearDistance FromKilometers(double value) => new() { BaseValue = value / Kilometers };
	public static LinearDistance FromCentimeters(double value) => new() { BaseValue = value / Centimeters };
	public static LinearDistance FromMillimeters(double value) => new() { BaseValue = value / Millimeters };
	public static LinearDistance FromNauticalMiles(double value) => new() { BaseValue = value / NauticalMiles };
	public static LinearDistance FromAstronomicalUnits(double value) => new() { BaseValue = value / AstronomicalUnits };
	public static LinearDistance FromLightYears(double value) => new() { BaseValue = value / LightYears };
	public static LinearDistance FromParsecs(double value) => new() { BaseValue = value / Parsecs };
	public double ToMeters() => BaseValue * Meters;
	public double ToFeet() => BaseValue * Feet;
	public double ToInches() => BaseValue * Inches;
	public double ToYards() => BaseValue * Yards;
	public double ToMiles() => BaseValue * Miles;
	public double ToKilometers() => BaseValue * Kilometers;
	public double ToCentimeters() => BaseValue * Centimeters;
	public double ToMillimeters() => BaseValue * Millimeters;
	public double ToNauticalMiles() => BaseValue * NauticalMiles;
	public double ToAstronomicalUnits() => BaseValue * AstronomicalUnits;
	public double ToLightYears() => BaseValue * LightYears;
	public double ToParsecs() => BaseValue * Parsecs;
}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Volume : Scalar<Volume>
{
	private const double CubicKilometers = 1e-9;
	private const double CubicMeters = 1;
	private const double CubicCentimeters = 1e6;
	private const double CubicMillimeters = 1e9;

	private const double CubicFeet = 0.028316846592;
	private const double CubicInches = 61023.744094732;
	private const double CubicYards = 0.03703703703703704;
	private const double CubicMiles = 2.3991275857893e-10;

	private const double Gigaliters = 1e-6;
	private const double Kiloliters = 1;
	private const double Hectoliters = 1e1;
	private const double Decaliters = 1e2;
	private const double Liters = 1e3;
	private const double Deciliters = 1e4;
	private const double Centiliters = 1e5;
	private const double Milliliters = 1e6;

	private const double Gallons = 264.1720523581484;
	private const double Quarts = 1056.6882094325936;
	private const double Pints = 2113.3764188651872;
	private const double Cups = 4226.7528377303744;
	private const double FluidOunces = 33814.022701843;
	private const double Tablespoons = 67628.045403686;
	private const double Teaspoons = 202884.136211058;

	public override string SIBaseUnitName => "m³";

	public static Volume operator +(Volume left, Volume right) => Add(left, right);
	public static Volume operator -(Volume left, Volume right) => Subtract(left, right);
	public static Volume operator *(Volume left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(Volume left, Volume right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Area operator /(Volume left, LinearDistance right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Volume operator *(Volume left, double right) => Multiply(left, right);
	public static Volume operator /(Volume left, double right) => Divide(left, right);
	public static bool operator <(Volume left, Volume right) => CompareTo(left, right) < 0;
	public static bool operator <=(Volume left, Volume right) => CompareTo(left, right) <= 0;
	public static bool operator >(Volume left, Volume right) => CompareTo(left, right) > 0;
	public static bool operator >=(Volume left, Volume right) => CompareTo(left, right) >= 0;
	public static Volume FromCubicKilometers(double value) => new() { BaseValue = value / CubicKilometers };
	public static Volume FromCubicMeters(double value) => new() { BaseValue = value / CubicMeters };
	public static Volume FromCubicCentimeters(double value) => new() { BaseValue = value / CubicCentimeters };
	public static Volume FromCubicMillimeters(double value) => new() { BaseValue = value / CubicMillimeters };
	public static Volume FromCubicFeet(double value) => new() { BaseValue = value / CubicFeet };
	public static Volume FromCubicInches(double value) => new() { BaseValue = value / CubicInches };
	public static Volume FromCubicYards(double value) => new() { BaseValue = value / CubicYards };
	public static Volume FromCubicMiles(double value) => new() { BaseValue = value / CubicMiles };
	public static Volume FromGigaliters(double value) => new() { BaseValue = value / Gigaliters };
	public static Volume FromKiloliters(double value) => new() { BaseValue = value / Kiloliters };
	public static Volume FromHectoliters(double value) => new() { BaseValue = value / Hectoliters };
	public static Volume FromDecaliters(double value) => new() { BaseValue = value / Decaliters };
	public static Volume FromLiters(double value) => new() { BaseValue = value / Liters };
	public static Volume FromDeciliters(double value) => new() { BaseValue = value / Deciliters };
	public static Volume FromCentiliters(double value) => new() { BaseValue = value / Centiliters };
	public static Volume FromMilliliters(double value) => new() { BaseValue = value / Milliliters };
	public static Volume FromGallons(double value) => new() { BaseValue = value / Gallons };
	public static Volume FromQuarts(double value) => new() { BaseValue = value / Quarts };
	public static Volume FromPints(double value) => new() { BaseValue = value / Pints };
	public static Volume FromCups(double value) => new() { BaseValue = value / Cups };
	public static Volume FromFluidOunces(double value) => new() { BaseValue = value / FluidOunces };
	public static Volume FromTablespoons(double value) => new() { BaseValue = value / Tablespoons };
	public static Volume FromTeaspoons(double value) => new() { BaseValue = value / Teaspoons };
	public double ToCubicKilometers() => BaseValue * CubicKilometers;
	public double ToCubicMeters() => BaseValue * CubicMeters;
	public double ToCubicCentimeters() => BaseValue * CubicCentimeters;
	public double ToCubicMillimeters() => BaseValue * CubicMillimeters;
	public double ToCubicFeet() => BaseValue * CubicFeet;
	public double ToCubicInches() => BaseValue * CubicInches;
	public double ToCubicYards() => BaseValue * CubicYards;
	public double ToCubicMiles() => BaseValue * CubicMiles;
	public double ToGigaliters() => BaseValue * Gigaliters;
	public double ToKiloliters() => BaseValue * Kiloliters;
	public double ToHectoliters() => BaseValue * Hectoliters;
	public double ToDecaliters() => BaseValue * Decaliters;
	public double ToLiters() => BaseValue * Liters;
	public double ToDeciliters() => BaseValue * Deciliters;
	public double ToCentiliters() => BaseValue * Centiliters;
	public double ToMilliliters() => BaseValue * Milliliters;
	public double ToGallons() => BaseValue * Gallons;
	public double ToQuarts() => BaseValue * Quarts;
	public double ToPints() => BaseValue * Pints;
	public double ToCups() => BaseValue * Cups;
	public double ToFluidOunces() => BaseValue * FluidOunces;
	public double ToTablespoons() => BaseValue * Tablespoons;
	public double ToTeaspoons() => BaseValue * Teaspoons;
}

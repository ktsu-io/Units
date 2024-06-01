#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Centimeters = Single;
using Feet = Single;
using Inches = Single;
using Kilometers = Single;
using Meters = Single;
using Miles = Single;
using Millimeters = Single;
using Yards = Single;

public static class LinearDistance
{
	public const Millimeters MillimetersPerCentimeter = 10;
	public const Millimeters MillimetersPerMeter = 1000;
	public const Millimeters MillimetersPerKilometer = 1000000;

	public const Centimeters CentimetersPerMillimeter = 1 / 10;
	public const Centimeters CentimetersPerMeter = 100;
	public const Centimeters CentimetersPerKilometer = 100000;

	public const Meters MetersPerMillimeter = 1 / 1000;
	public const Meters MetersPerCentimeter = 1 / 100;
	public const Meters MetersPerKilometer = 1000;

	public const Kilometers KilometersPerMillimeter = 1 / 1000000;
	public const Kilometers KilometersPerCentimeter = 1 / 100000;
	public const Kilometers KilometersPerMeter = 1 / 1000;

	public const Inches InchesPerFoot = 12;
	public const Inches InchesPerYard = 36;
	public const Inches InchesPerMile = 63360;

	public const Feet FeetPerInch = 1 / 12;
	public const Feet FeetPerYard = 3;
	public const Feet FeetPerMile = 5280;

	public const Yards YardsPerInch = 1 / 36;
	public const Yards YardsPerFoot = 1 / 3;
	public const Yards YardsPerMile = 1760;

	public const Miles MilesPerInch = 1 / 63360;
	public const Miles MilesPerFoot = 1 / 5280;
	public const Miles MilesPerYard = 1 / 1760;

	public const Millimeters MillimetersPerInch = 25.4f;
	public const Millimeters MillimetersPerFoot = 304.8f;
	public const Millimeters MillimetersPerYard = 914.4f;
	public const Millimeters MillimetersPerMile = 1609344f;

	public const Centimeters CentimetersPerInch = 2.54f;
	public const Centimeters CentimetersPerFoot = 30.48f;
	public const Centimeters CentimetersPerYard = 91.44f;
	public const Centimeters CentimetersPerMile = 160934.4f;

	public const Meters MetersPerInch = 0.0254f;
	public const Meters MetersPerFoot = 0.3048f;
	public const Meters MetersPerYard = 0.9144f;
	public const Meters MetersPerMile = 1609.344f;

	public const Kilometers KilometersPerInch = 0.0000254f;
	public const Kilometers KilometersPerFoot = 0.0003048f;
	public const Kilometers KilometersPerYard = 0.0009144f;
	public const Kilometers KilometersPerMile = 1.609344f;

	public const Inches InchesPerMillimeter = 1 / 25.4f;
	public const Inches InchesPerCentimeter = 1 / 2.54f;
	public const Inches InchesPerKilometer = 1 / 1609344f;

	public const Feet FeetPerMillimeter = 1 / 304.8f;
	public const Feet FeetPerCentimeter = 1 / 30.48f;
	public const Feet FeetPerKilometer = 1 / 160934.4f;

	public const Yards YardsPerMillimeter = 1 / 914.4f;
	public const Yards YardsPerCentimeter = 1 / 91.44f;
	public const Yards YardsPerKilometer = 1 / 160934.4f;

	public const Miles MilesPerMillimeter = 1 / 1609344f;
	public const Miles MilesPerCentimeter = 1 / 160934.4f;
	public const Miles MilesPerMeter = 1 / 1609.344f;

	public static Inches MillimetersToInches(Millimeters millimeters) => millimeters * 0.039370078740157f;
	public static Millimeters InchesToMillimeters(Inches inches) => inches * 25.4f;
	public static Feet MillimetersToFeet(Millimeters millimeters) => millimeters * 0.0032808398950131f;
	public static Millimeters FeetToMillimeters(Feet feet) => feet * 304.8f;
	public static Yards MillimetersToYards(Millimeters millimeters) => millimeters * 0.0010936132983377f;
	public static Millimeters YardsToMillimeters(Yards yards) => yards * 914.4f;
	public static Miles MillimetersToMiles(Millimeters millimeters) => millimeters * 0.00000062137119223733f;
	public static Millimeters MilesToMillimeters(Miles miles) => miles * 1609344f;
	public static Kilometers MillimetersToKilometers(Millimeters millimeters) => millimeters * 0.000001f;
	public static Millimeters KilometersToMillimeters(Kilometers kilometers) => kilometers * 1000000f;
	public static Inches CentimetersToInches(Centimeters centimeters) => centimeters * 0.39370078740157f;
	public static Centimeters InchesToCentimeters(Inches inches) => inches * 2.54f;
	public static Feet CentimetersToFeet(Centimeters centimeters) => centimeters * 0.032808398950131f;
	public static Centimeters FeetToCentimeters(Feet feet) => feet * 30.48f;
	public static Yards CentimetersToYards(Centimeters centimeters) => centimeters * 0.010936132983377f;
	public static Centimeters YardsToCentimeters(Yards yards) => yards * 91.44f;
	public static Miles CentimetersToMiles(Centimeters centimeters) => centimeters * 0.0000062137119223733f;
	public static Centimeters MilesToCentimeters(Miles miles) => miles * 160934.4f;
	public static Kilometers CentimetersToKilometers(Centimeters centimeters) => centimeters * 0.00001f;
	public static Centimeters KilometersToCentimeters(Kilometers kilometers) => kilometers * 100000f;
	public static Inches MetersToInches(Meters meters) => meters * 39.370078740157f;
	public static Meters InchesToMeters(Inches inches) => inches * 0.0254f;
	public static Feet MetersToFeet(Meters meters) => meters * 3.2808398950131f;
	public static Meters FeetToMeters(Feet feet) => feet * 0.3048f;
	public static Yards MetersToYards(Meters meters) => meters * 1.0936132983377f;
	public static Meters YardsToMeters(Yards yards) => yards * 0.9144f;
	public static Miles MetersToMiles(Meters meters) => meters * 0.00062137119223733f;
	public static Meters MilesToMeters(Miles miles) => miles * 1609.344f;
	public static Kilometers MetersToKilometers(Meters meters) => meters * 0.001f;
	public static Meters KilometersToMeters(Kilometers kilometers) => kilometers * 1000f;
	public static Inches KilometersToInches(Kilometers kilometers) => kilometers * 39370.078740157f;
	public static Kilometers InchesToKilometers(Inches inches) => inches * 0.0000254f;
	public static Feet KilometersToFeet(Kilometers kilometers) => kilometers * 3280.8398950131f;
	public static Kilometers FeetToKilometers(Feet feet) => feet * 0.0003048f;
	public static Yards KilometersToYards(Kilometers kilometers) => kilometers * 1093.6132983377f;
	public static Kilometers YardsToKilometers(Yards yards) => yards * 0.0009144f;
	public static Miles KilometersToMiles(Kilometers kilometers) => kilometers * 0.62137119223733f;
	public static Kilometers MilesToKilometers(Miles miles) => miles * 1.609344f;
	public static Inches MilesToInches(Miles miles) => miles * 63360f;
	public static Miles InchesToMiles(Inches inches) => inches * 0.000015782828282828f;
	public static Feet MilesToFeet(Miles miles) => miles * 5280f;
	public static Miles FeetToMiles(Feet feet) => feet * 0.00018939393939394f;
	public static Yards MilesToYards(Miles miles) => miles * 1760f;
	public static Miles YardsToMiles(Yards yards) => yards * 0.00056818181818182f;
	public static Inches FeetToInches(Feet feet) => feet * 12f;
	public static Feet InchesToFeet(Inches inches) => inches * 0.083333333333333f;
	public static Yards FeetToYards(Feet feet) => feet * 0.33333333333333f;
	public static Feet YardsToFeet(Yards yards) => yards * 3f;
}

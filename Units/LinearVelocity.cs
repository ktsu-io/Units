#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using FeetPerSecond = Double;
using KilometersPerHour = Double;
using MetersPerSecond = Double;
using MilesPerHour = Double;

public static class LinearVelocity
{
	public static MetersPerSecond KilometersPerHourToMetersPerSecond(KilometersPerHour kilometersPerHour) => kilometersPerHour * 1000 / 3600;

	public static KilometersPerHour MetersPerSecondToKilometersPerHour(MetersPerSecond metersPerSecond) => metersPerSecond * 3600 / 1000;

	public static MetersPerSecond MilesPerHourToMetersPerSecond(MilesPerHour milesPerHour) => milesPerHour * 1609.344 / 3600;

	public static MilesPerHour MetersPerSecondToMilesPerHour(MetersPerSecond metersPerSecond) => metersPerSecond * 3600 / 1609.344;

	public static MetersPerSecond FeetPerSecondToMetersPerSecond(FeetPerSecond feetPerSecond) => feetPerSecond * 0.3048;

	public static FeetPerSecond MetersPerSecondToFeetPerSecond(MetersPerSecond metersPerSecond) => metersPerSecond / 0.3048;

	public static FeetPerSecond MilesPerHourToFeetPerSecond(MilesPerHour milesPerHour) => milesPerHour * 5280 / 3600;

	public static MilesPerHour FeetPerSecondToMilesPerHour(FeetPerSecond feetPerSecond) => feetPerSecond * 3600 / 5280;

	public static KilometersPerHour MilesPerHourToKilometersPerHour(MilesPerHour milesPerHour) => milesPerHour * 1.609344;

	public static MilesPerHour KilometersPerHourToMilesPerHour(KilometersPerHour kilometersPerHour) => kilometersPerHour / 1.609344;
}

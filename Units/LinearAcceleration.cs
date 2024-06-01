#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using FeetPerSecondSquared = Double;
using KilometersPerHourPerSecond = Double;
using MetersPerSecondSquared = Double;
using MilesPerHourPerSecond = Double;

public static class LinearAcceleration
{
	public static MetersPerSecondSquared KilometersPerHourPerSecondToMetersPerSecondSquared(KilometersPerHourPerSecond kilometersPerHourPerSecond) => kilometersPerHourPerSecond * 1000 / 3600;

	public static KilometersPerHourPerSecond MetersPerSecondSquaredToKilometersPerHourPerSecond(MetersPerSecondSquared metersPerSecondSquared) => metersPerSecondSquared * 3600 / 1000;

	public static MetersPerSecondSquared MilesPerHourPerSecondToMetersPerSecondSquared(MilesPerHourPerSecond milesPerHourPerSecond) => milesPerHourPerSecond * 1609.344 / 3600;

	public static MilesPerHourPerSecond MetersPerSecondSquaredToMilesPerHourPerSecond(MetersPerSecondSquared metersPerSecondSquared) => metersPerSecondSquared * 3600 / 1609.344;

	public static MetersPerSecondSquared FeetPerSecondSquaredToMetersPerSecondSquared(FeetPerSecondSquared feetPerSecondSquared) => feetPerSecondSquared * 0.3048;

	public static FeetPerSecondSquared MetersPerSecondSquaredToFeetPerSecondSquared(MetersPerSecondSquared metersPerSecondSquared) => metersPerSecondSquared / 0.3048;

	public static FeetPerSecondSquared MilesPerHourPerSecondToFeetPerSecondSquared(MilesPerHourPerSecond milesPerHourPerSecond) => milesPerHourPerSecond * 5280 / 3600;

	public static MilesPerHourPerSecond FeetPerSecondSquaredToMilesPerHourPerSecond(FeetPerSecondSquared feetPerSecondSquared) => feetPerSecondSquared * 3600 / 5280;

	public static KilometersPerHourPerSecond MilesPerHourPerSecondToKilometersPerHourPerSecond(MilesPerHourPerSecond milesPerHourPerSecond) => milesPerHourPerSecond * 1.609344;

	public static MilesPerHourPerSecond KilometersPerHourPerSecondToMilesPerHourPerSecond(KilometersPerHourPerSecond kilometersPerHourPerSecond) => kilometersPerHourPerSecond / 1.609344;
}

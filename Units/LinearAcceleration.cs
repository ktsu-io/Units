#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using FeetPerSecondSquared = Single;
using KilometersPerHourPerSecond = Single;
using MetersPerSecondSquared = Single;
using MilesPerHourPerSecond = Single;

public static class LinearAcceleration
{
	public static MetersPerSecondSquared KilometersPerHourPerSecondToMetersPerSecondSquared(KilometersPerHourPerSecond kilometersPerHourPerSecond) => kilometersPerHourPerSecond * 1000f / 3600f;

	public static KilometersPerHourPerSecond MetersPerSecondSquaredToKilometersPerHourPerSecond(MetersPerSecondSquared metersPerSecondSquared) => metersPerSecondSquared * 3600f / 1000f;

	public static MetersPerSecondSquared MilesPerHourPerSecondToMetersPerSecondSquared(MilesPerHourPerSecond milesPerHourPerSecond) => milesPerHourPerSecond * 1609.344f / 3600f;

	public static MilesPerHourPerSecond MetersPerSecondSquaredToMilesPerHourPerSecond(MetersPerSecondSquared metersPerSecondSquared) => metersPerSecondSquared * 3600f / 1609.344f;

	public static MetersPerSecondSquared FeetPerSecondSquaredToMetersPerSecondSquared(FeetPerSecondSquared feetPerSecondSquared) => feetPerSecondSquared * 0.3048f;

	public static FeetPerSecondSquared MetersPerSecondSquaredToFeetPerSecondSquared(MetersPerSecondSquared metersPerSecondSquared) => metersPerSecondSquared / 0.3048f;

	public static FeetPerSecondSquared MilesPerHourPerSecondToFeetPerSecondSquared(MilesPerHourPerSecond milesPerHourPerSecond) => milesPerHourPerSecond * 5280f / 3600f;

	public static MilesPerHourPerSecond FeetPerSecondSquaredToMilesPerHourPerSecond(FeetPerSecondSquared feetPerSecondSquared) => feetPerSecondSquared * 3600f / 5280f;

	public static KilometersPerHourPerSecond MilesPerHourPerSecondToKilometersPerHourPerSecond(MilesPerHourPerSecond milesPerHourPerSecond) => milesPerHourPerSecond * 1.609344f;

	public static MilesPerHourPerSecond KilometersPerHourPerSecondToMilesPerHourPerSecond(KilometersPerHourPerSecond kilometersPerHourPerSecond) => kilometersPerHourPerSecond / 1.609344f;
}

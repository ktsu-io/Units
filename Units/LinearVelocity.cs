#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using FeetPerSecond = Single;
using KilometersPerHour = Single;
using MetersPerSecond = Single;
using MilesPerHour = Single;

public static class LinearVelocity
{
	public static MetersPerSecond KilometersPerHourToMetersPerSecond(KilometersPerHour kilometersPerHour) => kilometersPerHour * 1000f / 3600f;

	public static KilometersPerHour MetersPerSecondToKilometersPerHour(MetersPerSecond metersPerSecond) => metersPerSecond * 3600f / 1000f;

	public static MetersPerSecond MilesPerHourToMetersPerSecond(MilesPerHour milesPerHour) => milesPerHour * 1609.344f / 3600f;

	public static MilesPerHour MetersPerSecondToMilesPerHour(MetersPerSecond metersPerSecond) => metersPerSecond * 3600f / 1609.344f;

	public static MetersPerSecond FeetPerSecondToMetersPerSecond(FeetPerSecond feetPerSecond) => feetPerSecond * 0.3048f;

	public static FeetPerSecond MetersPerSecondToFeetPerSecond(MetersPerSecond metersPerSecond) => metersPerSecond / 0.3048f;

	public static FeetPerSecond MilesPerHourToFeetPerSecond(MilesPerHour milesPerHour) => milesPerHour * 5280f / 3600f;

	public static MilesPerHour FeetPerSecondToMilesPerHour(FeetPerSecond feetPerSecond) => feetPerSecond * 3600f / 5280f;

	public static KilometersPerHour MilesPerHourToKilometersPerHour(MilesPerHour milesPerHour) => milesPerHour * 1.609344f;

	public static MilesPerHour KilometersPerHourToMilesPerHour(KilometersPerHour kilometersPerHour) => kilometersPerHour / 1.609344f;
}

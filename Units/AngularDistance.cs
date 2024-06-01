#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Degrees = Single;
using Radians = Single;

public static class AngularDistance
{
	public const Radians RadiansPerDegree = MathF.PI / 180;
	public const Degrees DegreesPerRadian = 180 / MathF.PI;

	public const Degrees DegreesPerCircle = 360;
	public const Radians RadiansPerCircle = MathF.PI * 2;

	public const Degrees DegreesPerHalfCircle = 180;
	public const Radians RadiansPerHalfCircle = MathF.PI;

	public const Degrees DegreesPerQuarterCircle = 90;
	public const Radians RadiansPerQuarterCircle = MathF.PI / 2;

	public static Degrees RadiansToDegrees(Radians radians) => radians * DegreesPerRadian;
	public static Radians DegreesToRadians(Degrees degrees) => degrees * RadiansPerDegree;

	public static Degrees NormalizeDegrees(Degrees degrees)
	{
		degrees %= DegreesPerCircle;
		if (degrees < 0)
		{
			degrees += DegreesPerCircle;
		}

		return degrees;
	}

	public static Radians NormalizeRadians(Radians radians)
	{
		radians %= RadiansPerCircle;
		if (radians < 0)
		{
			radians += RadiansPerCircle;
		}

		return radians;
	}

	public static Degrees DegreesBetween(Degrees start, Degrees end)
	{
		Degrees distance = end - start;
		return NormalizeDegrees(distance);
	}

	public static Radians RadiansBetween(Radians start, Radians end)
	{
		Radians distance = end - start;
		return NormalizeRadians(distance);
	}

	public static Degrees ShortestDegreesBetween(Degrees start, Degrees end)
	{
		Degrees distance = DegreesBetween(start, end);
		if (distance > DegreesPerHalfCircle)
		{
			distance -= DegreesPerCircle;
		}

		return distance;
	}

	public static Radians ShortestRadiansBetween(Radians start, Radians end)
	{
		Radians distance = RadiansBetween(start, end);
		if (distance > RadiansPerHalfCircle)
		{
			distance -= RadiansPerCircle;
		}

		return distance;
	}
}

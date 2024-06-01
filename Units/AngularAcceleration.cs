#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using DegreesPerSecondSquared = Double;
using RadiansPerSecondSquared = Double;

public static class AngularAcceleration
{
	public static RadiansPerSecondSquared DegreesPerSecondSquaredToRadiansPerSecondSquared(DegreesPerSecondSquared degreesPerSecondSquared) => degreesPerSecondSquared * 0.01745329251994329576923690768489;
	public static DegreesPerSecondSquared RadiansPerSecondSquaredToDegreesPerSecondSquared(RadiansPerSecondSquared radiansPerSecondSquared) => radiansPerSecondSquared / 0.01745329251994329576923690768489;
}

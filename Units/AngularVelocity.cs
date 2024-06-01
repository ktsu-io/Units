#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using RadiansPerSecond = Double;
using RevolutionsPerMinute = Double;

public static class AngularVelocity
{
	public static RadiansPerSecond RevolutionsPerMinuteToRadiansPerSecond(RevolutionsPerMinute rpm) => rpm * 0.10471975513824;
	public static RevolutionsPerMinute RadiansPerSecondToRevolutionsPerMinute(RadiansPerSecond rads) => rads / 0.10471975513824;
}

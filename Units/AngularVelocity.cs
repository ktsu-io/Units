#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using RadiansPerSecond = Single;
using RevolutionsPerMinute = Single;

public static class AngularVelocity
{
	public static RadiansPerSecond RevolutionsPerMinuteToRadiansPerSecond(RevolutionsPerMinute rpm) => rpm * 0.10471975513824f;
	public static RevolutionsPerMinute RadiansPerSecondToRevolutionsPerMinute(RadiansPerSecond rads) => rads / 0.10471975513824f;
}

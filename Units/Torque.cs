#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using FootPounds = Double;
using NewtonMeters = Double;

public static class Torque
{
	public static NewtonMeters FootPoundsToNewtonMeters(FootPounds footPounds) => footPounds * 1.3558179483314004;
	public static FootPounds NewtonMetersToFootPounds(NewtonMeters newtonMeters) => newtonMeters / 1.3558179483314004;
}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Newtons = Single;
using PoundsForce = Single;

public static class Force
{
	public static Newtons PoundsForceToNewtons(PoundsForce poundsForce) => poundsForce * 4.4482216152605f;
	public static PoundsForce NewtonsToPoundsForce(Newtons newtons) => newtons / 4.4482216152605f;
}

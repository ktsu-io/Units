#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Newtons = Double;
using PoundsForce = Double;

public static class Force
{
	public static Newtons PoundsForceToNewtons(PoundsForce poundsForce) => poundsForce * 4.4482216152605;
	public static PoundsForce NewtonsToPoundsForce(Newtons newtons) => newtons / 4.4482216152605;
}

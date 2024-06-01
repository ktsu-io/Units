#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Pascals = Single;
using PoundsPerSquareInch = Single;

public static class Pressure
{
	public static Pascals PoundsPerSquareInchToPascals(PoundsPerSquareInch psi) => psi * 6894.757f;
	public static PoundsPerSquareInch PascalsToPoundsPerSquareInch(Pascals pascals) => pascals / 6894.757f;
}

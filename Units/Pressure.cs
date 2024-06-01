#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Pascals = Double;
using PoundsPerSquareInch = Double;

public static class Pressure
{
	public static Pascals PoundsPerSquareInchToPascals(PoundsPerSquareInch psi) => psi * 6894.757;
	public static PoundsPerSquareInch PascalsToPoundsPerSquareInch(Pascals pascals) => pascals / 6894.757;
}

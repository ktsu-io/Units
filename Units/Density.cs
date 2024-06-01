#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using KilogramsPerMeterCubed = Double;
using PoundsPerFootCubed = Double;

public static class Density
{
	public static KilogramsPerMeterCubed PoundsPerFootCubedToKilogramsPerMeterCubed(PoundsPerFootCubed poundsPerFootCubed) => poundsPerFootCubed * 16.0184633739609;
	public static PoundsPerFootCubed KilogramsPerMeterCubedToPoundsPerFootCubed(KilogramsPerMeterCubed kilogramsPerMeterCubed) => kilogramsPerMeterCubed / 16.0184633739609;
}

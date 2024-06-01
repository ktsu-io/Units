#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Horsepower = Single;
using Kilowatts = Single;
using Watts = Single;

public static class Power
{
	public static Watts KilowattsToWatts(Kilowatts kilowatts) => kilowatts * 1000f;
	public static Kilowatts WattsToKilowatts(Watts watts) => watts / 1000f;

	public static Watts HorsepowerToWatts(Horsepower horsepower) => horsepower * 745.69987158227022f;
	public static Horsepower WattsToHorsepower(Watts watts) => watts / 745.69987158227022f;

	public static Kilowatts HorsepowerToKilowatts(Horsepower horsepower) => horsepower * 0.74569987158227022f;
	public static Horsepower KilowattsToHorsepower(Kilowatts kilowatts) => kilowatts / 0.74569987158227022f;
}

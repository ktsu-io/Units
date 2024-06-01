#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using CentimetersSquared = Double;
using FeetSquared = Double;
using InchesSquared = Double;
using KilometersSquared = Double;
using MetersSquared = Double;
using MilesSquared = Double;
using MillimetersSquared = Double;
using YardsSquared = Double;

public static class Area
{
	public static MetersSquared MillimetersSquaredToMetersSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 1000000;
	public static MillimetersSquared MetersSquaredToMillimetersSquared(MetersSquared metersSquared) => metersSquared * 1000000;
	public static MetersSquared CentimetersSquaredToMetersSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 10000;
	public static CentimetersSquared MetersSquaredToCentimetersSquared(MetersSquared metersSquared) => metersSquared * 10000;
	public static MetersSquared KilometersSquaredToMetersSquared(KilometersSquared kilometersSquared) => kilometersSquared * 1000000;
	public static KilometersSquared MetersSquaredToKilometersSquared(MetersSquared metersSquared) => metersSquared / 1000000;
	public static MetersSquared InchesSquaredToMetersSquared(InchesSquared inchesSquared) => inchesSquared * 0.00064516;
	public static InchesSquared MetersSquaredToInchesSquared(MetersSquared metersSquared) => metersSquared / 0.00064516;
	public static MetersSquared FeetSquaredToMetersSquared(FeetSquared feetSquared) => feetSquared * 0.09290304;
	public static FeetSquared MetersSquaredToFeetSquared(MetersSquared metersSquared) => metersSquared / 0.09290304;
	public static MetersSquared YardsSquaredToMetersSquared(YardsSquared yardsSquared) => yardsSquared * 0.83612736;
	public static YardsSquared MetersSquaredToYardsSquared(MetersSquared metersSquared) => metersSquared / 0.83612736;
	public static MetersSquared MilesSquaredToMetersSquared(MilesSquared milesSquared) => milesSquared * 2589988.110336;
	public static MilesSquared MetersSquaredToMilesSquared(MetersSquared metersSquared) => metersSquared / 2589988.110336;
	public static CentimetersSquared MillimetersSquaredToCentimetersSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 100;
	public static MillimetersSquared CentimetersSquaredToMillimetersSquared(CentimetersSquared centimetersSquared) => centimetersSquared * 100;
	public static CentimetersSquared KilometersSquaredToCentimetersSquared(KilometersSquared kilometersSquared) => kilometersSquared * 10000000000;
	public static KilometersSquared CentimetersSquaredToKilometersSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 10000000000;
	public static CentimetersSquared InchesSquaredToCentimetersSquared(InchesSquared inchesSquared) => inchesSquared * 6.4516;
	public static InchesSquared CentimetersSquaredToInchesSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 6.4516;
	public static CentimetersSquared FeetSquaredToCentimetersSquared(FeetSquared feetSquared) => feetSquared * 929.0304;
	public static FeetSquared CentimetersSquaredToFeetSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 929.0304;
	public static CentimetersSquared YardsSquaredToCentimetersSquared(YardsSquared yardsSquared) => yardsSquared * 8361.2736;
	public static YardsSquared CentimetersSquaredToYardsSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 8361.2736;
	public static CentimetersSquared MilesSquaredToCentimetersSquared(MilesSquared milesSquared) => milesSquared * 25899881103.36;
	public static MilesSquared CentimetersSquaredToMilesSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 25899881103.36;
	public static MillimetersSquared KilometersSquaredToMillimetersSquared(KilometersSquared kilometersSquared) => kilometersSquared * 1000000000000;
	public static KilometersSquared MillimetersSquaredToKilometersSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 1000000000000;
	public static MillimetersSquared InchesSquaredToMillimetersSquared(InchesSquared inchesSquared) => inchesSquared * 645.16;
	public static InchesSquared MillimetersSquaredToInchesSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 645.16;
	public static MillimetersSquared FeetSquaredToMillimetersSquared(FeetSquared feetSquared) => feetSquared * 92903.04;
	public static FeetSquared MillimetersSquaredToFeetSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 92903.04;
	public static MillimetersSquared YardsSquaredToMillimetersSquared(YardsSquared yardsSquared) => yardsSquared * 836127.36;
	public static YardsSquared MillimetersSquaredToYardsSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 836127.36;
	public static MillimetersSquared MilesSquaredToMillimetersSquared(MilesSquared milesSquared) => milesSquared * 2589988110336;
	public static MilesSquared MillimetersSquaredToMilesSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 2589988110336;
	public static InchesSquared KilometersSquaredToInchesSquared(KilometersSquared kilometersSquared) => kilometersSquared * 1550003100.0062;
	public static KilometersSquared InchesSquaredToKilometersSquared(InchesSquared inchesSquared) => inchesSquared / 1550003100.0062;
}

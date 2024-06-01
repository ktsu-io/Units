#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using CentimetersSquared = Single;
using FeetSquared = Single;
using InchesSquared = Single;
using KilometersSquared = Single;
using MetersSquared = Single;
using MilesSquared = Single;
using MillimetersSquared = Single;
using YardsSquared = Single;

public static class Area
{
	public static MetersSquared MillimetersSquaredToMetersSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 1000000f;
	public static MillimetersSquared MetersSquaredToMillimetersSquared(MetersSquared metersSquared) => metersSquared * 1000000f;
	public static MetersSquared CentimetersSquaredToMetersSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 10000f;
	public static CentimetersSquared MetersSquaredToCentimetersSquared(MetersSquared metersSquared) => metersSquared * 10000f;
	public static MetersSquared KilometersSquaredToMetersSquared(KilometersSquared kilometersSquared) => kilometersSquared * 1000000f;
	public static KilometersSquared MetersSquaredToKilometersSquared(MetersSquared metersSquared) => metersSquared / 1000000f;
	public static MetersSquared InchesSquaredToMetersSquared(InchesSquared inchesSquared) => inchesSquared * 0.00064516f;
	public static InchesSquared MetersSquaredToInchesSquared(MetersSquared metersSquared) => metersSquared / 0.00064516f;
	public static MetersSquared FeetSquaredToMetersSquared(FeetSquared feetSquared) => feetSquared * 0.09290304f;
	public static FeetSquared MetersSquaredToFeetSquared(MetersSquared metersSquared) => metersSquared / 0.09290304f;
	public static MetersSquared YardsSquaredToMetersSquared(YardsSquared yardsSquared) => yardsSquared * 0.83612736f;
	public static YardsSquared MetersSquaredToYardsSquared(MetersSquared metersSquared) => metersSquared / 0.83612736f;
	public static MetersSquared MilesSquaredToMetersSquared(MilesSquared milesSquared) => milesSquared * 2589988.110336f;
	public static MilesSquared MetersSquaredToMilesSquared(MetersSquared metersSquared) => metersSquared / 2589988.110336f;
	public static CentimetersSquared MillimetersSquaredToCentimetersSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 100f;
	public static MillimetersSquared CentimetersSquaredToMillimetersSquared(CentimetersSquared centimetersSquared) => centimetersSquared * 100f;
	public static CentimetersSquared KilometersSquaredToCentimetersSquared(KilometersSquared kilometersSquared) => kilometersSquared * 10000000000f;
	public static KilometersSquared CentimetersSquaredToKilometersSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 10000000000f;
	public static CentimetersSquared InchesSquaredToCentimetersSquared(InchesSquared inchesSquared) => inchesSquared * 6.4516f;
	public static InchesSquared CentimetersSquaredToInchesSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 6.4516f;
	public static CentimetersSquared FeetSquaredToCentimetersSquared(FeetSquared feetSquared) => feetSquared * 929.0304f;
	public static FeetSquared CentimetersSquaredToFeetSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 929.0304f;
	public static CentimetersSquared YardsSquaredToCentimetersSquared(YardsSquared yardsSquared) => yardsSquared * 8361.2736f;
	public static YardsSquared CentimetersSquaredToYardsSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 8361.2736f;
	public static CentimetersSquared MilesSquaredToCentimetersSquared(MilesSquared milesSquared) => milesSquared * 25899881103.36f;
	public static MilesSquared CentimetersSquaredToMilesSquared(CentimetersSquared centimetersSquared) => centimetersSquared / 25899881103.36f;
	public static MillimetersSquared KilometersSquaredToMillimetersSquared(KilometersSquared kilometersSquared) => kilometersSquared * 1000000000000f;
	public static KilometersSquared MillimetersSquaredToKilometersSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 1000000000000f;
	public static MillimetersSquared InchesSquaredToMillimetersSquared(InchesSquared inchesSquared) => inchesSquared * 645.16f;
	public static InchesSquared MillimetersSquaredToInchesSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 645.16f;
	public static MillimetersSquared FeetSquaredToMillimetersSquared(FeetSquared feetSquared) => feetSquared * 92903.04f;
	public static FeetSquared MillimetersSquaredToFeetSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 92903.04f;
	public static MillimetersSquared YardsSquaredToMillimetersSquared(YardsSquared yardsSquared) => yardsSquared * 836127.36f;
	public static YardsSquared MillimetersSquaredToYardsSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 836127.36f;
	public static MillimetersSquared MilesSquaredToMillimetersSquared(MilesSquared milesSquared) => milesSquared * 2589988110336f;
	public static MilesSquared MillimetersSquaredToMilesSquared(MillimetersSquared millimetersSquared) => millimetersSquared / 2589988110336f;
	public static InchesSquared KilometersSquaredToInchesSquared(KilometersSquared kilometersSquared) => kilometersSquared * 1550003100.0062f;
	public static KilometersSquared InchesSquaredToKilometersSquared(InchesSquared inchesSquared) => inchesSquared / 1550003100.0062f;
}

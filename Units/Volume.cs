#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using CentimetersCubed = Double;
using FeetCubed = Double;
using InchesCubed = Double;
using MetersCubed = Double;
using MillimetersCubed = Double;
using YardsCubed = Double;

public static class Volume
{
	public static MillimetersCubed CentimetersCubedToMillimetersCubed(CentimetersCubed centimetersCubed) => centimetersCubed * 1000;
	public static CentimetersCubed MillimetersCubedToCentimetersCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 1000;
	public static MillimetersCubed MetersCubedToMillimetersCubed(MetersCubed metersCubed) => metersCubed * 1000000;
	public static MetersCubed MillimetersCubedToMetersCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 1000000;
	public static CentimetersCubed MetersCubedToCentimetersCubed(MetersCubed metersCubed) => metersCubed * 1000000;
	public static MetersCubed CentimetersCubedToMetersCubed(CentimetersCubed centimetersCubed) => centimetersCubed / 1000000;
	public static InchesCubed FeetCubedToInchesCubed(FeetCubed feetCubed) => feetCubed * 1728;
	public static FeetCubed InchesCubedToFeetCubed(InchesCubed inchesCubed) => inchesCubed / 1728;
	public static InchesCubed YardsCubedToInchesCubed(YardsCubed yardsCubed) => yardsCubed * 46656;
	public static YardsCubed InchesCubedToYardsCubed(InchesCubed inchesCubed) => inchesCubed / 46656;
	public static FeetCubed YardsCubedToFeetCubed(YardsCubed yardsCubed) => yardsCubed * 27;
	public static YardsCubed FeetCubedToYardsCubed(FeetCubed feetCubed) => feetCubed / 27;
	public static FeetCubed MetersCubedToFeetCubed(MetersCubed metersCubed) => metersCubed * 35.31466672148859;
	public static MetersCubed FeetCubedToMetersCubed(FeetCubed feetCubed) => feetCubed / 35.31466672148859;
	public static InchesCubed CentimetersCubedToInchesCubed(CentimetersCubed centimetersCubed) => centimetersCubed / 16.387064;
	public static CentimetersCubed InchesCubedToCentimetersCubed(InchesCubed inchesCubed) => inchesCubed * 16.387064;
	public static InchesCubed MillimetersCubedToInchesCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 16387.064;
	public static MillimetersCubed InchesCubedToMillimetersCubed(InchesCubed inchesCubed) => inchesCubed * 16387.064;
	public static CentimetersCubed FeetCubedToCentimetersCubed(FeetCubed feetCubed) => feetCubed * 28316.846592;
	public static FeetCubed CentimetersCubedToFeetCubed(CentimetersCubed centimetersCubed) => centimetersCubed / 28316.846592;
	public static MillimetersCubed YardsCubedToMillimetersCubed(YardsCubed yardsCubed) => yardsCubed * 764554857.984;
	public static YardsCubed MillimetersCubedToYardsCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 764554857.984;
	public static CentimetersCubed YardsCubedToCentimetersCubed(YardsCubed yardsCubed) => yardsCubed * 764554.857984;
	public static YardsCubed CentimetersCubedToYardsCubed(CentimetersCubed centimetersCubed) => centimetersCubed / 764554.857984;
	public static MillimetersCubed FeetCubedToMillimetersCubed(FeetCubed feetCubed) => feetCubed * 28316846.592;
	public static FeetCubed MillimetersCubedToFeetCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 28316846.592;
	public static InchesCubed MetersCubedToInchesCubed(MetersCubed metersCubed) => metersCubed * 61023.74409473229;
	public static MetersCubed InchesCubedToMetersCubed(InchesCubed inchesCubed) => inchesCubed / 61023.74409473229;
}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using CentimetersCubed = Single;
using FeetCubed = Single;
using InchesCubed = Single;
using MetersCubed = Single;
using MillimetersCubed = Single;
using YardsCubed = Single;

public static class Volume
{
	public static MillimetersCubed CentimetersCubedToMillimetersCubed(CentimetersCubed centimetersCubed) => centimetersCubed * 1000f;
	public static CentimetersCubed MillimetersCubedToCentimetersCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 1000f;
	public static MillimetersCubed MetersCubedToMillimetersCubed(MetersCubed metersCubed) => metersCubed * 1000000f;
	public static MetersCubed MillimetersCubedToMetersCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 1000000f;
	public static CentimetersCubed MetersCubedToCentimetersCubed(MetersCubed metersCubed) => metersCubed * 1000000f;
	public static MetersCubed CentimetersCubedToMetersCubed(CentimetersCubed centimetersCubed) => centimetersCubed / 1000000f;
	public static InchesCubed FeetCubedToInchesCubed(FeetCubed feetCubed) => feetCubed * 1728f;
	public static FeetCubed InchesCubedToFeetCubed(InchesCubed inchesCubed) => inchesCubed / 1728f;
	public static InchesCubed YardsCubedToInchesCubed(YardsCubed yardsCubed) => yardsCubed * 46656f;
	public static YardsCubed InchesCubedToYardsCubed(InchesCubed inchesCubed) => inchesCubed / 46656f;
	public static FeetCubed YardsCubedToFeetCubed(YardsCubed yardsCubed) => yardsCubed * 27f;
	public static YardsCubed FeetCubedToYardsCubed(FeetCubed feetCubed) => feetCubed / 27f;
	public static FeetCubed MetersCubedToFeetCubed(MetersCubed metersCubed) => metersCubed * 35.31466672148859f;
	public static MetersCubed FeetCubedToMetersCubed(FeetCubed feetCubed) => feetCubed / 35.31466672148859f;
	public static InchesCubed CentimetersCubedToInchesCubed(CentimetersCubed centimetersCubed) => centimetersCubed / 16.387064f;
	public static CentimetersCubed InchesCubedToCentimetersCubed(InchesCubed inchesCubed) => inchesCubed * 16.387064f;
	public static InchesCubed MillimetersCubedToInchesCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 16387.064f;
	public static MillimetersCubed InchesCubedToMillimetersCubed(InchesCubed inchesCubed) => inchesCubed * 16387.064f;
	public static CentimetersCubed FeetCubedToCentimetersCubed(FeetCubed feetCubed) => feetCubed * 28316.846592f;
	public static FeetCubed CentimetersCubedToFeetCubed(CentimetersCubed centimetersCubed) => centimetersCubed / 28316.846592f;
	public static MillimetersCubed YardsCubedToMillimetersCubed(YardsCubed yardsCubed) => yardsCubed * 764554857.984f;
	public static YardsCubed MillimetersCubedToYardsCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 764554857.984f;
	public static CentimetersCubed YardsCubedToCentimetersCubed(YardsCubed yardsCubed) => yardsCubed * 764554.857984f;
	public static YardsCubed CentimetersCubedToYardsCubed(CentimetersCubed centimetersCubed) => centimetersCubed / 764554.857984f;
	public static MillimetersCubed FeetCubedToMillimetersCubed(FeetCubed feetCubed) => feetCubed * 28316846.592f;
	public static FeetCubed MillimetersCubedToFeetCubed(MillimetersCubed millimetersCubed) => millimetersCubed / 28316846.592f;
	public static InchesCubed MetersCubedToInchesCubed(MetersCubed metersCubed) => metersCubed * 61023.74409473229f;
	public static MetersCubed InchesCubedToMetersCubed(InchesCubed inchesCubed) => inchesCubed / 61023.74409473229f;
}

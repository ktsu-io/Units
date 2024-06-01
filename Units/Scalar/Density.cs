#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Density : Scalar<Density>
{
	private const double KilogramsPerCubicMeter = 1;
	private const double GramsPerCubicCentimeter = 1000;
	private const double PoundsPerCubicFoot = 16.018463373960924;
	private const double PoundsPerCubicInch = 27679.904710194;
	public static Density operator +(Density left, Density right) => Add(left, right);
	public static Density operator -(Density left, Density right) => Subtract(left, right);
	public static Density operator *(Density left, Density right) => Multiply(left, right);
	public static Density operator /(Density left, Density right) => Divide(left, right);
	public static bool operator <(Density left, Density right) => CompareTo(left, right) < 0;
	public static bool operator <=(Density left, Density right) => CompareTo(left, right) <= 0;
	public static bool operator >(Density left, Density right) => CompareTo(left, right) > 0;
	public static bool operator >=(Density left, Density right) => CompareTo(left, right) >= 0;
	public static Density FromKilogramsPerCubicMeter(double value) => new() { BaseValue = value / KilogramsPerCubicMeter };
	public static Density FromGramsPerCubicCentimeter(double value) => new() { BaseValue = value / GramsPerCubicCentimeter };
	public static Density FromPoundsPerCubicFoot(double value) => new() { BaseValue = value / PoundsPerCubicFoot };
	public static Density FromPoundsPerCubicInch(double value) => new() { BaseValue = value / PoundsPerCubicInch };
	public double ToKilogramsPerCubicMeter() => BaseValue * KilogramsPerCubicMeter;
	public double ToGramsPerCubicCentimeter() => BaseValue * GramsPerCubicCentimeter;
	public double ToPoundsPerCubicFoot() => BaseValue * PoundsPerCubicFoot;
	public double ToPoundsPerCubicInch() => BaseValue * PoundsPerCubicInch;
}

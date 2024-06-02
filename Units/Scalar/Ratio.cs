#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Ratio : Scalar<Ratio>
{
	public static Ratio operator +(Ratio left, Ratio right) => Add(left, right);
	public static Ratio operator -(Ratio left, Ratio right) => Subtract(left, right);
	public static Ratio operator *(Ratio left, Ratio right) => Multiply(left, right);
	public static Ratio operator /(Ratio left, Ratio right) => Divide(left, right);
	public static Ratio operator *(Ratio left, double right) => Multiply(left, right);
	public static Ratio operator /(Ratio left, double right) => Divide(left, right);
	public static bool operator <(Ratio left, Ratio right) => CompareTo(left, right) < 0;
	public static bool operator <=(Ratio left, Ratio right) => CompareTo(left, right) <= 0;
	public static bool operator >(Ratio left, Ratio right) => CompareTo(left, right) > 0;
	public static bool operator >=(Ratio left, Ratio right) => CompareTo(left, right) >= 0;
	public static Ratio FromDouble(double value) => new() { BaseValue = value };
	public double ToDouble() => BaseValue;
}

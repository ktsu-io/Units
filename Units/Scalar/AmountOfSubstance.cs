#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record AmountOfSubstance : Scalar<AmountOfSubstance>
{
	private const double Moles = 1;

	public static AmountOfSubstance operator +(AmountOfSubstance left, AmountOfSubstance right) => Add(left, right);
	public static AmountOfSubstance operator -(AmountOfSubstance left, AmountOfSubstance right) => Subtract(left, right);
	public static AmountOfSubstance operator *(AmountOfSubstance left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(AmountOfSubstance left, AmountOfSubstance right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static AmountOfSubstance operator *(AmountOfSubstance left, double right) => Multiply(left, right);
	public static AmountOfSubstance operator /(AmountOfSubstance left, double right) => Divide(left, right);
	public static bool operator <(AmountOfSubstance left, AmountOfSubstance right) => CompareTo(left, right) < 0;
	public static bool operator <=(AmountOfSubstance left, AmountOfSubstance right) => CompareTo(left, right) <= 0;
	public static bool operator >(AmountOfSubstance left, AmountOfSubstance right) => CompareTo(left, right) > 0;
	public static bool operator >=(AmountOfSubstance left, AmountOfSubstance right) => CompareTo(left, right) >= 0;
	public static AmountOfSubstance FromMoles(double value) => new() { BaseValue = value / Moles };
	public double ToMoles() => BaseValue * Moles;
}

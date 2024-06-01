#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Temperature : Scalar<Temperature>
{
	private const double Kelvin = 1;
	private const double CelsiusOffset = 273.15;
	private const double FahrenheitOffset = 459.67;
	private const double FahrenheitRatio = 5 / 9;
	public static Temperature operator +(Temperature left, Temperature right) => Add(left, right);
	public static Temperature operator -(Temperature left, Temperature right) => Subtract(left, right);
	public static Temperature operator *(Temperature left, Temperature right) => Multiply(left, right);
	public static Temperature operator /(Temperature left, Temperature right) => Divide(left, right);
	public static bool operator <(Temperature left, Temperature right) => CompareTo(left, right) < 0;
	public static bool operator <=(Temperature left, Temperature right) => CompareTo(left, right) <= 0;
	public static bool operator >(Temperature left, Temperature right) => CompareTo(left, right) > 0;
	public static bool operator >=(Temperature left, Temperature right) => CompareTo(left, right) >= 0;
	public static Temperature FromKelvin(double value) => new() { BaseValue = value / Kelvin };
	public static Temperature FromCelsius(double value) => new() { BaseValue = (value + CelsiusOffset) / Kelvin };
	public static Temperature FromFahrenheit(double value) => new() { BaseValue = (value + FahrenheitOffset) * FahrenheitRatio / Kelvin };
	public double ToKelvin() => BaseValue * Kelvin;
	public double ToCelsius() => (BaseValue * Kelvin) - CelsiusOffset;
	public double ToFahrenheit() => (BaseValue * Kelvin * (1 / FahrenheitRatio)) - FahrenheitOffset;
}

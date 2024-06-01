#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Celsius = Single;
using Fahrenheit = Single;
using Kelvin = Single;

public static class Temperature
{
	public static Celsius FahrenheitToCelsius(Fahrenheit fahrenheit) => (fahrenheit - 32) * 5 / 9;
	public static Fahrenheit CelsiusToFahrenheit(Celsius celsius) => (celsius * 9 / 5) + 32;

	public static Celsius KelvinToCelsius(Kelvin kelvin) => kelvin - 273.15f;
	public static Kelvin CelsiusToKelvin(Celsius celsius) => celsius + 273.15f;

	public static Fahrenheit KelvinToFahrenheit(Kelvin kelvin) => (kelvin * 9 / 5) - 459.67f;
	public static Kelvin FahrenheitToKelvin(Fahrenheit fahrenheit) => (fahrenheit + 459.67f) * 5 / 9;
}

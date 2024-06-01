#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Celsius = Double;
using Fahrenheit = Double;
using Kelvin = Double;

public static class Temperature
{
	public static Celsius FahrenheitToCelsius(Fahrenheit fahrenheit) => (fahrenheit - 32) * 5 / 9;
	public static Fahrenheit CelsiusToFahrenheit(Celsius celsius) => (celsius * 9 / 5) + 32;

	public static Celsius KelvinToCelsius(Kelvin kelvin) => kelvin - 273.15;
	public static Kelvin CelsiusToKelvin(Celsius celsius) => celsius + 273.15;

	public static Fahrenheit KelvinToFahrenheit(Kelvin kelvin) => (kelvin * 9 / 5) - 459.67;
	public static Kelvin FahrenheitToKelvin(Fahrenheit fahrenheit) => (fahrenheit + 459.67) * 5 / 9;
}

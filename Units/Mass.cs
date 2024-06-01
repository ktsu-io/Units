#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Grams = Double;
using Kilograms = Double;
using Pounds = Double;

public static class Mass
{
	public static Kilograms GramsToKilograms(Grams grams) => grams / 1000;
	public static Grams KilogramsToGrams(Kilograms kilograms) => kilograms * 1000;

	public static Kilograms PoundsToKilograms(Pounds pounds) => pounds * 0.45359237;
	public static Pounds KilogramsToPounds(Kilograms kilograms) => kilograms / 0.45359237;

	public static Grams PoundsToGrams(Pounds pounds) => KilogramsToGrams(PoundsToKilograms(pounds));
	public static Pounds GramsToPounds(Grams grams) => KilogramsToPounds(GramsToKilograms(grams));
}

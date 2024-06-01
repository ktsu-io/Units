#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Grams = Single;
using Kilograms = Single;
using Pounds = Single;

public static class Mass
{
	public static Kilograms GramsToKilograms(Grams grams) => grams / 1000f;
	public static Grams KilogramsToGrams(Kilograms kilograms) => kilograms * 1000f;

	public static Kilograms PoundsToKilograms(Pounds pounds) => pounds * 0.45359237f;
	public static Pounds KilogramsToPounds(Kilograms kilograms) => kilograms / 0.45359237f;

	public static Grams PoundsToGrams(Pounds pounds) => KilogramsToGrams(PoundsToKilograms(pounds));
	public static Pounds GramsToPounds(Grams grams) => KilogramsToPounds(GramsToKilograms(grams));
}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public record Time : Scalar<Time>
{
	private const double Seconds = 1;
	private const double Minutes = 0.016666666666666666;
	private const double Hours = 0.0002777777777777778;
	private const double Days = 0.000011574074074074073;
	private const double Weeks = 0.0000016534391534391534;
	private const double Fortnights = 0.0000008267195767195767;
	private const double Months = 0.000000380517503805175;
	private const double Years = 0.00000003168808819133034;
	private const double Milliseconds = 1000;
	private const double Microseconds = 1000000;
	private const double Nanoseconds = 1000000000;

	public override string SIBaseUnitName => "s";

	public static Time operator +(Time left, Time right) => Add(left, right);
	public static Time operator -(Time left, Time right) => Subtract(left, right);
	public static Time operator *(Time left, Ratio right) => new() { BaseValue = Multiply(left, right).BaseValue };
	public static Ratio operator /(Time left, Time right) => new() { BaseValue = Divide(left, right).BaseValue };
	public static Time operator *(Time left, double right) => Multiply(left, right);
	public static Time operator /(Time left, double right) => Divide(left, right);
	public static bool operator <(Time left, Time right) => CompareTo(left, right) < 0;
	public static bool operator <=(Time left, Time right) => CompareTo(left, right) <= 0;
	public static bool operator >(Time left, Time right) => CompareTo(left, right) > 0;
	public static bool operator >=(Time left, Time right) => CompareTo(left, right) >= 0;
	public static Time FromSeconds(double value) => new() { BaseValue = value / Seconds };
	public static Time FromMinutes(double value) => new() { BaseValue = value / Minutes };
	public static Time FromHours(double value) => new() { BaseValue = value / Hours };
	public static Time FromDays(double value) => new() { BaseValue = value / Days };
	public static Time FromWeeks(double value) => new() { BaseValue = value / Weeks };
	public static Time FromFortnights(double value) => new() { BaseValue = value / Fortnights };
	public static Time FromMonths(double value) => new() { BaseValue = value / Months };
	public static Time FromYears(double value) => new() { BaseValue = value / Years };
	public static Time FromMilliseconds(double value) => new() { BaseValue = value / Milliseconds };
	public static Time FromMicroseconds(double value) => new() { BaseValue = value / Microseconds };
	public static Time FromNanoseconds(double value) => new() { BaseValue = value / Nanoseconds };
	public double ToMilliseconds() => BaseValue * Milliseconds;
	public double ToMicroseconds() => BaseValue * Microseconds;
	public double ToNanoseconds() => BaseValue * Nanoseconds;
	public double ToSeconds() => BaseValue * Seconds;
	public double ToMinutes() => BaseValue * Minutes;
	public double ToHours() => BaseValue * Hours;
	public double ToDays() => BaseValue * Days;
	public double ToWeeks() => BaseValue * Weeks;
	public double ToFortnights() => BaseValue * Fortnights;
	public double ToMonths() => BaseValue * Months;
	public double ToYears() => BaseValue * Years;
}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ktsu.io.Units;

using Days = Single;
using Hours = Single;
using Minutes = Single;
using Months = Single;
using Seconds = Single;
using Weeks = Single;
using Years = Single;

public static class Time
{
	public const Seconds SecondsPerMinute = 60;
	public const Seconds SecondsPerHour = 3600;
	public const Seconds SecondsPerDay = 86400;
	public const Seconds SecondsPerWeek = 604800;
	public const Seconds SecondsPerMonth = 2628000;
	public const Seconds SecondsPerYear = 31536000;

	public const Minutes MinutesPerSecond = 1 / 60;
	public const Minutes MinutesPerHour = 60;
	public const Minutes MinutesPerDay = 1440;
	public const Minutes MinutesPerWeek = 10080;
	public const Minutes MinutesPerMonth = 43800;
	public const Minutes MinutesPerYear = 525600;

	public const Hours HoursPerSecond = 1 / 3600;
	public const Hours HoursPerMinute = 1 / 60;
	public const Hours HoursPerDay = 24;
	public const Hours HoursPerWeek = 168;
	public const Hours HoursPerMonth = 730;
	public const Hours HoursPerYear = 8760;

	public const Days DaysPerSecond = 1 / 86400;
	public const Days DaysPerMinute = 1 / 1440;
	public const Days DaysPerHour = 1 / 24;
	public const Days DaysPerWeek = 7;
	public const Days DaysPerMonth = 30;
	public const Days DaysPerYear = 365;

	public const Weeks WeeksPerSecond = 1 / 604800;
	public const Weeks WeeksPerMinute = 1 / 10080;
	public const Weeks WeeksPerHour = 1 / 168;
	public const Weeks WeeksPerDay = 1 / 7;
	public const Weeks WeeksPerMonth = 1 / 4;
	public const Weeks WeeksPerYear = 52;

	public const Months MonthsPerSecond = 1 / 2628000;
	public const Months MonthsPerMinute = 1 / 43800;
	public const Months MonthsPerHour = 1 / 730;
	public const Months MonthsPerDay = 1 / 30;
	public const Months MonthsPerWeek = 1 / 4;
	public const Months MonthsPerYear = 12;

	public const Years YearsPerSecond = 1 / 31536000;
	public const Years YearsPerMinute = 1 / 525600;
	public const Years YearsPerHour = 1 / 8760;
	public const Years YearsPerDay = 1 / 365;
	public const Years YearsPerWeek = 1 / 52;
	public const Years YearsPerMonth = 1 / 12;

	public static Minutes SecondsToMinutes(Seconds seconds) => seconds / SecondsPerMinute;
	public static Hours SecondsToHours(Seconds seconds) => seconds / SecondsPerHour;
	public static Days SecondsToDays(Seconds seconds) => seconds / SecondsPerDay;
	public static Weeks SecondsToWeeks(Seconds seconds) => seconds / SecondsPerWeek;
	public static Months SecondsToMonths(Seconds seconds) => seconds / SecondsPerMonth;
	public static Years SecondsToYears(Seconds seconds) => seconds / SecondsPerYear;

	public static Seconds MinutesToSeconds(Minutes minutes) => minutes * SecondsPerMinute;
	public static Hours MinutesToHours(Minutes minutes) => minutes / MinutesPerHour;
	public static Days MinutesToDays(Minutes minutes) => minutes / MinutesPerDay;
	public static Weeks MinutesToWeeks(Minutes minutes) => minutes / MinutesPerWeek;
	public static Months MinutesToMonths(Minutes minutes) => minutes / MinutesPerMonth;
	public static Years MinutesToYears(Minutes minutes) => minutes / MinutesPerYear;

	public static Seconds HoursToSeconds(Hours hours) => hours * SecondsPerHour;
	public static Minutes HoursToMinutes(Hours hours) => hours * MinutesPerHour;
	public static Days HoursToDays(Hours hours) => hours / HoursPerDay;
	public static Weeks HoursToWeeks(Hours hours) => hours / HoursPerWeek;
	public static Months HoursToMonths(Hours hours) => hours / HoursPerMonth;
	public static Years HoursToYears(Hours hours) => hours / HoursPerYear;

	public static Seconds DaysToSeconds(Days days) => days * SecondsPerDay;
	public static Minutes DaysToMinutes(Days days) => days * MinutesPerDay;
	public static Hours DaysToHours(Days days) => days * HoursPerDay;
	public static Weeks DaysToWeeks(Days days) => days / DaysPerWeek;
	public static Months DaysToMonths(Days days) => days / DaysPerMonth;
	public static Years DaysToYears(Days days) => days / DaysPerYear;

	public static Seconds WeeksToSeconds(Weeks weeks) => weeks * SecondsPerWeek;
	public static Minutes WeeksToMinutes(Weeks weeks) => weeks * MinutesPerWeek;
	public static Hours WeeksToHours(Weeks weeks) => weeks * HoursPerWeek;
	public static Days WeeksToDays(Weeks weeks) => weeks * DaysPerWeek;
	public static Months WeeksToMonths(Weeks weeks) => weeks / WeeksPerMonth;
	public static Years WeeksToYears(Weeks weeks) => weeks / WeeksPerYear;

	public static Seconds MonthsToSeconds(Months months) => months * SecondsPerMonth;
	public static Minutes MonthsToMinutes(Months months) => months * MinutesPerMonth;
	public static Hours MonthsToHours(Months months) => months * HoursPerMonth;
	public static Days MonthsToDays(Months months) => months * DaysPerMonth;
	public static Weeks MonthsToWeeks(Months months) => months * WeeksPerMonth;
	public static Years MonthsToYears(Months months) => months / MonthsPerYear;

	public static Seconds YearsToSeconds(Years years) => years * SecondsPerYear;
	public static Minutes YearsToMinutes(Years years) => years * MinutesPerYear;
	public static Hours YearsToHours(Years years) => years * HoursPerYear;
	public static Days YearsToDays(Years years) => years * DaysPerYear;
	public static Weeks YearsToWeeks(Years years) => years * WeeksPerYear;
	public static Months YearsToMonths(Years years) => years * MonthsPerYear;
}

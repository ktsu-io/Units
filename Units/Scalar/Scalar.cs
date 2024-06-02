#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA2225 // Operator overloads have named alternates

namespace ktsu.io.Units.Scalar;

public abstract record Scalar
{
	internal double BaseValue { get; init; }
	protected virtual string SIBaseUnitName => string.Empty;

	public override int GetHashCode() => BaseValue.GetHashCode();
	public override string? ToString() => $"{BaseValue} {SIBaseUnitName}";
}

public abstract record Scalar<TDerived> : Scalar where TDerived : Scalar<TDerived>, new()
{
	protected static TDerived Add(Scalar<TDerived> left, Scalar right) => left is not null && right is not null ? new() { BaseValue = left.BaseValue + right.BaseValue } : throw new ArgumentNullException(left is null ? nameof(left) : nameof(right));
	protected static TDerived Subtract(Scalar<TDerived> left, Scalar right) => left is not null && right is not null ? new() { BaseValue = left.BaseValue - right.BaseValue } : throw new ArgumentNullException(left is null ? nameof(left) : nameof(right));
	protected static TDerived Multiply(Scalar<TDerived> left, Scalar right) => left is not null && right is not null ? new() { BaseValue = left.BaseValue * right.BaseValue } : throw new ArgumentNullException(left is null ? nameof(left) : nameof(right));
	protected static TDerived Divide(Scalar<TDerived> left, Scalar right) => left is not null && right is not null ? new() { BaseValue = left.BaseValue / right.BaseValue } : throw new ArgumentNullException(left is null ? nameof(left) : nameof(right));
	protected static int CompareTo(Scalar<TDerived> left, Scalar right) => left is not null && right is not null ? left.BaseValue.CompareTo(right.BaseValue) : throw new ArgumentNullException(left is null ? nameof(left) : nameof(right));

	protected static TDerived Add(Scalar<TDerived> left, double right) => left is not null ? new() { BaseValue = left.BaseValue + right } : throw new ArgumentNullException(nameof(left));
	protected static TDerived Subtract(Scalar<TDerived> left, double right) => left is not null ? new() { BaseValue = left.BaseValue - right } : throw new ArgumentNullException(nameof(left));
	protected static TDerived Multiply(Scalar<TDerived> left, double right) => left is not null ? new() { BaseValue = left.BaseValue * right } : throw new ArgumentNullException(nameof(left));
	protected static TDerived Divide(Scalar<TDerived> left, double right) => left is not null ? new() { BaseValue = left.BaseValue / right } : throw new ArgumentNullException(nameof(left));
	protected static int CompareTo(Scalar<TDerived> left, double right) => left is not null ? left.BaseValue.CompareTo(right) : throw new ArgumentNullException(nameof(left));
}

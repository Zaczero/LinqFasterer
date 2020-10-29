using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Determines whether a sequence contains a specified element by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
		/// <param name="source">A sequence in which to locate a value.</param>
		/// <param name="value">The value to locate in the sequence.</param>
		/// <param name="comparer">An equality comparer to compare values.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static bool ContainsF<TSource>(this IList<TSource> source, TSource value, IEqualityComparer<TSource> comparer = null)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			comparer ??= EqualityComparer<TSource>.Default;

			for (var i = 0; i < source.Count; i++)
				if (comparer.Equals(source[i], value))
					return true;

			return false;
		}
	}
}

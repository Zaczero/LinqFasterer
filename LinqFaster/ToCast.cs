using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Creates an array from a <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
		/// <returns>An array that contains the elements from the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create an array from.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource[] ToArrayF<TSource>(this IList<TSource> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var result = new TSource[source.Count];

			source.CopyTo(result, 0);

			return result;
		}

		/// <summary>Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.</returns>
		/// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static List<TSource> ToListF<TSource>(this IList<TSource> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var result = new List<TSource>(source.Count);

			// TODO: bechnmark addrange vs add
			result.AddRange(source);

			return result;
		}
	}
}
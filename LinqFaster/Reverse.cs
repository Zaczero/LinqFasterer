using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Inverts the order of the elements in a sequence.</summary>
		/// <returns>A sequence whose elements correspond to those of the input sequence in reverse order.</returns>
		/// <param name="source">A sequence of values to reverse.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> ReverseF<TSource>(this IList<TSource> source)
		{
			var result = new TSource[source.Count];

			for (var i = 0; i < source.Count; i++)
				result[i] = source[source.Count - i - 1];

			return result;
		}

		/// <summary>Inverts the order of the elements in a sequence.</summary>
		/// <returns>A sequence whose elements correspond to those of the input sequence in reverse order.</returns>
		/// <param name="source">A sequence of values to reverse.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> ReverseInPlaceF<TSource>(this IList<TSource> source)
		{
			for (var i = 0; i < source.Count / 2; i++)
			{
				var iReversed = source.Count - i - 1;

				var tmp = source[i];
				source[i] = source[iReversed];
				source[iReversed] = tmp;
			}

			return source;
		}
	}
}
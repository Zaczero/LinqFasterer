using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Adds a value to the beginning of the sequence.</summary>
		/// <returns>A new sequence that begins with element.</returns>
		/// <param name="source">A sequence of values.</param>
		/// <param name="element">The value to prepend to source.</param>
		public static IList<TSource> PrependF<TSource>(this IList<TSource> source, TSource element)
		{
			var sourceLength = source.Count;

			var result = new TSource[sourceLength];

			result[0] = element;
			source.CopyTo(result, 1);

			return result;
		}
	}
}
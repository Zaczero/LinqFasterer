using System;
using System.Collections;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Concatenates two sequences.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the concatenated elements of the two input sequences.</returns>
		/// <param name="first">The first sequence to concatenate.</param>
		/// <param name="second">The sequence to concatenate to the first sequence.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		public static IList<TSource> ConcatF<TSource>(this IList<TSource> first, IList<TSource> second)
		{
			if (first == null)
				throw Error.ArgumentNull(nameof(first));

			if (second == null)
				throw Error.ArgumentNull(nameof(second));

			var result = new TSource[first.Count + second.Count];

			first.CopyTo(result, 0);
			second.CopyTo(result, first.Count);

			return result;
		}
	}
}
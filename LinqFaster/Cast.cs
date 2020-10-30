using System;
using System.Collections;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Casts the elements of an <see cref="T:System.Collections.IEnumerable" /> to the specified type.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains each element of the source sequence cast to the specified type.</returns>
		/// <param name="source">The <see cref="T:System.Collections.IEnumerable" /> that contains the elements to be cast to type <paramref name="TResult" />.</param>
		/// <typeparam name="TResult">The type to cast the elements of <paramref name="source" /> to.</typeparam>
		public static IList<TResult> CastF<TResult>(this IList source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var result = new TResult[source.Count];

			for (var i = 0; i < source.Count; i++)
				result[i] = (TResult) source[i];

			return result;
		}
	}
}
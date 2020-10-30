using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		public static IList<TSource> AppendF<TSource>(this IList<TSource> source, TSource element)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var result = new TSource[source.Count + 1];

			source.CopyTo(result, 0);
			result[source.Count] = element;

			return result;
		}
	}
}
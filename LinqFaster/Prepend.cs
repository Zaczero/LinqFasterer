using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		public static IList<TSource> PrependF<TSource>(this IList<TSource> source, TSource element)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var result = new TSource[source.Count + 1];

			source.CopyTo(result, 1);
			result[0] = element;

			return result;
		}
	}
}
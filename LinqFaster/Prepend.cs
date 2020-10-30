using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
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
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Returns an empty <see cref="T:System.Collections.Generic.IEnumerable`1" /> that has the specified type argument.</summary>
		/// <returns>An empty <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose type argument is <paramref name="TResult" />.</returns>
		/// <typeparam name="TResult">The type to assign to the type parameter of the returned generic <see cref="T:System.Collections.Generic.IEnumerable`1" />.</typeparam>
		public static IList<TResult> EmptyF<TResult>()
		{
			return new TResult[0];
		}
	}
}
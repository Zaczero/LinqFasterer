using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Returns the element at a specified index in a sequence.</summary>
		/// <returns>The element at the specified position in the source sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="index">The zero-based index of the element to retrieve.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the number of elements in <paramref name="source" />.</exception>
		public static TSource ElementAtF<TSource>(this IReadOnlyList<TSource> source, int index)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			return source[index];
		}

		/// <summary>Returns the element at a specified index in a sequence.</summary>
		/// <returns>The element at the specified position in the source sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="index">The zero-based index of the element to retrieve.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the number of elements in <paramref name="source" />.</exception>
		public static TSource ElementAtOrDefaultF<TSource>(this IReadOnlyList<TSource> source, int index)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (index > -1 && index < source.Count)
				return source[index];

			return default;
		}
	}
}
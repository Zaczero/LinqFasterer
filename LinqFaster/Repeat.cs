using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Generates a sequence that contains one repeated value.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains a repeated value.</returns>
		/// <param name="element">The value to be repeated.</param>
		/// <param name="count">The number of times to repeat the value in the generated sequence.</param>
		/// <typeparam name="TResult">The type of the value to be repeated in the result sequence.</typeparam>
		public static IList<TResult> RepeatF<TResult>(TResult element, int count)
		{
			var result = new TResult[count];

			for (var i = 0; i < count; i++)
				result[i] = element;

			return result;
		}
	}
}

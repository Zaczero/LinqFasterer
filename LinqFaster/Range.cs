using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Generates a sequence of integral numbers within a specified range.</summary>
		/// <returns>An IEnumerable&lt;Int32&gt; in C# or IEnumerable(Of Int32) in Visual Basic that contains a range of sequential integral numbers.</returns>
		/// <param name="start">The value of the first integer in the sequence.</param>
		/// <param name="count">The number of sequential integers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<int> RangeF(int start, int count, int change = 1)
		{
			if (count < 0 || (long) start + count - 1 > int.MaxValue)
				throw Error.ArgumentOutOfRange(nameof(count));

			var result = new int[count];

			if (count == 0)
				return result;

			result[0] = start;

			for (var i = 1; i < count; i++)
				result[i] = result[i - 1] + change;

			return result;
		}
	}
}
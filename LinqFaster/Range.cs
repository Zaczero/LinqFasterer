using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Generates a sequence of integral numbers within a specified range.</summary>
		/// <returns>An IEnumerable&lt;Int32&gt; in C# or IEnumerable(Of Int32) in Visual Basic that contains a range of sequential integral numbers.</returns>
		/// <param name="start">The value of the first integer in the sequence.</param>
		/// <param name="count">The number of sequential integers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<int> RangeF(int start, int count, int change = 1)
		{
			var result = new int[count];

			checked
			{
				for (var i = 0; i < count; i++)
					result[i] = start + i * change;
			}

			return result;
		}

		/// <summary>Generates a sequence of integral numbers within a specified range.</summary>
		/// <returns>An IEnumerable&lt;Int32&gt; in C# or IEnumerable(Of Int32) in Visual Basic that contains a range of sequential integral numbers.</returns>
		/// <param name="start">The value of the first integer in the sequence.</param>
		/// <param name="count">The number of sequential integers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<long> RangeF(long start, int count, long change = 1)
		{
			var result = new long[count];

			checked
			{
				for (var i = 0; i < count; i++)
					result[i] = start + i * change;
			}

			return result;
		}

		/// <summary>Generates a sequence of integral numbers within a specified range.</summary>
		/// <returns>An IEnumerable&lt;Int32&gt; in C# or IEnumerable(Of Int32) in Visual Basic that contains a range of sequential integral numbers.</returns>
		/// <param name="start">The value of the first integer in the sequence.</param>
		/// <param name="count">The number of sequential integers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<float> RangeF(float start, int count, float change = 1)
		{
			var result = new float[count];

			checked
			{
				for (var i = 0; i < count; i++)
					result[i] = start + i * change;
			}

			return result;
		}

		/// <summary>Generates a sequence of integral numbers within a specified range.</summary>
		/// <returns>An IEnumerable&lt;Int32&gt; in C# or IEnumerable(Of Int32) in Visual Basic that contains a range of sequential integral numbers.</returns>
		/// <param name="start">The value of the first integer in the sequence.</param>
		/// <param name="count">The number of sequential integers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<double> RangeF(double start, int count, double change = 1)
		{
			var result = new double[count];

			checked
			{
				for (var i = 0; i < count; i++)
					result[i] = start + i * change;
			}

			return result;
		}

		/// <summary>Generates a sequence of integral numbers within a specified range.</summary>
		/// <returns>An IEnumerable&lt;Int32&gt; in C# or IEnumerable(Of Int32) in Visual Basic that contains a range of sequential integral numbers.</returns>
		/// <param name="start">The value of the first integer in the sequence.</param>
		/// <param name="count">The number of sequential integers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<decimal> RangeF(decimal start, int count, decimal change = 1)
		{
			var result = new decimal[count];

			checked
			{
				for (var i = 0; i < count; i++)
					result[i] = start + i * change;
			}

			return result;
		}
	}
}
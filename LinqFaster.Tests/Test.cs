using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		private const int RandomSeed = 0;

		public static (IList<TSource>, IList<TSource>) SplitArray<TSource>(IList<TSource> source, int firstSize)
		{
			var first = source.Take(firstSize).ToArray();
			var second = source.TakeLast(source.Count - firstSize).ToArray();

			return (first, second);
		}

		public static IEnumerable<object[]> TestArray(Type type, int size, int minValue, int maxValue)
		{
			var random = new Random(RandomSeed);

			switch (Type.GetTypeCode(type))
			{
				case TypeCode.Int32:
				{
					var arr = new int[size];

					for (var i = 0; i < size; i++)
						arr[i] = random.Next(minValue, maxValue);

					yield return new object[] {arr};
					break;
				}
				case TypeCode.Int64:
				{
					var arr = new long[size];

					for (var i = 0; i < size; i++)
						arr[i] = random.Next(minValue, maxValue);

					yield return new object[] {arr};
					break;
				}
				case TypeCode.Single:
				{
					var arr = new float[size];

					for (var i = 0; i < size; i++)
						arr[i] = (float) (random.NextDouble() * (maxValue - minValue) + minValue);

					yield return new object[] {arr};
					break;
				}
				case TypeCode.Double:
				{
					var arr = new double[size];

					for (var i = 0; i < size; i++)
						arr[i] = random.NextDouble() * (maxValue - minValue) + minValue;

					yield return new object[] {arr};
					break;
				}
				case TypeCode.Decimal:
				{
					var arr = new decimal[size];

					for (var i = 0; i < size; i++)
						arr[i] = (decimal) (random.NextDouble() * (maxValue - minValue) + minValue);

					yield return new object[] {arr};
					break;
				}
				case TypeCode.String:
				{
					var arr = new string[size];

					for (var i = 0; i < size; i++)
						arr[i] = RandomString(random, random.Next(2, 16));

					yield return new object[] {arr};
					break;
				}
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, "Unsupported type");
			}
		}

		private static string RandomString(Random random, int size)
		{
			var sb = new StringBuilder(size);

			for (var i = 0; i < size; i++)
				sb.Append((char) random.Next('!', '~' + 1));

			return sb.ToString();
		}
	}
}

using System;
namespace AlgorithmsTestProject
{
	public static class CombinationTest
	{
		public static bool AreSetsTheSame(List<int> a, List<int> b) {
            if (a.Count != b.Count) return false;
            var asorted = a.OrderBy(x => x);
            var bsorted = b.OrderBy(x => x);
            return asorted.SequenceEqual(bsorted);
        }

		public static bool DoesOutputSetContains(List<List<int>> outputSet, List<int> member) {
            foreach (var output in outputSet) {
                if (AreSetsTheSame(output, member)) {
                    return true;
                }
            }
            return false;
        }

		[Test]
		public static void TestGenerateCombinations()
		{
			var testInput = new[] { 1, 2, 3, 4 };
			var output = GenerateCombinations(testInput);

			Assert.AreEqual(8, output);
			var expectedResults = new List<List<int>>
			{
				new List<int> { 1 },
				new List<int> { 3 },
				new List<int> { 5 },
				new List<int> { 1, 3 },
				new List<int> { 1, 5 },
				new List<int> { 3, 5 },
				new List<int> { 1, 3, 5 },
			};	

			foreach (var expectedResult in expectedResults) {
                Assert.IsTrue(DoesOutputSetContains(output, expectedResult));
            }

			Assert.AreEqual(8, output.Count);
        }

		[Test]
		public static void OutputResults(){
			var testInput = new[] { 1, 2, 3, 4 };
			var output = GenerateCombinations(testInput);
			foreach (var xs in output)
			{
				Console.WriteLine(output);
			}
		}

		public static List<List<int>> GenerateCombinations(int[] input)
		{
			var result = new List<List<int>>();
			foreach (var x in input)
			{
				result.Add(new List<int> { x });
			}
			return result;
		}
	}
}


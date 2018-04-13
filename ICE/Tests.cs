using System.Linq;
using NUnit.Framework;

namespace ICE
{
    [TestFixture]
    public class Tests
    {
        private static string Input =
            "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

        [TestCase("Polly", new[]{1, 26, 51})]
        [TestCase("polly", new[] { 1, 26, 51 })]
        [TestCase("ll", new[] { 3, 28, 53, 78, 82 })]
        [TestCase("Ll", new[] { 3, 28, 53, 78, 82 })]
        [TestCase("X", new int[0])]
        [TestCase("Polx", new int[0])]
        public void TestScenarios(string subtext, int[] expectedOutput)
        {
            var result = new Matcher().Match(Input, subtext);
            Assert.IsTrue(expectedOutput.SequenceEqual(result));
        }
    }
}

using SolveMathFirstExpression.Lib;
namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public sealed class ValidMathFirstExpression1
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            Assert.AreEqual(Math.Round(MathFirstExpression.CalculateFirstExpression(1, 1, 1), 2), Math.Round(4.857142857, 2));
        }
    }
}

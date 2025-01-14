using SolveMathSecondExpression.Lib;
namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public sealed class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            Assert.AreEqual(Math.Round(MathSecondExpression.CalculateSecondExpression(1, 1, 1), 2), Math.Round(7.291666667, 2));
        }
    }
}

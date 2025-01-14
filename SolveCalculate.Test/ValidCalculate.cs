using SolveCalculate.Lib;
namespace SolveCalculate.Test
{
    [TestClass]
    public sealed class ValidCalculate
    {
        [TestMethod]
        public void TestCalculateSumma()
        {
            Assert.AreEqual(Calculate.CalculateSumma(1, 1), 2);
        }
        public void TestCalculateDifference()
        {
           Assert.AreEqual(Calculate.CalculateDifference(1, 1), 0);
        }
        public void TestCalculateMultiplication()
        {
           Assert.AreEqual(Calculate.CalculateMultiplication(1, 1), 1);
        }
        public void TestCalculateQuotient()
        {
           Assert.AreEqual(Calculate.CalculateQuotient(1, 1), 1);
        }
    }
}

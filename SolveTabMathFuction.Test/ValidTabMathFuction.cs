using SolveTabMathFuction.Lib;
namespace SolveTabMathFuction.Test
{
    [TestClass]
    public sealed class ValidTabMathFuction
    {
        [TestMethod]
        public void TestCalculateTabMathFuction()
        {
            double[] array = {
                80.58,
                169.01,
                295.06,
                457.88,
                656.49,
                890.25,
                1159.32,
                1464.54,
                1806.60,
                2185.43,
                2600.27


};
            CollectionAssert.AreEqual(array, TabMathFuction.CalculateTabMathFuction(2, 12));
        }
    }
}

namespace SolveTabMathFuction.Lib
{
    public class TabMathFuction
    {
        public static double[] CalculateTabMathFuction(int startValue, int stopValue)
        {
            int range = Math.Abs(startValue - stopValue) + 1;
            var res = new double[range];
            double x = startValue;
            for (int i = 0; i < range; i++)
            {
                res[i] = Math.Round(Math.Cos(x) + Math.Pow(((x + 1) / (x - 1)), x) + 18 * Math.Pow(x, 2), 2);
                x += 1;
            }
            return res;
        }
    }
}
